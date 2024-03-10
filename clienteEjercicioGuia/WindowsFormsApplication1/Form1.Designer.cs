namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alto = new System.Windows.Forms.TextBox();
            this.ALTURA = new System.Windows.Forms.Label();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.conn = new System.Windows.Forms.Button();
            this.Descon = new System.Windows.Forms.Button();
            this.confirmalto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.confirmalto);
            this.groupBox1.Controls.Add(this.alto);
            this.groupBox1.Controls.Add(this.ALTURA);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // alto
            // 
            this.alto.Location = new System.Drawing.Point(17, 135);
            this.alto.Name = "alto";
            this.alto.Size = new System.Drawing.Size(100, 22);
            this.alto.TabIndex = 10;
            // 
            // ALTURA
            // 
            this.ALTURA.AutoSize = true;
            this.ALTURA.Location = new System.Drawing.Point(34, 116);
            this.ALTURA.Name = "ALTURA";
            this.ALTURA.Size = new System.Drawing.Size(61, 16);
            this.ALTURA.TabIndex = 9;
            this.ALTURA.Text = "ALTURA";
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 112);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(209, 20);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(197, 20);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // conn
            // 
            this.conn.Location = new System.Drawing.Point(53, 50);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(104, 38);
            this.conn.TabIndex = 7;
            this.conn.Text = "Conectar";
            this.conn.UseVisualStyleBackColor = true;
            this.conn.Click += new System.EventHandler(this.conn_Click);
            // 
            // Descon
            // 
            this.Descon.Location = new System.Drawing.Point(278, 50);
            this.Descon.Name = "Descon";
            this.Descon.Size = new System.Drawing.Size(143, 38);
            this.Descon.TabIndex = 8;
            this.Descon.Text = "Desconectar";
            this.Descon.UseVisualStyleBackColor = true;
            this.Descon.Click += new System.EventHandler(this.Descon_Click);
            // 
            // confirmalto
            // 
            this.confirmalto.AutoSize = true;
            this.confirmalto.Location = new System.Drawing.Point(155, 140);
            this.confirmalto.Name = "confirmalto";
            this.confirmalto.Size = new System.Drawing.Size(123, 20);
            this.confirmalto.TabIndex = 11;
            this.confirmalto.TabStop = true;
            this.confirmalto.Text = "Dime si soy alto";
            this.confirmalto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.Descon);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button conn;
        private System.Windows.Forms.Button Descon;
        private System.Windows.Forms.TextBox alto;
        private System.Windows.Forms.Label ALTURA;
        private System.Windows.Forms.RadioButton confirmalto;
    }
}

