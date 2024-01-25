namespace WFBai1
{
    partial class FLoginGV
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
            this.gvGvien = new System.Windows.Forms.DataGridView();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.DTPNgayThangNam = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgayThangGV = new System.Windows.Forms.Label();
            this.lblCMNDGV = new System.Windows.Forms.Label();
            this.lblDiaChiGV = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvGvien)).BeginInit();
            this.SuspendLayout();
            // 
            // gvGvien
            // 
            this.gvGvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGvien.Location = new System.Drawing.Point(537, 42);
            this.gvGvien.Name = "gvGvien";
            this.gvGvien.RowHeadersWidth = 51;
            this.gvGvien.RowTemplate.Height = 24;
            this.gvGvien.Size = new System.Drawing.Size(447, 272);
            this.gvGvien.TabIndex = 24;
            this.gvGvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGvien_CellClick);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(428, 363);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(86, 32);
            this.btnSuaGV.TabIndex = 23;
            this.btnSuaGV.Text = "Sua";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(277, 363);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(86, 32);
            this.btnXoaGV.TabIndex = 22;
            this.btnXoaGV.Text = "Xoa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(132, 363);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(86, 32);
            this.btnThemGV.TabIndex = 21;
            this.btnThemGV.Text = "Them";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // DTPNgayThangNam
            // 
            this.DTPNgayThangNam.Location = new System.Drawing.Point(193, 224);
            this.DTPNgayThangNam.Name = "DTPNgayThangNam";
            this.DTPNgayThangNam.Size = new System.Drawing.Size(265, 22);
            this.DTPNgayThangNam.TabIndex = 20;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(193, 170);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(265, 22);
            this.txtCMND.TabIndex = 19;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(193, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(265, 22);
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(193, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(265, 22);
            this.txtHoTen.TabIndex = 17;
            // 
            // lblNgayThangGV
            // 
            this.lblNgayThangGV.AutoSize = true;
            this.lblNgayThangGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThangGV.Location = new System.Drawing.Point(11, 229);
            this.lblNgayThangGV.Name = "lblNgayThangGV";
            this.lblNgayThangGV.Size = new System.Drawing.Size(151, 16);
            this.lblNgayThangGV.TabIndex = 16;
            this.lblNgayThangGV.Text = "Ngay thang nam sinh";
            // 
            // lblCMNDGV
            // 
            this.lblCMNDGV.AutoSize = true;
            this.lblCMNDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNDGV.Location = new System.Drawing.Point(11, 170);
            this.lblCMNDGV.Name = "lblCMNDGV";
            this.lblCMNDGV.Size = new System.Drawing.Size(51, 16);
            this.lblCMNDGV.TabIndex = 15;
            this.lblCMNDGV.Text = "CMND";
            // 
            // lblDiaChiGV
            // 
            this.lblDiaChiGV.AutoSize = true;
            this.lblDiaChiGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiGV.Location = new System.Drawing.Point(11, 109);
            this.lblDiaChiGV.Name = "lblDiaChiGV";
            this.lblDiaChiGV.Size = new System.Drawing.Size(57, 16);
            this.lblDiaChiGV.TabIndex = 14;
            this.lblDiaChiGV.Text = "Dia Chi";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenGV.Location = new System.Drawing.Point(11, 62);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(81, 16);
            this.lblHoTenGV.TabIndex = 13;
            this.lblHoTenGV.Text = "Ho Va Ten";
            // 
            // FLoginGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.gvGvien);
            this.Controls.Add(this.btnSuaGV);
            this.Controls.Add(this.btnXoaGV);
            this.Controls.Add(this.btnThemGV);
            this.Controls.Add(this.DTPNgayThangNam);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgayThangGV);
            this.Controls.Add(this.lblCMNDGV);
            this.Controls.Add(this.lblDiaChiGV);
            this.Controls.Add(this.lblHoTenGV);
            this.Name = "FLoginGV";
            this.Text = "FLoginGV";
            this.Load += new System.EventHandler(this.FLoginGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvGvien;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.DateTimePicker DTPNgayThangNam;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgayThangGV;
        private System.Windows.Forms.Label lblCMNDGV;
        private System.Windows.Forms.Label lblDiaChiGV;
        private System.Windows.Forms.Label lblHoTenGV;
    }
}