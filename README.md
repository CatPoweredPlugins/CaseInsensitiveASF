# ASF Case Insensitive Bot Names Plugin
Plugin for [ASF](https://github.com/JustArchiNET/ArchiSteamFarm/) that makes bot names case-insensitive, so you can use `BotName`, `botname`, and `BoTnAmE` to refer to your bot. Also works for regular expressions in bot names.
Make sure you don't have multiple bots with names that differ only by case (only applicable to case-sensitive file systems of course). If you have two files `BotName.json` and `botname.json` in your config folder - you are guaranteed to have troubles.
Works only with ASF 4.0+
To use:
- download .zip file from [latest release](https://github.com/Rudokhvist/Case-Insensitive-ASF/releases/latest), in most cases you need `CaseInsensitiveASF.zip`, but if you use ASF-generic-netf.zip (you really need a strong reason to do that) download `CaseInsensitiveASF-netf.zip`.
- unpack downloaded .zip file to `plugins` folder inside your ASF folder.
- (re)start ASF, you should get a message indicating that plugin loaded successfully. 


