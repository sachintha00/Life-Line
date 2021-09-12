namespace LifeLine
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.pnlChild = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnCreateAcc = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShowPass = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.chkboxRemember = new Guna.UI.WinForms.GunaCheckBox();
            this.btnLogin = new Guna.UI.WinForms.GunaGradientButton();
            this.lnkForgotPW = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.drg = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.cntxtMnuCreateAccount = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.forStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pnlMain.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).BeginInit();
            this.cntxtMnuCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.gunaLabel4);
            this.pnlMain.Controls.Add(this.gunaPictureBox1);
            this.pnlMain.Controls.Add(this.pnlChild);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1323, 789);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlChild
            // 
            this.pnlChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChild.Controls.Add(this.gunaPanel1);
            this.pnlChild.Location = new System.Drawing.Point(0, 103);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1323, 686);
            this.pnlChild.TabIndex = 2;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.btnCreateAcc);
            this.gunaPanel1.Controls.Add(this.btnShowPass);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.chkboxRemember);
            this.gunaPanel1.Controls.Add(this.btnLogin);
            this.gunaPanel1.Controls.Add(this.lnkForgotPW);
            this.gunaPanel1.Controls.Add(this.txtPassword);
            this.gunaPanel1.Controls.Add(this.txtUsername);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1323, 686);
            this.gunaPanel1.TabIndex = 1;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAcc.AnimationHoverSpeed = 0.07F;
            this.btnCreateAcc.AnimationSpeed = 0.03F;
            this.btnCreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.BaseColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.btnCreateAcc.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.btnCreateAcc.CheckedImage = null;
            this.btnCreateAcc.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAcc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateAcc.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.btnCreateAcc.Image = null;
            this.btnCreateAcc.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCreateAcc.LineColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.Location = new System.Drawing.Point(1020, 470);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.btnCreateAcc.OnHoverImage = null;
            this.btnCreateAcc.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnCreateAcc.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.btnCreateAcc.OnPressedDepth = 100;
            this.btnCreateAcc.Radius = 2;
            this.btnCreateAcc.Size = new System.Drawing.Size(180, 56);
            this.btnCreateAcc.TabIndex = 7;
            this.btnCreateAcc.Text = "Create account";
            this.btnCreateAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.ImageActive = null;
            this.btnShowPass.Location = new System.Drawing.Point(1279, 302);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(27, 24);
            this.btnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowPass.TabIndex = 6;
            this.btnShowPass.TabStop = false;
            this.btnShowPass.Zoom = 10;
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.gunaLabel3.Location = new System.Drawing.Point(983, 58);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(217, 92);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "LIFE LINE \r\nUSER LOGIN";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(177)))), ((int)(((byte)(167)))));
            this.gunaLabel2.Location = new System.Drawing.Point(918, 170);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 25);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Username";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(177)))), ((int)(((byte)(167)))));
            this.gunaLabel1.Location = new System.Drawing.Point(918, 261);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 25);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Password";
            // 
            // chkboxRemember
            // 
            this.chkboxRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkboxRemember.BaseColor = System.Drawing.Color.White;
            this.chkboxRemember.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkboxRemember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(169)))));
            this.chkboxRemember.FillColor = System.Drawing.Color.White;
            this.chkboxRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.chkboxRemember.Location = new System.Drawing.Point(923, 354);
            this.chkboxRemember.Name = "chkboxRemember";
            this.chkboxRemember.Size = new System.Drawing.Size(148, 23);
            this.chkboxRemember.TabIndex = 3;
            this.chkboxRemember.Text = "Remember Me";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.btnLogin.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(169)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(963, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(167)))));
            this.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(177)))), ((int)(((byte)(167)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.OnPressedDepth = 20;
            this.btnLogin.Radius = 18;
            this.btnLogin.Size = new System.Drawing.Size(294, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkForgotPW
            // 
            this.lnkForgotPW.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(169)))));
            this.lnkForgotPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkForgotPW.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lnkForgotPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.lnkForgotPW.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkForgotPW.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.lnkForgotPW.Location = new System.Drawing.Point(1107, 354);
            this.lnkForgotPW.Name = "lnkForgotPW";
            this.lnkForgotPW.Size = new System.Drawing.Size(230, 22);
            this.lnkForgotPW.TabIndex = 1;
            this.lnkForgotPW.TabStop = true;
            this.lnkForgotPW.Text = "Forgot Password?";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderSize = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.FocusedForeColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(902, 289);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 20;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(372, 49);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderSize = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(147)))), ((int)(((byte)(165)))));
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(902, 198);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 20;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(372, 49);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.btnClose.IconSize = 2F;
            this.btnClose.Location = new System.Drawing.Point(1265, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(58, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // drg
            // 
            this.drg.TargetControl = this.pnlMain;
            // 
            // animate
            // 
            this.animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.animate.Interval = 500;
            this.animate.TargetControl = this;
            // 
            // cntxtMnuCreateAccount
            // 
            this.cntxtMnuCreateAccount.BackColor = System.Drawing.SystemColors.Control;
            this.cntxtMnuCreateAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtMnuCreateAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forStudentToolStripMenuItem,
            this.forTeacherToolStripMenuItem,
            this.forPrincipalToolStripMenuItem});
            this.cntxtMnuCreateAccount.Name = "cntxtMnuCreateAccount";
            this.cntxtMnuCreateAccount.RenderStyle.ArrowColor = System.Drawing.Color.Transparent;
            this.cntxtMnuCreateAccount.RenderStyle.BorderColor = System.Drawing.Color.Transparent;
            this.cntxtMnuCreateAccount.RenderStyle.ColorTable = null;
            this.cntxtMnuCreateAccount.RenderStyle.RoundedEdges = true;
            this.cntxtMnuCreateAccount.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cntxtMnuCreateAccount.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.cntxtMnuCreateAccount.RenderStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.cntxtMnuCreateAccount.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cntxtMnuCreateAccount.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.cntxtMnuCreateAccount.Size = new System.Drawing.Size(246, 100);
            // 
            // forStudentToolStripMenuItem
            // 
            this.forStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forStudentToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.forStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forStudentToolStripMenuItem.Image")));
            this.forStudentToolStripMenuItem.Name = "forStudentToolStripMenuItem";
            this.forStudentToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.forStudentToolStripMenuItem.Text = "        For student";
            this.forStudentToolStripMenuItem.Click += new System.EventHandler(this.forStudentToolStripMenuItem_Click);
            // 
            // forTeacherToolStripMenuItem
            // 
            this.forTeacherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forTeacherToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.forTeacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forTeacherToolStripMenuItem.Image")));
            this.forTeacherToolStripMenuItem.Name = "forTeacherToolStripMenuItem";
            this.forTeacherToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.forTeacherToolStripMenuItem.Text = "        For Teacher";
            this.forTeacherToolStripMenuItem.Click += new System.EventHandler(this.forTeacherToolStripMenuItem_Click);
            // 
            // forPrincipalToolStripMenuItem
            // 
            this.forPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.forPrincipalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forPrincipalToolStripMenuItem.Image")));
            this.forPrincipalToolStripMenuItem.Name = "forPrincipalToolStripMenuItem";
            this.forPrincipalToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.forPrincipalToolStripMenuItem.Text = "        For principal";
            this.forPrincipalToolStripMenuItem.Click += new System.EventHandler(this.forPrincipalToolStripMenuItem_Click);
            // 
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Interval = 10;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LifeLine.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(23, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(45, 41);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaLabel4.Location = new System.Drawing.Point(74, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(146, 28);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "LIFE LINE V0.1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 789);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlChild.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).EndInit();
            this.cntxtMnuCreateAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaPanel pnlChild;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI.WinForms.GunaDragControl drg;
        private Guna.UI.WinForms.GunaAnimateWindow animate;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnShowPass;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCheckBox chkboxRemember;
        private Guna.UI.WinForms.GunaGradientButton btnLogin;
        private Guna.UI.WinForms.GunaLinkLabel lnkForgotPW;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaContextMenuStrip cntxtMnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem forStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forPrincipalToolStripMenuItem;
        public Guna.UI.WinForms.GunaAdvenceButton btnCreateAcc;
        private System.Windows.Forms.Timer refresh;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}