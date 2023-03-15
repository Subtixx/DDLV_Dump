using System;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200036A")]
	public class StarRanking : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001091")]
		[SerializeField]
		private RectTransform[] _resultStars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001092")]
		[SerializeField]
		[Header("Animation settings")]
		private float _resultStarDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001093")]
		[SerializeField]
		private Vector3 _animatedStarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001094")]
		[SerializeField]
		private AK.Wwise.Event starSfx;

		[Cpp2IlInjected.Token(Token = "0x60015DD")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855490", VA = "0x180856A90")]
		public void SetRanking(int ranking, bool animate)
		{
			//Discarded unreachable code: IL_007a
			RectTransform[] resultStars = _resultStars;
			int num = 0;
			if (num < resultStars.Length)
			{
				RectTransform rectTransform = resultStars[num];
				if (!animate && ranking > num)
				{
					Vector3 one = Vector3.one;
				}
				float z = Vector3.zero.z;
				RectTransform[] resultStars2 = _resultStars;
				num++;
			}
			if (!animate || ranking <= 0)
			{
				return;
			}
			int star = num;
			float delay = default(float);
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_009b
				//IL_0010: Expected O, but got I4
				StarRanking starRanking = this;
				int num2 = 0;
				if (!(starRanking == (UnityEngine.Object)num2))
				{
					StarRanking starRanking2 = this;
					RectTransform[] resultStars3 = starRanking2._resultStars;
					int num3 = star;
					RectTransform rectTransform2 = resultStars3[num3];
					float z2 = starRanking2._animatedStarScale.z;
					StarRanking starRanking3 = this;
					RectTransform[] resultStars4 = starRanking3._resultStars;
					int num4 = star;
					float resultStarDelay = starRanking3._resultStarDelay;
					TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)resultStars4[num4], 1f, resultStarDelay);
					TweenCallback tweenCallback = delegate
					{
						AK.Wwise.Event @event = starSfx;
						if (@event != null)
						{
							GameObject gameObject = base.gameObject;
							uint num5 = @event.Post(gameObject);
						}
					};
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.OnStart(tweenCallback);
				}
			}, delay);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60015DE")]
		[Cpp2IlInjected.Address(RVA = "0x856990", Offset = "0x855390", VA = "0x180856990")]
		private void Animate(int ranking)
		{
			//Discarded unreachable code: IL_0032
			int num = 0;
			if (ranking <= 0)
			{
				return;
			}
			int star = num;
			float delay = default(float);
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_009b
				//IL_0010: Expected O, but got I4
				StarRanking starRanking = this;
				int num2 = 0;
				if (!(starRanking == (UnityEngine.Object)num2))
				{
					StarRanking starRanking2 = this;
					RectTransform[] resultStars = starRanking2._resultStars;
					int num3 = star;
					RectTransform rectTransform = resultStars[num3];
					float z = starRanking2._animatedStarScale.z;
					StarRanking starRanking3 = this;
					RectTransform[] resultStars2 = starRanking3._resultStars;
					int num4 = star;
					float resultStarDelay = starRanking3._resultStarDelay;
					TweenerCore<Vector3, Vector3, VectorOptions> t = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)resultStars2[num4], 1f, resultStarDelay);
					TweenCallback tweenCallback = delegate
					{
						AK.Wwise.Event @event = starSfx;
						if (@event != null)
						{
							GameObject gameObject = base.gameObject;
							uint num5 = @event.Post(gameObject);
						}
					};
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.OnStart(tweenCallback);
				}
			}, delay);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60015DF")]
		[Cpp2IlInjected.Address(RVA = "0x856C80", Offset = "0x855680", VA = "0x180856C80")]
		public unsafe StarRanking()
		{
			//IL_000e: Expected F4, but got I4
			//IL_0009: Expected native int or pointer, but got O
			((Vector3*)(IntPtr)_animatedStarScale)->z = 0f;
			_resultStarDelay = 0.25f;
			base._002Ector();
		}
	}
}
