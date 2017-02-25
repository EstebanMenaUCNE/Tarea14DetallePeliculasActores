using ProyectoPeliculas.Entidades;
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
        Pelicula pelicula = new Pelicula();

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

        private void LLenarComboCategorias()
        {
            categoriaComboBox.DataSource = BLL.CategoriaBLL.GetList();
            categoriaComboBox.DisplayMember = "Descripcion";
            categoriaComboBox.ValueMember = "CategoriaId";
        }

        private void LLenarComboActores()
        {
            actoresComboBox.DataSource = BLL.ActorBLL.GetList();
            actoresComboBox.DisplayMember = "Nombres";
            actoresComboBox.ValueMember = "ActorId";
        }

        private void LlenarGridActores()
        {
            ActoresDataGridView.DataSource = pelicula.Actores;
        }

        private void LlenarCamposPelicula()
        {
            pelicula.PeliculaId = Utilidades.ToInt(peliculaIdTextBox.Text);
            pelicula.Estreno = estrenoDateTimePicker.Value;
            pelicula.Descripcion = descripcionTextBox.Text;
            pelicula.CategoriaId = Convert.ToInt32(categoriaComboBox.SelectedValue);
        }

        private void FrmRegistroPeliculas_Load(object sender, EventArgs e)
        {
            LLenarComboCategorias();
            LLenarComboActores();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarCamposPelicula();
            if (Validar())
            {
                if (BLL.PeliculaBLL.Guardar(pelicula))
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
                pelicula = BLL.PeliculaBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));
                
                if (pelicula != null)
                {
                    estrenoDateTimePicker.Value = pelicula.Estreno;
                    descripcionTextBox.Text = pelicula.Descripcion;
                    categoriaComboBox.Text = pelicula.CategoriaId.ToString();
                    LlenarGridActores();
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }

        private void AnadirCategoriaButton_Click(object sender, EventArgs e)
        {
            pelicula.Actores.Add((Actor)actoresComboBox.SelectedItem);
            LlenarGridActores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
