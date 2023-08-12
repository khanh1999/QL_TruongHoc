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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DTO_Lop lh;

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataLop.DataSource = BUS_Lop.GetAllLop();
        }

        private void btnTlop_Click(object sender, EventArgs e)
        {
            if (this.textMaL.Text.Trim().CompareTo("") != 0 && this.textTenL.Text.Trim().CompareTo("") != 0 && this.textSiso.Text.Trim().CompareTo("") != 0 &&
                this.textCN.Text.Trim().CompareTo("") != 0 && this.textToan.Text.Trim().CompareTo("") != 0 && this.textLy.Text.Trim().CompareTo("") != 0 && this.textHoa.Text.Trim().CompareTo("") != 0)
            {
                if (IsNumber(this.textSiso.Text) == true)
                {
                    string maL = this.textMaL.Text;
                    string tenL = this.textTenL.Text;
                    int siSo = Int32.Parse(this.textSiso.Text);
                    string gvCN = this.textCN.Text;
                    string gvT = this.textToan.Text;
                    string gvL = this.textLy.Text;
                    string gvH = this.textHoa.Text;
                    lh = new DTO_Lop(maL, tenL, siSo, gvCN, gvT, gvL, gvH);

                    if (BUS_Lop.insertLop(lh))
                    {
                        dataLop.DataSource = BUS_Lop.GetAllLop();
                        this.textMaL.Text = "";
                        this.textTenL.Text = "";
                        this.textSiso.Text = "";
                        this.textCN.Text = "";
                        this.textToan.Text = "";
                        this.textLy.Text = "";
                        this.textHoa.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + "Không chỉnh sửa vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                    MessageBox.Show(@"Dữ liệu nhập vào Sỉ Số không đúng kiểu!!!");
            }
            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");
        }

        private void btbSlop_Click(object sender, EventArgs e)
        {
            if (this.textMaL.Text.Trim().CompareTo("") != 0 && this.textTenL.Text.Trim().CompareTo("") != 0 && this.textSiso.Text.Trim().CompareTo("") != 0 &&
                this.textCN.Text.Trim().CompareTo("") != 0 && this.textToan.Text.Trim().CompareTo("") != 0 && this.textLy.Text.Trim().CompareTo("") != 0 && this.textHoa.Text.Trim().CompareTo("") != 0)
            {
                if (IsNumber(this.textSiso.Text) == true)
                {
                    string maL = this.textMaL.Text;
                    string tenL = this.textTenL.Text;
                    int siSo = Int32.Parse(this.textSiso.Text);
                    string gvCN = this.textCN.Text;
                    string gvT = this.textToan.Text;
                    string gvL = this.textLy.Text;
                    string gvH = this.textHoa.Text;
                    lh = new DTO_Lop(maL, tenL, siSo, gvCN, gvT, gvL, gvH);
                    DialogResult dr = MessageBox.Show("Xác nhận đã cập nhật đúng thông tin!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (BUS_Lop.updateLop(lh))
                    {
                        dataLop.DataSource = BUS_Lop.GetAllLop();
                        this.textMaL.Text = "";
                        this.textTenL.Text = "";
                        this.textSiso.Text = "";
                        this.textCN.Text = "";
                        this.textToan.Text = "";
                        this.textLy.Text = "";
                        this.textHoa.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + "Không chỉnh sửa vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                    MessageBox.Show(@"Dữ liệu nhập vào Sỉ Số không đúng kiểu!!!");
            }
            else
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!!");
        
        }

        private void btnXlop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin này!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ma = dataLop.SelectedRows[0].Cells[0].Value.ToString();
                dataLop.DataSource = BUS_Lop.GetAllLop();
                if (BUS_Lop.deleteLop(ma))
                {
                    dataLop.DataSource = BUS_Lop.GetAllLop();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thể xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTKlop_Click(object sender, EventArgs e)
        {
            string tenL = this.textTenL.Text;
            dataLop.DataSource = BUS_Lop.LookUpLop(tenL);

        }

        private void btnE_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn quay lại trang chính!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Hide();
        }

        private void dataLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textMaL.Text = dataLop.SelectedRows[0].Cells[0].Value.ToString();
            this.textTenL.Text = dataLop.SelectedRows[0].Cells[1].Value.ToString();
            this.textSiso.Text = dataLop.SelectedRows[0].Cells[2].Value.ToString();
            this.textCN.Text = dataLop.SelectedRows[0].Cells[3].Value.ToString();
            this.textToan.Text = dataLop.SelectedRows[0].Cells[4].Value.ToString();
            this.textLy.Text = dataLop.SelectedRows[0].Cells[5].Value.ToString();
            this.textHoa.Text = dataLop.SelectedRows[0].Cells[6].Value.ToString();
        }

    }
}
