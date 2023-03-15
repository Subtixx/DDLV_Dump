using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200076A")]
	public static class ItemDatabaseInitializer
	{
		[Cpp2IlInjected.Token(Token = "0x60020F3")]
		[Cpp2IlInjected.Address(RVA = "0x11BF780", Offset = "0x11BE180", VA = "0x1811BF780")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeItemDatabase()
		{
			InitializeItemDatabase(force: false);
		}

		[Cpp2IlInjected.Token(Token = "0x60020F4")]
		[Cpp2IlInjected.Address(RVA = "0x11BF790", Offset = "0x11BE190", VA = "0x1811BF790")]
		private static void InitializeItemDatabase(bool force)
		{
			if (force)
			{
				int num = 0;
				UnityFileSystem.InitFileSystem();
				int num2 = 0;
			}
		}
	}
}
