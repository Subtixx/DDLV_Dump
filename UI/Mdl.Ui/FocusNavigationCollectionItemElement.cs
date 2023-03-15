using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200033E")]
	public class FocusNavigationCollectionItemElement : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000F3D")]
		public CollectionMenu CollectionMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000F3E")]
		public CollectionItem CollectionItem;

		[Cpp2IlInjected.Token(Token = "0x6001472")]
		[Cpp2IlInjected.Address(RVA = "0x16613D0", Offset = "0x165FDD0", VA = "0x1816613D0", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//Discarded unreachable code: IL_0206, IL_020c, IL_0212, IL_021e, IL_0224, IL_022a, IL_0230, IL_0236, IL_0242
			//IL_00ea: Expected O, but got I4
			//IL_015e: Expected O, but got I4
			//IL_01a9: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			Vector3 vector = default(Vector3);
			CollectionItem collectionItem = default(CollectionItem);
			Vector3 vector2 = default(Vector3);
			Vector2 b = default(Vector2);
			Vector3 vector3 = default(Vector3);
			CollectionItem collectionItem2 = default(CollectionItem);
			Vector3 vector4 = default(Vector3);
			Vector2 b2 = default(Vector2);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			CollectionItemGroup collectionItemGroup = default(CollectionItemGroup);
			while (true)
			{
				int num = 0;
				if (supportsFocusNavigation == null && direction != 0 && direction != 0)
				{
					if (direction != 0)
					{
						if (direction != FocusDirection.Right)
						{
							goto IL_01e2;
						}
						if ((CollectionItem.Model.IsInLastRow ? 1 : 0) != num)
						{
							CollectionItemGroup componentInParent = GetComponentInParent<CollectionItemGroup>();
							int siblingIndex = componentInParent.transform.GetSiblingIndex();
							int childCount = componentInParent.transform.parent.childCount;
							if (input >= childCount)
							{
								goto IL_01e2;
							}
							Transform transform = componentInParent.transform;
							int direction2 = 0;
							Transform parent = transform.parent;
							CollectionItemGroup firstContainerWithChildren = GetFirstContainerWithChildren((FocusDirection)direction2, parent, input);
							Transform transform2 = base.transform;
							float z = vector.z;
							int num2 = 0;
							IEnumerator enumerator = firstContainerWithChildren._items.GetEnumerator();
							if (enumerator != null)
							{
								int num3 = 0;
								if (enumerator == null)
								{
									throw new InvalidCastException();
								}
								if (!collectionItem.Model.IsInFirstRow)
								{
									continue;
								}
								Transform transform3 = collectionItem.transform;
								float z2 = vector2.z;
								float num4 = Vector2.Distance((Vector2)0, b);
							}
							num++;
							if (num != 0)
							{
							}
							if (num == 0)
							{
							}
						}
						CollectionItemGroup componentInParent2 = GetComponentInParent<CollectionItemGroup>();
						Transform transform4 = base.transform;
						float z3 = vector3.z;
						int num5 = 0;
						IEnumerator enumerator2 = componentInParent2._items.GetEnumerator();
						if (enumerator2 != null)
						{
							int num6 = 0;
							if (enumerator2 == null)
							{
								break;
							}
							if (!collectionItem2.Model.IsInLastRow)
							{
								continue;
							}
							Transform transform5 = collectionItem2.transform;
							float z4 = vector4.z;
							float num7 = Vector2.Distance((Vector2)0, b2);
						}
						if ((object)focusNavigationElement == null)
						{
						}
					}
					if ((CollectionItem.Model.IsInFirstRow ? 1 : 0) != num)
					{
						CollectionItemGroup componentInParent3 = GetComponentInParent<CollectionItemGroup>();
						if (componentInParent3.transform.GetSiblingIndex() > 0)
						{
							Transform parent2 = componentInParent3.transform.parent;
							int num8 = 0;
							if (collectionItemGroup != (UnityEngine.Object)num8 && collectionItemGroup._items.childCount > 0)
							{
								RectTransform items = collectionItemGroup._items;
								int childCount2 = items.childCount;
								int num9 = input - 1;
								FocusNavigationElement component = items.GetChild(childCount2).GetComponent<FocusNavigationElement>();
							}
						}
					}
				}
				goto IL_01e2;
				IL_01e2:
				CollectionTabButton selectedTab = CollectionMenu._selectedTab;
				if ((object)selectedTab != null)
				{
					FocusNavigationElement component2 = selectedTab.GetComponent<FocusNavigationElement>();
				}
				int num10 = 0;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001473")]
		[Cpp2IlInjected.Address(RVA = "0x1661CB0", Offset = "0x16606B0", VA = "0x181661CB0")]
		private CollectionItemGroup GetFirstContainerWithChildren(FocusDirection direction, Transform container, int index)
		{
			//Discarded unreachable code: IL_0076
			//IL_0028: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			if (direction != FocusDirection.Down)
			{
				if (direction == FocusDirection.Up && index != 0)
				{
					int index2 = index - 1;
					CollectionItemGroup component = container.GetChild(index2).GetComponent<CollectionItemGroup>();
					int num = 0;
					if (component != (UnityEngine.Object)num)
					{
						int childCount = component._items.childCount;
					}
				}
				int num2 = 0;
			}
			int childCount2 = container.childCount;
			while (index >= childCount2)
			{
			}
			CollectionItemGroup component2 = container.GetChild(index).GetComponent<CollectionItemGroup>();
			int num3 = 0;
			if (component2 != (UnityEngine.Object)num3)
			{
				int childCount3 = component2._items.childCount;
			}
			return component2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001474")]
		[Cpp2IlInjected.Address(RVA = "0x1661E70", Offset = "0x1660870", VA = "0x181661E70", Slot = "17")]
		protected override bool IsInFirstRow()
		{
			if (!CollectionItem.Model.IsInFirstRow)
			{
				int num = 0;
			}
			CollectionItemGroup componentInParent = GetComponentInParent<CollectionItemGroup>();
			if ((object)componentInParent != null)
			{
				CollectionItemGroupModel _003CModel_003Ek__BackingField = componentInParent.Model;
				if (_003CModel_003Ek__BackingField != null)
				{
					bool _003CIsFirstGroup_003Ek__BackingField = _003CModel_003Ek__BackingField.IsFirstGroup;
					int num2 = 0;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001475")]
		[Cpp2IlInjected.Address(RVA = "0x1661F30", Offset = "0x1660930", VA = "0x181661F30", Slot = "18")]
		protected override bool IsInLastRow()
		{
			if (!CollectionItem.Model.IsInLastRow)
			{
				int num = 0;
			}
			CollectionItemGroup componentInParent = GetComponentInParent<CollectionItemGroup>();
			if ((object)componentInParent != null)
			{
				CollectionItemGroupModel _003CModel_003Ek__BackingField = componentInParent.Model;
				if (_003CModel_003Ek__BackingField != null)
				{
					bool _003CIsLastGroup_003Ek__BackingField = _003CModel_003Ek__BackingField.IsLastGroup;
					int num2 = 0;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001476")]
		[Cpp2IlInjected.Address(RVA = "0x1661FF0", Offset = "0x16609F0", VA = "0x181661FF0", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0071
			//IL_0016: Expected O, but got I4
			base.SetFocus();
			CollectionMenu collectionMenu = CollectionMenu;
			int num = 0;
			if (collectionMenu != (UnityEngine.Object)num && !CollectionMenu.FocusNavigation.IsPaused)
			{
				CollectionMenu.IsOnTab = false;
				CollectionMenu collectionMenu2 = CollectionMenu;
				CollectionItemGroup collectionItemGroup = (collectionMenu2.FocusedCollectionItemGroup = base.transform.GetComponentInParent<CollectionItemGroup>());
				CollectionMenu collectionMenu3 = CollectionMenu;
				int num2 = (collectionMenu3.FocusedElementIndex = base.transform.GetSiblingIndex());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001477")]
		[Cpp2IlInjected.Address(RVA = "0x1662120", Offset = "0x1660B20", VA = "0x181662120")]
		public FocusNavigationCollectionItemElement()
		{
		}
	}
}
