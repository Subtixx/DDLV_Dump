using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000864")]
	public interface ITrashSeeker
	{
		[Cpp2IlInjected.Token(Token = "0x17000782")]
		Type TypeLookingFor
		{
			[Cpp2IlInjected.Token(Token = "0x6003513")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6003514")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HandleTrash(GameObject trash, object param);
	}
}
