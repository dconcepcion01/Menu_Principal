using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal
{
    public partial class Producto : Form

        // Objeto de base de datos
    {
        DataBaseContext db = new DataBaseContext();
        public Producto()
        {
           
            InitializeComponent();

            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //agregando producto

            Producto1 p = new  Producto1();
            p.Codigo =Convert.ToInt32(txtCodigo.Text);
            p.Descripcion = txtDescripcion.Text;
            p.Codigo_Categoria = Convert.ToInt32(txtCategoria.Text);
            p.Descripcion_Categoria = txtCategoria.Text;
            p.Precio = Convert.ToDouble(txtPrecio.Text);
            p.Cantidad = Convert.ToInt32(txtCantidad.Text);
            p.Marca = txtMarca.Text;
            p.Costo = Convert.ToDouble(txtCosto.Text);
            p.Itbis = Convert.ToDouble(txtItbis.Text);
            p.Referencia = txtreferencia.Text;
            

            db.producto1s.Add(p);
            Console.WriteLine("Desea Agregar otro Producto!!!");
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            CargarDgv();
            

            limpiar();

            //Limpiamos los text Box despues de agregar

            void limpiar()
            {
                txtCantidad.Text = "";
                txtCodigo.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                txtCosto.Text = "";
                txtCantidad.Text = "";
                txtCategoria.Text = "";
                txtCosto.Text = "";
                txtMarca.Text = "";
                txtreferencia.Text = "";
                txtItbis.Text = "";
            }



        }

        public  void CargarDgv()
        {
            Dgvproducto.DataSource = null;
            Dgvproducto.DataSource = db.producto1s;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        // Buscar por Id o codigo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (var p  in db.producto1s)
            {
                if (p.Codigo==Convert.ToInt32(txtCodigo.Text))
                {
                    txtDescripcion.Text = p.Descripcion;
                    txtDescripcion.Text =p.Descripcion_Categoria;
                    txtPrecio.Text = p.Precio.ToString();
                    txtCantidad.Text = p.Cantidad.ToString();
                    txtCategoria.Text = p.Codigo_Categoria.ToString();
                    txtMarca.Text = p.Marca;
                    txtCosto.Text = p.Costo.ToString();
                    txtItbis.Text = p.Itbis.ToString();
                    txtreferencia.Text = p.Referencia;






                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar por Nombre o Descripcion

            foreach (var p in db.producto1s)
            {
                if (p.Descripcion == (txtDescripcion.Text))
                {
                    txtCodigo.Text = p.Codigo.ToString();
                    txtDescripcion.Text = p.Descripcion_Categoria;
                    txtPrecio.Text = p.Precio.ToString();
                    txtCantidad.Text = p.Cantidad.ToString();
                    txtCategoria.Text = p.Codigo_Categoria.ToString();
                    txtMarca.Text = p.Marca;
                    txtCosto.Text = p.Costo.ToString();
                    txtItbis.Text = p.Itbis.ToString();
                    txtreferencia.Text = p.Referencia;






                }

            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void Dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
