
namespace Vista_PrototipoMenu
{
    partial class mant_catalogo
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
            this.label1 = new System.Windows.Forms.Label();
            this.npelicula = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.clasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelicula";
            // 
            // npelicula
            // 
            this.npelicula.Location = new System.Drawing.Point(289, 237);
            this.npelicula.Name = "npelicula";
            this.npelicula.Size = new System.Drawing.Size(100, 22);
            this.npelicula.TabIndex = 1;
            this.npelicula.Tag = "Nombre";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(61, 25);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 2;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // clasi
            // 
            this.clasi.Location = new System.Drawing.Point(506, 237);
            this.clasi.Name = "clasi";
            this.clasi.Size = new System.Drawing.Size(100, 22);
            this.clasi.TabIndex = 4;
            this.clasi.Tag = "Clasificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clasificacion";
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(695, 237);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(100, 22);
            this.Gen.TabIndex = 6;
            this.Gen.Tag = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(172, 313);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 22);
            this.sub.TabIndex = 8;
            this.sub.Tag = "Subtitulado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "subtitulado";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(559, 313);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 22);
            this.Precio.TabIndex = 10;
            this.Precio.Tag = "precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Tag = "idPeliculas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 12;
            this.label6.Tag = "idPeliculas";
            this.label6.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 313);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.Tag = "Idioma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Idioma";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 209);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Tag = "peliculas";
            // 
            // mant_catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.npelicula);
            this.Controls.Add(this.label1);
            this.Name = "mant_catalogo";
            this.Text = "mant_catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npelicula;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox clasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Gen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}