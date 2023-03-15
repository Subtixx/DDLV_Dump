using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[SerializeField]
		private Vector3 m_StartPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		private Vector3 m_EndPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[SerializeField]
		private float m_Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[SerializeField]
		private int m_CostModifier = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		private bool m_Bidirectional = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		private bool m_AutoUpdatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private NavMeshLinkInstance m_LinkInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static readonly List<NavMeshLink> s_Tracked = (List<NavMeshLink>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return m_AgentTypeID;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2F18C80", Offset = "0x2F17680", VA = "0x182F18C80")]
			set
			{
				m_AgentTypeID = value;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public unsafe Vector3 startPoint
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x11B4700", Offset = "0x11B3100", VA = "0x1811B4700")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x2F18D80", Offset = "0x2F17780", VA = "0x182F18D80")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_StartPoint)->z = z;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public unsafe Vector3 endPoint
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x164D150", Offset = "0x164BB50", VA = "0x18164D150")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2F18D40", Offset = "0x2F17740", VA = "0x182F18D40")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_EndPoint)->z = z;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float width
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get
			{
				return m_Width;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x2F18DC0", Offset = "0x2F177C0", VA = "0x182F18DC0")]
			set
			{
				m_Width = value;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int costModifier
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return m_CostModifier;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2F18D10", Offset = "0x2F17710", VA = "0x182F18D10")]
			set
			{
				m_CostModifier = value;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool bidirectional
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
			get
			{
				return m_Bidirectional;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2F18CE0", Offset = "0x2F176E0", VA = "0x182F18CE0")]
			set
			{
				m_Bidirectional = value;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool autoUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xBBB1C0", Offset = "0xBB9BC0", VA = "0x180BBB1C0")]
			get
			{
				return m_AutoUpdatePosition;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2F18890", Offset = "0x2F17290", VA = "0x182F18890")]
			set
			{
				if (m_AutoUpdatePosition != value)
				{
					m_AutoUpdatePosition = value;
					if (!value)
					{
						RemoveTracking(this);
					}
					else
					{
						AddTracking(this);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return m_Area;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2F18CB0", Offset = "0x2F176B0", VA = "0x182F18CB0")]
			set
			{
				m_Area = value;
				AddLink();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F186A0", Offset = "0x2F170A0", VA = "0x182F186A0")]
		private void OnEnable()
		{
			AddLink();
			bool flag = default(bool);
			if (m_AutoUpdatePosition && flag)
			{
				AddTracking(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F18640", Offset = "0x2F17040", VA = "0x182F18640")]
		private void OnDisable()
		{
			RemoveTracking(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2F18610", Offset = "0x2F17010", VA = "0x182F18610")]
		public void UpdateLink()
		{
			AddLink();
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F183A0", Offset = "0x2F16DA0", VA = "0x182F183A0")]
		private unsafe static void AddTracking(NavMeshLink link)
		{
			//Discarded unreachable code: IL_0034
			//IL_0012: Expected O, but got I4
			List<NavMeshLink> list = s_Tracked;
			int num = default(int);
			NavMesh.OnNavMeshPreUpdate onNavMeshPreUpdate = new NavMesh.OnNavMeshPreUpdate(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&UpdateTrackedInstances));
			num = 0;
			Delegate @delegate = Delegate.Combine(onNavMeshPreUpdate, onNavMeshPreUpdate);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				((List<T>)(object)s_Tracked).Add((T)link);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F18720", Offset = "0x2F17120", VA = "0x182F18720")]
		private unsafe static void RemoveTracking(NavMeshLink link)
		{
			//Discarded unreachable code: IL_0038
			//IL_001e: Expected O, but got I4
			bool flag = ((List<T>)(object)s_Tracked).Remove((T)link);
			List<NavMeshLink> list = s_Tracked;
			int num = default(int);
			NavMesh.OnNavMeshPreUpdate onNavMeshPreUpdate = new NavMesh.OnNavMeshPreUpdate(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&UpdateTrackedInstances));
			num = 0;
			Delegate @delegate = Delegate.Remove(onNavMeshPreUpdate, onNavMeshPreUpdate);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2F18890", Offset = "0x2F17290", VA = "0x182F18890")]
		private void SetAutoUpdate(bool value)
		{
			if (m_AutoUpdatePosition != value)
			{
				m_AutoUpdatePosition = value;
				if (!value)
				{
					RemoveTracking(this);
				}
				else
				{
					AddTracking(this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2F18190", Offset = "0x2F16B90", VA = "0x182F18190")]
		private unsafe void AddLink()
		{
			//Discarded unreachable code: IL_0049
			//IL_003b: Expected native int or pointer, but got O
			bool flag = m_Bidirectional;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			NavMeshLinkInstance linkInstance = default(NavMeshLinkInstance);
			m_LinkInstance = linkInstance;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			Transform transform3 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)m_LastPosition)->z = z;
			Transform transform4 = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2F18530", Offset = "0x2F16F30", VA = "0x182F18530")]
		private bool HasTransformChanged()
		{
			//Discarded unreachable code: IL_0039
			float z = m_LastPosition.z;
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			bool flag = default(bool);
			if (!flag)
			{
				Quaternion lastRotation = m_LastRotation;
				Transform transform2 = base.transform;
				bool flag2 = default(bool);
				if (!flag2)
				{
					return flag2;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2F18610", Offset = "0x2F17010", VA = "0x182F18610")]
		private void OnDidApplyAnimationProperties()
		{
			AddLink();
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2F18930", Offset = "0x2F17330", VA = "0x182F18930")]
		private static void UpdateTrackedInstances()
		{
			//Discarded unreachable code: IL_0020, IL_0026, IL_002c
			int num = 0;
			List<NavMeshLink> list = s_Tracked;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Vector3 vector = default(Vector3);
			float z = vector.z;
			bool flag2 = default(bool);
			if (!flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2F18BE0", Offset = "0x2F175E0", VA = "0x182F18BE0")]
		public unsafe NavMeshLink()
		{
			//IL_0010: Expected I4, but got I8
			//IL_0029: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)m_LastPosition)->z = z;
			Quaternion identity = Quaternion.identity;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2F18B60", Offset = "0x2F17560", VA = "0x182F18B60")]
		static NavMeshLink()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
