namespace Ailyntz_Payroll_System
{
    partial class Initializing
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLoad = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(135, 214);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(475, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(39)))));
            this.lblLoad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoad.Location = new System.Drawing.Point(627, 217);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(51, 26);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "Load";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.SlateBlue;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceed.Location = new System.Drawing.Point(344, 325);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(182, 36);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // Initializing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 490);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Initializing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initializing";
            this.Load += new System.EventHandler(this.Initializing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Button btnProceed;
    }
}