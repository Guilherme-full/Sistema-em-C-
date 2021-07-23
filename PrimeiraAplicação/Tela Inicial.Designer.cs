
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairAplicação = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBancoDeDados = new System.Windows.Forms.Button();
            this.pnlBancoDeDados = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlBancoDeDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.SairAplicação});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // SairAplicação
            // 
            this.SairAplicação.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairAplicação.ForeColor = System.Drawing.Color.White;
            this.SairAplicação.Name = "SairAplicação";
            this.SairAplicação.Size = new System.Drawing.Size(48, 26);
            this.SairAplicação.Text = "Sair";
            this.SairAplicação.Click += new System.EventHandler(this.SairAplicação_Click);
            // 
            // btnBancoDeDados
            // 
            this.btnBancoDeDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBancoDeDados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBancoDeDados.ForeColor = System.Drawing.Color.White;
            this.btnBancoDeDados.Location = new System.Drawing.Point(155, 85);
            this.btnBancoDeDados.Name = "btnBancoDeDados";
            this.btnBancoDeDados.Size = new System.Drawing.Size(195, 58);
            this.btnBancoDeDados.TabIndex = 5;
            this.btnBancoDeDados.Text = "Banco de Dados";
            this.btnBancoDeDados.UseVisualStyleBackColor = false;
            this.btnBancoDeDados.Click += new System.EventHandler(this.btnBancoDeDados_Click);
            // 
            // pnlBancoDeDados
            // 
            this.pnlBancoDeDados.BackColor = System.Drawing.Color.Transparent;
            this.pnlBancoDeDados.Controls.Add(this.btnBancoDeDados);
            this.pnlBancoDeDados.Location = new System.Drawing.Point(148, 51);
            this.pnlBancoDeDados.Name = "pnlBancoDeDados";
            this.pnlBancoDeDados.Size = new System.Drawing.Size(516, 357);
            this.pnlBancoDeDados.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBancoDeDados);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBancoDeDados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairAplicação;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.Button btnBancoDeDados;
        private System.Windows.Forms.Panel pnlBancoDeDados;
    }
}

