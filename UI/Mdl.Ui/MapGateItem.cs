using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200062F")]
	public class MapGateItem : MapBuildingItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400226F")]
		public Action OnGateItemClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002270")]
		[SerializeField]
		[NotNull]
		private RawImage _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002271")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002272")]
		[SerializeField]
		private BaseButton _baseButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002273")]
		private FastTravelDestination _fastTravelPod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002275")]
		[SerializeField]
		private AK.Wwise.Event _destinationLockedSFX;

		[Cpp2IlInjected.Token(Token = "0x1700060D")]
		public BaseButton BaseButton
		{
			[Cpp2IlInjected.Token(Token = "0x6002847")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _baseButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060E")]
		public FastTravelDestination FastTravelPod
		{
			[Cpp2IlInjected.Token(Token = "0x6002848")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _fastTravelPod;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060F")]
		public CanvasGroup BgCanvasGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6002849")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _canvasGroup;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000610")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x4002274")]
		internal override bool IsPinned
		{
			[Cpp2IlInjected.Token(Token = "0x600284A")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600284B")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600284C")]
		[Cpp2IlInjected.Address(RVA = "0x11039E0", Offset = "0x11023E0", VA = "0x1811039E0")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600284D")]
		[Cpp2IlInjected.Address(RVA = "0x117CE30", Offset = "0x117B830", VA = "0x18117CE30")]
		public void RefreshData(FastTravelDestination fastTravelPod)
		{
			//Discarded unreachable code: IL_0088
			//IL_0032: Expected O, but got I4
			_fastTravelPod = fastTravelPod;
			CanvasGroup canvasGroup = _canvasGroup;
			if (fastTravelPod.Unlocked)
			{
			}
			canvasGroup.alpha = 0.3f;
			BaseButton baseButton = _baseButton;
			int num = 0;
			if (baseButton != (UnityEngine.Object)num)
			{
				Button buttonComponent = _baseButton.ButtonComponent;
				bool flag = (buttonComponent.interactable = fastTravelPod.Unlocked);
				BaseButton baseButton2 = _baseButton;
				if (fastTravelPod.Unlocked)
				{
					BaseButton baseButton3 = _baseButton;
					bool flag2 = (baseButton3.UseScaleOnHighlight = fastTravelPod.Unlocked);
				}
				int num2 = ((baseButton2.UseScaleOnMouseOver = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600284E")]
		[Cpp2IlInjected.Address(RVA = "0x117CCF0", Offset = "0x117B6F0", VA = "0x18117CCF0", Slot = "7")]
		public override void OnClicked()
		{
			//Discarded unreachable code: IL_0053
			if (_fastTravelPod.Unlocked)
			{
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				FastTravelDestination fastTravelPod = _fastTravelPod;
				system.UseFastTravel(fastTravelPod);
				OnGateItemClicked?.Invoke();
			}
			else
			{
				AK.Wwise.Event destinationLockedSFX = _destinationLockedSFX;
				GameObject gameObject = base.gameObject;
				uint num = destinationLockedSFX.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600284F")]
		[Cpp2IlInjected.Address(RVA = "0x117CC50", Offset = "0x117B650", VA = "0x18117CC50", Slot = "6")]
		internal override void CopyTo(MapItem target)
		{
			if ((object)target != null)
			{
				int num = 0;
				if ((object)target == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002850")]
		[Cpp2IlInjected.Address(RVA = "0x117CF70", Offset = "0x117B970", VA = "0x18117CF70")]
		public MapGateItem()
		{
		}
	}
}
