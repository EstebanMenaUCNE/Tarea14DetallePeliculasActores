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
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            UsuariosDataGridView.DataSource = BLL.UsuarioBLL.GetList();
        }
    }
}
