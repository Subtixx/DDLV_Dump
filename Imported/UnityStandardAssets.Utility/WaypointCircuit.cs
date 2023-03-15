using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public class WaypointList
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WaypointCircuit circuit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public Transform[] items = new Transform[0];

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC7F0", Offset = "0x3DCB1F0", VA = "0x183DCC7F0")]
			public WaypointList()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct RoutePoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public Vector3 direction;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2E30", Offset = "0x2AF1830", VA = "0x182AF2E30")]
			public unsafe RoutePoint(Vector3 position, Vector3 direction)
			{
				//IL_0015: Expected native int or pointer, but got O
				float z = position.z;
				float z2 = direction.z;
				((Vector3*)(IntPtr)this.direction)->z = z2;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public WaypointList waypointList = new WaypointList
		{
			items = new Transform[0]
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private bool smoothRoute = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private int numPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Vector3[] points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private float[] distances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public float editorVisualisationSubsteps = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int p0n;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int p1n;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private int p2n;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private int p3n;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private float i;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Vector3 P0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Vector3 P1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Vector3 P2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Vector3 P3;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x40001BF")]
		public float Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x824260", Offset = "0x822C60", VA = "0x180824260")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Transform[] Waypoints
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x2A659E0", Offset = "0x2A643E0", VA = "0x182A659E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return waypointList.items;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB710", Offset = "0x3DCA110", VA = "0x183DCB710")]
		private void Awake()
		{
			//Discarded unreachable code: IL_002f
			WaypointList waypointList = this.waypointList;
			if (waypointList.items.Length > 1)
			{
				CachePositionsAndDistances();
			}
			int num = (numPoints = waypointList.items.Length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC240", Offset = "0x3DCAC40", VA = "0x183DCC240")]
		public RoutePoint GetRoutePoint(float dist)
		{
			float z = GetRoutePosition(dist).z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC340", Offset = "0x3DCAD40", VA = "0x183DCC340")]
		public Vector3 GetRoutePosition(float dist)
		{
			//IL_000d: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			float num4 = Mathf.Repeat(num2, dist);
			int num5 = 0;
			num++;
			num5 = num;
			num += num;
			float value = Mathf.InverseLerp(num4, dist, num4);
			int num6 = 0;
			float num7 = Mathf.Clamp01(value);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBB10", Offset = "0x3DCA510", VA = "0x183DCBB10")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			float z = p2.z;
			float z2 = p1.z;
			float z3 = p0.z;
			float z4 = p1.z;
			float z5 = p2.z;
			float z6 = p0.z;
			float z7 = p1.z;
			float z8 = p2.z;
			float z9 = p0.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB760", Offset = "0x3DCA160", VA = "0x183DCB760")]
		private void CachePositionsAndDistances()
		{
			//Discarded unreachable code: IL_010c
			//IL_009e: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00f5: Expected O, but got F4
			//IL_0103: Expected F4, but got I4
			int num = 0;
			int length = this.waypointList.items.Length;
			length++;
			Vector3[] array = (points = new Vector3[length]);
			int length2 = this.waypointList.items.Length;
			length2++;
			float[] array2 = (distances = new float[length2]);
			Vector3[] array3 = points;
			int num2 = 0;
			int num3 = 0;
			if (num2 >= array3.Length)
			{
				return;
			}
			Transform[] items = this.waypointList.items;
			int length3 = items.Length;
			Transform transform = items[(object)array2];
			Transform transform2 = items[(object)array2];
			int num4 = 0;
			if (transform != (UnityEngine.Object)num4)
			{
				int num5 = 0;
				if (transform2 != (UnityEngine.Object)num5)
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
					WaypointList waypointList = this.waypointList;
					Vector3[] array4 = points;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Transform transform3 = waypointList.items[(object)transform2];
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					array4[1] = (Vector3)z3;
					distances[0] = num3;
				}
			}
			Vector3[] array5 = points;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC730", Offset = "0x3DCB130", VA = "0x183DCC730")]
		private void OnDrawGizmos()
		{
			int selected = 0;
			DrawGizmos((byte)selected != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC720", Offset = "0x3DCB120", VA = "0x183DCC720")]
		private void OnDrawGizmosSelected()
		{
			DrawGizmos(selected: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBEE0", Offset = "0x3DCA8E0", VA = "0x183DCBEE0")]
		private void DrawGizmos(bool selected)
		{
			//Discarded unreachable code: IL_00e6
			//IL_00be: Invalid comparison between F4 and I4
			//IL_00d0: Invalid comparison between F4 and I4
			this.waypointList.circuit = this;
			int length = this.waypointList.items.Length;
			if (length <= 1)
			{
				return;
			}
			numPoints = length;
			CachePositionsAndDistances();
			float[] array = distances;
			int num = array.Length - 1;
			float num2 = array[num];
			int num3 = 0;
			int num4 = 0;
			Length = num2;
			if (selected)
			{
				Color yellow = Color.yellow;
			}
			Transform transform = this.waypointList.items[0];
			if ((smoothRoute ? 1 : 0) == num3)
			{
				WaypointList waypointList = this.waypointList;
				Transform[] items = waypointList.items;
				if (num3 >= items.Length)
				{
					return;
				}
				Transform transform2 = waypointList.items[(object)transform];
				WaypointList waypointList2 = this.waypointList;
			}
			float num5 = Length;
			if (!(num5 <= (float)num4))
			{
				float num6 = Length;
				num5 = num6;
				while (num6 > (float)num4)
				{
				}
			}
			Transform transform3 = this.waypointList.items[0];
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC740", Offset = "0x3DCB140", VA = "0x183DCC740")]
		public WaypointCircuit()
		{
		}
	}
}
