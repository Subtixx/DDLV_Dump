using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class WrappedRequest : IMessage<WrappedRequest>, IMessage, IEquatable<WrappedRequest>, IDeepCloneable<WrappedRequest>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly MessageParser<WrappedRequest> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public const int RequestIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int requestId_;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public const int MessageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private ByteString message_;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public const int RpcIdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private RpcId rpcId_;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public const int MetaDataFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly MapField<string, ByteString>.Codec _map_metaData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MapField<string, ByteString> metaData_;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[DebuggerNonUserCode]
		public static MessageParser<WrappedRequest> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x38E9200", Offset = "0x38E7C00", VA = "0x1838E9200")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x38E9130", Offset = "0x38E7B30", VA = "0x1838E9130")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x38E9260", Offset = "0x38E7C60", VA = "0x1838E9260", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[DebuggerNonUserCode]
		public int RequestId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return requestId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				requestId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		[DebuggerNonUserCode]
		public ByteString Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x38E9370", Offset = "0x38E7D70", VA = "0x1838E9370")]
			set
			{
				ByteString byteString = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		[DebuggerNonUserCode]
		public RpcId RpcId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rpcId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				rpcId_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		[DebuggerNonUserCode]
		public MapField<string, ByteString> MetaData
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return metaData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38E8ED0", Offset = "0x38E78D0", VA = "0x1838E8ED0")]
		[DebuggerNonUserCode]
		public WrappedRequest()
		{
			int num = 0;
			message_ = ByteString.Empty;
			metaData_ = (MapField<string, ByteString>)(object)new MapField<TKey, TValue>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38E8F90", Offset = "0x38E7990", VA = "0x1838E8F90")]
		[DebuggerNonUserCode]
		public WrappedRequest(WrappedRequest other)
		{
			//IL_0083: Expected O, but got I4
			int num = (requestId_ = other.requestId_);
			ByteString byteString = (message_ = other.message_);
			RpcId rpcId = other.rpcId_;
			if (rpcId != null)
			{
				RpcId rpcId2 = new RpcId
				{
					serviceName_ = "",
					methodName_ = ""
				};
				string text = (rpcId2.serviceName_ = rpcId.serviceName_);
				string text2 = (rpcId2.methodName_ = rpcId.methodName_);
				UnknownFieldSet unknownFieldSet = (rpcId2._unknownFields = UnknownFieldSet.Clone(rpcId._unknownFields));
			}
			int num2 = 0;
			rpcId_ = (RpcId)num2;
			MapField<string, ByteString> mapField = (metaData_ = (MapField<string, ByteString>)(object)((MapField<TKey, TValue>)(object)other.metaData_).Clone());
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38E8240", Offset = "0x38E6C40", VA = "0x1838E8240", Slot = "10")]
		[DebuggerNonUserCode]
		public WrappedRequest Clone()
		{
			return new WrappedRequest(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38E83B0", Offset = "0x38E6DB0", VA = "0x1838E83B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)requestId_ == (IntPtr)typeof(ByteString).TypeHandle)
				{
					ByteString byteString = message_;
					bool flag = default(bool);
					if (!flag && object.Equals(rpcId_, other))
					{
						MapField<string, ByteString> mapField = metaData_;
						bool flag2 = default(bool);
						if (flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x38E82A0", Offset = "0x38E6CA0", VA = "0x1838E82A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WrappedRequest other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.requestId_;
				if (requestId_ == num)
				{
					ByteString byteString = message_;
					ByteString byteString2 = other.message_;
					if (!(byteString != byteString2))
					{
						RpcId objB = other.rpcId_;
						if (object.Equals(rpcId_, objB))
						{
							MapField<string, ByteString> mapField = metaData_;
							MapField<string, ByteString> mapField2 = other.metaData_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x38E85F0", Offset = "0x38E6FF0", VA = "0x1838E85F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005a
			if (requestId_ != 0)
			{
			}
			if (message_.Length != 0)
			{
				int hashCode = message_.GetHashCode();
			}
			RpcId rpcId = rpcId_;
			if (rpcId != null)
			{
				int hashCode2 = rpcId.GetHashCode();
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)metaData_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x38E8B80", Offset = "0x38E7580", VA = "0x1838E8B80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x38E8BE0", Offset = "0x38E75E0", VA = "0x1838E8BE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0079
			if (requestId_ != 0)
			{
				int value = requestId_;
				output.WriteInt32(value);
			}
			if (message_.Length != 0)
			{
				ByteString value2 = message_;
				output.WriteBytes(value2);
			}
			if ((long)rpcId_ != 0)
			{
				RpcId value3 = rpcId_;
				output.WriteMessage(value3);
			}
			MapField<string, ByteString> mapField = metaData_;
			MapField<string, ByteString>.Codec map_metaData_codec = _map_metaData_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_metaData_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x38E7FE0", Offset = "0x38E69E0", VA = "0x1838E7FE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0093
			int num = requestId_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (message_.Length != 0)
			{
				int num4 = CodedOutputStream.ComputeBytesSize(message_);
				num4++;
				num2 += num4;
			}
			RpcId rpcId = rpcId_;
			if (rpcId != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(rpcId);
				num5++;
				num2 += num5;
			}
			MapField<string, ByteString> mapField = metaData_;
			MapField<string, ByteString>.Codec map_metaData_codec = _map_metaData_codec;
			int num6 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_metaData_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x38E8860", Offset = "0x38E7260", VA = "0x1838E8860", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WrappedRequest other)
		{
			//Discarded unreachable code: IL_00fa
			if (other == null)
			{
				return;
			}
			int num = other.requestId_;
			if (num != 0)
			{
				requestId_ = num;
			}
			if (other.message_.Length != 0)
			{
				ByteString byteString2 = (Message = other.message_);
			}
			if (other.rpcId_ != null)
			{
				RpcId rpcId2 = default(RpcId);
				RpcId rpcId3 = default(RpcId);
				if (rpcId_ == null)
				{
					RpcId rpcId = (rpcId_ = new RpcId());
					rpcId2 = rpcId_;
					rpcId3 = other.rpcId_;
				}
				if (rpcId3 != null)
				{
					string serviceName_ = rpcId3.serviceName_;
					if (serviceName_.m_stringLength != 0)
					{
						rpcId2.ServiceName = serviceName_;
					}
					string methodName_ = rpcId3.methodName_;
					if (methodName_.m_stringLength != 0)
					{
						rpcId2.MethodName = methodName_;
					}
					UnknownFieldSet unknownFields = rpcId3._unknownFields;
					UnknownFieldSet unknownFieldSet = (rpcId2._unknownFields = UnknownFieldSet.MergeFrom(rpcId2._unknownFields, unknownFields));
				}
			}
			MapField<string, ByteString> mapField = metaData_;
			MapField<string, ByteString> mapField2 = other.metaData_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38E86C0", Offset = "0x38E70C0", VA = "0x1838E86C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0099
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					RpcId rpcId = rpcId_;
					if (rpcId == null)
					{
						RpcId rpcId2 = (rpcId_ = new RpcId());
					}
					input.ReadMessage(rpcId);
				}
				if (num != 34)
				{
					goto IL_0082;
				}
				MapField<string, ByteString> mapField = metaData_;
				MapField<string, ByteString>.Codec map_metaData_codec = _map_metaData_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_metaData_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (requestId_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				ByteString byteString2 = (Message = input.ReadBytes());
			}
			goto IL_0082;
			IL_0082:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x38E8500", Offset = "0x38E6F00", VA = "0x1838E8500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						MapField<string, ByteString> mapField = metaData_;
					}
					RpcId rpcId = rpcId_;
				}
				ByteString byteString = message_;
			}
			int num2 = requestId_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x38E89F0", Offset = "0x38E73F0", VA = "0x1838E89F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0037
			//IL_0025: Expected O, but got I4
			//IL_0036: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num != 1)
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							rpcId_ = (RpcId)num2;
							return;
						}
					}
					else
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					throw new InvalidCastException();
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj = default(object);
				requestId_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x38E8150", Offset = "0x38E6B50", VA = "0x1838E8150", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0035
			//IL_0034: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						MapField<string, ByteString> mapField = metaData_;
						break;
					}
					case 0:
						break;
					default:
						return;
					}
				}
				int num2 = 0;
				ByteString byteString = (Message = ByteString.Empty);
			}
			else
			{
				requestId_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x38E8D30", Offset = "0x38E7730", VA = "0x1838E8D30")]
		static WrappedRequest()
		{
			Func<WrappedRequest> func = default(Func<WrappedRequest>);
			_parser = (MessageParser<WrappedRequest>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<ByteString> fieldCodec2 = (FieldCodec<ByteString>)(object)FieldCodec.ForBytes(18u);
			uint num = default(uint);
			_parser = (MessageParser<WrappedRequest>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
