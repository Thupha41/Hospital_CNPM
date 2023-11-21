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
    public partial class Cashier_New_General : Form
    {
        public Cashier_New_General()
        {
            InitializeComponent();
            LoadForm(new Cashier_New_Examine());
        }

        //public void LoadForm(Object form)
        //{
        //    if (this.Main_Panel.Controls.Count > 0)
        //    {
        //        this.Main_Panel.Controls.RemoveAt(0);
        //    }

        //    Form f = form as Form;
        //    f.TopLevel = false;
        //    f.Dock = DockStyle.Fill;
        //    this.Main_Panel.Controls.Add(f);
        //    this.Main_Panel.Tag = f;
        //    f.Show();
        //}

        public void LoadForm(Object form)
        {
            if (this.SelectionBound_Panel.Controls.Count > 0)
            {
                this.SelectionBound_Panel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.SelectionBound_Panel.Controls.Add(f);
            this.SelectionBound_Panel.Tag = f;
            f.Show();
        }

        private void Examine_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_New_Examine());
        }

        private void Prescription_Button_Click(object sender, EventArgs e)
        {
            LoadForm(new Cashier_New_Prescription());
        }

        private void Other_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
