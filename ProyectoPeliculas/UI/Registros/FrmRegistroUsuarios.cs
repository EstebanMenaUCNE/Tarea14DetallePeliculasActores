using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPeliculas.UI.Registros
{
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            usuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            claveTextBox.Clear();
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                NombreErrorProvider.SetError(nombreTextBox, "Por favor digite el nombre");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(claveTextBox.Text))
            {
                ClaveErrorProvider.SetError(claveTextBox, "Por favor digite la clave");
                retorno = false;
            }
            return retorno;
        }

        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (BLL.UsuarioBLL.Guardar(new Entidades.Usuario(nombreTextBox.Text, claveTextBox.Text)))
                {
                    MessageBox.Show("Guardado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar...");
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(usuarioIdTextBox.Text))
            {
                Entidades.Usuario usuario = BLL.UsuarioBLL.Buscar(Convert.ToInt32(usuarioIdTextBox.Text));
                if (usuario != null)
                {
                    nombreTextBox.Text = usuario.Nombre;
                    claveTextBox.Text = usuario.Clave;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuarioIdTextBox.Text))
            {
                if(BLL.UsuarioBLL.Eliminar(Convert.ToInt32(usuarioIdTextBox.Text)))
                {
                    MessageBox.Show("Eliminado con éxito!");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar...");
                }
            }
        }
    }
}
