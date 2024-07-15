using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class FormTimKiem : Form
    {
      
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void cboTkQuequan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //tim kiem
       

        public delegate void getDataQuequan(string data);
        public getDataQuequan mydata1;

        public delegate void getDataDonvi(string data);
        public getDataDonvi mydata2;

        public delegate void getDataHamvi(string data);
        public getDataHamvi mydata3;

        private void btn_TimKiemTheoData_Click(object sender, EventArgs e)
        {
            mydata1(cboTkQuequan.Text);
            mydata2(cboTkDonvi.Text);
            mydata3(cboTkHochamhocvi.Text);
        }
        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
