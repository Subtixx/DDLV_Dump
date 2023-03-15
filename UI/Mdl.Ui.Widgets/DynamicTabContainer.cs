using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000981")]
	public class DynamicTabContainer : FilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003840")]
		public DynamicTabConfig tabsConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003841")]
		public FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003842")]
		public RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003843")]
		public DynamicTab tabPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003844")]
		public DynamicSubTab subTabPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003845")]
		public int filterStartIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003848")]
		private HashSet<Filter> currentFilters = (HashSet<Filter>)(object)new HashSet<T>();

		[Cpp2IlInjected.Token(Token = "0x1700081E")]
		public DynamicTab SelectedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6003BB7")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedTab_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BB8")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CSelectedTab_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700081F")]
		public List<DynamicTab> Tabs
		{
			[Cpp2IlInjected.Token(Token = "0x6003BB9")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CTabs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BBA")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CTabs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<DynamicTab>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x6003BBB")]
		[Cpp2IlInjected.Address(RVA = "0xF239B0", Offset = "0xF223B0", VA = "0x180F239B0")]
		private void Start()
		{
			//IL_0012: Expected O, but got I4
			int num = 0;
			DynamicTabConfig dynamicTabConfig = tabsConfig;
			int num2 = 0;
			if (dynamicTabConfig != (UnityEngine.Object)num2)
			{
				List<DynamicTabData> tabData = tabsConfig.tabData;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBC")]
		[Cpp2IlInjected.Address(RVA = "0xF230A0", Offset = "0xF21AA0", VA = "0x180F230A0")]
		public void AddTab(DynamicTabData data)
		{
			//Discarded unreachable code: IL_0071
			DynamicTab original = tabPrefab;
			RectTransform parent = content;
			DynamicTab dynamicTab = UnityEngine.Object.Instantiate(original, parent);
			DynamicSubTab dynamicSubTab = subTabPrefab;
			((List<T>)(object)Tabs).Add((T)dynamicTab);
			DynamicTab.TabToggled b = OnTabToggled;
			DynamicTab.TabToggled onTabToggled = dynamicTab.OnTabToggled;
			Delegate @delegate = Delegate.Combine(onTabToggled, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onTabToggled)
				{
				}
				FilterSelectedByUser value = base.RaiseFilterSelectedByUser;
				dynamicTab.OnFilterSelectedByUser += value;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBD")]
		[Cpp2IlInjected.Address(RVA = "0xF232A0", Offset = "0xF21CA0", VA = "0x180F232A0", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0043
			//IL_001b: Expected O, but got I4
			((HashSet<T>)(object)currentFilters).Clear();
			DynamicTab dynamicTab = SelectedTab;
			int num = 0;
			if (dynamicTab != (UnityEngine.Object)num)
			{
				DynamicTab dynamicTab2 = SelectedTab;
				HashSet<Filter> hashSet = currentFilters;
				HashSet<Filter> hashSet2 = (HashSet<Filter>)(object)dynamicTab2.CurrentFilters();
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)hashSet2);
			}
			return currentFilters;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBE")]
		[Cpp2IlInjected.Address(RVA = "0xF236D0", Offset = "0xF220D0", VA = "0x180F236D0", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			//Discarded unreachable code: IL_0045
			//IL_0022: Expected O, but got I4
			HashSet<Filter> equals = (HashSet<Filter>)(object)this.CurrentFilters();
			if (!((HashSet<T>)(object)filters).SetEquals((IEnumerable<>)equals))
			{
				DynamicTab dynamicTab = this.FindTab((HashSet<>)(object)filters);
				int num = 0;
				if (!(dynamicTab != (UnityEngine.Object)num))
				{
					DeselectTab();
				}
				SelectTab(dynamicTab);
				SelectedTab.SelectFilters((HashSet<>)(object)filters);
				RaiseFilterChanged();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BBF")]
		[Cpp2IlInjected.Address(RVA = "0xF23420", Offset = "0xF21E20", VA = "0x180F23420")]
		private DynamicTab FindTab(HashSet<Filter> filters)
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
				List<DynamicTab> list = Tabs;
				Predicate<DynamicTab> predicate = (Predicate<DynamicTab>)(object)(Predicate<T>)delegate(DynamicTab t)
				{
					//Discarded unreachable code: IL_0009
					Filter _003CFilter_003Ek__BackingField = t.Filter;
					bool result = default(bool);
					return result;
				};
				DynamicTab dynamicTab = (DynamicTab)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
				int num2 = 0;
				if (dynamicTab != (UnityEngine.Object)num2)
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

		[Cpp2IlInjected.Token(Token = "0x6003BC0")]
		[Cpp2IlInjected.Address(RVA = "0xF237E0", Offset = "0xF221E0", VA = "0x180F237E0")]
		private void SelectTab(DynamicTab toSelect)
		{
			//Discarded unreachable code: IL_0025, IL_002b
			int num = 0;
			DynamicTab dynamicTab = SelectedTab;
			if (!(toSelect != dynamicTab))
			{
				return;
			}
			List<DynamicTab> list = Tabs;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC1")]
		[Cpp2IlInjected.Address(RVA = "0xF23380", Offset = "0xF21D80", VA = "0x180F23380")]
		private void DeselectTab()
		{
			//Discarded unreachable code: IL_003a
			//IL_0010: Expected O, but got I4
			//IL_0039: Expected O, but got I8
			DynamicTab dynamicTab = SelectedTab;
			int num = 0;
			if (dynamicTab != (UnityEngine.Object)num)
			{
				DynamicTab dynamicTab2 = SelectedTab;
				if (dynamicTab2.isSelected)
				{
					dynamicTab2.isSelected = false;
					dynamicTab2.UpdateState();
				}
				SelectedTab = (DynamicTab)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC2")]
		[Cpp2IlInjected.Address(RVA = "0xF23690", Offset = "0xF22090", VA = "0x180F23690")]
		private void OnTabToggled(DynamicTab toSelect, bool selected)
		{
			if (selected)
			{
				SelectTab(toSelect);
				RaiseFilterSelectedByUser();
			}
			else
			{
				DeselectTab();
				RaiseFilterSelectedByUser();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BC3")]
		[Cpp2IlInjected.Address(RVA = "0xF23B30", Offset = "0xF22530", VA = "0x180F23B30")]
		public DynamicTabContainer()
		{
		}
	}
}
