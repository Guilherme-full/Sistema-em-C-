
namespace PrimeiraAplicação
{
    partial class Excluir_Informações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir_Informações));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlExcluirInfo = new System.Windows.Forms.Panel();
            this.textExcluir = new System.Windows.Forms.TextBox();
            this.pnlExcluirInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(96, 140);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 42);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlExcluirInfo
            // 
            this.pnlExcluirInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlExcluirInfo.Controls.Add(this.textExcluir);
            this.pnlExcluirInfo.Controls.Add(this.btnExcluir);
            this.pnlExcluirInfo.Controls.Add(this.label1);
            this.pnlExcluirInfo.Location = new System.Drawing.Point(117, 52);
            this.pnlExcluirInfo.Name = "pnlExcluirInfo";
            this.pnlExcluirInfo.Size = new System.Drawing.Size(598, 250);
            this.pnlExcluirInfo.TabIndex = 3;
            // 
            // textExcluir
            // 
            this.textExcluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExcluir.Location = new System.Drawing.Point(130, 51);
            this.textExcluir.Multiline = true;
            this.textExcluir.Name = "textExcluir";
            this.textExcluir.Size = new System.Drawing.Size(294, 30);
            this.textExcluir.TabIndex = 3;
            // 
            // Excluir_Informações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlExcluirInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Excluir_Informações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir_Informações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Excluir_Informações_FormClosed);
            this.Load += new System.EventHandler(this.Excluir_Informações_Load);
            this.pnlExcluirInfo.ResumeLayout(false);
            this.pnlExcluirInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlExcluirInfo;
        private System.Windows.Forms.TextBox textExcluir;
    }
}