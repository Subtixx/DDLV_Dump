using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B8")]
	public class FocusNavElementToggle : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40018DA")]
		[SerializeField]
		[NotNull]
		private Toggle _toggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40018DB")]
		[SerializeField]
		[NotNull]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40018DC")]
		[SerializeField]
		private AK.Wwise.Event toggleSFX;

		[Cpp2IlInjected.Token(Token = "0x6001ED1")]
		[Cpp2IlInjected.Address(RVA = "0x16611D0", Offset = "0x165FBD0", VA = "0x1816611D0", Slot = "19")]
		public override void RemoveFocus()
		{
			//Discarded unreachable code: IL_0011
			GameObject highlight = _highlight;
			int active = 0;
			highlight.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED2")]
		[Cpp2IlInjected.Address(RVA = "0x1661200", Offset = "0x165FC00", VA = "0x181661200", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0023
			GameObject highlight = _highlight;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool active = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			highlight.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED3")]
		[Cpp2IlInjected.Address(RVA = "0x1661060", Offset = "0x165FA60", VA = "0x181661060", Slot = "21")]
		public override void Click(ShortcutDefinition shortcut)
		{
			//Discarded unreachable code: IL_0068
			//IL_0019: Expected O, but got I4
			//IL_0067: Expected I4, but got I8
			if (shortcut.RedirectionType > (RedirectionType)1)
			{
				return;
			}
			Toggle toggle = _toggle;
			int num = 0;
			if (toggle != (Object)num && _toggle.enabled && _toggle.gameObject.activeSelf && _toggle.gameObject.activeInHierarchy)
			{
				Toggle toggle2 = _toggle;
				if (!toggle2.m_IsOn)
				{
					ulong num2 = default(ulong);
					toggle2.isOn = (byte)num2 != 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED4")]
		[Cpp2IlInjected.Address(RVA = "0x1661180", Offset = "0x165FB80", VA = "0x181661180")]
		public void PlayToggleSFX(bool selected)
		{
			//Discarded unreachable code: IL_001c
			if (selected)
			{
				AK.Wwise.Event @event = toggleSFX;
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED5")]
		[Cpp2IlInjected.Address(RVA = "0x1661250", Offset = "0x165FC50", VA = "0x181661250")]
		public FocusNavElementToggle()
		{
		}
	}
}
