using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000770")]
	internal class LabelComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AD9")]
		private readonly HashSet<string> labels = (HashSet<string>)(object)new HashSet<T>();

		[Cpp2IlInjected.Token(Token = "0x6002102")]
		[Cpp2IlInjected.Address(RVA = "0x11C54A0", Offset = "0x11C3EA0", VA = "0x1811C54A0")]
		public bool AddLabel(string label)
		{
			//Discarded unreachable code: IL_000d
			return ((HashSet<T>)(object)labels).Add((T)label);
		}

		[Cpp2IlInjected.Token(Token = "0x6002103")]
		[Cpp2IlInjected.Address(RVA = "0x11C5500", Offset = "0x11C3F00", VA = "0x1811C5500")]
		public bool HasLabel(string label)
		{
			//Discarded unreachable code: IL_000d
			return ((HashSet<T>)(object)labels).Contains((T)label);
		}

		[Cpp2IlInjected.Token(Token = "0x6002104")]
		[Cpp2IlInjected.Address(RVA = "0x11C5560", Offset = "0x11C3F60", VA = "0x1811C5560")]
		public bool RemoveLabel(string label)
		{
			//Discarded unreachable code: IL_000d
			return ((HashSet<T>)(object)labels).Remove((T)label);
		}

		[Cpp2IlInjected.Token(Token = "0x6002105")]
		[Cpp2IlInjected.Address(RVA = "0x11C55C0", Offset = "0x11C3FC0", VA = "0x1811C55C0")]
		public LabelComponent()
		{
		}
	}
}
