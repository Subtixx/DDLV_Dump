using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D5")]
	public class TimelineDOFPostProcessReceiver : MonoBehaviour, INotificationReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C2")]
		private bool needsPop;

		[Cpp2IlInjected.Token(Token = "0x60019F9")]
		[Cpp2IlInjected.Address(RVA = "0x13CD780", Offset = "0x13CC180", VA = "0x1813CD780", Slot = "4")]
		public void OnNotify(Playable origin, INotification notification, object context)
		{
			//Discarded unreachable code: IL_008b
			//IL_003e: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			if (notification == null)
			{
				return;
			}
			int num = 0;
			if (notification == null)
			{
				return;
			}
			int num2 = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			int num3 = 0;
			bool flag = default(bool);
			if (flag)
			{
				if (needsPop)
				{
					PostProcessManager.Instance.PopPostProcessOverride();
				}
				PostProcessManager.Instance.PushPostProcessOverride((VolumeProfile)num3);
				needsPop = true;
				PlayableDirector component = GetComponent<PlayableDirector>();
				int num4 = 0;
				if (component != (UnityEngine.Object)num4)
				{
					Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(OnStopped);
					component.remove_stopped((Action<>)(object)action);
					Action<PlayableDirector> action2 = (Action<PlayableDirector>)(object)new Action<T>(OnStopped);
					component.add_stopped((Action<>)(object)action2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019FA")]
		[Cpp2IlInjected.Address(RVA = "0x13CDA10", Offset = "0x13CC410", VA = "0x1813CDA10")]
		private void SetupCameras(VolumeProfile volume)
		{
			//Discarded unreachable code: IL_00e3, IL_00e9, IL_00ef, IL_00f5, IL_0101
			//IL_0014: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			uint num6 = default(uint);
			UnityEngine.Object @object = default(UnityEngine.Object);
			Camera camera = default(Camera);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				PlayableDirector component = GetComponent<PlayableDirector>();
				int num3 = 0;
				if (component == (UnityEngine.Object)num3)
				{
					return;
				}
				PlayableAsset playableAsset = component.playableAsset;
				int num4 = 0;
				if ((object)playableAsset == null)
				{
					break;
				}
				int num5 = 0;
				if ((object)playableAsset == null)
				{
					break;
				}
				IEnumerable<PlayableBinding> enumerable = (IEnumerable<PlayableBinding>)playableAsset.get_outputs();
				if (enumerable != null)
				{
					if (num2 < (int)num6)
					{
						num2 += num2;
						if (num2 == (int)num6)
						{
							goto IL_0060;
						}
						num2++;
					}
					while (enumerable == null)
					{
					}
					goto IL_0060;
				}
				goto IL_00dd;
				IL_0060:
				enumerable = (IEnumerable<PlayableBinding>)(object)((object)enumerable + (object)enumerable);
				int num7 = 0;
				while (enumerable == null)
				{
				}
				int num8 = 0;
				if (@object == (UnityEngine.Object)num8)
				{
					continue;
				}
				if ((object)@object != null)
				{
					int num9 = 0;
					if (!(camera != (UnityEngine.Object)num9))
					{
						continue;
					}
					Volume component2 = camera.GetComponent<Volume>();
					int num10 = 0;
					if (component2 == (UnityEngine.Object)num10)
					{
						GameObject gameObject = camera.gameObject;
						Type typeFromHandle = typeof(Volume);
						Component component3 = gameObject.Internal_AddComponentWithType(typeFromHandle);
					}
					camera.GetComponent<Volume>().m_InternalProfile = volume;
					goto IL_00dd;
				}
				throw new InvalidCastException();
				IL_00dd:
				if (enumerable == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019FB")]
		[Cpp2IlInjected.Address(RVA = "0x13CD9A0", Offset = "0x13CC3A0", VA = "0x1813CD9A0")]
		private void OnStopped(PlayableDirector director)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			if (Application.isPlaying && needsPop)
			{
				PostProcessManager.Instance.PopPostProcessOverride();
				needsPop = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019FC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineDOFPostProcessReceiver()
		{
		}
	}
}
