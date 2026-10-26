namespace Actividad_2_pogra_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblmatricula = new Label();
            txtmatricula = new TextBox();
            txtnombre = new TextBox();
            lblnombre = new Label();
            txtgrupo = new TextBox();
            lblgrupo = new Label();
            nudsemestre = new NumericUpDown();
            lblsemestre = new Label();
            txtespecialidad = new TextBox();
            lblespecialidad = new Label();
            btnguardar = new Button();
            btnmostrar = new Button();
            btnlimpiar = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudsemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblmatricula
            // 
            lblmatricula.AutoSize = true;
            lblmatricula.Location = new Point(43, 57);
            lblmatricula.Name = "lblmatricula";
            lblmatricula.Size = new Size(57, 15);
            lblmatricula.TabIndex = 0;
            lblmatricula.Text = "Matricula";
            // 
            // txtmatricula
            // 
            txtmatricula.Location = new Point(128, 54);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(100, 23);
            txtmatricula.TabIndex = 1;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(128, 93);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(43, 96);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 2;
            lblnombre.Text = "Nombre";
            // 
            // txtgrupo
            // 
            txtgrupo.Location = new Point(366, 88);
            txtgrupo.Name = "txtgrupo";
            txtgrupo.Size = new Size(100, 23);
            txtgrupo.TabIndex = 5;
            // 
            // lblgrupo
            // 
            lblgrupo.AutoSize = true;
            lblgrupo.Location = new Point(281, 91);
            lblgrupo.Name = "lblgrupo";
            lblgrupo.Size = new Size(40, 15);
            lblgrupo.TabIndex = 4;
            lblgrupo.Text = "Grupo";
            // 
            // nudsemestre
            // 
            nudsemestre.Location = new Point(355, 51);
            nudsemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudsemestre.Name = "nudsemestre";
            nudsemestre.Size = new Size(120, 23);
            nudsemestre.TabIndex = 6;
            nudsemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudsemestre.ValueChanged += nudsemestre_ValueChanged;
            // 
            // lblsemestre
            // 
            lblsemestre.AutoSize = true;
            lblsemestre.Location = new Point(276, 51);
            lblsemestre.Name = "lblsemestre";
            lblsemestre.Size = new Size(55, 15);
            lblsemestre.TabIndex = 7;
            lblsemestre.Text = "Semestre";
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(366, 137);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(100, 23);
            txtespecialidad.TabIndex = 9;
            // 
            // lblespecialidad
            // 
            lblespecialidad.AutoSize = true;
            lblespecialidad.Location = new Point(281, 140);
            lblespecialidad.Name = "lblespecialidad";
            lblespecialidad.Size = new Size(72, 15);
            lblespecialidad.TabIndex = 8;
            lblespecialidad.Text = "Especialidad";
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(637, 49);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(637, 96);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(75, 23);
            btnmostrar.TabIndex = 11;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(637, 142);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 12;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(-1, 185);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(803, 265);
            dgv.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmostrar);
            Controls.Add(btnguardar);
            Controls.Add(txtespecialidad);
            Controls.Add(lblespecialidad);
            Controls.Add(lblsemestre);
            Controls.Add(nudsemestre);
            Controls.Add(txtgrupo);
            Controls.Add(lblgrupo);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(txtmatricula);
            Controls.Add(lblmatricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudsemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmatricula;
        private TextBox txtmatricula;
        private TextBox txtnombre;
        private Label lblnombre;
        private TextBox txtgrupo;
        private Label lblgrupo;
        private NumericUpDown nudsemestre;
        private Label lblsemestre;
        private TextBox txtespecialidad;
        private Label lblespecialidad;
        private Button btnguardar;
        private Button btnmostrar;
        private Button btnlimpiar;
        private DataGridView dgv;
    }
}
