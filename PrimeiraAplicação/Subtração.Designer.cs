
namespace PrimeiraAplicação
{
    partial class Subtração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subtração));
            this.text = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(273, 73);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(188, 30);
            this.text.TabIndex = 5;
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(273, 150);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(187, 30);
            this.text2.TabIndex = 6;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.ForeColor = System.Drawing.Color.Red;
            this.btnSubtrair.Location = new System.Drawing.Point(323, 226);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(98, 43);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(305, 311);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(135, 43);
            this.Result.TabIndex = 8;
            // 
            // Subtração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subtração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Subtração_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.TextBox Result;
    }
}