using Android.App;
using Android.Widget;
using Android.OS;
using static Android.App.ActionBar;
using Android.Graphics;
using System;

namespace testapp
{
    [Activity(Label = "testapp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            this.Window.SetSoftInputMode(Android.Views.SoftInput.StateAlwaysHidden);

            for (int i = 0; i < 2; i++)                 // Mindestspielerzahl sind 2 Spieler
            {
                CreateEditText();
            }
            button1.Click += (sender, e) =>
            {
                CreateEditText();
            };
        }

        private void CreateEditText()
        {
            EditText ET = new EditText(this);
            LinearLayout.LayoutParams testParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            ET.Id = Resource.ID.edit_text_test;                             // ID wird aus ids.xml ausgelesen.
                                                                            //ET.Gravity = Android.Views.GravityFlags.CenterHorizontal;                   
            ET.SetTextColor(Color.DeepSkyBlue);
            testParams.SetMargins(20, 20, 20, 20);
            ET.SetPadding(20, 20, 20, 20);
            ET.SetTextSize(Android.Util.ComplexUnitType.Dip, 25);
            ET.SetText(Resource.String.app_name);  
            testParams.Gravity = Android.Views.GravityFlags.CenterHorizontal;
            ET.LayoutParameters = testParams;
            ET.SetMaxLines(1);
            //        ET.ShowSoftInputOnFocus = false;
            // ET.Focusable = false;
            //ET.FocusableInTouchMode = false;
            //this.getWindow().setSoftInputMode(WindowManager.LayoutParams.SOFT_INPUT_STATE_ALWAYS_HIDDEN);
            LinearLayout TestLayout = (LinearLayout)FindViewById(Resource.Id.LayoutEditText);

            TestLayout.AddView(ET);

        }
    }
}


















