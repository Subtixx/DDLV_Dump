using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000977")]
	[CreateAssetMenu]
	public class DynamicFilterConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003817")]
		public List<DynamicFilterItemData> filters = (List<DynamicFilterItemData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003B7B")]
		[Cpp2IlInjected.Address(RVA = "0xF21E90", Offset = "0xF20890", VA = "0x180F21E90")]
		public DynamicFilterConfig()
		{
		}
	}
}
