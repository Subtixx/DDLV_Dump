using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class WrappedResponse : IMessage<WrappedResponse>, IMessage, IEquatable<WrappedResponse>, IDeepCloneable<WrappedResponse>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly MessageParser<WrappedResponse> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const int RequestIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int requestId_;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public const int MessageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ByteString message_;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const int ErrorInfoFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ErrorInfo errorInfo_;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const int MetaDataFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly MapField<string, ByteString>.Codec _map_metaData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly MapField<string, ByteString> metaData_;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[DebuggerNonUserCode]
		public static MessageParser<WrappedResponse> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x38EA5E0", Offset = "0x38E8FE0", VA = "0x1838EA5E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x38EA510", Offset = "0x38E8F10", VA = "0x1838EA510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x38EA640", Offset = "0x38E9040", VA = "0x1838EA640", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[DebuggerNonUserCode]
		public int RequestId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return requestId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				requestId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[DebuggerNonUserCode]
		public ByteString Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x38EA750", Offset = "0x38E9150", VA = "0x1838EA750")]
			set
			{
				ByteString byteString = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[DebuggerNonUserCode]
		public ErrorInfo ErrorInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return errorInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				errorInfo_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[DebuggerNonUserCode]
		public MapField<string, ByteString> MetaData
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return metaData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x20C0E60", Offset = "0x20BF860", VA = "0x1820C0E60")]
		public CallResult<TReply> GetResult<TReply>() where TReply : IMessage, new()
		{
			//Discarded unreachable code: IL_0028
			if ((long)errorInfo_ == 0)
			{
				IDictionary<string, ByteString> _003CValues_003Ek__BackingField = new MetadataCollection((IDictionary<, >)(object)metaData_).Values;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38EA280", Offset = "0x38E8C80", VA = "0x1838EA280")]
		[DebuggerNonUserCode]
		public WrappedResponse()
		{
			int num = 0;
			message_ = ByteString.Empty;
			metaData_ = (MapField<string, ByteString>)(object)new MapField<TKey, TValue>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x38EA340", Offset = "0x38E8D40", VA = "0x1838EA340")]
		[DebuggerNonUserCode]
		public WrappedResponse(WrappedResponse other)
		{
			//IL_0097: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			int num = (requestId_ = other.requestId_);
			ByteString byteString = (message_ = other.message_);
			ErrorInfo errorInfo = other.errorInfo_;
			if (errorInfo != null)
			{
				ErrorInfo errorInfo2 = new ErrorInfo
				{
					detail_ = "",
					stackTrace_ = ""
				};
				StatusCode statusCode = (errorInfo2.statusCode_ = errorInfo.statusCode_);
				string text = (errorInfo2.detail_ = errorInfo.detail_);
				string text2 = (errorInfo2.stackTrace_ = errorInfo.stackTrace_);
				Any unknownError_ = errorInfo.unknownError_;
				if (unknownError_ != null)
				{
					Any any = unknownError_.Clone();
				}
				int num2 = 0;
				errorInfo2.unknownError_ = (Any)num2;
				UnknownFieldSet unknownFieldSet = (errorInfo2._unknownFields = UnknownFieldSet.Clone(errorInfo._unknownFields));
			}
			int num3 = 0;
			errorInfo_ = (ErrorInfo)num3;
			MapField<string, ByteString> mapField = (metaData_ = (MapField<string, ByteString>)(object)((MapField<TKey, TValue>)(object)other.metaData_).Clone());
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x38E9640", Offset = "0x38E8040", VA = "0x1838E9640", Slot = "10")]
		[DebuggerNonUserCode]
		public WrappedResponse Clone()
		{
			return new WrappedResponse(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38E97B0", Offset = "0x38E81B0", VA = "0x1838E97B0", Slot = "0")]
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
					if (!flag && object.Equals(errorInfo_, other))
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

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x38E96A0", Offset = "0x38E80A0", VA = "0x1838E96A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WrappedResponse other)
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
						ErrorInfo objB = other.errorInfo_;
						if (object.Equals(errorInfo_, objB))
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

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
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
			ErrorInfo errorInfo = errorInfo_;
			if (errorInfo != null)
			{
				int hashCode2 = errorInfo.GetHashCode();
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)metaData_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38E9F30", Offset = "0x38E8930", VA = "0x1838E9F30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x38E9F90", Offset = "0x38E8990", VA = "0x1838E9F90", Slot = "6")]
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
			if ((long)errorInfo_ != 0)
			{
				ErrorInfo value3 = errorInfo_;
				output.WriteMessage(value3);
			}
			MapField<string, ByteString> mapField = metaData_;
			MapField<string, ByteString>.Codec map_metaData_codec = _map_metaData_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_metaData_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x38E93E0", Offset = "0x38E7DE0", VA = "0x1838E93E0", Slot = "7")]
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
			ErrorInfo errorInfo = errorInfo_;
			if (errorInfo != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(errorInfo);
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

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x38E99F0", Offset = "0x38E83F0", VA = "0x1838E99F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WrappedResponse other)
		{
			//Discarded unreachable code: IL_0151
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
			if (other.errorInfo_ != null)
			{
				ErrorInfo errorInfo2 = default(ErrorInfo);
				ErrorInfo errorInfo3 = default(ErrorInfo);
				if (errorInfo_ == null)
				{
					ErrorInfo errorInfo = (errorInfo_ = new ErrorInfo());
					errorInfo2 = errorInfo_;
					errorInfo3 = other.errorInfo_;
				}
				if (errorInfo3 != null)
				{
					StatusCode statusCode_ = errorInfo3.statusCode_;
					if (statusCode_ != 0)
					{
						errorInfo2.statusCode_ = statusCode_;
					}
					string detail_ = errorInfo3.detail_;
					if (detail_.m_stringLength != 0)
					{
						errorInfo2.Detail = detail_;
					}
					string stackTrace_ = errorInfo3.stackTrace_;
					if (stackTrace_.m_stringLength != 0)
					{
						errorInfo2.StackTrace = stackTrace_;
					}
					if ((long)errorInfo3.unknownError_ != 0)
					{
						Any unknownError_ = default(Any);
						if (errorInfo2.unknownError_ == null)
						{
							Any any = (errorInfo2.unknownError_ = new Any());
							unknownError_ = errorInfo2.unknownError_;
						}
						Any unknownError_2 = errorInfo3.unknownError_;
						unknownError_.MergeFrom(unknownError_2);
					}
					UnknownFieldSet unknownFields = errorInfo3._unknownFields;
					UnknownFieldSet unknownFieldSet = (errorInfo2._unknownFields = UnknownFieldSet.MergeFrom(errorInfo2._unknownFields, unknownFields));
				}
			}
			MapField<string, ByteString> mapField = metaData_;
			MapField<string, ByteString> mapField2 = other.metaData_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x38E9C00", Offset = "0x38E8600", VA = "0x1838E9C00", Slot = "5")]
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
					ErrorInfo errorInfo = errorInfo_;
					if (errorInfo == null)
					{
						ErrorInfo errorInfo2 = (errorInfo_ = new ErrorInfo());
					}
					input.ReadMessage(errorInfo);
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

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x38E9900", Offset = "0x38E8300", VA = "0x1838E9900", Slot = "11")]
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
					ErrorInfo errorInfo = errorInfo_;
				}
				ByteString byteString = message_;
			}
			int num2 = requestId_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x38E9DA0", Offset = "0x38E87A0", VA = "0x1838E9DA0", Slot = "12")]
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
							errorInfo_ = (ErrorInfo)num2;
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

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x38E9550", Offset = "0x38E7F50", VA = "0x1838E9550", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x38EA0E0", Offset = "0x38E8AE0", VA = "0x1838EA0E0")]
		static WrappedResponse()
		{
			Func<WrappedResponse> func = default(Func<WrappedResponse>);
			_parser = (MessageParser<WrappedResponse>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<ByteString> fieldCodec2 = (FieldCodec<ByteString>)(object)FieldCodec.ForBytes(18u);
			uint num = default(uint);
			_parser = (MessageParser<WrappedResponse>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
