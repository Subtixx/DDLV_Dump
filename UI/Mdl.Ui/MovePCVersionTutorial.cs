using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000207")]
	public class MovePCVersionTutorial : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008E9")]
		[SerializeField]
		private RectTransform _mcBubble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008EA")]
		[SerializeField]
		private ThreeNineSlices _mcBubbleBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008EB")]
		[SerializeField]
		private RectTransform _mcCursorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40008EC")]
		[SerializeField]
		private Image _mcCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40008ED")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40008EE")]
		private Tween _tween;

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x1295B00", Offset = "0x1294500", VA = "0x181295B00")]
		private void Start()
		{
			//IL_0018: Expected O, but got I4
			Transform transform = _tfLabel.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcBubble);
			_mcBubbleBg.RefreshDisplay();
			RectTransform mcBubble = _mcBubble;
			float z = Vector3.zero.z;
			RectTransform mcCursorContent = _mcCursorContent;
			RectTransform mcCursorContent2 = _mcCursorContent;
			float z2 = Vector3.zero.z;
			RectTransform mcCursorContent3 = _mcCursorContent;
			float z3 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			RectTransform mcBubble2 = _mcBubble;
			float z4 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutBack);
			TweenCallback tweenCallback = delegate
			{
				//IL_0067: Expected O, but got I4
				int num2 = 0;
				Sequence s = DOTween.Sequence();
				Image mcCursor = _mcCursor;
				Color white = Color.white;
				TweenerCore<Color, Color, ColorOptions> t3 = default(TweenerCore<Color, Color, ColorOptions>);
				Sequence s2 = s.Append(t3);
				int num3 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t4 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_mcCursorContent, 140f, 1.5f, (byte)num3 != 0)).SetEase(Ease.InOutCubic);
				Sequence s3 = s2.Append(t4);
				Image mcCursor2 = _mcCursor;
				int num4 = 0;
				TweenerCore<Color, Color, ColorOptions> t5 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcCursor2, (Color)num4, 0.25f);
				Sequence t6 = s3.Append(t5);
				int loopType = 0;
				Sequence sequence = (Sequence)(_tween = t6.SetLoops(-1, (LoopType)loopType));
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x1295AF0", Offset = "0x12944F0", VA = "0x181295AF0")]
		private void OnDestroy()
		{
			Tween tween = _tween;
			int complete = 0;
			tween.Kill((byte)complete != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x1295970", Offset = "0x1294370", VA = "0x181295970")]
		private void Animate()
		{
			RectTransform mcCursorContent = _mcCursorContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			RectTransform mcBubble = _mcBubble;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutBack);
			TweenCallback tweenCallback = delegate
			{
				//IL_0067: Expected O, but got I4
				int num = 0;
				Sequence s = DOTween.Sequence();
				Image mcCursor = _mcCursor;
				Color white = Color.white;
				TweenerCore<Color, Color, ColorOptions> t3 = default(TweenerCore<Color, Color, ColorOptions>);
				Sequence s2 = s.Append(t3);
				int num2 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> t4 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_mcCursorContent, 140f, 1.5f, (byte)num2 != 0)).SetEase(Ease.InOutCubic);
				Sequence s3 = s2.Append(t4);
				Image mcCursor2 = _mcCursor;
				int num3 = 0;
				TweenerCore<Color, Color, ColorOptions> t5 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcCursor2, (Color)num3, 0.25f);
				Sequence t6 = s3.Append(t5);
				int loopType = 0;
				Sequence sequence = (Sequence)(_tween = t6.SetLoops(-1, (LoopType)loopType));
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x1295DD0", Offset = "0x12947D0", VA = "0x181295DD0")]
		private void Step2()
		{
			//IL_0067: Expected O, but got I4
			int num = 0;
			Sequence s = DOTween.Sequence();
			Image mcCursor = _mcCursor;
			Color white = Color.white;
			TweenerCore<Color, Color, ColorOptions> t = default(TweenerCore<Color, Color, ColorOptions>);
			Sequence s2 = s.Append(t);
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_mcCursorContent, 140f, 1.5f, (byte)num2 != 0)).SetEase(Ease.InOutCubic);
			Sequence s3 = s2.Append(t2);
			Image mcCursor2 = _mcCursor;
			int num3 = 0;
			TweenerCore<Color, Color, ColorOptions> t3 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcCursor2, (Color)num3, 0.25f);
			Sequence t4 = s3.Append(t3);
			int loopType = 0;
			Sequence sequence = (Sequence)(_tween = t4.SetLoops(-1, (LoopType)loopType));
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MovePCVersionTutorial()
		{
		}
	}
}
