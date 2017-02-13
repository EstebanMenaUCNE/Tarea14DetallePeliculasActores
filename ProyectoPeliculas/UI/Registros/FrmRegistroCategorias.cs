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
    public partial class FrmRegistroCategorias : Form
    {
        public FrmRegistroCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            categoriaIdTextBox.Clear();
            descripcionTextBox.Clear();
            descripcionTextBox.Focus();
        }

        private bool Validar()
        {
            if(string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                DescripcionErrorProvider.SetError(descripcionTextBox, "Por favor digite la descripción");
                return false;
            }
            return true;
        }

        private void FrmRegistroCategorias_Load(object sender, EventArgs e)
        {
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                int id = 0;
                if (!string.IsNullOrWhiteSpace(categoriaIdTextBox.Text))
                {
                    id = Convert.ToInt32(categoriaIdTextBox.Text);
                }
                if (BLL.CategoriaBLL.Guardar(new Entidades.Categoria(id, descripcionTextBox.Text)))
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoriaIdTextBox.Text))
            {
                if (BLL.CategoriaBLL.Eliminar(Convert.ToInt32(categoriaIdTextBox.Text)))
                {
                    MessageBox.Show("Eliminado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar...");
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoriaIdTextBox.Text))
            {
                Entidades.Categoria categoria = BLL.CategoriaBLL.Buscar(Convert.ToInt32(categoriaIdTextBox.Text));
                if (categoria != null)
                {
                    descripcionTextBox.Text = categoria.Descripcion;
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }
    }
}
