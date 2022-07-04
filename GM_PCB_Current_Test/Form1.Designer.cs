namespace GM_PCB_Current_Test
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
            this.btnCreateConnection = new System.Windows.Forms.Button();
            this.txtPowerSupplyAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtEquipmentResponse = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateConnection
            // 
            this.btnCreateConnection.Location = new System.Drawing.Point(792, 81);
            this.btnCreateConnection.Name = "btnCreateConnection";
            this.btnCreateConnection.Size = new System.Drawing.Size(167, 40);
            this.btnCreateConnection.TabIndex = 0;
            this.btnCreateConnection.Text = "Bağlantı Kur";
            this.btnCreateConnection.UseVisualStyleBackColor = true;
            this.btnCreateConnection.Click += new System.EventHandler(this.btnCreateConnection_Click);
            // 
            // txtPowerSupplyAddress
            // 
            this.txtPowerSupplyAddress.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPowerSupplyAddress.Location = new System.Drawing.Point(316, 81);
            this.txtPowerSupplyAddress.Name = "txtPowerSupplyAddress";
            this.txtPowerSupplyAddress.Size = new System.Drawing.Size(470, 36);
            this.txtPowerSupplyAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Güç Kaynağı Adresi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "GM PCB Akım Test Programı";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandLine.Location = new System.Drawing.Point(316, 139);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(470, 36);
            this.txtCommandLine.TabIndex = 4;
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.Location = new System.Drawing.Point(792, 139);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(167, 40);
            this.btnRunCommand.TabIndex = 5;
            this.btnRunCommand.Text = "Çalıştır";
            this.btnRunCommand.UseVisualStyleBackColor = true;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "VISA Komutu : ";
            // 
            // rtxtEquipmentResponse
            // 
            this.rtxtEquipmentResponse.Location = new System.Drawing.Point(316, 198);
            this.rtxtEquipmentResponse.Name = "rtxtEquipmentResponse";
            this.rtxtEquipmentResponse.Size = new System.Drawing.Size(470, 240);
            this.rtxtEquipmentResponse.TabIndex = 7;
            this.rtxtEquipmentResponse.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ekipman Cevabı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtEquipmentResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRunCommand);
            this.Controls.Add(this.txtCommandLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPowerSupplyAddress);
            this.Controls.Add(this.btnCreateConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateConnection;
        private System.Windows.Forms.TextBox txtPowerSupplyAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtEquipmentResponse;
        private System.Windows.Forms.Label label4;
    }
}

