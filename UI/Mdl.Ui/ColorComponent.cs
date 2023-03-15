using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	public class ColorComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		public class ColorChanged : UnityEvent<int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0xA15C60", Offset = "0xA14660", VA = "0x180A15C60")]
			public ColorChanged()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private ColorChanged _OnColorChanged = new ColorChanged();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		[SerializeField]
		private ListBase list_color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public List<Color> ColorList;

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public ColorChanged OnColorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _OnColorChanged;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				_OnColorChanged = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public ListBase ListBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return list_color;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x114F3A0", Offset = "0x114DDA0", VA = "0x18114F3A0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0054
			UnityAction<ListBase.ListEventData> unityAction = default(UnityAction<ListBase.ListEventData>);
			((UnityEvent<T0>)(object)list_color.m_OnItemData).AddListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = list_color.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemDeselect = list_color.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).AddListener((UnityAction<>)(object)unityAction3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x114F7C0", Offset = "0x114E1C0", VA = "0x18114F7C0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0054
			UnityAction<ListBase.ListEventData> unityAction = default(UnityAction<ListBase.ListEventData>);
			((UnityEvent<T0>)(object)list_color.m_OnItemData).RemoveListener((UnityAction<>)(object)unityAction);
			ListBase.ListEvents onItemSelect = list_color.m_OnItemSelect;
			UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorSelectHandler);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
			ListBase.ListEvents onItemDeselect = list_color.m_OnItemDeselect;
			UnityAction<ListBase.ListEventData> unityAction3 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnColorSelectHandler);
			((UnityEvent<T0>)(object)onItemDeselect).RemoveListener((UnityAction<>)(object)unityAction3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x114F6A0", Offset = "0x114E0A0", VA = "0x18114F6A0")]
		private void OnColorSelectHandler(ListBase.ListEventData arg0)
		{
			//Discarded unreachable code: IL_0060
			//IL_0015: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			ColorItem component = arg0.DisplayObject.GetComponent<ColorItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				ListBase listBase = list_color;
				int itemIndex = arg0.ItemIndex;
				int selectedIndex = listBase.SelectedIndex;
				bool flag2 = (component.IsSelected = itemIndex == selectedIndex);
				if (component.IsSelected)
				{
					ColorChanged onColorChanged = _OnColorChanged;
					int itemIndex2 = arg0.ItemIndex;
					((UnityEvent<T0>)(object)onColorChanged).Invoke((T0)itemIndex2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x114F550", Offset = "0x114DF50", VA = "0x18114F550", Slot = "4")]
		protected virtual void OnColorDataHandler(ListBase.ListEventData arg0)
		{
			//Discarded unreachable code: IL_0065
			//IL_0015: Expected O, but got I4
			ColorItem component = arg0.DisplayObject.GetComponent<ColorItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				ListBase listBase = list_color;
				int itemIndex = arg0.ItemIndex;
				int selectedIndex = listBase.SelectedIndex;
				bool flag2 = (component.IsSelected = itemIndex == selectedIndex);
				List<Color> colorList = ColorList;
				int itemIndex2 = arg0.ItemIndex;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num2 += num2;
				Image mc_colorIcon = component.mc_colorIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x114F500", Offset = "0x114DF00", VA = "0x18114F500")]
		public void Init()
		{
			//Discarded unreachable code: IL_001d
			List<Color> colorList = ColorList;
			ListBase listBase = list_color;
			int num = (listBase.TotalCount = ((List<>)(object)colorList)._size);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x114F920", Offset = "0x114E320", VA = "0x18114F920")]
		public ColorComponent()
		{
		}
	}
}
