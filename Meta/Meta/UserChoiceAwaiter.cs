using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A66")]
	public class UserChoiceAwaiter<EnumT> : INotifyCompletion where EnumT : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002920")]
		private UserChoice<EnumT> userChoice;

		[Cpp2IlInjected.Token(Token = "0x17000ECD")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60059F2")]
			[Cpp2IlInjected.Address(RVA = "0x2BE4A10", Offset = "0x2BE3410", VA = "0x182BE4A10")]
			get
			{
				//Discarded unreachable code: IL_0020
				//IL_001c: Expected O, but got I4
				EqualityComparer<> @default = EqualityComparer<T>.get_Default();
				EnumT result = (EnumT)((UserChoice<EnumT>)(object)((UserChoiceAwaiter<>)(object)this).userChoice).Result;
				int num = 0;
				return !((EqualityComparer<T>)(object)@default).Equals((T)result, (T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059F3")]
		[Cpp2IlInjected.Address(RVA = "0x188BEB0", Offset = "0x188A8B0", VA = "0x18188BEB0")]
		public UserChoiceAwaiter(UserChoice<EnumT> userChoice)
		{
			((UserChoiceAwaiter<>)(object)this).userChoice = userChoice;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BE48C0", Offset = "0x2BE32C0", VA = "0x182BE48C0", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
			if (!IsCompleted)
			{
				UserChoice<>.OptionSelected optionSelected = default(UserChoice<>.OptionSelected);
				((UserChoice<EnumT>)(object)((UserChoiceAwaiter<>)(object)this).userChoice).add_OnOptionSelected(optionSelected);
				return;
			}
			Action action = continuation;
			while (action == null)
			{
			}
			action();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60059F5")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B5E0", Offset = "0x1C19FE0", VA = "0x181C1B5E0")]
		public EnumT GetResult()
		{
			UserChoice<> userChoice = (UserChoice<>)(object)((UserChoiceAwaiter<>)(object)this).userChoice;
			throw new NullReferenceException();
		}
	}
}
