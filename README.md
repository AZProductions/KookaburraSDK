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

## ⏱ Get Started
After downloading it from Nuget, add it to your project dependencies. Import it by typing `using Kookaburra.SDK;`.

## Copyright and License

This repository is under a [proprietary licence](https://github.com/AZProductions/Kookaburra/blob/main/LICENCE).

----

##### ***AZ Software is not responsible for any harm to your device(s).***
