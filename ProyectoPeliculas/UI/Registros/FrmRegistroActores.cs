using ProyectoPeliculas.BLL;
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
    public partial class FrmRegistroActores : Form
    {
        private Actor actor = new Actor();

        public FrmRegistroActores()
        {
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            actorIdTextBox.Clear();
            nombresTextBox.Clear();
            nombresTextBox.Focus();
        }

        private void LlenarCamposActor()
        {
            actor.ActorId = Utilidades.ToInt(actorIdTextBox.Text);
            actor.Nombres = nombresTextBox.Text;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(nombresTextBox.Text))
            {
                NombresErrorProvider.SetError(nombresTextBox, "Por favor digite los nombres");
                return false;
            }
            return true;
        }

        private void FrmRegistroActores_Load(object sender, EventArgs e)
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
                LlenarCamposActor();
                if (ActorBLL.Guardar(actor))
                {
                    MessageBox.Show("Guardado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(actorIdTextBox.Text))
            {
                LlenarCamposActor();
                if (ActorBLL.Eliminar(actor.ActorId))
                {
                    MessageBox.Show("Eliminado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar");
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(actorIdTextBox.Text))
            {
                actor = ActorBLL.Buscar(Utilidades.ToInt(actorIdTextBox.Text));
                if (actor != null)
                {
                    actorIdTextBox.Text = actor.ActorId.ToString();
                    nombresTextBox.Text = actor.Nombres;
                }
                else
                {
                    MessageBox.Show("No Encontrado...");
                }
            }
        }
    }
}
