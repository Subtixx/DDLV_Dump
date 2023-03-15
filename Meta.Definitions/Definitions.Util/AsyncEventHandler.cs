using System;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task AsyncEventHandler(object sender, EventArgs arg);
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task AsyncEventHandler<T>(object sender, T arg);
}
