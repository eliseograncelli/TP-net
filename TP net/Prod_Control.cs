using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_net
{
    public partial class Prod_Control : UserControl
    {
        public Prod_Control()
        {
            InitializeComponent();
        }

        private void Prod_Control_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreProd_Click(object sender, EventArgs e)
        {
            frmDetalleProducto frm = new frmDetalleProducto();
            frm.Show();
        }
    }
}
