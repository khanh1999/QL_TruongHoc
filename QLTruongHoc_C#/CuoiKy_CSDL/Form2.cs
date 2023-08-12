using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CuoiKy_CSDL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DTO_GiaoVien gv;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGV.DataSource = BUS_GiaoVien.GetAllGiaoVien();

        }

        private void btnTgv_Click(object sender, EventArgs e)
        {
            if (this.textMaGV.Text.Trim().CompareTo("") != 0 && this.textCM.Text.Trim().CompareTo("") != 0 && this.textCV.Text.Trim().CompareTo("") != 0 )
            {

                string maGV = this.textMaGV.Text;
                string chuyenMon = this.textCM.Text;
                string chucVu = this.textCV.Text;
                string maTT = this.textTT.Text;
                gv = new DTO_GiaoVien(maGV, chuyenMon, chucVu, maTT);
                if (BUS_GiaoVien.insertGV(gv))
                {
                    dataGV.DataSource = BUS_GiaoVien.GetAllGiaoVien();
                    this.textMaGV.Text = "";
                    this.textCM.Text = "";
                    this.textCV.Text = "";
                    this.textTT.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");
        }

        private void btnSgv_Click(object sender, EventArgs e)
        {
            if (this.textMaGV.Text.Trim().CompareTo("") != 0 && this.textCM.Text.Trim().CompareTo("") != 0 && this.textCV.Text.Trim().CompareTo("") != 0) 
            {

                string maGV = this.textMaGV.Text;
                string chuyenMon = this.textCM.Text;
                string chucVu = this.textCV.Text;
                string maTT = this.textTT.Text;
                gv = new DTO_GiaoVien(maGV, chuyenMon, chucVu, maTT);
                DialogResult dr = MessageBox.Show("Xác nhận đã cập nhật đúng thông tin!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (BUS_GiaoVien.updateGV(gv))
                    {
                        dataGV.DataSource = BUS_GiaoVien.GetAllGiaoVien();
                        this.textMaGV.Text = "";
                        this.textCM.Text = "";
                        this.textCV.Text = "";
                        this.textTT.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + "Không chỉnh sửa vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");
        }

        private void btnXgv_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin này!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ma = dataGV.SelectedRows[0].Cells[0].Value.ToString();
                dataGV.DataSource = BUS_GiaoVien.GetAllGiaoVien();
                if (BUS_GiaoVien.deleteGV(ma))
                {
                    dataGV.DataSource = BUS_GiaoVien.GetAllGiaoVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thể xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTKgv_Click(object sender, EventArgs e)
        {
            string chuyenMon = this.textCM.Text;  
            dataGV.DataSource = BUS_GiaoVien.LookUpGV(chuyenMon);
  
        }

        private void btnEgv_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn quay lại trang chính!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Hide();
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textMaGV.Text = dataGV.SelectedRows[0].Cells[0].Value.ToString();
            this.textCM.Text = dataGV.SelectedRows[0].Cells[2].Value.ToString();
            this.textCV.Text = dataGV.SelectedRows[0].Cells[3].Value.ToString();
            this.textTT.Text = dataGV.SelectedRows[0].Cells[4].Value.ToString();
        }

    }
}
