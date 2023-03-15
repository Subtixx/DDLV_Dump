using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000255")]
	[RequireComponent(typeof(DropDownMenu))]
	public class FocusNavigationElementDropDown : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000A8B")]
		private DropDownMenu _dropDownMenu;

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x1662AB0", Offset = "0x16614B0", VA = "0x181662AB0", Slot = "12")]
		protected override void Awake()
		{
			//IL_002c: Expected O, but got I4
			DropDownMenu dropDownMenu = (_dropDownMenu = GetComponent<DropDownMenu>());
			FocusNavigation focusNavigation = (base._focusNavigation = GetComponentInParent<FocusNavigation>());
			FocusNavigation focusNavigation2 = base._focusNavigation;
			int num = 0;
			if (focusNavigation2 == (UnityEngine.Object)num)
			{
				MenuNavigation menuNavigation = (base._menuNavigation = GetComponentInParent<MenuNavigation>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x1662CD0", Offset = "0x16616D0", VA = "0x181662CD0", Slot = "14")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00c7
			//IL_004c: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			FocusNavigation focusNavigation = base.FocusNavigation;
			FocusNavigation.HandlingFocusChanged b = OnHandlingFocusChanged;
			FocusNavigation.HandlingFocusChanged onHandlingFocusChanged = focusNavigation.OnHandlingFocusChanged;
			int num = 0;
			Delegate @delegate = Delegate.Combine(onHandlingFocusChanged, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onHandlingFocusChanged)
				{
				}
				LayoutGroup layoutGroup = LayoutGroup;
				int num2 = 0;
				if (layoutGroup == (UnityEngine.Object)num2)
				{
					Transform freeContainer = FreeContainer;
					int num3 = 0;
					if (freeContainer == (UnityEngine.Object)num3)
					{
						Transform transform = base.transform;
						if ((object)transform != null)
						{
							Transform parent = transform.parent;
							if ((object)parent != null)
							{
								LayoutGroup component = parent.GetComponent<LayoutGroup>();
							}
						}
						LayoutGroup = (LayoutGroup)num;
					}
				}
				BaseButton baseButton = BaseButton;
				int num4 = 0;
				if (baseButton == (UnityEngine.Object)num4)
				{
					Transform transform2 = base.transform;
					BaseButton componentInChildren = default(BaseButton);
					if ((object)transform2 != null)
					{
						componentInChildren = transform2.GetComponentInChildren<BaseButton>();
					}
					BaseButton = componentInChildren;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x1662BC0", Offset = "0x16615C0", VA = "0x181662BC0", Slot = "15")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_0030
			FocusNavigation focusNavigation = base.FocusNavigation;
			FocusNavigation.HandlingFocusChanged value = OnHandlingFocusChanged;
			FocusNavigation.HandlingFocusChanged onHandlingFocusChanged = focusNavigation.OnHandlingFocusChanged;
			Delegate @delegate = Delegate.Remove(onHandlingFocusChanged, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onHandlingFocusChanged)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE7")]
		[Cpp2IlInjected.Address(RVA = "0x1662F30", Offset = "0x1661930", VA = "0x181662F30")]
		private void OnHandlingFocusChanged(bool isFocused)
		{
			//Discarded unreachable code: IL_0033
			if (!isFocused)
			{
				DropDownMenu dropDownMenu = _dropDownMenu;
				if (dropDownMenu._isOpen != isFocused)
				{
					dropDownMenu.CloseDropDown();
					int _003C_003E1__state = default(int);
					_003CRemoveFocusLater_003Ed__5 _003CRemoveFocusLater_003Ed__ = new _003CRemoveFocusLater_003Ed__5(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CRemoveFocusLater_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = StartCoroutine(_003CRemoveFocusLater_003Ed__);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE8")]
		[Cpp2IlInjected.Address(RVA = "0x1662FD0", Offset = "0x16619D0", VA = "0x181662FD0")]
		[IteratorStateMachine(typeof(_003CRemoveFocusLater_003Ed__5))]
		private IEnumerator RemoveFocusLater()
		{
			int _003C_003E1__state = default(int);
			_003CRemoveFocusLater_003Ed__5 _003CRemoveFocusLater_003Ed__ = new _003CRemoveFocusLater_003Ed__5(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRemoveFocusLater_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE9")]
		[Cpp2IlInjected.Address(RVA = "0x1663040", Offset = "0x1661A40", VA = "0x181663040")]
		public FocusNavigationElementDropDown()
		{
		}
	}
}
