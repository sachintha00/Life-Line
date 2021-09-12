namespace LifeLine.QR
{
    partial class frmQRcamSelection
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
            this.elips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.cmbSelectCamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(565, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(82, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSelectCamera
            // 
            this.cmbSelectCamera.BackColor = System.Drawing.Color.Transparent;
            this.cmbSelectCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelectCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCamera.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSelectCamera.FocusedState.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSelectCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSelectCamera.FormattingEnabled = true;
            this.cmbSelectCamera.HoverState.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.ItemHeight = 30;
            this.cmbSelectCamera.ItemsAppearance.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Location = new System.Drawing.Point(180, 243);
            this.cmbSelectCamera.Name = "cmbSelectCamera";
            this.cmbSelectCamera.ShadowDecoration.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Size = new System.Drawing.Size(285, 36);
            this.cmbSelectCamera.TabIndex = 2;
            this.cmbSelectCamera.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCamera_SelectedIndexChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHOOSE A CAMERA";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(177, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "You can use the webcam on the computer or even an external webcam. Below you can " +
    "select the camera you want to use.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LifeLine.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(82, 90);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(73, 69);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmQRcamSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 367);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectCamera);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQRcamSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQRscanner";
            this.Load += new System.EventHandler(this.frmQRscanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elips;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSelectCamera;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}