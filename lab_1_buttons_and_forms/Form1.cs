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
        public int correct_counter = 0;

        public string[] WORDS = new string[] { "follow","children","door","follow","drive","air","walk","round","which","force","early","world","cold","free","always" };

        private void btnStart_Click(object sender, EventArgs e)
        {
            //here I initilize the programm with all fields empty
            arr_counter = 0;
            correct_counter = 0;
            tbSource.Text = WORDS[arr_counter];
            tbType.Text = "";
            lblScore.Text = "0";
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
                    correct_counter++;
                    lblScore.Text = correct_counter.ToString();
                }

                arr_counter++;
                tbSource.Text = WORDS[arr_counter];
                tbType.Text = "";
            }
        }
    }
}
