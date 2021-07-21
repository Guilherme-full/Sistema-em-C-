
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
            this.SuspendLayout();
            // 
            // textoSoftware
            // 
            this.textoSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSoftware.ForeColor = System.Drawing.Color.Black;
            this.textoSoftware.Location = new System.Drawing.Point(12, 24);
            this.textoSoftware.Multiline = true;
            this.textoSoftware.Name = "textoSoftware";
            this.textoSoftware.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textoSoftware.Size = new System.Drawing.Size(776, 346);
            this.textoSoftware.TabIndex = 0;
            this.textoSoftware.Text = resources.GetString("textoSoftware.Text");
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textoSoftware);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sistema_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoSoftware;
    }
}