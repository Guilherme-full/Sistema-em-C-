
namespace PrimeiraAplicação
{
    partial class Tela_Inicial_Banco_de_Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial_Banco_de_Dados));
            this.btnCadastarInform = new System.Windows.Forms.Button();
            this.btnAtualizaInfo = new System.Windows.Forms.Button();
            this.ExcluirInfo = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.pnlTelaInicialBanco = new System.Windows.Forms.Panel();
            this.pnlTelaInicialBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastarInform
            // 
            this.btnCadastarInform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastarInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarInform.ForeColor = System.Drawing.Color.White;
            this.btnCadastarInform.Location = new System.Drawing.Point(23, 91);
            this.btnCadastarInform.Name = "btnCadastarInform";
            this.btnCadastarInform.Size = new System.Drawing.Size(190, 59);
            this.btnCadastarInform.TabIndex = 0;
            this.btnCadastarInform.Text = "Cadastrar Informações";
            this.btnCadastarInform.UseVisualStyleBackColor = false;
            this.btnCadastarInform.Click += new System.EventHandler(this.btnCadastarInform_Click);
            // 
            // btnAtualizaInfo
            // 
            this.btnAtualizaInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAtualizaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaInfo.ForeColor = System.Drawing.Color.White;
            this.btnAtualizaInfo.Location = new System.Drawing.Point(242, 91);
            this.btnAtualizaInfo.Name = "btnAtualizaInfo";
            this.btnAtualizaInfo.Size = new System.Drawing.Size(177, 59);
            this.btnAtualizaInfo.TabIndex = 1;
            this.btnAtualizaInfo.Text = "Atualizar Informações";
            this.btnAtualizaInfo.UseVisualStyleBackColor = false;
            this.btnAtualizaInfo.Click += new System.EventHandler(this.btnAtualizaInfo_Click);
            // 
            // ExcluirInfo
            // 
            this.ExcluirInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExcluirInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirInfo.ForeColor = System.Drawing.Color.White;
            this.ExcluirInfo.Location = new System.Drawing.Point(442, 91);
            this.ExcluirInfo.Name = "ExcluirInfo";
            this.ExcluirInfo.Size = new System.Drawing.Size(162, 59);
            this.ExcluirInfo.TabIndex = 2;
            this.ExcluirInfo.Text = "Excluir Informações";
            this.ExcluirInfo.UseVisualStyleBackColor = false;
            this.ExcluirInfo.Click += new System.EventHandler(this.ExcluirInfo_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.White;
            this.btnExibir.Location = new System.Drawing.Point(631, 91);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(177, 59);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir Informações";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // pnlTelaInicialBanco
            // 
            this.pnlTelaInicialBanco.BackColor = System.Drawing.Color.Transparent;
            this.pnlTelaInicialBanco.Controls.Add(this.ExcluirInfo);
            this.pnlTelaInicialBanco.Controls.Add(this.btnCadastarInform);
            this.pnlTelaInicialBanco.Controls.Add(this.btnExibir);
            this.pnlTelaInicialBanco.Controls.Add(this.btnAtualizaInfo);
            this.pnlTelaInicialBanco.Location = new System.Drawing.Point(12, 58);
            this.pnlTelaInicialBanco.Name = "pnlTelaInicialBanco";
            this.pnlTelaInicialBanco.Size = new System.Drawing.Size(823, 265);
            this.pnlTelaInicialBanco.TabIndex = 4;
            // 
            // Tela_Inicial_Banco_de_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.pnlTelaInicialBanco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Inicial_Banco_de_Dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Inicial_Banco_de_Dados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_Inicial_Banco_de_Dados_FormClosed);
            this.Load += new System.EventHandler(this.Tela_Inicial_Banco_de_Dados_Load);
            this.pnlTelaInicialBanco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastarInform;
        private System.Windows.Forms.Button btnAtualizaInfo;
        private System.Windows.Forms.Button ExcluirInfo;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Panel pnlTelaInicialBanco;
    }
}