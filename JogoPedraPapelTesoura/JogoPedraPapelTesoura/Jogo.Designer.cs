namespace JogoPedraPapelTesoura
{
    partial class Jogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbljogadaCPU = new System.Windows.Forms.Label();
            this.lbljogPlacar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picbob = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbob)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // picJogador
            // 
            this.picJogador.Location = new System.Drawing.Point(3, 3);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(204, 188);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJogador.TabIndex = 0;
            this.picJogador.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.picCPU.Location = new System.Drawing.Point(6, 19);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(192, 188);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCPU.TabIndex = 1;
            this.picCPU.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(82, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.picturePedra_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(233, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.picturePapel_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(157, 334);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureTesoura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Location = new System.Drawing.Point(76, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha jogada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCPU);
            this.groupBox2.Location = new System.Drawing.Point(563, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada do Bob";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbljogadaCPU);
            this.groupBox3.Controls.Add(this.lbljogPlacar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(328, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Placar";
            // 
            // lbljogadaCPU
            // 
            this.lbljogadaCPU.AutoSize = true;
            this.lbljogadaCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljogadaCPU.Location = new System.Drawing.Point(141, 71);
            this.lbljogadaCPU.Name = "lbljogadaCPU";
            this.lbljogadaCPU.Size = new System.Drawing.Size(24, 26);
            this.lbljogadaCPU.TabIndex = 3;
            this.lbljogadaCPU.Text = "0";
            this.lbljogadaCPU.UseMnemonic = false;
            // 
            // lbljogPlacar
            // 
            this.lbljogPlacar.AutoSize = true;
            this.lbljogPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljogPlacar.Location = new System.Drawing.Point(32, 71);
            this.lbljogPlacar.Name = "lbljogPlacar";
            this.lbljogPlacar.Size = new System.Drawing.Size(24, 26);
            this.lbljogPlacar.TabIndex = 2;
            this.lbljogPlacar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bob";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbob
            // 
            this.picbob.Image = ((System.Drawing.Image)(resources.GetObject("picbob.Image")));
            this.picbob.Location = new System.Drawing.Point(631, 43);
            this.picbob.Name = "picbob";
            this.picbob.Size = new System.Drawing.Size(58, 53);
            this.picbob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbob.TabIndex = 9;
            this.picbob.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(82, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 50);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(133, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 50);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(157, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 50);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel4.Location = new System.Drawing.Point(208, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 50);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel5.Location = new System.Drawing.Point(233, 334);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 50);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel6.Location = new System.Drawing.Point(284, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 50);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel7.Location = new System.Drawing.Point(157, 382);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 2);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel8.Location = new System.Drawing.Point(82, 382);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 2);
            this.panel8.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel9.Location = new System.Drawing.Point(236, 382);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 2);
            this.panel9.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel10.Location = new System.Drawing.Point(236, 334);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(50, 2);
            this.panel10.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel11.Location = new System.Drawing.Point(157, 334);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(50, 2);
            this.panel11.TabIndex = 20;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(77)))));
            this.panel12.Location = new System.Drawing.Point(85, 334);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(50, 2);
            this.panel12.TabIndex = 21;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.panel13.Controls.Add(this.picJogador);
            this.panel13.Location = new System.Drawing.Point(3, 16);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(210, 191);
            this.panel13.TabIndex = 22;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 488);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picbob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo - JO-KEN-PO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbob)).EndInit();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbljogadaCPU;
        private System.Windows.Forms.Label lbljogPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picbob;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
    }
}

