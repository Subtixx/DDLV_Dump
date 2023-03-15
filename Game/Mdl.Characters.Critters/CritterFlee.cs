using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Grid;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092E")]
	internal class CritterFlee : Motivation<CritterFleeConfig>, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400331A")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400331B")]
		private float timer;

		[Cpp2IlInjected.Token(Token = "0x6002A42")]
		[Cpp2IlInjected.Address(RVA = "0x1100610", Offset = "0x10FF010", VA = "0x181100610")]
		public CritterFlee(CritterFleeConfig critterFleeConfig)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)critterFleeConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A43")]
		[Cpp2IlInjected.Address(RVA = "0x10FFC10", Offset = "0x10FE610", VA = "0x1810FFC10", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_001d
			//IL_001c: Expected F4, but got O
			MotivationConfig critterInterruptibleMotivationConfig = (critter = agent.GetComponent<Critter>())._critterInterruptibleMotivationConfig;
			timer = (float)critterInterruptibleMotivationConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A44")]
		[Cpp2IlInjected.Address(RVA = "0x10FFC80", Offset = "0x10FE680", VA = "0x1810FFC80", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0018: Expected O, but got I4
			//IL_007a: Expected O, but got F4
			//IL_009f: Expected O, but got F4
			//IL_00c4: Expected O, but got F4
			//IL_0100: Expected O, but got F4
			//IL_01a8: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Critter critter = this.critter;
			int num4 = 0;
			IOrderedEnumerable<Vector3> orderedEnumerable;
			if (!(critter == (UnityEngine.Object)num4))
			{
				NavMeshAgent agent2 = this.critter.Agent;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform = this.critter.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				bool flag = default(bool);
				if (flag)
				{
					Vector3[] array = new Vector3[4];
					GridScript _003CAssociatedGrid_003Ek__BackingField = this.critter.AssociatedGrid;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					array[1] = (Vector3)z3;
					GridData gridData = this.critter.AssociatedGrid.GridData;
					Vector3 vector4 = default(Vector3);
					float z4 = vector4.z;
					array[2] = (Vector3)z4;
					GridData gridData2 = this.critter.AssociatedGrid.GridData;
					Vector3 vector5 = default(Vector3);
					float z5 = vector5.z;
					array[4] = (Vector3)z5;
					int sizeX_ = this.critter.AssociatedGrid.GridData.sizeX_;
					GridData gridData3 = this.critter.AssociatedGrid.GridData;
					Vector3 vector6 = default(Vector3);
					float z6 = vector6.z;
					array[5] = (Vector3)z6;
					Func<Vector3, float> func = (Func<Vector3, float>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0015
						Transform transform2 = this.critter.transform;
						Vector3 vector11 = default(Vector3);
						float z11 = vector11.z;
						float result = default(float);
						return result;
					};
					orderedEnumerable = (IOrderedEnumerable<Vector3>)Enumerable.OrderByDescending<Vector3, float>((IEnumerable<>)(object)array, (Func<, >)(object)func);
					int num5 = 0;
					if (orderedEnumerable != null)
					{
						uint num6 = default(uint);
						if (num3 < (int)num6)
						{
							num3 += num3;
							if (num3 == (int)num6)
							{
								goto IL_0169;
							}
							num3++;
						}
						int walkableMask = this.critter.Agent.walkableMask;
						int agentTypeID = this.critter.Agent.agentTypeID;
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
						NavMeshAgent agent3 = this.critter.Agent;
					}
					goto IL_0169;
				}
				goto IL_01a8;
			}
			goto IL_01b0;
			IL_01b0:
			int num7 = 0;
			throw new IndexOutOfRangeException();
			IL_0169:
			if (orderedEnumerable != null)
			{
				int num8 = 0;
			}
			ulong num9 = default(ulong);
			if (num9 == 0)
			{
				Vector3 vector7 = default(Vector3);
				float z7 = vector7.z;
				Vector3 vector8 = default(Vector3);
				float z8 = vector8.z;
				Vector3 vector9 = default(Vector3);
				float z9 = vector9.z;
				Vector3 vector10 = default(Vector3);
				float z10 = vector10.z;
			}
			NavMeshAgent navMeshAgent = default(NavMeshAgent);
			navMeshAgent.speed = 1.1062477E+09f;
			goto IL_01a8;
			IL_01a8:
			if (0 > 1106247680)
			{
			}
			goto IL_01b0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A45")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A46")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A47")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "19")]
		public bool CanInteractWithAvatar()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A48")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool CanBeFed()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
