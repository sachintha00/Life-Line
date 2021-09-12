namespace LifeLine
{
    partial class frmGrade12TO13SubjectInside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrade12TO13SubjectInside));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.trnsLoad = new Guna.UI2.WinForms.Guna2Transition();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkUpload = new Guna.UI.WinForms.GunaLinkLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvNote = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teach_note_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssignment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teach_assignment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoteSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAssSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.animateSetting = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
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
            this.guna2Panel1.Controls.Add(this.gunaLabel4);
            this.guna2Panel1.Controls.Add(this.gunaLabel5);
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Controls.Add(this.dgvNote);
            this.guna2Panel1.Controls.Add(this.dgvAssignment);
            this.guna2Panel1.Controls.Add(this.txtNoteSearch);
            this.guna2Panel1.Controls.Add(this.txtAssSearch);
            this.trnsLoad.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 312);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1514, 623);
            this.guna2Panel1.TabIndex = 8;
            // 
            // gunaLabel4
            // 
            this.trnsLoad.SetDecoration(this.gunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(19, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(794, 63);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Download your class assignments from this  table when you want. You can use the s" +
    "earch bar to make it even easier";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(14, 28);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(565, 57);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "PREFER YOUR ASSIGNMENT";
            // 
            // gunaLabel3
            // 
            this.trnsLoad.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(19, 806);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(726, 82);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "Download your class Notes  from this  table when you want. You can use the search" +
    " bar to make it even easier";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(14, 734);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(432, 57);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "PREFER YOUR NOTES";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.lnkUpload);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.trnsLoad.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(1084, 244);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(379, 335);
            this.guna2Panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(105, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "to begin the upload";
            // 
            // lnkUpload
            // 
            this.lnkUpload.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkUpload.AutoSize = true;
            this.trnsLoad.SetDecoration(this.lnkUpload, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnkUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lnkUpload.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkUpload.Location = new System.Drawing.Point(147, 217);
            this.lnkUpload.Name = "lnkUpload";
            this.lnkUpload.Size = new System.Drawing.Size(81, 28);
            this.lnkUpload.TabIndex = 1;
            this.lnkUpload.TabStop = true;
            this.lnkUpload.Text = "Browse";
            this.lnkUpload.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.lnkUpload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpload_LinkClicked_1);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.trnsLoad.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.guna2Panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(379, 136);
            this.guna2Panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.trnsLoad.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "You can search and upload your assginments here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.trnsLoad.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignment Upload";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.trnsLoad.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(1094, 1461);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 17;
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.AllowUserToDeleteRows = false;
            this.dgvNote.AllowUserToResizeColumns = false;
            this.dgvNote.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNote.BackgroundColor = System.Drawing.Color.White;
            this.dgvNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNote.ColumnHeadersHeight = 60;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1,
            this.teach_note_id,
            this.noteName});
            this.dgvNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.trnsLoad.SetDecoration(this.dgvNote, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNote.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNote.EnableHeadersVisualStyles = false;
            this.dgvNote.GridColor = System.Drawing.Color.White;
            this.dgvNote.Location = new System.Drawing.Point(18, 998);
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(179)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNote.RowHeadersVisible = false;
            this.dgvNote.RowHeadersWidth = 51;
            this.dgvNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNote.RowTemplate.Height = 50;
            this.dgvNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNote.Size = new System.Drawing.Size(1029, 413);
            this.dgvNote.TabIndex = 16;
            this.dgvNote.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvNote.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNote.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNote.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNote.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNote.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNote.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNote.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvNote.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.dgvNote.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNote.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvNote.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNote.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNote.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvNote.ThemeStyle.ReadOnly = true;
            this.dgvNote.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNote.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNote.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvNote.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvNote.ThemeStyle.RowsStyle.Height = 50;
            this.dgvNote.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dgvNote.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gray;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.FillWeight = 10F;
            this.dataGridViewLinkColumn1.HeaderText = "";
            this.dataGridViewLinkColumn1.MinimumWidth = 3;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // teach_note_id
            // 
            this.teach_note_id.DataPropertyName = "teach_note_id ";
            this.teach_note_id.FillWeight = 109.8931F;
            this.teach_note_id.HeaderText = "Note No";
            this.teach_note_id.MinimumWidth = 6;
            this.teach_note_id.Name = "teach_note_id";
            this.teach_note_id.ReadOnly = true;
            // 
            // noteName
            // 
            this.noteName.DataPropertyName = "noteName";
            this.noteName.FillWeight = 109.8931F;
            this.noteName.HeaderText = "Note";
            this.noteName.MinimumWidth = 6;
            this.noteName.Name = "noteName";
            this.noteName.ReadOnly = true;
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.AllowUserToAddRows = false;
            this.dgvAssignment.AllowUserToDeleteRows = false;
            this.dgvAssignment.AllowUserToResizeColumns = false;
            this.dgvAssignment.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssignment.ColumnHeadersHeight = 60;
            this.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.teach_assignment_id,
            this.file_name});
            this.dgvAssignment.Cursor = System.Windows.Forms.Cursors.Default;
            this.trnsLoad.SetDecoration(this.dgvAssignment, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignment.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssignment.EnableHeadersVisualStyles = false;
            this.dgvAssignment.GridColor = System.Drawing.Color.White;
            this.dgvAssignment.Location = new System.Drawing.Point(24, 244);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(179)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignment.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAssignment.RowHeadersVisible = false;
            this.dgvAssignment.RowHeadersWidth = 51;
            this.dgvAssignment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAssignment.RowTemplate.Height = 50;
            this.dgvAssignment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAssignment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignment.Size = new System.Drawing.Size(1029, 413);
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
            // Column1
            // 
            this.Column1.HeaderText = "Download";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // teach_assignment_id
            // 
            this.teach_assignment_id.DataPropertyName = "teach_assignment_id";
            this.teach_assignment_id.HeaderText = "Assignment No";
            this.teach_assignment_id.MinimumWidth = 6;
            this.teach_assignment_id.Name = "teach_assignment_id";
            this.teach_assignment_id.ReadOnly = true;
            // 
            // file_name
            // 
            this.file_name.DataPropertyName = "file_name";
            this.file_name.HeaderText = "Assignment Name";
            this.file_name.MinimumWidth = 6;
            this.file_name.Name = "file_name";
            this.file_name.ReadOnly = true;
            // 
            // txtNoteSearch
            // 
            this.txtNoteSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtNoteSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.txtNoteSearch.BorderRadius = 5;
            this.txtNoteSearch.BorderThickness = 2;
            this.txtNoteSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trnsLoad.SetDecoration(this.txtNoteSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtNoteSearch.DefaultText = "";
            this.txtNoteSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoteSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoteSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoteSearch.DisabledState.Parent = this.txtNoteSearch;
            this.txtNoteSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoteSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.txtNoteSearch.FocusedState.Parent = this.txtNoteSearch;
            this.txtNoteSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtNoteSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.txtNoteSearch.HoverState.Parent = this.txtNoteSearch;
            this.txtNoteSearch.IconLeft = global::LifeLine.Properties.Resources.icons8_search_208px;
            this.txtNoteSearch.IconLeftSize = new System.Drawing.Size(26, 26);
            this.txtNoteSearch.Location = new System.Drawing.Point(24, 932);
            this.txtNoteSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoteSearch.Name = "txtNoteSearch";
            this.txtNoteSearch.PasswordChar = '\0';
            this.txtNoteSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNoteSearch.PlaceholderText = "Search";
            this.txtNoteSearch.SelectedText = "";
            this.txtNoteSearch.ShadowDecoration.Depth = 2;
            this.txtNoteSearch.ShadowDecoration.Enabled = true;
            this.txtNoteSearch.ShadowDecoration.Parent = this.txtNoteSearch;
            this.txtNoteSearch.Size = new System.Drawing.Size(425, 44);
            this.txtNoteSearch.TabIndex = 15;
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
            this.gunaLabel6.Location = new System.Drawing.Point(25, 43);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(597, 62);
            this.gunaLabel6.TabIndex = 23;
            this.gunaLabel6.Text = "NOTES AND ASSIGNMENS";
            // 
            // animateSetting
            // 
            this.animateSetting.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animateSetting.Interval = 700;
            // 
            // frmGrade12TO13SubjectInside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 1020);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.trnsLoad.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrade12TO13SubjectInside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade6StudentDash";
            this.Load += new System.EventHandler(this.frmGrade6Maths_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvNote;
        private Guna.UI2.WinForms.Guna2TextBox txtNoteSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaLinkLabel lnkUpload;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teach_assignment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teach_note_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Label label3;
    }
}