using Android.App;
using Android.Widget;
using Android.OS;

namespace Jason.Droid
{
	[Activity(Label = "Jason", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;
		private EditText _txtAccount;


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// iOS Xcode Custom Class
			// View - Controller Binding
			SetContentView(Resource.Layout.loginflow_loginview);

			// View's Element - Controller's UI Control Binding
			_txtAccount = FindViewById<EditText>(Resource.Id.loginflow_loginview_txtaccount);

			var txtPassword =FindViewById<EditText>(Resource.Id.loginflow_loginview_txtpassword);

			var btnLogin = FindViewById<Button>(Resource.Id.loginflow_loginview_btnlogin);
			btnLogin.Click += (sender, e) =>{ };

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button>(Resource.Id.myButton);

			//button.Click += delegate { button.Text = $"{count++} clicks!"; };
		}
	}
}

