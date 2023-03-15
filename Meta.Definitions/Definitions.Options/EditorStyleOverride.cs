using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200077D")]
	public sealed class EditorStyleOverride : IMessage<EditorStyleOverride>, IMessage, IEquatable<EditorStyleOverride>, IDeepCloneable<EditorStyleOverride>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200077E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200077F")]
			public enum FieldDisplayDirection
			{
				[Cpp2IlInjected.Token(Token = "0x400257C")]
				[OriginalName("None")]
				None,
				[Cpp2IlInjected.Token(Token = "0x400257D")]
				[OriginalName("Row")]
				Row,
				[Cpp2IlInjected.Token(Token = "0x400257E")]
				[OriginalName("Column")]
				Column
			}

			[Cpp2IlInjected.Token(Token = "0x2000780")]
			public enum UnityTextAnchor
			{
				[Cpp2IlInjected.Token(Token = "0x4002580")]
				[OriginalName("UpperLeft")]
				UpperLeft,
				[Cpp2IlInjected.Token(Token = "0x4002581")]
				[OriginalName("UpperCenter")]
				UpperCenter,
				[Cpp2IlInjected.Token(Token = "0x4002582")]
				[OriginalName("UpperRight")]
				UpperRight,
				[Cpp2IlInjected.Token(Token = "0x4002583")]
				[OriginalName("MiddleLeft")]
				MiddleLeft,
				[Cpp2IlInjected.Token(Token = "0x4002584")]
				[OriginalName("MiddleCenter")]
				MiddleCenter,
				[Cpp2IlInjected.Token(Token = "0x4002585")]
				[OriginalName("MiddleRight")]
				MiddleRight,
				[Cpp2IlInjected.Token(Token = "0x4002586")]
				[OriginalName("LowerLeft")]
				LowerLeft,
				[Cpp2IlInjected.Token(Token = "0x4002587")]
				[OriginalName("LowerCenter")]
				LowerCenter,
				[Cpp2IlInjected.Token(Token = "0x4002588")]
				[OriginalName("LowerRight")]
				LowerRight
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400252E")]
		private static readonly MessageParser<EditorStyleOverride> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400252F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002530")]
		public const int FieldDirectionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002531")]
		private Types.FieldDisplayDirection fieldDirection_;

		[Cpp2IlInjected.Token(Token = "0x4002532")]
		public const int TooltipFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002533")]
		private static readonly FieldCodec<string> _single_tooltip_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002534")]
		private string tooltip_;

		[Cpp2IlInjected.Token(Token = "0x4002535")]
		public const int FlexBasisFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4002536")]
		private static readonly FieldCodec<float?> _single_flexBasis_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002537")]
		private float? flexBasis_;

		[Cpp2IlInjected.Token(Token = "0x4002538")]
		public const int FlexGrowFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4002539")]
		private static readonly FieldCodec<float?> _single_flexGrow_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400253A")]
		private float? flexGrow_;

		[Cpp2IlInjected.Token(Token = "0x400253B")]
		public const int FlexShrinkFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400253C")]
		private static readonly FieldCodec<float?> _single_flexShrink_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400253D")]
		private float? flexShrink_;

		[Cpp2IlInjected.Token(Token = "0x400253E")]
		public const int MinWidthFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400253F")]
		private static readonly FieldCodec<int?> _single_minWidth_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002540")]
		private int? minWidth_;

		[Cpp2IlInjected.Token(Token = "0x4002541")]
		public const int MaxWidthFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4002542")]
		private static readonly FieldCodec<int?> _single_maxWidth_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002543")]
		private int? maxWidth_;

		[Cpp2IlInjected.Token(Token = "0x4002544")]
		public const int MinHeightFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4002545")]
		private static readonly FieldCodec<int?> _single_minHeight_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002546")]
		private int? minHeight_;

		[Cpp2IlInjected.Token(Token = "0x4002547")]
		public const int MaxHeightFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4002548")]
		private static readonly FieldCodec<int?> _single_maxHeight_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002549")]
		private int? maxHeight_;

		[Cpp2IlInjected.Token(Token = "0x400254A")]
		public const int MarginLeftFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x400254B")]
		private static readonly FieldCodec<int?> _single_marginLeft_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400254C")]
		private int? marginLeft_;

		[Cpp2IlInjected.Token(Token = "0x400254D")]
		public const int MarginTopFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x400254E")]
		private static readonly FieldCodec<int?> _single_marginTop_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400254F")]
		private int? marginTop_;

		[Cpp2IlInjected.Token(Token = "0x4002550")]
		public const int MarginRightFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4002551")]
		private static readonly FieldCodec<int?> _single_marginRight_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002552")]
		private int? marginRight_;

		[Cpp2IlInjected.Token(Token = "0x4002553")]
		public const int MarginBottomFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4002554")]
		private static readonly FieldCodec<int?> _single_marginBottom_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002555")]
		private int? marginBottom_;

		[Cpp2IlInjected.Token(Token = "0x4002556")]
		public const int PaddingLeftFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x4002557")]
		private static readonly FieldCodec<int?> _single_paddingLeft_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002558")]
		private int? paddingLeft_;

		[Cpp2IlInjected.Token(Token = "0x4002559")]
		public const int PaddingTopFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x400255A")]
		private static readonly FieldCodec<int?> _single_paddingTop_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400255B")]
		private int? paddingTop_;

		[Cpp2IlInjected.Token(Token = "0x400255C")]
		public const int PaddingRightFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x400255D")]
		private static readonly FieldCodec<int?> _single_paddingRight_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400255E")]
		private int? paddingRight_;

		[Cpp2IlInjected.Token(Token = "0x400255F")]
		public const int PaddingBottomFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4002560")]
		private static readonly FieldCodec<int?> _single_paddingBottom_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002561")]
		private int? paddingBottom_;

		[Cpp2IlInjected.Token(Token = "0x4002562")]
		public const int ColorFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x4002563")]
		private static readonly FieldCodec<string> _single_color_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002564")]
		private string color_;

		[Cpp2IlInjected.Token(Token = "0x4002565")]
		public const int BackgroundColorFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x4002566")]
		private static readonly FieldCodec<string> _single_backgroundColor_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002567")]
		private string backgroundColor_;

		[Cpp2IlInjected.Token(Token = "0x4002568")]
		public const int FontSizeFieldNumber = 24;

		[Cpp2IlInjected.Token(Token = "0x4002569")]
		private static readonly FieldCodec<int?> _single_fontSize_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400256A")]
		private int? fontSize_;

		[Cpp2IlInjected.Token(Token = "0x400256B")]
		public const int TextAlignFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400256C")]
		private Types.UnityTextAnchor textAlign_;

		[Cpp2IlInjected.Token(Token = "0x400256D")]
		public const int LabelMinWidthFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x400256E")]
		private static readonly FieldCodec<int?> _single_labelMinWidth_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400256F")]
		private int? labelMinWidth_;

		[Cpp2IlInjected.Token(Token = "0x4002570")]
		public const int LabelColorFieldNumber = 32;

		[Cpp2IlInjected.Token(Token = "0x4002571")]
		private static readonly FieldCodec<string> _single_labelColor_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002572")]
		private string labelColor_;

		[Cpp2IlInjected.Token(Token = "0x4002573")]
		public const int LabelBackgroundColorFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x4002574")]
		private static readonly FieldCodec<string> _single_labelBackgroundColor_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002575")]
		private string labelBackgroundColor_;

		[Cpp2IlInjected.Token(Token = "0x4002576")]
		public const int LabelFontSizeFieldNumber = 34;

		[Cpp2IlInjected.Token(Token = "0x4002577")]
		private static readonly FieldCodec<int?> _single_labelFontSize_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002578")]
		private int? labelFontSize_;

		[Cpp2IlInjected.Token(Token = "0x4002579")]
		public const int LabelTextAlignFieldNumber = 35;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400257A")]
		private Types.UnityTextAnchor labelTextAlign_;

		[Cpp2IlInjected.Token(Token = "0x170014E4")]
		[DebuggerNonUserCode]
		public static MessageParser<EditorStyleOverride> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005295")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B790", Offset = "0x2C9A190", VA = "0x182C9B790")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005296")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B6B0", Offset = "0x2C9A0B0", VA = "0x182C9B6B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005297")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B7F0", Offset = "0x2C9A1F0", VA = "0x182C9B7F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E7")]
		[DebuggerNonUserCode]
		public Types.FieldDisplayDirection FieldDirection
		{
			[Cpp2IlInjected.Token(Token = "0x600529B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return fieldDirection_;
			}
			[Cpp2IlInjected.Token(Token = "0x600529C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				fieldDirection_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E8")]
		[DebuggerNonUserCode]
		public string Tooltip
		{
			[Cpp2IlInjected.Token(Token = "0x600529D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return tooltip_;
			}
			[Cpp2IlInjected.Token(Token = "0x600529E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				tooltip_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E9")]
		[DebuggerNonUserCode]
		public float? FlexBasis
		{
			[Cpp2IlInjected.Token(Token = "0x600529F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return flexBasis_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052A0")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set
			{
				flexBasis_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EA")]
		[DebuggerNonUserCode]
		public float? FlexGrow
		{
			[Cpp2IlInjected.Token(Token = "0x60052A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return flexGrow_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052A2")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
			set
			{
				flexGrow_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EB")]
		[DebuggerNonUserCode]
		public float? FlexShrink
		{
			[Cpp2IlInjected.Token(Token = "0x60052A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return flexShrink_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B2EF0", Offset = "0x7B18F0", VA = "0x1807B2EF0")]
			set
			{
				flexShrink_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EC")]
		[DebuggerNonUserCode]
		public int? MinWidth
		{
			[Cpp2IlInjected.Token(Token = "0x60052A5")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return minWidth_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052A6")]
			[Cpp2IlInjected.Address(RVA = "0xA62710", Offset = "0xA61110", VA = "0x180A62710")]
			set
			{
				minWidth_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014ED")]
		[DebuggerNonUserCode]
		public int? MaxWidth
		{
			[Cpp2IlInjected.Token(Token = "0x60052A7")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return maxWidth_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052A8")]
			[Cpp2IlInjected.Address(RVA = "0x70BFD0", Offset = "0x70A9D0", VA = "0x18070BFD0")]
			set
			{
				maxWidth_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EE")]
		[DebuggerNonUserCode]
		public int? MinHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60052A9")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return minHeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052AA")]
			[Cpp2IlInjected.Address(RVA = "0x70BA20", Offset = "0x70A420", VA = "0x18070BA20")]
			set
			{
				minHeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014EF")]
		[DebuggerNonUserCode]
		public int? MaxHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60052AB")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return maxHeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B00", Offset = "0x7F5500", VA = "0x1807F6B00")]
			set
			{
				maxHeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F0")]
		[DebuggerNonUserCode]
		public int? MarginLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60052AD")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return marginLeft_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052AE")]
			[Cpp2IlInjected.Address(RVA = "0x1542C90", Offset = "0x1541690", VA = "0x181542C90")]
			set
			{
				marginLeft_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F1")]
		[DebuggerNonUserCode]
		public int? MarginTop
		{
			[Cpp2IlInjected.Token(Token = "0x60052AF")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return marginTop_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052B0")]
			[Cpp2IlInjected.Address(RVA = "0x70CF60", Offset = "0x70B960", VA = "0x18070CF60")]
			set
			{
				marginTop_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F2")]
		[DebuggerNonUserCode]
		public int? MarginRight
		{
			[Cpp2IlInjected.Token(Token = "0x60052B1")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return marginRight_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052B2")]
			[Cpp2IlInjected.Address(RVA = "0x70CDD0", Offset = "0x70B7D0", VA = "0x18070CDD0")]
			set
			{
				marginRight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F3")]
		[DebuggerNonUserCode]
		public int? MarginBottom
		{
			[Cpp2IlInjected.Token(Token = "0x60052B3")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return marginBottom_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052B4")]
			[Cpp2IlInjected.Address(RVA = "0x26B7D50", Offset = "0x26B6750", VA = "0x1826B7D50")]
			set
			{
				marginBottom_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F4")]
		[DebuggerNonUserCode]
		public int? PaddingLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60052B5")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return paddingLeft_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052B6")]
			[Cpp2IlInjected.Address(RVA = "0x70CF80", Offset = "0x70B980", VA = "0x18070CF80")]
			set
			{
				paddingLeft_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F5")]
		[DebuggerNonUserCode]
		public int? PaddingTop
		{
			[Cpp2IlInjected.Token(Token = "0x60052B7")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return paddingTop_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052B8")]
			[Cpp2IlInjected.Address(RVA = "0x70CE70", Offset = "0x70B870", VA = "0x18070CE70")]
			set
			{
				paddingTop_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F6")]
		[DebuggerNonUserCode]
		public int? PaddingRight
		{
			[Cpp2IlInjected.Token(Token = "0x60052B9")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return paddingRight_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052BA")]
			[Cpp2IlInjected.Address(RVA = "0x20AB6F0", Offset = "0x20AA0F0", VA = "0x1820AB6F0")]
			set
			{
				paddingRight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F7")]
		[DebuggerNonUserCode]
		public int? PaddingBottom
		{
			[Cpp2IlInjected.Token(Token = "0x60052BB")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return paddingBottom_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052BC")]
			[Cpp2IlInjected.Address(RVA = "0xD2D650", Offset = "0xD2C050", VA = "0x180D2D650")]
			set
			{
				paddingBottom_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F8")]
		[DebuggerNonUserCode]
		public string Color
		{
			[Cpp2IlInjected.Token(Token = "0x60052BD")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return color_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052BE")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			set
			{
				color_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014F9")]
		[DebuggerNonUserCode]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60052BF")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return backgroundColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052C0")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			set
			{
				backgroundColor_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FA")]
		[DebuggerNonUserCode]
		public int? FontSize
		{
			[Cpp2IlInjected.Token(Token = "0x60052C1")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return fontSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052C2")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B900", Offset = "0x2C9A300", VA = "0x182C9B900")]
			set
			{
				fontSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FB")]
		[DebuggerNonUserCode]
		public Types.UnityTextAnchor TextAlign
		{
			[Cpp2IlInjected.Token(Token = "0x60052C3")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCF0", Offset = "0xD2E6F0", VA = "0x180D2FCF0")]
			get
			{
				return textAlign_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052C4")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD30", Offset = "0xD2E730", VA = "0x180D2FD30")]
			set
			{
				textAlign_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FC")]
		[DebuggerNonUserCode]
		public int? LabelMinWidth
		{
			[Cpp2IlInjected.Token(Token = "0x60052C5")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B780", Offset = "0x2C9A180", VA = "0x182C9B780")]
			get
			{
				return labelMinWidth_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052C6")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B920", Offset = "0x2C9A320", VA = "0x182C9B920")]
			set
			{
				labelMinWidth_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FD")]
		[DebuggerNonUserCode]
		public string LabelColor
		{
			[Cpp2IlInjected.Token(Token = "0x60052C7")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return labelColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052C8")]
			[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
			set
			{
				labelColor_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FE")]
		[DebuggerNonUserCode]
		public string LabelBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60052C9")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return labelBackgroundColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052CA")]
			[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
			set
			{
				labelBackgroundColor_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014FF")]
		[DebuggerNonUserCode]
		public int? LabelFontSize
		{
			[Cpp2IlInjected.Token(Token = "0x60052CB")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return labelFontSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052CC")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B910", Offset = "0x2C9A310", VA = "0x182C9B910")]
			set
			{
				labelFontSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001500")]
		[DebuggerNonUserCode]
		public Types.UnityTextAnchor LabelTextAlign
		{
			[Cpp2IlInjected.Token(Token = "0x60052CD")]
			[Cpp2IlInjected.Address(RVA = "0x7DAFE0", Offset = "0x7D99E0", VA = "0x1807DAFE0")]
			get
			{
				return labelTextAlign_;
			}
			[Cpp2IlInjected.Token(Token = "0x60052CE")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4C0", Offset = "0x7D9EC0", VA = "0x1807DB4C0")]
			set
			{
				labelTextAlign_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005298")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public EditorStyleOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005299")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B520", Offset = "0x2C99F20", VA = "0x182C9B520")]
		[DebuggerNonUserCode]
		public EditorStyleOverride(EditorStyleOverride other)
		{
			Types.FieldDisplayDirection fieldDisplayDirection = (fieldDirection_ = other.fieldDirection_);
			string text = (tooltip_ = other.tooltip_);
			float? num = (flexBasis_ = other.flexBasis_);
			float? num2 = (flexGrow_ = other.flexGrow_);
			float? num3 = (flexShrink_ = other.flexShrink_);
			int? num4 = (minWidth_ = other.minWidth_);
			int? num5 = (maxWidth_ = other.maxWidth_);
			int? num6 = (minHeight_ = other.minHeight_);
			int? num7 = (maxHeight_ = other.maxHeight_);
			int? num8 = (marginLeft_ = other.marginLeft_);
			int? num9 = (marginTop_ = other.marginTop_);
			int? num10 = (marginRight_ = other.marginRight_);
			int? num11 = (marginBottom_ = other.marginBottom_);
			int? num12 = (paddingLeft_ = other.paddingLeft_);
			int? num13 = (paddingTop_ = other.paddingTop_);
			int? num14 = (paddingRight_ = other.paddingRight_);
			int? num15 = (paddingBottom_ = other.paddingBottom_);
			string text2 = (color_ = other.color_);
			string text3 = (backgroundColor_ = other.backgroundColor_);
			int? num16 = (fontSize_ = other.fontSize_);
			Types.UnityTextAnchor unityTextAnchor = (textAlign_ = other.textAlign_);
			int? num17 = (labelMinWidth_ = other.labelMinWidth_);
			string text4 = (labelColor_ = other.labelColor_);
			string text5 = (labelBackgroundColor_ = other.labelBackgroundColor_);
			int? num18 = (labelFontSize_ = other.labelFontSize_);
			Types.UnityTextAnchor unityTextAnchor2 = (labelTextAlign_ = other.labelTextAlign_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600529A")]
		[Cpp2IlInjected.Address(RVA = "0x2C97A10", Offset = "0x2C96410", VA = "0x182C97A10", Slot = "10")]
		[DebuggerNonUserCode]
		public EditorStyleOverride Clone()
		{
			//Discarded unreachable code: IL_01b7
			EditorStyleOverride editorStyleOverride = new EditorStyleOverride();
			Types.FieldDisplayDirection fieldDisplayDirection = (editorStyleOverride.fieldDirection_ = fieldDirection_);
			string text = (editorStyleOverride.tooltip_ = tooltip_);
			float? num = (editorStyleOverride.flexBasis_ = flexBasis_);
			float? num2 = (editorStyleOverride.flexGrow_ = flexGrow_);
			float? num3 = (editorStyleOverride.flexShrink_ = flexShrink_);
			int? num4 = (editorStyleOverride.minWidth_ = minWidth_);
			int? num5 = (editorStyleOverride.maxWidth_ = maxWidth_);
			int? num6 = (editorStyleOverride.minHeight_ = minHeight_);
			int? num7 = (editorStyleOverride.maxHeight_ = maxHeight_);
			int? num8 = (editorStyleOverride.marginLeft_ = marginLeft_);
			int? num9 = (editorStyleOverride.marginTop_ = marginTop_);
			int? num10 = (editorStyleOverride.marginRight_ = marginRight_);
			int? num11 = (editorStyleOverride.marginBottom_ = marginBottom_);
			int? num12 = (editorStyleOverride.paddingLeft_ = paddingLeft_);
			int? num13 = (editorStyleOverride.paddingTop_ = paddingTop_);
			int? num14 = (editorStyleOverride.paddingRight_ = paddingRight_);
			int? num15 = (editorStyleOverride.paddingBottom_ = paddingBottom_);
			string text2 = (editorStyleOverride.color_ = color_);
			string text3 = (editorStyleOverride.backgroundColor_ = backgroundColor_);
			int? num16 = (editorStyleOverride.fontSize_ = fontSize_);
			Types.UnityTextAnchor unityTextAnchor = (editorStyleOverride.textAlign_ = textAlign_);
			int? num17 = (editorStyleOverride.labelMinWidth_ = labelMinWidth_);
			string text4 = (editorStyleOverride.labelColor_ = labelColor_);
			string text5 = (editorStyleOverride.labelBackgroundColor_ = labelBackgroundColor_);
			int? num18 = (editorStyleOverride.labelFontSize_ = labelFontSize_);
			Types.UnityTextAnchor unityTextAnchor2 = (editorStyleOverride.labelTextAlign_ = labelTextAlign_);
			UnknownFieldSet unknownFieldSet = (editorStyleOverride._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return editorStyleOverride;
		}

		[Cpp2IlInjected.Token(Token = "0x60052CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C97BD0", Offset = "0x2C965D0", VA = "0x182C97BD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((EditorStyleOverride)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60052D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C97C30", Offset = "0x2C96630", VA = "0x182C97C30", Slot = "9")]
		[DebuggerNonUserCode]
		public unsafe bool Equals(EditorStyleOverride other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.FieldDisplayDirection fieldDisplayDirection = other.fieldDirection_;
				if ((IntPtr)_single_flexGrow_codec == (IntPtr)(void*)(int)fieldDisplayDirection)
				{
					string text = other.tooltip_;
					if (!(tooltip_ != text))
					{
						int? num = minWidth_;
						int? num2 = other.minWidth_;
						bool flag = (object)num == (object)num2;
						if ((object)num == (object)num2 != flag)
						{
							int? num3 = maxWidth_;
							int? num4 = other.maxWidth_;
							bool flag2 = (object)num3 == (object)num4;
							if ((object)num3 == (object)num4 != flag2)
							{
								int? num5 = minHeight_;
								int? num6 = other.minHeight_;
								bool flag3 = (object)num5 == (object)num6;
								if ((object)num5 == (object)num6 != flag3)
								{
									int? num7 = maxHeight_;
									int? num8 = other.maxHeight_;
									bool flag4 = (object)num7 == (object)num8;
									if ((object)num7 == (object)num8 != flag4)
									{
										int? num9 = marginLeft_;
										int? num10 = other.marginLeft_;
										bool flag5 = (object)num9 == (object)num10;
										if ((object)num9 == (object)num10 != flag5)
										{
											int? num11 = marginTop_;
											int? num12 = other.marginTop_;
											bool flag6 = (object)num11 == (object)num12;
											if ((object)num11 == (object)num12 != flag6)
											{
												int? num13 = marginRight_;
												int? num14 = other.marginRight_;
												bool flag7 = (object)num13 == (object)num14;
												if ((object)num13 == (object)num14 != flag7)
												{
													int? num15 = marginBottom_;
													int? num16 = other.marginBottom_;
													bool flag8 = (object)num15 == (object)num16;
													if ((object)num15 == (object)num16 != flag8)
													{
														int? num17 = paddingLeft_;
														int? num18 = other.paddingLeft_;
														bool flag9 = (object)num17 == (object)num18;
														if ((object)num17 == (object)num18 != flag9)
														{
															int? num19 = paddingTop_;
															int? num20 = other.paddingTop_;
															bool flag10 = (object)num19 == (object)num20;
															if ((object)num19 == (object)num20 != flag10)
															{
																int? num21 = paddingRight_;
																int? num22 = other.paddingRight_;
																bool flag11 = (object)num21 == (object)num22;
																if ((object)num21 == (object)num22 != flag11)
																{
																	int? num23 = paddingBottom_;
																	int? num24 = other.paddingBottom_;
																	bool flag12 = (object)num23 == (object)num24;
																	if ((object)num23 == (object)num24 != flag12)
																	{
																		string text2 = other.color_;
																		if (!(color_ != text2))
																		{
																			string text3 = other.backgroundColor_;
																			if (!(backgroundColor_ != text3))
																			{
																				int? num25 = fontSize_;
																				int? num26 = other.fontSize_;
																				bool flag13 = (object)num25 == (object)num26;
																				if ((object)num25 == (object)num26 != flag13)
																				{
																					Types.UnityTextAnchor unityTextAnchor = other.textAlign_;
																					if ((IntPtr)_single_labelFontSize_codec == (IntPtr)(void*)(int)unityTextAnchor)
																					{
																						int? num27 = labelMinWidth_;
																						int? num28 = other.labelMinWidth_;
																						bool flag14 = (object)num27 == (object)num28;
																						if ((object)num27 == (object)num28 != flag14)
																						{
																							string text4 = other.labelColor_;
																							if (!(labelColor_ != text4))
																							{
																								string text5 = other.labelBackgroundColor_;
																								if (!(labelBackgroundColor_ != text5))
																								{
																									int? num29 = labelFontSize_;
																									int? num30 = other.labelFontSize_;
																									bool flag15 = (object)num29 == (object)num30;
																									if ((object)num29 == (object)num30 != flag15)
																									{
																										Types.UnityTextAnchor unityTextAnchor2 = other.labelTextAlign_;
																										if (labelTextAlign_ == unityTextAnchor2)
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
				}
			}
			int num31 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60052D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C98490", Offset = "0x2C96E90", VA = "0x182C98490", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f9
			if (fieldDirection_ != 0)
			{
			}
			string text = tooltip_;
			if (text != null)
			{
				int hashCode = text.GetHashCode();
			}
			EqualityComparer<float?> _003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer;
			float? obj = flexBasis_;
			int hashCode2 = ((EqualityComparer<T>)(object)_003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)obj);
			EqualityComparer<float?> _003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer;
			float? obj2 = flexGrow_;
			int hashCode3 = ((EqualityComparer<T>)(object)_003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)obj2);
			EqualityComparer<float?> _003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField3 = ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer;
			float? obj3 = flexShrink_;
			int hashCode4 = ((EqualityComparer<T>)(object)_003CBitwiseNullableSingleEqualityComparer_003Ek__BackingField3).GetHashCode((T)obj3);
			string text2 = color_;
			if (text2 != null)
			{
				int hashCode5 = text2.GetHashCode();
			}
			string text3 = backgroundColor_;
			if (text3 != null)
			{
				int hashCode6 = text3.GetHashCode();
			}
			if (textAlign_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text3)->ResultCode;
			}
			string text4 = labelColor_;
			if (text4 != null)
			{
				int hashCode7 = text4.GetHashCode();
			}
			string text5 = labelBackgroundColor_;
			if (text5 != null)
			{
				int hashCode8 = text5.GetHashCode();
			}
			if (labelTextAlign_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60052D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A630", Offset = "0x2C99030", VA = "0x182C9A630", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60052D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A690", Offset = "0x2C99090", VA = "0x182C9A690", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_02a3
			if ((long)_single_flexGrow_codec != 0)
			{
			}
			if ((long)tooltip_ != 0)
			{
				FieldCodec<string> single_tooltip_codec = _single_tooltip_codec;
				string value = tooltip_;
				((FieldCodec<T>)(object)single_tooltip_codec).WriteTagAndValue(output, (T)value);
			}
			FieldCodec<float?> single_flexBasis_codec = _single_flexBasis_codec;
			float? value2 = flexBasis_;
			((FieldCodec<T>)(object)single_flexBasis_codec).WriteTagAndValue(output, (T)value2);
			FieldCodec<float?> single_flexGrow_codec = _single_flexGrow_codec;
			float? value3 = flexGrow_;
			((FieldCodec<T>)(object)single_flexGrow_codec).WriteTagAndValue(output, (T)value3);
			FieldCodec<float?> single_flexShrink_codec = _single_flexShrink_codec;
			float? value4 = flexShrink_;
			((FieldCodec<T>)(object)single_flexShrink_codec).WriteTagAndValue(output, (T)value4);
			FieldCodec<int?> single_minWidth_codec = _single_minWidth_codec;
			int? value5 = minWidth_;
			((FieldCodec<T>)(object)single_minWidth_codec).WriteTagAndValue(output, (T)value5);
			FieldCodec<int?> single_maxWidth_codec = _single_maxWidth_codec;
			int? value6 = maxWidth_;
			((FieldCodec<T>)(object)single_maxWidth_codec).WriteTagAndValue(output, (T)value6);
			FieldCodec<int?> single_minHeight_codec = _single_minHeight_codec;
			int? value7 = minHeight_;
			((FieldCodec<T>)(object)single_minHeight_codec).WriteTagAndValue(output, (T)value7);
			FieldCodec<int?> single_maxHeight_codec = _single_maxHeight_codec;
			int? value8 = maxHeight_;
			((FieldCodec<T>)(object)single_maxHeight_codec).WriteTagAndValue(output, (T)value8);
			FieldCodec<int?> single_marginLeft_codec = _single_marginLeft_codec;
			int? value9 = marginLeft_;
			((FieldCodec<T>)(object)single_marginLeft_codec).WriteTagAndValue(output, (T)value9);
			FieldCodec<int?> single_marginTop_codec = _single_marginTop_codec;
			int? value10 = marginTop_;
			((FieldCodec<T>)(object)single_marginTop_codec).WriteTagAndValue(output, (T)value10);
			FieldCodec<int?> single_marginRight_codec = _single_marginRight_codec;
			int? value11 = marginRight_;
			((FieldCodec<T>)(object)single_marginRight_codec).WriteTagAndValue(output, (T)value11);
			FieldCodec<int?> single_marginBottom_codec = _single_marginBottom_codec;
			int? value12 = marginBottom_;
			((FieldCodec<T>)(object)single_marginBottom_codec).WriteTagAndValue(output, (T)value12);
			FieldCodec<int?> single_paddingLeft_codec = _single_paddingLeft_codec;
			int? value13 = paddingLeft_;
			((FieldCodec<T>)(object)single_paddingLeft_codec).WriteTagAndValue(output, (T)value13);
			FieldCodec<int?> single_paddingTop_codec = _single_paddingTop_codec;
			int? value14 = paddingTop_;
			((FieldCodec<T>)(object)single_paddingTop_codec).WriteTagAndValue(output, (T)value14);
			FieldCodec<int?> single_paddingRight_codec = _single_paddingRight_codec;
			int? value15 = paddingRight_;
			((FieldCodec<T>)(object)single_paddingRight_codec).WriteTagAndValue(output, (T)value15);
			FieldCodec<int?> single_paddingBottom_codec = _single_paddingBottom_codec;
			int? value16 = paddingBottom_;
			((FieldCodec<T>)(object)single_paddingBottom_codec).WriteTagAndValue(output, (T)value16);
			if ((long)_single_labelMinWidth_codec != 0)
			{
				FieldCodec<string> single_color_codec = _single_color_codec;
				string value17 = color_;
				((FieldCodec<T>)(object)single_color_codec).WriteTagAndValue(output, (T)value17);
			}
			if ((long)backgroundColor_ != 0)
			{
				FieldCodec<string> single_backgroundColor_codec = _single_backgroundColor_codec;
				string value18 = backgroundColor_;
				((FieldCodec<T>)(object)single_backgroundColor_codec).WriteTagAndValue(output, (T)value18);
			}
			FieldCodec<int?> single_fontSize_codec = _single_fontSize_codec;
			int? value19 = fontSize_;
			((FieldCodec<T>)(object)single_fontSize_codec).WriteTagAndValue(output, (T)value19);
			if ((long)_single_labelFontSize_codec != 0)
			{
			}
			FieldCodec<int?> single_labelMinWidth_codec = _single_labelMinWidth_codec;
			int? value20 = labelMinWidth_;
			((FieldCodec<T>)(object)single_labelMinWidth_codec).WriteTagAndValue(output, (T)value20);
			if ((long)labelColor_ != 0)
			{
				FieldCodec<string> single_labelColor_codec = _single_labelColor_codec;
				string value21 = labelColor_;
				((FieldCodec<T>)(object)single_labelColor_codec).WriteTagAndValue(output, (T)value21);
			}
			if ((long)labelBackgroundColor_ != 0)
			{
				FieldCodec<string> single_labelBackgroundColor_codec = _single_labelBackgroundColor_codec;
				string value22 = labelBackgroundColor_;
				((FieldCodec<T>)(object)single_labelBackgroundColor_codec).WriteTagAndValue(output, (T)value22);
			}
			FieldCodec<int?> single_labelFontSize_codec = _single_labelFontSize_codec;
			int? value23 = labelFontSize_;
			((FieldCodec<T>)(object)single_labelFontSize_codec).WriteTagAndValue(output, (T)value23);
			if (labelTextAlign_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60052D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C96EF0", Offset = "0x2C958F0", VA = "0x182C96EF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0353
			Types.FieldDisplayDirection fieldDisplayDirection = fieldDirection_;
			int num = 0;
			if (fieldDisplayDirection != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)fieldDisplayDirection);
			}
			if (tooltip_ != null)
			{
				string value = tooltip_;
				int num3 = ((FieldCodec<T>)(object)_single_tooltip_codec).CalculateSizeWithTag((T)value);
				num += num3;
			}
			FieldCodec<float?> single_flexBasis_codec = _single_flexBasis_codec;
			float? value2 = flexBasis_;
			int num4 = ((FieldCodec<T>)(object)single_flexBasis_codec).CalculateSizeWithTag((T)value2);
			num += num4;
			FieldCodec<float?> single_flexGrow_codec = _single_flexGrow_codec;
			float? value3 = flexGrow_;
			int num5 = ((FieldCodec<T>)(object)single_flexGrow_codec).CalculateSizeWithTag((T)value3);
			num += num5;
			FieldCodec<float?> single_flexShrink_codec = _single_flexShrink_codec;
			float? value4 = flexShrink_;
			int num6 = ((FieldCodec<T>)(object)single_flexShrink_codec).CalculateSizeWithTag((T)value4);
			num += num6;
			FieldCodec<int?> single_minWidth_codec = _single_minWidth_codec;
			int? value5 = minWidth_;
			int num7 = ((FieldCodec<T>)(object)single_minWidth_codec).CalculateSizeWithTag((T)value5);
			num += num7;
			FieldCodec<int?> single_maxWidth_codec = _single_maxWidth_codec;
			int? value6 = maxWidth_;
			int num8 = ((FieldCodec<T>)(object)single_maxWidth_codec).CalculateSizeWithTag((T)value6);
			num += num8;
			FieldCodec<int?> single_minHeight_codec = _single_minHeight_codec;
			int? value7 = minHeight_;
			int num9 = ((FieldCodec<T>)(object)single_minHeight_codec).CalculateSizeWithTag((T)value7);
			num += num9;
			FieldCodec<int?> single_maxHeight_codec = _single_maxHeight_codec;
			int? value8 = maxHeight_;
			int num10 = ((FieldCodec<T>)(object)single_maxHeight_codec).CalculateSizeWithTag((T)value8);
			num += num10;
			FieldCodec<int?> single_marginLeft_codec = _single_marginLeft_codec;
			int? value9 = marginLeft_;
			int num11 = ((FieldCodec<T>)(object)single_marginLeft_codec).CalculateSizeWithTag((T)value9);
			num += num11;
			FieldCodec<int?> single_marginTop_codec = _single_marginTop_codec;
			int? value10 = marginTop_;
			int num12 = ((FieldCodec<T>)(object)single_marginTop_codec).CalculateSizeWithTag((T)value10);
			num += num12;
			FieldCodec<int?> single_marginRight_codec = _single_marginRight_codec;
			int? value11 = marginRight_;
			int num13 = ((FieldCodec<T>)(object)single_marginRight_codec).CalculateSizeWithTag((T)value11);
			num += num13;
			FieldCodec<int?> single_marginBottom_codec = _single_marginBottom_codec;
			int? value12 = marginBottom_;
			int num14 = ((FieldCodec<T>)(object)single_marginBottom_codec).CalculateSizeWithTag((T)value12);
			num += num14;
			FieldCodec<int?> single_paddingLeft_codec = _single_paddingLeft_codec;
			int? value13 = paddingLeft_;
			int num15 = ((FieldCodec<T>)(object)single_paddingLeft_codec).CalculateSizeWithTag((T)value13);
			num += num15;
			FieldCodec<int?> single_paddingTop_codec = _single_paddingTop_codec;
			int? value14 = paddingTop_;
			int num16 = ((FieldCodec<T>)(object)single_paddingTop_codec).CalculateSizeWithTag((T)value14);
			num += num16;
			FieldCodec<int?> single_paddingRight_codec = _single_paddingRight_codec;
			int? value15 = paddingRight_;
			int num17 = ((FieldCodec<T>)(object)single_paddingRight_codec).CalculateSizeWithTag((T)value15);
			num += num17;
			FieldCodec<int?> single_paddingBottom_codec = _single_paddingBottom_codec;
			int? value16 = paddingBottom_;
			int num18 = ((FieldCodec<T>)(object)single_paddingBottom_codec).CalculateSizeWithTag((T)value16);
			num += num18;
			if (color_ != null)
			{
				string value17 = color_;
				int num19 = ((FieldCodec<T>)(object)_single_color_codec).CalculateSizeWithTag((T)value17);
				num += num19;
			}
			if (backgroundColor_ != null)
			{
				string value18 = backgroundColor_;
				int num20 = ((FieldCodec<T>)(object)_single_backgroundColor_codec).CalculateSizeWithTag((T)value18);
				num += num20;
			}
			FieldCodec<int?> single_fontSize_codec = _single_fontSize_codec;
			int? value19 = fontSize_;
			int num21 = ((FieldCodec<T>)(object)single_fontSize_codec).CalculateSizeWithTag((T)value19);
			num += num21;
			Types.UnityTextAnchor unityTextAnchor = textAlign_;
			if (unityTextAnchor != 0)
			{
				int num22 = CodedOutputStream.ComputeEnumSize((int)unityTextAnchor);
				num22 += 2;
				num += num22;
			}
			FieldCodec<int?> single_labelMinWidth_codec = _single_labelMinWidth_codec;
			int? value20 = labelMinWidth_;
			int num23 = ((FieldCodec<T>)(object)single_labelMinWidth_codec).CalculateSizeWithTag((T)value20);
			num += num23;
			if (labelColor_ != null)
			{
				string value21 = labelColor_;
				int num24 = ((FieldCodec<T>)(object)_single_labelColor_codec).CalculateSizeWithTag((T)value21);
				num += num24;
			}
			if (labelBackgroundColor_ != null)
			{
				string value22 = labelBackgroundColor_;
				int num25 = ((FieldCodec<T>)(object)_single_labelBackgroundColor_codec).CalculateSizeWithTag((T)value22);
				num += num25;
			}
			FieldCodec<int?> single_labelFontSize_codec = _single_labelFontSize_codec;
			int? value23 = labelFontSize_;
			int num26 = ((FieldCodec<T>)(object)single_labelFontSize_codec).CalculateSizeWithTag((T)value23);
			num += num26;
			Types.UnityTextAnchor unityTextAnchor2 = labelTextAlign_;
			if (unityTextAnchor2 != 0)
			{
				int num27 = CodedOutputStream.ComputeEnumSize((int)unityTextAnchor2);
				num27 += 2;
				num += num27;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num28 = unknownFields.CalculateSize();
				num += num28;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60052D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C99770", Offset = "0x2C98170", VA = "0x182C99770", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(EditorStyleOverride other)
		{
			if (other != null)
			{
				Types.FieldDisplayDirection fieldDisplayDirection = other.fieldDirection_;
				if (fieldDisplayDirection != 0)
				{
					fieldDirection_ = fieldDisplayDirection;
				}
				string text = other.tooltip_;
				if (text != null && ((long)tooltip_ == 0 || text != ""))
				{
					string text2 = (tooltip_ = other.tooltip_);
				}
				int num = 0;
				float? num2 = other.flexBasis_;
				if ((IntPtr)num == (IntPtr)num2)
				{
					float? num3 = (flexBasis_ = other.flexBasis_);
				}
				float? num4 = other.flexGrow_;
				if ((IntPtr)num == (IntPtr)num4)
				{
					float? num5 = (flexGrow_ = other.flexGrow_);
				}
				float? num6 = other.flexShrink_;
				if ((IntPtr)num == (IntPtr)num6)
				{
					float? num7 = (flexShrink_ = other.flexShrink_);
				}
				int? num8 = other.minWidth_;
				if ((IntPtr)(((object)num8 == null) ? 1 : 0) == (IntPtr)(void*)num8)
				{
					int? num9 = (minWidth_ = other.minWidth_);
				}
				int? num10 = other.maxWidth_;
				if ((IntPtr)(((object)num10 == null) ? 1 : 0) == (IntPtr)(void*)num10)
				{
					int? num11 = (maxWidth_ = other.maxWidth_);
				}
				int? num12 = other.minHeight_;
				if ((IntPtr)(((object)num12 == null) ? 1 : 0) == (IntPtr)(void*)num12)
				{
					int? num13 = (minHeight_ = other.minHeight_);
				}
				int? num14 = other.maxHeight_;
				if ((IntPtr)(((object)num14 == null) ? 1 : 0) == (IntPtr)(void*)num14)
				{
					int? num15 = (maxHeight_ = other.maxHeight_);
				}
				int? num16 = other.marginLeft_;
				if ((IntPtr)(((object)num16 == null) ? 1 : 0) == (IntPtr)(void*)num16)
				{
					int? num17 = (marginLeft_ = other.marginLeft_);
				}
				int? num18 = other.marginTop_;
				if ((IntPtr)(((object)num18 == null) ? 1 : 0) == (IntPtr)(void*)num18)
				{
					int? num19 = (marginTop_ = other.marginTop_);
				}
				int? num20 = other.marginRight_;
				if ((IntPtr)(((object)num20 == null) ? 1 : 0) == (IntPtr)(void*)num20)
				{
					int? num21 = (marginRight_ = other.marginRight_);
				}
				int? num22 = other.marginBottom_;
				if ((IntPtr)(((object)num22 == null) ? 1 : 0) == (IntPtr)(void*)num22)
				{
					int? num23 = (marginBottom_ = other.marginBottom_);
				}
				int? num24 = other.paddingLeft_;
				if ((IntPtr)(((object)num24 == null) ? 1 : 0) == (IntPtr)(void*)num24)
				{
					int? num25 = (paddingLeft_ = other.paddingLeft_);
				}
				int? num26 = other.paddingTop_;
				if ((IntPtr)(((object)num26 == null) ? 1 : 0) == (IntPtr)(void*)num26)
				{
					int? num27 = (paddingTop_ = other.paddingTop_);
				}
				int? num28 = other.paddingRight_;
				if ((IntPtr)(((object)num28 == null) ? 1 : 0) == (IntPtr)(void*)num28)
				{
					int? num29 = (paddingRight_ = other.paddingRight_);
				}
				int? num30 = other.paddingBottom_;
				if ((IntPtr)(((object)num30 == null) ? 1 : 0) == (IntPtr)(void*)num30)
				{
					int? num31 = (paddingBottom_ = other.paddingBottom_);
				}
				string text3 = other.color_;
				if (text3 != null && ((IntPtr)_single_labelMinWidth_codec == (IntPtr)num || text3 != ""))
				{
					string text4 = (color_ = other.color_);
				}
				string text5 = other.backgroundColor_;
				if (text5 != null && ((IntPtr)backgroundColor_ == (IntPtr)num || text5 != ""))
				{
					string text6 = (backgroundColor_ = other.backgroundColor_);
				}
				int? num32 = other.fontSize_;
				if ((IntPtr)(((object)num32 == null) ? 1 : 0) == (IntPtr)(void*)num32)
				{
					int? num33 = (fontSize_ = other.fontSize_);
				}
				Types.UnityTextAnchor unityTextAnchor = other.textAlign_;
				if (unityTextAnchor != 0)
				{
					textAlign_ = unityTextAnchor;
				}
				int? num34 = other.labelMinWidth_;
				if ((IntPtr)(((object)num34 == null) ? 1 : 0) == (IntPtr)(void*)num34)
				{
					int? num35 = (labelMinWidth_ = other.labelMinWidth_);
				}
				string text7 = other.labelColor_;
				if (text7 != null && ((IntPtr)labelColor_ == (IntPtr)num || text7 != ""))
				{
					string text8 = (labelColor_ = other.labelColor_);
				}
				string text9 = other.labelBackgroundColor_;
				if (text9 != null && ((IntPtr)labelBackgroundColor_ == (IntPtr)num || text9 != ""))
				{
					string text10 = (labelBackgroundColor_ = other.labelBackgroundColor_);
				}
				int? num36 = other.labelFontSize_;
				if ((IntPtr)(((object)num36 == null) ? 1 : 0) == (IntPtr)(void*)num36)
				{
					int? num37 = (labelFontSize_ = other.labelFontSize_);
				}
				Types.UnityTextAnchor unityTextAnchor2 = other.labelTextAlign_;
				if (unityTextAnchor2 != 0)
				{
					labelTextAlign_ = unityTextAnchor2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C989F0", Offset = "0x2C973F0", VA = "0x182C989F0", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_04d9
			bool flag = default(bool);
			int? num4 = default(int?);
			int num5 = default(int);
			int? num7 = default(int?);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			int? num8 = default(int?);
			int? num9 = default(int?);
			int? num11 = default(int?);
			int? num12 = default(int?);
			int? num13 = default(int?);
			int? num14 = default(int?);
			int? num15 = default(int?);
			int? num16 = default(int?);
			int? num17 = default(int?);
			float? num18 = default(float?);
			float? num19 = default(float?);
			int? num20 = default(int?);
			int num21 = default(int);
			bool flag4 = default(bool);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((int)num > 138)
				{
					if ((int)num > 186)
					{
						if ((int)num > 250)
						{
							if ((int)num > 266)
							{
								if (num == 274)
								{
									int? num2 = (int?)((FieldCodec<T>)(object)_single_labelFontSize_codec).Read(input);
									if ((IntPtr)(((object)num2 == null) ? 1 : 0) != (IntPtr)(void*)num2)
									{
										continue;
									}
									labelFontSize_ = num2;
								}
								if (num != 280)
								{
									goto IL_04c2;
								}
								int num3 = (int)(labelTextAlign_ = (Types.UnityTextAnchor)input.ReadInt32());
							}
							if (num == 258)
							{
								string text = (string)((FieldCodec<T>)(object)_single_labelColor_codec).Read(input);
								if ((long)labelColor_ != 0)
								{
									flag = text != "";
									while (!flag)
									{
									}
								}
								labelColor_ = text;
							}
							if (!flag)
							{
								goto IL_04c2;
							}
							string text2 = (string)((FieldCodec<T>)(object)_single_labelBackgroundColor_codec).Read(input);
							if ((long)labelBackgroundColor_ != 0 && !(text2 != ""))
							{
								continue;
							}
							labelBackgroundColor_ = text2;
						}
						if (num == 194)
						{
							num4 = (int?)((FieldCodec<T>)(object)_single_fontSize_codec).Read(input);
							if ((IntPtr)(((object)num4 == null) ? 1 : 0) != (IntPtr)(void*)num4)
							{
								continue;
							}
							fontSize_ = num4;
						}
						if ((long)num4 == 200)
						{
							num5 = (int)(textAlign_ = (Types.UnityTextAnchor)input.ReadInt32());
						}
						if (num5 != 250)
						{
							goto IL_04c2;
						}
						int? num6 = (int?)((FieldCodec<T>)(object)_single_labelMinWidth_codec).Read(input);
						if ((IntPtr)(((object)num6 == null) ? 1 : 0) != (IntPtr)(void*)num6)
						{
							continue;
						}
						labelMinWidth_ = num6;
					}
					if ((int)num > 162)
					{
						if (num == 170)
						{
							num7 = (int?)((FieldCodec<T>)(object)_single_paddingBottom_codec).Read(input);
							if ((IntPtr)(((object)num7 == null) ? 1 : 0) != (IntPtr)(void*)num7)
							{
								continue;
							}
							paddingBottom_ = num7;
						}
						if ((long)num7 == 178)
						{
							string text3 = (string)((FieldCodec<T>)(object)_single_color_codec).Read(input);
							if ((long)_single_labelMinWidth_codec != 0)
							{
								flag2 = text3 != "";
								while (!flag2)
								{
								}
							}
							color_ = text3;
						}
						if (!flag2)
						{
							goto IL_04c2;
						}
						string text4 = (string)((FieldCodec<T>)(object)_single_backgroundColor_codec).Read(input);
						if ((long)backgroundColor_ != 0)
						{
							flag3 = text4 != "";
							while (!flag3)
							{
							}
						}
						backgroundColor_ = text4;
					}
					if (flag3)
					{
						num8 = (int?)((FieldCodec<T>)(object)_single_paddingLeft_codec).Read(input);
						if ((IntPtr)(((object)num8 == null) ? 1 : 0) != (IntPtr)(void*)num8)
						{
							continue;
						}
						paddingLeft_ = num8;
					}
					if ((long)num8 == 154)
					{
						num9 = (int?)((FieldCodec<T>)(object)_single_paddingTop_codec).Read(input);
						if ((IntPtr)(((object)num9 == null) ? 1 : 0) != (IntPtr)(void*)num9)
						{
							continue;
						}
						paddingTop_ = num9;
					}
					if ((long)num9 != 162)
					{
						goto IL_04c2;
					}
					int? num10 = (int?)((FieldCodec<T>)(object)_single_paddingRight_codec).Read(input);
					if ((IntPtr)(((object)num10 == null) ? 1 : 0) != (IntPtr)(void*)num10)
					{
						continue;
					}
					paddingRight_ = num10;
				}
				if ((int)num > 82)
				{
					if ((int)num > 106)
					{
						if ((int)num > 122)
						{
							if (num == 130)
							{
								num11 = (int?)((FieldCodec<T>)(object)_single_marginRight_codec).Read(input);
								if ((IntPtr)(((object)num11 == null) ? 1 : 0) != (IntPtr)(void*)num11)
								{
									continue;
								}
								marginRight_ = num11;
							}
							if ((long)num11 != 138)
							{
								goto IL_04c2;
							}
							num12 = (int?)((FieldCodec<T>)(object)_single_marginBottom_codec).Read(input);
							if ((IntPtr)(((object)num12 == null) ? 1 : 0) != (IntPtr)(void*)num12)
							{
								continue;
							}
							marginBottom_ = num12;
						}
						if ((long)num12 == 114)
						{
							num13 = (int?)((FieldCodec<T>)(object)_single_marginLeft_codec).Read(input);
							if ((IntPtr)(((object)num13 == null) ? 1 : 0) != (IntPtr)(void*)num13)
							{
								continue;
							}
							marginLeft_ = num13;
						}
						if ((long)num13 != 122)
						{
							goto IL_04c2;
						}
						num14 = (int?)((FieldCodec<T>)(object)_single_marginTop_codec).Read(input);
						if ((IntPtr)(((object)num14 == null) ? 1 : 0) != (IntPtr)(void*)num14)
						{
							continue;
						}
						marginTop_ = num14;
					}
					if ((long)num14 == 90)
					{
						num15 = (int?)((FieldCodec<T>)(object)_single_maxWidth_codec).Read(input);
						if ((IntPtr)(((object)num15 == null) ? 1 : 0) != (IntPtr)(void*)num15)
						{
							continue;
						}
						maxWidth_ = num15;
					}
					if ((long)num15 == 98)
					{
						num16 = (int?)((FieldCodec<T>)(object)_single_minHeight_codec).Read(input);
						if ((IntPtr)(((object)num16 == null) ? 1 : 0) != (IntPtr)(void*)num16)
						{
							continue;
						}
						minHeight_ = num16;
					}
					if ((long)num16 != 106)
					{
						goto IL_04c2;
					}
					num17 = (int?)((FieldCodec<T>)(object)_single_maxHeight_codec).Read(input);
					if ((IntPtr)(((object)num17 == null) ? 1 : 0) != (IntPtr)(void*)num17)
					{
						continue;
					}
					maxHeight_ = num17;
				}
				if ((long)num17 > 26)
				{
					if ((long)num17 == 34)
					{
						num18 = (float?)((FieldCodec<T>)(object)_single_flexGrow_codec).Read(input);
						if ((IntPtr)0 != (IntPtr)num18)
						{
							continue;
						}
						flexGrow_ = num18;
					}
					if ((long)num18 == 42)
					{
						num19 = (float?)((FieldCodec<T>)(object)_single_flexShrink_codec).Read(input);
						if ((IntPtr)0 != (IntPtr)num19)
						{
							continue;
						}
						flexShrink_ = num19;
					}
					if ((long)num19 != 82)
					{
						goto IL_04c2;
					}
					num20 = (int?)((FieldCodec<T>)(object)_single_minWidth_codec).Read(input);
					if ((IntPtr)(((object)num20 == null) ? 1 : 0) != (IntPtr)(void*)num20)
					{
						continue;
					}
					minWidth_ = num20;
				}
				if ((long)num20 == 8)
				{
					num21 = (int)(fieldDirection_ = (Types.FieldDisplayDirection)input.ReadInt32());
				}
				if (num21 == 18)
				{
					string text5 = (string)((FieldCodec<T>)(object)_single_tooltip_codec).Read(input);
					if ((long)tooltip_ != 0)
					{
						flag4 = text5 != "";
						while (!flag4)
						{
						}
					}
					tooltip_ = text5;
				}
				if (flag4)
				{
					float? num22 = (float?)((FieldCodec<T>)(object)_single_flexBasis_codec).Read(input);
					if ((IntPtr)0 != (IntPtr)num22)
					{
						continue;
					}
					flexBasis_ = num22;
				}
				goto IL_04c2;
				IL_04c2:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C98150", Offset = "0x2C96B50", VA = "0x182C98150", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 34)
			{
				string text = tooltip_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60052D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C99CF0", Offset = "0x2C986F0", VA = "0x182C99CF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_001c, IL_0024, IL_0028, IL_0030, IL_0034, IL_003c, IL_0040, IL_0048, IL_004c, IL_0054, IL_0058, IL_0060, IL_0064, IL_006c, IL_0070, IL_0078, IL_007c, IL_0084, IL_0088, IL_0090, IL_0094, IL_009c, IL_00a0, IL_00a8, IL_00ac, IL_00b4, IL_00b8, IL_00c0, IL_00c4, IL_00cc, IL_00d0, IL_00d8, IL_00dc, IL_00e3, IL_00e7, IL_00ee, IL_00f2, IL_00fa, IL_0102, IL_0106, IL_010e, IL_0112, IL_0119, IL_011d, IL_0124, IL_0128, IL_0130, IL_0138, IL_013e
			//IL_000e: Expected I4, but got O
			//IL_0023: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_0101: Expected I4, but got O
			//IL_010d: Expected O, but got I4
			//IL_012f: Expected O, but got I4
			//IL_0137: Expected I4, but got O
			if (fieldNumber - 1 <= 34)
			{
				object obj = default(object);
				fieldDirection_ = (Types.FieldDisplayDirection)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C97820", Offset = "0x2C96220", VA = "0x182C97820", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021
			//IL_000e: Expected I4, but got I8
			if (fieldNumber <= 34)
			{
				fieldDirection_ = Types.FieldDisplayDirection.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AFB0", Offset = "0x2C999B0", VA = "0x182C9AFB0")]
		static EditorStyleOverride()
		{
			Func<EditorStyleOverride> func = default(Func<EditorStyleOverride>);
			_parser = (MessageParser<EditorStyleOverride>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForClassWrapper<string>(num);
			uint num2 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<float>(num2);
			uint num3 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<float>(num3);
			uint num4 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<float>(num4);
			uint num5 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num5);
			uint num6 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num6);
			uint num7 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num7);
			uint num8 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num8);
			uint num9 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num9);
			uint num10 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num10);
			uint num11 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num11);
			uint num12 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num12);
			uint num13 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num13);
			uint num14 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num14);
			uint num15 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num15);
			uint num16 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num16);
			uint num17 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForClassWrapper<string>(num17);
			uint num18 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForClassWrapper<string>(num18);
			uint num19 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num19);
			uint num20 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num20);
			uint num21 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForClassWrapper<string>(num21);
			uint num22 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForClassWrapper<string>(num22);
			uint num23 = default(uint);
			_parser = (MessageParser<EditorStyleOverride>)(object)FieldCodec.ForStructWrapper<int>(num23);
			/*Error: Unexpected end of block*/;
		}
	}
}
