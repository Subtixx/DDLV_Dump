using Cpp2IlInjected;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200071A")]
	public static class AvatarRulesInitializer
	{
		[Cpp2IlInjected.Token(Token = "0x6001F85")]
		[Cpp2IlInjected.Address(RVA = "0x151F8B0", Offset = "0x151E2B0", VA = "0x18151F8B0")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeAvatarRules()
		{
			int num = 0;
			UnityFileSystem.InitFileSystem();
			int num2 = 0;
			AvatarRules.CreateInstance();
		}
	}
}
