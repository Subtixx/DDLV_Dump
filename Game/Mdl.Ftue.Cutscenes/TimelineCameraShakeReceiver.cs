using System;
using Cpp2IlInjected;
using Mdl.CameraFeedback;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D2")]
	public class TimelineCameraShakeReceiver : MonoBehaviour, INotificationReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x20005D3")]
		private class CameraShakeData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40023BB")]
			public AnimationCurve traumaCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40023BC")]
			public Vector3 maxAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40023BD")]
			public Vector3 maxTranslation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40023BE")]
			public float traumaReduction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40023BF")]
			public float timeMultiplier;

			[Cpp2IlInjected.Token(Token = "0x60019F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public CameraShakeData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023BA")]
		private CameraShakeData cameraShakeBackup;

		[Cpp2IlInjected.Token(Token = "0x60019F1")]
		[Cpp2IlInjected.Address(RVA = "0x13C8FC0", Offset = "0x13C79C0", VA = "0x1813C8FC0", Slot = "4")]
		public unsafe void OnNotify(Playable origin, INotification notification, object context)
		{
			//Discarded unreachable code: IL_00d3
			//IL_002e: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0078: Expected F4, but got O
			//IL_0073: Expected native int or pointer, but got O
			//IL_008a: Expected F4, but got O
			//IL_0085: Expected native int or pointer, but got O
			//IL_0097: Expected F4, but got O
			//IL_00a4: Expected F4, but got O
			if (notification == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (notification == null)
			{
				return;
			}
			int num3 = 0;
			if (Application.isPlaying)
			{
				if (false)
				{
				}
				int num4 = 0;
				if (!((UnityEngine.Object)num2 == (UnityEngine.Object)num4) && (long)cameraShakeBackup == 0)
				{
					PlayableDirector component = GetComponent<PlayableDirector>();
					CameraShakeData cameraShakeData = (cameraShakeBackup = new CameraShakeData());
					cameraShakeBackup.traumaCurve = (AnimationCurve)(object)cameraShakeData;
					((Vector3*)(IntPtr)cameraShakeBackup.maxAngle)->z = (float)cameraShakeData;
					((Vector3*)(IntPtr)cameraShakeBackup.maxTranslation)->z = (float)cameraShakeData;
					cameraShakeBackup.traumaReduction = (float)cameraShakeData;
					cameraShakeBackup.timeMultiplier = (float)cameraShakeData;
					Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(OnStopped);
					component.remove_stopped((Action<>)(object)action);
					Action<PlayableDirector> action2 = (Action<PlayableDirector>)(object)new Action<T>(OnStopped);
					component.add_stopped((Action<>)(object)action2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019F2")]
		[Cpp2IlInjected.Address(RVA = "0x13C92F0", Offset = "0x13C7CF0", VA = "0x1813C92F0")]
		private void OnStopped(PlayableDirector director)
		{
			//Discarded unreachable code: IL_0088
			//IL_0071: Expected O, but got I8
			if ((long)cameraShakeBackup != 0)
			{
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				if ((object)playerCamera != null)
				{
					CameraFeedbackTraumaScreenshake component = playerCamera.GetComponent<CameraFeedbackTraumaScreenshake>();
				}
				int num = 0;
				CameraShakeData cameraShakeData = cameraShakeBackup;
				float z = cameraShakeBackup.maxAngle.z;
				float z2 = cameraShakeBackup.maxTranslation.z;
				float traumaReduction = cameraShakeBackup.traumaReduction;
				float timeMultiplier = cameraShakeBackup.timeMultiplier;
				cameraShakeBackup = (CameraShakeData)0;
			}
			Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(OnStopped);
			director.remove_stopped((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60019F3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineCameraShakeReceiver()
		{
		}
	}
}
