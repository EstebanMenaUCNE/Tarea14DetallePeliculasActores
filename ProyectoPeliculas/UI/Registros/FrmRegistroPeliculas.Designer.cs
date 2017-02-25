namespace ProyectoPeliculas.UI.Registros
{
    partial class FrmRegistroPeliculas
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
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label ActoresLabel;
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.estrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.DescripcionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActoresGroupBox = new System.Windows.Forms.GroupBox();
            this.ActoresDataGridView = new System.Windows.Forms.DataGridView();
            this.AnadirActorButton = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.actoresComboBox = new System.Windows.Forms.ComboBox();
            peliculaIdLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ActoresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionErrorProvider)).BeginInit();
            this.ActoresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(40, 28);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(40, 55);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 3;
            estrenoLabel.Text = "Estreno:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(40, 80);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(40, 106);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(60, 13);
            categoriaIdLabel.TabIndex = 9;
            categoriaIdLabel.Text = "Categorias:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Location = new System.Drawing.Point(113, 25);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(67, 20);
            this.peliculaIdTextBox.TabIndex = 2;
            // 
            // estrenoDateTimePicker
            // 
            this.estrenoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.estrenoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.estrenoDateTimePicker.Location = new System.Drawing.Point(113, 51);
            this.estrenoDateTimePicker.Name = "estrenoDateTimePicker";
            this.estrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.estrenoDateTimePicker.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(113, 77);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(197, 23);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 18;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(234, 327);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(153, 327);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(72, 327);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // DescripcionErrorProvider
            // 
            this.DescripcionErrorProvider.ContainerControl = this;
            // 
            // ActoresGroupBox
            // 
            this.ActoresGroupBox.Controls.Add(ActoresLabel);
            this.ActoresGroupBox.Controls.Add(this.ActoresDataGridView);
            this.ActoresGroupBox.Controls.Add(this.AnadirActorButton);
            this.ActoresGroupBox.Controls.Add(this.actoresComboBox);
            this.ActoresGroupBox.Location = new System.Drawing.Point(34, 136);
            this.ActoresGroupBox.Name = "ActoresGroupBox";
            this.ActoresGroupBox.Size = new System.Drawing.Size(319, 185);
            this.ActoresGroupBox.TabIndex = 19;
            this.ActoresGroupBox.TabStop = false;
            this.ActoresGroupBox.Text = "Actores de la Película";
            // 
            // ActoresDataGridView
            // 
            this.ActoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActoresDataGridView.Location = new System.Drawing.Point(7, 46);
            this.ActoresDataGridView.Name = "ActoresDataGridView";
            this.ActoresDataGridView.Size = new System.Drawing.Size(301, 124);
            this.ActoresDataGridView.TabIndex = 21;
            this.ActoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AnadirActorButton
            // 
            this.AnadirActorButton.Location = new System.Drawing.Point(285, 18);
            this.AnadirActorButton.Name = "AnadirActorButton";
            this.AnadirActorButton.Size = new System.Drawing.Size(25, 23);
            this.AnadirActorButton.TabIndex = 20;
            this.AnadirActorButton.Text = " +";
            this.AnadirActorButton.UseVisualStyleBackColor = true;
            this.AnadirActorButton.Click += new System.EventHandler(this.AnadirCategoriaButton_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(113, 103);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoriaComboBox.TabIndex = 10;
            // 
            // ActoresLabel
            // 
            ActoresLabel.AutoSize = true;
            ActoresLabel.Location = new System.Drawing.Point(6, 23);
            ActoresLabel.Name = "ActoresLabel";
            ActoresLabel.Size = new System.Drawing.Size(52, 13);
            ActoresLabel.TabIndex = 22;
            ActoresLabel.Text = "Peliculas:";
            // 
            // actoresComboBox
            // 
            this.actoresComboBox.FormattingEnabled = true;
            this.actoresComboBox.Location = new System.Drawing.Point(79, 20);
            this.actoresComboBox.Name = "actoresComboBox";
            this.actoresComboBox.Size = new System.Drawing.Size(200, 21);
            this.actoresComboBox.TabIndex = 23;
            // 
            // FrmRegistroPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 376);
            this.Controls.Add(this.ActoresGroupBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(estrenoLabel);
            this.Controls.Add(this.estrenoDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Name = "FrmRegistroPeliculas";
            this.Text = "Registro de Peliculas";
            this.Load += new System.EventHandler(this.FrmRegistroPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionErrorProvider)).EndInit();
            this.ActoresGroupBox.ResumeLayout(false);
            this.ActoresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.DateTimePicker estrenoDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider DescripcionErrorProvider;
        private System.Windows.Forms.GroupBox ActoresGroupBox;
        private System.Windows.Forms.DataGridView ActoresDataGridView;
        private System.Windows.Forms.Button AnadirActorButton;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.ComboBox actoresComboBox;
    }
}