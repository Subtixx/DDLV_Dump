using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000293")]
	public class PulseAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B99")]
		[SerializeField]
		[Header("Components")]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B9A")]
		[SerializeField]
		[Header("Animation config")]
		private bool _animateOnStart = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000B9B")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _startOpacity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B9C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _endOpacity = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000B9D")]
		[SerializeField]
		[Min(0f)]
		[Tooltip("Time it would take to go from Start Opacity to End Opacity")]
		private float _deltaTimeOpacity = 2f;

		[Cpp2IlInjected.Token(Token = "0x600103B")]
		[Cpp2IlInjected.Address(RVA = "0xE1F2F0", Offset = "0xE1DCF0", VA = "0x180E1F2F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0048
			CanvasGroup canvasGroup = _canvasGroup;
			float startOpacity = _startOpacity;
			int loopType = 0;
			canvasGroup.alpha = startOpacity;
			if (_animateOnStart)
			{
				float deltaTimeOpacity = _deltaTimeOpacity;
				float endOpacity = _endOpacity;
				TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, endOpacity, deltaTimeOpacity)).SetLoops(-1, (LoopType)loopType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600103C")]
		[Cpp2IlInjected.Address(RVA = "0xE1F290", Offset = "0xE1DC90", VA = "0x180E1F290")]
		public void PlayAnimation()
		{
			float deltaTimeOpacity = _deltaTimeOpacity;
			float endOpacity = _endOpacity;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, endOpacity, deltaTimeOpacity);
		}

		[Cpp2IlInjected.Token(Token = "0x600103D")]
		[Cpp2IlInjected.Address(RVA = "0xE1F370", Offset = "0xE1DD70", VA = "0x180E1F370")]
		public PulseAnimation()
		{
		}
	}
}
