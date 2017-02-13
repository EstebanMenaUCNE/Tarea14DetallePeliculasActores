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
    public partial class FrmConsultaCategorias : Form
    {
        public FrmConsultaCategorias()
        {
            InitializeComponent();
        }

        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            CategoriasDataGridView.DataSource = BLL.CategoriaBLL.GetList();
        }
    }
}
