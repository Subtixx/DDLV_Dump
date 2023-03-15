using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Items;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005AB")]
	[CreateAssetMenu]
	public class ShowBuildingHint : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022F2")]
		[ItemID]
		public int building;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40022F3")]
		public bool tapAnywhere;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40022F4")]
		public string messageKey = "tutorial_show_garden_hint";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40022F5")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40022F6")]
		public float zoom = -1f;

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public ItemScript Building
		{
			[Cpp2IlInjected.Token(Token = "0x600193D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CBuilding_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600193E")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CBuilding_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x600193F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001940")]
			[Cpp2IlInjected.Address(RVA = "0xD391F0", Offset = "0xD37BF0", VA = "0x180D391F0", Slot = "6")]
			get
			{
				if ((object)this != null)
				{
				}
				float z = Vector3.zero.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6001941")]
			[Cpp2IlInjected.Address(RVA = "0xF4FC40", Offset = "0xF4E640", VA = "0x180F4FC40", Slot = "7")]
			get
			{
				while (true)
				{
					ItemScript itemScript = Building;
					if ((object)itemScript != null)
					{
						Collider component = itemScript.GetComponent<Collider>();
					}
					if (false)
					{
						/*Error: Could not find block for branch target IL_0016*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000386")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x6001942")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x6001943")]
			[Cpp2IlInjected.Address(RVA = "0xF4FBE0", Offset = "0xF4E5E0", VA = "0x180F4FBE0", Slot = "9")]
			get
			{
				ItemScript itemScript = Building;
				if ((object)itemScript != null)
				{
					return itemScript.GetComponent<Collider>();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000388")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x6001944")]
			[Cpp2IlInjected.Address(RVA = "0xF4FC30", Offset = "0xF4E630", VA = "0x180F4FC30", Slot = "10")]
			get
			{
				int num = 0;
				bool flag = (tapAnywhere ? 1 : 0) != num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001945")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6001946")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001947")]
		[Cpp2IlInjected.Address(RVA = "0xF4FA30", Offset = "0xF4E430", VA = "0x180F4FA30", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__25))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001948")]
		[Cpp2IlInjected.Address(RVA = "0xF4FB90", Offset = "0xF4E590", VA = "0x180F4FB90")]
		public ShowBuildingHint()
		{
		}
	}
}
