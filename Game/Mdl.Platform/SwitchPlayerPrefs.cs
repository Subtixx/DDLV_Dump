using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002E7")]
	public class SwitchPlayerPrefs : IPlayerPrefs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015CB")]
		public readonly string SwitchPlayerPrefsSaveFilename = "ddv_playerprefs";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015CC")]
		private IFileSystem persistantFS;

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Load(IFileSystem fs)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xCB32D0", Offset = "0xCB1CD0", VA = "0x180CB32D0", Slot = "5")]
		public void Save()
		{
			int num = 0;
			PlayerPrefs.Save();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x106AA30", Offset = "0x1069430", VA = "0x18106AA30")]
		public SwitchPlayerPrefs()
		{
			//IL_0014: Expected O, but got I4
			int num = 0;
			Load((IFileSystem)num);
		}
	}
}
