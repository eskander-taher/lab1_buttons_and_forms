using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_buttons_and_forms
{
    public partial class formMain : System.Windows.Forms.Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        public int arr_counter = 0;
        //public int correct_counter = 0;
        public int char_counter = 0;
        public int wrong_counter = 0;

        int timer_ticks;

        public string[] WORDS = new string[] { "follow","children","door","follow","drive","air","walk","round","which","force","early","world","cold","free","always" };

        private void btnStart_Click(object sender, EventArgs e)
        {
            //here I initilize the programm with all fields empty
            arr_counter = 0;
            tbSource.Text = WORDS[arr_counter];
            tbType.Text = "";
            tbScore.Text = "0";
            timer.Start();
        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {
            // I check if the space was typed to compare and find if it is correct
            if (tbType.Text.EndsWith(" "))
            {
                if (arr_counter >= WORDS.Length - 1)
                    arr_counter = 0;

                
                tbType.Text = tbType.Text.Remove(tbType.Text.Length - 1);//remove the space to compare

                if (string.Equals(WORDS[arr_counter], tbType.Text))
                {
                    char_counter++;
                    char_counter += tbSource.Text.Length;
                    tbScore.Text = "Your CPM is: " + char_counter.ToString() + ", WPM: " + (char_counter / 5).ToString() + ", Wrong words: " + wrong_counter.ToString();
                }else
                {
                    wrong_counter++;
                    tbScore.Text = "Your CPM is: " + char_counter.ToString() + ", WPM: " + (char_counter / 5).ToString() + ", Wrong words: " + wrong_counter.ToString();
                }

                arr_counter++;
                tbSource.Text = WORDS[arr_counter];
                tbType.Text = "";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text =  (timer_ticks++).ToString();
            if (timer_ticks > 10)
            {
                timer.Stop();
                timer_ticks = 0;
                lblTimer.Text = "0";
                arr_counter = 0;
                tbSource.Text = WORDS[arr_counter];
                tbType.Text = "";
                tbScore.Text = "Your CPM is: "+ char_counter.ToString() + ", WPM: " + (char_counter/5).ToString() + ",Wrong words: " + wrong_counter.ToString();
                char_counter = 0;
            }
                
        }
    }
}
