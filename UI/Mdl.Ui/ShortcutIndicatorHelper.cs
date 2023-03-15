using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200088D")]
	public class ShortcutIndicatorHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032A5")]
		[NotNull]
		public MenuNavigation MenuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032A6")]
		public UnityEvent OnControllerChanged;

		[Cpp2IlInjected.Token(Token = "0x6003607")]
		[Cpp2IlInjected.Address(RVA = "0x15EB230", Offset = "0x15E9C30", VA = "0x1815EB230")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0021
			UnityEvent onControllerChanged = MenuNavigation.OnControllerChanged;
			UnityAction call = OnControllerChangedHandler;
			onControllerChanged.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003608")]
		[Cpp2IlInjected.Address(RVA = "0x15EB190", Offset = "0x15E9B90", VA = "0x1815EB190")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0021
			UnityEvent onControllerChanged = MenuNavigation.OnControllerChanged;
			UnityAction call = OnControllerChangedHandler;
			onControllerChanged.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003609")]
		[Cpp2IlInjected.Address(RVA = "0x15EB170", Offset = "0x15E9B70", VA = "0x1815EB170")]
		private void OnControllerChangedHandler()
		{
			OnControllerChanged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600360A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShortcutIndicatorHelper()
		{
		}
	}
}
