# How to prevent the popup from closing when navigating to another page in .NET MAUI Popup (SfPopup)?
This repository contains a sample on how to prevent the popup from closing when navigating to another page in .NET MAUI Popup (SfPopup)

**Supported platforms**

.NET Multi-platform App UI (.NET MAUI) apps can be written for the following platforms:
* Android 5.0 (API 21) or higher.
* iOS 11 or higher, using the latest release of Xcode.
* macOS 10.15 or higher, using Mac Catalyst.
* Windows 11 and Windows 10 version 1809 or higher, using Windows UI Library (WinUI) 3.

**Requirements to run the sample**
**Development environment**
* Visual Studio 2022 17.9.0 Preview 1.0.
* Visual Studio 2022 17.8.0.
* Visual Studio Code. (Refer to this [link](https://devblogs.microsoft.com/visualstudio/announcing-the-dotnet-maui-extension-for-visual-studio-code/))

**Supported .NET versions**
* .NET 9.0
* .NET 8.0

**How to run the sample**

Clone the sample and open it in Visual Studio 2022 preview.

Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.

Register your license key in the App.cs file as demonstrated in the following code.

 public App()
 {
 	//Register Syncfusion license
 	Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
 
 	InitializeComponent();
 
 	MainPage = new MainPage();
 }
 
Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.

Clean and build the application.

Run the application.

**License**

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
