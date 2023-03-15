using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A39")]
	public interface IRecurringEvent
	{
		[Cpp2IlInjected.Token(Token = "0x17000EA7")]
		Item RecurringEventItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005898")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA8")]
		Timestamp NextOccurrence
		{
			[Cpp2IlInjected.Token(Token = "0x6005899")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600589A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA9")]
		Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x600589B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600589C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600589D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Execute(in World world, ITransactionContext context, Random random);

		[Cpp2IlInjected.Token(Token = "0x600589E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		TimeSpan GetMaxIntervalToFullyExecute(in World world);
	}
}
