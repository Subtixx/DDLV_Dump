using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A64")]
	public class UserChoice<EnumT> where EnumT : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000A65")]
		public delegate void OptionSelected();

		[Cpp2IlInjected.Token(Token = "0x17000ECC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400291F")]
		public EnumT Result
		{
			[Cpp2IlInjected.Token(Token = "0x60059E9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60059EA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000089")]
		public event OptionSelected OnOptionSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60059E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C740", Offset = "0x1C6B140", VA = "0x181C6C740")]
			[CompilerGenerated]
			add
			{
				UserChoice<>.OptionSelected onOptionSelected = (UserChoice<>.OptionSelected)(object)((UserChoice<>)(object)this).OnOptionSelected;
				Delegate @delegate = Delegate.Combine(onOptionSelected, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onOptionSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60059E8")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C800", Offset = "0x1C6B200", VA = "0x181C6C800")]
			[CompilerGenerated]
			remove
			{
				UserChoice<>.OptionSelected onOptionSelected = (UserChoice<>.OptionSelected)(object)((UserChoice<>)(object)this).OnOptionSelected;
				Delegate @delegate = Delegate.Remove(onOptionSelected, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onOptionSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4BA0", Offset = "0x2BE35A0", VA = "0x182BE4BA0")]
		public void SelectOption(EnumT option)
		{
			//Discarded unreachable code: IL_0019
			Result = option;
			((UserChoice<>)(object)this).OnOptionSelected?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60059EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4B30", Offset = "0x2BE3530", VA = "0x182BE4B30")]
		public UserChoiceAwaiter<EnumT> GetAwaiter()
		{
			return (UserChoiceAwaiter<EnumT>)(object)new UserChoiceAwaiter<EnumT>((UserChoice<>)(object)this);
		}

		[Cpp2IlInjected.Token(Token = "0x60059ED")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		public UserChoice()
		{
		}//Discarded unreachable code: IL_0007

	}
}
