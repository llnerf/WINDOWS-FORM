namespace Langit_Multiplexing_Multicasting
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRecipient = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisplaye = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(59, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(152, 16);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Enter Announcement:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(217, 53);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(511, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Recipient:";
            // 
            // cmbRecipient
            // 
            this.cmbRecipient.FormattingEnabled = true;
            this.cmbRecipient.Items.AddRange(new object[] {
            "All Students",
            "Teachers",
            "Administration"});
            this.cmbRecipient.Location = new System.Drawing.Point(217, 102);
            this.cmbRecipient.Name = "cmbRecipient";
            this.cmbRecipient.Size = new System.Drawing.Size(120, 21);
            this.cmbRecipient.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(573, 91);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 39);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status :";
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblLogTitle.Location = new System.Drawing.Point(59, 263);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(142, 16);
            this.lblLogTitle.TabIndex = 7;
            this.lblLogTitle.Text = "Announcement Log:";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(62, 283);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(666, 134);
            this.lstLog.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Location = new System.Drawing.Point(62, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 26);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDisplay);
            this.groupBox1.Controls.Add(this.lblDisplaye);
            this.groupBox1.Location = new System.Drawing.Point(62, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblDisplaye
            // 
            this.lblDisplaye.AutoSize = true;
            this.lblDisplaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaye.ForeColor = System.Drawing.Color.Black;
            this.lblDisplaye.Location = new System.Drawing.Point(23, 33);
            this.lblDisplaye.Name = "lblDisplaye";
            this.lblDisplaye.Size = new System.Drawing.Size(99, 16);
            this.lblDisplaye.TabIndex = 12;
            this.lblDisplaye.Text = "Announcement:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Blue;
            this.lblDisplay.Location = new System.Drawing.Point(10, 33);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(112, 16);
            this.lblDisplay.TabIndex = 13;
            this.lblDisplay.Text = "Announcement:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblLogTitle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbRecipient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRecipient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblDisplaye;
    }
}

