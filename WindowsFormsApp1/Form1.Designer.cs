namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbalimentos = new System.Windows.Forms.ComboBox();
            this.btnadcionar = new System.Windows.Forms.Button();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.lblindice = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbalimentos
            // 
            this.cmbalimentos.FormattingEnabled = true;
            this.cmbalimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.cmbalimentos.Location = new System.Drawing.Point(371, 56);
            this.cmbalimentos.Name = "cmbalimentos";
            this.cmbalimentos.Size = new System.Drawing.Size(151, 28);
            this.cmbalimentos.TabIndex = 0;
            this.cmbalimentos.Text = "Alimentos";
            this.cmbalimentos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnadcionar
            // 
            this.btnadcionar.Location = new System.Drawing.Point(397, 300);
            this.btnadcionar.Name = "btnadcionar";
            this.btnadcionar.Size = new System.Drawing.Size(94, 29);
            this.btnadcionar.TabIndex = 1;
            this.btnadcionar.Text = "Adicionar";
            this.btnadcionar.UseVisualStyleBackColor = true;
            this.btnadcionar.Click += new System.EventHandler(this.btnadcionar_Click);
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(381, 182);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(125, 27);
            this.txtalimento.TabIndex = 2;
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Location = new System.Drawing.Point(179, 304);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(50, 20);
            this.lblindice.TabIndex = 3;
            this.lblindice.Text = "label1";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(649, 300);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(50, 20);
            this.lbltexto.TabIndex = 4;
            this.lbltexto.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 586);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.btnadcionar);
            this.Controls.Add(this.cmbalimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbalimentos;
        private System.Windows.Forms.Button btnadcionar;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.Label lbltexto;
    }
}

