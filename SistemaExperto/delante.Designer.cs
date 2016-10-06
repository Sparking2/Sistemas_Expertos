namespace SistemaExperto
{
    partial class delante
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
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.lbl_atomo = new System.Windows.Forms.Label();
            this.rich_resultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_si
            // 
            this.btn_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.Location = new System.Drawing.Point(62, 86);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(75, 23);
            this.btn_si.TabIndex = 0;
            this.btn_si.Text = "Si";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(143, 86);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 1;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // lbl_atomo
            // 
            this.lbl_atomo.AutoSize = true;
            this.lbl_atomo.Location = new System.Drawing.Point(118, 44);
            this.lbl_atomo.Name = "lbl_atomo";
            this.lbl_atomo.Size = new System.Drawing.Size(25, 13);
            this.lbl_atomo.TabIndex = 2;
            this.lbl_atomo.Text = "::::::";
            // 
            // rich_resultado
            // 
            this.rich_resultado.Location = new System.Drawing.Point(37, 115);
            this.rich_resultado.Name = "rich_resultado";
            this.rich_resultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rich_resultado.Size = new System.Drawing.Size(201, 73);
            this.rich_resultado.TabIndex = 3;
            this.rich_resultado.Text = "";
            // 
            // delante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.rich_resultado);
            this.Controls.Add(this.lbl_atomo);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_si);
            this.Name = "delante";
            this.Text = "delante";
            this.Load += new System.EventHandler(this.delante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label lbl_atomo;
        private System.Windows.Forms.RichTextBox rich_resultado;
    }
}