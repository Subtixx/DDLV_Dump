using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using SoftMasking;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000730")]
	public class ItemPreviewUI : ItemPreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400298C")]
		[SerializeField]
		private SoftMask _footerMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400298D")]
		[SerializeField]
		private TextBase _footerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400298E")]
		[SerializeField]
		[Header("Tags config")]
		private ListBase _listBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400298F")]
		[SerializeField]
		private UIAutoScroll _autoScroller;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4002990")]
		[SerializeField]
		private TextBase _ipTextBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4002991")]
		[SerializeField]
		private AsyncAtlassedIcon _ipImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4002992")]
		[SerializeField]
		private TextBgScaler _ipTextBgScaler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4002993")]
		[SerializeField]
		private List<TagItemType> _tagExclusionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4002994")]
		[SerializeField]
		private List<string> _ipsToHide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4002995")]
		[SerializeField]
		protected BubbleAnimation _bubbleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4002996")]
		private List<Item> _itemTagsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4002997")]
		protected Vector3 _renderTargetInitPos;

		[Cpp2IlInjected.Token(Token = "0x6002DAD")]
		[Cpp2IlInjected.Address(RVA = "0x1320520", Offset = "0x131EF20", VA = "0x181320520", Slot = "4")]
		protected unsafe override void Start()
		{
			//Discarded unreachable code: IL_0021
			//IL_001b: Expected native int or pointer, but got O
			base.Start();
			RectTransform renderTargetRT = _renderTargetRT;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_renderTargetInitPos)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAE")]
		[Cpp2IlInjected.Address(RVA = "0x1320100", Offset = "0x131EB00", VA = "0x181320100", Slot = "6")]
		protected override void SetTarget(GameObject target)
		{
			base.SetTarget(target);
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			}
			if (itemType == ItemType.Clothing)
			{
				Item currentItem = _currentItem;
				ClothingItemData clothingItemData = default(ClothingItemData);
				string displayName_ = clothingItemData.displayName_;
				SetFooterText(displayName_);
				List<Item> list = (_itemTagsList = (List<Item>)(object)Enumerable.ToList<Item>(ItemDataExtensions.GetItemTags((IHasTags)clothingItemData)));
				SetupTagList();
				return;
			}
			while (itemType != ItemType.Trimming)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DAF")]
		[Cpp2IlInjected.Address(RVA = "0x1320300", Offset = "0x131ED00", VA = "0x181320300")]
		private void SetupTagList()
		{
			//Discarded unreachable code: IL_008c
			UnityAction<ListBase.ListEventData> unityAction = default(UnityAction<ListBase.ListEventData>);
			((UnityEvent<T0>)(object)_listBase.m_OnItemData).AddListener((UnityAction<>)(object)unityAction);
			List<Item> itemTagsList = _itemTagsList;
			ListBase listBase = _listBase;
			int size = ((List<>)(object)itemTagsList)._size;
			if (listBase._totalCount == size)
			{
				listBase.RefreshCells();
			}
			listBase._totalCount = size;
			if (size != 0)
			{
				int offset = 0;
				listBase.RefillCells(offset);
			}
			listBase.ClearCells();
			ListBase listBase2 = _listBase;
			int offset2 = 0;
			listBase2.RefillCells(offset2);
			_autoScroller?.StartAutoScroll();
			UnityAction<ListBase.ListEventData> unityAction2 = default(UnityAction<ListBase.ListEventData>);
			((UnityEvent<T0>)(object)_listBase.m_OnItemData).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB0")]
		[Cpp2IlInjected.Address(RVA = "0x131FCF0", Offset = "0x131E6F0", VA = "0x18131FCF0", Slot = "15")]
		protected virtual void OnItemDataHandler(ListBase.ListEventData arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB1")]
		[Cpp2IlInjected.Address(RVA = "0x13204E0", Offset = "0x131EEE0", VA = "0x1813204E0", Slot = "7")]
		public override void Show()
		{
			//Discarded unreachable code: IL_001a
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			int num = 0;
			int num2 = 0;
			bubbleAnimation.Show((Action)num2, (Action)num);
			base.Show();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB2")]
		[Cpp2IlInjected.Address(RVA = "0x131FC40", Offset = "0x131E640", VA = "0x18131FC40", Slot = "8")]
		public override void Hide()
		{
			//Discarded unreachable code: IL_0023
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			Action onComplete = delegate
			{
				base.Hide();
			};
			bubbleAnimation.Hide(onComplete);
			_isShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB3")]
		[Cpp2IlInjected.Address(RVA = "0x13200C0", Offset = "0x131EAC0", VA = "0x1813200C0", Slot = "11")]
		public override void SetSquareBottomActive(bool active)
		{
			//Discarded unreachable code: IL_0014
			base.SetSquareBottomActive(active);
			_footerMask.enabled = active;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB4")]
		[Cpp2IlInjected.Address(RVA = "0x1320080", Offset = "0x131EA80", VA = "0x181320080", Slot = "12")]
		public override void SetFooterText(string itemTextID)
		{
			//Discarded unreachable code: IL_0014
			base.SetFooterText(itemTextID);
			_footerText.StringID = itemTextID;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB5")]
		[Cpp2IlInjected.Address(RVA = "0x13204A0", Offset = "0x131EEA0", VA = "0x1813204A0", Slot = "9")]
		public override void ShowFooter()
		{
			//Discarded unreachable code: IL_0018
			((object)this)._002Ector();
			_footerMask.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB6")]
		[Cpp2IlInjected.Address(RVA = "0x131FC00", Offset = "0x131E600", VA = "0x18131FC00", Slot = "10")]
		public override void HideFooter()
		{
			//Discarded unreachable code: IL_001c
			((object)this)._002Ector();
			GameObject gameObject = _footerMask.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB7")]
		[Cpp2IlInjected.Address(RVA = "0x1320580", Offset = "0x131EF80", VA = "0x181320580", Slot = "14")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_0037
			base.Update();
			float z = _renderTargetInitPos.z;
			RectTransform renderTargetRT = _renderTargetRT;
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			int num = 0;
			float z2 = bubbleAnimation.CurrentOffset.z;
			float fixedDeltaTime = Time.fixedDeltaTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB8")]
		[Cpp2IlInjected.Address(RVA = "0x131FCE0", Offset = "0x131E6E0", VA = "0x18131FCE0", Slot = "5")]
		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB9")]
		[Cpp2IlInjected.Address(RVA = "0x1320670", Offset = "0x131F070", VA = "0x181320670")]
		public ItemPreviewUI()
		{
		}
	}
}
