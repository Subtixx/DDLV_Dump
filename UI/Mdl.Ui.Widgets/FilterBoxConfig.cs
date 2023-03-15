using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000993")]
	[CreateAssetMenu]
	public class FilterBoxConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003889")]
		public bool showTraits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400388A")]
		public List<TagCategoryData> tagCategories = (List<TagCategoryData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003C3D")]
		[Cpp2IlInjected.Address(RVA = "0x15305A0", Offset = "0x152EFA0", VA = "0x1815305A0")]
		public FilterBoxConfig()
		{
		}
	}
}
