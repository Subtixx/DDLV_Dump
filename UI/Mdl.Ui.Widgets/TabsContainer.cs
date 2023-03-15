using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009CC")]
	public class TabsContainer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20009CD")]
		public delegate void TabSelected(int index);

		[Cpp2IlInjected.Token(Token = "0x20009CE")]
		public delegate void TabDeselected(int index);

		[Cpp2IlInjected.Token(Token = "0x20009CF")]
		public delegate void TabClicked(int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40039B0")]
		public int initialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40039B1")]
		public bool initOnAwake = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40039B2")]
		public ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40039B5")]
		private List<Tab> _tabs = (List<Tab>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40039B6")]
		[SerializeField]
		private bool _useDeselect = true;

		[Cpp2IlInjected.Token(Token = "0x17000862")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40039B3")]
		public int LastTabIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6003D58")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003D59")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			private set;
		} = -1;


		[Cpp2IlInjected.Token(Token = "0x17000863")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x40039B4")]
		public int CurrentTabIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6003D5A")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003D5B")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000864")]
		public Tab CurrentTab
		{
			[Cpp2IlInjected.Token(Token = "0x6003D5C")]
			[Cpp2IlInjected.Address(RVA = "0x17E5B00", Offset = "0x17E4500", VA = "0x1817E5B00")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000865")]
		public int TabCount
		{
			[Cpp2IlInjected.Token(Token = "0x6003D5D")]
			[Cpp2IlInjected.Address(RVA = "0x17E5B60", Offset = "0x17E4560", VA = "0x1817E5B60")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)_tabs)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008C")]
		public event TabSelected OnTabSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003D52")]
			[Cpp2IlInjected.Address(RVA = "0x17E5A60", Offset = "0x17E4460", VA = "0x1817E5A60")]
			[CompilerGenerated]
			add
			{
				TabSelected onTabSelected = this.OnTabSelected;
				Delegate @delegate = Delegate.Combine(onTabSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D53")]
			[Cpp2IlInjected.Address(RVA = "0x17E5CE0", Offset = "0x17E46E0", VA = "0x1817E5CE0")]
			[CompilerGenerated]
			remove
			{
				TabSelected onTabSelected = this.OnTabSelected;
				Delegate @delegate = Delegate.Remove(onTabSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008D")]
		public event TabDeselected OnTabDeselected
		{
			[Cpp2IlInjected.Token(Token = "0x6003D54")]
			[Cpp2IlInjected.Address(RVA = "0x17E59C0", Offset = "0x17E43C0", VA = "0x1817E59C0")]
			[CompilerGenerated]
			add
			{
				TabDeselected onTabDeselected = this.OnTabDeselected;
				Delegate @delegate = Delegate.Combine(onTabDeselected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabDeselected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D55")]
			[Cpp2IlInjected.Address(RVA = "0x17E5C40", Offset = "0x17E4640", VA = "0x1817E5C40")]
			[CompilerGenerated]
			remove
			{
				TabDeselected onTabDeselected = this.OnTabDeselected;
				Delegate @delegate = Delegate.Remove(onTabDeselected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabDeselected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008E")]
		public event TabClicked OnTabClicked
		{
			[Cpp2IlInjected.Token(Token = "0x6003D56")]
			[Cpp2IlInjected.Address(RVA = "0x17E5920", Offset = "0x17E4320", VA = "0x1817E5920")]
			[CompilerGenerated]
			add
			{
				TabClicked onTabClicked = this.OnTabClicked;
				Delegate @delegate = Delegate.Combine(onTabClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D57")]
			[Cpp2IlInjected.Address(RVA = "0x17E5BA0", Offset = "0x17E45A0", VA = "0x1817E5BA0")]
			[CompilerGenerated]
			remove
			{
				TabClicked onTabClicked = this.OnTabClicked;
				Delegate @delegate = Delegate.Remove(onTabClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTabClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D5E")]
		[Cpp2IlInjected.Address(RVA = "0x17E50F0", Offset = "0x17E3AF0", VA = "0x1817E50F0")]
		private void Awake()
		{
			if (initOnAwake)
			{
				Init();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D5F")]
		[Cpp2IlInjected.Address(RVA = "0x17E5180", Offset = "0x17E3B80", VA = "0x1817E5180")]
		public void Init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003D60")]
		[Cpp2IlInjected.Address(RVA = "0x17E4E80", Offset = "0x17E3880", VA = "0x1817E4E80")]
		public unsafe void AddTab(Tab tab)
		{
			//Discarded unreachable code: IL_00c1
			//IL_002d: Expected I8, but got O
			bool flag = default(bool);
			if ((bool)this.scrollRect && flag)
			{
				ScrollRect scrollRect = this.scrollRect;
				ulong num = default(ulong);
				((ulong*)num)->m_value = (ulong)(long)scrollRect;
			}
			((List<T>)(object)_tabs).Add((T)tab);
			int index;
			bool flag2 = (tab._isOn = (index = ((List<>)(object)_tabs)._size) == CurrentTabIndex);
			tab.UpdateState();
			bool flag3 = (tab.useDeselect = _useDeselect);
			Tab.Select value = delegate
			{
				//Discarded unreachable code: IL_0016
				TabsContainer tabsContainer2 = this;
				int index3 = index;
				tabsContainer2.TabChanged(index3);
			};
			tab.OnSelect += value;
			Tab.Deselect value2 = delegate
			{
				//Discarded unreachable code: IL_000d
				TabChanged(-1);
			};
			tab.OnDeselect += value2;
			tab.ResetOnClickListener();
			Tab.Clicked value3 = delegate
			{
				//Discarded unreachable code: IL_0016
				TabsContainer tabsContainer = this;
				int index2 = index;
				tabsContainer.TabClick(index2);
			};
			tab.OnClicked += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D61")]
		[Cpp2IlInjected.Address(RVA = "0x17E5100", Offset = "0x17E3B00", VA = "0x1817E5100")]
		public Tab GetTab(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003D62")]
		[Cpp2IlInjected.Address(RVA = "0x17E54A0", Offset = "0x17E3EA0", VA = "0x1817E54A0")]
		public void SelectTab(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003D63")]
		[Cpp2IlInjected.Address(RVA = "0x17E5700", Offset = "0x17E4100", VA = "0x1817E5700")]
		private void TabChanged(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003D64")]
		[Cpp2IlInjected.Address(RVA = "0x17E57D0", Offset = "0x17E41D0", VA = "0x1817E57D0")]
		private void TabClick(int index)
		{
			this.OnTabClicked?.Invoke(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D65")]
		[Cpp2IlInjected.Address(RVA = "0x17E5660", Offset = "0x17E4060", VA = "0x1817E5660")]
		public void SetActiveTab(int index, bool active)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003D66")]
		[Cpp2IlInjected.Address(RVA = "0x17E5540", Offset = "0x17E3F40", VA = "0x1817E5540")]
		public void SetActiveAllTabs(bool active)
		{
			//Discarded unreachable code: IL_0013, IL_0019
			List<Tab> tabs = _tabs;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = default(GameObject);
				gameObject.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D67")]
		[Cpp2IlInjected.Address(RVA = "0x17E5890", Offset = "0x17E4290", VA = "0x1817E5890")]
		public TabsContainer()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
