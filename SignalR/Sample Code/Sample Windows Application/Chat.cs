using System;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace Sample_Windows_Application
{
	public partial class Chat : Form
	{
		HubConnection connection;
		IHubProxy chatHub;

		public Chat()
		{
			InitializeComponent();
		}

		private void EstablishConnection()
		{
			connection = new HubConnection("http://localhost:57142/");
			chatHub = connection.CreateHubProxy("chatHub");

			chatHub.On<string, object>("SendMessageToWinForm", (name, data) =>
			{
				if (txtChatHistory.InvokeRequired)
				{
					txtChatHistory.Invoke(new Action(() => txtChatHistory.AppendText($"{name} : {data}" + Environment.NewLine)));
				}
				else
				{
					txtChatHistory.AppendText($"{name} : {data}" + Environment.NewLine);
				}
			});

			try
			{
				connection.Start().Wait();
				MessageBox.Show("Connected Successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting the SignalR Hub. Message: " + ex.Message);
			}
		}

		private void Chat_Load(object sender, EventArgs e)
		{

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				txtChatHistory.AppendText($"WinForms : {txtChatMessage.Text}" + Environment.NewLine);

				chatHub
					.Invoke(
						"SendToWebApp",
						"WinForms",
						txtChatMessage.Text)
					.Wait();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void Chat_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (connection != null && connection.State == ConnectionState.Connected)
				connection.Stop();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			EstablishConnection();
		}
	}
}
