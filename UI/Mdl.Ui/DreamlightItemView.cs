using Cpp2IlInjected;
using Newtonsoft.Json.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000441")]
	public class DreamlightItemView : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001579")]
		public RectTransform Body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400157A")]
		internal DreamlightMenu.Phase Phase = DreamlightMenu.Phase.Achievement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400157B")]
		public RectTransform MilestoneNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400157C")]
		public TextBase Progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400157D")]
		public TextBase RewardAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400157E")]
		public RectTransform RewardTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400157F")]
		public GameObject RewardIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001580")]
		public GameObject RewardBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001581")]
		public GameObject LockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001582")]
		public GameObject GiftIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001583")]
		[Header("Backgrounds")]
		public GameObject BackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001584")]
		public GameObject BackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001585")]
		public GameObject ClaimBackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001586")]
		public GameObject ClaimBackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001587")]
		public GameObject HighlightBackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001588")]
		public GameObject HighlightBackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001589")]
		[Header("Btn")]
		public GameObject ButtonBackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400158A")]
		public GameObject ButtonBackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400158B")]
		public GameObject ClaimButtonBackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400158C")]
		public GameObject ClaimButtonBackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400158D")]
		public GameObject HighlightButtonBackgroundLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400158E")]
		public GameObject HighlightButtonBackgroundRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400158F")]
		public ParticleSystem VfxItemClaim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001590")]
		public UnityEvent[] Phases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001591")]
		public UnityEvent[] UiEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001592")]
		private bool _isClaimable;

		[Cpp2IlInjected.Token(Token = "0x17000482")]
		public TextBase Desc
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8A")]
			[Cpp2IlInjected.Address(RVA = "0xE32C90", Offset = "0xE31690", VA = "0x180E32C90")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.View.Label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000483")]
		public ImageHelper Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8B")]
			[Cpp2IlInjected.Address(RVA = "0xF1A0A0", Offset = "0xF18AA0", VA = "0x180F1A0A0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.View.DynamicIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000484")]
		public bool IsClaimable
		{
			[Cpp2IlInjected.Token(Token = "0x6001B8C")]
			[Cpp2IlInjected.Address(RVA = "0xF1A0C0", Offset = "0xF18AC0", VA = "0x180F1A0C0")]
			get
			{
				return _isClaimable;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B8D")]
			[Cpp2IlInjected.Address(RVA = "0xF1A0D0", Offset = "0xF18AD0", VA = "0x180F1A0D0")]
			set
			{
				if (_isClaimable != value)
				{
					_isClaimable = value;
					object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B8E")]
		[Cpp2IlInjected.Address(RVA = "0xF19F90", Offset = "0xF18990", VA = "0x180F19F90", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0061
			base.RefreshDisplay();
			UnityEvent[] phases = Phases;
			DreamlightMenu.Phase phase = Phase;
			phases[(int)phase]?.Invoke();
			if (!_isClaimable)
			{
				OnReleaseClaimChangeButtonBackground();
				if (!_isClaimable)
				{
					goto IL_0045;
				}
			}
			UnityEvent[] uiEvents = UiEvents;
			goto IL_0045;
			IL_0045:
			UiEvents[0]?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B8F")]
		[Cpp2IlInjected.Address(RVA = "0xF19CD0", Offset = "0xF186D0", VA = "0x180F19CD0")]
		public void OnPressClaimChangeButtonBackground()
		{
			//Discarded unreachable code: IL_006f
			if (ClaimBackgroundLeft.activeSelf && ClaimBackgroundRight.activeSelf)
			{
				Transform parent = base.transform.parent.parent;
				GameObject claimButtonBackgroundLeft = ClaimButtonBackgroundLeft;
				int active = 0;
				claimButtonBackgroundLeft.SetActive((byte)active != 0);
				GameObject claimButtonBackgroundRight = ClaimButtonBackgroundRight;
				int active2 = 0;
				claimButtonBackgroundRight.SetActive((byte)active2 != 0);
				HighlightButtonBackgroundLeft.SetActive(value: true);
				HighlightButtonBackgroundRight.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B90")]
		[Cpp2IlInjected.Address(RVA = "0xF19F60", Offset = "0xF18960", VA = "0x180F19F60")]
		public void PlayClaimVfx()
		{
			//Discarded unreachable code: IL_000c
			VfxItemClaim.Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B91")]
		[Cpp2IlInjected.Address(RVA = "0xF19DF0", Offset = "0xF187F0", VA = "0x180F19DF0")]
		public void OnReleaseClaimChangeButtonBackground()
		{
			//Discarded unreachable code: IL_00d6
			Transform parent = base.transform.parent.parent;
			GameObject claimButtonBackgroundLeft = ClaimButtonBackgroundLeft;
			int active = 0;
			claimButtonBackgroundLeft.SetActive((byte)active != 0);
			GameObject claimButtonBackgroundRight = ClaimButtonBackgroundRight;
			int active2 = 0;
			claimButtonBackgroundRight.SetActive((byte)active2 != 0);
			bool active3 = default(bool);
			BackgroundLeft.SetActive(active3);
			bool active4 = default(bool);
			BackgroundRight.SetActive(active4);
			GameObject highlightButtonBackgroundLeft = HighlightButtonBackgroundLeft;
			bool isHighlighted = ((TemplateButton)this)._isHighlighted;
			highlightButtonBackgroundLeft.SetActive(isHighlighted);
			GameObject highlightButtonBackgroundRight = HighlightButtonBackgroundRight;
			bool isHighlighted2 = ((TemplateButton)this)._isHighlighted;
			highlightButtonBackgroundRight.SetActive(isHighlighted2);
			GameObject claimBackgroundLeft = ClaimBackgroundLeft;
			int active5 = 0;
			claimBackgroundLeft.SetActive((byte)active5 != 0);
			GameObject claimBackgroundRight = ClaimBackgroundRight;
			int active6 = 0;
			claimBackgroundRight.SetActive((byte)active6 != 0);
			GameObject claimButtonBackgroundRight2 = ClaimButtonBackgroundRight;
			int active7 = 0;
			claimButtonBackgroundRight2.SetActive((byte)active7 != 0);
			GameObject claimButtonBackgroundLeft2 = ClaimButtonBackgroundLeft;
			int active8 = 0;
			claimButtonBackgroundLeft2.SetActive((byte)active8 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B92")]
		[Cpp2IlInjected.Address(RVA = "0xF19940", Offset = "0xF18340", VA = "0x180F19940")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_00c9, IL_00ca
			HighlightBackgroundLeft.SetActive(value: true);
			HighlightBackgroundRight.SetActive(value: true);
			HighlightButtonBackgroundLeft.SetActive(value: true);
			HighlightButtonBackgroundRight.SetActive(value: true);
			GameObject backgroundLeft = BackgroundLeft;
			int active = 0;
			backgroundLeft.SetActive((byte)active != 0);
			GameObject backgroundRight = BackgroundRight;
			int active2 = 0;
			backgroundRight.SetActive((byte)active2 != 0);
			GameObject buttonBackgroundLeft = ButtonBackgroundLeft;
			int active3 = 0;
			buttonBackgroundLeft.SetActive((byte)active3 != 0);
			GameObject buttonBackgroundRight = ButtonBackgroundRight;
			int active4 = 0;
			buttonBackgroundRight.SetActive((byte)active4 != 0);
			GameObject claimBackgroundLeft = ClaimBackgroundLeft;
			int active5 = 0;
			claimBackgroundLeft.SetActive((byte)active5 != 0);
			GameObject claimBackgroundRight = ClaimBackgroundRight;
			int active6 = 0;
			claimBackgroundRight.SetActive((byte)active6 != 0);
			GameObject claimButtonBackgroundRight = ClaimButtonBackgroundRight;
			int active7 = 0;
			claimButtonBackgroundRight.SetActive((byte)active7 != 0);
			GameObject claimButtonBackgroundLeft = ClaimButtonBackgroundLeft;
			int active8 = 0;
			claimButtonBackgroundLeft.SetActive((byte)active8 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B93")]
		[Cpp2IlInjected.Address(RVA = "0xF19A90", Offset = "0xF18490", VA = "0x180F19A90")]
		public void OnHighlightRemove()
		{
			//Discarded unreachable code: IL_014a, IL_014b
			GameObject highlightBackgroundLeft = HighlightBackgroundLeft;
			int active = 0;
			highlightBackgroundLeft.SetActive((byte)active != 0);
			GameObject highlightBackgroundRight = HighlightBackgroundRight;
			int active2 = 0;
			highlightBackgroundRight.SetActive((byte)active2 != 0);
			GameObject highlightButtonBackgroundLeft = HighlightButtonBackgroundLeft;
			int active3 = 0;
			highlightButtonBackgroundLeft.SetActive((byte)active3 != 0);
			GameObject highlightButtonBackgroundRight = HighlightButtonBackgroundRight;
			int active4 = 0;
			highlightButtonBackgroundRight.SetActive((byte)active4 != 0);
			GameObject backgroundLeft = BackgroundLeft;
			if (!_isClaimable)
			{
				backgroundLeft.SetActive(value: true);
				BackgroundRight.SetActive(value: true);
				ButtonBackgroundLeft.SetActive(value: true);
				ButtonBackgroundRight.SetActive(value: true);
				GameObject claimBackgroundLeft = ClaimBackgroundLeft;
				int active5 = 0;
				claimBackgroundLeft.SetActive((byte)active5 != 0);
				GameObject claimBackgroundRight = ClaimBackgroundRight;
				int active6 = 0;
				claimBackgroundRight.SetActive((byte)active6 != 0);
				GameObject claimButtonBackgroundRight = ClaimButtonBackgroundRight;
				int active7 = 0;
				claimButtonBackgroundRight.SetActive((byte)active7 != 0);
				GameObject claimButtonBackgroundLeft = ClaimButtonBackgroundLeft;
			}
			int active8 = 0;
			backgroundLeft.SetActive((byte)active8 != 0);
			GameObject backgroundRight = BackgroundRight;
			int active9 = 0;
			backgroundRight.SetActive((byte)active9 != 0);
			GameObject buttonBackgroundLeft = ButtonBackgroundLeft;
			int active10 = 0;
			buttonBackgroundLeft.SetActive((byte)active10 != 0);
			GameObject buttonBackgroundRight = ButtonBackgroundRight;
			int active11 = 0;
			buttonBackgroundRight.SetActive((byte)active11 != 0);
			ClaimBackgroundLeft.SetActive(value: true);
			ClaimBackgroundRight.SetActive(value: true);
			ClaimButtonBackgroundRight.SetActive(value: true);
			ClaimButtonBackgroundLeft.SetActive(value: true);
			object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B94")]
		[Cpp2IlInjected.Address(RVA = "0xF1A080", Offset = "0xF18A80", VA = "0x180F1A080")]
		public DreamlightItemView()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
