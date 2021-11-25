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
        public string[] WORDS = new string[] { "follow", "children", "door", "follow", "drive", "air", "walk", "round", "which", "force", "early", "world", "cold", "free", "always"};
        public int arr_counter = 0;
        public int char_counter = 0;
        public int wrong_counter = 0;
        public bool started = false;
        public int timer_ticks = 60;
        public int lbl_number = 1;

        public formMain()
        {
            //initilze the programm with default values
            InitializeComponent();
            arr_counter = 0;
            tbSource.Text = WORDS[arr_counter];
            tbType.Text = "";
            tbScore.Text = "Your CPM is: 0, WPM: 0, Wrong words: 0";
            wrong_counter = 0;
            rbDarkMode.Checked = true;

            //timer.Stop();
            timer_ticks = 60;
            lblTimer.Text = timer_ticks.ToString();
            started = false;
            tbType.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //restart the programm with all fields defualt values
            btnStart.Text = "Restart";
            arr_counter = 0;
            tbSource.Text = WORDS[arr_counter];
            tbType.Text = "";
            tbScore.Text = "Your CPM is: 0, WPM: 0, Wrong words: 0";
            wrong_counter = 0;
            timer.Stop();
            timer_ticks = 60;
            lblTimer.Text = timer_ticks.ToString();
            started = true;
            pbTimer.Value = 0;
            tbType.Focus();
        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {
            //check if programm restarted to start the timer
            if (string.Equals(btnStart.Text,"Restart") && started == true)
                timer.Start();

            //check if the space was typed in order to start comparing the two strings
            while (tbType.Text.EndsWith(" ") && started == true)
            {
                //if strings bank reaches end, start from the begining
                if (arr_counter >= WORDS.Length - 1)
                    arr_counter = 0;

                //remove the space to start comparing
                tbType.Text = tbType.Text.Remove(tbType.Text.Length - 1);
                if (string.Equals(WORDS[arr_counter], tbType.Text))
                {
                    char_counter += (tbSource.Text.Length + 1);
                    tbScore.Text = "Your CPM is: " + char_counter.ToString() + ", WPM: " + (char_counter / 5).ToString() + ", Wrong words: " + wrong_counter.ToString();
                }else
                {
                    wrong_counter++;
                    tbScore.Text = "Your CPM is: " + char_counter.ToString() + ", WPM: " + (char_counter / 5).ToString() + ", Wrong words: " + wrong_counter.ToString();
                }
                
                //move to next index and add the its value to the source text box
                arr_counter++;
                tbSource.Text = WORDS[arr_counter];
                tbType.Text = "";
            }
        }

        //reinitializing the programm when timers ends
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text =  (timer_ticks--).ToString();

            //this conditional statement because progress bar can't handle floating points
            if(timer_ticks > 20)
                pbTimer.Value += 2;
            else
                pbTimer.Value += 1;

            //turn number color to red at the last 10 seconds
            if (timer_ticks < 10)
                lblTimer.ForeColor = Color.Red;

            if (timer_ticks < 0)
            {
                timer.Stop();
                timer_ticks = 60;
                lblTimer.Text = "60";
                arr_counter = 0;
                tbSource.Text = WORDS[arr_counter];
                tbType.Text = "";
                tbScore.Text = "Your CPM is: "+ char_counter.ToString() + ", WPM: " + (char_counter/ 5 ).ToString() + ", Wrong words: " + wrong_counter.ToString();
                char_counter = 0;
                btnStart.Text = "Start";
                lblTimer.ForeColor = Color.White;
                started = false;
                pbTimer.Value = 0;
            }   
        }

        private void rbDarkMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(64, 64, 64);
            lblTitle.ForeColor = Color.White;
            pbTimer.ForeColor = Color.White;
            lblTimer.ForeColor = Color.White;
            cbRecord.ForeColor = Color.White;
            rbDarkMode.ForeColor = Color.White;
            rbLightMode.ForeColor = Color.White;
        }

        private void rbLightMode_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            lblTitle.ForeColor = Color.Black;
            pbTimer.ForeColor = Color.Black;
            lblTimer.ForeColor = Color.Black;
            cbRecord.ForeColor = Color.Black;
            rbDarkMode.ForeColor = Color.Black;
            rbLightMode.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addLabel();
        }
        
        private System.Windows.Forms.Label addLabel()
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.Top = lbl_number + (191);
            lbl.Left = tbScore.Left+ 285 + 10;
            lbl.Width = 234;
            lbl.Height = 23;
            lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lbl.Text = (this.lbl_number - 29).ToString() + "- " + tbScore.Text;
            lbl.ForeColor = Color.Red;
            lbl_number += 30;
            return lbl;
        }
    }
}
