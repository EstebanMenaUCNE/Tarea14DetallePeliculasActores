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
    public partial class FrmRegistroPeliculas : Form
    {
        public FrmRegistroPeliculas()
        {
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            peliculaIdTextBox.Clear();
            estrenoDateTimePicker.Value = DateTime.Today;
            descripcionTextBox.Clear();
            descripcionTextBox.Focus();
        }

        private bool Validar()
        {
            if(string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                DescripcionErrorProvider.SetError(descripcionTextBox, "Por favor digite la descripcion");
                return false;
            }
            return true;
        }

        private void LLenarCombo()
        {
            categoriaIdComboBox.DataSource = BLL.CategoriaBLL.GetList();
            categoriaIdComboBox.DisplayMember = "Descripcion";
            categoriaIdComboBox.ValueMember = "CategoriaId";
        }

        private void FrmRegistroPeliculas_Load(object sender, EventArgs e)
        {
            LLenarCombo();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                if (BLL.PeliculaBLL.Guardar(new Entidades.Pelicula(estrenoDateTimePicker.Value, descripcionTextBox.Text, Convert.ToInt32(categoriaIdComboBox.SelectedValue))))
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
            if(!string.IsNullOrWhiteSpace(peliculaIdTextBox.Text))
            {
                if (BLL.PeliculaBLL.Eliminar(Convert.ToInt32(peliculaIdTextBox.Text)))
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
            if (!string.IsNullOrWhiteSpace(peliculaIdTextBox.Text))
            {
                Entidades.Pelicula pelicula = BLL.PeliculaBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));
                
                if (pelicula != null)
                {
                    //estrenoDateTimePicker.Value = pelicula.Estreno;
                    descripcionTextBox.Text = pelicula.Descripcion;
                    categoriaIdComboBox.Text = pelicula.CategoriaId.ToString();
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }
    }
}
