using System;
using Cpp2IlInjected;
using Gameloft.Tracking;
using Google.Protobuf;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class CallResult<TMessage> where TMessage : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000006")]
		public TMessage Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000007")]
		public MetadataCollection Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x22BE370", Offset = "0x22BCD70", VA = "0x1822BE370")]
		public CallResult(TMessage message, MetadataCollection metadata)
		{
			((CallResult<>)(object)this).Message = message;
			((CallResult<>)(object)this).Metadata = metadata;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x22BE3D0", Offset = "0x22BCDD0", VA = "0x1822BE3D0")]
		public static implicit operator CallResult<IMessage>(CallResult<TMessage> result)
		{
			Session sessionInfo = ((ITracker)(object)result).SessionInfo;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x22BE0F0", Offset = "0x22BCAF0", VA = "0x1822BE0F0")]
		public CallResult<IMessage> ToCallResult()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
