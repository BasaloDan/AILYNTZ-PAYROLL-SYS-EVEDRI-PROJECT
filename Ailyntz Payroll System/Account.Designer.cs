namespace Ailyntz_Payroll_System
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioPARTTIME = new System.Windows.Forms.RadioButton();
            this.radioFULLTIME = new System.Windows.Forms.RadioButton();
            this.groupDeductions = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTAX = new System.Windows.Forms.CheckBox();
            this.boxSSS = new System.Windows.Forms.CheckBox();
            this.boxPAGIBIG = new System.Windows.Forms.CheckBox();
            this.boxPHILHEALTH = new System.Windows.Forms.CheckBox();
            this.boxOvertime = new System.Windows.Forms.CheckBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupTime.SuspendLayout();
            this.groupDeductions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTime
            // 
            this.groupTime.Controls.Add(this.label4);
            this.groupTime.Controls.Add(this.label3);
            this.groupTime.Controls.Add(this.radioPARTTIME);
            this.groupTime.Controls.Add(this.radioFULLTIME);
            this.groupTime.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTime.Location = new System.Drawing.Point(24, 21);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(274, 180);
            this.groupTime.TabIndex = 0;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "-Work Time-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "80/hr (4 hours)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "150/hr (8 hours)";
            // 
            // radioPARTTIME
            // 
            this.radioPARTTIME.AutoSize = true;
            this.radioPARTTIME.Location = new System.Drawing.Point(21, 106);
            this.radioPARTTIME.Name = "radioPARTTIME";
            this.radioPARTTIME.Size = new System.Drawing.Size(141, 22);
            this.radioPARTTIME.TabIndex = 1;
            this.radioPARTTIME.TabStop = true;
            this.radioPARTTIME.Text = "Part Time";
            this.radioPARTTIME.UseVisualStyleBackColor = true;
            this.radioPARTTIME.CheckedChanged += new System.EventHandler(this.radioPARTTIME_CheckedChanged);
            // 
            // radioFULLTIME
            // 
            this.radioFULLTIME.AutoSize = true;
            this.radioFULLTIME.Location = new System.Drawing.Point(21, 37);
            this.radioFULLTIME.Name = "radioFULLTIME";
            this.radioFULLTIME.Size = new System.Drawing.Size(141, 22);
            this.radioFULLTIME.TabIndex = 0;
            this.radioFULLTIME.TabStop = true;
            this.radioFULLTIME.Text = "Full Time";
            this.radioFULLTIME.UseVisualStyleBackColor = true;
            this.radioFULLTIME.CheckedChanged += new System.EventHandler(this.radioFULLTIME_CheckedChanged);
            // 
            // groupDeductions
            // 
            this.groupDeductions.Controls.Add(this.label8);
            this.groupDeductions.Controls.Add(this.label7);
            this.groupDeductions.Controls.Add(this.label6);
            this.groupDeductions.Controls.Add(this.label5);
            this.groupDeductions.Controls.Add(this.boxTAX);
            this.groupDeductions.Controls.Add(this.boxSSS);
            this.groupDeductions.Controls.Add(this.boxPAGIBIG);
            this.groupDeductions.Controls.Add(this.boxPHILHEALTH);
            this.groupDeductions.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeductions.Location = new System.Drawing.Point(322, 12);
            this.groupDeductions.Name = "groupDeductions";
            this.groupDeductions.Size = new System.Drawing.Size(217, 286);
            this.groupDeductions.TabIndex = 1;
            this.groupDeductions.TabStop = false;
            this.groupDeductions.Text = "-Deductions-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "10%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "100 Pesos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "200 Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "300 Pesos";
            // 
            // boxTAX
            // 
            this.boxTAX.AutoSize = true;
            this.boxTAX.Location = new System.Drawing.Point(15, 228);
            this.boxTAX.Name = "boxTAX";
            this.boxTAX.Size = new System.Drawing.Size(70, 22);
            this.boxTAX.TabIndex = 3;
            this.boxTAX.Text = "TAX";
            this.boxTAX.UseVisualStyleBackColor = true;
            this.boxTAX.CheckedChanged += new System.EventHandler(this.boxTAX_CheckedChanged);
            // 
            // boxSSS
            // 
            this.boxSSS.AutoSize = true;
            this.boxSSS.Location = new System.Drawing.Point(15, 167);
            this.boxSSS.Name = "boxSSS";
            this.boxSSS.Size = new System.Drawing.Size(70, 22);
            this.boxSSS.TabIndex = 2;
            this.boxSSS.Text = "SSS";
            this.boxSSS.UseVisualStyleBackColor = true;
            this.boxSSS.CheckedChanged += new System.EventHandler(this.boxSSS_CheckedChanged);
            // 
            // boxPAGIBIG
            // 
            this.boxPAGIBIG.AutoSize = true;
            this.boxPAGIBIG.Location = new System.Drawing.Point(15, 106);
            this.boxPAGIBIG.Name = "boxPAGIBIG";
            this.boxPAGIBIG.Size = new System.Drawing.Size(118, 22);
            this.boxPAGIBIG.TabIndex = 1;
            this.boxPAGIBIG.Text = "PAGIBIG";
            this.boxPAGIBIG.UseVisualStyleBackColor = true;
            this.boxPAGIBIG.CheckedChanged += new System.EventHandler(this.boxPAGIBIG_CheckedChanged);
            // 
            // boxPHILHEALTH
            // 
            this.boxPHILHEALTH.AutoSize = true;
            this.boxPHILHEALTH.Location = new System.Drawing.Point(15, 38);
            this.boxPHILHEALTH.Name = "boxPHILHEALTH";
            this.boxPHILHEALTH.Size = new System.Drawing.Size(154, 22);
            this.boxPHILHEALTH.TabIndex = 0;
            this.boxPHILHEALTH.Text = "PHILHEALTH";
            this.boxPHILHEALTH.UseVisualStyleBackColor = true;
            this.boxPHILHEALTH.CheckedChanged += new System.EventHandler(this.boxPHILHEALTH_CheckedChanged);
            // 
            // boxOvertime
            // 
            this.boxOvertime.AutoSize = true;
            this.boxOvertime.Checked = true;
            this.boxOvertime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxOvertime.Location = new System.Drawing.Point(45, 219);
            this.boxOvertime.Name = "boxOvertime";
            this.boxOvertime.Size = new System.Drawing.Size(98, 24);
            this.boxOvertime.TabIndex = 2;
            this.boxOvertime.Text = "Overtime";
            this.boxOvertime.UseVisualStyleBackColor = true;
            this.boxOvertime.CheckedChanged += new System.EventHandler(this.boxOvertime_CheckedChanged);
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(45, 253);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(237, 26);
            this.txtOvertime.TabIndex = 3;
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Location = new System.Drawing.Point(141, 290);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(45, 20);
            this.lblOvertime.TabIndex = 4;
            this.lblOvertime.Text = "45/hr";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-Amount-";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(132, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(269, 25);
            this.txtTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(359, 41);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 42);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(21, 41);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(139, 42);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(557, 21);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(649, 480);
            this.txtPreview.TabIndex = 6;
            this.txtPreview.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(191, 41);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(139, 42);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 513);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.boxOvertime);
            this.Controls.Add(this.groupDeductions);
            this.Controls.Add(this.groupTime);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.groupDeductions.ResumeLayout(false);
            this.groupDeductions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.RadioButton radioPARTTIME;
        private System.Windows.Forms.RadioButton radioFULLTIME;
        private System.Windows.Forms.GroupBox groupDeductions;
        private System.Windows.Forms.CheckBox boxTAX;
        private System.Windows.Forms.CheckBox boxSSS;
        private System.Windows.Forms.CheckBox boxPAGIBIG;
        private System.Windows.Forms.CheckBox boxPHILHEALTH;
        private System.Windows.Forms.CheckBox boxOvertime;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPreview;
    }
}