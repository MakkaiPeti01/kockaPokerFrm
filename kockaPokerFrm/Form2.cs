using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kockaPokerFrm
{
    public partial class frmKezdo : Form
    {
        private frmFo foForm;
        public frmKezdo(frmFo fo)
        {
            InitializeComponent();
            foForm = fo;
        }

        private void btnHarom_Click(object sender, EventArgs e)
        {
            foForm.KorokSzama = 3;
            foForm.Text += " | A körök száma 3";
            this.Close();
        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            foForm.KorokSzama = 3;
            foForm.Text += " | A körök száma 5";
            this.Close();
        }

        private void frmKezdo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (foForm.KorokSzama == 0)
            {
                var result = MessageBox.Show("Nincs beállítva a körökszáma, csak egy körös játék lesz!",
                    "Beállítás nélkül", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.No) 
                {
                    foForm.KorokSzama = 1;
                    foForm.Text += " | A körök száma: 1";
                    e.Cancel = false;
                    return;
                }
            }
        }
    }
}
