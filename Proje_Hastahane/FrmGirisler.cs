using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastahane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris dr= new FrmDoktorGiris();
            dr.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sr= new FrmSekreterGiris();
            sr.Show();
            this.Hide();
        }
    }
}
