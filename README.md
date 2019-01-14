# ASF Case Insensitive Bot Names Plugin
Plugin for [ASF](https://github.com/JustArchiNET/ArchiSteamFarm/) that makes bot names case-insensitive, so you can use `BotName`, `botname`, and `BoTnAmE` to refer to your bot. Also works for regular expressions in bot names.
Make sure you don't have multiple bots with names that differ only by case (only applicable to case-sensitive file systems of course). If you have two files `BotName.json` and `botname.json` in your config folder - you are guaranteed to have troubles.
Works only with ASF 4.0+
To use:
- download .zip file from [latest release](https://github.com/Ryzhehvost/Case-Insensitive-ASF/releases/latest), in most cases you need `CaseInsensitiveASF.zip`, but if you use ASF-generic-netf.zip (you really need a strong reason to do that) download `CaseInsensitiveASF-netf.zip`.
- unpack downloaded .zip file to `plugins` folder inside your ASF folder.
- (re)start ASF, you should get a message indicating that plugin loaded successfully. 


# Плагин для ASF чтобы сделать имена ботов регистронезависимыми
Этот плагин для [ASF](https://github.com/JustArchiNET/ArchiSteamFarm/) позволяет сделать имена ботов регистронезависимыми, так что имена `BotName`, `botname`, и `BoTnAmE` будут указывать на одного бота. Работает также для регулярных выражений в именах ботов.
Убедитесь, что у вас нет нескольких ботов, имена которых отличаются только регистром (разумеется, это возможно тольков случае регистрозависимой файловой системы). Если у вас в папке config есть два файла `BotName.json` и `botname.json` - у вас гарантированно будут проблемы.
Работает только в ASF 4.0+
Для установки:
- скачайте файл .zip из [последнего релиза](https://github.com/Ryzhehvost/Case-Insensitive-ASF/releases/latest), в большинстве случаев вам нужен файл `CaseInsensitiveASF.zip`, не если вы по какой-то причине пользуетесь ASF-generic-netf.zip (а для этого нужны веские причины) - скачайте `CaseInsensitiveASF-netf.zip`.
- распакуйте скачанный файл .zip в папку `plugins` внутри вашей папки с ASF.
- (пере)запустите ASF, вы должны получить сообщение что плагин успешно загружен. 

