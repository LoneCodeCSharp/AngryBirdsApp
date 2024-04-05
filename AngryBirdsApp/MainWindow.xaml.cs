using AngryBirdsApp.SmoothScroll;
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

namespace AngryBirdsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double m_ScrollStepRatio = 0.0;
        double m_ScrollPositionRatio=0.0;
        public string actionPage = "";
        public MainWindow()
        {
            InitializeComponent();
            Red.AnimScrollImage();
            Chuck.AnimScrollImage();
            Stella.AnimScrollImage();
            Bomb.AnimScrollImageBack();
            Terence.AnimScrollImageBack();
            Matilda.AnimScrollImageBack();
        }

        private void backScrollbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            m_ScrollStepRatio = scrollViewer.ViewportWidth / (scrollViewer.ExtentWidth - scrollViewer.ViewportWidth);
            m_ScrollPositionRatio = scrollViewer.ContentHorizontalOffset / scrollViewer.ScrollableWidth;
            scrollViewer.SmoothScroll(m_ScrollStepRatio, m_ScrollPositionRatio, ScrollDirection.Left);
            Red.AnimScrollImage();
            Chuck.AnimScrollImage();
            Stella.AnimScrollImage();
            Bomb.AnimScrollImageBack();
            Terence.AnimScrollImageBack();
            Matilda.AnimScrollImageBack();
        }

        private void nextScrollbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            m_ScrollStepRatio=scrollViewer.ViewportWidth/(scrollViewer.ExtentWidth-scrollViewer.ViewportWidth);
            m_ScrollPositionRatio = scrollViewer.ContentHorizontalOffset / scrollViewer.ScrollableWidth;
            scrollViewer.SmoothScroll(m_ScrollStepRatio, m_ScrollPositionRatio, ScrollDirection.Right);
            Red.AnimScrollImageBack();
            Chuck.AnimScrollImageBack();
            Stella.AnimScrollImageBack();
            Bomb.AnimScrollImage();
            Terence.AnimScrollImage();
            Matilda.AnimScrollImage();
        }

        private void backtoStart_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Task.Delay(10).ContinueWith(_ =>
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    scrollViewer.Margin = new Thickness(0, 0, 0, 50);
                    Red.Width = 220;
                    Red.Height = 340;

                    Stella.Width = 220;
                    Stella.Height = 340;

                    Chuck.Width = 220;
                    Chuck.Height = 340;

                    Bomb.Width = 220;
                    Bomb.Height = 340;

                    Matilda.Width = 220;
                    Matilda.Height = 340;

                    Terence.Width = 220;
                    Terence.Height = 340;
                    if (actionPage == "Red")
                    {
                        Red.DefaultAction();
                        Chuck.DefaultGrid();
                        Bomb.DefaultGrid();
                        Stella.DefaultGrid();
                        Matilda.DefaultGrid();
                        Terence.DefaultGrid();
                    }
                    if (actionPage == "Chuck")
                    {
                        Chuck.DefaultAction();
                        Red.DefaultGrid();
                        Bomb.DefaultGrid();
                        Stella.DefaultGrid();
                        Matilda.DefaultGrid();
                        Terence.DefaultGrid();
                    }
                    if (actionPage == "Stella")
                    {
                        Stella.DefaultAction();
                        Red.DefaultGrid();
                        Chuck.DefaultGrid();
                        Bomb.DefaultGrid();
                        Matilda.DefaultGrid();
                        Terence.DefaultGrid();
                    }
                    actionPage = "";
                    backtoStart.Visibility= Visibility.Hidden;
                }


                ));
            });
        }

        private void Red_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            actionPage = "Red";
            Chuck.AnimOpacityImage();
            Stella.AnimOpacityImage(); 
            Bomb.AnimOpacityImage();
            Terence.AnimOpacityImage();
            Matilda.AnimOpacityImage();
            Task.Delay(1000).ContinueWith(_ =>
            {
            Dispatcher.Invoke((Action)(() =>
            {
                Red.Width = 800;
                Red.Height= 390;
                scrollViewer.Margin=new Thickness(0);
                Red.AnimChangeSizeBorder("Red is a cardinal with red feathers that cover most of his body, hence his name. In most of his game appearances, Red had a spherical body without showing any limbs at all, however, he has little stubby wings as seen in Egg's Day Out.");
                  backtoStart.Visibility= Visibility.Visible;
            }


            ));
            });
        }

        private void Stella_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            actionPage = "Stella";
            Chuck.AnimOpacityImage();
            Red.AnimOpacityImage();
            Bomb.AnimOpacityImage();
            Terence.AnimOpacityImage();
            Matilda.AnimOpacityImage();
            Task.Delay(1000).ContinueWith(_ =>
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    Red.Width = 0;
                    Chuck.Width = 0;
                    Stella.Width = 800;
                    Stella.Height = 390;
                    scrollViewer.Margin = new Thickness(0);
                    Stella.AnimChangeSizeBorder("Stella is a round, pink bird with three pink plume feathers that have darker pink tips on the top of her head. She has blue eyes with eyelashes and a short yellow beak. Her breast is light pink, and she has three black tail feathers");
                    backtoStart.Visibility = Visibility.Visible;
                }


                ));
            });
        }

        private void Chuck_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            actionPage = "Chuck";
            Red.AnimOpacityImage();
            Stella.AnimOpacityImage();
            Bomb.AnimOpacityImage();
            Terence.AnimOpacityImage();
            Matilda.AnimOpacityImage();
            Task.Delay(1000).ContinueWith(_ =>
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    Red.Width = 0;
                    Chuck.Width = 800;
                    Chuck.Height = 390;
                    scrollViewer.Margin = new Thickness(0);
                    Chuck.AnimChangeSizeBorder("The earliest known appearance of Chuck had him as a yellow-colored, triangular-shaped bird with two feathers on his head and two large eyes with black pupils. He was soon after redesigned to have smaller eyes with red eyebrows floating on them, four black, spiky feathers on his head, and three of said feathers on his back as his tail. He also has white feathers on his belly.");
                    backtoStart.Visibility = Visibility.Visible;
                }


                ));
            });
        }
    }
}
