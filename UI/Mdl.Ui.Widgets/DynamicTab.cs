using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200097D")]
	public class DynamicTab : FilterSelector
	{
		[Cpp2IlInjected.Token(Token = "0x200097E")]
		public delegate void TabToggled(DynamicTab tab, bool selected);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400382D")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400382F")]
		private HashSet<Filter> currentFilter = (HashSet<Filter>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003832")]
		public Image icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003833")]
		public RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003834")]
		public Button openButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003835")]
		public Button closeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003836")]
		public CanvasGroup selector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003837")]
		public float transitionDuration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4003838")]
		public EasingType easingType = EasingType.QuadEaseInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003839")]
		public float delayBetweenSubTabs = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400383A")]
		private float panelHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400383B")]
		private RectTransform selectorRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400383C")]
		private Tween<float> panelAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400383D")]
		private Tween<float> selectorAnim;

		[Cpp2IlInjected.Token(Token = "0x1700081A")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003B96")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B97")]
			[Cpp2IlInjected.Address(RVA = "0xF254D0", Offset = "0xF23ED0", VA = "0x180F254D0")]
			set
			{
				if (value != isSelected)
				{
					isSelected = value;
					UpdateState();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081B")]
		public Filter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003B98")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B99")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081C")]
		public DynamicSubTab SelectedSubTab
		{
			[Cpp2IlInjected.Token(Token = "0x6003B9A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedSubTab_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B9B")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CSelectedSubTab_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081D")]
		public List<DynamicSubTab> SubTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6003B9C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CSubTabs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B9D")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CSubTabs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<DynamicSubTab>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x1400007F")]
		public event TabToggled OnTabToggled
		{
			[Cpp2IlInjected.Token(Token = "0x6003B94")]
			[Cpp2IlInjected.Address(RVA = "0xF25390", Offset = "0xF23D90", VA = "0x180F25390")]
			[CompilerGenerated]
			add
			{
				TabToggled onTabToggled = this.OnTabToggled;
				Delegate @delegate = Delegate.Combine(onTabToggled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabToggled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B95")]
			[Cpp2IlInjected.Address(RVA = "0xF25430", Offset = "0xF23E30", VA = "0x180F25430")]
			[CompilerGenerated]
			remove
			{
				TabToggled onTabToggled = this.OnTabToggled;
				Delegate @delegate = Delegate.Remove(onTabToggled, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabToggled)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9E")]
		[Cpp2IlInjected.Address(RVA = "0xF23BF0", Offset = "0xF225F0", VA = "0x180F23BF0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = openButton.m_OnClick;
			UnityAction call = OpenTab;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = closeButton.m_OnClick;
			UnityAction call2 = CloseTab;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9F")]
		[Cpp2IlInjected.Address(RVA = "0xF24880", Offset = "0xF23280", VA = "0x180F24880")]
		private void Start()
		{
			//IL_001a: Expected F4, but got I4
			Vector2 sizeDelta = content.sizeDelta;
			CanvasGroup canvasGroup = selector;
			panelHeight = 0f;
			RectTransform rectTransform = (selectorRect = canvasGroup.GetComponent<RectTransform>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA0")]
		[Cpp2IlInjected.Address(RVA = "0xF242F0", Offset = "0xF22CF0", VA = "0x180F242F0")]
		public void Init(DynamicTabData data, FilterColorConfig colorConfig, int filterStartIndex, DynamicSubTab subTabPrefab)
		{
			//Discarded unreachable code: IL_003a, IL_0040
			int num = 0;
			Filter filter = default(Filter);
			Filter = filter;
			Image image = icon;
			bool flag = default(bool);
			if (flag)
			{
				DynamicSubTab dynamicSubTab = default(DynamicSubTab);
				((List<T>)(object)SubTabs).Add((T)dynamicSubTab);
				DynamicSubTab.Selected value = OnSubTabSelected;
				dynamicSubTab.OnSelected += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA1")]
		[Cpp2IlInjected.Address(RVA = "0xF23D20", Offset = "0xF22720", VA = "0x180F23D20", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0061
			//IL_0033: Expected O, but got I4
			((HashSet<T>)(object)currentFilter).Clear();
			HashSet<Filter> hashSet = currentFilter;
			Filter item = Filter;
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)item);
			DynamicSubTab dynamicSubTab = SelectedSubTab;
			int num = 0;
			if (dynamicSubTab != (UnityEngine.Object)num)
			{
				DynamicSubTab dynamicSubTab2 = SelectedSubTab;
				HashSet<Filter> hashSet2 = currentFilter;
				Filter item2 = dynamicSubTab2.Filter;
				bool flag2 = ((HashSet<T>)(object)hashSet2).Add((T)item2);
			}
			return currentFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA2")]
		[Cpp2IlInjected.Address(RVA = "0xF24610", Offset = "0xF23010", VA = "0x180F24610", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			//IL_0011: Expected O, but got I4
			DynamicSubTab dynamicSubTab = this.FindSubTab((HashSet<>)(object)filters);
			int num = 0;
			if (!(dynamicSubTab != (UnityEngine.Object)num))
			{
				DeselectSubTab();
			}
			else
			{
				SelectSubTab(dynamicSubTab);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA3")]
		[Cpp2IlInjected.Address(RVA = "0xF24080", Offset = "0xF22A80", VA = "0x180F24080")]
		private DynamicSubTab FindSubTab(HashSet<Filter> filters)
		{
			//Discarded unreachable code: IL_0055, IL_005b
			//IL_0013: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			int num;
			bool flag = default(bool);
			while (true)
			{
				num = 0;
				if (!flag)
				{
					break;
				}
				Filter filter = (Filter)0;
				List<DynamicSubTab> list = SubTabs;
				Predicate<DynamicSubTab> predicate = (Predicate<DynamicSubTab>)(object)(Predicate<T>)delegate(DynamicSubTab t)
				{
					//Discarded unreachable code: IL_0009
					Filter filter2 = t.Filter;
					bool result = default(bool);
					return result;
				};
				DynamicSubTab dynamicSubTab = (DynamicSubTab)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				int num2 = 0;
				if (dynamicSubTab != (UnityEngine.Object)num2)
				{
					num++;
					break;
				}
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA4")]
		[Cpp2IlInjected.Address(RVA = "0xF246B0", Offset = "0xF230B0", VA = "0x180F246B0")]
		private void SelectSubTab(DynamicSubTab toSelect)
		{
			//Discarded unreachable code: IL_002b, IL_0031
			int num = 0;
			DynamicSubTab dynamicSubTab = SelectedSubTab;
			if (!(toSelect != dynamicSubTab))
			{
				return;
			}
			List<DynamicSubTab> list = SubTabs;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				int num2 = 0;
			}
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA5")]
		[Cpp2IlInjected.Address(RVA = "0xF23E00", Offset = "0xF22800", VA = "0x180F23E00")]
		private unsafe void DeselectSubTab()
		{
			//Discarded unreachable code: IL_00c2
			//IL_0010: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			DynamicSubTab dynamicSubTab = SelectedSubTab;
			int num = 0;
			if (dynamicSubTab != (UnityEngine.Object)num)
			{
				DynamicSubTab dynamicSubTab2 = SelectedSubTab;
				if (dynamicSubTab2.isSelected)
				{
					Image selectedIcon = dynamicSubTab2.selectedIcon;
					dynamicSubTab2.isSelected = false;
					GameObject gameObject = selectedIcon.gameObject;
					bool active = dynamicSubTab2.isSelected;
					gameObject.SetActive(active);
					GameObject gameObject2 = dynamicSubTab2.unselectedIcon.gameObject;
					bool active2 = !dynamicSubTab2.isSelected;
					gameObject2.SetActive(active2);
				}
				float alpha = selector.alpha;
				int num2 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num2 = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(easingType);
				Tween<float> tween = default(Tween<float>);
				selectorAnim = tween;
				Tween<float> tween2 = selectorAnim;
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateSelectorFade);
				((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA6")]
		[Cpp2IlInjected.Address(RVA = "0xF245B0", Offset = "0xF22FB0", VA = "0x180F245B0")]
		private void OnSubTabSelected(DynamicSubTab toSelect)
		{
			SelectSubTab(toSelect);
			RaiseFilterSelectedByUser();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA7")]
		[Cpp2IlInjected.Address(RVA = "0xF245D0", Offset = "0xF22FD0", VA = "0x180F245D0")]
		private void OpenTab()
		{
			if (!isSelected)
			{
				isSelected = true;
				UpdateState();
				TabToggled onTabToggled = this.OnTabToggled;
				if (onTabToggled != null)
				{
					bool selected = isSelected;
					onTabToggled(this, selected);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA8")]
		[Cpp2IlInjected.Address(RVA = "0xF23CE0", Offset = "0xF226E0", VA = "0x180F23CE0")]
		private void CloseTab()
		{
			if (isSelected)
			{
				isSelected = false;
				UpdateState();
				TabToggled onTabToggled = this.OnTabToggled;
				if (onTabToggled != null)
				{
					bool selected = isSelected;
					onTabToggled(this, selected);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA9")]
		[Cpp2IlInjected.Address(RVA = "0xF249D0", Offset = "0xF233D0", VA = "0x180F249D0")]
		private unsafe void UpdateSelector(bool immediate)
		{
			//IL_0053: Expected O, but got I4
			CanvasGroup canvasGroup = selector;
			float alpha = canvasGroup.alpha;
			if ((object)canvasGroup != null)
			{
				selector.alpha = 1f;
			}
			RectTransform rectTransform = selectorRect;
			if (!immediate)
			{
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				Vector2 anchoredPosition2 = SelectedSubTab.GetComponent<RectTransform>().anchoredPosition;
				int num = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(easingType);
				Tween<float> tween = default(Tween<float>);
				selectorAnim = tween;
				Tween<float> tween2 = selectorAnim;
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateSelectorPos);
				((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
				return;
			}
			Vector2 anchoredPosition3 = SelectedSubTab.GetComponent<RectTransform>().anchoredPosition;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAA")]
		[Cpp2IlInjected.Address(RVA = "0xF24C60", Offset = "0xF23660", VA = "0x180F24C60")]
		private void UpdateState()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAB")]
		[Cpp2IlInjected.Address(RVA = "0xF24900", Offset = "0xF23300", VA = "0x180F24900")]
		private void UpdatePanel(float height, float progress)
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			RectTransform rectTransform = content;
			int num = 0;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			rectTransform.sizeDelta = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAC")]
		[Cpp2IlInjected.Address(RVA = "0xF24970", Offset = "0xF23370", VA = "0x180F24970")]
		private void UpdateSelectorPos(float pos, float progress)
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			RectTransform rectTransform = selectorRect;
			int num = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			rectTransform.anchoredPosition = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAD")]
		[Cpp2IlInjected.Address(RVA = "0xF24950", Offset = "0xF23350", VA = "0x180F24950")]
		private void UpdateSelectorFade(float alpha, float progress)
		{
			//Discarded unreachable code: IL_000d
			selector.alpha = alpha;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAE")]
		[Cpp2IlInjected.Address(RVA = "0xF251E0", Offset = "0xF23BE0", VA = "0x180F251E0")]
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
			if ((object)this != null)
			{
				int num2 = 0;
				float deltaTime2 = Time.deltaTime;
				int num3 = 0;
				bool flag = default(bool);
				if (flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BAF")]
		[Cpp2IlInjected.Address(RVA = "0xF252B0", Offset = "0xF23CB0", VA = "0x180F252B0")]
		public DynamicTab()
		{
		}//IL_002f: Expected I4, but got I8

	}
}
