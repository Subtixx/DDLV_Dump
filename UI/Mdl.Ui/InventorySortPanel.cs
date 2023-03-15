using System;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005DC")]
	public class InventorySortPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020A5")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020A6")]
		[SerializeField]
		private FocusNavigationElement _firstChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020A7")]
		public Action OnClosed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40020A9")]
		private uint _storageID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40020AA")]
		private BaseButton[] _buttons;

		[Cpp2IlInjected.Token(Token = "0x170005E1")]
		public RectTransform ContentRectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6002682")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _rectTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40020A8")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6002683")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002684")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002685")]
		[Cpp2IlInjected.Address(RVA = "0xD31970", Offset = "0xD30370", VA = "0x180D31970")]
		public void Awake()
		{
			RectTransform rectTransform = (_rectTransform = GetComponent<RectTransform>());
			BaseButton[] array = (_buttons = base.gameObject.GetComponentsInChildren<BaseButton>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002686")]
		[Cpp2IlInjected.Address(RVA = "0xD31B50", Offset = "0xD30550", VA = "0x180D31B50")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_001b
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				FocusNavigationElement firstChild = _firstChild;
				focusNavigation.SetFocus(firstChild);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002687")]
		[Cpp2IlInjected.Address(RVA = "0xD31AF0", Offset = "0xD304F0", VA = "0x180D31AF0")]
		public void Open(uint storageId)
		{
			//Discarded unreachable code: IL_002d
			if (base.enabled && !IsOpen)
			{
				base.gameObject.SetActive(value: true);
				_storageID = storageId;
				IsOpen = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002688")]
		[Cpp2IlInjected.Address(RVA = "0xD31A00", Offset = "0xD30400", VA = "0x180D31A00")]
		public void Close()
		{
			//Discarded unreachable code: IL_005f
			if (!IsOpen)
			{
				return;
			}
			BaseButton[] buttons = _buttons;
			if (buttons != null)
			{
				int num = 0;
				int length = buttons.Length;
				if (num < length)
				{
					buttons[num].OnHighlightExit();
					num++;
				}
			}
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Action onClosed = OnClosed;
			IsOpen = false;
			onClosed?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002689")]
		[Cpp2IlInjected.Address(RVA = "0xD31AC0", Offset = "0xD304C0", VA = "0x180D31AC0")]
		public void OnSortByName()
		{
			int algorithm = 0;
			SortInventory((SortContainerInventory.Types.SortAlgorithm)algorithm);
		}

		[Cpp2IlInjected.Token(Token = "0x600268A")]
		[Cpp2IlInjected.Address(RVA = "0xD31AD0", Offset = "0xD304D0", VA = "0x180D31AD0")]
		public void OnSortByType()
		{
			SortInventory(SortContainerInventory.Types.SortAlgorithm.ByType);
		}

		[Cpp2IlInjected.Token(Token = "0x600268B")]
		[Cpp2IlInjected.Address(RVA = "0xD31AB0", Offset = "0xD304B0", VA = "0x180D31AB0")]
		public void OnSortByMana()
		{
			SortInventory(SortContainerInventory.Types.SortAlgorithm.ByMana);
		}

		[Cpp2IlInjected.Token(Token = "0x600268C")]
		[Cpp2IlInjected.Address(RVA = "0xD31AE0", Offset = "0xD304E0", VA = "0x180D31AE0")]
		public void OnSortByValue()
		{
			SortInventory(SortContainerInventory.Types.SortAlgorithm.BySellPrice);
		}

		[Cpp2IlInjected.Token(Token = "0x600268D")]
		[Cpp2IlInjected.Address(RVA = "0xD31BE0", Offset = "0xD305E0", VA = "0x180D31BE0")]
		private void SortInventory(SortContainerInventory.Types.SortAlgorithm algorithm)
		{
			//Discarded unreachable code: IL_0040
			//IL_0034: Expected O, but got I4
			SortContainerInventory.Types.Request request = new SortContainerInventory.Types.Request();
			uint num = (request.containerInventoryID_ = _storageID);
			request.algorithm_ = algorithm;
			Client metaClient = SystemRoot.Instance.MetaClient;
			int num2 = 0;
			metaClient.SortContainerInventory(request, (CancellationToken)num2).FireAndForgetTask();
			Close();
		}

		[Cpp2IlInjected.Token(Token = "0x600268E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InventorySortPanel()
		{
		}
	}
}
