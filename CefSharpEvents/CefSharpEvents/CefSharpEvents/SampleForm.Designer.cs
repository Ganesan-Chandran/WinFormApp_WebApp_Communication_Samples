namespace CefSharpEvents
{
	partial class SampleForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlChatContainer = new System.Windows.Forms.Panel();
			this.pnlBrowserContainer = new System.Windows.Forms.Panel();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.rtChatHistory = new System.Windows.Forms.RichTextBox();
			this.pnlChatContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChatContainer
			// 
			this.pnlChatContainer.Controls.Add(this.rtChatHistory);
			this.pnlChatContainer.Controls.Add(this.btnSend);
			this.pnlChatContainer.Controls.Add(this.txtMessage);
			this.pnlChatContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlChatContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlChatContainer.Name = "pnlChatContainer";
			this.pnlChatContainer.Size = new System.Drawing.Size(387, 450);
			this.pnlChatContainer.TabIndex = 1;
			// 
			// pnlBrowserContainer
			// 
			this.pnlBrowserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBrowserContainer.Location = new System.Drawing.Point(387, 0);
			this.pnlBrowserContainer.Name = "pnlBrowserContainer";
			this.pnlBrowserContainer.Size = new System.Drawing.Size(413, 450);
			this.pnlBrowserContainer.TabIndex = 2;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(15, 26);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(278, 20);
			this.txtMessage.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(299, 26);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// rtChatHistory
			// 
			this.rtChatHistory.Location = new System.Drawing.Point(15, 65);
			this.rtChatHistory.Name = "rtChatHistory";
			this.rtChatHistory.Size = new System.Drawing.Size(359, 368);
			this.rtChatHistory.TabIndex = 2;
			this.rtChatHistory.Text = "";
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlBrowserContainer);
			this.Controls.Add(this.pnlChatContainer);
			this.Name = "SampleForm";
			this.Text = "Sample Applications";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SampleForm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlChatContainer.ResumeLayout(false);
			this.pnlChatContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlChatContainer;
		private System.Windows.Forms.Panel pnlBrowserContainer;
		private System.Windows.Forms.RichTextBox rtChatHistory;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtMessage;
	}
}

