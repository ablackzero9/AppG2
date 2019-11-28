namespace AppG2.View
{
    partial class frmQuaTrinhHocTapChiTiet
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
            this.numTuNam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDenNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiHoc = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).BeginInit();
            this.SuspendLayout();
            // 
            // numTuNam
            // 
            this.numTuNam.Location = new System.Drawing.Point(125, 32);
            this.numTuNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numTuNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numTuNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numTuNam.Name = "numTuNam";
            this.numTuNam.Size = new System.Drawing.Size(90, 20);
            this.numTuNam.TabIndex = 0;
            this.numTuNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tu nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Den nam";
            // 
            // numDenNam
            // 
            this.numDenNam.Location = new System.Drawing.Point(125, 62);
            this.numDenNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDenNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numDenNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numDenNam.Name = "numDenNam";
            this.numDenNam.Size = new System.Drawing.Size(90, 20);
            this.numDenNam.TabIndex = 3;
            this.numDenNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Noi hoc";
            // 
            // txtNguoiHoc
            // 
            this.txtNguoiHoc.Location = new System.Drawing.Point(125, 87);
            this.txtNguoiHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNguoiHoc.Multiline = true;
            this.txtNguoiHoc.Name = "txtNguoiHoc";
            this.txtNguoiHoc.Size = new System.Drawing.Size(250, 97);
            this.txtNguoiHoc.TabIndex = 5;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Location = new System.Drawing.Point(357, 188);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(54, 40);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bo qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.Image = global::AppG2.Properties.Resources.add;
            this.btnDongY.Location = new System.Drawing.Point(245, 188);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(108, 40);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Dong y";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.BtnDongY_Click);
            // 
            // frmQuaTrinhHocTapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtNguoiHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDenNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTuNam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuaTrinhHocTapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Them moi/ Chinh sua qua trinh hoc tap";
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTuNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDenNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiHoc;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}