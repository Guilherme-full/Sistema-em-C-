﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAplicação
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void btnIrParaOlogin_Click(object sender, EventArgs e)
        {
            Tela_de_Login log = new Tela_de_Login();
            log.Show();
            this.Hide();
        }

        private void btnIrParaOCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadas = new Cadastro();
            cadas.Show();
            this.Hide();
        }
    }
}
