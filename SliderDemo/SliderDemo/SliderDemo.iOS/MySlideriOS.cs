using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace SliderDemo.iOS
{
    public class MySlideriOS : UISlider
    {
        public MySlideriOS()
        {
            this.MinimumTrackTintColor = UIColor.FromRGB(0xE6, 0x00, 0x06);
            this.ThumbTintColor = UIColor.Red;
            this.MinimumTrackTintColor = UIColor.Orange;
            this.MaximumTrackTintColor = UIColor.Yellow;
        }

        public override CGRect TrackRectForBounds(CGRect forBounds)
        {
            CGRect rect = base.TrackRectForBounds(forBounds);
            return new CGRect(rect.X, rect.Y, rect.Width, 20);
        }
    }
}