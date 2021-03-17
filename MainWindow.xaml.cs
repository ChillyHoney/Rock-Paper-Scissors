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
        
        
        public MainWindow()
        {
            InitializeComponent();
            

    }

        private void btnOnePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 1;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
        }

        private void btnThreePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 3;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
        }

        private void btnFivePoint_Click(object sender, RoutedEventArgs e)
        {
            intGameIsUpTo = 5;
            LabelGameIsUpTo.Content = strGameIsUpTo + intGameIsUpTo + strGameIsUpTo2;
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));

            Random r = new Random();
            int rInt = r.Next(0, 3);
            

            switch (rInt)
                {
                    case 0:
                        imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                        LabelResult.Content = "Draw";
                        LabelAI.Content = "AI: " + ++scoreAI;
                        LabelYou.Content = "You: " + ++scoreYou;
                        break;
                    case 1:
                        imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));
                        LabelResult.Content = "You lose";
                        LabelAI.Content = "AI: " + ++scoreAI;
                        break;
                    case 2:
                        imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                        LabelResult.Content = "You won";
                        LabelYou.Content = "You: " + ++scoreYou;
                        break;
                }

            
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));

            Random r = new Random();
            int rInt = r.Next(0, 3);
            

            switch (rInt)
                {
                    case 0:
                        imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                        LabelResult.Content = "You won";
                        LabelYou.Content = "You: " + ++scoreAI;
                        break;
                    case 1:
                        imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));
                        LabelResult.Content = "Draw";
                        LabelAI.Content = "AI: " + ++scoreAI;
                        LabelYou.Content = "You: " + ++scoreYou;
                        break;
                    case 2:
                        imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                        LabelResult.Content = "You lose";
                        LabelAI.Content = "AI: " + ++scoreAI;
                        break;
                }
         
            
        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
            imgYou.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));

            Random r = new Random();
            int rInt = r.Next(0, 3);
            

            switch (rInt)
            {
                case 0:
                    imgAI.Source = new BitmapImage(new Uri(@"https://jonathanyiv.github.io/rock-paper-scissors/assets/images/rock.jpg"));
                    LabelResult.Content = "You lose";
                    LabelAI.Content = "AI: " + ++scoreAI;
                    break;
                case 1:
                    imgAI.Source = new BitmapImage(new Uri(@"https://studio.code.org/v3/assets/A2SRu-eyjeKId-hZqDedVlscWzS_u_g01W2T5Ei2Sro/21mag-abstractimages-slide-2T4N-jumbo.jpg"));                    
                    LabelResult.Content = "You won";                    
                    LabelYou.Content = "You: " + ++scoreYou;
                    break;
                case 2:
                    imgAI.Source = new BitmapImage(new Uri(@"http://graphics8.nytimes.com/images/2011/08/21/magazine/21mag-abstractimages-slide-IRQ1/21mag-abstractimages-slide-IRQ1-jumbo.jpg"));
                    LabelResult.Content = "Draw";
                    LabelAI.Content = "AI: " + ++scoreAI;
                    LabelYou.Content = "You: " + ++scoreYou;
                    break;
            }


        }

       

        
    }
   
}
