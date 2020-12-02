namespace ColorPickerSocket_Server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxBlueCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGreenCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRedCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.buttonListen = new System.Windows.Forms.Button();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxBlueCode
            // 
            this.textBoxBlueCode.BackColor = System.Drawing.Color.Aqua;
            this.textBoxBlueCode.Enabled = false;
            this.textBoxBlueCode.Location = new System.Drawing.Point(19, 244);
            this.textBoxBlueCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBlueCode.Name = "textBoxBlueCode";
            this.textBoxBlueCode.ReadOnly = true;
            this.textBoxBlueCode.Size = new System.Drawing.Size(132, 22);
            this.textBoxBlueCode.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Blue";
            // 
            // textBoxGreenCode
            // 
            this.textBoxGreenCode.BackColor = System.Drawing.Color.Lime;
            this.textBoxGreenCode.Enabled = false;
            this.textBoxGreenCode.Location = new System.Drawing.Point(19, 197);
            this.textBoxGreenCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGreenCode.Name = "textBoxGreenCode";
            this.textBoxGreenCode.ReadOnly = true;
            this.textBoxGreenCode.Size = new System.Drawing.Size(132, 22);
            this.textBoxGreenCode.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Green";
            // 
            // textBoxRedCode
            // 
            this.textBoxRedCode.BackColor = System.Drawing.Color.Red;
            this.textBoxRedCode.Enabled = false;
            this.textBoxRedCode.Location = new System.Drawing.Point(19, 150);
            this.textBoxRedCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRedCode.Name = "textBoxRedCode";
            this.textBoxRedCode.ReadOnly = true;
            this.textBoxRedCode.Size = new System.Drawing.Size(132, 22);
            this.textBoxRedCode.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Red";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(176, 81);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 22);
            this.textBoxPort.TabIndex = 16;
            this.textBoxPort.Text = "16375";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(176, 34);
            this.textBoxIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxIPAddress.TabIndex = 14;
            this.textBoxIPAddress.Text = "192.168.0.100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP Address";
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.Color.White;
            this.panelColorSelected.Location = new System.Drawing.Point(19, 13);
            this.panelColorSelected.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(103, 100);
            this.panelColorSelected.TabIndex = 17;
            this.panelColorSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColorSelected_Paint);
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(208, 244);
            this.buttonListen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(100, 28);
            this.buttonListen.TabIndex = 24;
            this.buttonListen.Text = "LISTEN";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(337, 302);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.textBoxBlueCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGreenCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRedCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColorSelected);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Color Picker Socket Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBlueCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGreenCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRedCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Timer timerServer;
    }
}

