namespace RabbitMQ_Consumer
{
  partial class Consumer
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
      this.lblHostName = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUserName = new System.Windows.Forms.Label();
      this.txtHostName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.lblQueueName = new System.Windows.Forms.Label();
      this.txtQueueName = new System.Windows.Forms.TextBox();
      this.btnSubscribeEvent = new System.Windows.Forms.Button();
      this.btnPollingMessage = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblHostName
      // 
      this.lblHostName.AutoSize = true;
      this.lblHostName.Location = new System.Drawing.Point(34, 75);
      this.lblHostName.Name = "lblHostName";
      this.lblHostName.Size = new System.Drawing.Size(66, 13);
      this.lblHostName.TabIndex = 12;
      this.lblHostName.Text = "Host Name :";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(34, 47);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(60, 13);
      this.lblPassword.TabIndex = 11;
      this.lblPassword.Text = "Password :";
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Location = new System.Drawing.Point(34, 19);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(66, 13);
      this.lblUserName.TabIndex = 10;
      this.lblUserName.Text = "User Name :";
      // 
      // txtHostName
      // 
      this.txtHostName.Location = new System.Drawing.Point(111, 71);
      this.txtHostName.Name = "txtHostName";
      this.txtHostName.Size = new System.Drawing.Size(100, 20);
      this.txtHostName.TabIndex = 9;
      this.txtHostName.Text = "localhost";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(111, 43);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(100, 20);
      this.txtPassword.TabIndex = 8;
      this.txtPassword.Text = "guest";
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(111, 15);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(100, 20);
      this.txtUserName.TabIndex = 7;
      this.txtUserName.Text = "guest";
      // 
      // lblQueueName
      // 
      this.lblQueueName.AutoSize = true;
      this.lblQueueName.Location = new System.Drawing.Point(34, 103);
      this.lblQueueName.Name = "lblQueueName";
      this.lblQueueName.Size = new System.Drawing.Size(76, 13);
      this.lblQueueName.TabIndex = 14;
      this.lblQueueName.Text = "Queue Name :";
      // 
      // txtQueueName
      // 
      this.txtQueueName.Location = new System.Drawing.Point(111, 99);
      this.txtQueueName.Name = "txtQueueName";
      this.txtQueueName.Size = new System.Drawing.Size(100, 20);
      this.txtQueueName.TabIndex = 13;
      this.txtQueueName.Text = "message-queue-1";
      // 
      // btnSubscribeEvent
      // 
      this.btnSubscribeEvent.Location = new System.Drawing.Point(37, 158);
      this.btnSubscribeEvent.Name = "btnSubscribeEvent";
      this.btnSubscribeEvent.Size = new System.Drawing.Size(174, 23);
      this.btnSubscribeEvent.TabIndex = 16;
      this.btnSubscribeEvent.Text = "Subscribe Event";
      this.btnSubscribeEvent.UseVisualStyleBackColor = true;
      this.btnSubscribeEvent.Click += new System.EventHandler(this.btnSubscribeEvent_Click);
      // 
      // btnPollingMessage
      // 
      this.btnPollingMessage.Location = new System.Drawing.Point(37, 127);
      this.btnPollingMessage.Name = "btnPollingMessage";
      this.btnPollingMessage.Size = new System.Drawing.Size(174, 23);
      this.btnPollingMessage.TabIndex = 15;
      this.btnPollingMessage.Text = "Polling Message";
      this.btnPollingMessage.UseVisualStyleBackColor = true;
      this.btnPollingMessage.Click += new System.EventHandler(this.btnPollingMessage_Click);
      // 
      // Consumer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(248, 205);
      this.Controls.Add(this.btnSubscribeEvent);
      this.Controls.Add(this.btnPollingMessage);
      this.Controls.Add(this.lblQueueName);
      this.Controls.Add(this.txtQueueName);
      this.Controls.Add(this.lblHostName);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblUserName);
      this.Controls.Add(this.txtHostName);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUserName);
      this.MaximizeBox = false;
      this.Name = "Consumer";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RabbitMQ-Consumer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblHostName;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.TextBox txtHostName;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Label lblQueueName;
    private System.Windows.Forms.TextBox txtQueueName;
    private System.Windows.Forms.Button btnSubscribeEvent;
    private System.Windows.Forms.Button btnPollingMessage;
  }
}

