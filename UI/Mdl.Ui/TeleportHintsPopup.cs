using System;
using System.Collections;
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
	[Cpp2IlInjected.Token(Token = "0x20004CE")]
	public class TeleportHintsPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001956")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001957")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001958")]
		[SerializeField]
		private ButtonTmPro _btnOkay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001959")]
		[SerializeField]
		private GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400195A")]
		[SerializeField]
		private RectTransform[] _pages;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400195B")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400195C")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400195D")]
		private int _currentPageCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400195E")]
		private RectTransform _currentPage;

		[Cpp2IlInjected.Token(Token = "0x6001F61")]
		[Cpp2IlInjected.Address(RVA = "0x17E7B30", Offset = "0x17E6530", VA = "0x1817E7B30", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_002c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnOkay.ButtonComponent.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F62")]
		[Cpp2IlInjected.Address(RVA = "0x17E7BE0", Offset = "0x17E65E0", VA = "0x1817E7BE0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_002c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnOkay.ButtonComponent.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F63")]
		[Cpp2IlInjected.Address(RVA = "0x17E79B0", Offset = "0x17E63B0", VA = "0x1817E79B0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0035
			base.OnPush(stack, param);
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			RectTransform mcContent = _mcContent;
			float z = Vector3.zero.z;
			Image mcBackground = _mcBackground;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F64")]
		[Cpp2IlInjected.Address(RVA = "0x17E7640", Offset = "0x17E6040", VA = "0x1817E7640", Slot = "27")]
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
				//Discarded unreachable code: IL_0051
				RectTransform mcContent = _mcContent;
				float z = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetEase(Ease.OutBack);
				OnNextClickHandler();
				ParticleSystem[] array = _sparkles;
				int num3 = 0;
				int length = array.Length;
				if (num3 < length)
				{
					array[num3].Play();
					num3++;
				}
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F65")]
		[Cpp2IlInjected.Address(RVA = "0x17E74D0", Offset = "0x17E5ED0", VA = "0x1817E74D0")]
		private void AnimateIn()
		{
			//Discarded unreachable code: IL_0051
			RectTransform mcContent = _mcContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			OnNextClickHandler();
			ParticleSystem[] array = _sparkles;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].Play();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F66")]
		[Cpp2IlInjected.Address(RVA = "0x17E7AB0", Offset = "0x17E64B0", VA = "0x1817E7AB0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__14))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__14 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__14(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F67")]
		[Cpp2IlInjected.Address(RVA = "0x17E7790", Offset = "0x17E6190", VA = "0x1817E7790")]
		public void OnNextClickHandler()
		{
			//Discarded unreachable code: IL_0015, IL_0026, IL_002c, IL_003c, IL_0049, IL_0056, IL_006b, IL_00e0, IL_00e7, IL_00fc, IL_010d
			RectTransform[] pages = _pages;
			int currentPageCounter = _currentPageCounter;
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F68")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F69")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F6A")]
		[Cpp2IlInjected.Address(RVA = "0x17E75B0", Offset = "0x17E5FB0", VA = "0x1817E75B0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0029
			Button buttonComponent = _btnOkay.ButtonComponent;
			_btnOkay.ButtonComponent.m_OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6B")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public TeleportHintsPopup()
		{
		}
	}
}
