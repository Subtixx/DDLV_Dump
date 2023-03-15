using System;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000707")]
	public class ShopProductSubItemCustomizedBundleTemplate : UIChildTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400285B")]
		public UIChildTemplate NameHolderTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400285C")]
		public UITextTemplate NameTextTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400285D")]
		public UIChildTemplate NameBackgroundTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400285E")]
		public UIChildTemplate IconHolderTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400285F")]
		public UIChildTemplate IconTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002860")]
		public UIChildTemplate IconBackgroundTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002861")]
		public UIChildTemplate AmountHolderTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002862")]
		public UITextTemplate AmountTextTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002863")]
		public UIChildTemplate AmountBackgroundTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002864")]
		public UIChildTemplate RarityTemplate;

		[Cpp2IlInjected.Token(Token = "0x6002CC6")]
		[Cpp2IlInjected.Address(RVA = "0xC955C0", Offset = "0xC93FC0", VA = "0x180C955C0")]
		public ShopProductSubItemCustomizedBundleTemplate()
		{
		}
	}
}
