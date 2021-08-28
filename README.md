![Logo](https://raw.githubusercontent.com/AZProductions/Kookaburra/main/.github/icons/cover_art.png) **KookaburraSDK**
=======
###### ***SDK Toolkit for the Kookaburra Programming Language.***

----

[![Nuget Badge](https://img.shields.io/nuget/v/Kookaburra.SDK)](https://www.nuget.org/packages/Kookaburra.SDK)
[![Nuget Badge 2](https://img.shields.io/nuget/dt/Kookaburra.SDK)](https://www.nuget.org/stats/packages/Kookaburra.SDK?groupby=Version)
[![GitHub Stars](https://img.shields.io/github/stars/AZProductions/KookaburraSDK)](https://github.com/AZProductions/KookaburraSDK/stargazers)
----

## 📚 Description
Kookaburra.SDK is the official Software Development Kit for [Kookaburra](https://github.com/AZProductions/Kookaburra). The SDK includes usefull features like Alerts, Markup formatting and more. Get Started by Downloading it via [Nuget](https://www.nuget.org/packages/Kookaburra.SDK). [Read more..](https://github.com/AZProductions/KookaburraSDK/blob/main/README.md#-get-started)

###### **Remember, Kookaburra.SDK is still in Pre-Release. Features may vary in the final release.**

## 💡 Features
- Quick Markup formatting.
```c# 
Console.WriteLine(Markup.RemoveFirstChar("hhello")); //Prints 'hello'.
```
- Easy to use Alerts.
```c#
Alert.Display("This is an alert!", 4); //Prints '[Warning] This is an alert!'.
```
- Extensive Debugging features.
```c#
Debug db = new Debug(@"C:\....\file.exe", True);
db.Start();
db.Stop();
```
- Advanced Environment functions.
```C#
Console.WriteLine(Env.IsCurrentProcessAdmin()); //Returns true if the user is admin. (Using Windows API)
```
- Support for native windows API.
```c#
KeyInput.Send(ConsoleKey.A);
```

## ⏱ Get Started
After downloading it from Nuget, add it to your project dependencies. Import it by typing `using Kookaburra.SDK;`.

## ⚡ Tips
1. **When using the SDK, some libraries use the same namespaces which can cause confusion or even break your program.** You can import the library with a custom name like SDK by typing this: **`using SDK = Kookaburra.SDK;`**.

## 🧾List
### Markup Lib.
| Example | Name | Description |
| ----- | ----- | ----- |
| `Console.WriteLine(Markup.RemoveFirstChar("hhello"));` | **Markup.RemoveFirstChar** | Removes the first character from string and returns it. |
| `Console.WriteLine(Markup.RemoveLastChar("helloo");`| **Markup.RemoveLastChar** | Removes the last character from string and returns it.
| `Console.WriteLine(Markup.StartsWithUpper("Example").ToString());` | **Markup.StartsWithUpper** | Returns True if the string start with a uppercase letter. |
| `Console.WriteLine(Markup.StartsWithLower("example").ToString());` | **Markup.StartsWithLower** | Returns True if the string start with a lowercase letter. |
| `Console.WriteLine(Markup.ToLower("HELLO"));` | **Markup.ToLower** | Returns a lowercase version of the string. |
| `Console.WriteLine(Markup.ToUpper("hello"));` | **Markup.ToUpper** | Returns an uppercase version of the string. |
| `Console.WriteLine(Markup.IsInArray(Array, Value).ToString());` | **Markup.IsInArray** | Returns True if the selected string is in the array. |
| `Console.WriteLine(Markup.IsInIntArray(Array, Value).ToString());` | **Markup.IsInIntArray** | Returns True if the selected int is in the array. |
| `Console.WriteLine(Markup.DeleteChar('E', "Example"));` | **Markup.DeleteChar** | Deletes specified character from the string and returns it. |
| `Console.WriteLine(Markup.DeleteString("Kooka", "Kookaburra"));` | **Markup.DeleteString** | Deletes specified charaters (string) from the string and returns it. |
| `Markup.SetForegroundColor("Red");` | **Markup.SetForegroundColor** | Sets the foreground color to the specified string. |
| `Markup.SetBackgroundColor("Blue");` | **Markup.SetBackgroundColor** | Sets the background color to the specified string. |
| `Markup.SetForeground(ConsoleColor.Red);` | **Markup.SetForeground** | Sets the foreground color to the specified ConsoleColor. |
| `Markup.SetBackground(ConsoleColor.Red);` | **Markup.SetBackground** | Sets the background color to the specified ConsoleColor. |
| `Markup.WhiteSpace();` | **Markup.WhiteSpace** | Creates a blank line. |
| `Markup.WhiteSpaceANSI();` | **Markup.WhiteSpaceANSI** | Creates a blank line using ANSI charaters. '\x0A' |
| `Markup.Reset();` | **Markup.Reset** | Clears the terminal window and resets the colors. |
| `Markup.Clear();` | **Markup.Clear** | Clears the terminal window using ANCI characters. |
| `Console.WriteLine("Top = " + Markup.GetPos().Item1 + " Left = " Markup.GetPos().Item2);` | **Markup.GetPos** | Returns the coorinates of the console cursor. |
| `Markup.SetPos(1,2);` | **Markup.SetPos** | Sets the coorinates of the console cursor. |
|`Console.WriteLine(Markup.SplitAndRemove("Hello World !", " World ")[0].ToString());`| **Markup.SplitAndRemove** | Splits the string and removes the part where it got splitted. |

### Env Lib.
| Example | Name | Description |
| ----- | ----- | ----- |
| `Console.WriteLine(Env.Is64x);` | **Env.Is64x** | If True, the running program is x64 based. |
| `Console.WriteLine(Env.Is64xProcess);` | **Env.Is64xProcess** | If True, the system is x64 based. |
| `Console.WriteLine(Env.GetOSPlatform());` | **Env.GetOSPlatform** | Returns the current OS Platform.|
| `Console.WriteLine(Env.MachineName);` | **Env.MachineName** | Returns the current machinename.|
| `Console.WriteLine(Env.UserName);` | **Env.UserName* | Returns the current username. |
| `Console.WriteLine(Env.CurrentDirectory);` | **Env.CurrentDirectory** | Returns the current working directory.|
| `Console.WriteLine(Env.IsCurrentProcessAdmin());` | **Env.IsCurrentProcessAdmin** | Returns the current program is running in administrator mode.|
| `Console.WriteLine(Env.GetManufacturerName());` | **Env.GetManufacturerName** | Returns the manufacturer name of the current computer.|
| `Console.WriteLine(Env.GetCPUStatus());` | **Env.GetCPUStatus** | Returns the CPU status. (using Win32_Processor API) |
| `Console.WriteLine(Env.GetCPUCaption());` | **Env.GetCPUCaption** | Returns the CPU caption. (using Win32_Processor API) |
| `Console.WriteLine(Env.GetGPUCaption());` | **Env.GetGPUCaption** | Returns the GPU caption. (using Win32_VideoController API) |
| `Console.WriteLine(Env.GetLocalDriveCaption());` | **Env.GetLocalDriveCaption** | Returns the local drive caption. (using Win32_VideoController API) |
| `Console.WriteLine(Env.GetWin32Info("Win32_LogicalDisk", "Caption"));` | **Env.GetWin32Info** | Returns the requested data from the Win32 API. |
| `Console.WriteLine(Env.GetOSType());` | **Env.GetOSType** | Returns the current Operating System. (Windows, Linux, MacOS, FreeBSD) |
| `Console.WriteLine(Env.GetScreenBrightness());` | **Env.GetScreenBrightness** | Returns the current Screen Brightness. (using WmiMonitorBrightness API) |
| `Env.SetScreenBrightness(50);` | **Env.SetScreenBrightness** | Sets the current Screen Brightness. (using WmiMonitorBrightness API) [Max: 100, Min:1] |
| `Env.IncreaseVolume();` | **Env.IncreaseVolume** | Increases the users volume. (using user32.dll API) |
| `Env.DecreaseVolume();` | **Env.DecreaseVolume** | Decreases the users volume. (using user32.dll API) |

### WinAPI Lib.
| Example | Name | Description |
| ----- | ----- | ----- |
|`Console.WriteLine(WinAPI.Win32_Battery("TimeToFullCharge"));`| **WinAPI.Win32_Battery** | Returns the specified value in the Win32_VideoController API. |
|`Console.WriteLine(WinAPI.Win32_VideoController("Caption"));`| **WinAPI.Win32_VideoController** | Returns the specified value in the Win32_VideoController API. |
|`Console.WriteLine(WinAPI.Win32_Processor("Caption"));`| **WinAPI.Win32_Processor** | Returns the specified value in the Win32_Processor API. |

### Networking Lib.
| Example | Name | Description |
| ----- | ----- | ----- |
| `Console.WriteLine(Networking.HasInternet.ToString())` | **Networking.HasInternet** | If True, the current PC has an internet connection. |
| `Console.WriteLine(Networking.GetLocalIP())` | **Networking.GetLocalIP** | Returns the local IP of the current system. |
| `Console.WriteLine(Networking.GetPublicIP())` | **Networking.GetPublicIP** | Returns the public IP of the current system using the 'checkip.dydns.org' API. |
| `Networking.Download(location);` | **Networking.Download** | Downloads the mentioned file to the mentioned address, using the System.Net.DownloadFile API. |
| `Networking.DownloadAsync(location);` | **Networking.DownloadAsync** | Downloads the mentioned file to the mentioned address asynchronous, using the System.Net.DownloadFileAsync API. |
| `Console.WriteLine(Networking.APIRequest(location));` | **Networking.APIRequest** | Sends a HTTP web request to the specified server and returns the raw html. |

### BatteryInformation Lib.
| Example | Name | Description |
| ----- | ----- | ----- |
| `BatteryInformation bi = new BatteryInformation();` | **BatteryInformation** | BatteryInformation Object for the Kookaburra SDK. |
| `Console.WriteLine(bi.ListAPI());` | **BatteryInformation.ListAPI** | Returns the Battery status. (using Win32_Battery API) |
| `Console.WriteLine(bi.GetStatus());` | **BatteryInformation.GetStatus** | Returns the requested data from the Win32 API. |
| `Console.WriteLine(bi.TimeToFullCharge());` | **BatteryInformation.TimeToFullCharge** | Returns the time until the battery is fully charged. (using Win32_Battery API) |
| `Console.WriteLine(bi.GetBatteryCaption());` | **BatteryInformation.GetBatteryCaption** | Returns the Battery caption. (using Win32_Battery API) |
| `Console.WriteLine(bi.IsPowerManagementSupported());` | **BatteryInformation.IsPowerManagementSupported** | Returns True if the battery is PowerManagementSupported. (using Win32_Battery API) |

## Copyright and License

This repository is under a [proprietary licence](https://github.com/AZProductions/Kookaburra/blob/main/LICENCE).

----

##### ***AZ Software is not responsible for any harm to your device(s).***
