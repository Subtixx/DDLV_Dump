using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005EE")]
	public class TimelineItemHolder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002412")]
		[SerializeField]
		private string itemHolderId = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002413")]
		public bool RestoreItemInWorldAfterScene = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002414")]
		private GameObject InWorldObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002415")]
		private Vector3 startingPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002416")]
		private Quaternion startingRot;

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public string ItemHolderId
		{
			[Cpp2IlInjected.Token(Token = "0x6001A54")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemHolderId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A55")]
		[Cpp2IlInjected.Address(RVA = "0x13CEC90", Offset = "0x13CD690", VA = "0x1813CEC90")]
		public void SetItemID(Item item, PlayableDirector pd, [Optional] GameObject gameObj, bool objIsPrefab = true)
		{
			//Discarded unreachable code: IL_002f, IL_0044, IL_0051, IL_0063
			IEnumerator enumerator = base.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.DestroyImmediate(gameObject);
			}
			int num3 = 0;
			if ((object)gameObject != null)
			{
			}
			bool flag = default(bool);
			uint num4 = default(uint);
			if (flag && num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A56")]
		[Cpp2IlInjected.Address(RVA = "0x13CEB10", Offset = "0x13CD510", VA = "0x1813CEB10")]
		public void CutsceneStopped(PlayableDirector obj)
		{
			//Discarded unreachable code: IL_0072
			//IL_0010: Expected O, but got I4
			//IL_005b: Expected O, but got I8
			GameObject inWorldObj = InWorldObj;
			int num = 0;
			if (inWorldObj != (UnityEngine.Object)num)
			{
				if (RestoreItemInWorldAfterScene)
				{
					Transform transform = InWorldObj.transform;
					float z = startingPos.z;
					Transform transform2 = InWorldObj.transform;
					Quaternion quaternion2 = (transform2.rotation = startingRot);
				}
				InWorldObj = (GameObject)0;
				Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(CutsceneStopped);
				obj.remove_stopped((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A57")]
		[Cpp2IlInjected.Address(RVA = "0x13CF1A0", Offset = "0x13CDBA0", VA = "0x1813CF1A0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0045
			//IL_0010: Expected O, but got I4
			GameObject inWorldObj = InWorldObj;
			int num = 0;
			if (inWorldObj != (UnityEngine.Object)num)
			{
				Transform transform = InWorldObj.transform;
				Transform transform2 = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform3 = InWorldObj.transform;
				Transform transform4 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A58")]
		[Cpp2IlInjected.Address(RVA = "0x13CF2C0", Offset = "0x13CDCC0", VA = "0x1813CF2C0")]
		public TimelineItemHolder()
		{
		}
	}
}
