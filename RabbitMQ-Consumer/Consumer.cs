using System;
using RabbitMQ.Client;
using System.Windows.Forms;
using RabbitMQ.Client.Events;

namespace RabbitMQ_Consumer
{
  public partial class Consumer : Form
  {
    private ConnectionFactory factory = null;
    private IConnection connection = null;
    private IModel model = null;
    private EventingBasicConsumer basicConsumer = null;

    public Consumer()
    {
      InitializeComponent();
    }

    private void btnPollingMessage_Click(object sender, EventArgs e)
    {
      try
      {
        factory = new ConnectionFactory()
        {
          UserName = txtUserName.Text,
          Password = txtPassword.Text,
          HostName= txtHostName.Text
        };

        connection = factory.CreateConnection();
        model = connection.CreateModel();

        BasicGetResult result = model.BasicGet(txtQueueName.Text, false);

        if (result == null)
        {
          MessageBox.Show("Queue is empty.", "Queue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          ReadOnlyMemory<byte> body = result.Body;
          string message = System.Text.Encoding.UTF8.GetString(body.ToArray());

          MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          model.BasicAck(result.DeliveryTag, false);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void btnSubscribeEvent_Click(object sender, EventArgs e)
    {
      try
      {
        factory = new ConnectionFactory()
        {
          UserName = txtUserName.Text,
          Password = txtPassword.Text,
          HostName= txtHostName.Text
        };

        connection = factory.CreateConnection();
        model = connection.CreateModel();

        basicConsumer = new EventingBasicConsumer(model);
        basicConsumer.Received += OnNewMessageReceived;

        model.BasicConsume(txtQueueName.Text, true, basicConsumer);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void OnNewMessageReceived(object sender, BasicDeliverEventArgs e)
    {
      string message = System.Text.Encoding.UTF8.GetString(e.Body.ToArray());

      MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
