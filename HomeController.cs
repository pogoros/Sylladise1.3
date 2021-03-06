using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;

namespace Sylladise1
{
	partial class HomeController : UIViewController
	{
		public HomeController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			// on page load we will show the current user's First Name from Parse
			var currentUser = ParseUser.CurrentUser;
			lblWelcome.Text = "Welcome, " + currentUser["FirstName"];
		}
	}
}
