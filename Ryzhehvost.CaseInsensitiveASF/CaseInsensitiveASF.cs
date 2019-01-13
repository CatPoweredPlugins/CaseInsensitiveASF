using System;
using System.Composition;
using ArchiSteamFarm;
using ArchiSteamFarm.Plugins;

namespace Ryzhehvost.CaseInsensitiveASF {
	[Export(typeof(IPlugin))]
	public sealed class CaseInsensitiveASF : IBotsComparer {
		public string Name => nameof(CaseInsensitiveASF);
		public Version Version => typeof(CaseInsensitiveASF).Assembly.GetName().Version;

		public void OnLoaded() {
			ASF.ArchiLogger.LogGenericInfo("Case Insensitive ASF Plugin by Ryzhehvost, powered by ginger cats");
		}

		public StringComparer BotsComparer => StringComparer.InvariantCultureIgnoreCase;

	}
}
