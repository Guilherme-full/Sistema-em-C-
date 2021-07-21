
namespace PrimeiraAplicação
{
    partial class Exibir_Informações
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Informações));
            this.btnExibirRegistros = new System.Windows.Forms.Button();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibirRegistros
            // 
            this.btnExibirRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirRegistros.ForeColor = System.Drawing.Color.Red;
            this.btnExibirRegistros.Location = new System.Drawing.Point(59, 32);
            this.btnExibirRegistros.Name = "btnExibirRegistros";
            this.btnExibirRegistros.Size = new System.Drawing.Size(107, 46);
            this.btnExibirRegistros.TabIndex = 0;
            this.btnExibirRegistros.Text = "Exibir";
            this.btnExibirRegistros.UseVisualStyleBackColor = true;
            this.btnExibirRegistros.Click += new System.EventHandler(this.btnExibirRegistros_Click);
            // 
            // dvgDados
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgDados.Location = new System.Drawing.Point(59, 102);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgDados.Size = new System.Drawing.Size(765, 286);
            this.dvgDados.TabIndex = 1;
            // 
            // Exibir_Informações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(922, 469);
            this.Controls.Add(this.dvgDados);
            this.Controls.Add(this.btnExibirRegistros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exibir_Informações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir_Informações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exibir_Informações_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibirRegistros;
        private System.Windows.Forms.DataGridView dvgDados;
    }
}