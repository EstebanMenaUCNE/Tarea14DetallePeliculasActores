namespace ProyectoPeliculas.UI.Registros
{
    partial class FrmRegistroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usuarioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label claveLabel;
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.NombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClaveErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            usuarioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NombreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioIdLabel
            // 
            usuarioIdLabel.AutoSize = true;
            usuarioIdLabel.Location = new System.Drawing.Point(39, 85);
            usuarioIdLabel.Name = "usuarioIdLabel";
            usuarioIdLabel.Size = new System.Drawing.Size(58, 13);
            usuarioIdLabel.TabIndex = 1;
            usuarioIdLabel.Text = "Usuario Id:";
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.Location = new System.Drawing.Point(103, 82);
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(56, 20);
            this.usuarioIdTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 111);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(103, 108);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(137, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(39, 137);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 5;
            claveLabel.Text = "Clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(103, 134);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(137, 20);
            this.claveTextBox.TabIndex = 6;
            // 
            // NombreErrorProvider
            // 
            this.NombreErrorProvider.ContainerControl = this;
            // 
            // ClaveErrorProvider
            // 
            this.ClaveErrorProvider.ContainerControl = this;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(22, 186);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(103, 186);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(184, 186);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(165, 80);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FrmRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(usuarioIdLabel);
            this.Controls.Add(this.usuarioIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Name = "FrmRegistroUsuarios";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.FrmRegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.ErrorProvider NombreErrorProvider;
        private System.Windows.Forms.ErrorProvider ClaveErrorProvider;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}