using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200066E")]
	public class HideForConsole : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400240C")]
		[SerializeField]
		[Header("If its for all console: leave this at WindowsEditor")]
		private RuntimePlatform _specificConsole = RuntimePlatform.WindowsEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400240D")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400240E")]
		[SerializeField]
		private FocusNavigationElement _navigationElement;

		[Cpp2IlInjected.Token(Token = "0x60029A2")]
		[Cpp2IlInjected.Address(RVA = "0xAE3550", Offset = "0xAE1F50", VA = "0x180AE3550")]
		private void Start()
		{
			int num = 0;
			bool flag = InputDetectionHelper.IsConsole();
			if (!flag)
			{
				return;
			}
			if (_specificConsole != RuntimePlatform.WindowsEditor)
			{
				int num2 = 0;
				if ((flag ? RuntimePlatform.OSXPlayer : RuntimePlatform.OSXEditor) != _specificConsole)
				{
					return;
				}
			}
			HideAndDisableNav();
		}

		[Cpp2IlInjected.Token(Token = "0x60029A3")]
		[Cpp2IlInjected.Address(RVA = "0xAE3470", Offset = "0xAE1E70", VA = "0x180AE3470")]
		private void HideAndDisableNav()
		{
			//Discarded unreachable code: IL_0046
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected F4, but got I4
			//IL_0037: Expected O, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			if (canvasGroup != (Object)num)
			{
				CanvasGroup canvasGroup2 = _canvasGroup;
				int num2 = 0;
				canvasGroup2.alpha = num2;
			}
			FocusNavigationElement navigationElement = _navigationElement;
			int num3 = 0;
			if (navigationElement != (Object)num3)
			{
				Object.Destroy(_navigationElement);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60029A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE35D0", Offset = "0xAE1FD0", VA = "0x180AE35D0")]
		public HideForConsole()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
