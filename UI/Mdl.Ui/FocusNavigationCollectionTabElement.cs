using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200033F")]
	public class FocusNavigationCollectionTabElement : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000F3F")]
		public CollectionMenu CollectionMenu;

		[Cpp2IlInjected.Token(Token = "0x6001478")]
		[Cpp2IlInjected.Address(RVA = "0x1662180", Offset = "0x1660B80", VA = "0x181662180", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//IL_001f: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			if (supportsFocusNavigation == null && direction == FocusDirection.Right)
			{
				CollectionItemGroup focusedCollectionItemGroup = CollectionMenu.FocusedCollectionItemGroup;
				int num = 0;
				if (focusedCollectionItemGroup != (UnityEngine.Object)num)
				{
					CollectionMenu collectionMenu = CollectionMenu;
					if (collectionMenu.FocusedElementIndex != -1)
					{
						int childCount = collectionMenu.FocusedCollectionItemGroup._items.childCount;
						CollectionMenu collectionMenu2 = CollectionMenu;
						int focusedElementIndex = collectionMenu2.FocusedElementIndex;
						if (childCount > focusedElementIndex)
						{
							FocusNavigationElement component = collectionMenu2.FocusedCollectionItemGroup._items.GetChild(focusedElementIndex).GetComponent<FocusNavigationElement>();
							goto IL_0078;
						}
					}
				}
				CollectionItem collectionItem = default(CollectionItem);
				while ((object)collectionItem != null)
				{
				}
				throw new NullReferenceException();
			}
			goto IL_0078;
			IL_0078:
			return supportsFocusNavigation;
		}

		[Cpp2IlInjected.Token(Token = "0x6001479")]
		[Cpp2IlInjected.Address(RVA = "0x16622F0", Offset = "0x1660CF0", VA = "0x1816622F0", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0042
			//IL_001b: Expected O, but got I4
			base.SetFocus();
			CollectionTabButton component = base.gameObject.GetComponent<CollectionTabButton>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					CollectionMenu.SelectTab(component, fromMove: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600147A")]
		[Cpp2IlInjected.Address(RVA = "0x16623E0", Offset = "0x1660DE0", VA = "0x1816623E0")]
		public FocusNavigationCollectionTabElement()
		{
		}
	}
}
