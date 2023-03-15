using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Buildings;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x2000597")]
	[CreateAssetMenu]
	public class InteractWithShoppingStall : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002270")]
		public string messageKey = "tutorial_tap_on_gardening_stall";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002271")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002272")]
		public float zoom = -1f;

		[Cpp2IlInjected.Token(Token = "0x17000367")]
		public ShoppingStall Stall
		{
			[Cpp2IlInjected.Token(Token = "0x60018F3")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60018F4")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x60018F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60018F6")]
			[Cpp2IlInjected.Address(RVA = "0x11B9210", Offset = "0x11B7C10", VA = "0x1811B9210", Slot = "6")]
			get
			{
				if ((object)this != null)
				{
				}
				float z = Vector3.zero.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60018F7")]
			[Cpp2IlInjected.Address(RVA = "0x11B9270", Offset = "0x11B7C70", VA = "0x1811B9270", Slot = "7")]
			get
			{
				ShoppingStall shoppingStall = Stall;
				if ((object)shoppingStall != null)
				{
					Collider component = shoppingStall.GetComponent<Collider>();
				}
				if (false)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x60018F8")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x60018F9")]
			[Cpp2IlInjected.Address(RVA = "0x11B91C0", Offset = "0x11B7BC0", VA = "0x1811B91C0", Slot = "9")]
			get
			{
				ShoppingStall shoppingStall = Stall;
				if ((object)shoppingStall != null)
				{
					return shoppingStall.GetComponent<Collider>();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x60018FA")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60018FB")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60018FC")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018FD")]
		[Cpp2IlInjected.Address(RVA = "0x11B9020", Offset = "0x11B7A20", VA = "0x1811B9020", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__23))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018FE")]
		[Cpp2IlInjected.Address(RVA = "0x11B9170", Offset = "0x11B7B70", VA = "0x1811B9170")]
		public InteractWithShoppingStall()
		{
		}
	}
}
