﻿using System;
using System.Threading.Tasks;

using UIKit;

namespace Jason.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();



			Task.Run(() => {
				
				Task.Delay(2000);

				InvokeOnMainThread(() => {
					
					PerformSegue("moveToLoginViewSegue", this);
				
				});

			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
