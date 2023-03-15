using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000798")]
	public sealed class MapFieldOptions : IMessage<MapFieldOptions>, IMessage, IEquatable<MapFieldOptions>, IDeepCloneable<MapFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000799")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200079A")]
			public sealed class KeyOptions : IMessage<KeyOptions>, IMessage, IEquatable<KeyOptions>, IDeepCloneable<KeyOptions>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002609")]
				private static readonly MessageParser<KeyOptions> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400260A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400260B")]
				public const int EnumTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400260C")]
				private string enumType_;

				[Cpp2IlInjected.Token(Token = "0x400260D")]
				public const int ItemFieldFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400260E")]
				private ItemFieldOptions itemField_;

				[Cpp2IlInjected.Token(Token = "0x400260F")]
				public const int LabelMinWidthFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4002610")]
				private static readonly FieldCodec<int?> _single_labelMinWidth_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002611")]
				private int? labelMinWidth_;

				[Cpp2IlInjected.Token(Token = "0x17001531")]
				[DebuggerNonUserCode]
				public static MessageParser<KeyOptions> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60053C5")]
					[Cpp2IlInjected.Address(RVA = "0x2FEFF80", Offset = "0x2FEE980", VA = "0x182FEFF80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001532")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60053C6")]
					[Cpp2IlInjected.Address(RVA = "0x2FEFF00", Offset = "0x2FEE900", VA = "0x182FEFF00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001533")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60053C7")]
					[Cpp2IlInjected.Address(RVA = "0x2FEFFE0", Offset = "0x2FEE9E0", VA = "0x182FEFFE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001534")]
				[DebuggerNonUserCode]
				public string EnumType
				{
					[Cpp2IlInjected.Token(Token = "0x60053CB")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053CC")]
					[Cpp2IlInjected.Address(RVA = "0x2FF00A0", Offset = "0x2FEEAA0", VA = "0x182FF00A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001535")]
				[DebuggerNonUserCode]
				public ItemFieldOptions ItemField
				{
					[Cpp2IlInjected.Token(Token = "0x60053CD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053CE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001536")]
				[DebuggerNonUserCode]
				public int? LabelMinWidth
				{
					[Cpp2IlInjected.Token(Token = "0x60053CF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053D0")]
					[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60053C8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEFEB0", Offset = "0x2FEE8B0", VA = "0x182FEFEB0")]
				[DebuggerNonUserCode]
				public KeyOptions()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053C9")]
				[Cpp2IlInjected.Address(RVA = "0x2FEFDF0", Offset = "0x2FEE7F0", VA = "0x182FEFDF0")]
				[DebuggerNonUserCode]
				public KeyOptions(KeyOptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053CA")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF260", Offset = "0x2FEDC60", VA = "0x182FEF260", Slot = "10")]
				[DebuggerNonUserCode]
				public KeyOptions Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60053D1")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF420", Offset = "0x2FEDE20", VA = "0x182FEF420", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60053D2")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF350", Offset = "0x2FEDD50", VA = "0x182FEF350", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(KeyOptions other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60053D3")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF620", Offset = "0x2FEE020", VA = "0x182FEF620", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60053D4")]
				[Cpp2IlInjected.Address(RVA = "0x2FEFB20", Offset = "0x2FEE520", VA = "0x182FEFB20", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60053D5")]
				[Cpp2IlInjected.Address(RVA = "0x2FEFB80", Offset = "0x2FEE580", VA = "0x182FEFB80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053D6")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF090", Offset = "0x2FEDA90", VA = "0x182FEF090", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60053D7")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF700", Offset = "0x2FEE100", VA = "0x182FEF700", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(KeyOptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053D8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF830", Offset = "0x2FEE230", VA = "0x182FEF830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053D9")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF540", Offset = "0x2FEDF40", VA = "0x182FEF540", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60053DA")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF9D0", Offset = "0x2FEE3D0", VA = "0x182FEF9D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053DB")]
				[Cpp2IlInjected.Address(RVA = "0x2FEF1D0", Offset = "0x2FEDBD0", VA = "0x182FEF1D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200079C")]
			public sealed class ValueOptions : IMessage<ValueOptions>, IMessage, IEquatable<ValueOptions>, IDeepCloneable<ValueOptions>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002613")]
				private static readonly MessageParser<ValueOptions> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002614")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002615")]
				public const int AddressableFieldFieldNumber = 50000;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002616")]
				private AddressableFieldOptions addressableField_;

				[Cpp2IlInjected.Token(Token = "0x4002617")]
				public const int ItemFieldFieldNumber = 50001;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002618")]
				private ItemFieldOptions itemField_;

				[Cpp2IlInjected.Token(Token = "0x4002619")]
				public const int DurationFieldFieldNumber = 50005;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400261A")]
				private DurationFieldOptions durationField_;

				[Cpp2IlInjected.Token(Token = "0x400261B")]
				public const int ColorFieldFieldNumber = 50006;

				[Cpp2IlInjected.Token(Token = "0x400261C")]
				private static readonly FieldCodec<bool?> _single_colorField_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400261D")]
				private bool? colorField_;

				[Cpp2IlInjected.Token(Token = "0x400261E")]
				public const int NumericFieldRangeFieldNumber = 50007;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400261F")]
				private NumericFieldRangeOptions numericFieldRange_;

				[Cpp2IlInjected.Token(Token = "0x4002620")]
				public const int LocalizedFieldFieldNumber = 50010;

				[Cpp2IlInjected.Token(Token = "0x4002621")]
				private static readonly FieldCodec<bool?> _single_localizedField_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002622")]
				private bool? localizedField_;

				[Cpp2IlInjected.Token(Token = "0x4002623")]
				public const int ChoiceFieldNumber = 50011;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4002624")]
				private ChoiceOptions choice_;

				[Cpp2IlInjected.Token(Token = "0x4002625")]
				public const int CustomEditorFieldNumber = 50012;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4002626")]
				private CustomEditorOptions customEditor_;

				[Cpp2IlInjected.Token(Token = "0x4002627")]
				public const int EditorStyleFieldNumber = 50013;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4002628")]
				private EditorStyleOverride editorStyle_;

				[Cpp2IlInjected.Token(Token = "0x4002629")]
				public const int FileChoiceFieldNumber = 50017;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x400262A")]
				private FileChoiceOptions fileChoice_;

				[Cpp2IlInjected.Token(Token = "0x400262B")]
				public const int EquationFieldFieldNumber = 50018;

				[Cpp2IlInjected.Token(Token = "0x400262C")]
				private static readonly FieldCodec<bool?> _single_equationField_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x400262D")]
				private bool? equationField_;

				[Cpp2IlInjected.Token(Token = "0x400262E")]
				public const int ProbabilityFieldNumber = 50023;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x400262F")]
				private ProbabilityOptions probability_;

				[Cpp2IlInjected.Token(Token = "0x4002630")]
				public const int OnlineChoiceFieldNumber = 50024;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4002631")]
				private OnlineChoiceOptions onlineChoice_;

				[Cpp2IlInjected.Token(Token = "0x4002632")]
				public const int LocalizedSentenceFieldNumber = 50025;

				[Cpp2IlInjected.Token(Token = "0x4002633")]
				private static readonly FieldCodec<bool?> _single_localizedSentence_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4002634")]
				private bool? localizedSentence_;

				[Cpp2IlInjected.Token(Token = "0x4002635")]
				public const int ProtoDatabaseFieldFieldNumber = 50026;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4002636")]
				private ProtoDatabaseFieldOptions protoDatabaseField_;

				[Cpp2IlInjected.Token(Token = "0x4002637")]
				public const int LocalizedEmptyFieldNumber = 50028;

				[Cpp2IlInjected.Token(Token = "0x4002638")]
				private static readonly FieldCodec<bool?> _single_localizedEmpty_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4002639")]
				private bool? localizedEmpty_;

				[Cpp2IlInjected.Token(Token = "0x400263A")]
				public const int LocalizedWithGenderFieldNumber = 50035;

				[Cpp2IlInjected.Token(Token = "0x400263B")]
				private static readonly FieldCodec<bool?> _single_localizedWithGender_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
				[Cpp2IlInjected.Token(Token = "0x400263C")]
				private bool? localizedWithGender_;

				[Cpp2IlInjected.Token(Token = "0x17001537")]
				[DebuggerNonUserCode]
				public static MessageParser<ValueOptions> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60053E0")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9C80", Offset = "0x2FF8680", VA = "0x182FF9C80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001538")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60053E1")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9BE0", Offset = "0x2FF85E0", VA = "0x182FF9BE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001539")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60053E2")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9CE0", Offset = "0x2FF86E0", VA = "0x182FF9CE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153A")]
				[DebuggerNonUserCode]
				public AddressableFieldOptions AddressableField
				{
					[Cpp2IlInjected.Token(Token = "0x60053E6")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053E7")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153B")]
				[DebuggerNonUserCode]
				public ItemFieldOptions ItemField
				{
					[Cpp2IlInjected.Token(Token = "0x60053E8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053E9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153C")]
				[DebuggerNonUserCode]
				public DurationFieldOptions DurationField
				{
					[Cpp2IlInjected.Token(Token = "0x60053EA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053EB")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153D")]
				[DebuggerNonUserCode]
				public bool? ColorField
				{
					[Cpp2IlInjected.Token(Token = "0x60053EC")]
					[Cpp2IlInjected.Address(RVA = "0x14F8C90", Offset = "0x14F7690", VA = "0x1814F8C90")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053ED")]
					[Cpp2IlInjected.Address(RVA = "0x14F8CA0", Offset = "0x14F76A0", VA = "0x1814F8CA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153E")]
				[DebuggerNonUserCode]
				public NumericFieldRangeOptions NumericFieldRange
				{
					[Cpp2IlInjected.Token(Token = "0x60053EE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053EF")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700153F")]
				[DebuggerNonUserCode]
				public bool? LocalizedField
				{
					[Cpp2IlInjected.Token(Token = "0x60053F0")]
					[Cpp2IlInjected.Address(RVA = "0x2251CD0", Offset = "0x22506D0", VA = "0x182251CD0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053F1")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9DB0", Offset = "0x2FF87B0", VA = "0x182FF9DB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001540")]
				[DebuggerNonUserCode]
				public ChoiceOptions Choice
				{
					[Cpp2IlInjected.Token(Token = "0x60053F2")]
					[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053F3")]
					[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001541")]
				[DebuggerNonUserCode]
				public CustomEditorOptions CustomEditor
				{
					[Cpp2IlInjected.Token(Token = "0x60053F4")]
					[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053F5")]
					[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001542")]
				[DebuggerNonUserCode]
				public EditorStyleOverride EditorStyle
				{
					[Cpp2IlInjected.Token(Token = "0x60053F6")]
					[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053F7")]
					[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001543")]
				[DebuggerNonUserCode]
				public FileChoiceOptions FileChoice
				{
					[Cpp2IlInjected.Token(Token = "0x60053F8")]
					[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053F9")]
					[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001544")]
				[DebuggerNonUserCode]
				public bool? EquationField
				{
					[Cpp2IlInjected.Token(Token = "0x60053FA")]
					[Cpp2IlInjected.Address(RVA = "0x184D3C0", Offset = "0x184BDC0", VA = "0x18184D3C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053FB")]
					[Cpp2IlInjected.Address(RVA = "0x184D460", Offset = "0x184BE60", VA = "0x18184D460")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001545")]
				[DebuggerNonUserCode]
				public ProbabilityOptions Probability
				{
					[Cpp2IlInjected.Token(Token = "0x60053FC")]
					[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053FD")]
					[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001546")]
				[DebuggerNonUserCode]
				public OnlineChoiceOptions OnlineChoice
				{
					[Cpp2IlInjected.Token(Token = "0x60053FE")]
					[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60053FF")]
					[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001547")]
				[DebuggerNonUserCode]
				public bool? LocalizedSentence
				{
					[Cpp2IlInjected.Token(Token = "0x6005400")]
					[Cpp2IlInjected.Address(RVA = "0x20B6140", Offset = "0x20B4B40", VA = "0x1820B6140")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005401")]
					[Cpp2IlInjected.Address(RVA = "0x20B61B0", Offset = "0x20B4BB0", VA = "0x1820B61B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001548")]
				[DebuggerNonUserCode]
				public ProtoDatabaseFieldOptions ProtoDatabaseField
				{
					[Cpp2IlInjected.Token(Token = "0x6005402")]
					[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005403")]
					[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001549")]
				[DebuggerNonUserCode]
				public bool? LocalizedEmpty
				{
					[Cpp2IlInjected.Token(Token = "0x6005404")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9C60", Offset = "0x2FF8660", VA = "0x182FF9C60")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005405")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9DA0", Offset = "0x2FF87A0", VA = "0x182FF9DA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700154A")]
				[DebuggerNonUserCode]
				public bool? LocalizedWithGender
				{
					[Cpp2IlInjected.Token(Token = "0x6005406")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9C70", Offset = "0x2FF8670", VA = "0x182FF9C70")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005407")]
					[Cpp2IlInjected.Address(RVA = "0x2FF9DC0", Offset = "0x2FF87C0", VA = "0x182FF9DC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60053E3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ValueOptions()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053E4")]
				[Cpp2IlInjected.Address(RVA = "0x2FF99A0", Offset = "0x2FF83A0", VA = "0x182FF99A0")]
				[DebuggerNonUserCode]
				public ValueOptions(ValueOptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60053E5")]
				[Cpp2IlInjected.Address(RVA = "0x2FF75E0", Offset = "0x2FF5FE0", VA = "0x182FF75E0", Slot = "10")]
				[DebuggerNonUserCode]
				public ValueOptions Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005408")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7920", Offset = "0x2FF6320", VA = "0x182FF7920", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005409")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7640", Offset = "0x2FF6040", VA = "0x182FF7640", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ValueOptions other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600540A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7BB0", Offset = "0x2FF65B0", VA = "0x182FF7BB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600540B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF9250", Offset = "0x2FF7C50", VA = "0x182FF9250", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600540C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF92B0", Offset = "0x2FF7CB0", VA = "0x182FF92B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600540D")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6F70", Offset = "0x2FF5970", VA = "0x182FF6F70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600540E")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7E30", Offset = "0x2FF6830", VA = "0x182FF7E30", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ValueOptions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600540F")]
				[Cpp2IlInjected.Address(RVA = "0x2FF83F0", Offset = "0x2FF6DF0", VA = "0x182FF83F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005410")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7980", Offset = "0x2FF6380", VA = "0x182FF7980", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005411")]
				[Cpp2IlInjected.Address(RVA = "0x2FF8BC0", Offset = "0x2FF75C0", VA = "0x182FF8BC0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005412")]
				[Cpp2IlInjected.Address(RVA = "0x2FF7450", Offset = "0x2FF5E50", VA = "0x182FF7450", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002603")]
		private static readonly MessageParser<MapFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002604")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002605")]
		public const int KeyFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002606")]
		private Types.KeyOptions key_;

		[Cpp2IlInjected.Token(Token = "0x4002607")]
		public const int ValueFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002608")]
		private Types.ValueOptions value_;

		[Cpp2IlInjected.Token(Token = "0x1700152C")]
		[DebuggerNonUserCode]
		public static MessageParser<MapFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60053AF")]
			[Cpp2IlInjected.Address(RVA = "0x3068650", Offset = "0x3067050", VA = "0x183068650")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60053B0")]
			[Cpp2IlInjected.Address(RVA = "0x3068580", Offset = "0x3066F80", VA = "0x183068580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60053B1")]
			[Cpp2IlInjected.Address(RVA = "0x30686B0", Offset = "0x30670B0", VA = "0x1830686B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152F")]
		[DebuggerNonUserCode]
		public Types.KeyOptions Key
		{
			[Cpp2IlInjected.Token(Token = "0x60053B5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return key_;
			}
			[Cpp2IlInjected.Token(Token = "0x60053B6")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				key_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001530")]
		[DebuggerNonUserCode]
		public Types.ValueOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60053B7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x60053B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				value_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053B2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MapFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60053B3")]
		[Cpp2IlInjected.Address(RVA = "0x30684E0", Offset = "0x3066EE0", VA = "0x1830684E0")]
		[DebuggerNonUserCode]
		public MapFieldOptions(MapFieldOptions other)
		{
			//IL_0021: Expected O, but got I4
			Types.KeyOptions keyOptions = other.key_;
			int num = 0;
			if (keyOptions != null)
			{
				Types.KeyOptions keyOptions2 = keyOptions.Clone();
			}
			key_ = (Types.KeyOptions)num;
			Types.ValueOptions valueOptions = other.value_;
			Types.ValueOptions valueOptions2 = default(Types.ValueOptions);
			if (valueOptions != null)
			{
				valueOptions2 = valueOptions.Clone();
			}
			value_ = valueOptions2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053B4")]
		[Cpp2IlInjected.Address(RVA = "0x3067E20", Offset = "0x3066820", VA = "0x183067E20", Slot = "10")]
		[DebuggerNonUserCode]
		public MapFieldOptions Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			MapFieldOptions mapFieldOptions = new MapFieldOptions();
			Types.KeyOptions keyOptions = key_;
			int num = 0;
			if (keyOptions != null)
			{
				Types.KeyOptions keyOptions2 = keyOptions.Clone();
			}
			mapFieldOptions.key_ = (Types.KeyOptions)num;
			Types.ValueOptions valueOptions = value_;
			Types.ValueOptions valueOptions2 = default(Types.ValueOptions);
			if (valueOptions != null)
			{
				valueOptions2 = valueOptions.Clone();
			}
			mapFieldOptions.value_ = valueOptions2;
			UnknownFieldSet unknownFieldSet = (mapFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return mapFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x60053B9")]
		[Cpp2IlInjected.Address(RVA = "0x3067EF0", Offset = "0x30668F0", VA = "0x183067EF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(key_, other) && object.Equals(value_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053BA")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MapFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.KeyOptions objB = other.key_;
				if (object.Equals(key_, objB))
				{
					Types.ValueOptions objB2 = other.value_;
					if (object.Equals(value_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053BB")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Types.KeyOptions keyOptions = key_;
				if (keyOptions != null)
				{
					int hashCode = keyOptions.GetHashCode();
				}
				Types.ValueOptions valueOptions = value_;
				if (valueOptions != null)
				{
					int hashCode2 = valueOptions.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60053BC")]
		[Cpp2IlInjected.Address(RVA = "0x3068370", Offset = "0x3066D70", VA = "0x183068370", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60053BD")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)key_ != 0)
			{
				Types.KeyOptions value = key_;
				output.WriteMessage(value);
			}
			if ((long)value_ != 0)
			{
				Types.ValueOptions value2 = value_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60053BE")]
		[Cpp2IlInjected.Address(RVA = "0x3067D50", Offset = "0x3066750", VA = "0x183067D50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.KeyOptions keyOptions = key_;
				num = 0;
				if (keyOptions != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(keyOptions);
				}
				Types.ValueOptions valueOptions = value_;
				if (valueOptions != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(valueOptions);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60053BF")]
		[Cpp2IlInjected.Address(RVA = "0x3068180", Offset = "0x3066B80", VA = "0x183068180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MapFieldOptions other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.key_ != 0)
			{
				Types.KeyOptions keyOptions = key_;
				if (keyOptions == null)
				{
					Types.KeyOptions keyOptions2 = (key_ = new Types.KeyOptions());
					Types.KeyOptions keyOptions3 = key_;
				}
				Types.KeyOptions other2 = other.key_;
				keyOptions.MergeFrom(other2);
			}
			if ((long)other.value_ != 0)
			{
				Types.ValueOptions valueOptions2 = default(Types.ValueOptions);
				if (value_ == null)
				{
					Types.ValueOptions valueOptions = (value_ = new Types.ValueOptions());
					valueOptions2 = value_;
				}
				Types.ValueOptions other3 = other.value_;
				valueOptions2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60053C0")]
		[Cpp2IlInjected.Address(RVA = "0x3068040", Offset = "0x3066A40", VA = "0x183068040", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.KeyOptions keyOptions = key_;
				if (keyOptions == null)
				{
					Types.KeyOptions keyOptions2 = (key_ = new Types.KeyOptions());
				}
				input.ReadMessage(keyOptions);
			}
			if (num == 18)
			{
				Types.ValueOptions builder = default(Types.ValueOptions);
				if (value_ == null)
				{
					Types.ValueOptions valueOptions = (value_ = new Types.ValueOptions());
					builder = value_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60053C1")]
		[Cpp2IlInjected.Address(RVA = "0x3067FB0", Offset = "0x30669B0", VA = "0x183067FB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.KeyOptions keyOptions = key_;
			}
			if (fieldNumber == 2)
			{
				Types.ValueOptions valueOptions = value_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60053C2")]
		[Cpp2IlInjected.Address(RVA = "0x30682B0", Offset = "0x3066CB0", VA = "0x1830682B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					key_ = (Types.KeyOptions)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053C3")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053C4")]
		[Cpp2IlInjected.Address(RVA = "0x30683D0", Offset = "0x3066DD0", VA = "0x1830683D0")]
		static MapFieldOptions()
		{
			Func<MapFieldOptions> func = default(Func<MapFieldOptions>);
			_parser = (MessageParser<MapFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
