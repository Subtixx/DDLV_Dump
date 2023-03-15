using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
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
	[Cpp2IlInjected.Token(Token = "0x20004C2")]
	public class SellingReminderPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400190F")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001910")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001911")]
		[SerializeField]
		private Button _btnOkay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001912")]
		[SerializeField]
		private GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001913")]
		[SerializeField]
		private RectTransform[] _pages;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001914")]
		[SerializeField]
		private RectTransform[] _arrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001915")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.Token(Token = "0x6001F0F")]
		[Cpp2IlInjected.Address(RVA = "0x1260E50", Offset = "0x125F850", VA = "0x181260E50", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnOkay.m_OnClick;
			UnityAction call = onOkayClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F10")]
		[Cpp2IlInjected.Address(RVA = "0x1260F80", Offset = "0x125F980", VA = "0x181260F80", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnOkay.m_OnClick;
			UnityAction call = onOkayClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F11")]
		[Cpp2IlInjected.Address(RVA = "0x1260B50", Offset = "0x125F550", VA = "0x181260B50", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00a0
			base.OnPush(stack, param);
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
			Image mcBackground = _mcBackground;
			RectTransform[] pages = _pages;
			int num = 0;
			int length = pages.Length;
			if (num < length)
			{
				RectTransform rectTransform = pages[num];
				float z2 = Vector3.zero.z;
				num++;
			}
			RectTransform[] arrows = _arrows;
			int length2 = arrows.Length;
			if (num < length2)
			{
				RectTransform rectTransform2 = arrows[num];
				float z3 = Vector3.zero.z;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F12")]
		[Cpp2IlInjected.Address(RVA = "0x1260A00", Offset = "0x125F400", VA = "0x181260A00", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_004a
			//IL_0024: Expected O, but got I4
			base.OnFocusIn();
			Transform transform = base.transform;
			Image mcBackground = _mcBackground;
			int num = 0;
			int num2 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBackground, (Color)num, 0.3f);
			TweenCallback tweenCallback = delegate
			{
				AnimateIn();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F13")]
		[Cpp2IlInjected.Address(RVA = "0x1260700", Offset = "0x125F100", VA = "0x181260700")]
		private void AnimateIn()
		{
			//Discarded unreachable code: IL_00ba
			RectTransform mcContent = _mcContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			RectTransform[] pages = _pages;
			int num = 0;
			if (num < pages.Length)
			{
				RectTransform[] arrows = _arrows;
				RectTransform rectTransform = pages[num];
				RectTransform rectTransform2 = arrows[num];
				float z2 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutBack);
				float z3 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = t3.SetEase(Ease.OutBack);
				RectTransform[] pages2 = _pages;
				num++;
			}
			ParticleSystem[] array = _sparkles;
			int length = array.Length;
			if (num < length)
			{
				array[num].Play();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F14")]
		[Cpp2IlInjected.Address(RVA = "0x1260DD0", Offset = "0x125F7D0", VA = "0x181260DD0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__12))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__12 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__12(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F15")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void onOkayClickHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F16")]
		[Cpp2IlInjected.Address(RVA = "0x1260D60", Offset = "0x125F760", VA = "0x181260D60")]
		private void PlaySparkles()
		{
			//Discarded unreachable code: IL_0025
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Play();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F17")]
		[Cpp2IlInjected.Address(RVA = "0x1260F00", Offset = "0x125F900", VA = "0x181260F00")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F18")]
		[Cpp2IlInjected.Address(RVA = "0x12609B0", Offset = "0x125F3B0", VA = "0x1812609B0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0018
			_btnOkay.m_OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F19")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public SellingReminderPopup()
		{
		}
	}
}
