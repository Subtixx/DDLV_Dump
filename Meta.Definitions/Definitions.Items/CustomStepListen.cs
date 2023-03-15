using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004AA")]
	public sealed class CustomStepListen : IMessage<CustomStepListen>, IMessage, IEquatable<CustomStepListen>, IDeepCloneable<CustomStepListen>, IMessageFieldAccessor, IStringTag, ICharactersAvaibility, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40018F0")]
		private static readonly MessageParser<CustomStepListen> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018F1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018F2")]
		public const int RandomDiscussionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018F3")]
		private bool randomDiscussion_;

		[Cpp2IlInjected.Token(Token = "0x40018F4")]
		public const int NpcDiscussionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40018F5")]
		private int npcDiscussion_;

		[Cpp2IlInjected.Token(Token = "0x40018F6")]
		public const int IncludeOwnerFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018F7")]
		private bool includeOwner_;

		[Cpp2IlInjected.Token(Token = "0x40018F8")]
		public const int TargetNPCFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40018F9")]
		private int targetNPC_;

		[Cpp2IlInjected.Token(Token = "0x40018FA")]
		public const int TargetLocationFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018FB")]
		private LocationSource targetLocation_;

		[Cpp2IlInjected.Token(Token = "0x40018FC")]
		public const int RunFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018FD")]
		private bool run_;

		[Cpp2IlInjected.Token(Token = "0x17000E9C")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepListen> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600394C")]
			[Cpp2IlInjected.Address(RVA = "0x34F1470", Offset = "0x34EFE70", VA = "0x1834F1470")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E9D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600394D")]
			[Cpp2IlInjected.Address(RVA = "0x34F13A0", Offset = "0x34EFDA0", VA = "0x1834F13A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E9E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600394E")]
			[Cpp2IlInjected.Address(RVA = "0x34F15F0", Offset = "0x34EFFF0", VA = "0x1834F15F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E9F")]
		[DebuggerNonUserCode]
		public bool RandomDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6003953")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return randomDiscussion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003954")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				randomDiscussion_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA0")]
		[DebuggerNonUserCode]
		public int NpcDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6003955")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return npcDiscussion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003956")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				npcDiscussion_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA1")]
		[DebuggerNonUserCode]
		public bool IncludeOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6003957")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return includeOwner_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003958")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				includeOwner_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA2")]
		[DebuggerNonUserCode]
		public int TargetNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6003959")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return targetNPC_;
			}
			[Cpp2IlInjected.Token(Token = "0x600395A")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				targetNPC_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA3")]
		[DebuggerNonUserCode]
		public LocationSource TargetLocation
		{
			[Cpp2IlInjected.Token(Token = "0x600395B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return targetLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x600395C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				targetLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA4")]
		[DebuggerNonUserCode]
		public bool Run
		{
			[Cpp2IlInjected.Token(Token = "0x600395D")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return run_;
			}
			[Cpp2IlInjected.Token(Token = "0x600395E")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				run_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EA5")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x600396A")]
			[Cpp2IlInjected.Address(RVA = "0x34F14D0", Offset = "0x34EFED0", VA = "0x1834F14D0", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_0041
				string[] array;
				while (true)
				{
					array = new string[2];
					if ("CharacterName1" == null || "CharacterName1" != null)
					{
						array[0] = "CharacterName1";
						if ("CharacterName2" == null || "CharacterName2" != null)
						{
							break;
						}
					}
				}
				array[1] = "CharacterName2";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600394F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepListen()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003950")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003951")]
		[Cpp2IlInjected.Address(RVA = "0x34F1310", Offset = "0x34EFD10", VA = "0x1834F1310")]
		[DebuggerNonUserCode]
		public CustomStepListen(CustomStepListen other)
		{
			//IL_005f: Expected O, but got I4
			OnConstruction();
			bool flag = (randomDiscussion_ = other.randomDiscussion_);
			int num = (npcDiscussion_ = other.npcDiscussion_);
			bool flag2 = (includeOwner_ = other.includeOwner_);
			int num2 = (targetNPC_ = other.targetNPC_);
			LocationSource locationSource = other.targetLocation_;
			if (locationSource != null)
			{
				LocationSource locationSource2 = locationSource.Clone();
			}
			int num3 = 0;
			targetLocation_ = (LocationSource)num3;
			bool flag3 = (run_ = other.run_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003952")]
		[Cpp2IlInjected.Address(RVA = "0x34F05A0", Offset = "0x34EEFA0", VA = "0x1834F05A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepListen Clone()
		{
			//Discarded unreachable code: IL_0088
			//IL_0061: Expected O, but got I4
			CustomStepListen customStepListen = default(CustomStepListen);
			customStepListen.OnConstruction();
			bool flag = (customStepListen.randomDiscussion_ = randomDiscussion_);
			int num = (customStepListen.npcDiscussion_ = npcDiscussion_);
			bool flag2 = (customStepListen.includeOwner_ = includeOwner_);
			int num2 = (customStepListen.targetNPC_ = targetNPC_);
			LocationSource locationSource = targetLocation_;
			if (locationSource != null)
			{
				LocationSource locationSource2 = locationSource.Clone();
			}
			int num3 = 0;
			customStepListen.targetLocation_ = (LocationSource)num3;
			bool flag3 = (customStepListen.run_ = run_);
			UnknownFieldSet unknownFieldSet = (customStepListen._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepListen;
		}

		[Cpp2IlInjected.Token(Token = "0x600395F")]
		[Cpp2IlInjected.Address(RVA = "0x34F08F0", Offset = "0x34EF2F0", VA = "0x1834F08F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(randomDiscussion_ ? 1 : 0) == (IntPtr)typeof(CustomStepListen).TypeHandle && (IntPtr)npcDiscussion_ == (IntPtr)typeof(CustomStepListen).TypeHandle && (IntPtr)(includeOwner_ ? 1 : 0) == (IntPtr)typeof(CustomStepListen).TypeHandle && (IntPtr)targetNPC_ == (IntPtr)typeof(CustomStepListen).TypeHandle)
				{
					bool flag = object.Equals(targetLocation_, other);
					if (flag && run_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003960")]
		[Cpp2IlInjected.Address(RVA = "0x34F0860", Offset = "0x34EF260", VA = "0x1834F0860", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepListen other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.randomDiscussion_;
				if (randomDiscussion_ == flag)
				{
					int num = other.npcDiscussion_;
					if (npcDiscussion_ == num)
					{
						bool flag2 = other.includeOwner_;
						if (includeOwner_ == flag2)
						{
							int num2 = other.targetNPC_;
							if (targetNPC_ == num2)
							{
								LocationSource objB = other.targetLocation_;
								if (object.Equals(targetLocation_, objB))
								{
									bool flag3 = other.run_;
									if (run_ == flag3)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003961")]
		[Cpp2IlInjected.Address(RVA = "0x34F0B00", Offset = "0x34EF500", VA = "0x1834F0B00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (randomDiscussion_)
				{
				}
				if (npcDiscussion_ != 0)
				{
				}
				if (includeOwner_)
				{
				}
				if (targetNPC_ != 0)
				{
				}
				LocationSource locationSource = targetLocation_;
				if (locationSource != null)
				{
					int hashCode = locationSource.GetHashCode();
				}
				if (run_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003962")]
		[Cpp2IlInjected.Address(RVA = "0x34F1070", Offset = "0x34EFA70", VA = "0x1834F1070", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003963")]
		[Cpp2IlInjected.Address(RVA = "0x34F10D0", Offset = "0x34EFAD0", VA = "0x1834F10D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a6
			if (randomDiscussion_)
			{
				bool value = randomDiscussion_;
				output.WriteBool(value);
			}
			if (npcDiscussion_ != 0)
			{
				int value2 = npcDiscussion_;
				output.WriteInt32(value2);
			}
			if (includeOwner_)
			{
				bool value3 = includeOwner_;
				output.WriteBool(value3);
			}
			if (targetNPC_ != 0)
			{
				int value4 = targetNPC_;
				output.WriteInt32(value4);
			}
			if ((long)targetLocation_ != 0)
			{
				LocationSource value5 = targetLocation_;
				output.WriteMessage(value5);
			}
			if (run_)
			{
				bool value6 = run_;
				output.WriteBool(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003964")]
		[Cpp2IlInjected.Address(RVA = "0x34F02B0", Offset = "0x34EECB0", VA = "0x1834F02B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = npcDiscussion_;
			if (num != 0)
			{
				int num2 = CodedOutputStream.ComputeInt32Size(num);
				num2++;
			}
			int num3 = targetNPC_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			LocationSource locationSource = targetLocation_;
			if (locationSource != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(locationSource);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				return num6 + num;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003965")]
		[Cpp2IlInjected.Address(RVA = "0x34F0C00", Offset = "0x34EF600", VA = "0x1834F0C00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepListen other)
		{
			//Discarded unreachable code: IL_00c0
			if (other == null)
			{
				return;
			}
			bool flag = other.randomDiscussion_;
			if (flag)
			{
				randomDiscussion_ = flag;
			}
			int num = other.npcDiscussion_;
			if (num != 0)
			{
				npcDiscussion_ = num;
			}
			bool flag2 = other.includeOwner_;
			if (flag2)
			{
				includeOwner_ = flag2;
			}
			int num2 = other.targetNPC_;
			if (num2 != 0)
			{
				targetNPC_ = num2;
			}
			if ((long)other.targetLocation_ != 0)
			{
				LocationSource locationSource2 = default(LocationSource);
				if (targetLocation_ == null)
				{
					LocationSource locationSource = (targetLocation_ = new LocationSource());
					locationSource2 = targetLocation_;
				}
				LocationSource other2 = other.targetLocation_;
				locationSource2.MergeFrom(other2);
			}
			bool flag3 = other.run_;
			if (flag3)
			{
				run_ = flag3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003966")]
		[Cpp2IlInjected.Address(RVA = "0x34F0D00", Offset = "0x34EF700", VA = "0x1834F0D00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c1
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (targetNPC_ = input.ReadInt32());
				}
				LocationSource locationSource = default(LocationSource);
				if (num == 42)
				{
					LocationSource builder = default(LocationSource);
					if (targetLocation_ == null)
					{
						locationSource = (targetLocation_ = new LocationSource());
						builder = targetLocation_;
					}
					input.ReadMessage(builder);
				}
				if ((long)locationSource != 48)
				{
					goto IL_00aa;
				}
				bool flag = (run_ = input.ReadBool());
			}
			bool flag2 = default(bool);
			if (num == 8)
			{
				flag2 = (randomDiscussion_ = input.ReadBool());
			}
			int num3 = default(int);
			if (flag2)
			{
				num3 = (npcDiscussion_ = input.ReadInt32());
			}
			if (num3 == 24)
			{
				bool flag3 = (includeOwner_ = input.ReadBool());
			}
			goto IL_00aa;
			IL_00aa:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003967")]
		[Cpp2IlInjected.Address(RVA = "0x34F09D0", Offset = "0x34EF3D0", VA = "0x1834F09D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				bool flag = randomDiscussion_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003968")]
		[Cpp2IlInjected.Address(RVA = "0x34F0E50", Offset = "0x34EF850", VA = "0x1834F0E50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0020, IL_0026
			//IL_000d: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				randomDiscussion_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003969")]
		[Cpp2IlInjected.Address(RVA = "0x34F0530", Offset = "0x34EEF30", VA = "0x1834F0530", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_001e
			//IL_0015: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			if (fieldNumber <= 5)
			{
				randomDiscussion_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600396B")]
		[Cpp2IlInjected.Address(RVA = "0x34F03D0", Offset = "0x34EEDD0", VA = "0x1834F03D0", Slot = "15")]
		public bool? CheckCharactersAvaibility(List<int> availableCharacters)
		{
			//IL_002b: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			if (!randomDiscussion_ && npcDiscussion_ != 0)
			{
				int num = npcDiscussion_;
				NpcDiscussionItemData npcDiscussionItemData = default(NpcDiscussionItemData);
				if (npcDiscussionItemData != null)
				{
					int character1ItemID_ = npcDiscussionItemData.character1ItemID_;
					if (((List<T>)(object)availableCharacters).Contains((T)character1ItemID_))
					{
						int character2ItemID_ = npcDiscussionItemData.character2ItemID_;
						bool flag = ((List<T>)(object)availableCharacters).Contains((T)character2ItemID_);
					}
				}
				int num2 = 0;
				int num3 = 0;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600396C")]
		[Cpp2IlInjected.Address(RVA = "0xA63A00", Offset = "0xA62400", VA = "0x180A63A00", Slot = "16")]
		void IProtobufDefaultData.SetDefaultData()
		{
			run_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600396D")]
		[Cpp2IlInjected.Address(RVA = "0x34F0660", Offset = "0x34EF060", VA = "0x1834F0660", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00d4
			if (npcDiscussion_ == 0)
			{
				if (randomDiscussion_)
				{
					goto IL_003a;
				}
				string missionStepName = context.MissionStepName;
				string message = "Select a NpcDiscussion or make it random in " + missionStepName;
				context.AddInvalidMemberError(message, "NpcDiscussion");
			}
			if (randomDiscussion_)
			{
				goto IL_003a;
			}
			goto IL_0094;
			IL_003a:
			if (includeOwner_ && targetNPC_ != 0)
			{
				MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
				int num = 0;
				if (parentOfType != null)
				{
					int ownerCharacter_ = parentOfType.ownerCharacter_;
				}
				bool flag = num == targetNPC_;
				if (num != (flag ? 1 : 0))
				{
					string missionStepName2 = context.MissionStepName;
					string message2 = "TargetNPC and mission.OwnerCharacter cannot be the same in " + missionStepName2;
					context.AddInvalidMemberError(message2, "TargetNPC");
				}
			}
			goto IL_0094;
			IL_0094:
			LocationSource locationSource = targetLocation_;
			if (locationSource != null && locationSource.locationCase_ == LocationSource.LocationOneofCase.Anywhere)
			{
				string missionStepName3 = context.MissionStepName;
				string message3 = "Don't use InVillage in " + missionStepName3 + ". Select better location or 'Set to null' using right click\nOtherwise NPC will select a RANDOM position in village and will go talk there";
				context.AddInvalidMemberError(message3, "TargetLocation");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600396E")]
		[Cpp2IlInjected.Address(RVA = "0x34F1200", Offset = "0x34EFC00", VA = "0x1834F1200")]
		static CustomStepListen()
		{
			Func<CustomStepListen> func = default(Func<CustomStepListen>);
			_parser = (MessageParser<CustomStepListen>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
