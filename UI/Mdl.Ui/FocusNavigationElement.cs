using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	public class FocusNavigationElement : MonoBehaviour, ISupportsFocusNavigation, ISelectHandler, IEventSystemHandler, IDeselectHandler, IUpdateSelectedHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A58")]
		public GameObject Highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A59")]
		public BaseButton BaseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A5A")]
		public BaseButton InfoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A5B")]
		public TemplateButton ClickButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A5C")]
		public LayoutGroup LayoutGroup;

		[Cpp2IlInjected.Token(Token = "0x4000A5D")]
		[Header("Scroll Settings")]
		public static bool IsScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000A5E")]
		public ScrollRect ScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000A5F")]
		public LoopVerticalScrollRect LoopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000A60")]
		public float VerticalScrollMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000A61")]
		public float HorizontalScrollMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000A62")]
		public UnityEvent<int> OnScrollToCellCallBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000A64")]
		private float _scrollSpeed = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000A65")]
		[Header("Free Container")]
		public Transform FreeContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000A66")]
		[Range(0f, 43f)]
		public float FreeContainerRangeLeftOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000A67")]
		[Range(0f, 43f)]
		public float FreeContainerRangeRightOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000A68")]
		[Range(-43f, 43f)]
		public float FreeContainerRangeUpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000A69")]
		[Range(-43f, 43f)]
		public float FreeContainerRangeDownOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000A6A")]
		public float FreeContainerMaxDistance = 800f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000A6B")]
		public Transform FreeContainerAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000A6C")]
		public List<FocusDirection> UseAnchorWithDirection = (List<FocusDirection>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000A6D")]
		[Space]
		public bool ForceNoCheckParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000A6E")]
		public FocusNavigationElement[] Links = new FocusNavigationElement[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000A6F")]
		public bool AllowsAltAxis = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000A70")]
		public bool IgnoreThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x4000A71")]
		public bool ListIsInverted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x4000A72")]
		[Tooltip("Whether this gameobject is a child of the actual item we want to focus on.")]
		public bool IsChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000A73")]
		public UnityEvent<FocusDirection, int, FocusNavigationElement, ISupportsFocusNavigation> CustomFindNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000A75")]
		public UnityEvent OnControllerFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000A76")]
		private MenuNavigation _menuNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000A77")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4000A63")]
		public bool UsetAltLogicForScrolling
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA2")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000EA3")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB8"), Cpp2IlInjected.Token(Token = "0x4000A74")]
		public bool CustomFocusHandled
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA4")]
			[Cpp2IlInjected.Address(RVA = "0x12E8630", Offset = "0x12E7030", VA = "0x1812E8630")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000EA5")]
			[Cpp2IlInjected.Address(RVA = "0x12E87B0", Offset = "0x12E71B0", VA = "0x1812E87B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		public FocusNavigation FocusNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0x1668840", Offset = "0x1667240", VA = "0x181668840")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_002a: Expected O, but got I4
				FocusNavigation focusNavigation = _focusNavigation;
				int num = 0;
				if (focusNavigation != (UnityEngine.Object)num)
				{
					return _focusNavigation;
				}
				MenuNavigation menuNavigation = _menuNavigation;
				int num2 = 0;
				if (menuNavigation != (UnityEngine.Object)num2)
				{
					return _menuNavigation.FocusNavigation;
				}
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				if ((object)instance != null)
				{
					int num4 = 0;
					IMenu menuOnTop = instance.MenuOnTop;
					if (menuOnTop != null)
					{
						int num5 = 0;
						FocusNavigation result = default(FocusNavigation);
						if (menuOnTop != null)
						{
							return result;
						}
					}
				}
				int num6 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		public bool IsInFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0x16689A0", Offset = "0x16673A0", VA = "0x1816689A0")]
			get
			{
				//Discarded unreachable code: IL_0032
				//IL_0010: Expected O, but got I4
				//IL_002c: Expected O, but got I4
				FocusNavigation focusNavigation = FocusNavigation;
				int num = 0;
				bool flag = focusNavigation != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				if (FocusNavigation._focusedElement == null)
				{
					return (UnityEngine.Object)0 == this;
				}
				int num2 = 0;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA8")]
		[Cpp2IlInjected.Address(RVA = "0x1663850", Offset = "0x1662250", VA = "0x181663850", Slot = "12")]
		protected virtual void Awake()
		{
			//IL_001e: Expected O, but got I4
			FocusNavigation focusNavigation = (_focusNavigation = GetComponentInParent<FocusNavigation>());
			FocusNavigation focusNavigation2 = _focusNavigation;
			int num = 0;
			if (focusNavigation2 == (UnityEngine.Object)num)
			{
				MenuNavigation menuNavigation = (_menuNavigation = GetComponentInParent<MenuNavigation>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0x16686B0", Offset = "0x16670B0", VA = "0x1816686B0", Slot = "13")]
		protected virtual void Start()
		{
			//Discarded unreachable code: IL_0027
			//IL_0010: Expected O, but got I4
			Selectable component = GetComponent<Selectable>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				UnityEngine.UI.Navigation navigation = component.m_Navigation;
				Selectable selectOnDown = component.m_Navigation.m_SelectOnDown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAA")]
		[Cpp2IlInjected.Address(RVA = "0x1667E00", Offset = "0x1666800", VA = "0x181667E00", Slot = "14")]
		protected virtual void OnEnable()
		{
			//IL_0010: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			LayoutGroup layoutGroup = LayoutGroup;
			int num = 0;
			bool flag = layoutGroup == (UnityEngine.Object)num;
			int num2 = 0;
			if (flag)
			{
				Transform freeContainer = FreeContainer;
				int num3 = 0;
				if (freeContainer == (UnityEngine.Object)num3 && (ForceNoCheckParent ? 1 : 0) == num2)
				{
					Transform transform = base.transform;
					if ((object)transform != null)
					{
						Transform parent = transform.parent;
						if ((object)parent != null)
						{
							LayoutGroup component = parent.GetComponent<LayoutGroup>();
						}
					}
					LayoutGroup = (LayoutGroup)num2;
				}
			}
			BaseButton baseButton = BaseButton;
			int num4 = 0;
			if (baseButton == (UnityEngine.Object)num4)
			{
				Transform transform2 = base.transform;
				BaseButton componentInChildren = default(BaseButton);
				if ((object)transform2 != null)
				{
					componentInChildren = transform2.GetComponentInChildren<BaseButton>();
				}
				BaseButton = componentInChildren;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
		protected virtual void OnDisable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAC")]
		[Cpp2IlInjected.Address(RVA = "0x1668090", Offset = "0x1666A90", VA = "0x181668090", Slot = "9")]
		public void OnSelect(BaseEventData eventData)
		{
			//Discarded unreachable code: IL_0032
			//IL_0019: Expected O, but got I4
			if (!IsInFocus)
			{
				FocusNavigation focusNavigation = FocusNavigation;
				int num = 0;
				if (!(focusNavigation != (UnityEngine.Object)num))
				{
					ContextStack context = ((IDesignerSerializationManager)this).Context;
				}
				else
				{
					FocusNavigation.SetFocus((ISupportsFocusNavigation)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAD")]
		[Cpp2IlInjected.Address(RVA = "0x1667CF0", Offset = "0x16666F0", VA = "0x181667CF0", Slot = "10")]
		public void OnDeselect(BaseEventData eventData)
		{
			//Discarded unreachable code: IL_0053
			//IL_0019: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			if (!IsInFocus)
			{
				return;
			}
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (!(focusNavigation != (UnityEngine.Object)num))
			{
				RemoveFocus();
				return;
			}
			FocusNavigation focusNavigation2 = FocusNavigation;
			ISupportsFocusNavigation focusedElement = default(ISupportsFocusNavigation);
			if ((object)this == null)
			{
				focusedElement = focusNavigation2._focusedElement;
			}
			ISupportsFocusNavigation focusedElement2 = focusNavigation2._focusedElement;
			while (focusedElement2 == null)
			{
			}
			while (focusedElement2 != focusedElement)
			{
			}
			int num2 = 0;
			focusNavigation2.FocusedElement = (ISupportsFocusNavigation)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0x1668150", Offset = "0x1666B50", VA = "0x181668150", Slot = "11")]
		public void OnUpdateSelected(BaseEventData eventData)
		{
			//Discarded unreachable code: IL_0028
			//IL_0010: Expected O, but got I4
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num && FocusNavigation.ProcessOnFocusUpdate())
			{
				eventData.Use();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAF")]
		[Cpp2IlInjected.Address(RVA = "0x16654A0", Offset = "0x1663EA0", VA = "0x1816654A0")]
		[IteratorStateMachine(typeof(_003CFindNextOverrides_003Ed__49))]
		private IEnumerable<IFocusNavigationOverrideFindNext> FindNextOverrides(GameObject gameObject)
		{
			new _003CFindNextOverrides_003Ed__49(-2)._003C_003E3__gameObject = gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB0")]
		[Cpp2IlInjected.Address(RVA = "0x1665510", Offset = "0x1663F10", VA = "0x181665510")]
		private IEnumerable<IFocusNavigationOverrideFindNext> FindNextOverrides(Component component)
		{
			//IL_0009: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				GameObject gameObject = component.gameObject;
			}
			int num2 = 0;
			new _003CFindNextOverrides_003Ed__49(-2)._003C_003E3__gameObject = (GameObject)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0x16655F0", Offset = "0x1663FF0", VA = "0x1816655F0")]
		[IteratorStateMachine(typeof(_003CFindNextOverrides_003Ed__51))]
		private IEnumerable<IFocusNavigationOverrideFindNext> FindNextOverrides()
		{
			new _003CFindNextOverrides_003Ed__51(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB2")]
		[Cpp2IlInjected.Address(RVA = "0x1665660", Offset = "0x1664060", VA = "0x181665660", Slot = "16")]
		public virtual ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//IL_0023: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_012c: Expected O, but got I4
			//IL_016a: Expected O, but got I4
			//IL_017c: Expected O, but got I4
			//IL_0193: Expected O, but got I4
			//IL_0262: Expected O, but got I4
			//IL_02ab: Expected O, but got I4
			//IL_033b: Expected O, but got I4
			//IL_0370: Expected F4, but got I4
			//IL_037c: Expected F4, but got I4
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Expected I4, but got Unknown
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected I4, but got Unknown
			uint num4 = default(uint);
			Transform transform = default(Transform);
			Transform transform2 = default(Transform);
			Transform child2 = default(Transform);
			int num16 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			bool flag = default(bool);
			int num21 = default(int);
			int num22 = default(int);
			int num23 = default(int);
			int num24 = default(int);
			bool flag2 = default(bool);
			Transform transform3 = default(Transform);
			Transform transform4 = default(Transform);
			bool flag3 = default(bool);
			int num28 = default(int);
			int num32 = default(int);
			Transform transform5 = default(Transform);
			bool flag4 = default(bool);
			int num34 = default(int);
			int num35 = default(int);
			int num37 = default(int);
			uint num42 = default(uint);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			int num30 = default(int);
			int num45 = default(int);
			int num47 = default(int);
			int num46 = default(int);
			int num49 = default(int);
			Transform transform6 = default(Transform);
			int num52 = default(int);
			while (true)
			{
				int num = (int)direction;
				int num2 = 0;
				_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass52_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				LoopVerticalScrollRect loopScrollRect = LoopScrollRect;
				int num3 = 0;
				if (loopScrollRect != (UnityEngine.Object)num3)
				{
					LoopVerticalScrollRect loopScrollRect2 = LoopScrollRect;
				}
				_003CFindNextOverrides_003Ed__51 _003CFindNextOverrides_003Ed__ = new _003CFindNextOverrides_003Ed__51(-2);
				_003CFindNextOverrides_003Ed__._003C_003E4__this = this;
				if (_003CFindNextOverrides_003Ed__ != null)
				{
					if (num2 < (int)num4)
					{
						num2 += num2;
						num2++;
					}
					while (_003CFindNextOverrides_003Ed__ == null)
					{
					}
					num2++;
					num += num;
					num2 += 312;
				}
				num2++;
				int num5 = 0;
				if (_003CFindNextOverrides_003Ed__ != null)
				{
				}
				if (num2 != 0)
				{
					continue;
				}
				if (num2 != 0)
				{
				}
				int num6 = 0;
				int num7 = 0;
				if (!((UnityEngine.Object)num2 != (UnityEngine.Object)num7))
				{
					continue;
				}
				CS_0024_003C_003E8__locals0.index = num5;
				int childCount = transform.childCount;
				int num8 = 0;
				Transform parent = transform2.parent;
				int num9 = (CS_0024_003C_003E8__locals0.index = transform2.transform.GetSiblingIndex());
				if (num6 == 0)
				{
					continue;
				}
				int num10 = 0;
				if (num6 != 0)
				{
					int num11 = 0;
					if ((UnityEngine.Object)num5 == (UnityEngine.Object)num11)
					{
						int index = CS_0024_003C_003E8__locals0.index;
						Transform child = transform.GetChild(index);
						bool activeSelf = child.gameObject.activeSelf;
						int index2 = CS_0024_003C_003E8__locals0.index;
						if ((long)(CS_0024_003C_003E8__locals0.index = index2 + 1) < (long)(IntPtr)child)
						{
							int num12 = 0;
							if (child == (UnityEngine.Object)num12)
							{
								int index3 = CS_0024_003C_003E8__locals0.index;
								child2 = transform.GetChild(index3);
								bool activeSelf2 = child2.gameObject.activeSelf;
							}
						}
					}
					if ((object)child2 != null)
					{
						FocusNavigationElement component = child2.GetComponent<FocusNavigationElement>();
					}
					int num13 = 0;
					if (!(transform != (UnityEngine.Object)num13))
					{
						continue;
					}
					int num14 = 0;
					if (!(child2 != (UnityEngine.Object)num14))
					{
						int index4 = CS_0024_003C_003E8__locals0.index;
					}
					int num15 = 0;
					int index6;
					if (!(child2 != (UnityEngine.Object)num15))
					{
						int index5 = CS_0024_003C_003E8__locals0.index;
						index6 = CS_0024_003C_003E8__locals0.index;
						if (index6 <= num16)
						{
							continue;
						}
						Action action = delegate
						{
							//Discarded unreachable code: IL_0016
							FocusNavigationElement _003C_003E4__this5 = CS_0024_003C_003E8__locals0._003C_003E4__this;
							int index17 = CS_0024_003C_003E8__locals0.index;
							_003C_003E4__this5.OnScrollDone(index17);
						};
					}
					int num17 = 0;
					index6 = num18;
					if (index6 >= num19)
					{
						continue;
					}
					int num20 = 0;
					int index8;
					if (!flag)
					{
						int index7 = CS_0024_003C_003E8__locals0.index;
						index8 = CS_0024_003C_003E8__locals0.index;
						if (index8 <= num21)
						{
							continue;
						}
						Action action2 = delegate
						{
							//Discarded unreachable code: IL_0016
							FocusNavigationElement _003C_003E4__this4 = CS_0024_003C_003E8__locals0._003C_003E4__this;
							int index16 = CS_0024_003C_003E8__locals0.index;
							_003C_003E4__this4.OnScrollDone(index16);
						};
					}
					num22 = 0;
					index8 = num23;
					if (index8 <= num24)
					{
						continue;
					}
				}
				if (num22 == 0)
				{
					continue;
				}
				int num25 = 0;
				if (num22 != 0)
				{
					if (flag2)
					{
						int index9 = CS_0024_003C_003E8__locals0.index;
						bool activeSelf3 = transform3.gameObject.activeSelf;
						int index10 = CS_0024_003C_003E8__locals0.index;
						if ((long)(CS_0024_003C_003E8__locals0.index = index10 + 1) < (long)(IntPtr)transform3)
						{
							int num26 = 0;
							if (transform3 == (UnityEngine.Object)num26)
							{
								int index11 = CS_0024_003C_003E8__locals0.index;
								bool activeSelf4 = transform4.gameObject.activeSelf;
							}
						}
					}
					if ((object)transform4 != null)
					{
						FocusNavigationElement component2 = transform4.GetComponent<FocusNavigationElement>();
						if ((object)transform4 != null)
						{
							FocusNavigationElement componentInChildren = transform4.GetComponentInChildren<FocusNavigationElement>();
						}
					}
					if (!flag3)
					{
						continue;
					}
					int num27 = 0;
					if (!(transform4 != (UnityEngine.Object)num27))
					{
						continue;
					}
					_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = CS_0024_003C_003E8__locals0;
					int itemIndex = num28;
					int b = itemIndex;
					int num29 = Mathf.Max(0, b);
					num30 = itemIndex;
					Action action3 = delegate
					{
						//Discarded unreachable code: IL_001b
						FocusNavigationElement _003C_003E4__this3 = _003C_003Ec__DisplayClass52_._003C_003E4__this;
						int index15 = itemIndex;
						_003C_003E4__this3.OnScrollDone(index15);
					};
				}
				int num31 = 0;
				if (CS_0024_003C_003E8__locals0 == null)
				{
					continue;
				}
				if (CS_0024_003C_003E8__locals0 != null)
				{
					if ((long)CS_0024_003C_003E8__locals0 != 1)
					{
						continue;
					}
					int index12 = CS_0024_003C_003E8__locals0.index;
					num32++;
					if ((object)transform5 != null)
					{
						FocusNavigationElement component3 = transform5.GetComponent<FocusNavigationElement>();
					}
					if (!flag4)
					{
						continue;
					}
					int num33 = 0;
					if (!(transform5 != (UnityEngine.Object)num33))
					{
					}
					Action action4 = delegate
					{
						//Discarded unreachable code: IL_0016
						FocusNavigationElement _003C_003E4__this2 = CS_0024_003C_003E8__locals0._003C_003E4__this;
						int index14 = CS_0024_003C_003E8__locals0.index;
						_003C_003E4__this2.OnScrollDone(index14);
					};
					num34 -= num30;
					int num36 = num35;
					num34 = num37;
					Action action5 = delegate
					{
						//Discarded unreachable code: IL_0016
						FocusNavigationElement _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
						int index13 = CS_0024_003C_003E8__locals0.index;
						_003C_003E4__this.OnScrollDone(index13);
					};
				}
				int num38 = Mathf.CeilToInt(num35);
				int num39 = 0;
				int num40 = Mathf.FloorToInt(num35);
				int num41 = CS_0024_003C_003E8__locals0.index;
				num40 = num41;
				if (num42 != 0)
				{
					if (num42 != 0)
					{
						if (num42 != 0)
						{
							if (num42 == 1)
							{
								num41 += typeof(IFocusNavigationOverrideFindNext).TypeHandle;
								int num43 = num40 + 1;
							}
							if (!flag5 || !flag6)
							{
								continue;
							}
							if (num42 != 2)
							{
								goto IL_0430;
							}
							int num44 = 0;
							num30 = num45;
							num47 = num46 - 1;
							num30 = num45;
						}
						num41 -= typeof(IFocusNavigationOverrideFindNext).TypeHandle;
						int num48 = num40 - 1;
					}
					if ((long)(num47 + 1) >= (long)(IntPtr)typeof(IFocusNavigationOverrideFindNext).TypeHandle)
					{
						continue;
					}
					num41++;
				}
				while (num49 == 0)
				{
				}
				int num50 = (CS_0024_003C_003E8__locals0.index = CS_0024_003C_003E8__locals0.index);
				while ((object)transform6 == null)
				{
				}
				FocusNavigationElement component4 = transform6.GetComponent<FocusNavigationElement>();
				FocusNavigationElement component5 = transform6.GetComponent<FocusNavigationElement>();
				int num51 = 0;
				num30 = num52;
				goto IL_0430;
				IL_0430:
				if (num42 == 3)
				{
					/*Error: Could not find block for branch target IL_0439*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB3")]
		[Cpp2IlInjected.Address(RVA = "0x1667A10", Offset = "0x1666410", VA = "0x181667A10", Slot = "17")]
		protected virtual bool IsInFirstRow()
		{
			LayoutGroup layoutGroup = LayoutGroup;
			if ((object)layoutGroup != null)
			{
				int num = 0;
				if ((object)layoutGroup != null)
				{
					return base.transform.GetSiblingIndex() == 0;
				}
				if ((object)layoutGroup != null)
				{
					int num2 = 0;
					if ((object)layoutGroup != null)
					{
						int siblingIndex = base.transform.GetSiblingIndex();
						bool result = default(bool);
						return result;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB4")]
		[Cpp2IlInjected.Address(RVA = "0x1667B40", Offset = "0x1666540", VA = "0x181667B40", Slot = "18")]
		protected virtual bool IsInLastRow()
		{
			LayoutGroup layoutGroup = LayoutGroup;
			if ((object)layoutGroup != null)
			{
				int num = 0;
				if ((object)layoutGroup != null)
				{
					int siblingIndex = base.transform.GetSiblingIndex();
					int childCount = ScrollRect.m_Content.childCount;
				}
				if ((object)layoutGroup != null)
				{
					int num2 = 0;
					if ((object)layoutGroup != null)
					{
						int childCount2 = base.transform.childCount;
						Transform transform = base.transform;
						int num3 = 0;
						int childCount3 = transform.childCount;
						int siblingIndex2 = base.transform.GetSiblingIndex();
						int num4 = childCount2 - 1;
						if (num3 != 0)
						{
							num4 = childCount2;
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB5")]
		[Cpp2IlInjected.Address(RVA = "0x1663710", Offset = "0x1662110", VA = "0x181663710", Slot = "7")]
		public void AssignNext(FocusDirection direction, ISupportsFocusNavigation next)
		{
			//Discarded unreachable code: IL_001c
			while (direction != FocusDirection.DefaultOrFirst)
			{
				FocusNavigationElement[] links = Links;
				if (next != null)
				{
					int num = 0;
					if (next == null || num != 0)
					{
						int num2 = 0;
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x1667FE0", Offset = "0x16669E0", VA = "0x181667FE0")]
		private void OnScrollDone(int index)
		{
			//Discarded unreachable code: IL_0031
			//IL_0012: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			((UnityEvent<T0>)(object)OnScrollToCellCallBack)?.Invoke((T0)index);
			LoopVerticalScrollRect loopScrollRect = LoopScrollRect;
			int num = 0;
			if (loopScrollRect != (UnityEngine.Object)num)
			{
				LoopScrollRect.ForceUpdateBounds();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB7")]
		[Cpp2IlInjected.Address(RVA = "0x1668210", Offset = "0x1666C10", VA = "0x181668210", Slot = "19")]
		public virtual void RemoveFocus()
		{
			//Discarded unreachable code: IL_0102
			//IL_0011: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00f3: Expected O, but got I4
			int num = 0;
			EventSystem current = EventSystem.current;
			int num2 = 0;
			if (current != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				GameObject gameObject = base.gameObject;
				if (currentSelected == gameObject)
				{
					int num4 = 0;
					if (!EventSystem.current.m_SelectionGuard)
					{
						int num5 = 0;
						EventSystem current2 = EventSystem.current;
						int num6 = 0;
						current2.SetSelectedGameObject((GameObject)num6);
					}
				}
			}
			ScrollRect scrollRect = ScrollRect;
			int num7 = 0;
			if (scrollRect != (UnityEngine.Object)num7)
			{
				ScrollRect scrollRect2 = ScrollRect;
				int complete = 0;
				int num8 = DOTween.Kill(scrollRect2, (byte)complete != 0);
			}
			GameObject highlight = Highlight;
			int num9 = 0;
			if (highlight != (UnityEngine.Object)num9)
			{
				GameObject highlight2 = Highlight;
				int active = 0;
				highlight2.SetActive((byte)active != 0);
			}
			TemplateButton clickButton = ClickButton;
			int num10 = 0;
			if (clickButton != (UnityEngine.Object)num10)
			{
				TemplateButton clickButton2 = ClickButton;
				int num11 = ((clickButton2.IsHighlighted = false) ? 1 : 0);
			}
			BaseButton baseButton = BaseButton;
			int num12 = 0;
			if (baseButton != (UnityEngine.Object)num12)
			{
				BaseButton.OnHighlightExit();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB8")]
		[Cpp2IlInjected.Address(RVA = "0x16684F0", Offset = "0x1666EF0", VA = "0x1816684F0", Slot = "20")]
		public virtual void SetFocus()
		{
			//Discarded unreachable code: IL_00d3
			//IL_0010: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			ScrollRect scrollRect = ScrollRect;
			int num = 0;
			if (scrollRect != (UnityEngine.Object)num && ScrollRect.enabled)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					BringItemToFocus();
				}
			}
			GameObject highlight = Highlight;
			int num3 = 0;
			if (highlight != (UnityEngine.Object)num3)
			{
				Highlight.SetActive(value: true);
			}
			TemplateButton clickButton = ClickButton;
			int num4 = 0;
			if (clickButton != (UnityEngine.Object)num4)
			{
				ClickButton.IsHighlighted = true;
			}
			BaseButton baseButton = BaseButton;
			int num5 = 0;
			if (baseButton != (UnityEngine.Object)num5)
			{
				BaseButton.SetFocus();
			}
			int num6 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
			{
				OnControllerFocused?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB9")]
		[Cpp2IlInjected.Address(RVA = "0x1664A70", Offset = "0x1663470", VA = "0x181664A70", Slot = "21")]
		public virtual void Click(ShortcutDefinition shortcut)
		{
			//Discarded unreachable code: IL_0008
			ContextStack context = ((IDesignerSerializationManager)this).Context;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBA")]
		[Cpp2IlInjected.Address(RVA = "0x1664AA0", Offset = "0x16634A0", VA = "0x181664AA0", Slot = "22")]
		public virtual void Click(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_011f
			//IL_0012: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_0102: Expected O, but got I4
			BaseButton infoButton = default(BaseButton);
			while (true)
			{
				TemplateButton clickButton = ClickButton;
				int num = 0;
				bool flag = clickButton != (UnityEngine.Object)num;
				if (flag)
				{
					TemplateButton clickButton2 = ClickButton;
					if (clickButton2._interactable)
					{
						if ((flag ? 1 : 0) <= (true ? 1 : 0))
						{
							clickButton2.OnClicked?.Invoke();
						}
						return;
					}
				}
				if ((flag ? 1 : 0) <= (true ? 1 : 0))
				{
				}
				if (redirectionType == RedirectionType.GameClickButtonExtraInfo)
				{
					infoButton = InfoButton;
				}
				int num2 = 0;
				if (!(infoButton != (UnityEngine.Object)num2) || !infoButton.enabled || !infoButton.gameObject.activeSelf || !infoButton.gameObject.activeInHierarchy)
				{
					continue;
				}
				GameObject gameObject = infoButton.gameObject;
				int num3 = 0;
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				if (gameObject != currentSelected)
				{
					Button buttonComponent = infoButton.ButtonComponent;
					int num4 = 0;
					if (buttonComponent != (UnityEngine.Object)num4)
					{
						Button buttonComponent2 = infoButton.ButtonComponent;
						infoButton.ButtonComponent.m_OnClick.Invoke();
					}
					Toggle toggleComponent = infoButton.ToggleComponent;
					int num5 = 0;
					if (toggleComponent != (UnityEngine.Object)num5)
					{
						break;
					}
				}
			}
			Toggle toggleComponent2 = infoButton.ToggleComponent;
			infoButton.ToggleComponent.isOn = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBB")]
		[Cpp2IlInjected.Address(RVA = "0x1664D90", Offset = "0x1663790", VA = "0x181664D90", Slot = "23")]
		public virtual void Click()
		{
			ContextStack context = ((IDesignerSerializationManager)this).Context;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBC")]
		[Cpp2IlInjected.Address(RVA = "0x1663920", Offset = "0x1662320", VA = "0x181663920", Slot = "24")]
		public virtual void BringItemToFocus()
		{
			//Discarded unreachable code: IL_02cf
			//IL_0318: Expected O, but got I4
			//IL_03c9: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			if ((UsetAltLogicForScrolling ? 1 : 0) == num)
			{
				ScrollRect scrollRect = ScrollRect;
				if (!scrollRect.m_Vertical)
				{
					int num3 = 0;
					if ((scrollRect.m_Horizontal ? 1 : 0) != num3)
					{
						RectTransform component = base.gameObject.GetComponent<RectTransform>();
						Transform transform = ScrollRect.transform;
						Transform transform2 = base.gameObject.transform;
						Vector3 vector = default(Vector3);
						float z = vector.z;
						Vector3 vector2 = default(Vector3);
						float z2 = vector2.z;
						Transform transform3 = ScrollRect.transform;
						RectTransform viewport = ScrollRect.m_Viewport;
						Vector3 vector3 = default(Vector3);
						float z3 = vector3.z;
						ScrollRect scrollRect2 = ScrollRect;
						Vector3 vector4 = default(Vector3);
						float z4 = vector4.z;
						RectTransform viewport2 = scrollRect2.m_Viewport;
						RectTransform viewport3 = ScrollRect.m_Viewport;
						if (num3 == 0)
						{
							Transform transform4 = ScrollRect.transform;
							RectTransform content = ScrollRect.m_Content;
							Vector3 vector5 = default(Vector3);
							float z5 = vector5.z;
							Vector3 vector6 = default(Vector3);
							float z6 = vector6.z;
							if (num3 == 0)
							{
							}
							RectTransform viewport4 = ScrollRect.m_Viewport;
							Vector2 anchoredPosition = ScrollRect.m_Content.anchoredPosition;
							RectTransform content2 = ScrollRect.m_Content;
							RectTransform viewport5 = ScrollRect.m_Viewport;
							GameObject gameObject = base.gameObject;
							if (num3 != 0)
							{
								RectTransform component2 = gameObject.GetComponent<RectTransform>();
							}
							ScrollRect scrollRect3 = ScrollRect;
							RectTransform content3 = ScrollRect.m_Content;
							TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
							TweenerCore<Vector2, Vector2, VectorOptions> t2 = t.SetEase(Ease.OutCirc);
							TweenCallback action = OnScrollComplete;
							TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t2.OnComplete(action).Play();
						}
					}
					if ((ScrollRect.m_Vertical ? 1 : 0) != num3)
					{
						RectTransform component3 = base.gameObject.GetComponent<RectTransform>();
						RectTransform content4 = ScrollRect.m_Content;
						RectTransform viewport6 = ScrollRect.m_Viewport;
						Transform transform5 = ScrollRect.transform;
						Transform transform6 = base.gameObject.transform;
						Vector3 vector7 = default(Vector3);
						float z7 = vector7.z;
						Vector3 vector8 = default(Vector3);
						float z8 = vector8.z;
						Transform transform7 = ScrollRect.transform;
						RectTransform viewport7 = ScrollRect.m_Viewport;
						Vector3 vector9 = default(Vector3);
						float z9 = vector9.z;
						RectTransform viewport8 = ScrollRect.m_Viewport;
						RectTransform viewport9 = ScrollRect.m_Viewport;
						if (num3 == 0)
						{
							Transform transform8 = ScrollRect.transform;
							RectTransform content5 = ScrollRect.m_Content;
							Vector3 vector10 = default(Vector3);
							float z10 = vector10.z;
							Vector2 anchoredPosition2 = ScrollRect.m_Content.anchoredPosition;
							RectTransform viewport10 = ScrollRect.m_Viewport;
							RectTransform content6 = ScrollRect.m_Content;
							RectTransform viewport11 = ScrollRect.m_Viewport;
							RectTransform content7 = ScrollRect.m_Content;
							int complete = 0;
							int num4 = DOTween.Kill(content7, (byte)complete != 0);
							RectTransform content8 = ScrollRect.m_Content;
							TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
							TweenerCore<Vector2, Vector2, VectorOptions> t4 = t3.SetEase(Ease.OutCirc);
							TweenCallback action2 = OnScrollComplete;
							TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t4.OnComplete(action2).Play();
						}
					}
					return;
				}
			}
			Transform transform9 = base.transform;
			int bottom = 0;
			if ((object)transform9 != null)
			{
			}
			ScrollRect scrollRect4 = ScrollRect;
			RectTransform content9 = scrollRect4.m_Content;
			RectTransform viewport12 = scrollRect4.m_Viewport;
			int num5 = 0;
			bool flag = viewport12 != (UnityEngine.Object)num5;
			ScrollRect scrollRect5 = ScrollRect;
			if (flag)
			{
			}
			if ((object)scrollRect5.transform != null)
			{
			}
			bool flag2 = default(bool);
			while (flag2)
			{
			}
			LayoutGroup component4 = ScrollRect.m_Content.GetComponent<LayoutGroup>();
			RectOffset rectOffset = default(RectOffset);
			if ((object)component4 == null || component4.m_Padding == null)
			{
				int top = default(int);
				int right = default(int);
				int left = default(int);
				rectOffset = new RectOffset(left, right, top, bottom);
				top = 0;
				right = 0;
				left = 0;
			}
			ScrollRect scrollRect6 = ScrollRect;
			while (!scrollRect6.m_Vertical)
			{
			}
			RectTransform content10 = scrollRect6.m_Content;
			int complete2 = 0;
			int num6 = DOTween.Kill(content10, (byte)complete2 != 0);
			Vector2 anchoredPosition3 = content9.anchoredPosition;
			int top2 = rectOffset.top;
			int num7 = 0;
			int bottom2 = rectOffset.bottom;
			int num8 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(content9, (float)num7, 0.33f, (byte)num8 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBD")]
		[Cpp2IlInjected.Address(RVA = "0x1667F80", Offset = "0x1666980", VA = "0x181667F80")]
		private void OnScrollComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBE")]
		[Cpp2IlInjected.Address(RVA = "0x1664DB0", Offset = "0x16637B0", VA = "0x181664DB0")]
		public ISupportsFocusNavigation FindNextFocusElementByPosition(FocusDirection direction, IEnumerable<ISupportsFocusNavigation> candidates)
		{
			//Discarded unreachable code: IL_00f8, IL_00fe, IL_0104
			//IL_001e: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_009a: Invalid comparison between F4 and O
			//IL_00cb: Expected O, but got I4
			bool flag = default(bool);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			bool flag2 = default(bool);
			GameObject gameObject = default(GameObject);
			Transform transform = default(Transform);
			Vector3 vector4 = default(Vector3);
			ulong num8 = default(ulong);
			Vector2 vector5 = default(Vector2);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if ((object)base.transform != null)
				{
				}
				int num4 = 0;
				if ((UnityEngine.Object)num3 == (UnityEngine.Object)num4)
				{
					break;
				}
				if (direction != 0)
				{
					if (direction != 0)
					{
						if (direction != 0)
						{
							if (direction != FocusDirection.Right)
							{
								Vector3 zero = Vector3.zero;
							}
							Vector3 down = Vector3.down;
						}
						Vector3 up = Vector3.up;
					}
					Vector3 right = Vector3.right;
				}
				float z = Vector3.left.z;
				float z2 = Vector3.zero.z;
				if (flag)
				{
					break;
				}
				float z3 = vector.z;
				float z4 = vector2.z;
				float z5 = vector3.z;
				if (z5 != 0f)
				{
					int num5 = 0;
					while ((object)z5 == this)
					{
					}
					if (z5 == 0f)
					{
					}
					int num6 = 0;
					while (flag2)
					{
					}
					if (!gameObject.activeInHierarchy)
					{
						goto IL_0000;
					}
					if ((object)transform != null)
					{
					}
					int num7 = 0;
					if (transform == (UnityEngine.Object)num7)
					{
						goto IL_0000;
					}
					float z6 = vector4.z;
					while ((long)num >= (long)num8)
					{
					}
				}
				if (z5 != 0f)
				{
				}
			}
			while ((object)vector5 != null);
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x1668780", Offset = "0x1667180", VA = "0x181668780")]
		public FocusNavigationElement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static FocusNavigationElement()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
