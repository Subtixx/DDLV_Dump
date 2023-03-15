using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004D0")]
	public class UiTutorialPointer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001963")]
		[SerializeField]
		private Transform handCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001964")]
		private TweenerCore<Vector3, Vector3, VectorOptions> _tween;

		[Cpp2IlInjected.Token(Token = "0x6001F74")]
		[Cpp2IlInjected.Address(RVA = "0xCA9370", Offset = "0xCA7D70", VA = "0x180CA9370")]
		public void ShowDrag(Transform from, Transform to)
		{
			//IL_001d: Expected O, but got I8
			TweenerCore<Vector3, Vector3, VectorOptions> tween = _tween;
			if (tween != null)
			{
				int complete = 0;
				tween.Kill((byte)complete != 0);
				_tween = (TweenerCore<Vector3, Vector3, VectorOptions>)0;
			}
			base.gameObject.SetActive(value: true);
			Transform transform = handCursor;
			float z = Vector3.zero.z;
			handCursor.gameObject.SetActive(value: true);
			Transform transform2 = handCursor;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Transform transform3 = handCursor;
			float z3 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			Transform transform4 = handCursor;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = t2.SetEase(Ease.InOutQuint).SetDelay(0.25f);
			int loopType = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = (_tween = t3.SetLoops(-1, (LoopType)loopType));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F75")]
		[Cpp2IlInjected.Address(RVA = "0xCA9310", Offset = "0xCA7D10", VA = "0x180CA9310")]
		public void Hide()
		{
			//Discarded unreachable code: IL_002e
			//IL_001d: Expected O, but got I8
			TweenerCore<Vector3, Vector3, VectorOptions> tween = _tween;
			if (tween != null)
			{
				int complete = 0;
				tween.Kill((byte)complete != 0);
				_tween = (TweenerCore<Vector3, Vector3, VectorOptions>)0;
			}
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F76")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UiTutorialPointer()
		{
		}
	}
}
