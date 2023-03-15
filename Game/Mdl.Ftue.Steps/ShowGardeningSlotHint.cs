using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x200059A")]
	[CreateAssetMenu]
	public class ShowGardeningSlotHint : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.Token(Token = "0x200059B")]
		public enum SlotState
		{
			[Cpp2IlInjected.Token(Token = "0x400228A")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x400228B")]
			Harvestable,
			[Cpp2IlInjected.Token(Token = "0x400228C")]
			Plantable,
			[Cpp2IlInjected.Token(Token = "0x400228D")]
			Waterable
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002280")]
		public string messageKey = "tutorial_gardening_select_slot";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002281")]
		public SlotState slotState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002282")]
		public float colliderRadius = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002283")]
		public float zoom = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002284")]
		public bool selectedAtStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002285")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002286")]
		public bool hidePlayer = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002287")]
		[ItemID]
		public int seed;

		[Cpp2IlInjected.Token(Token = "0x17000370")]
		public GardeningSlot SlotToSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6001904")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CSlotToSelect_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001905")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CSlotToSelect_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000371")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x6001906")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001907")]
			[Cpp2IlInjected.Address(RVA = "0xF50940", Offset = "0xF4F340", VA = "0x180F50940", Slot = "6")]
			get
			{
				if ((object)this != null)
				{
				}
				float z = Vector3.zero.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000373")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6001908")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0", Slot = "7")]
			get
			{
				return colliderRadius;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x6001909")]
			[Cpp2IlInjected.Address(RVA = "0x823CC0", Offset = "0x8226C0", VA = "0x180823CC0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000375")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x600190A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000376")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x600190B")]
			[Cpp2IlInjected.Address(RVA = "0xF50930", Offset = "0xF4F330", VA = "0x180F50930", Slot = "10")]
			get
			{
				int num = 0;
				bool flag = (selectedAtStart ? 1 : 0) != num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000377")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600190C")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000378")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600190D")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600190E")]
		[Cpp2IlInjected.Address(RVA = "0xF506D0", Offset = "0xF4F0D0", VA = "0x180F506D0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__29))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600190F")]
		[Cpp2IlInjected.Address(RVA = "0xF508D0", Offset = "0xF4F2D0", VA = "0x180F508D0")]
		public ShowGardeningSlotHint()
		{
		}
	}
}
