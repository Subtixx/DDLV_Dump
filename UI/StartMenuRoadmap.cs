using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200005D")]
public class StartMenuRoadmap : Menu, IHasRedirectionHandler
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x85EA60", Offset = "0x85D460", VA = "0x18085EA60", Slot = "35")]
	internal override void OnControllerChanged()
	{
		//Discarded unreachable code: IL_0032
		//IL_0030: Expected O, but got I4
		base.OnControllerChanged();
		int num = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
		{
			FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
			int num2 = 0;
			focusNavigation.SetFocus((FocusNavigationElement)num2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x85E8E0", Offset = "0x85D2E0", VA = "0x18085E8E0")]
	private void OnClose()
	{
		//Discarded unreachable code: IL_0084
		//IL_0051: Expected O, but got I4
		int num = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
		{
			FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
			if (1L == 0L)
			{
			}
			FocusNavigationElement component = StartMenu.Instance._selectedTab.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}
		StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
		int num2 = 0;
		_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num2);
		AK.Wwise.Event @event = closeSFX;
		if (@event != null)
		{
			GameObject gameObject = base.gameObject;
			uint num3 = @event.Post(gameObject);
		}
		int num4 = 0;
		UiRoot.Instance._popupStack.Pop();
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "30")]
	protected override void RegisterBaseListeners()
	{
		((object)this)._002Ector();
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "31")]
	protected override void UnregisterBaseListeners()
	{
		((object)this)._002Ector();
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x85E750", Offset = "0x85D150", VA = "0x18085E750", Slot = "38")]
	public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
	{
		//Discarded unreachable code: IL_008f
		//IL_005c: Expected O, but got I4
		if (redirectionType != RedirectionType.MenuNavGoBackward)
		{
			return;
		}
		int num = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
		{
			FocusNavigation focusNavigation = StartMenu.Instance._focusNavigation;
			if (1L == 0L)
			{
			}
			FocusNavigationElement component = StartMenu.Instance._selectedTab.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}
		StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
		int num2 = 0;
		_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num2);
		AK.Wwise.Event @event = closeSFX;
		if (@event != null)
		{
			GameObject gameObject = base.gameObject;
			uint num3 = @event.Post(gameObject);
		}
		int num4 = 0;
		UiRoot.Instance._popupStack.Pop();
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x85C740", Offset = "0x85B140", VA = "0x18085C740", Slot = "26")]
	public override void OnPop()
	{
		base.OnPop();
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
	public StartMenuRoadmap()
	{
	}
}
