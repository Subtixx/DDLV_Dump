using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Systems;
using Mdl.Utils;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200099B")]
	public class FilterItemSelector : FilterSelector
	{
		[Cpp2IlInjected.Token(Token = "0x200099C")]
		public enum FilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40038C7")]
			Tag,
			[Cpp2IlInjected.Token(Token = "0x40038C8")]
			Trait,
			[Cpp2IlInjected.Token(Token = "0x40038C9")]
			Tier
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038AA")]
		protected bool _started;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038AB")]
		protected FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40038AC")]
		public FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40038AD")]
		public bool selectMultiple;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40038AE")]
		public bool deselectWhenSelected = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40038AF")]
		public bool raiseEventWhenSelectSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40038B0")]
		public List<Filter> extraFilters = (List<Filter>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40038B1")]
		[SerializeField]
		protected BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40038B2")]
		[SerializeField]
		protected Transform _bgHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40038B3")]
		[SerializeField]
		protected FilterItem _itemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40038B4")]
		[SerializeField]
		protected RectTransform filtersAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40038B5")]
		[SerializeField]
		protected LayoutElement _layout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40038B6")]
		[SerializeField]
		private bool _showSelectedHeader = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40038B7")]
		[SerializeField]
		protected GameObject _focusAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40038B8")]
		[SerializeField]
		private RectTransform _mcSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40038B9")]
		[SerializeField]
		private TextBase _tfSelectedCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40038BA")]
		[SerializeField]
		protected float _headerHeight = 55f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40038BB")]
		public List<Filter> allFilters = (List<Filter>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40038BC")]
		public List<Filter> selectedFilters = (List<Filter>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40038BD")]
		[SerializeField]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40038BE")]
		[SerializeField]
		protected bool showText = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40038BF")]
		public FilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40038C0")]
		[HideInInspector]
		public TagItemType tagType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40038C1")]
		[ItemID]
		[HideInInspector]
		[SerializeField]
		public int[] exclutionFilters = new int[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40038C2")]
		public List<string> RemovedFilters = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40038C3")]
		[HideInInspector]
		public FilterTierConfig tierConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40038C4")]
		public List<FilterItem> FilterItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40038C5")]
		public Action OnReady;

		[Cpp2IlInjected.Token(Token = "0x17000857")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6003C5F")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get
			{
				return isOpen;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C60")]
			[Cpp2IlInjected.Address(RVA = "0x1339830", Offset = "0x1338230", VA = "0x181339830")]
			set
			{
				isOpen = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C61")]
		[Cpp2IlInjected.Address(RVA = "0x1533E10", Offset = "0x1532810", VA = "0x181533E10")]
		public void Init()
		{
			//IL_00f2: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			uint num = default(uint);
			switch (filterType)
			{
			default:
			{
				List<Filter> list2 = (allFilters = (List<Filter>)(object)FilterUtil.BuildRarityFilters(tierConfig, (int)num));
				return;
			}
			case FilterType.Tag:
			{
				List<Filter> list = (allFilters = (List<Filter>)(object)FilterUtil.BuildTagFilters(tagType, (int)num));
				int[] array = exclutionFilters;
				int num2 = 0;
				if (num2 < array.Length)
				{
					int item = array[num2];
					Predicate<Filter> predicate = (Predicate<Filter>)(object)(Predicate<T>)delegate(Filter x)
					{
						if ((object)x != null)
						{
							int num5 = 0;
							if ((object)x != null)
							{
								return (IntPtr)x == (IntPtr)item;
							}
						}
						int num6 = 0;
						throw new NullReferenceException();
					};
					num2++;
				}
				int i = num2;
				List<string> removedFilters = RemovedFilters;
				Predicate<Filter> predicate2 = default(Predicate<Filter>);
				if (predicate2 == null)
				{
					predicate2 = (Predicate<Filter>)(object)(Predicate<T>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				if (tagType == TagItemType.Universe)
				{
					Func<Filter, bool> func = default(Func<Filter, bool>);
					if (_003C_003Ec._003C_003E9__32_3 == null)
					{
						func = (Func<Filter, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Filter x) => string.Equals(x.Name, "NonIP")));
					}
					Filter filter = Enumerable.FirstOrDefault<Filter>(Enumerable.Where<Filter>((IEnumerable<>)num2, (Func<, >)(object)func));
					int num3 = default(int);
					if (num3 != -1)
					{
						Filter filter2 = Enumerable.ElementAt<Filter>((IEnumerable<>)num2, num3);
					}
				}
				while (tagType != TagItemType.FurnitureFunction)
				{
				}
				if (_003C_003Ec._003C_003E9__32_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Filter x) => string.Equals(x.Name, "Door"));
				}
				break;
			}
			case FilterType.Trait:
				break;
			}
			uint num4 = default(uint);
			List<Filter> list3 = (List<Filter>)(object)FilterUtil.BuildTraitFilters((int)num4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C62")]
		[Cpp2IlInjected.Address(RVA = "0x1534DA0", Offset = "0x15337A0", VA = "0x181534DA0")]
		private void Start()
		{
			//Discarded unreachable code: IL_01ef, IL_01f5, IL_0201, IL_0207, IL_020d, IL_0213, IL_021f, IL_0225, IL_022b, IL_0231, IL_0237, IL_0249
			//IL_0096: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_015e: Expected O, but got I4
			//IL_017c: Expected O, but got I4
			//IL_0194: Expected O, but got I4
			List<FilterItem> list = (FilterItems = (List<FilterItem>)(object)new List<T>());
			List<Filter> list2 = extraFilters;
			bool flag = default(bool);
			if (flag)
			{
				FilterItem itemPrefab = _itemPrefab;
				RectTransform parent = filtersAnchor;
				FilterItem filterItem = UnityEngine.Object.Instantiate(itemPrefab, parent);
				filterItem.gameObject.SetActive(value: true);
				List<Filter> list3 = selectedFilters;
				bool isSelected = default(bool);
				filterItem._isSelected = isSelected;
				filterItem.RefreshSelected();
				FilterItem.Clicked onClicked = filterItem.OnClicked;
				FilterItem.Clicked b = SelectFilter;
				Delegate @delegate = Delegate.Combine(onClicked, b);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				filterItem.OnClicked = (FilterItem.Clicked)num;
				((List<T>)(object)FilterItems).Add((T)filterItem);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				FilterItem filterItem2 = default(FilterItem);
				filterItem2.gameObject.SetActive(value: true);
				bool isSelected2 = default(bool);
				filterItem2._isSelected = isSelected2;
				filterItem2.RefreshSelected();
				FilterItem.Clicked b2 = default(FilterItem.Clicked);
				Delegate delegate2 = Delegate.Combine(filterItem2.OnClicked, b2);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					throw new InvalidCastException();
				}
				filterItem2.OnClicked = (FilterItem.Clicked)delegate2;
			}
			GameObject gameObject = filtersAnchor.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive(value: true);
			IEnumerator enumerator = default(IEnumerator);
			bool flag3 = default(bool);
			TraitFilterItem traitFilterItem = default(TraitFilterItem);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				flag3 = traitFilterItem != (UnityEngine.Object)num4;
				while (!flag3)
				{
				}
				traitFilterItem.RefreshSize();
			}
			if (flag3)
			{
			}
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutCubic);
			int num5 = 0;
			if (traitFilterItem != (UnityEngine.Object)num5)
			{
				Transform transform = traitFilterItem.transform;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				transform.rotation = (Quaternion)num6;
				Transform transform2 = transform.transform;
				int num9 = 0;
				int num10 = 0;
				transform2.rotation = (Quaternion)num9;
			}
			Button button = default(Button);
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = OnToggleClickHandler;
			onClick.AddListener(call);
			bool flag4 = default(bool);
			if (!flag4)
			{
				return;
			}
			int num11 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag5 = default(bool);
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !flag5)
			{
				int num12 = default(int);
				if (num12 > 0)
				{
					int num13 = 0;
					Transform transform3 = default(Transform);
					FocusNavigationElement component = transform3.GetComponent<FocusNavigationElement>();
				}
				bool flag6 = default(bool);
				if (!flag6)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C63")]
		[Cpp2IlInjected.Address(RVA = "0x1534360", Offset = "0x1532D60", VA = "0x181534360")]
		private void OnEnable()
		{
			HandlePetException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C64")]
		[Cpp2IlInjected.Address(RVA = "0x1533B20", Offset = "0x1532520", VA = "0x181533B20")]
		private void HandlePetException()
		{
			//Discarded unreachable code: IL_00c3
			//IL_0024: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			int num = 0;
			bool active = (long)"{il2cpp field on {'constant27' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 1;
			int num2 = 0;
			ExtraFilter extraFilter = default(ExtraFilter);
			extraFilter.filterIcon = (Sprite)num2;
			extraFilter.filterBackground = (Sprite)num2;
			extraFilter._name = "Pets";
			extraFilter._displayName = "menu.wardrobe_pets";
			extraFilter._subFilters = (List<DynamicFilterItemData>)num2;
			extraFilter._index = num2;
			extraFilter._color = (Color)num;
			int childCount = filtersAnchor.childCount;
			if (num2 < childCount)
			{
				Filter _003CFilter_003Ek__BackingField = filtersAnchor.GetChild(num2).GetComponent<FilterItem>().Filter;
				if ((object)_003CFilter_003Ek__BackingField == null || !_003CFilter_003Ek__BackingField.Equals(extraFilter))
				{
					RectTransform rectTransform = filtersAnchor;
					num2++;
				}
				filtersAnchor.GetChild(num2).gameObject.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C65")]
		[Cpp2IlInjected.Address(RVA = "0x1534C30", Offset = "0x1533630", VA = "0x181534C30")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_008f
			//IL_0017: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			_focusNavigation = focusNavigation;
			FocusNavigation focusNavigation2 = _focusNavigation;
			int num = 0;
			bool flag = focusNavigation2 == (UnityEngine.Object)num;
			if (!flag && _started != flag)
			{
				if (filtersAnchor.childCount > 0 && isOpen)
				{
					RectTransform rectTransform = filtersAnchor;
					int index = 0;
					FocusNavigationElement component = rectTransform.GetChild(index).GetComponent<FocusNavigationElement>();
				}
				GameObject focusAnchor = _focusAnchor;
				int num2 = 0;
				if (focusAnchor != (UnityEngine.Object)num2)
				{
					GameObject focusAnchor2 = _focusAnchor;
					FocusNavigation focusNavigation3 = _focusNavigation;
					FocusNavigationElement component2 = focusAnchor2.GetComponent<FocusNavigationElement>();
					focusNavigation3.SetFocus(component2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C66")]
		[Cpp2IlInjected.Address(RVA = "0x15345A0", Offset = "0x1532FA0", VA = "0x1815345A0")]
		public void SelectCategoryFilter(FilterItem button)
		{
			SelectFilter(button);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C67")]
		[Cpp2IlInjected.Address(RVA = "0x15345B0", Offset = "0x1532FB0", VA = "0x1815345B0")]
		private void SelectFilter(FilterItem button)
		{
			//Discarded unreachable code: IL_01ae, IL_01b4, IL_01ba, IL_01c0, IL_01c6, IL_01d2, IL_01d8, IL_01de, IL_01f0
			int num = 0;
			List<Filter> list = selectedFilters;
			Filter _003CFilter_003Ek__BackingField = button.Filter;
			if (!((List<T>)(object)list).Contains((T)_003CFilter_003Ek__BackingField))
			{
				if ((selectMultiple ? 1 : 0) != num)
				{
					Filter _003CFilter_003Ek__BackingField2 = button.Filter;
					CheckSimilarities(_003CFilter_003Ek__BackingField2);
					List<Filter> list2 = selectedFilters;
					Filter _003CFilter_003Ek__BackingField3 = button.Filter;
					((List<T>)(object)list2).Add((T)_003CFilter_003Ek__BackingField3);
					IEnumerator enumerator = filtersAnchor.GetEnumerator();
					if (enumerator != null)
					{
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
						}
						int num3 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						FilterItem filterItem2 = default(FilterItem);
						FilterItem filterItem = filterItem2;
						FilterItem filterItem3 = filterItem;
						List<Filter> list3 = selectedFilters;
						Predicate<Filter> predicate = (Predicate<Filter>)(object)(Predicate<T>)delegate
						{
							//Discarded unreachable code: IL_000e
							Filter _003CFilter_003Ek__BackingField5 = filterItem.Filter;
							bool result = default(bool);
							return result;
						};
						bool flag = (filterItem3._isSelected = ((List<T>)(object)list3).Exists((Predicate<>)(object)predicate));
						filterItem3.RefreshSelected();
					}
				}
				((List<T>)(object)selectedFilters).Clear();
				IEnumerator enumerator2 = filtersAnchor.GetEnumerator();
				if (enumerator2 != null)
				{
					uint num4 = default(uint);
					if (num < (int)num4)
					{
						num += num;
						num++;
					}
					int num5 = 0;
					if (enumerator2 == null)
					{
						throw new InvalidCastException();
					}
					int num6 = 0;
					if (enumerator2 == null)
					{
						throw new InvalidCastException();
					}
					FilterItem filterItem4 = default(FilterItem);
					filterItem4._isSelected = false;
					filterItem4.RefreshSelected();
				}
				int num7 = 0;
			}
			if ((deselectWhenSelected ? 1 : 0) == num)
			{
				if ((raiseEventWhenSelectSelected ? 1 : 0) != num)
				{
					base.OnFilterSelectedByUser?.Invoke();
					base.OnFilterChanged?.Invoke();
				}
				return;
			}
			button._isSelected = (byte)num != 0;
			button.RefreshSelected();
			List<Filter> list4 = selectedFilters;
			Filter _003CFilter_003Ek__BackingField4 = button.Filter;
			bool flag2 = ((List<T>)(object)list4).Remove((T)_003CFilter_003Ek__BackingField4);
			base.OnFilterSelectedByUser?.Invoke();
			base.OnFilterChanged?.Invoke();
			RefreshSelected();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C68")]
		[Cpp2IlInjected.Address(RVA = "0x15344A0", Offset = "0x1532EA0", VA = "0x1815344A0")]
		public void RefreshSelected()
		{
			//Discarded unreachable code: IL_005f
			//IL_0010: Expected O, but got I4
			RectTransform mcSelected = _mcSelected;
			int num = 0;
			if (mcSelected != (UnityEngine.Object)num)
			{
				GameObject gameObject = _mcSelected.gameObject;
				List<Filter> list = selectedFilters;
				bool active = _showSelectedHeader;
				gameObject.SetActive(active);
			}
			List<Filter> list2 = selectedFilters;
			TextBase tfSelectedCounter = _tfSelectedCounter;
			int size = ((List<>)(object)list2)._size;
			string text = default(string);
			tfSelectedCounter.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C69")]
		[Cpp2IlInjected.Address(RVA = "0x15333E0", Offset = "0x1531DE0", VA = "0x1815333E0")]
		private void CheckSimilarities(Filter filter)
		{
			Predicate<Filter> predicate = default(Predicate<Filter>);
			do
			{
				IL_0000:
				if (filterType != FilterType.Trait || (object)filter == null)
				{
					return;
				}
				int num = 0;
				if ((object)filter != null)
				{
					continue;
				}
				int num2 = 0;
				if ((object)filter == null)
				{
					int num3 = 0;
					if ((object)filter == null)
					{
						int num4 = 0;
						if ((object)filter == null)
						{
							return;
						}
						List<Filter> list = selectedFilters;
						if (_003C_003Ec._003C_003E9__40_3 == null)
						{
							predicate = (Predicate<Filter>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(Filter x)
							{
								if ((object)x == null)
								{
									return 0 != 0;
								}
								int num9 = 0;
								return (object)x != null;
							});
						}
						int num5 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
						return;
					}
					if (_003C_003Ec._003C_003E9__40_2 != null)
					{
						goto IL_0000;
					}
					Predicate<Filter> predicate2 = (Predicate<Filter>)(object)(Predicate<T>)delegate(Filter x)
					{
						if ((object)x == null)
						{
							return 0 != 0;
						}
						int num8 = 0;
						return (object)x != null;
					};
				}
				if (_003C_003Ec._003C_003E9__40_1 != null)
				{
					goto IL_0000;
				}
				Predicate<Filter> predicate3 = (Predicate<Filter>)(object)(Predicate<T>)delegate(Filter x)
				{
					if ((object)x == null)
					{
						return 0 != 0;
					}
					int num7 = 0;
					return (object)x != null;
				};
			}
			while (_003C_003Ec._003C_003E9__40_0 != null);
			Predicate<Filter> predicate4 = (Predicate<Filter>)(object)(Predicate<T>)delegate(Filter x)
			{
				if ((object)x == null)
				{
					return 0 != 0;
				}
				int num6 = 0;
				return (object)x != null;
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6A")]
		[Cpp2IlInjected.Address(RVA = "0x1533870", Offset = "0x1532270", VA = "0x181533870")]
		internal void ClearAllSelected()
		{
			//Discarded unreachable code: IL_0043, IL_0049, IL_004f, IL_0061
			//IL_0032: Expected O, but got I4
			FilterItem filterItem = default(FilterItem);
			while (true)
			{
				((List<T>)(object)selectedFilters).Clear();
				IEnumerator enumerator = filtersAnchor.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator != null)
					{
						int num3 = 0;
						if (filterItem != (UnityEngine.Object)num3)
						{
							filterItem._isSelected = false;
							filterItem.RefreshSelected();
							return;
						}
						continue;
					}
					throw new InvalidCastException();
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4900", Offset = "0x8B3300", VA = "0x1808B4900")]
		protected void OnToggleClickHandler()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4900", Offset = "0x8B3300", VA = "0x1808B4900")]
		public void ForceToggle()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6D")]
		[Cpp2IlInjected.Address(RVA = "0x1535980", Offset = "0x1534380", VA = "0x181535980", Slot = "6")]
		protected virtual void Toggle()
		{
			//Discarded unreachable code: IL_00f0, IL_00f6, IL_00fc, IL_010e
			//IL_006a: Expected O, but got I4
			int num = 0;
			bool flag = (isOpen = (isOpen ? 1 : 0) == num);
			GameObject gameObject = filtersAnchor.gameObject;
			bool active = isOpen;
			gameObject.SetActive(active);
			if ((isOpen ? 1 : 0) != num)
			{
				IEnumerator enumerator = filtersAnchor.GetEnumerator();
				bool flag2 = default(bool);
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					TraitFilterItem traitFilterItem = default(TraitFilterItem);
					flag2 = traitFilterItem != (UnityEngine.Object)num4;
					while (!flag2)
					{
					}
					traitFilterItem.RefreshSize();
				}
				if (!flag2)
				{
				}
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(filtersAnchor);
			if (isOpen)
			{
				Vector2 sizeDelta = filtersAnchor.sizeDelta;
			}
			Transform transform = _btnToggle.Background.transform;
			int num5 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = t.SetEase(Ease.OutCubic);
			int num6 = 0;
			Transform bgHighlight = _bgHighlight;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = t2.SetEase(Ease.OutCubic);
			float preferredWidth = _layout.preferredWidth;
			TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = t3.SetEase(Ease.OutCubic);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6E")]
		[Cpp2IlInjected.Address(RVA = "0x1534370", Offset = "0x1532D70", VA = "0x181534370")]
		public void RefreshLayout()
		{
			//Discarded unreachable code: IL_0038
			LayoutRebuilder.ForceRebuildLayoutImmediate(filtersAnchor);
			if (isOpen)
			{
				Vector2 sizeDelta = filtersAnchor.sizeDelta;
			}
			float preferredWidth = _layout.preferredWidth;
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutCubic);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6F")]
		[Cpp2IlInjected.Address(RVA = "0x1533AC0", Offset = "0x15324C0", VA = "0x181533AC0", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			return (HashSet<Filter>)(object)new HashSet<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C70")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003C71")]
		[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
		public Transform GetContent()
		{
			RectTransform rectTransform = filtersAnchor;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C72")]
		[Cpp2IlInjected.Address(RVA = "0x1535DC0", Offset = "0x15347C0", VA = "0x181535DC0")]
		public FilterItemSelector()
		{
		}
	}
}
