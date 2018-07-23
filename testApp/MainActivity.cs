using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Java.Interop;

namespace testApp
{
    [Activity(Label = "testApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        TextView textView1;
        int count;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton):
            //button.Click += delegate { button.Text = $"{count++} clicks!"; };
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            FindViewById<Button>(Resource.Id.myButton).Click += (o, e) =>
                textView1.Text = (++count).ToString();
            FindViewById<Button>(Resource.Id.button1).Click += (o, e) =>
            {
                Toast.MakeText(this, "Hello,Xamarin.Android", ToastLength.Long).Show();
                textView1.Text = (--count).ToString();
            };
            //FindViewById<Button>(Resource.Id.button1) += (o, e) =>
            //    textView1.Text = (--count).ToString();
            FindViewById<Button>(Resource.Id.button2).Click += (o, e) =>
            {
                var intent = new Intent(this, typeof(SecondActivity));
                StartActivity(intent);
            };
               
        }

    }
}

