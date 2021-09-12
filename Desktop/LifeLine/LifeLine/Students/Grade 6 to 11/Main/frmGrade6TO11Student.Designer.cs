namespace LifeLine
{
    partial class frmGrade6TO11Student
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrade6TO11Student));
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSlider = new Guna.UI2.WinForms.Guna2Panel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pbProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pnlFlatButton = new Guna.UI.WinForms.GunaPanel();
            this.btnNewsEvents = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSubjects = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDash = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlChildForm = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.trnsSlider = new Guna.UI2.WinForms.Guna2Transition();
            this.transBtnSlider = new Guna.UI2.WinForms.Guna2Transition();
            this.trnsBtnMenu = new Guna.UI2.WinForms.Guna2Transition();
            this.trnsBtnMenu2 = new Guna.UI2.WinForms.Guna2Transition();
            this.trnsLogo = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.pnlSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.pnlFlatButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 1;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.pnlSlider);
            this.pnlMain.Controls.Add(this.pnlChildForm);
            this.pnlMain.Controls.Add(this.gunaControlBox2);
            this.pnlMain.Controls.Add(this.gunaControlBox1);
            this.trnsBtnMenu.SetDecoration(this.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1536, 864);
            this.pnlMain.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trnsBtnMenu.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.Image = global::LifeLine.Properties.Resources.icons8_settings_208px1;
            this.btnSettings.ImageActive = null;
            this.btnSettings.Location = new System.Drawing.Point(1315, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(37, 37);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.White;
            this.pnlSlider.Controls.Add(this.lblName);
            this.pnlSlider.Controls.Add(this.pbProfile);
            this.pnlSlider.Controls.Add(this.pnlFlatButton);
            this.trnsBtnMenu.SetDecoration(this.pnlSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.pnlSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.pnlSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.pnlSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.pnlSlider, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlider.Location = new System.Drawing.Point(0, 0);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.ShadowDecoration.Parent = this.pnlSlider;
            this.pnlSlider.Size = new System.Drawing.Size(311, 864);
            this.pnlSlider.TabIndex = 1;
            this.pnlSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSlider_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.trnsBtnMenu.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(47, 293);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(242, 32);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Sachintha Madhawa";
            // 
            // pbProfile
            // 
            this.pbProfile.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.trnsBtnMenu.SetDecoration(this.pbProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.pbProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.pbProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.pbProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.pbProfile, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(66, 91);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(186, 180);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 5;
            this.pbProfile.TabStop = false;
            this.pbProfile.UseTransfarantBackground = false;
            // 
            // pnlFlatButton
            // 
            this.pnlFlatButton.Controls.Add(this.btnNewsEvents);
            this.pnlFlatButton.Controls.Add(this.btnSubjects);
            this.pnlFlatButton.Controls.Add(this.btnDash);
            this.trnsBtnMenu.SetDecoration(this.pnlFlatButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.pnlFlatButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.pnlFlatButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.pnlFlatButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.pnlFlatButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlFlatButton.Location = new System.Drawing.Point(45, 384);
            this.pnlFlatButton.Name = "pnlFlatButton";
            this.pnlFlatButton.Size = new System.Drawing.Size(244, 353);
            this.pnlFlatButton.TabIndex = 1;
            // 
            // btnNewsEvents
            // 
            this.btnNewsEvents.Animated = true;
            this.btnNewsEvents.BackColor = System.Drawing.Color.Transparent;
            this.btnNewsEvents.BorderRadius = 20;
            this.btnNewsEvents.CheckedState.Parent = this.btnNewsEvents;
            this.btnNewsEvents.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewsEvents.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNewsEvents.CustomImages.Parent = this.btnNewsEvents;
            this.trnsLogo.SetDecoration(this.btnNewsEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.btnNewsEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.btnNewsEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.btnNewsEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu.SetDecoration(this.btnNewsEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNewsEvents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnNewsEvents.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnNewsEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewsEvents.ForeColor = System.Drawing.Color.White;
            this.btnNewsEvents.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnNewsEvents.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnNewsEvents.HoverState.Parent = this.btnNewsEvents;
            this.btnNewsEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnNewsEvents.Image")));
            this.btnNewsEvents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewsEvents.Location = new System.Drawing.Point(3, 61);
            this.btnNewsEvents.Name = "btnNewsEvents";
            this.btnNewsEvents.ShadowDecoration.BorderRadius = 28;
            this.btnNewsEvents.ShadowDecoration.Depth = 10;
            this.btnNewsEvents.ShadowDecoration.Enabled = true;
            this.btnNewsEvents.ShadowDecoration.Parent = this.btnNewsEvents;
            this.btnNewsEvents.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnNewsEvents.Size = new System.Drawing.Size(234, 52);
            this.btnNewsEvents.TabIndex = 5;
            this.btnNewsEvents.Text = "EXAM";
            this.btnNewsEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewsEvents.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Animated = true;
            this.btnSubjects.BackColor = System.Drawing.Color.Transparent;
            this.btnSubjects.BorderRadius = 20;
            this.btnSubjects.CheckedState.Parent = this.btnSubjects;
            this.btnSubjects.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubjects.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSubjects.CustomImages.Parent = this.btnSubjects;
            this.trnsLogo.SetDecoration(this.btnSubjects, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.btnSubjects, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.btnSubjects, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.btnSubjects, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu.SetDecoration(this.btnSubjects, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubjects.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnSubjects.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnSubjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubjects.ForeColor = System.Drawing.Color.White;
            this.btnSubjects.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnSubjects.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnSubjects.HoverState.Parent = this.btnSubjects;
            this.btnSubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnSubjects.Image")));
            this.btnSubjects.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubjects.Location = new System.Drawing.Point(1, 119);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.ShadowDecoration.BorderRadius = 28;
            this.btnSubjects.ShadowDecoration.Depth = 10;
            this.btnSubjects.ShadowDecoration.Enabled = true;
            this.btnSubjects.ShadowDecoration.Parent = this.btnSubjects;
            this.btnSubjects.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnSubjects.Size = new System.Drawing.Size(236, 52);
            this.btnSubjects.TabIndex = 4;
            this.btnSubjects.Text = "SUBJECTS";
            this.btnSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubjects.TextOffset = new System.Drawing.Point(10, 0);
            this.btnSubjects.Click += new System.EventHandler(this.btnSubject2_Click);
            // 
            // btnDash
            // 
            this.btnDash.Animated = true;
            this.btnDash.BackColor = System.Drawing.Color.Transparent;
            this.btnDash.BorderRadius = 20;
            this.btnDash.CheckedState.Parent = this.btnDash;
            this.btnDash.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDash.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDash.CustomImages.Parent = this.btnDash;
            this.trnsLogo.SetDecoration(this.btnDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.btnDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.btnDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.btnDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu.SetDecoration(this.btnDash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnDash.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnDash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnDash.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnDash.HoverState.Parent = this.btnDash;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDash.Location = new System.Drawing.Point(2, 3);
            this.btnDash.Name = "btnDash";
            this.btnDash.ShadowDecoration.BorderRadius = 28;
            this.btnDash.ShadowDecoration.Depth = 10;
            this.btnDash.ShadowDecoration.Enabled = true;
            this.btnDash.ShadowDecoration.Parent = this.btnDash;
            this.btnDash.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnDash.Size = new System.Drawing.Size(234, 52);
            this.btnDash.TabIndex = 2;
            this.btnDash.Text = "DASHBOARD";
            this.btnDash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDash.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildForm.AutoScroll = true;
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.trnsBtnMenu.SetDecoration(this.pnlChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.pnlChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.pnlChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.pnlChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.pnlChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlChildForm.Location = new System.Drawing.Point(317, 50);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1207, 802);
            this.pnlChildForm.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.trnsBtnMenu.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1383, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(66, 48);
            this.gunaControlBox2.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.trnsBtnMenu.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1454, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(82, 48);
            this.gunaControlBox1.TabIndex = 0;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // animate
            // 
            this.animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.animate.Interval = 3000;
            this.animate.TargetControl = null;
            // 
            // trnsSlider
            // 
            this.trnsSlider.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.trnsSlider.Cursor = null;
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
            this.trnsSlider.DefaultAnimation = animation3;
            // 
            // transBtnSlider
            // 
            this.transBtnSlider.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.transBtnSlider.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transBtnSlider.DefaultAnimation = animation2;
            // 
            // trnsBtnMenu
            // 
            this.trnsBtnMenu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.trnsBtnMenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.trnsBtnMenu.DefaultAnimation = animation1;
            this.trnsBtnMenu.MaxAnimationTime = 1000;
            // 
            // trnsBtnMenu2
            // 
            this.trnsBtnMenu2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.trnsBtnMenu2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.trnsBtnMenu2.DefaultAnimation = animation4;
            this.trnsBtnMenu2.MaxAnimationTime = 1000;
            // 
            // trnsLogo
            // 
            this.trnsLogo.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.trnsLogo.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0.5F;
            animation5.RotateLimit = 0.2F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.trnsLogo.DefaultAnimation = animation5;
            // 
            // frmGrade6TO11Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.pnlMain);
            this.trnsBtnMenu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transBtnSlider.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsSlider.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsBtnMenu2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLogo.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1536, 864);
            this.Name = "frmGrade6TO11Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6Student";
            this.Load += new System.EventHandler(this.frmGrade6Student_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.pnlSlider.ResumeLayout(false);
            this.pnlSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.pnlFlatButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlSlider;
        private Guna.UI.WinForms.GunaAnimateWindow animate;
        private Guna.UI2.WinForms.Guna2Transition trnsSlider;
        private Guna.UI2.WinForms.Guna2Transition transBtnSlider;
        private Guna.UI.WinForms.GunaPanel pnlFlatButton;
        private Guna.UI2.WinForms.Guna2GradientButton btnDash;
        private Guna.UI2.WinForms.Guna2GradientButton btnNewsEvents;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubjects;
        private Guna.UI.WinForms.GunaPanel pnlChildForm;
        private Guna.UI2.WinForms.Guna2Transition trnsBtnMenu;
        private Guna.UI2.WinForms.Guna2Transition trnsBtnMenu2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnSettings;
        private Guna.UI.WinForms.GunaCirclePictureBox pbProfile;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI2.WinForms.Guna2Transition trnsLogo;
    }
}