using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class DebugLogRecycledListView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		private RectTransform transformComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[SerializeField]
		private Color logItemNormalColor1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		private Color logItemNormalColor2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		private Color logItemSelectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private DebugLogManager manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private float logItemHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private float _1OverLogItemHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private float viewportHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private DebugLogIndexList indicesOfEntriesToShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private int indexOfSelectedLogEntry = int.MaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private float positionOfSelectedLogEntry = float.MaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private float heightOfSelectedLogEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private float deltaHeightOfSelectedLogEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private Dictionary<int, DebugLogItem> logItemsAtIndices = (Dictionary<int, DebugLogItem>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private bool isCollapseOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private int currentTopIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private int currentBottomIndex;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float ItemHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x823CB0", Offset = "0x8226B0", VA = "0x180823CB0")]
			get
			{
				return logItemHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public float SelectedItemHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x1338FA0", Offset = "0x13379A0", VA = "0x181338FA0")]
			get
			{
				return heightOfSelectedLogEntry;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1551DA0", Offset = "0x15507A0", VA = "0x181551DA0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0008
			RectTransform rectTransform = viewportTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1552320", Offset = "0x1550D20", VA = "0x181552320")]
		public void Initialize(DebugLogManager manager, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight)
		{
			//IL_001c: Expected F4, but got I4
			this.manager = manager;
			this.collapsedLogEntries = collapsedLogEntries;
			this.indicesOfEntriesToShow = indicesOfEntriesToShow;
			this.logItemHeight = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1552740", Offset = "0x1551140", VA = "0x181552740")]
		public void SetCollapseMode(bool collapse)
		{
			isCollapseOn = collapse;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1552510", Offset = "0x1550F10", VA = "0x181552510")]
		public void OnLogItemClicked(DebugLogItem item)
		{
			//Discarded unreachable code: IL_00f5
			//IL_0076: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00e2: Expected I4, but got I8
			int entryIndex = item.entryIndex;
			if (indexOfSelectedLogEntry == entryIndex)
			{
				DeselectSelectedLogItem();
			}
			DeselectSelectedLogItem();
			int num = (indexOfSelectedLogEntry = item.entryIndex);
			float num2 = default(float);
			positionOfSelectedLogEntry = num2;
			string content = item.ToString();
			float num3 = item.CalculateExpandedHeight(content);
			DebugLogManager debugLogManager = manager;
			heightOfSelectedLogEntry = num3;
			deltaHeightOfSelectedLogEntry = num3;
			debugLogManager.snapToBottom = false;
			int num4 = indexOfSelectedLogEntry;
			DebugLogItem debugLogItem = (DebugLogItem)((Dictionary<TKey, TValue>)(object)logItemsAtIndices)[(TKey)num4];
			Image image = default(Image);
			Color color2 = (image.color = logItemSelectedColor);
			DebugLogIndexList debugLogIndexList = indicesOfEntriesToShow;
			float b = default(float);
			float num5 = Mathf.Max(1f, b);
			RectTransform rectTransform = transformComponent;
			int num6 = 0;
			rectTransform.sizeDelta = (Vector2)num6;
			int num7 = currentTopIndex;
			if (num7 != -1)
			{
				int bottomIndex = currentBottomIndex;
				DestroyLogItemsBetweenIndices(num7, bottomIndex);
				currentTopIndex = -1;
			}
			UpdateItemsInTheList(updateAllVisibleItemContents: true);
			manager.ValidateScrollPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1552150", Offset = "0x1550B50", VA = "0x181552150")]
		public void DeselectSelectedLogItem()
		{
			//Discarded unreachable code: IL_0066
			//IL_0019: Expected I4, but got I8
			//IL_002b: Expected F4, but got I4
			//IL_0037: Expected O, but got I4
			int num = indexOfSelectedLogEntry;
			int num2 = 0;
			indexOfSelectedLogEntry = int.MaxValue;
			positionOfSelectedLogEntry = float.MaxValue;
			deltaHeightOfSelectedLogEntry = num2;
			DebugLogItem debugLogItem = (DebugLogItem)((Dictionary<TKey, TValue>)(object)logItemsAtIndices)[(TKey)num];
			if (num != indexOfSelectedLogEntry)
			{
				Image imageComponent = debugLogItem.imageComponent;
				if (num == 0)
				{
				}
			}
			Image imageComponent2 = debugLogItem.imageComponent;
			Color color2 = (imageComponent2.color = logItemSelectedColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1552420", Offset = "0x1550E20", VA = "0x181552420")]
		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents)
		{
			//Discarded unreachable code: IL_0068
			//IL_0025: Expected O, but got I4
			//IL_0060: Expected I4, but got I8
			DebugLogIndexList debugLogIndexList = indicesOfEntriesToShow;
			float b = default(float);
			float num = Mathf.Max(1f, b);
			RectTransform rectTransform = transformComponent;
			int num2 = 0;
			rectTransform.sizeDelta = (Vector2)num2;
			RectTransform rectTransform2 = viewportTransform;
			if (updateAllVisibleItemContents)
			{
				int num3 = currentTopIndex;
				if (num3 != -1)
				{
					int bottomIndex = currentBottomIndex;
					DestroyLogItemsBetweenIndices(num3, bottomIndex);
					currentTopIndex = -1;
				}
			}
			UpdateItemsInTheList(updateAllVisibleItemContents);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x15523A0", Offset = "0x1550DA0", VA = "0x1815523A0")]
		public void OnCollapsedLogEntryAtIndexUpdated(int index)
		{
			//Discarded unreachable code: IL_000c
			Dictionary<int, DebugLogItem> dictionary = logItemsAtIndices;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x15526E0", Offset = "0x15510E0", VA = "0x1815526E0")]
		public void OnViewportDimensionsChanged()
		{
			//Discarded unreachable code: IL_0011
			RectTransform rectTransform = viewportTransform;
			int updateAllVisibleItemContents = 0;
			UpdateItemsInTheList((byte)updateAllVisibleItemContents != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x15522E0", Offset = "0x1550CE0", VA = "0x1815522E0")]
		private void HardResetItems()
		{
			//IL_002a: Expected I4, but got I8
			int num = currentTopIndex;
			if (num != -1)
			{
				int bottomIndex = currentBottomIndex;
				DestroyLogItemsBetweenIndices(num, bottomIndex);
				currentTopIndex = -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1551DF0", Offset = "0x15507F0", VA = "0x181551DF0")]
		private void CalculateContentHeight()
		{
			//Discarded unreachable code: IL_0026
			//IL_0025: Expected O, but got I4
			DebugLogIndexList debugLogIndexList = indicesOfEntriesToShow;
			float b = default(float);
			float num = Mathf.Max(1f, b);
			RectTransform rectTransform = transformComponent;
			int num2 = 0;
			rectTransform.sizeDelta = (Vector2)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1552750", Offset = "0x1551150", VA = "0x181552750")]
		public void UpdateItemsInTheList(bool updateAllVisibleItemContents)
		{
			//Discarded unreachable code: IL_003a, IL_006a, IL_0070, IL_0080, IL_0086, IL_0096, IL_00a4, IL_00b2, IL_00c4, IL_00ca, IL_00e6, IL_0116, IL_012d, IL_013d, IL_0148
			//IL_0039: Expected I4, but got I8
			//IL_006e: Invalid comparison between F4 and I4
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected F4, but got Unknown
			//IL_0080: Expected I4, but got F4
			//IL_0084: Invalid comparison between I4 and F4
			//IL_0096: Expected I4, but got F4
			//IL_00a2: Invalid comparison between F4 and I4
			//IL_00ae: Expected I4, but got F4
			//IL_00c4: Expected I4, but got F4
			//IL_00c8: Invalid comparison between I4 and F4
			//IL_00e2: Expected I4, but got F4
			//IL_00fe: Expected I4, but got F4
			//IL_0108: Expected I4, but got F4
			//IL_0116: Expected I4, but got F4
			//IL_0126: Expected I4, but got F4
			if (indicesOfEntriesToShow != null)
			{
				int num = currentTopIndex;
				if (num != -1)
				{
					int bottomIndex = currentBottomIndex;
					DestroyLogItemsBetweenIndices(num, bottomIndex);
					currentTopIndex = -1;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1552000", Offset = "0x1550A00", VA = "0x181552000")]
		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
			//Discarded unreachable code: IL_0050, IL_0054, IL_0055
			DebugLogItem debugLogItem = debugManager.PopLogItem();
			if (topIndex > indexOfSelectedLogEntry)
			{
			}
			RectTransform rectTransform = debugLogItem.transformComponent;
			Image imageComponent = debugLogItem.imageComponent;
			if (topIndex == indexOfSelectedLogEntry || topIndex != 1)
			{
			}
			Color color2 = (imageComponent.color = logItemSelectedColor);
			Dictionary<int, DebugLogItem> dictionary = logItemsAtIndices;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1551EE0", Offset = "0x15508E0", VA = "0x181551EE0")]
		private void CreateLogItemAtIndex(int index)
		{
			//Discarded unreachable code: IL_004e
			//IL_004d: Expected O, but got I4
			DebugLogItem debugLogItem = debugManager.PopLogItem();
			if (index > indexOfSelectedLogEntry)
			{
			}
			RectTransform rectTransform = debugLogItem.transformComponent;
			Image imageComponent = debugLogItem.imageComponent;
			if (index == indexOfSelectedLogEntry || index != 1)
			{
			}
			Color color2 = (imageComponent.color = logItemSelectedColor);
			((Dictionary<TKey, TValue>)(object)logItemsAtIndices)[(TKey)index] = (TValue)debugLogItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1552240", Offset = "0x1550C40", VA = "0x181552240")]
		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			Dictionary<int, DebugLogItem> dictionary = logItemsAtIndices;
			DebugLogManager debugLogManager = debugManager;
			DebugLogItem logItem = (DebugLogItem)((Dictionary<TKey, TValue>)(object)dictionary)[(TKey)topIndex];
			debugLogManager.PoolLogItem(logItem);
			while (topIndex <= bottomIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x15529C0", Offset = "0x15513C0", VA = "0x1815529C0")]
		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1551E60", Offset = "0x1550860", VA = "0x181551E60")]
		private void ColorLogItem(DebugLogItem logItem, int index)
		{
			//Discarded unreachable code: IL_002a
			if (index != indexOfSelectedLogEntry)
			{
				Image imageComponent = logItem.imageComponent;
				if (index == 0)
				{
				}
			}
			Image imageComponent2 = logItem.imageComponent;
			Color color2 = (imageComponent2.color = logItemSelectedColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1552AF0", Offset = "0x15514F0", VA = "0x181552AF0")]
		public DebugLogRecycledListView()
		{
		}//IL_0010: Expected I4, but got I8
		//IL_0031: Expected I4, but got I8

	}
}
