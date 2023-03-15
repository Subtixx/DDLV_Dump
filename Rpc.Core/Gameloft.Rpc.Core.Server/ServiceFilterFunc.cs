using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate IEnumerable<Type> ServiceFilterFunc(IEnumerable<Type> serviceTypes);
}
