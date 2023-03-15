using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000343")]
	public class MemoryShardsPopUp : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000F47")]
		private List<CollectionItemModel> _itemModels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000F48")]
		private CollectionItemModel _targetItemModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000F49")]
		private int AnimatePiece;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000F4A")]
		[SerializeField]
		public ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000F4B")]
		[SerializeField]
		public RectTransform _memories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000F4C")]
		[SerializeField]
		public GameObject _prefabMemoryShards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000F4D")]
		[SerializeField]
		public CollectionMemoryShards _shardDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000F4E")]
		[SerializeField]
		public TextBase _desctriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000F4F")]
		[SerializeField]
		public GameObject _descriptionContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000F50")]
		[SerializeField]
		private TextBase _shortcutLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000F51")]
		[SerializeField]
		private string _backStringId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000F52")]
		[SerializeField]
		private string _closeStringId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000F53")]
		[SerializeField]
		private HorizontalLayoutGroup _shortcutLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000F54")]
		[SerializeField]
		private float _xPosForPopup = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000F55")]
		[SerializeField]
		private float _yPosForPopup = 14f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000F56")]
		[SerializeField]
		private RectTransform _shortcutRootRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000F57")]
		private RectTransform _originalShortcutrootRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000F58")]
		private bool _isPopupOnItsOwn;

		[Cpp2IlInjected.Token(Token = "0x6001483")]
		[Cpp2IlInjected.Address(RVA = "0x118CFE0", Offset = "0x118B9E0", VA = "0x18118CFE0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0091: Expected I4, but got O
			//IL_00b4: Expected I4, but got O
			base.OnPush(stack, param);
			UnityEvent onDisplayRefresh = _shardDisplay.OnDisplayRefresh;
			UnityAction call = RefreshText;
			onDisplayRefresh.AddListener(call);
			if (param == null)
			{
				return;
			}
			object[] @params = param.Params;
			if (@params != null)
			{
				int length = @params.Length;
				object obj = @params[0];
				if (obj == null)
				{
				}
				int num = 0;
				_itemModels = (List<CollectionItemModel>)obj;
				object obj2 = param.Params[1];
				if (obj2 != null)
				{
					int num2 = 0;
				}
				_targetItemModel = (CollectionItemModel)obj2;
				object obj3 = param.Params[2];
				AnimatePiece = (int)obj3;
				object[] params2 = param.Params;
				int length2 = params2.Length;
				object obj4 = params2[3];
				_isPopupOnItsOwn = (byte)(int)obj4 != 0;
				TextBase shortcutLabel = _shortcutLabel;
				if (_isPopupOnItsOwn)
				{
				}
				string text = (shortcutLabel.StringID = _backStringId);
				_shortcutLayout.spacing = 1.4E-44f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001484")]
		[Cpp2IlInjected.Address(RVA = "0x118CDB0", Offset = "0x118B7B0", VA = "0x18118CDB0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0060
			base.OnFocusIn();
			if (_isPopupOnItsOwn)
			{
				RectTransform rectTransform = (_originalShortcutrootRT = _shortcutRootRT);
				RectTransform shortcutRootRT = _shortcutRootRT;
				float xPosForPopup = _xPosForPopup;
				float yPosForPopup = _yPosForPopup;
			}
			RefreshDisplay();
			((Menu)this).IsDataUpToDate = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001485")]
		[Cpp2IlInjected.Address(RVA = "0x118CE70", Offset = "0x118B870", VA = "0x18118CE70", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001486")]
		[Cpp2IlInjected.Address(RVA = "0x118CEC0", Offset = "0x118B8C0", VA = "0x18118CEC0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0053
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I8
			RectTransform originalShortcutrootRT = _originalShortcutrootRT;
			int num = 0;
			if (originalShortcutrootRT != (UnityEngine.Object)num)
			{
				RectTransform rectTransform = (_shortcutRootRT = _originalShortcutrootRT);
				_originalShortcutrootRT = (RectTransform)0;
			}
			UnityEvent onDisplayRefresh = _shardDisplay.OnDisplayRefresh;
			UnityAction call = RefreshText;
			onDisplayRefresh.RemoveListener(call);
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001487")]
		[Cpp2IlInjected.Address(RVA = "0x118D300", Offset = "0x118BD00", VA = "0x18118D300")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00c4
			//IL_00c3: Expected I4, but got I8
			int animatePiece = AnimatePiece;
			_shardDisplay.PieceToReveal = animatePiece;
			CollectionMemoryShards shardDisplay = _shardDisplay;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)_targetItemModel).ItemData;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
			shardDisplay.MemoryShardItemData = memoryShardItemData;
			_shardDisplay.RefreshDisplay();
			GameObject descriptionContainer = _descriptionContainer;
			int active = 0;
			descriptionContainer.SetActive((byte)active != 0);
			MemoryShardItemData memoryShardItemData2 = _shardDisplay._memoryShardItemData;
			TextBase desctriptionText = _desctriptionText;
			string text = (desctriptionText.StringID = memoryShardItemData2.descriptionText_);
			if (_shardDisplay.IsCompleted && !string.IsNullOrEmpty(_shardDisplay._memoryShardItemData.descriptionText_))
			{
				ulong num3 = default(ulong);
				_descriptionContainer.SetActive((byte)num3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001488")]
		[Cpp2IlInjected.Address(RVA = "0x118D590", Offset = "0x118BF90", VA = "0x18118D590")]
		private void RefreshText()
		{
			//Discarded unreachable code: IL_0067
			GameObject descriptionContainer = _descriptionContainer;
			int active = 0;
			descriptionContainer.SetActive((byte)active != 0);
			MemoryShardItemData memoryShardItemData = _shardDisplay._memoryShardItemData;
			TextBase desctriptionText = _desctriptionText;
			string text = (desctriptionText.StringID = memoryShardItemData.descriptionText_);
			if (_shardDisplay.IsCompleted && !string.IsNullOrEmpty(_shardDisplay._memoryShardItemData.descriptionText_))
			{
				_descriptionContainer.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001489")]
		[Cpp2IlInjected.Address(RVA = "0x118D650", Offset = "0x118C050", VA = "0x18118D650")]
		public void ScrollTo(int index, float duration = 0.25f)
		{
			//Discarded unreachable code: IL_00ae
			//IL_008d: Expected O, but got I4
			if (index <= -1)
			{
				return;
			}
			int childCount = _memories.childCount;
			int num = 0;
			int num2 = 0;
			if (index < childCount)
			{
				Transform parent = _memories.parent;
				Transform child = _memories.GetChild(index);
				if ((object)parent != null)
				{
				}
				if ((object)child == null)
				{
				}
			}
			Vector2 anchoredPosition = _memories.anchoredPosition;
			Vector2 anchoredPosition2 = _memories.anchoredPosition;
			TweenMax.KillAllByCancelationToken(_memories.gameObject);
			GameObject target = _memories.gameObject;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			TweenLiteArgs tweenLiteArgs = default(TweenLiteArgs);
			tweenLiteArgs.Position = (Vector3?)(object)num7;
			GameObject cancellationToken = _memories.gameObject;
			TweenLite tweenLite = TweenLite.To(target, duration, tweenLiteArgs, int.MinValue, cancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600148A")]
		[Cpp2IlInjected.Address(RVA = "0x118CC40", Offset = "0x118B640", VA = "0x18118CC40")]
		private float GetDistanceFromCenter(int childIndex)
		{
			int childCount = _memories.childCount;
			if (childIndex < childCount)
			{
				Transform parent = _memories.parent;
				Transform child = _memories.GetChild(childIndex);
				if ((object)parent != null)
				{
				}
				if ((object)child == null)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600148B")]
		[Cpp2IlInjected.Address(RVA = "0x118CD60", Offset = "0x118B760", VA = "0x18118CD60", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600148C")]
		[Cpp2IlInjected.Address(RVA = "0x118DA60", Offset = "0x118C460", VA = "0x18118DA60")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_001f
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			CollectionMemoryShards currentMemoryShards = GetCurrentMemoryShards();
			if ((object)currentMemoryShards != null)
			{
				FocusNavigationElement component = currentMemoryShards.GetComponent<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600148D")]
		[Cpp2IlInjected.Address(RVA = "0x118C900", Offset = "0x118B300", VA = "0x18118C900")]
		private CollectionMemoryShards GetCurrentMemoryShards()
		{
			//Discarded unreachable code: IL_004f, IL_0055, IL_005b, IL_0061, IL_006d
			uint num3 = default(uint);
			GameObject gameObject = default(GameObject);
			CollectionMemoryShards collectionMemoryShards = default(CollectionMemoryShards);
			Vector2 vector = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				Transform parent = _memories.parent;
				IEnumerator enumerator = _memories.GetEnumerator();
				if (enumerator != null)
				{
					if (num2 < (int)num3)
					{
						num2 += num2;
						num2++;
					}
					int num4 = 0;
					if (enumerator == null)
					{
						break;
					}
					if (!gameObject.activeSelf)
					{
						continue;
					}
					if ((object)parent == null)
					{
					}
				}
				if ((object)collectionMemoryShards != null)
				{
				}
				if ((object)vector == null)
				{
					return collectionMemoryShards;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600148E")]
		[Cpp2IlInjected.Address(RVA = "0x118CD20", Offset = "0x118B720", VA = "0x18118CD20", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if ((redirectionType > RedirectionType.GamePromptClose && redirectionType == RedirectionType.GamePromptGoBackward) || redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePromptClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600148F")]
		[Cpp2IlInjected.Address(RVA = "0x118DAF0", Offset = "0x118C4F0", VA = "0x18118DAF0")]
		public MemoryShardsPopUp()
		{
		}
	}
}
