using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using MQTTnet;
using MQTTnet.Protocol;
using MQTTnet.Server;

namespace MqttNetServer;

public partial class FrmMqttServer : Form
{
    private MqttServer _mqttServer;

    private Action<string> _updateListBoxAction;

    public FrmMqttServer()
    {
        InitializeComponent();
        listBox1.DoubleBuffering(true);
    }

    private void FrmMqttServer_Load(object sender, EventArgs e)
    {
        _updateListBoxAction = s =>
        {
            listBox1.BeginUpdate();
            listBox1.Items.Add("{DateTime.Now}" + s);
            if (listBox1.Items.Count > 1000)
            {
                listBox1.Items.RemoveAt(0);
            }

            listBox1.TopIndex = listBox1.Items.Count - 1;
            listBox1.EndUpdate();
        };


        listBox1.KeyPress += (o, args) =>
        {
            if (args.KeyChar == 'c' || args.KeyChar == 'C')
            {
                listBox1.Items.Clear();
            }
        };

        BtnStart.Enabled = true;
        BtnStop.Enabled = false;
        TxbServer.Enabled = true;
        TxbPort.Enabled = true;
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        MqttServer();
        BtnStart.Enabled = false;
        BtnStop.Enabled = true;
        TxbServer.Enabled = false;
        TxbPort.Enabled = false;
    }

    private void BtnStop_Click(object sender, EventArgs e)
    {
        if (_mqttServer is not null)
        {
            foreach (var clientSessionStatus in _mqttServer.GetSessionsAsync().Result)
            {
                clientSessionStatus.DeleteAsync();
            }

            _mqttServer.StopAsync();
            _mqttServer = null;
        }

        BtnStart.Enabled = true;
        BtnStop.Enabled = false;
        TxbServer.Enabled = true;
        TxbPort.Enabled = true;
    }

    private async void MqttServer()
    {
        if (_mqttServer is not null)
        {
            return;
        }

        var optionBuilder = new MqttServerOptionsBuilder();
        optionBuilder =
            optionBuilder
            .WithDefaultEndpoint()
            .WithConnectionBacklog(1000)
            .WithDefaultEndpointPort(Convert.ToInt32(TxbPort.Text));

        if (!string.IsNullOrEmpty(TxbServer.Text))
        {
            optionBuilder.WithDefaultEndpointBoundIPAddress(IPAddress.Parse(TxbServer.Text));
        }

        var options = optionBuilder.Build();
        _mqttServer = new MqttFactory().CreateMqttServer(options);
        _mqttServer.ValidatingConnectionAsync += c =>
        {
            c.ReasonCode = MqttConnectReasonCode.Success;
            if (c.ClientId.Length < 10)
            {
                c.ReasonCode = MqttConnectReasonCode.ClientIdentifierNotValid;
            }

            if (!c.UserName.Equals("admin"))
            {
                c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
            }

            if (!c.Password.Equals("public"))
            {
                c.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
            }

            return Task.CompletedTask;
        };

        _mqttServer.StartedAsync += StartedAsync;
        _mqttServer.StoppedAsync += StoppedAsync;
        _mqttServer.ValidatingConnectionAsync += ValidatingConnectionAsync;
        _mqttServer.ClientConnectedAsync += ClientConnectedAsync;
        _mqttServer.ClientDisconnectedAsync += ClientDisconnectedAsync;
        _mqttServer.ApplicationMessageNotConsumedAsync += ApplicationMessageNotConsumedAsync;
        _mqttServer.ClientSubscribedTopicAsync += ClientSubscribedTopicAsync;
        _mqttServer.ClientUnsubscribedTopicAsync += ClientUnsubscribedTopicAsync;

        await _mqttServer.StartAsync();
    }

    private Task ClientUnsubscribedTopicAsync(ClientUnsubscribedTopicEventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Client unsubscribed topic. ClientId:{e.ClientId} Topic:{e.TopicFilter.Length}");
        return Task.CompletedTask;
    }

    private Task ClientSubscribedTopicAsync(ClientSubscribedTopicEventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Client subscribed topic. ClientId:{e.ClientId} Topic:{e.TopicFilter.Topic} QualityOfServiceLevel:{e.TopicFilter.QualityOfServiceLevel}");
        return Task.CompletedTask;
    }

    private Task ClientConnectedAsync(ClientConnectedEventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Client Connected:ClientId:{e.ClientId}");
        var s = _mqttServer.GetSessionsAsync();
        lblClientCount.BeginInvoke(new Action(() => { lblClientCount.Text = $@"连接总数：{s.Result.Count}"; }));
        return Task.CompletedTask;
    }

    private Task ClientDisconnectedAsync(ClientDisconnectedEventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Client Disconnected:ClientId:{e.ClientId}");
        var s = _mqttServer.GetSessionsAsync();
        lblClientCount.BeginInvoke(new Action(() => { lblClientCount.Text = $@"连接总数：{s.Result.Count}"; }));
        return Task.CompletedTask;
    }

    private Task StoppedAsync(EventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Mqtt Server Stopped...");
        return Task.CompletedTask;
    }

    private Task StartedAsync(EventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction, $"Mqtt Server Started...");
        return Task.CompletedTask;
    }

    private Task ValidatingConnectionAsync(ValidatingConnectionEventArgs e)
    {
        e.ReasonCode = MqttConnectReasonCode.Success;
        if (!e.UserName.Equals("admin"))
        {
            e.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
        }

        if (!e.Password.Equals("public"))
        {
            e.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
        }

        return Task.CompletedTask;
    }

    private Task ApplicationMessageNotConsumedAsync(ApplicationMessageNotConsumedEventArgs e)
    {
        listBox1.BeginInvoke(_updateListBoxAction,
                             $"ClientId:{e.SenderId} Topic:{e.ApplicationMessage.Topic} Payload:{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} QualityOfServiceLevel:{e.ApplicationMessage.QualityOfServiceLevel}");
        return Task.CompletedTask;
    }
}
