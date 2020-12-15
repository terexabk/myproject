
namespace MyElector
{
    partial class ucCoDong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAnh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaCoDong = new System.Windows.Forms.MaskedTextBox();
            this.txtCMND = new System.Windows.Forms.MaskedTextBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoCPSoHuu = new System.Windows.Forms.TextBox();
            this.picboxCoDong = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnInGiayMoi = new System.Windows.Forms.Button();
            this.btnInPhieuBau = new System.Windows.Forms.Button();
            this.checkboxLaToChuc = new System.Windows.Forms.CheckBox();
            this.grbAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCoDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAnh
            // 
            this.grbAnh.Controls.Add(this.picboxCoDong);
            this.grbAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnh.Location = new System.Drawing.Point(83, 58);
            this.grbAnh.Name = "grbAnh";
            this.grbAnh.Size = new System.Drawing.Size(155, 190);
            this.grbAnh.TabIndex = 0;
            this.grbAnh.TabStop = false;
            this.grbAnh.Text = "Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số CP sở hữu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Là tổ chức:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(405, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(169, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtMaCoDong
            // 
            this.txtMaCoDong.Location = new System.Drawing.Point(405, 121);
            this.txtMaCoDong.Name = "txtMaCoDong";
            this.txtMaCoDong.Size = new System.Drawing.Size(169, 20);
            this.txtMaCoDong.TabIndex = 8;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(405, 163);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(169, 20);
            this.txtCMND.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(405, 204);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(169, 20);
            this.txtNgaySinh.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(747, 81);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(169, 20);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtSoCPSoHuu
            // 
            this.txtSoCPSoHuu.Location = new System.Drawing.Point(747, 121);
            this.txtSoCPSoHuu.Name = "txtSoCPSoHuu";
            this.txtSoCPSoHuu.Size = new System.Drawing.Size(169, 20);
            this.txtSoCPSoHuu.TabIndex = 12;
            // 
            // picboxCoDong
            // 
            this.picboxCoDong.Location = new System.Drawing.Point(20, 35);
            this.picboxCoDong.Name = "picboxCoDong";
            this.picboxCoDong.Size = new System.Drawing.Size(116, 134);
            this.picboxCoDong.TabIndex = 0;
            this.picboxCoDong.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 291);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(437, 291);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnInGiayMoi
            // 
            this.btnInGiayMoi.Location = new System.Drawing.Point(571, 291);
            this.btnInGiayMoi.Name = "btnInGiayMoi";
            this.btnInGiayMoi.Size = new System.Drawing.Size(75, 23);
            this.btnInGiayMoi.TabIndex = 16;
            this.btnInGiayMoi.Text = "In giấy mời";
            this.btnInGiayMoi.UseVisualStyleBackColor = true;
            // 
            // btnInPhieuBau
            // 
            this.btnInPhieuBau.Location = new System.Drawing.Point(702, 291);
            this.btnInPhieuBau.Name = "btnInPhieuBau";
            this.btnInPhieuBau.Size = new System.Drawing.Size(75, 23);
            this.btnInPhieuBau.TabIndex = 17;
            this.btnInPhieuBau.Text = "In phiếu bầu";
            this.btnInPhieuBau.UseVisualStyleBackColor = true;
            // 
            // checkboxLaToChuc
            // 
            this.checkboxLaToChuc.AutoSize = true;
            this.checkboxLaToChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxLaToChuc.Location = new System.Drawing.Point(747, 169);
            this.checkboxLaToChuc.Name = "checkboxLaToChuc";
            this.checkboxLaToChuc.Size = new System.Drawing.Size(15, 14);
            this.checkboxLaToChuc.TabIndex = 18;
            this.checkboxLaToChuc.UseVisualStyleBackColor = true;
            // 
            // ucCoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkboxLaToChuc);
            this.Controls.Add(this.btnInPhieuBau);
            this.Controls.Add(this.btnInGiayMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtSoCPSoHuu);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtMaCoDong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbAnh);
            this.Name = "ucCoDong";
            this.Size = new System.Drawing.Size(984, 529);
            this.Load += new System.EventHandler(this.ucCoDong_Load);
            this.grbAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCoDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picboxCoDong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.MaskedTextBox txtMaCoDong;
        private System.Windows.Forms.MaskedTextBox txtCMND;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtSoCPSoHuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnInGiayMoi;
        private System.Windows.Forms.Button btnInPhieuBau;
        private System.Windows.Forms.CheckBox checkboxLaToChuc;
    }
}
