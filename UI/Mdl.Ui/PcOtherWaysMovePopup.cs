using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004BE")]
	public class PcOtherWaysMovePopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40018F8")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40018F9")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40018FA")]
		[SerializeField]
		private ButtonTmPro _btnNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40018FB")]
		[SerializeField]
		private List<GameObject> _listSteps;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40018FC")]
		[SerializeField]
		private GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40018FD")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40018FE")]
		private int _step;

		[Cpp2IlInjected.Token(Token = "0x6001EED")]
		[Cpp2IlInjected.Address(RVA = "0x9B50C0", Offset = "0x9B3AC0", VA = "0x1809B50C0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0022
			base.OnPush(stack, param);
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			ShowNextStep();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEE")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F10", Offset = "0x9B3910", VA = "0x1809B4F10", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0083
			//IL_001d: Expected O, but got I4
			base.OnFocusIn();
			Image mcBlocker = _mcBlocker;
			int num = 0;
			int num2 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBlocker, (Color)num, 0.35f);
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
			RectTransform mcContent2 = _mcContent;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			ParticleSystem[] array = _sparkles;
			int length = array.Length;
			if (num2 < length)
			{
				ParticleSystemManager.Play(array[num2]);
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEF")]
		[Cpp2IlInjected.Address(RVA = "0x9B51C0", Offset = "0x9B3BC0", VA = "0x1809B51C0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__9))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__9 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF0")]
		[Cpp2IlInjected.Address(RVA = "0x9B5240", Offset = "0x9B3C40", VA = "0x1809B5240", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF1")]
		[Cpp2IlInjected.Address(RVA = "0x9B5590", Offset = "0x9B3F90", VA = "0x1809B5590", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002c
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF2")]
		[Cpp2IlInjected.Address(RVA = "0x9B50B0", Offset = "0x9B3AB0", VA = "0x1809B50B0")]
		private void OnNextClickHandler()
		{
			ShowNextStep();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF3")]
		[Cpp2IlInjected.Address(RVA = "0x9B52F0", Offset = "0x9B3CF0", VA = "0x1809B52F0")]
		private void ShowNextStep()
		{
			//Discarded unreachable code: IL_0032, IL_0037, IL_003a, IL_004c, IL_0052
			//IL_002b: Expected O, but got I4
			int size = ((List<>)(object)_listSteps)._size;
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num = 0;
					answerAction((T)num);
				}
			}
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF4")]
		[Cpp2IlInjected.Address(RVA = "0x9B5150", Offset = "0x9B3B50", VA = "0x1809B5150")]
		private void PlaySparkles()
		{
			//Discarded unreachable code: IL_0025
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				ParticleSystemManager.Play(array[num]);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF5")]
		[Cpp2IlInjected.Address(RVA = "0x9B5520", Offset = "0x9B3F20", VA = "0x1809B5520")]
		private void StopSparkles()
		{
			//Discarded unreachable code: IL_0025
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Stop();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF6")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E80", Offset = "0x9B3880", VA = "0x1809B4E80", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0029
			Button buttonComponent = _btnNext.ButtonComponent;
			_btnNext.ButtonComponent.m_OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001EF7")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public PcOtherWaysMovePopup()
		{
		}
	}
}
