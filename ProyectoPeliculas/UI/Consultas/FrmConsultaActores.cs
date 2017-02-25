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
    public partial class FrmConsultaActores : Form
    {
        public FrmConsultaActores()
        {
            InitializeComponent();
        }

        private void LlenarGridActores()
        {
            ActoresDataGridView.DataSource = BLL.ActorBLL.GetList();
        }

        private void FrmConsultaActores_Load(object sender, EventArgs e)
        {
            LlenarGridActores();
        }
    }
}
