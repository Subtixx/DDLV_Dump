using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006E0")]
	public abstract class ShopProductGroupDefault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40026BC")]
		[SerializeField]
		protected GameObject _mcProductsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40026BD")]
		[SerializeField]
		protected GameObject _prefabProduct;

		[Cpp2IlInjected.Token(Token = "0x6002C10")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void RefreshData(List<ShopProductModel> products);

		[Cpp2IlInjected.Token(Token = "0x6002C11")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RefreshDisplay();

		[Cpp2IlInjected.Token(Token = "0x6002C12")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected ShopProductGroupDefault()
		{
		}
	}
}
