using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AngryBirdsApp.SmoothScroll
{
    public class SmoothScrollViewer:ScrollViewer
    {
        public double HorizontalScrollRatio
        {
            get { return (double)GetValue(HorizontalScrollRatioProperty); }
            set { SetValue(HorizontalScrollRatioProperty, value); }
        }
        public static readonly DependencyProperty HorizontalScrollRatioProperty=
            DependencyProperty.Register("HorizontalScrollRatio",typeof(double),typeof(SmoothScrollViewer),new PropertyMetadata(0.0,new PropertyChangedCallback(H_ScrollRatioChangedCallBack)));
            private static void H_ScrollRatioChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var scrollviewer = (ScrollViewer)(d);
            if(scrollviewer != null) 
            {
                scrollviewer.ScrollToHorizontalOffset((double)(e.NewValue)*scrollviewer.ScrollableWidth);
            }
        }
    }
}
