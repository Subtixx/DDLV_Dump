using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using NodeCanvas.Framework;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public abstract class MdlConditionTask : ConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		protected GameObject Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D20", Offset = "0xBC0720", VA = "0x180BC1D20")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		protected PlayerAvatar AvatarComponent
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xBC1C90", Offset = "0xBC0690", VA = "0x180BC1C90")]
			get
			{
				//Discarded unreachable code: IL_0009
				IBlackboard blackboard = ((Task)this)._blackboard;
				PlayerAvatar result = default(PlayerAvatar);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		protected GameObject Character
		{
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0xBC1E10", Offset = "0xBC0810", VA = "0x180BC1E10")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected Mdl.Characters.Character CharacterComponent
		{
			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D80", Offset = "0xBC0780", VA = "0x180BC1D80")]
			get
			{
				//Discarded unreachable code: IL_0009
				IBlackboard blackboard = ((Task)this)._blackboard;
				Mdl.Characters.Character result = default(Mdl.Characters.Character);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		protected MissionSlotClass MissionSlotClass
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0xBC1E70", Offset = "0xBC0870", VA = "0x180BC1E70")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected int MissionSlotId
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0xBC1ED0", Offset = "0xBC08D0", VA = "0x180BC1ED0")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		protected MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F30", Offset = "0xBC0930", VA = "0x180BC1F30")]
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

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0xBC20C0", Offset = "0xBC0AC0", VA = "0x180BC20C0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xBC1C80", Offset = "0xBC0680", VA = "0x180BC1C80")]
		protected MdlConditionTask()
		{
		}
	}
}
