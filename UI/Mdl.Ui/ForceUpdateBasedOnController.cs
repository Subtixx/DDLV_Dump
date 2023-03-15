using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000844")]
	public class ForceUpdateBasedOnController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000845")]
		public enum CheckType
		{
			[Cpp2IlInjected.Token(Token = "0x40030BC")]
			Controller,
			[Cpp2IlInjected.Token(Token = "0x40030BD")]
			Console
		}

		[Cpp2IlInjected.Token(Token = "0x2000846")]
		public enum ActionNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x40030BF")]
			ShouldEnable,
			[Cpp2IlInjected.Token(Token = "0x40030C0")]
			ShouldDisable
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030B9")]
		[SerializeField]
		private CheckType _checkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40030BA")]
		[SerializeField]
		private ActionNeeded _actionNeeded;

		[Cpp2IlInjected.Token(Token = "0x600348D")]
		[Cpp2IlInjected.Address(RVA = "0x166C740", Offset = "0x166B140", VA = "0x18166C740")]
		private void Update()
		{
			//Discarded unreachable code: IL_0066
			if (_checkType == CheckType.Controller)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			}
			int num2 = 0;
			if (InputDetectionHelper.IsConsole())
			{
				bool activeInHierarchy = base.gameObject.activeInHierarchy;
				int num3 = 0;
				bool flag2 = _actionNeeded == (ActionNeeded)num3;
				if (activeInHierarchy != flag2)
				{
					GameObject gameObject = base.gameObject;
					bool active = _actionNeeded == ActionNeeded.ShouldEnable;
					gameObject.SetActive(active);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600348E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ForceUpdateBasedOnController()
		{
		}
	}
}
