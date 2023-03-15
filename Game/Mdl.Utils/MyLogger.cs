using Cpp2IlInjected;
using Gameloft.FileSystem;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007D0")]
	internal class MyLogger : Gameloft.FileSystem.ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60022B9")]
		[Cpp2IlInjected.Address(RVA = "0xF00830", Offset = "0xEFF230", VA = "0x180F00830", Slot = "7")]
		public void Error(string msg)
		{
			UnityEngine.Debug.LogError(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60022BA")]
		[Cpp2IlInjected.Address(RVA = "0xF008F0", Offset = "0xEFF2F0", VA = "0x180F008F0", Slot = "6")]
		public void Warning(string msg)
		{
			UnityEngine.Debug.LogWarning(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60022BB")]
		[Cpp2IlInjected.Address(RVA = "0xF00890", Offset = "0xEFF290", VA = "0x180F00890", Slot = "5")]
		public void Info(string msg)
		{
			UnityEngine.Debug.Log(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60022BC")]
		[Cpp2IlInjected.Address(RVA = "0xF007D0", Offset = "0xEFF1D0", VA = "0x180F007D0", Slot = "4")]
		public void Debug(string msg)
		{
			UnityEngine.Debug.Log(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60022BD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MyLogger()
		{
		}
	}
}
