using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002A1")]
	[RequiredAllNotNull]
	public class BuildingUpgradeIcon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BD7")]
		[SerializeField]
		private SpriteAtlasImage _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BD8")]
		[SerializeField]
		private RectTransform _mcHammerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BD9")]
		[SerializeField]
		public TextBase _tfLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BDA")]
		private Action _onFinish;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000BDB")]
		private int _currentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000BDC")]
		private float _shaketime = 0.15f;

		[Cpp2IlInjected.Token(Token = "0x600107B")]
		[Cpp2IlInjected.Address(RVA = "0xA69D70", Offset = "0xA68770", VA = "0x180A69D70")]
		public void RefreshIcon(string imageAddress, int level)
		{
			//Discarded unreachable code: IL_002d
			if ((long)_onFinish == 0)
			{
				_mcBackground.ImageAddress = imageAddress;
				TextBase tfLevel = _tfLevel;
				_currentLevel = level;
				string text = default(string);
				tfLevel.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600107C")]
		[Cpp2IlInjected.Address(RVA = "0xA69D40", Offset = "0xA68740", VA = "0x180A69D40")]
		public void AnimateUpgrade(Action onFinish)
		{
			_onFinish = onFinish;
			StepOne();
		}

		[Cpp2IlInjected.Token(Token = "0x600107D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7D0", Offset = "0xA691D0", VA = "0x180A6A7D0")]
		private void StepOne()
		{
			_mcHammerIcon.gameObject.SetActive(value: true);
			RectTransform mcHammerIcon = _mcHammerIcon;
			RectTransform mcHammerIcon2 = _mcHammerIcon;
			int num = 0;
			Vector2 zero = Vector2.zero;
			Transform transform = _mcBackground.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutSine);
			RectTransform mcHammerIcon3 = _mcHammerIcon;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutBounce);
			TweenCallback tweenCallback = delegate
			{
				RectTransform mcHammerIcon4 = _mcHammerIcon;
				Vector3 zero2 = Vector3.zero;
				int num2 = 0;
				float z2 = zero2.z;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> t3 = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore3 = t3.SetEase(Ease.OutQuad);
				TweenCallback tweenCallback2 = delegate
				{
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				};
				Delegate delegate2 = Delegate.Combine(tweenCallback2, tweenCallback2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600107E")]
		[Cpp2IlInjected.Address(RVA = "0xA69DD0", Offset = "0xA687D0", VA = "0x180A69DD0")]
		private void Step2()
		{
			RectTransform mcHammerIcon = _mcHammerIcon;
			Vector3 zero = Vector3.zero;
			int num = 0;
			float z = zero.z;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = t.SetEase(Ease.OutQuad);
			TweenCallback tweenCallback = delegate
			{
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600107F")]
		[Cpp2IlInjected.Address(RVA = "0xA69F10", Offset = "0xA68910", VA = "0x180A69F10")]
		[AsyncStateMachine(typeof(_003CStep3_003Ed__9))]
		private Task Step3()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001080")]
		[Cpp2IlInjected.Address(RVA = "0xA6A010", Offset = "0xA68A10", VA = "0x180A6A010")]
		private void Step4()
		{
			//IL_0057: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			int num = 0;
			Sequence s = DOTween.Sequence();
			Transform transform = _mcBackground.transform;
			float shaketime = _shaketime;
			int num2 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = t.SetEase(Ease.OutQuad);
			Sequence s2 = s.Append(t2);
			Transform transform2 = _mcBackground.transform;
			float shaketime2 = _shaketime;
			int num3 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t3 = ((TweenerCore<Quaternion, Vector3, QuaternionOptions>)(object)ShortcutExtensions.DORotate(transform2, (Vector3)num2, shaketime2, (RotateMode)num3)).SetEase(Ease.InOutQuad);
			Sequence s3 = s2.Append(t3);
			Transform transform3 = _mcBackground.transform;
			float num4 = _shaketime * 0.5f;
			int num5 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t4 = ((TweenerCore<Quaternion, Vector3, QuaternionOptions>)(object)ShortcutExtensions.DORotate(transform3, (Vector3)num2, num4, (RotateMode)num5)).SetEase(Ease.InOutQuad);
			Sequence s4 = s3.Append(t4);
			Transform transform4 = _mcBackground.transform;
			int num6 = 0;
			Vector2 one = Vector2.one;
			TweenerCore<Vector3, Vector3, VectorOptions> t5 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(transform4, (Vector3)num2, 0.2f)).SetEase(Ease.OutQuad);
			Sequence sequence = s4.Append(t5);
			Sequence sequence2 = sequence.SetDelay(0.2f);
			TweenCallback onComplete = sequence.onComplete;
			TweenCallback b = delegate
			{
				TextBase tfLevel = _tfLevel;
				int num7 = 0;
				int num8 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(tfLevel.RectTransform, -80f, 0.25f, (byte)num8 != 0);
				TweenCallback tweenCallback = delegate
				{
					Step6();
				};
				Delegate delegate2 = Delegate.Combine(tweenCallback, tweenCallback);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			};
			Delegate @delegate = Delegate.Combine(onComplete, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				sequence.onComplete = (TweenCallback)num2;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001081")]
		[Cpp2IlInjected.Address(RVA = "0xA6A310", Offset = "0xA68D10", VA = "0x180A6A310")]
		private void Step5()
		{
			TextBase tfLevel = _tfLevel;
			int num = 0;
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(tfLevel.RectTransform, -80f, 0.25f, (byte)num2 != 0);
			TweenCallback tweenCallback = delegate
			{
				Step6();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001082")]
		[Cpp2IlInjected.Address(RVA = "0xA6A420", Offset = "0xA68E20", VA = "0x180A6A420")]
		private void Step6()
		{
			//IL_0028: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			string text = default(string);
			_tfLevel.Text = text;
			RectTransform rectTransform = _tfLevel.RectTransform;
			int num = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			rectTransform.anchoredPosition = (Vector2)num;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			TextBase tfLevel = _tfLevel;
			int num3 = 0;
			RectTransform rectTransform2 = tfLevel.RectTransform;
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			Sequence s2 = s.Join(t);
			if ((object)base.transform != null)
			{
			}
			int num4 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY((RectTransform)num3, 326f, 0.2f, (byte)num4 != 0)).SetEase(Ease.OutCubic).SetDelay(0.15f);
			Sequence sequence = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//IL_0020: Expected O, but got I4
				Transform transform = base.transform;
				int num5 = 0;
				if ((object)transform != null)
				{
				}
				int num6 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY((RectTransform)num5, 340f, 0.2f, (byte)num6 != 0)).SetEase(Ease.InCubic);
				TweenCallback tweenCallback2 = delegate
				{
					Action onFinish;
					do
					{
						onFinish = _onFinish;
					}
					while (onFinish == null);
					onFinish();
					/*Error: Unexpected end of block*/;
				};
				Delegate delegate2 = Delegate.Combine(tweenCallback2, tweenCallback2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				sequence.onComplete = (TweenCallback)@delegate;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001083")]
		[Cpp2IlInjected.Address(RVA = "0xA6A680", Offset = "0xA69080", VA = "0x180A6A680")]
		private void Step7()
		{
			//IL_0020: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY((RectTransform)num, 340f, 0.2f, (byte)num2 != 0)).SetEase(Ease.InCubic);
			TweenCallback tweenCallback = delegate
			{
				Action onFinish;
				do
				{
					onFinish = _onFinish;
				}
				while (onFinish == null);
				onFinish();
				/*Error: Unexpected end of block*/;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001084")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABB0", Offset = "0xA695B0", VA = "0x180A6ABB0")]
		public BuildingUpgradeIcon()
		{
		}
	}
}
