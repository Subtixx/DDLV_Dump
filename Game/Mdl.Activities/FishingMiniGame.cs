using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Activities.Fishing;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.CameraFeedback;
using Mdl.InputSystem;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B32")]
	public class FishingMiniGame : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000B33")]
		public enum FishingState
		{
			[Cpp2IlInjected.Token(Token = "0x4003E50")]
			WaitingForBite,
			[Cpp2IlInjected.Token(Token = "0x4003E51")]
			FishBit,
			[Cpp2IlInjected.Token(Token = "0x4003E52")]
			Hidden
		}

		[Cpp2IlInjected.Token(Token = "0x2000B34")]
		public enum FishingResult
		{
			[Cpp2IlInjected.Token(Token = "0x4003E54")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003E55")]
			RopeBroke,
			[Cpp2IlInjected.Token(Token = "0x4003E56")]
			FishEscaped,
			[Cpp2IlInjected.Token(Token = "0x4003E57")]
			Canceled
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000B35")]
		public struct RarityAndVFX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003E58")]
			public FishRippleRarity Rarity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003E59")]
			public GameObject Prefab;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003E3C")]
		[SerializeField]
		private GameObject _fishingReelInfoGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003E3D")]
		[SerializeField]
		private RarityAndVFX[] _hookRippleWaitVFXPrefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003E3E")]
		private GameObject hookRippleWaitVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003E3F")]
		[Space]
		[SerializeField]
		private GameObject lostFlashVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003E40")]
		[SerializeField]
		[Space]
		private GameObject transitionFlashVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003E41")]
		[SerializeField]
		private FishingMinigameConfig GameplayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003E42")]
		private InputAction inputReel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003E43")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003E44")]
		private FishingRod fishingRod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003E45")]
		private FishRipple fishRipple;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003E46")]
		private PendingFish pendingFish;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003E47")]
		private FishDifficulty fishDifficulty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003E49")]
		private TaskCompletionSource<FishingResult> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003E4A")]
		private CancellationTokenSource infoGizmoCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003E4B")]
		private Camera playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003E4C")]
		private FishingMinigameGameplay Gameplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003E4D")]
		private FishingMinigameVisuals GameplayTargetBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003E4E")]
		private FishingMinigameAvatarBehaviour AvatarBehaviour;

		[Cpp2IlInjected.Token(Token = "0x1700070F")]
		public Transform HookRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60033A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CHookRoot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60033A7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CHookRoot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000710")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x98"), Cpp2IlInjected.Token(Token = "0x4003E48")]
		public FishingState CurrentFishingState
		{
			[Cpp2IlInjected.Token(Token = "0x60033A8")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60033A9")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000085")]
		public event Action FishHookedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60033A0")]
			[Cpp2IlInjected.Address(RVA = "0x1373880", Offset = "0x1372280", VA = "0x181373880")]
			[CompilerGenerated]
			add
			{
				Action fishHookedEvent = this.FishHookedEvent;
				Delegate @delegate = Delegate.Combine(fishHookedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishHookedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033A1")]
			[Cpp2IlInjected.Address(RVA = "0x1373A60", Offset = "0x1372460", VA = "0x181373A60")]
			[CompilerGenerated]
			remove
			{
				Action fishHookedEvent = this.FishHookedEvent;
				Delegate @delegate = Delegate.Remove(fishHookedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishHookedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000086")]
		public event Action FishingStart
		{
			[Cpp2IlInjected.Token(Token = "0x60033A2")]
			[Cpp2IlInjected.Address(RVA = "0x13739C0", Offset = "0x13723C0", VA = "0x1813739C0")]
			[CompilerGenerated]
			add
			{
				Action fishingStart = this.FishingStart;
				Delegate @delegate = Delegate.Combine(fishingStart, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishingStart)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033A3")]
			[Cpp2IlInjected.Address(RVA = "0x1373BA0", Offset = "0x13725A0", VA = "0x181373BA0")]
			[CompilerGenerated]
			remove
			{
				Action fishingStart = this.FishingStart;
				Delegate @delegate = Delegate.Remove(fishingStart, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishingStart)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000087")]
		public event Action FishingEnd
		{
			[Cpp2IlInjected.Token(Token = "0x60033A4")]
			[Cpp2IlInjected.Address(RVA = "0x1373920", Offset = "0x1372320", VA = "0x181373920")]
			[CompilerGenerated]
			add
			{
				Action fishingEnd = this.FishingEnd;
				Delegate @delegate = Delegate.Combine(fishingEnd, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishingEnd)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033A5")]
			[Cpp2IlInjected.Address(RVA = "0x1373B00", Offset = "0x1372500", VA = "0x181373B00")]
			[CompilerGenerated]
			remove
			{
				Action fishingEnd = this.FishingEnd;
				Delegate @delegate = Delegate.Remove(fishingEnd, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != fishingEnd)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033AA")]
		[Cpp2IlInjected.Address(RVA = "0x1372F60", Offset = "0x1371960", VA = "0x181372F60")]
		[AsyncStateMachine(typeof(_003CPlayMinigame_003Ed__38))]
		public Task<FishingResult> PlayMinigame(FishRipple fishRipple, PendingFish pendingFish, PlayerAvatar avatar, Camera playerCamera)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FishingResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60033AB")]
		[Cpp2IlInjected.Address(RVA = "0x1373550", Offset = "0x1371F50", VA = "0x181373550")]
		private void Update()
		{
			//Discarded unreachable code: IL_0184
			//IL_00a9: Expected F4, but got I4
			//IL_013c: Expected O, but got I4
			FishingMinigameVisuals gameplayTargetBehaviour;
			int num3;
			float deltaTime;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[1];
				InputAction inputAction = inputReel;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction.UpdateAll(deltaTime, array);
				FishingMinigameGameplay gameplay = Gameplay;
				int num2 = 0;
				float deltaTime2 = Time.deltaTime;
				gameplay.Update(deltaTime2);
				FishingMinigameGameplay gameplay2 = Gameplay;
				gameplayTargetBehaviour = GameplayTargetBehaviour;
				if (gameplay2.State == FishingMinigameGameplay.MinigameState.Active)
				{
					int currentRoundIndex = gameplay2.currentRoundIndex;
					if (currentRoundIndex != -1)
					{
						FishingMinigameGameplayConfig fishingMinigameGameplayConfig = gameplay2.roundConfigs[currentRoundIndex];
					}
				}
				num3 = 0;
				if (gameplayTargetBehaviour.allowProgressionUpdates)
				{
					break;
				}
			}
			float remapEnd = gameplayTargetBehaviour.remapEnd;
			float num4 = Mathf.Lerp(gameplayTargetBehaviour.remapStart, remapEnd, num3);
			GameObject shrinkingCircle = gameplayTargetBehaviour.shrinkingCircle;
			deltaTime = num4;
			Transform transform = shrinkingCircle.transform;
			if (Gameplay.State == FishingMinigameGameplay.MinigameState.Finished)
			{
				return;
			}
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			CameraFeedbackRotationNoise noise = avatarBehaviour.noise;
			float waitingAmplitude = avatarBehaviour.waitingAmplitude;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise.SetAmplitude(waitingAmplitude);
			float waitingFrequency = avatarBehaviour.waitingFrequency;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetFrequency(waitingFrequency);
			float lineTensionLerpDuration = avatarBehaviour.lineTensionLerpDuration;
			if (!(lineTensionLerpDuration <= avatarBehaviour.lineTensionLerp))
			{
				FishingRod fishingRod = avatarBehaviour.fishingRod;
				FishingLine fishingLine = fishingRod.fishingLine;
				int num5 = 0;
				if (fishingLine != (UnityEngine.Object)num5)
				{
					FishingLine fishingLine2 = fishingRod.fishingLine;
				}
				float lineTensionLerp = avatarBehaviour.lineTensionLerp;
				float targetTension = avatarBehaviour.targetTension;
				targetTension = (fishingRod.FishingLineTension = Mathf.Lerp(lineTensionLerpDuration, targetTension, lineTensionLerp));
				int num7 = 0;
				float num8 = (avatarBehaviour.lineTensionLerp = Time.deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033AC")]
		[Cpp2IlInjected.Address(RVA = "0x1370E20", Offset = "0x136F820", VA = "0x181370E20")]
		private void BindToGameplayEvents()
		{
			//Discarded unreachable code: IL_0275
			EventHandler<FishingMiniGameEventArgs> onEndRound;
			Delegate delegate6;
			while (true)
			{
				FishingMinigameGameplay gameplay = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameBeginRound);
				EventHandler<FishingMiniGameEventArgs> onBeginRound = gameplay.OnBeginRound;
				Delegate @delegate = Delegate.Combine(onBeginRound, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				while ((object)@delegate != onBeginRound)
				{
				}
				FishingMinigameGameplay gameplay2 = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b2 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameEnterTriggerZone);
				EventHandler<FishingMiniGameEventArgs> onEnterTriggerZone = gameplay2.OnEnterTriggerZone;
				Delegate delegate2 = Delegate.Combine(onEnterTriggerZone, b2);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					continue;
				}
				while ((object)delegate2 != onEnterTriggerZone)
				{
				}
				FishingMinigameGameplay gameplay3 = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b3 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameInputSuccess);
				EventHandler<FishingMiniGameEventArgs> onInputSuccess = gameplay3.OnInputSuccess;
				Delegate delegate3 = Delegate.Combine(onInputSuccess, b3);
				if ((object)delegate3 != null && (object)delegate3 == null)
				{
					continue;
				}
				while ((object)delegate3 != onInputSuccess)
				{
				}
				FishingMinigameGameplay gameplay4 = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b4 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameInputFail);
				EventHandler<FishingMiniGameEventArgs> onInputFail = gameplay4.OnInputFail;
				Delegate delegate4 = Delegate.Combine(onInputFail, b4);
				if ((object)delegate4 != null && (object)delegate4 == null)
				{
					continue;
				}
				while ((object)delegate4 != onInputFail)
				{
				}
				FishingMinigameGameplay gameplay5 = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b5 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameExitTriggerZone);
				EventHandler<FishingMiniGameEventArgs> onExitTriggerZone = gameplay5.OnExitTriggerZone;
				Delegate delegate5 = Delegate.Combine(onExitTriggerZone, b5);
				if ((object)delegate5 == null || (object)delegate5 != null)
				{
					while ((object)delegate5 != onExitTriggerZone)
					{
					}
					FishingMinigameGameplay gameplay6 = Gameplay;
					EventHandler<FishingMiniGameEventArgs> b6 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameEndRound);
					onEndRound = gameplay6.OnEndRound;
					delegate6 = Delegate.Combine(onEndRound, b6);
					if ((object)delegate6 == null || (object)delegate6 != null)
					{
						break;
					}
				}
			}
			while ((object)delegate6 != onEndRound)
			{
			}
			FishingMinigameGameplay gameplay7 = Gameplay;
			EventHandler<FishingMiniGameEventArgs> eventHandler = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameCancelled);
			Delegate delegate7 = default(Delegate);
			if ((object)delegate7 == null || (object)delegate7 != null)
			{
				while (delegate7 != gameplay7)
				{
				}
				FishingMinigameGameplay gameplay8 = Gameplay;
				EventHandler<FishingMiniGameEventArgs> b7 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameFinishedSuccess);
				EventHandler<FishingMiniGameEventArgs> onFinishedSuccess = gameplay8.OnFinishedSuccess;
				Delegate delegate8 = Delegate.Combine(onFinishedSuccess, b7);
				if ((object)delegate8 == null || (object)delegate8 != null)
				{
					while ((object)delegate8 != onFinishedSuccess)
					{
					}
					FishingMinigameGameplay gameplay9 = Gameplay;
					EventHandler<FishingMiniGameEventArgs> b8 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameFinishedRopeBroke);
					EventHandler<FishingMiniGameEventArgs> onFinishedRopeBroke = gameplay9.OnFinishedRopeBroke;
					Delegate delegate9 = Delegate.Combine(onFinishedRopeBroke, b8);
					if ((object)delegate9 == null || (object)delegate9 != null)
					{
						while ((object)delegate9 != onFinishedRopeBroke)
						{
						}
						FishingMinigameGameplay gameplay10 = Gameplay;
						EventHandler<FishingMiniGameEventArgs> b9 = (EventHandler<FishingMiniGameEventArgs>)(object)new EventHandler<TEventArgs>(OnMinigameFinishedFishEscaped);
						EventHandler<FishingMiniGameEventArgs> onFinishedFishEscaped = gameplay10.OnFinishedFishEscaped;
						Delegate delegate10 = Delegate.Combine(onFinishedFishEscaped, b9);
						if ((object)delegate10 == null || (object)delegate10 != null)
						{
							while ((object)delegate10 != onFinishedFishEscaped)
							{
							}
							FishingMinigameGameplay gameplay11 = Gameplay;
							Action<FishingResult> b10 = (Action<FishingResult>)(object)new Action<T>(OnMinigameCompleted);
							Action<FishingResult> onMinigameCompleted = gameplay11.OnMinigameCompleted;
							Delegate delegate11 = Delegate.Combine(onMinigameCompleted, b10);
							if ((object)delegate11 == null || (object)delegate11 != null)
							{
								while ((object)delegate11 != onMinigameCompleted)
								{
								}
								return;
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033AD")]
		[Cpp2IlInjected.Address(RVA = "0x13718F0", Offset = "0x13702F0", VA = "0x1813718F0")]
		public void OnMinigameBeginRound(object o, FishingMiniGameEventArgs e)
		{
			//Discarded unreachable code: IL_0066
			//IL_0059: Expected I4, but got I8
			FishingMinigameVisuals gameplayTargetBehaviour = GameplayTargetBehaviour;
			if (e.CurrentRoundIndex != 0)
			{
				GameObject visualRoot = gameplayTargetBehaviour.visualRoot;
			}
			GameObject visualRoot2 = gameplayTargetBehaviour.visualRoot;
			int active = 0;
			visualRoot2.SetActive((byte)active != 0);
			FishingMinigameGameplayConfig config = e.Config;
			FishingRod fishingRod = this.fishingRod;
			FishingMinigameVisuals gameplayTargetBehaviour2 = GameplayTargetBehaviour;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Action fishingStart = this.FishingStart;
			CurrentFishingState = FishingState.WaitingForBite;
			fishingStart?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60033AE")]
		[Cpp2IlInjected.Address(RVA = "0x1371E00", Offset = "0x1370800", VA = "0x181371E00")]
		public void OnMinigameEnterTriggerZone(object o, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_011a
			//IL_0052: Expected O, but got I4
			//IL_010d: Expected I4, but got I8
			FishingMinigameVisuals gameplayTargetBehaviour = GameplayTargetBehaviour;
			FishingMinigameVisualTarget visualTarget = gameplayTargetBehaviour.visualTarget;
			SpriteRenderer waitingCircle = visualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			visualTarget.triggerCircle.enabled = true;
			SpriteRenderer failCircle = visualTarget.failCircle;
			int num2 = ((failCircle.enabled = false) ? 1 : 0);
			GameObject fishBiteSplashVFX = gameplayTargetBehaviour.fishBiteSplashVFX;
			int num3 = 0;
			if (fishBiteSplashVFX != (UnityEngine.Object)num3)
			{
				GameObject fishBiteSplashVFX2 = gameplayTargetBehaviour.fishBiteSplashVFX;
				float z = gameplayTargetBehaviour.sourcePosition.z;
				Quaternion identity = Quaternion.identity;
				FishingRod fishingRod = gameplayTargetBehaviour.fishingRod;
				GameObject splashVFXInstance = default(GameObject);
				gameplayTargetBehaviour.SplashVFXInstance = splashVFXInstance;
			}
			int num4 = 0;
			VibrationsManager.TriggerWarning();
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			avatarBehaviour.fishingRod.FishingLineTension = 1f;
			SystemRoot.Instance._avatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.alert);
			CameraFeedbackBounce bounce = avatarBehaviour.bounce;
			AnimationCurve foundBounce = avatarBehaviour.foundBounce;
			bounce.Bounce(0.5f, foundBounce);
			avatarBehaviour.playerAvatar.Animator.SetTrigger("FishBite");
			avatarBehaviour.targetTension = 1f;
			Action fishHookedEvent = this.FishHookedEvent;
			CurrentFishingState = FishingState.FishBit;
			fishHookedEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60033AF")]
		[Cpp2IlInjected.Address(RVA = "0x1372D90", Offset = "0x1371790", VA = "0x181372D90")]
		public void OnMinigameInputSuccess(object o, FishingMiniGameEventArgs e)
		{
			//Discarded unreachable code: IL_0075
			//IL_002b: Expected F4, but got I4
			//IL_0074: Expected I4, but got I8
			FishingMinigameVisuals CS_0024_003C_003E8__locals0 = GameplayTargetBehaviour;
			float progressionFadeOutTime = CS_0024_003C_003E8__locals0.progressionFadeOutTime;
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject shrinkingCircle = CS_0024_003C_003E8__locals0.shrinkingCircle;
				int active = 0;
				shrinkingCircle.SetActive((byte)active != 0);
			};
			int num = 0;
			IEnumerator routine = CS_0024_003C_003E8__locals0.FadeProgressionCircle(1f, (float)num, progressionFadeOutTime, callback);
			Coroutine coroutine = CS_0024_003C_003E8__locals0.StartCoroutine(routine);
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			SystemRoot.Instance._avatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.hooked);
			avatarBehaviour.playerAvatar.Animator.SetTrigger("Hooked");
			CurrentFishingState = FishingState.Hidden;
		}

		[Cpp2IlInjected.Token(Token = "0x60033B0")]
		[Cpp2IlInjected.Address(RVA = "0x1372B40", Offset = "0x1371540", VA = "0x181372B40")]
		public void OnMinigameInputFail(object o, FishingMiniGameEventArgs e)
		{
			//Discarded unreachable code: IL_00f4
			//IL_0074: Expected F4, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00f3: Expected I4, but got I8
			FishingMinigameVisuals CS_0024_003C_003E8__locals0 = GameplayTargetBehaviour;
			FishingMinigameVisualTarget visualTarget = CS_0024_003C_003E8__locals0.visualTarget;
			float fadeOutDuration = visualTarget.fadeOutDuration;
			IEnumerator routine = default(IEnumerator);
			Coroutine coroutine = visualTarget.StartCoroutine(routine);
			SpriteRenderer waitingCircle = visualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			SpriteRenderer triggerCircle = visualTarget.triggerCircle;
			int num2 = ((triggerCircle.enabled = false) ? 1 : 0);
			visualTarget.failCircle.enabled = true;
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject shrinkingCircle = CS_0024_003C_003E8__locals0.shrinkingCircle;
				int active = 0;
				shrinkingCircle.SetActive((byte)active != 0);
			};
			int num3 = 0;
			IEnumerator routine2 = CS_0024_003C_003E8__locals0.FadeProgressionCircle(1f, (float)num3, fadeOutDuration, callback);
			Coroutine coroutine2 = CS_0024_003C_003E8__locals0.StartCoroutine(routine2);
			CameraRelativeShake component = CS_0024_003C_003E8__locals0.visualRoot.GetComponent<CameraRelativeShake>();
			int num4 = 0;
			if (component != (UnityEngine.Object)num4)
			{
				Camera camera = CS_0024_003C_003E8__locals0.playerCamera;
				component.StartShake(camera);
			}
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			avatarBehaviour.playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.failed);
			avatarBehaviour.playerAvatar.Animator.SetTrigger("Hooked");
			avatarBehaviour.targetTension = 0.9f;
			CurrentFishingState = FishingState.Hidden;
		}

		[Cpp2IlInjected.Token(Token = "0x60033B1")]
		[Cpp2IlInjected.Address(RVA = "0x1372120", Offset = "0x1370B20", VA = "0x181372120")]
		public void OnMinigameExitTriggerZone(object o, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_0044
			//IL_0043: Expected I4, but got I8
			FishingMinigameVisualTarget visualTarget = GameplayTargetBehaviour.visualTarget;
			SpriteRenderer waitingCircle = visualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			visualTarget.triggerCircle.enabled = true;
			SpriteRenderer failCircle = visualTarget.failCircle;
			int num2 = ((failCircle.enabled = false) ? 1 : 0);
			CurrentFishingState = FishingState.Hidden;
		}

		[Cpp2IlInjected.Token(Token = "0x60033B2")]
		[Cpp2IlInjected.Address(RVA = "0x1371CE0", Offset = "0x13706E0", VA = "0x181371CE0")]
		public void OnMinigameEndRound(object minigame, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_005d
			//IL_0047: Expected F4, but got I4
			//IL_005c: Expected I4, but got I8
			FishingMinigameVisuals CS_0024_003C_003E8__locals0 = GameplayTargetBehaviour;
			FishingMinigameVisualTarget visualTarget = CS_0024_003C_003E8__locals0.visualTarget;
			CS_0024_003C_003E8__locals0.allowProgressionUpdates = false;
			float fadeOutDuration = visualTarget.fadeOutDuration;
			IEnumerator routine = default(IEnumerator);
			Coroutine coroutine = visualTarget.StartCoroutine(routine);
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject shrinkingCircle = CS_0024_003C_003E8__locals0.shrinkingCircle;
				int active = 0;
				shrinkingCircle.SetActive((byte)active != 0);
			};
			int num = 0;
			IEnumerator routine2 = CS_0024_003C_003E8__locals0.FadeProgressionCircle(1f, (float)num, fadeOutDuration, callback);
			Coroutine coroutine2 = CS_0024_003C_003E8__locals0.StartCoroutine(routine2);
			CurrentFishingState = FishingState.Hidden;
		}

		[Cpp2IlInjected.Token(Token = "0x60033B3")]
		[Cpp2IlInjected.Address(RVA = "0x1372720", Offset = "0x1371120", VA = "0x181372720")]
		public void OnMinigameFinishedSuccess(object minigame, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_00de
			PendingFish pendingFish = this.pendingFish;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item fishingDataItem = pendingFish.FishingDataItem;
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			FishingDataItemData fishingDataItemData = default(FishingDataItemData);
			FishRarity rarity_ = fishingDataItemData.rarity_;
			avatarBehaviour.playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			avatarBehaviour.playerAvatar.Animator.SetBool("Succeed", value: true);
			AudioCharacterController audioController = avatarBehaviour.playerAvatar.AudioController;
			CameraFeedbackBounce bounce = avatarBehaviour.bounce;
			AnimationCurve foundBounce = avatarBehaviour.foundBounce;
			bounce.Bounce(0.5f, foundBounce);
			if (!SystemRoot.Instance.GetSystem<GameSettingsSystem>().DisableFlashes)
			{
				Camera camera = playerCamera;
				GameObject gameObject = transitionFlashVFX;
				Transform transform = camera.transform;
				Transform transform2 = playerCamera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Quaternion identity = Quaternion.identity;
				Transform transform3 = playerCamera.transform;
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj, 0.5f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B4")]
		[Cpp2IlInjected.Address(RVA = "0x1372460", Offset = "0x1370E60", VA = "0x181372460")]
		public void OnMinigameFinishedRopeBroke(object minigame, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_0081
			//IL_0076: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			AvatarBehaviour.RopeBroke();
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				ShowRipples(show: true);
			}, 0.05f);
			if (!SystemRoot.Instance.GetSystem<GameSettingsSystem>().DisableFlashes)
			{
				Camera camera = playerCamera;
				GameObject original = lostFlashVFX;
				Transform transform = camera.transform;
				Transform transform2 = playerCamera.transform;
				int num = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num2 = 0;
				Quaternion identity = Quaternion.identity;
				UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate(original, (Vector3)num2, (Quaternion)num), 0.05f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B5")]
		[Cpp2IlInjected.Address(RVA = "0x13721A0", Offset = "0x1370BA0", VA = "0x1813721A0")]
		public void OnMinigameFinishedFishEscaped(object minigame, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_0081
			//IL_0076: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			AvatarBehaviour.FishEscaped();
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				ShowRipples(show: true);
			}, 0.21f);
			if (!SystemRoot.Instance.GetSystem<GameSettingsSystem>().DisableFlashes)
			{
				Camera camera = playerCamera;
				GameObject original = lostFlashVFX;
				Transform transform = camera.transform;
				Transform transform2 = playerCamera.transform;
				int num = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num2 = 0;
				Quaternion identity = Quaternion.identity;
				UnityEngine.Object.Destroy(UnityEngine.Object.Instantiate(original, (Vector3)num2, (Quaternion)num), 0.21f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B6")]
		[Cpp2IlInjected.Address(RVA = "0x1371A00", Offset = "0x1370400", VA = "0x181371A00")]
		public void OnMinigameCancelled(object minigame, FishingMiniGameEventArgs args)
		{
			//Discarded unreachable code: IL_0054
			//IL_0017: Expected F4, but got I4
			//IL_0023: Expected F4, but got I4
			FishingMinigameAvatarBehaviour avatarBehaviour = AvatarBehaviour;
			CameraFeedbackRotationNoise noise = avatarBehaviour.noise;
			int num = 0;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise.SetAmplitude(num);
			int num2 = 0;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetFrequency(num2);
			avatarBehaviour.playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			avatarBehaviour.playerAvatar.Animator.SetTrigger("Locomotion");
			ShowRipples(show: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60033B7")]
		[Cpp2IlInjected.Address(RVA = "0x1371AD0", Offset = "0x13704D0", VA = "0x181371AD0")]
		private void OnMinigameCompleted(FishingResult result)
		{
			//Discarded unreachable code: IL_00c3
			//IL_0010: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_008b: Expected I4, but got I8
			//IL_0092: Expected O, but got I4
			GameObject gameObject = hookRippleWaitVFXInstance;
			int num = 0;
			bool flag = gameObject != (UnityEngine.Object)num;
			int num2 = 0;
			if (flag)
			{
				UnityEngine.Object.Destroy(hookRippleWaitVFXInstance);
				hookRippleWaitVFXInstance = (GameObject)num2;
			}
			GameObject splashVFXInstance = GameplayTargetBehaviour.SplashVFXInstance;
			int num3 = 0;
			if (splashVFXInstance != (UnityEngine.Object)num3)
			{
				UnityEngine.Object.Destroy(GameplayTargetBehaviour.SplashVFXInstance);
			}
			CancellationTokenSource cancellationTokenSource = infoGizmoCTS;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				infoGizmoCTS.Dispose();
				infoGizmoCTS = (CancellationTokenSource)num2;
			}
			HookRoot = (Transform)num2;
			CurrentFishingState = FishingState.Hidden;
			fishDifficulty = (FishDifficulty)num2;
			GameObject gameObject2 = base.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			TaskCompletionSource<FishingResult> taskCompletionSource = this.taskCompletionSource;
			this.FishingEnd?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60033B8")]
		[Cpp2IlInjected.Address(RVA = "0x13732E0", Offset = "0x1371CE0", VA = "0x1813732E0")]
		private void SpawnRipples()
		{
			//Discarded unreachable code: IL_008c
			//IL_005a: Expected O, but got I4
			FishRipple fishRipple = this.fishRipple;
			if ((object)fishRipple != null)
			{
				if (fishRipple.PendingFish.Buffed)
				{
				}
				if ((object)fishRipple != null)
				{
					PendingFish _003CPendingFish_003Ek__BackingField = fishRipple.PendingFish;
				}
			}
			FishRippleRarity rarity = FishRippleRarity.BodyOfWater;
			Func<RarityAndVFX, bool> func = (Func<RarityAndVFX, bool>)(object)(Func<T, TResult>)delegate
			{
				FishRippleRarity fishRippleRarity = rarity;
				bool result = default(bool);
				return result;
			};
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = hookRippleWaitVFXInstance;
				int num = 0;
				if (gameObject == (UnityEngine.Object)num)
				{
					FishingRod fishingRod = this.fishingRod;
					GameObject gameObject2 = default(GameObject);
					hookRippleWaitVFXInstance = gameObject2;
					Transform transform = hookRippleWaitVFXInstance.transform;
					FishingRod fishingRod2 = this.fishingRod;
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033B9")]
		[Cpp2IlInjected.Address(RVA = "0x13730F0", Offset = "0x1371AF0", VA = "0x1813730F0")]
		private void ShowRipples(bool show)
		{
			//Discarded unreachable code: IL_0071
			//IL_0010: Expected O, but got I4
			//IL_006a: Expected F4, but got I4
			FishRipple fishRipple = this.fishRipple;
			int num = 0;
			if (fishRipple != (UnityEngine.Object)num && (bool)hookRippleWaitVFXInstance)
			{
				ParticleSystem component = hookRippleWaitVFXInstance.transform.Find("Selected").GetComponent<ParticleSystem>();
				ParticleSystem.MainModule main = component.main;
				ParticleSystem.MinMaxCurve minMaxCurve = default(ParticleSystem.MinMaxCurve);
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
				if ((object)component != null)
				{
					ParticleSystem.MinMaxCurve minMaxCurve2 = default(ParticleSystem.MinMaxCurve);
					AnimationCurve curveMax2 = minMaxCurve2.m_CurveMax;
					int withChildren = 0;
					int num2 = 0;
					component.Simulate(num2, (byte)withChildren != 0, restart: true);
					component.Play();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033BA")]
		[Cpp2IlInjected.Address(RVA = "0x1371690", Offset = "0x1370090", VA = "0x181371690")]
		private List<FishingMinigameGameplayConfig> CreateGameplayConfigs()
		{
			//Discarded unreachable code: IL_012a
			List<FishingMinigameGameplayConfig> list = (List<FishingMinigameGameplayConfig>)(object)new List<T>();
			System.Random rand = new System.Random();
			FishingMinigameConfig gameplayConfig = GameplayConfig;
			float initialRoundMaximumTime = gameplayConfig.InitialRoundMaximumTime;
			float initialRoundMinimumTime = gameplayConfig.InitialRoundMinimumTime;
			float triggerStartTime = rand.Next(initialRoundMinimumTime, initialRoundMaximumTime);
			float initialRoundTriggerTime = GameplayConfig.InitialRoundTriggerTime;
			FishingMinigameGameplayConfig fishingMinigameGameplayConfig = new FishingMinigameGameplayConfig();
			fishingMinigameGameplayConfig.TriggerStartTime = triggerStartTime;
			fishingMinigameGameplayConfig.MaxTime = initialRoundTriggerTime;
			fishingMinigameGameplayConfig.TriggerEndTime = initialRoundTriggerTime;
			float num = (fishingMinigameGameplayConfig.BetweenRoundTime = GameplayConfig.BetweenRoundTime);
			float num2 = (fishingMinigameGameplayConfig.FailTime = GameplayConfig.FailTime);
			((List<T>)(object)list).Add((T)fishingMinigameGameplayConfig);
			FishingMinigameRoundConfig[] roundConfigs = fishDifficulty.RoundConfigs;
			int num3 = 0;
			int length = roundConfigs.Length;
			if (num3 < length)
			{
				FishingMinigameRoundConfig fishingMinigameRoundConfig = roundConfigs[num3];
				float timeInsideTrigger = fishingMinigameRoundConfig.TimeInsideTrigger;
				FishingMinigameGameplayConfig fishingMinigameGameplayConfig2 = new FishingMinigameGameplayConfig();
				fishingMinigameGameplayConfig2.MaxTime = timeInsideTrigger;
				float timeOutsideTrigger = fishingMinigameRoundConfig.TimeOutsideTrigger;
				fishingMinigameGameplayConfig2.TriggerEndTime = timeInsideTrigger;
				fishingMinigameGameplayConfig2.TriggerStartTime = timeOutsideTrigger;
				float num4 = (fishingMinigameGameplayConfig2.BetweenRoundTime = GameplayConfig.BetweenRoundTime);
				float num5 = (fishingMinigameGameplayConfig2.FailTime = GameplayConfig.FailTime);
				((List<T>)(object)list).Add((T)fishingMinigameGameplayConfig2);
				num3++;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60033BB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FishingMiniGame()
		{
		}
	}
}
