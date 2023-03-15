using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20006BF")]
	public class ShopBundleLayoutTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400261E")]
		public List<ShopProductItemCustomizedBundleTemplate> BundleTemplates;

		[Cpp2IlInjected.Token(Token = "0x6002B80")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ShopBundleLayoutTemplate()
		{
		}
	}
}
