using Cpp2IlInjected;
using Definitions.Util;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E19")]
	public interface IAction
	{
		[Cpp2IlInjected.Token(Token = "0x170014A8")]
		string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60076B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60076AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Apply(Profile profile, ITransactionContext context);
	}
}
