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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarImagem image = new CarregarImagem();
            image.Show();
            this.Hide();
        }
        
        private void Gerador_Click(object sender, EventArgs e)
        {
            Gerador_de_Número gera = new Gerador_de_Número();
            gera.Show();
            this.Hide();
        }

        private void SairAplicação_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema sistem = new Sistema();
            sistem.Show();
            this.Hide();
        }

        private void btnBancoDeDados_Click(object sender, EventArgs e)
        {
            Tela_Inicial_Banco_de_Dados tela = new Tela_Inicial_Banco_de_Dados();
            tela.Show();
            this.Hide();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formularioAberto in Application.OpenForms)
                {
                    if (formularioAberto is Tela_de_Login)
                    {
                        formularioAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
