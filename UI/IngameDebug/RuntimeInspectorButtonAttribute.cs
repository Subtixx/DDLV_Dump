using System;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RuntimeInspectorButtonAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private readonly string m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private readonly bool m_isInitializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private readonly ButtonVisibility m_visibility;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				return m_label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsInitializer
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return m_isInitializer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public ButtonVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return m_visibility;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE3ADC0", Offset = "0xE397C0", VA = "0x180E3ADC0")]
		public RuntimeInspectorButtonAttribute(string label, bool isInitializer, ButtonVisibility visibility)
		{
			m_label = label;
			m_isInitializer = isInitializer;
			m_visibility = visibility;
		}
	}
}
