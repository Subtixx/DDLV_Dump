using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class Protocol
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x38E0180", Offset = "0x38DEB80", VA = "0x1838E0180")]
		public static void WriteMessage(Stream stream, IMessage message)
		{
			message.WriteTo(stream);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x38DFDE0", Offset = "0x38DE7E0", VA = "0x1838DFDE0")]
		public static WrappedRequest WrapRequest(int requestId, IMessage message, MethodDescriptor method, CallOptions callOptions)
		{
			//Discarded unreachable code: IL_00a3
			WrappedRequest wrappedRequest = new WrappedRequest();
			wrappedRequest.requestId_ = requestId;
			ByteString byteString = (wrappedRequest.message_ = ProtoPreconditions.CheckNotNull(message.ToByteString(), "value"));
			RpcId rpcId = new RpcId();
			rpcId.serviceName_ = "";
			rpcId.methodName_ = "";
			string text = (rpcId.serviceName_ = ProtoPreconditions.CheckNotNull(method.Service.Name, "value"));
			string text2 = (rpcId.methodName_ = ProtoPreconditions.CheckNotNull(method.Name, "value"));
			wrappedRequest.rpcId_ = rpcId;
			MetadataCollection _003CMetadata_003Ek__BackingField = callOptions.Metadata;
			MapField<string, ByteString> metaData_ = wrappedRequest.metaData_;
			IDictionary<string, ByteString> _003CValues_003Ek__BackingField = _003CMetadata_003Ek__BackingField.Values;
			((MapField<TKey, TValue>)(object)metaData_).Add((IDictionary<, >)_003CValues_003Ek__BackingField);
			return wrappedRequest;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x38E0060", Offset = "0x38DEA60", VA = "0x1838E0060")]
		public static WrappedResponse WrapResponse(int requestId, CallResult<IMessage> result)
		{
			//Discarded unreachable code: IL_004b
			WrappedResponse wrappedResponse = new WrappedResponse();
			wrappedResponse.requestId_ = requestId;
			_00210 _003CMessage_003Ek__BackingField = (_00210)((CallResult<>)(object)result).Message;
			ByteString value = default(ByteString);
			ByteString byteString = (wrappedResponse.message_ = ProtoPreconditions.CheckNotNull(value, "value"));
			MetadataCollection _003CMetadata_003Ek__BackingField = ((CallResult<>)(object)result).Metadata;
			MapField<string, ByteString> metaData_ = wrappedResponse.metaData_;
			IDictionary<string, ByteString> _003CValues_003Ek__BackingField = _003CMetadata_003Ek__BackingField.Values;
			((MapField<TKey, TValue>)(object)metaData_).Add((IDictionary<, >)_003CValues_003Ek__BackingField);
			return wrappedResponse;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x38DFA60", Offset = "0x38DE460", VA = "0x1838DFA60")]
		public static WrappedResponse WrapException(int requestId, StatusCode statusCode, Exception exception)
		{
			//Discarded unreachable code: IL_00e6
			WrappedResponse wrappedResponse = new WrappedResponse();
			wrappedResponse.requestId_ = requestId;
			ErrorInfo errorInfo = new ErrorInfo();
			errorInfo.detail_ = "";
			errorInfo.stackTrace_ = "";
			errorInfo.statusCode_ = statusCode;
			string text = (errorInfo.detail_ = ProtoPreconditions.CheckNotNull(exception.Message, "value"));
			string text2 = (errorInfo.stackTrace_ = ProtoPreconditions.CheckNotNull(exception.StackTrace, "value"));
			wrappedResponse.errorInfo_ = errorInfo;
			UnknownException ex = new UnknownException();
			ex.clrType_ = "";
			ex.message_ = "";
			string text3 = (ex.clrType_ = ProtoPreconditions.CheckNotNull(exception.GetType().AssemblyQualifiedName, "value"));
			string text4 = (ex.message_ = ProtoPreconditions.CheckNotNull(exception.Message, "value"));
			ErrorInfo errorInfo_ = wrappedResponse.errorInfo_;
			Any any = (errorInfo_.unknownError_ = Any.Pack(ex, ""));
			return wrappedResponse;
		}
	}
}
