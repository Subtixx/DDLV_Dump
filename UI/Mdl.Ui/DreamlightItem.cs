using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Meta.Online;
using Newtonsoft.Json.Utilities;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200043B")]
	public class DreamlightItem : MonoBehaviour, IHasDynamicView
	{
		[Cpp2IlInjected.Token(Token = "0x200043C")]
		internal enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x400155B")]
			OnGoing,
			[Cpp2IlInjected.Token(Token = "0x400155C")]
			Claimable,
			[Cpp2IlInjected.Token(Token = "0x400155D")]
			Claimed
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400154D")]
		public RectTransform ViewHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400154E")]
		public RedDot RedDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400154F")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001550")]
		public FocusNavigationElement FocusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001551")]
		public TextButton ClaimButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001552")]
		public CanvasGroup CanvasGroupAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001553")]
		public RecycleBin RecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001554")]
		public UnityEvent[] Phases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001555")]
		public UnityEvent OnClaimed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001556")]
		public bool IsClaimable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001557")]
		private int interval = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001558")]
		private float nextTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001559")]
		private bool shouldUpdateViewOnStarted;

		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		internal DreamlightItemModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001B62")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B63")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		public DreamlightItemView View
		{
			[Cpp2IlInjected.Token(Token = "0x6001B64")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CView_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B65")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CView_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400154A")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6001B66")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B67")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x29"), Cpp2IlInjected.Token(Token = "0x400154B")]
		public bool IsInFirstRow
		{
			[Cpp2IlInjected.Token(Token = "0x6001B68")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B69")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2A"), Cpp2IlInjected.Token(Token = "0x400154C")]
		public bool IsInLastRow
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6A")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B6B")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		public TextBase RewardAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6C")]
			[Cpp2IlInjected.Address(RVA = "0xF1BFA0", Offset = "0xF1A9A0", VA = "0x180F1BFA0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return View.RewardAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		public TextBase Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6D")]
			[Cpp2IlInjected.Address(RVA = "0xF1BF80", Offset = "0xF1A980", VA = "0x180F1BF80")]
			get
			{
				//Discarded unreachable code: IL_000c
				return View.Progress;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		public RectTransform MilestoneNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6001B6E")]
			[Cpp2IlInjected.Address(RVA = "0xF1BF60", Offset = "0xF1A960", VA = "0x180F1BF60")]
			get
			{
				//Discarded unreachable code: IL_000c
				return View.MilestoneNodes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B6F")]
		[Cpp2IlInjected.Address(RVA = "0xF1AD30", Offset = "0xF19730", VA = "0x180F1AD30")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00fa
			//IL_0024: Expected O, but got I4
			//IL_00f9: Expected O, but got I8
			if ((long)Model != 0)
			{
				UpdateView();
				DreamlightItemView dreamlightItemView = View;
				int num = 0;
				if (dreamlightItemView != (UnityEngine.Object)num)
				{
					bool flag = Model.IsClaimable();
					TextButton claimButton = ClaimButton;
					IsClaimable = flag;
					claimButton.IsInteractable = flag;
					DreamlightItemView dreamlightItemView2 = View;
					bool isClaimable = IsClaimable;
					if (dreamlightItemView2._isClaimable != isClaimable)
					{
						dreamlightItemView2._isClaimable = isClaimable;
						dreamlightItemView2.RefreshDisplay();
					}
					if (!isClaimable)
					{
						View.OnReleaseClaimChangeButtonBackground();
						ClaimButton.View.Label.StringID = "";
						ClaimButton.View.Label.Text = "";
					}
					View.RefreshDisplay();
					Model.UpdateDisplay(this);
					View.RefreshDisplay();
					ReplaceRedDot();
				}
			}
			else
			{
				IsVisible = false;
				ReleaseView();
				Model = (DreamlightItemModel)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B70")]
		[Cpp2IlInjected.Address(RVA = "0xF1B650", Offset = "0xF1A050", VA = "0x180F1B650", Slot = "6")]
		internal virtual void UpdateView()
		{
			//Discarded unreachable code: IL_0229
			//IL_001c: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_01fc: Expected I4, but got I8
			//IL_021a: Expected O, but got I4
			ulong num6 = default(ulong);
			DreamlightItemView dreamlightItemView7;
			int num7;
			do
			{
				if (IsVisible)
				{
					DreamlightItemView dreamlightItemView = View;
					int num = 0;
					if (dreamlightItemView == (UnityEngine.Object)num)
					{
						RecycleBin recycleBin = RecycleBin;
						Type typeFromHandle = typeof(DreamlightItemView);
						RectTransform viewHolder = ViewHolder;
						DreamlightItemView dreamlightItemView2 = (View = recycleBin.FindReusableOrNew(typeFromHandle, viewHolder).GetComponent<DreamlightItemView>());
						DreamlightItemView dreamlightItemView3 = View;
						int num2 = 0;
						if (dreamlightItemView3 != (UnityEngine.Object)num2)
						{
							FocusNavigationElement focusNavigationElement = FocusNavigationElement;
							DreamlightItemView dreamlightItemView4 = (DreamlightItemView)(focusNavigationElement.ClickButton = View);
							FocusNavigationElement.UsetAltLogicForScrolling = true;
							DreamlightItemView dreamlightItemView5 = View;
							FocusNavigationElement focusNavigationElement2 = (((TemplateButton)dreamlightItemView5).FocusNavigationElement = FocusNavigationElement);
							DreamlightItemView dreamlightItemView6 = View;
							FocusNavigation focusNavigation = (((TemplateButton)dreamlightItemView6).FocusNavigation = FocusNavigation);
							UnityEvent onHighlighted = View.OnHighlighted;
							UnityAction call = OnBodyHighlighted;
							onHighlighted.AddListener(call);
							UnityEvent onDehighlighted = View.OnDehighlighted;
							UnityAction call2 = OnBodyHighlighted;
							onDehighlighted.AddListener(call2);
							UnityEvent onClicked = View.OnClicked;
							UnityAction call3 = OnBodyClicked;
							onClicked.AddListener(call3);
							UnityEvent onHighlighted2 = ClaimButton.OnHighlighted;
							UnityAction call4 = OnButtonHighlighted;
							onHighlighted2.AddListener(call4);
							UnityEvent onDehighlighted2 = ClaimButton.OnDehighlighted;
							UnityAction call5 = OnButtonHighlighted;
							onDehighlighted2.AddListener(call5);
							UnityEvent onClicked2 = ClaimButton.OnClicked;
							UnityAction call6 = OnClaimClicked;
							onClicked2.AddListener(call6);
							UnityEvent onPressed = ClaimButton.OnPressed;
							UnityAction call7 = OnClaimPressed;
							onPressed.AddListener(call7);
							Transform transform = View.transform;
							int num3 = 0;
							if ((object)transform != null)
							{
							}
							int num4 = 0;
							Vector2 zero = Vector2.zero;
							int num5 = 0;
							Vector2 zero2 = Vector2.zero;
							View.gameObject.SetActive((byte)num6 != 0);
						}
						return;
					}
					while (IsVisible)
					{
					}
				}
				dreamlightItemView7 = View;
				num7 = 0;
			}
			while (!(dreamlightItemView7 != (UnityEngine.Object)num7));
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B71")]
		[Cpp2IlInjected.Address(RVA = "0xF1A550", Offset = "0xF18F50", VA = "0x180F1A550")]
		private void OnBodyClicked()
		{
			//Discarded unreachable code: IL_002b
			if (ClaimButton.gameObject.activeSelf)
			{
				ClaimButton.OnClicked?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B72")]
		[Cpp2IlInjected.Address(RVA = "0xF1A6C0", Offset = "0xF190C0", VA = "0x180F1A6C0")]
		private void OnButtonHighlighted()
		{
			//Discarded unreachable code: IL_005e
			//IL_0010: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			DreamlightItemView dreamlightItemView = View;
			int num = 0;
			if (dreamlightItemView != (UnityEngine.Object)num)
			{
				TextButton claimButton = ClaimButton;
				DreamlightItemView dreamlightItemView2 = View;
				bool flag = (dreamlightItemView2.IsHighlighted = ((TemplateButton)claimButton)._isHighlighted);
			}
			RectTransform body = ClaimButton.Body;
			View.Body.anchoredPosition = (Vector2)num;
			body.anchoredPosition = (Vector2)num;
			ReplaceRedDot();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B73")]
		[Cpp2IlInjected.Address(RVA = "0xF1A5B0", Offset = "0xF18FB0", VA = "0x180F1A5B0")]
		private void OnBodyHighlighted()
		{
			//Discarded unreachable code: IL_0064
			//IL_0055: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			UpdateView();
			GameObject gameObject = ClaimButton.gameObject;
			int num = 0;
			if (gameObject.activeSelf)
			{
				TextButton claimButton = ClaimButton;
				bool flag = (claimButton.IsHighlighted = ((TemplateButton)View)._isHighlighted);
			}
			RectTransform body = ClaimButton.Body;
			View.Body.anchoredPosition = (Vector2)num;
			body.anchoredPosition = (Vector2)num;
			ReplaceRedDot();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B74")]
		[Cpp2IlInjected.Address(RVA = "0xF1B3E0", Offset = "0xF19DE0", VA = "0x180F1B3E0")]
		private void ReplaceRedDot()
		{
			//Discarded unreachable code: IL_0033
			Transform transform = RedDot.transform;
			DreamlightItemModel dreamlightItemModel = Model;
			int num = 0;
			if ((object)transform != null)
			{
			}
			if (dreamlightItemModel != null)
			{
				int num2 = 0;
				if (dreamlightItemModel != null && (object)transform == null)
				{
				}
			}
			int num3 = 0;
			DreamlightItemView dreamlightItemView = View;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B75")]
		[Cpp2IlInjected.Address(RVA = "0xF1AC10", Offset = "0xF19610", VA = "0x180F1AC10")]
		private void OnClaimPressed()
		{
			//Discarded unreachable code: IL_0076
			DreamlightItemView dreamlightItemView = View;
			if (dreamlightItemView.ClaimBackgroundLeft.activeSelf && dreamlightItemView.ClaimBackgroundRight.activeSelf)
			{
				Transform parent = dreamlightItemView.transform.parent.parent;
				GameObject claimButtonBackgroundLeft = dreamlightItemView.ClaimButtonBackgroundLeft;
				int active = 0;
				claimButtonBackgroundLeft.SetActive((byte)active != 0);
				GameObject claimButtonBackgroundRight = dreamlightItemView.ClaimButtonBackgroundRight;
				int active2 = 0;
				claimButtonBackgroundRight.SetActive((byte)active2 != 0);
				dreamlightItemView.HighlightButtonBackgroundLeft.SetActive(value: true);
				dreamlightItemView.HighlightButtonBackgroundRight.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B76")]
		[Cpp2IlInjected.Address(RVA = "0xF1A900", Offset = "0xF19300", VA = "0x180F1A900")]
		private void OnClaimClicked()
		{
			//Discarded unreachable code: IL_008d
			if ((long)Model == 0)
			{
				return;
			}
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			TextButton claimButton = ClaimButton;
			AK.Wwise.Event @event = claimButton.SFXS[0];
			if (@event != null)
			{
				GameObject gameObject = claimButton.gameObject;
				uint num6 = @event.Post(gameObject);
			}
			DreamlightItemModel dreamlightItemModel = Model;
			if (dreamlightItemModel != null)
			{
				int num7 = 0;
				if (dreamlightItemModel != null)
				{
					goto IL_0082;
				}
			}
			View.VfxItemClaim.Play();
			goto IL_0082;
			IL_0082:
			int num8 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B77")]
		[Cpp2IlInjected.Address(RVA = "0xF1A7E0", Offset = "0xF191E0", VA = "0x180F1A7E0")]
		[AsyncStateMachine(typeof(_003COnClaimClickedTask_003Ed__48))]
		private Task OnClaimClickedTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B78")]
		[Cpp2IlInjected.Address(RVA = "0xF1AF70", Offset = "0xF19970", VA = "0x180F1AF70")]
		private void ReleaseClaim()
		{
			//Discarded unreachable code: IL_0040
			View.OnReleaseClaimChangeButtonBackground();
			ClaimButton.View.Label.StringID = "";
			ClaimButton.View.Label.Text = "";
		}

		[Cpp2IlInjected.Token(Token = "0x6001B79")]
		[Cpp2IlInjected.Address(RVA = "0xF1A0F0", Offset = "0xF18AF0", VA = "0x180F1A0F0")]
		[AsyncStateMachine(typeof(_003CCollectAchievementReward_003Ed__50))]
		private Task CollectAchievementReward(AchievementItemModel achievementItemModel, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7A")]
		[Cpp2IlInjected.Address(RVA = "0xF1A370", Offset = "0xF18D70", VA = "0x180F1A370")]
		[AsyncStateMachine(typeof(_003CCollectRoyalDutyReward_003Ed__51))]
		private Task CollectRoyalDutyReward(RoyalDutyItemModel model, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7B")]
		[Cpp2IlInjected.Address(RVA = "0xF1A230", Offset = "0xF18C30", VA = "0x180F1A230")]
		[AsyncStateMachine(typeof(_003CCollectBattlePassTaskReward_003Ed__52))]
		private Task CollectBattlePassTaskReward(BattlePassTaskItemModel model, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7C")]
		[Cpp2IlInjected.Address(RVA = "0xF1B3A0", Offset = "0xF19DA0", VA = "0x180F1B3A0")]
		internal void Release()
		{
			IsVisible = false;
			ReleaseView();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7D")]
		[Cpp2IlInjected.Address(RVA = "0xF1A4B0", Offset = "0xF18EB0", VA = "0x180F1A4B0", Slot = "4")]
		public GameObject GetView()
		{
			//Discarded unreachable code: IL_0022
			RecycleBin recycleBin = RecycleBin;
			Type typeFromHandle = typeof(DreamlightItemView);
			RectTransform viewHolder = ViewHolder;
			return recycleBin.FindReusableOrNew(typeFromHandle, viewHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7E")]
		[Cpp2IlInjected.Address(RVA = "0xF1B010", Offset = "0xF19A10", VA = "0x180F1B010", Slot = "7")]
		public virtual void ReleaseView()
		{
			//Discarded unreachable code: IL_00e4
			//IL_00e3: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				MethodInfo method_info = ((Delegate)new UnityAction(OnBodyHighlighted)).method_info;
				UnityAction unityAction = OnBodyHighlighted;
				UnityAction unityAction2 = OnBodyClicked;
				UnityEvent onHighlighted = ClaimButton.OnHighlighted;
				UnityAction call = OnButtonHighlighted;
				onHighlighted.RemoveListener(call);
				UnityEvent onDehighlighted = ClaimButton.OnDehighlighted;
				UnityAction call2 = OnButtonHighlighted;
				onDehighlighted.RemoveListener(call2);
				UnityEvent onClicked = ClaimButton.OnClicked;
				UnityAction call3 = OnClaimClicked;
				onClicked.RemoveListener(call3);
				UnityEvent onPressed = ClaimButton.OnPressed;
				UnityAction call4 = OnClaimPressed;
				onPressed.RemoveListener(call4);
				GameObject trash = default(GameObject);
				RecycleBin?.SendToBin(trash);
				View = (DreamlightItemView)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B7F")]
		[Cpp2IlInjected.Address(RVA = "0xF1B520", Offset = "0xF19F20", VA = "0x180F1B520")]
		private void UpdateClaimable()
		{
			//Discarded unreachable code: IL_0096
			bool flag = Model.IsClaimable();
			TextButton claimButton = ClaimButton;
			IsClaimable = flag;
			claimButton.IsInteractable = flag;
			DreamlightItemView dreamlightItemView = View;
			bool isClaimable = IsClaimable;
			if (dreamlightItemView._isClaimable != isClaimable)
			{
				dreamlightItemView._isClaimable = isClaimable;
				dreamlightItemView.RefreshDisplay();
			}
			if (!isClaimable)
			{
				View.OnReleaseClaimChangeButtonBackground();
				ClaimButton.View.Label.StringID = "";
				ClaimButton.View.Label.Text = "";
			}
			object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)View).UnderlyingCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B80")]
		[Cpp2IlInjected.Address(RVA = "0xF1BB80", Offset = "0xF1A580", VA = "0x180F1BB80")]
		private void Update()
		{
			//Discarded unreachable code: IL_0130
			//IL_005a: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			string text;
			Client client = default(Client);
			CanvasGroup component3;
			int num6;
			do
			{
				DreamlightItemModel dreamlightItemModel = Model;
				if (dreamlightItemModel == null)
				{
					return;
				}
				int num = 0;
				if (dreamlightItemModel == null)
				{
					return;
				}
				int num2 = 0;
				float time = Time.time;
				if (flag)
				{
					if (flag2 && shouldUpdateViewOnStarted)
					{
						CanvasGroup component = View.View.Label.gameObject.GetComponent<CanvasGroup>();
						int num3 = 0;
						if (component != (UnityEngine.Object)num3)
						{
							CanvasGroup component2 = View.View.Label.gameObject.GetComponent<CanvasGroup>();
							int num4 = ((component2.ignoreParentGroups = false) ? 1 : 0);
						}
						dreamlightItemModel.UpdateDisplay(this);
						shouldUpdateViewOnStarted = false;
					}
					return;
				}
				shouldUpdateViewOnStarted = true;
				int num5 = 0;
				text = EventDisplayManager.CalculateCountdown(client.ServerTime, (DateTime)num5);
				component3 = View.View.Label.gameObject.GetComponent<CanvasGroup>();
				num6 = 0;
			}
			while (!(component3 == (UnityEngine.Object)num6));
			View.View.Label.gameObject.AddComponent<CanvasGroup>().ignoreParentGroups = true;
			TextBase label = View.View.Label;
			int num7 = 0;
			string text3 = (label.Text = LocalizationManager.FromStringID("menu.starpath_task_available_in", (IResolver)num7) + text);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B81")]
		[Cpp2IlInjected.Address(RVA = "0xF1BF40", Offset = "0xF1A940", VA = "0x180F1BF40")]
		public DreamlightItem()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
