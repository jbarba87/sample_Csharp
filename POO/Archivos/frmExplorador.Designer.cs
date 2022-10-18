
namespace POO.Archivos
{
    partial class frmExplorador
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
            this.lstCarpetas = new System.Windows.Forms.ListBox();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.cboDiscos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.Location = new System.Drawing.Point(2, 80);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.Size = new System.Drawing.Size(221, 368);
            this.lstCarpetas.TabIndex = 0;
            this.lstCarpetas.SelectedIndexChanged += new System.EventHandler(this.lstCarpetas_SelectedIndexChanged);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(237, 0);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(245, 446);
            this.lstArchivos.TabIndex = 1;
            this.lstArchivos.SelectedIndexChanged += new System.EventHandler(this.lstArchivos_SelectedIndexChanged);
            this.lstArchivos.DoubleClick += new System.EventHandler(this.lstArchivos_DoubleClick);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(497, 2);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(291, 444);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 2;
            this.pcbImagen.TabStop = false;
            // 
            // cboDiscos
            // 
            this.cboDiscos.FormattingEnabled = true;
            this.cboDiscos.Location = new System.Drawing.Point(2, 13);
            this.cboDiscos.Name = "cboDiscos";
            this.cboDiscos.Size = new System.Drawing.Size(221, 21);
            this.cboDiscos.TabIndex = 3;
            this.cboDiscos.SelectedIndexChanged += new System.EventHandler(this.cboDiscos_SelectedIndexChanged);
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDiscos);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.lstCarpetas);
            this.Name = "frmExplorador";
            this.Text = "frmExplorador";
            this.Load += new System.EventHandler(this.frmExplorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarpetas;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.ComboBox cboDiscos;
    }
}