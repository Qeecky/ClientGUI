namespace ClientGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Serv_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.IP_textbox = new System.Windows.Forms.TextBox();
            this.usernmae_textbox = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.msg_textbox = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.chat_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Serv_label
            // 
            this.Serv_label.AutoSize = true;
            this.Serv_label.Location = new System.Drawing.Point(42, 35);
            this.Serv_label.Name = "Serv_label";
            this.Serv_label.Size = new System.Drawing.Size(52, 15);
            this.Serv_label.TabIndex = 0;
            this.Serv_label.Text = "Server IP";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(34, 73);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(60, 15);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            this.Username_label.Click += new System.EventHandler(this.Username_label_Click);
            // 
            // IP_textbox
            // 
            this.IP_textbox.Location = new System.Drawing.Point(115, 32);
            this.IP_textbox.Name = "IP_textbox";
            this.IP_textbox.Size = new System.Drawing.Size(135, 23);
            this.IP_textbox.TabIndex = 2;
            // 
            // usernmae_textbox
            // 
            this.usernmae_textbox.Location = new System.Drawing.Point(113, 70);
            this.usernmae_textbox.Name = "usernmae_textbox";
            this.usernmae_textbox.Size = new System.Drawing.Size(137, 23);
            this.usernmae_textbox.TabIndex = 3;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(276, 70);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            // 
            // msg_textbox
            // 
            this.msg_textbox.Location = new System.Drawing.Point(24, 405);
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Size = new System.Drawing.Size(258, 23);
            this.msg_textbox.TabIndex = 5;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(292, 405);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 6;
            this.send_btn.Text = "send";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // chat_textbox
            // 
            this.chat_textbox.Location = new System.Drawing.Point(52, 224);
            this.chat_textbox.Name = "chat_textbox";
            this.chat_textbox.Size = new System.Drawing.Size(274, 23);
            this.chat_textbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.chat_textbox);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.msg_textbox);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.usernmae_textbox);
            this.Controls.Add(this.IP_textbox);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Serv_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Serv_label;
        private Label Username_label;
        private TextBox IP_textbox;
        private TextBox usernmae_textbox;
        private Button connect_btn;
        private TextBox msg_textbox;
        private Button send_btn;
        private TextBox chat_textbox;
    }
}