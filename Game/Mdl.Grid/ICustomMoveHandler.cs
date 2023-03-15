using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200046E")]
	internal interface ICustomMoveHandler
	{
		[Cpp2IlInjected.Token(Token = "0x600135F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject CheckHover(Vector2 screenPosition);

		[Cpp2IlInjected.Token(Token = "0x6001360")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ShouldBeginMove(Vector2 screenPosition);

		[Cpp2IlInjected.Token(Token = "0x6001361")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EndMove();
	}
}
