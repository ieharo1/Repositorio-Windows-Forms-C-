namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.TextBox();
            this.lblRFactorial = new System.Windows.Forms.Label();
            this.lblRMultiplicacion = new System.Windows.Forms.Label();
            this.lblRFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(145, 394);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "Continuar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido Ingrese los datos por consola";
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(40, 100);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(53, 13);
            this.lblFibonacci.TabIndex = 3;
            this.lblFibonacci.Text = "Fibonacci";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(40, 173);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(71, 13);
            this.lblMultiplicacion.TabIndex = 4;
            this.lblMultiplicacion.Text = "Multiplicación";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(145, 100);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 5;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(145, 170);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 6;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(296, 170);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 20);
            this.text3.TabIndex = 7;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(40, 250);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(47, 13);
            this.lblFactorial.TabIndex = 8;
            this.lblFactorial.Text = "Factorial";
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(145, 243);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(100, 20);
            this.text4.TabIndex = 9;
            // 
            // lblRFactorial
            // 
            this.lblRFactorial.AutoSize = true;
            this.lblRFactorial.Location = new System.Drawing.Point(40, 332);
            this.lblRFactorial.Name = "lblRFactorial";
            this.lblRFactorial.Size = new System.Drawing.Size(104, 13);
            this.lblRFactorial.TabIndex = 10;
            this.lblRFactorial.Text = "Respuesta Factorial:";
            // 
            // lblRMultiplicacion
            // 
            this.lblRMultiplicacion.AutoSize = true;
            this.lblRMultiplicacion.Location = new System.Drawing.Point(40, 309);
            this.lblRMultiplicacion.Name = "lblRMultiplicacion";
            this.lblRMultiplicacion.Size = new System.Drawing.Size(128, 13);
            this.lblRMultiplicacion.TabIndex = 11;
            this.lblRMultiplicacion.Text = "Respuesta Multiplicacion:";
            // 
            // lblRFibonacci
            // 
            this.lblRFibonacci.AutoSize = true;
            this.lblRFibonacci.Location = new System.Drawing.Point(40, 287);
            this.lblRFibonacci.Name = "lblRFibonacci";
            this.lblRFibonacci.Size = new System.Drawing.Size(110, 13);
            this.lblRFibonacci.TabIndex = 12;
            this.lblRFibonacci.Text = "Respuesta Fibonacci:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.lblRFibonacci);
            this.Controls.Add(this.lblRMultiplicacion);
            this.Controls.Add(this.lblRFactorial);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Name = "Form1";
            this.Text = "Programa Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Label lblRFactorial;
        private System.Windows.Forms.Label lblRMultiplicacion;
        private System.Windows.Forms.Label lblRFibonacci;
    }
}

