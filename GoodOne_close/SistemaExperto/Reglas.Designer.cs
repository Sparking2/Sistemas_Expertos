namespace SistemaExperto
{
    partial class Reglas
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
            this.txtReglas = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.comboAtomo = new System.Windows.Forms.ComboBox();
            this.chBoxNo = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnImplica = new System.Windows.Forms.Button();
            this.richRules = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtReglas
            // 
            this.txtReglas.Location = new System.Drawing.Point(12, 12);
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.ReadOnly = true;
            this.txtReglas.Size = new System.Drawing.Size(260, 20);
            this.txtReglas.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 38);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(85, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(197, 38);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Listo";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // comboAtomo
            // 
            this.comboAtomo.FormattingEnabled = true;
            this.comboAtomo.Location = new System.Drawing.Point(60, 104);
            this.comboAtomo.Name = "comboAtomo";
            this.comboAtomo.Size = new System.Drawing.Size(123, 21);
            this.comboAtomo.TabIndex = 3;
            // 
            // chBoxNo
            // 
            this.chBoxNo.AutoSize = true;
            this.chBoxNo.Location = new System.Drawing.Point(12, 106);
            this.chBoxNo.Name = "chBoxNo";
            this.chBoxNo.Size = new System.Drawing.Size(42, 17);
            this.chBoxNo.TabIndex = 4;
            this.chBoxNo.Text = "NO";
            this.chBoxNo.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(12, 137);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(75, 23);
            this.btnAnd.TabIndex = 6;
            this.btnAnd.Text = "Y";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnImplica
            // 
            this.btnImplica.Location = new System.Drawing.Point(98, 137);
            this.btnImplica.Name = "btnImplica";
            this.btnImplica.Size = new System.Drawing.Size(75, 23);
            this.btnImplica.TabIndex = 7;
            this.btnImplica.Text = "→";
            this.btnImplica.UseVisualStyleBackColor = true;
            this.btnImplica.Click += new System.EventHandler(this.btnImplica_Click);
            // 
            // richRules
            // 
            this.richRules.Location = new System.Drawing.Point(12, 176);
            this.richRules.Name = "richRules";
            this.richRules.ReadOnly = true;
            this.richRules.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richRules.Size = new System.Drawing.Size(260, 96);
            this.richRules.TabIndex = 8;
            this.richRules.Text = "";
            // 
            // Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.richRules);
            this.Controls.Add(this.btnImplica);
            this.Controls.Add(this.btnAnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chBoxNo);
            this.Controls.Add(this.comboAtomo);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtReglas);
            this.Name = "Reglas";
            this.Text = "Reglas";
            this.Load += new System.EventHandler(this.Reglas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReglas;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox comboAtomo;
        private System.Windows.Forms.CheckBox chBoxNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnImplica;
        private System.Windows.Forms.RichTextBox richRules;
    }
}