namespace SistemaExperto
{
    partial class Frm_Reglas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_no = new System.Windows.Forms.CheckBox();
            this.combo_Atom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Y = new System.Windows.Forms.Button();
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.implies = new System.Windows.Forms.Button();
            this.btn_Regla = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_O = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.implies);
            this.groupBox1.Controls.Add(this.btn_Y);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_Atom);
            this.groupBox1.Controls.Add(this.cBox_no);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facil";
            // 
            // cBox_no
            // 
            this.cBox_no.AutoSize = true;
            this.cBox_no.Location = new System.Drawing.Point(6, 38);
            this.cBox_no.Name = "cBox_no";
            this.cBox_no.Size = new System.Drawing.Size(40, 17);
            this.cBox_no.TabIndex = 0;
            this.cBox_no.Text = "No";
            this.cBox_no.UseVisualStyleBackColor = true;
            // 
            // combo_Atom
            // 
            this.combo_Atom.FormattingEnabled = true;
            this.combo_Atom.Location = new System.Drawing.Point(52, 36);
            this.combo_Atom.Name = "combo_Atom";
            this.combo_Atom.Size = new System.Drawing.Size(121, 21);
            this.combo_Atom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atomo";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(179, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_O);
            this.groupBox2.Controls.Add(this.btn_right);
            this.groupBox2.Controls.Add(this.btn_left);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dificil";
            // 
            // btn_Y
            // 
            this.btn_Y.Location = new System.Drawing.Point(270, 34);
            this.btn_Y.Name = "btn_Y";
            this.btn_Y.Size = new System.Drawing.Size(75, 23);
            this.btn_Y.TabIndex = 2;
            this.btn_Y.Text = "y ( ^ )";
            this.btn_Y.UseVisualStyleBackColor = true;
            this.btn_Y.Click += new System.EventHandler(this.btn_Y_Click);
            // 
            // richBox
            // 
            this.richBox.Location = new System.Drawing.Point(18, 12);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(444, 96);
            this.richBox.TabIndex = 2;
            this.richBox.Text = "";
            // 
            // implies
            // 
            this.implies.Location = new System.Drawing.Point(361, 34);
            this.implies.Name = "implies";
            this.implies.Size = new System.Drawing.Size(75, 23);
            this.implies.TabIndex = 3;
            this.implies.Text = "->";
            this.implies.UseVisualStyleBackColor = true;
            this.implies.Click += new System.EventHandler(this.implies_Click);
            // 
            // btn_Regla
            // 
            this.btn_Regla.Location = new System.Drawing.Point(373, 114);
            this.btn_Regla.Name = "btn_Regla";
            this.btn_Regla.Size = new System.Drawing.Size(89, 32);
            this.btn_Regla.TabIndex = 3;
            this.btn_Regla.Text = "Agregar Regla";
            this.btn_Regla.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(6, 19);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(40, 23);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "(";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(52, 19);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(40, 23);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = ")";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_O
            // 
            this.btn_O.Location = new System.Drawing.Point(98, 19);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(75, 23);
            this.btn_O.TabIndex = 2;
            this.btn_O.Text = "o ( v )";
            this.btn_O.UseVisualStyleBackColor = true;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // Frm_Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 414);
            this.Controls.Add(this.btn_Regla);
            this.Controls.Add(this.richBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reglas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglas";
            this.Load += new System.EventHandler(this.Frm_Reglas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button implies;
        private System.Windows.Forms.Button btn_Y;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Atom;
        private System.Windows.Forms.CheckBox cBox_no;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.Button btn_Regla;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
    }
}