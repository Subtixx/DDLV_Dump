using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000685")]
	public class QuestLogListItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024B5")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024B6")]
		[SerializeField]
		private QuestLogCategory _category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024B7")]
		[SerializeField]
		private QuestLogItem _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024B8")]
		private int _switchFontMin = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40024B9")]
		private int _switchFontMax;

		[Cpp2IlInjected.Token(Token = "0x17000636")]
		[HideInInspector]
		public bool AdjustForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6002A0D")]
			[Cpp2IlInjected.Address(RVA = "0xF2DDF0", Offset = "0xF2C7F0", VA = "0x180F2DDF0")]
			get
			{
				if (_switchFontMin == -1)
				{
					int num = 0;
				}
				return _switchFontMax != -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000637")]
		internal QuestLogItem QuestLogItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002A0E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0F")]
		[Cpp2IlInjected.Address(RVA = "0xF2D970", Offset = "0xF2C370", VA = "0x180F2D970")]
		public void Refresh(QuestLogListItemData data, QuestLogListItemData? nextData, bool selected, bool tracked, Action<QuestLogListItemData> onClick, Action onHighlight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A10")]
		[Cpp2IlInjected.Address(RVA = "0xF2D870", Offset = "0xF2C270", VA = "0x180F2D870")]
		private float GetItemHeight(QuestLogListItemData data, QuestLogListItemData? nextData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A11")]
		[Cpp2IlInjected.Address(RVA = "0xF2DD30", Offset = "0xF2C730", VA = "0x180F2DD30")]
		public void SetSwitchFont(int min, int max)
		{
			//Discarded unreachable code: IL_002f
			//IL_001e: Expected O, but got I4
			QuestLogItem item = _item;
			_switchFontMin = min;
			_switchFontMax = max;
			int num = 0;
			if (item != (UnityEngine.Object)num)
			{
				_item.ApplySwitchSettings(min, max);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A12")]
		[Cpp2IlInjected.Address(RVA = "0xF2DDE0", Offset = "0xF2C7E0", VA = "0x180F2DDE0")]
		public QuestLogListItem()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
