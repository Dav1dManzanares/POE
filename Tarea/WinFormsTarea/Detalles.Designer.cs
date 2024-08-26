namespace WinFormsTarea
{
    partial class Detalles
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
            cerrar = new Button();
            name2 = new TextBox();
            carrera2 = new TextBox();
            txtmat2 = new TextBox();
            dirrecion2 = new TextBox();
            telefono2 = new TextBox();
            correo2 = new TextBox();
            SuspendLayout();
            // 
            // cerrar
            // 
            cerrar.Location = new Point(211, 368);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(75, 23);
            cerrar.TabIndex = 0;
            cerrar.Text = "Aceptar";
            cerrar.UseVisualStyleBackColor = true;
            cerrar.Click += cerrar_Click;
            // 
            // name2
            // 
            name2.Location = new Point(120, 31);
            name2.Name = "name2";
            name2.Size = new Size(100, 23);
            name2.TabIndex = 1;
            // 
            // carrera2
            // 
            carrera2.Location = new Point(121, 93);
            carrera2.Name = "carrera2";
            carrera2.Size = new Size(100, 23);
            carrera2.TabIndex = 2;
            // 
            // txtmat2
            // 
            txtmat2.Location = new Point(124, 153);
            txtmat2.Name = "txtmat2";
            txtmat2.Size = new Size(100, 23);
            txtmat2.TabIndex = 3;
            // 
            // dirrecion2
            // 
            dirrecion2.Location = new Point(126, 207);
            dirrecion2.Name = "dirrecion2";
            dirrecion2.Size = new Size(100, 23);
            dirrecion2.TabIndex = 4;
            // 
            // telefono2
            // 
            telefono2.Location = new Point(126, 264);
            telefono2.Name = "telefono2";
            telefono2.Size = new Size(100, 23);
            telefono2.TabIndex = 5;
            // 
            // correo2
            // 
            correo2.Location = new Point(131, 317);
            correo2.Name = "correo2";
            correo2.Size = new Size(100, 23);
            correo2.TabIndex = 6;
            // 
            // Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(correo2);
            Controls.Add(telefono2);
            Controls.Add(dirrecion2);
            Controls.Add(txtmat2);
            Controls.Add(carrera2);
            Controls.Add(name2);
            Controls.Add(cerrar);
            Name = "Detalles";
            Text = "Detalles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cerrar;
        public TextBox name2;
        public TextBox carrera2;
        public TextBox txtmat2;
        public TextBox dirrecion2;
        public TextBox telefono2;
        public TextBox correo2;
    }
}