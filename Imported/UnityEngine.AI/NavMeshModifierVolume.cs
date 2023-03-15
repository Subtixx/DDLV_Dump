using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private static readonly HashSet<NavMeshModifierVolume> s_NavMeshModifiers = (HashSet<NavMeshModifierVolume>)(object)new HashSet<T>();

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public unsafe Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x146C860", Offset = "0x146B260", VA = "0x18146C860")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1EC58E0", Offset = "0x1EC42E0", VA = "0x181EC58E0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_Size)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public unsafe Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xBA1890", Offset = "0xBA0290", VA = "0x180BA1890")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xBA18D0", Offset = "0xBA02D0", VA = "0x180BA18D0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_Center)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return m_Area;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				m_Area = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static HashSet<NavMeshModifierVolume> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2F19190", Offset = "0x2F17B90", VA = "0x182F19190")]
			get
			{
				return s_NavMeshModifiers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2F18F40", Offset = "0x2F17940", VA = "0x182F18F40")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_001c
			if (!((HashSet<T>)(object)s_NavMeshModifiers).Contains((T)this))
			{
				bool flag = ((HashSet<T>)(object)s_NavMeshModifiers).Add((T)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2F18EB0", Offset = "0x2F178B0", VA = "0x182F18EB0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_000d
			bool flag = ((HashSet<T>)(object)s_NavMeshModifiers).Remove((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F18DF0", Offset = "0x2F177F0", VA = "0x182F18DF0")]
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

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F190A0", Offset = "0x2F17AA0", VA = "0x182F190A0")]
		public unsafe NavMeshModifierVolume()
		{
			//Discarded unreachable code: IL_0033
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			//IL_0018: Expected F4, but got I8
			//IL_0013: Expected native int or pointer, but got O
			//IL_0025: Expected O, but got I4
			ulong num = default(ulong);
			((Vector3*)(IntPtr)m_Size)->z = (long)num;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)m_Center)->z = (long)num2;
			m_AffectedAgents = (List<int>)(object)new List<T> { (T)(-1) };
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F19020", Offset = "0x2F17A20", VA = "0x182F19020")]
		static NavMeshModifierVolume()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
