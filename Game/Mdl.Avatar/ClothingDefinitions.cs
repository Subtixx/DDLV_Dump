using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A4F")]
	public static class ClothingDefinitions
	{
		[Cpp2IlInjected.Token(Token = "0x170006B5")]
		public static ClothingParameters Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6003015")]
			[Cpp2IlInjected.Address(RVA = "0xA85FA0", Offset = "0xA849A0", VA = "0x180A85FA0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003016")]
			[Cpp2IlInjected.Address(RVA = "0xA85FE0", Offset = "0xA849E0", VA = "0x180A85FE0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003017")]
		[Cpp2IlInjected.Address(RVA = "0xA85EE0", Offset = "0xA848E0", VA = "0x180A85EE0")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeClothing()
		{
			//Discarded unreachable code: IL_001d, IL_0023
			ClothingParameters[] array = Resources.LoadAll<ClothingParameters>("");
			if (array.Length != 0)
			{
				ClothingParameters clothingParameters = array[0];
			}
		}
	}
}
