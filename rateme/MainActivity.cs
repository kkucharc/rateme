using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace rateme
{
	[Activity (Label = "rateme", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
	{
		int count = 1;

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            List<string> items = new List<string>();
            for (int i = 1; i < 21; i++)
            {
                items.Add("item " + i);
            }
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
            listView.Adapter = adapter;

            Button button = FindViewById<Button> (Resource.Id.circle);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


