using System;

using UIKit;

namespace Jason.iOS
{
	public partial class MyWebViewController : UIViewController
	{
		public MyWebViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			/*UIKeyboard.Notifications.ObserveWillChangeFrame((sender, e) =>
			{

				var beginRect = e.FrameBegin;
				var endRect = e.FrameEnd;

			//WriteLine($"ObserveWillChangeFrame endRect:{endRect.Height}");
			Console.WriteLine($"ObserveWillChangeFrame endRect:{endRect.Height}");




				InvokeOnMainThread(() =>
				{
					UIView.Animate(1, () =>
				{
							btnGoBottomConstraint.Constant = endRect.Height + 5;
						});
				});


				this.NavigationController.PopViewController
			});*/
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

