using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A1")]
	internal class CharacterSpawnTracker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40030A8")]
		internal Dictionary<object, int> spawnCounts = (Dictionary<object, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x60027EA")]
		[Cpp2IlInjected.Address(RVA = "0x12E8DE0", Offset = "0x12E77E0", VA = "0x1812E8DE0")]
		public void Reset()
		{
			//Discarded unreachable code: IL_000c
			((Dictionary<TKey, TValue>)(object)spawnCounts).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60027EB")]
		[Cpp2IlInjected.Address(RVA = "0x12E8C80", Offset = "0x12E7680", VA = "0x1812E8C80")]
		public int CountFor(object o)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0013, IL_0020
			//IL_0020: Expected I4, but got O
			Dictionary<object, int> dictionary = spawnCounts;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027EC")]
		[Cpp2IlInjected.Address(RVA = "0x12E8D10", Offset = "0x12E7710", VA = "0x1812E8D10")]
		public void IncrementFor(object o)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_003a
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			//IL_0039: Expected O, but got I4
			Dictionary<object, int> dictionary = spawnCounts;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027ED")]
		[Cpp2IlInjected.Address(RVA = "0x12E8E30", Offset = "0x12E7830", VA = "0x1812E8E30")]
		public CharacterSpawnTracker()
		{
		}
	}
}
