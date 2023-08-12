namespace CuoiKy_CSDL
{
    partial class Form1
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
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLC = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnBM = new System.Windows.Forms.Button();
            this.btnBV = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTKnv = new System.Windows.Forms.Button();
            this.btnSnv = new System.Windows.Forms.Button();
            this.btnXnv = new System.Windows.Forms.Button();
            this.btnTnv = new System.Windows.Forms.Button();
            this.textPB = new System.Windows.Forms.TextBox();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.textGT = new System.Windows.Forms.TextBox();
            this.dateNV = new System.Windows.Forms.DateTimePicker();
            this.textTenNV = new System.Windows.Forms.TextBox();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSpb = new System.Windows.Forms.Button();
            this.btnXpb = new System.Windows.Forms.Button();
            this.btnTpb = new System.Windows.Forms.Button();
            this.textTenPB = new System.Windows.Forms.TextBox();
            this.textMaPB = new System.Windows.Forms.TextBox();
            this.dataPB = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnLH = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNV
            // 
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Location = new System.Drawing.Point(12, 322);
            this.dataNV.Name = "dataNV";
            this.dataNV.Size = new System.Drawing.Size(761, 227);
            this.dataNV.TabIndex = 0;
            this.dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLC);
            this.groupBox1.Controls.Add(this.btnLD);
            this.groupBox1.Controls.Add(this.btnCN);
            this.groupBox1.Controls.Add(this.btnBM);
            this.groupBox1.Controls.Add(this.btnBV);
            this.groupBox1.Controls.Add(this.btnGV);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnTKnv);
            this.groupBox1.Controls.Add(this.btnSnv);
            this.groupBox1.Controls.Add(this.btnXnv);
            this.groupBox1.Controls.Add(this.btnTnv);
            this.groupBox1.Controls.Add(this.textPB);
            this.groupBox1.Controls.Add(this.textSdt);
            this.groupBox1.Controls.Add(this.textGT);
            this.groupBox1.Controls.Add(this.dateNV);
            this.groupBox1.Controls.Add(this.textTenNV);
            this.groupBox1.Controls.Add(this.textMaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnLC
            // 
            this.btnLC.Location = new System.Drawing.Point(322, 176);
            this.btnLC.Name = "btnLC";
            this.btnLC.Size = new System.Drawing.Size(75, 23);
            this.btnLC.TabIndex = 23;
            this.btnLC.Text = "Lao Công";
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.btnLC_Click);
            // 
            // btnLD
            // 
            this.btnLD.Location = new System.Drawing.Point(440, 230);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(75, 23);
            this.btnLD.TabIndex = 22;
            this.btnLD.Text = "Lãnh đạo";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(440, 205);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(75, 23);
            this.btnCN.TabIndex = 21;
            this.btnCN.Text = "GVCN";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnBM
            // 
            this.btnBM.Location = new System.Drawing.Point(322, 230);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(75, 23);
            this.btnBM.TabIndex = 20;
            this.btnBM.Text = "GVBM";
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.btnBM_Click);
            // 
            // btnBV
            // 
            this.btnBV.Location = new System.Drawing.Point(440, 176);
            this.btnBV.Name = "btnBV";
            this.btnBV.Size = new System.Drawing.Size(75, 23);
            this.btnBV.TabIndex = 19;
            this.btnBV.Text = "Bảo Vệ";
            this.btnBV.UseVisualStyleBackColor = true;
            this.btnBV.Click += new System.EventHandler(this.btnBV_Click);
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(322, 205);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(75, 23);
            this.btnGV.TabIndex = 18;
            this.btnGV.Text = "Giáo Viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(322, 110);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 17;
            this.btnXuat.Text = "Xuất DL";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lọc thông tin";
            // 
            // btnTKnv
            // 
            this.btnTKnv.Location = new System.Drawing.Point(440, 70);
            this.btnTKnv.Name = "btnTKnv";
            this.btnTKnv.Size = new System.Drawing.Size(75, 23);
            this.btnTKnv.TabIndex = 15;
            this.btnTKnv.Text = "Tìm kiếm";
            this.btnTKnv.UseVisualStyleBackColor = true;
            this.btnTKnv.Click += new System.EventHandler(this.btnTKnv_Click);
            // 
            // btnSnv
            // 
            this.btnSnv.Location = new System.Drawing.Point(322, 70);
            this.btnSnv.Name = "btnSnv";
            this.btnSnv.Size = new System.Drawing.Size(75, 23);
            this.btnSnv.TabIndex = 14;
            this.btnSnv.Text = "Sửa";
            this.btnSnv.UseVisualStyleBackColor = true;
            this.btnSnv.Click += new System.EventHandler(this.btnSnv_Click);
            // 
            // btnXnv
            // 
            this.btnXnv.Location = new System.Drawing.Point(440, 30);
            this.btnXnv.Name = "btnXnv";
            this.btnXnv.Size = new System.Drawing.Size(75, 23);
            this.btnXnv.TabIndex = 13;
            this.btnXnv.Text = "Xóa";
            this.btnXnv.UseVisualStyleBackColor = true;
            this.btnXnv.Click += new System.EventHandler(this.btnXnv_Click);
            // 
            // btnTnv
            // 
            this.btnTnv.Location = new System.Drawing.Point(322, 30);
            this.btnTnv.Name = "btnTnv";
            this.btnTnv.Size = new System.Drawing.Size(75, 23);
            this.btnTnv.TabIndex = 12;
            this.btnTnv.Text = "Thêm";
            this.btnTnv.UseVisualStyleBackColor = true;
            this.btnTnv.Click += new System.EventHandler(this.btnTnv_Click);
            // 
            // textPB
            // 
            this.textPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPB.Location = new System.Drawing.Point(96, 230);
            this.textPB.Multiline = true;
            this.textPB.Name = "textPB";
            this.textPB.Size = new System.Drawing.Size(87, 25);
            this.textPB.TabIndex = 11;
            // 
            // textSdt
            // 
            this.textSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSdt.Location = new System.Drawing.Point(96, 190);
            this.textSdt.Multiline = true;
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(200, 25);
            this.textSdt.TabIndex = 10;
            // 
            // textGT
            // 
            this.textGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGT.Location = new System.Drawing.Point(96, 150);
            this.textGT.Multiline = true;
            this.textGT.Name = "textGT";
            this.textGT.Size = new System.Drawing.Size(87, 25);
            this.textGT.TabIndex = 9;
            // 
            // dateNV
            // 
            this.dateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNV.Location = new System.Drawing.Point(96, 110);
            this.dateNV.Name = "dateNV";
            this.dateNV.Size = new System.Drawing.Size(200, 22);
            this.dateNV.TabIndex = 8;
            // 
            // textTenNV
            // 
            this.textTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenNV.Location = new System.Drawing.Point(96, 70);
            this.textTenNV.Multiline = true;
            this.textTenNV.Name = "textTenNV";
            this.textTenNV.Size = new System.Drawing.Size(200, 25);
            this.textTenNV.TabIndex = 7;
            this.textTenNV.UseWaitCursor = true;
            // 
            // textMaNV
            // 
            this.textMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaNV.Location = new System.Drawing.Point(96, 30);
            this.textMaNV.Multiline = true;
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(87, 25);
            this.textMaNV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phòng Ban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpb);
            this.groupBox2.Controls.Add(this.btnXpb);
            this.groupBox2.Controls.Add(this.btnTpb);
            this.groupBox2.Controls.Add(this.textTenPB);
            this.groupBox2.Controls.Add(this.textMaPB);
            this.groupBox2.Controls.Add(this.dataPB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(571, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 263);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng ban";
            // 
            // btnSpb
            // 
            this.btnSpb.Location = new System.Drawing.Point(309, 232);
            this.btnSpb.Name = "btnSpb";
            this.btnSpb.Size = new System.Drawing.Size(75, 23);
            this.btnSpb.TabIndex = 7;
            this.btnSpb.Text = "Sửa";
            this.btnSpb.UseVisualStyleBackColor = true;
            this.btnSpb.Click += new System.EventHandler(this.btnSpb_Click);
            // 
            // btnXpb
            // 
            this.btnXpb.Location = new System.Drawing.Point(309, 192);
            this.btnXpb.Name = "btnXpb";
            this.btnXpb.Size = new System.Drawing.Size(75, 23);
            this.btnXpb.TabIndex = 6;
            this.btnXpb.Text = "Xóa";
            this.btnXpb.UseVisualStyleBackColor = true;
            this.btnXpb.Click += new System.EventHandler(this.btnXpb_Click);
            // 
            // btnTpb
            // 
            this.btnTpb.Location = new System.Drawing.Point(309, 147);
            this.btnTpb.Name = "btnTpb";
            this.btnTpb.Size = new System.Drawing.Size(75, 23);
            this.btnTpb.TabIndex = 5;
            this.btnTpb.Text = "Thêm";
            this.btnTpb.UseVisualStyleBackColor = true;
            this.btnTpb.Click += new System.EventHandler(this.btnTpb_Click);
            // 
            // textTenPB
            // 
            this.textTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenPB.Location = new System.Drawing.Point(100, 100);
            this.textTenPB.Multiline = true;
            this.textTenPB.Name = "textTenPB";
            this.textTenPB.Size = new System.Drawing.Size(154, 25);
            this.textTenPB.TabIndex = 4;
            // 
            // textMaPB
            // 
            this.textMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaPB.Location = new System.Drawing.Point(100, 40);
            this.textMaPB.Multiline = true;
            this.textMaPB.Name = "textMaPB";
            this.textMaPB.Size = new System.Drawing.Size(100, 25);
            this.textMaPB.TabIndex = 3;
            // 
            // dataPB
            // 
            this.dataPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPB.Location = new System.Drawing.Point(33, 147);
            this.dataPB.Name = "dataPB";
            this.dataPB.Size = new System.Drawing.Size(254, 108);
            this.dataPB.TabIndex = 2;
            this.dataPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPB_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên PB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã PB:";
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(790, 322);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(180, 50);
            this.btnTM.TabIndex = 3;
            this.btnTM.Text = "QL Tổ Môn";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // btnLH
            // 
            this.btnLH.Location = new System.Drawing.Point(790, 407);
            this.btnLH.Name = "btnLH";
            this.btnLH.Size = new System.Drawing.Size(180, 50);
            this.btnLH.TabIndex = 4;
            this.btnLH.Text = "QL Lớp Học";
            this.btnLH.UseVisualStyleBackColor = true;
            this.btnLH.Click += new System.EventHandler(this.btnLH_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(843, 499);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(80, 50);
            this.btnE.TabIndex = 5;
            this.btnE.Text = "Thoát";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnLH);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLC;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnBM;
        private System.Windows.Forms.Button btnBV;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTKnv;
        private System.Windows.Forms.Button btnSnv;
        private System.Windows.Forms.Button btnXnv;
        private System.Windows.Forms.Button btnTnv;
        private System.Windows.Forms.TextBox textPB;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.TextBox textGT;
        private System.Windows.Forms.DateTimePicker dateNV;
        private System.Windows.Forms.TextBox textTenNV;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSpb;
        private System.Windows.Forms.Button btnXpb;
        private System.Windows.Forms.Button btnTpb;
        private System.Windows.Forms.TextBox textTenPB;
        private System.Windows.Forms.TextBox textMaPB;
        private System.Windows.Forms.DataGridView dataPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnLH;
        private System.Windows.Forms.Button btnE;
    }
}

