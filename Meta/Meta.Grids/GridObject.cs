using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001074")]
	public sealed class GridObject : IMessage<GridObject>, IMessage, IEquatable<GridObject>, IDeepCloneable<GridObject>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2001075")]
		public enum SourceOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40043EB")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40043EC")]
			From = 7
		}

		[Cpp2IlInjected.Token(Token = "0x40043D8")]
		private static readonly MessageParser<GridObject> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40043D9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40043DA")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40043DB")]
		private uint iD_;

		[Cpp2IlInjected.Token(Token = "0x40043DC")]
		public const int ItemIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40043DD")]
		private int itemID_;

		[Cpp2IlInjected.Token(Token = "0x40043DE")]
		public const int XFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40043DF")]
		private int x_;

		[Cpp2IlInjected.Token(Token = "0x40043E0")]
		public const int YFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40043E1")]
		private int y_;

		[Cpp2IlInjected.Token(Token = "0x40043E2")]
		public const int OrientationFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40043E3")]
		private GridOrientation orientation_;

		[Cpp2IlInjected.Token(Token = "0x40043E4")]
		public const int StateFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40043E5")]
		private GridState state_;

		[Cpp2IlInjected.Token(Token = "0x40043E6")]
		public const int FromFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40043E7")]
		private object source_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40043E8")]
		private SourceOneofCase sourceCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40043E9")]
		private GridArea gridArea;

		[Cpp2IlInjected.Token(Token = "0x1700172F")]
		[DebuggerNonUserCode]
		public static MessageParser<GridObject> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008562")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EEC0", Offset = "0x1D0D8C0", VA = "0x181D0EEC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001730")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008563")]
			[Cpp2IlInjected.Address(RVA = "0x1D0ED80", Offset = "0x1D0D780", VA = "0x181D0ED80")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001731")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008564")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EFC0", Offset = "0x1D0D9C0", VA = "0x181D0EFC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001732")]
		[DebuggerNonUserCode]
		public uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x6008568")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008569")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001733")]
		[DebuggerNonUserCode]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600856A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return itemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600856B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				itemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001734")]
		[DebuggerNonUserCode]
		public int X
		{
			[Cpp2IlInjected.Token(Token = "0x600856C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return x_;
			}
			[Cpp2IlInjected.Token(Token = "0x600856D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				x_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001735")]
		[DebuggerNonUserCode]
		public int Y
		{
			[Cpp2IlInjected.Token(Token = "0x600856E")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return y_;
			}
			[Cpp2IlInjected.Token(Token = "0x600856F")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				y_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001736")]
		[DebuggerNonUserCode]
		public GridOrientation Orientation
		{
			[Cpp2IlInjected.Token(Token = "0x6008570")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return orientation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008571")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				orientation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001737")]
		[DebuggerNonUserCode]
		public GridState State
		{
			[Cpp2IlInjected.Token(Token = "0x6008572")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008573")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001738")]
		[DebuggerNonUserCode]
		public GridSource From
		{
			[Cpp2IlInjected.Token(Token = "0x6008574")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EE50", Offset = "0x1D0D850", VA = "0x181D0EE50")]
			get
			{
				if (sourceCase_ == SourceOneofCase.From)
				{
					object obj = source_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008575")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F0D0", Offset = "0x1D0DAD0", VA = "0x181D0F0D0")]
			set
			{
				//IL_0016: Expected I4, but got I8
				source_ = typeof(GridSource).TypeHandle;
				sourceCase_ = SourceOneofCase.From;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001739")]
		[DebuggerNonUserCode]
		public SourceOneofCase SourceCase
		{
			[Cpp2IlInjected.Token(Token = "0x6008576")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return sourceCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173A")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6008585")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				int num = itemID_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6008586")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				itemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173B")]
		public GridPosition Position
		{
			[Cpp2IlInjected.Token(Token = "0x6008587")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EF20", Offset = "0x1D0D920", VA = "0x181D0EF20")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6008588")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F140", Offset = "0x1D0DB40", VA = "0x181D0F140")]
			set
			{
				//IL_0007: Expected I4, but got O
				//IL_000e: Expected I4, but got O
				x_ = (int)value;
				y_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173C")]
		public GridSource? Source
		{
			[Cpp2IlInjected.Token(Token = "0x6008589")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EF50", Offset = "0x1D0D950", VA = "0x181D0EF50")]
			get
			{
				if (sourceCase_ == SourceOneofCase.None)
				{
					int num = 0;
				}
				int from = (int)From;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600858A")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F150", Offset = "0x1D0DB50", VA = "0x181D0F150")]
			set
			{
				//IL_000d: Expected I4, but got I8
				//IL_0015: Expected O, but got I4
				//IL_001e: Expected I4, but got I8
				bool flag = default(bool);
				if (!flag)
				{
					sourceCase_ = SourceOneofCase.None;
					return;
				}
				GridSource gridSource = default(GridSource);
				source_ = gridSource;
				sourceCase_ = SourceOneofCase.From;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008565")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GridObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008566")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EC50", Offset = "0x1D0D650", VA = "0x181D0EC50")]
		[DebuggerNonUserCode]
		public GridObject(GridObject other)
		{
			//IL_006f: Expected O, but got I4
			//IL_0094: Expected I4, but got I8
			uint num = (iD_ = other.iD_);
			int num2 = (itemID_ = other.itemID_);
			int num3 = (x_ = other.x_);
			int num4 = (y_ = other.y_);
			GridOrientation gridOrientation = (orientation_ = other.orientation_);
			GridState gridState = other.state_;
			if (gridState != null)
			{
				GridState gridState2 = new GridState(gridState);
			}
			int num5 = 0;
			state_ = (GridState)num5;
			if (other.sourceCase_ == SourceOneofCase.From)
			{
				int from = (int)other.From;
				source_ = typeof(GridSource).TypeHandle;
				sourceCase_ = SourceOneofCase.From;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008567")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA60", Offset = "0x1D0C460", VA = "0x181D0DA60", Slot = "10")]
		[DebuggerNonUserCode]
		public GridObject Clone()
		{
			//Discarded unreachable code: IL_00ad
			//IL_0071: Expected O, but got I4
			//IL_0096: Expected I4, but got I8
			GridObject gridObject = new GridObject();
			uint num = (gridObject.iD_ = iD_);
			int num2 = (gridObject.itemID_ = itemID_);
			int num3 = (gridObject.x_ = x_);
			int num4 = (gridObject.y_ = y_);
			GridOrientation gridOrientation = (gridObject.orientation_ = orientation_);
			GridState gridState = state_;
			if (gridState != null)
			{
				GridState gridState2 = new GridState(gridState);
			}
			int num5 = 0;
			gridObject.state_ = (GridState)num5;
			if (sourceCase_ == SourceOneofCase.From)
			{
				int from = (int)From;
				gridObject.source_ = typeof(GridSource).TypeHandle;
				gridObject.sourceCase_ = SourceOneofCase.From;
			}
			UnknownFieldSet unknownFieldSet = (gridObject._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6008577")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearSource()
		{
			//IL_0010: Expected O, but got I4
			source_ = (sourceCase_ = SourceOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008578")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DC90", Offset = "0x1D0C690", VA = "0x181D0DC90", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			//IL_0087: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)iD_ == (IntPtr)typeof(GridObject).TypeHandle && (IntPtr)itemID_ == (IntPtr)typeof(GridObject).TypeHandle && (IntPtr)x_ == (IntPtr)typeof(GridObject).TypeHandle && (IntPtr)y_ == (IntPtr)typeof(GridObject).TypeHandle && (IntPtr)(void*)(int)orientation_ == (IntPtr)typeof(GridObject).TypeHandle && object.Equals(state_, other))
				{
					GridSource from = From;
					int num = 0;
					GridSource gridSource = default(GridSource);
					if (from == gridSource && sourceCase_ == (SourceOneofCase)gridSource)
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008579")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DBC0", Offset = "0x1D0C5C0", VA = "0x181D0DBC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridObject other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.iD_;
				if (iD_ == num)
				{
					int num2 = other.itemID_;
					if (itemID_ == num2)
					{
						int num3 = other.x_;
						if (x_ == num3)
						{
							int num4 = other.y_;
							if (y_ == num4)
							{
								GridOrientation gridOrientation = other.orientation_;
								if (orientation_ == gridOrientation)
								{
									GridState objB = other.state_;
									if (object.Equals(state_, objB))
									{
										int from = (int)From;
										GridSource from2 = other.From;
										if (from == (int)from2)
										{
											SourceOneofCase sourceOneofCase = other.sourceCase_;
											if (sourceCase_ == sourceOneofCase)
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
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600857A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E140", Offset = "0x1D0CB40", VA = "0x181D0E140", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0076
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
			}
			if (itemID_ != 0)
			{
			}
			if (x_ != 0)
			{
			}
			if (y_ != 0)
			{
			}
			if (orientation_ != 0)
			{
			}
			GridState gridState = state_;
			if (gridState != null)
			{
				int hashCode = gridState.GetHashCode();
			}
			if (sourceCase_ == SourceOneofCase.From && sourceCase_ == SourceOneofCase.From)
			{
				object obj = source_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600857B")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E980", Offset = "0x1D0D380", VA = "0x181D0E980", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600857C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E9E0", Offset = "0x1D0D3E0", VA = "0x181D0E9E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b0
			if (iD_ != 0)
			{
				uint value = iD_;
				output.WriteUInt32(value);
			}
			if (itemID_ != 0)
			{
				int value2 = itemID_;
				output.WriteInt32(value2);
			}
			if (x_ != 0)
			{
				int value3 = x_;
				output.WriteInt32(value3);
			}
			if (y_ != 0)
			{
				int value4 = y_;
				output.WriteInt32(value4);
			}
			if (orientation_ != 0)
			{
			}
			if ((long)state_ != 0)
			{
				GridState value5 = state_;
				output.WriteMessage(value5);
			}
			if (sourceCase_ == SourceOneofCase.From)
			{
				int from = (int)From;
				output.WriteInt32(from);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600857D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D740", Offset = "0x1D0C140", VA = "0x181D0D740", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f7
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			int num4 = itemID_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = x_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = y_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			GridOrientation gridOrientation = orientation_;
			if (gridOrientation != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)gridOrientation);
				num10++;
				num2 += num10;
			}
			GridState gridState = state_;
			if (gridState != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(gridState);
				num11++;
				num2 += num11;
			}
			if (sourceCase_ == SourceOneofCase.From)
			{
				if (sourceCase_ == SourceOneofCase.From)
				{
					object obj = source_;
				}
				num2++;
				int num12 = default(int);
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600857E")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E420", Offset = "0x1D0CE20", VA = "0x181D0E420", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridObject other)
		{
			//Discarded unreachable code: IL_00d2
			if (other == null)
			{
				return;
			}
			uint num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			int num2 = other.itemID_;
			if (num2 != 0)
			{
				itemID_ = num2;
			}
			int num3 = other.x_;
			if (num3 != 0)
			{
				x_ = num3;
			}
			int num4 = other.y_;
			if (num4 != 0)
			{
				y_ = num4;
			}
			GridOrientation gridOrientation = other.orientation_;
			if (gridOrientation != 0)
			{
				orientation_ = gridOrientation;
			}
			if ((long)other.state_ != 0)
			{
				GridState gridState2 = default(GridState);
				if (state_ == null)
				{
					GridState gridState = (state_ = new GridState());
					gridState2 = state_;
				}
				GridState other2 = other.state_;
				gridState2.MergeFrom(other2);
			}
			if (other.sourceCase_ == SourceOneofCase.From)
			{
				GridSource from = other.From;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600857F")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E540", Offset = "0x1D0CF40", VA = "0x181D0E540", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00e7
			//IL_005a: Expected O, but got I4
			//IL_0063: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if ((int)num > 40)
				{
					if (num == 50)
					{
						GridState gridState = state_;
						if (gridState == null)
						{
							GridState gridState2 = (state_ = new GridState());
						}
						input.ReadMessage(gridState);
					}
					if (num != 56)
					{
						goto IL_00d0;
					}
					int num2 = input.ReadInt32();
					source_ = num2;
					sourceCase_ = SourceOneofCase.From;
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (y_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_00d0;
				}
				int num4 = (int)(orientation_ = (GridOrientation)input.ReadInt32());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (int)(iD_ = (uint)input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 16)
			{
				num6 = (itemID_ = input.ReadInt32());
			}
			if (num6 == 24)
			{
				int num7 = (x_ = input.ReadInt32());
			}
			goto IL_00d0;
			IL_00d0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008580")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DDA0", Offset = "0x1D0C7A0", VA = "0x181D0DDA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				uint num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008581")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E700", Offset = "0x1D0D100", VA = "0x181D0E700", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001a, IL_0020
			//IL_000d: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				object obj = default(object);
				iD_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008582")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D950", Offset = "0x1D0C350", VA = "0x181D0D950", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c, IL_0036, IL_003a
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			if (fieldNumber <= 6)
			{
				iD_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008583")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E370", Offset = "0x1D0CD70", VA = "0x181D0E370", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Source"))
			{
				SourceOneofCase sourceOneofCase = sourceCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008584")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D9D0", Offset = "0x1D0C3D0", VA = "0x181D0D9D0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Source"))
			{
				source_ = (sourceCase_ = SourceOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600858B")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E2A0", Offset = "0x1D0CCA0", VA = "0x181D0E2A0")]
		public GridPosition GetLocalGridPosition(in GridPosition globalGridPosition)
		{
			GridOrientation gridOrientation = orientation_;
			GridPosition result = default(GridPosition);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600858C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DF40", Offset = "0x1D0C940", VA = "0x181D0DF40")]
		public GridArea GetGridArea()
		{
			//IL_0013: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag && ItemDatabase.Instance.GetItemData<IGridPlaceableItemData>((Item)num) == null)
			{
				int num3 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600858D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB40", Offset = "0x1D0D540", VA = "0x181D0EB40")]
		static GridObject()
		{
			Func<GridObject> func = default(Func<GridObject>);
			_parser = (MessageParser<GridObject>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
