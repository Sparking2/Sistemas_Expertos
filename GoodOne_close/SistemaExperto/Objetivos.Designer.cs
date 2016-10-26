namespace SistemaExperto
{
    partial class Objetivos
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
            this.comboAtomos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAtomos
            // 
            this.comboAtomos.FormattingEnabled = true;
            this.comboAtomos.Location = new System.Drawing.Point(80, 25);
            this.comboAtomos.Name = "comboAtomos";
            this.comboAtomos.Size = new System.Drawing.Size(121, 21);
            this.comboAtomos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificar:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(84, 91);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(118, 13);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = ":-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:";
            // 
            // btnSI
            // 
            this.btnSI.Enabled = false;
            this.btnSI.Location = new System.Drawing.Point(48, 118);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(75, 23);
            this.btnSI.TabIndex = 3;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // btnNo
            // 
            this.btnNo.Enabled = false;
            this.btnNo.Location = new System.Drawing.Point(160, 118);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAtomos);
            this.Name = "Objetivos";
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAtomos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnStart;
    }
}