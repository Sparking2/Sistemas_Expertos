namespace SistemaExperto
{
    partial class Form1
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
            this.btnDiccionario = new System.Windows.Forms.Button();
            this.btnReglas = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiccionario
            // 
            this.btnDiccionario.Location = new System.Drawing.Point(55, 12);
            this.btnDiccionario.Name = "btnDiccionario";
            this.btnDiccionario.Size = new System.Drawing.Size(167, 43);
            this.btnDiccionario.TabIndex = 0;
            this.btnDiccionario.Text = "Diccionario";
            this.btnDiccionario.UseVisualStyleBackColor = true;
            this.btnDiccionario.Click += new System.EventHandler(this.btnDiccionario_Click);
            // 
            // btnReglas
            // 
            this.btnReglas.Location = new System.Drawing.Point(55, 61);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(167, 43);
            this.btnReglas.TabIndex = 1;
            this.btnReglas.Text = "Reglas";
            this.btnReglas.UseVisualStyleBackColor = true;
            this.btnReglas.Click += new System.EventHandler(this.btnReglas_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(55, 110);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(167, 43);
            this.btnAdelante.TabIndex = 2;
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(55, 159);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 43);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnReglas);
            this.Controls.Add(this.btnDiccionario);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiccionario;
        private System.Windows.Forms.Button btnReglas;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
    }
}

