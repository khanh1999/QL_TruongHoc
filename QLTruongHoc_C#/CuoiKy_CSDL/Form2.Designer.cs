namespace CuoiKy_CSDL
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTT = new System.Windows.Forms.TextBox();
            this.textCV = new System.Windows.Forms.TextBox();
            this.textCM = new System.Windows.Forms.TextBox();
            this.textMaGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTKgv = new System.Windows.Forms.Button();
            this.btnXgv = new System.Windows.Forms.Button();
            this.btnSgv = new System.Windows.Forms.Button();
            this.btnTgv = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btnEgv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TỔ MÔN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTT);
            this.groupBox1.Controls.Add(this.textCV);
            this.groupBox1.Controls.Add(this.textCM);
            this.groupBox1.Controls.Add(this.textMaGV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(60, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tổ Môn";
            // 
            // textTT
            // 
            this.textTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTT.Location = new System.Drawing.Point(110, 145);
            this.textTT.Multiline = true;
            this.textTT.Name = "textTT";
            this.textTT.Size = new System.Drawing.Size(115, 25);
            this.textTT.TabIndex = 7;
            // 
            // textCV
            // 
            this.textCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCV.Location = new System.Drawing.Point(110, 105);
            this.textCV.Multiline = true;
            this.textCV.Name = "textCV";
            this.textCV.Size = new System.Drawing.Size(115, 25);
            this.textCV.TabIndex = 6;
            // 
            // textCM
            // 
            this.textCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCM.Location = new System.Drawing.Point(110, 65);
            this.textCM.Multiline = true;
            this.textCM.Name = "textCM";
            this.textCM.Size = new System.Drawing.Size(115, 25);
            this.textCM.TabIndex = 5;
            // 
            // textMaGV
            // 
            this.textMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaGV.Location = new System.Drawing.Point(110, 25);
            this.textMaGV.Multiline = true;
            this.textMaGV.Name = "textMaGV";
            this.textMaGV.Size = new System.Drawing.Size(115, 25);
            this.textMaGV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Tổ Trưởng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã GV:";
            // 
            // btnTKgv
            // 
            this.btnTKgv.Location = new System.Drawing.Point(534, 145);
            this.btnTKgv.Name = "btnTKgv";
            this.btnTKgv.Size = new System.Drawing.Size(90, 40);
            this.btnTKgv.TabIndex = 6;
            this.btnTKgv.Text = "Tìm kiếm";
            this.btnTKgv.UseVisualStyleBackColor = true;
            this.btnTKgv.Click += new System.EventHandler(this.btnTKgv_Click);
            // 
            // btnXgv
            // 
            this.btnXgv.Location = new System.Drawing.Point(428, 145);
            this.btnXgv.Name = "btnXgv";
            this.btnXgv.Size = new System.Drawing.Size(90, 40);
            this.btnXgv.TabIndex = 4;
            this.btnXgv.Text = "Xóa";
            this.btnXgv.UseVisualStyleBackColor = true;
            this.btnXgv.Click += new System.EventHandler(this.btnXgv_Click);
            // 
            // btnSgv
            // 
            this.btnSgv.Location = new System.Drawing.Point(534, 75);
            this.btnSgv.Name = "btnSgv";
            this.btnSgv.Size = new System.Drawing.Size(90, 40);
            this.btnSgv.TabIndex = 5;
            this.btnSgv.Text = "Sửa";
            this.btnSgv.UseVisualStyleBackColor = true;
            this.btnSgv.Click += new System.EventHandler(this.btnSgv_Click);
            // 
            // btnTgv
            // 
            this.btnTgv.Location = new System.Drawing.Point(428, 75);
            this.btnTgv.Name = "btnTgv";
            this.btnTgv.Size = new System.Drawing.Size(90, 40);
            this.btnTgv.TabIndex = 3;
            this.btnTgv.Text = "Thêm";
            this.btnTgv.UseVisualStyleBackColor = true;
            this.btnTgv.Click += new System.EventHandler(this.btnTgv_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(60, 249);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(500, 200);
            this.dataGV.TabIndex = 2;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellClick);
            // 
            // btnEgv
            // 
            this.btnEgv.Location = new System.Drawing.Point(481, 197);
            this.btnEgv.Name = "btnEgv";
            this.btnEgv.Size = new System.Drawing.Size(90, 40);
            this.btnEgv.TabIndex = 7;
            this.btnEgv.Text = "Thoát";
            this.btnEgv.UseVisualStyleBackColor = true;
            this.btnEgv.Click += new System.EventHandler(this.btnEgv_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.btnEgv);
            this.Controls.Add(this.btnTKgv);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSgv);
            this.Controls.Add(this.btnTgv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTT;
        private System.Windows.Forms.TextBox textCV;
        private System.Windows.Forms.TextBox textCM;
        private System.Windows.Forms.TextBox textMaGV;
        private System.Windows.Forms.Button btnTgv;
        private System.Windows.Forms.Button btnXgv;
        private System.Windows.Forms.Button btnSgv;
        private System.Windows.Forms.Button btnTKgv;
        private System.Windows.Forms.Button btnEgv;
    }
}