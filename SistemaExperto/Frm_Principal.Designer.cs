namespace SistemaExperto
{
    partial class MenuPpl
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
            this.btn_diccionario = new System.Windows.Forms.Button();
            this.btn_reglas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_diccionario
            // 
            this.btn_diccionario.Location = new System.Drawing.Point(66, 12);
            this.btn_diccionario.Name = "btn_diccionario";
            this.btn_diccionario.Size = new System.Drawing.Size(90, 41);
            this.btn_diccionario.TabIndex = 0;
            this.btn_diccionario.Text = "Diccionario";
            this.btn_diccionario.UseVisualStyleBackColor = true;
            this.btn_diccionario.Click += new System.EventHandler(this.btn_diccionario_Click);
            // 
            // btn_reglas
            // 
            this.btn_reglas.Location = new System.Drawing.Point(66, 61);
            this.btn_reglas.Name = "btn_reglas";
            this.btn_reglas.Size = new System.Drawing.Size(90, 41);
            this.btn_reglas.TabIndex = 1;
            this.btn_reglas.Text = "Reglas";
            this.btn_reglas.UseVisualStyleBackColor = true;
            this.btn_reglas.Click += new System.EventHandler(this.btn_reglas_Click);
            // 
            // MenuPpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 211);
            this.Controls.Add(this.btn_reglas);
            this.Controls.Add(this.btn_diccionario);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MenuPpl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_diccionario;
        private System.Windows.Forms.Button btn_reglas;
    }
}

