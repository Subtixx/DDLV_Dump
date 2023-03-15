using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000380")]
	public class CookingIngredientFocusElement : FocusNavigationGroupedElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40010EB")]
		[NotNull]
		public CookingIngredientItem CookingIngredientItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40010EC")]
		public CookingIngredientsContent CookingIngredientsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40010ED")]
		public CanvasGroup ContentCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40010EE")]
		public BaseButton ButtonPageUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40010EF")]
		public BaseButton ButtonPageDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40010F0")]
		public FocusNavigationElement StartCookingButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40010F1")]
		private int previousRightSibling = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40010F2")]
		private int previousLeftSibling;

		[Cpp2IlInjected.Token(Token = "0x600164F")]
		[Cpp2IlInjected.Address(RVA = "0x14A8C90", Offset = "0x14A7690", VA = "0x1814A8C90", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//IL_0280: Expected I4, but got I8
			//IL_028b: Expected I4, but got I8
			//IL_02a7: Expected I4, but got I8
			//IL_02b2: Expected I4, but got I8
			//IL_034a: Expected I4, but got I8
			//IL_0366: Expected I4, but got I8
			//IL_0371: Expected I4, but got I8
			//IL_0397: Expected I4, but got I8
			//IL_03b3: Expected I4, but got I8
			//IL_03be: Expected I4, but got I8
			//IL_03da: Expected I4, but got I8
			//IL_03e5: Expected I4, but got I8
			//IL_0464: Expected O, but got I4
			int num = 0;
			if (direction == FocusDirection.Left)
			{
				goto IL_02fa;
			}
			if (direction == FocusDirection.Left)
			{
				goto IL_023b;
			}
			if (direction == FocusDirection.Left)
			{
				goto IL_0141;
			}
			if (direction == FocusDirection.Right)
			{
				BaseButton buttonPageDown = ButtonPageDown;
				if ((buttonPageDown._isActive ? 1 : 0) != num && buttonPageDown.gameObject.activeSelf)
				{
					Button buttonComponent = ButtonPageDown.ButtonComponent;
					int siblingIndex = base.transform.GetSiblingIndex();
					if (siblingIndex == 1 || siblingIndex == 4 || siblingIndex == 8)
					{
						ButtonPageDown.ButtonComponent.m_OnClick?.Invoke();
						int siblingIndex2 = base.transform.GetSiblingIndex();
						if (siblingIndex2 != 1)
						{
							bool activeSelf = default(bool);
							if (siblingIndex2 == 4)
							{
								activeSelf = base.transform.parent.GetChild(num).gameObject.activeSelf;
								if (activeSelf)
								{
									goto IL_0425;
								}
							}
							uint index = default(uint);
							if (activeSelf && !base.transform.parent.GetChild((int)index).gameObject.activeSelf && !base.transform.parent.GetChild((int)index).gameObject.activeSelf)
							{
								goto IL_0118;
							}
						}
						goto IL_0425;
					}
				}
				goto IL_0118;
			}
			goto IL_048e;
			IL_023b:
			Transform transform = base.transform;
			int num2 = 0;
			int siblingIndex3 = transform.GetSiblingIndex();
			uint num3 = default(uint);
			if ((long)transform <= 6)
			{
				(new int[2])[0] = (int)num3;
				int[] array = new int[2];
				int length = array.Length;
				array[0] = 2;
				array[0] = 3;
				int[] array2 = new int[2];
				int length2 = array2.Length;
				array2[0] = 3;
				array2[0] = 4;
			}
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			if (supportsFocusNavigation == null)
			{
				if (siblingIndex3 > 4)
				{
				}
				uint num4 = default(uint);
				CookingIngredientFocusElement component = base.transform.parent.GetChild((int)num4).GetComponent<CookingIngredientFocusElement>();
				num4++;
				component.previousLeftSibling = siblingIndex3;
				while ((int)num4 <= (int)num3)
				{
				}
				if (num != 0)
				{
					bool flag = default(bool);
					if (flag)
					{
					}
					goto IL_02fa;
				}
			}
			goto IL_0425;
			IL_04a4:
			throw new NullReferenceException();
			IL_0425:
			int num5 = default(int);
			ISupportsFocusNavigation supportsFocusNavigation2 = default(ISupportsFocusNavigation);
			if (base.transform.parent.childCount > 0)
			{
				if (num != 0)
				{
					goto IL_04a4;
				}
				CookingIngredientFocusElement component2 = base.transform.parent.GetChild(num5).GetComponent<CookingIngredientFocusElement>();
				int num6 = 0;
				if (!(component2 != (UnityEngine.Object)num6) || component2.gameObject.activeSelf)
				{
				}
				if ((num5 != 1 && num5 != 4) || direction == FocusDirection.Left)
				{
				}
				while (supportsFocusNavigation2 == null)
				{
				}
			}
			if (supportsFocusNavigation2 == null)
			{
				goto IL_048e;
			}
			goto IL_04a4;
			IL_0118:
			int siblingIndex4 = base.transform.GetSiblingIndex();
			if (siblingIndex4 != 1)
			{
				if (siblingIndex4 == 4)
				{
				}
				if (siblingIndex4 == 8)
				{
				}
				ISupportsFocusNavigation supportsFocusNavigation3 = base.FindNext(FocusDirection.Down, input);
				goto IL_0141;
			}
			goto IL_0425;
			IL_02fa:
			int siblingIndex5 = base.transform.GetSiblingIndex();
			if (siblingIndex5 != 0)
			{
				if (siblingIndex5 != 0)
				{
					if (siblingIndex5 != 0)
					{
						if (siblingIndex5 != 0)
						{
							ISupportsFocusNavigation supportsFocusNavigation4 = default(ISupportsFocusNavigation);
							if (siblingIndex5 != 1 && supportsFocusNavigation4 != null)
							{
								goto IL_0425;
							}
							int[] array3 = new int[2];
							int length3 = array3.Length;
							array3[0] = 7;
						}
						int[] array4 = new int[2];
						int length4 = array4.Length;
						array4[0] = 6;
						array4[0] = 7;
					}
					int[] array5 = new int[2];
					int length5 = array5.Length;
					uint num7 = default(uint);
					array5[0] = (int)num7;
					array5[0] = 6;
				}
				int[] array6 = new int[2];
				int length6 = array6.Length;
				array6[0] = 3;
				array6[0] = 4;
			}
			int[] array7 = new int[2];
			int length7 = array7.Length;
			array7[0] = 2;
			array7[0] = 3;
			if (siblingIndex5 < 2)
			{
			}
			uint num8 = default(uint);
			CookingIngredientFocusElement component3 = base.transform.parent.GetChild((int)num8).GetComponent<CookingIngredientFocusElement>();
			num8++;
			component3.previousRightSibling = siblingIndex5;
			if (array7 != null)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				num5 = previousLeftSibling;
			}
			goto IL_0425;
			IL_0141:
			BaseButton buttonPageUp = ButtonPageUp;
			if ((buttonPageUp._isActive ? 1 : 0) != num && buttonPageUp.gameObject.activeSelf)
			{
				Button buttonComponent2 = ButtonPageUp.ButtonComponent;
				int siblingIndex6 = base.transform.GetSiblingIndex();
				if (siblingIndex6 == -3 || siblingIndex6 == 5)
				{
					ButtonPageUp.ButtonComponent.m_OnClick?.Invoke();
					int siblingIndex7 = base.transform.GetSiblingIndex();
					if (siblingIndex7 == 0)
					{
					}
					bool activeSelf2 = default(bool);
					if (siblingIndex7 == 2)
					{
						uint index2 = default(uint);
						activeSelf2 = base.transform.parent.GetChild((int)index2).gameObject.activeSelf;
						if (activeSelf2)
						{
							goto IL_0425;
						}
					}
					uint index3 = default(uint);
					if (!activeSelf2 || base.transform.parent.GetChild((int)index3).gameObject.activeSelf)
					{
						goto IL_0425;
					}
				}
			}
			int siblingIndex8 = base.transform.GetSiblingIndex();
			while (true)
			{
				switch (siblingIndex8)
				{
				case 0:
					continue;
				}
				break;
			}
			if (siblingIndex8 == 5)
			{
			}
			ISupportsFocusNavigation supportsFocusNavigation5 = base.FindNext(FocusDirection.Up, input);
			goto IL_023b;
			IL_048e:
			if (!StartCookingButton.IgnoreThis)
			{
				switch (direction)
				{
				}
			}
			goto IL_04a4;
		}

		[Cpp2IlInjected.Token(Token = "0x6001650")]
		[Cpp2IlInjected.Address(RVA = "0x14A9920", Offset = "0x14A8320", VA = "0x1814A9920")]
		public void SetPreviousLeftSibling(int index)
		{
			previousLeftSibling = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6001651")]
		[Cpp2IlInjected.Address(RVA = "0x14A99F0", Offset = "0x14A83F0", VA = "0x1814A99F0")]
		public void SetPreviousRightSibling(int index)
		{
			previousRightSibling = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6001652")]
		[Cpp2IlInjected.Address(RVA = "0x14A9930", Offset = "0x14A8330", VA = "0x1814A9930")]
		public void SetPreviousLeftSiblingsForColumn(int index)
		{
			//Discarded unreachable code: IL_0025
			if (2 <= 4)
			{
				base.transform.parent.GetChild(2).GetComponent<CookingIngredientFocusElement>().previousLeftSibling = index;
				while (2 <= 4)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001653")]
		[Cpp2IlInjected.Address(RVA = "0x14A9A00", Offset = "0x14A8400", VA = "0x1814A9A00")]
		public void SetPreviousRightSiblingsForColumn(int index)
		{
			//Discarded unreachable code: IL_0027
			if (2 <= 4)
			{
				base.transform.parent.GetChild(2).GetComponent<CookingIngredientFocusElement>().previousRightSibling = index;
				while (2 <= 4)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001654")]
		[Cpp2IlInjected.Address(RVA = "0x14A89F0", Offset = "0x14A73F0", VA = "0x1814A89F0", Slot = "21")]
		public override void Click(ShortcutDefinition shortcut)
		{
			//Discarded unreachable code: IL_0078
			if (ContentCanvasGroup.interactable)
			{
				if (Enumerable.Count<Item>(CookingIngredientsContent.SelectedIngredientContent.get_SelectedIngredientList()) < 5)
				{
					IItemData itemData = CookingIngredientItem.ItemData;
					CancellationToken cancellationToken = GetComponentInParent<Menu>().CancellationToken;
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				else
				{
					int num4 = 0;
					GenericAlert genericAlert = UiRoot.Instance._genericAlert;
					int skipLocManager = 0;
					int showCloseButton = 0;
					genericAlert.Alert("cooking.cooking_ingredient_number_exeeded_desc", "cooking.cooking_ingredient_number_exeeded_title", (byte)showCloseButton != 0, (byte)skipLocManager != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001655")]
		[Cpp2IlInjected.Address(RVA = "0x14A88E0", Offset = "0x14A72E0", VA = "0x1814A88E0")]
		[AsyncStateMachine(typeof(_003CAddIngredientTask_003Ed__14))]
		private Task AddIngredientTask(Item item, CancellationToken ct)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001656")]
		[Cpp2IlInjected.Address(RVA = "0x14A9AD0", Offset = "0x14A84D0", VA = "0x1814A9AD0")]
		public CookingIngredientFocusElement()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
