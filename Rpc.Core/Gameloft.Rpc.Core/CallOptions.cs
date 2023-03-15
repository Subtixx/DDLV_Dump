using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CallOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000005")]
		public MetadataCollection Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38DA120", Offset = "0x38D8B20", VA = "0x1838DA120")]
		public CallOptions([Optional] MetadataCollection metadata)
		{
			if (metadata == null)
			{
				MetadataCollection metadataCollection = new MetadataCollection();
				Dictionary<string, ByteString> dictionary = (Dictionary<string, ByteString>)(metadataCollection.Values = (IDictionary<string, ByteString>)new Dictionary<TKey, TValue>());
			}
			Metadata = metadata;
			throw new NullReferenceException();
		}
	}
}
