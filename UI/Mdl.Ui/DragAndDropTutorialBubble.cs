using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000205")]
	public class DragAndDropTutorialBubble : TutorialBubble
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008E5")]
		[SerializeField]
		private RectTransform bubble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40008E6")]
		[SerializeField]
		private RectTransform handCursor;

		[Cpp2IlInjected.Token(Token = "0x6000CEA")]
		[Cpp2IlInjected.Address(RVA = "0xF17C70", Offset = "0xF16670", VA = "0x180F17C70", Slot = "4")]
		internal override void Init(Transform target, TutorialBubbleConfig bubbleConfig)
		{
			//Discarded unreachable code: IL_0208
			//IL_0012: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_011b: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			//IL_01c6: Expected O, but got I4
			//IL_0205: Expected O, but got I4
			RectTransform rectTransform = bubble;
			int num = 0;
			int num2 = 0;
			rectTransform.localScale = (Vector3)num2;
			TextBase label = Label;
			string text = (label.StringID = bubbleConfig.Label);
			TutorialBubbleConfig.BubblePosition position = bubbleConfig.Position;
			if (position != 0)
			{
				if (position != 0)
				{
					if (position != 0)
					{
						if (position != TutorialBubbleConfig.BubblePosition.Left)
						{
							goto IL_0137;
						}
						RectTransform rectTransform2 = bubble;
						RectTransform rectTransform3 = bubble;
						bubble.anchoredPosition = (Vector2)num;
						int num3 = 0;
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(bubble, 50f, 1f, (byte)num3 != 0);
					}
					RectTransform rectTransform4 = bubble;
					RectTransform rectTransform5 = bubble;
					bubble.anchoredPosition = (Vector2)num;
				}
				ThreeNineSlices threeNineSlices = background;
				int num4 = 0;
				threeNineSlices.transform.localScale = (Vector3)num4;
				Transform transform = Label.transform;
				RectTransform rectTransform6 = bubble;
				RectTransform rectTransform7 = bubble;
				bubble.anchoredPosition = (Vector2)num;
				int num5 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(bubble, -50f, 1f, (byte)num5 != 0);
			}
			RectTransform rectTransform8 = bubble;
			RectTransform rectTransform9 = bubble;
			bubble.anchoredPosition = (Vector2)num;
			int num6 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(bubble, 50f, 1f, (byte)num6 != 0);
			goto IL_0137;
			IL_0137:
			RectTransform rectTransform10 = handCursor;
			int num7 = 0;
			Vector3 zero = Vector3.zero;
			rectTransform10.localScale = (Vector3)num7;
			RectTransform rectTransform11 = handCursor;
			Transform transform2 = rectTransform11.transform;
			Vector3 position2 = rectTransform11.position;
			RectTransform rectTransform12 = handCursor;
			int num8 = 0;
			Vector3 one = Vector3.one;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)rectTransform12, (Vector3)num8, 0.3f);
			RectTransform rectTransform13 = handCursor;
			Vector2 anchoredPosition = rectTransform13.anchoredPosition;
			RectTransform rectTransform14 = handCursor;
			int num9 = 0;
			Vector2 anchoredPosition2 = rectTransform14.anchoredPosition;
			int num10 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPos(rectTransform13, (Vector2)num9, 1.5f, (byte)num10 != 0);
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = t.SetDelay(0.25f);
			int loopType = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = t2.SetLoops(-1, (LoopType)loopType);
			RectTransform rectTransform15 = bubble;
			int num11 = 0;
			Vector3 one2 = Vector3.one;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore7 = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)rectTransform15, (Vector3)num11, 0.5f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public DragAndDropTutorialBubble()
		{
		}
	}
}
