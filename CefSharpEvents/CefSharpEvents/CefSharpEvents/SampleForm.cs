using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CefSharpEvents
{
	public partial class SampleForm : Form
	{
		private ChromiumWebBrowser browser;
		public SampleForm()
		{
			InitializeComponent();

			AddBrowserControl();
		}

		private void AddBrowserControl()
		{
			browser = new ChromiumWebBrowser("http://localhost:3000");
			pnlBrowserContainer.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;

			browser.JavascriptMessageReceived += OnReceiveNotification;
			browser.LoadingStateChanged += OnLoadingStateChanged;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void OnReceiveNotification(object sender, JavascriptMessageReceivedEventArgs e)
		{
			Message message = JsonConvert.DeserializeObject<Message>((string)e.Message);

			if (rtChatHistory.InvokeRequired)
			{
				rtChatHistory.Invoke(new Action(() => rtChatHistory.AppendText("Web: " + message.Data + Environment.NewLine)));
			}
			else
			{
				rtChatHistory.AppendText("Web: " + message.Data + Environment.NewLine);
			}
		}

		private void OnLoadingStateChanged(object sender, EventArgs e)
		{
			string script = @"if(!messageSentEvent){
										var messageSentEvent = new Event('messageSentEvent'); 
										document.addEventListener('messageSentEvent', (message)=>{
											CefSharp.PostMessage(JSON.stringify(message.detail)); 
										});
									}";

			browser.GetMainFrame().ExecuteJavaScriptAsync(script);
		}

		private void SendNotification(Message message)
		{
			string jsonMessage = SerializeMessage(message);

			string script = @" var event= new CustomEvent('messageReceiveEvent', {detail: " + jsonMessage + @"}); 
							document.dispatchEvent(event);";

			browser.GetMainFrame().ExecuteJavaScriptAsync(script);
		}

		private static string SerializeMessage(Message message)
		{
			return JsonConvert.SerializeObject(message, new StringEnumConverter());
		}

		private void SampleForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (browser != null)
			{
				browser.JavascriptMessageReceived -= OnReceiveNotification;
				browser.LoadingStateChanged -= OnLoadingStateChanged;
				browser.Dispose();
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			Message message = new Message()
			{
				Data = txtMessage.Text
			};

			rtChatHistory.AppendText("Windows: " + message.Data + Environment.NewLine);
			SendNotification(message);
		}
	}
}
