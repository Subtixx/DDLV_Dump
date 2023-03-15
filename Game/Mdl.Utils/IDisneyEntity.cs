using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000754")]
	internal interface IDisneyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		Transform transform
		{
			[Cpp2IlInjected.Token(Token = "0x600209E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		GameObject gameObject
		{
			[Cpp2IlInjected.Token(Token = "0x600209F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
