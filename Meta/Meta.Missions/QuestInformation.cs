using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using NodeCanvas.DialogueTrees.Gameloft.Flux;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001046")]
	public sealed class QuestInformation : IMessage<QuestInformation>, IMessage, IEquatable<QuestInformation>, IDeepCloneable<QuestInformation>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004314")]
		private static readonly MessageParser<QuestInformation> _parser = (MessageParser<QuestInformation>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new QuestInformation()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004315")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004316")]
		public const int MissionsCompletedFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4004317")]
		private static readonly FieldCodec<int> _repeated_missionsCompleted_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004318")]
		private readonly RepeatedField<int> missionsCompleted_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004319")]
		private Dictionary<int, QuestNode> QuestNodeMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400431A")]
		private Dictionary<int, QuestTree> QuestTreeMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400431B")]
		private readonly List<QuestTree> WaitingQueue = (List<QuestTree>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400431C")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400431D")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400431E")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400431F")]
		private bool IsFrozenDebugMode;

		[Cpp2IlInjected.Token(Token = "0x170016F7")]
		[DebuggerNonUserCode]
		public static MessageParser<QuestInformation> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600842C")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE20", Offset = "0x5B9820", VA = "0x1805BAE20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600842D")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD50", Offset = "0x5B9750", VA = "0x1805BAD50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600842E")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE80", Offset = "0x5B9880", VA = "0x1805BAE80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FA")]
		[DebuggerNonUserCode]
		public RepeatedField<int> MissionsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6008432")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return missionsCompleted_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FB")]
		public IEnumerable<QuestNode> AllQuestNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6008444")]
			[Cpp2IlInjected.Address(RVA = "0x5BACB0", Offset = "0x5B96B0", VA = "0x1805BACB0")]
			get
			{
				Dictionary<int, QuestNode>.ValueCollection values = (Dictionary<int, QuestNode>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)QuestNodeMap).get_Values();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FC")]
		public IEnumerable<QuestTree> AllQuests
		{
			[Cpp2IlInjected.Token(Token = "0x6008445")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD00", Offset = "0x5B9700", VA = "0x1805BAD00")]
			get
			{
				Dictionary<int, QuestTree>.ValueCollection values = (Dictionary<int, QuestTree>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)QuestTreeMap).get_Values();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600842F")]
		[Cpp2IlInjected.Address(RVA = "0x5BAAB0", Offset = "0x5B94B0", VA = "0x1805BAAB0")]
		[DebuggerNonUserCode]
		public QuestInformation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008430")]
		[Cpp2IlInjected.Address(RVA = "0x5BAB70", Offset = "0x5B9570", VA = "0x1805BAB70")]
		[DebuggerNonUserCode]
		public QuestInformation(QuestInformation other)
		{
			RepeatedField<int> repeatedField = (missionsCompleted_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.missionsCompleted_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008431")]
		[Cpp2IlInjected.Address(RVA = "0x5B6200", Offset = "0x5B4C00", VA = "0x1805B6200", Slot = "10")]
		[DebuggerNonUserCode]
		public QuestInformation Clone()
		{
			//Discarded unreachable code: IL_004a
			QuestInformation questInformation = new QuestInformation();
			RepeatedField<int> repeatedField = (questInformation.missionsCompleted_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			List<QuestTree> list = (questInformation.WaitingQueue = (List<QuestTree>)(object)new List<T>());
			RepeatedField<int> repeatedField2 = (questInformation.missionsCompleted_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)missionsCompleted_).Clone());
			UnknownFieldSet unknownFieldSet = (questInformation._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return questInformation;
		}

		[Cpp2IlInjected.Token(Token = "0x6008433")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DA0", Offset = "0x5B67A0", VA = "0x1805B7DA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = missionsCompleted_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008434")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D10", Offset = "0x5B6710", VA = "0x1805B7D10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(QuestInformation other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = missionsCompleted_;
				RepeatedField<int> repeatedField2 = other.missionsCompleted_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008435")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)missionsCompleted_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6008436")]
		[Cpp2IlInjected.Address(RVA = "0x5B9FF0", Offset = "0x5B89F0", VA = "0x1805B9FF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008437")]
		[Cpp2IlInjected.Address(RVA = "0x5BA8B0", Offset = "0x5B92B0", VA = "0x1805BA8B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = missionsCompleted_;
			FieldCodec<int> repeated_missionsCompleted_codec = _repeated_missionsCompleted_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_missionsCompleted_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008438")]
		[Cpp2IlInjected.Address(RVA = "0x5B6000", Offset = "0x5B4A00", VA = "0x1805B6000", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = missionsCompleted_;
			FieldCodec<int> repeated_missionsCompleted_codec = _repeated_missionsCompleted_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_missionsCompleted_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008439")]
		[Cpp2IlInjected.Address(RVA = "0x5B9500", Offset = "0x5B7F00", VA = "0x1805B9500", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(QuestInformation other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = missionsCompleted_;
				RepeatedField<int> repeatedField2 = other.missionsCompleted_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600843A")]
		[Cpp2IlInjected.Address(RVA = "0x5B9580", Offset = "0x5B7F80", VA = "0x1805B9580", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = missionsCompleted_;
				FieldCodec<int> repeated_missionsCompleted_codec = _repeated_missionsCompleted_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_missionsCompleted_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600843B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8E30", Offset = "0x5B7830", VA = "0x1805B8E30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = missionsCompleted_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600843C")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F50", Offset = "0x5B8950", VA = "0x1805B9F50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600843D")]
		[Cpp2IlInjected.Address(RVA = "0x5B61A0", Offset = "0x5B4BA0", VA = "0x1805B61A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = missionsCompleted_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600843E")]
		[Cpp2IlInjected.Address(RVA = "0x5B90F0", Offset = "0x5B7AF0", VA = "0x1805B90F0")]
		public void Initialize(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002d
			//IL_001e: Expected O, but got I4
			this.profile = profile;
			this.dispatcher = dispatcher;
			this.context = context;
			int num = 0;
			ConstructData((Item)num);
			if ((object)typeof(ITransactionContext).TypeHandle == null)
			{
				PrepareWaitingQueue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600843F")]
		[Cpp2IlInjected.Address(RVA = "0x5B5FE0", Offset = "0x5B49E0", VA = "0x1805B5FE0")]
		public void Actualize()
		{
			RepairQuest();
			PrepareWaitingQueue();
		}

		[Cpp2IlInjected.Token(Token = "0x6008440")]
		[Cpp2IlInjected.Address(RVA = "0x5BA050", Offset = "0x5B8A50", VA = "0x1805BA050")]
		public bool TryGetInfo(Item missionItem, out QuestNode node, out QuestTree quest)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			MissionItemData missionItemData = default(MissionItemData);
			if (missionItemData != null)
			{
				int iD = missionItemData.ID;
				Dictionary<int, QuestNode> questNodeMap = QuestNodeMap;
				bool flag = default(bool);
				if (flag)
				{
					int questId = missionItemData.QuestId;
					Dictionary<int, QuestTree> questTreeMap = QuestTreeMap;
					bool flag2 = default(bool);
					if (flag2)
					{
						return true;
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008441")]
		[Cpp2IlInjected.Address(RVA = "0x5BA210", Offset = "0x5B8C10", VA = "0x1805BA210")]
		public bool TryGetInfo(MissionItemData missionItemData, out QuestNode node, out QuestTree quest)
		{
			if (missionItemData != null)
			{
				int iD = missionItemData.ID;
				Dictionary<int, QuestNode> questNodeMap = QuestNodeMap;
				bool flag = default(bool);
				if (flag)
				{
					iD = missionItemData.QuestId;
					Dictionary<int, QuestTree> questTreeMap = QuestTreeMap;
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
				}
			}
			int num = 0;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008442")]
		[Cpp2IlInjected.Address(RVA = "0x5BA320", Offset = "0x5B8D20", VA = "0x1805BA320")]
		public bool TryGetQuestNode(Item missionItem, out QuestNode node)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<int, QuestNode> questNodeMap = QuestNodeMap;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008443")]
		[Cpp2IlInjected.Address(RVA = "0x5BA390", Offset = "0x5B8D90", VA = "0x1805BA390")]
		public bool TryGetQuest(Item questItem, out QuestTree quest)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<int, QuestTree> questTreeMap = QuestTreeMap;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008446")]
		[Cpp2IlInjected.Address(RVA = "0x5B9220", Offset = "0x5B7C20", VA = "0x1805B9220")]
		public bool IsQuestActive(QuestTree quest)
		{
			if (quest != null)
			{
				Profile profile = this.profile;
				if (profile != null)
				{
					return Enumerable.Any<MissionSlot>(profile.world_.SearchQuestSlots(quest));
				}
				int num = 0;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008447")]
		[Cpp2IlInjected.Address(RVA = "0x5B6370", Offset = "0x5B4D70", VA = "0x1805B6370")]
		public unsafe void ConstructData([Optional] Item specificQuest)
		{
			//Discarded unreachable code: IL_0234, IL_023a, IL_0240, IL_024c, IL_0252, IL_0258, IL_025e, IL_0264, IL_026a, IL_027f, IL_0285, IL_028b, IL_0291, IL_0297, IL_029d, IL_02a3, IL_02a9, IL_02b8, IL_02be, IL_02c4, IL_02d0, IL_02d6, IL_02e5, IL_02eb, IL_02fd
			//IL_001f: Expected O, but got I4
			//IL_0176: Expected O, but got I4
			//IL_0184: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			Func<MissionQuestItemData, QuestTree> func = default(Func<MissionQuestItemData, QuestTree>);
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			Func<MissionItemData, int> func4 = default(Func<MissionItemData, int>);
			Func<MissionItemData, QuestNode> func5 = default(Func<MissionItemData, QuestNode>);
			bool flag = default(bool);
			IEnumerable<QuestNode> enumerable4 = default(IEnumerable<QuestNode>);
			bool flag2 = default(bool);
			Func<KeyValuePair<int, QuestTree>, bool> func6 = default(Func<KeyValuePair<int, QuestTree>, bool>);
			bool result = default(bool);
			Func<KeyValuePair<int, QuestTree>, int> func7 = default(Func<KeyValuePair<int, QuestTree>, int>);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int itemID = specificQuest.ItemID;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
				CS_0024_003C_003E8__locals0.specificQuest = (Item)itemID;
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				if ((IntPtr)QuestNodeMap != (IntPtr)num && (IntPtr)QuestTreeMap != (IntPtr)num)
				{
					return;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Func<MissionQuestItemData, int> _003C_003E9__45_ = _003C_003Ec._003C_003E9__45_0;
				if (_003C_003E9__45_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionQuestItemData x) => x.iD_);
				}
				if (_003C_003Ec._003C_003E9__45_1 == null)
				{
					func = (Func<MissionQuestItemData, QuestTree>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionQuestItemData x) => new QuestTree(x)));
				}
				Dictionary<MissionQuestItemData, int> dictionary = (Dictionary<MissionQuestItemData, int>)(object)(QuestTreeMap = (Dictionary<int, QuestTree>)(object)Enumerable.ToDictionary<MissionQuestItemData, int, QuestTree>(enumerable, (Func<, >)(object)_003C_003E9__45_, (Func<, >)(object)func));
				if (false)
				{
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					if (_003C_003Ec._003C_003E9__45_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionItemData x) => x.iD_);
					}
					if (_003C_003Ec._003C_003E9__45_3 != null)
					{
						goto IL_013f;
					}
					Func<MissionItemData, QuestNode> func2 = (Func<MissionItemData, QuestNode>)(object)(Func<T, TResult>)((MissionItemData x) => new QuestNode(x));
				}
				ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
				Func<MissionItemData, bool> func3 = (Func<MissionItemData, bool>)(object)(Func<T, TResult>)delegate(MissionItemData x)
				{
					int questId = x.QuestId;
					throw new NullReferenceException();
				};
				IEnumerable<MissionItemData> enumerable3 = (IEnumerable<MissionItemData>)Enumerable.Where<MissionItemData>(enumerable2, (Func<, >)(object)func3);
				if (_003C_003Ec._003C_003E9__45_5 == null)
				{
					func4 = (Func<MissionItemData, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionItemData x) => x.iD_));
				}
				if (_003C_003Ec._003C_003E9__45_6 == null)
				{
					func5 = (Func<MissionItemData, QuestNode>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionItemData x) => new QuestNode(x)));
				}
				goto IL_013f;
				IL_013f:
				Dictionary<MissionItemData, int> dictionary2 = (Dictionary<MissionItemData, int>)(object)(QuestNodeMap = (Dictionary<int, QuestNode>)(object)Enumerable.ToDictionary<MissionItemData, int, QuestNode>((IEnumerable<>)enumerable3, (Func<, >)(object)func4, (Func<, >)(object)func5));
				List<QuestNode> list = (List<QuestNode>)(object)new List<T>();
				Dictionary<int, QuestNode> questNodeMap = QuestNodeMap;
				if (flag)
				{
					if (!((Dictionary<TKey, TValue>)(object)QuestTreeMap).TryGetValue((TKey)flag, out *(TValue*)num))
					{
						throw new NullReferenceException();
					}
					enumerable4 = (IEnumerable<QuestNode>)CS_0024_003C_003E8__locals0._003CConstructData_003Eg___ExtractParents_007C7((QuestNode)num);
					if (enumerable4 != null && flag2)
					{
						throw new NullReferenceException();
					}
					if (enumerable4 != null)
					{
					}
					if (enumerable != null)
					{
						throw new NullReferenceException();
					}
					num += 24;
					((int*)num)->m_value = num;
					((List<T>)(object)list).Add((T)num);
				}
				if (enumerable == null)
				{
					if (_003C_003Ec._003C_003E9__45_10 == null)
					{
						func6 = (Func<KeyValuePair<int, QuestTree>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, QuestTree> x) => result));
					}
					IEnumerable<KeyValuePair<int, QuestTree>> enumerable5 = (IEnumerable<KeyValuePair<int, QuestTree>>)Enumerable.Where<KeyValuePair<int, QuestTree>>((IEnumerable<>)enumerable4, (Func<, >)(object)func6);
					if (_003C_003Ec._003C_003E9__45_11 == null)
					{
						func7 = (Func<KeyValuePair<int, QuestTree>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					List<int> list2 = (List<int>)(object)Enumerable.ToList<int>(Enumerable.Select<KeyValuePair<int, QuestTree>, int>((IEnumerable<>)enumerable5, (Func<, >)(object)func7));
					if (flag3)
					{
					}
					if (enumerable != null)
					{
						break;
					}
					if (flag4)
					{
					}
					if (enumerable == null)
					{
						return;
					}
					continue;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008448")]
		[Cpp2IlInjected.Address(RVA = "0x5B7790", Offset = "0x5B6190", VA = "0x1805B7790")]
		public void DEBUG_GenerateAllMissions()
		{
			//Discarded unreachable code: IL_0085, IL_008b, IL_0091
			//IL_0055: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num2 = default(uint);
			bool flag = default(bool);
			string text = default(string);
			do
			{
				int num = 0;
				((RepeatedField<T>)(object)missionsCompleted_).Clear();
				((MapField<TKey, TValue>)(object)profile.world_.missionSlots_).Clear();
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (enumerable != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_005f;
						}
						num++;
					}
					num++;
					while (flag)
					{
					}
					num++;
					text = $"GenerateAllMissions: Failed to start {flag}";
					Log(text);
					goto IL_005f;
				}
				goto IL_0066;
				IL_0066:
				if (enumerable != null)
				{
				}
				continue;
				IL_005f:
				text += text;
				goto IL_0066;
			}
			while (flag);
			int num3 = default(int);
			int num4 = default(int);
			Log($"GenerateAllMissions: {num3} missions generated ({num4} errors)", (ITransactionContext)num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6008449")]
		[Cpp2IlInjected.Address(RVA = "0x5B82F0", Offset = "0x5B6CF0", VA = "0x1805B82F0")]
		public bool GenerateMission(Item missionItem, bool cheatForced = false, bool cheatNoAutoAccept = false)
		{
			//Discarded unreachable code: IL_02b3, IL_02b9, IL_02bf, IL_02c5
			//IL_0034: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0149: Expected O, but got I4
			//IL_02a3: Expected O, but got I8
			bool flag = default(bool);
			QuestNode node = default(QuestNode);
			MissionItemData missionItemData = default(MissionItemData);
			QuestTree quest = default(QuestTree);
			Predicate<MissionSlot> predicate = default(Predicate<MissionSlot>);
			MissionSlot missionSlot = default(MissionSlot);
			MultiReward rewards = default(MultiReward);
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				int itemID = missionItem.ItemID;
				int num = 0;
				if (this.profile.world_.questInfo_ == null)
				{
					string message = $"GenerateMission: NoQuest! : {flag}";
					ITransactionContext transactionContext = context;
					Log(message, transactionContext);
					int num2 = 0;
				}
				QuestNode questNode = node;
				if ((questNode == null || questNode.Data == null) && missionItemData == null)
				{
					break;
				}
				QuestNode questNode2 = node;
				if (questNode2 != null)
				{
					ConditionsList availableConditions_ = questNode2.Data.availableConditions_;
					ITransactionContext transactionContext2 = context;
					Profile profile = this.profile;
					bool flag2 = availableConditions_.Evaluate(profile, transactionContext2);
					if (!flag2)
					{
						string message2 = $"GenerateMission: AvailableCondition was false, {flag2}";
						Log(message2);
					}
					if (Enumerable.Any<QuestNode>((IEnumerable<>)node.Parents))
					{
						List<QuestNode> parents = node.Parents;
						Func<QuestNode, bool> func = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
						{
							//Discarded unreachable code: IL_0018
							QuestInformation questInformation = this;
							int iD = x.Data.ID;
							bool flag5 = default(bool);
							return !flag5;
						};
						bool flag3 = ((IEnumerable<>)parents).All<QuestNode>((Func<, >)(object)func);
						if (flag3)
						{
							string message3 = $"GenerateMission: One parents should be completed, {flag3}";
							Log(message3);
						}
					}
					QuestInformation questInfo_ = this.profile.world_.questInfo_;
					QuestTree quest2 = quest;
					bool flag4 = questInfo_.IsQuestActive(quest2);
					if (flag4)
					{
						string message4 = $"GenerateMission: Quest already active, {flag4}";
						Log(message4);
					}
				}
				switch (missionItemData.type_)
				{
				}
				MissionQueue missionQueue = this.profile.world_.GetMissionQueue((MissionSlotClass)num);
				RepeatedField<MissionSlot> slots_ = missionQueue.slots_;
				if (_003C_003Ec._003C_003E9__47_1 == null)
				{
					predicate = (Predicate<MissionSlot>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionSlot x)
					{
						Item missionItem2 = x.MissionItem;
						throw new NullReferenceException();
					});
				}
				if (((RepeatedField<>)(object)slots_).Find<MissionSlot>((Predicate<>)(object)predicate) == null)
				{
					missionSlot = new MissionSlot();
					missionSlot.class_ = (MissionSlotClass)num;
					int num3 = (missionSlot.slotId_ = ((RepeatedField<T>)(object)missionQueue.slots_).Count);
					missionSlot.state_ = (MissionSlotState)num;
					((RepeatedField<T>)(object)missionQueue.slots_).Add((T)missionSlot);
				}
				Random random = new Random(this.profile.player_.GetRandomSeed("generate_mission"));
				int itemID2 = missionSlot.CharacterItem.ItemID;
				Func<int> func2 = (Func<int>)(object)(Func<TResult>)(() => node.Index);
				Func<int> func3 = (Func<int>)(object)(Func<TResult>)delegate
				{
					//Discarded unreachable code: IL_0012
					int maxIndex = quest.MaxIndex;
					return maxIndex + 1;
				};
				MultiReward multiReward = (missionSlot.rewards_ = missionSlot.OverrideMissionRewards(rewards, random));
				MultiReward multiReward2 = (missionSlot.additionalRewards_ = missionSlot.AdditionalMissionRewards(random));
				Profile profile2 = this.profile;
				profile2.player_.AdvanceRandomSeed("generate_mission");
				string message5 = $"Mission generated {profile2}";
				Log(message5);
				if (disposable != null)
				{
				}
				if (func2 != null)
				{
					continue;
				}
				break;
			}
			ulong num4 = default(ulong);
			string message6 = $"GenerateMission: Invalid mission {num4}";
			Log(message6);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600844A")]
		[Cpp2IlInjected.Address(RVA = "0x5B91B0", Offset = "0x5B7BB0", VA = "0x1805B91B0")]
		public bool IsMissionCompleted(Item item)
		{
			//Discarded unreachable code: IL_0013
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Mission)
			{
				int num = 0;
			}
			RepeatedField<int> repeatedField = missionsCompleted_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600844B")]
		[Cpp2IlInjected.Address(RVA = "0x5B7BB0", Offset = "0x5B65B0", VA = "0x1805B7BB0")]
		public void EndMission(Item missionItem)
		{
			//Discarded unreachable code: IL_004a
			//IL_001b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			int itemID = missionItem.ItemID;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Mission)
			{
				bool flag = ((RepeatedField<T>)(object)missionsCompleted_).Contains((T)itemID);
				if (flag)
				{
					string message = $"EndMission: Was already completed {flag}";
					ITransactionContext transactionContext = context;
					Log(message, transactionContext);
					return;
				}
			}
			((RepeatedField<T>)(object)missionsCompleted_).Add((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x600844C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BA0", Offset = "0x5B75A0", VA = "0x1805B8BA0")]
		public bool GenerateNextMission(Item missionItem)
		{
			//Discarded unreachable code: IL_004b
			//IL_0036: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag)
			{
				if (flag2)
				{
					goto IL_002b;
				}
				MissionItemData missionItemData = default(MissionItemData);
				if (missionItemData != null && missionItemData.status_ == (MissionItemData.Types.MissionStatus)num)
				{
					goto IL_003e;
				}
			}
			ITransactionContext transactionContext = context;
			string message = default(string);
			Log(message, transactionContext);
			int num2 = 0;
			goto IL_002b;
			IL_003e:
			return true;
			IL_002b:
			QuestNode questNode = default(QuestNode);
			if (questNode == null)
			{
				bool flag3 = default(bool);
				if (Enumerable.Any<QuestNode>((IEnumerable<>)num) && flag3)
				{
				}
				goto IL_003e;
			}
			int count = ((CaptureCollection)flag2).Count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600844D")]
		[Cpp2IlInjected.Address(RVA = "0x5B9990", Offset = "0x5B8390", VA = "0x1805B9990")]
		private void RepairQuest()
		{
			//Discarded unreachable code: IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c, IL_0142
			//IL_00b9: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			IEnumerable<MissionSlot> enumerable = (IEnumerable<MissionSlot>)this.profile.world_.SearchUnquestSlots();
			Action<MissionSlot> action = (Action<MissionSlot>)(object)(Action<T>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_003c
				//IL_0022: Expected O, but got I4
				int slotId_2 = x.slotId_;
				Item missionItem2 = x.MissionItem;
				int missionId_2 = x.missionId_;
				string message2 = $"RepairQuest: Reset slot#{slotId_2}, contain unquest mission, {missionItem2} (id={missionItem2})";
				ITransactionContext transactionContext3 = context;
				Log(message2, transactionContext3);
				x.ResetMission();
			};
			MoreLinq.ForEach<MissionSlot>((IEnumerable<>)enumerable, (Action<>)(object)action);
			Dictionary<int, QuestTree>.ValueCollection values = (Dictionary<int, QuestTree>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)QuestTreeMap).get_Values();
			QuestInformation CS_0024_003C_003E8__locals0;
			if (values != null)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_00c9;
					}
					num2++;
				}
				CS_0024_003C_003E8__locals0.quest = (QuestTree)(object)CS_0024_003C_003E8__locals0;
				ProfileWorld world_ = this.profile.world_;
				QuestTree quest2 = CS_0024_003C_003E8__locals0.quest;
				List<MissionSlot> list = (List<MissionSlot>)(object)Enumerable.ToList<MissionSlot>(world_.SearchQuestSlots(quest2));
				QuestTree quest3 = CS_0024_003C_003E8__locals0.quest;
				int flag = 0;
				ITransactionContext transactionContext = context;
				Profile profile = this.profile;
				ulong num4 = default(ulong);
				QuestNode questNode = quest3.EvaluateNextNodes(profile, transactionContext, (ConditionListener)flag, (byte)num4 != 0);
				while (questNode == null)
				{
				}
				MissionItemData data = questNode.Data;
				goto IL_00c9;
			}
			goto IL_00e8;
			IL_00e8:
			if (values != null)
			{
				int num5 = 0;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				MissionSlot missionSlot = default(MissionSlot);
				while (missionSlot.state_ != 0)
				{
				}
				int num6 = default(int);
				int num7 = num6 - 1;
			}
			return;
			IL_00c9:
			int num8 = num8 + num8;
			Action<MissionSlot> action2 = (Action<MissionSlot>)(object)(Action<T>)delegate(MissionSlot x)
			{
				//Discarded unreachable code: IL_0017
				CS_0024_003C_003E8__locals0 = CS_0024_003C_003E8__locals0._003C_003E4__this;
				QuestTree quest4 = CS_0024_003C_003E8__locals0.quest;
				_resetDuplicateQuestSlot(x, quest4);
				[Cpp2IlInjected.Token(Token = "0x600845A")]
				[Cpp2IlInjected.Address(RVA = "0x5BA5C0", Offset = "0x5B8FC0", VA = "0x1805BA5C0")]
				void _resetDuplicateQuestSlot(MissionSlot slot, QuestTree quest)
				{
					//Discarded unreachable code: IL_0093
					//IL_004c: Expected O, but got I4
					//IL_006e: Expected O, but got I4
					object[] array;
					int missionId_;
					while (true)
					{
						array = new object[4];
						int slotId_ = slot.slotId_;
						if (array == null || array != null)
						{
							array[0] = array;
							Item missionItem = slot.MissionItem;
							if ((object)missionItem == null || (object)missionItem != null)
							{
								array[1] = missionItem;
								missionId_ = slot.missionId_;
								if (missionId_ == 0 || missionId_ != 0)
								{
									array[2] = missionId_;
									int iD = quest.Data.ID;
									missionId_ = iD;
									if (iD == 0 || iD != 0)
									{
										break;
									}
								}
							}
						}
					}
					array[3] = missionId_;
					string message = string.Format("RepairQuest: Reset slot#{0}, contain duplicated quest, {1} (id={2}), Quest={3}", array);
					ITransactionContext transactionContext2 = CS_0024_003C_003E8__locals0.context;
					Log(message, transactionContext2);
					slot.ResetMission();
				}
			};
			IEnumerable<MissionSlot> enumerable2 = default(IEnumerable<MissionSlot>);
			MoreLinq.ForEach<MissionSlot>((IEnumerable<>)enumerable2, (Action<>)(object)action2);
			goto IL_00e8;
		}

		[Cpp2IlInjected.Token(Token = "0x600844E")]
		[Cpp2IlInjected.Address(RVA = "0x5B96A0", Offset = "0x5B80A0", VA = "0x1805B96A0")]
		private void PrepareWaitingQueue()
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			//IL_0064: Expected O, but got I4
			int num = 0;
			((List<T>)(object)WaitingQueue).Clear();
			Dictionary<int, QuestTree>.ValueCollection values = (Dictionary<int, QuestTree>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)QuestTreeMap).get_Values();
			Func<QuestTree, bool> func = (Func<QuestTree, bool>)(object)(Func<T, TResult>)delegate(QuestTree x)
			{
				if (x != null)
				{
					Profile profile2 = this.profile;
					if (profile2 != null)
					{
						return Enumerable.Any<MissionSlot>(profile2.world_.SearchQuestSlots(x));
					}
				}
				int num4 = 0;
				throw new NullReferenceException();
			};
			IEnumerable<QuestTree> enumerable = (IEnumerable<QuestTree>)Enumerable.Where<QuestTree>((IEnumerable<>)(object)values, (Func<, >)(object)func);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0064;
					}
					num++;
				}
				Profile profile = this.profile;
				int num3 = 0;
				ProfileWorld world_ = profile.world_;
				((List<T>)(object)WaitingQueue).Add((T)num);
				goto IL_0064;
			}
			goto IL_0068;
			IL_0068:
			if (enumerable == null)
			{
			}
			return;
			IL_0064:
			num += num;
			goto IL_0068;
		}

		[Cpp2IlInjected.Token(Token = "0x600844F")]
		[Cpp2IlInjected.Address(RVA = "0x5B9670", Offset = "0x5B8070", VA = "0x1805B9670")]
		private void OnAnyConditionsChanged(ConditionListener flag)
		{
			if (!IsFrozenDebugMode)
			{
				int forceRefresh = 0;
				EvaluateWaitingQueue(flag, (byte)forceRefresh != 0);
				EvaluateAllAutoStart();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008450")]
		[Cpp2IlInjected.Address(RVA = "0x5B8120", Offset = "0x5B6B20", VA = "0x1805B8120")]
		private void EvaluateWaitingQueue(ConditionListener flag, bool forceRefresh = false)
		{
			//Discarded unreachable code: IL_0069
			List<QuestNode> nodeToStart = (List<QuestNode>)(object)new List<T>();
			List<QuestTree> waitingQueue = WaitingQueue;
			Predicate<QuestTree> predicate = (Predicate<QuestTree>)(object)(Predicate<T>)delegate(QuestTree quest)
			{
				//Discarded unreachable code: IL_0045
				QuestInformation questInformation2 = this;
				bool forceRefresh2 = forceRefresh;
				ITransactionContext transactionContext = questInformation2.context;
				Profile profile = questInformation2.profile;
				ConditionListener flag2 = flag;
				QuestNode questNode = quest.EvaluateNextNodes(profile, transactionContext, flag2, forceRefresh2);
				if (questNode == null)
				{
				}
				((List<T>)(object)nodeToStart).Add((T)questNode);
				return true;
			};
			int num = ((List<T>)(object)waitingQueue).RemoveAll((Predicate<>)(object)predicate);
			List<QuestNode> list = nodeToStart;
			Action<QuestNode> action = (Action<QuestNode>)(object)(Action<T>)delegate(QuestNode x)
			{
				//Discarded unreachable code: IL_0014
				QuestInformation questInformation = this;
				int iD = x.Data.ID;
			};
			((List<T>)(object)list).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6008451")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E80", Offset = "0x5B6880", VA = "0x1805B7E80")]
		private void EvaluateAllAutoStart()
		{
			//Discarded unreachable code: IL_0067, IL_006d
			int num = 0;
			int num2 = 0;
			if (MissionSlot.InInitScopeCounter)
			{
				return;
			}
			ProfileWorld world_ = profile.world_;
			Func<MissionSlot, bool> _003C_003E9__55_ = _003C_003Ec._003C_003E9__55_0;
			if (_003C_003E9__55_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSlot x)
				{
					if (x.state_ == MissionSlotState.Available)
					{
						MissionItemData data = x.Data;
						if (data != null)
						{
							return Enumerable.Any<MissionItemData.Types.AutoAcceptOption>((IEnumerable<>)(object)data.autoAccept_);
						}
					}
					int num5 = 0;
					throw new NullReferenceException();
				};
			}
			IEnumerable<MissionSlot> allMissionSlot = (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)(object)_003C_003E9__55_);
			int num4 = default(int);
			if (allMissionSlot != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_005a;
					}
					num++;
				}
				num4 = 0;
				goto IL_005a;
			}
			goto IL_0061;
			IL_0061:
			if (allMissionSlot == null)
			{
			}
			return;
			IL_005a:
			num4 += num4;
			goto IL_0061;
		}

		[Cpp2IlInjected.Token(Token = "0x6008452")]
		[Cpp2IlInjected.Address(RVA = "0x5B9FB0", Offset = "0x5B89B0", VA = "0x1805B9FB0")]
		public void StartFrozenDebugMode()
		{
			IsFrozenDebugMode = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6008453")]
		[Cpp2IlInjected.Address(RVA = "0x5B9FC0", Offset = "0x5B89C0", VA = "0x1805B9FC0")]
		public void StopFrozenDebugMode()
		{
			IsFrozenDebugMode = false;
			int flag = 0;
			EvaluateWaitingQueue((ConditionListener)flag, forceRefresh: true);
			EvaluateAllAutoStart();
		}

		[Cpp2IlInjected.Token(Token = "0x6008454")]
		[Cpp2IlInjected.Address(RVA = "0x5B60B0", Offset = "0x5B4AB0", VA = "0x1805B60B0")]
		public bool CharacterHasStandByMission(Item characterItem)
		{
			//Discarded unreachable code: IL_0037
			//IL_001b: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<QuestTree> waitingQueue = WaitingQueue;
			Func<QuestNode, bool> func = default(Func<QuestNode, bool>);
			Func<QuestTree, bool> cpp2il__autoParamName__idx_ = (Func<QuestTree, bool>)(object)(Func<T, TResult>)delegate(QuestTree tree)
			{
				//Discarded unreachable code: IL_003a
				Func<QuestNode, bool> func2 = func;
				List<QuestNode> nextNodes = tree.NextNodes;
				if (func2 == null)
				{
					func = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
					{
						//Discarded unreachable code: IL_0033
						if (x.Data.OwnerCharacter == 0)
						{
						}
						return profile.settings_.isDev_ || (long)"{il2cpp field on True, offset 0x3C}" == 1;
					};
				}
				bool flag = ((IEnumerable<>)nextNodes).Any<QuestNode>((Func<, >)(object)func2);
				bool flag2 = default(bool);
				return (!flag) ? flag : (!flag2);
			};
			return ((IEnumerable<>)waitingQueue).Any<QuestTree>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6008455")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F10", Offset = "0x5B7910", VA = "0x1805B8F10")]
		public IEnumerable<Item> GetWaitingQueueMissionsForCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0063
			//IL_001b: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<QuestTree> waitingQueue = WaitingQueue;
			Func<QuestNode, bool> func = default(Func<QuestNode, bool>);
			Func<QuestTree, bool> func2 = (Func<QuestTree, bool>)(object)(Func<T, TResult>)delegate(QuestTree tree)
			{
				//Discarded unreachable code: IL_002e
				List<QuestNode> nextNodes2 = tree.NextNodes;
				Func<QuestNode, bool> func3 = func;
				if (func3 == null)
				{
					func = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
					{
						//Discarded unreachable code: IL_0033
						if (x.Data.OwnerCharacter == 0)
						{
						}
						return profile.settings_.isDev_ || (long)"{il2cpp field on True, offset 0x3C}" == 1;
					};
				}
				return ((IEnumerable<>)nextNodes2).Any<QuestNode>((Func<, >)(object)func3);
			};
			IEnumerable<QuestTree> enumerable = (IEnumerable<QuestTree>)Enumerable.Where<QuestTree>((IEnumerable<>)waitingQueue, (Func<, >)(object)func2);
			Func<QuestTree, IEnumerable<Item>> _003C_003E9__60_ = _003C_003Ec._003C_003E9__60_1;
			if (_003C_003E9__60_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(QuestTree y)
				{
					//Discarded unreachable code: IL_002e
					List<QuestNode> nextNodes = y.NextNodes;
					Func<QuestNode, Item> _003C_003E9__60_2 = _003C_003Ec._003C_003E9__60_3;
					if (_003C_003E9__60_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(QuestNode z)
						{
							int iD = z.Data.ID;
							throw new NullReferenceException();
						};
					}
					return (IEnumerable<Item>)Enumerable.Select<QuestNode, Item>((IEnumerable<>)nextNodes, (Func<, >)(object)_003C_003E9__60_2);
				};
			}
			return (IEnumerable<Item>)Enumerable.SelectMany<QuestTree, Item>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__60_);
		}

		[Cpp2IlInjected.Token(Token = "0x6008456")]
		[Cpp2IlInjected.Address(RVA = "0x5B9490", Offset = "0x5B7E90", VA = "0x1805B9490")]
		private void Log(string message)
		{
			ITransactionContext transactionContext = context;
			Log(message, transactionContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6008457")]
		[Cpp2IlInjected.Address(RVA = "0x5B92A0", Offset = "0x5B7CA0", VA = "0x1805B92A0")]
		public static void Log(string message, [Optional] ITransactionContext context)
		{
			//Discarded unreachable code: IL_0041
			//IL_003f: Expected O, but got I4
			if (context == null)
			{
			}
			string text = "-cli";
			if ("-cli" != null)
			{
				text = "-srv";
			}
			int num = 0;
			string text2 = "[QUEST" + text + "] " + message;
			if ((long)num < (long)(IntPtr)text)
			{
				num += num;
				num++;
			}
			bool autoSkip = ((IFluxStatement)num).AutoSkip;
		}

		[Cpp2IlInjected.Token(Token = "0x6008458")]
		[Cpp2IlInjected.Address(RVA = "0x5BA970", Offset = "0x5B9370", VA = "0x1805BA970")]
		static QuestInformation()
		{
			_parser = (MessageParser<QuestInformation>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
