
namespace PrimeiraAplicação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.Gerador = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairAplicação = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBancoDeDados = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.Red;
            this.btnCarregar.Location = new System.Drawing.Point(284, 40);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(195, 60);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar Imagem";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Gerador
            // 
            this.Gerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerador.ForeColor = System.Drawing.Color.Red;
            this.Gerador.Location = new System.Drawing.Point(284, 228);
            this.Gerador.Name = "Gerador";
            this.Gerador.Size = new System.Drawing.Size(195, 53);
            this.Gerador.TabIndex = 3;
            this.Gerador.Text = "Gerar Número";
            this.Gerador.UseVisualStyleBackColor = true;
            this.Gerador.Click += new System.EventHandler(this.Gerador_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.SairAplicação});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // SairAplicação
            // 
            this.SairAplicação.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairAplicação.ForeColor = System.Drawing.Color.Red;
            this.SairAplicação.Name = "SairAplicação";
            this.SairAplicação.Size = new System.Drawing.Size(45, 24);
            this.SairAplicação.Text = "Sair";
            this.SairAplicação.Click += new System.EventHandler(this.SairAplicação_Click);
            // 
            // btnBancoDeDados
            // 
            this.btnBancoDeDados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBancoDeDados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBancoDeDados.ForeColor = System.Drawing.Color.Red;
            this.btnBancoDeDados.Location = new System.Drawing.Point(284, 318);
            this.btnBancoDeDados.Name = "btnBancoDeDados";
            this.btnBancoDeDados.Size = new System.Drawing.Size(195, 58);
            this.btnBancoDeDados.TabIndex = 5;
            this.btnBancoDeDados.Text = "Banco de Dados";
            this.btnBancoDeDados.UseVisualStyleBackColor = false;
            this.btnBancoDeDados.Click += new System.EventHandler(this.btnBancoDeDados_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.Red;
            this.btnCalculadora.Location = new System.Drawing.Point(284, 137);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(195, 55);
            this.btnCalculadora.TabIndex = 6;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnBancoDeDados);
            this.Controls.Add(this.Gerador);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button Gerador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairAplicação;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.Button btnBancoDeDados;
        private System.Windows.Forms.Button btnCalculadora;
    }
}

