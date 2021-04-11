namespace tp_fonctions
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalculer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtresultat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_div = new System.Windows.Forms.RadioButton();
            this.rd_add = new System.Windows.Forms.RadioButton();
            this.rd_multip = new System.Windows.Forms.RadioButton();
            this.rd_sous = new System.Windows.Forms.RadioButton();
            this.zero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculer
            // 
            this.btncalculer.Location = new System.Drawing.Point(477, 204);
            this.btncalculer.Name = "btncalculer";
            this.btncalculer.Size = new System.Drawing.Size(75, 23);
            this.btncalculer.TabIndex = 0;
            this.btncalculer.Text = "Calculer";
            this.btncalculer.UseVisualStyleBackColor = true;
            this.btncalculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(643, 204);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(75, 23);
            this.btnquitter.TabIndex = 1;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre 3";
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(515, 20);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(123, 20);
            this.txtnombre1.TabIndex = 5;
            this.txtnombre1.TextChanged += new System.EventHandler(this.txtnombre1_TextChanged);
            this.txtnombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre1_keyPress);
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(515, 58);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(123, 20);
            this.txtnombre2.TabIndex = 6;
            this.txtnombre2.TextChanged += new System.EventHandler(this.txtnombre2_TextChanged);
            // 
            // txtresultat
            // 
            this.txtresultat.Enabled = false;
            this.txtresultat.Location = new System.Drawing.Point(515, 102);
            this.txtresultat.Name = "txtresultat";
            this.txtresultat.Size = new System.Drawing.Size(123, 20);
            this.txtresultat.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_div);
            this.groupBox1.Controls.Add(this.rd_add);
            this.groupBox1.Controls.Add(this.rd_multip);
            this.groupBox1.Controls.Add(this.rd_sous);
            this.groupBox1.Location = new System.Drawing.Point(45, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // rd_div
            // 
            this.rd_div.AutoSize = true;
            this.rd_div.Location = new System.Drawing.Point(6, 106);
            this.rd_div.Name = "rd_div";
            this.rd_div.Size = new System.Drawing.Size(62, 17);
            this.rd_div.TabIndex = 11;
            this.rd_div.TabStop = true;
            this.rd_div.Text = "Division";
            this.rd_div.UseVisualStyleBackColor = true;
            this.rd_div.CheckedChanged += new System.EventHandler(this.rd_div_CheckedChanged);
            // 
            // rd_add
            // 
            this.rd_add.AutoSize = true;
            this.rd_add.Location = new System.Drawing.Point(6, 32);
            this.rd_add.Name = "rd_add";
            this.rd_add.Size = new System.Drawing.Size(63, 17);
            this.rd_add.TabIndex = 9;
            this.rd_add.TabStop = true;
            this.rd_add.Text = "Addition";
            this.rd_add.UseVisualStyleBackColor = true;
            this.rd_add.CheckedChanged += new System.EventHandler(this.rd_add_CheckedChanged);
            // 
            // rd_multip
            // 
            this.rd_multip.AutoSize = true;
            this.rd_multip.Location = new System.Drawing.Point(6, 82);
            this.rd_multip.Name = "rd_multip";
            this.rd_multip.Size = new System.Drawing.Size(86, 17);
            this.rd_multip.TabIndex = 10;
            this.rd_multip.TabStop = true;
            this.rd_multip.Text = "Multiplication";
            this.rd_multip.UseVisualStyleBackColor = true;
            this.rd_multip.CheckedChanged += new System.EventHandler(this.rd_multip_CheckedChanged);
            // 
            // rd_sous
            // 
            this.rd_sous.AutoSize = true;
            this.rd_sous.Location = new System.Drawing.Point(6, 59);
            this.rd_sous.Name = "rd_sous";
            this.rd_sous.Size = new System.Drawing.Size(84, 17);
            this.rd_sous.TabIndex = 9;
            this.rd_sous.TabStop = true;
            this.rd_sous.Text = "Soustraction";
            this.rd_sous.UseVisualStyleBackColor = true;
            this.rd_sous.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // zero
            // 
            this.zero.AutoSize = true;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.Blue;
            this.zero.Location = new System.Drawing.Point(421, 159);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(0, 25);
            this.zero.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 261);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtresultat);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.txtnombre1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btncalculer);
            this.Name = "Form1";
            this.Text = "Partie 2 les fonctions ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtresultat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_div;
        private System.Windows.Forms.RadioButton rd_add;
        private System.Windows.Forms.RadioButton rd_multip;
        private System.Windows.Forms.RadioButton rd_sous;
        private System.Windows.Forms.Label zero;
    }
}

