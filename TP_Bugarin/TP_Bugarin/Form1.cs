using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Bugarin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand;
        //array of words used in the game
        string[] words =
        {
        "book","boat","jump","monster","hiccup","archer","coffee","shadow","window","darts"
    };
        //variables for the word 
        string word;
        int word_order;
        //variables for the score
        int score;
        int incorrectGuesses;

        // to display the guessing word, but hidding some letters
        public void WordGuess()
        {
            //loop for words 
            if (word_order < words.Length)
            {
                //to Uppercase the words
                word = words[word_order].ToUpper();
                int word_length = word.Length;
                StringBuilder wordGuess = new StringBuilder(word_length);
                int mask = word_length / 2; // Number of letters to hide
                HashSet<int> letter_mask = new HashSet<int>();

                // to hide rand
                while (letter_mask.Count < mask)
                {
                    letter_mask.Add(rand.Next(word_length));
                }

                for (int i = 0; i < word_length; i++)
                {
                    if (letter_mask.Contains(i))
                    {
                        wordGuess.Append("?");
                    }
                    else
                    {
                        wordGuess.Append(word[i]);
                    }
                }
                lb_wordGuess.Text = wordGuess.ToString();
            }
            else
            {
                RefreshWords();
                WordGuess();
            }
        }

        public void RefreshWords()
        {
            words = words.OrderBy(x => rand.Next()).ToArray();
            word_order = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            RefreshWords();
            WordGuess();
            score = 0;
            incorrectGuesses = 0;
            UpdateScoreLabel();
        }

        private void tb_guess_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text.Equals("Play Again?"))
            {
                word_order++;
                if (word_order < words.Length)
                {
                    WordGuess();
                    tb_guess.Text = "Guess";
                    WrongList.Items.Clear();
                    incorrectGuesses = 0;
                }
                else
                {
                    MessageBox.Show("No more words to guess.");
                }
                tb_answer.Text = "";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tb_answer.Text))
                {
                    MessageBox.Show("Please enter a guess.");
                    return;
                }

                if (tb_answer.Text.ToUpper().Equals(word))
                {
                    lb_wordGuess.Text = word;
                    tb_guess.Text = "Play Again?";
                    MessageBox.Show("Correct Guess");
                    score++;
                }
                else
                {
                    WrongList.Items.Add(tb_answer.Text);
                    MessageBox.Show("Wrong Guess");
                    incorrectGuesses++;
                }
                tb_answer.Text = "";

                UpdateScoreLabel();
            }
        }
        //method to update the score
        private void UpdateScoreLabel()
        {
            lb_score.Text= "Score: " +score.ToString();
        }
    }
}
