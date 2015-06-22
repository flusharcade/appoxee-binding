namespace Appoxee
{
    using System;

    using UIKit;
    using Foundation;
    using ObjCRuntime;
    using CoreGraphics;

    // @interface AppoxeeMessage : NSObject
    [BaseType (typeof(NSObject))]
    [Protocol]
    interface AppoxeeMessage
    {
        // @property (retain, nonatomic) NSString * messageHeader;
        [Export ("messageHeader", ArgumentSemantic.Retain)]
        string MessageHeader { get; set; }

        // @property (retain, nonatomic) NSString * messageDescription;
        [Export ("messageDescription", ArgumentSemantic.Retain)]
        string MessageDescription { get; set; }

        // @property (retain, nonatomic) NSString * messageGroupID;
        [Export ("messageGroupID", ArgumentSemantic.Retain)]
        string MessageGroupID { get; set; }

        // @property (retain, nonatomic) NSString * messageType;
        [Export ("messageType", ArgumentSemantic.Retain)]
        string MessageType { get; set; }

        // @property (retain, nonatomic) NSDate * messagePostDate;
        [Export ("messagePostDate", ArgumentSemantic.Retain)]
        NSDate MessagePostDate { get; set; }

        // @property (retain, nonatomic) NSDate * messageUpdateDate;
        [Export ("messageUpdateDate", ArgumentSemantic.Retain)]
        NSDate MessageUpdateDate { get; set; }

        // @property (nonatomic) BOOL isMessageOpened;
        [Export ("isMessageOpened")]
        bool IsMessageOpened { get; set; }

        // -(NSString *)getMessageLinkAndReportToServer;
        [Export ("getMessageLinkAndReportToServer")]
        //[Verify (MethodToProperty)]
        string MessageLinkAndReportToServer { get; }
    }

    // @protocol AppoxeeDelegate <NSObject>
    [BaseType (typeof(NSObject))]
    [Protocol, Model]
    interface AppoxeeDelegate
    {
        // @required -(NSString *)AppoxeeDelegateAppSDKID;
        [Abstract]
        [Export ("AppoxeeDelegateAppSDKID")]
        //[Verify (MethodToProperty)]
        string AppoxeeDelegateAppSDKID { get; }

        // @required -(NSString *)AppoxeeDelegateAppSecret;
        [Abstract]
        [Export ("AppoxeeDelegateAppSecret")]
        //[Verify (MethodToProperty)]
        string AppoxeeDelegateAppSecret { get; }

        // @optional -(void)AppoxeeDelegateReciveAppoxeeClosed;
        [Export ("AppoxeeDelegateReciveAppoxeeClosed")]
        void AppoxeeDelegateReciveAppoxeeClosed ();

        // @optional -(void)AppoxeeDelegateReciveAppoxeeRequestFocus;
        [Export ("AppoxeeDelegateReciveAppoxeeRequestFocus")]
        void AppoxeeDelegateReciveAppoxeeRequestFocus ();

        // @optional -(void)AppoxeeNeedsToUpdateBadge:(int)badgeNum hasNumberChanged:(BOOL)hasNumberChanged;
        [Export ("AppoxeeNeedsToUpdateBadge:hasNumberChanged:")]
        void AppoxeeNeedsToUpdateBadge (int badgeNum, bool hasNumberChanged);

        // @optional -(BOOL)shouldAppoxeeRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation;
        [Export ("shouldAppoxeeRotateToInterfaceOrientation:")]
        bool ShouldAppoxeeRotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation);

        // @optional -(void)appDidOpenFromPushNotification:(NSDictionary *)userInfo;
        [Export ("appDidOpenFromPushNotification:")]
        void AppDidOpenFromPushNotification (NSDictionary userInfo);

        // @optional -(void)appNeedsToRegisterForPush;
        [Export ("appNeedsToRegisterForPush")]
        void AppNeedsToRegisterForPush ();
    }

    // @interface AppoxeeManager : NSObject
    [BaseType (typeof(NSObject))]
    [Protocol]
    interface AppoxeeManager
    {
        // +(id)sharedManager;
        [Static]
        [Export ("sharedManager")]
        //[Verify (MethodToProperty)]
        AppoxeeManager SharedManager { get; }

        // -(void)initManagerWithDelegate:(id<AppoxeeDelegate>)d andOptions:(NSDictionary *)options;
        [Export ("initManagerWithDelegate:andOptions:")]
        void InitManagerWithDelegate (AppoxeeDelegate d, [NullAllowed] NSDictionary options);

        // -(BOOL)managerParseLaunchOptions:(NSDictionary *)launchOptions;
        [Export ("managerParseLaunchOptions:")]
        bool ManagerParseLaunchOptions ([NullAllowed] NSDictionary launchOptions);

        // -(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)token;
        [Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
        void DidRegisterForRemoteNotificationsWithDeviceToken (NSData token);

        // -(BOOL)didReceiveRemoteNotification:(NSDictionary *)userInfo;
        [Export ("didReceiveRemoteNotification:")]
        bool DidReceiveRemoteNotification (NSDictionary userInfo);

        // -(void)show;
        [Export ("show")]
        void Show ();

        // -(BOOL)showMoreAppsViewController;
        [Export ("showMoreAppsViewController")]
        //[Verify (MethodToProperty)]
        //bool ShowMoreAppsViewController { get; }
        bool ShowMoreAppsViewController();

        // -(BOOL)showFeedbackViewController;
        [Export ("showFeedbackViewController")]
        //[Verify (MethodToProperty)]
        //bool ShowFeedbackViewController { get; }
        bool ShowFeedbackViewController();

        // -(void)showMoreAppsOnInbox:(BOOL)show;
        [Export ("showMoreAppsOnInbox:")]
        void ShowMoreAppsOnInbox (bool show);

        // -(void)showFeedbackOnInbox:(BOOL)show;
        [Export ("showFeedbackOnInbox:")]
        void ShowFeedbackOnInbox (bool show);

        // -(UIViewController *)getAppoxeeViewController;
        [Export ("getAppoxeeViewController")]
        //[Verify (MethodToProperty)]
        UIViewController AppoxeeViewController { get; }

        // -(void)recalculateUnreadMessagesBadge;
        [Export ("recalculateUnreadMessagesBadge")]
        void RecalculateUnreadMessagesBadge ();

        // -(int)calculateUnreadMessagesBadgeValue;
        [Export ("calculateUnreadMessagesBadgeValue")]
        //[Verify (MethodToProperty)]
        //int CalculateUnreadMessagesBadgeValue { get; }
        int CalculateUnreadMessagesBadgeValue();

        // -(void)statusBar:(BOOL)status :(UIViewController *)rootVC;
        [Export ("statusBar::")]
        void StatusBar (bool status, UIViewController rootVC);

        // -(BOOL)getUsingCustomInboxFlag;
        [Export ("getUsingCustomInboxFlag")]
        //[Verify (MethodToProperty)]
        bool UsingCustomInboxFlag { get; }

        // -(void)setUsingCustomInbox:(BOOL)isCustom;
        [Export ("setUsingCustomInbox:")]
        void SetUsingCustomInbox (bool isCustom);

        // -(void)showCustomInbox:(BOOL)show;
        [Export ("showCustomInbox:")]
        void ShowCustomInbox (bool show);

        // -(void)loadMessagesFromServer_V3;
        [Export ("loadMessagesFromServer_V3")]
        void LoadMessagesFromServer_V3 ();

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation;
        [Export ("addBadgeToView:badgeText:badgeLocation:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation);

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation shouldFlashBadge:(BOOL)shouldFlashBadge;
        [Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge);

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation shouldFlashBadge:(BOOL)shouldFlashBadge withFontSize:(float)fontSize;
        [Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge, float fontSize);

        // -(NSString *)getADID;
        [Export ("getADID")]
        //[Verify (MethodToProperty)]
        string ADID { get; }

        // -(NSArray *)getInboxMessages;
        [Export ("getInboxMessages")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] InboxMessages { get; }

        // -(void)openAppoxeeMessage:(AppoxeeMessage *)appoxeeMessage;
        [Export ("openAppoxeeMessage:")]
        void OpenAppoxeeMessage (AppoxeeMessage appoxeeMessage);

        // -(void)deleteAppoxeeMessage:(AppoxeeMessage *)appoxeeMessage;
        [Export ("deleteAppoxeeMessage:")]
        void DeleteAppoxeeMessage (AppoxeeMessage appoxeeMessage);

        // -(BOOL)addTagsToDevice:(NSArray *)tagsToAdd andRemove:(NSArray *)tagsToRemove;
        [Export ("addTagsToDevice:andRemove:")]
        //[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
        bool AddTagsToDevice (NSObject[] tagsToAdd, NSObject[] tagsToRemove);

        // -(BOOL)addTagsToDevice:(NSArray *)tags;
        [Export ("addTagsToDevice:")]
        //[Verify (StronglyTypedNSArray)]
        bool AddTagsToDevice (NSObject[] tags);

        // -(BOOL)removeTagsFromDevice:(NSArray *)tags;
        [Export ("removeTagsFromDevice:")]
        //[Verify (StronglyTypedNSArray)]
        bool RemoveTagsFromDevice (NSObject[] tags);

        // -(NSArray *)getDeviceTags;
        [Export ("getDeviceTags")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] DeviceTags { get; }

        // -(NSArray *)getTagList;
        [Export ("getTagList")]
        //[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] TagList { get; }

        // -(void)clearTagsCache;
        [Export ("clearTagsCache")]
        void ClearTagsCache ();

        // -(BOOL)setDeviceAlias:(NSString *)alias;
        [Export ("setDeviceAlias:")]
        bool SetDeviceAlias (string alias);

        // -(BOOL)removeDeviceAlias;
        [Export ("removeDeviceAlias")]
        //[Verify (MethodToProperty)]
        //bool RemoveDeviceAlias { get; }
        bool RemoveDeviceAlias();

        // -(NSString *)getDeviceAlias;
        [Export ("getDeviceAlias")]
        //[Verify (MethodToProperty)]
        string DeviceAlias { get; }

        // -(void)clearAliasCache;
        [Export ("clearAliasCache")]
        void ClearAliasCache ();

        // -(NSString *)getDeviceOsName;
        [Export ("getDeviceOsName")]
        //[Verify (MethodToProperty)]
        string DeviceOsName { get; }

        // -(NSString *)getDeviceOsNumber;
        [Export ("getDeviceOsNumber")]
        //[Verify (MethodToProperty)]
        string DeviceOsNumber { get; }

        // -(NSString *)getHardwareType;
        [Export ("getHardwareType")]
        //[Verify (MethodToProperty)]
        string HardwareType { get; }

        // -(NSString *)getDeviceCountry;
        [Export ("getDeviceCountry")]
        //[Verify (MethodToProperty)]
        string DeviceCountry { get; }

        // -(int)getDeviceActivations;
        [Export ("getDeviceActivations")]
        //[Verify (MethodToProperty)]
        int DeviceActivations { get; }

        // -(NSDecimalNumber *)getInAppPayment;
        [Export ("getInAppPayment")]
        //[Verify (MethodToProperty)]
        NSDecimalNumber InAppPayment { get; }

        // -(int)getNumProductsPurchased;
        [Export ("getNumProductsPurchased")]
        //[Verify (MethodToProperty)]
        int NumProductsPurchased { get; }

        // -(BOOL)increaseInAppPayment:(NSDecimalNumber *)payment andNumPurchased:(int)numPurchased;
        [Export ("increaseInAppPayment:andNumPurchased:")]
        bool IncreaseInAppPayment (NSDecimalNumber payment, int numPurchased);

        // -(BOOL)increaseNumProductPurchased:(NSDecimalNumber *)payment;
        [Export ("increaseNumProductPurchased:")]
        bool IncreaseNumProductPurchased (NSDecimalNumber payment);

        // -(BOOL)isPushEnabled;
        [Export ("isPushEnabled")]
        //[Verify (MethodToProperty)]
        bool IsPushEnabled { get; }

        // -(BOOL)isSoundEnabled;
        [Export ("isSoundEnabled")]
        //[Verify (MethodToProperty)]
        bool IsSoundEnabled { get; }

        // -(BOOL)isBadgeEnabled;
        [Export ("isBadgeEnabled")]
        //[Verify (MethodToProperty)]
        bool IsBadgeEnabled { get; }

        // -(void)setPushEnabled:(BOOL)enabled;
        [Export ("setPushEnabled:")]
        void SetPushEnabled (bool enabled);

        // -(void)setSoundEnabled:(BOOL)enabled;
        [Export ("setSoundEnabled:")]
        void SetSoundEnabled (bool enabled);

        // -(void)setBadgeEnabled:(BOOL)enabled;
        [Export ("setBadgeEnabled:")]
        void SetBadgeEnabled (bool enabled);

        // -(void)configureAppoxeeForLocale:(NSString *)theLocale;
        [Export ("configureAppoxeeForLocale:")]
        void ConfigureAppoxeeForLocale (string theLocale);

        // -(NSString *)getAttribute:(NSString *)param;
        [Export ("getAttribute:")]
        string GetAttribute (string param);

        // -(NSArray *)setAttribute:(NSString *)param;
        [Export ("setAttribute:")]
        //[Verify (StronglyTypedNSArray)]
        NSObject[] SetAttribute (string param);
    }

    //[Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const AppoxeeManagerModalParam;
        [Field ("AppoxeeManagerModalParam")]
        NSString AppoxeeManagerModalParam { get; }

        // extern NSString *const AppoxeeManagerViewHeightParam;
        [Field ("AppoxeeManagerViewHeightParam")]
        NSString AppoxeeManagerViewHeightParam { get; }

        // extern NSString *const AppoxeeManagerNewMailSoundFileName;
        [Field ("AppoxeeManagerNewMailSoundFileName")]
        NSString AppoxeeManagerNewMailSoundFileName { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam;
        [Field ("AppoxeeManagerViewAnimationTypeParam")]
        NSString AppoxeeManagerViewAnimationTypeParam { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam_PageCurl;
        [Field ("AppoxeeManagerViewAnimationTypeParam_PageCurl")]
        NSString AppoxeeManagerViewAnimationTypeParam_PageCurl { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam_VerticalMove;
        [Field ("AppoxeeManagerViewAnimationTypeParam_VerticalMove")]
        NSString AppoxeeManagerViewAnimationTypeParam_VerticalMove { get; }
    }
}
