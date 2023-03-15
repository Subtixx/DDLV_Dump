using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Campaign;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008F1")]
	public sealed class CampaignHistoryData : IMessage<CampaignHistoryData>, IMessage, IEquatable<CampaignHistoryData>, IDeepCloneable<CampaignHistoryData>, IMessageFieldAccessor, ICampaignManager
	{
		[Cpp2IlInjected.Token(Token = "0x4002438")]
		private static readonly MessageParser<CampaignHistoryData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002439")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400243A")]
		public const int StatesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400243B")]
		private static readonly MapField<string, CampaignState>.Codec _map_states_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400243C")]
		private readonly MapField<string, CampaignState> states_ = (MapField<string, CampaignState>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400243D")]
		private Player player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400243E")]
		private World world;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400243F")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002440")]
		private List<CampaignData> validCampaigns = (List<CampaignData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002443")]
		private ConditionListener usefulListeners;

		[Cpp2IlInjected.Token(Token = "0x17000D32")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignHistoryData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D81")]
			[Cpp2IlInjected.Address(RVA = "0x717EE0", Offset = "0x7168E0", VA = "0x180717EE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D33")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D82")]
			[Cpp2IlInjected.Address(RVA = "0x717E00", Offset = "0x716800", VA = "0x180717E00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D34")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D83")]
			[Cpp2IlInjected.Address(RVA = "0x717F40", Offset = "0x716940", VA = "0x180717F40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D35")]
		[DebuggerNonUserCode]
		public MapField<string, CampaignState> States
		{
			[Cpp2IlInjected.Token(Token = "0x6004D87")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return states_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D36")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4002441")]
		public DateTime NextEventDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004D93")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004D94")]
			[Cpp2IlInjected.Address(RVA = "0x70BA20", Offset = "0x70A420", VA = "0x18070BA20")]
			private set;
		} = DateTime.MaxValue;


		[Cpp2IlInjected.Token(Token = "0x17000D37")]
		public Action NextEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x6004D95")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CNextEventAction_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D96")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CNextEventAction_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D84")]
		[Cpp2IlInjected.Address(RVA = "0x717B80", Offset = "0x716580", VA = "0x180717B80")]
		[DebuggerNonUserCode]
		public CampaignHistoryData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D85")]
		[Cpp2IlInjected.Address(RVA = "0x717C80", Offset = "0x716680", VA = "0x180717C80")]
		[DebuggerNonUserCode]
		public CampaignHistoryData(CampaignHistoryData other)
		{
			MapField<string, CampaignState> mapField = (states_ = (MapField<string, CampaignState>)(object)((MapField<TKey, TValue>)(object)other.states_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D86")]
		[Cpp2IlInjected.Address(RVA = "0x715F10", Offset = "0x714910", VA = "0x180715F10", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignHistoryData Clone()
		{
			//Discarded unreachable code: IL_0059
			CampaignHistoryData campaignHistoryData = new CampaignHistoryData();
			MapField<string, CampaignState> mapField = (campaignHistoryData.states_ = (MapField<string, CampaignState>)(object)new MapField<TKey, TValue>());
			List<CampaignData> list = (campaignHistoryData.validCampaigns = (List<CampaignData>)(object)new List<T>());
			DateTime dateTime = (campaignHistoryData.NextEventDateTime = DateTime.MaxValue);
			MapField<string, CampaignState> mapField2 = (campaignHistoryData.states_ = (MapField<string, CampaignState>)(object)((MapField<TKey, TValue>)(object)states_).Clone());
			UnknownFieldSet unknownFieldSet = (campaignHistoryData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return campaignHistoryData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D88")]
		[Cpp2IlInjected.Address(RVA = "0x716150", Offset = "0x714B50", VA = "0x180716150", Slot = "0")]
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
				MapField<string, CampaignState> mapField = states_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D89")]
		[Cpp2IlInjected.Address(RVA = "0x7160C0", Offset = "0x714AC0", VA = "0x1807160C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignHistoryData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, CampaignState> mapField = states_;
				MapField<string, CampaignState> mapField2 = other.states_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)states_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8B")]
		[Cpp2IlInjected.Address(RVA = "0x717720", Offset = "0x716120", VA = "0x180717720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8C")]
		[Cpp2IlInjected.Address(RVA = "0x717890", Offset = "0x716290", VA = "0x180717890", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<string, CampaignState> mapField = states_;
			MapField<string, CampaignState>.Codec map_states_codec = _map_states_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_states_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8D")]
		[Cpp2IlInjected.Address(RVA = "0x715E00", Offset = "0x714800", VA = "0x180715E00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<string, CampaignState> mapField = states_;
			MapField<string, CampaignState>.Codec map_states_codec = _map_states_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_states_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8E")]
		[Cpp2IlInjected.Address(RVA = "0x716BD0", Offset = "0x7155D0", VA = "0x180716BD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignHistoryData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<string, CampaignState> mapField = states_;
				MapField<string, CampaignState> mapField2 = other.states_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8F")]
		[Cpp2IlInjected.Address(RVA = "0x716C50", Offset = "0x715650", VA = "0x180716C50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, CampaignState> mapField = states_;
					MapField<string, CampaignState>.Codec map_states_codec = _map_states_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_states_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D90")]
		[Cpp2IlInjected.Address(RVA = "0x716760", Offset = "0x715160", VA = "0x180716760", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, CampaignState> mapField = states_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D91")]
		[Cpp2IlInjected.Address(RVA = "0x717620", Offset = "0x716020", VA = "0x180717620", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004D92")]
		[Cpp2IlInjected.Address(RVA = "0x715EB0", Offset = "0x7148B0", VA = "0x180715EB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<string, CampaignState> mapField = states_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D97")]
		[Cpp2IlInjected.Address(RVA = "0x7167E0", Offset = "0x7151E0", VA = "0x1807167E0")]
		public void Initialize(in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_006e, IL_0074, IL_007a, IL_0080
			int num = 0;
			ITransactionContext transactionContext = (this.context = context);
			IEnumerable<> enumerable = ProtoDatabase.Instance.EnumerateWithId<CampaignData>();
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0052;
					}
					num++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				List<CampaignData> list = validCampaigns;
			}
			goto IL_0052;
			IL_0052:
			if (enumerable != null)
			{
			}
			Func<CampaignData, DateTime> func = (Func<CampaignData, DateTime>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				CampaignHistoryData campaignHistoryData = this;
				DateTime result = default(DateTime);
				return result;
			};
			IOrderedEnumerable<CampaignData> orderedEnumerable = default(IOrderedEnumerable<CampaignData>);
			List<CampaignData> list2 = (List<CampaignData>)(object)Enumerable.ToList<CampaignData>((IEnumerable<>)orderedEnumerable);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D98")]
		[Cpp2IlInjected.Address(RVA = "0x716230", Offset = "0x714C30", VA = "0x180716230")]
		public void Evaluate()
		{
			//Discarded unreachable code: IL_00ad, IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1, IL_00d7
			//IL_0016: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			int num = 0;
			DateTime dateTime = (NextEventDateTime = DateTime.MaxValue);
			NextEventAction = (Action)num;
			IPlayerEventDispatcher dispatcher = player.dispatcher;
			ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			int num2 = 0;
			int num3 = 0;
			usefulListeners = (ConditionListener)num;
			List<CampaignData> list = validCampaigns;
			bool flag = default(bool);
			if (flag)
			{
				MapField<string, CampaignState> mapField = states_;
				bool flag2 = default(bool);
				CampaignState campaignState = default(CampaignState);
				if (!flag2)
				{
					int num4 = 0;
					((MapField<TKey, TValue>)(object)states_).Add((TKey)num4, (TValue)campaignState);
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					goto IL_0084;
				}
				if (campaignState.isActive_)
				{
					campaignState.isActive_ = false;
					ICampaignType campaignType = default(ICampaignType);
					if (campaignType != null)
					{
						goto IL_0084;
					}
				}
				goto IL_008e;
			}
			goto IL_00a3;
			IL_00a3:
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			return;
			IL_0084:
			ICampaignType campaignType2 = default(ICampaignType);
			ICampaignType campaignType3 = default(ICampaignType);
			if (campaignType2 != null && campaignType3 == null)
			{
			}
			goto IL_008e;
			IL_008e:
			int num8 = 0;
			DateTime dateTime2 = default(DateTime);
			SetNextEventDateTime(dateTime2, (Action)num8);
			ConditionListener conditionListener = default(ConditionListener);
			usefulListeners = conditionListener;
			goto IL_00a3;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D99")]
		[Cpp2IlInjected.Address(RVA = "0x717510", Offset = "0x715F10", VA = "0x180717510")]
		private void RegisterListeners()
		{
			//Discarded unreachable code: IL_0027
			if (usefulListeners != 0)
			{
				IPlayerEventDispatcher dispatcher = player.dispatcher;
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
				int num = 0;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9A")]
		[Cpp2IlInjected.Address(RVA = "0x717780", Offset = "0x716180", VA = "0x180717780")]
		private void UnregisterListeners()
		{
			//Discarded unreachable code: IL_0027
			//IL_0026: Expected I4, but got I8
			IPlayerEventDispatcher dispatcher = player.dispatcher;
			ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			int num = 0;
			int num2 = 0;
			usefulListeners = ConditionListener.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9B")]
		[Cpp2IlInjected.Address(RVA = "0x716D40", Offset = "0x715740", VA = "0x180716D40")]
		private void OnAnyConditionChanged(ConditionListener listener)
		{
			if (usefulListeners.IsAffectedBy(listener))
			{
				Evaluate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9C")]
		[Cpp2IlInjected.Address(RVA = "0x717680", Offset = "0x716080", VA = "0x180717680")]
		public void SetNextEventDateTime(DateTime dateTime, Action action)
		{
			if (NextEventDateTime > dateTime)
			{
				NextEventAction = action;
				NextEventDateTime = dateTime;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9D")]
		[Cpp2IlInjected.Address(RVA = "0x716F10", Offset = "0x715910", VA = "0x180716F10", Slot = "14")]
		public void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMegaEvent megaEvent)
		{
			uint num2 = default(uint);
			MegaEventData megaEventData = default(MegaEventData);
			do
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				if (update != 0)
				{
					switch (update)
					{
					case CampaignUpdate.Continue:
						if (world.dispatcher != null && world.dispatcher == null)
						{
						}
						return;
					default:
						return;
					case CampaignUpdate.Enter:
						break;
					}
				}
				if (world.dispatcher != null)
				{
					CampaignData campaignData = campaign;
					CampaignData campaignData2 = campaign;
					int num = 0;
					string name_ = megaEvent.name_;
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
				}
				StartChapters();
				ITransactionContext transactionContext = context;
				[Cpp2IlInjected.Token(Token = "0x6004DA5")]
				[Cpp2IlInjected.Address(RVA = "0xEF7C50", Offset = "0xEF6650", VA = "0x180EF7C50")]
				void StartChapters()
				{
					//Discarded unreachable code: IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c
					//IL_0077: Expected I4, but got O
					//IL_0081: Expected I4, but got I8
					int num3 = 0;
					List<Item> list = (List<Item>)(object)new List<T>();
					ITransactionContext transactionContext2 = context;
					uint num4 = default(uint);
					if (num3 < (int)num4)
					{
						num3 += num3;
						num3++;
					}
					RepeatedField<MegaEventChapterData> chapters_ = megaEventData.chapters_;
					bool flag = default(bool);
					if (flag)
					{
						MegaEventData megaEventData2 = megaEventData;
						CampaignData campaignData3 = campaign;
						CampaignHistoryData campaignHistoryData = this;
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
						CampaignHistoryData campaignHistoryData2 = this;
						bool flag3 = default(bool);
						while (flag3)
						{
						}
						Character character = new Character();
						int num5 = 0;
						character.base_.id_ = (int)character;
						character.status_ = Character.Types.CharacterStatus.InEvent;
						character.friendshipLevel_ = num3;
						CampaignHistoryData campaignHistoryData3 = this;
						IPlayerEventDispatcher dispatcher = campaignHistoryData3.player.dispatcher;
						ITransactionContext transactionContext3 = campaignHistoryData3.context;
						if (dispatcher == null)
						{
							num5 += num5;
						}
						int num6 = 0;
						CampaignHistoryData campaignHistoryData4 = this;
						ProfileWorld profileWorld = default(ProfileWorld);
						((RepeatedField<T>)(object)profileWorld.characters_).Add((T)character);
					}
				}
			}
			while (world.dispatcher == null);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9E")]
		[Cpp2IlInjected.Address(RVA = "0x717220", Offset = "0x715C20", VA = "0x180717220", Slot = "15")]
		public void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMiniEvent miniEvent)
		{
			do
			{
				if (update == CampaignUpdate.Enter)
				{
					continue;
				}
				switch (update)
				{
				case CampaignUpdate.Continue:
					if (player.dispatcher == null)
					{
						break;
					}
					goto case CampaignUpdate.Enter;
				case CampaignUpdate.Enter:
					if (player.dispatcher != null)
					{
						string name_ = miniEvent.name_;
					}
					break;
				}
				return;
			}
			while (player.dispatcher == null);
			string name_2 = miniEvent.name_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9F")]
		[Cpp2IlInjected.Address(RVA = "0x716D70", Offset = "0x715770", VA = "0x180716D70", Slot = "16")]
		public void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMicroEvent microEvent)
		{
			//Discarded unreachable code: IL_0023
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			if (update != 0)
			{
				switch (update)
				{
				}
			}
			else
			{
				IPlayerEventDispatcher dispatcher = player.dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA0")]
		[Cpp2IlInjected.Address(RVA = "0x717340", Offset = "0x715D40", VA = "0x180717340", Slot = "17")]
		public void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignPhonePromptEvent phonePromptEvent)
		{
			//IL_0042: Expected I4, but got I8
			if (update != 0)
			{
				switch (update)
				{
				case CampaignUpdate.Continue:
				{
					ProfilePlayer profilePlayer = default(ProfilePlayer);
					profilePlayer.phonePromptEvent_.Name = "";
					return;
				}
				default:
					return;
				case CampaignUpdate.Enter:
					break;
				}
			}
			else
			{
				ITransactionContext transactionContext = context;
				ProfilePlayer profilePlayer2 = default(ProfilePlayer);
				Timestamp startDate_ = default(Timestamp);
				profilePlayer2.phonePromptEvent_.startDate_ = startDate_;
				ProfilePlayer profilePlayer3 = default(ProfilePlayer);
				profilePlayer3.phonePromptEvent_.participationCount_ = 0;
			}
			ProfilePlayer profilePlayer4 = default(ProfilePlayer);
			PhonePromptEventData phonePromptEvent_ = profilePlayer4.phonePromptEvent_;
			string text = (phonePromptEvent_.Name = phonePromptEvent.name_);
			ProfilePlayer profilePlayer5 = default(ProfilePlayer);
			DateTime _003CEndDate_003Ek__BackingField = default(DateTime);
			profilePlayer5.phonePromptEvent_.EndDate = _003CEndDate_003Ek__BackingField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA1")]
		[Cpp2IlInjected.Address(RVA = "0x717950", Offset = "0x716350", VA = "0x180717950")]
		static CampaignHistoryData()
		{
			Func<CampaignHistoryData> func = default(Func<CampaignHistoryData>);
			_parser = (MessageParser<CampaignHistoryData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<CampaignState> parser = CampaignState._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<CampaignState>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<CampaignHistoryData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
