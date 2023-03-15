using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000748")]
	public class TutorialInfoBox : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A7F")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A81")]
		[SerializeField]
		private RectTransform _arrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A82")]
		private Action _boxShownCallBack;

		[Cpp2IlInjected.Token(Token = "0x6002E8A")]
		[Cpp2IlInjected.Address(RVA = "0x17F45E0", Offset = "0x17F2FE0", VA = "0x1817F45E0")]
		public void AnimateIn(float delay, Action boxShownCallBack)
		{
			//Discarded unreachable code: IL_0108
			//IL_0017: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			_boxShownCallBack = boxShownCallBack;
			RectTransform content = _content;
			int num = 0;
			if (content != (UnityEngine.Object)num)
			{
				Vector2 anchoredPosition = _content.anchoredPosition;
				TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, 1f, 0.42f)).SetEase(Ease.OutQuart).SetDelay(delay).Play();
				RectTransform content2 = _content;
				int num2 = 0;
				Vector2 anchoredPosition2 = content2.anchoredPosition;
				content2.anchoredPosition = (Vector2)num2;
				RectTransform content3 = _content;
				TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = t.SetEase(Ease.OutQuart).SetDelay(delay);
				TweenCallback action = OnBoxShown;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t2.OnComplete(action).Play();
			}
			RectTransform arrow = _arrow;
			int num3 = 0;
			if (arrow != (UnityEngine.Object)num3)
			{
				Vector2 anchoredPosition3 = _arrow.anchoredPosition;
				RectTransform arrow2 = _arrow;
				int num4 = 0;
				Vector2 anchoredPosition4 = arrow2.anchoredPosition;
				arrow2.anchoredPosition = (Vector2)num4;
				RectTransform arrow3 = _arrow;
				TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = t3.SetEase(Ease.OutQuart).SetDelay(delay).Play();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8B")]
		[Cpp2IlInjected.Address(RVA = "0x17F4940", Offset = "0x17F3340", VA = "0x1817F4940")]
		public void Show()
		{
			//Discarded unreachable code: IL_0011
			_canvasGroup.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8C")]
		[Cpp2IlInjected.Address(RVA = "0x17F4920", Offset = "0x17F3320", VA = "0x1817F4920")]
		private void OnBoxShown()
		{
			_boxShownCallBack?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TutorialInfoBox()
		{
		}
	}
}
