using Cpp2IlInjected;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	public class LocalizationManagerConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4001110")]
		public const bool UseBinaryFolderMergeOptim = false;

		[Cpp2IlInjected.Token(Token = "0x4001111")]
		public const bool UseBinaryGenderOptim = true;

		[Cpp2IlInjected.Token(Token = "0x4001112")]
		public const bool DebugKeepJsonFileInPlayers = false;

		[Cpp2IlInjected.Token(Token = "0x4001113")]
		public const bool DebugKeepBinaryFileWithZip = false;

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xBB59B0", Offset = "0xBB43B0", VA = "0x180BB59B0")]
		public static bool IsUsingBinary(RuntimePlatform target)
		{
			return target != RuntimePlatform.Android;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		public static bool IsUsingBinaryArchive(RuntimePlatform target)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LocalizationManagerConfig()
		{
		}
	}
}
