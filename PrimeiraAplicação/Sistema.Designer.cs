
namespace PrimeiraAplicação
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.textoSoftware = new System.Windows.Forms.TextBox();
            this.pnlSistema = new System.Windows.Forms.Panel();
            this.pnlSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoSoftware
            // 
            this.textoSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textoSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSoftware.ForeColor = System.Drawing.Color.White;
            this.textoSoftware.Location = new System.Drawing.Point(8, 21);
            this.textoSoftware.Multiline = true;
            this.textoSoftware.Name = "textoSoftware";
            this.textoSoftware.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textoSoftware.Size = new System.Drawing.Size(776, 341);
            this.textoSoftware.TabIndex = 0;
            this.textoSoftware.Text = resources.GetString("textoSoftware.Text");
            // 
            // pnlSistema
            // 
            this.pnlSistema.Controls.Add(this.textoSoftware);
            this.pnlSistema.Location = new System.Drawing.Point(4, 4);
            this.pnlSistema.Name = "pnlSistema";
            this.pnlSistema.Size = new System.Drawing.Size(794, 385);
            this.pnlSistema.TabIndex = 1;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSistema);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sistema_FormClosed);
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.pnlSistema.ResumeLayout(false);
            this.pnlSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoSoftware;
        private System.Windows.Forms.Panel pnlSistema;
    }
}