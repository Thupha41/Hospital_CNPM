using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.CashierView
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            LoadForm(new Cashier_Dashboard());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadForm(Object form)
        {
            if (this.Main_Panel.Controls.Count > 0)
            {
                this.Main_Panel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Main_Panel.Controls.Add(f);
            this.Main_Panel.Tag = f;
            f.Show();
        }

        //Main >> DashBoard
        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_Dashboard());
        }

        //Main >> New general
        private void New_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_New_General());
        }
        //Main >> Database
        private void Database_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_Query());
        }

        //Main >> Settings
        private void Settings_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_Settings());
        }
    }
}
