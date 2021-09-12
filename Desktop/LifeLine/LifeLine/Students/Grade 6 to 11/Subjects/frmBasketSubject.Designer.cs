namespace LifeLine
{
    partial class frmBasketSubject
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
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasketSubject));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.trnsLoad = new Guna.UI2.WinForms.Guna2Transition();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pnl1st = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnNext1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmb1stBasket = new Guna.UI.WinForms.GunaComboBox();
            this.pnl2nd = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnNext2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmb2ndBasket = new Guna.UI.WinForms.GunaComboBox();
            this.pnl3rd = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnSubmit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmb3rdBasket = new Guna.UI.WinForms.GunaComboBox();
            this.animateSetting = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.trnsStudent = new Guna.UI2.WinForms.Guna2Transition();
            this.pnl1st.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.pnl2nd.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnl3rd.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.trnsLoad.DefaultAnimation = animation4;
            this.trnsLoad.MaxAnimationTime = 700;
            this.trnsLoad.TimeStep = 0.03F;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gunaLabel1.Location = new System.Drawing.Point(50, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(478, 120);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "SELECT YOUR BASKET\r\nSUBJECT\r\n";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.trnsStudent.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(59, 176);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(465, 79);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "In addition to the 6 main subjects, you can choose some of your favourite subject" +
    "s elow. Choose one subject from each selection";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1st
            // 
            this.pnl1st.Controls.Add(this.guna2Panel3);
            this.pnl1st.Controls.Add(this.btnNext1);
            this.pnl1st.Controls.Add(this.cmb1stBasket);
            this.trnsStudent.SetDecoration(this.pnl1st, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.pnl1st, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl1st.Location = new System.Drawing.Point(46, 288);
            this.pnl1st.Name = "pnl1st";
            this.pnl1st.ShadowDecoration.Parent = this.pnl1st;
            this.pnl1st.Size = new System.Drawing.Size(493, 421);
            this.pnl1st.TabIndex = 11;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.guna2Panel3.Controls.Add(this.gunaLabel3);
            this.trnsStudent.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(493, 149);
            this.guna2Panel3.TabIndex = 22;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(45, 34);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(393, 92);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "SELECT YOUR BASKET 1 \r\nSUBJECT";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext1
            // 
            this.btnNext1.AnimationHoverSpeed = 0.07F;
            this.btnNext1.AnimationSpeed = 0.03F;
            this.btnNext1.BackColor = System.Drawing.Color.Transparent;
            this.btnNext1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.btnNext1.BorderColor = System.Drawing.Color.Black;
            this.btnNext1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNext1.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNext1.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext1.CheckedImage = null;
            this.btnNext1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trnsStudent.SetDecoration(this.btnNext1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.btnNext1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext1.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext1.Font = new System.Drawing.Font("DINPro-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Image = null;
            this.btnNext1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext1.Location = new System.Drawing.Point(142, 341);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnNext1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext1.OnHoverImage = null;
            this.btnNext1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnNext1.OnPressedDepth = 50;
            this.btnNext1.Radius = 5;
            this.btnNext1.Size = new System.Drawing.Size(183, 57);
            this.btnNext1.TabIndex = 21;
            this.btnNext1.Text = "Next";
            this.btnNext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // cmb1stBasket
            // 
            this.cmb1stBasket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb1stBasket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb1stBasket.BackColor = System.Drawing.Color.Transparent;
            this.cmb1stBasket.BaseColor = System.Drawing.Color.White;
            this.cmb1stBasket.BorderColor = System.Drawing.Color.Silver;
            this.trnsStudent.SetDecoration(this.cmb1stBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.cmb1stBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb1stBasket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb1stBasket.DropDownHeight = 90;
            this.cmb1stBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1stBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb1stBasket.FocusedColor = System.Drawing.Color.Empty;
            this.cmb1stBasket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb1stBasket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb1stBasket.FormattingEnabled = true;
            this.cmb1stBasket.IntegralHeight = false;
            this.cmb1stBasket.Location = new System.Drawing.Point(111, 215);
            this.cmb1stBasket.Name = "cmb1stBasket";
            this.cmb1stBasket.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb1stBasket.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb1stBasket.Size = new System.Drawing.Size(243, 31);
            this.cmb1stBasket.TabIndex = 15;
            this.cmb1stBasket.SelectedIndexChanged += new System.EventHandler(this.cmb1stBasket_SelectedIndexChanged);
            // 
            // pnl2nd
            // 
            this.pnl2nd.Controls.Add(this.guna2Panel2);
            this.pnl2nd.Controls.Add(this.btnNext2);
            this.pnl2nd.Controls.Add(this.cmb2ndBasket);
            this.trnsStudent.SetDecoration(this.pnl2nd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.pnl2nd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl2nd.Location = new System.Drawing.Point(46, 288);
            this.pnl2nd.Name = "pnl2nd";
            this.pnl2nd.ShadowDecoration.Parent = this.pnl2nd;
            this.pnl2nd.Size = new System.Drawing.Size(493, 421);
            this.pnl2nd.TabIndex = 16;
            this.pnl2nd.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.guna2Panel2.Controls.Add(this.gunaLabel4);
            this.trnsStudent.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(493, 149);
            this.guna2Panel2.TabIndex = 22;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(45, 34);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(398, 92);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "SELECT YOUR BASKET 2 \r\nSUBJECT";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext2
            // 
            this.btnNext2.AnimationHoverSpeed = 0.07F;
            this.btnNext2.AnimationSpeed = 0.03F;
            this.btnNext2.BackColor = System.Drawing.Color.Transparent;
            this.btnNext2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.btnNext2.BorderColor = System.Drawing.Color.Black;
            this.btnNext2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNext2.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNext2.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext2.CheckedImage = null;
            this.btnNext2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trnsStudent.SetDecoration(this.btnNext2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.btnNext2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext2.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext2.Font = new System.Drawing.Font("DINPro-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.Image = null;
            this.btnNext2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext2.Location = new System.Drawing.Point(142, 341);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnNext2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext2.OnHoverImage = null;
            this.btnNext2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.btnNext2.OnPressedDepth = 50;
            this.btnNext2.Radius = 5;
            this.btnNext2.Size = new System.Drawing.Size(183, 57);
            this.btnNext2.TabIndex = 21;
            this.btnNext2.Text = "Next";
            this.btnNext2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // cmb2ndBasket
            // 
            this.cmb2ndBasket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb2ndBasket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb2ndBasket.BackColor = System.Drawing.Color.Transparent;
            this.cmb2ndBasket.BaseColor = System.Drawing.Color.White;
            this.cmb2ndBasket.BorderColor = System.Drawing.Color.Silver;
            this.trnsStudent.SetDecoration(this.cmb2ndBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.cmb2ndBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb2ndBasket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb2ndBasket.DropDownHeight = 90;
            this.cmb2ndBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2ndBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb2ndBasket.FocusedColor = System.Drawing.Color.Empty;
            this.cmb2ndBasket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb2ndBasket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb2ndBasket.FormattingEnabled = true;
            this.cmb2ndBasket.IntegralHeight = false;
            this.cmb2ndBasket.Location = new System.Drawing.Point(111, 215);
            this.cmb2ndBasket.Name = "cmb2ndBasket";
            this.cmb2ndBasket.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb2ndBasket.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb2ndBasket.Size = new System.Drawing.Size(243, 31);
            this.cmb2ndBasket.TabIndex = 18;
            this.cmb2ndBasket.SelectedIndexChanged += new System.EventHandler(this.cmb2ndBasket_SelectedIndexChanged);
            // 
            // pnl3rd
            // 
            this.pnl3rd.Controls.Add(this.guna2Panel1);
            this.pnl3rd.Controls.Add(this.btnSubmit);
            this.pnl3rd.Controls.Add(this.cmb3rdBasket);
            this.trnsStudent.SetDecoration(this.pnl3rd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.pnl3rd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl3rd.Location = new System.Drawing.Point(46, 288);
            this.pnl3rd.Name = "pnl3rd";
            this.pnl3rd.ShadowDecoration.Parent = this.pnl3rd;
            this.pnl3rd.Size = new System.Drawing.Size(493, 421);
            this.pnl3rd.TabIndex = 19;
            this.pnl3rd.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(188)))));
            this.guna2Panel1.Controls.Add(this.gunaLabel5);
            this.trnsStudent.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(493, 149);
            this.guna2Panel1.TabIndex = 21;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.trnsStudent.SetDecoration(this.gunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.gunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(45, 34);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(398, 92);
            this.gunaLabel5.TabIndex = 18;
            this.gunaLabel5.Text = "SELECT YOUR BASKET 3 \r\nSUBJECT";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSubmit.Location = new System.Drawing.Point(142, 341);
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
            // cmb3rdBasket
            // 
            this.cmb3rdBasket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb3rdBasket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb3rdBasket.BackColor = System.Drawing.Color.Transparent;
            this.cmb3rdBasket.BaseColor = System.Drawing.Color.White;
            this.cmb3rdBasket.BorderColor = System.Drawing.Color.Silver;
            this.trnsStudent.SetDecoration(this.cmb3rdBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this.cmb3rdBasket, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb3rdBasket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb3rdBasket.DropDownHeight = 90;
            this.cmb3rdBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3rdBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb3rdBasket.FocusedColor = System.Drawing.Color.Empty;
            this.cmb3rdBasket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb3rdBasket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb3rdBasket.FormattingEnabled = true;
            this.cmb3rdBasket.IntegralHeight = false;
            this.cmb3rdBasket.Location = new System.Drawing.Point(111, 215);
            this.cmb3rdBasket.Name = "cmb3rdBasket";
            this.cmb3rdBasket.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb3rdBasket.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb3rdBasket.Size = new System.Drawing.Size(240, 31);
            this.cmb3rdBasket.TabIndex = 19;
            this.cmb3rdBasket.SelectedIndexChanged += new System.EventHandler(this.cmb3rdBasket_SelectedIndexChanged);
            // 
            // animateSetting
            // 
            this.animateSetting.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.animateSetting.Interval = 700;
            // 
            // trnsStudent
            // 
            this.trnsStudent.Cursor = null;
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
            this.trnsStudent.DefaultAnimation = animation3;
            // 
            // frmBasketSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 753);
            this.Controls.Add(this.pnl3rd);
            this.Controls.Add(this.pnl2nd);
            this.Controls.Add(this.pnl1st);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.trnsStudent.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trnsLoad.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBasketSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6StudentDash";
            this.Load += new System.EventHandler(this.frmGrade6Maths_Load);
            this.pnl1st.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.pnl2nd.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.pnl3rd.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Transition trnsLoad;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateSetting;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnl3rd;
        private Guna.UI.WinForms.GunaComboBox cmb3rdBasket;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2Panel pnl2nd;
        private Guna.UI.WinForms.GunaComboBox cmb2ndBasket;
        private Guna.UI2.WinForms.Guna2Panel pnl1st;
        private Guna.UI.WinForms.GunaComboBox cmb1stBasket;
        private Guna.UI.WinForms.GunaAdvenceButton btnSubmit;
        private Guna.UI.WinForms.GunaAdvenceButton btnNext2;
        private Guna.UI.WinForms.GunaAdvenceButton btnNext1;
        private Guna.UI2.WinForms.Guna2Transition trnsStudent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}