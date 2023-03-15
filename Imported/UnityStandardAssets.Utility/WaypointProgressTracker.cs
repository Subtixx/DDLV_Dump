using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public enum ProgressStyle
		{
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			SmoothAlongRoute,
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			PointToPoint
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float lookAheadForTargetOffset = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private float lookAheadForTargetFactor = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private float lookAheadForSpeedOffset = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private float lookAheadForSpeedFactor = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private float pointToPointThreshold = 4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float progressDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int progressNum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private float speed;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x3DCD4B0", Offset = "0x3DCBEB0", VA = "0x183DCD4B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3DCD510", Offset = "0x3DCBF10", VA = "0x183DCD510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2FBB6A0", Offset = "0x2FBA0A0", VA = "0x182FBB6A0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3DCD4F0", Offset = "0x3DCBEF0", VA = "0x183DCD4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3B2FD40", Offset = "0x3B2E740", VA = "0x183B2FD40")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3DCD4D0", Offset = "0x3DCBED0", VA = "0x183DCD4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCB90", Offset = "0x3DCB590", VA = "0x183DCCB90")]
		private void Start()
		{
			//Discarded unreachable code: IL_00a6
			//IL_0010: Expected O, but got I4
			//IL_003e: Expected F4, but got I4
			Transform transform = target;
			int num = 0;
			if (transform == (UnityEngine.Object)num)
			{
				Transform transform2 = (target = new GameObject(base.name + " Waypoint Target").transform);
			}
			int num2 = 0;
			progressDistance = num2;
			if (progressStyle == ProgressStyle.PointToPoint)
			{
				WaypointCircuit waypointCircuit = circuit;
				Transform transform3 = target;
				Transform transform4 = waypointCircuit.waypointList.items[0];
				Vector3 vector = default(Vector3);
				float z = vector.z;
				WaypointCircuit waypointCircuit2 = circuit;
				Transform transform5 = target;
				Transform[] items = waypointCircuit2.waypointList.items;
				int num3 = progressNum;
				Transform transform6 = items[num3];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCA60", Offset = "0x3DCB460", VA = "0x183DCCA60")]
		public void Reset()
		{
			//Discarded unreachable code: IL_006d
			//IL_0009: Expected F4, but got I4
			int num = 0;
			progressDistance = num;
			if (progressStyle == ProgressStyle.PointToPoint)
			{
				WaypointCircuit waypointCircuit = circuit;
				Transform transform = target;
				Transform transform2 = waypointCircuit.waypointList.items[0];
				Vector3 vector = default(Vector3);
				float z = vector.z;
				WaypointCircuit waypointCircuit2 = circuit;
				Transform transform3 = target;
				Transform[] items = waypointCircuit2.waypointList.items;
				int num2 = progressNum;
				Transform transform4 = items[num2];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCDB0", Offset = "0x3DCB7B0", VA = "0x183DCCDB0")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_01bd
			//IL_00fa: Invalid comparison between F4 and I4
			//IL_01b7: Expected native int or pointer, but got O
			int num = 0;
			if (progressStyle != (ProgressStyle)num)
			{
				Transform transform = target;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform2 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int num2 = 0;
				float num3 = default(float);
				if (!(pointToPointThreshold <= num3))
				{
					Transform[] items = circuit.waypointList.items;
					int num4 = progressNum;
					num4++;
					progressNum = num2;
				}
				WaypointCircuit waypointCircuit = circuit;
				Transform transform3 = target;
				Transform[] items2 = waypointCircuit.waypointList.items;
				int num5 = progressNum;
				Transform transform4 = items2[num5];
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				WaypointCircuit waypointCircuit2 = circuit;
				Transform transform5 = target;
				Transform[] items3 = waypointCircuit2.waypointList.items;
				int num6 = progressNum;
				Transform transform6 = items3[num6];
				WaypointCircuit waypointCircuit3 = circuit;
				Transform transform7 = base.transform;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				int num7 = 0;
			}
			int num8 = 0;
			float deltaTime = Time.deltaTime;
			int num9 = 0;
			if (!(deltaTime <= (float)num9))
			{
				float z5 = lastPosition.z;
				Transform transform8 = base.transform;
				Vector3 vector5 = default(Vector3);
				float z6 = vector5.z;
				int num10 = 0;
				float deltaTime2 = Time.deltaTime;
				int num11 = 0;
				float deltaTime3 = Time.deltaTime;
				float b = default(float);
				float num12 = (speed = Mathf.Lerp(deltaTime3, b, deltaTime3));
			}
			WaypointCircuit waypointCircuit4 = circuit;
			Transform transform9 = target;
			float num13 = speed;
			WaypointCircuit waypointCircuit5 = circuit;
			Transform transform10 = target;
			float num14 = speed;
			WaypointCircuit waypointCircuit6 = circuit;
			Transform transform11 = base.transform;
			Vector3 vector6 = default(Vector3);
			float z7 = vector6.z;
			float num15 = default(float);
			float num16 = (progressDistance = num15 * 0.5f);
			Transform transform12 = base.transform;
			Vector3 vector7 = default(Vector3);
			float z8 = vector7.z;
			((Vector3*)(IntPtr)lastPosition)->z = z8;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC850", Offset = "0x3DCB250", VA = "0x183DCC850")]
		private void OnDrawGizmos()
		{
			//Discarded unreachable code: IL_0056
			//IL_0016: Expected O, but got I4
			int num = 0;
			if (Application.isPlaying)
			{
				Color green = Color.green;
				Gizmos.color = (Color)num;
				Transform transform = base.transform;
				Transform transform2 = target;
				WaypointCircuit waypointCircuit = circuit;
				Color yellow = Color.yellow;
				Transform transform3 = target;
				Transform transform4 = target;
				Transform transform5 = target;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD480", Offset = "0x3DCBE80", VA = "0x183DCD480")]
		public WaypointProgressTracker()
		{
		}
	}
}
