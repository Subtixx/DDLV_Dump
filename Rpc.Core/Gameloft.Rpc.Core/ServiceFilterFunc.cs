using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate IEnumerable<Type> ServiceFilterFunc(IEnumerable<Type> serviceTypes);
}
