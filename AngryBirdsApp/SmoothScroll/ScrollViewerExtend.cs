using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace AngryBirdsApp.SmoothScroll
{
    public static class ScrollViewerExtend
    {
        public static void SmoothScroll(this SmoothScrollViewer scrollViewer,double ScrollStepRatio,double ScrollPositionRatio,ScrollDirection direction)
        {
            if (double.IsNaN(ScrollStepRatio) || double.IsInfinity(ScrollPositionRatio))
                return;
            DoubleAnimation Animation=new DoubleAnimation();
            Animation.From = ScrollPositionRatio;
            if (ScrollDirection.Down == direction || ScrollDirection.Right == direction)
            {
                double To = ScrollPositionRatio + ScrollStepRatio;
                Animation.To = To > 0.95 ? 1.0 : To;
            }
            else if (ScrollDirection.Up == direction || ScrollDirection.Left == direction)
            {
                double To = ScrollPositionRatio - ScrollStepRatio;
                Animation.To = To < 0.05 ? 0.0 : To;
            }
            Animation.Duration = new Duration(TimeSpan.FromMilliseconds(500));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(Animation);
            Storyboard.SetTarget(Animation, scrollViewer);
            if (ScrollDirection.Right == direction || ScrollDirection.Left == direction)
                Storyboard.SetTargetProperty(Animation, new PropertyPath(SmoothScrollViewer.HorizontalScrollRatioProperty));
            storyboard.Begin();

        }
        
    }
    public enum ScrollDirection 
    {
        Up, Down, Left, Right,
    }
}
