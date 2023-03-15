using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000208")]
	public class TutorialBubble : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008EF")]
		[SerializeField]
		protected TextBase Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008F0")]
		[SerializeField]
		protected ThreeNineSlices background;

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x17F3670", Offset = "0x17F2070", VA = "0x1817F3670", Slot = "4")]
		internal virtual void Init(Transform target, TutorialBubbleConfig bubbleConfig)
		{
			//Discarded unreachable code: IL_00c5
			//IL_001d: Expected O, but got I4
			int num = 0;
			RectTransform component = GetComponent<RectTransform>();
			Vector3 zero = Vector3.zero;
			float z = zero.z;
			component.localScale = (Vector3)num;
			TextBase label = Label;
			string stringID = label._stringID;
			string label2 = bubbleConfig.Label;
			if ((object)zero == null)
			{
				label._stringID = label2;
				label.RefreshText();
			}
			TutorialBubbleConfig.BubblePosition position = bubbleConfig.Position;
			if (position != 0)
			{
				if (position != 0 && position != 0)
				{
					if (position != TutorialBubbleConfig.BubblePosition.Left)
					{
						goto IL_00b8;
					}
					int num2 = 0;
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(component, 50f, 1f, (byte)num2 != 0);
				}
				Transform transform = background.transform;
				int num3 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(component, -50f, 1f, (byte)num3 != 0);
			}
			int num4 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(component, 50f, 1f, (byte)num4 != 0);
			goto IL_00b8;
			IL_00b8:
			float z2 = Vector3.one.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TutorialBubble()
		{
		}
	}
}
