using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010EF")]
	public sealed class Vector3 : IVector3, IEquatable<IVector3>, IMessage<Vector3>, IMessage, IEquatable<Vector3>, IDeepCloneable<Vector3>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045D9")]
		private static readonly MessageParser<Vector3> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045DA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045DB")]
		public const int XFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045DC")]
		private float x_;

		[Cpp2IlInjected.Token(Token = "0x40045DD")]
		public const int YFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40045DE")]
		private float y_;

		[Cpp2IlInjected.Token(Token = "0x40045DF")]
		public const int ZFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40045E0")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x1700180D")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60089D6")]
			[Cpp2IlInjected.Address(RVA = "0x15E0580", Offset = "0x15DEF80", VA = "0x1815E0580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700180E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60089D7")]
			[Cpp2IlInjected.Address(RVA = "0x15E04B0", Offset = "0x15DEEB0", VA = "0x1815E04B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700180F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60089D8")]
			[Cpp2IlInjected.Address(RVA = "0x15E05E0", Offset = "0x15DEFE0", VA = "0x1815E05E0", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001810")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60089DC")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330", Slot = "4")]
			get
			{
				return x_;
			}
			[Cpp2IlInjected.Token(Token = "0x60089DD")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				x_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001811")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60089DE")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320", Slot = "5")]
			get
			{
				return y_;
			}
			[Cpp2IlInjected.Token(Token = "0x60089DF")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				y_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001812")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60089E0")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0", Slot = "6")]
			get
			{
				return z_;
			}
			[Cpp2IlInjected.Token(Token = "0x60089E1")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				z_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089D5")]
		[Cpp2IlInjected.Address(RVA = "0x15DF8C0", Offset = "0x15DE2C0", VA = "0x1815DF8C0", Slot = "7")]
		public bool Equals(IVector3 other)
		{
			if (other == null && other == null && other == null)
			{
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089D9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Vector3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60089DA")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public Vector3(Vector3 other)
		{
			float num = (x_ = other.x_);
			float num2 = (y_ = other.y_);
			float num3 = (z_ = other.z_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089DB")]
		[Cpp2IlInjected.Address(RVA = "0x15DF830", Offset = "0x15DE230", VA = "0x1815DF830", Slot = "14")]
		[DebuggerNonUserCode]
		public Vector3 Clone()
		{
			//Discarded unreachable code: IL_0047
			Vector3 vector = new Vector3();
			float num = (vector.x_ = x_);
			float num2 = (vector.y_ = y_);
			float num3 = (vector.z_ = z_);
			UnknownFieldSet unknownFieldSet = (vector._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return vector;
		}

		[Cpp2IlInjected.Token(Token = "0x60089E2")]
		[Cpp2IlInjected.Address(RVA = "0x15DFAF0", Offset = "0x15DE4F0", VA = "0x1815DFAF0", Slot = "0")]
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
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089E3")]
		[Cpp2IlInjected.Address(RVA = "0x15DF980", Offset = "0x15DE380", VA = "0x1815DF980", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3 other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089E4")]
		[Cpp2IlInjected.Address(RVA = "0x15DFD70", Offset = "0x15DE770", VA = "0x1815DFD70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0032
			while (ProtobufEqualityComparers.BitwiseSingleEqualityComparer == null)
			{
			}
			if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60089E5")]
		[Cpp2IlInjected.Address(RVA = "0x15E0210", Offset = "0x15DEC10", VA = "0x1815E0210", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60089E6")]
		[Cpp2IlInjected.Address(RVA = "0x15E0270", Offset = "0x15DEC70", VA = "0x1815E0270", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			float value = x_;
			output.WriteFloat(value);
			if (output != null)
			{
				float value2 = y_;
				output.WriteFloat(value2);
			}
			if (output != null)
			{
				float value3 = z_;
				output.WriteFloat(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60089E7")]
		[Cpp2IlInjected.Address(RVA = "0x15DF7A0", Offset = "0x15DE1A0", VA = "0x1815DF7A0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			uint num = default(uint);
			UnknownFieldSet unknownFields;
			do
			{
				num += 5;
				num += 5;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num2 = unknownFields.CalculateSize();
			return num2 + (int)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60089E8")]
		[Cpp2IlInjected.Address(RVA = "0x15DFFD0", Offset = "0x15DE9D0", VA = "0x1815DFFD0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(Vector3 other)
		{
			if (other != null)
			{
				float num = other.x_;
				if (other != null)
				{
					x_ = num;
				}
				float num2 = other.y_;
				if (other != null)
				{
					y_ = num2;
				}
				float num3 = other.z_;
				if (other != null)
				{
					z_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089E9")]
		[Cpp2IlInjected.Address(RVA = "0x15E0050", Offset = "0x15DEA50", VA = "0x1815E0050", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005f
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 13)
				{
					float num2 = (x_ = input.ReadFloat());
				}
				if (num == 21)
				{
					float num3 = (y_ = input.ReadFloat());
				}
				if (num == 29)
				{
					float num4 = (z_ = input.ReadFloat());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089EA")]
		[Cpp2IlInjected.Address(RVA = "0x15DFCA0", Offset = "0x15DE6A0", VA = "0x1815DFCA0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				float num2 = x_;
				return typeof(float).TypeHandle;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60089EB")]
		[Cpp2IlInjected.Address(RVA = "0x15E0100", Offset = "0x15DEB00", VA = "0x1815E0100", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected F4, but got O
			//IL_001f: Expected F4, but got O
			//IL_0027: Expected F4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					z_ = (float)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					y_ = (float)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				x_ = (float)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089EC")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_001c
			if (fieldNumber == 1)
			{
				z_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089ED")]
		[Cpp2IlInjected.Address(RVA = "0x15E0340", Offset = "0x15DED40", VA = "0x1815E0340")]
		static Vector3()
		{
			Func<Vector3> func = default(Func<Vector3>);
			_parser = (MessageParser<Vector3>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
