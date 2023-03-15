using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C3")]
	public abstract class ShopContentDefault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400262D")]
		[SerializeField]
		protected GameObject _mcProductGroupsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400262E")]
		[SerializeField]
		protected GameObject _prefabProductGroup;

		[Cpp2IlInjected.Token(Token = "0x6002B8A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void RefreshData(List<ShopProductModel> products, [Optional] List<ShopProductItemCustomizedBundleTemplate> templates);

		[Cpp2IlInjected.Token(Token = "0x6002B8B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RefreshDisplay();

		[Cpp2IlInjected.Token(Token = "0x6002B8C")]
		[Cpp2IlInjected.Address(RVA = "0x1426E70", Offset = "0x1425870", VA = "0x181426E70")]
		internal ShopProductItemDefault GetFirstProductItem()
		{
			//Discarded unreachable code: IL_000c
			return _mcProductGroupsHolder.GetComponentInChildren<ShopProductItemDefault>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B8D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected ShopContentDefault()
		{
		}
	}
}
