using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200047A")]
	public sealed class TargetRealm : IMessage<TargetRealm>, IMessage, IEquatable<TargetRealm>, IDeepCloneable<TargetRealm>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200047B")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400181C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400181D")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x400181E")]
			RealmID
		}

		[Cpp2IlInjected.Token(Token = "0x4001815")]
		private static readonly MessageParser<TargetRealm> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001816")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001817")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001818")]
		public const int RealmIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001819")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400181A")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DF7")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetRealm> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60036DA")]
			[Cpp2IlInjected.Address(RVA = "0x3547340", Offset = "0x3545D40", VA = "0x183547340")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036DB")]
			[Cpp2IlInjected.Address(RVA = "0x3547270", Offset = "0x3545C70", VA = "0x183547270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036DC")]
			[Cpp2IlInjected.Address(RVA = "0x35474C0", Offset = "0x3545EC0", VA = "0x1835474C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFA")]
		[DebuggerNonUserCode]
		public TargetAny Any
		{
			[Cpp2IlInjected.Token(Token = "0x60036E0")]
			[Cpp2IlInjected.Address(RVA = "0x3547210", Offset = "0x3545C10", VA = "0x183547210")]
			get
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60036E1")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				target_ = value;
				bool flag = (byte)(targetCase_ = ((value != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFB")]
		[DebuggerNonUserCode]
		public int RealmID
		{
			[Cpp2IlInjected.Token(Token = "0x60036E2")]
			[Cpp2IlInjected.Address(RVA = "0x35473A0", Offset = "0x3545DA0", VA = "0x1835473A0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.RealmID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60036E3")]
			[Cpp2IlInjected.Address(RVA = "0x35475D0", Offset = "0x3545FD0", VA = "0x1835475D0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.RealmID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFC")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x60036E4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DFD")]
		public Item RealmItem
		{
			[Cpp2IlInjected.Token(Token = "0x60036F3")]
			[Cpp2IlInjected.Address(RVA = "0x3547410", Offset = "0x3545E10", VA = "0x183547410")]
			get
			{
				if (targetCase_ == TargetOneofCase.RealmID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036DD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TargetRealm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60036DE")]
		[Cpp2IlInjected.Address(RVA = "0x3547110", Offset = "0x3545B10", VA = "0x183547110")]
		[DebuggerNonUserCode]
		public TargetRealm(TargetRealm other)
		{
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = other.targetCase_;
				if (other.target_ == null)
				{
					throw new InvalidCastException();
				}
				TargetAny targetAny = default(TargetAny);
				target_ = targetAny;
				bool flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (targetOneofCase == TargetOneofCase.RealmID)
			{
				int num = (RealmID = other.RealmID);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036DF")]
		[Cpp2IlInjected.Address(RVA = "0x35463D0", Offset = "0x3544DD0", VA = "0x1835463D0", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetRealm Clone()
		{
			//Discarded unreachable code: IL_0064
			TargetRealm targetRealm = new TargetRealm();
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				if (target_ == null)
				{
					throw new InvalidCastException();
				}
				TargetAny targetAny = default(TargetAny);
				targetRealm.target_ = targetAny;
				bool flag = (byte)(targetRealm.targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (targetOneofCase == TargetOneofCase.RealmID)
			{
				int num = (targetRealm.RealmID = RealmID);
			}
			UnknownFieldSet unknownFieldSet = (targetRealm._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return targetRealm;
		}

		[Cpp2IlInjected.Token(Token = "0x60036E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036E6")]
		[Cpp2IlInjected.Address(RVA = "0x3546630", Offset = "0x3545030", VA = "0x183546630", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0069: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (targetCase_ == TargetOneofCase.Any)
					{
						object obj = target_;
						if (obj != null && obj == null)
						{
							goto IL_006e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(TargetAny).TypeHandle != null && (object)typeof(TargetAny).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						int realmID = RealmID;
						int num2 = 0;
						int num3 = default(int);
						if (realmID == num3 && targetCase_ == (TargetOneofCase)num3)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			goto IL_006e;
			IL_006e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036E7")]
		[Cpp2IlInjected.Address(RVA = "0x3546510", Offset = "0x3544F10", VA = "0x183546510", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetRealm other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						goto IL_0090;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					obj2 = other.target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int realmID = RealmID;
					int realmID2 = other.RealmID;
					if (realmID == realmID2)
					{
						TargetOneofCase targetOneofCase = other.targetCase_;
						if (targetCase_ == targetOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0090;
			IL_0090:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036E8")]
		[Cpp2IlInjected.Address(RVA = "0x35468A0", Offset = "0x35452A0", VA = "0x1835468A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004c
			TargetOneofCase targetOneofCase = targetCase_;
			int num = 0;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (targetOneofCase == TargetOneofCase.RealmID && targetCase_ == TargetOneofCase.RealmID)
			{
				object obj2 = target_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60036E9")]
		[Cpp2IlInjected.Address(RVA = "0x3546EC0", Offset = "0x35458C0", VA = "0x183546EC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036EA")]
		[Cpp2IlInjected.Address(RVA = "0x3546F20", Offset = "0x3545920", VA = "0x183546F20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			//IL_002c: Expected O, but got I4
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (targetOneofCase == TargetOneofCase.RealmID)
			{
				int realmID = RealmID;
				output.WriteInt32(realmID);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60036EB")]
		[Cpp2IlInjected.Address(RVA = "0x3546170", Offset = "0x3544B70", VA = "0x183546170", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (targetCase_ == TargetOneofCase.Any)
			{
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (targetCase_ == TargetOneofCase.RealmID)
			{
				if (targetCase_ == TargetOneofCase.RealmID)
				{
					object obj2 = target_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EC")]
		[Cpp2IlInjected.Address(RVA = "0x3546BF0", Offset = "0x35455F0", VA = "0x183546BF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetRealm other)
		{
			if (other == null)
			{
				return;
			}
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				int num = 0;
				if (targetOneofCase2 == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(targetCase_ = (((target_ = new TargetAny()) != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
				}
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj2 = target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					object obj3 = other.target_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if (targetOneofCase == TargetOneofCase.RealmID)
			{
				int num2 = (RealmID = other.RealmID);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60036ED")]
		[Cpp2IlInjected.Address(RVA = "0x3546A80", Offset = "0x3545480", VA = "0x183546A80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				TargetAny targetAny = new TargetAny();
				if (targetCase_ == TargetOneofCase.Any)
				{
					if (targetCase_ != TargetOneofCase.Any)
					{
					}
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(targetAny);
				target_ = targetAny;
				bool flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num3 = (RealmID = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60036EE")]
		[Cpp2IlInjected.Address(RVA = "0x3546790", Offset = "0x3545190", VA = "0x183546790", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (targetCase_ == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 2)
			{
				int realmID = RealmID;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EF")]
		[Cpp2IlInjected.Address(RVA = "0x3546DD0", Offset = "0x35457D0", VA = "0x183546DD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				target_ = num;
				bool flag = (byte)(targetCase_ = ((num != 0) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036F0")]
		[Cpp2IlInjected.Address(RVA = "0x35462D0", Offset = "0x3544CD0", VA = "0x1835462D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				targetCase_ = TargetOneofCase.None;
				break;
			case 2:
			{
				int num = default(int);
				target_ = num;
				targetCase_ = TargetOneofCase.RealmID;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036F1")]
		[Cpp2IlInjected.Address(RVA = "0x35469D0", Offset = "0x35453D0", VA = "0x1835469D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				TargetOneofCase targetOneofCase = targetCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F2")]
		[Cpp2IlInjected.Address(RVA = "0x3546360", Offset = "0x3544D60", VA = "0x183546360", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				target_ = (targetCase_ = TargetOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036F4")]
		[Cpp2IlInjected.Address(RVA = "0x3547000", Offset = "0x3545A00", VA = "0x183547000")]
		static TargetRealm()
		{
			Func<TargetRealm> func = default(Func<TargetRealm>);
			_parser = (MessageParser<TargetRealm>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
