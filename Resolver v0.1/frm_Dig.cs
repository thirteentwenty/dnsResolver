using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnsResolver
{
    public partial class frm_dig : Form
    {
        public frm_dig()
        {
            InitializeComponent();
        }

        private void frm_dig_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_closeFormDig_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
