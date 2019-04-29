namespace projekti
{
    partial class Form1
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
            this.plaintexti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.textdekriptuar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plaintexti
            // 
            this.plaintexti.Location = new System.Drawing.Point(12, 47);
            this.plaintexti.Name = "plaintexti";
            this.plaintexti.Size = new System.Drawing.Size(729, 20);
            this.plaintexti.TabIndex = 0;
            this.plaintexti.TextChanged += new System.EventHandler(this.plaintexti_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaintext";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(566, 126);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(173, 41);
            this.btnEnkripto.TabIndex = 2;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text i enkriptuar";
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(572, 296);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(169, 40);
            this.btnDekripto.TabIndex = 5;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // textdekriptuar
            // 
            this.textdekriptuar.Location = new System.Drawing.Point(12, 359);
            this.textdekriptuar.Name = "textdekriptuar";
            this.textdekriptuar.Size = new System.Drawing.Size(728, 20);
            this.textdekriptuar.TabIndex = 6;
            this.textdekriptuar.TextChanged += new System.EventHandler(this.textdekriptuar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 332);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text i dekriptuar";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(481, 84);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(258, 20);
            this.keyword.TabIndex = 8;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key :";
            // 
            // ciphertext
            // 
            this.ciphertext.Location = new System.Drawing.Point(15, 223);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(724, 20);
            this.ciphertext.TabIndex = 10;
            this.ciphertext.TextChanged += new System.EventHandler(this.ciphertext_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textdekriptuar);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plaintexti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintexti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox textdekriptuar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ciphertext;
    }
}

