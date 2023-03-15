using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FB5")]
	public class InterceptorUtils
	{
		[Cpp2IlInjected.Token(Token = "0x40040C5")]
		public const string AvatarPositionKey = "avatarpos";

		[Cpp2IlInjected.Token(Token = "0x40040C6")]
		public const string TransactionTimeKey = "TransactionTime";

		[Cpp2IlInjected.Token(Token = "0x6007F3F")]
		[Cpp2IlInjected.Address(RVA = "0x19AD230", Offset = "0x19ABC30", VA = "0x1819AD230")]
		public static CallResult<TReply> CreateErrorResult<TReply>() where TReply : IMessage, new()
		{
			if ("Result" == null)
			{
				FieldDescriptor fieldDescriptor = default(FieldDescriptor);
				if (fieldDescriptor == null)
				{
				}
				if (fieldDescriptor != null && fieldDescriptor.IsIntegerLike())
				{
					IFieldAccessor accessor = fieldDescriptor.accessor;
				}
			}
			IDictionary<string, ByteString> _003CValues_003Ek__BackingField = new MetadataCollection().Values;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F40")]
		[Cpp2IlInjected.Address(RVA = "0x19AD430", Offset = "0x19ABE30", VA = "0x1819AD430")]
		public static CallResult<TReply> CreateOnlineErrorResult<TReply>() where TReply : IMessage, new()
		{
			if ("playfabresult" == null)
			{
				FieldDescriptor fieldDescriptor = default(FieldDescriptor);
				if (fieldDescriptor == null)
				{
				}
				if (fieldDescriptor != null && fieldDescriptor.IsIntegerLike())
				{
					IFieldAccessor accessor = fieldDescriptor.accessor;
				}
			}
			IDictionary<string, ByteString> _003CValues_003Ek__BackingField = new MetadataCollection().Values;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F41")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InterceptorUtils()
		{
		}
	}
}
