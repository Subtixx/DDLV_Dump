using System;
using Cpp2IlInjected;
using Mdl.Utils;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Category("Movement/Pathfinding")]
	[Description("find a point in the donut region (minDistance, maxDistance) around the character. the destination will be on the nav mesh and reachable. if it cannot find a point in 10 tries, will return failure.")]
	[Name("Find Valid Position Around NavMesh", 0)]
	public class FindValidPositionAround : ActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public BBParameter<GameObject> source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public BBParameter<float> minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public BBParameter<float> maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public BBParameter<float> maxTravelDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		[BlackboardOnly]
		public BBParameter<Vector3> saveFoundPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private NavMeshHit hit;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x136FF90", Offset = "0x136E990", VA = "0x18136FF90", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x136F9A0", Offset = "0x136E3A0", VA = "0x18136F9A0")]
		private static float GetPathLength(NavMeshPath path)
		{
			int num = 0;
			if (path.status != NavMeshPathStatus.PathInvalid)
			{
				Vector3[] corners = path.corners;
				if (1 < corners.Length)
				{
					Vector3[] corners2 = path.corners;
					Vector3[] corners3 = path.corners;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x136FAD0", Offset = "0x136E4D0", VA = "0x18136FAD0", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_0040: Expected F4, but got O
			//IL_004d: Expected F4, but got O
			//IL_008e: Expected F4, but got O
			Transform transform = ((GameObject)((BBParameter<T>)(object)source).value).transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			System.Random random = new System.Random();
			int num = 0;
			int minValue = 0;
			int num2 = random.Next(minValue, 360);
			float min = (float)((BBParameter<T>)(object)minDistance).value;
			float max = (float)((BBParameter<T>)(object)maxDistance).value;
			min = random.Next(min, max);
			bool flag = default(bool);
			if (flag)
			{
				NavMeshPath path = new NavMeshPath();
				bool flag2 = default(bool);
				if (flag2)
				{
					if (!maxTravelDistance.isDefined)
					{
						BBParameter<Vector3> bBParameter = saveFoundPosition;
						throw new NullReferenceException();
					}
					float pathLength = GetPathLength(path);
					float num3 = (float)((BBParameter<T>)(object)maxTravelDistance).value;
				}
			}
			num++;
			int success = 0;
			EndAction((byte)success != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x136FF10", Offset = "0x136E910", VA = "0x18136FF10")]
		public FindValidPositionAround()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			minDistance = (BBParameter<float>)(object)bBParameter;
			BBParameter<> bBParameter2 = default(BBParameter<>);
			maxDistance = (BBParameter<float>)(object)bBParameter2;
			base._002Ector();
		}
	}
}
