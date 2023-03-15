using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008B8")]
	[RequireComponent(typeof(Collider))]
	public class StimulusReceiver : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008B9")]
		public delegate void Stimulus(GameObject sender, object message, StimulusBroadcaster.ProbabilityFunction probability);

		[Cpp2IlInjected.Token(Token = "0x1400005E")]
		public event Stimulus OnStimulus
		{
			[Cpp2IlInjected.Token(Token = "0x600284D")]
			[Cpp2IlInjected.Address(RVA = "0xF63550", Offset = "0xF61F50", VA = "0x180F63550")]
			[CompilerGenerated]
			add
			{
				Stimulus onStimulus = this.OnStimulus;
				Delegate @delegate = Delegate.Combine(onStimulus, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStimulus)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600284E")]
			[Cpp2IlInjected.Address(RVA = "0xF635F0", Offset = "0xF61FF0", VA = "0x180F635F0")]
			[CompilerGenerated]
			remove
			{
				Stimulus onStimulus = this.OnStimulus;
				Delegate @delegate = Delegate.Remove(onStimulus, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStimulus)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600284F")]
		[Cpp2IlInjected.Address(RVA = "0xF63450", Offset = "0xF61E50", VA = "0x180F63450")]
		public void OnTriggerEnter(Collider other)
		{
			//Discarded unreachable code: IL_0059
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			StimulusBroadcaster component = other.GetComponent<StimulusBroadcaster>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				return;
			}
			GameObject _003CSender_003Ek__BackingField = component.Sender;
			int num2 = 0;
			if (_003CSender_003Ek__BackingField != (UnityEngine.Object)num2)
			{
				Stimulus onStimulus = this.OnStimulus;
				if (onStimulus != null)
				{
					StimulusBroadcaster.ProbabilityFunction _003CProbability_003Ek__BackingField = component.Probability;
					object _003CMessage_003Ek__BackingField = component.Message;
					GameObject _003CSender_003Ek__BackingField2 = component.Sender;
					onStimulus(_003CSender_003Ek__BackingField2, _003CMessage_003Ek__BackingField, _003CProbability_003Ek__BackingField);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002850")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StimulusReceiver()
		{
		}
	}
}
