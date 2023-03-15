using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002B0")]
	[RequiredAllNotNull]
	public class GardeningStallSelectionContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C34")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.Token(Token = "0x60010E6")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDE0", Offset = "0xE4A7E0", VA = "0x180E4BDE0")]
		public void Show(float delay = 0f)
		{
			//Discarded unreachable code: IL_005b
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			int complete = 0;
			int num = DOTween.Kill(mcAnimatedContent, (byte)complete != 0);
			RectTransform mcAnimatedContent2 = _mcAnimatedContent;
			float z = Vector3.zero.z;
			_mcAnimatedContent.gameObject.SetActive(value: true);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)_mcAnimatedContent, 1f, 0.35f)).SetEase(Ease.OutBack).SetDelay(delay);
		}

		[Cpp2IlInjected.Token(Token = "0x60010E7")]
		[Cpp2IlInjected.Address(RVA = "0xE4BCA0", Offset = "0xE4A6A0", VA = "0x180E4BCA0")]
		public void Hide()
		{
			//IL_0028: Expected F4, but got I4
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			int complete = 0;
			int num = DOTween.Kill(mcAnimatedContent, (byte)complete != 0);
			RectTransform mcAnimatedContent2 = _mcAnimatedContent;
			int num2 = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)mcAnimatedContent2, (float)num2, 0.35f)).SetEase(Ease.InBack);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0016
				GameObject gameObject = _mcAnimatedContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010E8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GardeningStallSelectionContent()
		{
		}
	}
}
