using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomLabel.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(CustomLabel.CustomLabel),typeof(CustomLabelRedner))]
namespace CustomLabel.iOS
{
    public class CustomLabelRedner:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextAlignment = UITextAlignment.Justified;
            }
        }
    }
}