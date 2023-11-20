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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioPARTTIME = new System.Windows.Forms.RadioButton();
            this.radioFULLTIME = new System.Windows.Forms.RadioButton();
            this.groupDeductions = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxSSS = new System.Windows.Forms.CheckBox();
            this.boxPAGIBIG = new System.Windows.Forms.CheckBox();
            this.boxPHILHEALTH = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxOvertime = new System.Windows.Forms.CheckBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupTime.SuspendLayout();
            this.groupDeductions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTime
            // 
            this.groupTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.groupTime.Controls.Add(this.label4);
            this.groupTime.Controls.Add(this.label3);
            this.groupTime.Controls.Add(this.radioPARTTIME);
            this.groupTime.Controls.Add(this.radioFULLTIME);
            this.groupTime.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTime.ForeColor = System.Drawing.SystemColors.Window;
            this.groupTime.Location = new System.Drawing.Point(243, 183);
            this.groupTime.Margin = new System.Windows.Forms.Padding(2);
            this.groupTime.Name = "groupTime";
            this.groupTime.Padding = new System.Windows.Forms.Padding(2);
            this.groupTime.Size = new System.Drawing.Size(161, 156);
            this.groupTime.TabIndex = 0;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "WORK TIME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 11);
            this.label4.TabIndex = 3;
            this.label4.Text = "80/hr (4 hours)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "150/hr (8 hours)";
            // 
            // radioPARTTIME
            // 
            this.radioPARTTIME.AutoSize = true;
            this.radioPARTTIME.Location = new System.Drawing.Point(14, 96);
            this.radioPARTTIME.Margin = new System.Windows.Forms.Padding(2);
            this.radioPARTTIME.Name = "radioPARTTIME";
            this.radioPARTTIME.Size = new System.Drawing.Size(102, 21);
            this.radioPARTTIME.TabIndex = 1;
            this.radioPARTTIME.TabStop = true;
            this.radioPARTTIME.Text = "Part Time";
            this.radioPARTTIME.UseVisualStyleBackColor = true;
            this.radioPARTTIME.CheckedChanged += new System.EventHandler(this.RadioPARTTIME_CheckedChanged);
            // 
            // radioFULLTIME
            // 
            this.radioFULLTIME.AutoSize = true;
            this.radioFULLTIME.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFULLTIME.Location = new System.Drawing.Point(14, 41);
            this.radioFULLTIME.Margin = new System.Windows.Forms.Padding(2);
            this.radioFULLTIME.Name = "radioFULLTIME";
            this.radioFULLTIME.Size = new System.Drawing.Size(100, 21);
            this.radioFULLTIME.TabIndex = 0;
            this.radioFULLTIME.TabStop = true;
            this.radioFULLTIME.Text = "Full Time";
            this.radioFULLTIME.UseVisualStyleBackColor = true;
            this.radioFULLTIME.CheckedChanged += new System.EventHandler(this.RadioFULLTIME_CheckedChanged);
            // 
            // groupDeductions
            // 
            this.groupDeductions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.groupDeductions.Controls.Add(this.label7);
            this.groupDeductions.Controls.Add(this.label6);
            this.groupDeductions.Controls.Add(this.label5);
            this.groupDeductions.Controls.Add(this.boxSSS);
            this.groupDeductions.Controls.Add(this.boxPAGIBIG);
            this.groupDeductions.Controls.Add(this.boxPHILHEALTH);
            this.groupDeductions.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeductions.ForeColor = System.Drawing.SystemColors.Window;
            this.groupDeductions.Location = new System.Drawing.Point(412, 183);
            this.groupDeductions.Margin = new System.Windows.Forms.Padding(2);
            this.groupDeductions.Name = "groupDeductions";
            this.groupDeductions.Padding = new System.Windows.Forms.Padding(2);
            this.groupDeductions.Size = new System.Drawing.Size(167, 156);
            this.groupDeductions.TabIndex = 1;
            this.groupDeductions.TabStop = false;
            this.groupDeductions.Text = "DEDUCTIONS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 11);
            this.label7.TabIndex = 6;
            this.label7.Text = "100 Pesos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 11);
            this.label6.TabIndex = 6;
            this.label6.Text = "200 Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 11);
            this.label5.TabIndex = 4;
            this.label5.Text = "300 Pesos";
            // 
            // boxSSS
            // 
            this.boxSSS.AutoSize = true;
            this.boxSSS.Location = new System.Drawing.Point(25, 112);
            this.boxSSS.Margin = new System.Windows.Forms.Padding(2);
            this.boxSSS.Name = "boxSSS";
            this.boxSSS.Size = new System.Drawing.Size(54, 21);
            this.boxSSS.TabIndex = 2;
            this.boxSSS.Text = "SSS";
            this.boxSSS.UseVisualStyleBackColor = true;
            this.boxSSS.CheckedChanged += new System.EventHandler(this.BoxSSS_CheckedChanged);
            // 
            // boxPAGIBIG
            // 
            this.boxPAGIBIG.AutoSize = true;
            this.boxPAGIBIG.Location = new System.Drawing.Point(25, 72);
            this.boxPAGIBIG.Margin = new System.Windows.Forms.Padding(2);
            this.boxPAGIBIG.Name = "boxPAGIBIG";
            this.boxPAGIBIG.Size = new System.Drawing.Size(93, 21);
            this.boxPAGIBIG.TabIndex = 1;
            this.boxPAGIBIG.Text = "PAGIBIG";
            this.boxPAGIBIG.UseVisualStyleBackColor = true;
            this.boxPAGIBIG.CheckedChanged += new System.EventHandler(this.BoxPAGIBIG_CheckedChanged);
            // 
            // boxPHILHEALTH
            // 
            this.boxPHILHEALTH.AutoSize = true;
            this.boxPHILHEALTH.Location = new System.Drawing.Point(25, 28);
            this.boxPHILHEALTH.Margin = new System.Windows.Forms.Padding(2);
            this.boxPHILHEALTH.Name = "boxPHILHEALTH";
            this.boxPHILHEALTH.Size = new System.Drawing.Size(127, 21);
            this.boxPHILHEALTH.TabIndex = 0;
            this.boxPHILHEALTH.Text = "PHILHEALTH";
            this.boxPHILHEALTH.UseVisualStyleBackColor = true;
            this.boxPHILHEALTH.CheckedChanged += new System.EventHandler(this.BoxPHILHEALTH_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(285, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Automated Tax Deduction by roughly 10%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxOvertime
            // 
            this.boxOvertime.AutoSize = true;
            this.boxOvertime.BackColor = System.Drawing.Color.Indigo;
            this.boxOvertime.Checked = true;
            this.boxOvertime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxOvertime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOvertime.ForeColor = System.Drawing.SystemColors.Window;
            this.boxOvertime.Location = new System.Drawing.Point(371, 391);
            this.boxOvertime.Margin = new System.Windows.Forms.Padding(2);
            this.boxOvertime.Name = "boxOvertime";
            this.boxOvertime.Size = new System.Drawing.Size(81, 25);
            this.boxOvertime.TabIndex = 2;
            this.boxOvertime.Text = "Overtime";
            this.boxOvertime.UseVisualStyleBackColor = false;
            this.boxOvertime.CheckedChanged += new System.EventHandler(this.BoxOvertime_CheckedChanged_1);
            // 
            // txtOvertime
            // 
            this.txtOvertime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOvertime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOvertime.Location = new System.Drawing.Point(319, 420);
            this.txtOvertime.Margin = new System.Windows.Forms.Padding(2);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(183, 26);
            this.txtOvertime.TabIndex = 3;
            this.txtOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.BackColor = System.Drawing.Color.Indigo;
            this.lblOvertime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOvertime.Location = new System.Drawing.Point(462, 425);
            this.lblOvertime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(34, 16);
            this.lblOvertime.TabIndex = 4;
            this.lblOvertime.Text = "45/hr";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(142, 16);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(114, 29);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(774, 517);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 35);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MediumPurple;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(363, 95);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(165, 55);
            this.txtTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlueViolet;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Overall Pay";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompute.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(14, 16);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(115, 29);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Location = new System.Drawing.Point(608, 29);
            this.txtPreview.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(458, 553);
            this.txtPreview.TabIndex = 6;
            this.txtPreview.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
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
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.lblDateTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(29, 398);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(41, 24);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "TEXT";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(279, 466);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(269, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumPurple;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(308, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 61);
            this.label9.TabIndex = 2;
            this.label9.Text = "₱";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogout.Location = new System.Drawing.Point(51, 520);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(115, 30);
            this.BtnLogout.TabIndex = 17;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(63, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "TODAY IS:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1071, 600);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.boxOvertime);
            this.Controls.Add(this.groupDeductions);
            this.Controls.Add(this.groupTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.groupDeductions.ResumeLayout(false);
            this.groupDeductions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.RadioButton radioPARTTIME;
        private System.Windows.Forms.RadioButton radioFULLTIME;
        private System.Windows.Forms.GroupBox groupDeductions;
        private System.Windows.Forms.CheckBox boxSSS;
        private System.Windows.Forms.CheckBox boxPAGIBIG;
        private System.Windows.Forms.CheckBox boxPHILHEALTH;
        private System.Windows.Forms.CheckBox boxOvertime;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label label8;
    }
}