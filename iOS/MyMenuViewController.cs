using System;
using System.Collections.Generic;

using UIKit;

namespace Jason.iOS
{
	public partial class MyMenuViewController : UIViewController
	{
		public MyMenuViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			//UserTableSource users = new UserTableSource(new List<User>() { new User() {  }  });
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public class UserTableSource : UITableViewSource
		{
			const string UserViewCellIdentifier = @"UserViewCell";

			private List<User> Users { get; set; }

			public UserTableSource(IEnumerable<User> users)
			{
				Users = new List<User>();
				Users.AddRange(users);
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return Users.Count;
			}

			public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				User myClass = Users[indexPath.Row];
				UserViewCell cell = tableView.DequeueReusableCell(UserViewCellIdentifier) as UserViewCell;

				cell.UpdateUI(myClass);

				return cell;

			}

			public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				tableView.DeselectRow(indexPath, true);

				User user = Users[indexPath.Row];

				EventHandler<UserSelectedEventArgs> handle = UserSelected;

				if (null != handle)
				{
					var args = new UserSelectedEventArgs { SelectedUser = user };

					handle(this, args);
				}

			}

			public event EventHandler<UserSelectedEventArgs> UserSelected;

		}

			public class UserSelectedEventArgs : EventArgs
			{

				public User SelectedUser { get; set; }

			}
		}
	}

