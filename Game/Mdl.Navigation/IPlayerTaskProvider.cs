using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C87")]
	public interface IPlayerTaskProvider
	{
		[Cpp2IlInjected.Token(Token = "0x60039F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<PlayerTaskDefinition> GetTasks();
	}
}
