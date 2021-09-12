namespace LifeLine
{
    partial class frmALselectionSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmALselectionSubject));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.trnsLoad = new Guna.UI2.WinForms.Guna2Transition();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnSubmit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.animateSetting = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.trnsStudent = new Guna.UI2.WinForms.Guna2Transition();
            this.chckMaths = new Guna.UI.WinForms.GunaRadioButton();
            this.chckBio = new Guna.UI.WinForms.GunaRadioButton();
            this.chckArts = new Guna.UI.WinForms.GunaRadioButton();
            this.chckCommerce = new Guna.UI.WinForms.GunaRadioButton();
            this.chckTech = new Guna.UI.WinForms.GunaRadioButton();
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
            animation1.TransparencyCoeff = 0F;
            this.trnsLoad.DefaultAnimation = animation1;
            this.trnsLoad.MaxAnimationTime = 700;
            this.trnsLoad.TimeStep = 0.03F;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(94, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(390, 120);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "SELECT YOUR A/L\r\nSUBJECT\r\n";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(232, 207);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "gunaLabel1";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSubmit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.CheckedForeColor = System.Drawing.Color.White;
            this.btnSubmit.CheckedImage = null;
            this.btnSubmit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trnsStudent.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("DINPro-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSubmit.Location = new System.Drawing.Point(204, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSubmit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnSubmit.OnPressedDepth = 50;
            this.btnSubmit.Radius = 5;
            this.btnSubmit.Size = new System.Drawing.Size(183, 57);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // animateSetting
            // 
            this.animateSetting.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.animateSetting.Interval = 700;
            // 
            // trnsStudent
            // 
            this.trnsStudent.Cursor = null;
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
            this.trnsStudent.DefaultAnimation = animation2;
            // 
            // chckMaths
            // 
            this.chckMaths.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckMaths.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckMaths.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.trnsLoad.SetDecoration(this.chckMaths, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsStudent.SetDecoration(this.chckMaths, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chckMaths.FillColor = System.Drawing.Color.White;
            this.chckMaths.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckMaths.ForeColor = System.Drawing.Color.DimGray;
            this.chckMaths.Location = new System.Drawing.Point(210, 284);
            this.chckMaths.Name = "chckMaths";
            this.chckMaths.Size = new System.Drawing.Size(126, 35);
            this.chckMaths.TabIndex = 22;
            this.chckMaths.Text = "MATHS";
            // 
            // chckBio
            // 
            this.chckBio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckBio.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckBio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.trnsLoad.SetDecoration(this.chckBio, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsStudent.SetDecoration(this.chckBio, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chckBio.FillColor = System.Drawing.Color.White;
            this.chckBio.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBio.ForeColor = System.Drawing.Color.DimGray;
            this.chckBio.Location = new System.Drawing.Point(210, 341);
            this.chckBio.Name = "chckBio";
            this.chckBio.Size = new System.Drawing.Size(144, 35);
            this.chckBio.TabIndex = 22;
            this.chckBio.Text = "BIOLOGY";
            // 
            // chckArts
            // 
            this.chckArts.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckArts.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckArts.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.trnsLoad.SetDecoration(this.chckArts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsStudent.SetDecoration(this.chckArts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chckArts.FillColor = System.Drawing.Color.White;
            this.chckArts.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckArts.ForeColor = System.Drawing.Color.DimGray;
            this.chckArts.Location = new System.Drawing.Point(210, 398);
            this.chckArts.Name = "chckArts";
            this.chckArts.Size = new System.Drawing.Size(101, 35);
            this.chckArts.TabIndex = 22;
            this.chckArts.Text = "ARTS";
            // 
            // chckCommerce
            // 
            this.chckCommerce.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckCommerce.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckCommerce.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.trnsLoad.SetDecoration(this.chckCommerce, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsStudent.SetDecoration(this.chckCommerce, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chckCommerce.FillColor = System.Drawing.Color.White;
            this.chckCommerce.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckCommerce.ForeColor = System.Drawing.Color.DimGray;
            this.chckCommerce.Location = new System.Drawing.Point(210, 455);
            this.chckCommerce.Name = "chckCommerce";
            this.chckCommerce.Size = new System.Drawing.Size(180, 35);
            this.chckCommerce.TabIndex = 22;
            this.chckCommerce.Text = "COMMERCE";
            // 
            // chckTech
            // 
            this.chckTech.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckTech.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.chckTech.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.trnsLoad.SetDecoration(this.chckTech, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsStudent.SetDecoration(this.chckTech, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chckTech.FillColor = System.Drawing.Color.White;
            this.chckTech.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTech.ForeColor = System.Drawing.Color.DimGray;
            this.chckTech.Location = new System.Drawing.Point(210, 512);
            this.chckTech.Name = "chckTech";
            this.chckTech.Size = new System.Drawing.Size(206, 35);
            this.chckTech.TabIndex = 22;
            this.chckTech.Text = "TECHNOLOGY";
            // 
            // frmALselectionSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 753);
            this.Controls.Add(this.chckTech);
            this.Controls.Add(this.chckCommerce);
            this.Controls.Add(this.chckArts);
            this.Controls.Add(this.chckBio);
            this.Controls.Add(this.chckMaths);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.trnsStudent.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmALselectionSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6StudentDash";
            this.Load += new System.EventHandler(this.frmGrade6Maths_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Transition trnsLoad;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateSetting;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSubmit;
        private Guna.UI2.WinForms.Guna2Transition trnsStudent;
        private Guna.UI.WinForms.GunaRadioButton chckMaths;
        private Guna.UI.WinForms.GunaRadioButton chckTech;
        private Guna.UI.WinForms.GunaRadioButton chckCommerce;
        private Guna.UI.WinForms.GunaRadioButton chckArts;
        private Guna.UI.WinForms.GunaRadioButton chckBio;
    }
}