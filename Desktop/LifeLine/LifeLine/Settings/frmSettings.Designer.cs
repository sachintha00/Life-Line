namespace LifeLine
{
    partial class frmSettings
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.trnsLoad = new Guna.UI2.WinForms.Guna2Transition();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSettChild = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAuthentication = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSettAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlTheme = new Guna.UI2.WinForms.Guna2PictureBox();
            this.animateSetting = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // trnsLoad
            // 
            this.trnsLoad.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.trnsLoad.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.trnsLoad.DefaultAnimation = animation3;
            this.trnsLoad.MaxAnimationTime = 700;
            this.trnsLoad.TimeStep = 0.03F;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trnsLoad.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1469, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(82, 48);
            this.gunaControlBox1.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.trnsLoad.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(418, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(5, 698);
            this.guna2Panel1.TabIndex = 8;
            // 
            // pnlSettChild
            // 
            this.pnlSettChild.AutoScroll = true;
            this.trnsLoad.SetDecoration(this.pnlSettChild, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSettChild.Location = new System.Drawing.Point(431, 63);
            this.pnlSettChild.Name = "pnlSettChild";
            this.pnlSettChild.ShadowDecoration.Parent = this.pnlSettChild;
            this.pnlSettChild.Size = new System.Drawing.Size(1107, 687);
            this.pnlSettChild.TabIndex = 9;
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Animated = true;
            this.btnAuthentication.BorderRadius = 15;
            this.btnAuthentication.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAuthentication.Checked = true;
            this.btnAuthentication.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnAuthentication.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnAuthentication.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAuthentication.CheckedState.Parent = this.btnAuthentication;
            this.btnAuthentication.CustomImages.Parent = this.btnAuthentication;
            this.trnsLoad.SetDecoration(this.btnAuthentication, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAuthentication.FillColor = System.Drawing.Color.Transparent;
            this.btnAuthentication.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAuthentication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAuthentication.ForeColor = System.Drawing.Color.Gray;
            this.btnAuthentication.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnAuthentication.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnAuthentication.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAuthentication.HoverState.Parent = this.btnAuthentication;
            this.btnAuthentication.Location = new System.Drawing.Point(163, 290);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.ShadowDecoration.Parent = this.btnAuthentication;
            this.btnAuthentication.Size = new System.Drawing.Size(229, 59);
            this.btnAuthentication.TabIndex = 10;
            this.btnAuthentication.Text = "Authentication";
            this.btnAuthentication.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // btnSettAccount
            // 
            this.btnSettAccount.Animated = true;
            this.btnSettAccount.BorderRadius = 15;
            this.btnSettAccount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettAccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnSettAccount.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnSettAccount.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSettAccount.CheckedState.Parent = this.btnSettAccount;
            this.btnSettAccount.CustomImages.Parent = this.btnSettAccount;
            this.trnsLoad.SetDecoration(this.btnSettAccount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnSettAccount.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSettAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSettAccount.ForeColor = System.Drawing.Color.Gray;
            this.btnSettAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnSettAccount.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnSettAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettAccount.HoverState.Parent = this.btnSettAccount;
            this.btnSettAccount.Location = new System.Drawing.Point(163, 355);
            this.btnSettAccount.Name = "btnSettAccount";
            this.btnSettAccount.ShadowDecoration.Parent = this.btnSettAccount;
            this.btnSettAccount.Size = new System.Drawing.Size(229, 59);
            this.btnSettAccount.TabIndex = 10;
            this.btnSettAccount.Text = "Account";
            this.btnSettAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSettAccount.Click += new System.EventHandler(this.btnSettAccount_Click);
            // 
            // pnlTheme
            // 
            this.trnsLoad.SetDecoration(this.pnlTheme, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTheme.Location = new System.Drawing.Point(0, 766);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.ShadowDecoration.Parent = this.pnlTheme;
            this.pnlTheme.Size = new System.Drawing.Size(1550, 254);
            this.pnlTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlTheme.TabIndex = 6;
            this.pnlTheme.TabStop = false;
            this.pnlTheme.Visible = false;
            // 
            // animateSetting
            // 
            this.animateSetting.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animateSetting.Interval = 700;
            // 
            // frmSettingsStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 1020);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.btnSettAccount);
            this.Controls.Add(this.pnlSettChild);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.pnlTheme);
            this.trnsLoad.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettingsStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6StudentDash";
            this.Load += new System.EventHandler(this.frmGrade6StudentSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox pnlTheme;
        private Guna.UI2.WinForms.Guna2Transition trnsLoad;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateSetting;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlSettChild;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSettAccount;
        private Guna.UI2.WinForms.Guna2GradientButton btnAuthentication;
    }
}