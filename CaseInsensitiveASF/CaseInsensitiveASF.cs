using System;
using System.Composition;
using ArchiSteamFarm.Core;
using ArchiSteamFarm.Plugins.Interfaces;

namespace Ryzhehvost.CaseInsensitiveASF {
	[Export(typeof(IPlugin))]
	public sealed class CaseInsensitiveASF : IBotsComparer {
		public string Name => nameof(CaseInsensitiveASF);
		public Version Version => typeof(CaseInsensitiveASF).Assembly.GetName().Version ?? new Version("0");

		public void OnLoaded() {
			ASF.ArchiLogger.LogGenericInfo("Case Insensitive ASF Plugin by Ryzhehvost, powered by ginger cats");
		}

		public StringComparer BotsComparer => StringComparer.OrdinalIgnoreCase;

	}
}
