namespace SistemaExperto
{
    partial class Atras
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
            this.comboFinal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFinal
            // 
            this.comboFinal.FormattingEnabled = true;
            this.comboFinal.Location = new System.Drawing.Point(74, 35);
            this.comboFinal.Name = "comboFinal";
            this.comboFinal.Size = new System.Drawing.Size(121, 21);
            this.comboFinal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Determinar";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(89, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(106, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = ":-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:-:";
            // 
            // btnSI
            // 
            this.btnSI.Location = new System.Drawing.Point(35, 99);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(65, 47);
            this.btnSI.TabIndex = 3;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = true;
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(169, 99);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(65, 47);
            this.btnNO.TabIndex = 4;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFinal);
            this.Name = "Atras";
            this.Text = "Atras";
            this.Load += new System.EventHandler(this.Atras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnNO;
    }
}