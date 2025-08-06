namespace WindowsFormsApp2
{
    partial class boton
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
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt30 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1000 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt200 = new System.Windows.Forms.TextBox();
            this.txt10000 = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.paso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(90, 269);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(136, 20);
            this.txt3.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(122, 234);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(68, 20);
            this.txt2.TabIndex = 1;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(137, 200);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(43, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izquierda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt30
            // 
            this.txt30.Location = new System.Drawing.Point(475, 269);
            this.txt30.Name = "txt30";
            this.txt30.Size = new System.Drawing.Size(136, 20);
            this.txt30.TabIndex = 4;
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(309, 269);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(68, 20);
            this.txt20.TabIndex = 5;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(517, 269);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(43, 20);
            this.txt10.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Medio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Derecho";
            // 
            // txt1000
            // 
            this.txt1000.Location = new System.Drawing.Point(320, 234);
            this.txt1000.Name = "txt1000";
            this.txt1000.Size = new System.Drawing.Size(43, 20);
            this.txt1000.TabIndex = 9;
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(137, 269);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(43, 20);
            this.txt100.TabIndex = 10;
            // 
            // txt200
            // 
            this.txt200.Location = new System.Drawing.Point(507, 234);
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(68, 20);
            this.txt200.TabIndex = 11;
            // 
            // txt10000
            // 
            this.txt10000.Location = new System.Drawing.Point(519, 200);
            this.txt10000.Name = "txt10000";
            this.txt10000.Size = new System.Drawing.Size(43, 20);
            this.txt10000.TabIndex = 12;
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(309, 391);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 13;
            this.boton1.Text = "siguiente";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paso
            // 
            this.paso.Location = new System.Drawing.Point(293, 101);
            this.paso.Name = "paso";
            this.paso.Size = new System.Drawing.Size(100, 20);
            this.paso.TabIndex = 14;
            // 
            // boton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paso);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.txt10000);
            this.Controls.Add(this.txt200);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.txt1000);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt20);
            this.Controls.Add(this.txt30);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Name = "boton";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt30;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1000;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt200;
        private System.Windows.Forms.TextBox txt10000;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox paso;
    }
}

