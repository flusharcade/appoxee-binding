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

[Protocol (Name = "AppoxeeMessage", WrapperType = typeof (AppoxeeMessageWrapper))]
public interface IAppoxeeMessage : INativeObject, IDisposable
{
}

public static partial class AppoxeeMessage_Extensions {
	[CompilerGenerated]
	public static string GetMessageHeader (this IAppoxeeMessage This)
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messageHeader")));
	}
	
	[CompilerGenerated]
	public static void SetMessageHeader (this IAppoxeeMessage This, string value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessageHeader:"), nsvalue);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[CompilerGenerated]
	public static string GetMessageDescription (this IAppoxeeMessage This)
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messageDescription")));
	}
	
	[CompilerGenerated]
	public static void SetMessageDescription (this IAppoxeeMessage This, string value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessageDescription:"), nsvalue);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[CompilerGenerated]
	public static string GetMessageGroupID (this IAppoxeeMessage This)
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messageGroupID")));
	}
	
	[CompilerGenerated]
	public static void SetMessageGroupID (this IAppoxeeMessage This, string value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessageGroupID:"), nsvalue);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[CompilerGenerated]
	public static string GetMessageType (this IAppoxeeMessage This)
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messageType")));
	}
	
	[CompilerGenerated]
	public static void SetMessageType (this IAppoxeeMessage This, string value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsvalue = NSString.CreateNative (value);
		
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessageType:"), nsvalue);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[CompilerGenerated]
	public static NSDate GetMessagePostDate (this IAppoxeeMessage This)
	{
		return  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messagePostDate")));
	}
	
	[CompilerGenerated]
	public static void SetMessagePostDate (this IAppoxeeMessage This, NSDate value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessagePostDate:"), value.Handle);
	}
	
	[CompilerGenerated]
	public static NSDate GetMessageUpdateDate (this IAppoxeeMessage This)
	{
		return  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("messageUpdateDate")));
	}
	
	[CompilerGenerated]
	public static void SetMessageUpdateDate (this IAppoxeeMessage This, NSDate value)
	{
		if (value == null)
			throw new ArgumentNullException ("value");
		ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMessageUpdateDate:"), value.Handle);
	}
	
	[CompilerGenerated]
	public static bool GetIsMessageOpened (this IAppoxeeMessage This)
	{
		return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMessageOpened"));
	}
	
	[CompilerGenerated]
	public static void SetIsMessageOpened (this IAppoxeeMessage This, bool value)
	{
		ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsMessageOpened:"), value);
	}
	
	[CompilerGenerated]
	public static string GetMessageLinkAndReportToServer (this IAppoxeeMessage This)
	{
		return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getMessageLinkAndReportToServer")));
	}
	
}

internal sealed class AppoxeeMessageWrapper : BaseWrapper, IAppoxeeMessage {
	public AppoxeeMessageWrapper (IntPtr handle)
		: base (handle, false)
	{
	}
	
	[Preserve (Conditional = true)]
	public AppoxeeMessageWrapper (IntPtr handle, bool owns)
		: base (handle, owns)
	{
	}
	
}
[Protocol]
[Register("AppoxeeMessage", true)]
public unsafe partial class AppoxeeMessage : NSObject, IAppoxeeMessage {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("AppoxeeMessage");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AppoxeeMessage () : base (NSObjectFlag.Empty)
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
		protected AppoxeeMessage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AppoxeeMessage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[CompilerGenerated]
	public virtual bool IsMessageOpened {
		[Export ("isMessageOpened")]
		get {
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMessageOpened"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMessageOpened"));
			}
		}
		
		[Export ("setIsMessageOpened:")]
		set {
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsMessageOpened:"), value);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsMessageOpened:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual string MessageDescription {
		[Export ("messageDescription", ArgumentSemantic.Retain)]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageDescription")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageDescription")));
			}
		}
		
		[Export ("setMessageDescription:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageDescription:"), nsvalue);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageDescription:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual string MessageGroupID {
		[Export ("messageGroupID", ArgumentSemantic.Retain)]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageGroupID")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageGroupID")));
			}
		}
		
		[Export ("setMessageGroupID:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageGroupID:"), nsvalue);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageGroupID:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual string MessageHeader {
		[Export ("messageHeader", ArgumentSemantic.Retain)]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageHeader")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageHeader")));
			}
		}
		
		[Export ("setMessageHeader:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageHeader:"), nsvalue);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageHeader:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual string MessageLinkAndReportToServer {
		[Export ("getMessageLinkAndReportToServer")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMessageLinkAndReportToServer")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMessageLinkAndReportToServer")));
			}
		}
		
	}
	
	[CompilerGenerated]
	object __mt_MessagePostDate_var;
	[CompilerGenerated]
	public virtual NSDate MessagePostDate {
		[Export ("messagePostDate", ArgumentSemantic.Retain)]
		get {
			NSDate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messagePostDate")));
			} else {
				ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messagePostDate")));
			}
			if (!IsNewRefcountEnabled ())
				__mt_MessagePostDate_var = ret;
			return ret;
		}
		
		[Export ("setMessagePostDate:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessagePostDate:"), value.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessagePostDate:"), value.Handle);
			}
			if (!IsNewRefcountEnabled ())
				__mt_MessagePostDate_var = value;
		}
	}
	
	[CompilerGenerated]
	public virtual string MessageType {
		[Export ("messageType", ArgumentSemantic.Retain)]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageType")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageType")));
			}
		}
		
		[Export ("setMessageType:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageType:"), nsvalue);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageType:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	object __mt_MessageUpdateDate_var;
	[CompilerGenerated]
	public virtual NSDate MessageUpdateDate {
		[Export ("messageUpdateDate", ArgumentSemantic.Retain)]
		get {
			NSDate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageUpdateDate")));
			} else {
				ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageUpdateDate")));
			}
			if (!IsNewRefcountEnabled ())
				__mt_MessageUpdateDate_var = ret;
			return ret;
		}
		
		[Export ("setMessageUpdateDate:", ArgumentSemantic.Retain)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageUpdateDate:"), value.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageUpdateDate:"), value.Handle);
			}
			if (!IsNewRefcountEnabled ())
				__mt_MessageUpdateDate_var = value;
		}
	}
	
	[CompilerGenerated]
	protected override void Dispose (bool disposing)
	{
		base.Dispose (disposing);
		if (Handle == IntPtr.Zero) {
			__mt_MessagePostDate_var = null;
			__mt_MessageUpdateDate_var = null;
		}
	}
} /* class AppoxeeMessage */
