// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iPadClient
{
	[Register ("iPadClientViewController")]
	partial class iPadClientViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField ServiceAddressField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField NameField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton SubmitButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView OutputText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ServiceAddressField != null) {
				ServiceAddressField.Dispose ();
				ServiceAddressField = null;
			}

			if (NameField != null) {
				NameField.Dispose ();
				NameField = null;
			}

			if (SubmitButton != null) {
				SubmitButton.Dispose ();
				SubmitButton = null;
			}

			if (OutputText != null) {
				OutputText.Dispose ();
				OutputText = null;
			}
		}
	}
}
