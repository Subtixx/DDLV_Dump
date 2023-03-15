using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	public sealed class AvatarCustomization : IMessage<AvatarCustomization>, IMessage, IEquatable<AvatarCustomization>, IDeepCloneable<AvatarCustomization>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200019C")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000596")]
				[OriginalName("ClothingNotInInventory")]
				ClothingNotInInventory,
				[Cpp2IlInjected.Token(Token = "0x4000597")]
				[OriginalName("NotAdequatelyDressed")]
				NotAdequatelyDressed,
				[Cpp2IlInjected.Token(Token = "0x4000598")]
				[OriginalName("MakeupNotInInventory")]
				MakeupNotInInventory
			}

			[Cpp2IlInjected.Token(Token = "0x200019D")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public const int FemaleFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059C")]
				private Avatar female_;

				[Cpp2IlInjected.Token(Token = "0x400059D")]
				public const int MaleFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400059E")]
				private Avatar male_;

				[Cpp2IlInjected.Token(Token = "0x400059F")]
				public const int IsMaleFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005A0")]
				private bool isMale_;

				[Cpp2IlInjected.Token(Token = "0x17000309")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001153")]
					[Cpp2IlInjected.Address(RVA = "0x272B610", Offset = "0x272A010", VA = "0x18272B610")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700030A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001154")]
					[Cpp2IlInjected.Address(RVA = "0x272AE10", Offset = "0x2729810", VA = "0x18272AE10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700030B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001155")]
					[Cpp2IlInjected.Address(RVA = "0x272BB50", Offset = "0x272A550", VA = "0x18272BB50", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700030C")]
				[DebuggerNonUserCode]
				public Avatar Female
				{
					[Cpp2IlInjected.Token(Token = "0x6001159")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600115A")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700030D")]
				[DebuggerNonUserCode]
				public Avatar Male
				{
					[Cpp2IlInjected.Token(Token = "0x600115B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600115C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700030E")]
				[DebuggerNonUserCode]
				public bool IsMale
				{
					[Cpp2IlInjected.Token(Token = "0x600115D")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600115E")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001156")]
				[Cpp2IlInjected.Address(RVA = "0x272A7E0", Offset = "0x27291E0", VA = "0x18272A7E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001157")]
				[Cpp2IlInjected.Address(RVA = "0x272A880", Offset = "0x2729280", VA = "0x18272A880")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001158")]
				[Cpp2IlInjected.Address(RVA = "0x2725680", Offset = "0x2724080", VA = "0x182725680", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600115F")]
				[Cpp2IlInjected.Address(RVA = "0x2725BD0", Offset = "0x27245D0", VA = "0x182725BD0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001160")]
				[Cpp2IlInjected.Address(RVA = "0x2725FC0", Offset = "0x27249C0", VA = "0x182725FC0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001161")]
				[Cpp2IlInjected.Address(RVA = "0x2726AC0", Offset = "0x27254C0", VA = "0x182726AC0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001162")]
				[Cpp2IlInjected.Address(RVA = "0x27284A0", Offset = "0x2726EA0", VA = "0x1827284A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001163")]
				[Cpp2IlInjected.Address(RVA = "0x27294F0", Offset = "0x2727EF0", VA = "0x1827294F0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001164")]
				[Cpp2IlInjected.Address(RVA = "0x2724CA0", Offset = "0x27236A0", VA = "0x182724CA0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001165")]
				[Cpp2IlInjected.Address(RVA = "0x2727260", Offset = "0x2725C60", VA = "0x182727260", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001166")]
				[Cpp2IlInjected.Address(RVA = "0x2727600", Offset = "0x2726000", VA = "0x182727600", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001167")]
				[Cpp2IlInjected.Address(RVA = "0x2726900", Offset = "0x2725300", VA = "0x182726900", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001168")]
				[Cpp2IlInjected.Address(RVA = "0x2727E90", Offset = "0x2726890", VA = "0x182727E90", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001169")]
				[Cpp2IlInjected.Address(RVA = "0x2724D80", Offset = "0x2723780", VA = "0x182724D80", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600116A")]
				[Cpp2IlInjected.Address(RVA = "0x27285C0", Offset = "0x2726FC0", VA = "0x1827285C0")]
				public static Result ValidateAvatar(Avatar avatar, ProfilePlayer profilePlayer)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x600116B")]
				[Cpp2IlInjected.Address(RVA = "0x27292B0", Offset = "0x2727CB0", VA = "0x1827292B0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200019F")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40005A2")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40005A3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40005A4")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40005A5")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40005A6")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005A7")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700030F")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001170")]
					[Cpp2IlInjected.Address(RVA = "0x2735D50", Offset = "0x2734750", VA = "0x182735D50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000310")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001171")]
					[Cpp2IlInjected.Address(RVA = "0x27357B0", Offset = "0x27341B0", VA = "0x1827357B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000311")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001172")]
					[Cpp2IlInjected.Address(RVA = "0x2736170", Offset = "0x2734B70", VA = "0x182736170", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000312")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001176")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001177")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000313")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001178")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001179")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000314")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001185")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001186")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001173")]
				[Cpp2IlInjected.Address(RVA = "0x2734D70", Offset = "0x2733770", VA = "0x182734D70")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001174")]
				[Cpp2IlInjected.Address(RVA = "0x27352B0", Offset = "0x2733CB0", VA = "0x1827352B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001175")]
				[Cpp2IlInjected.Address(RVA = "0x272FD00", Offset = "0x272E700", VA = "0x18272FD00", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600117A")]
				[Cpp2IlInjected.Address(RVA = "0x2730740", Offset = "0x272F140", VA = "0x182730740", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600117B")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600117C")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600117D")]
				[Cpp2IlInjected.Address(RVA = "0x2733B40", Offset = "0x2732540", VA = "0x182733B40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600117E")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600117F")]
				[Cpp2IlInjected.Address(RVA = "0x272F170", Offset = "0x272DB70", VA = "0x18272F170", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001180")]
				[Cpp2IlInjected.Address(RVA = "0x2732BD0", Offset = "0x27315D0", VA = "0x182732BD0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001181")]
				[Cpp2IlInjected.Address(RVA = "0x2731AF0", Offset = "0x27304F0", VA = "0x182731AF0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001182")]
				[Cpp2IlInjected.Address(RVA = "0x2730EB0", Offset = "0x272F8B0", VA = "0x182730EB0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001183")]
				[Cpp2IlInjected.Address(RVA = "0x2733060", Offset = "0x2731A60", VA = "0x182733060", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001184")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001187")]
				[Cpp2IlInjected.Address(RVA = "0x272E930", Offset = "0x272D330", VA = "0x18272E930", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001188")]
				[Cpp2IlInjected.Address(RVA = "0x2731120", Offset = "0x272FB20", VA = "0x182731120")]
				private (List<ClothingInfo>, List<Item>) GetNewEquippedItems(Request request, ProfilePlayer profilePlayer)
				{
					return default((List<ClothingInfo>, List<Item>));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private static readonly MessageParser<AvatarCustomization> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarCustomization> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001141")]
			[Cpp2IlInjected.Address(RVA = "0x1AABE10", Offset = "0x1AAA810", VA = "0x181AABE10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001142")]
			[Cpp2IlInjected.Address(RVA = "0x1AABD40", Offset = "0x1AAA740", VA = "0x181AABD40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001143")]
			[Cpp2IlInjected.Address(RVA = "0x1AABE70", Offset = "0x1AAA870", VA = "0x181AABE70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001144")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AvatarCustomization()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001145")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public AvatarCustomization(AvatarCustomization other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001146")]
		[Cpp2IlInjected.Address(RVA = "0x1AABA60", Offset = "0x1AAA460", VA = "0x181AABA60", Slot = "10")]
		[DebuggerNonUserCode]
		public AvatarCustomization Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			AvatarCustomization avatarCustomization = default(AvatarCustomization);
			avatarCustomization.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (avatarCustomization._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return avatarCustomization;
		}

		[Cpp2IlInjected.Token(Token = "0x6001147")]
		[Cpp2IlInjected.Address(RVA = "0x1AABAE0", Offset = "0x1AAA4E0", VA = "0x181AABAE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001148")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarCustomization other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001149")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600114A")]
		[Cpp2IlInjected.Address(RVA = "0x1AABBD0", Offset = "0x1AAA5D0", VA = "0x181AABBD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600114B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600114C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600114D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarCustomization other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600114E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600114F")]
		[Cpp2IlInjected.Address(RVA = "0x1AABB60", Offset = "0x1AAA560", VA = "0x181AABB60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001150")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001151")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001152")]
		[Cpp2IlInjected.Address(RVA = "0x1AABC30", Offset = "0x1AAA630", VA = "0x181AABC30")]
		static AvatarCustomization()
		{
			Func<AvatarCustomization> func = default(Func<AvatarCustomization>);
			_parser = (MessageParser<AvatarCustomization>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
