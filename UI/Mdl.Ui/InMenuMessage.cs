using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	public class InMenuMessage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		[SerializeField]
		private Image _blocker;

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0xD20BE0", Offset = "0xD1F5E0", VA = "0x180D20BE0", Slot = "4")]
		public virtual void Show()
		{
			//Discarded unreachable code: IL_0063
			Image blocker = _blocker;
			RectTransform content = _content;
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			base.gameObject.SetActive(value: true);
			Image blocker2 = _blocker;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)_content, 1f, 0.3f)).SetEase(Ease.OutBack).SetDelay(0.2f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0xD20AA0", Offset = "0xD1F4A0", VA = "0x180D20AA0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_004f
			//IL_0029: Expected F4, but got I4
			Image blocker = _blocker;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			RectTransform content = _content;
			int num5 = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)content, (float)num5, 0.2f);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InMenuMessage()
		{
		}
	}
}
