using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public interface IMaterialReplacer
	{
		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		int order
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material Replace(Material material);
	}
}
