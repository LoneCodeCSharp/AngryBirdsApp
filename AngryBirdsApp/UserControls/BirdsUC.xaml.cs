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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AngryBirdsApp.UserControls
{
    /// <summary>
    /// Interaction logic for BirdsUC.xaml
    /// </summary>
    public partial class BirdsUC : UserControl
    {
        public BirdsUC()
        {
            InitializeComponent();
        }


        public void AnimScrollImage()
        { 
            DoubleAnimation sChangeSize= new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 150;
            sChangeSize.To = 220;
            img.BeginAnimation(WidthProperty, sChangeSize);
        }
        public void AnimScrollImageBack()
        {
            DoubleAnimation sChangeSize = new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 220;
            sChangeSize.To = 150;
            img.BeginAnimation(WidthProperty, sChangeSize);
        }
        public void AnimOpacityImage()
        {
            DoubleAnimation opacityanim = new DoubleAnimation();
            opacityanim.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            opacityanim.From = 1;
            opacityanim.To = 0;
            birdgrid.BeginAnimation(OpacityProperty, opacityanim);
        }
        public void AnimChangeSizeBorder(string desc)
        {
            cubeBird.VerticalAlignment= VerticalAlignment.Bottom;
            cubeBird.HorizontalAlignment=HorizontalAlignment.Right;
            DoubleAnimation sChangeSize = new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 220;
            sChangeSize.To = 600;
            cubeBird.BeginAnimation(WidthProperty, sChangeSize);

            DoubleAnimation sChangeSize1 = new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 200;
            sChangeSize.To = 380;
            cubeBird.BeginAnimation(HeightProperty, sChangeSize);
            Desript(desc);
        }

        public void Desript(string desc)
        {
            ThicknessAnimationUsingKeyFrames usingKeyFrames = new ThicknessAnimationUsingKeyFrames();
            KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5));
            Thickness thickness1 = new Thickness(0, 0, 0, 0);
            Thickness thickness2 = new Thickness(-120, 0, 0, 0);
            usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1,keyTime1));
            usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
            img.BeginAnimation(MarginProperty, usingKeyFrames);
            nameBirdtxt.VerticalAlignment=VerticalAlignment.Top;
            nameBirdtxt.HorizontalAlignment=HorizontalAlignment.Right;
            nameBirdtxt.Margin=new Thickness(0,20,50,0);
            nameBirdtxt.FontSize=45;
            DescriptText.Text=desc;
            DescriptText.HorizontalAlignment=HorizontalAlignment.Left;
            DescriptText.VerticalAlignment=VerticalAlignment.Top;
            DescriptText.Margin=new Thickness(270,90,0,0);
            DescriptText.FontSize = 18;
            DescriptText.Width=300;
            DescriptText.Height = 300;
            DescriptText.TextWrapping=TextWrapping.Wrap;
        }
        public void DefaultDes(string desc)
        {
            ThicknessAnimationUsingKeyFrames usingKeyFrames = new ThicknessAnimationUsingKeyFrames();
            KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5));
            Thickness thickness1 = new Thickness(-120, 0, 0, 0);
            Thickness thickness2 = new Thickness(0, 0, 0, 0);
            usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
            usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
            img.BeginAnimation(MarginProperty, usingKeyFrames);
            nameBirdtxt.VerticalAlignment = VerticalAlignment.Bottom;
            nameBirdtxt.HorizontalAlignment = HorizontalAlignment.Left;
            nameBirdtxt.Margin = new Thickness(20, 0, 0, 30);
            nameBirdtxt.FontSize = 30;
            DescriptText.Text = "";
            DescriptText.HorizontalAlignment = HorizontalAlignment.Left;
            DescriptText.VerticalAlignment = VerticalAlignment.Top;
            DescriptText.Margin = new Thickness(270, 90, 0, 0);
            DescriptText.FontSize = 18;
            DescriptText.Width = 300;
            DescriptText.Height = 300;
            DescriptText.TextWrapping = TextWrapping.Wrap;
        }

        public void AnimChangeSizeBorderDefault()
        {
            cubeBird.VerticalAlignment = VerticalAlignment.Bottom;
            cubeBird.HorizontalAlignment = HorizontalAlignment.Right;
            DoubleAnimation sChangeSize = new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 220;
            sChangeSize.To = 200;
            cubeBird.BeginAnimation(WidthProperty, sChangeSize);

            DoubleAnimation sChangeSize1 = new DoubleAnimation();
            sChangeSize.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            sChangeSize.From = 220;
            sChangeSize.To = 200;
            cubeBird.BeginAnimation(HeightProperty, sChangeSize);
           
        }
        public void DefaultAction()
        {
            AnimChangeSizeBorderDefault();
            DefaultDes("");
        }
        public void DefaultGrid()
        {
            cubeBird.VerticalAlignment = VerticalAlignment.Bottom;
            cubeBird.HorizontalAlignment = HorizontalAlignment.Right;
            cubeBird.Width = 200;
            cubeBird.Height = 200;
            img.VerticalAlignment= VerticalAlignment.Top;
            img.HorizontalAlignment= HorizontalAlignment.Center;
            img.Width = 220;
            img.Margin = new Thickness(0,0,0,0);
            DoubleAnimation opacitiAnim = new DoubleAnimation();
            opacitiAnim.Duration = new Duration(TimeSpan.Parse("00:00:01.0"));
            opacitiAnim.From = 0;
            opacitiAnim.To = 1;
            birdgrid.BeginAnimation(OpacityProperty, opacitiAnim);

        }





        public string HeightGrid
        {
            get { return (string)GetValue(HeightGridProperty);}
            set {SetValue(HeightGridProperty,value);}
        }
        public static readonly DependencyProperty HeightGridProperty = DependencyProperty.Register("HeightGrid", typeof(string), typeof(BirdsUC));
        public string WidthGrid
        {
            get { return (string)GetValue(WidthGridProperty); }
            set { SetValue(WidthGridProperty, value); }
        }
        public static readonly DependencyProperty WidthGridProperty = DependencyProperty.Register("WidthGrid", typeof(string), typeof(BirdsUC));
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(BirdsUC));
        public Color Color1
        {
            get { return (Color)GetValue(Color1Property); }
            set { SetValue(Color1Property, value); }
        }
        public static readonly DependencyProperty Color1Property = DependencyProperty.Register("Color1", typeof(Color), typeof(BirdsUC));
        public Color Color2
        {
            get { return (Color)GetValue(Color2Property); }
            set { SetValue(Color2Property, value); }
        }
        public static readonly DependencyProperty Color2Property = DependencyProperty.Register("Color2", typeof(Color), typeof(BirdsUC));
        public string BirdName
        {
            get { return (string)GetValue(BirdNameProperty); }
            set { SetValue(BirdNameProperty, value); }
        }
        public static readonly DependencyProperty BirdNameProperty = DependencyProperty.Register("BirdName", typeof(string), typeof(BirdsUC));
    }
}
