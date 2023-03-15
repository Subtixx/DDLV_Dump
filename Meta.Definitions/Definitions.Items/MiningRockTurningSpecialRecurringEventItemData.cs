using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B8")]
	public sealed class MiningRockTurningSpecialRecurringEventItemData : IMessage<MiningRockTurningSpecialRecurringEventItemData>, IMessage, IEquatable<MiningRockTurningSpecialRecurringEventItemData>, IDeepCloneable<MiningRockTurningSpecialRecurringEventItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IRecurringEventData, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x20003B9")]
		public enum UpdateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001378")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001379")]
			AllOfTypes = 9,
			[Cpp2IlInjected.Token(Token = "0x400137A")]
			SpecificLocation = 10
		}

		[Cpp2IlInjected.Token(Token = "0x20003BA")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003BB")]
			public sealed class UpdateAllOfTypes : IMessage<UpdateAllOfTypes>, IMessage, IEquatable<UpdateAllOfTypes>, IDeepCloneable<UpdateAllOfTypes>, IMessageFieldAccessor, IProtobufDefaultData
			{
				[Cpp2IlInjected.Token(Token = "0x400137B")]
				private static readonly MessageParser<UpdateAllOfTypes> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400137C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400137D")]
				public const int VillageAreasFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400137E")]
				private bool villageAreas_;

				[Cpp2IlInjected.Token(Token = "0x400137F")]
				public const int OffGridBuildingsFieldNumber = 10;

				[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
				[Cpp2IlInjected.Token(Token = "0x4001380")]
				private bool offGridBuildings_;

				[Cpp2IlInjected.Token(Token = "0x4001381")]
				public const int RealmsFieldNumber = 11;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
				[Cpp2IlInjected.Token(Token = "0x4001382")]
				private bool realms_;

				[Cpp2IlInjected.Token(Token = "0x17000B14")]
				[DebuggerNonUserCode]
				public static MessageParser<UpdateAllOfTypes> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002C4C")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6E50", Offset = "0x2FF5850", VA = "0x182FF6E50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B15")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C4D")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6DD0", Offset = "0x2FF57D0", VA = "0x182FF6DD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B16")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002C4E")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6EB0", Offset = "0x2FF58B0", VA = "0x182FF6EB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B17")]
				[DebuggerNonUserCode]
				public bool VillageAreas
				{
					[Cpp2IlInjected.Token(Token = "0x6002C52")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C53")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B18")]
				[DebuggerNonUserCode]
				public bool OffGridBuildings
				{
					[Cpp2IlInjected.Token(Token = "0x6002C54")]
					[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C55")]
					[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000B19")]
				[DebuggerNonUserCode]
				public bool Realms
				{
					[Cpp2IlInjected.Token(Token = "0x6002C56")]
					[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002C57")]
					[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002C4F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public UpdateAllOfTypes()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C50")]
				[Cpp2IlInjected.Address(RVA = "0x2631780", Offset = "0x2630180", VA = "0x182631780")]
				[DebuggerNonUserCode]
				public UpdateAllOfTypes(UpdateAllOfTypes other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C51")]
				[Cpp2IlInjected.Address(RVA = "0x2FF67E0", Offset = "0x2FF51E0", VA = "0x182FF67E0", Slot = "10")]
				[DebuggerNonUserCode]
				public UpdateAllOfTypes Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C58")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6880", Offset = "0x2FF5280", VA = "0x182FF6880", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C59")]
				[Cpp2IlInjected.Address(RVA = "0x26310E0", Offset = "0x262FAE0", VA = "0x1826310E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(UpdateAllOfTypes other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5A")]
				[Cpp2IlInjected.Address(RVA = "0x2631290", Offset = "0x262FC90", VA = "0x182631290", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6BB0", Offset = "0x2FF55B0", VA = "0x182FF6BB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6C10", Offset = "0x2FF5610", VA = "0x182FF6C10", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5D")]
				[Cpp2IlInjected.Address(RVA = "0x2630FE0", Offset = "0x262F9E0", VA = "0x182630FE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5E")]
				[Cpp2IlInjected.Address(RVA = "0x26313E0", Offset = "0x262FDE0", VA = "0x1826313E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(UpdateAllOfTypes other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C5F")]
				[Cpp2IlInjected.Address(RVA = "0x2FF69F0", Offset = "0x2FF53F0", VA = "0x182FF69F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C60")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6920", Offset = "0x2FF5320", VA = "0x182FF6920", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002C61")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6AA0", Offset = "0x2FF54A0", VA = "0x182FF6AA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C62")]
				[Cpp2IlInjected.Address(RVA = "0x2FF67C0", Offset = "0x2FF51C0", VA = "0x182FF67C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002C63")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6870", Offset = "0x2FF5270", VA = "0x182FF6870", Slot = "14")]
				void IProtobufDefaultData.SetDefaultData()
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001361")]
		private static readonly MessageParser<MiningRockTurningSpecialRecurringEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001362")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001363")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001364")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001365")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001366")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001367")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001368")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001369")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400136A")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400136B")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400136C")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400136D")]
		public const int ActiveByDefaultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400136E")]
		private bool activeByDefault_;

		[Cpp2IlInjected.Token(Token = "0x400136F")]
		public const int IntervalDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001370")]
		private RecurringEventIntervalData intervalData_;

		[Cpp2IlInjected.Token(Token = "0x4001371")]
		public const int ExecuteOnAddFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001372")]
		private bool executeOnAdd_;

		[Cpp2IlInjected.Token(Token = "0x4001373")]
		public const int AllOfTypesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001374")]
		public const int SpecificLocationFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001375")]
		private object update_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001376")]
		private UpdateOneofCase updateCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B05")]
		[DebuggerNonUserCode]
		public static MessageParser<MiningRockTurningSpecialRecurringEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002C1F")]
			[Cpp2IlInjected.Address(RVA = "0x1D37D80", Offset = "0x1D36780", VA = "0x181D37D80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B06")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C20")]
			[Cpp2IlInjected.Address(RVA = "0x1D37CB0", Offset = "0x1D366B0", VA = "0x181D37CB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B07")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C21")]
			[Cpp2IlInjected.Address(RVA = "0x1D37E40", Offset = "0x1D36840", VA = "0x181D37E40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B08")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002C26")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "19")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C27")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B09")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002C28")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "21")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C29")]
			[Cpp2IlInjected.Address(RVA = "0x1D38070", Offset = "0x1D36A70", VA = "0x181D38070")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0A")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002C2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "22")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C2B")]
			[Cpp2IlInjected.Address(RVA = "0x1D37F90", Offset = "0x1D36990", VA = "0x181D37F90")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0B")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C2C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "23")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C2D")]
			[Cpp2IlInjected.Address(RVA = "0x1D38000", Offset = "0x1D36A00", VA = "0x181D38000")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0C")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002C2E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "24")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C2F")]
			[Cpp2IlInjected.Address(RVA = "0x1D380E0", Offset = "0x1D36AE0", VA = "0x181D380E0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0D")]
		[DebuggerNonUserCode]
		public bool ActiveByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6002C30")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "16")]
			get
			{
				return activeByDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C31")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				activeByDefault_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0E")]
		[DebuggerNonUserCode]
		public RecurringEventIntervalData IntervalData
		{
			[Cpp2IlInjected.Token(Token = "0x6002C32")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "17")]
			get
			{
				return intervalData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C33")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				intervalData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B0F")]
		[DebuggerNonUserCode]
		public bool ExecuteOnAdd
		{
			[Cpp2IlInjected.Token(Token = "0x6002C34")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "18")]
			get
			{
				return executeOnAdd_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C35")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				executeOnAdd_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B10")]
		[DebuggerNonUserCode]
		public Types.UpdateAllOfTypes AllOfTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002C36")]
			[Cpp2IlInjected.Address(RVA = "0x1D37C50", Offset = "0x1D36650", VA = "0x181D37C50")]
			get
			{
				int num = 0;
				if (updateCase_ == UpdateOneofCase.AllOfTypes)
				{
					object obj = update_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C37")]
			[Cpp2IlInjected.Address(RVA = "0x1D37F50", Offset = "0x1D36950", VA = "0x181D37F50")]
			set
			{
				update_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B11")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter SpecificLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6002C38")]
			[Cpp2IlInjected.Address(RVA = "0x1D37DE0", Offset = "0x1D367E0", VA = "0x181D37DE0")]
			get
			{
				int num = 0;
				if (updateCase_ == UpdateOneofCase.SpecificLocation)
				{
					object obj = update_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C39")]
			[Cpp2IlInjected.Address(RVA = "0x1D38150", Offset = "0x1D36B50", VA = "0x181D38150")]
			set
			{
				update_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B12")]
		[DebuggerNonUserCode]
		public UpdateOneofCase UpdateCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002C3A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return updateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B13")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002C49")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "20")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C22")]
		[Cpp2IlInjected.Address(RVA = "0x1D37860", Offset = "0x1D36260", VA = "0x181D37860")]
		[DebuggerNonUserCode]
		public MiningRockTurningSpecialRecurringEventItemData()
		{
			//IL_0053: Expected I4, but got O
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			updateCase_ = (UpdateOneofCase)(update_ = new ActivityDataLocationFilter());
		}

		[Cpp2IlInjected.Token(Token = "0x6002C23")]
		[Cpp2IlInjected.Address(RVA = "0x1D37020", Offset = "0x1D35A20", VA = "0x181D37020")]
		private void OnConstruction()
		{
			//IL_0021: Expected I4, but got O
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			updateCase_ = (UpdateOneofCase)(update_ = new ActivityDataLocationFilter());
		}

		[Cpp2IlInjected.Token(Token = "0x6002C24")]
		[Cpp2IlInjected.Address(RVA = "0x1D37970", Offset = "0x1D36370", VA = "0x181D37970")]
		[DebuggerNonUserCode]
		public MiningRockTurningSpecialRecurringEventItemData(MiningRockTurningSpecialRecurringEventItemData other)
		{
			//IL_0053: Expected I4, but got O
			//IL_00d0: Expected O, but got I4
			//IL_012c: Expected I4, but got O
			RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
			updateCase_ = (UpdateOneofCase)(update_ = new ActivityDataLocationFilter());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			bool flag = other.activeByDefault_;
			int num2 = 0;
			activeByDefault_ = flag;
			RecurringEventIntervalData recurringEventIntervalData2 = other.intervalData_;
			if (recurringEventIntervalData2 != null)
			{
				RecurringEventIntervalData recurringEventIntervalData3 = recurringEventIntervalData2.Clone();
			}
			intervalData_ = (RecurringEventIntervalData)num2;
			bool flag2 = (executeOnAdd_ = other.executeOnAdd_);
			Types.UpdateAllOfTypes updateAllOfTypes = default(Types.UpdateAllOfTypes);
			if (other.updateCase_ == UpdateOneofCase.AllOfTypes)
			{
				UpdateOneofCase updateOneofCase = other.updateCase_;
				if (other.update_ == null)
				{
					throw new InvalidCastException();
				}
				update_ = updateAllOfTypes;
			}
			if ((long)updateAllOfTypes == 10)
			{
				UpdateOneofCase updateOneofCase2 = other.updateCase_;
				if (other.update_ == null)
				{
					throw new InvalidCastException();
				}
				ActivityDataLocationFilter activityDataLocationFilter = default(ActivityDataLocationFilter);
				update_ = activityDataLocationFilter;
				updateCase_ = (UpdateOneofCase)activityDataLocationFilter;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C25")]
		[Cpp2IlInjected.Address(RVA = "0x1D36180", Offset = "0x1D34B80", VA = "0x181D36180", Slot = "10")]
		[DebuggerNonUserCode]
		public MiningRockTurningSpecialRecurringEventItemData Clone()
		{
			return new MiningRockTurningSpecialRecurringEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3B")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearUpdate()
		{
			//IL_0010: Expected O, but got I4
			update_ = (updateCase_ = UpdateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3C")]
		[Cpp2IlInjected.Address(RVA = "0x1D361E0", Offset = "0x1D34BE0", VA = "0x181D361E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MiningRockTurningSpecialRecurringEventItemData).TypeHandle)
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
								if (!flag4 && activeByDefault_ == flag4)
								{
									bool flag5 = object.Equals(intervalData_, other);
									Types.UpdateAllOfTypes objB = default(Types.UpdateAllOfTypes);
									if (flag5 && executeOnAdd_ == flag5 && object.Equals(AllOfTypes, objB))
									{
										ActivityDataLocationFilter objB2 = default(ActivityDataLocationFilter);
										bool flag6 = object.Equals(SpecificLocation, objB2);
										if (flag6 && updateCase_ == (flag6 ? ((UpdateOneofCase)1) : UpdateOneofCase.None))
										{
											return object.Equals(_unknownFields, objB2);
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

		[Cpp2IlInjected.Token(Token = "0x6002C3D")]
		[Cpp2IlInjected.Address(RVA = "0x1D36380", Offset = "0x1D34D80", VA = "0x181D36380", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiningRockTurningSpecialRecurringEventItemData other)
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
									bool flag = other.activeByDefault_;
									if (activeByDefault_ == flag)
									{
										RecurringEventIntervalData objB = other.intervalData_;
										if (object.Equals(intervalData_, objB))
										{
											bool flag2 = other.executeOnAdd_;
											if (executeOnAdd_ == flag2)
											{
												Types.UpdateAllOfTypes allOfTypes = AllOfTypes;
												Types.UpdateAllOfTypes allOfTypes2 = other.AllOfTypes;
												if (object.Equals(allOfTypes, allOfTypes2))
												{
													ActivityDataLocationFilter specificLocation = SpecificLocation;
													ActivityDataLocationFilter specificLocation2 = other.SpecificLocation;
													if (object.Equals(specificLocation, specificLocation2))
													{
														UpdateOneofCase updateOneofCase = other.updateCase_;
														if (updateCase_ == updateOneofCase)
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
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3E")]
		[Cpp2IlInjected.Address(RVA = "0x1D36690", Offset = "0x1D35090", VA = "0x181D36690", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00f8
			do
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				if (activeByDefault_)
				{
				}
				RecurringEventIntervalData recurringEventIntervalData = intervalData_;
				if (recurringEventIntervalData != null)
				{
					int hashCode5 = recurringEventIntervalData.GetHashCode();
				}
				if (executeOnAdd_)
				{
				}
			}
			while (updateCase_ != UpdateOneofCase.AllOfTypes);
			object obj = update_;
			if (obj != null)
			{
				int hashCode6 = obj.GetHashCode();
				if (updateCase_ == UpdateOneofCase.SpecificLocation)
				{
					object obj2 = update_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode7 = obj2.GetHashCode();
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode8 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3F")]
		[Cpp2IlInjected.Address(RVA = "0x1D37440", Offset = "0x1D35E40", VA = "0x181D37440", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C40")]
		[Cpp2IlInjected.Address(RVA = "0x1D374A0", Offset = "0x1D35EA0", VA = "0x181D374A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0142
			UpdateOneofCase updateOneofCase;
			do
			{
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
				if (activeByDefault_)
				{
					bool value6 = activeByDefault_;
					output.WriteBool(value6);
				}
				if ((long)intervalData_ != 0)
				{
					RecurringEventIntervalData value7 = intervalData_;
					output.WriteMessage(value7);
				}
				if (executeOnAdd_)
				{
					bool value8 = executeOnAdd_;
					output.WriteBool(value8);
				}
				updateOneofCase = updateCase_;
				int num = 0;
			}
			while (updateOneofCase != UpdateOneofCase.AllOfTypes);
			if (updateCase_ == UpdateOneofCase.AllOfTypes)
			{
				object obj = update_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (updateCase_ == UpdateOneofCase.SpecificLocation && updateCase_ == UpdateOneofCase.SpecificLocation)
			{
				object obj2 = update_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C41")]
		[Cpp2IlInjected.Address(RVA = "0x1D35CD0", Offset = "0x1D346D0", VA = "0x181D35CD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0145
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RecurringEventIntervalData recurringEventIntervalData = intervalData_;
			if (recurringEventIntervalData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(recurringEventIntervalData);
				num8++;
				num2 += num8;
			}
			if (updateCase_ == UpdateOneofCase.AllOfTypes)
			{
				if (updateCase_ != UpdateOneofCase.AllOfTypes)
				{
				}
				object obj = update_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num9 = default(int);
				num2 += num9;
			}
			if (updateCase_ == UpdateOneofCase.SpecificLocation)
			{
				if (updateCase_ == UpdateOneofCase.SpecificLocation)
				{
					object obj2 = update_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num10 = default(int);
				num2 += num10;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num2 += num11;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C42")]
		[Cpp2IlInjected.Address(RVA = "0x1D36CD0", Offset = "0x1D356D0", VA = "0x181D36CD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiningRockTurningSpecialRecurringEventItemData other)
		{
			//Discarded unreachable code: IL_01cf
			//IL_0196: Expected I4, but got O
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
			bool flag = other.activeByDefault_;
			if (flag)
			{
				activeByDefault_ = flag;
			}
			if ((long)other.intervalData_ != 0)
			{
				RecurringEventIntervalData recurringEventIntervalData2 = default(RecurringEventIntervalData);
				if (intervalData_ == null)
				{
					RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
					recurringEventIntervalData2 = intervalData_;
				}
				RecurringEventIntervalData other2 = other.intervalData_;
				recurringEventIntervalData2.MergeFrom(other2);
			}
			bool flag2 = other.executeOnAdd_;
			if (flag2)
			{
				executeOnAdd_ = flag2;
			}
			if (other.updateCase_ == UpdateOneofCase.AllOfTypes)
			{
				UpdateOneofCase updateOneofCase = updateCase_;
				object obj = default(object);
				if (updateOneofCase == UpdateOneofCase.AllOfTypes)
				{
					obj = update_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Types.UpdateAllOfTypes updateAllOfTypes = (Types.UpdateAllOfTypes)(update_ = new Types.UpdateAllOfTypes());
					updateCase_ = updateOneofCase;
				}
				if (updateCase_ == UpdateOneofCase.AllOfTypes)
				{
					object obj2 = update_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.updateCase_ == UpdateOneofCase.AllOfTypes)
				{
					object obj3 = other.update_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Types.UpdateAllOfTypes).TypeHandle == 10)
			{
				if (SpecificLocation == null)
				{
					updateCase_ = (UpdateOneofCase)(update_ = new ActivityDataLocationFilter());
				}
				ActivityDataLocationFilter specificLocation = SpecificLocation;
				ActivityDataLocationFilter specificLocation2 = other.SpecificLocation;
				specificLocation.MergeFrom(specificLocation2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C43")]
		[Cpp2IlInjected.Address(RVA = "0x1D36970", Offset = "0x1D35370", VA = "0x181D36970", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0080: Expected I4, but got O
			//IL_00d9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if (num == 64)
					{
						bool flag = (executeOnAdd_ = input.ReadBool());
					}
					if (num == 74)
					{
						Types.UpdateAllOfTypes builder = new Types.UpdateAllOfTypes();
						if (updateCase_ == UpdateOneofCase.AllOfTypes)
						{
							if (updateCase_ != UpdateOneofCase.AllOfTypes)
							{
							}
							object obj = update_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						update_ = builder;
						updateCase_ = (UpdateOneofCase)typeof(Types.UpdateAllOfTypes).TypeHandle;
					}
					if ((long)typeof(Types.UpdateAllOfTypes).TypeHandle != 82)
					{
						goto IL_0198;
					}
					ActivityDataLocationFilter builder2 = new ActivityDataLocationFilter();
					if (updateCase_ == UpdateOneofCase.SpecificLocation)
					{
						if (updateCase_ != UpdateOneofCase.SpecificLocation)
						{
						}
						object obj2 = update_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					update_ = builder2;
					updateCase_ = (UpdateOneofCase)typeof(ActivityDataLocationFilter).TypeHandle;
				}
				bool flag2 = default(bool);
				if (num == 48)
				{
					flag2 = (activeByDefault_ = input.ReadBool());
				}
				if (!flag2)
				{
					goto IL_0198;
				}
				RecurringEventIntervalData builder3 = default(RecurringEventIntervalData);
				if (intervalData_ == null)
				{
					RecurringEventIntervalData recurringEventIntervalData = (intervalData_ = new RecurringEventIntervalData());
					builder3 = intervalData_;
				}
				input.ReadMessage(builder3);
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
					goto IL_0198;
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
			goto IL_0198;
			IL_0198:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C44")]
		[Cpp2IlInjected.Address(RVA = "0x1D364F0", Offset = "0x1D34EF0", VA = "0x181D364F0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C45")]
		[Cpp2IlInjected.Address(RVA = "0x1D370C0", Offset = "0x1D35AC0", VA = "0x181D370C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_0019, IL_001a, IL_001e, IL_0022, IL_0023, IL_0027, IL_002b, IL_002c, IL_0030, IL_0034, IL_0035, IL_0036, IL_003a, IL_003e, IL_003f, IL_0043, IL_0048, IL_004c, IL_0050, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C46")]
		[Cpp2IlInjected.Address(RVA = "0x1D35FA0", Offset = "0x1D349A0", VA = "0x181D35FA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			if (fieldNumber - 1 <= 9)
			{
				int num = (iD_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C47")]
		[Cpp2IlInjected.Address(RVA = "0x1D368C0", Offset = "0x1D352C0", VA = "0x181D368C0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Update"))
			{
				UpdateOneofCase updateOneofCase = updateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C48")]
		[Cpp2IlInjected.Address(RVA = "0x1D360F0", Offset = "0x1D34AF0", VA = "0x181D360F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Update"))
			{
				update_ = (updateCase_ = UpdateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4A")]
		[Cpp2IlInjected.Address(RVA = "0x1D36180", Offset = "0x1D34B80", VA = "0x181D36180", Slot = "25")]
		IItemData IItemData.Clone()
		{
			MiningRockTurningSpecialRecurringEventItemData miningRockTurningSpecialRecurringEventItemData = new MiningRockTurningSpecialRecurringEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4B")]
		[Cpp2IlInjected.Address(RVA = "0x1D37750", Offset = "0x1D36150", VA = "0x181D37750")]
		static MiningRockTurningSpecialRecurringEventItemData()
		{
			Func<MiningRockTurningSpecialRecurringEventItemData> func = default(Func<MiningRockTurningSpecialRecurringEventItemData>);
			_parser = (MessageParser<MiningRockTurningSpecialRecurringEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
