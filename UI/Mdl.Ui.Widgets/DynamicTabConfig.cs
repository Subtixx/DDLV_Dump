using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000980")]
	[CreateAssetMenu]
	public class DynamicTabConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400383F")]
		public List<DynamicTabData> tabData = (List<DynamicTabData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003BB6")]
		[Cpp2IlInjected.Address(RVA = "0xF23020", Offset = "0xF21A20", VA = "0x180F23020")]
		public DynamicTabConfig()
		{
		}
	}
}
