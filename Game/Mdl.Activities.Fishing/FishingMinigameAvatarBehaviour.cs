using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.CameraFeedback;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Activities.Fishing
{
	[Cpp2IlInjected.Token(Token = "0x2000B94")]
	internal class FishingMinigameAvatarBehaviour : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400407A")]
		[SerializeField]
		private AnimationCurve foundBounce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400407B")]
		[SerializeField]
		private float waitingAmplitude = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400407C")]
		[SerializeField]
		private float waitingFrequency = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400407D")]
		[SerializeField]
		private float fishEscapedAmplitude = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400407E")]
		[SerializeField]
		private float fishEscapedFrequency = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400407F")]
		[SerializeField]
		private float ropeBrokeTrauma = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004080")]
		[SerializeField]
		private GameObject lineBrokeVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004081")]
		private PlayerAvatar playerAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004082")]
		private FishingRod fishingRod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004083")]
		private Camera playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004084")]
		private float targetTension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004085")]
		private CameraFeedbackRotationNoise noise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004086")]
		private CameraFeedbackUnscaledTraumaScreenshake unscaledTraumaScreenshake;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4004087")]
		private CameraFeedbackBounce bounce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4004088")]
		private float lineTensionLerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4004089")]
		private float lineTensionLerpDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400408A")]
		private Transform HookRoot;

		[Cpp2IlInjected.Token(Token = "0x6003589")]
		[Cpp2IlInjected.Address(RVA = "0x1374370", Offset = "0x1372D70", VA = "0x181374370")]
		public void Init(PlayerAvatar withAvatar, FishingRod withFishingRod, Camera withCamera)
		{
			//IL_0062: Expected F4, but got I4
			playerAvatar = withAvatar;
			fishingRod = withFishingRod;
			playerCamera = withCamera;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = (noise = playerCamera.GetComponent<CameraFeedbackRotationNoise>());
			CameraFeedbackUnscaledTraumaScreenshake cameraFeedbackUnscaledTraumaScreenshake = (unscaledTraumaScreenshake = playerCamera.GetComponent<CameraFeedbackUnscaledTraumaScreenshake>());
			CameraFeedbackBounce cameraFeedbackBounce = (bounce = playerCamera.GetComponent<CameraFeedbackBounce>());
			int num = 0;
			targetTension = 0.9f;
			lineTensionLerp = num;
			NodeAnchor[] componentsInChildren = withFishingRod.GetComponentsInChildren<NodeAnchor>();
			Func<NodeAnchor, bool> _003C_003E9__17_ = _003C_003Ec._003C_003E9__17_0;
			if (_003C_003E9__17_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NodeAnchor x) => string.Equals(x.AnchorName, "HookRoot"));
			}
			NodeAnchor nodeAnchor = Enumerable.FirstOrDefault<NodeAnchor>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__17_);
			Transform hookRoot = default(Transform);
			if ((object)nodeAnchor != null)
			{
				hookRoot = nodeAnchor.transform;
			}
			HookRoot = hookRoot;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600358A")]
		[Cpp2IlInjected.Address(RVA = "0x1373DC0", Offset = "0x13727C0", VA = "0x181373DC0")]
		public void FishBit()
		{
			//Discarded unreachable code: IL_0063
			fishingRod.FishingLineTension = 1f;
			SystemRoot.Instance._avatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.alert);
			CameraFeedbackBounce cameraFeedbackBounce = bounce;
			AnimationCurve curve = foundBounce;
			cameraFeedbackBounce.Bounce(0.5f, curve);
			playerAvatar.Animator.SetTrigger("FishBite");
			targetTension = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x600358B")]
		[Cpp2IlInjected.Address(RVA = "0x1374270", Offset = "0x1372C70", VA = "0x181374270")]
		public void FishHooked()
		{
			//Discarded unreachable code: IL_002c
			SystemRoot.Instance._avatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.hooked);
			playerAvatar.Animator.SetTrigger("Hooked");
		}

		[Cpp2IlInjected.Token(Token = "0x600358C")]
		[Cpp2IlInjected.Address(RVA = "0x13741E0", Offset = "0x1372BE0", VA = "0x1813741E0")]
		public void FishHookedFailure()
		{
			//Discarded unreachable code: IL_0033
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.failed);
			playerAvatar.Animator.SetTrigger("Hooked");
			targetTension = 0.9f;
		}

		[Cpp2IlInjected.Token(Token = "0x600358D")]
		[Cpp2IlInjected.Address(RVA = "0x1373CF0", Offset = "0x13726F0", VA = "0x181373CF0")]
		public void CaughtFish(FishRarity rarity)
		{
			//Discarded unreachable code: IL_004f
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			playerAvatar.Animator.SetBool("Succeed", value: true);
			AudioCharacterController audioController = playerAvatar.AudioController;
			CameraFeedbackBounce cameraFeedbackBounce = bounce;
			AnimationCurve curve = foundBounce;
			cameraFeedbackBounce.Bounce(0.5f, curve);
		}

		[Cpp2IlInjected.Token(Token = "0x600358E")]
		[Cpp2IlInjected.Address(RVA = "0x13745E0", Offset = "0x1372FE0", VA = "0x1813745E0")]
		public void RopeBroke()
		{
			//Discarded unreachable code: IL_00c0
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			Coroutines.Do((Action<>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0027
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise4 = noise;
				float frequency = fishEscapedFrequency;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise5 = cameraFeedbackRotationNoise4.SetFrequency(frequency);
				float amplitude = fishEscapedAmplitude;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise6 = cameraFeedbackRotationNoise5.SetAmplitude(amplitude);
			}, 0.2f);
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_0016
				playerAvatar.Animator.SetTrigger("Exit");
			}, 0.075f);
			Coroutine coroutine2 = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_0016
				CameraFeedbackUnscaledTraumaScreenshake cameraFeedbackUnscaledTraumaScreenshake = unscaledTraumaScreenshake;
				float trauma = ropeBrokeTrauma;
				cameraFeedbackUnscaledTraumaScreenshake.AddTrauma(trauma);
			}, 0.05f);
			Coroutine coroutine3 = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_001d
				//IL_0010: Expected F4, but got I4
				//IL_001a: Expected F4, but got I4
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise;
				int num = 0;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetFrequency(num);
				int num2 = 0;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise3 = cameraFeedbackRotationNoise2.SetAmplitude(num2);
			}, 0.21f);
			Transform hookRoot = HookRoot;
			GameObject gameObject = lineBrokeVFX;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Quaternion identity = Quaternion.identity;
			GameObject gameObject2 = default(GameObject);
			Transform transform = gameObject2.transform;
			float z2 = Vector3.one.z;
			UnityEngine.Object.Destroy(gameObject2, 0.5f);
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.failed);
		}

		[Cpp2IlInjected.Token(Token = "0x600358F")]
		[Cpp2IlInjected.Address(RVA = "0x1373F10", Offset = "0x1372910", VA = "0x181373F10")]
		public void FishEscaped()
		{
			//Discarded unreachable code: IL_00af
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			Coroutines.Do((Action<>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0027
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise4 = noise;
				float frequency = fishEscapedFrequency;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise5 = cameraFeedbackRotationNoise4.SetFrequency(frequency);
				float amplitude = fishEscapedAmplitude;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise6 = cameraFeedbackRotationNoise5.SetAmplitude(amplitude);
			}, 0.2f);
			CameraFeedbackUnscaledTraumaScreenshake cameraFeedbackUnscaledTraumaScreenshake = unscaledTraumaScreenshake;
			float trauma = ropeBrokeTrauma;
			cameraFeedbackUnscaledTraumaScreenshake.AddTrauma(trauma);
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_0032
				//IL_0025: Expected F4, but got I4
				//IL_002f: Expected F4, but got I4
				playerAvatar.Animator.SetTrigger("Exit");
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise;
				int num2 = 0;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetFrequency(num2);
				int num3 = 0;
				CameraFeedbackRotationNoise cameraFeedbackRotationNoise3 = cameraFeedbackRotationNoise2.SetAmplitude(num3);
			}, 0.21f);
			Transform hookRoot = HookRoot;
			GameObject gameObject = lineBrokeVFX;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Quaternion identity = Quaternion.identity;
			GameObject gameObject2 = default(GameObject);
			Transform transform = gameObject2.transform;
			float z2 = Vector3.one.z;
			UnityEngine.Object.Destroy(gameObject2, 0.5f);
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.failed);
			int num = 0;
			VibrationsManager.TriggerFailure();
		}

		[Cpp2IlInjected.Token(Token = "0x6003590")]
		[Cpp2IlInjected.Address(RVA = "0x1373C50", Offset = "0x1372650", VA = "0x181373C50")]
		public void CancelFishing()
		{
			//Discarded unreachable code: IL_0044
			//IL_0010: Expected F4, but got I4
			//IL_001a: Expected F4, but got I4
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise;
			int num = 0;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetAmplitude(num);
			int num2 = 0;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise3 = cameraFeedbackRotationNoise2.SetFrequency(num2);
			playerAvatar.AudioController.OnFishingEventAudio(AudioCharacterController.FishingEvents.stopreel);
			playerAvatar.Animator.SetTrigger("Locomotion");
		}

		[Cpp2IlInjected.Token(Token = "0x6003591")]
		[Cpp2IlInjected.Address(RVA = "0x1374AA0", Offset = "0x13734A0", VA = "0x181374AA0")]
		public void UpdateBehaviour()
		{
			//Discarded unreachable code: IL_009b
			//IL_0051: Expected O, but got I4
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise;
			float amplitude = waitingAmplitude;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetAmplitude(amplitude);
			float frequency = waitingFrequency;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise3 = cameraFeedbackRotationNoise2.SetFrequency(frequency);
			if (!(lineTensionLerpDuration <= lineTensionLerp))
			{
				FishingRod fishingRod = this.fishingRod;
				FishingLine fishingLine = fishingRod.fishingLine;
				int num = 0;
				if (!(fishingLine != (UnityEngine.Object)num))
				{
				}
				float tension = fishingRod.fishingLine.tension;
				float t = lineTensionLerp;
				float b = targetTension;
				b = (fishingRod.FishingLineTension = Mathf.Lerp(tension, b, t));
				int num3 = 0;
				float num4 = (lineTensionLerp = Time.deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003592")]
		[Cpp2IlInjected.Address(RVA = "0x1374C10", Offset = "0x1373610", VA = "0x181374C10")]
		private void UpdateFishingRod()
		{
			//Discarded unreachable code: IL_006b
			//IL_0025: Expected O, but got I4
			if (!(lineTensionLerpDuration <= lineTensionLerp))
			{
				FishingRod fishingRod = this.fishingRod;
				FishingLine fishingLine = fishingRod.fishingLine;
				int num = 0;
				if (!(fishingLine != (UnityEngine.Object)num))
				{
				}
				float tension = fishingRod.fishingLine.tension;
				float t = lineTensionLerp;
				float b = targetTension;
				b = (fishingRod.FishingLineTension = Mathf.Lerp(tension, b, t));
				int num3 = 0;
				float num4 = (lineTensionLerp = Time.deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003593")]
		[Cpp2IlInjected.Address(RVA = "0x1374BD0", Offset = "0x13735D0", VA = "0x181374BD0")]
		private void UpdateCamera()
		{
			//Discarded unreachable code: IL_0027
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise = noise;
			float amplitude = waitingAmplitude;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise2 = cameraFeedbackRotationNoise.SetAmplitude(amplitude);
			float frequency = waitingFrequency;
			CameraFeedbackRotationNoise cameraFeedbackRotationNoise3 = cameraFeedbackRotationNoise2.SetFrequency(frequency);
		}

		[Cpp2IlInjected.Token(Token = "0x6003594")]
		[Cpp2IlInjected.Address(RVA = "0x1374D10", Offset = "0x1373710", VA = "0x181374D10")]
		public FishingMinigameAvatarBehaviour()
		{
		}
	}
}
