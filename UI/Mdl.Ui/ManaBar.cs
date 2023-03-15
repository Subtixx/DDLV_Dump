using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Systems;
using Mdl.Ui.Effects;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200057D")]
	public class ManaBar : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200057E")]
		public enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x4001E1D")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4001E1E")]
			LowMana
		}

		[Cpp2IlInjected.Token(Token = "0x200057F")]
		public delegate void AnimationStarted(float changes);

		[Cpp2IlInjected.Token(Token = "0x2000580")]
		public delegate void AnimationStopped(float changes);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E02")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E03")]
		[SerializeField]
		private RectTransform _progress1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E04")]
		[SerializeField]
		private RectTransform _progress2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E05")]
		[SerializeField]
		private TextBase _debugMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E06")]
		[SerializeField]
		private Image _mcWarningLowMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E07")]
		[SerializeField]
		private Image _lowMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E08")]
		[SerializeField]
		private CanvasGroup _prefabPlusIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E09")]
		[SerializeField]
		private ParticleSystem _sparkle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E0A")]
		[SerializeField]
		private ParticleSystem _sparkle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E0B")]
		[SerializeField]
		private FitEmitter _fitEmitter1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E0C")]
		[SerializeField]
		private FitEmitter _fitEmitter2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001E0D")]
		[SerializeField]
		private RawImage _mcEmptyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001E0E")]
		[SerializeField]
		private Image _mcEmptyProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001E0F")]
		[SerializeField]
		private Image _mcEmptyBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001E10")]
		public float WidthMin = 160f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001E11")]
		public float WidthMax = 360f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001E12")]
		public float AniDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001E13")]
		public float shakeAmplitude = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001E14")]
		public float shakeFrequence = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4001E15")]
		public int shakeLoop = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001E18")]
		private Tween _lowManaTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001E19")]
		private Tween _warningLowManaTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001E1A")]
		private Tween _notEnoughManaTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001E1B")]
		private Phase _phase;

		[Cpp2IlInjected.Token(Token = "0x14000040")]
		public event AnimationStarted OnAnimationStarted
		{
			[Cpp2IlInjected.Token(Token = "0x60023EC")]
			[Cpp2IlInjected.Address(RVA = "0xFACA10", Offset = "0xFAB410", VA = "0x180FACA10")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60023ED")]
			[Cpp2IlInjected.Address(RVA = "0xFACB50", Offset = "0xFAB550", VA = "0x180FACB50")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000041")]
		public event AnimationStopped OnAnimationStopped
		{
			[Cpp2IlInjected.Token(Token = "0x60023EE")]
			[Cpp2IlInjected.Address(RVA = "0xFACAB0", Offset = "0xFAB4B0", VA = "0x180FACAB0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60023EF")]
			[Cpp2IlInjected.Address(RVA = "0xFACBF0", Offset = "0xFAB5F0", VA = "0x180FACBF0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F0")]
		[Cpp2IlInjected.Address(RVA = "0xFAC1F0", Offset = "0xFAABF0", VA = "0x180FAC1F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0049
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ManaChanged value = OnManaChangedHandler;
			_003CDispatcher_003Ek__BackingField.OnManaChanged += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerLevelGained value2 = OnPlayerLevelGained;
			_003CDispatcher_003Ek__BackingField2.OnPlayerLevelGained += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x60023F1")]
		[Cpp2IlInjected.Address(RVA = "0xFAAED0", Offset = "0xFA98D0", VA = "0x180FAAED0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_006d
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.ManaChanged value = OnManaChangedHandler;
					_003CDispatcher_003Ek__BackingField.OnManaChanged -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerLevelGained value2 = OnPlayerLevelGained;
					_003CDispatcher_003Ek__BackingField2.OnPlayerLevelGained -= value2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F2")]
		[Cpp2IlInjected.Address(RVA = "0xFAB270", Offset = "0xFA9C70", VA = "0x180FAB270")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_005d
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			ProfilePlayer player_2 = _003CInstance_003Ek__BackingField.MetaClient.profile.player_;
			int num2 = 0;
			int num3 = 0;
			UnityEvent onNotEnoughMana = UiRoot.Instance.Dispatcher.OnNotEnoughMana;
			UnityAction call = OnNotEnoughManaHandler;
			onNotEnoughMana.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60023F3")]
		[Cpp2IlInjected.Address(RVA = "0xFAB150", Offset = "0xFA9B50", VA = "0x180FAB150")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_006c
			_sparkle1.Stop();
			_sparkle2.Stop();
			GameObject gameObject = _sparkle1.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _sparkle2.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			int num = 0;
			UnityEvent onNotEnoughMana = UiRoot.Instance.Dispatcher.OnNotEnoughMana;
			UnityAction call = OnNotEnoughManaHandler;
			onNotEnoughMana.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60023F4")]
		[Cpp2IlInjected.Address(RVA = "0xFAB480", Offset = "0xFA9E80", VA = "0x180FAB480")]
		private void OnManaChangedHandler(int oldValue, int newValue, bool refill, ProfileEventDispatcher.ManaSpentData _)
		{
			//IL_000e: Expected F4, but got I4
			//IL_000e: Expected F4, but got I4
			bool animate = oldValue < newValue;
			Refresh(oldValue, newValue, animate);
		}

		[Cpp2IlInjected.Token(Token = "0x60023F5")]
		[Cpp2IlInjected.Address(RVA = "0xFAB4C0", Offset = "0xFA9EC0", VA = "0x180FAB4C0")]
		private void OnPlayerLevelGained(int gained)
		{
			//Discarded unreachable code: IL_002b
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			ProfilePlayer player_2 = SystemRoot.Instance.MetaClient.profile.player_;
		}

		[Cpp2IlInjected.Token(Token = "0x60023F6")]
		[Cpp2IlInjected.Address(RVA = "0xFAB650", Offset = "0xFAA050", VA = "0x180FAB650")]
		internal unsafe void Refresh(float oldValue, float newValue, bool animate = false)
		{
			//IL_0089: Expected O, but got I4
			//IL_00cc: Expected F4, but got I4
			//IL_0173: Expected O, but got I4
			//IL_0173: Expected O, but got I4
			//IL_0173: Expected O, but got I4
			//IL_0215: Expected O, but got F4
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected F4, but got Unknown
			//IL_0221: Expected F4, but got I4
			//IL_0251: Expected O, but got I4
			//IL_0271: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			int num = 0;
			float oldValue2 = oldValue;
			TweenMax.KillAllByCancelationToken(this);
			bool flag = ProtoDatabase.Instance.TryGet("ManaInfo", out *(ManaData*)num);
			float widthMin = WidthMin;
			int maxLevel = SystemRoot.Instance.MetaClient.profile.player_.GetMaxLevel();
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			float currentWidth = widthMin;
			RectTransform content = _content;
			int num2 = 0;
			Vector2 sizeDelta = content.sizeDelta;
			content.sizeDelta = (Vector2)num2;
			ProfilePlayer player_2 = SystemRoot.Instance.MetaClient.profile.player_;
			int level_ = SystemRoot.Instance.MetaClient.profile.player_.level_;
			int maximumManaAmountForLevel = player_2.GetMaximumManaAmountForLevel(level_);
			float maxMana1 = 0f;
			ProfilePlayer player_3 = SystemRoot.Instance.MetaClient.profile.player_;
			int level_2 = SystemRoot.Instance.MetaClient.profile.player_.level_;
			int maximumExceedingManaAmountForLevel = player_3.GetMaximumExceedingManaAmountForLevel(level_2);
			float factor = oldValue;
			float maxMana2 = widthMin;
			GameObject gameObject = _debugMana.gameObject;
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			uint num4 = num4 + 20;
			num4 += num4;
			bool activeSelf = _debugMana.gameObject.activeSelf;
			if (activeSelf)
			{
				TextBase debugMana = _debugMana;
				float num5 = maxMana1;
				string text2 = (debugMana.Text = $"{activeSelf}/{activeSelf}/{activeSelf}");
			}
			if (!animate)
			{
				float currentWidth2 = currentWidth;
				float maxMana3 = maxMana2;
				float maxMana4 = maxMana1;
				UpdateProgress(oldValue, maxMana4, maxMana3, currentWidth2);
			}
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			TweenLiteArgs tweenLiteArgs = default(TweenLiteArgs);
			TweenDelegate tweenDelegate = (tweenLiteArgs.OnUpdate = delegate
			{
				//Discarded unreachable code: IL_0039
				int num12 = 0;
				uint num13 = default(uint);
				if (num12 < (int)num13)
				{
					num12 += num12;
					num12++;
				}
				ManaBar manaBar = this;
				float num14 = currentWidth;
				float maxMana6 = maxMana2;
				float maxMana7 = maxMana1;
				manaBar.UpdateProgress(num14, maxMana7, maxMana6, num14);
			});
			TweenDelegate tweenDelegate2 = (tweenLiteArgs.OnStart = delegate
			{
				//Discarded unreachable code: IL_0020
				AnimationStarted onAnimationStarted = this.OnAnimationStarted;
				if (onAnimationStarted != null)
				{
					float changes2 = factor;
					onAnimationStarted(changes2);
				}
			});
			TweenDelegate tweenDelegate3 = (tweenLiteArgs.OnComplete = delegate
			{
				//Discarded unreachable code: IL_0020
				AnimationStopped onAnimationStopped = this.OnAnimationStopped;
				if (onAnimationStopped != null)
				{
					float changes = factor;
					onAnimationStopped(changes);
				}
			});
			uint tagNum = default(uint);
			TweenLite tweenLite = TweenLite.To(this, oldValue, tweenLiteArgs, (int)tagNum, this);
			float maxMana5 = ((_003C_003Ec__DisplayClass39_0)(oldValue * 0.01f)).maxMana1;
			float b = /*Error near IL_0216: Stack underflow*/* maxMana5;
			float num11 = Mathf.Max(num10, b);
			_phase = (Phase)num;
			GameObject gameObject6 = default(GameObject);
			if (num != 1)
			{
				Tween lowManaTween = _lowManaTween;
				if (lowManaTween != null)
				{
					int complete = 0;
					lowManaTween.Kill((byte)complete != 0);
				}
				_lowManaTween = (Tween)num;
				Tween warningLowManaTween = _warningLowManaTween;
				if (warningLowManaTween != null)
				{
					int complete2 = 0;
					warningLowManaTween.Kill((byte)complete2 != 0);
				}
				_warningLowManaTween = (Tween)num;
				Tween notEnoughManaTween = _notEnoughManaTween;
				if (notEnoughManaTween != null)
				{
					int complete3 = 0;
					notEnoughManaTween.Kill((byte)complete3 != 0);
				}
				_notEnoughManaTween = (Tween)num;
				GameObject gameObject2 = _lowMana.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
				GameObject gameObject3 = _mcWarningLowMana.gameObject;
				int active2 = 0;
				gameObject3.SetActive((byte)active2 != 0);
				GameObject gameObject4 = _mcEmptyProgress.gameObject;
				int active3 = 0;
				gameObject4.SetActive((byte)active3 != 0);
				GameObject gameObject5 = _mcEmptyIcon.gameObject;
				int active4 = 0;
				gameObject5.SetActive((byte)active4 != 0);
				gameObject6 = _mcEmptyBg.gameObject;
				int active5 = 0;
				gameObject6.SetActive((byte)active5 != 0);
				return;
			}
			if ((object)gameObject6 == null)
			{
				AnimateLowMana();
			}
			AnimateWarningLowMana();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023F7")]
		[Cpp2IlInjected.Address(RVA = "0xFAC5F0", Offset = "0xFAAFF0", VA = "0x180FAC5F0")]
		private void UpdateProgress(float value, float maxMana1, float maxMana2, float currentWidth)
		{
			//IL_001e: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			//IL_018f: Expected O, but got I4
			RectTransform progress;
			while (true)
			{
				progress = _progress1;
				if (maxMana1 > value)
				{
					break;
				}
				int num = 0;
				Vector2 sizeDelta = progress.sizeDelta;
				progress.sizeDelta = (Vector2)num;
				RectTransform progress2 = _progress2;
				if (!(value > maxMana1))
				{
					int num2 = 0;
					Vector2 sizeDelta2 = progress2.sizeDelta;
					progress2.sizeDelta = (Vector2)num2;
					if (_sparkle1.gameObject.activeSelf)
					{
						int isOn = 0;
						TurnSparkleOnOff((byte)isOn != 0);
						_fitEmitter1.Start();
						_fitEmitter2.Start();
					}
					return;
				}
				int num3 = 0;
				Vector2 sizeDelta3 = progress2.sizeDelta;
				progress2.sizeDelta = (Vector2)num3;
				if (_sparkle1.isPaused || _sparkle1.isStopped || !_sparkle1.gameObject.activeSelf)
				{
					_sparkle1.gameObject.SetActive(value: true);
					_sparkle2.gameObject.SetActive(value: true);
					ParticleSystemManager.Play(_sparkle1);
					ParticleSystemManager.Play(_sparkle2);
					break;
				}
			}
			int num4 = 0;
			Vector2 sizeDelta4 = progress.sizeDelta;
			progress.sizeDelta = (Vector2)num4;
			if (_sparkle1.gameObject.activeSelf)
			{
				_sparkle1.Stop();
				_sparkle2.Stop();
				GameObject gameObject = _sparkle1.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _sparkle2.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				_fitEmitter1.Start();
				_fitEmitter2.Start();
			}
			RectTransform progress3 = _progress2;
			int num5 = 0;
			Vector2 sizeDelta5 = progress3.sizeDelta;
			progress3.sizeDelta = (Vector2)num5;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023F8")]
		[Cpp2IlInjected.Address(RVA = "0xFAC3E0", Offset = "0xFAADE0", VA = "0x180FAC3E0")]
		private void TurnSparkleOnOff(bool isOn)
		{
			//Discarded unreachable code: IL_007d
			ParticleSystem sparkle = _sparkle1;
			if (!isOn)
			{
				sparkle.Stop();
				_sparkle2.Stop();
				GameObject gameObject = _sparkle1.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _sparkle2.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
			else
			{
				sparkle.gameObject.SetActive(value: true);
				_sparkle2.gameObject.SetActive(value: true);
				ParticleSystemManager.Play(_sparkle1);
				ParticleSystemManager.Play(_sparkle2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F9")]
		[Cpp2IlInjected.Address(RVA = "0xFAB4B0", Offset = "0xFA9EB0", VA = "0x180FAB4B0")]
		private void OnNotEnoughManaHandler()
		{
			AnimateNotEnoughMana();
		}

		[Cpp2IlInjected.Token(Token = "0x60023FA")]
		[Cpp2IlInjected.Address(RVA = "0xFAA290", Offset = "0xFA8C90", VA = "0x180FAA290")]
		private void AnimateLowMana()
		{
			//Discarded unreachable code: IL_007a
			//IL_0028: Expected O, but got I8
			if ((long)_notEnoughManaTween == 0)
			{
				Tween warningLowManaTween = _warningLowManaTween;
				if (warningLowManaTween != null)
				{
					int complete = 0;
					warningLowManaTween.Kill((byte)complete != 0);
				}
				_warningLowManaTween = (Tween)0;
				GameObject gameObject = _mcWarningLowMana.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Image lowMana = _lowMana;
				_lowMana.gameObject.SetActive(value: true);
				Image lowMana2 = _lowMana;
				Color white = Color.white;
				TweenerCore<Color, Color, ColorOptions> t = default(TweenerCore<Color, Color, ColorOptions>);
				TweenerCore<Color, Color, ColorOptions> tweenerCore = t.SetEase(Ease.InOutCubic);
				TweenerCore<Color, Color, ColorOptions> lowManaTween = default(TweenerCore<Color, Color, ColorOptions>);
				_lowManaTween = lowManaTween;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023FB")]
		[Cpp2IlInjected.Address(RVA = "0xFAAA00", Offset = "0xFA9400", VA = "0x180FAAA00")]
		private void AnimateWarningLowMana()
		{
			//Discarded unreachable code: IL_0181
			//IL_003f: Expected O, but got I8
			//IL_0048: Expected O, but got I8
			//IL_007b: Expected O, but got I4
			if ((long)_notEnoughManaTween != 0)
			{
				return;
			}
			Tween lowManaTween = _lowManaTween;
			if (lowManaTween != null)
			{
				int complete = 0;
				lowManaTween.Kill((byte)complete != 0);
			}
			Tween warningLowManaTween = _warningLowManaTween;
			if (warningLowManaTween != null)
			{
				int complete2 = 0;
				warningLowManaTween.Kill((byte)complete2 != 0);
			}
			_lowManaTween = (Tween)0;
			_warningLowManaTween = (Tween)0;
			Image mcWarningLowMana = _mcWarningLowMana;
			Image lowMana = _lowMana;
			int num = 0;
			Sequence s = DOTween.Sequence();
			Image mcWarningLowMana2 = _mcWarningLowMana;
			int num2 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcWarningLowMana2, (Color)num2, 0.7f)).SetEase(Ease.InOutCubic);
			TweenerCore<Color, Color, ColorOptions> t = default(TweenerCore<Color, Color, ColorOptions>);
			Sequence s2 = s.Append(t);
			Image mcWarningLowMana3 = _mcWarningLowMana;
			TweenerCore<Color, Color, ColorOptions> t2 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> t3 = t2.SetEase(Ease.InOutCubic).SetLoops(1, LoopType.Yoyo);
			Sequence t4 = s2.Append(t3);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_0012
				_mcWarningLowMana.gameObject.SetActive(value: true);
			};
			Sequence t5 = t4.OnPlay(action);
			TweenCallback action2 = delegate
			{
				GameObject gameObject2 = _mcWarningLowMana.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_warningLowManaTween = t5.OnComplete(action2));
			int num3 = 0;
			Sequence s3 = DOTween.Sequence();
			Image lowMana2 = _lowMana;
			Color white = Color.white;
			TweenerCore<Color, Color, ColorOptions> t6 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = t6.SetEase(Ease.InOutCubic);
			TweenerCore<Color, Color, ColorOptions> t7 = default(TweenerCore<Color, Color, ColorOptions>);
			Sequence s4 = s3.Append(t7);
			Image lowMana3 = _lowMana;
			TweenerCore<Color, Color, ColorOptions> t8 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> t9 = t8.SetEase(Ease.InOutCubic).SetLoops(1, LoopType.Yoyo);
			Sequence t10 = s4.Append(t9);
			TweenCallback action3 = delegate
			{
				//Discarded unreachable code: IL_0012
				_lowMana.gameObject.SetActive(value: true);
			};
			Sequence t11 = t10.OnPlay(action3);
			TweenCallback action4 = delegate
			{
				//Discarded unreachable code: IL_0026
				GameObject gameObject = _lowMana.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				if (_phase == Phase.LowMana)
				{
					AnimateLowMana();
				}
			};
			Sequence sequence2 = (Sequence)(_lowManaTween = t11.OnComplete(action4));
		}

		[Cpp2IlInjected.Token(Token = "0x60023FC")]
		[Cpp2IlInjected.Address(RVA = "0xFAA440", Offset = "0xFA8E40", VA = "0x180FAA440")]
		private void AnimateNotEnoughMana()
		{
			//IL_0042: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_00ae: Expected F4, but got O
			Tween lowManaTween = _lowManaTween;
			if (lowManaTween != null)
			{
				int complete = 0;
				lowManaTween.Kill((byte)complete != 0);
			}
			Tween warningLowManaTween = _warningLowManaTween;
			if (warningLowManaTween != null)
			{
				int complete2 = 0;
				warningLowManaTween.Kill((byte)complete2 != 0);
			}
			int num = 0;
			_lowManaTween = (Tween)num;
			_warningLowManaTween = (Tween)num;
			GameObject gameObject = _mcWarningLowMana.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _lowMana.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			if ((object)gameObject2 != null)
			{
			}
			_notEnoughManaTween = (Tween)num;
			RectTransform RT = GetComponent<RectTransform>();
			Vector2 anchoredPosition = RT.anchoredPosition;
			float originalX = (float)anchoredPosition;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			float num3 = originalX;
			int num4 = 0;
			float num5 = shakeFrequence * 0.5f;
			TweenerCore<Vector2, Vector2, VectorOptions> t = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(RT, num3, num5, (byte)num4 != 0)).SetEase(Ease.Linear);
			Sequence s2 = s.Append(t);
			float num6 = shakeAmplitude;
			int num7 = 0;
			float num8 = shakeFrequence;
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(RT, num6, num8, (byte)num7 != 0)).SetEase(Ease.Linear);
			int loops = shakeLoop;
			TweenerCore<Vector2, Vector2, VectorOptions> t3 = t2.SetLoops(loops, LoopType.Yoyo);
			Sequence s3 = s2.Append(t3);
			float num9 = shakeFrequence;
			int num10 = 0;
			float num11 = originalX;
			TweenerCore<Vector2, Vector2, VectorOptions> t4 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(RT, num11, num9, (byte)num10 != 0)).SetEase(Ease.Linear);
			Sequence sequence = s3.Append(t4);
			int num12 = 0;
			Sequence s4 = DOTween.Sequence();
			Image mcEmptyBg = _mcEmptyBg;
			TweenerCore<Color, Color, ColorOptions> t5 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> t6 = t5.SetEase(Ease.InOutCubic);
			Sequence s5 = s4.Append(t6);
			Image mcEmptyProgress = _mcEmptyProgress;
			TweenerCore<Color, Color, ColorOptions> t7 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> t8 = t7.SetEase(Ease.InOutCubic);
			Sequence s6 = s5.Join(t8);
			RawImage mcEmptyIcon = _mcEmptyIcon;
			TweenerCore<Color, Color, ColorOptions> t9 = default(TweenerCore<Color, Color, ColorOptions>);
			TweenerCore<Color, Color, ColorOptions> t10 = t9.SetEase(Ease.InOutCubic);
			Sequence t11 = s6.Join(t10);
			Sequence t12 = sequence.Append(t11);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_007b
				Image mcEmptyProgress2 = _mcEmptyProgress;
				Color white = Color.white;
				Image mcEmptyBg2 = _mcEmptyBg;
				Color white2 = Color.white;
				RawImage mcEmptyIcon2 = _mcEmptyIcon;
				Color white3 = Color.white;
				_mcEmptyProgress.gameObject.SetActive(value: true);
				_mcEmptyBg.gameObject.SetActive(value: true);
				_mcEmptyIcon.gameObject.SetActive(value: true);
			};
			Sequence sequence2 = (Sequence)(_notEnoughManaTween = t12.OnPlay(action));
			TweenCallback onKill = sequence.onKill;
			TweenCallback b = delegate
			{
				//IL_0017: Expected O, but got I4
				RectTransform rectTransform = RT;
				int num13 = 0;
				Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
				rectTransform.anchoredPosition = (Vector2)num13;
				GameObject gameObject6 = _mcEmptyProgress.gameObject;
				int active6 = 0;
				gameObject6.SetActive((byte)active6 != 0);
				GameObject gameObject7 = _mcEmptyBg.gameObject;
				int active7 = 0;
				gameObject7.SetActive((byte)active7 != 0);
				GameObject gameObject8 = _mcEmptyIcon.gameObject;
				int active8 = 0;
				gameObject8.SetActive((byte)active8 != 0);
				ManaBar manaBar3 = this;
				throw new NullReferenceException();
			};
			Delegate @delegate = Delegate.Combine(onKill, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				sequence.onKill = (TweenCallback)@delegate;
				TweenCallback onComplete = sequence.onComplete;
				TweenCallback b2 = delegate
				{
					//Discarded unreachable code: IL_0075
					GameObject gameObject3 = _mcEmptyProgress.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
					GameObject gameObject4 = _mcEmptyBg.gameObject;
					int active4 = 0;
					gameObject4.SetActive((byte)active4 != 0);
					GameObject gameObject5 = _mcEmptyIcon.gameObject;
					int active5 = 0;
					gameObject5.SetActive((byte)active5 != 0);
					ManaBar manaBar = this;
					ManaBar manaBar2 = this;
					if (manaBar2._phase == Phase.LowMana)
					{
						manaBar2.AnimateLowMana();
					}
				};
				Delegate delegate2 = Delegate.Combine(onComplete, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					sequence.onComplete = (TweenCallback)delegate2;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023FD")]
		[Cpp2IlInjected.Address(RVA = "0xFAC9C0", Offset = "0xFAB3C0", VA = "0x180FAC9C0")]
		public ManaBar()
		{
		}//IL_0040: Expected I4, but got I8

	}
}
