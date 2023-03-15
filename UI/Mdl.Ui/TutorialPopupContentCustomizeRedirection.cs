using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200074D")]
	public class TutorialPopupContentCustomizeRedirection : TutorialPopupContent
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002A9B")]
		public GameObject _keyboardShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002A9C")]
		public GameObject _gamepadShortcut;

		[Cpp2IlInjected.Token(Token = "0x6002EA9")]
		[Cpp2IlInjected.Address(RVA = "0x17F51B0", Offset = "0x17F3BB0", VA = "0x1817F51B0")]
		public TutorialPopupContentCustomizeRedirection()
		{
			BoxDelay = 0.75f;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
