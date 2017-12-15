using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escalonadores
{
    public partial class fMenuPrincipal : Form
    {
        public fMenuPrincipal()
        {
            InitializeComponent();
        }

        private void fMenuPrincipal_Load(object sender, EventArgs e)
        {
            SRT x = new SRT(); x.Show();
        }
    }
}
