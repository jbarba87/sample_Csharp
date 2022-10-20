
namespace POO.Aplicaciones
{
    partial class frmPagos
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPlanilla = new System.Windows.Forms.RadioButton();
            this.rbContratado = new System.Windows.Forms.RadioButton();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstArea = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaContratado = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBasico = new System.Windows.Forms.TextBox();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // rbPlanilla
            // 
            this.rbPlanilla.AutoSize = true;
            this.rbPlanilla.Location = new System.Drawing.Point(114, 98);
            this.rbPlanilla.Name = "rbPlanilla";
            this.rbPlanilla.Size = new System.Drawing.Size(58, 17);
            this.rbPlanilla.TabIndex = 8;
            this.rbPlanilla.TabStop = true;
            this.rbPlanilla.Text = "Planilla";
            this.rbPlanilla.UseVisualStyleBackColor = true;
            // 
            // rbContratado
            // 
            this.rbContratado.AutoSize = true;
            this.rbContratado.Location = new System.Drawing.Point(193, 98);
            this.rbContratado.Name = "rbContratado";
            this.rbContratado.Size = new System.Drawing.Size(77, 17);
            this.rbContratado.TabIndex = 9;
            this.rbContratado.TabStop = true;
            this.rbContratado.Text = "Contratado";
            this.rbContratado.UseVisualStyleBackColor = true;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Jefe",
            "Supervisor",
            "Otro"});
            this.cboCargo.Location = new System.Drawing.Point(117, 69);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCargo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Area";
            // 
            // lstArea
            // 
            this.lstArea.FormattingEnabled = true;
            this.lstArea.Items.AddRange(new object[] {
            "Ventas",
            "Sistemas",
            "RRHH",
            "Producción"});
            this.lstArea.Location = new System.Drawing.Point(27, 185);
            this.lstArea.Name = "lstArea";
            this.lstArea.Size = new System.Drawing.Size(120, 95);
            this.lstArea.TabIndex = 12;
            this.lstArea.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Contrato";
            // 
            // dtpFechaContratado
            // 
            this.dtpFechaContratado.Location = new System.Drawing.Point(134, 121);
            this.dtpFechaContratado.Name = "dtpFechaContratado";
            this.dtpFechaContratado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaContratado.TabIndex = 14;
            this.dtpFechaContratado.ValueChanged += new System.EventHandler(this.dtpFechaContratado_ValueChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(374, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(374, 61);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(374, 103);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Básico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bonificación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Neto";
            // 
            // txtBasico
            // 
            this.txtBasico.Location = new System.Drawing.Point(349, 182);
            this.txtBasico.Name = "txtBasico";
            this.txtBasico.Size = new System.Drawing.Size(100, 20);
            this.txtBasico.TabIndex = 23;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Location = new System.Drawing.Point(349, 205);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(100, 20);
            this.txtBonificacion.TabIndex = 24;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(349, 228);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 25;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(349, 251);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 20);
            this.txtNeto.TabIndex = 26;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 302);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtBonificacion);
            this.Controls.Add(this.txtBasico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpFechaContratado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.rbContratado);
            this.Controls.Add(this.rbPlanilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPlanilla;
        private System.Windows.Forms.RadioButton rbContratado;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaContratado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBasico;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtNeto;
    }
}