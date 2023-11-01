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
            //if(sender is Button btn)
            //{
            //    if(btn.Tag is Lineas_Control linea)
            //    {
            //        FlowLayoutPanel flw = this.Parent as FlowLayoutPanel;
            //        flw.Controls.Remove(this);
            //        flw.Refresh();
            //        //Controls.Remove(linea);
            //        //int idd = (int)btnEliminar.Tag;
            //        ////v.EliminaLinea(idd);
            //        ////v.Lineas.RemoveAt(idd);
            //        //ProductoBE p = new ProductoBE(idd);
            //        //int c = 0;
            //        //v.AgregarProductos(p, c);

            //    }
            //}
            int lineaId = (int)this.Tag;
            v.EliminaLinea(lineaId);
            FlowLayoutPanel flw = this.Parent as FlowLayoutPanel;
            flw.Controls.Remove(this);
            //flw.Refresh();




            //Lineas_Control seleccionada = (Lineas_Control)sender;
            //int idSeleccionada = (int)seleccionada.Tag;
            //v.EliminaLinea(idSeleccionada);

        }
    }
}
