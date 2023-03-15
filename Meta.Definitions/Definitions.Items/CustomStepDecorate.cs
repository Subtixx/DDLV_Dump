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
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004FC")]
	public sealed class CustomStepDecorate : IMessage<CustomStepDecorate>, IMessage, IEquatable<CustomStepDecorate>, IDeepCloneable<CustomStepDecorate>, IMessageFieldAccessor, IMessageOneofAccessor, IItemSelector, IStepAmount, IAreaFilter, IVillageAreaMapMarker, IBuildingMapMarker, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004FD")]
		public enum LocationTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001AAF")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001AB0")]
			AnywhereInTheVillage = 4,
			[Cpp2IlInjected.Token(Token = "0x4001AB1")]
			PlayerHouse = 5,
			[Cpp2IlInjected.Token(Token = "0x4001AB2")]
			VillageArea = 6,
			[Cpp2IlInjected.Token(Token = "0x4001AB3")]
			SpecificLocation = 7
		}

		[Cpp2IlInjected.Token(Token = "0x4001A9E")]
		private static readonly MessageParser<CustomStepDecorate> _parser = (MessageParser<CustomStepDecorate>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomStepDecorate()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A9F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AA0")]
		public const int TargetItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AA1")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x4001AA2")]
		public const int LocationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AA3")]
		private GridLocationFilter location_;

		[Cpp2IlInjected.Token(Token = "0x4001AA4")]
		public const int AnywhereInTheVillageFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001AA5")]
		public const int PlayerHouseFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001AA6")]
		public const int VillageAreaFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001AA7")]
		public const int SpecificLocationFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001AA8")]
		public const int AmountToPlaceFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AA9")]
		private StepAmount amountToPlace_;

		[Cpp2IlInjected.Token(Token = "0x4001AAA")]
		public const int AutoConfirmFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001AAB")]
		private bool autoConfirm_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001AAC")]
		private object locationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001AAD")]
		private LocationTypeOneofCase locationTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000FC3")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepDecorate> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003D87")]
			[Cpp2IlInjected.Address(RVA = "0x2D58710", Offset = "0x2D57110", VA = "0x182D58710")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D88")]
			[Cpp2IlInjected.Address(RVA = "0x2D58640", Offset = "0x2D57040", VA = "0x182D58640")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D89")]
			[Cpp2IlInjected.Address(RVA = "0x2D58FF0", Offset = "0x2D579F0", VA = "0x182D58FF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC6")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003D8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC7")]
		[DebuggerNonUserCode]
		public GridLocationFilter Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003D90")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC8")]
		[DebuggerNonUserCode]
		public Empty AnywhereInTheVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6003D92")]
			[Cpp2IlInjected.Address(RVA = "0x2D58580", Offset = "0x2D56F80", VA = "0x182D58580")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D93")]
			[Cpp2IlInjected.Address(RVA = "0x2D59100", Offset = "0x2D57B00", VA = "0x182D59100")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC9")]
		[DebuggerNonUserCode]
		public Empty PlayerHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6003D94")]
			[Cpp2IlInjected.Address(RVA = "0x2D58770", Offset = "0x2D57170", VA = "0x182D58770")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D95")]
			[Cpp2IlInjected.Address(RVA = "0x1D306E0", Offset = "0x1D2F0E0", VA = "0x181D306E0")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCA")]
		[DebuggerNonUserCode]
		public LocationVillageArea VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6003D96")]
			[Cpp2IlInjected.Address(RVA = "0x2D58F90", Offset = "0x2D57990", VA = "0x182D58F90")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D97")]
			[Cpp2IlInjected.Address(RVA = "0x1D30790", Offset = "0x1D2F190", VA = "0x181D30790")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCB")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius SpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6003D98")]
			[Cpp2IlInjected.Address(RVA = "0x2D587D0", Offset = "0x2D571D0", VA = "0x182D587D0")]
			get
			{
				int num = 0;
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D99")]
			[Cpp2IlInjected.Address(RVA = "0x2D59140", Offset = "0x2D57B40", VA = "0x182D59140")]
			set
			{
				locationType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCC")]
		[DebuggerNonUserCode]
		public StepAmount AmountToPlace
		{
			[Cpp2IlInjected.Token(Token = "0x6003D9A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return amountToPlace_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D9B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				amountToPlace_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCD")]
		[DebuggerNonUserCode]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x6003D9C")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return autoConfirm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D9D")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				autoConfirm_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCE")]
		[DebuggerNonUserCode]
		public LocationTypeOneofCase LocationTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003D9E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return locationTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCF")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003DAD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "16")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD0")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003DAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return amountToPlace_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD1")]
		public List<VillageAreaType> AreaFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6003DAF")]
			[Cpp2IlInjected.Address(RVA = "0x2D585E0", Offset = "0x2D56FE0", VA = "0x182D585E0", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_0020
				LocationVillageArea villageArea = location_.VillageArea;
				if (villageArea != null)
				{
					return (List<VillageAreaType>)(object)Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)villageArea.targetAreas_);
				}
				List<VillageAreaType> result = default(List<VillageAreaType>);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD2")]
		List<VillageAreaType> IVillageAreaMapMarker.VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6003DB0")]
			[Cpp2IlInjected.Address(RVA = "0x2D566D0", Offset = "0x2D550D0", VA = "0x182D566D0", Slot = "19")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (List<VillageAreaType>)(object)location_.get_VillageAreaMapMarker();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD3")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003DB2")]
			[Cpp2IlInjected.Address(RVA = "0x2D58830", Offset = "0x2D57230", VA = "0x182D58830", Slot = "21")]
			get
			{
				//Discarded unreachable code: IL_01f5
				string[] array;
				while (true)
				{
					array = new string[16];
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
					if ("CurrentAmount" != null && "CurrentAmount" == null)
					{
						continue;
					}
					array[2] = "CurrentAmount";
					if ("Location" != null && "Location" == null)
					{
						continue;
					}
					array[3] = "Location";
					if ("Complexity" != null && "Complexity" == null)
					{
						continue;
					}
					array[4] = "Complexity";
					if ("Mood" != null && "Mood" == null)
					{
						continue;
					}
					array[5] = "Mood";
					if ("Sturdiness" != null && "Sturdiness" == null)
					{
						continue;
					}
					array[6] = "Sturdiness";
					if ("Normality" != null && "Normality" == null)
					{
						continue;
					}
					array[7] = "Normality";
					if ("MinRarity" != null && "MinRarity" == null)
					{
						continue;
					}
					array[8] = "MinRarity";
					if ("MaxRarity" != null && "MaxRarity" == null)
					{
						continue;
					}
					array[9] = "MaxRarity";
					if ("Tags" != null && "Tags" == null)
					{
						continue;
					}
					array[10] = "Tags";
					if ("Color" != null && "Color" == null)
					{
						continue;
					}
					array[11] = "Color";
					if ("Style" != null && "Style" == null)
					{
						continue;
					}
					array[12] = "Style";
					if ("Function" != null && "Function" == null)
					{
						continue;
					}
					array[13] = "Function";
					if ("Zone" == null || "Zone" != null)
					{
						array[14] = "Zone";
						if ("Universe" == null || "Universe" != null)
						{
							break;
						}
					}
				}
				array[15] = "Universe";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D8A")]
		[Cpp2IlInjected.Address(RVA = "0x2D58190", Offset = "0x2D56B90", VA = "0x182D58190")]
		[DebuggerNonUserCode]
		public CustomStepDecorate()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			location_ = gridLocationFilter;
			StepAmount stepAmount = (amountToPlace_ = new StepAmount());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D8B")]
		[Cpp2IlInjected.Address(RVA = "0x2D57920", Offset = "0x2D56320", VA = "0x182D57920")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			location_ = gridLocationFilter;
			StepAmount stepAmount = (amountToPlace_ = new StepAmount());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D8C")]
		[Cpp2IlInjected.Address(RVA = "0x2D582B0", Offset = "0x2D56CB0", VA = "0x182D582B0")]
		[DebuggerNonUserCode]
		public CustomStepDecorate(CustomStepDecorate other)
		{
			//IL_005b: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_011f: Expected I4, but got O
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			GridLocationFilter gridLocationFilter = new GridLocationFilter();
			Empty empty2 = (gridLocationFilter.AnywhereInTheVillage = new Empty());
			location_ = gridLocationFilter;
			StepAmount stepAmount = (amountToPlace_ = new StepAmount());
			ItemSelector itemSelector2 = other.targetItem_;
			int num = 0;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			GridLocationFilter gridLocationFilter2 = other.location_;
			if (gridLocationFilter2 != null)
			{
				GridLocationFilter gridLocationFilter3 = gridLocationFilter2.Clone();
			}
			location_ = (GridLocationFilter)num;
			StepAmount stepAmount2 = other.amountToPlace_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			amountToPlace_ = stepAmount3;
			bool flag = (autoConfirm_ = other.autoConfirm_);
			LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
			if (stepAmount2 != null)
			{
				if (stepAmount2 != null)
				{
					if (stepAmount2 != null)
					{
						if (locationTypeOneofCase != (LocationTypeOneofCase)1)
						{
							goto IL_011f;
						}
						LocationSourceWithRadius locationSourceWithRadius = (LocationSourceWithRadius)(locationType_ = other.SpecificLocation.Clone());
					}
					LocationVillageArea locationVillageArea = (LocationVillageArea)(locationType_ = other.VillageArea.Clone());
				}
				Empty empty3 = (Empty)(locationType_ = other.PlayerHouse.Clone());
			}
			locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = other.AnywhereInTheVillage.Clone());
			goto IL_011f;
			IL_011f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D8D")]
		[Cpp2IlInjected.Address(RVA = "0x2D56100", Offset = "0x2D54B00", VA = "0x182D56100", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepDecorate Clone()
		{
			return new CustomStepDecorate(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D9F")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearLocationType()
		{
			//IL_0010: Expected O, but got I4
			locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA0")]
		[Cpp2IlInjected.Address(RVA = "0x2D566F0", Offset = "0x2D550F0", VA = "0x182D566F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				Empty objB = default(Empty);
				Empty objB2 = default(Empty);
				LocationVillageArea objB3 = default(LocationVillageArea);
				LocationSourceWithRadius objB4 = default(LocationSourceWithRadius);
				if (object.Equals(targetItem_, other) && object.Equals(location_, other) && object.Equals(AnywhereInTheVillage, objB) && object.Equals(PlayerHouse, objB2) && object.Equals(VillageArea, objB3) && object.Equals(SpecificLocation, objB4))
				{
					bool flag = object.Equals(amountToPlace_, objB4);
					if (flag && autoConfirm_ == flag && locationTypeCase_ == (flag ? ((LocationTypeOneofCase)1) : LocationTypeOneofCase.None))
					{
						return object.Equals(_unknownFields, objB4);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA1")]
		[Cpp2IlInjected.Address(RVA = "0x2D56890", Offset = "0x2D55290", VA = "0x182D56890", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepDecorate other)
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
					GridLocationFilter objB2 = other.location_;
					if (object.Equals(location_, objB2))
					{
						Empty anywhereInTheVillage = AnywhereInTheVillage;
						Empty anywhereInTheVillage2 = other.AnywhereInTheVillage;
						if (object.Equals(anywhereInTheVillage, anywhereInTheVillage2))
						{
							Empty playerHouse = PlayerHouse;
							Empty playerHouse2 = other.PlayerHouse;
							if (object.Equals(playerHouse, playerHouse2))
							{
								LocationVillageArea villageArea = VillageArea;
								LocationVillageArea villageArea2 = other.VillageArea;
								if (object.Equals(villageArea, villageArea2))
								{
									LocationSourceWithRadius specificLocation = SpecificLocation;
									LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
									if (object.Equals(specificLocation, specificLocation2))
									{
										StepAmount objB3 = other.amountToPlace_;
										if (object.Equals(amountToPlace_, objB3))
										{
											bool flag = other.autoConfirm_;
											if (autoConfirm_ == flag)
											{
												LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
												if (locationTypeCase_ == locationTypeOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D56B70", Offset = "0x2D55570", VA = "0x182D56B70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e8
			while (true)
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null)
				{
					int hashCode = itemSelector.GetHashCode();
				}
				GridLocationFilter gridLocationFilter = location_;
				if (gridLocationFilter != null)
				{
					int hashCode2 = gridLocationFilter.GetHashCode();
				}
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				int num = 0;
				if (locationTypeOneofCase != LocationTypeOneofCase.AnywhereInTheVillage)
				{
					continue;
				}
				object obj = locationType_;
				if (obj != null)
				{
					int hashCode3 = obj.GetHashCode();
					if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
					{
						continue;
					}
					object obj2 = locationType_;
					if (obj2 != null)
					{
						int hashCode4 = obj2.GetHashCode();
						if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
						{
							continue;
						}
						object obj3 = locationType_;
						if (obj3 != null)
						{
							int hashCode5 = obj3.GetHashCode();
							if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
							{
								object obj4 = locationType_;
								if (obj4 == null)
								{
									break;
								}
								int hashCode6 = obj4.GetHashCode();
							}
							StepAmount stepAmount = amountToPlace_;
							if (stepAmount != null)
							{
								int hashCode7 = stepAmount.GetHashCode();
							}
							if (autoConfirm_)
							{
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode8 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6003DA3")]
		[Cpp2IlInjected.Address(RVA = "0x2D57D50", Offset = "0x2D56750", VA = "0x182D57D50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA4")]
		[Cpp2IlInjected.Address(RVA = "0x2D57DB0", Offset = "0x2D567B0", VA = "0x182D57DB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_011c
			while (true)
			{
				if ((long)targetItem_ != 0)
				{
					ItemSelector value = targetItem_;
					output.WriteMessage(value);
				}
				if ((long)location_ != 0)
				{
					GridLocationFilter value2 = location_;
					output.WriteMessage(value2);
				}
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
				int num = 0;
				if (locationTypeOneofCase != LocationTypeOneofCase.AnywhereInTheVillage)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
				{
					object obj = locationType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
				{
					object obj2 = locationType_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
				{
					continue;
				}
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj3 = locationType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation && locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if ((long)amountToPlace_ != 0)
				{
					StepAmount value3 = amountToPlace_;
					output.WriteMessage(value3);
				}
				if (autoConfirm_)
				{
					bool value4 = autoConfirm_;
					output.WriteBool(value4);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D55CB0", Offset = "0x2D546B0", VA = "0x182D55CB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			ItemSelector itemSelector = targetItem_;
			int num = 0;
			if (itemSelector != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(itemSelector);
			}
			GridLocationFilter gridLocationFilter = location_;
			if (gridLocationFilter != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(gridLocationFilter);
				num3++;
				num += num3;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.AnywhereInTheVillage)
				{
				}
				object obj = locationType_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
				{
				}
				object obj2 = locationType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
				{
				}
				object obj3 = locationType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			StepAmount stepAmount = amountToPlace_;
			if (stepAmount != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num8++;
				num += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num += num9;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D57590", Offset = "0x2D55F90", VA = "0x182D57590", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepDecorate other)
		{
			//Discarded unreachable code: IL_01ec
			//IL_0111: Expected I4, but got O
			//IL_014a: Expected I4, but got O
			//IL_0183: Expected I4, but got O
			//IL_01b3: Expected I4, but got O
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
			if ((long)other.location_ != 0)
			{
				GridLocationFilter gridLocationFilter2 = default(GridLocationFilter);
				if (location_ == null)
				{
					GridLocationFilter gridLocationFilter = (location_ = new GridLocationFilter());
					gridLocationFilter2 = location_;
				}
				GridLocationFilter other3 = other.location_;
				gridLocationFilter2.MergeFrom(other3);
			}
			if ((long)other.amountToPlace_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (amountToPlace_ == null)
				{
					StepAmount stepAmount = (amountToPlace_ = new StepAmount());
					stepAmount2 = amountToPlace_;
				}
				StepAmount other4 = other.amountToPlace_;
				stepAmount2.MergeFrom(other4);
			}
			bool flag = other.autoConfirm_;
			if (flag)
			{
				autoConfirm_ = flag;
			}
			LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
			if (flag)
			{
				if (flag)
				{
					if (flag)
					{
						if (locationTypeOneofCase != (LocationTypeOneofCase)1)
						{
							goto IL_01cc;
						}
						if (SpecificLocation == null)
						{
							locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = new LocationSourceWithRadius());
						}
						LocationSourceWithRadius specificLocation = SpecificLocation;
						LocationSourceWithRadius specificLocation2 = other.SpecificLocation;
						specificLocation.MergeFrom(specificLocation2);
					}
					if (VillageArea == null)
					{
						locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = new LocationVillageArea());
					}
					LocationVillageArea villageArea = VillageArea;
					LocationVillageArea villageArea2 = other.VillageArea;
					villageArea.MergeFrom(villageArea2);
				}
				if (PlayerHouse == null)
				{
					locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = new Empty());
				}
				Empty playerHouse = PlayerHouse;
				Empty playerHouse2 = other.PlayerHouse;
			}
			if (AnywhereInTheVillage == null)
			{
				locationTypeCase_ = (LocationTypeOneofCase)(locationType_ = new Empty());
			}
			Empty anywhereInTheVillage = AnywhereInTheVillage;
			Empty anywhereInTheVillage2 = other.AnywhereInTheVillage;
			anywhereInTheVillage.MergeFrom(anywhereInTheVillage2);
			goto IL_01cc;
			IL_01cc:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D570C0", Offset = "0x2D55AC0", VA = "0x182D570C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a9: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			//IL_0158: Expected I4, but got O
			//IL_01af: Expected I4, but got O
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
						StepAmount stepAmount = amountToPlace_;
						if (stepAmount == null)
						{
							StepAmount stepAmount2 = (amountToPlace_ = new StepAmount());
						}
						input.ReadMessage(stepAmount);
					}
					if (num != 72)
					{
						goto IL_0212;
					}
					bool flag = (autoConfirm_ = input.ReadBool());
				}
				if (num == 50)
				{
					LocationVillageArea builder = new LocationVillageArea();
					if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
					{
						if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
						{
						}
						object obj = locationType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					locationType_ = builder;
					locationTypeCase_ = (LocationTypeOneofCase)typeof(LocationVillageArea).TypeHandle;
				}
				if ((long)typeof(LocationVillageArea).TypeHandle != 58)
				{
					goto IL_0212;
				}
				LocationSourceWithRadius builder2 = new LocationSourceWithRadius();
				if (locationTypeCase_ == LocationTypeOneofCase.SpecificLocation)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.SpecificLocation)
					{
					}
					object obj2 = locationType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				locationType_ = builder2;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(LocationSourceWithRadius).TypeHandle;
			}
			if ((int)num > 18)
			{
				if (num == 34)
				{
					Empty builder3 = new Empty();
					if (locationTypeCase_ == LocationTypeOneofCase.AnywhereInTheVillage)
					{
						if (locationTypeCase_ != LocationTypeOneofCase.AnywhereInTheVillage)
						{
						}
						object obj3 = locationType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					locationType_ = builder3;
					locationTypeCase_ = (LocationTypeOneofCase)typeof(Empty).TypeHandle;
				}
				if ((long)typeof(Empty).TypeHandle != 42)
				{
					goto IL_0212;
				}
				Empty builder4 = new Empty();
				if (locationTypeCase_ == LocationTypeOneofCase.PlayerHouse)
				{
					if (locationTypeCase_ != LocationTypeOneofCase.PlayerHouse)
					{
					}
					object obj4 = locationType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				locationType_ = builder4;
				locationTypeCase_ = (LocationTypeOneofCase)typeof(Empty).TypeHandle;
			}
			ItemSelector itemSelector = default(ItemSelector);
			if ((long)typeof(Empty).TypeHandle == 10)
			{
				ItemSelector builder5 = default(ItemSelector);
				if (targetItem_ == null)
				{
					itemSelector = (targetItem_ = new ItemSelector());
					builder5 = targetItem_;
				}
				input.ReadMessage(builder5);
			}
			if ((long)itemSelector == 18)
			{
				GridLocationFilter builder6 = default(GridLocationFilter);
				if (location_ == null)
				{
					GridLocationFilter gridLocationFilter = (location_ = new GridLocationFilter());
					builder6 = location_;
				}
				input.ReadMessage(builder6);
			}
			goto IL_0212;
			IL_0212:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D56A00", Offset = "0x2D55400", VA = "0x182D56A00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				ItemSelector itemSelector = targetItem_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D57A60", Offset = "0x2D56460", VA = "0x182D57A60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_0020, IL_0024, IL_0028, IL_0029, IL_002d, IL_0031, IL_0032, IL_0036, IL_003a, IL_003b, IL_003f, IL_0043, IL_0044, IL_0048, IL_004c, IL_004d, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 8)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				targetItem_ = (ItemSelector)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D55FC0", Offset = "0x2D549C0", VA = "0x182D55FC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0027
			//IL_000d: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			if (fieldNumber <= 8)
			{
				int num = 0;
				targetItem_ = (ItemSelector)num;
				int num2 = 0;
				location_ = (GridLocationFilter)num2;
				int num3 = 0;
				locationType_ = num3;
				locationTypeCase_ = (LocationTypeOneofCase)num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D56DF0", Offset = "0x2D557F0", VA = "0x182D56DF0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DAC")]
		[Cpp2IlInjected.Address(RVA = "0x2D56090", Offset = "0x2D54A90", VA = "0x182D56090", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D566B0", Offset = "0x2D550B0", VA = "0x182D566B0", Slot = "20")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_000e
			return (List<Item>)(object)location_.GetBuildingMapMarker(data, ref world);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D57A30", Offset = "0x2D56430", VA = "0x182D57A30", Slot = "22")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			amountToPlace_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D56160", Offset = "0x2D54B60", VA = "0x182D56160", Slot = "23")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_01f9
			//IL_0124: Expected O, but got I4
			if (amountToPlace_.IsValueSmallerThen(1))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "AmountToPlace");
			}
			GridLocationFilter gridLocationFilter = location_;
			if (gridLocationFilter.locationTypeCase_ == GridLocationFilter.LocationTypeOneofCase.SpecificLocation)
			{
				if (gridLocationFilter.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.AnywhereVillageArea)
				{
					string missionStepName2 = context.MissionStepName;
					string error = "Please use VillageArea instead of SpecificLocation/AnywhereVillageArea in " + missionStepName2;
					context.AddError(error);
				}
				if (location_.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.AvatarFront || location_.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.NearAvatar || location_.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.FishingSpot || location_.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.Castle || location_.SpecificLocation.location_.locationCase_ == LocationSource.LocationOneofCase.Other)
				{
					LocationSource.LocationOneofCase locationCase_ = location_.SpecificLocation.location_.locationCase_;
					string missionStepName3 = context.MissionStepName;
					string error2 = string.Format("{0} can't be {1} in {2}", "Location", locationCase_, missionStepName3);
					context.AddError(error2);
				}
			}
			if (locationTypeCase_ != 0)
			{
				string missionStepName4 = context.MissionStepName;
				string error3 = "Deprecated 'LocationType' still used in " + missionStepName4 + ". Please use 'Convert DecorateSteps' from Windows/Script.";
				context.AddError(error3);
			}
			if (autoConfirm_)
			{
				IEnumerable<Item> cpp2il__autoParamName__idx_ = (IEnumerable<Item>)targetItem_.SelectedItems();
				Func<Item, bool> cpp2il__autoParamName__idx_2 = default(Func<Item, bool>);
				if (_003C_003Ec._003C_003E9__79_0 == null)
				{
					cpp2il__autoParamName__idx_2 = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000b
						ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
						bool flag = default(bool);
						return !flag;
					});
				}
				if (((IEnumerable<>)cpp2il__autoParamName__idx_).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_2))
				{
					context.AddError("[Completion Mode] Decorate can use Permanent only for Blocker items");
				}
			}
			if (context != null)
			{
				if (location_.locationTypeCase_ != GridLocationFilter.LocationTypeOneofCase.PlayerHouse)
				{
					context.AddError("[LocationType] 'PlayerHouse' is required with Wallpaper/Floor");
				}
				if (!autoConfirm_)
				{
					context.AddError("[Completion Mode] Only 'Pernament' is supported with Wallpaper/Floor [Code Restriction]");
				}
				if (amountToPlace_.IsValueGreaterThen(1))
				{
					context.AddInvalidMemberError("Wallpaper/Floor support only 1 has amount [Code Restriction]", "AmountToPlace");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D56EA0", Offset = "0x2D558A0", VA = "0x182D56EA0")]
		public bool GetSpecialInfo(out bool isWallpaper, out bool isFloor)
		{
			//Discarded unreachable code: IL_00bf
			//IL_008d: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			ItemSelector itemSelector = targetItem_;
			if (itemSelector != null)
			{
				MissionItemGenerator filterGenerator = itemSelector.FilterGenerator;
				if (filterGenerator != null && filterGenerator.tags_ != null)
				{
					goto IL_0045;
				}
			}
			ItemSelector itemSelector2 = targetItem_;
			RepeatedField<TagGroupWithRndOption> tags_ = default(RepeatedField<TagGroupWithRndOption>);
			if (itemSelector2 != null)
			{
				MissionItemGenerator itemGenerator = itemSelector2.ItemGenerator;
				if (itemGenerator != null)
				{
					tags_ = itemGenerator.tags_;
					if (tags_ != null)
					{
						goto IL_0045;
					}
				}
			}
			goto IL_009c;
			IL_0045:
			Func<TagGroupWithRndOption, bool> func = default(Func<TagGroupWithRndOption, bool>);
			if (_003C_003Ec._003C_003E9__80_0 == null)
			{
				func = (Func<TagGroupWithRndOption, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((TagGroupWithRndOption x) => x.tagType_ == TagItemType.FurnitureFunction));
			}
			TagGroupWithRndOption tagGroupWithRndOption = Enumerable.FirstOrDefault<TagGroupWithRndOption>((IEnumerable<>)(object)tags_, (Func<, >)(object)func);
			if (tagGroupWithRndOption != null)
			{
				RepeatedField<int> tags_2 = tagGroupWithRndOption.tags_;
				if (tags_2 != null)
				{
					uint num = default(uint);
					if (((RepeatedField<T>)(object)tags_2).Contains((T)num))
					{
					}
					uint num2 = default(uint);
					if (!((RepeatedField<T>)(object)tags_2).Contains((T)num2))
					{
					}
				}
			}
			goto IL_009c;
			IL_009c:
			GridLocationFilter gridLocationFilter = location_;
			if (gridLocationFilter.locationTypeCase_ != GridLocationFilter.LocationTypeOneofCase.PlayerHouse)
			{
				int num3 = 0;
			}
			return gridLocationFilter.locationTypeCase_ != GridLocationFilter.LocationTypeOneofCase.PlayerHouse;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DB6")]
		[Cpp2IlInjected.Address(RVA = "0x2D58080", Offset = "0x2D56A80", VA = "0x182D58080")]
		static CustomStepDecorate()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
