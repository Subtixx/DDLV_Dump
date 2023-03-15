using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007A5")]
	public class RelaxingPosition : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x20007A6")]
		public class RelaxingPositionTaskConditional : IPlayerTaskConditional
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002B99")]
			private RelaxingPosition[] RelaxingPositions;

			[Cpp2IlInjected.Token(Token = "0x6002210")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public RelaxingPositionTaskConditional(RelaxingPosition[] relaxingPositions)
			{
				RelaxingPositions = relaxingPositions;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002211")]
			[Cpp2IlInjected.Address(RVA = "0x1603C10", Offset = "0x1602610", VA = "0x181603C10", Slot = "4")]
			public bool Evaluate()
			{
				RelaxingPosition[] relaxingPositions = RelaxingPositions;
				Func<RelaxingPosition, bool> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RelaxingPosition x) => default(bool));
				}
				return ((IEnumerable<>)(object)relaxingPositions).Any<RelaxingPosition>((Func<, >)(object)_003C_003E9__2_);
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007A9")]
		public class AdditionalData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002B9D")]
			public string Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002B9E")]
			public float Value;

			[Cpp2IlInjected.Token(Token = "0x6002217")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AdditionalData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B93")]
		[SerializeField]
		[FormerlySerializedAs("CharacterDestination")]
		private Transform characterDestination;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B94")]
		[SerializeField]
		private Transform[] additionalDestinations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B95")]
		public RelaxingBehaviourData BehaviourData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B96")]
		public List<AdditionalData> AdditionalDatas = (List<AdditionalData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		public IEnumerable<Transform> AllDestinations
		{
			[Cpp2IlInjected.Token(Token = "0x6002203")]
			[Cpp2IlInjected.Address(RVA = "0xCC01E0", Offset = "0xCBEBE0", VA = "0x180CC01E0")]
			[IteratorStateMachine(typeof(_003Cget_AllDestinations_003Ed__4))]
			get
			{
				new _003Cget_AllDestinations_003Ed__4(-2)._003C_003E4__this = this;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		public GameObject RelaxingCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6002204")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CRelaxingCharacter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002205")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CRelaxingCharacter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public bool Available
		{
			[Cpp2IlInjected.Token(Token = "0x6002206")]
			[Cpp2IlInjected.Address(RVA = "0xCC0250", Offset = "0xCBEC50", VA = "0x180CC0250")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = RelaxingCharacter;
				int num = 0;
				return gameObject == (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004E")]
		public event EventHandler RelaxingPositionDestroyedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002207")]
			[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBEB40", VA = "0x180CC0140")]
			[CompilerGenerated]
			add
			{
				EventHandler relaxingPositionDestroyedEvent = this.RelaxingPositionDestroyedEvent;
				Delegate @delegate = Delegate.Combine(relaxingPositionDestroyedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != relaxingPositionDestroyedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002208")]
			[Cpp2IlInjected.Address(RVA = "0xCC02B0", Offset = "0xCBECB0", VA = "0x180CC02B0")]
			[CompilerGenerated]
			remove
			{
				EventHandler relaxingPositionDestroyedEvent = this.RelaxingPositionDestroyedEvent;
				Delegate @delegate = Delegate.Remove(relaxingPositionDestroyedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != relaxingPositionDestroyedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002209")]
		[Cpp2IlInjected.Address(RVA = "0xCBFDB0", Offset = "0xCBE7B0", VA = "0x180CBFDB0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_001d
			GameObject gameObject = base.gameObject;
			bool flag = default(bool);
			if (flag)
			{
				RelaxingPositionTaskConditional relaxingPositionTaskConditional = new RelaxingPositionTaskConditional(base.gameObject.GetComponents<RelaxingPosition>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600220A")]
		[Cpp2IlInjected.Address(RVA = "0xCBFFB0", Offset = "0xCBE9B0", VA = "0x180CBFFB0")]
		private void OnDestroy()
		{
			if (this.RelaxingPositionDestroyedEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600220B")]
		[Cpp2IlInjected.Address(RVA = "0xCBFF40", Offset = "0xCBE940", VA = "0x180CBFF40")]
		public int GetDestinationCount()
		{
			Transform[] array;
			do
			{
				array = additionalDestinations;
			}
			while (array == null);
			int length = array.Length;
			return length + 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600220C")]
		[Cpp2IlInjected.Address(RVA = "0xCBFF60", Offset = "0xCBE960", VA = "0x180CBFF60")]
		public Transform GetDestination(int index)
		{
			//Discarded unreachable code: IL_0018
			if (index != 0)
			{
				return additionalDestinations[index];
			}
			return characterDestination;
		}

		[Cpp2IlInjected.Token(Token = "0x600220D")]
		[Cpp2IlInjected.Address(RVA = "0xCC0030", Offset = "0xCBEA30", VA = "0x180CC0030")]
		public void Reserve(GameObject gameObject)
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject2 = RelaxingCharacter;
			int num = 0;
			if (gameObject2 == (UnityEngine.Object)num)
			{
				RelaxingCharacter = gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600220E")]
		[Cpp2IlInjected.Address(RVA = "0xCBFEB0", Offset = "0xCBE8B0", VA = "0x180CBFEB0")]
		public void Free(GameObject gameObject)
		{
			//IL_0018: Expected O, but got I8
			if (RelaxingCharacter == gameObject)
			{
				RelaxingCharacter = (GameObject)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600220F")]
		[Cpp2IlInjected.Address(RVA = "0xCC00C0", Offset = "0xCBEAC0", VA = "0x180CC00C0")]
		public RelaxingPosition()
		{
		}
	}
}
