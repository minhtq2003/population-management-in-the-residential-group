using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_NHANKHAU : Form
    {
        public frm_NHANKHAU()
        {
            InitializeComponent();
        }
        PHAMVANLOC_6904 lopchung = new PHAMVANLOC_6904();

        private void dt_BANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Loadnhankhau()
        {
            string sql = "Select * from nhankhau";
            dt_BANG.DataSource = lopchung.LoadDuLieu(sql);
        }

        private void frm_NHANKHAU_Load(object sender, EventArgs e)
        {
            Loadnhankhau();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlthem = "Insert into nhankhau values('" + txt_Manhankhau.Text + "',N'" + txt_Tenchuho.Text + "',N'" + txt_Hoten.Text + "',N'" + txt_So.Text + "',N'" + cb_Gioitinh.Text + "',N'" + txt_Ghichu.Text + "',convert(dateTime, '" + dt_Ngaysinh.Text + "',103),N'" + txt_Noisinh.Text + "',N'" + txt_Dantoc.Text + "',N'" + txt_Quoctich.Text + "',N'" + txt_CCCD.Text + "',N'" + txt_Quanhe.Text + "',N'" + txt_Diachithuongtru.Text + "',N'" + txt_Diachitamtru.Text + "',convert(dateTime,'" + dt_Ngaycap.Text + "',103))";
            int kq = lopchung.ThemXoaSua(sqlthem);
            if (kq >= 1) MessageBox.Show("Thêm nhân khẩu  thành công");
            else MessageBox.Show("Thêm  nhân khẩu thất bại thất bại");
            Loadnhankhau();

        }



        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn chắc chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn Có Thật Sự Muốn Xóa Dòng Dữ Liệu Này Không?", "Cảnh Báo", MessageBoxButtons.YesNoCancel);
            if (dt == DialogResult.Yes)
            {
                string sql = "DELETE nhankhau WHERE manhankhau = '" + txt_Manhankhau.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xóa Nhân khẩu Thành Công");
                else MessageBox.Show("Xóa Nhân Khẩu Thất Bại");
                Loadnhankhau();
            }
        }

        private void dt_Ngaycap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlthem = "Update nhankhau set tenchuho = N'" + txt_Tenchuho.Text + "',Hoten = N'" + txt_Hoten.Text + "',sodienthoai = N'" + txt_So.Text + "',gioitinh = N'" + cb_Gioitinh.Text + "',ghichu = N'" + txt_Ghichu.Text + "',ngaysinh = convert(dateTime, '" + dt_Ngaysinh.Text + "',103),noisinh = N'" + txt_Noisinh.Text + "',dantoc = N'" + txt_Dantoc.Text + "',quoctich = N'" + txt_Quoctich.Text + "',cccd = N'" + txt_CCCD.Text + "',quanhechuho = N'" + txt_Quanhe.Text + "',diachithuongtru = N'" + txt_Diachithuongtru.Text + "',diachitamctru = N'" + txt_Diachitamtru.Text + "',ngaycap = convert(dateTime,'" + dt_Ngaycap.Text + "',103) WHERE manhankhau = '" + txt_Manhankhau.Text + "'";
            int kq = lopchung.ThemXoaSua(sqlthem);
            if (kq >= 1) MessageBox.Show("Sửa nhân khẩu  thành công");
            else MessageBox.Show("Sửa  nhân khẩu thất bại thất bại");
            Loadnhankhau();
        }

         private void txt_Nhap_TextChanged(object sender, EventArgs e)
         {
            String name = txt_Nhap.Text.Trim();
            if (name == "")
            {
                frm_NHANKHAU_Load(sender, e);
            }
            else
            {
                
                string queyry = "SELECT * FROM NhanKhau WHERE manhankhau LIKE N'%" + name + "%' COLLATE SQL_Latin1_General_CP1_CI_AI OR tenchuho LIKE N'%" + name + "%' COLLATE SQL_Latin1_General_CP1_CI_AI";
                dt_BANG.DataSource = lopchung.LoadDuLieu(queyry);
            }
        }

    }
}
