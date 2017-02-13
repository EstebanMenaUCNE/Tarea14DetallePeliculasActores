using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPeliculas.UI.Consultas
{
    public partial class FrmConsultaPeliculas : Form
    {
        public FrmConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void LlenarCombo()
        {
            FiltrarPorComboBox.Items.Insert(0, "Descripcion");
            FiltrarPorComboBox.Items.Insert(1, "Id");
            FiltrarPorComboBox.Items.Insert(2, "Fecha");
            FiltrarPorComboBox.DataSource = FiltrarPorComboBox.Items;
            FiltrarPorComboBox.DisplayMember = "Id";
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            if (FiltrarPorComboBox.SelectedIndex == 0)
            {
                PeliculasDataGridView.DataSource = BLL.PeliculaBLL.GetListDescripcion(FiltrarTextBox.Text);
            }
            else
            {
                if (FiltrarPorComboBox.SelectedIndex == 1)
                {
                    if(!string.IsNullOrWhiteSpace(FiltrarTextBox.Text))
                    {
                        var lista = new List<Entidades.Pelicula>();
                        lista.Add(BLL.PeliculaBLL.Buscar(Convert.ToInt32(FiltrarTextBox.Text)));
                        PeliculasDataGridView.DataSource = lista;
                    }
                }
                else
                {
                    if (FiltrarPorComboBox.SelectedIndex == 2)
                    {
                        PeliculasDataGridView.DataSource = BLL.PeliculaBLL.GetListDate(DesdeDateTimePicker.Value, HastaDateTimePicker.Value);
                    }
                }
            }
        }

        private void FrmConsultaPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void FiltrarPorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
