using SliderDemo;
using SliderDemo.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MySlider), typeof(MySliderRenderer))]
namespace SliderDemo.iOS
{
    class MySliderRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            SetNativeControl(new MySlideriOS());
            base.OnElementChanged(e);
        }
    }
}
