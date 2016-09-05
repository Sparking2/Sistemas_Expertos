namespace SistemaExperto
{
    partial class Frm_Atomos
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
            this.txtAtomo = new System.Windows.Forms.TextBox();
            this.btn_AddAtom = new System.Windows.Forms.Button();
            this.rich_Text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtAtomo
            // 
            this.txtAtomo.Location = new System.Drawing.Point(58, 12);
            this.txtAtomo.Name = "txtAtomo";
            this.txtAtomo.Size = new System.Drawing.Size(162, 20);
            this.txtAtomo.TabIndex = 0;
            // 
            // btn_AddAtom
            // 
            this.btn_AddAtom.Location = new System.Drawing.Point(108, 38);
            this.btn_AddAtom.Name = "btn_AddAtom";
            this.btn_AddAtom.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAtom.TabIndex = 1;
            this.btn_AddAtom.Text = "Agregar";
            this.btn_AddAtom.UseVisualStyleBackColor = true;
            this.btn_AddAtom.Click += new System.EventHandler(this.btn_AddAtom_Click);
            // 
            // rich_Text
            // 
            this.rich_Text.Location = new System.Drawing.Point(34, 95);
            this.rich_Text.Name = "rich_Text";
            this.rich_Text.ReadOnly = true;
            this.rich_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rich_Text.Size = new System.Drawing.Size(211, 131);
            this.rich_Text.TabIndex = 2;
            this.rich_Text.Text = "";
            // 
            // Frm_Atomos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rich_Text);
            this.Controls.Add(this.btn_AddAtom);
            this.Controls.Add(this.txtAtomo);
            this.Name = "Frm_Atomos";
            this.Text = "Frm_Atomos";
            this.Load += new System.EventHandler(this.Frm_Atomos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtomo;
        private System.Windows.Forms.Button btn_AddAtom;
        private System.Windows.Forms.RichTextBox rich_Text;
    }
}