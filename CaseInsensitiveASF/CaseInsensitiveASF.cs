using System;
using System.Composition;
using System.Threading.Tasks;
using ArchiSteamFarm.Core;
using ArchiSteamFarm.Plugins.Interfaces;

namespace Rudokhvist.CaseInsensitiveASF {
	[Export(typeof(IPlugin))]
	public sealed class CaseInsensitiveASF : IBotsComparer {
		public string Name => nameof(CaseInsensitiveASF);
		public Version Version => typeof(CaseInsensitiveASF).Assembly.GetName().Version ?? new Version("0.0.0.0");

		public Task OnLoaded() {
			ASF.ArchiLogger.LogGenericInfo("Case Insensitive ASF Plugin by Rudokhvist, powered by ginger cats");
			return Task.CompletedTask;
		}

		public StringComparer BotsComparer => StringComparer.OrdinalIgnoreCase;

	}
}
