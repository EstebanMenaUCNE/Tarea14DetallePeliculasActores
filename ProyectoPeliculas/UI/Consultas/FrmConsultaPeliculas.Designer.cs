namespace ProyectoPeliculas.UI.Consultas
{
    partial class FrmConsultaPeliculas
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
            this.PeliculasDataGridView = new System.Windows.Forms.DataGridView();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrarPorComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorLabel = new System.Windows.Forms.Label();
            this.FiltrarTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculasDataGridView
            // 
            this.PeliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasDataGridView.Location = new System.Drawing.Point(21, 103);
            this.PeliculasDataGridView.Name = "PeliculasDataGridView";
            this.PeliculasDataGridView.Size = new System.Drawing.Size(415, 150);
            this.PeliculasDataGridView.TabIndex = 0;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(37, 67);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(38, 13);
            this.DesdeLabel.TabIndex = 2;
            this.DesdeLabel.Text = "Desde";
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(232, 67);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(35, 13);
            this.HastaLabel.TabIndex = 4;
            this.HastaLabel.Text = "Hasta";
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(353, 32);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(57, 23);
            this.FiltrarButton.TabIndex = 5;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(94, 61);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DesdeDateTimePicker.TabIndex = 6;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(289, 61);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.HastaDateTimePicker.TabIndex = 7;
            // 
            // FiltrarPorComboBox
            // 
            this.FiltrarPorComboBox.FormattingEnabled = true;
            this.FiltrarPorComboBox.Location = new System.Drawing.Point(94, 34);
            this.FiltrarPorComboBox.Name = "FiltrarPorComboBox";
            this.FiltrarPorComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarPorComboBox.TabIndex = 8;
            this.FiltrarPorComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrarPorComboBox_SelectedIndexChanged);
            // 
            // FiltrarPorLabel
            // 
            this.FiltrarPorLabel.AutoSize = true;
            this.FiltrarPorLabel.Location = new System.Drawing.Point(37, 37);
            this.FiltrarPorLabel.Name = "FiltrarPorLabel";
            this.FiltrarPorLabel.Size = new System.Drawing.Size(51, 13);
            this.FiltrarPorLabel.TabIndex = 9;
            this.FiltrarPorLabel.Text = "Filtrar Por";
            // 
            // FiltrarTextBox
            // 
            this.FiltrarTextBox.Location = new System.Drawing.Point(235, 35);
            this.FiltrarTextBox.Name = "FiltrarTextBox";
            this.FiltrarTextBox.Size = new System.Drawing.Size(112, 20);
            this.FiltrarTextBox.TabIndex = 10;
            // 
            // FrmConsultaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 282);
            this.Controls.Add(this.FiltrarTextBox);
            this.Controls.Add(this.FiltrarPorLabel);
            this.Controls.Add(this.FiltrarPorComboBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.PeliculasDataGridView);
            this.Name = "FrmConsultaPeliculas";
            this.Text = "Consulta de Peliculas";
            this.Load += new System.EventHandler(this.FrmConsultaPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculasDataGridView;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.ComboBox FiltrarPorComboBox;
        private System.Windows.Forms.Label FiltrarPorLabel;
        private System.Windows.Forms.TextBox FiltrarTextBox;
    }
}