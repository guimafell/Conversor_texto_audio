using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Conversor_txt_per_sound
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private static SpeechSynthesizer synthesizer;
        private void button1_Click(object sender, EventArgs e)
        {
            string convesor = TxtForAudio.Text;
            synthesizer = new SpeechSynthesizer();

            if (convesor!="")
            {
                
                synthesizer.SpeakAsync(convesor);

                
            }
            else
            {
                string aviso = "Escreva um texto para eu poder falar";
                synthesizer.SpeakAsync(aviso);
                MessageBox.Show(aviso);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtForAudio.Text = "";
        }
        
    }
}
