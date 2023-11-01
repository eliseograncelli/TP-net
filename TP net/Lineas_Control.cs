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
using TP_net;

namespace TP_net
{
    public partial class Lineas_Control : UserControl
    {
        //private LineaVenta linea;

        //public Lineas_Control(LineaVenta lv)
        //{
        //    InitializeComponent();
        //    linea = lv;
        //}


        private Venta v;

        public Lineas_Control(Venta venta)
        {
            InitializeComponent();
            v = venta;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int lineaId = (int)this.Tag;
            v.EliminaLinea(lineaId);
            FlowLayoutPanel flw = this.Parent as FlowLayoutPanel;
            flw.Controls.Remove(this);

        }
    }
}
