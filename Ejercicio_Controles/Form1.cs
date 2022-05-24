using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Controles
{
    public partial class Ejer_Controles : Form
    {
        public Ejer_Controles()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //hola
        }

        private void bt_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";      
            CB_NACIONALIDAD.SelectedIndex = 0;
            lst_preferencia.Items.Clear();
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            //Agregar preferencias
            //lst_preferencia.Items.Add("");

        }

        private void bt_agregar_Click(object sender, EventArgs e )
        {
            if (txt_lista.Text !="" )

            {
                lst_preferencia.Items.Add(txt_lista.Text);
                txt_lista.Text = "";
                txt_lista.Focus();
            }
            else
            {
                MessageBox.Show("Ese valor no es valido, una preferencia");
                txt_lista.Focus();
            }
      
        }

       private void bt_borrar_Click(object sender, EventArgs e)
        {
            //lst_preferencia.Items.Clear();
        }

        private void txt_lista_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_agregar_MouseEnter(object sender, EventArgs e)
        {
            bt_agregar.BackColor = Color.Coral;
        }

        private void bt_agregar_MouseLeave(object sender, EventArgs e)
        {
            bt_agregar.BackColor = Color.Silver;
        }

        private void bt_Nuevo_MouseEnter(object sender, EventArgs e)
        {
            bt_Nuevo.BackColor = Color.Fuchsia;
        }

        private void bt_Nuevo_MouseLeave(object sender, EventArgs e)
        {
            bt_Nuevo.BackColor = Color.Aqua;
        }

        private void bt_Salir_MouseEnter(object sender, EventArgs e)
        {
            bt_Salir.BackColor = Color.DarkSalmon;
        }

        private void bt_Salir_MouseLeave(object sender, EventArgs e)
        {
           bt_Salir.BackColor = Color.Red;
        }

        private void bt_borrar_MouseEnter(object sender, EventArgs e)
        {
            bt_borrar.BackColor = Color.Indigo;
        }

        private void bt_borrar_MouseLeave(object sender, EventArgs e)
        {
            bt_borrar.BackColor = Color.DarkMagenta;
        }

        private void txt_Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_preferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
