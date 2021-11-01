using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDoBebePC
{

    public partial class JogoDoBebe : Form
    {
        public JogoDoBebe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            int rolar1 = dice.Next(1, 14);
            
            int total = rolar1;

           
            if (total == 1)
            {
                var resultadoDois = "Você tirou 1 = Você bebe.";
                lblResposta.Text = resultadoDois;
            }

            if (total == 2)
            {
                var resultadoDois = "Você tirou 2 = Escolha alguém para beber.";
                lblResposta.Text = resultadoDois;
            }

            if (total == 3)
            {
                var resultadoDois = "Você tirou 3 = Elas bebem.";
                lblResposta.Text = resultadoDois;
            }
            if (total == 4)
            {
                var resultadoDois = "Você tirou 4 =Eles bebem.";
                lblResposta.Text = resultadoDois;
            }

            if (total == 5)
            {
                var resultadoDois = "Você tirou 5 = Escolha alguém para beber 3 doses.";
                lblResposta.Text = resultadoDois;
            }
            if (total == 6)
            {
                var resultadoDois = "Você tirou 6 = Beba 3 doses. ";
                lblResposta.Text = resultadoDois;
            }
            if (total == 7)
            {
                var resultadoDois = "Você tirou 7 = Jogo do pi. Já sabem né? Multiplos de 7, números com 7, etc..";
                lblResposta.Text = resultadoDois;
            }
            if (total == 8)
            {
                var resultadoDois = "Você tirou 8 = História.";
                lblResposta.Text = resultadoDois;
            }
            if (total == 9)
            {
                var resultadoDois = "Você tirou 9 = Escolha uma regra!";
                lblResposta.Text = resultadoDois;
            }
            if (total == 10)
            {
                var resultadoDois = "Você tirou 10 = Um vale banheiro.";
                lblResposta.Text = resultadoDois;
            }
            if (total == 11)
            {
                var resultadoDois = "Você tirou 11 = Todos bebem!";
                lblResposta.Text = resultadoDois;
            }
            if (total == 12)
            {
                var resultadoDois = "Você tirou 12 = Queima regra!";
                lblResposta.Text = resultadoDois;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            int rolar1 = dice.Next(1, 8);

            int total = rolar1;


            if (total == 1)
            {
                var resultadoDois = "Imite uma galinha";
                lblResposta.Text = resultadoDois;
            }

            if (total == 2)
            {
                var resultadoDois = "Chupe um limão";
                lblResposta.Text = resultadoDois;
            }

            if (total == 3)
            {
                var resultadoDois = "Converse com um travesseiro como se fosse o amor da sua vida";
                lblResposta.Text = resultadoDois;
            }
            if (total == 4)
            {
                var resultadoDois = "Escolha uma música e cante-a até o final";
                lblResposta.Text = resultadoDois;
            }

            if (total == 5)
            {
                var resultadoDois = "Dance na boquinha da garrafa, famosa música do É o tchan!";
                lblResposta.Text = resultadoDois;
            }
            if (total == 6)
            {
                var resultadoDois = "Imite uma foca!";
                lblResposta.Text = resultadoDois;
            }
            if (total == 7)
            {
                var resultadoDois = "Cheire o pé da pessoa ao lado e descreva esse cheiro de forma poética a todos da roda";
                lblResposta.Text = resultadoDois;
            }   
        }
    }
}
