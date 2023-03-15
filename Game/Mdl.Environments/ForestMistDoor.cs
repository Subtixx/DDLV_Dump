using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000632")]
	internal class ForestMistDoor : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000633")]
		public delegate void WrongDoorEntered(ForestMistDoor door);

		[Cpp2IlInjected.Token(Token = "0x2000634")]
		public delegate void RealDoorEntered(ForestMistDoor door);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002524")]
		public bool Real;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002525")]
		public WrongDoorEntered OnWrongDoorEntered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002526")]
		public RealDoorEntered OnRealDoorEntered;

		[Cpp2IlInjected.Token(Token = "0x6001B84")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B85")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B86")]
		[Cpp2IlInjected.Address(RVA = "0x1464680", Offset = "0x1463080", VA = "0x181464680")]
		private void OnTriggerEnter(Collider collider)
		{
			//Discarded unreachable code: IL_0049
			Collider _003CCollider_003Ek__BackingField = SystemRoot.Instance._avatar.Collider;
			if (!(collider == _003CCollider_003Ek__BackingField))
			{
				return;
			}
			if (!Real)
			{
				OnWrongDoorEntered?.Invoke(this);
				return;
			}
			RealDoorEntered onRealDoorEntered = OnRealDoorEntered;
			while (onRealDoorEntered == null)
			{
			}
			onRealDoorEntered(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B87")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ForestMistDoor()
		{
		}
	}
}
