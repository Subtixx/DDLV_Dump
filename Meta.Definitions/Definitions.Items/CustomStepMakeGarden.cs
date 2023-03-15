using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004B0")]
	public sealed class CustomStepMakeGarden : IMessage<CustomStepMakeGarden>, IMessage, IEquatable<CustomStepMakeGarden>, IDeepCloneable<CustomStepMakeGarden>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IStringTag, IItemSelector, IProtobufOneOfDefaultValue, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x20004B1")]
		public enum LocationOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001923")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001924")]
			VillageArea = 10,
			[Cpp2IlInjected.Token(Token = "0x4001925")]
			Realm = 11,
			[Cpp2IlInjected.Token(Token = "0x4001926")]
			Building = 5,
			[Cpp2IlInjected.Token(Token = "0x4001927")]
			SpecificLocation = 12
		}

		[Cpp2IlInjected.Token(Token = "0x4001914")]
		private static readonly MessageParser<CustomStepMakeGarden> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001915")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001916")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001917")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001918")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001919")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x400191A")]
		public const int AutoConfirmFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400191B")]
		private bool autoConfirm_;

		[Cpp2IlInjected.Token(Token = "0x400191C")]
		public const int VillageAreaFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400191D")]
		public const int RealmFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x400191E")]
		public const int BuildingFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400191F")]
		public const int SpecificLocationFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001920")]
		private object location_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001921")]
		private LocationOneofCase locationCase_;

		[Cpp2IlInjected.Token(Token = "0x17000EB9")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepMakeGarden> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60039B3")]
			[Cpp2IlInjected.Address(RVA = "0x34F35F0", Offset = "0x34F1FF0", VA = "0x1834F35F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60039B4")]
			[Cpp2IlInjected.Address(RVA = "0x34F3520", Offset = "0x34F1F20", VA = "0x1834F3520")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60039B5")]
			[Cpp2IlInjected.Address(RVA = "0x34F3920", Offset = "0x34F2320", VA = "0x1834F3920", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBC")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x60039BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x60039BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBD")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60039BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60039BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBE")]
		[DebuggerNonUserCode]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x60039BE")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return autoConfirm_;
			}
			[Cpp2IlInjected.Token(Token = "0x60039BF")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				autoConfirm_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EBF")]
		[DebuggerNonUserCode]
		public OptionalField VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x60039C0")]
			[Cpp2IlInjected.Address(RVA = "0x34F38C0", Offset = "0x34F22C0", VA = "0x1834F38C0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.VillageArea)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039C1")]
			[Cpp2IlInjected.Address(RVA = "0x34F3B50", Offset = "0x34F2550", VA = "0x1834F3B50")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC0")]
		[DebuggerNonUserCode]
		public string Realm
		{
			[Cpp2IlInjected.Token(Token = "0x60039C2")]
			[Cpp2IlInjected.Address(RVA = "0x34F3650", Offset = "0x34F2050", VA = "0x1834F3650")]
			get
			{
				if (locationCase_ == LocationOneofCase.Realm)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x60039C3")]
			[Cpp2IlInjected.Address(RVA = "0x34F3AA0", Offset = "0x34F24A0", VA = "0x1834F3AA0")]
			set
			{
				//IL_001d: Expected I4, but got I8
				string text = (string)(location_ = ProtoPreconditions.CheckNotNull(value, "value"));
				locationCase_ = LocationOneofCase.Realm;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC1")]
		[DebuggerNonUserCode]
		public int Building
		{
			[Cpp2IlInjected.Token(Token = "0x60039C4")]
			[Cpp2IlInjected.Address(RVA = "0x34F34B0", Offset = "0x34F1EB0", VA = "0x1834F34B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (locationCase_ == LocationOneofCase.Building)
				{
					object obj = location_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60039C5")]
			[Cpp2IlInjected.Address(RVA = "0x34F3A30", Offset = "0x34F2430", VA = "0x1834F3A30")]
			set
			{
				//IL_0014: Expected I4, but got I8
				location_ = typeof(int).TypeHandle;
				locationCase_ = LocationOneofCase.Building;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC2")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius SpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x60039C6")]
			[Cpp2IlInjected.Address(RVA = "0x34F36C0", Offset = "0x34F20C0", VA = "0x1834F36C0")]
			get
			{
				int num = 0;
				if (locationCase_ == LocationOneofCase.SpecificLocation)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039C7")]
			[Cpp2IlInjected.Address(RVA = "0x34F3B10", Offset = "0x34F2510", VA = "0x1834F3B10")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC3")]
		[DebuggerNonUserCode]
		public LocationOneofCase LocationCase
		{
			[Cpp2IlInjected.Token(Token = "0x60039C8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return locationCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC4")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60039D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC5")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60039D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "18")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC6")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60039D9")]
			[Cpp2IlInjected.Address(RVA = "0x34F3720", Offset = "0x34F2120", VA = "0x1834F3720", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039B6")]
		[Cpp2IlInjected.Address(RVA = "0x34F33B0", Offset = "0x34F1DB0", VA = "0x1834F33B0")]
		[DebuggerNonUserCode]
		public CustomStepMakeGarden()
		{
			//Discarded unreachable code: IL_004f
			//IL_004e: Expected I4, but got I8
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			OptionalField optionalField = new OptionalField
			{
				useField_ = true
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			locationCase_ = LocationOneofCase.VillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x60039B7")]
		[Cpp2IlInjected.Address(RVA = "0x34F29D0", Offset = "0x34F13D0", VA = "0x1834F29D0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected I4, but got I8
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = true;
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			locationCase_ = LocationOneofCase.VillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x60039B8")]
		[Cpp2IlInjected.Address(RVA = "0x34F3120", Offset = "0x34F1B20", VA = "0x1834F3120")]
		[DebuggerNonUserCode]
		public CustomStepMakeGarden(CustomStepMakeGarden other)
		{
			//IL_004e: Expected I4, but got I8
			//IL_006f: Expected O, but got I4
			//IL_00c2: Expected I4, but got I8
			//IL_0104: Expected I4, but got O
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			OptionalField optionalField = new OptionalField
			{
				useField_ = true
			};
			int num = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			location_ = optionalField;
			locationCase_ = LocationOneofCase.VillageArea;
			ItemSelector itemSelector2 = other.targetItem_;
			int num2 = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num2;
			StepAmount stepAmount2 = other.targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = stepAmount3;
			bool flag = (autoConfirm_ = other.autoConfirm_);
			if (other.locationCase_ == LocationOneofCase.Building)
			{
				int building = other.Building;
				location_ = typeof(int).TypeHandle;
				locationCase_ = LocationOneofCase.Building;
			}
			LocationSourceWithRadius locationSourceWithRadius = (LocationSourceWithRadius)(location_ = other.SpecificLocation.Clone());
			string text = (Realm = other.Realm);
			locationCase_ = (LocationOneofCase)(location_ = other.VillageArea.Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039B9")]
		[Cpp2IlInjected.Address(RVA = "0x34F1B70", Offset = "0x34F0570", VA = "0x1834F1B70", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepMakeGarden Clone()
		{
			return new CustomStepMakeGarden(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60039C9")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearLocation()
		{
			//IL_0010: Expected O, but got I4
			location_ = (locationCase_ = LocationOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CA")]
		[Cpp2IlInjected.Address(RVA = "0x34F1C80", Offset = "0x34F0680", VA = "0x1834F1C80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(targetItem_, other))
				{
					bool flag = object.Equals(targetAmount_, other);
					OptionalField objB = default(OptionalField);
					string text = default(string);
					int num = default(int);
					if (flag && autoConfirm_ == flag && object.Equals(VillageArea, objB) && !(Realm != text) && Building == num)
					{
						LocationSourceWithRadius objB2 = default(LocationSourceWithRadius);
						bool flag2 = object.Equals(SpecificLocation, objB2);
						if (flag2 && locationCase_ == (flag2 ? ((LocationOneofCase)1) : LocationOneofCase.None))
						{
							return object.Equals(_unknownFields, objB2);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CB")]
		[Cpp2IlInjected.Address(RVA = "0x34F1E00", Offset = "0x34F0800", VA = "0x1834F1E00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepMakeGarden other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemSelector objB = other.targetItem_;
				if (object.Equals(targetItem_, objB))
				{
					StepAmount objB2 = other.targetAmount_;
					if (object.Equals(targetAmount_, objB2))
					{
						bool flag = other.autoConfirm_;
						if (autoConfirm_ == flag)
						{
							OptionalField villageArea = VillageArea;
							OptionalField villageArea2 = other.VillageArea;
							if (object.Equals(villageArea, villageArea2))
							{
								string realm = Realm;
								string realm2 = other.Realm;
								if (!(realm != realm2))
								{
									int building = Building;
									int building2 = other.Building;
									if (building == building2)
									{
										LocationSourceWithRadius specificLocation = SpecificLocation;
										LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
										if (object.Equals(specificLocation, specificLocation2))
										{
											LocationOneofCase locationOneofCase = other.locationCase_;
											if (locationCase_ == locationOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039CC")]
		[Cpp2IlInjected.Address(RVA = "0x34F20E0", Offset = "0x34F0AE0", VA = "0x1834F20E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d7
			while (true)
			{
				int num = 0;
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int hashCode2 = stepAmount.GetHashCode();
				}
				if (autoConfirm_)
				{
				}
				if (locationCase_ != LocationOneofCase.VillageArea)
				{
					continue;
				}
				object obj = location_;
				if (obj != null)
				{
					int hashCode3 = obj.GetHashCode();
					if (locationCase_ != LocationOneofCase.Realm)
					{
						continue;
					}
					if (locationCase_ != LocationOneofCase.Realm)
					{
					}
					object obj2 = location_;
					if (obj2 == null || obj2 != null)
					{
						int hashCode4 = obj2.GetHashCode();
						if (locationCase_ == LocationOneofCase.Building)
						{
							if (locationCase_ != LocationOneofCase.Building)
							{
							}
							object obj3 = location_;
						}
						if (locationCase_ == LocationOneofCase.SpecificLocation)
						{
							object obj4 = location_;
							if (obj4 == null)
							{
								break;
							}
							int hashCode5 = obj4.GetHashCode();
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode6 = unknownFields.GetHashCode();
						}
						return 1;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039CD")]
		[Cpp2IlInjected.Address(RVA = "0x34F2D90", Offset = "0x34F1790", VA = "0x1834F2D90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60039CE")]
		[Cpp2IlInjected.Address(RVA = "0x34F2DF0", Offset = "0x34F17F0", VA = "0x1834F2DF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e6
			LocationOneofCase locationOneofCase = default(LocationOneofCase);
			while (true)
			{
				if ((long)targetItem_ != 0)
				{
					ItemSelector value = targetItem_;
					output.WriteMessage(value);
				}
				if ((long)targetAmount_ != 0)
				{
					StepAmount value2 = targetAmount_;
					output.WriteMessage(value2);
				}
				if (autoConfirm_)
				{
					bool value3 = autoConfirm_;
					output.WriteBool(value3);
				}
				if (locationCase_ == LocationOneofCase.Building)
				{
					int building = Building;
					output.WriteInt32(building);
					locationOneofCase = locationCase_;
				}
				int num = 0;
				if (locationOneofCase != LocationOneofCase.VillageArea)
				{
					continue;
				}
				if (locationCase_ == LocationOneofCase.VillageArea)
				{
					object obj = location_;
					if (obj != null && obj == null)
					{
						break;
					}
				}
				if (locationCase_ != LocationOneofCase.Realm)
				{
					continue;
				}
				string realm = Realm;
				output.WriteString(realm);
				if (locationCase_ == LocationOneofCase.SpecificLocation && locationCase_ == LocationOneofCase.SpecificLocation)
				{
					object obj2 = location_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039CF")]
		[Cpp2IlInjected.Address(RVA = "0x34F1700", Offset = "0x34F0100", VA = "0x1834F1700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			ItemSelector itemSelector = targetItem_;
			int num = 0;
			if (itemSelector != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num3++;
				num += num3;
			}
			if (locationCase_ == LocationOneofCase.VillageArea)
			{
				if (locationCase_ != LocationOneofCase.VillageArea)
				{
				}
				object obj = location_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (locationCase_ == LocationOneofCase.Realm)
			{
				if (locationCase_ != LocationOneofCase.Realm)
				{
				}
				object obj2 = location_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (locationCase_ == LocationOneofCase.Building)
			{
				if (locationCase_ != LocationOneofCase.Building)
				{
				}
				object obj3 = location_;
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (locationCase_ == LocationOneofCase.SpecificLocation)
			{
				if (locationCase_ == LocationOneofCase.SpecificLocation)
				{
					object obj4 = location_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D0")]
		[Cpp2IlInjected.Address(RVA = "0x34F2740", Offset = "0x34F1140", VA = "0x1834F2740", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepMakeGarden other)
		{
			//Discarded unreachable code: IL_0162
			//IL_00e0: Expected I4, but got O
			//IL_0129: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.targetItem_ != 0)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector == null)
				{
					ItemSelector itemSelector2 = (targetItem_ = new ItemSelector());
					ItemSelector itemSelector3 = targetItem_;
				}
				ItemSelector other2 = other.targetItem_;
				itemSelector.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			bool flag = other.autoConfirm_;
			if (flag)
			{
				autoConfirm_ = flag;
			}
			LocationOneofCase locationOneofCase = other.locationCase_;
			if (locationOneofCase == LocationOneofCase.Building)
			{
				int num = (Building = other.Building);
			}
			if (locationOneofCase != LocationOneofCase.Building)
			{
				if (locationOneofCase != LocationOneofCase.Building)
				{
					if ((long)this != 1)
					{
						goto IL_0142;
					}
					if (SpecificLocation == null)
					{
						locationCase_ = (LocationOneofCase)(location_ = new LocationSourceWithRadius());
					}
					LocationSourceWithRadius specificLocation = SpecificLocation;
					LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
					specificLocation.MergeFrom(specificLocation2);
				}
				string text = (Realm = other.Realm);
			}
			if (VillageArea == null)
			{
				locationCase_ = (LocationOneofCase)(location_ = new OptionalField());
			}
			OptionalField villageArea = VillageArea;
			OptionalField villageArea2 = other.VillageArea;
			villageArea.MergeFrom(villageArea2);
			goto IL_0142;
			IL_0142:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60039D1")]
		[Cpp2IlInjected.Address(RVA = "0x34F2410", Offset = "0x34F0E10", VA = "0x1834F2410", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0080: Expected I4, but got O
			//IL_00ea: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if ((int)num > 82)
				{
					if (num == 90)
					{
						string text2 = (Realm = input.ReadString());
					}
					if (num != 98)
					{
						goto IL_0160;
					}
					LocationSourceWithRadius builder = new LocationSourceWithRadius();
					if (locationCase_ == LocationOneofCase.SpecificLocation)
					{
						if (locationCase_ != LocationOneofCase.SpecificLocation)
						{
						}
						object obj = location_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					location_ = builder;
					locationCase_ = (LocationOneofCase)typeof(LocationSourceWithRadius).TypeHandle;
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (Building = input.ReadInt32());
				}
				if (num3 != 82)
				{
					goto IL_0160;
				}
				OptionalField builder2 = new OptionalField();
				if (locationCase_ == LocationOneofCase.VillageArea)
				{
					if (locationCase_ != LocationOneofCase.VillageArea)
					{
					}
					object obj2 = location_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				location_ = builder2;
				locationCase_ = (LocationOneofCase)typeof(OptionalField).TypeHandle;
			}
			ItemSelector itemSelector = default(ItemSelector);
			if (num == 10)
			{
				ItemSelector builder3 = default(ItemSelector);
				if (targetItem_ == null)
				{
					itemSelector = (targetItem_ = new ItemSelector());
					builder3 = targetItem_;
				}
				input.ReadMessage(builder3);
			}
			StepAmount stepAmount = default(StepAmount);
			if ((long)itemSelector == 18)
			{
				StepAmount builder4 = default(StepAmount);
				if (targetAmount_ == null)
				{
					stepAmount = (targetAmount_ = new StepAmount());
					builder4 = targetAmount_;
				}
				input.ReadMessage(builder4);
			}
			if ((long)stepAmount == 24)
			{
				bool flag = (autoConfirm_ = input.ReadBool());
			}
			goto IL_0160;
			IL_0160:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60039D2")]
		[Cpp2IlInjected.Address(RVA = "0x34F1F50", Offset = "0x34F0950", VA = "0x1834F1F50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				ItemSelector itemSelector = targetItem_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D3")]
		[Cpp2IlInjected.Address(RVA = "0x34F2AC0", Offset = "0x34F14C0", VA = "0x1834F2AC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_0029, IL_002d, IL_0032, IL_0036, IL_003a, IL_003b, IL_003f, IL_0043, IL_0044, IL_0056, IL_005c
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				targetItem_ = (ItemSelector)num;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				targetItem_ = (ItemSelector)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039D4")]
		[Cpp2IlInjected.Address(RVA = "0x34F19F0", Offset = "0x34F03F0", VA = "0x1834F19F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001a, IL_001d
			//IL_0010: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				targetItem_ = (ItemSelector)num;
				int num2 = 0;
				targetItem_ = (ItemSelector)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039D5")]
		[Cpp2IlInjected.Address(RVA = "0x34F2360", Offset = "0x34F0D60", VA = "0x1834F2360", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				LocationOneofCase locationOneofCase = locationCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D6")]
		[Cpp2IlInjected.Address(RVA = "0x34F1B00", Offset = "0x34F0500", VA = "0x1834F1B00", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Location"))
			{
				location_ = (locationCase_ = LocationOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039DA")]
		[Cpp2IlInjected.Address(RVA = "0x31FC4E0", Offset = "0x31FAEE0", VA = "0x1831FC4E0", Slot = "20")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60039DB")]
		[Cpp2IlInjected.Address(RVA = "0x34F1BD0", Offset = "0x34F05D0", VA = "0x1834F1BD0", Slot = "19")]
		object IProtobufOneOfDefaultValue.GetDefaultValue(Enum enumValue)
		{
			int num = 0;
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = true;
			int num2 = (int)(optionalField.VillageArea = VillageAreaType.Beach);
			optionalField.showRandomCheckbox_ = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039DC")]
		[Cpp2IlInjected.Address(RVA = "0x34F3010", Offset = "0x34F1A10", VA = "0x1834F3010")]
		static CustomStepMakeGarden()
		{
			Func<CustomStepMakeGarden> func = default(Func<CustomStepMakeGarden>);
			_parser = (MessageParser<CustomStepMakeGarden>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
