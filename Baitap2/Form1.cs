using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baitap2
{
    public partial class fmDSSV : Form
    {
        public fmDSSV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            else
            {
                ListViewItem item = lvDS.Items.Add(txtMSSV.Text);
                item.SubItems.Add(txtHoTen.Text);
                item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
                item.SubItems.Add(cmbLop.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                lvDS.Items.Remove(lvDS.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn ít nhất 1 dòng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                lvDS.SelectedItems[0].SubItems[0].Text = txtMSSV.Text;
                lvDS.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                lvDS.SelectedItems[0].SubItems[2].Text = dtpNgaySinh.Value.ToShortDateString();
                lvDS.SelectedItems[0].SubItems[3].Text = cmbLop.Text;
            }
        }

        private void fmDSSV_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
