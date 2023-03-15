using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20006EE")]
	public class ShopProductItemCustomizedBundleTemplate : UIChildTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400272E")]
		public UIDownloadableImageTemplate BackgroundTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400272F")]
		public UITextTemplate TitleTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002730")]
		public UITextTemplate SubtitleTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002731")]
		public UIChildTemplate InfoButtonTemplateWhite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002732")]
		public UIChildTemplate InfoButtonTemplateBlue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002733")]
		public UIChildTemplate PurchaseButtonTemplateRed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002734")]
		public UIChildTemplate PurchaseButtonTemplateBlue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002735")]
		public List<ShopProductSubItemCustomizedBundleTemplate> SubItemTemplates;

		[Cpp2IlInjected.Token(Token = "0x6002C4E")]
		[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
		public ShopProductItemCustomizedBundleTemplate()
		{
		}
	}
}
