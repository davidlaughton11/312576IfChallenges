﻿/*David Laughton
 * March 6 2019
 * If Challenges
 */
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

namespace _312576IfChallenges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1;
        int num2;

        int num3;
        int num4;
        int num5;

        int num6;

        int num7;

        int num8;

        int num9;

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSize_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numSize1.Text, out num1);
            int.TryParse(numSize2.Text, out num2);

            if (num1 > num2)
            {
                lblOutput.Content = num1;
            }
            else
            {
                lblOutput.Content = num2;
            }
        }

        private void btnSize1_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numSize3.Text, out num3);
            int.TryParse(numSize4.Text, out num4);
            int.TryParse(numSize5.Text, out num5);

            if (num3 > num4 && num3 > num5)
            {
                lblOutput1.Content = num3;
            }
            else if (num4 > num3 && num4 > num5)
            {
                lblOutput1.Content = num4;
            }
            else if (num5 > num3 && num5 > num4)
            {
                lblOutput1.Content = num5;
            }
        }

        private void btnnum_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numPN0.Text, out num6);
            if (num6 == 0)
            {
                lblOutput2.Content = "0";
            }
            else if (num6 > 0)
            {
                lblOutput2.Content = "Positive";
            }
            else if (num6 < 0)
            {
                lblOutput2.Content = "Negitive";
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numDiv.Text, out num7);
            if ((num7 % 5) == 0 && (num7 % 11) == 0)
            {
                lblOutput3.Content = "It is divisable by 5 and 11";
            }
            else
            {
                lblOutput3.Content = "It is not divisable";
            }
        }

        private void btnEO_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numEO.Text, out num8);
            if ((num8 % 2) == 0)
            {
                lblOutput4.Content = "It is even";
            }
            else
            {
                lblOutput4.Content = "It is odd";
            }
        }

        private void btnLY_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numLY.Text, out num9);
            if ((num9 % 4) == 0)
            {
                lblOutput5.Content = "It is a leap year";
            }
            else
            {
                lblOutput5.Content = "It is not a leap year";
            }
        }
        //Find how to do this with alphabet or not 
        private void btnChar1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
