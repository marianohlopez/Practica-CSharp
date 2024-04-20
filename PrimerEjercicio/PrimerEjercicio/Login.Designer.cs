namespace PrimerEjercicio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(328, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(142, 23);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "LOGIN";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(512, 255);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(148, 36);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(422, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(422, 163);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(217, 23);
            txtClave.TabIndex = 4;
            txtClave.Text = "Contraseña";
            txtClave.Enter += txtClave_Enter;
            txtClave.Leave += txtClave_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBox1;
        private Button btnAceptar;
        private TextBox txtUsuario;
        private TextBox txtClave;
    }
}