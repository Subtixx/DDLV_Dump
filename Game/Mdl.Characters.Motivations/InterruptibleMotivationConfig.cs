using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008E4")]
	[CreateAssetMenu]
	public class InterruptibleMotivationConfig : MotivationConfig
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20008E5")]
		public class ConditionalMotivation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400318E")]
			[Tooltip("Chance of occurring in percentage")]
			public float probability = 10f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400318F")]
			[Tooltip("Cooldown in seconds")]
			public float cooldown = 30f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003190")]
			public MotivationConfig motivation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003191")]
			public List<MotivationConditionConfig> conditions = (List<MotivationConditionConfig>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60028F5")]
			[Cpp2IlInjected.Address(RVA = "0xE5EEA0", Offset = "0xE5D8A0", VA = "0x180E5EEA0")]
			public ConditionalMotivation()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003187")]
		[Tooltip("Chance of interrupting an other character in percentage")]
		public float broadcastStimulusProbability = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003188")]
		[Tooltip("The NPC won't react to stimuli for n seconds")]
		public float reactionCooldown = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003189")]
		[Tooltip("The motivation of the NPC when there is no interruption")]
		public MotivationConfig motivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400318A")]
		[Tooltip("Reaction to an other NPC saying hi (null means no reaction)")]
		public SayHiToVillagerConfig sayHiConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400318B")]
		[Tooltip("Reactions to point of interest stimuli (null means no reaction)")]
		public List<VisitPointOfInterestConfig> pointOfInterestReactionConfig = (List<VisitPointOfInterestConfig>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400318C")]
		[Tooltip("Check for conditional interrupts every n seconds")]
		public float checkForConditionalInterruptsInterval = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400318D")]
		[Tooltip("Interrupts that can occur given a probability and certain conditions")]
		public List<ConditionalMotivation> conditionalInterrupts = (List<ConditionalMotivation>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60028F3")]
		[Cpp2IlInjected.Address(RVA = "0x11B97C0", Offset = "0x11B81C0", VA = "0x1811B97C0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			InterruptibleMotivation interruptibleMotivation = new InterruptibleMotivation(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028F4")]
		[Cpp2IlInjected.Address(RVA = "0x11B9820", Offset = "0x11B8220", VA = "0x1811B9820")]
		public InterruptibleMotivationConfig()
		{
		}
	}
}
