using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class DebugLogItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[SerializeField]
		private RectTransform transformComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[SerializeField]
		private Image imageComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		private Text logText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		private Image logTypeImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		private GameObject logCountParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		private Text logCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private DebugLogEntry logEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private int entryIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private DebugLogRecycledListView manager;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public RectTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return transformComponent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return imageComponent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return entryIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
		public void Initialize(DebugLogRecycledListView manager)
		{
			this.manager = manager;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x112FAE0", Offset = "0x112E4E0", VA = "0x18112FAE0")]
		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded)
		{
			//Discarded unreachable code: IL_0098
			this.logEntry = logEntry;
			RectTransform rectTransform = transformComponent;
			this.entryIndex = entryIndex;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			Text text = logText;
			if (!isExpanded)
			{
				text.horizontalOverflow = HorizontalWrapMode.Overflow;
				DebugLogRecycledListView debugLogRecycledListView = manager;
			}
			int num = (int)(text.horizontalOverflow = HorizontalWrapMode.Wrap);
			float heightOfSelectedLogEntry = manager.heightOfSelectedLogEntry;
			transformComponent.sizeDelta = sizeDelta;
			Text text2 = logText;
			if (isExpanded)
			{
				string text3 = logEntry.ToString();
			}
			string text4 = (text2.text = logEntry.logString);
			Image image = logTypeImage;
			Sprite sprite = (image.sprite = logEntry.logTypeSpriteRepresentation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x112FC20", Offset = "0x112E620", VA = "0x18112FC20")]
		public void ShowCount()
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected I4, but got I8
			Text text = logCountText;
			DebugLogEntry debugLogEntry = logEntry;
			string text2 = default(string);
			text.text = text2;
			ulong num = default(ulong);
			logCountParent.SetActive((byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1113640", Offset = "0x1112040", VA = "0x181113640")]
		public void HideCount()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = logCountParent;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x112FAB0", Offset = "0x112E4B0", VA = "0x18112FAB0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_000d
			manager.OnLogItemClicked(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x112F9A0", Offset = "0x112E3A0", VA = "0x18112F9A0")]
		public float CalculateExpandedHeight(string content)
		{
			//Discarded unreachable code: IL_0068
			string text = logText.text;
			HorizontalWrapMode horizontalOverflow = logText.horizontalOverflow;
			logText.text = content;
			Text text2 = logText;
			int num = (int)(text2.horizontalOverflow = HorizontalWrapMode.Wrap);
			float preferredHeight = logText.preferredHeight;
			logText.text = text;
			Text text3 = logText;
			return Mathf.Max(manager.logItemHeight, preferredHeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x112FC90", Offset = "0x112E690", VA = "0x18112FC90", Slot = "3")]
		public override string ToString()
		{
			DebugLogEntry debugLogEntry = logEntry;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugLogItem()
		{
		}
	}
}
