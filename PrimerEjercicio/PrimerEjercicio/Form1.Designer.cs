namespace PrimerEjercicio
{
    partial class PrimerEjercicio
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            BtnCalculo = new Button();
            comboBox1 = new ComboBox();
            labelTipo = new Label();
            dtgvDatos = new DataGridView();
            cellNombre = new DataGridViewTextBoxColumn();
            cellApellido = new DataGridViewTextBoxColumn();
            cellDocumento = new DataGridViewTextBoxColumn();
            cellTipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(164, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 126);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(164, 123);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(366, 27);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(95, 30);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(366, 74);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 31);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // BtnCalculo
            // 
            BtnCalculo.Location = new Point(615, 34);
            BtnCalculo.Name = "BtnCalculo";
            BtnCalculo.Size = new Size(105, 23);
            BtnCalculo.TabIndex = 8;
            BtnCalculo.Text = "Calculo";
            BtnCalculo.UseVisualStyleBackColor = true;
            BtnCalculo.Click += BtnCalculo_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DNI", "PASAPORTE", "EXTRANJERO" });
            comboBox1.Location = new Point(164, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 9;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(93, 177);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 10;
            labelTipo.Text = "Tipo";
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new DataGridViewColumn[] { cellNombre, cellApellido, cellDocumento, cellTipo });
            dtgvDatos.Location = new Point(337, 188);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.Size = new Size(444, 150);
            dtgvDatos.TabIndex = 11;
            dtgvDatos.CellClick += dtgvDatos_CellClick;
            // 
            // cellNombre
            // 
            cellNombre.HeaderText = "Nombre";
            cellNombre.Name = "cellNombre";
            // 
            // cellApellido
            // 
            cellApellido.HeaderText = "Apellido";
            cellApellido.Name = "cellApellido";
            // 
            // cellDocumento
            // 
            cellDocumento.HeaderText = "Documento";
            cellDocumento.Name = "cellDocumento";
            // 
            // cellTipo
            // 
            cellTipo.HeaderText = "Tipo";
            cellTipo.Name = "cellTipo";
            // 
            // PrimerEjercicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(793, 450);
            Controls.Add(dtgvDatos);
            Controls.Add(labelTipo);
            Controls.Add(comboBox1);
            Controls.Add(BtnCalculo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "PrimerEjercicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimerEjercicio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button BtnCalculo;
        private ComboBox comboBox1;
        private Label labelTipo;
        private DataGridView dtgvDatos;
        private DataGridViewTextBoxColumn cellNombre;
        private DataGridViewTextBoxColumn cellApellido;
        private DataGridViewTextBoxColumn cellDocumento;
        private DataGridViewTextBoxColumn cellTipo;
    }
}
