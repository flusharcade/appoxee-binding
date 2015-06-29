using System;
using ObjCRuntime;

[assembly: LinkWith ("libAppoxee_ios_32bit_64bit_sdk_v3.2.4.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator64, Frameworks="QuartzCore AudioToolbox CoreGraphics Foundation UIKit", SmartLink = true, ForceLoad = true)]
