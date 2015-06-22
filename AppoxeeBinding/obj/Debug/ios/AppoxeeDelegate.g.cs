//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

[Protocol (Name = "AppoxeeDelegate", WrapperType = typeof (AppoxeeDelegateWrapper))]
public interface IAppoxeeDelegate : INativeObject, IDisposable
{
	[Preserve (Conditional = true)]
	string AppoxeeDelegateAppSDKID {
		[Export ("AppoxeeDelegateAppSDKID")]
		get;
	}
	
	[Preserve (Conditional = true)]
	string AppoxeeDelegateAppSecret {
		[Export ("AppoxeeDelegateAppSecret")]
		get;
	}
	
}

public static partial class AppoxeeDelegate_Extensions {
	[CompilerGenerated]
	public static void AppoxeeDelegateReciveAppoxeeClosed (this IAppoxeeDelegate This)
	{
		ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("AppoxeeDelegateReciveAppoxeeClosed"));
	}
	
	[CompilerGenerated]
	public static void AppoxeeDelegateReciveAppoxeeRequestFocus (this IAppoxeeDelegate This)
	{
		ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("AppoxeeDelegateReciveAppoxeeRequestFocus"));
	}
	
	[CompilerGenerated]
	public static void AppoxeeNeedsToUpdateBadge (this IAppoxeeDelegate This, int badgeNum, bool hasNumberChanged)
	{
		ApiDefinition.Messaging.void_objc_msgSend_int_bool (This.Handle, Selector.GetHandle ("AppoxeeNeedsToUpdateBadge:hasNumberChanged:"), badgeNum, hasNumberChanged);
	}
	
	[CompilerGenerated]
	public static bool ShouldAppoxeeRotateToInterfaceOrientation (this IAppoxeeDelegate This, global::UIKit.UIInterfaceOrientation toInterfaceOrientation)
	{
		if (IntPtr.Size == 8) {
			return ApiDefinition.Messaging.bool_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("shouldAppoxeeRotateToInterfaceOrientation:"), (Int64)toInterfaceOrientation);
		} else {
			return ApiDefinition.Messaging.bool_objc_msgSend_int (This.Handle, Selector.GetHandle ("shouldAppoxeeRotateToInterfaceOrientation:"), (int)toInterfaceOrientation);
		}
	}
	
	[CompilerGenerated]
	public static void AppDidOpenFromPushNotification (this IAppoxeeDelegate This, NSDictionary userInfo)
	{
		if (userInfo == null)
			throw new ArgumentNullException ("userInfo");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appDidOpenFromPushNotification:"), userInfo.Handle);
	}
	
	[CompilerGenerated]
	public static void AppNeedsToRegisterForPush (this IAppoxeeDelegate This)
	{
		ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("appNeedsToRegisterForPush"));
	}
	
}

internal sealed class AppoxeeDelegateWrapper : BaseWrapper, IAppoxeeDelegate {
	public AppoxeeDelegateWrapper (IntPtr handle)
		: base (handle, false)
	{
	}
	
	[Preserve (Conditional = true)]
	public AppoxeeDelegateWrapper (IntPtr handle, bool owns)
		: base (handle, owns)
	{
	}
	
	[CompilerGenerated]
	public string AppoxeeDelegateAppSDKID {
		[Export ("AppoxeeDelegateAppSDKID")]
		get {
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("AppoxeeDelegateAppSDKID")));
		}
		
	}
	
	[CompilerGenerated]
	public string AppoxeeDelegateAppSecret {
		[Export ("AppoxeeDelegateAppSecret")]
		get {
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("AppoxeeDelegateAppSecret")));
		}
		
	}
	
}
[Protocol]
[Register("AppoxeeDelegate", false)]
[Model]
public unsafe abstract partial class AppoxeeDelegate : NSObject, IAppoxeeDelegate {
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AppoxeeDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AppoxeeDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AppoxeeDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("appDidOpenFromPushNotification:")]
	[CompilerGenerated]
	public virtual void AppDidOpenFromPushNotification (NSDictionary userInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[Export ("appNeedsToRegisterForPush")]
	[CompilerGenerated]
	public virtual void AppNeedsToRegisterForPush ()
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[Export ("AppoxeeDelegateReciveAppoxeeClosed")]
	[CompilerGenerated]
	public virtual void AppoxeeDelegateReciveAppoxeeClosed ()
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[Export ("AppoxeeDelegateReciveAppoxeeRequestFocus")]
	[CompilerGenerated]
	public virtual void AppoxeeDelegateReciveAppoxeeRequestFocus ()
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[Export ("AppoxeeNeedsToUpdateBadge:hasNumberChanged:")]
	[CompilerGenerated]
	public virtual void AppoxeeNeedsToUpdateBadge (int badgeNum, bool hasNumberChanged)
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[Export ("shouldAppoxeeRotateToInterfaceOrientation:")]
	[CompilerGenerated]
	public virtual bool ShouldAppoxeeRotateToInterfaceOrientation (global::UIKit.UIInterfaceOrientation toInterfaceOrientation)
	{
		throw new You_Should_Not_Call_base_In_This_Method ();
	}
	
	[CompilerGenerated]
	public abstract string AppoxeeDelegateAppSDKID {
		[Export ("AppoxeeDelegateAppSDKID")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract string AppoxeeDelegateAppSecret {
		[Export ("AppoxeeDelegateAppSecret")]
		get; 
	}
	
} /* class AppoxeeDelegate */
