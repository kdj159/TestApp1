﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TestApp1.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caller_android))]
namespace TestApp1.Droid
{
    class Caller_android : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("안드로이드에서 전화");
            return true;
        }
    }
}