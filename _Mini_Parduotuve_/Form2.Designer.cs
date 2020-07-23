namespace _Mini_Parduotuve
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SiuntimoBudas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SiuntimoIs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(447, 456);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 22);
            this.Total.TabIndex = 1;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(605, 320);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(108, 68);
            this.order.TabIndex = 2;
            this.order.Text = "Užsakyti";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasirinkite kaip norite atsiimti siuntą :";
            // 
            // SiuntimoBudas
            // 
            this.SiuntimoBudas.FormattingEnabled = true;
            this.SiuntimoBudas.Location = new System.Drawing.Point(24, 364);
            this.SiuntimoBudas.Name = "SiuntimoBudas";
            this.SiuntimoBudas.Size = new System.Drawing.Size(300, 24);
            this.SiuntimoBudas.TabIndex = 4;
            this.SiuntimoBudas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Siuntimo išlaidos :";
            // 
            // SiuntimoIs
            // 
            this.SiuntimoIs.Location = new System.Drawing.Point(24, 456);
            this.SiuntimoIs.Name = "SiuntimoIs";
            this.SiuntimoIs.Size = new System.Drawing.Size(118, 22);
            this.SiuntimoIs.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.SiuntimoIs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SiuntimoBudas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Krepšelis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SiuntimoBudas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SiuntimoIs;
    }
}