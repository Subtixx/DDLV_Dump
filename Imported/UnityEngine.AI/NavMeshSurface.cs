using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Serialization;

namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ExecuteAlways]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[DefaultExecutionOrder(-102)]
	public class NavMeshSurface : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		private CollectObjects m_CollectObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		private LayerMask m_LayerMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		private int m_DefaultArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		[SerializeField]
		private bool m_IgnoreNavMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		private bool m_IgnoreNavMeshObstacle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		private bool m_OverrideTileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		private int m_TileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		private bool m_OverrideVoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		private float m_VoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		private bool m_BuildHeightMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		[FormerlySerializedAs("m_BakedNavMeshData")]
		private NavMeshData m_NavMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private NavMeshDataInstance m_NavMeshDataInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private static readonly List<NavMeshSurface> s_NavMeshSurfaces = (List<NavMeshSurface>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return m_AgentTypeID;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				m_AgentTypeID = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public CollectObjects collectObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return m_CollectObjects;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				m_CollectObjects = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public unsafe Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x2702380", Offset = "0x2700D80", VA = "0x182702380")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x27024A0", Offset = "0x2700EA0", VA = "0x1827024A0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_Size)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public unsafe Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xA64BD0", Offset = "0xA635D0", VA = "0x180A64BD0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA64BF0", Offset = "0xA635F0", VA = "0x180A64BF0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)m_Center)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public LayerMask layerMask
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return m_LayerMask;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				m_LayerMask = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public NavMeshCollectGeometry useGeometry
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return m_UseGeometry;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				m_UseGeometry = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int defaultArea
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return m_DefaultArea;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				m_DefaultArea = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool ignoreNavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get
			{
				return m_IgnoreNavMeshAgent;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			set
			{
				m_IgnoreNavMeshAgent = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ignoreNavMeshObstacle
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x139A3F0", Offset = "0x1398DF0", VA = "0x18139A3F0")]
			get
			{
				return m_IgnoreNavMeshObstacle;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x139A700", Offset = "0x1399100", VA = "0x18139A700")]
			set
			{
				m_IgnoreNavMeshObstacle = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool overrideTileSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x139A400", Offset = "0x1398E00", VA = "0x18139A400")]
			get
			{
				return m_OverrideTileSize;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x139A710", Offset = "0x1399110", VA = "0x18139A710")]
			set
			{
				m_OverrideTileSize = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int tileSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return m_TileSize;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				m_TileSize = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool overrideVoxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70")]
			get
			{
				return m_OverrideVoxelSize;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set
			{
				m_OverrideVoxelSize = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float voxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930")]
			get
			{
				return m_VoxelSize;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x282E0B0", Offset = "0x282CAB0", VA = "0x18282E0B0")]
			set
			{
				m_VoxelSize = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool buildHeightMesh
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430")]
			get
			{
				return m_BuildHeightMesh;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				m_BuildHeightMesh = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public NavMeshData navMeshData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return m_NavMeshData;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				m_NavMeshData = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static List<NavMeshSurface> activeSurfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2F1C2C0", Offset = "0x2F1ACC0", VA = "0x182F1C2C0")]
			get
			{
				return s_NavMeshSurfaces;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BA30", Offset = "0x2F1A430", VA = "0x182F1BA30")]
		private void OnEnable()
		{
			Register(this);
			AddData();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B870", Offset = "0x2F1A270", VA = "0x182F1B870")]
		private unsafe void OnDisable()
		{
			//Discarded unreachable code: IL_003a
			//IL_0009: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			int num = 0;
			m_NavMeshDataInstance = (NavMeshDataInstance)num;
			bool flag = ((List<T>)(object)s_NavMeshSurfaces).Remove((T)this);
			List<NavMeshSurface> list = s_NavMeshSurfaces;
			int num2 = default(int);
			NavMesh.OnNavMeshPreUpdate onNavMeshPreUpdate = new NavMesh.OnNavMeshPreUpdate(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&UpdateActive));
			num2 = 0;
			int num3 = 0;
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F19620", Offset = "0x2F18020", VA = "0x182F19620")]
		public unsafe void AddData()
		{
			//Discarded unreachable code: IL_0066
			//IL_0014: Expected O, but got I4
			//IL_0058: Expected native int or pointer, but got O
			bool flag = default(bool);
			if (!flag)
			{
				NavMeshData navMeshData = m_NavMeshData;
				int num = 0;
				if (navMeshData != (Object)num)
				{
					NavMeshData navMeshData2 = m_NavMeshData;
					Transform transform = base.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Transform transform2 = base.transform;
					NavMeshDataInstance navMeshDataInstance = default(NavMeshDataInstance);
					m_NavMeshDataInstance = navMeshDataInstance;
				}
				Transform transform3 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				((Vector3*)(IntPtr)m_LastPosition)->z = z2;
				Transform transform4 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BC80", Offset = "0x2F1A680", VA = "0x182F1BC80")]
		public void RemoveData()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			m_NavMeshDataInstance = (NavMeshDataInstance)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B370", Offset = "0x2F19D70", VA = "0x182F1B370")]
		public unsafe NavMeshBuildSettings GetBuildSettings()
		{
			//IL_0010: Expected O, but got I4
			//IL_001c: Expected F4, but got I4
			//IL_0017: Expected native int or pointer, but got O
			//IL_003a: Expected I, but got F4
			//IL_0042: Expected O, but got I4
			//IL_004f: Expected F4, but got I4
			//IL_004a: Expected native int or pointer, but got O
			NavMeshBuildSettings navMeshBuildSettings = default(NavMeshBuildSettings);
			string text = default(string);
			while (true)
			{
				int num = 0;
				((Object)this).m_CachedPtr = (IntPtr)num;
				m_Size = (Vector3)num;
				((Vector3*)(IntPtr)m_Center)->y = num;
				float agentClimb = navMeshBuildSettings.m_AgentClimb;
				int num2 = navMeshBuildSettings.m_OverrideVoxelSize;
				int accuratePlacement = navMeshBuildSettings.m_AccuratePlacement;
				((Object)this).m_CachedPtr = (IntPtr)agentClimb;
				m_Size = (Vector3)num2;
				((Vector3*)(IntPtr)m_Center)->y = accuratePlacement;
				if ((long)navMeshBuildSettings == -1)
				{
					string text2 = "No build settings for agent type ID " + text;
				}
				if ((long)"{il2cpp array field il2cppMethodInfo->}" != 0)
				{
				}
				if ((long)"{il2cpp array field il2cppMethodInfo->}" != 0)
				{
					/*Error: Could not find block for branch target IL_0077*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F19D80", Offset = "0x2F18780", VA = "0x182F19D80")]
		public void BuildNavMesh()
		{
			//Discarded unreachable code: IL_008f
			//IL_0053: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			List<NavMeshBuildSource> list = (List<NavMeshBuildSource>)(object)this.CollectSources();
			float z = m_Size.z;
			float z2 = m_Center.z;
			if (m_CollectObjects == (CollectObjects)(-3))
			{
			}
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Transform transform2 = base.transform;
			int num3 = 0;
			NavMeshData navMeshData = default(NavMeshData);
			if (navMeshData != (Object)num3)
			{
				string text2 = (navMeshData.name = base.gameObject.name);
				int num4 = 0;
				m_NavMeshDataInstance = (NavMeshDataInstance)num4;
				m_NavMeshData = navMeshData;
				if (base.isActiveAndEnabled)
				{
					AddData();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BFE0", Offset = "0x2F1A9E0", VA = "0x182F1BFE0")]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			int num = 0;
			int num2 = 0;
			List<NavMeshBuildSource> list = (List<NavMeshBuildSource>)(object)this.CollectSources();
			float z = m_Size.z;
			float z2 = m_Center.z;
			if (m_CollectObjects == (CollectObjects)(-3))
			{
			}
			AsyncOperation result = default(AsyncOperation);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BA90", Offset = "0x2F1A490", VA = "0x182F1BA90")]
		private unsafe static void Register(NavMeshSurface surface)
		{
			//Discarded unreachable code: IL_0043
			//IL_0012: Expected O, but got I4
			List<NavMeshSurface> list = s_NavMeshSurfaces;
			int num = default(int);
			NavMesh.OnNavMeshPreUpdate onNavMeshPreUpdate = new NavMesh.OnNavMeshPreUpdate(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&UpdateActive));
			num = 0;
			Delegate @delegate = Delegate.Combine(onNavMeshPreUpdate, onNavMeshPreUpdate);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				if (!((List<T>)(object)s_NavMeshSurfaces).Contains((T)surface))
				{
					((List<T>)(object)s_NavMeshSurfaces).Add((T)surface);
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BCA0", Offset = "0x2F1A6A0", VA = "0x182F1BCA0")]
		private unsafe static void Unregister(NavMeshSurface surface)
		{
			//Discarded unreachable code: IL_0038
			//IL_001e: Expected O, but got I4
			bool flag = ((List<T>)(object)s_NavMeshSurfaces).Remove((T)surface);
			List<NavMeshSurface> list = s_NavMeshSurfaces;
			int num = default(int);
			NavMesh.OnNavMeshPreUpdate onNavMeshPreUpdate = new NavMesh.OnNavMeshPreUpdate(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&UpdateActive));
			num = 0;
			Delegate @delegate = Delegate.Remove(onNavMeshPreUpdate, onNavMeshPreUpdate);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BE10", Offset = "0x2F1A810", VA = "0x182F1BE10")]
		private static void UpdateActive()
		{
			//Discarded unreachable code: IL_0013
			int num = 0;
			List<NavMeshSurface> list = s_NavMeshSurfaces;
			List<NavMeshSurface> list2 = s_NavMeshSurfaces;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2F197B0", Offset = "0x2F181B0", VA = "0x182F197B0")]
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_009d, IL_00a3, IL_00a9, IL_00af
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (m_CollectObjects != CollectObjects.Children)
			{
			}
			HashSet<NavMeshModifierVolume> hashSet = (HashSet<NavMeshModifierVolume>)(object)new HashSet<T>((IEqualityComparer<>)(object)GetComponentsInChildren<NavMeshModifierVolume>());
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				LayerMask layerMask = m_LayerMask;
				GameObject gameObject = default(GameObject);
				int layer = gameObject.layer;
				while ((long)(IntPtr)gameObject >= 0L)
				{
				}
				int num4 = m_AgentTypeID;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float z3 = vector2.z;
				int num5 = 0;
				int num6 = 0;
				float z4 = Vector3.one.z;
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AA90", Offset = "0x2F19490", VA = "0x182F1AA90")]
		private unsafe List<NavMeshBuildSource> CollectSources()
		{
			//Discarded unreachable code: IL_012c, IL_0132, IL_0138, IL_013e
			//IL_0024: Expected I4, but got O
			//IL_0085: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			List<NavMeshBuildSource> list = (List<NavMeshBuildSource>)(object)new List<T>();
			List<NavMeshBuildMarkup> list2 = (List<NavMeshBuildMarkup>)(object)new List<T>();
			if (m_CollectObjects != CollectObjects.Children)
			{
			}
			List<NavMeshModifier> list3 = (List<NavMeshModifier>)(object)new List<T>((int)GetComponentsInChildren<NavMeshModifier>());
			Predicate<NavMeshModifier> _003C_003E9__77_ = _003C_003Ec._003C_003E9__77_0;
			if (_003C_003E9__77_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((NavMeshModifier x) => !x.isActiveAndEnabled);
			}
			int num3 = ((List<T>)(object)list3).RemoveAll((Predicate<>)(object)_003C_003E9__77_);
			bool flag = default(bool);
			if (flag)
			{
				LayerMask layerMask = m_LayerMask;
				GameObject gameObject = default(GameObject);
				int layer = gameObject.layer;
				while ((long)(IntPtr)gameObject >= 0L)
				{
				}
				int num4 = m_AgentTypeID;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				int num5 = 0;
				((List<T>)(object)list2).Add((T)num5);
			}
			int num6 = 0;
			Transform transform = default(Transform);
			if ((object)transform != null && (long)transform != 2)
			{
				if ((long)transform != 1)
				{
					goto IL_00d4;
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float z2 = Vector3.one.z;
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				int num7 = 0;
				int num8 = 0;
			}
			int num9 = 0;
			goto IL_00d4;
			IL_00d4:
			Predicate<NavMeshBuildSource> predicate = default(Predicate<NavMeshBuildSource>);
			if (_003C_003Ec._003C_003E9__77_1 == null)
			{
				predicate = (Predicate<NavMeshBuildSource>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(NavMeshBuildSource x)
				{
					//IL_0010: Expected O, but got I4
					Component component3 = ((NavMeshBuildSource*)x)->component;
					int num13 = 0;
					bool flag4 = component3 != (Object)num13;
					if (!flag4)
					{
						return flag4;
					}
					Component component4 = ((NavMeshBuildSource*)x)->component;
					if ((object)component4 != null)
					{
					}
					return (object)component4 != null;
				});
			}
			int num10 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
			Predicate<NavMeshBuildSource> predicate2 = default(Predicate<NavMeshBuildSource>);
			if (_003C_003Ec._003C_003E9__77_2 == null)
			{
				predicate2 = (Predicate<NavMeshBuildSource>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(NavMeshBuildSource x)
				{
					//IL_0010: Expected O, but got I4
					Component component = ((NavMeshBuildSource*)x)->component;
					int num12 = 0;
					bool flag3 = component != (Object)num12;
					if (!flag3)
					{
						return flag3;
					}
					Component component2 = default(Component);
					if ((object)component2 != null)
					{
					}
					return (object)component2 != null;
				});
			}
			int num11 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate2);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2F195D0", Offset = "0x2F17FD0", VA = "0x182F195D0")]
		private unsafe static Vector3 Abs(Vector3 v)
		{
			//IL_0007: Expected F4, but got I4
			//IL_0002: Expected native int or pointer, but got O
			((Vector3*)(IntPtr)v)->z = 0f;
			return v;
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B4C0", Offset = "0x2F19EC0", VA = "0x182F1B4C0")]
		private unsafe static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			//IL_002f: Expected F4, but got I4
			//IL_002a: Expected native int or pointer, but got O
			//IL_003a: Expected F4, but got I4
			//IL_0035: Expected native int or pointer, but got O
			Vector3 right = Vector3.right;
			Vector3 up = Vector3.up;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 forward = Vector3.forward;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num = 0;
			((Matrix4x4*)(IntPtr)mat)->m00 = num;
			int num2 = 0;
			((Matrix4x4*)(IntPtr)mat)->m01 = num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A080", Offset = "0x2F18A80", VA = "0x182F1A080")]
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			//Discarded unreachable code: IL_0160, IL_0166
			int num = 0;
			int num2 = 0;
			((Object)this).m_CachedPtr = (IntPtr)num2;
			int num3 = 0;
			int num4 = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = Vector3.one.z;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			float m4 = matrix4x2.m01;
			float m5 = matrix4x2.m02;
			float m6 = matrix4x2.m03;
			int num5 = 0;
			int num6 = 0;
			((Object)this).m_CachedPtr = (IntPtr)num6;
			bool flag = default(bool);
			if (flag)
			{
				NavMeshBuildSourceShape navMeshBuildSourceShape = default(NavMeshBuildSourceShape);
				while (navMeshBuildSourceShape > NavMeshBuildSourceShape.ModifierBox)
				{
				}
				Object @object = default(Object);
				if ((object)@object != null)
				{
				}
				Matrix4x4 matrix4x3 = default(Matrix4x4);
				float m7 = matrix4x3.m01;
				float m8 = matrix4x3.m02;
				float m9 = matrix4x3.m03;
				Matrix4x4 matrix4x4 = default(Matrix4x4);
				float m10 = matrix4x4.m01;
				float m11 = matrix4x4.m02;
				float m12 = matrix4x4.m03;
				Object object2 = default(Object);
				if ((object)object2 != null)
				{
				}
				Matrix4x4 matrix4x5 = default(Matrix4x4);
				float m13 = matrix4x5.m01;
				float m14 = matrix4x5.m02;
				float m15 = matrix4x5.m03;
				Matrix4x4 matrix4x6 = default(Matrix4x4);
				float m16 = matrix4x6.m01;
				float m17 = matrix4x6.m02;
				float m18 = matrix4x6.m03;
				Vector3 vector2 = default(Vector3);
				float num7 = vector2.z * 0.5f;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				int num8 = 0;
				int num9 = 0;
				Matrix4x4 matrix4x7 = default(Matrix4x4);
				float m19 = matrix4x7.m01;
				float m20 = matrix4x7.m02;
				float m21 = matrix4x7.m03;
				Matrix4x4 matrix4x8 = default(Matrix4x4);
				float m22 = matrix4x8.m01;
				float m23 = matrix4x8.m02;
				float m24 = matrix4x8.m03;
				float z4 = Vector3.zero.z;
				Vector3 vector4 = default(Vector3);
				float z5 = vector4.z;
				int num10 = 0;
				int num11 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B790", Offset = "0x2F1A190", VA = "0x182F1B790")]
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

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BEF0", Offset = "0x2F1A8F0", VA = "0x182F1BEF0")]
		private void UpdateDataIfTransformChanged()
		{
			//Discarded unreachable code: IL_0046
			//IL_003f: Expected O, but got I4
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
					return;
				}
			}
			int num = 0;
			m_NavMeshDataInstance = (NavMeshDataInstance)num;
			AddData();
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C210", Offset = "0x2F1AC10", VA = "0x182F1C210")]
		public unsafe NavMeshSurface()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			//IL_0018: Expected F4, but got I8
			//IL_0013: Expected native int or pointer, but got O
			//IL_003a: Expected I4, but got I8
			//IL_004c: Expected native int or pointer, but got O
			ulong num = default(ulong);
			((Vector3*)(IntPtr)m_Size)->z = (long)num;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)m_Center)->z = (long)num2;
			m_LayerMask = -1;
			m_IgnoreNavMeshAgent = true;
			m_TileSize = 256;
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)m_LastPosition)->z = z;
			Quaternion identity = Quaternion.identity;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C190", Offset = "0x2F1AB90", VA = "0x182F1C190")]
		static NavMeshSurface()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
