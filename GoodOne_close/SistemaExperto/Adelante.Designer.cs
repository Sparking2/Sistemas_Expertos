namespace SistemaExperto
{
    partial class Adelante
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
            this.lblAtomo = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.explain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAtomo
            // 
            this.lblAtomo.AutoSize = true;
            this.lblAtomo.Location = new System.Drawing.Point(99, 22);
            this.lblAtomo.Name = "lblAtomo";
            this.lblAtomo.Size = new System.Drawing.Size(64, 13);
            this.lblAtomo.TabIndex = 0;
            this.lblAtomo.Text = ":-:-:-:-:-:-:-:-:-:";
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(42, 54);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(148, 54);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 2;
            this.btnNO.Text = "No";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // explain
            // 
            this.explain.Location = new System.Drawing.Point(42, 107);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(181, 96);
            this.explain.TabIndex = 3;
            this.explain.Text = "";
            // 
            // Adelante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblAtomo);
            this.Name = "Adelante";
            this.Text = "Adelante";
            this.Load += new System.EventHandler(this.Adelante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtomo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.RichTextBox explain;
    }
}