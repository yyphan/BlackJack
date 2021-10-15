using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        // CONSTANTS
        private const int DealerMax = 16;
        private const int LostScore = -10; 
        private const int WinScoreNormal = 10;
        private const int WinScoreBJ = 15;

        // VARIABLES
        private int playerScore = 0;
        private Deck deck;
        private Hand playerHand;
        private Hand dealerHand;
        private Boolean isNewRound = true;
        private Boolean isPlayerStaying = false;
        private Boolean isDealerStaying = false;

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
        }

        private void btnPlayerHit_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "Score: " + playerScore;

            if (isNewRound)
            {
                StartNewRound();
            }
            else 
            {
                deck.DrawCard(playerHand);

                if (dealerHand.CurrentSum > DealerMax)
                {
                    isDealerStaying = true;
                }
                else
                {
                    deck.DrawCard(dealerHand);
                }  
            }

            DisplayHands();

            Check21();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            // Disable when showing the results
            if (isNewRound) return;

            isPlayerStaying = true;

            while (!isDealerStaying)
            {
                if (dealerHand.CurrentSum > DealerMax)
                {
                    isDealerStaying = true;
                }
                else
                {
                    deck.DrawCard(dealerHand);
                }
            }
            DisplayHands();
            CheckSum();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxResult.Text = "Welcome to Black Jack" + Environment.NewLine +
                                "Click Hit to Start";
        }

        private void StartNewRound()
        {
            playerHand = new Hand(deck);
            dealerHand = new Hand(deck);
            textBoxResult.Text = "Score: " + playerScore + Environment.NewLine;

            isNewRound = false;
            isPlayerStaying = false;
            isDealerStaying = false;
        }

        private void DisplayHands()
        {
            textBoxPlayerHand.Clear();
            textBoxDealerHand.Clear();

            foreach (Card playerCard in playerHand.Cards)
            {
                textBoxPlayerHand.Text += playerCard.ToString() + Environment.NewLine;
                
            }

            foreach (Card dealerCard in dealerHand.Cards)
            {
                textBoxDealerHand.Text += dealerCard.ToString() + Environment.NewLine;
            }

            // Display Sum
            labelPlayerSum.Text = playerHand.CurrentSum.ToString();
            labelDealerSum.Text = dealerHand.CurrentSum.ToString();
        }

        private Boolean Check21()
        {
            if (playerHand.CurrentSum > 21 || dealerHand.CurrentSum > 21)
            {
                if (playerHand.CurrentSum > dealerHand.CurrentSum)
                {
                    PlayerLost();
                }
                else if (playerHand.CurrentSum < dealerHand.CurrentSum)
                {
                    PlayerWon();
                }
                else
                {
                    Tie();
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        private void CheckSum()
        {
            // Proceed only if neither players exceeds 21
            if (!Check21()) return;

            if (playerHand.CurrentSum > dealerHand.CurrentSum)
            {
                PlayerWon();
            }
            else if (playerHand.CurrentSum == dealerHand.CurrentSum)
            {
                Tie();
            }
            else
            {
                PlayerLost();
            }
        }

        private void PlayerLost()
        {
            playerScore += LostScore;
            textBoxResult.Text = "Score: " + playerScore + Environment.NewLine;
            textBoxResult.Text += "You lost last round " + playerHand.CurrentSum + " to " + dealerHand.CurrentSum + Environment.NewLine;
            textBoxResult.Text += "Click Hit to Continue";
            isNewRound = true;
        }

        private void Tie()
        {
            textBoxResult.Text = "Score: " + playerScore + Environment.NewLine;
            textBoxResult.Text += "Last round was a tie " + playerHand.CurrentSum + " to " + dealerHand.CurrentSum + Environment.NewLine;
            textBoxResult.Text += "Click Hit to Continue";
            isNewRound = true;
        }

        private void PlayerWon()
        {
            if (playerHand.CurrentSum == 21 && playerHand.Cards.Count == 2)
            {
                playerScore += WinScoreBJ;
                textBoxResult.Text = "Score: " + playerScore + Environment.NewLine;
                textBoxResult.Text += "Black Jack!!!" + Environment.NewLine;
            }
            else
            {
                playerScore += WinScoreNormal;
                textBoxResult.Text = "Score: " + playerScore + Environment.NewLine;
            }
            textBoxResult.Text += "You won last round " + playerHand.CurrentSum + " to " + dealerHand.CurrentSum + Environment.NewLine;
            textBoxResult.Text += "Click Hit to Continue";
            isNewRound = true;
        }
    }
}
