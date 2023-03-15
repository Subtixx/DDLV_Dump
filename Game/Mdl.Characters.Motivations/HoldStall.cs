using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Buildings;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008DA")]
	public class HoldStall : Motivation<HoldStallConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003166")]
		private Character character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003167")]
		private Task gotoTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003168")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.Token(Token = "0x60028CF")]
		[Cpp2IlInjected.Address(RVA = "0x11ACD90", Offset = "0x11AB790", VA = "0x1811ACD90")]
		public HoldStall(HoldStallConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x60028D0")]
		[Cpp2IlInjected.Address(RVA = "0x11ACA90", Offset = "0x11AB490", VA = "0x1811ACA90", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_0013
			string text = default(string);
			return ((Motivation<C>)(object)this).GetInfo(agent) + " - " + text;
		}

		[Cpp2IlInjected.Token(Token = "0x60028D1")]
		[Cpp2IlInjected.Address(RVA = "0x11AC3B0", Offset = "0x11AADB0", VA = "0x1811AC3B0", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			CancellationTokenSource cancellationTokenSource = (ctSource = new CancellationTokenSource());
			Character character = (this.character = agent.GetComponent<Character>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D2")]
		[Cpp2IlInjected.Address(RVA = "0x11ACA30", Offset = "0x11AB430", VA = "0x1811ACA30", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			CancellationTokenSource cancellationTokenSource = ctSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctSource.Dispose();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D3")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B20", Offset = "0xCC7520", VA = "0x180CC8B20", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			IMotivation subMotivation = ((IMotivation)this).SubMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x60028D4")]
		[Cpp2IlInjected.Address(RVA = "0x11AC450", Offset = "0x11AAE50", VA = "0x1811AC450", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			Character character = this.character;
			int num = 0;
			if (!(character == (UnityEngine.Object)num))
			{
				Character character2 = this.character;
				if (character2.WorkingAtAShop)
				{
					Stall _003CMyStall_003Ek__BackingField = character2.MyStall;
					int num2 = 0;
					if (!(_003CMyStall_003Ek__BackingField == (UnityEngine.Object)num2))
					{
						Task task = gotoTask;
						if (task == null || task.IsCompleted)
						{
							Transform employeePosition = this.character.MyStall._employeePosition;
							Vector3 vector = default(Vector3);
							float z = vector.z;
							Transform transform = agent.transform;
							Vector3 vector2 = default(Vector3);
							float z2 = vector2.z;
							float num3 = default(float);
							if (!(num3 <= 0.0001f))
							{
								Transform employeePosition2 = this.character.MyStall._employeePosition;
								Vector3 vector3 = default(Vector3);
								float z3 = vector3.z;
								Transform transform2 = agent.transform;
								Vector3 vector4 = default(Vector3);
								float z4 = vector4.z;
								Transform _003Ctransform_003Ek__BackingField = this.character.transform;
								Vector3 vector5 = default(Vector3);
								float z5 = vector5.z;
								Transform employeePosition3 = this.character.MyStall._employeePosition;
								Vector3 vector6 = default(Vector3);
								float z6 = vector6.z;
								float num4 = default(float);
								if (!(num4 > 0.1f))
								{
									int num5 = 0;
									gotoTask = (Task)num5;
								}
								CancellationToken token = ctSource.Token;
								int num6 = 0;
								CancellationToken token2 = ctSource.Token;
								int num7 = 0;
								Task task2 = default(Task);
								gotoTask = task2;
							}
						}
					}
				}
			}
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D5")]
		[Cpp2IlInjected.Address(RVA = "0x11ACC50", Offset = "0x11AB650", VA = "0x1811ACC50")]
		[AsyncStateMachine(typeof(_003CWalkToPosition_003Ed__9))]
		private Task WalkToPosition(GameObject agent, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60028D6")]
		[Cpp2IlInjected.Address(RVA = "0x11ACB20", Offset = "0x11AB520", VA = "0x1811ACB20")]
		[AsyncStateMachine(typeof(_003CTeleportToPosition_003Ed__10))]
		private Task TeleportToPosition(GameObject agent, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
