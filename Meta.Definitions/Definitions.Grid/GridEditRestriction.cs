using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006E7")]
	public sealed class GridEditRestriction : IMessage<GridEditRestriction>, IMessage, IEquatable<GridEditRestriction>, IDeepCloneable<GridEditRestriction>, IMessageFieldAccessor, IDataValidation, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x20006E8")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20006E9")]
			public sealed class Restriction : IMessage<Restriction>, IMessage, IEquatable<Restriction>, IDeepCloneable<Restriction>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20006EA")]
				public enum RestrictionOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4002331")]
					None,
					[Cpp2IlInjected.Token(Token = "0x4002332")]
					Value,
					[Cpp2IlInjected.Token(Token = "0x4002333")]
					Conditions
				}

				[Cpp2IlInjected.Token(Token = "0x400232A")]
				private static readonly MessageParser<Restriction> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400232B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400232C")]
				public const int ValueFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400232D")]
				public const int ConditionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400232E")]
				private object restriction_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400232F")]
				private RestrictionOneofCase restrictionCase_;

				[Cpp2IlInjected.Token(Token = "0x170013C5")]
				[DebuggerNonUserCode]
				public static MessageParser<Restriction> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004CEE")]
					[Cpp2IlInjected.Address(RVA = "0x2949710", Offset = "0x2948110", VA = "0x182949710")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013C6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004CEF")]
					[Cpp2IlInjected.Address(RVA = "0x2949690", Offset = "0x2948090", VA = "0x182949690")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013C7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004CF0")]
					[Cpp2IlInjected.Address(RVA = "0x29497E0", Offset = "0x29481E0", VA = "0x1829497E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013C8")]
				[DebuggerNonUserCode]
				public bool Value
				{
					[Cpp2IlInjected.Token(Token = "0x6004CF5")]
					[Cpp2IlInjected.Address(RVA = "0x2949770", Offset = "0x2948170", VA = "0x182949770")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6004CF6")]
					[Cpp2IlInjected.Address(RVA = "0x29498A0", Offset = "0x29482A0", VA = "0x1829498A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013C9")]
				[DebuggerNonUserCode]
				public ConditionsList Conditions
				{
					[Cpp2IlInjected.Token(Token = "0x6004CF7")]
					[Cpp2IlInjected.Address(RVA = "0x2949630", Offset = "0x2948030", VA = "0x182949630")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004CF8")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013CA")]
				[DebuggerNonUserCode]
				public RestrictionOneofCase RestrictionCase
				{
					[Cpp2IlInjected.Token(Token = "0x6004CF9")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(RestrictionOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004CF1")]
				[Cpp2IlInjected.Address(RVA = "0x29495D0", Offset = "0x2947FD0", VA = "0x1829495D0")]
				[DebuggerNonUserCode]
				public Restriction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004CF2")]
				[Cpp2IlInjected.Address(RVA = "0x2949070", Offset = "0x2947A70", VA = "0x182949070")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004CF3")]
				[Cpp2IlInjected.Address(RVA = "0x2949450", Offset = "0x2947E50", VA = "0x182949450")]
				[DebuggerNonUserCode]
				public Restriction(Restriction other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004CF4")]
				[Cpp2IlInjected.Address(RVA = "0x29487C0", Offset = "0x29471C0", VA = "0x1829487C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Restriction Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFA")]
				[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
				[DebuggerNonUserCode]
				public void ClearRestriction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFB")]
				[Cpp2IlInjected.Address(RVA = "0x2948970", Offset = "0x2947370", VA = "0x182948970", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFC")]
				[Cpp2IlInjected.Address(RVA = "0x2948A60", Offset = "0x2947460", VA = "0x182948A60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Restriction other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFD")]
				[Cpp2IlInjected.Address(RVA = "0x2948C20", Offset = "0x2947620", VA = "0x182948C20", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFE")]
				[Cpp2IlInjected.Address(RVA = "0x2949200", Offset = "0x2947C00", VA = "0x182949200", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004CFF")]
				[Cpp2IlInjected.Address(RVA = "0x2949260", Offset = "0x2947C60", VA = "0x182949260", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D00")]
				[Cpp2IlInjected.Address(RVA = "0x29484F0", Offset = "0x2946EF0", VA = "0x1829484F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004D01")]
				[Cpp2IlInjected.Address(RVA = "0x2948F60", Offset = "0x2947960", VA = "0x182948F60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Restriction other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D02")]
				[Cpp2IlInjected.Address(RVA = "0x2948E00", Offset = "0x2947800", VA = "0x182948E00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D03")]
				[Cpp2IlInjected.Address(RVA = "0x2948B10", Offset = "0x2947510", VA = "0x182948B10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004D04")]
				[Cpp2IlInjected.Address(RVA = "0x29490D0", Offset = "0x2947AD0", VA = "0x1829490D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D05")]
				[Cpp2IlInjected.Address(RVA = "0x29486D0", Offset = "0x29470D0", VA = "0x1829486D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D06")]
				[Cpp2IlInjected.Address(RVA = "0x2948D50", Offset = "0x2947750", VA = "0x182948D50", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004D07")]
				[Cpp2IlInjected.Address(RVA = "0x2948750", Offset = "0x2947150", VA = "0x182948750", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004D08")]
				[Cpp2IlInjected.Address(RVA = "0x29485D0", Offset = "0x2946FD0", VA = "0x1829485D0")]
				public bool CanDoAction(IProfile profile, ITransactionContext context)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400231C")]
		private static readonly MessageParser<GridEditRestriction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400231D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400231E")]
		public const int CanMoveFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400231F")]
		private Types.Restriction canMove_;

		[Cpp2IlInjected.Token(Token = "0x4002320")]
		public const int CanRotateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002321")]
		private Types.Restriction canRotate_;

		[Cpp2IlInjected.Token(Token = "0x4002322")]
		public const int CanBeRemovedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002323")]
		private Types.Restriction canBeRemoved_;

		[Cpp2IlInjected.Token(Token = "0x4002324")]
		public const int CanBeClearedFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002325")]
		private bool canBeCleared_;

		[Cpp2IlInjected.Token(Token = "0x4002326")]
		public const int CanBeSelectedFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002327")]
		private Types.Restriction canBeSelected_;

		[Cpp2IlInjected.Token(Token = "0x4002328")]
		public const int CanSwitchGridFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002329")]
		private Types.Restriction canSwitchGrid_;

		[Cpp2IlInjected.Token(Token = "0x170013BC")]
		[DebuggerNonUserCode]
		public static MessageParser<GridEditRestriction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004CCE")]
			[Cpp2IlInjected.Address(RVA = "0x2F8EB10", Offset = "0x2F8D510", VA = "0x182F8EB10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013BD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CCF")]
			[Cpp2IlInjected.Address(RVA = "0x2F8EA40", Offset = "0x2F8D440", VA = "0x182F8EA40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013BE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CD0")]
			[Cpp2IlInjected.Address(RVA = "0x2F8EB70", Offset = "0x2F8D570", VA = "0x182F8EB70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013BF")]
		[DebuggerNonUserCode]
		public Types.Restriction CanMove
		{
			[Cpp2IlInjected.Token(Token = "0x6004CD4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return canMove_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CD5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				canMove_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C0")]
		[DebuggerNonUserCode]
		public Types.Restriction CanRotate
		{
			[Cpp2IlInjected.Token(Token = "0x6004CD6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return canRotate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CD7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				canRotate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C1")]
		[DebuggerNonUserCode]
		public Types.Restriction CanBeRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6004CD8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return canBeRemoved_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CD9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				canBeRemoved_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C2")]
		[DebuggerNonUserCode]
		public bool CanBeCleared
		{
			[Cpp2IlInjected.Token(Token = "0x6004CDA")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return canBeCleared_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CDB")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				canBeCleared_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C3")]
		[DebuggerNonUserCode]
		public Types.Restriction CanBeSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6004CDC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return canBeSelected_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CDD")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				canBeSelected_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C4")]
		[DebuggerNonUserCode]
		public Types.Restriction CanSwitchGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6004CDE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return canSwitchGrid_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CDF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				canSwitchGrid_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GridEditRestriction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD2")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E920", Offset = "0x2F8D320", VA = "0x182F8E920")]
		[DebuggerNonUserCode]
		public GridEditRestriction(GridEditRestriction other)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			Types.Restriction restriction = other.canMove_;
			int num = 0;
			if (restriction != null)
			{
				Types.Restriction restriction2 = restriction.Clone();
			}
			canMove_ = (Types.Restriction)num;
			Types.Restriction restriction3 = other.canRotate_;
			if (restriction3 != null)
			{
				Types.Restriction restriction4 = restriction3.Clone();
			}
			canRotate_ = (Types.Restriction)num;
			Types.Restriction restriction5 = other.canBeRemoved_;
			if (restriction5 != null)
			{
				Types.Restriction restriction6 = restriction5.Clone();
			}
			canBeRemoved_ = (Types.Restriction)num;
			bool flag = (canBeCleared_ = other.canBeCleared_);
			Types.Restriction restriction7 = other.canBeSelected_;
			if (restriction7 != null)
			{
				Types.Restriction restriction8 = restriction7.Clone();
			}
			canBeSelected_ = (Types.Restriction)num;
			Types.Restriction restriction9 = other.canSwitchGrid_;
			Types.Restriction restriction10 = default(Types.Restriction);
			if (restriction9 != null)
			{
				restriction10 = restriction9.Clone();
			}
			canSwitchGrid_ = restriction10;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D8F0", Offset = "0x2F8C2F0", VA = "0x182F8D8F0", Slot = "10")]
		[DebuggerNonUserCode]
		public GridEditRestriction Clone()
		{
			//Discarded unreachable code: IL_00bd
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			GridEditRestriction gridEditRestriction = new GridEditRestriction();
			Types.Restriction restriction = canMove_;
			int num = 0;
			if (restriction != null)
			{
				Types.Restriction restriction2 = restriction.Clone();
			}
			gridEditRestriction.canMove_ = (Types.Restriction)num;
			Types.Restriction restriction3 = canRotate_;
			if (restriction3 != null)
			{
				Types.Restriction restriction4 = restriction3.Clone();
			}
			gridEditRestriction.canRotate_ = (Types.Restriction)num;
			Types.Restriction restriction5 = canBeRemoved_;
			if (restriction5 != null)
			{
				Types.Restriction restriction6 = restriction5.Clone();
			}
			gridEditRestriction.canBeRemoved_ = (Types.Restriction)num;
			bool flag = (gridEditRestriction.canBeCleared_ = canBeCleared_);
			Types.Restriction restriction7 = canBeSelected_;
			if (restriction7 != null)
			{
				Types.Restriction restriction8 = restriction7.Clone();
			}
			gridEditRestriction.canBeSelected_ = (Types.Restriction)num;
			Types.Restriction restriction9 = canSwitchGrid_;
			Types.Restriction restriction10 = default(Types.Restriction);
			if (restriction9 != null)
			{
				restriction10 = restriction9.Clone();
			}
			gridEditRestriction.canSwitchGrid_ = restriction10;
			UnknownFieldSet unknownFieldSet = (gridEditRestriction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridEditRestriction;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DC20", Offset = "0x2F8C620", VA = "0x182F8DC20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(canMove_, other) && object.Equals(canRotate_, other))
				{
					bool flag = object.Equals(canBeRemoved_, other);
					if (flag && canBeCleared_ == flag && object.Equals(canBeSelected_, other) && object.Equals(canSwitchGrid_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE1")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DB50", Offset = "0x2F8C550", VA = "0x182F8DB50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridEditRestriction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.Restriction objB = other.canMove_;
				if (object.Equals(canMove_, objB))
				{
					Types.Restriction objB2 = other.canRotate_;
					if (object.Equals(canRotate_, objB2))
					{
						Types.Restriction objB3 = other.canBeRemoved_;
						if (object.Equals(canBeRemoved_, objB3))
						{
							bool flag = other.canBeCleared_;
							if (canBeCleared_ == flag)
							{
								Types.Restriction objB4 = other.canBeSelected_;
								if (object.Equals(canBeSelected_, objB4))
								{
									Types.Restriction objB5 = other.canSwitchGrid_;
									if (object.Equals(canSwitchGrid_, objB5))
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE2")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DE60", Offset = "0x2F8C860", VA = "0x182F8DE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.Restriction restriction = canMove_;
				if (restriction != null)
				{
					int hashCode = restriction.GetHashCode();
				}
				Types.Restriction restriction2 = canRotate_;
				if (restriction2 != null)
				{
					int hashCode2 = restriction2.GetHashCode();
				}
				Types.Restriction restriction3 = canBeRemoved_;
				if (restriction3 != null)
				{
					int hashCode3 = restriction3.GetHashCode();
				}
				if (canBeCleared_)
				{
				}
				Types.Restriction restriction4 = canBeSelected_;
				if (restriction4 != null)
				{
					int hashCode4 = restriction4.GetHashCode();
				}
				Types.Restriction restriction5 = canSwitchGrid_;
				if (restriction5 != null)
				{
					int hashCode5 = restriction5.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE3")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E670", Offset = "0x2F8D070", VA = "0x182F8E670", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE4")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E6D0", Offset = "0x2F8D0D0", VA = "0x182F8E6D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ae
			if ((long)canMove_ != 0)
			{
				Types.Restriction value = canMove_;
				output.WriteMessage(value);
			}
			if ((long)canRotate_ != 0)
			{
				Types.Restriction value2 = canRotate_;
				output.WriteMessage(value2);
			}
			if ((long)canBeRemoved_ != 0)
			{
				Types.Restriction value3 = canBeRemoved_;
				output.WriteMessage(value3);
			}
			if (canBeCleared_)
			{
				bool value4 = canBeCleared_;
				output.WriteBool(value4);
			}
			if ((long)canBeSelected_ != 0)
			{
				Types.Restriction value5 = canBeSelected_;
				output.WriteMessage(value5);
			}
			if ((long)canSwitchGrid_ != 0)
			{
				Types.Restriction value6 = canSwitchGrid_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE5")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D6D0", Offset = "0x2F8C0D0", VA = "0x182F8D6D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.Restriction restriction = canMove_;
				num = 0;
				if (restriction != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(restriction);
				}
				Types.Restriction restriction2 = canRotate_;
				if (restriction2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(restriction2);
					num3++;
					num += num3;
				}
				Types.Restriction restriction3 = canBeRemoved_;
				if (restriction3 != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(restriction3);
					num4++;
					num += num4;
				}
				Types.Restriction restriction4 = canBeSelected_;
				if (restriction4 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(restriction4);
					num5++;
					num += num5;
				}
				Types.Restriction restriction5 = canSwitchGrid_;
				if (restriction5 != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(restriction5);
					num6++;
					num += num6;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num7 = unknownFields.CalculateSize();
			return num7 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE6")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E180", Offset = "0x2F8CB80", VA = "0x182F8E180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridEditRestriction other)
		{
			//Discarded unreachable code: IL_0164
			if (other == null)
			{
				return;
			}
			if ((long)other.canMove_ != 0)
			{
				Types.Restriction restriction = canMove_;
				if (restriction == null)
				{
					Types.Restriction restriction2 = (canMove_ = new Types.Restriction());
					Types.Restriction restriction3 = canMove_;
				}
				Types.Restriction other2 = other.canMove_;
				restriction.MergeFrom(other2);
			}
			if ((long)other.canRotate_ != 0)
			{
				Types.Restriction restriction5 = default(Types.Restriction);
				if (canRotate_ == null)
				{
					Types.Restriction restriction4 = (canRotate_ = new Types.Restriction());
					restriction5 = canRotate_;
				}
				Types.Restriction other3 = other.canRotate_;
				restriction5.MergeFrom(other3);
			}
			if ((long)other.canBeRemoved_ != 0)
			{
				Types.Restriction restriction7 = default(Types.Restriction);
				if (canBeRemoved_ == null)
				{
					Types.Restriction restriction6 = (canBeRemoved_ = new Types.Restriction());
					restriction7 = canBeRemoved_;
				}
				Types.Restriction other4 = other.canBeRemoved_;
				restriction7.MergeFrom(other4);
			}
			bool flag = other.canBeCleared_;
			if (flag)
			{
				canBeCleared_ = flag;
			}
			if ((long)other.canBeSelected_ != 0)
			{
				Types.Restriction restriction9 = default(Types.Restriction);
				if (canBeSelected_ == null)
				{
					Types.Restriction restriction8 = (canBeSelected_ = new Types.Restriction());
					restriction9 = canBeSelected_;
				}
				Types.Restriction other5 = other.canBeSelected_;
				restriction9.MergeFrom(other5);
			}
			if ((long)other.canSwitchGrid_ != 0)
			{
				Types.Restriction restriction11 = default(Types.Restriction);
				if (canSwitchGrid_ == null)
				{
					Types.Restriction restriction10 = (canSwitchGrid_ = new Types.Restriction());
					restriction11 = canSwitchGrid_;
				}
				Types.Restriction other6 = other.canSwitchGrid_;
				restriction11.MergeFrom(other6);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE7")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DF50", Offset = "0x2F8C950", VA = "0x182F8DF50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_012a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 32)
				{
					bool flag = (canBeCleared_ = input.ReadBool());
				}
				Types.Restriction restriction = default(Types.Restriction);
				if (num == 42)
				{
					Types.Restriction builder = default(Types.Restriction);
					if (canBeSelected_ == null)
					{
						restriction = (canBeSelected_ = new Types.Restriction());
						builder = canBeSelected_;
					}
					input.ReadMessage(builder);
				}
				if ((long)restriction != 50)
				{
					goto IL_0113;
				}
				Types.Restriction builder2 = default(Types.Restriction);
				if (canSwitchGrid_ == null)
				{
					Types.Restriction restriction2 = (canSwitchGrid_ = new Types.Restriction());
					builder2 = canSwitchGrid_;
				}
				input.ReadMessage(builder2);
			}
			Types.Restriction restriction3 = default(Types.Restriction);
			if (num == 10)
			{
				Types.Restriction builder3 = default(Types.Restriction);
				if (canMove_ == null)
				{
					restriction3 = (canMove_ = new Types.Restriction());
					builder3 = canMove_;
				}
				input.ReadMessage(builder3);
			}
			Types.Restriction restriction4 = default(Types.Restriction);
			if ((long)restriction3 == 18)
			{
				Types.Restriction builder4 = default(Types.Restriction);
				if (canRotate_ == null)
				{
					restriction4 = (canRotate_ = new Types.Restriction());
					builder4 = canRotate_;
				}
				input.ReadMessage(builder4);
			}
			if ((long)restriction4 == 26)
			{
				Types.Restriction builder5 = default(Types.Restriction);
				if (canBeRemoved_ == null)
				{
					Types.Restriction restriction5 = (canBeRemoved_ = new Types.Restriction());
					builder5 = canBeRemoved_;
				}
				input.ReadMessage(builder5);
			}
			goto IL_0113;
			IL_0113:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DD30", Offset = "0x2F8C730", VA = "0x182F8DD30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				Types.Restriction restriction = canMove_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE9")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E4A0", Offset = "0x2F8CEA0", VA = "0x182F8E4A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0020, IL_002c, IL_0032, IL_0038
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				canMove_ = (Types.Restriction)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CEA")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D850", Offset = "0x2F8C250", VA = "0x182F8D850", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber > 5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CEB")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DA40", Offset = "0x2F8C440", VA = "0x182F8DA40", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_006d
			if ((long)canMove_ == 0)
			{
				context.AddInvalidMemberError("Member is Null. Needs to be converted to new Data Structure.", "CanMove");
			}
			if ((long)canRotate_ == 0)
			{
				context.AddInvalidMemberError("Member is Null. Needs to be converted to new Data Structure.", "CanRotate");
			}
			if ((long)canBeRemoved_ == 0)
			{
				context.AddInvalidMemberError("Member is Null. Needs to be converted to new Data Structure.", "CanBeRemoved");
			}
			if ((long)canBeSelected_ == 0)
			{
				context.AddInvalidMemberError("Member is Null. Needs to be converted to new Data Structure.", "CanBeSelected");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CEC")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E3A0", Offset = "0x2F8CDA0", VA = "0x182F8E3A0", Slot = "15")]
		public void SetDefaultData()
		{
			Types.Restriction restriction = (canMove_ = new Types.Restriction());
			Types.Restriction restriction2 = (canRotate_ = new Types.Restriction());
			Types.Restriction restriction3 = (canBeRemoved_ = new Types.Restriction());
			canBeCleared_ = true;
			Types.Restriction restriction4 = (canBeSelected_ = new Types.Restriction());
			Types.Restriction restriction5 = (canSwitchGrid_ = new Types.Restriction());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CED")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E810", Offset = "0x2F8D210", VA = "0x182F8E810")]
		static GridEditRestriction()
		{
			Func<GridEditRestriction> func = default(Func<GridEditRestriction>);
			_parser = (MessageParser<GridEditRestriction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
