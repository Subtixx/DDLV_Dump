using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using NodeCanvas.Framework;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	public abstract class MdlActionTask : ActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		protected GameObject Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0xBC0420", Offset = "0xBBEE20", VA = "0x180BC0420")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		protected PlayerAvatar AvatarComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0xBC0390", Offset = "0xBBED90", VA = "0x180BC0390")]
			get
			{
				//Discarded unreachable code: IL_0009
				IBlackboard blackboard = ((Task)this)._blackboard;
				PlayerAvatar result = default(PlayerAvatar);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		protected GameObject Character
		{
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0xBC0510", Offset = "0xBBEF10", VA = "0x180BC0510")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		protected Mdl.Characters.Character CharacterComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0xBC0480", Offset = "0xBBEE80", VA = "0x180BC0480")]
			get
			{
				//Discarded unreachable code: IL_0009
				IBlackboard blackboard = ((Task)this)._blackboard;
				Mdl.Characters.Character result = default(Mdl.Characters.Character);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		protected MissionSlotClass MissionSlotClass
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xBC0570", Offset = "0xBBEF70", VA = "0x180BC0570")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected int MissionSlotId
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xBC05D0", Offset = "0xBBEFD0", VA = "0x180BC05D0")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		protected MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0xBC0630", Offset = "0xBBF030", VA = "0x180BC0630")]
			get
			{
				//Discarded unreachable code: IL_0025
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				IBlackboard blackboard = ((Task)this)._blackboard;
				IBlackboard blackboard2 = ((Task)this)._blackboard;
				MissionSlot result = default(MissionSlot);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0xBC07C0", Offset = "0xBBF1C0", VA = "0x180BC07C0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xBC0120", Offset = "0xBBEB20", VA = "0x180BC0120")]
		protected string AddErrors(string prefix)
		{
			//Discarded unreachable code: IL_007b
			//IL_0006: Expected O, but got I4
			int num = default(int);
			DataValidation.Context context = new DataValidation.Context(num);
			num = 0;
			if (context != null)
			{
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
			if (!Enumerable.Any<DataValidationError>((IEnumerable<>)context.errors))
			{
				return prefix;
			}
			List<DataValidationError> errors = context.errors;
			Func<DataValidationError, string> func = default(Func<DataValidationError, string>);
			if (_003C_003Ec._003C_003E9__16_0 == null)
			{
				func = (Func<DataValidationError, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DataValidationError x) => x.Message));
			}
			IEnumerable<DataValidationError> enumerable = (IEnumerable<DataValidationError>)Enumerable.Select<DataValidationError, string>((IEnumerable<>)errors, (Func<, >)(object)func);
			string text = string.Join("\n", (IEnumerable<>)enumerable);
			return prefix + "\n\nERROR:\n" + text;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D130", Offset = "0xA3BB30", VA = "0x180A3D130")]
		protected MdlActionTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	public abstract class MdlActionTask<T> : MdlActionTask where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public sealed override Type agentType
		{
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x28AD240", Offset = "0x28ABC40", VA = "0x1828AD240", Slot = "8")]
			get
			{
				Type result = default(Type);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public new T agent
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x1C747E0", Offset = "0x1C731E0", VA = "0x181C747E0")]
			get
			{
				//Discarded unreachable code: IL_000d
				Component component = base.agent;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x28AD220", Offset = "0x28ABC20", VA = "0x1828AD220")]
		protected MdlActionTask()
		{
		}//Discarded unreachable code: IL_0007

	}
}
