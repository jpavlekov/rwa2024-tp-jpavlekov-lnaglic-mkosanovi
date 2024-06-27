using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ
{
    public partial class Recenziranje : Form
    {
        private string _username;
        public Recenziranje(string username)
        {
            InitializeComponent();
            _username = username;

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSCVZ frm = new FrmSCVZ(_username);    
            frm.ShowDialog();
            Close();

        }

        private void Recenziranje_Load(object sender, EventArgs e)
        {

        }
    }
}
