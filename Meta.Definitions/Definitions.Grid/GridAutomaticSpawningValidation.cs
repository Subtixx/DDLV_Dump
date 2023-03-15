using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mdl.Utils;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200070B")]
	public sealed class GridAutomaticSpawningValidation : IMessage<GridAutomaticSpawningValidation>, IMessage, IEquatable<GridAutomaticSpawningValidation>, IDeepCloneable<GridAutomaticSpawningValidation>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40023A5")]
		private static readonly MessageParser<GridAutomaticSpawningValidation> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023A7")]
		public const int GridDataPathsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023A8")]
		private static readonly FieldCodec<string> _repeated_gridDataPaths_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023A9")]
		private readonly RepeatedField<string> gridDataPaths_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001418")]
		[DebuggerNonUserCode]
		public static MessageParser<GridAutomaticSpawningValidation> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E8D")]
			[Cpp2IlInjected.Address(RVA = "0x2F8BF20", Offset = "0x2F8A920", VA = "0x182F8BF20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001419")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E8E")]
			[Cpp2IlInjected.Address(RVA = "0x2F8BE50", Offset = "0x2F8A850", VA = "0x182F8BE50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E8F")]
			[Cpp2IlInjected.Address(RVA = "0x2F8BF80", Offset = "0x2F8A980", VA = "0x182F8BF80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141B")]
		[DebuggerNonUserCode]
		public RepeatedField<string> GridDataPaths
		{
			[Cpp2IlInjected.Token(Token = "0x6004E93")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gridDataPaths_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E90")]
		[Cpp2IlInjected.Address(RVA = "0x2F8BCD0", Offset = "0x2F8A6D0", VA = "0x182F8BCD0")]
		[DebuggerNonUserCode]
		public GridAutomaticSpawningValidation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E91")]
		[Cpp2IlInjected.Address(RVA = "0x2F8BD50", Offset = "0x2F8A750", VA = "0x182F8BD50")]
		[DebuggerNonUserCode]
		public GridAutomaticSpawningValidation(GridAutomaticSpawningValidation other)
		{
			RepeatedField<string> repeatedField = (gridDataPaths_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.gridDataPaths_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E92")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ADB0", Offset = "0x2F897B0", VA = "0x182F8ADB0", Slot = "10")]
		[DebuggerNonUserCode]
		public GridAutomaticSpawningValidation Clone()
		{
			//Discarded unreachable code: IL_003b
			GridAutomaticSpawningValidation gridAutomaticSpawningValidation = new GridAutomaticSpawningValidation();
			RepeatedField<string> repeatedField = (gridAutomaticSpawningValidation.gridDataPaths_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			RepeatedField<string> repeatedField2 = (gridAutomaticSpawningValidation.gridDataPaths_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)gridDataPaths_).Clone());
			UnknownFieldSet unknownFieldSet = (gridAutomaticSpawningValidation._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridAutomaticSpawningValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E94")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B240", Offset = "0x2F89C40", VA = "0x182F8B240", Slot = "0")]
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
				RepeatedField<string> repeatedField = gridDataPaths_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E95")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B320", Offset = "0x2F89D20", VA = "0x182F8B320", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridAutomaticSpawningValidation other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<string> repeatedField = gridDataPaths_;
				RepeatedField<string> repeatedField2 = other.gridDataPaths_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E96")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)gridDataPaths_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E97")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B600", Offset = "0x2F8A000", VA = "0x182F8B600", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E98")]
		[Cpp2IlInjected.Address(RVA = "0x2F8BAD0", Offset = "0x2F8A4D0", VA = "0x182F8BAD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<string> repeatedField = gridDataPaths_;
			FieldCodec<string> repeated_gridDataPaths_codec = _repeated_gridDataPaths_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gridDataPaths_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E99")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AB30", Offset = "0x2F89530", VA = "0x182F8AB30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<string> repeatedField = gridDataPaths_;
			FieldCodec<string> repeated_gridDataPaths_codec = _repeated_gridDataPaths_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gridDataPaths_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9A")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B520", Offset = "0x2F89F20", VA = "0x182F8B520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridAutomaticSpawningValidation other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<string> repeatedField = gridDataPaths_;
				RepeatedField<string> repeatedField2 = other.gridDataPaths_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9B")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B430", Offset = "0x2F89E30", VA = "0x182F8B430", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<string> repeatedField = gridDataPaths_;
					FieldCodec<string> repeated_gridDataPaths_codec = _repeated_gridDataPaths_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridDataPaths_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9C")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B3B0", Offset = "0x2F89DB0", VA = "0x182F8B3B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = gridDataPaths_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9D")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B5A0", Offset = "0x2F89FA0", VA = "0x182F8B5A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9E")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AD50", Offset = "0x2F89750", VA = "0x182F8AD50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = gridDataPaths_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9F")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AEE0", Offset = "0x2F898E0", VA = "0x182F8AEE0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_014a
			if (((RepeatedField<T>)(object)gridDataPaths_).Count <= 1)
			{
				return;
			}
			RepeatedField<string> repeatedField = gridDataPaths_;
			int index = 0;
			GridData gridData = GridData.Get((string)((RepeatedField<T>)(object)repeatedField)[index]);
			int count = ((RepeatedField<T>)(object)gridDataPaths_).Count;
			if (1 >= count)
			{
				return;
			}
			GridData gridData2 = GridData.Get((string)((RepeatedField<T>)(object)gridDataPaths_)[1]);
			int sizeX_ = gridData2.sizeX_;
			if (gridData.sizeX_ == sizeX_)
			{
				int sizeY_ = gridData2.sizeY_;
				if (gridData.sizeY_ == sizeY_)
				{
					int num = 0;
					if (num < gridData.sizeX_)
					{
						int num2 = 0;
						if (num2 < gridData.sizeY_)
						{
							GridFloorType gridFloorType = gridData[num, num2];
							GridFloorType all = GridFloorTypeExtensions.All;
							GridFloorType gridFloorType2 = gridData2[num, num2];
							GridFloorType all2 = GridFloorTypeExtensions.All;
							if (all != all2)
							{
								goto IL_00cf;
							}
							num2++;
						}
						num++;
						goto IL_00cf;
					}
					goto IL_0141;
				}
			}
			goto IL_0108;
			IL_0141:
			RepeatedField<string> repeatedField2 = gridDataPaths_;
			return;
			IL_00cf:
			string text = (string)((RepeatedField<T>)(object)gridDataPaths_)[1];
			RepeatedField<string> repeatedField3 = gridDataPaths_;
			int index2 = 0;
			string text2 = (string)((RepeatedField<T>)(object)repeatedField3)[index2];
			string text3 = "GridData of " + text + " does not have the same floor types as " + text2;
			goto IL_0108;
			IL_0108:
			string text4 = (string)((RepeatedField<T>)(object)gridDataPaths_)[1];
			RepeatedField<string> repeatedField4 = gridDataPaths_;
			int index3 = 0;
			string text5 = (string)((RepeatedField<T>)(object)repeatedField4)[index3];
			string text6 = "GridData " + text4 + " does not have the same size as " + text5;
			goto IL_0141;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ABE0", Offset = "0x2F895E0", VA = "0x182F8ABE0")]
		public bool CanUniformize()
		{
			if (((RepeatedField<T>)(object)gridDataPaths_).Count > 1)
			{
				RepeatedField<string> repeatedField = gridDataPaths_;
				int index = 0;
				GridData gridData = GridData.Get((string)((RepeatedField<T>)(object)repeatedField)[index]);
				int count = ((RepeatedField<T>)(object)gridDataPaths_).Count;
				if (1 >= count)
				{
					goto IL_0078;
				}
				GridData gridData2 = GridData.Get((string)((RepeatedField<T>)(object)gridDataPaths_)[1]);
				int sizeX_ = gridData2.sizeX_;
				if (gridData.sizeX_ == sizeX_)
				{
					int sizeY_ = gridData2.sizeY_;
					if (gridData.sizeY_ == sizeY_)
					{
						RepeatedField<string> repeatedField2 = gridDataPaths_;
					}
				}
			}
			int num = 0;
			goto IL_0078;
			IL_0078:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA1")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B660", Offset = "0x2F8A060", VA = "0x182F8B660")]
		public void Uniformize()
		{
			//Discarded unreachable code: IL_0164
			//IL_0129: Expected O, but got I4
			//IL_0149: Expected I4, but got I8
			ulong num5 = default(ulong);
			uint num4 = default(uint);
			while (((RepeatedField<T>)(object)gridDataPaths_).Count > 1)
			{
				RepeatedField<string> repeatedField = gridDataPaths_;
				int index = 0;
				GridData gridData = GridData.Get((string)((RepeatedField<T>)(object)repeatedField)[index]);
				int count = ((RepeatedField<T>)(object)gridDataPaths_).Count;
				RepeatedField<string> repeatedField2 = gridDataPaths_;
				if (1 < count)
				{
					GridData gridData2 = GridData.Get((string)((RepeatedField<T>)(object)repeatedField2)[1]);
					int sizeX_ = gridData2.sizeX_;
					if (gridData.sizeX_ != sizeX_)
					{
						break;
					}
					int sizeY_ = gridData2.sizeY_;
					if (gridData.sizeY_ != sizeY_)
					{
						break;
					}
					if (gridDataPaths_ != null)
					{
						continue;
					}
				}
				int index2 = 0;
				GridData gridData3 = GridData.Get((string)((RepeatedField<T>)(object)repeatedField2)[index2]);
				int count2 = ((RepeatedField<T>)(object)gridDataPaths_).Count;
				if (1 >= count2)
				{
					break;
				}
				GridData gridData4 = GridData.Get((string)((RepeatedField<T>)(object)gridDataPaths_)[1]);
				int num = 0;
				int num2 = 0;
				if (num2 < gridData3.sizeX_)
				{
					int num3 = 0;
					if (num3 < gridData3.sizeY_)
					{
						GridFloorType gridFloorType = gridData3[num2, num3];
						GridFloorType all = GridFloorTypeExtensions.All;
						GridFloorType gridFloorType2 = gridData4[num2, num3];
						if (gridData4[num2, num3] != all)
						{
						}
						num3++;
					}
					num2++;
				}
				if (num != 0)
				{
					IFileSystem binaryLocalizationFs = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
					string path = (string)((RepeatedField<T>)(object)gridDataPaths_)[(int)num4];
					int formatEnumAsIntegers = 0;
					string text = gridData4.ToJSONString(formatDefaultValues: true, indented: true, (byte)formatEnumAsIntegers != 0, (int)num5);
					binaryLocalizationFs.WriteAllText(path, text);
				}
				RepeatedField<string> repeatedField3 = gridDataPaths_;
				num4++;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA2")]
		[Cpp2IlInjected.Address(RVA = "0x2F8BB90", Offset = "0x2F8A590", VA = "0x182F8BB90")]
		static GridAutomaticSpawningValidation()
		{
			Func<GridAutomaticSpawningValidation> func = default(Func<GridAutomaticSpawningValidation>);
			_parser = (MessageParser<GridAutomaticSpawningValidation>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<GridAutomaticSpawningValidation>)(object)FieldCodec.ForString(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
