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

## ⏱ Get Started
After downloading it from Nuget, add it to your project dependencies. Import it by typing `using Kookaburra.SDK;`.

## 🧾List
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

## Copyright and License

This repository is under a [proprietary licence](https://github.com/AZProductions/Kookaburra/blob/main/LICENCE).

----

##### ***AZ Software is not responsible for any harm to your device(s).***
