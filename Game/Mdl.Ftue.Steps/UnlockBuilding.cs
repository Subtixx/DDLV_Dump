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
	[Cpp2IlInjected.Token(Token = "0x20005B6")]
	[CreateAssetMenu]
	public class UnlockBuilding : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400233B")]
		[ItemID]
		public int building;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400233C")]
		public string messageKey = "tutorial_unlock_walle_stall";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400233D")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400233E")]
		public float zoom = -1f;

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public ItemScript Building
		{
			[Cpp2IlInjected.Token(Token = "0x6001970")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CBuilding_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001971")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CBuilding_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x6001972")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001973")]
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

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6001974")]
			[Cpp2IlInjected.Address(RVA = "0xD39250", Offset = "0xD37C50", VA = "0x180D39250", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x6001975")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x6001976")]
			[Cpp2IlInjected.Address(RVA = "0xD391A0", Offset = "0xD37BA0", VA = "0x180D391A0", Slot = "9")]
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

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x6001977")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001978")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6001979")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600197A")]
		[Cpp2IlInjected.Address(RVA = "0xD38930", Offset = "0xD37330", VA = "0x180D38930", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__24))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600197B")]
		[Cpp2IlInjected.Address(RVA = "0xD39150", Offset = "0xD37B50", VA = "0x180D39150")]
		public UnlockBuilding()
		{
		}
	}
}
