namespace App07
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
            label1 = new Label();
            label2 = new Label();
            TxtOriginale = new TextBox();
            txtCifrato = new TextBox();
            btnCifra = new Button();
            btnDecifra = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 0;
            label1.Text = "Testo da cifrare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "Testo cifrato";
            // 
            // TxtOriginale
            // 
            TxtOriginale.Location = new Point(204, 36);
            TxtOriginale.Name = "TxtOriginale";
            TxtOriginale.Size = new Size(564, 39);
            TxtOriginale.TabIndex = 2;
            // 
            // txtCifrato
            // 
            txtCifrato.Location = new Point(204, 84);
            txtCifrato.Name = "txtCifrato";
            txtCifrato.Size = new Size(564, 39);
            txtCifrato.TabIndex = 3;
            // 
            // btnCifra
            // 
            btnCifra.Location = new Point(163, 186);
            btnCifra.Name = "btnCifra";
            btnCifra.Size = new Size(150, 46);
            btnCifra.TabIndex = 4;
            btnCifra.Text = "cifra";
            btnCifra.UseVisualStyleBackColor = true;
            btnCifra.Click += btnCifra_Click;
            // 
            // btnDecifra
            // 
            btnDecifra.Location = new Point(483, 186);
            btnDecifra.Name = "btnDecifra";
            btnDecifra.Size = new Size(150, 46);
            btnDecifra.TabIndex = 5;
            btnDecifra.Text = "decifra";
            btnDecifra.UseVisualStyleBackColor = true;
            btnDecifra.Click += btnDecifra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 296);
            Controls.Add(btnDecifra);
            Controls.Add(btnCifra);
            Controls.Add(txtCifrato);
            Controls.Add(TxtOriginale);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtOriginale;
        private TextBox txtCifrato;
        private Button btnCifra;
        private Button btnDecifra;
    }
}
