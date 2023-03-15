using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008B6")]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(Rigidbody))]
	public class StimulusBroadcaster : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008B7")]
		public delegate float ProbabilityFunction(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x170005E2")]
		public GameObject Sender
		{
			[Cpp2IlInjected.Token(Token = "0x6002840")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CSender_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002841")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CSender_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E3")]
		public object Message
		{
			[Cpp2IlInjected.Token(Token = "0x6002842")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CMessage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002843")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CMessage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E4")]
		public ProbabilityFunction Probability
		{
			[Cpp2IlInjected.Token(Token = "0x6002844")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CProbability_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002845")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CProbability_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002846")]
		[Cpp2IlInjected.Address(RVA = "0xF63390", Offset = "0xF61D90", VA = "0x180F63390")]
		private void Awake()
		{
			//Discarded unreachable code: IL_000d
			GetComponent<Collider>().isTrigger = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002847")]
		[Cpp2IlInjected.Address(RVA = "0xF633F0", Offset = "0xF61DF0", VA = "0x180F633F0")]
		public void Broadcast(GameObject sender, object message, ProbabilityFunction probability)
		{
			Sender = sender;
			Message = message;
			Probability = probability;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002848")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StimulusBroadcaster()
		{
		}
	}
}
