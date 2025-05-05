namespace ConsultaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBuscar = new Button();
            lblBuscaCep = new Label();
            pictureBox1 = new PictureBox();
            lblCEP = new Label();
            lblLogradouro = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUF = new Label();
            lblMostrarLogradouro = new Label();
            lblMostrarBairro = new Label();
            lblMostrarCidade = new Label();
            lblMostrarUF = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            txtCep = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CornflowerBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(191, 322);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 39);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscaCep
            // 
            lblBuscaCep.AutoSize = true;
            lblBuscaCep.Font = new Font("Arial", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscaCep.ForeColor = SystemColors.HotTrack;
            lblBuscaCep.Location = new Point(229, 111);
            lblBuscaCep.Margin = new Padding(4, 0, 4, 0);
            lblBuscaCep.Name = "lblBuscaCep";
            lblBuscaCep.Size = new Size(298, 62);
            lblBuscaCep.TabIndex = 1;
            lblBuscaCep.Text = "Busca Cep";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 72);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Arial Narrow", 16F);
            lblCEP.Location = new Point(41, 295);
            lblCEP.Margin = new Padding(4, 0, 4, 0);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(134, 26);
            lblCEP.TabIndex = 4;
            lblCEP.Text = "Informe o CEP:";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogradouro.Location = new Point(41, 391);
            lblLogradouro.Margin = new Padding(4, 0, 4, 0);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(109, 25);
            lblLogradouro.TabIndex = 5;
            lblLogradouro.Text = "Logradouro:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Arial Narrow", 16F);
            lblBairro.Location = new Point(41, 433);
            lblBairro.Margin = new Padding(4, 0, 4, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(65, 26);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Arial Narrow", 16F);
            lblCidade.Location = new Point(41, 476);
            lblCidade.Margin = new Padding(4, 0, 4, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(74, 26);
            lblCidade.TabIndex = 7;
            lblCidade.Text = "Cidade:";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Arial Narrow", 16F);
            lblUF.Location = new Point(43, 520);
            lblUF.Margin = new Padding(4, 0, 4, 0);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(41, 26);
            lblUF.TabIndex = 8;
            lblUF.Text = "UF:";
            // 
            // lblMostrarLogradouro
            // 
            lblMostrarLogradouro.AutoSize = true;
            lblMostrarLogradouro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarLogradouro.Location = new Point(287, 391);
            lblMostrarLogradouro.Margin = new Padding(4, 0, 4, 0);
            lblMostrarLogradouro.Name = "lblMostrarLogradouro";
            lblMostrarLogradouro.Size = new Size(0, 25);
            lblMostrarLogradouro.TabIndex = 9;
            // 
            // lblMostrarBairro
            // 
            lblMostrarBairro.AutoSize = true;
            lblMostrarBairro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarBairro.Location = new Point(287, 434);
            lblMostrarBairro.Margin = new Padding(4, 0, 4, 0);
            lblMostrarBairro.Name = "lblMostrarBairro";
            lblMostrarBairro.Size = new Size(0, 25);
            lblMostrarBairro.TabIndex = 10;
            // 
            // lblMostrarCidade
            // 
            lblMostrarCidade.AutoSize = true;
            lblMostrarCidade.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarCidade.Location = new Point(287, 477);
            lblMostrarCidade.Margin = new Padding(4, 0, 4, 0);
            lblMostrarCidade.Name = "lblMostrarCidade";
            lblMostrarCidade.Size = new Size(0, 25);
            lblMostrarCidade.TabIndex = 11;
            // 
            // lblMostrarUF
            // 
            lblMostrarUF.AutoSize = true;
            lblMostrarUF.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarUF.Location = new Point(287, 520);
            lblMostrarUF.Margin = new Padding(4, 0, 4, 0);
            lblMostrarUF.Name = "lblMostrarUF";
            lblMostrarUF.Size = new Size(0, 25);
            lblMostrarUF.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 43);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Highlight;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(635, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Highlight;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(668, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(44, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 29);
            label1.TabIndex = 14;
            label1.Text = "achador de cep 2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(149, 584);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(399, 32);
            label2.TabIndex = 15;
            label2.Text = "Desenvolvido por: Matheusar";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.HotTrack;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 6);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(44, 326);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(131, 29);
            txtCep.TabIndex = 17;
            txtCep.MaskInputRejected += this.txtCep_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 625);
            Controls.Add(txtCep);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lblMostrarUF);
            Controls.Add(lblMostrarCidade);
            Controls.Add(lblMostrarBairro);
            Controls.Add(lblMostrarLogradouro);
            Controls.Add(lblUF);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblLogradouro);
            Controls.Add(lblCEP);
            Controls.Add(pictureBox1);
            Controls.Add(lblBuscaCep);
            Controls.Add(btnBuscar);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label lblBuscaCep;
        private TextBox txtCep;
        private PictureBox pictureBox1;
        private Label lblCEP;
        private Label lblLogradouro;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUF;
        private Label lblMostrarLogradouro;
        private Label lblMostrarBairro;
        private Label lblMostrarCidade;
        private Label lblMostrarUF;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private MaskedTextBox txtCep;
    }
}
