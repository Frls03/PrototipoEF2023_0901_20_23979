using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 




namespace Vista_PrototipoMenu
{
    //Controlador con = new Controlador();
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea realizar la transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {




                // Llamar al Controlador para insertar el movimiento en la base de datos
                //cn.InsertarMovimiento(asiento.Text, subtotal.Text, factura.Text);



                // Limpiar los TextBox y combobox
                asiento.Clear();
                subtotal.Clear();
                factura.Clear();
                pel.Clear();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Movimiento realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Limpiar los TextBox
                asiento.Clear();
                subtotal.Clear();
                factura.Clear();
                pel.Clear();
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalogo frm = new Catalogo();
            frm.Show();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }
    }
}
