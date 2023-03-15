using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B83")]
	internal class MiningRockIndexDistributor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400400A")]
		private MiningRock[] miningRocks;

		[Cpp2IlInjected.Token(Token = "0x600354C")]
		[Cpp2IlInjected.Address(RVA = "0xBC69D0", Offset = "0xBC53D0", VA = "0x180BC69D0")]
		public int GetIndex(MiningRock miningRock)
		{
			if (miningRocks == null)
			{
				MiningRock[] array = (miningRocks = GetComponentsInChildren<MiningRock>());
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600354D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MiningRockIndexDistributor()
		{
		}
	}
}
