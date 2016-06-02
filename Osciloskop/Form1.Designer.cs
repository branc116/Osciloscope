﻿namespace Osciloskop
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
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.connButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshRateTextBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.RestartEspButton = new System.Windows.Forms.Button();
            this.osci = new Osciloskop.GrafPrikazOsciloskopa();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomBar
            // 
            this.zoomBar.LargeChange = 50;
            this.zoomBar.Location = new System.Drawing.Point(12, 102);
            this.zoomBar.Maximum = 20;
            this.zoomBar.Minimum = 2;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(617, 56);
            this.zoomBar.SmallChange = 10;
            this.zoomBar.TabIndex = 10;
            this.zoomBar.Value = 5;
            this.zoomBar.ValueChanged += new System.EventHandler(this.zoomBar_ValueChanged);
            // 
            // connButton
            // 
            this.connButton.Location = new System.Drawing.Point(13, 9);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(75, 27);
            this.connButton.TabIndex = 11;
            this.connButton.Text = "Connect";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(94, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 26);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(175, 9);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(92, 27);
            this.DisconnectButton.TabIndex = 13;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Period osvježavanja ( ms ) :";
            // 
            // RefreshRateTextBox
            // 
            this.RefreshRateTextBox.Location = new System.Drawing.Point(202, 56);
            this.RefreshRateTextBox.Name = "RefreshRateTextBox";
            this.RefreshRateTextBox.Size = new System.Drawing.Size(65, 22);
            this.RefreshRateTextBox.TabIndex = 15;
            this.RefreshRateTextBox.Text = "10";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(273, 56);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 16;
            this.Send.Text = "Popravi";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // RestartEspButton
            // 
            this.RestartEspButton.Location = new System.Drawing.Point(273, 8);
            this.RestartEspButton.Name = "RestartEspButton";
            this.RestartEspButton.Size = new System.Drawing.Size(92, 27);
            this.RestartEspButton.TabIndex = 17;
            this.RestartEspButton.Text = "Restart";
            this.RestartEspButton.UseVisualStyleBackColor = true;
            this.RestartEspButton.Click += new System.EventHandler(this.RestartEspButton_Click);
            // 
            // osci
            // 
            this.osci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osci.Location = new System.Drawing.Point(12, 164);
            this.osci.Name = "osci";
            this.osci.Size = new System.Drawing.Size(789, 294);
            this.osci.TabIndex = 0;
            this.osci.Text = "grafPrikazOsciloskopa1";
            this.osci.zoom = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 470);
            this.Controls.Add(this.RestartEspButton);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.RefreshRateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.osci);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrafPrikazOsciloskopa osci;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Button connButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RefreshRateTextBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button RestartEspButton;
    }
}

