using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Formatter;
using MQTTnet.Packets;
using MQTTnet.Protocol;

namespace MqttNetClient;

public partial class FrmMqttClient : Form
{
    private string _username = "admin";
    private string _password = "public";

    private IMqttClient _mqttClient;

    private Action<string> _updateListBoxAction;

    private readonly List<IManagedMqttClient> _managedMqttClients = new();

    public FrmMqttClient()
    {
        InitializeComponent();
        listBox1.DoubleBuffering(true);
    }

    private void FrmMqttClient_Load(object sender, EventArgs e)
    {
        foreach (object value in Enum.GetValues(typeof(MqttQualityOfServiceLevel)))
        {
            CmbPubMqttQuality.Items.Add((int)value);
            CmbSubMqttQuality.Items.Add((int)value);
        }

        CmbPubMqttQuality.SelectedItem = 0;
        CmbSubMqttQuality.SelectedIndex = 0;

        _updateListBoxAction = (s) =>
        {
            listBox1.BeginUpdate();
            listBox1.Items.Add(s);
            if (listBox1.Items.Count > 100)
            {
                listBox1.Items.RemoveAt(0);
            }

            listBox1.TopIndex = listBox1.Items.Count - 1;
            listBox1.EndUpdate();
        };
    }

    private void BtnConnect_Click(object sender, EventArgs e)
    {
        MqttClient();
    }

    private async void BtnDisConnect_Click(object sender, EventArgs e)
    {
        if (_mqttClient is not null && _mqttClient.IsConnected)
        {
            await _mqttClient.DisconnectAsync();
            _mqttClient.Dispose();
            _mqttClient = null;
        }
    }

    private async void BtnSubscribe_Click(object sender, EventArgs e)
    {
        try
        {
            var so = new MqttClientSubscribeOptions();
            so.TopicFilters = new List<MqttTopicFilter>
            {
                new MqttTopicFilter
                {
                    Topic = txbSubscribe.Text,
                    QualityOfServiceLevel = (MqttQualityOfServiceLevel)Enum.Parse(typeof(MqttQualityOfServiceLevel), CmbSubMqttQuality.Text)
                }
            };
            await _mqttClient.SubscribeAsync(so);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private async void BtnSend_Click(object sender, EventArgs e)
    {
        try
        {
            var msg = new MqttApplicationMessage
            {
                Topic = TxbTopic.Text,
                PayloadSegment = Encoding.UTF8.GetBytes(TxbPayload.Text),
                QualityOfServiceLevel =
                    (MqttQualityOfServiceLevel)
                        Enum.Parse(typeof(MqttQualityOfServiceLevel), CmbPubMqttQuality.Text),
                Retain = false
            };

            if (_mqttClient is not null)
            {
                await _mqttClient.PublishAsync(msg);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void BtnMultiConnect_Click(object sender, EventArgs e)
    {
        MqttMultiClient(Convert.ToInt32(TxbConnectCount.Text));
    }

    private async void BtnMultiDisConnect_Click(object sender, EventArgs e)
    {
        foreach (IManagedMqttClient client in _managedMqttClients)
        {
            await client.StopAsync();
            client.Dispose();
            Thread.Sleep(100);
        }
    }

    private async void MqttClient()
    {
        try
        {
            var options = new MqttClientOptions
            {
                ClientId = Guid.NewGuid().ToString("D"),
                ProtocolVersion = MqttProtocolVersion.V500,
            };

            options.ChannelOptions = new MqttClientTcpOptions
            {
                Server = TxbServer.Text,
                Port = Convert.ToInt32(TxbPort.Text)
            };

            options.Credentials = new MqttClientCredentials(_username, Encoding.UTF8.GetBytes(_password));

            options.CleanSession = true;
            options.KeepAlivePeriod = TimeSpan.FromSeconds(100);

            if (null != _mqttClient)
            {
                await _mqttClient.DisconnectAsync();
                _mqttClient = null;
            }

            _mqttClient = new MqttFactory().CreateMqttClient();

            _mqttClient.ApplicationMessageReceivedAsync += e =>
            {
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment.Array);
                listBox1.BeginInvoke(
                    _updateListBoxAction,
                    $"{DateTime.Now} ClientID:{e.ClientId} | TOPIC:{e.ApplicationMessage.Topic} | Payload:{payload} | QoS:{e.ApplicationMessage.QualityOfServiceLevel} | Retain:{e.ApplicationMessage.Retain}"
                    );
                return Task.CompletedTask;
            };

            _mqttClient.DisconnectedAsync += e =>
            {
                listBox1.BeginInvoke(_updateListBoxAction,
                    $"{DateTime.Now} Client is Connected:  IsSessionPresent:{e.ConnectResult}");
                return Task.CompletedTask;
            };

            await _mqttClient.ConnectAsync(options);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private async void MqttMultiClient(int clientsCount)
    {
        for (int i = 0; i < clientsCount; i++)
        {
            var options = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(new MqttClientOptionsBuilder()
                .WithClientId(Guid.NewGuid().ToString().Substring(0, 13))
                .WithTcpServer(TxbServer.Text, Convert.ToInt32(TxbPort.Text))
                .WithCredentials(_username, _password)
                .Build()
            )
            .Build();

            IManagedMqttClient c = new MqttFactory().CreateManagedMqttClient();
            var so = new MqttClientSubscribeOptions();
            so.TopicFilters = new List<MqttTopicFilter>
            {
                new MqttTopicFilter
                {
                    Topic = txbSubscribe.Text,
                    QualityOfServiceLevel = (MqttQualityOfServiceLevel)Enum.Parse(typeof(MqttQualityOfServiceLevel), CmbSubMqttQuality.Text)
                }
            };
            await c.SubscribeAsync(so.TopicFilters);
            await c.StartAsync(options);

            _managedMqttClients.Add(c);

            Thread.Sleep(200);
        }
    }
}
