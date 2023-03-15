using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005B4")]
	[CreateAssetMenu]
	public class TapToMoveTutorial : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400232C")]
		public GameObject vfxPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400232D")]
		public float worldObjectRadius = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400232E")]
		public Vector3 worldObjectOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400232F")]
		public string messageKey = "tutorial_tap_to_move";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002330")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002331")]
		private Vector3 position;

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x6001964")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001965")]
			[Cpp2IlInjected.Address(RVA = "0x106F6B0", Offset = "0x106E0B0", VA = "0x18106F6B0", Slot = "6")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6001966")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0", Slot = "7")]
			get
			{
				return worldObjectRadius;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x6001967")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x6001968")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x6001969")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600196A")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600196B")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "12")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600196C")]
		[Cpp2IlInjected.Address(RVA = "0x106F500", Offset = "0x106DF00", VA = "0x18106F500", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__22))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600196D")]
		[Cpp2IlInjected.Address(RVA = "0x106F660", Offset = "0x106E060", VA = "0x18106F660")]
		public TapToMoveTutorial()
		{
		}
	}
}
