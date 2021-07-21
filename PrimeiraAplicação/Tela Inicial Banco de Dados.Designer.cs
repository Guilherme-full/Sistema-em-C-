
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
            this.SuspendLayout();
            // 
            // btnCadastarInform
            // 
            this.btnCadastarInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarInform.ForeColor = System.Drawing.Color.Red;
            this.btnCadastarInform.Location = new System.Drawing.Point(27, 124);
            this.btnCadastarInform.Name = "btnCadastarInform";
            this.btnCadastarInform.Size = new System.Drawing.Size(190, 59);
            this.btnCadastarInform.TabIndex = 0;
            this.btnCadastarInform.Text = "Cadastrar Informações";
            this.btnCadastarInform.UseVisualStyleBackColor = true;
            this.btnCadastarInform.Click += new System.EventHandler(this.btnCadastarInform_Click);
            // 
            // btnAtualizaInfo
            // 
            this.btnAtualizaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaInfo.ForeColor = System.Drawing.Color.Red;
            this.btnAtualizaInfo.Location = new System.Drawing.Point(239, 124);
            this.btnAtualizaInfo.Name = "btnAtualizaInfo";
            this.btnAtualizaInfo.Size = new System.Drawing.Size(177, 59);
            this.btnAtualizaInfo.TabIndex = 1;
            this.btnAtualizaInfo.Text = "Atualizar Informações";
            this.btnAtualizaInfo.UseVisualStyleBackColor = true;
            this.btnAtualizaInfo.Click += new System.EventHandler(this.btnAtualizaInfo_Click);
            // 
            // ExcluirInfo
            // 
            this.ExcluirInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirInfo.ForeColor = System.Drawing.Color.Red;
            this.ExcluirInfo.Location = new System.Drawing.Point(438, 124);
            this.ExcluirInfo.Name = "ExcluirInfo";
            this.ExcluirInfo.Size = new System.Drawing.Size(162, 59);
            this.ExcluirInfo.TabIndex = 2;
            this.ExcluirInfo.Text = "Excluir Informações";
            this.ExcluirInfo.UseVisualStyleBackColor = true;
            this.ExcluirInfo.Click += new System.EventHandler(this.ExcluirInfo_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.Red;
            this.btnExibir.Location = new System.Drawing.Point(626, 124);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(177, 59);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir Informações";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // Tela_Inicial_Banco_de_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.ExcluirInfo);
            this.Controls.Add(this.btnAtualizaInfo);
            this.Controls.Add(this.btnCadastarInform);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Inicial_Banco_de_Dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Inicial_Banco_de_Dados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_Inicial_Banco_de_Dados_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastarInform;
        private System.Windows.Forms.Button btnAtualizaInfo;
        private System.Windows.Forms.Button ExcluirInfo;
        private System.Windows.Forms.Button btnExibir;
    }
}