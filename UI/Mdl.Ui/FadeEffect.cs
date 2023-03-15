using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000292")]
	public class FadeEffect : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B93")]
		[SerializeField]
		private Image _fadeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B94")]
		[SerializeField]
		private ThrobberIcon _throbberIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B95")]
		[SerializeField]
		private ThrobberIcon _throbberIconMiddle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B96")]
		[Header("Events")]
		public UnityEvent OnFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B97")]
		public UnityEvent OnFadeOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B98")]
		private Tween<Color> _fadeEffect;

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public bool IsInTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6001034")]
			[Cpp2IlInjected.Address(RVA = "0x1526450", Offset = "0x1524E50", VA = "0x181526450")]
			get
			{
				Image fadeColor = _fadeColor;
				int num = 0;
				Color color = default(Color);
				float a = color.a;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001035")]
		[Cpp2IlInjected.Address(RVA = "0x1525E80", Offset = "0x1524880", VA = "0x181525E80")]
		public void Fade(float duration, Color startColor, Color endColor, EasingFunction easing, bool preventSameColorTransition = true, [Optional] Tween<Color>.FinishEventHandler onFinish)
		{
			//Discarded unreachable code: IL_0047, IL_007e, IL_0089, IL_00b1, IL_00d0
			//IL_001d: Expected O, but got I8
			//IL_006c: Expected O, but got I4
			Tween<Color> fadeEffect = _fadeEffect;
			if (fadeEffect != null)
			{
				int reverse = 0;
				((Tween<T>)(object)fadeEffect).ForceToFinish((byte)reverse != 0);
				_fadeEffect = (Tween<Color>)0;
			}
			Image fadeColor = _fadeColor;
			GameObject gameObject = _fadeColor.gameObject;
			if ((object)gameObject == null)
			{
			}
			gameObject.SetActive(value: true);
			Image fadeColor2 = _fadeColor;
		}

		[Cpp2IlInjected.Token(Token = "0x6001036")]
		[Cpp2IlInjected.Address(RVA = "0x15262B0", Offset = "0x1524CB0", VA = "0x1815262B0")]
		public void SetLogoVisibility(bool isVisible, float duration = 0.1f, bool isMiddle = false)
		{
			//Discarded unreachable code: IL_0024
			while (!isMiddle)
			{
				ThrobberIcon throbberIcon = _throbberIcon;
				if (!isVisible)
				{
					throbberIcon.Hide(duration);
					return;
				}
			}
			_throbberIconMiddle.Show(duration);
		}

		[Cpp2IlInjected.Token(Token = "0x6001037")]
		[Cpp2IlInjected.Address(RVA = "0x1526320", Offset = "0x1524D20", VA = "0x181526320")]
		private void UpdateFadeEffect(Color color, float progress)
		{
			//Discarded unreachable code: IL_0028
			if ((object)_fadeColor == null && (object)_fadeColor == null)
			{
				GameObject gameObject = _fadeColor.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001038")]
		[Cpp2IlInjected.Address(RVA = "0x15263D0", Offset = "0x1524DD0", VA = "0x1815263D0")]
		private void Update()
		{
			//IL_0032: Expected O, but got I8
			Tween<Color> fadeEffect = _fadeEffect;
			if (fadeEffect != null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				int reverse = 0;
				if (!((Tween<T>)(object)fadeEffect).Play(deltaTime, (byte)reverse != 0) && fadeEffect == _fadeEffect)
				{
					_fadeEffect = (Tween<Color>)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001039")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FadeEffect()
		{
		}
	}
}
