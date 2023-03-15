using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000861")]
	public interface IHasDynamicView
	{
		[Cpp2IlInjected.Token(Token = "0x6003507")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject GetView();

		[Cpp2IlInjected.Token(Token = "0x6003508")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ReleaseView();
	}
}
