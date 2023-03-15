using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006F7")]
	public sealed class GridSizeQualifierData : IMessage<GridSizeQualifierData>, IMessage, IEquatable<GridSizeQualifierData>, IDeepCloneable<GridSizeQualifierData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20006F8")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20006F9")]
			public sealed class AreaData : IMessage<AreaData>, IMessage, IEquatable<AreaData>, IDeepCloneable<AreaData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002365")]
				private static readonly MessageParser<AreaData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002366")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002367")]
				public const int MinAreaFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002368")]
				private int minArea_;

				[Cpp2IlInjected.Token(Token = "0x4002369")]
				public const int MaxAreaFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400236A")]
				private int maxArea_;

				[Cpp2IlInjected.Token(Token = "0x400236B")]
				public const int QualifierFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400236C")]
				private GridSizeQualifier qualifier_;

				[Cpp2IlInjected.Token(Token = "0x170013EC")]
				[DebuggerNonUserCode]
				public static MessageParser<AreaData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004DAE")]
					[Cpp2IlInjected.Address(RVA = "0x2938830", Offset = "0x2937230", VA = "0x182938830")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013ED")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004DAF")]
					[Cpp2IlInjected.Address(RVA = "0x29387B0", Offset = "0x29371B0", VA = "0x1829387B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013EE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004DB0")]
					[Cpp2IlInjected.Address(RVA = "0x2938890", Offset = "0x2937290", VA = "0x182938890", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013EF")]
				[DebuggerNonUserCode]
				public int MinArea
				{
					[Cpp2IlInjected.Token(Token = "0x6004DB4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DB5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F0")]
				[DebuggerNonUserCode]
				public int MaxArea
				{
					[Cpp2IlInjected.Token(Token = "0x6004DB6")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DB7")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F1")]
				[DebuggerNonUserCode]
				public GridSizeQualifier Qualifier
				{
					[Cpp2IlInjected.Token(Token = "0x6004DB8")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(GridSizeQualifier);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DB9")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004DB1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public AreaData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DB2")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public AreaData(AreaData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DB3")]
				[Cpp2IlInjected.Address(RVA = "0x2938310", Offset = "0x2936D10", VA = "0x182938310", Slot = "10")]
				[DebuggerNonUserCode]
				public AreaData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBA")]
				[Cpp2IlInjected.Address(RVA = "0x29383A0", Offset = "0x2936DA0", VA = "0x1829383A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBB")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(AreaData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBC")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B090", Offset = "0x1E79A90", VA = "0x181E7B090", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBD")]
				[Cpp2IlInjected.Address(RVA = "0x2938640", Offset = "0x2937040", VA = "0x182938640", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBE")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DBF")]
				[Cpp2IlInjected.Address(RVA = "0x2938210", Offset = "0x2936C10", VA = "0x182938210", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DC0")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(AreaData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DC1")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DC2")]
				[Cpp2IlInjected.Address(RVA = "0x2938440", Offset = "0x2936E40", VA = "0x182938440", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DC3")]
				[Cpp2IlInjected.Address(RVA = "0x2938520", Offset = "0x2936F20", VA = "0x182938520", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DC4")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20006FB")]
			public sealed class WallData : IMessage<WallData>, IMessage, IEquatable<WallData>, IDeepCloneable<WallData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400236E")]
				private static readonly MessageParser<WallData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400236F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002370")]
				public const int MinWidthFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002371")]
				private int minWidth_;

				[Cpp2IlInjected.Token(Token = "0x4002372")]
				public const int MaxWidthFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002373")]
				private int maxWidth_;

				[Cpp2IlInjected.Token(Token = "0x4002374")]
				public const int QualifierFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002375")]
				private GridSizeQualifier qualifier_;

				[Cpp2IlInjected.Token(Token = "0x170013F2")]
				[DebuggerNonUserCode]
				public static MessageParser<WallData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004DC9")]
					[Cpp2IlInjected.Address(RVA = "0x294F600", Offset = "0x294E000", VA = "0x18294F600")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004DCA")]
					[Cpp2IlInjected.Address(RVA = "0x294F580", Offset = "0x294DF80", VA = "0x18294F580")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004DCB")]
					[Cpp2IlInjected.Address(RVA = "0x294F660", Offset = "0x294E060", VA = "0x18294F660", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F5")]
				[DebuggerNonUserCode]
				public int MinWidth
				{
					[Cpp2IlInjected.Token(Token = "0x6004DCF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DD0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F6")]
				[DebuggerNonUserCode]
				public int MaxWidth
				{
					[Cpp2IlInjected.Token(Token = "0x6004DD1")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DD2")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170013F7")]
				[DebuggerNonUserCode]
				public GridSizeQualifier Qualifier
				{
					[Cpp2IlInjected.Token(Token = "0x6004DD3")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(GridSizeQualifier);
					}
					[Cpp2IlInjected.Token(Token = "0x6004DD4")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004DCC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public WallData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DCD")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public WallData(WallData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DCE")]
				[Cpp2IlInjected.Address(RVA = "0x294F0E0", Offset = "0x294DAE0", VA = "0x18294F0E0", Slot = "10")]
				[DebuggerNonUserCode]
				public WallData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DD5")]
				[Cpp2IlInjected.Address(RVA = "0x294F170", Offset = "0x294DB70", VA = "0x18294F170", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DD6")]
				[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(WallData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DD7")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B090", Offset = "0x1E79A90", VA = "0x181E7B090", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DD8")]
				[Cpp2IlInjected.Address(RVA = "0x294F410", Offset = "0x294DE10", VA = "0x18294F410", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DD9")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDA")]
				[Cpp2IlInjected.Address(RVA = "0x294EFE0", Offset = "0x294D9E0", VA = "0x18294EFE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDB")]
				[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(WallData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDC")]
				[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDD")]
				[Cpp2IlInjected.Address(RVA = "0x294F210", Offset = "0x294DC10", VA = "0x18294F210", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDE")]
				[Cpp2IlInjected.Address(RVA = "0x294F2F0", Offset = "0x294DCF0", VA = "0x18294F2F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004DDF")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400235D")]
		private static readonly MessageParser<GridSizeQualifierData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400235E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400235F")]
		public const int AreaDataListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002360")]
		private static readonly FieldCodec<Types.AreaData> _repeated_areaDataList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002361")]
		private readonly RepeatedField<Types.AreaData> areaDataList_ = (RepeatedField<Types.AreaData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002362")]
		public const int WallDataListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002363")]
		private static readonly FieldCodec<Types.WallData> _repeated_wallDataList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002364")]
		private readonly RepeatedField<Types.WallData> wallDataList_ = (RepeatedField<Types.WallData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170013E7")]
		[DebuggerNonUserCode]
		public static MessageParser<GridSizeQualifierData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D9A")]
			[Cpp2IlInjected.Address(RVA = "0x2F946B0", Offset = "0x2F930B0", VA = "0x182F946B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D9B")]
			[Cpp2IlInjected.Address(RVA = "0x2F945E0", Offset = "0x2F92FE0", VA = "0x182F945E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D9C")]
			[Cpp2IlInjected.Address(RVA = "0x2F94710", Offset = "0x2F93110", VA = "0x182F94710", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EA")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.AreaData> AreaDataList
		{
			[Cpp2IlInjected.Token(Token = "0x6004DA0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return areaDataList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EB")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.WallData> WallDataList
		{
			[Cpp2IlInjected.Token(Token = "0x6004DA1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return wallDataList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9D")]
		[Cpp2IlInjected.Address(RVA = "0x2F94520", Offset = "0x2F92F20", VA = "0x182F94520")]
		[DebuggerNonUserCode]
		public GridSizeQualifierData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9E")]
		[Cpp2IlInjected.Address(RVA = "0x2F943A0", Offset = "0x2F92DA0", VA = "0x182F943A0")]
		[DebuggerNonUserCode]
		public GridSizeQualifierData(GridSizeQualifierData other)
		{
			RepeatedField<Types.AreaData> repeatedField = (areaDataList_ = (RepeatedField<Types.AreaData>)(object)((RepeatedField<T>)(object)other.areaDataList_).Clone());
			RepeatedField<Types.WallData> repeatedField2 = (wallDataList_ = (RepeatedField<Types.WallData>)(object)((RepeatedField<T>)(object)other.wallDataList_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9F")]
		[Cpp2IlInjected.Address(RVA = "0x2F93910", Offset = "0x2F92310", VA = "0x182F93910", Slot = "10")]
		[DebuggerNonUserCode]
		public GridSizeQualifierData Clone()
		{
			//Discarded unreachable code: IL_005f
			GridSizeQualifierData gridSizeQualifierData = new GridSizeQualifierData();
			RepeatedField<Types.AreaData> repeatedField = (gridSizeQualifierData.areaDataList_ = (RepeatedField<Types.AreaData>)(object)new RepeatedField<T>());
			RepeatedField<Types.WallData> repeatedField2 = (gridSizeQualifierData.wallDataList_ = (RepeatedField<Types.WallData>)(object)new RepeatedField<T>());
			RepeatedField<Types.AreaData> repeatedField3 = (gridSizeQualifierData.areaDataList_ = (RepeatedField<Types.AreaData>)(object)((RepeatedField<T>)(object)areaDataList_).Clone());
			RepeatedField<Types.WallData> repeatedField4 = (gridSizeQualifierData.wallDataList_ = (RepeatedField<Types.WallData>)(object)((RepeatedField<T>)(object)wallDataList_).Clone());
			UnknownFieldSet unknownFieldSet = (gridSizeQualifierData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridSizeQualifierData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA2")]
		[Cpp2IlInjected.Address(RVA = "0x2F93B80", Offset = "0x2F92580", VA = "0x182F93B80", Slot = "0")]
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
				RepeatedField<Types.AreaData> repeatedField = areaDataList_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<Types.WallData> repeatedField2 = wallDataList_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA3")]
		[Cpp2IlInjected.Address(RVA = "0x2F93AC0", Offset = "0x2F924C0", VA = "0x182F93AC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridSizeQualifierData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.AreaData> repeatedField = areaDataList_;
				RepeatedField<Types.AreaData> repeatedField2 = other.areaDataList_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<Types.WallData> repeatedField3 = wallDataList_;
					RepeatedField<Types.WallData> repeatedField4 = other.wallDataList_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA4")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)areaDataList_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)wallDataList_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA5")]
		[Cpp2IlInjected.Address(RVA = "0x2F93FC0", Offset = "0x2F929C0", VA = "0x182F93FC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA6")]
		[Cpp2IlInjected.Address(RVA = "0x2F94020", Offset = "0x2F92A20", VA = "0x182F94020", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<Types.AreaData> repeatedField = areaDataList_;
			FieldCodec<Types.AreaData> repeated_areaDataList_codec = _repeated_areaDataList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_areaDataList_codec);
			RepeatedField<Types.WallData> repeatedField2 = wallDataList_;
			FieldCodec<Types.WallData> repeated_wallDataList_codec = _repeated_wallDataList_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_wallDataList_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA7")]
		[Cpp2IlInjected.Address(RVA = "0x2F937B0", Offset = "0x2F921B0", VA = "0x182F937B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<Types.AreaData> repeatedField = areaDataList_;
			FieldCodec<Types.AreaData> repeated_areaDataList_codec = _repeated_areaDataList_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_areaDataList_codec);
			RepeatedField<Types.WallData> repeatedField2 = wallDataList_;
			FieldCodec<Types.WallData> repeated_wallDataList_codec = _repeated_wallDataList_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_wallDataList_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.AreaData>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA8")]
		[Cpp2IlInjected.Address(RVA = "0x2F93E70", Offset = "0x2F92870", VA = "0x182F93E70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridSizeQualifierData other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<Types.AreaData> repeatedField = areaDataList_;
				RepeatedField<Types.AreaData> repeatedField2 = other.areaDataList_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.WallData> repeatedField3 = wallDataList_;
				RepeatedField<Types.WallData> repeatedField4 = other.wallDataList_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA9")]
		[Cpp2IlInjected.Address(RVA = "0x2F93D10", Offset = "0x2F92710", VA = "0x182F93D10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.AreaData> repeatedField = areaDataList_;
					FieldCodec<Types.AreaData> repeated_areaDataList_codec = _repeated_areaDataList_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areaDataList_codec);
				}
				if (num == 18)
				{
					RepeatedField<Types.WallData> repeatedField2 = wallDataList_;
					FieldCodec<Types.WallData> repeated_wallDataList_codec = _repeated_wallDataList_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_wallDataList_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F93C80", Offset = "0x2F92680", VA = "0x182F93C80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.AreaData> repeatedField = areaDataList_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.WallData> repeatedField2 = wallDataList_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAB")]
		[Cpp2IlInjected.Address(RVA = "0x2F93F10", Offset = "0x2F92910", VA = "0x182F93F10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAC")]
		[Cpp2IlInjected.Address(RVA = "0x2F938A0", Offset = "0x2F922A0", VA = "0x182F938A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.WallData> repeatedField = wallDataList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAD")]
		[Cpp2IlInjected.Address(RVA = "0x2F94110", Offset = "0x2F92B10", VA = "0x182F94110")]
		static GridSizeQualifierData()
		{
			Func<GridSizeQualifierData> func = default(Func<GridSizeQualifierData>);
			_parser = (MessageParser<GridSizeQualifierData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.AreaData> parser = Types.AreaData._parser;
			uint num = default(uint);
			_parser = (MessageParser<GridSizeQualifierData>)(object)FieldCodec.ForMessage<Types.AreaData>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.WallData> parser2 = Types.WallData._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<GridSizeQualifierData>)(object)FieldCodec.ForMessage<Types.WallData>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
