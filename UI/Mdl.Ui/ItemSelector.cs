using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.InputSystem;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B9")]
	[RequiredAllNotNull]
	public class ItemSelector : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D4D")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D4E")]
		[SerializeField]
		private RectTransform _hitRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D4F")]
		[SerializeField]
		[Nulllable]
		private LayoutGroup _listLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D50")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002D51")]
		[SerializeField]
		private InteractionInfoGroup _interactionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002D52")]
		[SerializeField]
		[Header("Position and Size")]
		private bool _adaptSize = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x4002D53")]
		[SerializeField]
		private bool _updatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002D54")]
		[SerializeField]
		private float _maxWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002D55")]
		[SerializeField]
		private float _minYRatio = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4002D56")]
		private int _initialSelectionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002D57")]
		private IItemSelectorItem[] _allItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002D58")]
		private Dictionary<int, Sprite> _itemIcons;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002D59")]
		private Action<int> _onItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002D5A")]
		private IEnumerable<ProfileWorld.FilterInfo> _quests;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002D5B")]
		[SerializeField]
		private AK.Wwise.Event _openGizmoSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002D5C")]
		[SerializeField]
		private AK.Wwise.Event _closeGizmoSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002D5D")]
		[SerializeField]
		private AK.Wwise.Event _selectItemSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002D5E")]
		private FocusNavigation _hudFocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002D5F")]
		private InputAction _inputActionInteractPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002D60")]
		private InputAction _inputActionInteractRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002D61")]
		private bool _canBeTriggered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002D62")]
		private IItemContainer _itemContainer;

		[Cpp2IlInjected.Token(Token = "0x6003153")]
		[Cpp2IlInjected.Address(RVA = "0x1322770", Offset = "0x1321170", VA = "0x181322770")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0017
			//IL_0010: Expected F4, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			canvasGroup.alpha = num;
			InitItemContainer();
		}

		[Cpp2IlInjected.Token(Token = "0x6003154")]
		[Cpp2IlInjected.Address(RVA = "0x1323280", Offset = "0x1321C80", VA = "0x181323280", Slot = "10")]
		public override void Init(GameObject target, IInfoGizmoArgs args, bool followTarget = false, [System.Runtime.InteropServices.Optional] CancellationToken? ct)
		{
			//IL_0093: Expected I4, but got I8
			//IL_00af: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			//IL_01b2: Expected O, but got I8
			int num = 0;
			if (args != null && args != null)
			{
				IInfoGizmoArgs infoGizmoArgs = default(IInfoGizmoArgs);
				_allItems = (IItemSelectorItem[])(object)infoGizmoArgs;
				_itemIcons = (Dictionary<int, Sprite>)infoGizmoArgs;
				_onItemSelected = (Action<int>)(object)infoGizmoArgs;
				IEnumerable<ProfileWorld.FilterInfo> enumerable = (_quests = (IEnumerable<ProfileWorld.FilterInfo>)SystemRoot.Instance.Client.Profile.world_.GetFiltersCropInfo());
				_canvasGroup.alpha = 1f;
				if (_itemContainer != null)
				{
					IItemSelectorItem[] allItems = _allItems;
					IItemSelectorItem[] allItems2 = _allItems;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
				}
				bool flag = default(bool);
				if (flag)
				{
					ulong num3 = default(ulong);
					_interactionInfo.gameObject.SetActive((byte)num3 != 0);
					InteractionInfoGroup interactionInfo = _interactionInfo;
				}
			}
			BubbleAnimation bubbleAnimation = base.bubbleAnimation;
			int num4 = 0;
			if (!(bubbleAnimation != (UnityEngine.Object)num4))
			{
				AK.Wwise.Event openGizmoSfx = _openGizmoSfx;
				GameObject gameObject = base.gameObject;
				uint num5 = openGizmoSfx.Post(gameObject);
				gameObject = (GameObject)(object)((object)gameObject + (object)gameObject);
				num5 += 376;
			}
			Action a = onAnimationComplete;
			Action b = OnAnimationComplete;
			Delegate @delegate = Delegate.Combine(a, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				onAnimationComplete = (Action)@delegate;
				_canBeTriggered = (byte)num != 0;
				InputTriggerPressed trigger = new InputTriggerPressed();
				int num6 = default(int);
				InputActionBool inputActionInteractPress = new InputActionBool("[ A ]", trigger, (InputProvider)num6);
				num6 = 0;
				_inputActionInteractPress = inputActionInteractPress;
				InputTriggerReleased trigger2 = new InputTriggerReleased();
				int num7 = default(int);
				InputActionBool inputActionInteractRelease = new InputActionBool("[ A ]", trigger2, (InputProvider)num7);
				num7 = 0;
				_inputActionInteractRelease = inputActionInteractRelease;
				InputAction inputActionInteractPress2 = _inputActionInteractPress;
				int num8 = 0;
				float deltaTime = Time.deltaTime;
				inputActionInteractPress2.Update(deltaTime);
				if ((_inputActionInteractPress.IsTriggered ? 1 : 0) == num)
				{
					_canBeTriggered = true;
				}
				int num9 = 0;
				ulong num10 = default(ulong);
				((UnityEvent<T0>)(object)UiRoot.Instance.Dispatcher.OnItemSelectorOnOff)?.Invoke((T0)num10);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003155")]
		[Cpp2IlInjected.Address(RVA = "0x1322940", Offset = "0x1321340", VA = "0x181322940", Slot = "12")]
		protected override IInfoGizmoArgs InitArgs(params object[] parameters)
		{
			if (parameters.Length > 2)
			{
				object obj = parameters[1];
				if (obj != null)
				{
					int num = 0;
					if (obj != null)
					{
						object obj2 = parameters[2];
						if (obj2 != null && obj2 != null)
						{
							if ((object)typeof(Action<int>).TypeHandle != null)
							{
								goto IL_0091;
							}
							if ((object)typeof(Action<int>).TypeHandle != null)
							{
								if (_003C_003Ec._003C_003E9__24_1 == null)
								{
									_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AssetReferenceTexture2D texture) => new ItemSelectorItemIcon(texture));
								}
								IEnumerable<AssetReferenceTexture2D> cpp2il__autoParamName__idx_ = default(IEnumerable<AssetReferenceTexture2D>);
								ItemSelectorItemIcon[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<ItemSelectorItemIcon>();
								if (parameters.Length > 3 && parameters[3] != null)
								{
									int num2 = 0;
								}
								if (parameters.Length > 4)
								{
									goto IL_0091;
								}
							}
						}
					}
				}
			}
			goto IL_00e3;
			IL_0091:
			if (_003C_003Ec._003C_003E9__24_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemInstance item) => new ItemSelectorItemInstance(item));
			}
			IEnumerable<ItemInstance> cpp2il__autoParamName__idx_2 = default(IEnumerable<ItemInstance>);
			ItemSelectorItemInstance[] array2 = ((IEnumerable<>)cpp2il__autoParamName__idx_2).ToArray<ItemSelectorItemInstance>();
			if (parameters.Length > 3 && parameters[3] != null)
			{
				int num3 = 0;
			}
			if (parameters.Length > 4 && parameters[4] != null)
			{
				int num4 = 0;
			}
			goto IL_00e3;
			IL_00e3:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003156")]
		[Cpp2IlInjected.Address(RVA = "0x1323A30", Offset = "0x1322430", VA = "0x181323A30")]
		private void OnAnimationComplete()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event openGizmoSfx = _openGizmoSfx;
			GameObject gameObject = base.gameObject;
			uint num = openGizmoSfx.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003157")]
		[Cpp2IlInjected.Address(RVA = "0x1323F60", Offset = "0x1322960", VA = "0x181323F60")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0032
			//IL_0010: Expected O, but got I4
			FocusNavigation hudFocusNavigation = _hudFocusNavigation;
			int num = 0;
			if (hudFocusNavigation == (UnityEngine.Object)num)
			{
				_hudFocusNavigation = focusNavigation;
			}
			if (_itemContainer != null)
			{
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003158")]
		[Cpp2IlInjected.Address(RVA = "0x1324080", Offset = "0x1322A80", VA = "0x181324080")]
		public void SetItemFocus(FocusNavigationElement elementToFocus)
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			FocusNavigation hudFocusNavigation = _hudFocusNavigation;
			int num = 0;
			if (hudFocusNavigation != (UnityEngine.Object)num)
			{
				_hudFocusNavigation.SetFocus(elementToFocus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003159")]
		[Cpp2IlInjected.Address(RVA = "0x13228A0", Offset = "0x13212A0", VA = "0x1813228A0")]
		public void ClearItemFocus(FocusNavigationElement focusElement)
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			FocusNavigation hudFocusNavigation = _hudFocusNavigation;
			int num = 0;
			if (hudFocusNavigation != (UnityEngine.Object)num)
			{
				_hudFocusNavigation.RemoveFocus((ISupportsFocusNavigation)focusElement);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600315A")]
		[Cpp2IlInjected.Address(RVA = "0x13226B0", Offset = "0x13210B0", VA = "0x1813226B0")]
		private void AdaptSize(float width)
		{
			//Discarded unreachable code: IL_0020
			//IL_001f: Expected O, but got I4
			float num = Math.Min(width, width);
			RectTransform rectTransform = _rectTransform;
			int num2 = 0;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			rectTransform.sizeDelta = (Vector2)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600315B")]
		[Cpp2IlInjected.Address(RVA = "0x1323A70", Offset = "0x1322470", VA = "0x181323A70")]
		private void OnDestroy()
		{
			//IL_0030: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_00c8: Expected O, but got I8
			Action source = onAnimationComplete;
			Action value = OnAnimationComplete;
			Delegate @delegate = Delegate.Remove(source, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				onAnimationComplete = (Action)num;
				AK.Wwise.Event closeGizmoSfx = _closeGizmoSfx;
				GameObject gameObject = base.gameObject;
				uint num2 = closeGizmoSfx.Post(gameObject);
				int num3 = 0;
				if (Application.isPlaying)
				{
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					int num4 = 0;
					if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num4)
					{
						int num5 = 0;
						UnityEvent<bool> onItemSelectorOnOff = UiRoot.Instance.Dispatcher.OnItemSelectorOnOff;
						if (onItemSelectorOnOff != null)
						{
							int num6 = 0;
							((UnityEvent<T0>)(object)onItemSelectorOnOff).Invoke((T0)num6);
						}
					}
				}
				if (_itemContainer != null)
				{
					ItemDataDelegate itemDataDelegate = OnListItemData;
					IItemContainer itemContainer = _itemContainer;
					if (new ItemActivatedDelegate(OnListItemTapped) != null)
					{
					}
					_itemContainer = (IItemContainer)0;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600315C")]
		[Cpp2IlInjected.Address(RVA = "0x1323DA0", Offset = "0x13227A0", VA = "0x181323DA0")]
		private unsafe void OnListItemData(GameObject displayObject, int itemIndex, bool selected)
		{
			//Discarded unreachable code: IL_0044
			//IL_001c: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			ItemSelectorItem component = displayObject.GetComponent<ItemSelectorItem>();
			Dictionary<int, Sprite> itemIcons = _itemIcons;
			int num = 0;
			if (itemIcons != null)
			{
				bool flag = ((Dictionary<TKey, TValue>)(object)itemIcons).TryGetValue((TKey)itemIndex, out *(TValue*)num);
			}
			IItemSelectorItem[] allItems = _allItems;
			IEnumerable<ProfileWorld.FilterInfo> quests = _quests;
			IItemSelectorItem itemSelectorItem = allItems[itemIndex];
			component.Refresh(itemSelectorItem, selected, (Sprite)num, (IEnumerable<>)quests);
		}

		[Cpp2IlInjected.Token(Token = "0x600315D")]
		[Cpp2IlInjected.Address(RVA = "0x1323EA0", Offset = "0x13228A0", VA = "0x181323EA0")]
		public void OnListItemTapped(GameObject displayObject, int itemIndex)
		{
			//Discarded unreachable code: IL_003a
			//IL_0039: Expected O, but got I4
			if (_canBeTriggered)
			{
				displayObject.GetComponent<BaseButton>().Bump();
				AK.Wwise.Event selectItemSfx = _selectItemSfx;
				if (selectItemSfx != null)
				{
					uint num = selectItemSfx.Post(displayObject);
				}
				((Action<T>)(object)_onItemSelected)?.Invoke((T)itemIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600315E")]
		[Cpp2IlInjected.Address(RVA = "0x1324120", Offset = "0x1322B20", VA = "0x181324120")]
		internal void Simulate(int maxItems = -1)
		{
			//Discarded unreachable code: IL_00ba
			//IL_00b9: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			IEnumerable<> enumerable = default(IEnumerable<>);
			Action<int> action = default(Action<int>);
			int num2;
			object[] array;
			while (true)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Func<SeedItemData, ItemInstance> _003C_003E9__33_ = _003C_003Ec._003C_003E9__33_0;
				if (_003C_003E9__33_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SeedItemData item)
					{
						//Discarded unreachable code: IL_002d
						//IL_002b: Expected I4, but got I8
						ItemInstance itemInstance = new ItemInstance();
						int num5 = (itemInstance.ItemID = item.ID);
						int num6 = (itemInstance.itemID_ = item.iD_);
						itemInstance.amount_ = 0;
						return itemInstance;
					};
				}
				List<ItemInstance> list = (List<ItemInstance>)(object)Enumerable.ToList<ItemInstance>(Enumerable.Select<SeedItemData, ItemInstance>(enumerable, (Func<, >)(object)_003C_003E9__33_));
				int num = 0;
				List<ItemInstance> range = (List<ItemInstance>)(object)((List<T>)(object)list).GetRange(num, maxItems);
				if (_003C_003Ec._003C_003E9__33_1 == null)
				{
					action = (Action<int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				num2 = 0;
				array = new object[2];
				ItemInstance[] array2 = (ItemInstance[])(object)((List<T>)(object)range).ToArray();
				if (array2 == null || array2 != null)
				{
					array[0] = array2;
					if (action == null || array2 != null)
					{
						break;
					}
				}
			}
			array[1] = action;
			int num3 = 0;
			int num4 = 0;
			((InfoGizmo)this).Init((GameObject)num4, (byte)num3 != 0, (Nullable<>)num2, array);
		}

		[Cpp2IlInjected.Token(Token = "0x600315F")]
		[Cpp2IlInjected.Address(RVA = "0x1323870", Offset = "0x1322270", VA = "0x181323870")]
		private void KeepOnScreen()
		{
			//Discarded unreachable code: IL_0042
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			if (_updatePosition)
			{
				RectTransform rectTransform = _rectTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				RectTransform rectTransform2 = _rectTransform;
				RectTransform rectTransform3 = _rectTransform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003160")]
		[Cpp2IlInjected.Address(RVA = "0x1324590", Offset = "0x1322F90", VA = "0x181324590", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_00f6
			//IL_0068: Expected O, but got F4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected F4, but got Unknown
			float deltaTime;
			InputAction[] array;
			InputAction inputActionInteractRelease;
			do
			{
				base.Update();
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[1];
				inputActionInteractRelease = _inputActionInteractRelease;
			}
			while (inputActionInteractRelease != null && array == null);
			array[0] = inputActionInteractRelease;
			InputAction.UpdateAll(deltaTime, array);
			if (!_canBeTriggered && _inputActionInteractRelease.IsTriggered)
			{
				_canBeTriggered = true;
			}
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			float minYRatio = ((ItemSelector)deltaTime)._minYRatio;
			float num2 = /*Error near IL_0069: Stack underflow*/* minYRatio;
			if (_updatePosition)
			{
				RectTransform rectTransform = _rectTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				if (!(num2 <= deltaTime))
				{
					RectTransform rectTransform2 = _rectTransform;
					RectTransform rectTransform3 = _rectTransform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
				}
			}
			int num3 = 0;
			if (CursorWrapper.Clickable && (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)) && !_hitRect.ContainsMouseCursor())
			{
				int _003C_003E1__state = default(int);
				_003CCancelAsync_003Ed__38 _003CCancelAsync_003Ed__ = new _003CCancelAsync_003Ed__38(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CCancelAsync_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CCancelAsync_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003161")]
		[Cpp2IlInjected.Address(RVA = "0x1324570", Offset = "0x1322F70", VA = "0x181324570", Slot = "17")]
		protected override void UpdatePosition()
		{
			if (_updatePosition)
			{
				base.UpdatePosition();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003162")]
		[Cpp2IlInjected.Address(RVA = "0x1322820", Offset = "0x1321220", VA = "0x181322820")]
		public void Cancel()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CCancelAsync_003Ed__38 _003CCancelAsync_003Ed__ = new _003CCancelAsync_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCancelAsync_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CCancelAsync_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6003163")]
		[Cpp2IlInjected.Address(RVA = "0x13227B0", Offset = "0x13211B0", VA = "0x1813227B0")]
		[IteratorStateMachine(typeof(_003CCancelAsync_003Ed__38))]
		private IEnumerator CancelAsync()
		{
			int _003C_003E1__state = default(int);
			_003CCancelAsync_003Ed__38 _003CCancelAsync_003Ed__ = new _003CCancelAsync_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCancelAsync_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003164")]
		[Cpp2IlInjected.Address(RVA = "0x1322FE0", Offset = "0x13219E0", VA = "0x181322FE0")]
		private void InitItemContainer()
		{
			//Discarded unreachable code: IL_00a5
			//IL_0010: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			LoopScrollRect componentInChildren = GetComponentInChildren<LoopScrollRect>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num && componentInChildren.enabled)
			{
				ItemContainerLoopScrollRectWrapper itemContainerLoopScrollRectWrapper = new ItemContainerLoopScrollRectWrapper(componentInChildren);
				LayoutGroup layoutGroup = (itemContainerLoopScrollRectWrapper.ListLayout = _listLayout);
				Action<float> action = (Action<float>)(object)new Action<T>(AdaptSize);
				itemContainerLoopScrollRectWrapper.add_OnAdaptSize((Action<>)(object)action);
				_itemContainer = itemContainerLoopScrollRectWrapper;
			}
			ItemGrid componentInChildren2 = GetComponentInChildren<ItemGrid>();
			int num2 = 0;
			if (componentInChildren2 != (UnityEngine.Object)num2 && componentInChildren2.enabled)
			{
				_itemContainer = componentInChildren2;
			}
			if (_itemContainer != null)
			{
				ItemDataDelegate itemDataDelegate = OnListItemData;
				IItemContainer itemContainer = _itemContainer;
				ItemActivatedDelegate itemActivatedDelegate = OnListItemTapped;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003165")]
		[Cpp2IlInjected.Address(RVA = "0x1324970", Offset = "0x1323370", VA = "0x181324970")]
		public ItemSelector()
		{
		}
	}
}
