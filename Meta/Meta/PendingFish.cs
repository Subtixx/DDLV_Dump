using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000875")]
	public sealed class PendingFish : IMessage<PendingFish>, IMessage, IEquatable<PendingFish>, IDeepCloneable<PendingFish>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40021F2")]
		private static readonly MessageParser<PendingFish> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40021F3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40021F4")]
		public const int RarityFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021F5")]
		private FishRippleRarity rarity_;

		[Cpp2IlInjected.Token(Token = "0x40021F6")]
		public const int LocationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021F7")]
		private ActivityDataLocationFilter location_;

		[Cpp2IlInjected.Token(Token = "0x40021F8")]
		public const int ForcedFishingDataItemIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40021F9")]
		private int forcedFishingDataItemID_;

		[Cpp2IlInjected.Token(Token = "0x40021FA")]
		public const int MassFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40021FB")]
		private static readonly FieldCodec<float?> _single_mass_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40021FC")]
		private float? mass_;

		[Cpp2IlInjected.Token(Token = "0x40021FD")]
		public const int IsSpecificFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40021FE")]
		private bool isSpecific_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40021FF")]
		private int fishingDataItemID;

		[Cpp2IlInjected.Token(Token = "0x17000BC3")]
		[DebuggerNonUserCode]
		public static MessageParser<PendingFish> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004730")]
			[Cpp2IlInjected.Address(RVA = "0x13AD1E0", Offset = "0x13ABBE0", VA = "0x1813AD1E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004731")]
			[Cpp2IlInjected.Address(RVA = "0x13AD040", Offset = "0x13ABA40", VA = "0x1813AD040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004732")]
			[Cpp2IlInjected.Address(RVA = "0x13AD240", Offset = "0x13ABC40", VA = "0x1813AD240", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC6")]
		[DebuggerNonUserCode]
		public FishRippleRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6004736")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004737")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC7")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter Location
		{
			[Cpp2IlInjected.Token(Token = "0x6004738")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004739")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC8")]
		[DebuggerNonUserCode]
		public int ForcedFishingDataItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600473A")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return forcedFishingDataItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600473B")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				forcedFishingDataItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BC9")]
		[DebuggerNonUserCode]
		public float? Mass
		{
			[Cpp2IlInjected.Token(Token = "0x600473C")]
			[Cpp2IlInjected.Address(RVA = "0x13AD1D0", Offset = "0x13ABBD0", VA = "0x1813AD1D0")]
			get
			{
				return mass_;
			}
			[Cpp2IlInjected.Token(Token = "0x600473D")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			set
			{
				mass_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCA")]
		[DebuggerNonUserCode]
		public bool IsSpecific
		{
			[Cpp2IlInjected.Token(Token = "0x600473E")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
			get
			{
				return isSpecific_;
			}
			[Cpp2IlInjected.Token(Token = "0x600473F")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
			set
			{
				isSpecific_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCB")]
		public Item FishingDataItem
		{
			[Cpp2IlInjected.Token(Token = "0x600474B")]
			[Cpp2IlInjected.Address(RVA = "0x13AD110", Offset = "0x13ABB10", VA = "0x1813AD110")]
			get
			{
				long num = Convert.ToInt64((uint)fishingDataItemID);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600474C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				//IL_0007: Expected I4, but got O
				fishingDataItemID = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCC")]
		public Item ForcedFishingDataItem
		{
			[Cpp2IlInjected.Token(Token = "0x600474D")]
			[Cpp2IlInjected.Address(RVA = "0x13AD170", Offset = "0x13ABB70", VA = "0x1813AD170")]
			get
			{
				long num = Convert.ToInt64((uint)forcedFishingDataItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BCD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4002200")]
		public bool Buffed
		{
			[Cpp2IlInjected.Token(Token = "0x600474E")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600474F")]
			[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x6004733")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PendingFish()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004734")]
		[Cpp2IlInjected.Address(RVA = "0x13ACFB0", Offset = "0x13AB9B0", VA = "0x1813ACFB0")]
		[DebuggerNonUserCode]
		public PendingFish(PendingFish other)
		{
			//IL_002f: Expected O, but got I4
			FishRippleRarity fishRippleRarity = (rarity_ = other.rarity_);
			ActivityDataLocationFilter activityDataLocationFilter = other.location_;
			if (activityDataLocationFilter != null)
			{
				ActivityDataLocationFilter activityDataLocationFilter2 = activityDataLocationFilter.Clone();
			}
			int num = 0;
			location_ = (ActivityDataLocationFilter)num;
			int num2 = (forcedFishingDataItemID_ = other.forcedFishingDataItemID_);
			float? num3 = (mass_ = other.mass_);
			bool flag = (isSpecific_ = other.isSpecific_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004735")]
		[Cpp2IlInjected.Address(RVA = "0x13AC170", Offset = "0x13AAB70", VA = "0x1813AC170", Slot = "10")]
		[DebuggerNonUserCode]
		public PendingFish Clone()
		{
			//Discarded unreachable code: IL_0078
			//IL_0031: Expected O, but got I4
			PendingFish pendingFish = new PendingFish();
			FishRippleRarity fishRippleRarity = (pendingFish.rarity_ = rarity_);
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				ActivityDataLocationFilter activityDataLocationFilter2 = activityDataLocationFilter.Clone();
			}
			int num = 0;
			pendingFish.location_ = (ActivityDataLocationFilter)num;
			int num2 = (pendingFish.forcedFishingDataItemID_ = forcedFishingDataItemID_);
			float? num3 = (pendingFish.mass_ = mass_);
			bool flag = (pendingFish.isSpecific_ = isSpecific_);
			UnknownFieldSet unknownFieldSet = (pendingFish._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pendingFish;
		}

		[Cpp2IlInjected.Token(Token = "0x6004740")]
		[Cpp2IlInjected.Address(RVA = "0x13AC330", Offset = "0x13AAD30", VA = "0x1813AC330", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
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
				if ((IntPtr)(void*)(int)rarity_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle)
				{
					bool flag = object.Equals(location_, other);
					if (flag && forcedFishingDataItemID_ == (flag ? 1 : 0))
					{
						float? objB = mass_;
						sbyte b = default(sbyte);
						if ((isSpecific_ ? 1u : 0u) == (uint)b)
						{
							return object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004741")]
		[Cpp2IlInjected.Address(RVA = "0x13AC230", Offset = "0x13AAC30", VA = "0x1813AC230", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PendingFish other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				FishRippleRarity fishRippleRarity = other.rarity_;
				if (rarity_ == fishRippleRarity)
				{
					ActivityDataLocationFilter objB = other.location_;
					if (object.Equals(location_, objB))
					{
						int num = other.forcedFishingDataItemID_;
						if (forcedFishingDataItemID_ == num)
						{
							bool flag = other.isSpecific_;
							if (isSpecific_ == flag)
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

		[Cpp2IlInjected.Token(Token = "0x6004742")]
		[Cpp2IlInjected.Address(RVA = "0x13AC5C0", Offset = "0x13AAFC0", VA = "0x1813AC5C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005f
			int num = 0;
			if (rarity_ != 0)
			{
			}
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				int hashCode = activityDataLocationFilter.GetHashCode();
			}
			if (forcedFishingDataItemID_ != 0)
			{
			}
			EqualityComparer<float?> _003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer;
			float? obj = mass_;
			int hashCode2 = ((EqualityComparer<T>)(object)_003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)obj);
			if (isSpecific_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004743")]
		[Cpp2IlInjected.Address(RVA = "0x13ACC90", Offset = "0x13AB690", VA = "0x1813ACC90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004744")]
		[Cpp2IlInjected.Address(RVA = "0x13ACCF0", Offset = "0x13AB6F0", VA = "0x1813ACCF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007d
			if (rarity_ != 0)
			{
			}
			if ((long)location_ != 0)
			{
				ActivityDataLocationFilter value = location_;
				output.WriteMessage(value);
			}
			if (forcedFishingDataItemID_ != 0)
			{
				int value2 = forcedFishingDataItemID_;
				output.WriteInt32(value2);
			}
			FieldCodec<float?> single_mass_codec = _single_mass_codec;
			float? value3 = mass_;
			((FieldCodec<T>)(object)single_mass_codec).WriteTagAndValue(output, (T)value3);
			if (isSpecific_)
			{
				bool value4 = isSpecific_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004745")]
		[Cpp2IlInjected.Address(RVA = "0x13ABFB0", Offset = "0x13AA9B0", VA = "0x1813ABFB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008f
			FishRippleRarity fishRippleRarity = rarity_;
			int num = 0;
			if (fishRippleRarity != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)fishRippleRarity);
			}
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(activityDataLocationFilter);
				num3++;
				num += num3;
			}
			int num4 = forcedFishingDataItemID_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			FieldCodec<float?> single_mass_codec = _single_mass_codec;
			float? value = mass_;
			int num6 = ((FieldCodec<T>)(object)single_mass_codec).CalculateSizeWithTag((T)value);
			num += num6;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004746")]
		[Cpp2IlInjected.Address(RVA = "0x13AC740", Offset = "0x13AB140", VA = "0x1813AC740", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PendingFish other)
		{
			//Discarded unreachable code: IL_00b6
			if (other == null)
			{
				return;
			}
			FishRippleRarity fishRippleRarity = other.rarity_;
			if (fishRippleRarity != 0)
			{
				rarity_ = fishRippleRarity;
			}
			if ((long)other.location_ != 0)
			{
				ActivityDataLocationFilter activityDataLocationFilter2 = default(ActivityDataLocationFilter);
				if (location_ == null)
				{
					ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
					activityDataLocationFilter2 = location_;
				}
				ActivityDataLocationFilter other2 = other.location_;
				activityDataLocationFilter2.MergeFrom(other2);
			}
			int num = other.forcedFishingDataItemID_;
			if (num != 0)
			{
				forcedFishingDataItemID_ = num;
			}
			float? num2 = other.mass_;
			if ((IntPtr)0 == (IntPtr)num2)
			{
				float? num3 = (mass_ = other.mass_);
			}
			bool flag = other.isSpecific_;
			if (flag)
			{
				isSpecific_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004747")]
		[Cpp2IlInjected.Address(RVA = "0x13AC890", Offset = "0x13AB290", VA = "0x1813AC890", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b5
			float? num3 = default(float?);
			int num4 = default(int);
			ActivityDataLocationFilter builder = default(ActivityDataLocationFilter);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((int)num > 18)
				{
					if (num == 24)
					{
						int num2 = (forcedFishingDataItemID_ = input.ReadInt32());
					}
					if (num == 34)
					{
						num3 = (float?)((FieldCodec<T>)(object)_single_mass_codec).Read(input);
						if ((IntPtr)0 != (IntPtr)num3)
						{
							continue;
						}
						mass_ = num3;
					}
					if ((long)num3 != 40)
					{
						goto IL_009e;
					}
					bool flag = (isSpecific_ = input.ReadBool());
				}
				if (num == 8)
				{
					num4 = (int)(rarity_ = (FishRippleRarity)input.ReadInt32());
				}
				if (num4 == 18)
				{
					if (location_ == null)
					{
						ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
						builder = location_;
					}
					input.ReadMessage(builder);
				}
				goto IL_009e;
				IL_009e:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004748")]
		[Cpp2IlInjected.Address(RVA = "0x13AC470", Offset = "0x13AAE70", VA = "0x1813AC470", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0035;
						}
						bool flag = isSpecific_;
					}
					float? num2 = mass_;
				}
				ActivityDataLocationFilter activityDataLocationFilter = location_;
			}
			FishRippleRarity fishRippleRarity = rarity_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004749")]
		[Cpp2IlInjected.Address(RVA = "0x13ACA90", Offset = "0x13AB490", VA = "0x1813ACA90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_004c
			//IL_001f: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0033: Expected I4, but got O
			//IL_004b: Expected I4, but got O
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
						{
							object obj = default(object);
							isSpecific_ = (byte)(int)obj != 0;
							break;
						}
						case 0:
							if (value != null)
							{
							}
							mass_ = (float?)(object)0;
							break;
						}
					}
					else
					{
						object obj2 = default(object);
						forcedFishingDataItemID_ = (int)obj2;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					location_ = (ActivityDataLocationFilter)value;
				}
			}
			else
			{
				object obj3 = default(object);
				rarity_ = (FishRippleRarity)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600474A")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AAB20", VA = "0x1813AC120", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected O, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				isSpecific_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004750")]
		[Cpp2IlInjected.Address(RVA = "0x13ACE60", Offset = "0x13AB860", VA = "0x1813ACE60")]
		static PendingFish()
		{
			Func<PendingFish> func = default(Func<PendingFish>);
			_parser = (MessageParser<PendingFish>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<PendingFish>)(object)FieldCodec.ForStructWrapper<float>(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
