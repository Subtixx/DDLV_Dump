using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20009A7")]
	[CreateAssetMenu]
	public class FilterTierConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038E0")]
		public List<TierFilterItemData> TiersFilter;

		[Cpp2IlInjected.Token(Token = "0x6003C9B")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public FilterTierConfig()
		{
		}
	}
}
