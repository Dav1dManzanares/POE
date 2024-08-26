namespace WinFormsTarea
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            name = new TextBox();
            carrera = new TextBox();
            txtmat = new TextBox();
            direccion = new TextBox();
            telefono = new TextBox();
            correo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(27, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 118);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            Column1.HeaderText = "carrera";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Matricula";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Direccion";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Correo";
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Location = new Point(78, 144);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Location = new Point(77, 189);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Carrera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Highlight;
            label3.Location = new Point(77, 242);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Highlight;
            label4.Location = new Point(77, 283);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Dirrecion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Highlight;
            label5.Location = new Point(77, 320);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HotTrack;
            label6.Location = new Point(84, 363);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 6;
            label6.Text = "Correo";
            // 
            // name
            // 
            name.Location = new Point(162, 141);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 7;
            // 
            // carrera
            // 
            carrera.Location = new Point(162, 186);
            carrera.Name = "carrera";
            carrera.Size = new Size(100, 23);
            carrera.TabIndex = 8;
            // 
            // txtmat
            // 
            txtmat.Location = new Point(162, 234);
            txtmat.Name = "txtmat";
            txtmat.Size = new Size(100, 23);
            txtmat.TabIndex = 9;
            // 
            // direccion
            // 
            direccion.Location = new Point(162, 275);
            direccion.Name = "direccion";
            direccion.Size = new Size(100, 23);
            direccion.TabIndex = 10;
            // 
            // telefono
            // 
            telefono.Location = new Point(162, 312);
            telefono.Name = "telefono";
            telefono.Size = new Size(100, 23);
            telefono.TabIndex = 11;
            // 
            // correo
            // 
            correo.Location = new Point(162, 355);
            correo.Name = "correo";
            correo.Size = new Size(100, 23);
            correo.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(71, 412);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Location = new Point(221, 412);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Location = new Point(384, 412);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Visualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(533, 412);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Highlight;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(487, 189);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 17;
            label7.Text = "Lista de matricula";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(correo);
            Controls.Add(telefono);
            Controls.Add(direccion);
            Controls.Add(txtmat);
            Controls.Add(carrera);
            Controls.Add(name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn Nombre;
        public TextBox name;
        public TextBox carrera;
        public TextBox txtmat;
        public TextBox direccion;
        public TextBox telefono;
        public TextBox correo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label7;
    }
}
