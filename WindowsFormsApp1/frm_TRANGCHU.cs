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
    public partial class frm_TRANGCHU : Form
    {
        public frm_TRANGCHU()
        {
            InitializeComponent();
        }

        private void thôngTinHộKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NHANKHAU"] == null)
            {
                frm_NHANKHAU ns = new frm_NHANKHAU();
                ns.MdiParent = this;
                ns.Show();
            }
            else Application.OpenForms["frm_NHANKHAU"].Activate();
        }
    }
}
