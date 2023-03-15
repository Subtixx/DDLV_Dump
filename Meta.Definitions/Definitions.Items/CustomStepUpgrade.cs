using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200047F")]
	public sealed class CustomStepUpgrade : IMessage<CustomStepUpgrade>, IMessage, IEquatable<CustomStepUpgrade>, IDeepCloneable<CustomStepUpgrade>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IBuildingMapMarker, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000480")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001835")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001836")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x4001837")]
			BuildingID,
			[Cpp2IlInjected.Token(Token = "0x4001838")]
			PlayerLevel
		}

		[Cpp2IlInjected.Token(Token = "0x2000481")]
		public enum TargetTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400183A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400183B")]
			TargetLevel = 4,
			[Cpp2IlInjected.Token(Token = "0x400183C")]
			AmountOfUpgrade = 5
		}

		[Cpp2IlInjected.Token(Token = "0x4001829")]
		private static readonly MessageParser<CustomStepUpgrade> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400182A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400182B")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400182C")]
		public const int BuildingIDFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400182D")]
		public const int PlayerLevelFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400182E")]
		public const int TargetLevelFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400182F")]
		public const int AmountOfUpgradeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001830")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001831")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001832")]
		private object targetType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001833")]
		private TargetTypeOneofCase targetTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E05")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepUpgrade> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003714")]
			[Cpp2IlInjected.Address(RVA = "0x3562540", Offset = "0x3560F40", VA = "0x183562540")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E06")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003715")]
			[Cpp2IlInjected.Address(RVA = "0x3562470", Offset = "0x3560E70", VA = "0x183562470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E07")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003716")]
			[Cpp2IlInjected.Address(RVA = "0x35628D0", Offset = "0x35612D0", VA = "0x1835628D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E08")]
		[DebuggerNonUserCode]
		public TargetAny Any
		{
			[Cpp2IlInjected.Token(Token = "0x600371B")]
			[Cpp2IlInjected.Address(RVA = "0x35622F0", Offset = "0x3560CF0", VA = "0x1835622F0")]
			get
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600371C")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				target_ = value;
				bool flag = (byte)(targetCase_ = ((value != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E09")]
		[DebuggerNonUserCode]
		public int BuildingID
		{
			[Cpp2IlInjected.Token(Token = "0x600371D")]
			[Cpp2IlInjected.Address(RVA = "0x3562350", Offset = "0x3560D50", VA = "0x183562350")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.BuildingID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600371E")]
			[Cpp2IlInjected.Address(RVA = "0x3562A20", Offset = "0x3561420", VA = "0x183562A20")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.BuildingID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0A")]
		[DebuggerNonUserCode]
		public Empty PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600371F")]
			[Cpp2IlInjected.Address(RVA = "0x35625A0", Offset = "0x3560FA0", VA = "0x1835625A0")]
			get
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.PlayerLevel)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003720")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				target_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0B")]
		[DebuggerNonUserCode]
		public int TargetLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6003721")]
			[Cpp2IlInjected.Address(RVA = "0x3562860", Offset = "0x3561260", VA = "0x183562860")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetTypeCase_ == TargetTypeOneofCase.TargetLevel)
				{
					object obj = targetType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003722")]
			[Cpp2IlInjected.Address(RVA = "0x3562A90", Offset = "0x3561490", VA = "0x183562A90")]
			set
			{
				//IL_0014: Expected I4, but got I8
				targetType_ = typeof(int).TypeHandle;
				targetTypeCase_ = TargetTypeOneofCase.TargetLevel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0C")]
		[DebuggerNonUserCode]
		public StepAmount AmountOfUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6003723")]
			[Cpp2IlInjected.Address(RVA = "0x3562290", Offset = "0x3560C90", VA = "0x183562290")]
			get
			{
				int num = 0;
				if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
				{
					object obj = targetType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003724")]
			[Cpp2IlInjected.Address(RVA = "0x35629E0", Offset = "0x35613E0", VA = "0x1835629E0")]
			set
			{
				targetType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0D")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003725")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0E")]
		[DebuggerNonUserCode]
		public TargetTypeOneofCase TargetTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003727")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return targetTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E0F")]
		public Item BuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003736")]
			[Cpp2IlInjected.Address(RVA = "0x35623C0", Offset = "0x3560DC0", VA = "0x1835623C0")]
			get
			{
				if (targetCase_ == TargetOneofCase.BuildingID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E10")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003738")]
			[Cpp2IlInjected.Address(RVA = "0x3562600", Offset = "0x3561000", VA = "0x183562600", Slot = "16")]
			get
			{
				if (targetTypeCase_ != TargetTypeOneofCase.AmountOfUpgrade)
				{
					return new StepAmount(TargetLevel);
				}
				if (targetTypeCase_ != TargetTypeOneofCase.AmountOfUpgrade)
				{
					int num = 0;
				}
				object obj = targetType_;
				while (obj == null)
				{
				}
				while (obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E11")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003739")]
			[Cpp2IlInjected.Address(RVA = "0x35626C0", Offset = "0x35610C0", VA = "0x1835626C0", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("TargetName" != null && "TargetName" == null)
					{
						continue;
					}
					array[0] = "TargetName";
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

		[Cpp2IlInjected.Token(Token = "0x6003717")]
		[Cpp2IlInjected.Address(RVA = "0x3561EC0", Offset = "0x35608C0", VA = "0x183561EC0")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade()
		{
			//IL_0029: Expected O, but got I4
			//IL_0032: Expected I4, but got I8
			bool flag = (byte)(targetCase_ = (((target_ = new TargetAny()) != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			int num = default(int);
			targetType_ = num;
			targetTypeCase_ = TargetTypeOneofCase.TargetLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6003718")]
		[Cpp2IlInjected.Address(RVA = "0x3561860", Offset = "0x3560260", VA = "0x183561860")]
		private void OnConstruction()
		{
			//IL_0023: Expected O, but got I4
			//IL_002c: Expected I4, but got I8
			bool flag = (byte)(targetCase_ = (((target_ = new TargetAny()) != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			int num = default(int);
			targetType_ = num;
			targetTypeCase_ = TargetTypeOneofCase.TargetLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6003719")]
		[Cpp2IlInjected.Address(RVA = "0x3561F80", Offset = "0x3560980", VA = "0x183561F80")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade(CustomStepUpgrade other)
		{
			//IL_002c: Expected O, but got I4
			//IL_0035: Expected I4, but got I8
			//IL_0059: Expected I4, but got O
			//IL_00bc: Expected I4, but got I8
			//IL_00e7: Expected I4, but got O
			TargetAny targetAny = (TargetAny)(target_ = new TargetAny());
			int num = 0;
			bool flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			int num2 = default(int);
			targetType_ = num2;
			targetTypeCase_ = TargetTypeOneofCase.TargetLevel;
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (other.target_ != null)
			{
				Empty empty = default(Empty);
				target_ = empty;
				targetCase_ = (TargetOneofCase)empty;
				int num3 = (BuildingID = other.BuildingID);
				TargetOneofCase targetOneofCase2 = other.targetCase_;
				if (other.target_ != null)
				{
					TargetAny targetAny2 = default(TargetAny);
					target_ = targetAny2;
					bool flag2 = (byte)(targetCase_ = ((targetAny2 != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
					if (other.targetTypeCase_ == TargetTypeOneofCase.TargetLevel)
					{
						int targetLevel = other.TargetLevel;
						targetType_ = typeof(int).TypeHandle;
						targetTypeCase_ = TargetTypeOneofCase.TargetLevel;
					}
					if ((long)typeof(int).TypeHandle == 5)
					{
						TargetTypeOneofCase targetTypeOneofCase = other.targetTypeCase_;
						if (other.targetType_ == null)
						{
							throw new InvalidCastException();
						}
						StepAmount stepAmount = default(StepAmount);
						targetType_ = stepAmount;
						targetTypeCase_ = (TargetTypeOneofCase)stepAmount;
					}
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600371A")]
		[Cpp2IlInjected.Address(RVA = "0x35608E0", Offset = "0x355F2E0", VA = "0x1835608E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepUpgrade Clone()
		{
			return new CustomStepUpgrade(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003726")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003728")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearTargetType()
		{
			//IL_0010: Expected O, but got I4
			targetType_ = (targetTypeCase_ = TargetTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003729")]
		[Cpp2IlInjected.Address(RVA = "0x3560B70", Offset = "0x355F570", VA = "0x183560B70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CustomStepUpgrade)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600372A")]
		[Cpp2IlInjected.Address(RVA = "0x3560BD0", Offset = "0x355F5D0", VA = "0x183560BD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepUpgrade other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						goto IL_00fc;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					obj2 = other.target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int buildingID = BuildingID;
					int buildingID2 = other.BuildingID;
					if (buildingID == buildingID2)
					{
						Empty playerLevel = PlayerLevel;
						Empty playerLevel2 = other.PlayerLevel;
						if (object.Equals(playerLevel, playerLevel2))
						{
							int targetLevel = TargetLevel;
							int targetLevel2 = other.TargetLevel;
							if (targetLevel == targetLevel2)
							{
								StepAmount amountOfUpgrade = AmountOfUpgrade;
								StepAmount amountOfUpgrade2 = other.AmountOfUpgrade;
								if (object.Equals(amountOfUpgrade, amountOfUpgrade2))
								{
									TargetOneofCase targetOneofCase = other.targetCase_;
									if (targetCase_ == targetOneofCase)
									{
										TargetTypeOneofCase targetTypeOneofCase = other.targetTypeCase_;
										if (targetTypeCase_ == targetTypeOneofCase)
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											bool flag = object.Equals(_unknownFields, unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00fc;
			IL_00fc:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600372B")]
		[Cpp2IlInjected.Address(RVA = "0x3560F90", Offset = "0x355F990", VA = "0x183560F90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b0
			TargetOneofCase targetOneofCase = targetCase_;
			int num = 0;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (targetOneofCase == TargetOneofCase.BuildingID)
			{
				if (targetCase_ != TargetOneofCase.BuildingID)
				{
				}
				object obj2 = target_;
			}
			if (targetCase_ == TargetOneofCase.PlayerLevel)
			{
				object obj3 = target_;
				if (obj3 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj3.GetHashCode();
			}
			if (targetTypeCase_ == TargetTypeOneofCase.TargetLevel)
			{
				if (targetTypeCase_ != TargetTypeOneofCase.TargetLevel)
				{
				}
				object obj4 = targetType_;
			}
			TargetTypeOneofCase result = default(TargetTypeOneofCase);
			if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
			{
				object obj5 = targetType_;
				if (obj5 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode3 = obj5.GetHashCode();
				result = targetTypeCase_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return (int)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600372C")]
		[Cpp2IlInjected.Address(RVA = "0x3561B40", Offset = "0x3560540", VA = "0x183561B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600372D")]
		[Cpp2IlInjected.Address(RVA = "0x3561BA0", Offset = "0x35605A0", VA = "0x183561BA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b8
			//IL_002f: Expected O, but got I4
			while (true)
			{
				TargetOneofCase targetOneofCase = targetCase_;
				int num = 0;
				if (targetOneofCase == TargetOneofCase.Any)
				{
					if (targetCase_ == TargetOneofCase.Any)
					{
						object obj = target_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (targetOneofCase != TargetOneofCase.BuildingID)
				{
					continue;
				}
				int buildingID = BuildingID;
				output.WriteInt32(buildingID);
				if (targetCase_ == TargetOneofCase.PlayerLevel && targetCase_ == TargetOneofCase.PlayerLevel)
				{
					object obj2 = target_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (targetTypeCase_ != TargetTypeOneofCase.TargetLevel)
				{
					continue;
				}
				int targetLevel = TargetLevel;
				output.WriteInt32(targetLevel);
				if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade && targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
				{
					object obj3 = targetType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600372E")]
		[Cpp2IlInjected.Address(RVA = "0x35604C0", Offset = "0x355EEC0", VA = "0x1835604C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (targetCase_ == TargetOneofCase.Any)
			{
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (targetCase_ == TargetOneofCase.BuildingID)
			{
				if (targetCase_ != TargetOneofCase.BuildingID)
				{
				}
				object obj2 = target_;
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (targetCase_ == TargetOneofCase.PlayerLevel)
			{
				if (targetCase_ != TargetOneofCase.PlayerLevel)
				{
				}
				object obj3 = target_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (targetTypeCase_ == TargetTypeOneofCase.TargetLevel)
			{
				if (targetTypeCase_ != TargetTypeOneofCase.TargetLevel)
				{
				}
				object obj4 = targetType_;
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
			{
				if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
				{
					object obj5 = targetType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600372F")]
		[Cpp2IlInjected.Address(RVA = "0x3561620", Offset = "0x3560020", VA = "0x183561620", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepUpgrade other)
		{
			//Discarded unreachable code: IL_0119
			//IL_003a: Expected I4, but got O
			//IL_00e0: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (targetOneofCase != TargetOneofCase.Any)
					{
						goto IL_00a2;
					}
					if (PlayerLevel == null)
					{
						targetCase_ = (TargetOneofCase)(target_ = new Empty());
					}
					Empty playerLevel = PlayerLevel;
					Empty playerLevel2 = other.PlayerLevel;
					playerLevel.MergeFrom(playerLevel2);
				}
				int num = (BuildingID = other.BuildingID);
			}
			if (Any == null)
			{
				bool flag = (byte)(targetCase_ = (((target_ = new TargetAny()) != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			TargetAny any = Any;
			TargetAny any2 = other.Any;
			any.MergeFrom(any2);
			goto IL_00a2;
			IL_00a2:
			int num2 = default(int);
			if (other.targetTypeCase_ == TargetTypeOneofCase.TargetLevel)
			{
				num2 = (TargetLevel = other.TargetLevel);
			}
			if (num2 == 5)
			{
				if (AmountOfUpgrade == null)
				{
					targetTypeCase_ = (TargetTypeOneofCase)(targetType_ = new StepAmount());
				}
				StepAmount amountOfUpgrade = AmountOfUpgrade;
				StepAmount amountOfUpgrade2 = other.AmountOfUpgrade;
				amountOfUpgrade.MergeFrom(amountOfUpgrade2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003730")]
		[Cpp2IlInjected.Address(RVA = "0x3561300", Offset = "0x355FD00", VA = "0x183561300", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00c2: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					Empty empty = new Empty();
					if (targetCase_ == TargetOneofCase.PlayerLevel)
					{
						if (targetCase_ != TargetOneofCase.PlayerLevel)
						{
						}
						object obj = target_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(empty);
					target_ = empty;
					targetCase_ = (TargetOneofCase)empty;
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (TargetLevel = input.ReadInt32());
				}
				if (num3 != 42)
				{
					goto IL_012a;
				}
				StepAmount builder = new StepAmount();
				if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
				{
					if (targetTypeCase_ != TargetTypeOneofCase.AmountOfUpgrade)
					{
					}
					object obj2 = targetType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				targetType_ = builder;
				targetTypeCase_ = (TargetTypeOneofCase)typeof(StepAmount).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				TargetAny targetAny = new TargetAny();
				if (targetCase_ == TargetOneofCase.Any)
				{
					if (targetCase_ != TargetOneofCase.Any)
					{
					}
					object obj3 = target_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(targetAny);
				target_ = targetAny;
				flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (flag)
			{
				int num5 = (BuildingID = input.ReadInt32());
			}
			goto IL_012a;
			IL_012a:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003731")]
		[Cpp2IlInjected.Address(RVA = "0x3560E70", Offset = "0x355F870", VA = "0x183560E70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0 && num == 1)
			{
				StepAmount amountOfUpgrade = AmountOfUpgrade;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003732")]
		[Cpp2IlInjected.Address(RVA = "0x3561920", Offset = "0x3560320", VA = "0x183561920", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			//IL_0034: Expected I4, but got O
			//IL_0050: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0)
				{
					return;
				}
				if (num != 0)
				{
					if (num != 0 && num == 1)
					{
						int num2 = 0;
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						targetType_ = num2;
						targetTypeCase_ = (TargetTypeOneofCase)typeof(TargetAny).TypeHandle;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					target_ = value;
					targetCase_ = (TargetOneofCase)typeof(TargetAny).TypeHandle;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				target_ = value;
				bool flag = (byte)(targetCase_ = ((value != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003733")]
		[Cpp2IlInjected.Address(RVA = "0x35607B0", Offset = "0x355F1B0", VA = "0x1835607B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_0018, IL_001b
			//IL_000d: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				targetType_ = num;
				targetTypeCase_ = (TargetTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003734")]
		[Cpp2IlInjected.Address(RVA = "0x3561220", Offset = "0x355FC20", VA = "0x183561220", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "Target"))
				{
					TargetOneofCase targetOneofCase = targetCase_;
				}
				if (string.Equals(oneofName, "TargetType"))
				{
					TargetTypeOneofCase targetTypeOneofCase = targetTypeCase_;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003735")]
		[Cpp2IlInjected.Address(RVA = "0x3560840", Offset = "0x355F240", VA = "0x183560840", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0039: Expected O, but got I4
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "Target"))
				{
					int num = (int)(targetCase_ = TargetOneofCase.None);
				}
				if (string.Equals(oneofName, "TargetType"))
				{
					targetType_ = (targetTypeCase_ = TargetTypeOneofCase.None);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003737")]
		[Cpp2IlInjected.Address(RVA = "0x3560D70", Offset = "0x355F770", VA = "0x183560D70")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			if (targetCase_ == TargetOneofCase.BuildingID)
			{
				Item buildingItem = BuildingItem;
				bool flag = default(bool);
				if (flag)
				{
					List<Item> result = (List<Item>)(object)new List<T>();
					Item buildingItem2 = BuildingItem;
					return result;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600373A")]
		[Cpp2IlInjected.Address(RVA = "0x3560940", Offset = "0x355F340", VA = "0x183560940", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004b
			if (targetCase_ == TargetOneofCase.None)
			{
				context.AddError("Target can't be None");
			}
			TargetTypeOneofCase targetTypeOneofCase = targetTypeCase_;
			if (targetTypeOneofCase != 0)
			{
				if (targetTypeOneofCase != TargetTypeOneofCase.AmountOfUpgrade)
				{
					goto IL_0037;
				}
				if (targetType_ == null)
				{
					throw new InvalidCastException();
				}
			}
			context.AddError("TargetType can't be None");
			goto IL_0037;
			IL_0037:
			if (targetCase_ == TargetOneofCase.BuildingID)
			{
				int level = 0;
				BuildingLevelValidation(context, level);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600373B")]
		[Cpp2IlInjected.Address(RVA = "0x3560090", Offset = "0x355EA90", VA = "0x183560090")]
		public void BuildingLevelValidation(DataValidation.Context context, int level = 0)
		{
			//IL_0079: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			int num = 0;
			if (targetCase_ == TargetOneofCase.BuildingID)
			{
				object obj = target_;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IBuildingUpgradable buildingUpgradable = default(IBuildingUpgradable);
			if (buildingUpgradable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					int num3 = num3 + num3;
					num3 += 312;
				}
			}
			string message = default(string);
			if (targetTypeCase_ == TargetTypeOneofCase.AmountOfUpgrade)
			{
				if (targetType_ != null)
				{
					ScalableValue value = AmountOfUpgrade.Value;
					int value_ = value.value_;
					int num4 = default(int);
					message = string.Format("{0} is too high for \"{1}\" (MaxLevel={2})", "AmountOfUpgrade", value, num4);
					context.AddInvalidMemberError(message, "AmountOfUpgrade");
					return;
				}
				throw new InvalidCastException();
			}
			while ((long)message != 4)
			{
			}
			int targetLevel = TargetLevel;
			string text = string.Format("{0} is too high for \"{1}\" (MaxLevel={2})", "TargetLevel", targetLevel, targetLevel);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600373C")]
		[Cpp2IlInjected.Address(RVA = "0x3561DB0", Offset = "0x35607B0", VA = "0x183561DB0")]
		static CustomStepUpgrade()
		{
			Func<CustomStepUpgrade> func = default(Func<CustomStepUpgrade>);
			_parser = (MessageParser<CustomStepUpgrade>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600373D")]
		[Cpp2IlInjected.Address(RVA = "0x3560A60", Offset = "0x355F460", VA = "0x183560A60", Slot = "17")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			if (targetCase_ == TargetOneofCase.BuildingID)
			{
				Item buildingItem = BuildingItem;
				bool flag = default(bool);
				if (flag)
				{
					List<Item> result = (List<Item>)(object)new List<T>();
					Item buildingItem2 = BuildingItem;
					return result;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
