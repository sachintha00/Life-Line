namespace LifeLine
{
    partial class frmLoard
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.prgrssLoard = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblPercentage = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.prgrssLoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // prgrssLoard
            // 
            this.prgrssLoard.Controls.Add(this.gunaLabel1);
            this.prgrssLoard.Controls.Add(this.lblPercentage);
            this.prgrssLoard.FillThickness = 590;
            this.prgrssLoard.Location = new System.Drawing.Point(21, -391);
            this.prgrssLoard.Name = "prgrssLoard";
            this.prgrssLoard.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.prgrssLoard.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.prgrssLoard.ProgressThickness = 520;
            this.prgrssLoard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prgrssLoard.ShadowDecoration.Parent = this.prgrssLoard;
            this.prgrssLoard.Size = new System.Drawing.Size(1800, 1670);
            this.prgrssLoard.TabIndex = 0;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft JhengHei", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(147)))), ((int)(((byte)(197)))));
            this.lblPercentage.Location = new System.Drawing.Point(169, 800);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(113, 125);
            this.lblPercentage.TabIndex = 0;
            this.lblPercentage.Text = "0";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaLabel1.Location = new System.Drawing.Point(216, 400);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(451, 125);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Life Line";
            // 
            // frmLoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 754);
            this.Controls.Add(this.prgrssLoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoard_Load);
            this.prgrssLoard.ResumeLayout(false);
            this.prgrssLoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timerLoading;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prgrssLoard;
        private Guna.UI.WinForms.GunaLabel lblPercentage;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

