using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098F")]
	public class FilterBox : FilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400386F")]
		public FilterBoxConfig boxConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003870")]
		public FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003871")]
		public int filterStartIndex = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003872")]
		public FilterButton headerButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003873")]
		public FilterButton contentButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003874")]
		public FilterCategoryButton categoryButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003875")]
		public RectTransform panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003876")]
		public RectTransform headerAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003877")]
		public RectTransform categoriesAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003878")]
		public RectTransform categoryAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003879")]
		public Button addButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400387A")]
		public Button clearAllButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400387B")]
		public float transitionDuration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400387C")]
		public EasingType transitionEasing = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400387D")]
		public List<FilterSelector> externalSelectors = (List<FilterSelector>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400387E")]
		private HashSet<Filter> allFilters = (HashSet<Filter>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400387F")]
		private HashSet<Filter> boxFilters = (HashSet<Filter>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003880")]
		private List<FilterCategoryButton> categories = (List<FilterCategoryButton>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003881")]
		private Tween<float> panelAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003882")]
		private bool panelShown;

		[Cpp2IlInjected.Token(Token = "0x6003C27")]
		[Cpp2IlInjected.Address(RVA = "0x1531D60", Offset = "0x1530760", VA = "0x181531D60")]
		private void Start()
		{
			//Discarded unreachable code: IL_008f, IL_0095, IL_009b
			int num = 0;
			Button.ButtonClickedEvent onClick = clearAllButton.m_OnClick;
			UnityAction call = ClearAll;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = addButton.m_OnClick;
			UnityAction call2 = TogglePanel;
			onClick2.AddListener(call2);
			List<FilterSelector> list = externalSelectors;
			bool flag = default(bool);
			if (flag)
			{
				FilterSelectedByUser filterSelectedByUser = UpdateFilters;
			}
			int num2 = 0;
			bool flag2 = default(bool);
			if (flag2)
			{
				string text = UIUtil.Loc("menu.wardrobe_filter_trait");
				List<TagCategoryData> tagCategories = boxConfig.tagCategories;
				bool flag3 = default(bool);
				if (flag3)
				{
					string locKey = default(string);
					string text2 = UIUtil.Loc(locKey);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C28")]
		[Cpp2IlInjected.Address(RVA = "0x1530620", Offset = "0x152F020", VA = "0x181530620")]
		public void AddCategory(string label, Color color, List<Filter> filters)
		{
			//Discarded unreachable code: IL_00a7
			//IL_009a: Expected O, but got I4
			FilterCategoryButton original = categoryButtonPrefab;
			RectTransform parent = categoriesAnchor;
			FilterCategoryButton filterCategoryButton = UnityEngine.Object.Instantiate(original, parent);
			filterCategoryButton.Filters = filters;
			Image bg = filterCategoryButton.bg;
			filterCategoryButton.text.text = label;
			Button.ButtonClickedEvent onClick = filterCategoryButton.button.m_OnClick;
			UnityAction call = filterCategoryButton.Click;
			onClick.AddListener(call);
			LayoutRebuilder.ForceRebuildLayoutImmediate(filterCategoryButton.text.GetComponent<RectTransform>());
			FilterCategoryButton.Clicked onClicked = filterCategoryButton.OnClicked;
			FilterCategoryButton.Clicked b = SelectCategory;
			Delegate @delegate = Delegate.Combine(onClicked, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				filterCategoryButton.OnClicked = (FilterCategoryButton.Clicked)num;
				((List<T>)(object)categories).Add((T)filterCategoryButton);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C29")]
		[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			return boxFilters;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2A")]
		[Cpp2IlInjected.Address(RVA = "0x15317A0", Offset = "0x15301A0", VA = "0x1815317A0", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			//Discarded unreachable code: IL_003d, IL_0043
			//IL_002b: Expected O, but got I4
			bool flag = default(bool);
			Filter filter = default(Filter);
			while (!((HashSet<T>)(object)boxFilters).SetEquals((IEnumerable<>)filters))
			{
				((HashSet<T>)(object)boxFilters).Clear();
				if (flag)
				{
					while ((object)filter == null)
					{
					}
					int num = 0;
					if (!filter.Equals((Filter)num))
					{
						bool flag2 = ((HashSet<T>)(object)boxFilters).Add((T)filter);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2B")]
		[Cpp2IlInjected.Address(RVA = "0x1530AB0", Offset = "0x152F4B0", VA = "0x181530AB0")]
		private HashSet<Filter> AllFilters()
		{
			//Discarded unreachable code: IL_003a, IL_0040
			((HashSet<T>)(object)allFilters).Clear();
			HashSet<Filter> hashSet = allFilters;
			HashSet<Filter> hashSet2 = boxFilters;
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)hashSet2);
			List<FilterSelector> list = externalSelectors;
			bool flag = default(bool);
			if (flag)
			{
				HashSet<Filter> hashSet3 = allFilters;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2C")]
		[Cpp2IlInjected.Address(RVA = "0x1530DD0", Offset = "0x152F7D0", VA = "0x181530DD0")]
		private Filter FoundInCategories(Filter filter)
		{
			//Discarded unreachable code: IL_0054, IL_005a
			int num = 0;
			List<FilterCategoryButton> list = categories;
			bool flag = default(bool);
			if (flag)
			{
				Predicate<Filter> predicate = default(Predicate<Filter>);
				if (predicate == null)
				{
					bool result = default(bool);
					predicate = (Predicate<Filter>)(object)(Predicate<T>)((Filter f) => result);
				}
				int num2 = 0;
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2D")]
		[Cpp2IlInjected.Address(RVA = "0x1532410", Offset = "0x1530E10", VA = "0x181532410")]
		private void UpdateFilters()
		{
			//Discarded unreachable code: IL_00b2, IL_00b8, IL_00ca, IL_00d6, IL_00dc
			int num = 0;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)this.AllFilters();
			Func<Filter, int> _003C_003E9__26_ = _003C_003Ec._003C_003E9__26_0;
			if (_003C_003E9__26_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Filter f) => f.Order);
			}
			IOrderedEnumerable<Filter> orderedEnumerable = (IOrderedEnumerable<Filter>)Enumerable.OrderBy<Filter, int>((IEnumerable<>)hashSet, (Func<, >)(object)_003C_003E9__26_);
			IEnumerator enumerator = headerAnchor.GetEnumerator();
			GameObject gameObject = default(GameObject);
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
				UnityEngine.Object.Destroy(gameObject);
			}
			int num4 = 0;
			if ((object)gameObject != null)
			{
			}
			Delegate @delegate = default(Delegate);
			if ((object)gameObject != null)
			{
				uint num5 = default(uint);
				if (num4 < (int)num5)
				{
					num4 += num4;
					if (num4 == (int)num5)
					{
						goto IL_00a5;
					}
					num4++;
				}
				FilterButton filterButton = default(FilterButton);
				FilterButton.Clicked b = default(FilterButton.Clicked);
				@delegate = Delegate.Combine(filterButton.OnClicked, b);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					filterButton.OnClicked = (FilterButton.Clicked)@delegate;
					goto IL_00a5;
				}
				throw new InvalidCastException();
			}
			goto IL_00ac;
			IL_00a5:
			@delegate = (Delegate)(object)((object)@delegate + (object)@delegate);
			goto IL_00ac;
			IL_00ac:
			if ((object)gameObject == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2E")]
		[Cpp2IlInjected.Address(RVA = "0x1532210", Offset = "0x1530C10", VA = "0x181532210")]
		private unsafe void TogglePanel()
		{
			//Discarded unreachable code: IL_0071
			//IL_0034: Expected O, but got I4
			if (panelShown && categoriesAnchor.gameObject.activeSelf)
			{
				Vector2 anchoredPosition = panel.anchoredPosition;
				int num = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(transitionEasing);
				Tween<float> tween = default(Tween<float>);
				panelAnim = tween;
				Tween<float> tween2 = panelAnim;
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePanel);
				((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
			ShowPanel();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2F")]
		[Cpp2IlInjected.Address(RVA = "0x1531970", Offset = "0x1530370", VA = "0x181531970")]
		private unsafe void ShowPanel()
		{
			//Discarded unreachable code: IL_0053, IL_0059, IL_006b
			//IL_003e: Expected O, but got I4
			IEnumerator enumerator = categoryAnchor.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject != null)
			{
				int num3 = 0;
			}
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive(value: true);
			int num4 = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num4 = 0;
			Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePanel);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C30")]
		[Cpp2IlInjected.Address(RVA = "0x1531050", Offset = "0x152FA50", VA = "0x181531050")]
		private unsafe void HidePanel()
		{
			//Discarded unreachable code: IL_004f
			//IL_0018: Expected O, but got I4
			Vector2 anchoredPosition = panel.anchoredPosition;
			int num = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num = 0;
			EasingFunction easingFunction = EasingUtil.EasingFunction(transitionEasing);
			Tween<float> tween = default(Tween<float>);
			panelAnim = tween;
			Tween<float> tween2 = panelAnim;
			Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePanel);
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C31")]
		[Cpp2IlInjected.Address(RVA = "0x1532960", Offset = "0x1531360", VA = "0x181532960")]
		private void UpdatePanel(float pos, float progress)
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			RectTransform rectTransform = panel;
			int num = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			rectTransform.anchoredPosition = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C32")]
		[Cpp2IlInjected.Address(RVA = "0x15329B0", Offset = "0x15313B0", VA = "0x1815329B0")]
		private void Update()
		{
			//IL_0029: Expected O, but got I8
			Tween<float> tween = panelAnim;
			if (tween != null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				int reverse = 0;
				if (!((Tween<T>)(object)tween).Play(deltaTime, (byte)reverse != 0))
				{
					panelAnim = (Tween<float>)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C33")]
		[Cpp2IlInjected.Address(RVA = "0x15313A0", Offset = "0x152FDA0", VA = "0x1815313A0")]
		private unsafe void SelectCategory(FilterCategoryButton category)
		{
			//Discarded unreachable code: IL_007b, IL_0087
			//IL_005c: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			int num = 0;
			List<Filter> _003CFilters_003Ek__BackingField = category.Filters;
			bool flag = default(bool);
			if (flag)
			{
				FilterButton original = contentButtonPrefab;
				RectTransform parent = categoryAnchor;
				FilterButton filterButton = UnityEngine.Object.Instantiate(original, parent);
				FilterButton.Clicked onClicked = filterButton.OnClicked;
				FilterButton.Clicked b = AddFilter;
				Delegate @delegate = Delegate.Combine(onClicked, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				filterButton.OnClicked = (FilterButton.Clicked)num;
			}
			int active = 0;
			GameObject gameObject = default(GameObject);
			gameObject.SetActive((byte)active != 0);
			int num2 = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C34")]
		[Cpp2IlInjected.Address(RVA = "0x1530C50", Offset = "0x152F650", VA = "0x181530C50")]
		private void ClearAll()
		{
			//Discarded unreachable code: IL_0022, IL_0028
			((HashSet<T>)(object)allFilters).Clear();
			((HashSet<T>)(object)boxFilters).Clear();
			List<FilterSelector> list = externalSelectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C35")]
		[Cpp2IlInjected.Address(RVA = "0x1531200", Offset = "0x152FC00", VA = "0x181531200")]
		private void RemoveFilter(FilterButton button)
		{
			//Discarded unreachable code: IL_003d, IL_0043
			HashSet<Filter> hashSet = allFilters;
			Filter _003CFilter_003Ek__BackingField = button.Filter;
			bool flag = ((HashSet<T>)(object)hashSet).Remove((T)_003CFilter_003Ek__BackingField);
			HashSet<Filter> hashSet2 = boxFilters;
			Filter _003CFilter_003Ek__BackingField2 = button.Filter;
			bool flag2 = ((HashSet<T>)(object)hashSet2).Remove((T)_003CFilter_003Ek__BackingField2);
			List<FilterSelector> list = externalSelectors;
			bool flag3 = default(bool);
			if (!flag3)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C36")]
		[Cpp2IlInjected.Address(RVA = "0x15308B0", Offset = "0x152F2B0", VA = "0x1815308B0")]
		private void AddFilter(FilterButton button)
		{
			//Discarded unreachable code: IL_0074, IL_007a
			HashSet<Filter> hashSet = boxFilters;
			Filter _003CFilter_003Ek__BackingField = button.Filter;
			if (!((HashSet<T>)(object)hashSet).Contains((T)_003CFilter_003Ek__BackingField))
			{
				HashSet<Filter> hashSet2 = boxFilters;
				Filter _003CFilter_003Ek__BackingField2 = button.Filter;
				bool flag = ((HashSet<T>)(object)hashSet2).Add((T)_003CFilter_003Ek__BackingField2);
				HashSet<Filter> hashSet3 = allFilters;
				Filter _003CFilter_003Ek__BackingField3 = button.Filter;
				if (!((HashSet<T>)(object)hashSet3).Contains((T)_003CFilter_003Ek__BackingField3))
				{
					HashSet<Filter> hashSet4 = allFilters;
					Filter _003CFilter_003Ek__BackingField4 = button.Filter;
					bool flag2 = ((HashSet<T>)(object)hashSet4).Add((T)_003CFilter_003Ek__BackingField4);
				}
				List<FilterSelector> list = externalSelectors;
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C37")]
		[Cpp2IlInjected.Address(RVA = "0x1532A30", Offset = "0x1531430", VA = "0x181532A30")]
		public FilterBox()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_0022: Expected I4, but got I8

	}
}
