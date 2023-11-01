using BusinessEntities;
using BusinessLogic;
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
    public partial class frmMisCompras : Form
    {
        List<Venta> compras = new List<Venta>();

        public frmMisCompras(UsuarioBE us)
        {
            InitializeComponent();

            VentaBL v = new VentaBL();
            compras = v.ListarCompras(us);
            LlenaFlw(compras);
        }

        public void LlenaFlw(List<Venta> listaCompras)
        {
            foreach (Venta c in listaCompras)
            {
                MisCompras_Control misCControl = new MisCompras_Control();
                misCControl.txtId.Text = c.Id.ToString();
                misCControl.txtFecha.Text = c.fecha.ToString();
                misCControl.txtMonto.Text = "$" + c.Monto.ToString();
                misCControl.txtEstado.Text = c.Estado;
                misCControl.Tag = c.Id;
                flwMisCompras.Controls.Add(misCControl);
            }
        }
    }
}
