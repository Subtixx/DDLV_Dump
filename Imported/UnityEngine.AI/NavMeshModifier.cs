using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		[SerializeField]
		private bool m_OverrideArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		[SerializeField]
		private bool m_IgnoreFromBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static readonly List<NavMeshModifier> s_NavMeshModifiers = (List<NavMeshModifier>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool overrideArea
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return m_OverrideArea;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				m_OverrideArea = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return m_Area;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				m_Area = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ignoreFromBuild
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return m_IgnoreFromBuild;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				m_IgnoreFromBuild = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static List<NavMeshModifier> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2F19570", Offset = "0x2F17F70", VA = "0x182F19570")]
			get
			{
				return s_NavMeshModifiers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2F19340", Offset = "0x2F17D40", VA = "0x182F19340")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_001b
			if (!((List<T>)(object)s_NavMeshModifiers).Contains((T)this))
			{
				((List<T>)(object)s_NavMeshModifiers).Add((T)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F192B0", Offset = "0x2F17CB0", VA = "0x182F192B0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_000d
			bool flag = ((List<T>)(object)s_NavMeshModifiers).Remove((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F191F0", Offset = "0x2F17BF0", VA = "0x182F191F0")]
		public bool AffectsAgentType(int agentTypeID)
		{
			//IL_0021: Expected O, but got I4
			List<int> affectedAgents = m_AffectedAgents;
			if (((List<>)(object)affectedAgents)._size != 0)
			{
				if ((long)"{il2cpp array field local4->}" != -1)
				{
					return ((List<T>)(object)affectedAgents).IndexOf((T)agentTypeID) != -1;
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2F194A0", Offset = "0x2F17EA0", VA = "0x182F194A0")]
		public NavMeshModifier()
		{
			//Discarded unreachable code: IL_002d
			//IL_0018: Expected I4, but got I8
			//IL_001e: Expected I4, but got O
			int[] array = new int[1];
			array[0] = -1;
			m_AffectedAgents = (List<int>)(object)new List<T>((int)array);
			((Renderer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2F19420", Offset = "0x2F17E20", VA = "0x182F19420")]
		static NavMeshModifier()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
