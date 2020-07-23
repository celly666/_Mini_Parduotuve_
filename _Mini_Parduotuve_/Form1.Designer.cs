namespace _Mini_Parduotuve
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
            this.IdetiIKrepsBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PrekiuInfo = new System.Windows.Forms.TabControl();
            this.Pavadinimas = new System.Windows.Forms.TextBox();
            this.Svoris = new System.Windows.Forms.TextBox();
            this.Kaina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdetiIKrepsBTN
            // 
            this.IdetiIKrepsBTN.Location = new System.Drawing.Point(585, 337);
            this.IdetiIKrepsBTN.Name = "IdetiIKrepsBTN";
            this.IdetiIKrepsBTN.Size = new System.Drawing.Size(103, 82);
            this.IdetiIKrepsBTN.TabIndex = 0;
            this.IdetiIKrepsBTN.Text = "Įdėti į krepšelį";
            this.IdetiIKrepsBTN.UseVisualStyleBackColor = true;
            this.IdetiIKrepsBTN.Click += new System.EventHandler(this.IdetiIKrepsBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Krepselis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrekiuInfo
            // 
            this.PrekiuInfo.Location = new System.Drawing.Point(12, 21);
            this.PrekiuInfo.Name = "PrekiuInfo";
            this.PrekiuInfo.SelectedIndex = 0;
            this.PrekiuInfo.Size = new System.Drawing.Size(532, 297);
            this.PrekiuInfo.TabIndex = 2;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Location = new System.Drawing.Point(31, 356);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(100, 22);
            this.Pavadinimas.TabIndex = 3;
            // 
            // Svoris
            // 
            this.Svoris.Location = new System.Drawing.Point(204, 356);
            this.Svoris.Name = "Svoris";
            this.Svoris.Size = new System.Drawing.Size(100, 22);
            this.Svoris.TabIndex = 4;
            // 
            // Kaina
            // 
            this.Kaina.Location = new System.Drawing.Point(353, 356);
            this.Kaina.Name = "Kaina";
            this.Kaina.Size = new System.Drawing.Size(100, 22);
            this.Kaina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pavadinimas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Svoris :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kaina :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaina);
            this.Controls.Add(this.Svoris);
            this.Controls.Add(this.Pavadinimas);
            this.Controls.Add(this.PrekiuInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdetiIKrepsBTN);
            this.Name = "Form1";
            this.Text = "Prekės";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IdetiIKrepsBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl PrekiuInfo;
        private System.Windows.Forms.TextBox Pavadinimas;
        private System.Windows.Forms.TextBox Svoris;
        private System.Windows.Forms.TextBox Kaina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

