using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2F175A0", Offset = "0x2F15FA0", VA = "0x182F175A0")]
		private void OnEnable()
		{
			int num = 0;
			EnableControlRig((byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2F178B0", Offset = "0x2F162B0", VA = "0x182F178B0")]
		private void Start()
		{
			//Discarded unreachable code: IL_002e
			//IL_000f: Expected O, but got I4
			EventSystem eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>();
			int num = 0;
			if (eventSystem == (UnityEngine.Object)num)
			{
				GameObject gameObject = new GameObject("EventSystem");
				EventSystem eventSystem2 = gameObject.AddComponent<EventSystem>();
				StandaloneInputModule standaloneInputModule = gameObject.AddComponent<StandaloneInputModule>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2F175A0", Offset = "0x2F15FA0", VA = "0x182F175A0")]
		private void CheckEnableControlRig()
		{
			int num = 0;
			EnableControlRig((byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2F175B0", Offset = "0x2F15FB0", VA = "0x182F175B0")]
		private void EnableControlRig(bool enabled)
		{
			//Discarded unreachable code: IL_007d, IL_0083, IL_0095
			int num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				num += 312;
				num += 328;
				int num4 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				gameObject.SetActive(enabled);
			}
			int num6 = 0;
			uint num7 = default(uint);
			if ((object)gameObject != null && num6 < (int)num7)
			{
				num6 += num6;
				num6++;
			}
			gameObject = (GameObject)(object)((object)gameObject + (object)gameObject);
			num6 += 312;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MobileControlRig()
		{
		}
	}
}
