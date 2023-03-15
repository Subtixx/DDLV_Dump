using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200052F")]
	public class HouseExpansionElevatorPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000530")]
		public delegate void OnFloorChangedDelegate(int floor);

		[Cpp2IlInjected.Token(Token = "0x2000531")]
		public delegate void OnFloorAddedDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000532")]
		public delegate void OnFloorPanelColapsedDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000533")]
		public delegate void OnFloorPanelExpandedDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BFA")]
		[SerializeField]
		private ButtonTmProIcon _btnAddFloor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001BFB")]
		[SerializeField]
		private ScrollRect _floorScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001BFC")]
		[SerializeField]
		private RectTransform _floorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001BFD")]
		[SerializeField]
		private AnimatedButton _floorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001BFE")]
		[SerializeField]
		private SpriteAtlasImage _lockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001BFF")]
		[SerializeField]
		private RectTransform _costContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001C00")]
		[SerializeField]
		private TextBase _labelBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001C01")]
		private bool _isConstructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001C02")]
		private AnimatedButton _lastSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001C03")]
		private int _currentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001C04")]
		private bool _canAddFloor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001C05")]
		[SerializeField]
		internal BaseButton btnExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001C06")]
		[SerializeField]
		internal BaseButton btnCollapse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4001C08")]
		public bool IsInAnimation;

		[Cpp2IlInjected.Token(Token = "0x17000540")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x98"), Cpp2IlInjected.Token(Token = "0x4001C07")]
		internal bool isExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60021B0")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0F0", Offset = "0xA8CAF0", VA = "0x180A8E0F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60021B1")]
			[Cpp2IlInjected.Address(RVA = "0xAEDA40", Offset = "0xAEC440", VA = "0x180AEDA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400003C")]
		public event OnFloorChangedDelegate OnFloorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60021A8")]
			[Cpp2IlInjected.Address(RVA = "0xAED5E0", Offset = "0xAEBFE0", VA = "0x180AED5E0")]
			[CompilerGenerated]
			add
			{
				OnFloorChangedDelegate onFloorChanged = this.OnFloorChanged;
				Delegate @delegate = Delegate.Combine(onFloorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021A9")]
			[Cpp2IlInjected.Address(RVA = "0xAED860", Offset = "0xAEC260", VA = "0x180AED860")]
			[CompilerGenerated]
			remove
			{
				OnFloorChangedDelegate onFloorChanged = this.OnFloorChanged;
				Delegate @delegate = Delegate.Remove(onFloorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003D")]
		public event OnFloorAddedDelegate OnFloorAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60021AA")]
			[Cpp2IlInjected.Address(RVA = "0xAED540", Offset = "0xAEBF40", VA = "0x180AED540")]
			[CompilerGenerated]
			add
			{
				OnFloorAddedDelegate onFloorAdded = this.OnFloorAdded;
				Delegate @delegate = Delegate.Combine(onFloorAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021AB")]
			[Cpp2IlInjected.Address(RVA = "0xAED7C0", Offset = "0xAEC1C0", VA = "0x180AED7C0")]
			[CompilerGenerated]
			remove
			{
				OnFloorAddedDelegate onFloorAdded = this.OnFloorAdded;
				Delegate @delegate = Delegate.Remove(onFloorAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003E")]
		public event OnFloorPanelColapsedDelegate OnFloorPanelCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x60021AC")]
			[Cpp2IlInjected.Address(RVA = "0xAED680", Offset = "0xAEC080", VA = "0x180AED680")]
			[CompilerGenerated]
			add
			{
				OnFloorPanelColapsedDelegate onFloorPanelCollapsed = this.OnFloorPanelCollapsed;
				Delegate @delegate = Delegate.Combine(onFloorPanelCollapsed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorPanelCollapsed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021AD")]
			[Cpp2IlInjected.Address(RVA = "0xAED900", Offset = "0xAEC300", VA = "0x180AED900")]
			[CompilerGenerated]
			remove
			{
				OnFloorPanelColapsedDelegate onFloorPanelCollapsed = this.OnFloorPanelCollapsed;
				Delegate @delegate = Delegate.Remove(onFloorPanelCollapsed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorPanelCollapsed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003F")]
		public event OnFloorPanelColapsedDelegate OnFloorPanelExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60021AE")]
			[Cpp2IlInjected.Address(RVA = "0xAED720", Offset = "0xAEC120", VA = "0x180AED720")]
			[CompilerGenerated]
			add
			{
				OnFloorPanelColapsedDelegate onFloorPanelExpanded = this.OnFloorPanelExpanded;
				Delegate @delegate = Delegate.Combine(onFloorPanelExpanded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorPanelExpanded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021AF")]
			[Cpp2IlInjected.Address(RVA = "0xAED9A0", Offset = "0xAEC3A0", VA = "0x180AED9A0")]
			[CompilerGenerated]
			remove
			{
				OnFloorPanelColapsedDelegate onFloorPanelExpanded = this.OnFloorPanelExpanded;
				Delegate @delegate = Delegate.Remove(onFloorPanelExpanded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFloorPanelExpanded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021B2")]
		[Cpp2IlInjected.Address(RVA = "0xAEC400", Offset = "0xAEAE00", VA = "0x180AEC400")]
		public void Init(int numberOfFloorsInTheHouse, int currentFloor, CurrencyCost currencyCost)
		{
			//Discarded unreachable code: IL_01e4, IL_0264, IL_026a, IL_027c
			//IL_00c6: Expected O, but got I4
			//IL_00d8: Expected I4, but got I8
			//IL_00fa: Expected O, but got I4
			//IL_0125: Expected I4, but got I8
			//IL_01c0: Expected O, but got I4
			//IL_0246: Expected I4, but got I8
			//IL_025b: Expected O, but got I4
			int num = 0;
			if (!_isConstructed)
			{
				Construct();
			}
			if (currencyCost == null)
			{
				GameObject gameObject = _btnAddFloor.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = currencyCost.Item;
			AsyncAtlassedIcon currencyIcon = _btnAddFloor._currencyIcon;
			string text = default(string);
			_btnAddFloor.Label.Text = text;
			House playerHouse_ = SystemRoot.Instance.MetaClient.profile.world_.playerHouse_;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			bool flag = (_canAddFloor = playerHouse_.CanAddFloor(world_));
			TextBase labelBtn = _labelBtn;
			RectTransform rectTransform = default(RectTransform);
			if (!flag)
			{
				rectTransform = labelBtn.RectTransform;
				int num2 = 0;
				Vector2 sizeDelta = rectTransform.sizeDelta;
				rectTransform.sizeDelta = (Vector2)num2;
				ulong num3 = default(ulong);
				_lockedIcon.gameObject.SetActive((byte)num3 != 0);
				GameObject gameObject2 = _costContent.gameObject;
			}
			int num4 = 0;
			Vector2 sizeDelta2 = rectTransform.sizeDelta;
			rectTransform.sizeDelta = (Vector2)num4;
			GameObject gameObject3 = _lockedIcon.gameObject;
			int active2 = 0;
			gameObject3.SetActive((byte)active2 != 0);
			ulong num5 = default(ulong);
			_costContent.gameObject.SetActive((byte)num5 != 0);
			_btnAddFloor.AnimatedContent.RebuildLayout();
			IEnumerator enumerator = _floorContent.GetEnumerator();
			uint num6 = default(uint);
			if (num < (int)num6)
			{
				num += num;
				num++;
			}
			GameObject gameObject4 = default(GameObject);
			if (enumerator != null)
			{
				uint num7 = default(uint);
				if (num < (int)num7)
				{
					num += num;
					num++;
				}
				num += 312;
				num += 328;
				int num8 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num9 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject4);
			}
			int num10 = 0;
			uint num11 = default(uint);
			if ((object)gameObject4 != null && num10 < (int)num11)
			{
				num10 += num10;
				num10++;
			}
			num10 += 312;
			HouseExpansionElevatorPanel houseExpansionElevatorPanel = (HouseExpansionElevatorPanel)0;
			AnimatedButton animatedButton = default(AnimatedButton);
			AnimatedButton floor = animatedButton;
			TextBase label = floor.Label;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021B3")]
		[Cpp2IlInjected.Address(RVA = "0xAEC310", Offset = "0xAEAD10", VA = "0x180AEC310")]
		private void FloorClickedHandler(AnimatedButton floorButton, int floorIndex)
		{
			//Discarded unreachable code: IL_0047
			//IL_0010: Expected O, but got I4
			AnimatedButton lastSelected = _lastSelected;
			int num = 0;
			if (lastSelected != (UnityEngine.Object)num)
			{
				AnimatedButton lastSelected2 = _lastSelected;
				int num2 = ((lastSelected2.isSelected = false) ? 1 : 0);
			}
			floorButton.isSelected = true;
			_lastSelected = floorButton;
			this.OnFloorChanged?.Invoke(floorIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60021B4")]
		[Cpp2IlInjected.Address(RVA = "0xAEC0D0", Offset = "0xAEAAD0", VA = "0x180AEC0D0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_00b9
			Button.ButtonClickedEvent onClick = _btnAddFloor.ButtonComponent.m_OnClick;
			UnityAction call = OnAddFloorClickedHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = btnExpand.ButtonComponent.m_OnClick;
			UnityAction call2 = OnExpandFloorClickedHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = btnCollapse.ButtonComponent.m_OnClick;
			UnityAction call3 = OnCollapseFloorClickedHandler;
			onClick3.AddListener(call3);
			BaseButton baseButton = btnExpand;
			BaseButton.OnBaseButtonPress value = OnPress;
			baseButton.OnPress += value;
			BaseButton baseButton2 = btnExpand;
			BaseButton.OnBaseButtonRelease value2 = OnRelease;
			baseButton2.OnRelease += value2;
			_isConstructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B5")]
		[Cpp2IlInjected.Address(RVA = "0xAECF30", Offset = "0xAEB930", VA = "0x180AECF30")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00b2
			Button.ButtonClickedEvent onClick = _btnAddFloor.ButtonComponent.m_OnClick;
			UnityAction call = OnAddFloorClickedHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = btnExpand.ButtonComponent.m_OnClick;
			UnityAction call2 = OnExpandFloorClickedHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = btnCollapse.ButtonComponent.m_OnClick;
			UnityAction call3 = OnCollapseFloorClickedHandler;
			onClick3.RemoveListener(call3);
			BaseButton baseButton = btnExpand;
			BaseButton.OnBaseButtonPress value = OnPress;
			baseButton.OnPress -= value;
			BaseButton baseButton2 = btnExpand;
			BaseButton.OnBaseButtonRelease value2 = OnRelease;
			baseButton2.OnRelease -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B6")]
		[Cpp2IlInjected.Address(RVA = "0xAECE30", Offset = "0xAEB830", VA = "0x180AECE30")]
		private void OnAddFloorClickedHandler()
		{
			//Discarded unreachable code: IL_003f
			//IL_003e: Expected I4, but got I8
			if (_canAddFloor)
			{
				this.OnFloorAdded?.Invoke();
				return;
			}
			int num = 0;
			GenericAlert genericAlert = UiRoot.Instance._genericAlert;
			int showCloseButton = 0;
			ulong num2 = default(ulong);
			genericAlert.Alert("menu.cannot_add_room_need_upgrade", "", (byte)showCloseButton != 0, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60021B7")]
		[Cpp2IlInjected.Address(RVA = "0xAED170", Offset = "0xAEBB70", VA = "0x180AED170")]
		private void OnExpandFloorClickedHandler()
		{
			//Discarded unreachable code: IL_0036
			if (btnExpand.gameObject.activeInHierarchy && !IsInAnimation)
			{
				OnFloorPanelColapsedDelegate onFloorPanelExpanded = this.OnFloorPanelExpanded;
				isExpanded = true;
				onFloorPanelExpanded?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021B8")]
		[Cpp2IlInjected.Address(RVA = "0xAECED0", Offset = "0xAEB8D0", VA = "0x180AECED0")]
		private void OnCollapseFloorClickedHandler()
		{
			//Discarded unreachable code: IL_0036
			if (btnCollapse.gameObject.activeInHierarchy && !IsInAnimation)
			{
				OnFloorPanelColapsedDelegate onFloorPanelCollapsed = this.OnFloorPanelCollapsed;
				isExpanded = false;
				onFloorPanelCollapsed?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021B9")]
		[Cpp2IlInjected.Address(RVA = "0xAED330", Offset = "0xAEBD30", VA = "0x180AED330")]
		public void SetFocus(FocusNavigation focus)
		{
			//IL_005d: Expected O, but got I4
			if (!_floorScroll.gameObject.activeSelf || _floorScroll.m_Content.childCount <= 0)
			{
				return;
			}
			if (focus._focusedElement == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Transform parent = base.transform;
				Transform transform = default(Transform);
				if (transform.IsChildOf(parent))
				{
					return;
				}
			}
			AnimatedButton lastSelected = _lastSelected;
			int num2 = 0;
			if (!(lastSelected != (UnityEngine.Object)num2))
			{
				RectTransform content = _floorScroll.m_Content;
				int index = 0;
				Transform child = content.GetChild(index);
				FocusNavigationElement component = default(FocusNavigationElement);
				if ((object)child != null)
				{
					component = child.GetComponent<FocusNavigationElement>();
				}
				focus.SetFocus(component);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BA")]
		[Cpp2IlInjected.Address(RVA = "0xAED1D0", Offset = "0xAEBBD0", VA = "0x180AED1D0")]
		private void OnPress(BaseButton btn)
		{
			//Discarded unreachable code: IL_001f
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)btn.AnimatedContent, 0.9f, 0.2f)).SetEase(Ease.OutCubic);
		}

		[Cpp2IlInjected.Token(Token = "0x60021BB")]
		[Cpp2IlInjected.Address(RVA = "0xAED240", Offset = "0xAEBC40", VA = "0x180AED240")]
		private void OnRelease(BaseButton btn)
		{
			//Discarded unreachable code: IL_001f
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)btn.AnimatedContent, 1f, 0.5f)).SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x60021BC")]
		[Cpp2IlInjected.Address(RVA = "0xAED2B0", Offset = "0xAEBCB0", VA = "0x180AED2B0")]
		[IteratorStateMachine(typeof(_003CRebuildLayout_003Ed__44))]
		private IEnumerator RebuildLayout(bool snapScroller)
		{
			int _003C_003E1__state = default(int);
			_003CRebuildLayout_003Ed__44 _003CRebuildLayout_003Ed__ = new _003CRebuildLayout_003Ed__44(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRebuildLayout_003Ed__._003C_003E4__this = this;
			_003CRebuildLayout_003Ed__.snapScroller = snapScroller;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HouseExpansionElevatorPanel()
		{
		}
	}
}
