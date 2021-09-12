namespace LifeLine
{
    partial class frmAuthentication
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthentication));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grbOld = new System.Windows.Forms.GroupBox();
            this.lblOldPw = new Guna.UI.WinForms.GunaLabel();
            this.txtOldPassword = new Guna.UI.WinForms.GunaTextBox();
            this.btnShwOldPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblOld = new Guna.UI.WinForms.GunaLabel();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.lblComPassword = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.btnShwComfirmPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShwNewPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNewPw = new Guna.UI.WinForms.GunaLabel();
            this.lblUsername = new Guna.UI.WinForms.GunaLabel();
            this.txtCofirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.lblComPw = new Guna.UI.WinForms.GunaLabel();
            this.txtNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.transAuthenticaion = new Guna.UI2.WinForms.Guna2Transition();
            this.grbOld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwOldPassword)).BeginInit();
            this.grbNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwComfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // grbOld
            // 
            this.grbOld.Controls.Add(this.lblOldPw);
            this.grbOld.Controls.Add(this.txtOldPassword);
            this.grbOld.Controls.Add(this.btnShwOldPassword);
            this.grbOld.Controls.Add(this.lblOld);
            this.transAuthenticaion.SetDecoration(this.grbOld, Guna.UI2.AnimatorNS.DecorationType.None);
            this.grbOld.Location = new System.Drawing.Point(69, 68);
            this.grbOld.Name = "grbOld";
            this.grbOld.Size = new System.Drawing.Size(505, 155);
            this.grbOld.TabIndex = 0;
            this.grbOld.TabStop = false;
            this.grbOld.Text = "groupBox1";
            // 
            // lblOldPw
            // 
            this.lblOldPw.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblOldPw, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOldPw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOldPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblOldPw.Location = new System.Drawing.Point(27, 108);
            this.lblOldPw.Name = "lblOldPw";
            this.lblOldPw.Size = new System.Drawing.Size(0, 20);
            this.lblOldPw.TabIndex = 21;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BaseColor = System.Drawing.Color.White;
            this.txtOldPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transAuthenticaion.SetDecoration(this.txtOldPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtOldPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOldPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.txtOldPassword.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOldPassword.Location = new System.Drawing.Point(25, 65);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.Size = new System.Drawing.Size(394, 40);
            this.txtOldPassword.TabIndex = 18;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // btnShwOldPassword
            // 
            this.btnShwOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShwOldPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShwOldPassword.BackgroundImage")));
            this.btnShwOldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transAuthenticaion.SetDecoration(this.btnShwOldPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShwOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShwOldPassword.Image")));
            this.btnShwOldPassword.ImageActive = null;
            this.btnShwOldPassword.Location = new System.Drawing.Point(427, 68);
            this.btnShwOldPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShwOldPassword.Name = "btnShwOldPassword";
            this.btnShwOldPassword.Size = new System.Drawing.Size(35, 33);
            this.btnShwOldPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShwOldPassword.TabIndex = 20;
            this.btnShwOldPassword.TabStop = false;
            this.btnShwOldPassword.Zoom = 20;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblOld, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOld.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOld.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOld.Location = new System.Drawing.Point(20, 34);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(140, 28);
            this.lblOld.TabIndex = 14;
            this.lblOld.Text = "Old Password";
            // 
            // grbNew
            // 
            this.grbNew.Controls.Add(this.lblComPassword);
            this.grbNew.Controls.Add(this.btnSave);
            this.grbNew.Controls.Add(this.txtUsername);
            this.grbNew.Controls.Add(this.btnShwComfirmPassword);
            this.grbNew.Controls.Add(this.btnShwNewPassword);
            this.grbNew.Controls.Add(this.lblNewPw);
            this.grbNew.Controls.Add(this.lblUsername);
            this.grbNew.Controls.Add(this.txtCofirmPassword);
            this.grbNew.Controls.Add(this.lblComPw);
            this.grbNew.Controls.Add(this.txtNewPassword);
            this.transAuthenticaion.SetDecoration(this.grbNew, Guna.UI2.AnimatorNS.DecorationType.None);
            this.grbNew.Location = new System.Drawing.Point(69, 243);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(505, 410);
            this.grbNew.TabIndex = 0;
            this.grbNew.TabStop = false;
            this.grbNew.Text = "New";
            // 
            // lblComPassword
            // 
            this.lblComPassword.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblComPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblComPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblComPassword.Location = new System.Drawing.Point(27, 285);
            this.lblComPassword.Name = "lblComPassword";
            this.lblComPassword.Size = new System.Drawing.Size(0, 20);
            this.lblComPassword.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 25;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.transAuthenticaion.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(105, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(246, 61);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transAuthenticaion.SetDecoration(this.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUsername.Enabled = false;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(25, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(394, 40);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // btnShwComfirmPassword
            // 
            this.btnShwComfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShwComfirmPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShwComfirmPassword.BackgroundImage")));
            this.btnShwComfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transAuthenticaion.SetDecoration(this.btnShwComfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShwComfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShwComfirmPassword.Image")));
            this.btnShwComfirmPassword.ImageActive = null;
            this.btnShwComfirmPassword.Location = new System.Drawing.Point(427, 247);
            this.btnShwComfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShwComfirmPassword.Name = "btnShwComfirmPassword";
            this.btnShwComfirmPassword.Size = new System.Drawing.Size(35, 33);
            this.btnShwComfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShwComfirmPassword.TabIndex = 19;
            this.btnShwComfirmPassword.TabStop = false;
            this.btnShwComfirmPassword.Zoom = 20;
            // 
            // btnShwNewPassword
            // 
            this.btnShwNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShwNewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShwNewPassword.BackgroundImage")));
            this.btnShwNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transAuthenticaion.SetDecoration(this.btnShwNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShwNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShwNewPassword.Image")));
            this.btnShwNewPassword.ImageActive = null;
            this.btnShwNewPassword.Location = new System.Drawing.Point(427, 156);
            this.btnShwNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShwNewPassword.Name = "btnShwNewPassword";
            this.btnShwNewPassword.Size = new System.Drawing.Size(35, 33);
            this.btnShwNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShwNewPassword.TabIndex = 21;
            this.btnShwNewPassword.TabStop = false;
            this.btnShwNewPassword.Zoom = 20;
            // 
            // lblNewPw
            // 
            this.lblNewPw.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblNewPw, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNewPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewPw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewPw.Location = new System.Drawing.Point(20, 122);
            this.lblNewPw.Name = "lblNewPw";
            this.lblNewPw.Size = new System.Drawing.Size(150, 28);
            this.lblNewPw.TabIndex = 12;
            this.lblNewPw.Text = "New Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsername.Location = new System.Drawing.Point(20, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 28);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            // 
            // txtCofirmPassword
            // 
            this.txtCofirmPassword.BaseColor = System.Drawing.Color.White;
            this.txtCofirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCofirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transAuthenticaion.SetDecoration(this.txtCofirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCofirmPassword.Enabled = false;
            this.txtCofirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCofirmPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.txtCofirmPassword.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCofirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCofirmPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCofirmPassword.Location = new System.Drawing.Point(25, 242);
            this.txtCofirmPassword.Name = "txtCofirmPassword";
            this.txtCofirmPassword.PasswordChar = '●';
            this.txtCofirmPassword.SelectedText = "";
            this.txtCofirmPassword.Size = new System.Drawing.Size(394, 40);
            this.txtCofirmPassword.TabIndex = 15;
            this.txtCofirmPassword.TextChanged += new System.EventHandler(this.txtCofirmPassword_TextChanged);
            this.txtCofirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCofirmPassword_KeyDown);
            // 
            // lblComPw
            // 
            this.lblComPw.AutoSize = true;
            this.transAuthenticaion.SetDecoration(this.lblComPw, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblComPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblComPw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComPw.Location = new System.Drawing.Point(20, 211);
            this.lblComPw.Name = "lblComPw";
            this.lblComPw.Size = new System.Drawing.Size(189, 28);
            this.lblComPw.TabIndex = 11;
            this.lblComPw.Text = "Comfirm Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transAuthenticaion.SetDecoration(this.txtNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.txtNewPassword.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNewPassword.Location = new System.Drawing.Point(25, 153);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(394, 40);
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // transAuthenticaion
            // 
            this.transAuthenticaion.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.transAuthenticaion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transAuthenticaion.DefaultAnimation = animation1;
            // 
            // frmStudentAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 687);
            this.Controls.Add(this.grbNew);
            this.Controls.Add(this.grbOld);
            this.transAuthenticaion.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentAuthentication";
            this.Text = "frmStudentAuthentication";
            this.Load += new System.EventHandler(this.frmStudentAuthentication_Load);
            this.grbOld.ResumeLayout(false);
            this.grbOld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwOldPassword)).EndInit();
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwComfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.GroupBox grbOld;
        private Bunifu.Framework.UI.BunifuImageButton btnShwComfirmPassword;
        private Guna.UI.WinForms.GunaTextBox txtOldPassword;
        private Bunifu.Framework.UI.BunifuImageButton btnShwOldPassword;
        private Guna.UI.WinForms.GunaLabel lblOld;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtCofirmPassword;
        private Guna.UI.WinForms.GunaTextBox txtNewPassword;
        private Guna.UI.WinForms.GunaLabel lblComPw;
        private Guna.UI.WinForms.GunaLabel lblUsername;
        private Guna.UI.WinForms.GunaLabel lblNewPw;
        private Bunifu.Framework.UI.BunifuImageButton btnShwNewPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2Transition transAuthenticaion;
        private Guna.UI.WinForms.GunaLabel lblOldPw;
        private Guna.UI.WinForms.GunaLabel lblComPassword;
    }
}