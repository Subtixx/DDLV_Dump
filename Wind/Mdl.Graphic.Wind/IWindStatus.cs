using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Wind
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IWindStatus<T> where T : Object
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		WindStatus<T> status
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
