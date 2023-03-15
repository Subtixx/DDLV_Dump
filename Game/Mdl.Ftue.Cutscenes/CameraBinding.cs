using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005C2")]
	[RequireComponent(typeof(PlayableDirector))]
	public class CameraBinding : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002372")]
		private PlayableDirector timeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002373")]
		private TimelineAsset timelineAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002374")]
		private bool camBinded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4002375")]
		public bool overrideCameras = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002376")]
		public Transform EndOfCSMainCameraTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002377")]
		public bool preserveCamPosRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4002378")]
		private bool camPosRotSaved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002379")]
		private Vector3 camOriginaPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400237A")]
		private Quaternion camOriginalRot;

		[Cpp2IlInjected.Token(Token = "0x400237B")]
		private const float DEFAULT_FOV = 40f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400237C")]
		public float EndOFCSFieldOfView = 40f;

		[Cpp2IlInjected.Token(Token = "0x60019B8")]
		[Cpp2IlInjected.Address(RVA = "0x1648000", Offset = "0x1646A00", VA = "0x181648000")]
		public unsafe void BindTimelineTracks()
		{
			//Discarded unreachable code: IL_01d8, IL_01de, IL_01e4, IL_01ea, IL_01f0, IL_01f6, IL_01fc, IL_020e, IL_0214
			//IL_002d: Expected native int or pointer, but got O
			//IL_0091: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_0197: Expected O, but got I4
			Vector3 vector = default(Vector3);
			float endOFCSFieldOfView = default(float);
			uint num6 = default(uint);
			UnityEngine.Object @object = default(UnityEngine.Object);
			Camera camera = default(Camera);
			GameObject gameObject2 = default(GameObject);
			GameObject gameObject3 = default(GameObject);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if ((preserveCamPosRot ? 1 : 0) != num2)
				{
					Transform transform = SystemRoot.Instance._playerCamera.transform;
					float z = vector.z;
					((Vector3*)(IntPtr)camOriginaPos)->z = z;
					Transform transform2 = SystemRoot.Instance._playerCamera.transform;
					camPosRotSaved = true;
				}
				IEnumerable<PlayableBinding> enumerable;
				if ((overrideCameras ? 1 : 0) != num2)
				{
					if ((camBinded ? 1 : 0) != num2)
					{
						return;
					}
					int num3 = 0;
					EndOFCSFieldOfView = endOFCSFieldOfView;
					PlayableDirector playableDirector = (timeline = GetComponent<PlayableDirector>());
					PlayableDirector playableDirector2 = timeline;
					int num4 = 0;
					if (playableDirector2 == (UnityEngine.Object)num4)
					{
						return;
					}
					PlayableAsset playableAsset = timeline.playableAsset;
					if ((object)playableAsset == null)
					{
					}
					int num5 = 0;
					if ((object)playableAsset == null)
					{
						break;
					}
					timelineAsset = (TimelineAsset)playableAsset;
					enumerable = (IEnumerable<PlayableBinding>)timelineAsset.get_outputs();
					if (enumerable != null)
					{
						if (num2 < (int)num6)
						{
							num2 += num2;
							if (num2 == (int)num6)
							{
								goto IL_00e8;
							}
							num2++;
						}
						while (enumerable == null)
						{
						}
						goto IL_00e8;
					}
					goto IL_01b4;
				}
				GameObject gameObject = SystemRoot.Instance._playerCamera.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				return;
				IL_01b4:
				if (enumerable == null)
				{
				}
				return;
				IL_00e8:
				enumerable = (IEnumerable<PlayableBinding>)(object)((object)enumerable + (object)enumerable);
				int num7 = 0;
				while (enumerable == null)
				{
				}
				PlayableDirector playableDirector3 = timeline;
				int num8 = 0;
				if (@object == (UnityEngine.Object)num8)
				{
					continue;
				}
				int num9 = 0;
				if ((object)@object != null)
				{
					int num10 = 0;
					if ((object)@object != null)
					{
						int num11 = 0;
						if (!(camera != (UnityEngine.Object)num11))
						{
							continue;
						}
						string text = camera.gameObject.name;
						UnityEngine.Object activationTrackWithName = GetActivationTrackWithName(text);
						int num12 = 0;
						if (!(activationTrackWithName != (UnityEngine.Object)num12))
						{
							string text2 = camera.gameObject.name;
							Debug.LogError("Unable to find activation track for camera " + text2);
						}
						int num13 = 0;
						TimelinePlayerCameraHolder component = gameObject2.GetComponent<TimelinePlayerCameraHolder>();
						int num14 = 0;
						if (!(component == (UnityEngine.Object)num14))
						{
							continue;
						}
						Type typeFromHandle = typeof(TimelinePlayerCameraHolder);
						Component component2 = gameObject3.Internal_AddComponentWithType(typeFromHandle);
						goto IL_01b4;
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019B9")]
		[Cpp2IlInjected.Address(RVA = "0x1648C20", Offset = "0x1647620", VA = "0x181648C20")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_00b5
			//IL_0010: Expected O, but got I4
			Transform endOfCSMainCameraTransform = EndOfCSMainCameraTransform;
			int num = 0;
			bool flag = endOfCSMainCameraTransform != (UnityEngine.Object)num;
			if (!flag)
			{
				if (camPosRotSaved == flag)
				{
					goto IL_0072;
				}
				camPosRotSaved = flag;
				int num2 = 0;
				float z = camOriginaPos.z;
				int num3 = 0;
			}
			Transform transform = SystemRoot.Instance._playerCamera.transform;
			Transform endOfCSMainCameraTransform2 = EndOfCSMainCameraTransform;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Transform transform2 = SystemRoot.Instance._playerCamera.transform;
			Transform endOfCSMainCameraTransform3 = EndOfCSMainCameraTransform;
			goto IL_0072;
			IL_0072:
			if (camBinded)
			{
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				float num4 = (playerCamera.fieldOfView = EndOFCSFieldOfView);
				camBinded = false;
			}
			SystemRoot.Instance._playerCamera.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60019BA")]
		[Cpp2IlInjected.Address(RVA = "0x1648890", Offset = "0x1647290", VA = "0x181648890")]
		private UnityEngine.Object GetActivationTrackWithName(string name)
		{
			//Discarded unreachable code: IL_0070, IL_0076, IL_007c, IL_0088, IL_008e
			//IL_0048: Expected O, but got I4
			uint num3 = default(uint);
			UnityEngine.Object @object = default(UnityEngine.Object);
			Camera camera = default(Camera);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				IEnumerable<PlayableBinding> outputs = (IEnumerable<PlayableBinding>)timelineAsset.get_outputs();
				if (outputs != null)
				{
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0030;
						}
						num2++;
					}
					PlayableDirector playableDirector = timeline;
					while (outputs == null)
					{
					}
					goto IL_0030;
				}
				goto IL_005e;
				IL_0030:
				int num4 = 0;
				while (outputs == null)
				{
				}
				if ((object)@object == null)
				{
					break;
				}
				int num5 = 0;
				if (!(camera != (UnityEngine.Object)num5) || camera.gameObject.name == null)
				{
					continue;
				}
				num2++;
				goto IL_005e;
				IL_005e:
				num2++;
				if (outputs != null)
				{
				}
				if (num2 != 0)
				{
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019BB")]
		[Cpp2IlInjected.Address(RVA = "0x1649020", Offset = "0x1647A20", VA = "0x181649020")]
		public CameraBinding()
		{
		}
	}
}
