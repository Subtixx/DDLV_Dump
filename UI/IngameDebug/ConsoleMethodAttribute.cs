using System;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ConsoleMethodAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private string m_command;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private string m_description;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public string Command
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				return m_command;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_description;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x14A33B0", Offset = "0x14A1DB0", VA = "0x1814A33B0")]
		public ConsoleMethodAttribute(string command, string description)
		{
			((Array)(object)this)._002Ector();
			m_command = command;
			m_description = description;
			/*Error: Unexpected end of block*/;
		}
	}
}
