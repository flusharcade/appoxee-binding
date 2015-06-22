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

namespace Appoxee {
	[Protocol (Name = "AppoxeeManager", WrapperType = typeof (AppoxeeManagerWrapper))]
	public interface IAppoxeeManager : INativeObject, IDisposable
	{
	}
	
	public static partial class AppoxeeManager_Extensions {
		[CompilerGenerated]
		public static void InitManagerWithDelegate (this IAppoxeeManager This, AppoxeeDelegate d, NSDictionary options)
		{
			if (d == null)
				throw new ArgumentNullException ("d");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("initManagerWithDelegate:andOptions:"), d.Handle, options == null ? IntPtr.Zero : options.Handle);
		}
		
		[CompilerGenerated]
		public static bool ManagerParseLaunchOptions (this IAppoxeeManager This, NSDictionary launchOptions)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("managerParseLaunchOptions:"), launchOptions == null ? IntPtr.Zero : launchOptions.Handle);
		}
		
		[CompilerGenerated]
		public static void DidRegisterForRemoteNotificationsWithDeviceToken (this IAppoxeeManager This, NSData token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didRegisterForRemoteNotificationsWithDeviceToken:"), token.Handle);
		}
		
		[CompilerGenerated]
		public static bool DidReceiveRemoteNotification (this IAppoxeeManager This, NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didReceiveRemoteNotification:"), userInfo.Handle);
		}
		
		[CompilerGenerated]
		public static void Show (this IAppoxeeManager This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("show"));
		}
		
		[CompilerGenerated]
		public static bool ShowMoreAppsViewController (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showMoreAppsViewController"));
		}
		
		[CompilerGenerated]
		public static bool ShowFeedbackViewController (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showFeedbackViewController"));
		}
		
		[CompilerGenerated]
		public static void ShowMoreAppsOnInbox (this IAppoxeeManager This, bool show)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("showMoreAppsOnInbox:"), show);
		}
		
		[CompilerGenerated]
		public static void ShowFeedbackOnInbox (this IAppoxeeManager This, bool show)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("showFeedbackOnInbox:"), show);
		}
		
		[CompilerGenerated]
		public static void RecalculateUnreadMessagesBadge (this IAppoxeeManager This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("recalculateUnreadMessagesBadge"));
		}
		
		[CompilerGenerated]
		public static int CalculateUnreadMessagesBadgeValue (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("calculateUnreadMessagesBadgeValue"));
		}
		
		[CompilerGenerated]
		public static void StatusBar (this IAppoxeeManager This, bool status, global::UIKit.UIViewController rootVC)
		{
			if (rootVC == null)
				throw new ArgumentNullException ("rootVC");
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("statusBar::"), status, rootVC.Handle);
		}
		
		[CompilerGenerated]
		public static void SetUsingCustomInbox (this IAppoxeeManager This, bool isCustom)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setUsingCustomInbox:"), isCustom);
		}
		
		[CompilerGenerated]
		public static void ShowCustomInbox (this IAppoxeeManager This, bool show)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("showCustomInbox:"), show);
		}
		
		[CompilerGenerated]
		public static void LoadMessagesFromServer_V3 (this IAppoxeeManager This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("loadMessagesFromServer_V3"));
		}
		
		[CompilerGenerated]
		public static void AddBadgeToView (this IAppoxeeManager This, global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:"), badgeView.Handle, nsbadgeText, badgeLocation);
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[CompilerGenerated]
		public static void AddBadgeToView (this IAppoxeeManager This, global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_bool (This.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge);
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[CompilerGenerated]
		public static void AddBadgeToView (this IAppoxeeManager This, global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge, float fontSize)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_bool_float (This.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge, fontSize);
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[CompilerGenerated]
		public static void OpenAppoxeeMessage (this IAppoxeeManager This, AppoxeeMessage appoxeeMessage)
		{
			if (appoxeeMessage == null)
				throw new ArgumentNullException ("appoxeeMessage");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("openAppoxeeMessage:"), appoxeeMessage.Handle);
		}
		
		[CompilerGenerated]
		public static void DeleteAppoxeeMessage (this IAppoxeeManager This, AppoxeeMessage appoxeeMessage)
		{
			if (appoxeeMessage == null)
				throw new ArgumentNullException ("appoxeeMessage");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteAppoxeeMessage:"), appoxeeMessage.Handle);
		}
		
		[CompilerGenerated]
		public static bool AddTagsToDevice (this IAppoxeeManager This, NSObject[] tagsToAdd, NSObject[] tagsToRemove)
		{
			if (tagsToAdd == null)
				throw new ArgumentNullException ("tagsToAdd");
			if (tagsToRemove == null)
				throw new ArgumentNullException ("tagsToRemove");
			var nsa_tagsToAdd = NSArray.FromNSObjects (tagsToAdd);
			var nsa_tagsToRemove = NSArray.FromNSObjects (tagsToRemove);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("addTagsToDevice:andRemove:"), nsa_tagsToAdd.Handle, nsa_tagsToRemove.Handle);
			nsa_tagsToAdd.Dispose ();
			nsa_tagsToRemove.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool AddTagsToDevice (this IAppoxeeManager This, NSObject[] tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addTagsToDevice:"), nsa_tags.Handle);
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool RemoveTagsFromDevice (this IAppoxeeManager This, NSObject[] tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("removeTagsFromDevice:"), nsa_tags.Handle);
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void ClearTagsCache (this IAppoxeeManager This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearTagsCache"));
		}
		
		[CompilerGenerated]
		public static bool SetDeviceAlias (this IAppoxeeManager This, string alias)
		{
			if (alias == null)
				throw new ArgumentNullException ("alias");
			var nsalias = NSString.CreateNative (alias);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDeviceAlias:"), nsalias);
			NSString.ReleaseNative (nsalias);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool RemoveDeviceAlias (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("removeDeviceAlias"));
		}
		
		[CompilerGenerated]
		public static void ClearAliasCache (this IAppoxeeManager This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearAliasCache"));
		}
		
		[CompilerGenerated]
		public static bool IncreaseInAppPayment (this IAppoxeeManager This, NSDecimalNumber payment, int numPurchased)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("increaseInAppPayment:andNumPurchased:"), payment.Handle, numPurchased);
		}
		
		[CompilerGenerated]
		public static bool IncreaseNumProductPurchased (this IAppoxeeManager This, NSDecimalNumber payment)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("increaseNumProductPurchased:"), payment.Handle);
		}
		
		[CompilerGenerated]
		public static void SetPushEnabled (this IAppoxeeManager This, bool enabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setPushEnabled:"), enabled);
		}
		
		[CompilerGenerated]
		public static void SetSoundEnabled (this IAppoxeeManager This, bool enabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSoundEnabled:"), enabled);
		}
		
		[CompilerGenerated]
		public static void SetBadgeEnabled (this IAppoxeeManager This, bool enabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setBadgeEnabled:"), enabled);
		}
		
		[CompilerGenerated]
		public static void ConfigureAppoxeeForLocale (this IAppoxeeManager This, string theLocale)
		{
			if (theLocale == null)
				throw new ArgumentNullException ("theLocale");
			var nstheLocale = NSString.CreateNative (theLocale);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("configureAppoxeeForLocale:"), nstheLocale);
			NSString.ReleaseNative (nstheLocale);
			
		}
		
		[CompilerGenerated]
		public static string GetAttribute (this IAppoxeeManager This, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			string ret;
			ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getAttribute:"), nsparam));
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static NSObject[] SetAttribute (this IAppoxeeManager This, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAttribute:"), nsparam));
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIViewController GetAppoxeeViewController (this IAppoxeeManager This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAppoxeeViewController")));
		}
		
		[CompilerGenerated]
		public static bool GetUsingCustomInboxFlag (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("getUsingCustomInboxFlag"));
		}
		
		[CompilerGenerated]
		public static string GetADID (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getADID")));
		}
		
		[CompilerGenerated]
		public static NSObject[] GetInboxMessages (this IAppoxeeManager This)
		{
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInboxMessages")));
		}
		
		[CompilerGenerated]
		public static NSObject[] GetDeviceTags (this IAppoxeeManager This)
		{
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceTags")));
		}
		
		[CompilerGenerated]
		public static NSObject[] GetTagList (this IAppoxeeManager This)
		{
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getTagList")));
		}
		
		[CompilerGenerated]
		public static string GetDeviceAlias (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceAlias")));
		}
		
		[CompilerGenerated]
		public static string GetDeviceOsName (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceOsName")));
		}
		
		[CompilerGenerated]
		public static string GetDeviceOsNumber (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceOsNumber")));
		}
		
		[CompilerGenerated]
		public static string GetHardwareType (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getHardwareType")));
		}
		
		[CompilerGenerated]
		public static string GetDeviceCountry (this IAppoxeeManager This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceCountry")));
		}
		
		[CompilerGenerated]
		public static int GetDeviceActivations (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getDeviceActivations"));
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber GetInAppPayment (this IAppoxeeManager This)
		{
			return  Runtime.GetNSObject<NSDecimalNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInAppPayment")));
		}
		
		[CompilerGenerated]
		public static int GetNumProductsPurchased (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getNumProductsPurchased"));
		}
		
		[CompilerGenerated]
		public static bool GetIsPushEnabled (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPushEnabled"));
		}
		
		[CompilerGenerated]
		public static bool GetIsSoundEnabled (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSoundEnabled"));
		}
		
		[CompilerGenerated]
		public static bool GetIsBadgeEnabled (this IAppoxeeManager This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isBadgeEnabled"));
		}
		
	}
	
	internal sealed class AppoxeeManagerWrapper : BaseWrapper, IAppoxeeManager {
		public AppoxeeManagerWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public AppoxeeManagerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Appoxee {
	[Protocol]
	[Register("AppoxeeManager", true)]
	public unsafe partial class AppoxeeManager : NSObject, IAppoxeeManager {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AppoxeeManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AppoxeeManager () : base (NSObjectFlag.Empty)
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
		protected AppoxeeManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AppoxeeManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addBadgeToView:badgeText:badgeLocation:")]
		[CompilerGenerated]
		public virtual void AddBadgeToView (global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:"), badgeView.Handle, nsbadgeText, badgeLocation);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGPoint (this.SuperHandle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:"), badgeView.Handle, nsbadgeText, badgeLocation);
			}
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:")]
		[CompilerGenerated]
		public virtual void AddBadgeToView (global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_bool (this.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_bool (this.SuperHandle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge);
			}
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:")]
		[CompilerGenerated]
		public virtual void AddBadgeToView (global::UIKit.UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge, float fontSize)
		{
			if (badgeView == null)
				throw new ArgumentNullException ("badgeView");
			if (badgeText == null)
				throw new ArgumentNullException ("badgeText");
			var nsbadgeText = NSString.CreateNative (badgeText);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGPoint_bool_float (this.Handle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge, fontSize);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_bool_float (this.SuperHandle, Selector.GetHandle ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:"), badgeView.Handle, nsbadgeText, badgeLocation, shouldFlashBadge, fontSize);
			}
			NSString.ReleaseNative (nsbadgeText);
			
		}
		
		[Export ("addTagsToDevice:andRemove:")]
		[CompilerGenerated]
		public virtual bool AddTagsToDevice (NSObject[] tagsToAdd, NSObject[] tagsToRemove)
		{
			if (tagsToAdd == null)
				throw new ArgumentNullException ("tagsToAdd");
			if (tagsToRemove == null)
				throw new ArgumentNullException ("tagsToRemove");
			var nsa_tagsToAdd = NSArray.FromNSObjects (tagsToAdd);
			var nsa_tagsToRemove = NSArray.FromNSObjects (tagsToRemove);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addTagsToDevice:andRemove:"), nsa_tagsToAdd.Handle, nsa_tagsToRemove.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addTagsToDevice:andRemove:"), nsa_tagsToAdd.Handle, nsa_tagsToRemove.Handle);
			}
			nsa_tagsToAdd.Dispose ();
			nsa_tagsToRemove.Dispose ();
			
			return ret;
		}
		
		[Export ("addTagsToDevice:")]
		[CompilerGenerated]
		public virtual bool AddTagsToDevice (NSObject[] tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addTagsToDevice:"), nsa_tags.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addTagsToDevice:"), nsa_tags.Handle);
			}
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("calculateUnreadMessagesBadgeValue")]
		[CompilerGenerated]
		public virtual int CalculateUnreadMessagesBadgeValue ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("calculateUnreadMessagesBadgeValue"));
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("calculateUnreadMessagesBadgeValue"));
			}
		}
		
		[Export ("clearAliasCache")]
		[CompilerGenerated]
		public virtual void ClearAliasCache ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAliasCache"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearAliasCache"));
			}
		}
		
		[Export ("clearTagsCache")]
		[CompilerGenerated]
		public virtual void ClearTagsCache ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearTagsCache"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearTagsCache"));
			}
		}
		
		[Export ("configureAppoxeeForLocale:")]
		[CompilerGenerated]
		public virtual void ConfigureAppoxeeForLocale (string theLocale)
		{
			if (theLocale == null)
				throw new ArgumentNullException ("theLocale");
			var nstheLocale = NSString.CreateNative (theLocale);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("configureAppoxeeForLocale:"), nstheLocale);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("configureAppoxeeForLocale:"), nstheLocale);
			}
			NSString.ReleaseNative (nstheLocale);
			
		}
		
		[Export ("deleteAppoxeeMessage:")]
		[CompilerGenerated]
		public virtual void DeleteAppoxeeMessage (AppoxeeMessage appoxeeMessage)
		{
			if (appoxeeMessage == null)
				throw new ArgumentNullException ("appoxeeMessage");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteAppoxeeMessage:"), appoxeeMessage.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteAppoxeeMessage:"), appoxeeMessage.Handle);
			}
		}
		
		[Export ("didReceiveRemoteNotification:")]
		[CompilerGenerated]
		public virtual bool DidReceiveRemoteNotification (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didReceiveRemoteNotification:"), userInfo.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveRemoteNotification:"), userInfo.Handle);
			}
		}
		
		[Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
		[CompilerGenerated]
		public virtual void DidRegisterForRemoteNotificationsWithDeviceToken (NSData token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didRegisterForRemoteNotificationsWithDeviceToken:"), token.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didRegisterForRemoteNotificationsWithDeviceToken:"), token.Handle);
			}
		}
		
		[Export ("getAttribute:")]
		[CompilerGenerated]
		public virtual string GetAttribute (string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getAttribute:"), nsparam));
			} else {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getAttribute:"), nsparam));
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("increaseInAppPayment:andNumPurchased:")]
		[CompilerGenerated]
		public virtual bool IncreaseInAppPayment (NSDecimalNumber payment, int numPurchased)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("increaseInAppPayment:andNumPurchased:"), payment.Handle, numPurchased);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("increaseInAppPayment:andNumPurchased:"), payment.Handle, numPurchased);
			}
		}
		
		[Export ("increaseNumProductPurchased:")]
		[CompilerGenerated]
		public virtual bool IncreaseNumProductPurchased (NSDecimalNumber payment)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("increaseNumProductPurchased:"), payment.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("increaseNumProductPurchased:"), payment.Handle);
			}
		}
		
		[Export ("initManagerWithDelegate:andOptions:")]
		[CompilerGenerated]
		public virtual void InitManagerWithDelegate (AppoxeeDelegate d, NSDictionary options)
		{
			if (d == null)
				throw new ArgumentNullException ("d");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initManagerWithDelegate:andOptions:"), d.Handle, options == null ? IntPtr.Zero : options.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initManagerWithDelegate:andOptions:"), d.Handle, options == null ? IntPtr.Zero : options.Handle);
			}
		}
		
		[Export ("loadMessagesFromServer_V3")]
		[CompilerGenerated]
		public virtual void LoadMessagesFromServer_V3 ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadMessagesFromServer_V3"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadMessagesFromServer_V3"));
			}
		}
		
		[Export ("managerParseLaunchOptions:")]
		[CompilerGenerated]
		public virtual bool ManagerParseLaunchOptions (NSDictionary launchOptions)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("managerParseLaunchOptions:"), launchOptions == null ? IntPtr.Zero : launchOptions.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("managerParseLaunchOptions:"), launchOptions == null ? IntPtr.Zero : launchOptions.Handle);
			}
		}
		
		[Export ("openAppoxeeMessage:")]
		[CompilerGenerated]
		public virtual void OpenAppoxeeMessage (AppoxeeMessage appoxeeMessage)
		{
			if (appoxeeMessage == null)
				throw new ArgumentNullException ("appoxeeMessage");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("openAppoxeeMessage:"), appoxeeMessage.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("openAppoxeeMessage:"), appoxeeMessage.Handle);
			}
		}
		
		[Export ("recalculateUnreadMessagesBadge")]
		[CompilerGenerated]
		public virtual void RecalculateUnreadMessagesBadge ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("recalculateUnreadMessagesBadge"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recalculateUnreadMessagesBadge"));
			}
		}
		
		[Export ("removeDeviceAlias")]
		[CompilerGenerated]
		public virtual bool RemoveDeviceAlias ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("removeDeviceAlias"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeDeviceAlias"));
			}
		}
		
		[Export ("removeTagsFromDevice:")]
		[CompilerGenerated]
		public virtual bool RemoveTagsFromDevice (NSObject[] tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeTagsFromDevice:"), nsa_tags.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeTagsFromDevice:"), nsa_tags.Handle);
			}
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("setAttribute:")]
		[CompilerGenerated]
		public virtual NSObject[] SetAttribute (string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttribute:"), nsparam));
			} else {
				ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAttribute:"), nsparam));
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("setBadgeEnabled:")]
		[CompilerGenerated]
		public virtual void SetBadgeEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBadgeEnabled:"), enabled);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBadgeEnabled:"), enabled);
			}
		}
		
		[Export ("setDeviceAlias:")]
		[CompilerGenerated]
		public virtual bool SetDeviceAlias (string alias)
		{
			if (alias == null)
				throw new ArgumentNullException ("alias");
			var nsalias = NSString.CreateNative (alias);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDeviceAlias:"), nsalias);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDeviceAlias:"), nsalias);
			}
			NSString.ReleaseNative (nsalias);
			
			return ret;
		}
		
		[Export ("setPushEnabled:")]
		[CompilerGenerated]
		public virtual void SetPushEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPushEnabled:"), enabled);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPushEnabled:"), enabled);
			}
		}
		
		[Export ("setSoundEnabled:")]
		[CompilerGenerated]
		public virtual void SetSoundEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSoundEnabled:"), enabled);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSoundEnabled:"), enabled);
			}
		}
		
		[Export ("setUsingCustomInbox:")]
		[CompilerGenerated]
		public virtual void SetUsingCustomInbox (bool isCustom)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsingCustomInbox:"), isCustom);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUsingCustomInbox:"), isCustom);
			}
		}
		
		[Export ("show")]
		[CompilerGenerated]
		public virtual void Show ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("show"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("show"));
			}
		}
		
		[Export ("showCustomInbox:")]
		[CompilerGenerated]
		public virtual void ShowCustomInbox (bool show)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showCustomInbox:"), show);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showCustomInbox:"), show);
			}
		}
		
		[Export ("showFeedbackOnInbox:")]
		[CompilerGenerated]
		public virtual void ShowFeedbackOnInbox (bool show)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showFeedbackOnInbox:"), show);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showFeedbackOnInbox:"), show);
			}
		}
		
		[Export ("showFeedbackViewController")]
		[CompilerGenerated]
		public virtual bool ShowFeedbackViewController ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showFeedbackViewController"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showFeedbackViewController"));
			}
		}
		
		[Export ("showMoreAppsOnInbox:")]
		[CompilerGenerated]
		public virtual void ShowMoreAppsOnInbox (bool show)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("showMoreAppsOnInbox:"), show);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("showMoreAppsOnInbox:"), show);
			}
		}
		
		[Export ("showMoreAppsViewController")]
		[CompilerGenerated]
		public virtual bool ShowMoreAppsViewController ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showMoreAppsViewController"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showMoreAppsViewController"));
			}
		}
		
		[Export ("statusBar::")]
		[CompilerGenerated]
		public virtual void StatusBar (bool status, global::UIKit.UIViewController rootVC)
		{
			if (rootVC == null)
				throw new ArgumentNullException ("rootVC");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("statusBar::"), status, rootVC.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("statusBar::"), status, rootVC.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string ADID {
			[Export ("getADID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getADID")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getADID")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AppoxeeViewController_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController AppoxeeViewController {
			[Export ("getAppoxeeViewController")]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAppoxeeViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAppoxeeViewController")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AppoxeeViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DeviceActivations {
			[Export ("getDeviceActivations")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceActivations"));
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceActivations"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceAlias {
			[Export ("getDeviceAlias")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceAlias")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceAlias")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceCountry {
			[Export ("getDeviceCountry")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceCountry")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceCountry")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceOsName {
			[Export ("getDeviceOsName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceOsName")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceOsName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceOsNumber {
			[Export ("getDeviceOsNumber")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceOsNumber")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceOsNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DeviceTags_var;
		[CompilerGenerated]
		public virtual NSObject[] DeviceTags {
			[Export ("getDeviceTags")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceTags")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceTags")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DeviceTags_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string HardwareType {
			[Export ("getHardwareType")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getHardwareType")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHardwareType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_InAppPayment_var;
		[CompilerGenerated]
		public virtual NSDecimalNumber InAppPayment {
			[Export ("getInAppPayment")]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getInAppPayment")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getInAppPayment")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InAppPayment_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_InboxMessages_var;
		[CompilerGenerated]
		public virtual NSObject[] InboxMessages {
			[Export ("getInboxMessages")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getInboxMessages")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getInboxMessages")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InboxMessages_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsBadgeEnabled {
			[Export ("isBadgeEnabled")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBadgeEnabled"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBadgeEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPushEnabled {
			[Export ("isPushEnabled")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPushEnabled"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPushEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSoundEnabled {
			[Export ("isSoundEnabled")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSoundEnabled"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSoundEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int NumProductsPurchased {
			[Export ("getNumProductsPurchased")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getNumProductsPurchased"));
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getNumProductsPurchased"));
				}
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_SharedManager_var_static;
		[CompilerGenerated]
		public static AppoxeeManager SharedManager {
			[Export ("sharedManager")]
			get {
				AppoxeeManager ret;
				ret =  Runtime.GetNSObject<AppoxeeManager> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedManager")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedManager_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TagList_var;
		[CompilerGenerated]
		public virtual NSObject[] TagList {
			[Export ("getTagList")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTagList")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTagList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TagList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UsingCustomInboxFlag {
			[Export ("getUsingCustomInboxFlag")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getUsingCustomInboxFlag"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getUsingCustomInboxFlag"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AppoxeeViewController_var = null;
				__mt_DeviceTags_var = null;
				__mt_InAppPayment_var = null;
				__mt_InboxMessages_var = null;
				__mt_TagList_var = null;
			}
		}
	} /* class AppoxeeManager */
}
