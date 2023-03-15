using System;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000200")]
	public interface IHasTimeSpan
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TimeSpan GetTime();
	}
}
