using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000517")]
	public sealed class SceneToVisit : IMessage<SceneToVisit>, IMessage, IEquatable<SceneToVisit>, IDeepCloneable<SceneToVisit>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001B31")]
		private static readonly MessageParser<SceneToVisit> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B32")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B33")]
		public const int SceneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B34")]
		private int scene_;

		[Cpp2IlInjected.Token(Token = "0x17001037")]
		[DebuggerNonUserCode]
		public static MessageParser<SceneToVisit> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003F1C")]
			[Cpp2IlInjected.Address(RVA = "0x383DC00", Offset = "0x383C600", VA = "0x18383DC00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001038")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F1D")]
			[Cpp2IlInjected.Address(RVA = "0x383DB30", Offset = "0x383C530", VA = "0x18383DB30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001039")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F1E")]
			[Cpp2IlInjected.Address(RVA = "0x383DC60", Offset = "0x383C660", VA = "0x18383DC60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103A")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x6003F22")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F23")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				scene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F1F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SceneToVisit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003F20")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public SceneToVisit(SceneToVisit other)
		{
			int num = (scene_ = other.scene_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F21")]
		[Cpp2IlInjected.Address(RVA = "0x383D780", Offset = "0x383C180", VA = "0x18383D780", Slot = "10")]
		[DebuggerNonUserCode]
		public SceneToVisit Clone()
		{
			//Discarded unreachable code: IL_0029
			SceneToVisit sceneToVisit = new SceneToVisit();
			int num = (sceneToVisit.scene_ = scene_);
			UnknownFieldSet unknownFieldSet = (sceneToVisit._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return sceneToVisit;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F24")]
		[Cpp2IlInjected.Address(RVA = "0x383D800", Offset = "0x383C200", VA = "0x18383D800", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)scene_ == (IntPtr)typeof(SceneToVisit).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F25")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SceneToVisit other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.scene_;
				if (scene_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F26")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (scene_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F27")]
		[Cpp2IlInjected.Address(RVA = "0x383D9C0", Offset = "0x383C3C0", VA = "0x18383D9C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F28")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (scene_ != 0)
			{
				int value = scene_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F29")]
		[Cpp2IlInjected.Address(RVA = "0x383D6E0", Offset = "0x383C0E0", VA = "0x18383D6E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = scene_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2A")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SceneToVisit other)
		{
			if (other != null)
			{
				int num = other.scene_;
				if (num != 0)
				{
					scene_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2B")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (scene_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2C")]
		[Cpp2IlInjected.Address(RVA = "0x383D890", Offset = "0x383C290", VA = "0x18383D890", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = scene_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2D")]
		[Cpp2IlInjected.Address(RVA = "0x383D940", Offset = "0x383C340", VA = "0x18383D940", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				scene_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2E")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				scene_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F2F")]
		[Cpp2IlInjected.Address(RVA = "0x383DA20", Offset = "0x383C420", VA = "0x18383DA20")]
		static SceneToVisit()
		{
			Func<SceneToVisit> func = default(Func<SceneToVisit>);
			_parser = (MessageParser<SceneToVisit>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
