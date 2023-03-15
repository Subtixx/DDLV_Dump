using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C22")]
	public class Boundaries : MonoBehaviour, ICameraBoundary
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004399")]
		[SerializeField]
		private Rect _limits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400439A")]
		[SerializeField]
		private Color DebugColor;

		[Cpp2IlInjected.Token(Token = "0x1700075B")]
		public bool IsConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6003738")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075C")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6003739")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075D")]
		public Rect Limits
		{
			[Cpp2IlInjected.Token(Token = "0x600373A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600373B")]
			[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9969C0", VA = "0x180997FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600373C")]
		[Cpp2IlInjected.Address(RVA = "0x16445C0", Offset = "0x1642FC0", VA = "0x1816445C0")]
		private void OnDrawGizmos()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600373D")]
		[Cpp2IlInjected.Address(RVA = "0x1644420", Offset = "0x1642E20", VA = "0x181644420", Slot = "4")]
		public bool IsIn(Vector3 point)
		{
			//Discarded unreachable code: IL_0042
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			float z = point.z;
			Transform transform3 = base.transform;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = point.z;
			Transform transform4 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600373E")]
		[Cpp2IlInjected.Address(RVA = "0x1643F60", Offset = "0x1642960", VA = "0x181643F60")]
		private Vector3 BottomLeft()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600373F")]
		[Cpp2IlInjected.Address(RVA = "0x1644030", Offset = "0x1642A30", VA = "0x181644030")]
		private Vector3 BottomRight()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003740")]
		[Cpp2IlInjected.Address(RVA = "0x1644860", Offset = "0x1643260", VA = "0x181644860")]
		private Vector3 TopLeft()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003741")]
		[Cpp2IlInjected.Address(RVA = "0x16448F0", Offset = "0x16432F0", VA = "0x1816448F0")]
		private Vector3 TopRight()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003742")]
		[Cpp2IlInjected.Address(RVA = "0x16440C0", Offset = "0x1642AC0", VA = "0x1816440C0")]
		private Vector3 Center()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003743")]
		[Cpp2IlInjected.Address(RVA = "0x1644180", Offset = "0x1642B80", VA = "0x181644180", Slot = "5")]
		public Vector3 ClosestPoint(Vector3 point)
		{
			int num = 0;
			Vector3 vector = BottomLeft();
			Vector3 vector2 = BottomLeft();
			Vector3 vector3 = BottomLeft();
			float z = BottomLeft().z;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003744")]
		[Cpp2IlInjected.Address(RVA = "0x1644990", Offset = "0x1643390", VA = "0x181644990")]
		public Boundaries()
		{
			Color blue = Color.blue;
			base._002Ector();
		}
	}
}
