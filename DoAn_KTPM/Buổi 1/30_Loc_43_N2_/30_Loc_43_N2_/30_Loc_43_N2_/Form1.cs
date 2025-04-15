using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Loc_43_N2_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCong_30_Loc_Click(object sender, EventArgs e)
        {
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);
            Caculation_30_Loc c = new Caculation_30_Loc(a_30_Loc, b_30_Loc);
            ketQua_30_Loc = c.Execute("+");
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }

        private void btnTru_30_Loc_Click(object sender, EventArgs e)
        {
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);
            Caculation_30_Loc c = new Caculation_30_Loc(a_30_Loc, b_30_Loc);
            ketQua_30_Loc = c.Execute("-");
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }

        private void btnNhan_30_Loc_Click(object sender, EventArgs e)
        {
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);
            Caculation_30_Loc c = new Caculation_30_Loc(a_30_Loc, b_30_Loc);
            ketQua_30_Loc = c.Execute("*");
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }

        private void btnChia_30_Loc_Click(object sender, EventArgs e)
        {
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);
            Caculation_30_Loc c = new Caculation_30_Loc(a_30_Loc, b_30_Loc);
            ketQua_30_Loc = c.Execute("/");
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }
    }
}
