using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007BC")]
	public class ItemSelectorItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D6C")]
		[NotNull]
		[SerializeField]
		[Header("Objects")]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D6D")]
		[SerializeField]
		private SpriteAtlasImage _additionalIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D6E")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D6F")]
		[SerializeField]
		private GameObject _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002D70")]
		[SerializeField]
		[Header("Count")]
		private GameObject _countHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D71")]
		[SerializeField]
		private TextBase _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002D72")]
		[SerializeField]
		private ItemType[] _hideCountForTypes = new ItemType[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002D73")]
		private bool _hideCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4002D74")]
		[SerializeField]
		[Header("Availability")]
		private bool _alwaysAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002D75")]
		[NotNull]
		[SerializeField]
		private Color _availableColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4002D76")]
		[NotNull]
		[SerializeField]
		private Color _unavailableColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4002D77")]
		[NotNull]
		[SerializeField]
		private Color _highlightedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002D78")]
		[SerializeField]
		[NotNull]
		private Color _selectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002D79")]
		[SerializeField]
		private bool _enableSelectedVisualState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4002D7A")]
		private bool _available;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x4002D7B")]
		private bool _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
		[Cpp2IlInjected.Token(Token = "0x4002D7C")]
		private bool _selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D7D")]
		private ItemSelector _itemSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D7E")]
		private CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x170006EF")]
		private ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003173")]
			[Cpp2IlInjected.Address(RVA = "0x1321A10", Offset = "0x1320410", VA = "0x181321A10")]
			get
			{
				//IL_0010: Expected O, but got I4
				ItemSelector itemSelector = _itemSelector;
				int num = 0;
				if (itemSelector == (UnityEngine.Object)num)
				{
					ItemSelector itemSelector2 = (_itemSelector = GetComponentInParent<ItemSelector>());
				}
				return _itemSelector;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003174")]
		[Cpp2IlInjected.Address(RVA = "0x1321050", Offset = "0x131FA50", VA = "0x181321050")]
		public void Refresh(IItemSelectorItem item, bool isSelected, Sprite additionalIconSprite, IEnumerable<ProfileWorld.FilterInfo> quests)
		{
			//Discarded unreachable code: IL_01dc
			//IL_006c: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_010d: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			//IL_015f: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			//IL_019f: Expected I4, but got I8
			//IL_01bb: Expected O, but got I4
			int num = 0;
			_selected = isSelected;
			if ("" == null)
			{
			}
			if ("" == null)
			{
			}
			ItemType[] hideCountForTypes = _hideCountForTypes;
			bool hideCount = default(bool);
			_hideCount = hideCount;
			bool flag = (_alwaysAvailable = "" != null);
			bool available = default(bool);
			if ((_alwaysAvailable ? 1 : 0) == num)
			{
				available = (long)(IntPtr)typeof(UnityEngine.Object).TypeHandle > 0L;
			}
			_available = available;
			GameObject countHolder = _countHolder;
			int num2 = 0;
			if (countHolder != (UnityEngine.Object)num2)
			{
				GameObject countHolder2 = _countHolder;
				if ((_available ? 1 : 0) == num)
				{
				}
				bool active = (_hideCount ? 1 : 0) == num;
				countHolder2.SetActive(active);
			}
			TextBase count = _count;
			int num3 = 0;
			if (count != (UnityEngine.Object)num3)
			{
				GameObject gameObject = _count.gameObject;
				if ((_available ? 1 : 0) == num)
				{
				}
				bool active2 = (_hideCount ? 1 : 0) == num;
				gameObject.SetActive(active2);
				string text = default(string);
				_count.Text = text;
			}
			CancellationToken token = cts.Token;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			SpriteAtlasImage additionalIcon = _additionalIcon;
			int num5 = 0;
			bool flag2 = additionalIcon != (UnityEngine.Object)num5;
			if (flag2)
			{
				SpriteAtlasImage additionalIcon2 = _additionalIcon;
				if (!flag2)
				{
					GameObject gameObject2 = additionalIcon2.gameObject;
					int active3 = 0;
					gameObject2.SetActive((byte)active3 != 0);
				}
				int num6 = 0;
				bool active4 = additionalIconSprite != (UnityEngine.Object)num6;
				GameObject gameObject3 = default(GameObject);
				gameObject3.SetActive(active4);
				SpriteAtlasImage additionalIcon3 = _additionalIcon;
				int num7 = 0;
				if (additionalIconSprite != (UnityEngine.Object)num7)
				{
					string text2 = additionalIconSprite.name;
				}
				additionalIcon3.ImageAddress = "";
			}
			TextBase label = _label;
			int num8 = 0;
			if (label != (UnityEngine.Object)num8)
			{
				ulong num9 = default(ulong);
				_label.gameObject.SetActive((byte)num9 != 0);
				TextBase label2 = _label;
			}
			GameObject questMarker = _questMarker;
			int num10 = 0;
			if (questMarker != (UnityEngine.Object)num10)
			{
				GameObject questMarker2 = _questMarker;
				uint num11 = default(uint);
				if (num < (int)num11)
				{
					num += num;
					num++;
				}
				questMarker2.SetActive((byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003175")]
		[Cpp2IlInjected.Address(RVA = "0x1320CE0", Offset = "0x131F6E0", VA = "0x181320CE0")]
		[AsyncStateMachine(typeof(_003CLoadIcon_003Ed__22))]
		private Task LoadIcon(IItemSelectorItem item, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003176")]
		[Cpp2IlInjected.Address(RVA = "0x13216C0", Offset = "0x13200C0", VA = "0x1813216C0")]
		public void SetAmount(int newAmount)
		{
			//Discarded unreachable code: IL_0099
			//IL_0022: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			int num = 0;
			if ((_alwaysAvailable ? 1 : 0) != num)
			{
			}
			bool available = default(bool);
			_available = available;
			GameObject countHolder = _countHolder;
			int num2 = 0;
			if (countHolder != (UnityEngine.Object)num2)
			{
				GameObject countHolder2 = _countHolder;
				if ((_available ? 1 : 0) == num)
				{
				}
				bool active = (_hideCount ? 1 : 0) == num;
				countHolder2.SetActive(active);
			}
			TextBase count = _count;
			int num3 = 0;
			if (count != (UnityEngine.Object)num3)
			{
				GameObject gameObject = _count.gameObject;
				bool active2 = default(bool);
				if ((_available ? 1 : 0) != num)
				{
					active2 = (_hideCount ? 1 : 0) == num;
				}
				gameObject.SetActive(active2);
				string text = default(string);
				_count.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003177")]
		[Cpp2IlInjected.Address(RVA = "0x1320CD0", Offset = "0x131F6D0", VA = "0x181320CD0")]
		public void Highlight(bool highlight)
		{
			_highlighted = highlight;
			UpdateColor();
		}

		[Cpp2IlInjected.Token(Token = "0x6003178")]
		[Cpp2IlInjected.Address(RVA = "0x13216B0", Offset = "0x13200B0", VA = "0x1813216B0")]
		public void Select(bool select)
		{
			_selected = select;
			UpdateColor();
		}

		[Cpp2IlInjected.Token(Token = "0x6003179")]
		[Cpp2IlInjected.Address(RVA = "0x1320E10", Offset = "0x131F810", VA = "0x181320E10")]
		public void OnPointerEnter()
		{
			//Discarded unreachable code: IL_0045
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			ItemSelector itemSelector = ItemSelector;
			int num = 0;
			if (itemSelector != (UnityEngine.Object)num)
			{
				ItemSelector itemSelector2 = ItemSelector;
				FocusNavigationElement component = GetComponent<FocusNavigationElement>();
				FocusNavigation hudFocusNavigation = itemSelector2._hudFocusNavigation;
				int num2 = 0;
				if (hudFocusNavigation != (UnityEngine.Object)num2)
				{
					itemSelector2._hudFocusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600317A")]
		[Cpp2IlInjected.Address(RVA = "0x1320F30", Offset = "0x131F930", VA = "0x181320F30")]
		public void OnPointerExit()
		{
			//Discarded unreachable code: IL_0045
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			ItemSelector itemSelector = ItemSelector;
			int num = 0;
			if (itemSelector != (UnityEngine.Object)num)
			{
				ItemSelector itemSelector2 = ItemSelector;
				FocusNavigationElement component = GetComponent<FocusNavigationElement>();
				FocusNavigation hudFocusNavigation = itemSelector2._hudFocusNavigation;
				int num2 = 0;
				if (hudFocusNavigation != (UnityEngine.Object)num2)
				{
					itemSelector2._hudFocusNavigation.RemoveFocus((ISupportsFocusNavigation)component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600317B")]
		[Cpp2IlInjected.Address(RVA = "0x1321810", Offset = "0x1320210", VA = "0x181321810")]
		private void UpdateColor()
		{
			//Discarded unreachable code: IL_006e
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			AsyncAtlassedIcon icon = _icon;
			int num = 0;
			if (icon != (UnityEngine.Object)num)
			{
				RawImage rawImage = _icon.RawImage;
				int num2 = 0;
				if (rawImage == (UnityEngine.Object)num2)
				{
					return;
				}
			}
			RawImage rawImage2 = _icon.RawImage;
			if (!_available)
			{
			}
			if (!_selected || _enableSelectedVisualState)
			{
			}
			if (_highlighted)
			{
			}
			Color color = (rawImage2.color = _availableColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600317C")]
		[Cpp2IlInjected.Address(RVA = "0x1321940", Offset = "0x1320340", VA = "0x181321940")]
		public ItemSelectorItem()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			_enableSelectedVisualState = true;
			cts = new CancellationTokenSource();
			base._002Ector();
		}
	}
}
