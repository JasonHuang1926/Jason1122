﻿using System;

using Foundation;
using UIKit;

namespace Jason.iOS
{
	public partial class UserViewCell : UITableViewCell
	{
		protected UserViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void UpdateUI(User user)
		{ }
	}
}
