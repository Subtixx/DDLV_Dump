using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000504")]
	public class PresentPopUp : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001B08")]
		private bool _closed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001B09")]
		private PresentPopUpParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001B0A")]
		private int _currentPhaseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001B0B")]
		public AK.Wwise.Event _sfxOpenPresentEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001B0C")]
		public AK.Wwise.Event _sfxClosePresentEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001B0D")]
		public AK.Wwise.Event _sfxRevealItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001B0E")]
		[SerializeField]
		private PresentItems _mcPresentItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4001B0F")]
		[SerializeField]
		private List<GameObject> _listPhases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001B10")]
		[SerializeField]
		private IPresentBoxPhase _currentPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001B11")]
		private bool _isOpened;

		[Cpp2IlInjected.Token(Token = "0x600209F")]
		[Cpp2IlInjected.Address(RVA = "0xE1A840", Offset = "0xE19240", VA = "0x180E1A840", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (PresentPopUpParam)param;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1A830", Offset = "0xE19230", VA = "0x180E1A830", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x60020A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1A720", Offset = "0xE19120", VA = "0x180E1A720", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_005b
			//IL_0031: Expected I4, but got I8
			base.OnFocusIn();
			PresentPopUpParam param = _param;
			if (param != null)
			{
				List<ItemReward> _003CRewards_003Ek__BackingField = param.Rewards;
				if (_003CRewards_003Ek__BackingField != null)
				{
					_mcPresentItems.RefreshData((List<>)(object)_003CRewards_003Ek__BackingField);
				}
			}
			_currentPhaseIndex = 0;
			int playAnimation = 0;
			int phaseIndex = 0;
			ShowPresentBoxPhase(phaseIndex, (byte)playAnimation != 0);
			IPresentBoxPhase currentPhase = _currentPhase;
			Action action = delegate
			{
				IPresentBoxPhase currentPhase2 = _currentPhase;
				throw new NullReferenceException();
			};
			((Menu)this).IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1AB90", Offset = "0xE19590", VA = "0x180E1AB90", Slot = "29")]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			return base.PreFocusOut(popAfterPreFocusOut);
		}

		[Cpp2IlInjected.Token(Token = "0x60020A3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60020A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x60020A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF00", Offset = "0xE19900", VA = "0x180E1AF00")]
		private void Update()
		{
			int num = 0;
			if (Input.anyKeyDown)
			{
				int phaseIndex = 0;
				OnScreenClicked(phaseIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1ABA0", Offset = "0xE195A0", VA = "0x180E1ABA0")]
		private void ShowPresentBoxPhase(int phaseIndex, bool playAnimation = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1A920", Offset = "0xE19320", VA = "0x180E1A920")]
		public void OnScreenClicked(int phaseIndex)
		{
			if (!_isOpened)
			{
				AK.Wwise.Event sfxOpenPresentEvent = _sfxOpenPresentEvent;
				if (sfxOpenPresentEvent != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxOpenPresentEvent.Post(gameObject);
				}
				_isOpened = true;
			}
			if (_mcPresentItems.gameObject.activeSelf && !TweenMax.HasCancelationToken(_mcPresentItems))
			{
				_mcPresentItems.ThrowFirstItemAway();
				int childCount = _mcPresentItems.transform.childCount;
				int num2 = 0;
				VibrationsManager.TriggerSuccess();
				IPresentBoxPhase currentPhase = _currentPhase;
				Action action = OnAllFinished;
				AK.Wwise.Event sfxRevealItem = _sfxRevealItem;
				if (sfxRevealItem != null)
				{
					GameObject gameObject2 = base.gameObject;
					uint num3 = sfxRevealItem.Post(gameObject2);
				}
				int num4 = 0;
				VibrationsManager.TriggerSuccess();
				IPresentBoxPhase currentPhase2 = _currentPhase;
				return;
			}
			IPresentBoxPhase currentPhase3 = _currentPhase;
			bool flag = default(bool);
			while (flag)
			{
			}
			IPresentBoxPhase currentPhase4 = _currentPhase;
			Action action2 = delegate
			{
				int currentPhaseIndex = _currentPhaseIndex;
				ShowPresentBoxPhase(_currentPhaseIndex = currentPhaseIndex + 1, playAnimation: true);
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1A6C0", Offset = "0xE190C0", VA = "0x180E1A6C0")]
		public void OnCloseClicked()
		{
			if (!_closed)
			{
				AK.Wwise.Event sfxClosePresentEvent = _sfxClosePresentEvent;
				_closed = true;
				if (sfxClosePresentEvent != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxClosePresentEvent.Post(gameObject);
				}
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1A6C0", Offset = "0xE190C0", VA = "0x180E1A6C0")]
		private void OnAllFinished()
		{
			if (!_closed)
			{
				AK.Wwise.Event sfxClosePresentEvent = _sfxClosePresentEvent;
				_closed = true;
				if (sfxClosePresentEvent != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxClosePresentEvent.Post(gameObject);
				}
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1A6A0", Offset = "0xE190A0", VA = "0x180E1A6A0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_000a
			int phaseIndex = 0;
			OnScreenClicked(phaseIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60020AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public PresentPopUp()
		{
		}
	}
}
