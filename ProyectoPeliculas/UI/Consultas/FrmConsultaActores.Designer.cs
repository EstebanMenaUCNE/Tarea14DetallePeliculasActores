namespace ProyectoPeliculas.UI.Consultas
{
    partial class FrmConsultaActores
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
            this.ActoresDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActoresDataGridView
            // 
            this.ActoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActoresDataGridView.Location = new System.Drawing.Point(21, 77);
            this.ActoresDataGridView.Name = "ActoresDataGridView";
            this.ActoresDataGridView.Size = new System.Drawing.Size(240, 150);
            this.ActoresDataGridView.TabIndex = 0;
            // 
            // FrmConsultaActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ActoresDataGridView);
            this.Name = "FrmConsultaActores";
            this.Text = "Consulta de Actores";
            this.Load += new System.EventHandler(this.FrmConsultaActores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActoresDataGridView;
    }
}