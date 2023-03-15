using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006DA")]
	public class ShopProductGroupBundle : ShopProductGroupDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40026AC")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40026AD")]
		[SerializeField]
		protected GameObject _prefabProductCharacterBundle;

		[Cpp2IlInjected.Token(Token = "0x17000669")]
		public List<ShopProductItemCustomizedBundleTemplate> Templates
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CTemplates_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BF5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CTemplates_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF6")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF7")]
		[Cpp2IlInjected.Address(RVA = "0x142BBF0", Offset = "0x142A5F0", VA = "0x18142BBF0", Slot = "5")]
		public override void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BF8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductGroupBundle()
		{
		}
	}
}
