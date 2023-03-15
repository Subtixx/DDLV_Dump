using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E1")]
	internal class TestPathTo : EnvironmentQuery.Test
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C2A")]
		public int AreaMask = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C2B")]
		public bool SampleQueryPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C2C")]
		public float SampleMaxDistance = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public override float Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60022EA")]
			[Cpp2IlInjected.Address(RVA = "0x1072BF0", Offset = "0x10715F0", VA = "0x181072BF0", Slot = "4")]
			get
			{
				while (true)
				{
					if (SampleQueryPosition)
					{
						/*Error: Could not find block for branch target IL_0009*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022EB")]
		[Cpp2IlInjected.Address(RVA = "0x1072650", Offset = "0x1071050", VA = "0x181072650", Slot = "6")]
		protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
		{
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_006b: Expected F4, but got I4
			int num = 0;
			NavMeshPath navMeshPath = new NavMeshPath();
			int num2 = 0;
			bool flag = default(bool);
			if ((SampleQueryPosition ? 1 : 0) == num2 || flag)
			{
			}
			float z = Vector3.up.z;
			int num3 = 0;
			Color cyan = Color.cyan;
			int areaMask = AreaMask;
			bool flag2 = NavMesh.CalculatePath((Vector3)num, (Vector3)num3, areaMask, navMeshPath);
			NavMeshPathStatus status = navMeshPath.status;
			int num4 = 0;
			int num5 = (int)status;
			float pathLength = GetPathLength(navMeshPath);
			int num6 = 0;
			float num7 = Mathf.Clamp(pathLength, num6, 1f);
			bool flag3 = num5 == 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022EC")]
		[Cpp2IlInjected.Address(RVA = "0x10728E0", Offset = "0x10712E0", VA = "0x1810728E0")]
		private float GetPathLength(NavMeshPath path)
		{
			if (path.corners.Length != 0)
			{
				int num = 0;
				int num2 = 0;
				Vector3[] corners = path.corners;
				if (1 < corners.Length)
				{
					Vector3[] corners2 = path.corners;
					Vector3[] corners3 = path.corners;
					Color magenta = Color.magenta;
					Vector3[] corners4 = path.corners;
					Vector3[] corners5 = path.corners;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022ED")]
		[Cpp2IlInjected.Address(RVA = "0x1072BD0", Offset = "0x10715D0", VA = "0x181072BD0")]
		public TestPathTo()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
