using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200097A")]
	public interface IVFXPool
	{
		[Cpp2IlInjected.Token(Token = "0x17000659")]
		GameObject Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x6002C28")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C29")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestEffect(Transform parent);

		[Cpp2IlInjected.Token(Token = "0x6002C2A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EndEffect(Transform parent);
	}
}
