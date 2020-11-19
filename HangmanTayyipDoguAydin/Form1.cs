using HangmanTayyipDoguAydin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanTayyipDoguAydin
{
    public partial class hangmanProg : Form
    {
        string _word;
        int _error;

        WordProcesses wordChoice;
        WordProcesses stars;

        public hangmanProg()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            wordChoice = new WordProcesses();
            stars = new WordProcesses();
            label3.Visible = false;
            lbErrorCount.Visible = false;
            lbShow.Visible = false;
        }

        private void bSendSentence_Click(object sender, EventArgs e)
        {
            string sentence = rtbSentence.Text.Trim();
            
            lbShow.Items.Add(sentence);
            _word = wordChoice.wordSelection(sentence);
            string output = stars.initialStars(_word);

            lbShow.Items.Add(_word);
            lbGuess.Items.Add(output);
        }

        private void bSendLetter_Click(object sender, EventArgs e)
        {
            bSendSentence.Enabled = false;

            if (tbLetter.Text.Length > 1)
            {
                MessageBox.Show("Please enter a one letter!");
            }
            else if (rtbSentence.Text.Length == 0 && tbLetter.Text.Length == 0)
            {
                MessageBox.Show("Please enter a sentence first!");
            }
            else if (rtbSentence.Text.Length == 0 && tbLetter.Text.Length != 0)
            {
                MessageBox.Show("Please enter a sentence first!");
            }
            else if (lbGuess.Items.Count == 0 && tbLetter.Text.Length != 0)
            {
                MessageBox.Show("Please send sentence first");
            }
            else
            {
                char input = Convert.ToChar(tbLetter.Text.Trim());

                string output = stars.numberOfStars(_word, input);

                lbGuess.Items.Clear();
                lbGuess.Items.Add(output);

                _error = stars.errorCount();
                lbErrorCount.Items.Clear();
                lbErrorCount.Items.Add(_error);

               
                
                if (_word == output && _error < 6)
                {
                    lbGuess.Items.Clear();
                    lbGuess.Items.Add("you guessed it right before hanged! The word was " + _word);
                    bSendLetter.Enabled = false;

                }

                switch (_error)
                {
                    case 1:
                        label3.Visible = true;
                        lbHangedOne.Items.Add(wordChoice.hangMan(1));
                        break;
                    case 2:
                        lbHangedTwo.Items.Add(wordChoice.hangMan(2));
                        break;
                    case 3:
                        lbHangedTwo.Items.Clear();
                        lbHangedTwo.Items.Add(wordChoice.hangMan(3));
                        break;
                    case 4:
                        lbHangedTwo.Items.Clear();
                        lbHangedTwo.Items.Add(wordChoice.hangMan(4));
                        break;
                    case 5:
                        lbHangedThree.Items.Add(wordChoice.hangMan(5));
                        break;
                    case 6:
                        lbHangedThree.Items.Clear();
                        lbHangedThree.Items.Add(wordChoice.hangMan(6));
                        lbGuess.Items.Clear();
                        lbGuess.Items.Add("You couldn't guess before hanged :( The word was " + _word);
                        bSendLetter.Enabled = false;
                        break;

                    default:
                        break;
                }

            }
        }

        private void bReplay_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }
    }
}
