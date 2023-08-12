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
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;


namespace CuoiKy_CSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DTO_NhanVien nv;
        DTO_PhongBan pb;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.GetAllNhanVien();
            dataPB.DataSource = BUS_PhongBan.GetAllPhongBan();

        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnTnv_Click(object sender, EventArgs e)
        {

            if (this.textMaNV.Text.Trim().CompareTo("") != 0 && this.textTenNV.Text.Trim().CompareTo("") != 0 && this.dateNV.Text.Trim().CompareTo("") != 0 &&
                this.textGT.Text.Trim().CompareTo("") != 0 && this.textSdt.Text.Trim().CompareTo("") != 0 && this.textPB.Text.Trim().CompareTo("") != 0)
            {
 
                string maVN = this.textMaNV.Text;
                string hoTen = this.textTenNV.Text;
                DateTime ngaySinh = this.dateNV.Value;
                string gioiTinh = this.textGT.Text;
                string sdt = this.textSdt.Text;
                string phongBan = this.textPB.Text;
                nv = new DTO_NhanVien(maVN, hoTen, ngaySinh, gioiTinh, sdt, phongBan);
                if (BUS_NhanVien.insertNV(nv))
                {
                    dataNV.DataSource = BUS_NhanVien.GetAllNhanVien();
                    this.textMaNV.Text = "";
                    this.textTenNV.Text = "";
                    this.textGT.Text = "";
                    this.textSdt.Text = "";
                    this.textPB.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");
        }

        private void btnSnv_Click(object sender, EventArgs e)
        {
            if (this.textMaNV.Text.Trim().CompareTo("") != 0 && this.textTenNV.Text.Trim().CompareTo("") != 0 && this.dateNV.Text.Trim().CompareTo("") != 0 &&
                this.textGT.Text.Trim().CompareTo("") != 0 && this.textSdt.Text.Trim().CompareTo("") != 0 && this.textPB.Text.Trim().CompareTo("") != 0)
            {

                string maVN = this.textMaNV.Text;
                string hoTen = this.textTenNV.Text;
                DateTime ngaySinh = this.dateNV.Value;
                string gioiTinh = this.textGT.Text;
                string sdt = this.textSdt.Text;
                string phongBan = this.textPB.Text;
                nv = new DTO_NhanVien(maVN, hoTen, ngaySinh, gioiTinh, sdt, phongBan);
                DialogResult dr = MessageBox.Show("Xác nhận đã cập nhật đúng thông tin!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (BUS_NhanVien.updateNV(nv))
                    {
                        dataNV.DataSource = BUS_NhanVien.GetAllNhanVien();
                        this.textMaNV.Text = "";
                        this.textTenNV.Text = "";
                        this.textGT.Text = "";
                        this.textSdt.Text = "";
                        this.textPB.Text = "";
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

        private void btnXnv_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin này!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ma = dataNV.SelectedRows[0].Cells[0].Value.ToString();
                dataNV.DataSource = BUS_NhanVien.GetAllNhanVien();
                if (BUS_NhanVien.deleteNV(ma))
                {
                    dataNV.DataSource = BUS_NhanVien.GetAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thể xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTKnv_Click(object sender, EventArgs e)
        {
            string ten = this.textTenNV.Text;
            dataNV.DataSource = BUS_NhanVien.LookUpNV(ten);
        }

        private void btnTpb_Click(object sender, EventArgs e)
        {

            if (this.textMaPB.Text.Trim().CompareTo("") != 0 && this.textTenPB.Text.Trim().CompareTo("") != 0)
            {

                string maPB = this.textMaPB.Text;
                string tenPB = this.textTenPB.Text;
                pb = new DTO_PhongBan(maPB, tenPB);
                if (BUS_PhongBan.insertPB(pb))
                {
                    dataPB.DataSource = BUS_PhongBan.GetAllPhongBan();
                    this.textMaPB.Text = "";
                    this.textTenPB.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");

        }

        private void btnSpb_Click(object sender, EventArgs e)
        {

            if (this.textMaPB.Text.Trim().CompareTo("") != 0 && this.textTenPB.Text.Trim().CompareTo("") != 0)
            {

                string maPB = this.textMaPB.Text;
                string tenPB = this.textTenPB.Text;
                pb = new DTO_PhongBan(maPB, tenPB);
                DialogResult dr = MessageBox.Show("Xác nhận đã cập nhật đúng thông tin!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (BUS_PhongBan.updatePB(pb))
                    {
                        dataPB.DataSource = BUS_PhongBan.GetAllPhongBan();
                        this.textMaPB.Text = "";
                        this.textTenPB.Text = "";
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

        private void btnXpb_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin này!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ma = dataPB.SelectedRows[0].Cells[0].Value.ToString();
                dataPB.DataSource = BUS_PhongBan.GetAllPhongBan();
                if (BUS_PhongBan.deletePB(ma))
                {
                    dataPB.DataSource = BUS_PhongBan.GetAllPhongBan();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thể xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpGV();
        }

        private void btnBV_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpBV();
        }

        private void btnBM_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpGVBM();
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpLD();
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpGVCN();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = BUS_NhanVien.LookUpLC();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát chương trình không!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                System.Windows.Forms.Application.Exit(); 
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataNV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataNV.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataNV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataNV.Columns.Count; j++)
                {
                    if (dataNV.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataNV.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textMaNV.Text = dataNV.SelectedRows[0].Cells[0].Value.ToString();
            this.textTenNV.Text = dataNV.SelectedRows[0].Cells[1].Value.ToString();
            this.dateNV.Text = dataNV.SelectedRows[0].Cells[2].Value.ToString();
            this.textGT.Text = dataNV.SelectedRows[0].Cells[3].Value.ToString();
            this.textSdt.Text = dataNV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textMaPB.Text = dataPB.SelectedRows[0].Cells[0].Value.ToString();
            this.textTenPB.Text = dataPB.SelectedRows[0].Cells[1].Value.ToString();
        }

    }
 }

