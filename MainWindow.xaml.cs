using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rock_Paper_Scissors
{
    public partial class MainWindow : Window
    {
        int scoreAI = 0;
        int scoreYou = 0;
        int intGameIsUpTo = 0;
        string strGameIsUpTo = "Game is up to ";
        string strGameIsUpTo2 = " score.";
        string plusScore = "+1";
        
        public MainWindow()
        {
            InitializeComponent();

            intGameIsUpTo = 3;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;

            
        }
         
        

        private void btnOnePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 1;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
            warningMessage();
        }

        private void btnThreePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 3;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
            if (scoreYou < 3 && scoreYou >= 1)
            {
                warningMessage();
            }
            else if (scoreAI < 3 && scoreAI >= 1)
            {
                warningMessage();
            }
        }

        private void btnFivePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 5;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
            if (scoreYou < 5 && scoreYou >= 1)
            {
                warningMessage();
            }
            else if (scoreAI < 5 && scoreAI >= 1)
            {
                warningMessage();
            }
        }

        public void warningMessage()
        {
            if (MessageBox.Show("Do you want to change a game?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                
            }
            else
            {
                enableButtons();
            }
        }

        public void enableButtons()
        {
            btnRock.IsEnabled = true;
            btnPaper.IsEnabled = true;
            btnScissors.IsEnabled = true;

            scoreAI = 0;
            scoreYou = 0;

            LabelAI.Content = "AI: " + scoreAI;
            LabelYou.Content = "You: " + scoreYou;
            LabelAIplusOne.Content = "";
            LabelYouPlusOne.Content = "";
            LabelResult.Content = "";
            //changing image for buttons ---HERE---
        }

        public void disableButtons()
        {
            btnRock.IsEnabled = false;
            btnPaper.IsEnabled = false;
            btnScissors.IsEnabled = false;
            intGameIsUpTo = 0;
            //changing image for buttons ---HERE---
        }

        public void gameScore()
        {
            if (intGameIsUpTo == 1)
            {
                if (scoreYou == 1)
                {
                    LabelResult.Content = "You won a game";
                    disableButtons();
                }
                else if (scoreAI == 1)
                {
                    LabelResult.Content = "You lost a game";
                    disableButtons();
                }
            }

            if (intGameIsUpTo == 3)
            {
                if (scoreYou == 3)
                {
                    LabelResult.Content = "You won a game";
                    disableButtons();
                }
                else if (scoreAI == 3)
                {
                    LabelResult.Content = "You lost a game";
                    disableButtons();
                }
            }

            if (intGameIsUpTo == 5)
            {
                if (scoreYou == 5)
                {
                    LabelResult.Content = "You won a game";
                    disableButtons();
                }
                else if (scoreAI == 5)
                {
                    LabelResult.Content = "You lost a game";
                    disableButtons();
                }
            }
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
            LabelAIplusOne.Content = "";
            LabelYouPlusOne.Content = "";

            Random r = new Random();
            int rInt = r.Next(0, 3);
            
            switch (rInt)
                {
                    case 0:
                        imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                        LabelResult.Content = "Draw";
                        LabelResult.Foreground = new SolidColorBrush(Colors.Orange);
                        
                       // LabelAI.Content = "AI: " + ++scoreAI;
                       // LabelYou.Content = "You: " + ++scoreYou;
                       // LabelAIplusOne.Content = plusScore;
                       // LabelYouPlusOne.Content = plusScore;
                        break;
                    case 1:
                        imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));
                        LabelResult.Content = "You lose";
                        LabelResult.Foreground = new SolidColorBrush(Colors.DarkRed);

                        LabelAI.Content = "AI: " + ++scoreAI;
                        LabelAIplusOne.Content = plusScore;
                        break;
                    case 2:
                        imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                        LabelResult.Content = "You win";
                        LabelResult.Foreground = new SolidColorBrush(Colors.DarkGreen);
                  
                        LabelYouPlusOne.Content = plusScore;
                        LabelYou.Content = "You: " + ++scoreYou;
                        break;
                }

            gameScore();

        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));
            LabelAIplusOne.Content = "";
            LabelYouPlusOne.Content = "";

            Random r = new Random();
            int rInt = r.Next(0, 3);
            

            switch (rInt)
                {
                    case 0:
                        imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                        LabelResult.Content = "You win";
                        LabelResult.Foreground = new SolidColorBrush(Colors.DarkGreen);

                        LabelYou.Content = "You: " + ++scoreYou;
                        LabelYouPlusOne.Content = plusScore;
                        break;
                    case 1:
                        imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));
                        LabelResult.Content = "Draw";
                        LabelResult.Foreground = new SolidColorBrush(Colors.Orange);                        
                        
                       // LabelAI.Content = "AI: " + ++scoreAI;
                       // LabelYou.Content = "You: " + ++scoreYou;
                       // LabelAIplusOne.Content = plusScore;
                       // LabelYouPlusOne.Content = plusScore;
                        break;
                    case 2:
                        imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                        LabelResult.Content = "You lose";
                        LabelResult.Foreground = new SolidColorBrush(Colors.DarkRed);

                        LabelAI.Content = "AI: " + ++scoreAI;
                        LabelAIplusOne.Content = plusScore;
                        break;
                }

            gameScore();

        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
            LabelAIplusOne.Content = "";
            LabelYouPlusOne.Content = "";

            Random r = new Random();
            int rInt = r.Next(0, 3);
            

            switch (rInt)
            {
                case 0:
                    imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                    LabelResult.Content = "You lose";
                    LabelResult.Foreground = new SolidColorBrush(Colors.DarkRed);

                    LabelAI.Content = "AI: " + ++scoreAI;
                    LabelAIplusOne.Content = plusScore;
                    break;
                case 1:
                    imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));                    
                    LabelResult.Content = "You win";
                    LabelResult.Foreground = new SolidColorBrush(Colors.DarkGreen);

                    LabelYou.Content = "You: " + ++scoreYou;
                    LabelYouPlusOne.Content = plusScore;
                    break;
                case 2:
                    imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                    LabelResult.Content = "Draw";
                    LabelResult.Foreground = new SolidColorBrush(Colors.Orange);
                    
                   // LabelAI.Content = "AI: " + ++scoreAI;
                   // LabelYou.Content = "You: " + ++scoreYou;
                   // LabelAIplusOne.Content = plusScore;
                   // LabelYouPlusOne.Content = plusScore;
                    break;
            }

            gameScore();

        }

       

        
    }
   
}
