using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B41")]
	internal class FishingMinigameVisuals : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E9C")]
		[Category]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E9D")]
		[Category]
		[SerializeField]
		private GameObject targetRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E9E")]
		[SerializeField]
		[Category]
		private FishingMinigameVisualTarget visualTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E9F")]
		[Category]
		[SerializeField]
		private GameObject shrinkingCircle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003EA0")]
		private float remapStart = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003EA1")]
		private float remapEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003EA2")]
		[SerializeField]
		private GameObject fishBiteSplashVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003EA3")]
		private PlayerAvatar playerAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003EA4")]
		private FishingRod fishingRod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003EA5")]
		private Camera playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003EA6")]
		private Vector3 sourcePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4003EA7")]
		private float ratio = 0.51f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003EA8")]
		[SerializeField]
		private float progressionFadeInTime = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4003EA9")]
		[SerializeField]
		private float progressionFadeOutTime = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003EAA")]
		[SerializeField]
		private float targetScale = 0.420683f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4003EAB")]
		[SerializeField]
		private float preTriggerBuffer = 0.03f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003EAC")]
		[SerializeField]
		private float postTriggerBuffer = 0.02f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4003EAD")]
		private bool allowProgressionUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003EAE")]
		public GameObject SplashVFXInstance;

		[Cpp2IlInjected.Token(Token = "0x600340A")]
		[Cpp2IlInjected.Address(RVA = "0x13773A0", Offset = "0x1375DA0", VA = "0x1813773A0")]
		public void Init(PlayerAvatar withAvatar, FishingRod withFishingRod, Camera withCamera)
		{
			playerAvatar = withAvatar;
			fishingRod = withFishingRod;
			playerCamera = withCamera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600340B")]
		[Cpp2IlInjected.Address(RVA = "0x1377270", Offset = "0x1375C70", VA = "0x181377270")]
		public void HideProgression()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = visualRoot;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600340C")]
		[Cpp2IlInjected.Address(RVA = "0x1377660", Offset = "0x1376060", VA = "0x181377660")]
		public void ShowProgression()
		{
			//Discarded unreachable code: IL_000d
			visualRoot.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600340D")]
		[Cpp2IlInjected.Address(RVA = "0x1377690", Offset = "0x1376090", VA = "0x181377690")]
		public unsafe void Show(Vector3 position, float innerScale)
		{
			//Discarded unreachable code: IL_014b
			//IL_0015: Expected O, but got I4
			//IL_0038: Expected native int or pointer, but got O
			//IL_0088: Expected O, but got I4
			//IL_0088: Expected F4, but got I4
			//IL_012b: Expected O, but got I4
			//IL_012b: Expected F4, but got I4
			CameraRelativeShake component = visualRoot.GetComponent<CameraRelativeShake>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int num2 = ((component.enabled = false) ? 1 : 0);
			}
			GameObject gameObject = visualRoot;
			float z = position.z;
			((Vector3*)(IntPtr)sourcePosition)->z = z;
			Transform transform = gameObject.transform;
			float z2 = position.z;
			bool activeInHierarchy = visualRoot.activeInHierarchy;
			int num3 = 0;
			if (activeInHierarchy)
			{
				FishingMinigameVisualTarget fishingMinigameVisualTarget = visualTarget;
				float fadeInDuration = fishingMinigameVisualTarget.fadeInDuration;
				int num4 = 0;
				IEnumerator routine = fishingMinigameVisualTarget.Fading((float)num4, 1f, fadeInDuration, (Action)num3);
				Coroutine coroutine = fishingMinigameVisualTarget.StartCoroutine(routine);
				fishingMinigameVisualTarget.waitingCircle.enabled = true;
				SpriteRenderer triggerCircle = fishingMinigameVisualTarget.triggerCircle;
				int num5 = ((triggerCircle.enabled = false) ? 1 : 0);
				SpriteRenderer failCircle = fishingMinigameVisualTarget.failCircle;
				int num6 = ((failCircle.enabled = false) ? 1 : 0);
			}
			Transform transform2 = targetRoot.transform;
			float num7 = targetScale;
			float num8 = default(float);
			remapEnd = num8;
			Transform transform3 = visualRoot.transform;
			Transform transform4 = shrinkingCircle.transform;
			float z3 = Vector3.one.z;
			float duration = progressionFadeInTime;
			int num9 = 0;
			IEnumerator routine2 = FadeProgressionCircle(num9, 1f, duration, (Action)num3);
			Coroutine coroutine2 = StartCoroutine(routine2);
			shrinkingCircle.SetActive(value: true);
			allowProgressionUpdates = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600340E")]
		[Cpp2IlInjected.Address(RVA = "0x13772A0", Offset = "0x1375CA0", VA = "0x1813772A0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_004d
			//IL_0040: Expected F4, but got I4
			FishingMinigameVisualTarget fishingMinigameVisualTarget = visualTarget;
			allowProgressionUpdates = false;
			float fadeOutDuration = fishingMinigameVisualTarget.fadeOutDuration;
			IEnumerator routine = default(IEnumerator);
			Coroutine coroutine = fishingMinigameVisualTarget.StartCoroutine(routine);
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject gameObject = shrinkingCircle;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			int num = 0;
			IEnumerator routine2 = FadeProgressionCircle(1f, num, fadeOutDuration, callback);
			Coroutine coroutine2 = StartCoroutine(routine2);
		}

		[Cpp2IlInjected.Token(Token = "0x600340F")]
		[Cpp2IlInjected.Address(RVA = "0x1376F90", Offset = "0x1375990", VA = "0x181376F90")]
		internal void EndRoundFeedback(FishingMiniGame.FishingResult value)
		{
			//Discarded unreachable code: IL_0014
			if (value == FishingMiniGame.FishingResult.Success)
			{
				int num = 0;
				VibrationsManager.TriggerMediumImpact();
			}
			else
			{
				int num2 = 0;
				VibrationsManager.TriggerFailure();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003410")]
		[Cpp2IlInjected.Address(RVA = "0x1376FB0", Offset = "0x13759B0", VA = "0x181376FB0")]
		public void EnterTrigger()
		{
			//Discarded unreachable code: IL_0081
			//IL_0049: Expected O, but got I4
			FishingMinigameVisualTarget fishingMinigameVisualTarget = visualTarget;
			SpriteRenderer waitingCircle = fishingMinigameVisualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			fishingMinigameVisualTarget.triggerCircle.enabled = true;
			SpriteRenderer failCircle = fishingMinigameVisualTarget.failCircle;
			int num2 = ((failCircle.enabled = false) ? 1 : 0);
			GameObject gameObject = fishBiteSplashVFX;
			int num3 = 0;
			if (gameObject != (UnityEngine.Object)num3)
			{
				GameObject gameObject2 = fishBiteSplashVFX;
				float z = sourcePosition.z;
				Quaternion identity = Quaternion.identity;
				FishingRod fishingRod = this.fishingRod;
				GameObject splashVFXInstance = default(GameObject);
				SplashVFXInstance = splashVFXInstance;
			}
			int num4 = 0;
			VibrationsManager.TriggerWarning();
		}

		[Cpp2IlInjected.Token(Token = "0x6003411")]
		[Cpp2IlInjected.Address(RVA = "0x1377150", Offset = "0x1375B50", VA = "0x181377150")]
		public void ExitTrigger()
		{
			//Discarded unreachable code: IL_0036
			FishingMinigameVisualTarget fishingMinigameVisualTarget = visualTarget;
			SpriteRenderer waitingCircle = fishingMinigameVisualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			fishingMinigameVisualTarget.triggerCircle.enabled = true;
			SpriteRenderer failCircle = fishingMinigameVisualTarget.failCircle;
			int num2 = ((failCircle.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003412")]
		[Cpp2IlInjected.Address(RVA = "0x13775B0", Offset = "0x1375FB0", VA = "0x1813775B0")]
		public void InputSuccess()
		{
			//IL_0024: Expected F4, but got I4
			float duration = progressionFadeOutTime;
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject gameObject = shrinkingCircle;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			int num = 0;
			IEnumerator routine = FadeProgressionCircle(1f, num, duration, callback);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6003413")]
		[Cpp2IlInjected.Address(RVA = "0x1377400", Offset = "0x1375E00", VA = "0x181377400")]
		public void InputFail()
		{
			//Discarded unreachable code: IL_00a7
			//IL_006d: Expected F4, but got I4
			//IL_0092: Expected O, but got I4
			FishingMinigameVisualTarget fishingMinigameVisualTarget = visualTarget;
			float fadeOutDuration = fishingMinigameVisualTarget.fadeOutDuration;
			IEnumerator routine = default(IEnumerator);
			Coroutine coroutine = fishingMinigameVisualTarget.StartCoroutine(routine);
			SpriteRenderer waitingCircle = fishingMinigameVisualTarget.waitingCircle;
			int num = ((waitingCircle.enabled = false) ? 1 : 0);
			SpriteRenderer triggerCircle = fishingMinigameVisualTarget.triggerCircle;
			int num2 = ((triggerCircle.enabled = false) ? 1 : 0);
			fishingMinigameVisualTarget.failCircle.enabled = true;
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				GameObject gameObject = shrinkingCircle;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			};
			int num3 = 0;
			IEnumerator routine2 = FadeProgressionCircle(1f, num3, fadeOutDuration, callback);
			Coroutine coroutine2 = StartCoroutine(routine2);
			CameraRelativeShake component = visualRoot.GetComponent<CameraRelativeShake>();
			int num4 = 0;
			if (component != (UnityEngine.Object)num4)
			{
				Camera camera = playerCamera;
				component.StartShake(camera);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003414")]
		[Cpp2IlInjected.Address(RVA = "0x1377A10", Offset = "0x1376410", VA = "0x181377A10")]
		public void UpdateProgress(float normalizedValue)
		{
			//Discarded unreachable code: IL_002d
			if (allowProgressionUpdates)
			{
				float a = remapStart;
				float b = remapEnd;
				float num = Mathf.Lerp(a, b, normalizedValue);
				Transform transform = shrinkingCircle.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003415")]
		[Cpp2IlInjected.Address(RVA = "0x1377A10", Offset = "0x1376410", VA = "0x181377A10")]
		private void UpdateShrinkingCircle(float normalizedValue)
		{
			//Discarded unreachable code: IL_002d
			if (allowProgressionUpdates)
			{
				float a = remapStart;
				float b = remapEnd;
				float num = Mathf.Lerp(a, b, normalizedValue);
				Transform transform = shrinkingCircle.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003416")]
		[Cpp2IlInjected.Address(RVA = "0x13771B0", Offset = "0x1375BB0", VA = "0x1813771B0")]
		[IteratorStateMachine(typeof(_003CFadeProgressionCircle_003Ed__31))]
		private IEnumerator FadeProgressionCircle(float from, float to, float duration, [Optional] Action callback)
		{
			//IL_0017: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CFadeProgressionCircle_003Ed__31 _003CFadeProgressionCircle_003Ed__ = new _003CFadeProgressionCircle_003Ed__31(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFadeProgressionCircle_003Ed__._003C_003E4__this = this;
			_003CFadeProgressionCircle_003Ed__.callback = (Action)0;
			_003CFadeProgressionCircle_003Ed__.from = from;
			_003CFadeProgressionCircle_003Ed__.to = to;
			_003CFadeProgressionCircle_003Ed__.duration = duration;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003417")]
		[Cpp2IlInjected.Address(RVA = "0x1377A90", Offset = "0x1376490", VA = "0x181377A90")]
		public FishingMinigameVisuals()
		{
		}
	}
}
