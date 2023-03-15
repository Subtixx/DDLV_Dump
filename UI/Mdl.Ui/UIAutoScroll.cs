using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008B4")]
	public class UIAutoScroll : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008B5")]
		public enum ScrollDirection
		{
			[Cpp2IlInjected.Token(Token = "0x400342C")]
			Vertical,
			[Cpp2IlInjected.Token(Token = "0x400342D")]
			Horizontal
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003424")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003425")]
		public bool AutoScrollOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003426")]
		[Header("Animation config")]
		public ScrollDirection _scrollDirection = ScrollDirection.Horizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003427")]
		public float ScrollSpeed = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003428")]
		public float StartDelay = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003429")]
		private Sequence _scrollSequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400342A")]
		[SerializeField]
		private float visibleSize;

		[Cpp2IlInjected.Token(Token = "0x600370A")]
		[Cpp2IlInjected.Address(RVA = "0x3F216C0", Offset = "0x3F200C0", VA = "0x183F216C0")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			ScrollRect scrollRect = _scrollRect;
			int num = 0;
			if (scrollRect == (Object)num)
			{
				ScrollRect scrollRect2 = (_scrollRect = GetComponent<ScrollRect>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370B")]
		[Cpp2IlInjected.Address(RVA = "0x3F21780", Offset = "0x3F20180", VA = "0x183F21780")]
		private void OnEnable()
		{
			if (AutoScrollOnStart)
			{
				ScrollDirection scrollDirection = _scrollDirection;
				StartAutoScroll(scrollDirection);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370C")]
		[Cpp2IlInjected.Address(RVA = "0x3F21760", Offset = "0x3F20160", VA = "0x183F21760")]
		private void OnDestroy()
		{
			Sequence scrollSequence = _scrollSequence;
			if (scrollSequence != null)
			{
				int complete = 0;
				scrollSequence.Kill((byte)complete != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370D")]
		[Cpp2IlInjected.Address(RVA = "0x3F21B30", Offset = "0x3F20530", VA = "0x183F21B30")]
		public void StartAutoScroll()
		{
			ScrollDirection scrollDirection = _scrollDirection;
			StartAutoScroll(scrollDirection);
		}

		[Cpp2IlInjected.Token(Token = "0x600370E")]
		[Cpp2IlInjected.Address(RVA = "0x3F217A0", Offset = "0x3F201A0", VA = "0x183F217A0")]
		public void StartAutoScroll(ScrollDirection scrollDir)
		{
			//Discarded unreachable code: IL_0119
			//IL_0040: Expected F4, but got I4
			//IL_0090: Expected F4, but got I4
			Sequence scrollSequence = _scrollSequence;
			if (scrollSequence != null)
			{
				int complete = 0;
				scrollSequence.Kill((byte)complete != 0);
			}
			int num = 0;
			Sequence sequence = (_scrollSequence = DOTween.Sequence());
			if (_scrollDirection == ScrollDirection.Vertical)
			{
				ScrollRect scrollRect = _scrollRect;
				int num2 = 0;
				scrollRect.verticalNormalizedPosition = num2;
				RectTransform content = _scrollRect.m_Content;
				float startDelay = StartDelay;
				Sequence sequence2 = _scrollSequence.SetDelay(startDelay);
				DOGetter<float> dOGetter = (DOGetter<float>)(object)(DOGetter<T>)(() => _scrollRect.verticalNormalizedPosition);
			}
			DOSetter<float> dOSetter = default(DOSetter<float>);
			if ((long)dOSetter == 1)
			{
				ScrollRect scrollRect2 = _scrollRect;
				int num3 = 0;
				scrollRect2.horizontalNormalizedPosition = num3;
				RectTransform content2 = _scrollRect.m_Content;
				float startDelay2 = StartDelay;
				Sequence sequence3 = _scrollSequence.SetDelay(startDelay2);
				Sequence scrollSequence2 = _scrollSequence;
				DOGetter<float> dOGetter2 = (DOGetter<float>)(object)(DOGetter<T>)(() => _scrollRect.horizontalNormalizedPosition);
				DOSetter<float> dOSetter2 = (DOSetter<float>)(object)(DOSetter<T>)delegate(float x)
				{
					//Discarded unreachable code: IL_000d
					_scrollRect.horizontalNormalizedPosition = x;
				};
				TweenerCore<float, float, FloatOptions> t = default(TweenerCore<float, float, FloatOptions>);
				TweenerCore<float, float, FloatOptions> t2 = t.SetEase(Ease.Linear);
				Sequence sequence4 = scrollSequence2.Append(t2);
				float startDelay3 = StartDelay;
				int loopType = 0;
				Sequence sequence5 = _scrollSequence.AppendInterval(startDelay3);
				Sequence sequence6 = _scrollSequence.SetLoops(-1, (LoopType)loopType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600370F")]
		[Cpp2IlInjected.Address(RVA = "0x3F21760", Offset = "0x3F20160", VA = "0x183F21760")]
		public void KillTween()
		{
			Sequence scrollSequence = _scrollSequence;
			if (scrollSequence != null)
			{
				int complete = 0;
				scrollSequence.Kill((byte)complete != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003710")]
		[Cpp2IlInjected.Address(RVA = "0x3F21BC0", Offset = "0x3F205C0", VA = "0x183F21BC0")]
		public UIAutoScroll()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
