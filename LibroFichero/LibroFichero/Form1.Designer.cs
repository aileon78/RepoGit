namespace LibroFichero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.TBAny = new System.Windows.Forms.TextBox();
            this.TBAutor = new System.Windows.Forms.TextBox();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBContenido = new System.Windows.Forms.TextBox();
            this.CBDimensiones = new System.Windows.Forms.ComboBox();
            this.TBPaginas = new System.Windows.Forms.TextBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BTMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contenido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dimensiones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Páginas";
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(27, 304);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 7;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // TBTitulo
            // 
            this.TBTitulo.Location = new System.Drawing.Point(128, 17);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(100, 20);
            this.TBTitulo.TabIndex = 8;
            // 
            // TBAny
            // 
            this.TBAny.Location = new System.Drawing.Point(128, 52);
            this.TBAny.Name = "TBAny";
            this.TBAny.Size = new System.Drawing.Size(100, 20);
            this.TBAny.TabIndex = 9;
            // 
            // TBAutor
            // 
            this.TBAutor.Location = new System.Drawing.Point(128, 87);
            this.TBAutor.Name = "TBAutor";
            this.TBAutor.Size = new System.Drawing.Size(100, 20);
            this.TBAutor.TabIndex = 10;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(128, 128);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(100, 20);
            this.TBColor.TabIndex = 11;
            // 
            // TBContenido
            // 
            this.TBContenido.Location = new System.Drawing.Point(128, 165);
            this.TBContenido.Name = "TBContenido";
            this.TBContenido.Size = new System.Drawing.Size(100, 20);
            this.TBContenido.TabIndex = 12;
            // 
            // CBDimensiones
            // 
            this.CBDimensiones.FormattingEnabled = true;
            this.CBDimensiones.Items.AddRange(new object[] {
            "60x60",
            "90x90"});
            this.CBDimensiones.Location = new System.Drawing.Point(128, 201);
            this.CBDimensiones.Name = "CBDimensiones";
            this.CBDimensiones.Size = new System.Drawing.Size(121, 21);
            this.CBDimensiones.TabIndex = 13;
            // 
            // TBPaginas
            // 
            this.TBPaginas.Location = new System.Drawing.Point(128, 243);
            this.TBPaginas.Name = "TBPaginas";
            this.TBPaginas.Size = new System.Drawing.Size(100, 20);
            this.TBPaginas.TabIndex = 14;
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(310, 17);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(219, 246);
            this.RTB1.TabIndex = 15;
            this.RTB1.Text = "";
            // 
            // BTMostrar
            // 
            this.BTMostrar.Location = new System.Drawing.Point(392, 304);
            this.BTMostrar.Name = "BTMostrar";
            this.BTMostrar.Size = new System.Drawing.Size(75, 23);
            this.BTMostrar.TabIndex = 16;
            this.BTMostrar.Text = "Mostrar";
            this.BTMostrar.UseVisualStyleBackColor = true;
            this.BTMostrar.Click += new System.EventHandler(this.BTMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 360);
            this.Controls.Add(this.BTMostrar);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.TBPaginas);
            this.Controls.Add(this.CBDimensiones);
            this.Controls.Add(this.TBContenido);
            this.Controls.Add(this.TBColor);
            this.Controls.Add(this.TBAutor);
            this.Controls.Add(this.TBAny);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.TextBox TBAny;
        private System.Windows.Forms.TextBox TBAutor;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBContenido;
        private System.Windows.Forms.ComboBox CBDimensiones;
        private System.Windows.Forms.TextBox TBPaginas;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTMostrar;
    }
}

