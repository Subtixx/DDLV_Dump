using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B15")]
	public class CallEvent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DA8")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DA9")]
		public AK.Wwise.Event sfxNpcFoleyEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DAA")]
		public AK.Wwise.Event sfxNpcFsEvent;

		[Cpp2IlInjected.Token(Token = "0x4003DAB")]
		private const string INDEXPRE = "index_";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003DAC")]
		private AudioEmitterCullingManager cullingScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003DAD")]
		private bool usingCulling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4003DAE")]
		private bool playSound = true;

		[Cpp2IlInjected.Token(Token = "0x6003318")]
		[Cpp2IlInjected.Address(RVA = "0x1647640", Offset = "0x1646040", VA = "0x181647640")]
		public void Start()
		{
			//Discarded unreachable code: IL_003c
			//IL_0023: Expected O, but got I4
			AudioEmitterCullingManager audioEmitterCullingManager = (cullingScript = audioEmitter.GetComponent<AudioEmitterCullingManager>());
			AudioEmitterCullingManager audioEmitterCullingManager2 = cullingScript;
			int num = 0;
			if (audioEmitterCullingManager2 != (UnityEngine.Object)num && cullingScript.enabled)
			{
				usingCulling = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003319")]
		[Cpp2IlInjected.Address(RVA = "0x1647A00", Offset = "0x1646400", VA = "0x181647A00")]
		public void callEvent(string s)
		{
			//Discarded unreachable code: IL_0035
			if (usingCulling)
			{
				bool flag = (playSound = cullingScript.isInsideCollider);
			}
			if (playSound)
			{
				GameObject in_gameObjectID = audioEmitter;
				uint num = AkSoundEngine.PostEvent(s, in_gameObjectID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600331A")]
		[Cpp2IlInjected.Address(RVA = "0x1647A90", Offset = "0x1646490", VA = "0x181647A90")]
		public void callNpcFoleyEvent(AnimationEvent animationEvent)
		{
			//Discarded unreachable code: IL_008a
			if (usingCulling)
			{
				bool flag = (playSound = cullingScript.isInsideCollider);
			}
			if (playSound)
			{
				string stringParameter = animationEvent.stringParameter;
				int intParameter = animationEvent.intParameter;
				GameObject in_gameObjectID = audioEmitter;
				AKRESULT aKRESULT = AkSoundEngine.SetSwitch("Movement_Type", stringParameter, in_gameObjectID);
				string text = default(string);
				string text2 = "index_" + text;
				GameObject in_gameObjectID2 = audioEmitter;
				string in_pszSwitchState = default(string);
				AKRESULT aKRESULT2 = AkSoundEngine.SetSwitch("Movement_Index", in_pszSwitchState, in_gameObjectID2);
				AK.Wwise.Event @event = sfxNpcFoleyEvent;
				GameObject gameObject = audioEmitter;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600331B")]
		[Cpp2IlInjected.Address(RVA = "0x1647510", Offset = "0x1645F10", VA = "0x181647510")]
		public void SetSurfaceEvent()
		{
			//Discarded unreachable code: IL_001a
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600331C")]
		[Cpp2IlInjected.Address(RVA = "0x1647BF0", Offset = "0x16465F0", VA = "0x181647BF0")]
		public void callNpcFsEvent(string s)
		{
			//Discarded unreachable code: IL_00c1
			//IL_0061: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			if (usingCulling)
			{
				bool flag = (playSound = cullingScript.isInsideCollider);
			}
			if (!playSound)
			{
				return;
			}
			GameObject in_gameObjectID = audioEmitter;
			AKRESULT aKRESULT = AkSoundEngine.SetSwitch("Npc_Footsteps_Intensity", "normal", in_gameObjectID);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				AudioManager system = _003CInstance_003Ek__BackingField.GetSystem<AudioManager>();
			}
			int num = 0;
			int num2 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num2))
			{
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				bool flag2 = default(bool);
				if (flag2)
				{
					goto IL_00a5;
				}
				AudioManager audioManager = default(AudioManager);
				Switch defaultFootStepGroundType = audioManager.DefaultFootStepGroundType;
				GameObject value = audioEmitter;
				defaultFootStepGroundType.SetValue(value);
			}
			Transform transform2 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			goto IL_00a5;
			IL_00a5:
			AK.Wwise.Event @event = sfxNpcFsEvent;
			GameObject gameObject = audioEmitter;
			uint num3 = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600331D")]
		[Cpp2IlInjected.Address(RVA = "0x1647710", Offset = "0x1646110", VA = "0x181647710")]
		private unsafe void TryUseAudioSurface(Vector3 footPosition)
		{
			//Discarded unreachable code: IL_009c
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			int num3;
			string[] array;
			do
			{
				int num = 0;
				int num2 = 0;
				num3 = 0;
				float z = Vector3.down.z;
				array = new string[0];
			}
			while ("Audio" != null && array == null);
			array[0] = "Audio";
			int mask = LayerMask.GetMask(array);
			float z2 = footPosition.z;
			int num4 = 0;
			RaycastHit[] array2 = default(RaycastHit[]);
			int length = array2.Length;
			if (num3 < length)
			{
				long num5 = (long)num3 * 44L;
				Transform transform = default(Transform);
				if (transform.gameObject.TryGetComponent<AudioFootStepData>(out *(AudioFootStepData*)num3))
				{
					int num6 = 0;
					RaycastHit raycastHit = default(RaycastHit);
					if (!((UnityEngine.Object)num3 == (UnityEngine.Object)num6) && (long)num4 <= (long)(IntPtr)raycastHit)
					{
					}
				}
				num3++;
			}
			int num7 = 0;
			if ((UnityEngine.Object)num3 != (UnityEngine.Object)num7)
			{
				GameObject gameObject = audioEmitter;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600331E")]
		[Cpp2IlInjected.Address(RVA = "0x16479F0", Offset = "0x16463F0", VA = "0x1816479F0")]
		public CallEvent()
		{
		}
	}
}
