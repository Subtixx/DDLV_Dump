using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005B0")]
	[CreateAssetMenu]
	public class ShowMenuHint : FtueStep, IMenuHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002311")]
		public string elementName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002312")]
		public string elementContainerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002313")]
		public string menuName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002314")]
		public MenuHintScope searchScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002315")]
		public float searchTimeout = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002316")]
		public MenuHintCompletion completion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002317")]
		public string messageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002318")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4002319")]
		public bool skipIfInactive;

		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x6001953")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6001954")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
			get
			{
				return elementName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		public string ElementContainerName
		{
			[Cpp2IlInjected.Token(Token = "0x6001955")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "8")]
			get
			{
				return elementContainerName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		public string MenuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001956")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "6")]
			get
			{
				return menuName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		public MenuHintScope SearchScope
		{
			[Cpp2IlInjected.Token(Token = "0x6001957")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "9")]
			get
			{
				return searchScope;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		public float SearchTimeout
		{
			[Cpp2IlInjected.Token(Token = "0x6001958")]
			[Cpp2IlInjected.Address(RVA = "0xF50B10", Offset = "0xF4F510", VA = "0x180F50B10", Slot = "10")]
			get
			{
				return searchTimeout;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000391")]
		public MenuHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x6001959")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "11")]
			get
			{
				return completion;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600195A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "12")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		public bool SkipIfInactive
		{
			[Cpp2IlInjected.Token(Token = "0x600195B")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0", Slot = "13")]
			get
			{
				return skipIfInactive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600195C")]
		[Cpp2IlInjected.Address(RVA = "0xF509A0", Offset = "0xF4F3A0", VA = "0x180F509A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__27))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600195D")]
		[Cpp2IlInjected.Address(RVA = "0xF50B00", Offset = "0xF4F500", VA = "0x180F50B00")]
		public ShowMenuHint()
		{
		}
	}
}
