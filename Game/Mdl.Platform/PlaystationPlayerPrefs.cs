using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002D1")]
	public class PlaystationPlayerPrefs : IPlayerPrefs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400158F")]
		public readonly string PlaystationPlayerPrefsSaveFilename = "ddv_playerprefs";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001590")]
		private IFileSystem persistantFS;

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Load(IFileSystem fs)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0xCB32D0", Offset = "0xCB1CD0", VA = "0x180CB32D0", Slot = "5")]
		public void Save()
		{
			int num = 0;
			PlayerPrefs.Save();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0xCB32E0", Offset = "0xCB1CE0", VA = "0x180CB32E0")]
		public PlaystationPlayerPrefs()
		{
			//IL_0014: Expected O, but got I4
			int num = 0;
			Load((IFileSystem)num);
		}
	}
}
