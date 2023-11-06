using BusinessEntities;
using BusinessLogic;
using DataAccess;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class frmVendedor : Form
    {
        public frmVendedor(UsuarioBE usuario)
        {
            InitializeComponent();
            llenarDGW(usuario.Id);
            this.idVendedor = usuario.Id;
            this.IDVendedorlabel.Text = usuario.Id.ToString();
            this.label4.Text = usuario.Nombre.ToString() + usuario.Apellido.ToString();
            this.usuario = usuario;
            this.splitContainer1.Panel2.Controls.Clear();
        }
        UsuarioBE usuario;
        int idVendedor;

        // Panel izquiero, botones de navegacion
        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.IdTxt);
            this.splitContainer1.Panel2.Controls.Add(this.idProducto);
            this.splitContainer1.Panel2.Controls.Add(textBox7);
            this.splitContainer1.Panel2.Controls.Add(label12);
            this.splitContainer1.Panel2.Controls.Add(button8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotal);
            this.splitContainer1.Panel2.Controls.Add(this.btnImprimir);
            float MontoVendedor = 0;
            flowLayoutPanel1.Controls.Clear();
            var lineas = RecuperarLineas();
            var par = 0;
            foreach (LineaVenta lv in lineas)
            {

                VentaVendedorController vvC = new VentaVendedorController();
                Venta venta = VentaBL.getVenta(lv);
                vvC.txtIDVenta.Text = venta.Id.ToString();
                vvC.txtFechaVenta.Text = venta.fecha.ToString();
                UsuarioBE cliente = UsuarioBL.getCliente(venta);
                vvC.txtCliente.Text = cliente.Nombre.ToString();
                ProductoBE producto = ProductoBL.buscarProducto(lv);
                vvC.txtProd.Text = producto.Nombre.ToString();
                vvC.txtCantidad.Text = lv.Cantidad.ToString();
                float MontoTotal = 0;
                if (par == 0)
                {
                    vvC.BackColor = Color.LightGray;
                    par++;
                }
                else if (par == 1)
                {
                    vvC.BackColor = Color.DarkGray;
                    par--;
                }
                if (lv.Cantidad <= 9)
                {
                    MontoTotal = producto.PrecioUnitario * lv.Cantidad;
                }
                else MontoTotal = producto.PrecioX10 * lv.Cantidad;
                MontoVendedor = MontoVendedor + MontoTotal;
                vvC.txtTotal.Text = MontoTotal.ToString();
                flowLayoutPanel1.Controls.Add(vvC);
            }
            this.txtTotal.Text = "$" + MontoVendedor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paginaHtml = Properties.Resources.plantillaVendedor.ToString();
            paginaHtml = paginaHtml.Replace("@VENDEDOR", this.usuario.Nombre.ToString() + " " + this.usuario.Apellido.ToString());
            paginaHtml = paginaHtml.Replace("@FECHA", DateTime.Now.ToString());
            var htmlRows = new StringBuilder();
            foreach (VentaVendedorController vvc in this.flowLayoutPanel1.Controls)
            {
                htmlRows.Append("<tr>");
                htmlRows.Append($"<td>{vvc.txtIDVenta.Text}</td>");
                htmlRows.Append($"<td>{vvc.txtProd.Text}</td>");
                htmlRows.Append($"<td>{vvc.txtCantidad.Text}</td>");
                htmlRows.Append($"<td>{vvc.txtFechaVenta.Text}</td>");
                htmlRows.Append($"<td>{vvc.txtTotal.Text}</td>");
                htmlRows.Append("</tr>");
            }
            paginaHtml = paginaHtml.Replace("@TOTAL", this.txtTotal.Text);
            paginaHtml = paginaHtml.Replace("@HtmlRows", htmlRows.ToString());

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(paginaHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "archivos de imagen (*jpg; *png;) | *jpg; *png;";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(file.FileName);
            }
        }

        //Metodos Agregar Producto, Eliminar Producto -------- Falta el editar por ahora
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null && this.textBox1.Text != "" && this.textBox2.Text != "" &&
                this.textBox3.Text != "" && this.textBox4.Text != "" && this.textBox5.Text != "" && this.textBox6.Text != "" && this.textBox7.Text != "")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ProductoBE newProd = new ProductoBE(textBox1.Text, textBox2.Text, textBox6.Text, float.Parse(textBox5.Text),
                                                    float.Parse(textBox3.Text), float.Parse(textBox4.Text), int.Parse(IDVendedorlabel.Text)
                                                    , ms.ToArray(), int.Parse(textBox7.Text));
                ProductoBL prodBL = new ProductoBL();
                MessageBox.Show(prodBL.Agregar(newProd));
                llenarDGW(this.idVendedor);
                borrartextos();
            }
            else MessageBox.Show("Todos los campos deben estar completos para crear un producto");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (idProducto.Text != "")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ProductoBE newProd = new ProductoBE(textBox1.Text, textBox2.Text, textBox6.Text, float.Parse(textBox5.Text),
                                                    float.Parse(textBox3.Text), float.Parse(textBox4.Text), int.Parse(IDVendedorlabel.Text)
                                                    , ms.ToArray(), int.Parse(textBox7.Text));
                ProductoBL prod = new ProductoBL();
                MessageBox.Show(prod.Eliminar(int.Parse(idProducto.Text)));
                llenarDGW(this.idVendedor);
                borrartextos();
            }
            else MessageBox.Show("Seleccione el producto de la Grilla que desea eliminar");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null && this.textBox1.Text != "" && this.textBox2.Text != "" &&
                this.textBox3.Text != "" && this.textBox4.Text != "" && this.textBox5.Text != "" && this.textBox6.Text != "" && this.textBox7.Text != ""
                && idProducto.Text != "")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ProductoBE modifProd = new ProductoBE(textBox1.Text, textBox2.Text, textBox6.Text, float.Parse(textBox5.Text),
                                                    float.Parse(textBox3.Text), float.Parse(textBox4.Text), int.Parse(IDVendedorlabel.Text)
                                                    , ms.ToArray(), int.Parse(textBox7.Text));
                ProductoBL prodBL = new ProductoBL();
                MessageBox.Show(prodBL.Modificar(modifProd, int.Parse(idProducto.Text)));
                llenarDGW(this.idVendedor);
                borrartextos();
            }
            else if (idProducto.Text == "") { MessageBox.Show("Seleccione el producto a modificar"); }
            else MessageBox.Show("Todos los campos deben estar completos para crear un producto");
        }



        // Data Grid view Methods
        private void llenarDGW(int id)
        {
            ProductoBL pro = new ProductoBL();
            dataGridView1.DataSource = pro.ObtenerProductos(id);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index indice = e.RowIndex;
            idProducto.Text = dataGridView1.Rows[indice].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[indice].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[indice].Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.Rows[indice].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.Rows[indice].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[indice].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[indice].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[indice].Cells[9].Value.ToString();
            byte[] fotoProd = (byte[])dataGridView1.Rows[indice].Cells[8].Value;
            MemoryStream ms = new MemoryStream(fotoProd);
            pictureBox1.Image = System.Drawing.Image.FromStream(ms);
        }

        private List<LineaVenta> RecuperarLineas()
        {
            VentaBL logica = new VentaBL();
            return logica.ListarLineas(this.usuario);
        }


        private void borrartextos()
        {
            this.pictureBox1.Image = null;
            this.textBox1.Text = ""; this.textBox2.Text = ""; this.textBox3.Text = "";
            this.textBox4.Text = ""; this.textBox5.Text = ""; this.textBox6.Text = "";
        }

        // Estos metodos validan la entrada por teclado de los campos Precios

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            return;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            return;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(textBox7.Text);
            cant++;
            textBox7.Text = cant.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}
