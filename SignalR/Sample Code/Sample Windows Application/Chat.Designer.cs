namespace Sample_Windows_Application
{
	partial class Chat
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
			this.txtChatMessage = new System.Windows.Forms.TextBox();
			this.txtChatHistory = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lblConnectionId = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtChatMessage
			// 
			this.txtChatMessage.Location = new System.Drawing.Point(12, 74);
			this.txtChatMessage.Name = "txtChatMessage";
			this.txtChatMessage.Size = new System.Drawing.Size(275, 20);
			this.txtChatMessage.TabIndex = 0;
			// 
			// txtChatHistory
			// 
			this.txtChatHistory.Location = new System.Drawing.Point(12, 166);
			this.txtChatHistory.Name = "txtChatHistory";
			this.txtChatHistory.Size = new System.Drawing.Size(275, 296);
			this.txtChatHistory.TabIndex = 1;
			this.txtChatHistory.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(88, 100);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(103, 30);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Message:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Chat History:";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(15, 12);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(103, 27);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// lblConnectionId
			// 
			this.lblConnectionId.AutoSize = true;
			this.lblConnectionId.Location = new System.Drawing.Point(134, 19);
			this.lblConnectionId.Name = "lblConnectionId";
			this.lblConnectionId.Size = new System.Drawing.Size(0, 13);
			this.lblConnectionId.TabIndex = 6;
			// 
			// Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 474);
			this.Controls.Add(this.lblConnectionId);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtChatHistory);
			this.Controls.Add(this.txtChatMessage);
			this.Name = "Chat";
			this.Text = "Chat - WinForm Application";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
			this.Load += new System.EventHandler(this.Chat_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtChatMessage;
		private System.Windows.Forms.RichTextBox txtChatHistory;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label lblConnectionId;
	}
}

