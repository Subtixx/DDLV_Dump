using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000AC8")]
	[CreateAssetMenu]
	public class ToolAnimations : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003BA9")]
		public AnimationClip Idle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003BAA")]
		public AnimationClip IdleToWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003BAB")]
		public AnimationClip IdleToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003BAC")]
		public AnimationClip Walk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003BAD")]
		public AnimationClip Jog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003BAE")]
		public AnimationClip Run;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003BAF")]
		public AnimationClip RunTurnLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003BB0")]
		public AnimationClip RunTurnRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003BB1")]
		public AnimationClip RunTurn180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003BB2")]
		public AnimationClip WalkToIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003BB3")]
		public AnimationClip HardStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003BB4")]
		public AnimationClip Use;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003BB5")]
		public AnimationClip Fail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003BB6")]
		public AnimationClip Equip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003BB7")]
		public AnimationClip Unequip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003BB8")]
		public AnimationClip EquipLoopStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003BB9")]
		public AnimationClip EquipLoop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003BBA")]
		public AnimationClip EquipLoopEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003BBB")]
		public AnimationClip EquipWristMovement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003BBC")]
		public AnimationClip Mana;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003BBD")]
		public AnimationClip Collect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003BBE")]
		public AnimationClip Removal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003BBF")]
		public AnimationClip Interact;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003BC0")]
		public AnimationClip Rubble;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003BC1")]
		public AnimationClip Gardening;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003BC2")]
		public string AnimationLayerName;

		[Cpp2IlInjected.Token(Token = "0x60031B2")]
		[Cpp2IlInjected.Address(RVA = "0x13D4F90", Offset = "0x13D3990", VA = "0x1813D4F90")]
		public static void ReplaceAnimations(ToolAnimations animations, ToolAnimations defaults, List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			//Discarded unreachable code: IL_0308
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			//IL_0169: Expected O, but got I4
			//IL_0188: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			//IL_01c6: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_0204: Expected O, but got I4
			//IL_0223: Expected O, but got I4
			//IL_0242: Expected O, but got I4
			//IL_0261: Expected O, but got I4
			//IL_0280: Expected O, but got I4
			//IL_029f: Expected O, but got I4
			//IL_02be: Expected O, but got I4
			//IL_02dd: Expected O, but got I4
			//IL_02fc: Expected O, but got I4
			AnimationClip idle = animations.Idle;
			int num = 0;
			bool flag = idle != (Object)num;
			int num2 = 0;
			if (flag)
			{
				AnimationClip idle2 = defaults.Idle;
			}
			AnimationClip idleToWalk = animations.IdleToWalk;
			int num3 = 0;
			if (idleToWalk != (Object)num3)
			{
				AnimationClip idleToWalk2 = defaults.IdleToWalk;
			}
			AnimationClip idleToRun = animations.IdleToRun;
			int num4 = 0;
			if (idleToRun != (Object)num4)
			{
				AnimationClip idleToRun2 = defaults.IdleToRun;
			}
			AnimationClip walk = animations.Walk;
			int num5 = 0;
			if (walk != (Object)num5)
			{
				AnimationClip walk2 = defaults.Walk;
			}
			AnimationClip jog = animations.Jog;
			int num6 = 0;
			if (jog != (Object)num6)
			{
				AnimationClip jog2 = defaults.Jog;
			}
			AnimationClip run = animations.Run;
			int num7 = 0;
			if (run != (Object)num7)
			{
				AnimationClip run2 = defaults.Run;
			}
			AnimationClip runTurnLeft = animations.RunTurnLeft;
			int num8 = 0;
			if (runTurnLeft != (Object)num8)
			{
				AnimationClip runTurnLeft2 = defaults.RunTurnLeft;
			}
			AnimationClip runTurnRight = animations.RunTurnRight;
			int num9 = 0;
			if (runTurnRight != (Object)num9)
			{
				AnimationClip runTurnRight2 = defaults.RunTurnRight;
			}
			AnimationClip runTurn = animations.RunTurn180;
			int num10 = 0;
			if (runTurn != (Object)num10)
			{
				AnimationClip runTurn2 = defaults.RunTurn180;
			}
			AnimationClip walkToIdle = animations.WalkToIdle;
			int num11 = 0;
			if (walkToIdle != (Object)num11)
			{
				AnimationClip walkToIdle2 = defaults.WalkToIdle;
			}
			AnimationClip hardStop = animations.HardStop;
			int num12 = 0;
			if (hardStop != (Object)num12)
			{
				AnimationClip hardStop2 = defaults.HardStop;
			}
			AnimationClip use = animations.Use;
			int num13 = 0;
			if (use != (Object)num13)
			{
				AnimationClip use2 = defaults.Use;
			}
			AnimationClip fail = animations.Fail;
			int num14 = 0;
			if (fail != (Object)num14)
			{
				AnimationClip fail2 = defaults.Fail;
			}
			AnimationClip equip = animations.Equip;
			int num15 = 0;
			if (equip != (Object)num15)
			{
				AnimationClip equip2 = defaults.Equip;
			}
			AnimationClip unequip = animations.Unequip;
			int num16 = 0;
			if (unequip != (Object)num16)
			{
				AnimationClip unequip2 = defaults.Unequip;
			}
			AnimationClip equipLoopStart = animations.EquipLoopStart;
			int num17 = 0;
			if (equipLoopStart != (Object)num17)
			{
				AnimationClip equipLoopStart2 = defaults.EquipLoopStart;
			}
			AnimationClip equipLoop = animations.EquipLoop;
			int num18 = 0;
			if (equipLoop != (Object)num18)
			{
				AnimationClip equipLoop2 = defaults.EquipLoop;
			}
			AnimationClip equipLoopEnd = animations.EquipLoopEnd;
			int num19 = 0;
			if (equipLoopEnd != (Object)num19)
			{
				AnimationClip equipLoopEnd2 = defaults.EquipLoopEnd;
			}
			AnimationClip equipWristMovement = animations.EquipWristMovement;
			int num20 = 0;
			if (equipWristMovement != (Object)num20)
			{
				AnimationClip equipWristMovement2 = defaults.EquipWristMovement;
			}
			AnimationClip mana = animations.Mana;
			int num21 = 0;
			if (mana != (Object)num21)
			{
				AnimationClip mana2 = defaults.Mana;
			}
			AnimationClip collect = animations.Collect;
			int num22 = 0;
			if (collect != (Object)num22)
			{
				AnimationClip collect2 = defaults.Collect;
			}
			AnimationClip removal = animations.Removal;
			int num23 = 0;
			if (removal != (Object)num23)
			{
				AnimationClip removal2 = defaults.Removal;
			}
			AnimationClip interact = animations.Interact;
			int num24 = 0;
			if (interact != (Object)num24)
			{
				AnimationClip interact2 = defaults.Interact;
			}
			AnimationClip rubble = animations.Rubble;
			int num25 = 0;
			if (rubble != (Object)num25)
			{
				AnimationClip rubble2 = defaults.Rubble;
			}
			AnimationClip gardening = animations.Gardening;
			int num26 = 0;
			if (gardening != (Object)num26)
			{
				AnimationClip gardening2 = defaults.Gardening;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031B3")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public ToolAnimations()
		{
		}
	}
}
