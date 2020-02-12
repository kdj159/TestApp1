using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TestApp1.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caller_ios))]
namespace TestApp1.iOS
{
    class Caller_ios : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("IOS에서 전화");
            return true;
        }
    }
}