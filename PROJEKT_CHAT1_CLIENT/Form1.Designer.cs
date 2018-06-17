namespace PROJEKT_CHAT1_CLIENT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericServerPort = new System.Windows.Forms.NumericUpDown();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serwer IP:";
            // 
            // textServerIP
            // 
            this.textServerIP.Location = new System.Drawing.Point(12, 29);
            this.textServerIP.Name = "textServerIP";
            this.textServerIP.Size = new System.Drawing.Size(100, 20);
            this.textServerIP.TabIndex = 1;
            this.textServerIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serwer Port:";
            // 
            // numericServerPort
            // 
            this.numericServerPort.Location = new System.Drawing.Point(12, 92);
            this.numericServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericServerPort.Name = "numericServerPort";
            this.numericServerPort.Size = new System.Drawing.Size(100, 20);
            this.numericServerPort.TabIndex = 3;
            this.numericServerPort.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 144);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 45);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "STATUS:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(-3, 275);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(124, 16);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "NIEPOŁĄCZONY";
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(118, 12);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(577, 279);
            this.textLog.TabIndex = 7;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(13, 302);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(540, 87);
            this.textMessage.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(559, 302);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(136, 87);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Wyślij wiadomość!";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 196);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(100, 51);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Rozłącz";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 401);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.numericServerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericServerPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

