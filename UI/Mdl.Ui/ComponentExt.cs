using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003EA")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x60018E9")]
		[Cpp2IlInjected.Address(RVA = "0x16CC980", Offset = "0x16CB380", VA = "0x1816CC980")]
		public static bool TryGetComponent<T>(this Component self, out T value) where T : Component
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}
	}
}
