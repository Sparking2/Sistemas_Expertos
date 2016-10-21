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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SI = new System.Windows.Forms.Button();
            this.btn_NO = new System.Windows.Forms.Button();
            this.comboFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":::::::::::::::::::::::::::::::::::::::::";
            // 
            // btn_SI
            // 
            this.btn_SI.Location = new System.Drawing.Point(32, 99);
            this.btn_SI.Name = "btn_SI";
            this.btn_SI.Size = new System.Drawing.Size(75, 23);
            this.btn_SI.TabIndex = 1;
            this.btn_SI.Text = "SI";
            this.btn_SI.UseVisualStyleBackColor = true;
            // 
            // btn_NO
            // 
            this.btn_NO.Location = new System.Drawing.Point(175, 99);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(75, 23);
            this.btn_NO.TabIndex = 2;
            this.btn_NO.Text = "NO";
            this.btn_NO.UseVisualStyleBackColor = true;
            // 
            // comboFinal
            // 
            this.comboFinal.FormattingEnabled = true;
            this.comboFinal.Location = new System.Drawing.Point(79, 12);
            this.comboFinal.Name = "comboFinal";
            this.comboFinal.Size = new System.Drawing.Size(121, 21);
            this.comboFinal.TabIndex = 3;
            // 
            // Atras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboFinal);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_SI);
            this.Controls.Add(this.label1);
            this.Name = "Atras";
            this.Text = "Atras";
            this.Load += new System.EventHandler(this.Atras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SI;
        private System.Windows.Forms.Button btn_NO;
        private System.Windows.Forms.ComboBox comboFinal;
    }
}