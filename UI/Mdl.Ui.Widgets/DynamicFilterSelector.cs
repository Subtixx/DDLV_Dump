using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000978")]
	public class DynamicFilterSelector : ToggleFilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003818")]
		[SerializeField]
		protected FilterItem _itemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003819")]
		public bool deselectWhenSelected = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400381A")]
		public DynamicFilterConfig filterConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400381B")]
		private bool _initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400381C")]
		public bool AutoInitite = true;

		[Cpp2IlInjected.Token(Token = "0x6003B7C")]
		[Cpp2IlInjected.Address(RVA = "0xF22930", Offset = "0xF21330", VA = "0x180F22930")]
		private void Start()
		{
			if (!_initiated && AutoInitite)
			{
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B7D")]
		[Cpp2IlInjected.Address(RVA = "0xF21F10", Offset = "0xF20910", VA = "0x180F21F10", Slot = "6")]
		public unsafe override void Init()
		{
			//Discarded unreachable code: IL_00a0, IL_00a6, IL_00ac, IL_00b8, IL_00be, IL_00c4
			//IL_004a: Expected I4, but got I8
			//IL_0054: Expected I4, but got I8
			//IL_0054: Expected O, but got I4
			bool flag = default(bool);
			ExtraFilter item = default(ExtraFilter);
			bool flag2 = default(bool);
			FilterItem filterItem = default(FilterItem);
			ulong num5 = default(ulong);
			ulong num6 = default(ulong);
			bool isSelected = default(bool);
			FilterItem.Clicked b = default(FilterItem.Clicked);
			bool flag3 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if ((_initiated ? 1 : 0) == num2)
				{
					List<DynamicFilterItemData> filters = filterConfig.filters;
					if (flag)
					{
						List<Filter> list = allFilters;
						int num4 = 0;
						((List<T>)(object)list).Add((T)item);
					}
					if (flag2)
					{
						filterItem.gameObject.SetActive((byte)num5 != 0);
						filterItem.Init((Filter)num2, (byte)num6 != 0);
						filterItem.isSelected = isSelected;
						Delegate @delegate = Delegate.Combine(filterItem.OnClicked, b);
						if ((object)@delegate != null && (object)@delegate == null)
						{
							break;
						}
						filterItem.OnClicked = (FilterItem.Clicked)@delegate;
						while (!flag3)
						{
						}
						if (filterItem.TryGetComponent<FocusNavigationElement>(out *(FocusNavigationElement*)num3))
						{
							num3 += 64;
							((int*)num3)->m_value = num3;
							return;
						}
						continue;
					}
					return;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B7E")]
		[Cpp2IlInjected.Address(RVA = "0xF225E0", Offset = "0xF20FE0", VA = "0x180F225E0")]
		protected void SelectFilter(FilterItem button)
		{
			//Discarded unreachable code: IL_00db, IL_00e1, IL_00f3
			//IL_005e: Expected O, but got I4
			int num = 0;
			List<Filter> list = selectedFilters;
			Filter _003CFilter_003Ek__BackingField = button.Filter;
			if (!((List<T>)(object)list).Contains((T)_003CFilter_003Ek__BackingField))
			{
				List<Filter> list2 = selectedFilters;
				((List<T>)(object)list2).Clear();
				IEnumerator enumerator = filtersAnchor.GetEnumerator();
				bool flag = default(bool);
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
					FilterItem filterItem = default(FilterItem);
					flag = filterItem != (UnityEngine.Object)num4;
					while (!flag)
					{
					}
					int num5 = ((filterItem.isSelected = false) ? 1 : 0);
				}
				if (flag)
				{
				}
				Filter _003CFilter_003Ek__BackingField2 = button.Filter;
				((List<T>)(object)list2).Add((T)_003CFilter_003Ek__BackingField2);
				button.isSelected = true;
				RefreshSelected();
				RaiseFilterSelectedByUser();
				return;
			}
			while ((deselectWhenSelected ? 1 : 0) == num)
			{
			}
			int num6 = ((button.isSelected = false) ? 1 : 0);
			List<Filter> list3 = selectedFilters;
			Filter _003CFilter_003Ek__BackingField3 = button.Filter;
			bool flag4 = ((List<T>)(object)list3).Remove((T)_003CFilter_003Ek__BackingField3);
			RaiseFilterSelectedByUser();
			RefreshSelected();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B7F")]
		[Cpp2IlInjected.Address(RVA = "0xF224F0", Offset = "0xF20EF0", VA = "0x180F224F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003B80")]
		[Cpp2IlInjected.Address(RVA = "0xF22470", Offset = "0xF20E70", VA = "0x180F22470")]
		public void RefreshLayout()
		{
			//IL_0013: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B81")]
		[Cpp2IlInjected.Address(RVA = "0xF22960", Offset = "0xF21360", VA = "0x180F22960")]
		public DynamicFilterSelector()
		{
		}
	}
}
