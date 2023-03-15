using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004C0")]
	public class SandboxLoopPopup : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001903")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001904")]
		[SerializeField]
		private RectTransform _mcTitleContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001905")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001906")]
		[SerializeField]
		private GameObject sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001907")]
		[SerializeField]
		private RectTransform[] _pages;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001908")]
		private int _currentPageCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001909")]
		private RectTransform _currentPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400190A")]
		private ParticleSystem[] _sparkles;

		[Cpp2IlInjected.Token(Token = "0x6001EFF")]
		[Cpp2IlInjected.Address(RVA = "0xE42F00", Offset = "0xE41900", VA = "0x180E42F00")]
		private void Awake()
		{
			ParticleSystem[] array = (_sparkles = sparkles.GetComponentsInChildren<ParticleSystem>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F00")]
		[Cpp2IlInjected.Address(RVA = "0xE42F60", Offset = "0xE41960", VA = "0x180E42F60", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_005f
			//IL_0039: Expected O, but got I4
			base.OnFocusIn();
			Transform transform = base.transform;
			RectTransform rectTransform = content;
			float z = Vector3.zero.z;
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

		[Cpp2IlInjected.Token(Token = "0x6001F01")]
		[Cpp2IlInjected.Address(RVA = "0xE42CF0", Offset = "0xE416F0", VA = "0x180E42CF0")]
		private void AnimateIn()
		{
			//Discarded unreachable code: IL_00c9
			//IL_0089: Expected O, but got I4
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcTitleContent);
			RectTransform rectTransform = content;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			int length = _pages.Length;
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			int num2 = 0;
			popupStack.Pop();
			RectTransform currentPage = _currentPage;
			if ((object)currentPage != null)
			{
				GameObject gameObject = currentPage.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			int currentPageCounter = _currentPageCounter;
			_currentPage = (RectTransform)num2;
			_currentPage.gameObject.SetActive(value: true);
			ParticleSystem[] array = _sparkles;
			int num3 = 0;
			int length2 = array.Length;
			if (num3 < length2)
			{
				ParticleSystemManager.Play(array[num3]);
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F02")]
		[Cpp2IlInjected.Address(RVA = "0xE43260", Offset = "0xE41C60", VA = "0x180E43260", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__11))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__11 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F03")]
		[Cpp2IlInjected.Address(RVA = "0xE430F0", Offset = "0xE41AF0", VA = "0x180E430F0")]
		public void OnNextClickHandler()
		{
			//Discarded unreachable code: IL_0022, IL_0026, IL_003a, IL_0047
			int length = _pages.Length;
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			int num2 = 0;
			popupStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F04")]
		[Cpp2IlInjected.Address(RVA = "0xE431F0", Offset = "0xE41BF0", VA = "0x180E431F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F05")]
		[Cpp2IlInjected.Address(RVA = "0xE432E0", Offset = "0xE41CE0", VA = "0x180E432E0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F06")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public SandboxLoopPopup()
		{
		}
	}
}
