using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009AD")]
	public class FishingStallLayout : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400356C")]
		[SerializeField]
		private List<GameObject> _collectLayoutPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700067D")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6002D4E")]
			[Cpp2IlInjected.Address(RVA = "0x13792A0", Offset = "0x1377CA0", VA = "0x1813792A0")]
			get
			{
				//Discarded unreachable code: IL_0009
				List<GameObject> collectLayoutPrefab = _collectLayoutPrefab;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4F")]
		[Cpp2IlInjected.Address(RVA = "0x13790D0", Offset = "0x1377AD0", VA = "0x1813790D0")]
		public int GetLayoutIndex(int fishCount, int fishCap)
		{
			//Discarded unreachable code: IL_0025
			if (fishCount > 0)
			{
				List<GameObject> collectLayoutPrefab = _collectLayoutPrefab;
				if (fishCount != fishCap)
				{
					int size = ((List<>)(object)collectLayoutPrefab)._size;
					return size + 1;
				}
				return ((List<>)(object)collectLayoutPrefab)._size;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D50")]
		[Cpp2IlInjected.Address(RVA = "0x1379180", Offset = "0x1377B80", VA = "0x181379180")]
		public GameObject InitLayout(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D51")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FishingStallLayout()
		{
		}
	}
}
