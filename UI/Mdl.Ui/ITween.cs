using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008A4")]
	public interface ITween
	{
		[Cpp2IlInjected.Token(Token = "0x17000795")]
		bool IsComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6003643")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003644")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000796")]
		bool IsInPeace
		{
			[Cpp2IlInjected.Token(Token = "0x6003645")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003646")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000797")]
		int TagNum
		{
			[Cpp2IlInjected.Token(Token = "0x6003647")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003648")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000798")]
		object CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6003649")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600364A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000799")]
		int RepeatOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x600364B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600364C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700079A")]
		int Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x600364D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600364E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700079B")]
		int RepeatCount
		{
			[Cpp2IlInjected.Token(Token = "0x600364F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003650")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700079C")]
		float Ratio
		{
			[Cpp2IlInjected.Token(Token = "0x6003651")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700079D")]
		object Target
		{
			[Cpp2IlInjected.Token(Token = "0x6003652")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003653")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x6003655")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x6003656")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void Kill();
	}
}
