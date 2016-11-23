// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Jason.iOS
{
	[Register ("MyMenuViewController")]
	partial class MyMenuViewController
	{
		[Outlet]
		UIKit.UITableView userTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (userTable != null) {
				userTable.Dispose ();
				userTable = null;
			}
		}
	}
}
