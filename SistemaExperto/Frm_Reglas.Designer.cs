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
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Atom = new System.Windows.Forms.ComboBox();
            this.cBox_no = new System.Windows.Forms.CheckBox();
            this.implies = new System.Windows.Forms.Button();
            this.btn_Y = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_O = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.btn_Regla = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richRules = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_Atom);
            this.groupBox1.Controls.Add(this.cBox_no);
            this.groupBox1.Location = new System.Drawing.Point(18, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atomos";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(179, 57);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            // combo_Atom
            // 
            this.combo_Atom.FormattingEnabled = true;
            this.combo_Atom.Location = new System.Drawing.Point(52, 36);
            this.combo_Atom.Name = "combo_Atom";
            this.combo_Atom.Size = new System.Drawing.Size(121, 21);
            this.combo_Atom.TabIndex = 1;
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
            this.cBox_no.CheckedChanged += new System.EventHandler(this.cBox_no_CheckedChanged);
            // 
            // implies
            // 
            this.implies.Location = new System.Drawing.Point(199, 34);
            this.implies.Name = "implies";
            this.implies.Size = new System.Drawing.Size(75, 23);
            this.implies.TabIndex = 3;
            this.implies.Text = "->";
            this.implies.UseVisualStyleBackColor = true;
            this.implies.Click += new System.EventHandler(this.implies_Click);
            // 
            // btn_Y
            // 
            this.btn_Y.Location = new System.Drawing.Point(101, 34);
            this.btn_Y.Name = "btn_Y";
            this.btn_Y.Size = new System.Drawing.Size(75, 23);
            this.btn_Y.TabIndex = 2;
            this.btn_Y.Text = "y ( ^ )";
            this.btn_Y.UseVisualStyleBackColor = true;
            this.btn_Y.Click += new System.EventHandler(this.btn_Y_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.implies);
            this.groupBox2.Controls.Add(this.btn_O);
            this.groupBox2.Controls.Add(this.btn_Y);
            this.groupBox2.Location = new System.Drawing.Point(349, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores";
            // 
            // btn_O
            // 
            this.btn_O.Location = new System.Drawing.Point(6, 34);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(75, 23);
            this.btn_O.TabIndex = 2;
            this.btn_O.Text = "o ( v )";
            this.btn_O.UseVisualStyleBackColor = true;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(56, 29);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(40, 23);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = ")";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(10, 29);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(40, 23);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "(";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // richBox
            // 
            this.richBox.Location = new System.Drawing.Point(18, 12);
            this.richBox.Name = "richBox";
            this.richBox.ReadOnly = true;
            this.richBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richBox.Size = new System.Drawing.Size(611, 45);
            this.richBox.TabIndex = 2;
            this.richBox.Text = "";
            // 
            // btn_Regla
            // 
            this.btn_Regla.Location = new System.Drawing.Point(540, 58);
            this.btn_Regla.Name = "btn_Regla";
            this.btn_Regla.Size = new System.Drawing.Size(89, 32);
            this.btn_Regla.TabIndex = 3;
            this.btn_Regla.Text = "Agregar Regla";
            this.btn_Regla.UseVisualStyleBackColor = true;
            this.btn_Regla.Click += new System.EventHandler(this.btn_Regla_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_left);
            this.groupBox3.Controls.Add(this.btn_right);
            this.groupBox3.Location = new System.Drawing.Point(262, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros";
            // 
            // richRules
            // 
            this.richRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richRules.Location = new System.Drawing.Point(18, 324);
            this.richRules.Name = "richRules";
            this.richRules.ReadOnly = true;
            this.richRules.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richRules.Size = new System.Drawing.Size(611, 96);
            this.richRules.TabIndex = 5;
            this.richRules.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(636, 160);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Da Rules";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(18, 58);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(89, 32);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Frm_Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 467);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.richRules);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Regla);
            this.Controls.Add(this.richBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richRules;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRestart;
    }
}