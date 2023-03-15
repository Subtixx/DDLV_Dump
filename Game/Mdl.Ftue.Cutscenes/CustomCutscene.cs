using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005C3")]
	[RequireComponent(typeof(PlayableDirector))]
	public class CustomCutscene : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60019BC")]
		[Cpp2IlInjected.Address(RVA = "0x110EA20", Offset = "0x110D420", VA = "0x18110EA20")]
		public void SetCustomParameters(GameObject targetObj, Dictionary<string, Item> items, [Optional] Dictionary<int, GameObject> itemPrefabMap, [Optional] Dictionary<string, string> textForTracks, string objHolderId = "")
		{
			//Discarded unreachable code: IL_003b
			//IL_0010: Expected O, but got I4
			Cutscene componentInParent = GetComponentInParent<Cutscene>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				Transform transform = componentInParent.transform;
				Transform transform2 = targetObj.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform3 = componentInParent.transform;
				Transform transform4 = targetObj.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019BD")]
		[Cpp2IlInjected.Address(RVA = "0x110EBC0", Offset = "0x110D5C0", VA = "0x18110EBC0")]
		private void SetTracks(Dictionary<string, Item> items, Dictionary<int, GameObject> itemPrefabMap, Dictionary<string, string> textForTracks, GameObject targetObj, string objHolderId = "")
		{
			//Discarded unreachable code: IL_00a4, IL_00b2, IL_00b7, IL_00cf, IL_00d4, IL_00e2, IL_0100, IL_0106, IL_010c, IL_0118, IL_012a
			//IL_0014: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			uint num6 = default(uint);
			UnityEngine.Object @object = default(UnityEngine.Object);
			TimelineItemHolder timelineItemHolder = default(TimelineItemHolder);
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
				IEnumerable<PlayableBinding> outputs = (IEnumerable<PlayableBinding>)playableAsset.get_outputs();
				if (outputs != null)
				{
					if (num2 < (int)num6)
					{
						num2 += num2;
						if (num2 == (int)num6)
						{
							goto IL_0063;
						}
						num2++;
					}
					if (outputs != null)
					{
						goto IL_0063;
					}
					goto IL_00e6;
				}
				goto IL_00fa;
				IL_0063:
				int num7 = 0;
				if (outputs != null && items != null)
				{
					int num8 = 0;
					if (!(@object == (UnityEngine.Object)num8))
					{
						if ((object)@object == null)
						{
							throw new InvalidCastException();
						}
						int num9 = 0;
						if (timelineItemHolder != (UnityEngine.Object)num9)
						{
							throw new NullReferenceException();
						}
					}
					continue;
				}
				goto IL_00e6;
				IL_00fa:
				if (outputs == null)
				{
				}
				return;
				IL_00e6:
				while (num2 == 0)
				{
				}
				while ((object)timelineItemHolder == null)
				{
				}
				if (num2 != 0)
				{
					if (num2 != 0)
					{
						int num10 = 0;
						goto IL_00fa;
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019BE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CustomCutscene()
		{
		}
	}
}
