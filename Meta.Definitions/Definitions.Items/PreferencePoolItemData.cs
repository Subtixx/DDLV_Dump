using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000344")]
	public sealed class PreferencePoolItemData : IMessage<PreferencePoolItemData>, IMessage, IEquatable<PreferencePoolItemData>, IDeepCloneable<PreferencePoolItemData>, IMessageFieldAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x2000345")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000346")]
			public sealed class FavoriteMeal : IMessage<FavoriteMeal>, IMessage, IEquatable<FavoriteMeal>, IDeepCloneable<FavoriteMeal>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000347")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000348")]
					public sealed class MealProperties : IMessage<MealProperties>, IMessage, IEquatable<MealProperties>, IDeepCloneable<MealProperties>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x40010D7")]
						private static readonly MessageParser<MealProperties> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x40010D8")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x40010D9")]
						public const int SpecificItemsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x40010DA")]
						private static readonly FieldCodec<int> _repeated_specificItems_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x40010DB")]
						private readonly RepeatedField<int> specificItems_;

						[Cpp2IlInjected.Token(Token = "0x40010DC")]
						public const int MealTypeFieldNumber = 2;

						[Cpp2IlInjected.Token(Token = "0x40010DD")]
						private static readonly FieldCodec<int> _repeated_mealType_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x40010DE")]
						private readonly RepeatedField<int> mealType_;

						[Cpp2IlInjected.Token(Token = "0x40010DF")]
						public const int ContainsIngredientsFieldNumber = 3;

						[Cpp2IlInjected.Token(Token = "0x40010E0")]
						private static readonly FieldCodec<int> _repeated_containsIngredients_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
						[Cpp2IlInjected.Token(Token = "0x40010E1")]
						private readonly RepeatedField<int> containsIngredients_;

						[Cpp2IlInjected.Token(Token = "0x1700097A")]
						[DebuggerNonUserCode]
						public static MessageParser<MealProperties> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x600265E")]
							[Cpp2IlInjected.Address(RVA = "0x3F9AC40", Offset = "0x3F99640", VA = "0x183F9AC40")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700097B")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x600265F")]
							[Cpp2IlInjected.Address(RVA = "0x3F9ABC0", Offset = "0x3F995C0", VA = "0x183F9ABC0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700097C")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002660")]
							[Cpp2IlInjected.Address(RVA = "0x3F9ACA0", Offset = "0x3F996A0", VA = "0x183F9ACA0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700097D")]
						[DebuggerNonUserCode]
						public RepeatedField<int> SpecificItems
						{
							[Cpp2IlInjected.Token(Token = "0x6002664")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700097E")]
						[DebuggerNonUserCode]
						public RepeatedField<int> MealType
						{
							[Cpp2IlInjected.Token(Token = "0x6002665")]
							[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700097F")]
						[DebuggerNonUserCode]
						public RepeatedField<int> ContainsIngredients
						{
							[Cpp2IlInjected.Token(Token = "0x6002666")]
							[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002661")]
						[Cpp2IlInjected.Address(RVA = "0x3F9AA10", Offset = "0x3F99410", VA = "0x183F9AA10")]
						[DebuggerNonUserCode]
						public MealProperties()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002662")]
						[Cpp2IlInjected.Address(RVA = "0x3F9AAE0", Offset = "0x3F994E0", VA = "0x183F9AAE0")]
						[DebuggerNonUserCode]
						public MealProperties(MealProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002663")]
						[Cpp2IlInjected.Address(RVA = "0x3F99FF0", Offset = "0x3F989F0", VA = "0x183F99FF0", Slot = "10")]
						[DebuggerNonUserCode]
						public MealProperties Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002667")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A100", Offset = "0x3F98B00", VA = "0x183F9A100", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002668")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A220", Offset = "0x3F98C20", VA = "0x183F9A220", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(MealProperties other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002669")]
						[Cpp2IlInjected.Address(RVA = "0x13A9490", Offset = "0x13A7E90", VA = "0x1813A9490", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600266A")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A710", Offset = "0x3F99110", VA = "0x183F9A710", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600266B")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A770", Offset = "0x3F99170", VA = "0x183F9A770", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600266C")]
						[Cpp2IlInjected.Address(RVA = "0x3F99E60", Offset = "0x3F98860", VA = "0x183F99E60", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600266D")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A560", Offset = "0x3F98F60", VA = "0x183F9A560", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(MealProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600266E")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A390", Offset = "0x3F98D90", VA = "0x183F9A390", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600266F")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A2F0", Offset = "0x3F98CF0", VA = "0x183F9A2F0", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002670")]
						[Cpp2IlInjected.Address(RVA = "0x3F9A610", Offset = "0x3F99010", VA = "0x183F9A610", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002671")]
						[Cpp2IlInjected.Address(RVA = "0x3F99F70", Offset = "0x3F98970", VA = "0x183F99F70", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x200034A")]
					public sealed class InclusionsMeal : IMessage<InclusionsMeal>, IMessage, IEquatable<InclusionsMeal>, IDeepCloneable<InclusionsMeal>, IMessageFieldAccessor, IMessageOneofAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x200034B")]
						public enum InclusionTypeOneofCase
						{
							[Cpp2IlInjected.Token(Token = "0x40010EA")]
							None,
							[Cpp2IlInjected.Token(Token = "0x40010EB")]
							All,
							[Cpp2IlInjected.Token(Token = "0x40010EC")]
							Custom
						}

						[Cpp2IlInjected.Token(Token = "0x40010E3")]
						private static readonly MessageParser<InclusionsMeal> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x40010E4")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x40010E5")]
						public const int AllFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x40010E6")]
						public const int CustomFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x40010E7")]
						private object inclusionType_;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x40010E8")]
						private InclusionTypeOneofCase inclusionTypeCase_;

						[Cpp2IlInjected.Token(Token = "0x17000980")]
						[DebuggerNonUserCode]
						public static MessageParser<InclusionsMeal> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x6002676")]
							[Cpp2IlInjected.Address(RVA = "0x3F97AA0", Offset = "0x3F964A0", VA = "0x183F97AA0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000981")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002677")]
							[Cpp2IlInjected.Address(RVA = "0x3F97A20", Offset = "0x3F96420", VA = "0x183F97A20")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000982")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002678")]
							[Cpp2IlInjected.Address(RVA = "0x3F97B00", Offset = "0x3F96500", VA = "0x183F97B00", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000983")]
						[DebuggerNonUserCode]
						public Empty All
						{
							[Cpp2IlInjected.Token(Token = "0x600267C")]
							[Cpp2IlInjected.Address(RVA = "0x3F97960", Offset = "0x3F96360", VA = "0x183F97960")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x600267D")]
							[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000984")]
						[DebuggerNonUserCode]
						public MealProperties Custom
						{
							[Cpp2IlInjected.Token(Token = "0x600267E")]
							[Cpp2IlInjected.Address(RVA = "0x3F979C0", Offset = "0x3F963C0", VA = "0x183F979C0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x600267F")]
							[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000985")]
						[DebuggerNonUserCode]
						public InclusionTypeOneofCase InclusionTypeCase
						{
							[Cpp2IlInjected.Token(Token = "0x6002680")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(InclusionTypeOneofCase);
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002679")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public InclusionsMeal()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600267A")]
						[Cpp2IlInjected.Address(RVA = "0x3F97720", Offset = "0x3F96120", VA = "0x183F97720")]
						[DebuggerNonUserCode]
						public InclusionsMeal(InclusionsMeal other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600267B")]
						[Cpp2IlInjected.Address(RVA = "0x3F96950", Offset = "0x3F95350", VA = "0x183F96950", Slot = "10")]
						[DebuggerNonUserCode]
						public InclusionsMeal Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002681")]
						[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
						[DebuggerNonUserCode]
						public void ClearInclusionType()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002682")]
						[Cpp2IlInjected.Address(RVA = "0x3F96AE0", Offset = "0x3F954E0", VA = "0x183F96AE0", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002683")]
						[Cpp2IlInjected.Address(RVA = "0x3F969B0", Offset = "0x3F953B0", VA = "0x183F969B0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(InclusionsMeal other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002684")]
						[Cpp2IlInjected.Address(RVA = "0x3F96D60", Offset = "0x3F95760", VA = "0x183F96D60", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002685")]
						[Cpp2IlInjected.Address(RVA = "0x3F97480", Offset = "0x3F95E80", VA = "0x183F97480", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002686")]
						[Cpp2IlInjected.Address(RVA = "0x3F974E0", Offset = "0x3F95EE0", VA = "0x183F974E0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002687")]
						[Cpp2IlInjected.Address(RVA = "0x3F96790", Offset = "0x3F95190", VA = "0x183F96790", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002688")]
						[Cpp2IlInjected.Address(RVA = "0x3F96F40", Offset = "0x3F95940", VA = "0x183F96F40", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(InclusionsMeal other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002689")]
						[Cpp2IlInjected.Address(RVA = "0x3F97190", Offset = "0x3F95B90", VA = "0x183F97190", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600268A")]
						[Cpp2IlInjected.Address(RVA = "0x3F96C50", Offset = "0x3F95650", VA = "0x183F96C50", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600268B")]
						[Cpp2IlInjected.Address(RVA = "0x3F97390", Offset = "0x3F95D90", VA = "0x183F97390", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600268C")]
						[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600268D")]
						[Cpp2IlInjected.Address(RVA = "0x3F96E90", Offset = "0x3F95890", VA = "0x183F96E90", Slot = "14")]
						[DebuggerNonUserCode]
						public int GetOneofCase(string oneofName)
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600268E")]
						[Cpp2IlInjected.Address(RVA = "0x3F968E0", Offset = "0x3F952E0", VA = "0x183F968E0", Slot = "15")]
						[DebuggerNonUserCode]
						public void ClearOneOf(string oneofName)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x40010D1")]
				private static readonly MessageParser<FavoriteMeal> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40010D2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40010D3")]
				public const int InclusionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40010D4")]
				private Types.InclusionsMeal inclusions_;

				[Cpp2IlInjected.Token(Token = "0x40010D5")]
				public const int ExclusionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40010D6")]
				private Types.MealProperties exclusions_;

				[Cpp2IlInjected.Token(Token = "0x17000975")]
				[DebuggerNonUserCode]
				public static MessageParser<FavoriteMeal> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002647")]
					[Cpp2IlInjected.Address(RVA = "0x2FEDD60", Offset = "0x2FEC760", VA = "0x182FEDD60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000976")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002648")]
					[Cpp2IlInjected.Address(RVA = "0x2FEDCE0", Offset = "0x2FEC6E0", VA = "0x182FEDCE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000977")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002649")]
					[Cpp2IlInjected.Address(RVA = "0x2FEDDC0", Offset = "0x2FEC7C0", VA = "0x182FEDDC0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000978")]
				[DebuggerNonUserCode]
				public Types.InclusionsMeal Inclusions
				{
					[Cpp2IlInjected.Token(Token = "0x600264E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600264F")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000979")]
				[DebuggerNonUserCode]
				public Types.MealProperties Exclusions
				{
					[Cpp2IlInjected.Token(Token = "0x6002650")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002651")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600264A")]
				[Cpp2IlInjected.Address(RVA = "0x2FEDB10", Offset = "0x2FEC510", VA = "0x182FEDB10")]
				[DebuggerNonUserCode]
				public FavoriteMeal()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600264B")]
				[Cpp2IlInjected.Address(RVA = "0x2FED850", Offset = "0x2FEC250", VA = "0x182FED850")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600264C")]
				[Cpp2IlInjected.Address(RVA = "0x2FEDBB0", Offset = "0x2FEC5B0", VA = "0x182FEDBB0")]
				[DebuggerNonUserCode]
				public FavoriteMeal(FavoriteMeal other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600264D")]
				[Cpp2IlInjected.Address(RVA = "0x2FED330", Offset = "0x2FEBD30", VA = "0x182FED330", Slot = "10")]
				[DebuggerNonUserCode]
				public FavoriteMeal Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002652")]
				[Cpp2IlInjected.Address(RVA = "0x2FED490", Offset = "0x2FEBE90", VA = "0x182FED490", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002653")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FavoriteMeal other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002654")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002655")]
				[Cpp2IlInjected.Address(RVA = "0x2FED9A0", Offset = "0x2FEC3A0", VA = "0x182FED9A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002656")]
				[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002657")]
				[Cpp2IlInjected.Address(RVA = "0x2FED260", Offset = "0x2FEBC60", VA = "0x182FED260", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002658")]
				[Cpp2IlInjected.Address(RVA = "0x2FED5E0", Offset = "0x2FEBFE0", VA = "0x182FED5E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FavoriteMeal other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002659")]
				[Cpp2IlInjected.Address(RVA = "0x2FED710", Offset = "0x2FEC110", VA = "0x182FED710", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600265A")]
				[Cpp2IlInjected.Address(RVA = "0x2FED550", Offset = "0x2FEBF50", VA = "0x182FED550", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600265B")]
				[Cpp2IlInjected.Address(RVA = "0x2FED8E0", Offset = "0x2FEC2E0", VA = "0x182FED8E0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600265C")]
				[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200034E")]
			public sealed class FavoriteIngredient : IMessage<FavoriteIngredient>, IMessage, IEquatable<FavoriteIngredient>, IDeepCloneable<FavoriteIngredient>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200034F")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000350")]
					public sealed class IngredientProperties : IMessage<IngredientProperties>, IMessage, IEquatable<IngredientProperties>, IDeepCloneable<IngredientProperties>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x40010F5")]
						private static readonly MessageParser<IngredientProperties> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x40010F6")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x40010F7")]
						public const int SpecificItemsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x40010F8")]
						private static readonly FieldCodec<int> _repeated_specificItems_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x40010F9")]
						private readonly RepeatedField<int> specificItems_;

						[Cpp2IlInjected.Token(Token = "0x40010FA")]
						public const int IngredientTypeFieldNumber = 2;

						[Cpp2IlInjected.Token(Token = "0x40010FB")]
						private static readonly FieldCodec<int> _repeated_ingredientType_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x40010FC")]
						private readonly RepeatedField<int> ingredientType_;

						[Cpp2IlInjected.Token(Token = "0x40010FD")]
						public const int IngredientTagsFieldNumber = 3;

						[Cpp2IlInjected.Token(Token = "0x40010FE")]
						private static readonly FieldCodec<int> _repeated_ingredientTags_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
						[Cpp2IlInjected.Token(Token = "0x40010FF")]
						private readonly RepeatedField<int> ingredientTags_;

						[Cpp2IlInjected.Token(Token = "0x1700098B")]
						[DebuggerNonUserCode]
						public static MessageParser<IngredientProperties> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60026AD")]
							[Cpp2IlInjected.Address(RVA = "0x3F99D40", Offset = "0x3F98740", VA = "0x183F99D40")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700098C")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026AE")]
							[Cpp2IlInjected.Address(RVA = "0x3F99CC0", Offset = "0x3F986C0", VA = "0x183F99CC0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700098D")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026AF")]
							[Cpp2IlInjected.Address(RVA = "0x3F99DA0", Offset = "0x3F987A0", VA = "0x183F99DA0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700098E")]
						[DebuggerNonUserCode]
						public RepeatedField<int> SpecificItems
						{
							[Cpp2IlInjected.Token(Token = "0x60026B3")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700098F")]
						[DebuggerNonUserCode]
						public RepeatedField<int> IngredientType
						{
							[Cpp2IlInjected.Token(Token = "0x60026B4")]
							[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000990")]
						[DebuggerNonUserCode]
						public RepeatedField<int> IngredientTags
						{
							[Cpp2IlInjected.Token(Token = "0x60026B5")]
							[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60026B0")]
						[Cpp2IlInjected.Address(RVA = "0x3F99B10", Offset = "0x3F98510", VA = "0x183F99B10")]
						[DebuggerNonUserCode]
						public IngredientProperties()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026B1")]
						[Cpp2IlInjected.Address(RVA = "0x3F99BE0", Offset = "0x3F985E0", VA = "0x183F99BE0")]
						[DebuggerNonUserCode]
						public IngredientProperties(IngredientProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026B2")]
						[Cpp2IlInjected.Address(RVA = "0x3F990F0", Offset = "0x3F97AF0", VA = "0x183F990F0", Slot = "10")]
						[DebuggerNonUserCode]
						public IngredientProperties Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026B6")]
						[Cpp2IlInjected.Address(RVA = "0x3F99200", Offset = "0x3F97C00", VA = "0x183F99200", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60026B7")]
						[Cpp2IlInjected.Address(RVA = "0x3F99320", Offset = "0x3F97D20", VA = "0x183F99320", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(IngredientProperties other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60026B8")]
						[Cpp2IlInjected.Address(RVA = "0x13A9490", Offset = "0x13A7E90", VA = "0x1813A9490", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60026B9")]
						[Cpp2IlInjected.Address(RVA = "0x3F99810", Offset = "0x3F98210", VA = "0x183F99810", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026BA")]
						[Cpp2IlInjected.Address(RVA = "0x3F99870", Offset = "0x3F98270", VA = "0x183F99870", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026BB")]
						[Cpp2IlInjected.Address(RVA = "0x3F98F60", Offset = "0x3F97960", VA = "0x183F98F60", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60026BC")]
						[Cpp2IlInjected.Address(RVA = "0x3F99490", Offset = "0x3F97E90", VA = "0x183F99490", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(IngredientProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026BD")]
						[Cpp2IlInjected.Address(RVA = "0x3F99540", Offset = "0x3F97F40", VA = "0x183F99540", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026BE")]
						[Cpp2IlInjected.Address(RVA = "0x3F993F0", Offset = "0x3F97DF0", VA = "0x183F993F0", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026BF")]
						[Cpp2IlInjected.Address(RVA = "0x3F99710", Offset = "0x3F98110", VA = "0x183F99710", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026C0")]
						[Cpp2IlInjected.Address(RVA = "0x3F99070", Offset = "0x3F97A70", VA = "0x183F99070", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x2000352")]
					public sealed class InclusionsIngredient : IMessage<InclusionsIngredient>, IMessage, IEquatable<InclusionsIngredient>, IDeepCloneable<InclusionsIngredient>, IMessageFieldAccessor, IMessageOneofAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x2000353")]
						public enum InclusionTypeOneofCase
						{
							[Cpp2IlInjected.Token(Token = "0x4001108")]
							None,
							[Cpp2IlInjected.Token(Token = "0x4001109")]
							All,
							[Cpp2IlInjected.Token(Token = "0x400110A")]
							Custom
						}

						[Cpp2IlInjected.Token(Token = "0x4001101")]
						private static readonly MessageParser<InclusionsIngredient> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001102")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001103")]
						public const int AllFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x4001104")]
						public const int CustomFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001105")]
						private object inclusionType_;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001106")]
						private InclusionTypeOneofCase inclusionTypeCase_;

						[Cpp2IlInjected.Token(Token = "0x17000991")]
						[DebuggerNonUserCode]
						public static MessageParser<InclusionsIngredient> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60026C5")]
							[Cpp2IlInjected.Address(RVA = "0x3F96670", Offset = "0x3F95070", VA = "0x183F96670")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000992")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026C6")]
							[Cpp2IlInjected.Address(RVA = "0x3F965F0", Offset = "0x3F94FF0", VA = "0x183F965F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000993")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026C7")]
							[Cpp2IlInjected.Address(RVA = "0x3F966D0", Offset = "0x3F950D0", VA = "0x183F966D0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000994")]
						[DebuggerNonUserCode]
						public Empty All
						{
							[Cpp2IlInjected.Token(Token = "0x60026CB")]
							[Cpp2IlInjected.Address(RVA = "0x3F96530", Offset = "0x3F94F30", VA = "0x183F96530")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60026CC")]
							[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000995")]
						[DebuggerNonUserCode]
						public IngredientProperties Custom
						{
							[Cpp2IlInjected.Token(Token = "0x60026CD")]
							[Cpp2IlInjected.Address(RVA = "0x3F96590", Offset = "0x3F94F90", VA = "0x183F96590")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60026CE")]
							[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17000996")]
						[DebuggerNonUserCode]
						public InclusionTypeOneofCase InclusionTypeCase
						{
							[Cpp2IlInjected.Token(Token = "0x60026CF")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(InclusionTypeOneofCase);
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60026C8")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public InclusionsIngredient()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026C9")]
						[Cpp2IlInjected.Address(RVA = "0x3F962F0", Offset = "0x3F94CF0", VA = "0x183F962F0")]
						[DebuggerNonUserCode]
						public InclusionsIngredient(InclusionsIngredient other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026CA")]
						[Cpp2IlInjected.Address(RVA = "0x3F95520", Offset = "0x3F93F20", VA = "0x183F95520", Slot = "10")]
						[DebuggerNonUserCode]
						public InclusionsIngredient Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026D0")]
						[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
						[DebuggerNonUserCode]
						public void ClearInclusionType()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026D1")]
						[Cpp2IlInjected.Address(RVA = "0x3F95580", Offset = "0x3F93F80", VA = "0x183F95580", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60026D2")]
						[Cpp2IlInjected.Address(RVA = "0x3F956F0", Offset = "0x3F940F0", VA = "0x183F956F0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(InclusionsIngredient other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60026D3")]
						[Cpp2IlInjected.Address(RVA = "0x3F95930", Offset = "0x3F94330", VA = "0x183F95930", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60026D4")]
						[Cpp2IlInjected.Address(RVA = "0x3F96050", Offset = "0x3F94A50", VA = "0x183F96050", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026D5")]
						[Cpp2IlInjected.Address(RVA = "0x3F960B0", Offset = "0x3F94AB0", VA = "0x183F960B0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026D6")]
						[Cpp2IlInjected.Address(RVA = "0x3F95360", Offset = "0x3F93D60", VA = "0x183F95360", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60026D7")]
						[Cpp2IlInjected.Address(RVA = "0x3F95D10", Offset = "0x3F94710", VA = "0x183F95D10", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(InclusionsIngredient other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026D8")]
						[Cpp2IlInjected.Address(RVA = "0x3F95B10", Offset = "0x3F94510", VA = "0x183F95B10", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026D9")]
						[Cpp2IlInjected.Address(RVA = "0x3F95820", Offset = "0x3F94220", VA = "0x183F95820", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60026DA")]
						[Cpp2IlInjected.Address(RVA = "0x3F95F60", Offset = "0x3F94960", VA = "0x183F95F60", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026DB")]
						[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60026DC")]
						[Cpp2IlInjected.Address(RVA = "0x3F95A60", Offset = "0x3F94460", VA = "0x183F95A60", Slot = "14")]
						[DebuggerNonUserCode]
						public int GetOneofCase(string oneofName)
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60026DD")]
						[Cpp2IlInjected.Address(RVA = "0x3F954B0", Offset = "0x3F93EB0", VA = "0x183F954B0", Slot = "15")]
						[DebuggerNonUserCode]
						public void ClearOneOf(string oneofName)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x40010EF")]
				private static readonly MessageParser<FavoriteIngredient> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40010F0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40010F1")]
				public const int InclusionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40010F2")]
				private Types.InclusionsIngredient inclusions_;

				[Cpp2IlInjected.Token(Token = "0x40010F3")]
				public const int ExclusionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40010F4")]
				private Types.IngredientProperties exclusions_;

				[Cpp2IlInjected.Token(Token = "0x17000986")]
				[DebuggerNonUserCode]
				public static MessageParser<FavoriteIngredient> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002696")]
					[Cpp2IlInjected.Address(RVA = "0x2FED140", Offset = "0x2FEBB40", VA = "0x182FED140")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000987")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002697")]
					[Cpp2IlInjected.Address(RVA = "0x2FED0C0", Offset = "0x2FEBAC0", VA = "0x182FED0C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000988")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002698")]
					[Cpp2IlInjected.Address(RVA = "0x2FED1A0", Offset = "0x2FEBBA0", VA = "0x182FED1A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000989")]
				[DebuggerNonUserCode]
				public Types.InclusionsIngredient Inclusions
				{
					[Cpp2IlInjected.Token(Token = "0x600269D")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600269E")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700098A")]
				[DebuggerNonUserCode]
				public Types.IngredientProperties Exclusions
				{
					[Cpp2IlInjected.Token(Token = "0x600269F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026A0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002699")]
				[Cpp2IlInjected.Address(RVA = "0x2FED020", Offset = "0x2FEBA20", VA = "0x182FED020")]
				[DebuggerNonUserCode]
				public FavoriteIngredient()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600269A")]
				[Cpp2IlInjected.Address(RVA = "0x2FECC30", Offset = "0x2FEB630", VA = "0x182FECC30")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600269B")]
				[Cpp2IlInjected.Address(RVA = "0x2FECEF0", Offset = "0x2FEB8F0", VA = "0x182FECEF0")]
				[DebuggerNonUserCode]
				public FavoriteIngredient(FavoriteIngredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600269C")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC710", Offset = "0x2FEB110", VA = "0x182FEC710", Slot = "10")]
				[DebuggerNonUserCode]
				public FavoriteIngredient Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026A1")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC870", Offset = "0x2FEB270", VA = "0x182FEC870", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A2")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FavoriteIngredient other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A3")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A4")]
				[Cpp2IlInjected.Address(RVA = "0x2FECD80", Offset = "0x2FEB780", VA = "0x182FECD80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026A5")]
				[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026A6")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC640", Offset = "0x2FEB040", VA = "0x182FEC640", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A7")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC9C0", Offset = "0x2FEB3C0", VA = "0x182FEC9C0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FavoriteIngredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026A8")]
				[Cpp2IlInjected.Address(RVA = "0x2FECAF0", Offset = "0x2FEB4F0", VA = "0x182FECAF0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026A9")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC930", Offset = "0x2FEB330", VA = "0x182FEC930", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026AA")]
				[Cpp2IlInjected.Address(RVA = "0x2FECCC0", Offset = "0x2FEB6C0", VA = "0x182FECCC0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026AB")]
				[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000356")]
			public sealed class FavoriteMineral : IMessage<FavoriteMineral>, IMessage, IEquatable<FavoriteMineral>, IDeepCloneable<FavoriteMineral>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000357")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000358")]
					public sealed class InclusionsMineral : IMessage<InclusionsMineral>, IMessage, IEquatable<InclusionsMineral>, IDeepCloneable<InclusionsMineral>, IMessageFieldAccessor, IMessageOneofAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x2000359")]
						public enum InclusionTypeOneofCase
						{
							[Cpp2IlInjected.Token(Token = "0x400111A")]
							None,
							[Cpp2IlInjected.Token(Token = "0x400111B")]
							All,
							[Cpp2IlInjected.Token(Token = "0x400111C")]
							Custom
						}

						[Cpp2IlInjected.Token(Token = "0x200035A")]
						[DebuggerNonUserCode]
						public static class Types
						{
							[Cpp2IlInjected.Token(Token = "0x200035B")]
							public sealed class InclusionCustomMineral : IMessage<InclusionCustomMineral>, IMessage, IEquatable<InclusionCustomMineral>, IDeepCloneable<InclusionCustomMineral>, IMessageFieldAccessor
							{
								[Cpp2IlInjected.Token(Token = "0x400111D")]
								private static readonly MessageParser<InclusionCustomMineral> _parser;

								[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
								[Cpp2IlInjected.Token(Token = "0x400111E")]
								private UnknownFieldSet _unknownFields;

								[Cpp2IlInjected.Token(Token = "0x400111F")]
								public const int SpecificItemsFieldNumber = 1;

								[Cpp2IlInjected.Token(Token = "0x4001120")]
								private static readonly FieldCodec<int> _repeated_specificItems_codec;

								[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
								[Cpp2IlInjected.Token(Token = "0x4001121")]
								private readonly RepeatedField<int> specificItems_;

								[Cpp2IlInjected.Token(Token = "0x4001122")]
								public const int DominantColorFieldNumber = 2;

								[Cpp2IlInjected.Token(Token = "0x4001123")]
								private static readonly FieldCodec<int> _repeated_dominantColor_codec;

								[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
								[Cpp2IlInjected.Token(Token = "0x4001124")]
								private readonly RepeatedField<int> dominantColor_;

								[Cpp2IlInjected.Token(Token = "0x170009A2")]
								[DebuggerNonUserCode]
								public static MessageParser<InclusionCustomMineral> Parser
								{
									[Cpp2IlInjected.Token(Token = "0x6002716")]
									[Cpp2IlInjected.Address(RVA = "0x3F92A20", Offset = "0x3F91420", VA = "0x183F92A20")]
									get
									{
										return null;
									}
								}

								[Cpp2IlInjected.Token(Token = "0x170009A3")]
								[DebuggerNonUserCode]
								public static MessageDescriptor Descriptor
								{
									[Cpp2IlInjected.Token(Token = "0x6002717")]
									[Cpp2IlInjected.Address(RVA = "0x3F929A0", Offset = "0x3F913A0", VA = "0x183F929A0")]
									get
									{
										return null;
									}
								}

								[Cpp2IlInjected.Token(Token = "0x170009A4")]
								[DebuggerNonUserCode]
								private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
								{
									[Cpp2IlInjected.Token(Token = "0x6002718")]
									[Cpp2IlInjected.Address(RVA = "0x3F92A80", Offset = "0x3F91480", VA = "0x183F92A80", Slot = "8")]
									get
									{
										return null;
									}
								}

								[Cpp2IlInjected.Token(Token = "0x170009A5")]
								[DebuggerNonUserCode]
								public RepeatedField<int> SpecificItems
								{
									[Cpp2IlInjected.Token(Token = "0x600271C")]
									[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
									get
									{
										return null;
									}
								}

								[Cpp2IlInjected.Token(Token = "0x170009A6")]
								[DebuggerNonUserCode]
								public RepeatedField<int> DominantColor
								{
									[Cpp2IlInjected.Token(Token = "0x600271D")]
									[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
									get
									{
										return null;
									}
								}

								[Cpp2IlInjected.Token(Token = "0x6002719")]
								[Cpp2IlInjected.Address(RVA = "0x3F92840", Offset = "0x3F91240", VA = "0x183F92840")]
								[DebuggerNonUserCode]
								public InclusionCustomMineral()
								{
								}

								[Cpp2IlInjected.Token(Token = "0x600271A")]
								[Cpp2IlInjected.Address(RVA = "0x3F928F0", Offset = "0x3F912F0", VA = "0x183F928F0")]
								[DebuggerNonUserCode]
								public InclusionCustomMineral(InclusionCustomMineral other)
								{
								}

								[Cpp2IlInjected.Token(Token = "0x600271B")]
								[Cpp2IlInjected.Address(RVA = "0x3F91FD0", Offset = "0x3F909D0", VA = "0x183F91FD0", Slot = "10")]
								[DebuggerNonUserCode]
								public InclusionCustomMineral Clone()
								{
									return null;
								}

								[Cpp2IlInjected.Token(Token = "0x600271E")]
								[Cpp2IlInjected.Address(RVA = "0x3F92160", Offset = "0x3F90B60", VA = "0x183F92160", Slot = "0")]
								[DebuggerNonUserCode]
								public override bool Equals(object other)
								{
									return default(bool);
								}

								[Cpp2IlInjected.Token(Token = "0x600271F")]
								[Cpp2IlInjected.Address(RVA = "0x3F920B0", Offset = "0x3F90AB0", VA = "0x183F920B0", Slot = "9")]
								[DebuggerNonUserCode]
								public bool Equals(InclusionCustomMineral other)
								{
									return default(bool);
								}

								[Cpp2IlInjected.Token(Token = "0x6002720")]
								[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
								[DebuggerNonUserCode]
								public override int GetHashCode()
								{
									return default(int);
								}

								[Cpp2IlInjected.Token(Token = "0x6002721")]
								[Cpp2IlInjected.Address(RVA = "0x3F92590", Offset = "0x3F90F90", VA = "0x183F92590", Slot = "3")]
								[DebuggerNonUserCode]
								public override string ToString()
								{
									return null;
								}

								[Cpp2IlInjected.Token(Token = "0x6002722")]
								[Cpp2IlInjected.Address(RVA = "0x3F925F0", Offset = "0x3F90FF0", VA = "0x183F925F0", Slot = "6")]
								[DebuggerNonUserCode]
								public void WriteTo(CodedOutputStream output)
								{
								}

								[Cpp2IlInjected.Token(Token = "0x6002723")]
								[Cpp2IlInjected.Address(RVA = "0x3F91E80", Offset = "0x3F90880", VA = "0x183F91E80", Slot = "7")]
								[DebuggerNonUserCode]
								public int CalculateSize()
								{
									return default(int);
								}

								[Cpp2IlInjected.Token(Token = "0x6002724")]
								[Cpp2IlInjected.Address(RVA = "0x3F922E0", Offset = "0x3F90CE0", VA = "0x183F922E0", Slot = "4")]
								[DebuggerNonUserCode]
								public void MergeFrom(InclusionCustomMineral other)
								{
								}

								[Cpp2IlInjected.Token(Token = "0x6002725")]
								[Cpp2IlInjected.Address(RVA = "0x3F92380", Offset = "0x3F90D80", VA = "0x183F92380", Slot = "5")]
								[DebuggerNonUserCode]
								public void MergeFrom(CodedInputStream input)
								{
								}

								[Cpp2IlInjected.Token(Token = "0x6002726")]
								[Cpp2IlInjected.Address(RVA = "0x3F92250", Offset = "0x3F90C50", VA = "0x183F92250", Slot = "11")]
								[DebuggerNonUserCode]
								public object GetFieldValue(int fieldNumber)
								{
									return null;
								}

								[Cpp2IlInjected.Token(Token = "0x6002727")]
								[Cpp2IlInjected.Address(RVA = "0x3F924E0", Offset = "0x3F90EE0", VA = "0x183F924E0", Slot = "12")]
								[DebuggerNonUserCode]
								public void SetFieldValue(int fieldNumber, object value)
								{
								}

								[Cpp2IlInjected.Token(Token = "0x6002728")]
								[Cpp2IlInjected.Address(RVA = "0x3F91F60", Offset = "0x3F90960", VA = "0x183F91F60", Slot = "13")]
								[DebuggerNonUserCode]
								public void ClearFieldValue(int fieldNumber)
								{
								}
							}
						}

						[Cpp2IlInjected.Token(Token = "0x4001113")]
						private static readonly MessageParser<InclusionsMineral> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001114")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001115")]
						public const int AllFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x4001116")]
						public const int CustomFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001117")]
						private object inclusionType_;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001118")]
						private InclusionTypeOneofCase inclusionTypeCase_;

						[Cpp2IlInjected.Token(Token = "0x1700099C")]
						[DebuggerNonUserCode]
						public static MessageParser<InclusionsMineral> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60026FC")]
							[Cpp2IlInjected.Address(RVA = "0x3F98EB0", Offset = "0x3F978B0", VA = "0x183F98EB0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700099D")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026FD")]
							[Cpp2IlInjected.Address(RVA = "0x3F98E30", Offset = "0x3F97830", VA = "0x183F98E30")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700099E")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60026FE")]
							[Cpp2IlInjected.Address(RVA = "0x3F98F10", Offset = "0x3F97910", VA = "0x183F98F10", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700099F")]
						[DebuggerNonUserCode]
						public Empty All
						{
							[Cpp2IlInjected.Token(Token = "0x6002702")]
							[Cpp2IlInjected.Address(RVA = "0x3F98D70", Offset = "0x3F97770", VA = "0x183F98D70")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6002703")]
							[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009A0")]
						[DebuggerNonUserCode]
						public Types.InclusionCustomMineral Custom
						{
							[Cpp2IlInjected.Token(Token = "0x6002704")]
							[Cpp2IlInjected.Address(RVA = "0x3F98DD0", Offset = "0x3F977D0", VA = "0x183F98DD0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6002705")]
							[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009A1")]
						[DebuggerNonUserCode]
						public InclusionTypeOneofCase InclusionTypeCase
						{
							[Cpp2IlInjected.Token(Token = "0x6002706")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(InclusionTypeOneofCase);
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60026FF")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public InclusionsMineral()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002700")]
						[Cpp2IlInjected.Address(RVA = "0x3F98B50", Offset = "0x3F97550", VA = "0x183F98B50")]
						[DebuggerNonUserCode]
						public InclusionsMineral(InclusionsMineral other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002701")]
						[Cpp2IlInjected.Address(RVA = "0x3F97D80", Offset = "0x3F96780", VA = "0x183F97D80", Slot = "10")]
						[DebuggerNonUserCode]
						public InclusionsMineral Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002707")]
						[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
						[DebuggerNonUserCode]
						public void ClearInclusionType()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002708")]
						[Cpp2IlInjected.Address(RVA = "0x3F97F10", Offset = "0x3F96910", VA = "0x183F97F10", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6002709")]
						[Cpp2IlInjected.Address(RVA = "0x3F97DE0", Offset = "0x3F967E0", VA = "0x183F97DE0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(InclusionsMineral other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600270A")]
						[Cpp2IlInjected.Address(RVA = "0x3F98190", Offset = "0x3F96B90", VA = "0x183F98190", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600270B")]
						[Cpp2IlInjected.Address(RVA = "0x3F988B0", Offset = "0x3F972B0", VA = "0x183F988B0", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600270C")]
						[Cpp2IlInjected.Address(RVA = "0x3F98910", Offset = "0x3F97310", VA = "0x183F98910", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600270D")]
						[Cpp2IlInjected.Address(RVA = "0x3F97BC0", Offset = "0x3F965C0", VA = "0x183F97BC0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600270E")]
						[Cpp2IlInjected.Address(RVA = "0x3F98370", Offset = "0x3F96D70", VA = "0x183F98370", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(InclusionsMineral other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600270F")]
						[Cpp2IlInjected.Address(RVA = "0x3F985C0", Offset = "0x3F96FC0", VA = "0x183F985C0", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002710")]
						[Cpp2IlInjected.Address(RVA = "0x3F98080", Offset = "0x3F96A80", VA = "0x183F98080", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002711")]
						[Cpp2IlInjected.Address(RVA = "0x3F987C0", Offset = "0x3F971C0", VA = "0x183F987C0", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002712")]
						[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002713")]
						[Cpp2IlInjected.Address(RVA = "0x3F982C0", Offset = "0x3F96CC0", VA = "0x183F982C0", Slot = "14")]
						[DebuggerNonUserCode]
						public int GetOneofCase(string oneofName)
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002714")]
						[Cpp2IlInjected.Address(RVA = "0x3F97D10", Offset = "0x3F96710", VA = "0x183F97D10", Slot = "15")]
						[DebuggerNonUserCode]
						public void ClearOneOf(string oneofName)
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x200035E")]
					public sealed class ExclusionsMineral : IMessage<ExclusionsMineral>, IMessage, IEquatable<ExclusionsMineral>, IDeepCloneable<ExclusionsMineral>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001127")]
						private static readonly MessageParser<ExclusionsMineral> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001128")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001129")]
						public const int SpecificItemsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x400112A")]
						private static readonly FieldCodec<int> _repeated_specificItems_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x400112B")]
						private readonly RepeatedField<int> specificItems_;

						[Cpp2IlInjected.Token(Token = "0x400112C")]
						public const int DominantColorFieldNumber = 2;

						[Cpp2IlInjected.Token(Token = "0x400112D")]
						private static readonly FieldCodec<int> _repeated_dominantColor_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x400112E")]
						private readonly RepeatedField<int> dominantColor_;

						[Cpp2IlInjected.Token(Token = "0x400112F")]
						public const int ShinyFieldNumber = 3;

						[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
						[Cpp2IlInjected.Token(Token = "0x4001130")]
						private bool shiny_;

						[Cpp2IlInjected.Token(Token = "0x170009A7")]
						[DebuggerNonUserCode]
						public static MessageParser<ExclusionsMineral> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x6002730")]
							[Cpp2IlInjected.Address(RVA = "0x3F90CF0", Offset = "0x3F8F6F0", VA = "0x183F90CF0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009A8")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002731")]
							[Cpp2IlInjected.Address(RVA = "0x3F90C70", Offset = "0x3F8F670", VA = "0x183F90C70")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009A9")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002732")]
							[Cpp2IlInjected.Address(RVA = "0x3F90D50", Offset = "0x3F8F750", VA = "0x183F90D50", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009AA")]
						[DebuggerNonUserCode]
						public RepeatedField<int> SpecificItems
						{
							[Cpp2IlInjected.Token(Token = "0x6002736")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009AB")]
						[DebuggerNonUserCode]
						public RepeatedField<int> DominantColor
						{
							[Cpp2IlInjected.Token(Token = "0x6002737")]
							[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009AC")]
						[DebuggerNonUserCode]
						public bool Shiny
						{
							[Cpp2IlInjected.Token(Token = "0x6002738")]
							[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
							get
							{
								return default(bool);
							}
							[Cpp2IlInjected.Token(Token = "0x6002739")]
							[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002733")]
						[Cpp2IlInjected.Address(RVA = "0x3F90BC0", Offset = "0x3F8F5C0", VA = "0x183F90BC0")]
						[DebuggerNonUserCode]
						public ExclusionsMineral()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002734")]
						[Cpp2IlInjected.Address(RVA = "0x3F90B00", Offset = "0x3F8F500", VA = "0x183F90B00")]
						[DebuggerNonUserCode]
						public ExclusionsMineral(ExclusionsMineral other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002735")]
						[Cpp2IlInjected.Address(RVA = "0x3F900D0", Offset = "0x3F8EAD0", VA = "0x183F900D0", Slot = "10")]
						[DebuggerNonUserCode]
						public ExclusionsMineral Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600273A")]
						[Cpp2IlInjected.Address(RVA = "0x3F90270", Offset = "0x3F8EC70", VA = "0x183F90270", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600273B")]
						[Cpp2IlInjected.Address(RVA = "0x3F901B0", Offset = "0x3F8EBB0", VA = "0x183F901B0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(ExclusionsMineral other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600273C")]
						[Cpp2IlInjected.Address(RVA = "0x3F90450", Offset = "0x3F8EE50", VA = "0x183F90450", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600273D")]
						[Cpp2IlInjected.Address(RVA = "0x3F90830", Offset = "0x3F8F230", VA = "0x183F90830", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600273E")]
						[Cpp2IlInjected.Address(RVA = "0x3F90890", Offset = "0x3F8F290", VA = "0x183F90890", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600273F")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FF70", Offset = "0x3F8E970", VA = "0x183F8FF70", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002740")]
						[Cpp2IlInjected.Address(RVA = "0x3F90670", Offset = "0x3F8F070", VA = "0x183F90670", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(ExclusionsMineral other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002741")]
						[Cpp2IlInjected.Address(RVA = "0x3F90500", Offset = "0x3F8EF00", VA = "0x183F90500", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002742")]
						[Cpp2IlInjected.Address(RVA = "0x3F90370", Offset = "0x3F8ED70", VA = "0x183F90370", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002743")]
						[Cpp2IlInjected.Address(RVA = "0x3F90710", Offset = "0x3F8F110", VA = "0x183F90710", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002744")]
						[Cpp2IlInjected.Address(RVA = "0x3F90050", Offset = "0x3F8EA50", VA = "0x183F90050", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400110D")]
				private static readonly MessageParser<FavoriteMineral> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400110E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400110F")]
				public const int InclusionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001110")]
				private Types.InclusionsMineral inclusions_;

				[Cpp2IlInjected.Token(Token = "0x4001111")]
				public const int ExclusionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001112")]
				private Types.ExclusionsMineral exclusions_;

				[Cpp2IlInjected.Token(Token = "0x17000997")]
				[DebuggerNonUserCode]
				public static MessageParser<FavoriteMineral> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60026E5")]
					[Cpp2IlInjected.Address(RVA = "0x2FEE980", Offset = "0x2FED380", VA = "0x182FEE980")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000998")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026E6")]
					[Cpp2IlInjected.Address(RVA = "0x2FEE900", Offset = "0x2FED300", VA = "0x182FEE900")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000999")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60026E7")]
					[Cpp2IlInjected.Address(RVA = "0x2FEE9E0", Offset = "0x2FED3E0", VA = "0x182FEE9E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700099A")]
				[DebuggerNonUserCode]
				public Types.InclusionsMineral Inclusions
				{
					[Cpp2IlInjected.Token(Token = "0x60026EC")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026ED")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700099B")]
				[DebuggerNonUserCode]
				public Types.ExclusionsMineral Exclusions
				{
					[Cpp2IlInjected.Token(Token = "0x60026EE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026EF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60026E8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE860", Offset = "0x2FED260", VA = "0x182FEE860")]
				[DebuggerNonUserCode]
				public FavoriteMineral()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026E9")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE470", Offset = "0x2FECE70", VA = "0x182FEE470")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026EA")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE730", Offset = "0x2FED130", VA = "0x182FEE730")]
				[DebuggerNonUserCode]
				public FavoriteMineral(FavoriteMineral other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026EB")]
				[Cpp2IlInjected.Address(RVA = "0x2FEDF50", Offset = "0x2FEC950", VA = "0x182FEDF50", Slot = "10")]
				[DebuggerNonUserCode]
				public FavoriteMineral Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026F0")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE0B0", Offset = "0x2FECAB0", VA = "0x182FEE0B0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F1")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FavoriteMineral other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F2")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F3")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE5C0", Offset = "0x2FECFC0", VA = "0x182FEE5C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026F4")]
				[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026F5")]
				[Cpp2IlInjected.Address(RVA = "0x2FEDE80", Offset = "0x2FEC880", VA = "0x182FEDE80", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026F6")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE340", Offset = "0x2FECD40", VA = "0x182FEE340", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FavoriteMineral other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026F7")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE200", Offset = "0x2FECC00", VA = "0x182FEE200", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026F8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE170", Offset = "0x2FECB70", VA = "0x182FEE170", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026F9")]
				[Cpp2IlInjected.Address(RVA = "0x2FEE500", Offset = "0x2FECF00", VA = "0x182FEE500", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026FA")]
				[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000361")]
			public sealed class FavoriteFlower : IMessage<FavoriteFlower>, IMessage, IEquatable<FavoriteFlower>, IDeepCloneable<FavoriteFlower>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000362")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000363")]
					public sealed class FlowerProperties : IMessage<FlowerProperties>, IMessage, IEquatable<FlowerProperties>, IDeepCloneable<FlowerProperties>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001139")]
						private static readonly MessageParser<FlowerProperties> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x400113A")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x400113B")]
						public const int SpecificItemsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x400113C")]
						private static readonly FieldCodec<int> _repeated_specificItems_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x400113D")]
						private readonly RepeatedField<int> specificItems_;

						[Cpp2IlInjected.Token(Token = "0x400113E")]
						public const int DominantColorFieldNumber = 2;

						[Cpp2IlInjected.Token(Token = "0x400113F")]
						private static readonly FieldCodec<int> _repeated_dominantColor_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001140")]
						private readonly RepeatedField<int> dominantColor_;

						[Cpp2IlInjected.Token(Token = "0x4001141")]
						public const int RarityFieldNumber = 3;

						[Cpp2IlInjected.Token(Token = "0x4001142")]
						private static readonly FieldCodec<FlowerRarity> _repeated_rarity_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
						[Cpp2IlInjected.Token(Token = "0x4001143")]
						private readonly RepeatedField<FlowerRarity> rarity_;

						[Cpp2IlInjected.Token(Token = "0x170009B2")]
						[DebuggerNonUserCode]
						public static MessageParser<FlowerProperties> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x6002763")]
							[Cpp2IlInjected.Address(RVA = "0x3F91D60", Offset = "0x3F90760", VA = "0x183F91D60")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B3")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002764")]
							[Cpp2IlInjected.Address(RVA = "0x3F91CE0", Offset = "0x3F906E0", VA = "0x183F91CE0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B4")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6002765")]
							[Cpp2IlInjected.Address(RVA = "0x3F91DC0", Offset = "0x3F907C0", VA = "0x183F91DC0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B5")]
						[DebuggerNonUserCode]
						public RepeatedField<int> SpecificItems
						{
							[Cpp2IlInjected.Token(Token = "0x6002769")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B6")]
						[DebuggerNonUserCode]
						public RepeatedField<int> DominantColor
						{
							[Cpp2IlInjected.Token(Token = "0x600276A")]
							[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B7")]
						[DebuggerNonUserCode]
						public RepeatedField<FlowerRarity> Rarity
						{
							[Cpp2IlInjected.Token(Token = "0x600276B")]
							[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002766")]
						[Cpp2IlInjected.Address(RVA = "0x3F91B00", Offset = "0x3F90500", VA = "0x183F91B00")]
						[DebuggerNonUserCode]
						public FlowerProperties()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002767")]
						[Cpp2IlInjected.Address(RVA = "0x3F91BF0", Offset = "0x3F905F0", VA = "0x183F91BF0")]
						[DebuggerNonUserCode]
						public FlowerProperties(FlowerProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002768")]
						[Cpp2IlInjected.Address(RVA = "0x3F90FB0", Offset = "0x3F8F9B0", VA = "0x183F90FB0", Slot = "10")]
						[DebuggerNonUserCode]
						public FlowerProperties Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600276C")]
						[Cpp2IlInjected.Address(RVA = "0x3F910D0", Offset = "0x3F8FAD0", VA = "0x183F910D0", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600276D")]
						[Cpp2IlInjected.Address(RVA = "0x3F911F0", Offset = "0x3F8FBF0", VA = "0x183F911F0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(FlowerProperties other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600276E")]
						[Cpp2IlInjected.Address(RVA = "0x13A9490", Offset = "0x13A7E90", VA = "0x1813A9490", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600276F")]
						[Cpp2IlInjected.Address(RVA = "0x3F91710", Offset = "0x3F90110", VA = "0x183F91710", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002770")]
						[Cpp2IlInjected.Address(RVA = "0x3F91770", Offset = "0x3F90170", VA = "0x183F91770", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002771")]
						[Cpp2IlInjected.Address(RVA = "0x3F90E10", Offset = "0x3F8F810", VA = "0x183F90E10", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002772")]
						[Cpp2IlInjected.Address(RVA = "0x3F91370", Offset = "0x3F8FD70", VA = "0x183F91370", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(FlowerProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002773")]
						[Cpp2IlInjected.Address(RVA = "0x3F91430", Offset = "0x3F8FE30", VA = "0x183F91430", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002774")]
						[Cpp2IlInjected.Address(RVA = "0x3F912D0", Offset = "0x3F8FCD0", VA = "0x183F912D0", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002775")]
						[Cpp2IlInjected.Address(RVA = "0x3F91610", Offset = "0x3F90010", VA = "0x183F91610", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002776")]
						[Cpp2IlInjected.Address(RVA = "0x3F90F30", Offset = "0x3F8F930", VA = "0x183F90F30", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x2000365")]
					public sealed class InclusionsFlower : IMessage<InclusionsFlower>, IMessage, IEquatable<InclusionsFlower>, IDeepCloneable<InclusionsFlower>, IMessageFieldAccessor, IMessageOneofAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x2000366")]
						public enum InclusionTypeOneofCase
						{
							[Cpp2IlInjected.Token(Token = "0x400114C")]
							None,
							[Cpp2IlInjected.Token(Token = "0x400114D")]
							All,
							[Cpp2IlInjected.Token(Token = "0x400114E")]
							Custom
						}

						[Cpp2IlInjected.Token(Token = "0x4001145")]
						private static readonly MessageParser<InclusionsFlower> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001146")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001147")]
						public const int AllFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x4001148")]
						public const int CustomFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001149")]
						private object inclusionType_;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x400114A")]
						private InclusionTypeOneofCase inclusionTypeCase_;

						[Cpp2IlInjected.Token(Token = "0x170009B8")]
						[DebuggerNonUserCode]
						public static MessageParser<InclusionsFlower> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x600277D")]
							[Cpp2IlInjected.Address(RVA = "0x3F95240", Offset = "0x3F93C40", VA = "0x183F95240")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009B9")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x600277E")]
							[Cpp2IlInjected.Address(RVA = "0x3F951C0", Offset = "0x3F93BC0", VA = "0x183F951C0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009BA")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x600277F")]
							[Cpp2IlInjected.Address(RVA = "0x3F952A0", Offset = "0x3F93CA0", VA = "0x183F952A0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009BB")]
						[DebuggerNonUserCode]
						public Empty All
						{
							[Cpp2IlInjected.Token(Token = "0x6002783")]
							[Cpp2IlInjected.Address(RVA = "0x3F95100", Offset = "0x3F93B00", VA = "0x183F95100")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6002784")]
							[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009BC")]
						[DebuggerNonUserCode]
						public FlowerProperties Custom
						{
							[Cpp2IlInjected.Token(Token = "0x6002785")]
							[Cpp2IlInjected.Address(RVA = "0x3F95160", Offset = "0x3F93B60", VA = "0x183F95160")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6002786")]
							[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009BD")]
						[DebuggerNonUserCode]
						public InclusionTypeOneofCase InclusionTypeCase
						{
							[Cpp2IlInjected.Token(Token = "0x6002787")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(InclusionTypeOneofCase);
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6002780")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public InclusionsFlower()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002781")]
						[Cpp2IlInjected.Address(RVA = "0x3F94EB0", Offset = "0x3F938B0", VA = "0x183F94EB0")]
						[DebuggerNonUserCode]
						public InclusionsFlower(InclusionsFlower other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002782")]
						[Cpp2IlInjected.Address(RVA = "0x3F940E0", Offset = "0x3F92AE0", VA = "0x183F940E0", Slot = "10")]
						[DebuggerNonUserCode]
						public InclusionsFlower Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002788")]
						[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
						[DebuggerNonUserCode]
						public void ClearInclusionType()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002789")]
						[Cpp2IlInjected.Address(RVA = "0x3F94140", Offset = "0x3F92B40", VA = "0x183F94140", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600278A")]
						[Cpp2IlInjected.Address(RVA = "0x3F942B0", Offset = "0x3F92CB0", VA = "0x183F942B0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(InclusionsFlower other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600278B")]
						[Cpp2IlInjected.Address(RVA = "0x3F944F0", Offset = "0x3F92EF0", VA = "0x183F944F0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600278C")]
						[Cpp2IlInjected.Address(RVA = "0x3F94C10", Offset = "0x3F93610", VA = "0x183F94C10", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600278D")]
						[Cpp2IlInjected.Address(RVA = "0x3F94C70", Offset = "0x3F93670", VA = "0x183F94C70", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600278E")]
						[Cpp2IlInjected.Address(RVA = "0x3F93F20", Offset = "0x3F92920", VA = "0x183F93F20", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600278F")]
						[Cpp2IlInjected.Address(RVA = "0x3F948D0", Offset = "0x3F932D0", VA = "0x183F948D0", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(InclusionsFlower other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002790")]
						[Cpp2IlInjected.Address(RVA = "0x3F946D0", Offset = "0x3F930D0", VA = "0x183F946D0", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002791")]
						[Cpp2IlInjected.Address(RVA = "0x3F943E0", Offset = "0x3F92DE0", VA = "0x183F943E0", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6002792")]
						[Cpp2IlInjected.Address(RVA = "0x3F94B20", Offset = "0x3F93520", VA = "0x183F94B20", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002793")]
						[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6002794")]
						[Cpp2IlInjected.Address(RVA = "0x3F94620", Offset = "0x3F93020", VA = "0x183F94620", Slot = "14")]
						[DebuggerNonUserCode]
						public int GetOneofCase(string oneofName)
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6002795")]
						[Cpp2IlInjected.Address(RVA = "0x3F94070", Offset = "0x3F92A70", VA = "0x183F94070", Slot = "15")]
						[DebuggerNonUserCode]
						public void ClearOneOf(string oneofName)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001133")]
				private static readonly MessageParser<FavoriteFlower> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001134")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001135")]
				public const int InclusionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001136")]
				private Types.InclusionsFlower inclusions_;

				[Cpp2IlInjected.Token(Token = "0x4001137")]
				public const int ExclusionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001138")]
				private Types.FlowerProperties exclusions_;

				[Cpp2IlInjected.Token(Token = "0x170009AD")]
				[DebuggerNonUserCode]
				public static MessageParser<FavoriteFlower> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600274C")]
					[Cpp2IlInjected.Address(RVA = "0x2FEC520", Offset = "0x2FEAF20", VA = "0x182FEC520")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600274D")]
					[Cpp2IlInjected.Address(RVA = "0x2FEC4A0", Offset = "0x2FEAEA0", VA = "0x182FEC4A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009AF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600274E")]
					[Cpp2IlInjected.Address(RVA = "0x2FEC580", Offset = "0x2FEAF80", VA = "0x182FEC580", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B0")]
				[DebuggerNonUserCode]
				public Types.InclusionsFlower Inclusions
				{
					[Cpp2IlInjected.Token(Token = "0x6002753")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002754")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009B1")]
				[DebuggerNonUserCode]
				public Types.FlowerProperties Exclusions
				{
					[Cpp2IlInjected.Token(Token = "0x6002755")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002756")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600274F")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC2D0", Offset = "0x2FEACD0", VA = "0x182FEC2D0")]
				[DebuggerNonUserCode]
				public FavoriteFlower()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002750")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC010", Offset = "0x2FEAA10", VA = "0x182FEC010")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002751")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC370", Offset = "0x2FEAD70", VA = "0x182FEC370")]
				[DebuggerNonUserCode]
				public FavoriteFlower(FavoriteFlower other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002752")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBAF0", Offset = "0x2FEA4F0", VA = "0x182FEBAF0", Slot = "10")]
				[DebuggerNonUserCode]
				public FavoriteFlower Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002757")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBC50", Offset = "0x2FEA650", VA = "0x182FEBC50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002758")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FavoriteFlower other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002759")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600275A")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC160", Offset = "0x2FEAB60", VA = "0x182FEC160", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600275B")]
				[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600275C")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBA20", Offset = "0x2FEA420", VA = "0x182FEBA20", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600275D")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBDA0", Offset = "0x2FEA7A0", VA = "0x182FEBDA0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FavoriteFlower other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600275E")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBED0", Offset = "0x2FEA8D0", VA = "0x182FEBED0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600275F")]
				[Cpp2IlInjected.Address(RVA = "0x2FEBD10", Offset = "0x2FEA710", VA = "0x182FEBD10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002760")]
				[Cpp2IlInjected.Address(RVA = "0x2FEC0A0", Offset = "0x2FEAAA0", VA = "0x182FEC0A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002761")]
				[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000369")]
			public sealed class FavoriteCraftingMaterial : IMessage<FavoriteCraftingMaterial>, IMessage, IEquatable<FavoriteCraftingMaterial>, IDeepCloneable<FavoriteCraftingMaterial>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200036A")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x200036B")]
					public sealed class CraftingMaterialProperties : IMessage<CraftingMaterialProperties>, IMessage, IEquatable<CraftingMaterialProperties>, IDeepCloneable<CraftingMaterialProperties>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001157")]
						private static readonly MessageParser<CraftingMaterialProperties> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001158")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001159")]
						public const int SpecificItemsFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x400115A")]
						private static readonly FieldCodec<int> _repeated_specificItems_codec;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x400115B")]
						private readonly RepeatedField<int> specificItems_;

						[Cpp2IlInjected.Token(Token = "0x170009C3")]
						[DebuggerNonUserCode]
						public static MessageParser<CraftingMaterialProperties> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60027B4")]
							[Cpp2IlInjected.Address(RVA = "0x3F8FE50", Offset = "0x3F8E850", VA = "0x183F8FE50")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009C4")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60027B5")]
							[Cpp2IlInjected.Address(RVA = "0x3F8FDD0", Offset = "0x3F8E7D0", VA = "0x183F8FDD0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009C5")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60027B6")]
							[Cpp2IlInjected.Address(RVA = "0x3F8FEB0", Offset = "0x3F8E8B0", VA = "0x183F8FEB0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009C6")]
						[DebuggerNonUserCode]
						public RepeatedField<int> SpecificItems
						{
							[Cpp2IlInjected.Token(Token = "0x60027BA")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60027B7")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FCC0", Offset = "0x3F8E6C0", VA = "0x183F8FCC0")]
						[DebuggerNonUserCode]
						public CraftingMaterialProperties()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027B8")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FD40", Offset = "0x3F8E740", VA = "0x183F8FD40")]
						[DebuggerNonUserCode]
						public CraftingMaterialProperties(CraftingMaterialProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027B9")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F5E0", Offset = "0x3F8DFE0", VA = "0x183F8F5E0", Slot = "10")]
						[DebuggerNonUserCode]
						public CraftingMaterialProperties Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027BB")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F730", Offset = "0x3F8E130", VA = "0x183F8F730", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60027BC")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F6A0", Offset = "0x3F8E0A0", VA = "0x183F8F6A0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(CraftingMaterialProperties other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60027BD")]
						[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60027BE")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FA60", Offset = "0x3F8E460", VA = "0x183F8FA60", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027BF")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FAC0", Offset = "0x3F8E4C0", VA = "0x183F8FAC0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027C0")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F4D0", Offset = "0x3F8DED0", VA = "0x183F8F4D0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60027C1")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F980", Offset = "0x3F8E380", VA = "0x183F8F980", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(CraftingMaterialProperties other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027C2")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F890", Offset = "0x3F8E290", VA = "0x183F8F890", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027C3")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F810", Offset = "0x3F8E210", VA = "0x183F8F810", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027C4")]
						[Cpp2IlInjected.Address(RVA = "0x3F8FA00", Offset = "0x3F8E400", VA = "0x183F8FA00", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027C5")]
						[Cpp2IlInjected.Address(RVA = "0x3F8F580", Offset = "0x3F8DF80", VA = "0x183F8F580", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x200036D")]
					public sealed class InclusionsCraftingMaterial : IMessage<InclusionsCraftingMaterial>, IMessage, IEquatable<InclusionsCraftingMaterial>, IDeepCloneable<InclusionsCraftingMaterial>, IMessageFieldAccessor, IMessageOneofAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x200036E")]
						public enum InclusionTypeOneofCase
						{
							[Cpp2IlInjected.Token(Token = "0x4001164")]
							None,
							[Cpp2IlInjected.Token(Token = "0x4001165")]
							All,
							[Cpp2IlInjected.Token(Token = "0x4001166")]
							Custom
						}

						[Cpp2IlInjected.Token(Token = "0x400115D")]
						private static readonly MessageParser<InclusionsCraftingMaterial> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x400115E")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x400115F")]
						public const int AllFieldNumber = 1;

						[Cpp2IlInjected.Token(Token = "0x4001160")]
						public const int CustomFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001161")]
						private object inclusionType_;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001162")]
						private InclusionTypeOneofCase inclusionTypeCase_;

						[Cpp2IlInjected.Token(Token = "0x170009C7")]
						[DebuggerNonUserCode]
						public static MessageParser<InclusionsCraftingMaterial> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60027CA")]
							[Cpp2IlInjected.Address(RVA = "0x3F93E00", Offset = "0x3F92800", VA = "0x183F93E00")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009C8")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60027CB")]
							[Cpp2IlInjected.Address(RVA = "0x3F93D80", Offset = "0x3F92780", VA = "0x183F93D80")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009C9")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60027CC")]
							[Cpp2IlInjected.Address(RVA = "0x3F93E60", Offset = "0x3F92860", VA = "0x183F93E60", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009CA")]
						[DebuggerNonUserCode]
						public Empty All
						{
							[Cpp2IlInjected.Token(Token = "0x60027D0")]
							[Cpp2IlInjected.Address(RVA = "0x3F93CC0", Offset = "0x3F926C0", VA = "0x183F93CC0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60027D1")]
							[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009CB")]
						[DebuggerNonUserCode]
						public CraftingMaterialProperties Custom
						{
							[Cpp2IlInjected.Token(Token = "0x60027D2")]
							[Cpp2IlInjected.Address(RVA = "0x3F93D20", Offset = "0x3F92720", VA = "0x183F93D20")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60027D3")]
							[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x170009CC")]
						[DebuggerNonUserCode]
						public InclusionTypeOneofCase InclusionTypeCase
						{
							[Cpp2IlInjected.Token(Token = "0x60027D4")]
							[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
							get
							{
								return default(InclusionTypeOneofCase);
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60027CD")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public InclusionsCraftingMaterial()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027CE")]
						[Cpp2IlInjected.Address(RVA = "0x3F93AD0", Offset = "0x3F924D0", VA = "0x183F93AD0")]
						[DebuggerNonUserCode]
						public InclusionsCraftingMaterial(InclusionsCraftingMaterial other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027CF")]
						[Cpp2IlInjected.Address(RVA = "0x3F92D00", Offset = "0x3F91700", VA = "0x183F92D00", Slot = "10")]
						[DebuggerNonUserCode]
						public InclusionsCraftingMaterial Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027D5")]
						[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
						[DebuggerNonUserCode]
						public void ClearInclusionType()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027D6")]
						[Cpp2IlInjected.Address(RVA = "0x3F92D60", Offset = "0x3F91760", VA = "0x183F92D60", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60027D7")]
						[Cpp2IlInjected.Address(RVA = "0x3F92ED0", Offset = "0x3F918D0", VA = "0x183F92ED0", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(InclusionsCraftingMaterial other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60027D8")]
						[Cpp2IlInjected.Address(RVA = "0x3F93110", Offset = "0x3F91B10", VA = "0x183F93110", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60027D9")]
						[Cpp2IlInjected.Address(RVA = "0x3F93830", Offset = "0x3F92230", VA = "0x183F93830", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027DA")]
						[Cpp2IlInjected.Address(RVA = "0x3F93890", Offset = "0x3F92290", VA = "0x183F93890", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027DB")]
						[Cpp2IlInjected.Address(RVA = "0x3F92B40", Offset = "0x3F91540", VA = "0x183F92B40", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60027DC")]
						[Cpp2IlInjected.Address(RVA = "0x3F932F0", Offset = "0x3F91CF0", VA = "0x183F932F0", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(InclusionsCraftingMaterial other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027DD")]
						[Cpp2IlInjected.Address(RVA = "0x3F93540", Offset = "0x3F91F40", VA = "0x183F93540", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027DE")]
						[Cpp2IlInjected.Address(RVA = "0x3F93000", Offset = "0x3F91A00", VA = "0x183F93000", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60027DF")]
						[Cpp2IlInjected.Address(RVA = "0x3F93740", Offset = "0x3F92140", VA = "0x183F93740", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027E0")]
						[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60027E1")]
						[Cpp2IlInjected.Address(RVA = "0x3F93240", Offset = "0x3F91C40", VA = "0x183F93240", Slot = "14")]
						[DebuggerNonUserCode]
						public int GetOneofCase(string oneofName)
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60027E2")]
						[Cpp2IlInjected.Address(RVA = "0x3F92C90", Offset = "0x3F91690", VA = "0x183F92C90", Slot = "15")]
						[DebuggerNonUserCode]
						public void ClearOneOf(string oneofName)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001151")]
				private static readonly MessageParser<FavoriteCraftingMaterial> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001152")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001153")]
				public const int InclusionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001154")]
				private Types.InclusionsCraftingMaterial inclusions_;

				[Cpp2IlInjected.Token(Token = "0x4001155")]
				public const int ExclusionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001156")]
				private Types.CraftingMaterialProperties exclusions_;

				[Cpp2IlInjected.Token(Token = "0x170009BE")]
				[DebuggerNonUserCode]
				public static MessageParser<FavoriteCraftingMaterial> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600279D")]
					[Cpp2IlInjected.Address(RVA = "0x2FEB900", Offset = "0x2FEA300", VA = "0x182FEB900")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009BF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600279E")]
					[Cpp2IlInjected.Address(RVA = "0x2FEB880", Offset = "0x2FEA280", VA = "0x182FEB880")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009C0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600279F")]
					[Cpp2IlInjected.Address(RVA = "0x2FEB960", Offset = "0x2FEA360", VA = "0x182FEB960", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009C1")]
				[DebuggerNonUserCode]
				public Types.InclusionsCraftingMaterial Inclusions
				{
					[Cpp2IlInjected.Token(Token = "0x60027A4")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027A5")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009C2")]
				[DebuggerNonUserCode]
				public Types.CraftingMaterialProperties Exclusions
				{
					[Cpp2IlInjected.Token(Token = "0x60027A6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60027A7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60027A0")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB7E0", Offset = "0x2FEA1E0", VA = "0x182FEB7E0")]
				[DebuggerNonUserCode]
				public FavoriteCraftingMaterial()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027A1")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB3F0", Offset = "0x2FE9DF0", VA = "0x182FEB3F0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027A2")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB6B0", Offset = "0x2FEA0B0", VA = "0x182FEB6B0")]
				[DebuggerNonUserCode]
				public FavoriteCraftingMaterial(FavoriteCraftingMaterial other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027A3")]
				[Cpp2IlInjected.Address(RVA = "0x2FEAED0", Offset = "0x2FE98D0", VA = "0x182FEAED0", Slot = "10")]
				[DebuggerNonUserCode]
				public FavoriteCraftingMaterial Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027A8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB030", Offset = "0x2FE9A30", VA = "0x182FEB030", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027A9")]
				[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FavoriteCraftingMaterial other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60027AA")]
				[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027AB")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB540", Offset = "0x2FE9F40", VA = "0x182FEB540", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027AC")]
				[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027AD")]
				[Cpp2IlInjected.Address(RVA = "0x2FEAE00", Offset = "0x2FE9800", VA = "0x182FEAE00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60027AE")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB2C0", Offset = "0x2FE9CC0", VA = "0x182FEB2C0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FavoriteCraftingMaterial other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027AF")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB180", Offset = "0x2FE9B80", VA = "0x182FEB180", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027B0")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB0F0", Offset = "0x2FE9AF0", VA = "0x182FEB0F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60027B1")]
				[Cpp2IlInjected.Address(RVA = "0x2FEB480", Offset = "0x2FE9E80", VA = "0x182FEB480", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60027B2")]
				[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40010BB")]
		private static readonly MessageParser<PreferencePoolItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40010BC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40010BD")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010BE")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40010BF")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010C0")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010C1")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010C2")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010C3")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010C4")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010C5")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010C6")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010C7")]
		public const int FavoriteFlowersFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010C8")]
		private Types.FavoriteFlower favoriteFlowers_;

		[Cpp2IlInjected.Token(Token = "0x40010C9")]
		public const int FavoriteMealsFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40010CA")]
		private Types.FavoriteMeal favoriteMeals_;

		[Cpp2IlInjected.Token(Token = "0x40010CB")]
		public const int FavoriteIngredientsFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40010CC")]
		private Types.FavoriteIngredient favoriteIngredients_;

		[Cpp2IlInjected.Token(Token = "0x40010CD")]
		public const int FavoriteMineralsFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40010CE")]
		private Types.FavoriteMineral favoriteMinerals_;

		[Cpp2IlInjected.Token(Token = "0x40010CF")]
		public const int FavoriteCraftingMaterialsFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40010D0")]
		private Types.FavoriteCraftingMaterial favoriteCraftingMaterials_;

		[Cpp2IlInjected.Token(Token = "0x17000967")]
		[DebuggerNonUserCode]
		public static MessageParser<PreferencePoolItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600261E")]
			[Cpp2IlInjected.Address(RVA = "0x287D1C0", Offset = "0x287BBC0", VA = "0x18287D1C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000968")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600261F")]
			[Cpp2IlInjected.Address(RVA = "0x287D0F0", Offset = "0x287BAF0", VA = "0x18287D0F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000969")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002620")]
			[Cpp2IlInjected.Address(RVA = "0x287D220", Offset = "0x287BC20", VA = "0x18287D220", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096A")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002625")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002626")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096B")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002627")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002628")]
			[Cpp2IlInjected.Address(RVA = "0x287D410", Offset = "0x287BE10", VA = "0x18287D410")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096C")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002629")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600262A")]
			[Cpp2IlInjected.Address(RVA = "0x287D330", Offset = "0x287BD30", VA = "0x18287D330")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096D")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600262B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600262C")]
			[Cpp2IlInjected.Address(RVA = "0x287D3A0", Offset = "0x287BDA0", VA = "0x18287D3A0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096E")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600262D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600262E")]
			[Cpp2IlInjected.Address(RVA = "0x287D480", Offset = "0x287BE80", VA = "0x18287D480")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700096F")]
		[DebuggerNonUserCode]
		public Types.FavoriteFlower FavoriteFlowers
		{
			[Cpp2IlInjected.Token(Token = "0x600262F")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return favoriteFlowers_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002630")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				favoriteFlowers_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000970")]
		[DebuggerNonUserCode]
		public Types.FavoriteMeal FavoriteMeals
		{
			[Cpp2IlInjected.Token(Token = "0x6002631")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return favoriteMeals_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002632")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				favoriteMeals_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000971")]
		[DebuggerNonUserCode]
		public Types.FavoriteIngredient FavoriteIngredients
		{
			[Cpp2IlInjected.Token(Token = "0x6002633")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return favoriteIngredients_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002634")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				favoriteIngredients_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000972")]
		[DebuggerNonUserCode]
		public Types.FavoriteMineral FavoriteMinerals
		{
			[Cpp2IlInjected.Token(Token = "0x6002635")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return favoriteMinerals_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002636")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				favoriteMinerals_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000973")]
		[DebuggerNonUserCode]
		public Types.FavoriteCraftingMaterial FavoriteCraftingMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6002637")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return favoriteCraftingMaterials_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002638")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				favoriteCraftingMaterials_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000974")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002644")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002621")]
		[Cpp2IlInjected.Address(RVA = "0x287CF50", Offset = "0x287B950", VA = "0x18287CF50")]
		[DebuggerNonUserCode]
		public PreferencePoolItemData()
		{
			Types.FavoriteFlower favoriteFlower = (favoriteFlowers_ = new Types.FavoriteFlower());
			Types.FavoriteMineral favoriteMineral = (favoriteMinerals_ = new Types.FavoriteMineral());
			Types.FavoriteMeal favoriteMeal = (favoriteMeals_ = new Types.FavoriteMeal());
			Types.FavoriteIngredient favoriteIngredient = (favoriteIngredients_ = new Types.FavoriteIngredient());
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial = (favoriteCraftingMaterials_ = new Types.FavoriteCraftingMaterial());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002622")]
		[Cpp2IlInjected.Address(RVA = "0x287C460", Offset = "0x287AE60", VA = "0x18287C460")]
		private void OnConstruction()
		{
			Types.FavoriteFlower favoriteFlower = (favoriteFlowers_ = new Types.FavoriteFlower());
			Types.FavoriteMineral favoriteMineral = (favoriteMinerals_ = new Types.FavoriteMineral());
			Types.FavoriteMeal favoriteMeal = (favoriteMeals_ = new Types.FavoriteMeal());
			Types.FavoriteIngredient favoriteIngredient = (favoriteIngredients_ = new Types.FavoriteIngredient());
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial = (favoriteCraftingMaterials_ = new Types.FavoriteCraftingMaterial());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002623")]
		[Cpp2IlInjected.Address(RVA = "0x287CC50", Offset = "0x287B650", VA = "0x18287CC50")]
		[DebuggerNonUserCode]
		public PreferencePoolItemData(PreferencePoolItemData other)
		{
			//IL_00e6: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			//IL_0122: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			Types.FavoriteFlower favoriteFlower = (favoriteFlowers_ = new Types.FavoriteFlower());
			Types.FavoriteMineral favoriteMineral = (favoriteMinerals_ = new Types.FavoriteMineral());
			Types.FavoriteMeal favoriteMeal = (favoriteMeals_ = new Types.FavoriteMeal());
			Types.FavoriteIngredient favoriteIngredient = (favoriteIngredients_ = new Types.FavoriteIngredient());
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial = (favoriteCraftingMaterials_ = new Types.FavoriteCraftingMaterial());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			Types.FavoriteFlower favoriteFlower2 = other.favoriteFlowers_;
			int num2 = 0;
			if (favoriteFlower2 != null)
			{
				Types.FavoriteFlower favoriteFlower3 = favoriteFlower2.Clone();
			}
			favoriteFlowers_ = (Types.FavoriteFlower)num2;
			Types.FavoriteMeal favoriteMeal2 = other.favoriteMeals_;
			if (favoriteMeal2 != null)
			{
				Types.FavoriteMeal favoriteMeal3 = favoriteMeal2.Clone();
			}
			favoriteMeals_ = (Types.FavoriteMeal)num2;
			Types.FavoriteIngredient favoriteIngredient2 = other.favoriteIngredients_;
			if (favoriteIngredient2 != null)
			{
				Types.FavoriteIngredient favoriteIngredient3 = favoriteIngredient2.Clone();
			}
			favoriteIngredients_ = (Types.FavoriteIngredient)num2;
			Types.FavoriteMineral favoriteMineral2 = other.favoriteMinerals_;
			if (favoriteMineral2 != null)
			{
				Types.FavoriteMineral favoriteMineral3 = favoriteMineral2.Clone();
			}
			favoriteMinerals_ = (Types.FavoriteMineral)num2;
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial2 = other.favoriteCraftingMaterials_;
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial3 = default(Types.FavoriteCraftingMaterial);
			if (favoriteCraftingMaterial2 != null)
			{
				favoriteCraftingMaterial3 = favoriteCraftingMaterial2.Clone();
			}
			favoriteCraftingMaterials_ = favoriteCraftingMaterial3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002624")]
		[Cpp2IlInjected.Address(RVA = "0x287B880", Offset = "0x287A280", VA = "0x18287B880", Slot = "10")]
		[DebuggerNonUserCode]
		public PreferencePoolItemData Clone()
		{
			return new PreferencePoolItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002639")]
		[Cpp2IlInjected.Address(RVA = "0x287B8E0", Offset = "0x287A2E0", VA = "0x18287B8E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(PreferencePoolItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && object.Equals(favoriteFlowers_, other) && object.Equals(favoriteMeals_, other) && object.Equals(favoriteIngredients_, other) && object.Equals(favoriteMinerals_, other) && object.Equals(favoriteCraftingMaterials_, other))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600263A")]
		[Cpp2IlInjected.Address(RVA = "0x287BA60", Offset = "0x287A460", VA = "0x18287BA60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PreferencePoolItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									Types.FavoriteFlower objB = other.favoriteFlowers_;
									if (object.Equals(favoriteFlowers_, objB))
									{
										Types.FavoriteMeal objB2 = other.favoriteMeals_;
										if (object.Equals(favoriteMeals_, objB2))
										{
											Types.FavoriteIngredient objB3 = other.favoriteIngredients_;
											if (object.Equals(favoriteIngredients_, objB3))
											{
												Types.FavoriteMineral objB4 = other.favoriteMinerals_;
												if (object.Equals(favoriteMinerals_, objB4))
												{
													Types.FavoriteCraftingMaterial objB5 = other.favoriteCraftingMaterials_;
													if (object.Equals(favoriteCraftingMaterials_, objB5))
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
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600263B")]
		[Cpp2IlInjected.Address(RVA = "0x287BD10", Offset = "0x287A710", VA = "0x18287BD10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f4
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			Types.FavoriteFlower favoriteFlower = favoriteFlowers_;
			if (favoriteFlower != null)
			{
				int hashCode5 = favoriteFlower.GetHashCode();
			}
			Types.FavoriteMeal favoriteMeal = favoriteMeals_;
			if (favoriteMeal != null)
			{
				int hashCode6 = favoriteMeal.GetHashCode();
			}
			Types.FavoriteIngredient favoriteIngredient = favoriteIngredients_;
			if (favoriteIngredient != null)
			{
				int hashCode7 = favoriteIngredient.GetHashCode();
			}
			Types.FavoriteMineral favoriteMineral = favoriteMinerals_;
			if (favoriteMineral != null)
			{
				int hashCode8 = favoriteMineral.GetHashCode();
			}
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial = favoriteCraftingMaterials_;
			if (favoriteCraftingMaterial != null)
			{
				int hashCode9 = favoriteCraftingMaterial.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode10 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600263C")]
		[Cpp2IlInjected.Address(RVA = "0x287C8C0", Offset = "0x287B2C0", VA = "0x18287C8C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600263D")]
		[Cpp2IlInjected.Address(RVA = "0x287C920", Offset = "0x287B320", VA = "0x18287C920", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0126
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)favoriteFlowers_ != 0)
			{
				Types.FavoriteFlower value6 = favoriteFlowers_;
				output.WriteMessage(value6);
			}
			if ((long)favoriteMeals_ != 0)
			{
				Types.FavoriteMeal value7 = favoriteMeals_;
				output.WriteMessage(value7);
			}
			if ((long)favoriteIngredients_ != 0)
			{
				Types.FavoriteIngredient value8 = favoriteIngredients_;
				output.WriteMessage(value8);
			}
			if ((long)favoriteMinerals_ != 0)
			{
				Types.FavoriteMineral value9 = favoriteMinerals_;
				output.WriteMessage(value9);
			}
			if ((long)favoriteCraftingMaterials_ != 0)
			{
				Types.FavoriteCraftingMaterial value10 = favoriteCraftingMaterials_;
				output.WriteMessage(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600263E")]
		[Cpp2IlInjected.Address(RVA = "0x287B4C0", Offset = "0x2879EC0", VA = "0x18287B4C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_016b
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			Types.FavoriteFlower favoriteFlower = favoriteFlowers_;
			if (favoriteFlower != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(favoriteFlower);
				num8++;
				num2 += num8;
			}
			Types.FavoriteMeal favoriteMeal = favoriteMeals_;
			if (favoriteMeal != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(favoriteMeal);
				num9++;
				num2 += num9;
			}
			Types.FavoriteIngredient favoriteIngredient = favoriteIngredients_;
			if (favoriteIngredient != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(favoriteIngredient);
				num10++;
				num2 += num10;
			}
			Types.FavoriteMineral favoriteMineral = favoriteMinerals_;
			if (favoriteMineral != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(favoriteMineral);
				num11++;
				num2 += num11;
			}
			Types.FavoriteCraftingMaterial favoriteCraftingMaterial = favoriteCraftingMaterials_;
			if (favoriteCraftingMaterial != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(favoriteCraftingMaterial);
				num12++;
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

		[Cpp2IlInjected.Token(Token = "0x600263F")]
		[Cpp2IlInjected.Address(RVA = "0x287BE90", Offset = "0x287A890", VA = "0x18287BE90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PreferencePoolItemData other)
		{
			//Discarded unreachable code: IL_01c4
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if ((long)other.favoriteFlowers_ != 0)
			{
				Types.FavoriteFlower favoriteFlower2 = default(Types.FavoriteFlower);
				if (favoriteFlowers_ == null)
				{
					Types.FavoriteFlower favoriteFlower = (favoriteFlowers_ = new Types.FavoriteFlower());
					favoriteFlower2 = favoriteFlowers_;
				}
				Types.FavoriteFlower other2 = other.favoriteFlowers_;
				favoriteFlower2.MergeFrom(other2);
			}
			if ((long)other.favoriteMeals_ != 0)
			{
				Types.FavoriteMeal favoriteMeal2 = default(Types.FavoriteMeal);
				if (favoriteMeals_ == null)
				{
					Types.FavoriteMeal favoriteMeal = (favoriteMeals_ = new Types.FavoriteMeal());
					favoriteMeal2 = favoriteMeals_;
				}
				Types.FavoriteMeal other3 = other.favoriteMeals_;
				favoriteMeal2.MergeFrom(other3);
			}
			if ((long)other.favoriteIngredients_ != 0)
			{
				Types.FavoriteIngredient favoriteIngredient2 = default(Types.FavoriteIngredient);
				if (favoriteIngredients_ == null)
				{
					Types.FavoriteIngredient favoriteIngredient = (favoriteIngredients_ = new Types.FavoriteIngredient());
					favoriteIngredient2 = favoriteIngredients_;
				}
				Types.FavoriteIngredient other4 = other.favoriteIngredients_;
				favoriteIngredient2.MergeFrom(other4);
			}
			if ((long)other.favoriteMinerals_ != 0)
			{
				Types.FavoriteMineral favoriteMineral2 = default(Types.FavoriteMineral);
				if (favoriteMinerals_ == null)
				{
					Types.FavoriteMineral favoriteMineral = (favoriteMinerals_ = new Types.FavoriteMineral());
					favoriteMineral2 = favoriteMinerals_;
				}
				Types.FavoriteMineral other5 = other.favoriteMinerals_;
				favoriteMineral2.MergeFrom(other5);
			}
			if ((long)other.favoriteCraftingMaterials_ != 0)
			{
				Types.FavoriteCraftingMaterial favoriteCraftingMaterial2 = default(Types.FavoriteCraftingMaterial);
				if (favoriteCraftingMaterials_ == null)
				{
					Types.FavoriteCraftingMaterial favoriteCraftingMaterial = (favoriteCraftingMaterials_ = new Types.FavoriteCraftingMaterial());
					favoriteCraftingMaterial2 = favoriteCraftingMaterials_;
				}
				Types.FavoriteCraftingMaterial other6 = other.favoriteCraftingMaterials_;
				favoriteCraftingMaterial2.MergeFrom(other6);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002640")]
		[Cpp2IlInjected.Address(RVA = "0x287C160", Offset = "0x287AB60", VA = "0x18287C160", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0195
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if (num == 66)
					{
						Types.FavoriteIngredient favoriteIngredient = favoriteIngredients_;
						if (favoriteIngredient == null)
						{
							Types.FavoriteIngredient favoriteIngredient2 = (favoriteIngredients_ = new Types.FavoriteIngredient());
						}
						input.ReadMessage(favoriteIngredient);
					}
					Types.FavoriteMineral favoriteMineral = default(Types.FavoriteMineral);
					if (num == 74)
					{
						Types.FavoriteMineral builder = default(Types.FavoriteMineral);
						if (favoriteMinerals_ == null)
						{
							favoriteMineral = (favoriteMinerals_ = new Types.FavoriteMineral());
							builder = favoriteMinerals_;
						}
						input.ReadMessage(builder);
					}
					if ((long)favoriteMineral != 82)
					{
						goto IL_017e;
					}
					Types.FavoriteCraftingMaterial builder2 = default(Types.FavoriteCraftingMaterial);
					if (favoriteCraftingMaterials_ == null)
					{
						Types.FavoriteCraftingMaterial favoriteCraftingMaterial = (favoriteCraftingMaterials_ = new Types.FavoriteCraftingMaterial());
						builder2 = favoriteCraftingMaterials_;
					}
					input.ReadMessage(builder2);
				}
				Types.FavoriteFlower favoriteFlower = default(Types.FavoriteFlower);
				if (num == 50)
				{
					Types.FavoriteFlower builder3 = default(Types.FavoriteFlower);
					if (favoriteFlowers_ == null)
					{
						favoriteFlower = (favoriteFlowers_ = new Types.FavoriteFlower());
						builder3 = favoriteFlowers_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)favoriteFlower != 58)
				{
					goto IL_017e;
				}
				Types.FavoriteMeal builder4 = default(Types.FavoriteMeal);
				if (favoriteMeals_ == null)
				{
					Types.FavoriteMeal favoriteMeal = (favoriteMeals_ = new Types.FavoriteMeal());
					builder4 = favoriteMeals_;
				}
				input.ReadMessage(builder4);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_017e;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text6 == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_017e;
			IL_017e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002641")]
		[Cpp2IlInjected.Address(RVA = "0x287BB90", Offset = "0x287A590", VA = "0x18287BB90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002642")]
		[Cpp2IlInjected.Address(RVA = "0x287C590", Offset = "0x287AF90", VA = "0x18287C590", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_002a, IL_0030, IL_0036, IL_003c, IL_0042, IL_0048, IL_004e, IL_0054
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002643")]
		[Cpp2IlInjected.Address(RVA = "0x287B750", Offset = "0x287A150", VA = "0x18287B750", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0014, IL_0015, IL_0016, IL_0018
			//IL_0012: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num <= 9)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002645")]
		[Cpp2IlInjected.Address(RVA = "0x287B880", Offset = "0x287A280", VA = "0x18287B880", Slot = "20")]
		IItemData IItemData.Clone()
		{
			PreferencePoolItemData preferencePoolItemData = new PreferencePoolItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002646")]
		[Cpp2IlInjected.Address(RVA = "0x287CB40", Offset = "0x287B540", VA = "0x18287CB40")]
		static PreferencePoolItemData()
		{
			Func<PreferencePoolItemData> func = default(Func<PreferencePoolItemData>);
			_parser = (MessageParser<PreferencePoolItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
