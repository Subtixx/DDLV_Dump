using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004A3")]
	public sealed class CustomStepTakePicture : IMessage<CustomStepTakePicture>, IMessage, IEquatable<CustomStepTakePicture>, IDeepCloneable<CustomStepTakePicture>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IItemSelector, IItemAmount, IBuildingMapMarker, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004A4")]
		public enum ItemOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40018E1")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40018E2")]
			TargetCharacter,
			[Cpp2IlInjected.Token(Token = "0x40018E3")]
			TargetItem,
			[Cpp2IlInjected.Token(Token = "0x40018E4")]
			TargetGroup,
			[Cpp2IlInjected.Token(Token = "0x40018E5")]
			TargetDifferent,
			[Cpp2IlInjected.Token(Token = "0x40018E6")]
			TargetGarden
		}

		[Cpp2IlInjected.Token(Token = "0x20004A5")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004A6")]
			public sealed class TakePictureItemsList : IMessage<TakePictureItemsList>, IMessage, IEquatable<TakePictureItemsList>, IDeepCloneable<TakePictureItemsList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40018E7")]
				private static readonly MessageParser<TakePictureItemsList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40018E8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40018E9")]
				public const int ItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40018EA")]
				private static readonly FieldCodec<int> _repeated_items_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40018EB")]
				private readonly RepeatedField<int> items_;

				[Cpp2IlInjected.Token(Token = "0x17000E98")]
				[DebuggerNonUserCode]
				public static MessageParser<TakePictureItemsList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600392E")]
					[Cpp2IlInjected.Address(RVA = "0x294C490", Offset = "0x294AE90", VA = "0x18294C490")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000E99")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600392F")]
					[Cpp2IlInjected.Address(RVA = "0x294C410", Offset = "0x294AE10", VA = "0x18294C410")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000E9A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003930")]
					[Cpp2IlInjected.Address(RVA = "0x294C4F0", Offset = "0x294AEF0", VA = "0x18294C4F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000E9B")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Items
				{
					[Cpp2IlInjected.Token(Token = "0x6003934")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003931")]
				[Cpp2IlInjected.Address(RVA = "0x294C290", Offset = "0x294AC90", VA = "0x18294C290")]
				[DebuggerNonUserCode]
				public TakePictureItemsList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003932")]
				[Cpp2IlInjected.Address(RVA = "0x294C310", Offset = "0x294AD10", VA = "0x18294C310")]
				[DebuggerNonUserCode]
				public TakePictureItemsList(TakePictureItemsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003933")]
				[Cpp2IlInjected.Address(RVA = "0x294BB40", Offset = "0x294A540", VA = "0x18294BB40", Slot = "10")]
				[DebuggerNonUserCode]
				public TakePictureItemsList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003935")]
				[Cpp2IlInjected.Address(RVA = "0x294BC70", Offset = "0x294A670", VA = "0x18294BC70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003936")]
				[Cpp2IlInjected.Address(RVA = "0x294BD50", Offset = "0x294A750", VA = "0x18294BD50", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TakePictureItemsList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003937")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003938")]
				[Cpp2IlInjected.Address(RVA = "0x294C030", Offset = "0x294AA30", VA = "0x18294C030", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003939")]
				[Cpp2IlInjected.Address(RVA = "0x294C090", Offset = "0x294AA90", VA = "0x18294C090", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600393A")]
				[Cpp2IlInjected.Address(RVA = "0x294BA30", Offset = "0x294A430", VA = "0x18294BA30", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600393B")]
				[Cpp2IlInjected.Address(RVA = "0x294BF50", Offset = "0x294A950", VA = "0x18294BF50", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TakePictureItemsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600393C")]
				[Cpp2IlInjected.Address(RVA = "0x294BE60", Offset = "0x294A860", VA = "0x18294BE60", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600393D")]
				[Cpp2IlInjected.Address(RVA = "0x294BDE0", Offset = "0x294A7E0", VA = "0x18294BDE0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600393E")]
				[Cpp2IlInjected.Address(RVA = "0x294BFD0", Offset = "0x294A9D0", VA = "0x18294BFD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600393F")]
				[Cpp2IlInjected.Address(RVA = "0x294BAE0", Offset = "0x294A4E0", VA = "0x18294BAE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40018CF")]
		private static readonly MessageParser<CustomStepTakePicture> _parser = (MessageParser<CustomStepTakePicture>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomStepTakePicture()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018D0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018D1")]
		public const int TargetCharacterFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40018D2")]
		public const int TargetItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40018D3")]
		public const int TargetGroupFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40018D4")]
		public const int TargetDifferentFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40018D5")]
		public const int TargetGardenFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40018D6")]
		public const int UseDifferentItemFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018D7")]
		private bool useDifferentItem_;

		[Cpp2IlInjected.Token(Token = "0x40018D8")]
		public const int LocationFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018D9")]
		private OptionalField location_;

		[Cpp2IlInjected.Token(Token = "0x40018DA")]
		public const int AmountOfItemsFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018DB")]
		private StepAmount amountOfItems_;

		[Cpp2IlInjected.Token(Token = "0x40018DC")]
		public const int AmountOfPicturesFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018DD")]
		private StepAmount amountOfPictures_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40018DE")]
		private object item_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40018DF")]
		private ItemOneofCase itemCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E87")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepTakePicture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60038FB")]
			[Cpp2IlInjected.Address(RVA = "0x3205590", Offset = "0x3203F90", VA = "0x183205590")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E88")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038FC")]
			[Cpp2IlInjected.Address(RVA = "0x32053D0", Offset = "0x3203DD0", VA = "0x1832053D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E89")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038FD")]
			[Cpp2IlInjected.Address(RVA = "0x3205AC0", Offset = "0x32044C0", VA = "0x183205AC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8A")]
		[DebuggerNonUserCode]
		public ItemSelector TargetCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6003902")]
			[Cpp2IlInjected.Address(RVA = "0x32058E0", Offset = "0x32042E0", VA = "0x1832058E0")]
			get
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetCharacter)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003903")]
			[Cpp2IlInjected.Address(RVA = "0x3205BD0", Offset = "0x32045D0", VA = "0x183205BD0")]
			set
			{
				item_ = value;
				bool flag = (byte)(itemCase_ = ((value != null) ? ItemOneofCase.TargetCharacter : ItemOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8B")]
		[DebuggerNonUserCode]
		public AnyItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003904")]
			[Cpp2IlInjected.Address(RVA = "0x3205A60", Offset = "0x3204460", VA = "0x183205A60")]
			get
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetItem)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003905")]
			[Cpp2IlInjected.Address(RVA = "0x3205C50", Offset = "0x3204650", VA = "0x183205C50")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8C")]
		[DebuggerNonUserCode]
		public Types.TakePictureItemsList TargetGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6003906")]
			[Cpp2IlInjected.Address(RVA = "0x3205A00", Offset = "0x3204400", VA = "0x183205A00")]
			get
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetGroup)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003907")]
			[Cpp2IlInjected.Address(RVA = "0x3205C10", Offset = "0x3204610", VA = "0x183205C10")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8D")]
		[DebuggerNonUserCode]
		public Types.TakePictureItemsList TargetDifferent
		{
			[Cpp2IlInjected.Token(Token = "0x6003908")]
			[Cpp2IlInjected.Address(RVA = "0x3205940", Offset = "0x3204340", VA = "0x183205940")]
			get
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetDifferent)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003909")]
			[Cpp2IlInjected.Address(RVA = "0x2D59100", Offset = "0x2D57B00", VA = "0x182D59100")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8E")]
		[DebuggerNonUserCode]
		public ItemSelector TargetGarden
		{
			[Cpp2IlInjected.Token(Token = "0x600390A")]
			[Cpp2IlInjected.Address(RVA = "0x32059A0", Offset = "0x32043A0", VA = "0x1832059A0")]
			get
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetGarden)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600390B")]
			[Cpp2IlInjected.Address(RVA = "0x1D306E0", Offset = "0x1D2F0E0", VA = "0x181D306E0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8F")]
		[DebuggerNonUserCode]
		public bool UseDifferentItem
		{
			[Cpp2IlInjected.Token(Token = "0x600390C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useDifferentItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x600390D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useDifferentItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E90")]
		[DebuggerNonUserCode]
		public OptionalField Location
		{
			[Cpp2IlInjected.Token(Token = "0x600390E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x600390F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E91")]
		[DebuggerNonUserCode]
		public StepAmount AmountOfItems
		{
			[Cpp2IlInjected.Token(Token = "0x6003910")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return amountOfItems_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003911")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				amountOfItems_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E92")]
		[DebuggerNonUserCode]
		public StepAmount AmountOfPictures
		{
			[Cpp2IlInjected.Token(Token = "0x6003912")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return amountOfPictures_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003913")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				amountOfPictures_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E93")]
		[DebuggerNonUserCode]
		public ItemOneofCase ItemCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003914")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return itemCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E94")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003923")]
			[Cpp2IlInjected.Address(RVA = "0x32056D0", Offset = "0x32040D0", VA = "0x1832056D0", Slot = "20")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[1] = "TargetAmount";
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[2] = "CurrentAmount";
						if ("ItemAmount" == null || "ItemAmount" != null)
						{
							break;
						}
					}
				}
				array[3] = "ItemAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E95")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003924")]
			[Cpp2IlInjected.Address(RVA = "0x32054B0", Offset = "0x3203EB0", VA = "0x1832054B0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0016, IL_0031, IL_003d, IL_0044
				if (itemCase_ != ItemOneofCase.TargetCharacter)
				{
					return new ItemSelector();
				}
				return TargetGarden;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E96")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003925")]
			[Cpp2IlInjected.Address(RVA = "0x32055F0", Offset = "0x3203FF0", VA = "0x1832055F0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0020
				if (itemCase_ != ItemOneofCase.TargetDifferent)
				{
					return amountOfPictures_;
				}
				int value = default(int);
				if (item_ != null)
				{
					return new StepAmount(value);
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E97")]
		public StepAmount ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003926")]
			[Cpp2IlInjected.Address(RVA = "0x32054A0", Offset = "0x3203EA0", VA = "0x1832054A0", Slot = "18")]
			get
			{
				if (itemCase_ == ItemOneofCase.TargetItem)
				{
					return amountOfItems_;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FE")]
		[Cpp2IlInjected.Address(RVA = "0x32052E0", Offset = "0x3203CE0", VA = "0x1832052E0")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture()
		{
			location_ = new OptionalField
			{
				useField_ = false,
				Scene = SceneType.Village,
				showRandomCheckbox_ = false
			};
			StepAmount stepAmount = (amountOfItems_ = new StepAmount());
			StepAmount stepAmount2 = (amountOfPictures_ = new StepAmount());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038FF")]
		[Cpp2IlInjected.Address(RVA = "0x32046C0", Offset = "0x32030C0", VA = "0x1832046C0")]
		private void OnConstruction()
		{
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			optionalField.Scene = SceneType.Village;
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			StepAmount stepAmount = (amountOfItems_ = new StepAmount());
			StepAmount stepAmount2 = (amountOfPictures_ = new StepAmount());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003900")]
		[Cpp2IlInjected.Address(RVA = "0x3204FD0", Offset = "0x32039D0", VA = "0x183204FD0")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture(CustomStepTakePicture other)
		{
			//IL_0071: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00f1: Expected I4, but got O
			//IL_010e: Expected I4, but got O
			//IL_012b: Expected I4, but got O
			//IL_0148: Expected I4, but got O
			location_ = new OptionalField
			{
				useField_ = false,
				Scene = SceneType.Village,
				showRandomCheckbox_ = false
			};
			StepAmount stepAmount = (amountOfItems_ = new StepAmount());
			StepAmount stepAmount2 = (amountOfPictures_ = new StepAmount());
			bool flag = other.useDifferentItem_;
			int num = 0;
			useDifferentItem_ = flag;
			OptionalField optionalField = other.location_;
			if (optionalField != null)
			{
				OptionalField optionalField2 = optionalField.Clone();
			}
			location_ = (OptionalField)num;
			StepAmount stepAmount3 = other.amountOfItems_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			amountOfItems_ = (StepAmount)num;
			StepAmount stepAmount5 = other.amountOfPictures_;
			if (stepAmount5 != null)
			{
				StepAmount stepAmount6 = stepAmount5.Clone();
			}
			amountOfPictures_ = (StepAmount)num;
			ItemOneofCase itemOneofCase = other.itemCase_;
			if (stepAmount5 != null)
			{
				if (stepAmount5 != null)
				{
					if (stepAmount5 != null)
					{
						if (stepAmount5 != null)
						{
							if (itemOneofCase != ItemOneofCase.TargetCharacter)
							{
								goto IL_016f;
							}
							itemCase_ = (ItemOneofCase)(item_ = other.TargetGarden.Clone());
						}
						itemCase_ = (ItemOneofCase)(item_ = other.TargetDifferent.Clone());
					}
					itemCase_ = (ItemOneofCase)(item_ = other.TargetGroup.Clone());
				}
				itemCase_ = (ItemOneofCase)(item_ = other.TargetItem.Clone());
			}
			bool flag2 = (byte)(itemCase_ = (((item_ = other.TargetCharacter.Clone()) != null) ? ItemOneofCase.TargetCharacter : ItemOneofCase.None)) != 0;
			goto IL_016f;
			IL_016f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003901")]
		[Cpp2IlInjected.Address(RVA = "0x3202350", Offset = "0x3200D50", VA = "0x183202350", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepTakePicture Clone()
		{
			return new CustomStepTakePicture(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003915")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearItem()
		{
			//IL_0010: Expected O, but got I4
			item_ = (itemCase_ = ItemOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003916")]
		[Cpp2IlInjected.Address(RVA = "0x3203050", Offset = "0x3201A50", VA = "0x183203050", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003917")]
		[Cpp2IlInjected.Address(RVA = "0x32030B0", Offset = "0x3201AB0", VA = "0x1832030B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepTakePicture other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (itemCase_ == ItemOneofCase.TargetCharacter)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
						goto IL_0159;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.itemCase_ == ItemOneofCase.TargetCharacter)
				{
					obj2 = other.item_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					AnyItemSelector targetItem = TargetItem;
					AnyItemSelector targetItem2 = other.TargetItem;
					if (object.Equals(targetItem, targetItem2))
					{
						Types.TakePictureItemsList targetGroup = TargetGroup;
						Types.TakePictureItemsList targetGroup2 = other.TargetGroup;
						if (object.Equals(targetGroup, targetGroup2))
						{
							Types.TakePictureItemsList targetDifferent = TargetDifferent;
							Types.TakePictureItemsList targetDifferent2 = other.TargetDifferent;
							if (object.Equals(targetDifferent, targetDifferent2))
							{
								ItemSelector targetGarden = TargetGarden;
								ItemSelector targetGarden2 = other.TargetGarden;
								if (object.Equals(targetGarden, targetGarden2))
								{
									bool flag = other.useDifferentItem_;
									if (useDifferentItem_ == flag)
									{
										OptionalField objB = other.location_;
										if (object.Equals(location_, objB))
										{
											StepAmount objB2 = other.amountOfItems_;
											if (object.Equals(amountOfItems_, objB2))
											{
												StepAmount objB3 = other.amountOfPictures_;
												if (object.Equals(amountOfPictures_, objB3))
												{
													ItemOneofCase itemOneofCase = other.itemCase_;
													if (itemCase_ == itemOneofCase)
													{
														UnknownFieldSet unknownFields = other._unknownFields;
														bool flag2 = object.Equals(_unknownFields, unknownFields);
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
			goto IL_0159;
			IL_0159:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003918")]
		[Cpp2IlInjected.Address(RVA = "0x32037E0", Offset = "0x32021E0", VA = "0x1832037E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0109
			while (true)
			{
				ItemOneofCase itemOneofCase = itemCase_;
				int num = 0;
				if (itemOneofCase == ItemOneofCase.TargetCharacter)
				{
					object obj = item_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (itemOneofCase != ItemOneofCase.TargetItem)
				{
					continue;
				}
				object obj2 = item_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (itemCase_ != ItemOneofCase.TargetGroup)
					{
						continue;
					}
					object obj3 = item_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (itemCase_ != ItemOneofCase.TargetDifferent)
						{
							continue;
						}
						object obj4 = item_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (itemCase_ == ItemOneofCase.TargetGarden)
							{
								object obj5 = item_;
								if (obj5 == null)
								{
									break;
								}
								int hashCode5 = obj5.GetHashCode();
							}
							if (useDifferentItem_)
							{
							}
							OptionalField optionalField = location_;
							if (optionalField != null)
							{
								int hashCode6 = optionalField.GetHashCode();
							}
							StepAmount stepAmount = amountOfItems_;
							if (stepAmount != null)
							{
								int hashCode7 = stepAmount.GetHashCode();
							}
							StepAmount stepAmount2 = amountOfPictures_;
							if (stepAmount2 != null)
							{
								int hashCode8 = stepAmount2.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode9 = unknownFields.GetHashCode();
							}
							return 1;
						}
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003919")]
		[Cpp2IlInjected.Address(RVA = "0x3204B20", Offset = "0x3203520", VA = "0x183204B20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600391A")]
		[Cpp2IlInjected.Address(RVA = "0x3204B80", Offset = "0x3203580", VA = "0x183204B80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0146
			//IL_002f: Expected O, but got I4
			while (true)
			{
				ItemOneofCase itemOneofCase = itemCase_;
				int num = 0;
				if (itemOneofCase == ItemOneofCase.TargetCharacter)
				{
					if (itemCase_ == ItemOneofCase.TargetCharacter)
					{
						object obj = item_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (itemOneofCase != ItemOneofCase.TargetItem)
				{
					continue;
				}
				if (itemCase_ == ItemOneofCase.TargetItem)
				{
					object obj2 = item_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemCase_ != ItemOneofCase.TargetGroup)
				{
					continue;
				}
				if (itemCase_ == ItemOneofCase.TargetGroup)
				{
					object obj3 = item_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (itemCase_ != ItemOneofCase.TargetDifferent)
				{
					continue;
				}
				if (itemCase_ == ItemOneofCase.TargetDifferent)
				{
					object obj4 = item_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemCase_ == ItemOneofCase.TargetGarden && itemCase_ == ItemOneofCase.TargetGarden)
				{
					object obj5 = item_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (useDifferentItem_)
				{
					bool value = useDifferentItem_;
					output.WriteBool(value);
				}
				if ((long)location_ != 0)
				{
					OptionalField value2 = location_;
					output.WriteMessage(value2);
				}
				if ((long)amountOfItems_ != 0)
				{
					StepAmount value3 = amountOfItems_;
					output.WriteMessage(value3);
				}
				if ((long)amountOfPictures_ != 0)
				{
					StepAmount value4 = amountOfPictures_;
					output.WriteMessage(value4);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600391B")]
		[Cpp2IlInjected.Address(RVA = "0x3201EA0", Offset = "0x32008A0", VA = "0x183201EA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (itemCase_ == ItemOneofCase.TargetCharacter)
			{
				if (itemCase_ == ItemOneofCase.TargetCharacter)
				{
					object obj = item_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (itemCase_ == ItemOneofCase.TargetItem)
			{
				if (itemCase_ != ItemOneofCase.TargetItem)
				{
				}
				object obj2 = item_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (itemCase_ == ItemOneofCase.TargetGroup)
			{
				if (itemCase_ != ItemOneofCase.TargetGroup)
				{
				}
				object obj3 = item_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (itemCase_ == ItemOneofCase.TargetDifferent)
			{
				if (itemCase_ != ItemOneofCase.TargetDifferent)
				{
				}
				object obj4 = item_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (itemCase_ == ItemOneofCase.TargetGarden)
			{
				if (itemCase_ == ItemOneofCase.TargetGarden)
				{
					object obj5 = item_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			OptionalField optionalField = location_;
			if (optionalField != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(optionalField);
				num7++;
				num += num7;
			}
			StepAmount stepAmount = amountOfItems_;
			if (stepAmount != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num8++;
				num += num8;
			}
			StepAmount stepAmount2 = amountOfPictures_;
			if (stepAmount2 != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(stepAmount2);
				num9++;
				num += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600391C")]
		[Cpp2IlInjected.Address(RVA = "0x32042D0", Offset = "0x3202CD0", VA = "0x1832042D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepTakePicture other)
		{
			//Discarded unreachable code: IL_0226
			//IL_0111: Expected I4, but got O
			//IL_0141: Expected I4, but got O
			//IL_0171: Expected I4, but got O
			//IL_01aa: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			bool flag = other.useDifferentItem_;
			if (flag)
			{
				useDifferentItem_ = flag;
			}
			if ((long)other.location_ != 0)
			{
				OptionalField optionalField2 = default(OptionalField);
				if (location_ == null)
				{
					OptionalField optionalField = (location_ = new OptionalField());
					optionalField2 = location_;
				}
				OptionalField other2 = other.location_;
				optionalField2.MergeFrom(other2);
			}
			if ((long)other.amountOfItems_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountOfItems_ == null)
				{
					StepAmount stepAmount = (amountOfItems_ = new StepAmount());
					stepAmount2 = amountOfItems_;
				}
				StepAmount other3 = other.amountOfItems_;
				stepAmount2.MergeFrom(other3);
			}
			StepAmount stepAmount4 = default(StepAmount);
			if ((long)other.amountOfPictures_ != 0)
			{
				if (amountOfPictures_ == null)
				{
					StepAmount stepAmount3 = (amountOfPictures_ = new StepAmount());
					stepAmount4 = amountOfPictures_;
				}
				StepAmount other4 = other.amountOfPictures_;
				stepAmount4.MergeFrom(other4);
			}
			ItemOneofCase itemOneofCase = other.itemCase_;
			if (stepAmount4 != null)
			{
				if (stepAmount4 != null)
				{
					if (stepAmount4 != null)
					{
						if (stepAmount4 != null)
						{
							if (itemOneofCase != ItemOneofCase.TargetCharacter)
							{
								goto IL_0206;
							}
							if (TargetGarden == null)
							{
								itemCase_ = (ItemOneofCase)(item_ = new ItemSelector());
							}
							ItemSelector targetGarden = TargetGarden;
							ItemSelector targetGarden2 = other.TargetGarden;
						}
						if (TargetDifferent == null)
						{
							itemCase_ = (ItemOneofCase)(item_ = new Types.TakePictureItemsList());
						}
						Types.TakePictureItemsList targetDifferent = TargetDifferent;
						Types.TakePictureItemsList targetDifferent2 = other.TargetDifferent;
					}
					if (TargetGroup == null)
					{
						itemCase_ = (ItemOneofCase)(item_ = new Types.TakePictureItemsList());
					}
					Types.TakePictureItemsList targetGroup = TargetGroup;
					Types.TakePictureItemsList targetGroup2 = other.TargetGroup;
					targetGroup.MergeFrom(targetGroup2);
				}
				if (TargetItem == null)
				{
					itemCase_ = (ItemOneofCase)(item_ = new AnyItemSelector());
				}
				AnyItemSelector targetItem = TargetItem;
				AnyItemSelector targetItem2 = other.TargetItem;
				targetItem.MergeFrom(targetItem2);
			}
			if (TargetCharacter == null)
			{
				bool flag2 = (byte)(itemCase_ = (((item_ = new ItemSelector()) != null) ? ItemOneofCase.TargetCharacter : ItemOneofCase.None)) != 0;
			}
			ItemSelector targetCharacter = TargetCharacter;
			ItemSelector targetCharacter2 = other.TargetCharacter;
			targetCharacter.MergeFrom(targetCharacter2);
			goto IL_0206;
			IL_0206:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600391D")]
		[Cpp2IlInjected.Address(RVA = "0x3203D50", Offset = "0x3202750", VA = "0x183203D50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00fb: Expected I4, but got O
			//IL_016f: Expected I4, but got O
			//IL_01c6: Expected I4, but got O
			//IL_026c: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			bool flag = default(bool);
			if ((int)num > 34)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if ((int)num > 80)
				{
					OptionalField optionalField = default(OptionalField);
					if (num == 90)
					{
						OptionalField builder = default(OptionalField);
						if (location_ == null)
						{
							optionalField = (location_ = new OptionalField());
							builder = location_;
						}
						input.ReadMessage(builder);
					}
					StepAmount stepAmount = default(StepAmount);
					if ((long)optionalField == 98)
					{
						StepAmount builder2 = default(StepAmount);
						if (amountOfItems_ == null)
						{
							stepAmount = (amountOfItems_ = new StepAmount());
							builder2 = amountOfItems_;
						}
						input.ReadMessage(builder2);
					}
					if ((long)stepAmount != 106)
					{
						goto IL_026c;
					}
					StepAmount builder3 = default(StepAmount);
					if (amountOfPictures_ == null)
					{
						stepAmount2 = (amountOfPictures_ = new StepAmount());
						builder3 = amountOfPictures_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)stepAmount2 == 42)
				{
					ItemSelector builder4 = new ItemSelector();
					if (itemCase_ == ItemOneofCase.TargetGarden)
					{
						if (itemCase_ != ItemOneofCase.TargetGarden)
						{
						}
						object obj = item_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					item_ = builder4;
					itemCase_ = (ItemOneofCase)typeof(ItemSelector).TypeHandle;
				}
				if ((long)typeof(ItemSelector).TypeHandle != 80)
				{
					goto IL_026c;
				}
				flag = (useDifferentItem_ = input.ReadBool());
			}
			if ((flag ? 1 : 0) > (true ? 1 : 0))
			{
				if (flag)
				{
					Types.TakePictureItemsList builder5 = new Types.TakePictureItemsList();
					if (itemCase_ == ItemOneofCase.TargetGroup)
					{
						if (itemCase_ != ItemOneofCase.TargetGroup)
						{
						}
						object obj2 = item_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder5);
					item_ = builder5;
					itemCase_ = (ItemOneofCase)typeof(Types.TakePictureItemsList).TypeHandle;
				}
				if ((long)typeof(Types.TakePictureItemsList).TypeHandle != 34)
				{
					goto IL_026c;
				}
				Types.TakePictureItemsList builder6 = new Types.TakePictureItemsList();
				if (itemCase_ == ItemOneofCase.TargetDifferent)
				{
					if (itemCase_ != ItemOneofCase.TargetDifferent)
					{
					}
					object obj3 = item_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder6);
				item_ = builder6;
				itemCase_ = (ItemOneofCase)typeof(Types.TakePictureItemsList).TypeHandle;
			}
			bool flag2 = default(bool);
			if ((long)typeof(Types.TakePictureItemsList).TypeHandle == 10)
			{
				ItemSelector itemSelector = new ItemSelector();
				if (itemCase_ == ItemOneofCase.TargetCharacter)
				{
					if (itemCase_ != ItemOneofCase.TargetCharacter)
					{
					}
					object obj4 = item_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(itemSelector);
				item_ = itemSelector;
				flag2 = (byte)(itemCase_ = ((itemSelector != null) ? ItemOneofCase.TargetCharacter : ItemOneofCase.None)) != 0;
			}
			if (flag2)
			{
				AnyItemSelector builder7 = new AnyItemSelector();
				if (itemCase_ == ItemOneofCase.TargetItem)
				{
					if (itemCase_ != ItemOneofCase.TargetItem)
					{
					}
					object obj5 = item_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder7);
				item_ = builder7;
				itemCase_ = (ItemOneofCase)typeof(AnyItemSelector).TypeHandle;
			}
			goto IL_026c;
			IL_026c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600391E")]
		[Cpp2IlInjected.Address(RVA = "0x3203650", Offset = "0x3202050", VA = "0x183203650", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				ItemSelector targetCharacter = TargetCharacter;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600391F")]
		[Cpp2IlInjected.Address(RVA = "0x32047A0", Offset = "0x32031A0", VA = "0x1832047A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002b, IL_002f, IL_0033, IL_0034, IL_0038, IL_003c, IL_003d, IL_0041, IL_0045, IL_0046, IL_004a, IL_004e, IL_004f, IL_0050, IL_0054, IL_0058, IL_005c, IL_0060, IL_0064, IL_0068, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				item_ = num;
				bool flag = (byte)(itemCase_ = ((num != 0) ? ItemOneofCase.TargetCharacter : ItemOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003920")]
		[Cpp2IlInjected.Address(RVA = "0x3202220", Offset = "0x3200C20", VA = "0x183202220", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0016, IL_001e, IL_0028, IL_002d, IL_003f, IL_004f
			//IL_000e: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			if (fieldNumber <= 12)
			{
				int num = 0;
				item_ = num;
				itemCase_ = (ItemOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003921")]
		[Cpp2IlInjected.Address(RVA = "0x3203AD0", Offset = "0x32024D0", VA = "0x183203AD0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Item"))
			{
				ItemOneofCase itemOneofCase = itemCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003922")]
		[Cpp2IlInjected.Address(RVA = "0x32022E0", Offset = "0x3200CE0", VA = "0x1832022E0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Item"))
			{
				item_ = (itemCase_ = ItemOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003927")]
		[Cpp2IlInjected.Address(RVA = "0x32032B0", Offset = "0x3201CB0", VA = "0x1832032B0")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//IL_009b: Expected O, but got I4
			OptionalField optionalField = location_;
			int num = 0;
			if ((optionalField.useField_ ? 1 : 0) != num)
			{
				SceneType scene = optionalField.Scene;
				if ((optionalField.useField_ ? 1 : 0) == num)
				{
					goto IL_00a2;
				}
				if ((optionalField.useField_ ? 1 : 0) == num)
				{
					goto IL_0077;
				}
				if ((optionalField.useField_ ? 1 : 0) != num)
				{
					if ((optionalField.useField_ ? 1 : 0) != num && scene == SceneType.Village)
					{
						List<Item> list = (List<Item>)(object)new List<T>();
						Item restaurant = BuildingItem.Restaurant;
						((List<T>)(object)list).Add((T)restaurant);
						return list;
					}
				}
				else
				{
					int ownerCharacter = data.OwnerCharacter;
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (flag && flag2)
					{
						List<Item> list2 = (List<Item>)(object)new List<T>();
						goto IL_0077;
					}
				}
			}
			goto IL_00a9;
			IL_00a9:
			throw new NullReferenceException();
			IL_00a2:
			List<Item> list3 = (List<Item>)(object)new List<T>();
			goto IL_00a9;
			IL_0077:
			List<Item> list4 = (List<Item>)(object)new List<T>();
			IProfileWorld section = world.Section;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			((List<T>)(object)list4).Add((T)num);
			list4 = (List<Item>)(object)((object)list4 + (object)list4);
			goto IL_00a2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003928")]
		[Cpp2IlInjected.Address(RVA = "0x32023B0", Offset = "0x3200DB0", VA = "0x1832023B0")]
		private ItemSelector CreateTargetCharactersItemSelector(RepeatedField<int> field)
		{
			//Discarded unreachable code: IL_006b, IL_0071, IL_0077
			//IL_0047: Expected I4, but got I8
			GeneratorItemList generatorItemList = new GeneratorItemList();
			generatorItemList.useAsFilter_ = true;
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<GeneratorWeightedItem> list_ = generatorItemList.list_;
				GeneratorWeightedItem generatorWeightedItem = new GeneratorWeightedItem();
				generatorWeightedItem.item_ = 0;
				((RepeatedField<T>)(object)list_).Add((T)generatorWeightedItem);
			}
			ItemSelector itemSelector = new ItemSelector();
			MissionItemGenerator missionItemGenerator = new MissionItemGenerator();
			missionItemGenerator.type_ = ItemType.Character;
			GeneratorItem generatorItem = new GeneratorItem();
			generatorItem.ItemList = generatorItemList;
			missionItemGenerator.item_ = generatorItem;
			itemSelector.ItemList = missionItemGenerator;
			return itemSelector;
		}

		[Cpp2IlInjected.Token(Token = "0x6003929")]
		[Cpp2IlInjected.Address(RVA = "0x3203B80", Offset = "0x3202580", VA = "0x183203B80")]
		public bool IsReallyUsingDifferentItem()
		{
			ItemOneofCase itemOneofCase = itemCase_;
			if (itemOneofCase != ItemOneofCase.TargetDifferent)
			{
				if (!useDifferentItem_)
				{
					int num = 0;
				}
				return itemOneofCase == ItemOneofCase.TargetGarden;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600392A")]
		[Cpp2IlInjected.Address(RVA = "0x3203BB0", Offset = "0x32025B0", VA = "0x183203BB0")]
		private static bool IsValidItem(Item item)
		{
			//Discarded unreachable code: IL_002c
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			if (!flag && (num == 0 || (num == 0 && num == 0 && num == 0)))
			{
				return num != 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600392B")]
		[Cpp2IlInjected.Address(RVA = "0x3202600", Offset = "0x3201000", VA = "0x183202600", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0403
			//IL_00cf: Expected O, but got I4
			_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
			_003C_003Ec__DisplayClass84_.context = context;
			OptionalField optionalField = location_;
			if (optionalField.useField_)
			{
				SceneType scene = optionalField.Scene;
				if (scene == SceneType.Main || scene == SceneType.DisneyWorld || scene == SceneType.IntroScene)
				{
					DataValidation.Context context2 = _003C_003Ec__DisplayClass84_.context;
					string text = default(string);
					string text2 = "Unsupported picture location in " + text;
				}
			}
			if (amountOfPictures_.IsValueSmallerThen(1) && _003C_003Ec__DisplayClass84_.context.IsMissionStep)
			{
				DataValidation.Context context3 = _003C_003Ec__DisplayClass84_.context;
				string missionStepName = context3.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context3.AddInvalidMemberError(message, "AmountOfPictures");
			}
			ItemSelector itemSelector = ItemSelector;
			if (itemSelector != null)
			{
				MissionItemGenerator item = itemSelector.Item;
				if (item != null)
				{
					GeneratorItem generatorItem = item.item_;
					if (generatorItem != null)
					{
						int item2 = generatorItem.Item;
						int num = 0;
					}
				}
			}
			int num2 = 0;
			_003C_003Ec__DisplayClass84_._003CDataValidation_003Eg__CheckForInvalidItems_007C0((Nullable<>)num2);
			ItemSelector itemSelector2 = ItemSelector;
			if (itemSelector2 != null)
			{
				MissionItemGenerator itemList = itemSelector2.ItemList;
				if (itemList != null)
				{
					GeneratorItem generatorItem2 = itemList.item_;
					if (generatorItem2 != null)
					{
						GeneratorItemList itemList2 = generatorItem2.ItemList;
						if (itemList2 != null)
						{
							RepeatedField<GeneratorWeightedItem> list_ = itemList2.list_;
							if (list_ != null)
							{
								Func<GeneratorWeightedItem, int> func = default(Func<GeneratorWeightedItem, int>);
								if (_003C_003Ec._003C_003E9__84_2 == null)
								{
									func = (Func<GeneratorWeightedItem, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GeneratorWeightedItem x) => x.item_));
								}
								IEnumerable<GeneratorWeightedItem> enumerable = (IEnumerable<GeneratorWeightedItem>)Enumerable.Select<GeneratorWeightedItem, int>((IEnumerable<>)(object)list_, (Func<, >)(object)func);
								if (enumerable != null && Enumerable.ToList<int>((IEnumerable<>)enumerable) != null)
								{
									goto IL_0159;
								}
							}
						}
					}
				}
			}
			List<int> list = (List<int>)(object)new List<T>();
			goto IL_0159;
			IL_0159:
			_003C_003Ec__DisplayClass84_._003CDataValidation_003Eg__CheckForInvalidItemsFromList_007C1((List<>)(object)list);
			if (itemCase_ == ItemOneofCase.TargetItem)
			{
				if (amountOfItems_.IsValueSmallerThen(1) && _003C_003Ec__DisplayClass84_.context.IsMissionStep)
				{
					DataValidation.Context context4 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName2 = context4.MissionStepName;
					string message2 = "Should be 1+ in " + missionStepName2;
					context4.AddInvalidMemberError(message2, "AmountOfItems");
				}
				if (amountOfItems_.IsValueGreaterThen(1))
				{
					if (item_ == null)
					{
						throw new InvalidCastException();
					}
					DataValidation.Context context5 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName3 = context5.MissionStepName;
					string message3 = "SORRY this option don't works with' ITEM' for now, please use 1 or select 'FILTER' in " + missionStepName3;
					context5.AddInvalidMemberError(message3, "AmountOfItems");
				}
				if (useDifferentItem_ && amountOfItems_.IsValueGreaterThen(1))
				{
					DataValidation.Context context6 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName4 = context6.MissionStepName;
					string message4 = "Must be 1 with using UseDifferentItem with TargetItem in " + missionStepName4;
					context6.AddInvalidMemberError(message4, "AmountOfItems");
				}
			}
			string text3 = default(string);
			if (itemCase_ == ItemOneofCase.TargetGroup)
			{
				if (item_ == null)
				{
					throw new InvalidCastException();
				}
				int num3 = default(int);
				if (num3 == 0)
				{
					DataValidation.Context context7 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName5 = context7.MissionStepName;
					string error = "TargetGroup should not be empty in " + missionStepName5;
					context7.AddError(error);
				}
				if (item_ == null)
				{
					throw new InvalidCastException();
				}
				IEnumerable<int> enumerable2 = default(IEnumerable<int>);
				int num4 = Enumerable.Count<int>((IEnumerable<>)enumerable2);
				if (item_ == null)
				{
					throw new InvalidCastException();
				}
				int num5 = default(int);
				if (num4 != num5)
				{
					DataValidation.Context context8 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName6 = context8.MissionStepName;
					text3 = "TargetGroup should not contain duplicated value in " + missionStepName6;
					context8.AddError(text3);
				}
			}
			ItemOneofCase itemOneofCase = itemCase_;
			if (itemOneofCase != ItemOneofCase.TargetDifferent)
			{
				if (!useDifferentItem_ || ((long)text3 > 1 && itemOneofCase != ItemOneofCase.TargetGarden) || !amountOfPictures_.IsValueSmallerThen(2))
				{
					goto IL_03af;
				}
				_003C_003Ec__DisplayClass84_.context.AddInvalidMemberError("Must be 2+ when used with UseDifferentItem", "AmountOfPictures");
			}
			string text4 = default(string);
			if (item_ != null)
			{
				int num6 = default(int);
				if (num6 == 0)
				{
					DataValidation.Context context9 = _003C_003Ec__DisplayClass84_.context;
					string missionStepName7 = context9.MissionStepName;
					string error2 = "TargetDifferent should not be empty in " + missionStepName7;
					context9.AddError(error2);
				}
				if (item_ != null)
				{
					IEnumerable<int> enumerable3 = default(IEnumerable<int>);
					int num7 = Enumerable.Count<int>((IEnumerable<>)enumerable3);
					if (item_ != null)
					{
						int num8 = default(int);
						if (num7 != num8)
						{
							DataValidation.Context context10 = _003C_003Ec__DisplayClass84_.context;
							string missionStepName8 = context10.MissionStepName;
							text4 = "TargetDifferent should not contain duplicated value in " + missionStepName8;
							context10.AddError(text4);
						}
						goto IL_03af;
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
			IL_03af:
			ItemOneofCase itemOneofCase2 = itemCase_;
			if ((itemOneofCase2 == ItemOneofCase.TargetDifferent || (useDifferentItem_ && ((long)text4 <= 1 || itemOneofCase2 == ItemOneofCase.TargetGarden))) && (ItemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.Item || ItemSelector.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.ItemGenerator))
			{
				_003C_003Ec__DisplayClass84_.context.AddInvalidMemberError("Cannot be used with an Item generator", "UseDifferentItem");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600392C")]
		[Cpp2IlInjected.Address(RVA = "0x3204EC0", Offset = "0x32038C0", VA = "0x183204EC0")]
		static CustomStepTakePicture()
		{
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600392D")]
		[Cpp2IlInjected.Address(RVA = "0x3203040", Offset = "0x3201A40", VA = "0x183203040", Slot = "19")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			return (List<Item>)(object)this.GetBuildingMapMarker(data, ref world);
		}
	}
}
