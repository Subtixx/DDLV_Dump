using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private enum BuildTargetGroup
		{
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			Standalone,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			Mobile
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0680", Offset = "0x3DBF080", VA = "0x183DC0680")]
		private void OnEnable()
		{
			bool flag = m_BuildTargetGroup != BuildTargetGroup.Mobile;
			EnableContent(flag);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0680", Offset = "0x3DBF080", VA = "0x183DC0680")]
		private void CheckEnableContent()
		{
			bool flag = m_BuildTargetGroup != BuildTargetGroup.Mobile;
			EnableContent(flag);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC06A0", Offset = "0x3DBF0A0", VA = "0x183DC06A0")]
		private void EnableContent(bool enabled)
		{
			//Discarded unreachable code: IL_0093, IL_0099, IL_009f, IL_00b1
			//IL_0030: Expected O, but got I4
			int num = 0;
			GameObject[] content = m_Content;
			if (content.Length != num)
			{
				int length = content.Length;
				if (num < length)
				{
					GameObject gameObject = content[num];
					int num2 = 0;
					if (gameObject != (UnityEngine.Object)num2)
					{
						gameObject.SetActive(enabled);
					}
					num++;
				}
			}
			GameObject gameObject2 = default(GameObject);
			int num6 = default(int);
			if ((m_ChildrenOfThisObject ? 1 : 0) != num)
			{
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					int num4 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num5 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					gameObject2.SetActive(enabled);
				}
				num6 = 0;
				if ((object)gameObject2 == null)
				{
				}
			}
			if ((long)num6 < (long)(IntPtr)gameObject2)
			{
				num6++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC09D0", Offset = "0x3DBF3D0", VA = "0x183DC09D0")]
		public PlatformSpecificContent()
		{
		}
	}
}
