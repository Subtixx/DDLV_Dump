using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006E4")]
	public sealed class GridAreaData : IMessage<GridAreaData>, IMessage, IEquatable<GridAreaData>, IDeepCloneable<GridAreaData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400230A")]
		private static readonly MessageParser<GridAreaData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400230B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400230C")]
		public const int SizeXFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400230D")]
		private int sizeX_;

		[Cpp2IlInjected.Token(Token = "0x400230E")]
		public const int SizeYFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400230F")]
		private int sizeY_;

		[Cpp2IlInjected.Token(Token = "0x4002310")]
		public const int LayersFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002311")]
		private static readonly FieldCodec<int> _repeated_layers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002312")]
		private readonly RepeatedField<int> layers_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002313")]
		public const int AcceptedFloorTypesFlagFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002314")]
		private int acceptedFloorTypesFlag_;

		[Cpp2IlInjected.Token(Token = "0x4002315")]
		public const int StrideOverrideFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002316")]
		private static readonly FieldCodec<int?> _single_strideOverride_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002317")]
		private int? strideOverride_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002318")]
		private GridArea gridArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002319")]
		private GridSizeQualifier? gridSizeQualifier;

		[Cpp2IlInjected.Token(Token = "0x170013B2")]
		[DebuggerNonUserCode]
		public static MessageParser<GridAreaData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA5")]
			[Cpp2IlInjected.Address(RVA = "0x2F89F80", Offset = "0x2F88980", VA = "0x182F89F80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA6")]
			[Cpp2IlInjected.Address(RVA = "0x2F89E40", Offset = "0x2F88840", VA = "0x182F89E40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004CA7")]
			[Cpp2IlInjected.Address(RVA = "0x2F89FE0", Offset = "0x2F889E0", VA = "0x182F89FE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B5")]
		[DebuggerNonUserCode]
		public int SizeX
		{
			[Cpp2IlInjected.Token(Token = "0x6004CAC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return sizeX_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CAD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				sizeX_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B6")]
		[DebuggerNonUserCode]
		public int SizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6004CAE")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return sizeY_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CAF")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				sizeY_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B7")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Layers
		{
			[Cpp2IlInjected.Token(Token = "0x6004CB0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return layers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B8")]
		[DebuggerNonUserCode]
		public int AcceptedFloorTypesFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6004CB1")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return acceptedFloorTypesFlag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CB2")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				acceptedFloorTypesFlag_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B9")]
		[DebuggerNonUserCode]
		public int? StrideOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6004CB3")]
			[Cpp2IlInjected.Address(RVA = "0x13AD1D0", Offset = "0x13ABBD0", VA = "0x1813AD1D0")]
			get
			{
				return strideOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CB4")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			set
			{
				strideOverride_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013BA")]
		public GridFloorType AcceptedFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004CC0")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				int num = acceptedFloorTypesFlag_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6004CC1")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				acceptedFloorTypesFlag_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013BB")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6004CC2")]
			[Cpp2IlInjected.Address(RVA = "0x2F89F10", Offset = "0x2F88910", VA = "0x182F89F10")]
			get
			{
				if (sizeX_ != 0 && sizeY_ != 0)
				{
					int count = ((RepeatedField<T>)(object)layers_).Count;
					int num = sizeY_;
					return count == num;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2F89C00", Offset = "0x2F88600", VA = "0x182F89C00")]
		[DebuggerNonUserCode]
		public GridAreaData()
		{
			GridFloorType gridFloorType = (GridFloorType)(acceptedFloorTypesFlag_ = (int)GridFloorTypeExtensions.VillageGrass);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2F89560", Offset = "0x2F87F60", VA = "0x182F89560")]
		private void OnConstruction()
		{
			GridFloorType gridFloorType = (GridFloorType)(acceptedFloorTypesFlag_ = (int)GridFloorTypeExtensions.VillageGrass);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F89CD0", Offset = "0x2F886D0", VA = "0x182F89CD0")]
		[DebuggerNonUserCode]
		public GridAreaData(GridAreaData other)
		{
			GridFloorType gridFloorType = (GridFloorType)(acceptedFloorTypesFlag_ = (int)GridFloorTypeExtensions.VillageGrass);
			int num = (sizeX_ = other.sizeX_);
			int num2 = (sizeY_ = other.sizeY_);
			RepeatedField<int> repeatedField = (layers_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.layers_).Clone());
			int num3 = (acceptedFloorTypesFlag_ = other.acceptedFloorTypesFlag_);
			int? num4 = (strideOverride_ = other.strideOverride_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2F88700", Offset = "0x2F87100", VA = "0x182F88700", Slot = "10")]
		[DebuggerNonUserCode]
		public GridAreaData Clone()
		{
			//Discarded unreachable code: IL_008a
			GridAreaData gridAreaData = new GridAreaData();
			RepeatedField<int> repeatedField = (gridAreaData.layers_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			GridFloorType gridFloorType = (GridFloorType)(gridAreaData.acceptedFloorTypesFlag_ = (int)GridFloorTypeExtensions.VillageGrass);
			int num = (gridAreaData.sizeX_ = sizeX_);
			int num2 = (gridAreaData.sizeY_ = sizeY_);
			RepeatedField<int> repeatedField2 = (gridAreaData.layers_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)layers_).Clone());
			int num3 = (gridAreaData.acceptedFloorTypesFlag_ = acceptedFloorTypesFlag_);
			int? num4 = (gridAreaData.strideOverride_ = strideOverride_);
			UnknownFieldSet unknownFieldSet = (gridAreaData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridAreaData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB5")]
		[Cpp2IlInjected.Address(RVA = "0x2F88A10", Offset = "0x2F87410", VA = "0x182F88A10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0056: Expected O, but got I4
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
				if ((IntPtr)sizeX_ == (IntPtr)typeof(GridAreaData).TypeHandle && (IntPtr)sizeY_ == (IntPtr)typeof(GridAreaData).TypeHandle)
				{
					RepeatedField<int> repeatedField = layers_;
					bool flag = default(bool);
					if (flag && acceptedFloorTypesFlag_ == (flag ? 1 : 0))
					{
						int? num2 = strideOverride_;
						bool flag2 = default(bool);
						bool flag3 = default(bool);
						if (flag2 != flag3)
						{
							return object.Equals(_unknownFields, flag3);
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB6")]
		[Cpp2IlInjected.Address(RVA = "0x2F88B60", Offset = "0x2F87560", VA = "0x182F88B60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridAreaData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.sizeX_;
				if (sizeX_ == num)
				{
					int num2 = other.sizeY_;
					if (sizeY_ == num2)
					{
						RepeatedField<int> repeatedField = layers_;
						RepeatedField<int> repeatedField2 = other.layers_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							int num3 = other.acceptedFloorTypesFlag_;
							if (acceptedFloorTypesFlag_ == num3)
							{
								int? num4 = strideOverride_;
								int? num5 = other.strideOverride_;
								bool flag = (object)num4 == (object)num5;
								if ((object)num4 == (object)num5 != flag)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB7")]
		[Cpp2IlInjected.Address(RVA = "0x2F89190", Offset = "0x2F87B90", VA = "0x182F89190", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0048
			int num = 0;
			if (sizeX_ != 0)
			{
			}
			if (sizeY_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)layers_).GetHashCode();
			if (acceptedFloorTypesFlag_ != 0)
			{
			}
			int? num2 = strideOverride_;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2F89850", Offset = "0x2F88250", VA = "0x182F89850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB9")]
		[Cpp2IlInjected.Address(RVA = "0x2F898E0", Offset = "0x2F882E0", VA = "0x182F898E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
			if (sizeX_ != 0)
			{
				int value = sizeX_;
				output.WriteInt32(value);
			}
			if (sizeY_ != 0)
			{
				int value2 = sizeY_;
				output.WriteInt32(value2);
			}
			RepeatedField<int> repeatedField = layers_;
			FieldCodec<int> repeated_layers_codec = _repeated_layers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_layers_codec);
			if (acceptedFloorTypesFlag_ != 0)
			{
				int value3 = acceptedFloorTypesFlag_;
				output.WriteInt32(value3);
			}
			FieldCodec<int?> single_strideOverride_codec = _single_strideOverride_codec;
			int? value4 = strideOverride_;
			((FieldCodec<T>)(object)single_strideOverride_codec).WriteTagAndValue(output, (T)value4);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBA")]
		[Cpp2IlInjected.Address(RVA = "0x2F88480", Offset = "0x2F86E80", VA = "0x182F88480", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ae
			int num = sizeX_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = sizeY_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<int> repeatedField = layers_;
			FieldCodec<int> repeated_layers_codec = _repeated_layers_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_layers_codec);
			int num7 = acceptedFloorTypesFlag_;
			num2 += num6;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			FieldCodec<int?> single_strideOverride_codec = _single_strideOverride_codec;
			int? value = strideOverride_;
			int num9 = ((FieldCodec<T>)(object)single_strideOverride_codec).CalculateSizeWithTag((T)value);
			num2 += num9;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBB")]
		[Cpp2IlInjected.Address(RVA = "0x2F89480", Offset = "0x2F87E80", VA = "0x182F89480", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(GridAreaData other)
		{
			//Discarded unreachable code: IL_0096
			if (other != null)
			{
				int num = other.sizeX_;
				if (num != 0)
				{
					sizeX_ = num;
				}
				int num2 = other.sizeY_;
				if (num2 != 0)
				{
					sizeY_ = num2;
				}
				RepeatedField<int> repeatedField = layers_;
				RepeatedField<int> repeatedField2 = other.layers_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num3 = other.acceptedFloorTypesFlag_;
				if (num3 != 0)
				{
					acceptedFloorTypesFlag_ = num3;
				}
				int? num4 = other.strideOverride_;
				if ((IntPtr)(((object)num4 == null) ? 1 : 0) == (IntPtr)(void*)num4)
				{
					int? num5 = (strideOverride_ = other.strideOverride_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBC")]
		[Cpp2IlInjected.Address(RVA = "0x2F89290", Offset = "0x2F87C90", VA = "0x182F89290", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ad
			int num4 = default(int);
			int num5 = default(int);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((int)num > 24)
				{
					if (num == 26)
					{
						goto IL_007d;
					}
					if (num == 32)
					{
						int num2 = (acceptedFloorTypesFlag_ = input.ReadInt32());
					}
					if (num != 42)
					{
						goto IL_0096;
					}
					int? num3 = (int?)((FieldCodec<T>)(object)_single_strideOverride_codec).Read(input);
					if ((IntPtr)(((object)num3 == null) ? 1 : 0) != (IntPtr)(void*)num3)
					{
						continue;
					}
					strideOverride_ = num3;
				}
				if (num == 8)
				{
					num4 = (sizeX_ = input.ReadInt32());
				}
				if (num4 == 16)
				{
					num5 = (sizeY_ = input.ReadInt32());
				}
				if (num5 == 24)
				{
					goto IL_007d;
				}
				goto IL_0096;
				IL_007d:
				RepeatedField<int> repeatedField = layers_;
				FieldCodec<int> repeated_layers_codec = _repeated_layers_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_layers_codec);
				goto IL_0096;
				IL_0096:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBD")]
		[Cpp2IlInjected.Address(RVA = "0x2F88C60", Offset = "0x2F87660", VA = "0x182F88C60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 1)
					{
						goto IL_002d;
					}
					int? num2 = strideOverride_;
				}
				RepeatedField<int> repeatedField = layers_;
			}
			int num3 = sizeX_;
			goto IL_002d;
			IL_002d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBE")]
		[Cpp2IlInjected.Address(RVA = "0x2F895D0", Offset = "0x2F87FD0", VA = "0x182F895D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003c
			//IL_0023: Expected O, but got I4
			//IL_002b: Expected I4, but got O
			//IL_0033: Expected I4, but got O
			//IL_003b: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					switch (num)
					{
					case 1:
						if (value != null)
						{
						}
						strideOverride_ = (int?)(object)0;
						break;
					case 0:
					{
						object obj = default(object);
						acceptedFloorTypesFlag_ = (int)obj;
						break;
					}
					}
				}
				else
				{
					object obj2 = default(object);
					sizeY_ = (int)obj2;
				}
			}
			else
			{
				object obj3 = default(object);
				sizeX_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CBF")]
		[Cpp2IlInjected.Address(RVA = "0x2F88640", Offset = "0x2F87040", VA = "0x182F88640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0047
			//IL_0021: Expected O, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_0046: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
							strideOverride_ = (int?)(object)0;
							break;
						case 0:
							acceptedFloorTypesFlag_ = 0;
							break;
						}
						return;
					}
					RepeatedField<int> repeatedField = layers_;
				}
				sizeY_ = 0;
			}
			else
			{
				sizeX_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC3")]
		[Cpp2IlInjected.Address(RVA = "0x2F88D70", Offset = "0x2F87770", VA = "0x182F88D70")]
		public GridArea GetGridArea()
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (flag)
				{
					/*Error: Could not find block for branch target IL_0008*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC4")]
		[Cpp2IlInjected.Address(RVA = "0x2F897A0", Offset = "0x2F881A0", VA = "0x182F897A0")]
		public unsafe void SetLayersSize()
		{
			//Discarded unreachable code: IL_0048
			//IL_001f: Expected O, but got I4
			//IL_0026: Expected native int or pointer, but got O
			//IL_0043: Expected O, but got I4
			int num = sizeY_;
			((RepeatedField<T>)(object)layers_).Clear();
			int floorType = 0;
			int num2 = 0;
			int num3 = 0;
			gridArea = (GridArea)num2;
			((GridArea*)(IntPtr)gridArea)->FloorType = (GridFloorType)floorType;
			if (num > 0)
			{
				RepeatedField<int> repeatedField = layers_;
				int num4 = 0;
				((RepeatedField<T>)(object)repeatedField).Add((T)num4);
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC5")]
		[Cpp2IlInjected.Address(RVA = "0x2F88E60", Offset = "0x2F87860", VA = "0x182F88E60")]
		public GridSizeQualifier GetGridSizeQualifier()
		{
			//IL_004c: Expected O, but got I8
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				if (acceptedFloorTypesFlag_ == 2048)
				{
					int area = sizeY_;
					Predicate<GridSizeQualifierData.Types.AreaData> predicate = (Predicate<GridSizeQualifierData.Types.AreaData>)(object)(Predicate<T>)delegate(GridSizeQualifierData.Types.AreaData x)
					{
						//Discarded unreachable code: IL_001f
						int num5 = area;
						if (num5 < x.minArea_)
						{
							int num6 = 0;
						}
						return num5 <= x.maxArea_;
					};
					GridSizeQualifierData.Types.AreaData areaData = default(GridSizeQualifierData.Types.AreaData);
					GridSizeQualifier qualifier_ = areaData.qualifier_;
					ulong num = default(ulong);
					gridSizeQualifier = (GridSizeQualifier?)(object)num;
					GridSizeQualifier result = default(GridSizeQualifier);
					return result;
				}
				Predicate<GridSizeQualifierData.Types.WallData> predicate2 = (Predicate<GridSizeQualifierData.Types.WallData>)(object)(Predicate<T>)delegate(GridSizeQualifierData.Types.WallData x)
				{
					//Discarded unreachable code: IL_001f
					int num3 = sizeX_;
					if (num3 < x.minWidth_)
					{
						int num4 = 0;
					}
					return num3 <= x.maxWidth_;
				};
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC6")]
		[Cpp2IlInjected.Address(RVA = "0x2F888A0", Offset = "0x2F872A0", VA = "0x182F888A0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0074
			//IL_0058: Expected I4, but got O
			if (sizeX_ != 0 && sizeY_ != 0)
			{
				int count = ((RepeatedField<T>)(object)layers_).Count;
				int num = sizeY_;
				if (count == num)
				{
					goto IL_0034;
				}
			}
			context.AddError("Grid data is not valid");
			goto IL_0034;
			IL_0034:
			RepeatedField<int> repeatedField = layers_;
			int num2 = 0;
			int count2 = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num2 < count2)
			{
				int num3 = (int)((RepeatedField<T>)(object)layers_)[num2];
				RepeatedField<int> repeatedField2 = layers_;
				num2++;
			}
			if (1 == 0)
			{
				context.AddError("Grid data is not set (no layers on any cells)");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2F89A90", Offset = "0x2F88490", VA = "0x182F89A90")]
		static GridAreaData()
		{
			Func<GridAreaData> func = default(Func<GridAreaData>);
			_parser = (MessageParser<GridAreaData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<GridAreaData>)(object)FieldCodec.ForInt32(26u);
			uint num = default(uint);
			_parser = (MessageParser<GridAreaData>)(object)FieldCodec.ForStructWrapper<int>(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
