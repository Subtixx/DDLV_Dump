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
	[Cpp2IlInjected.Token(Token = "0x200058C")]
	[CreateAssetMenu]
	public class InteractWithCookingStall : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002235")]
		public CookingStallState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002236")]
		public string messageKey = "tutorial_tap_on_cauldron";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002237")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002238")]
		public float zoom = -1f;

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		public CookingStall Stall
		{
			[Cpp2IlInjected.Token(Token = "0x60018C3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60018C4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x60018C5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60018C6")]
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

		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60018C7")]
			[Cpp2IlInjected.Address(RVA = "0x11B8680", Offset = "0x11B7080", VA = "0x1811B8680", Slot = "7")]
			get
			{
				CookingStall cookingStall = Stall;
				if ((object)cookingStall != null)
				{
					Collider component = cookingStall.GetComponent<Collider>();
				}
				if (false)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x60018C8")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000359")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x60018C9")]
			[Cpp2IlInjected.Address(RVA = "0x11B8630", Offset = "0x11B7030", VA = "0x1811B8630", Slot = "9")]
			get
			{
				CookingStall cookingStall = Stall;
				if ((object)cookingStall != null)
				{
					return cookingStall.GetComponent<Collider>();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x60018CA")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60018CB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60018CC")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018CD")]
		[Cpp2IlInjected.Address(RVA = "0x11B8470", Offset = "0x11B6E70", VA = "0x1811B8470", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__24))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018CE")]
		[Cpp2IlInjected.Address(RVA = "0x11B85E0", Offset = "0x11B6FE0", VA = "0x1811B85E0")]
		public InteractWithCookingStall()
		{
		}
	}
}
