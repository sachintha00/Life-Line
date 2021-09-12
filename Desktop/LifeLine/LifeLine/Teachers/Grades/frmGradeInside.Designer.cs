namespace LifeLine
{
    partial class frmGradeInside
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
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradeInside));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.trnsLoad = new Guna.UI2.WinForms.Guna2Transition();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkLblNotes = new Guna.UI.WinForms.GunaLinkLabel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkLblAssignment = new Guna.UI.WinForms.GunaLinkLabel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAssignment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtAssSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.animateSetting = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.st_assignment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).BeginInit();
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.trnsLoad.DefaultAnimation = animation5;
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
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.gunaLabel7);
            this.guna2Panel1.Controls.Add(this.gunaLabel4);
            this.guna2Panel1.Controls.Add(this.gunaLabel5);
            this.guna2Panel1.Controls.Add(this.guna2Panel6);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Controls.Add(this.dgvAssignment);
            this.guna2Panel1.Controls.Add(this.txtAssSearch);
            this.trnsLoad.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 273);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1514, 679);
            this.guna2Panel1.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.trnsLoad.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(20, 848);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(744, 63);
            this.gunaLabel3.TabIndex = 24;
            this.gunaLabel3.Text = "Assignments uploaded by students can be downloaded here. Use the search var to ma" +
    "ke it easier, or select the grade from the combo box.";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(15, 776);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(762, 57);
            this.gunaLabel7.TabIndex = 25;
            this.gunaLabel7.Text = "DOWNLOAD STUDENT ASSIGNMENTS\r\n";
            // 
            // gunaLabel4
            // 
            this.trnsLoad.SetDecoration(this.gunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(19, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(744, 63);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Assignments uploaded by students can be downloaded here. Use the search var to ma" +
    "ke it easier, or select the grade from the combo box.";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(14, 28);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(762, 57);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "DOWNLOAD STUDENT ASSIGNMENTS\r\n";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel6.Controls.Add(this.label7);
            this.guna2Panel6.Controls.Add(this.lnkLblNotes);
            this.guna2Panel6.Controls.Add(this.guna2Panel7);
            this.trnsLoad.SetDecoration(this.guna2Panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel6.Location = new System.Drawing.Point(654, 970);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(431, 420);
            this.guna2Panel6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(123, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "to begin the upload";
            // 
            // lnkLblNotes
            // 
            this.lnkLblNotes.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblNotes.AutoSize = true;
            this.trnsLoad.SetDecoration(this.lnkLblNotes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnkLblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lnkLblNotes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblNotes.Location = new System.Drawing.Point(167, 258);
            this.lnkLblNotes.Name = "lnkLblNotes";
            this.lnkLblNotes.Size = new System.Drawing.Size(81, 28);
            this.lnkLblNotes.TabIndex = 1;
            this.lnkLblNotes.TabStop = true;
            this.lnkLblNotes.Text = "Browse";
            this.lnkLblNotes.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblNotes_LinkClicked);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel7.Controls.Add(this.label8);
            this.guna2Panel7.Controls.Add(this.label9);
            this.trnsLoad.SetDecoration(this.guna2Panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(431, 136);
            this.guna2Panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.trnsLoad.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "You can search and upload your notes here";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Note Upload";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.lnkLblAssignment);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.trnsLoad.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel4.Location = new System.Drawing.Point(34, 970);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(431, 420);
            this.guna2Panel4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(123, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "to begin the upload";
            // 
            // lnkLblAssignment
            // 
            this.lnkLblAssignment.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblAssignment.AutoSize = true;
            this.trnsLoad.SetDecoration(this.lnkLblAssignment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnkLblAssignment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lnkLblAssignment.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblAssignment.Location = new System.Drawing.Point(167, 258);
            this.lnkLblAssignment.Name = "lnkLblAssignment";
            this.lnkLblAssignment.Size = new System.Drawing.Size(81, 28);
            this.lnkLblAssignment.TabIndex = 1;
            this.lnkLblAssignment.TabStop = true;
            this.lnkLblAssignment.Text = "Browse";
            this.lnkLblAssignment.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkLblAssignment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblAssignment_LinkClicked);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.Controls.Add(this.label6);
            this.trnsLoad.SetDecoration(this.guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(431, 136);
            this.guna2Panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.trnsLoad.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "You can search and upload your assginments here";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Assignment Upload";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(1094, 1531);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 17;
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.AllowUserToAddRows = false;
            this.dgvAssignment.AllowUserToDeleteRows = false;
            this.dgvAssignment.AllowUserToResizeColumns = false;
            this.dgvAssignment.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAssignment.ColumnHeadersHeight = 60;
            this.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.st_assignment_id,
            this.grade,
            this.student_ID});
            this.dgvAssignment.Cursor = System.Windows.Forms.Cursors.Default;
            this.trnsLoad.SetDecoration(this.dgvAssignment, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignment.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAssignment.EnableHeadersVisualStyles = false;
            this.dgvAssignment.GridColor = System.Drawing.Color.White;
            this.dgvAssignment.Location = new System.Drawing.Point(24, 244);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(179)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignment.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvAssignment.RowHeadersVisible = false;
            this.dgvAssignment.RowHeadersWidth = 51;
            this.dgvAssignment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAssignment.RowTemplate.Height = 50;
            this.dgvAssignment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAssignment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignment.Size = new System.Drawing.Size(1239, 413);
            this.dgvAssignment.TabIndex = 16;
            this.dgvAssignment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.dgvAssignment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvAssignment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignment.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvAssignment.ThemeStyle.ReadOnly = true;
            this.dgvAssignment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvAssignment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvAssignment.ThemeStyle.RowsStyle.Height = 50;
            this.dgvAssignment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dgvAssignment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignment_CellClick);
            // 
            // txtAssSearch
            // 
            this.txtAssSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtAssSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.txtAssSearch.BorderRadius = 5;
            this.txtAssSearch.BorderThickness = 2;
            this.txtAssSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trnsLoad.SetDecoration(this.txtAssSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAssSearch.DefaultText = "";
            this.txtAssSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAssSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAssSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssSearch.DisabledState.Parent = this.txtAssSearch;
            this.txtAssSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.txtAssSearch.FocusedState.Parent = this.txtAssSearch;
            this.txtAssSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtAssSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.txtAssSearch.HoverState.Parent = this.txtAssSearch;
            this.txtAssSearch.IconLeft = global::LifeLine.Properties.Resources.icons8_search_208px;
            this.txtAssSearch.IconLeftSize = new System.Drawing.Size(26, 26);
            this.txtAssSearch.Location = new System.Drawing.Point(24, 180);
            this.txtAssSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssSearch.Name = "txtAssSearch";
            this.txtAssSearch.PasswordChar = '\0';
            this.txtAssSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAssSearch.PlaceholderText = "Search";
            this.txtAssSearch.SelectedText = "";
            this.txtAssSearch.ShadowDecoration.Depth = 2;
            this.txtAssSearch.ShadowDecoration.Enabled = true;
            this.txtAssSearch.ShadowDecoration.Parent = this.txtAssSearch;
            this.txtAssSearch.Size = new System.Drawing.Size(425, 44);
            this.txtAssSearch.TabIndex = 15;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.gunaLabel6.Location = new System.Drawing.Point(25, 52);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(636, 62);
            this.gunaLabel6.TabIndex = 22;
            this.gunaLabel6.Text = "ASSIGNMENTS AND NOTES ";
            // 
            // gunaLabel2
            // 
            this.trnsLoad.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(31, 128);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(744, 63);
            this.gunaLabel2.TabIndex = 23;
            this.gunaLabel2.Text = "It allows you to upload and download all the items and subject notes related to y" +
    "our subjects";
            // 
            // animateSetting
            // 
            this.animateSetting.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animateSetting.Interval = 700;
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Download";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "Download";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // st_assignment_id
            // 
            this.st_assignment_id.DataPropertyName = "st_assignment_id";
            this.st_assignment_id.HeaderText = "Assignment No";
            this.st_assignment_id.MinimumWidth = 6;
            this.st_assignment_id.Name = "st_assignment_id";
            this.st_assignment_id.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // student_ID
            // 
            this.student_ID.DataPropertyName = "student_ID";
            this.student_ID.HeaderText = "Student ID";
            this.student_ID.MinimumWidth = 6;
            this.student_ID.Name = "student_ID";
            this.student_ID.ReadOnly = true;
            // 
            // frmGradeInside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 1020);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaControlBox1);
            this.trnsLoad.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradeInside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6StudentDash";
            this.Load += new System.EventHandler(this.frmGrade6Maths_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Transition trnsLoad;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateSetting;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtAssSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAssignment;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLinkLabel lnkLblNotes;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLinkLabel lnkLblAssignment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_assignment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_ID;
    }
}