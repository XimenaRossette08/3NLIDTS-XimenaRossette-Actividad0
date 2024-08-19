namespace _3NLIDTS_XimenaRossette_Actividad0
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttCelsiusFahrenheit = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.bttFahrenheitCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Temperatura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(588, 144);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(70, 16);
            this.lblFahrenheit.TabIndex = 2;
            this.lblFahrenheit.Text = "Fahrenheit";
            this.lblFahrenheit.Click += new System.EventHandler(this.lblFahrenheit_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(146, 144);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(51, 16);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "Celsius";
            this.lblCelsius.Click += new System.EventHandler(this.lblCelsius_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(576, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bttCelsiusFahrenheit
            // 
            this.bttCelsiusFahrenheit.Location = new System.Drawing.Point(89, 286);
            this.bttCelsiusFahrenheit.Name = "bttCelsiusFahrenheit";
            this.bttCelsiusFahrenheit.Size = new System.Drawing.Size(160, 23);
            this.bttCelsiusFahrenheit.TabIndex = 5;
            this.bttCelsiusFahrenheit.Text = "Celsius a Fahrenheit";
            this.bttCelsiusFahrenheit.UseVisualStyleBackColor = true;
            this.bttCelsiusFahrenheit.Click += new System.EventHandler(this.bttCelsiusFahrenheit_Click);
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(354, 286);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 6;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // bttFahrenheitCelsius
            // 
            this.bttFahrenheitCelsius.Location = new System.Drawing.Point(538, 286);
            this.bttFahrenheitCelsius.Name = "bttFahrenheitCelsius";
            this.bttFahrenheitCelsius.Size = new System.Drawing.Size(173, 23);
            this.bttFahrenheitCelsius.TabIndex = 7;
            this.bttFahrenheitCelsius.Text = "Fahrenheit a Celsius";
            this.bttFahrenheitCelsius.UseVisualStyleBackColor = true;
            this.bttFahrenheitCelsius.Click += new System.EventHandler(this.bttFahrenheitCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3NLIDTS_XimenaRossette_Actividad0.Properties.Resources.Programacion;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttFahrenheitCelsius);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttCelsiusFahrenheit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttCelsiusFahrenheit;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button bttFahrenheitCelsius;
    }
}

