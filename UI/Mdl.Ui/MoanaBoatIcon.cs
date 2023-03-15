using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002BB")]
	[RequiredAllNotNull]
	public class MoanaBoatIcon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C8D")]
		[SerializeField]
		private RectTransform _mcWave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C8E")]
		[SerializeField]
		private RectTransform _mcBoat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C8F")]
		public TextBase LevelLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C90")]
		private Sequence _tweenHead;

		[Cpp2IlInjected.Token(Token = "0x6001137")]
		[Cpp2IlInjected.Address(RVA = "0x1293DF0", Offset = "0x12927F0", VA = "0x181293DF0")]
		public void StartAnimation()
		{
			//Discarded unreachable code: IL_0153
			//IL_0063: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> t = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(_mcWave, -127.5f, 4f, (byte)num2 != 0)).SetEase(Ease.Linear);
			int loopType = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetLoops(-1, (LoopType)loopType);
			Vector2 anchoredPosition = _mcBoat.anchoredPosition;
			int num3 = 0;
			Sequence s = DOTween.Sequence();
			Transform transform = _mcBoat.transform;
			int num4 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ((TweenerCore<Quaternion, Vector3, QuaternionOptions>)(object)ShortcutExtensions.DORotate(transform, (Vector3)num, 1.05f, (RotateMode)num4)).SetEase(Ease.Linear);
			Sequence s2 = s.Append(t2);
			RectTransform mcBoat = _mcBoat;
			TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> t4 = t3.SetEase(Ease.Linear);
			Sequence s3 = s2.Join(t4);
			Transform transform2 = _mcBoat.transform;
			int num5 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t5 = ((TweenerCore<Quaternion, Vector3, QuaternionOptions>)(object)ShortcutExtensions.DORotate(transform2, (Vector3)num, 1.05f, (RotateMode)num5)).SetEase(Ease.Linear);
			Sequence s4 = s3.Append(t5);
			RectTransform mcBoat2 = _mcBoat;
			TweenerCore<Vector2, Vector2, VectorOptions> t6 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> t7 = t6.SetEase(Ease.Linear);
			Sequence s5 = s4.Join(t7);
			Transform transform3 = _mcBoat.transform;
			int num6 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t8 = ((TweenerCore<Quaternion, Vector3, QuaternionOptions>)(object)ShortcutExtensions.DORotate(transform3, (Vector3)num, 1.05f, (RotateMode)num6)).SetEase(Ease.Linear);
			Sequence s6 = s5.Append(t8);
			RectTransform mcBoat3 = _mcBoat;
			TweenerCore<Vector2, Vector2, VectorOptions> t9 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> t10 = t9.SetEase(Ease.Linear);
			Sequence sequence = (_tweenHead = s6.Join(t10));
			int loopType2 = 0;
			Sequence sequence2 = _tweenHead.SetLoops(-1, (LoopType)loopType2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001138")]
		[Cpp2IlInjected.Address(RVA = "0x1293D80", Offset = "0x1292780", VA = "0x181293D80")]
		private void OnDestroy()
		{
			Sequence tweenHead = _tweenHead;
			if (tweenHead != null)
			{
				int complete = 0;
				tweenHead.Kill((byte)complete != 0);
			}
			RectTransform mcWave = _mcWave;
			int complete2 = 0;
			int num = DOTween.Kill(mcWave, (byte)complete2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001139")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MoanaBoatIcon()
		{
		}
	}
}
