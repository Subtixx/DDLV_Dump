using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008D8")]
	public sealed class BattlePassStatesData : IMessage<BattlePassStatesData>, IMessage, IEquatable<BattlePassStatesData>, IDeepCloneable<BattlePassStatesData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023BF")]
		private static readonly MessageParser<BattlePassStatesData> _parser = (MessageParser<BattlePassStatesData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new BattlePassStatesData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023C0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023C1")]
		public const int ProgressFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023C2")]
		private static readonly MapField<string, BattlePassProgress>.Codec _map_progress_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C3")]
		private readonly MapField<string, BattlePassProgress> progress_ = (MapField<string, BattlePassProgress>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000CE5")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassStatesData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004C20")]
			[Cpp2IlInjected.Address(RVA = "0x1ABD5B0", Offset = "0x1ABBFB0", VA = "0x181ABD5B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C21")]
			[Cpp2IlInjected.Address(RVA = "0x1ABD4E0", Offset = "0x1ABBEE0", VA = "0x181ABD4E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C22")]
			[Cpp2IlInjected.Address(RVA = "0x1ABD610", Offset = "0x1ABC010", VA = "0x181ABD610", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE8")]
		[DebuggerNonUserCode]
		public MapField<string, BattlePassProgress> Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6004C26")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return progress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE9")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6004C32")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C33")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEA")]
		private ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6004C34")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C35")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEB")]
		private ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x6004C36")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C37")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C23")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD360", Offset = "0x1ABBD60", VA = "0x181ABD360")]
		[DebuggerNonUserCode]
		public BattlePassStatesData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004C24")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD3E0", Offset = "0x1ABBDE0", VA = "0x181ABD3E0")]
		[DebuggerNonUserCode]
		public BattlePassStatesData(BattlePassStatesData other)
		{
			MapField<string, BattlePassProgress> mapField = (progress_ = (MapField<string, BattlePassProgress>)(object)((MapField<TKey, TValue>)(object)other.progress_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C25")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC420", Offset = "0x1ABAE20", VA = "0x181ABC420", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassStatesData Clone()
		{
			//Discarded unreachable code: IL_003b
			BattlePassStatesData battlePassStatesData = new BattlePassStatesData();
			MapField<string, BattlePassProgress> mapField = (battlePassStatesData.progress_ = (MapField<string, BattlePassProgress>)(object)new MapField<TKey, TValue>());
			MapField<string, BattlePassProgress> mapField2 = (battlePassStatesData.progress_ = (MapField<string, BattlePassProgress>)(object)((MapField<TKey, TValue>)(object)progress_).Clone());
			UnknownFieldSet unknownFieldSet = (battlePassStatesData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassStatesData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C27")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC5E0", Offset = "0x1ABAFE0", VA = "0x181ABC5E0", Slot = "0")]
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
				MapField<string, BattlePassProgress> mapField = progress_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C28")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC550", Offset = "0x1ABAF50", VA = "0x181ABC550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassStatesData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, BattlePassProgress> mapField = progress_;
				MapField<string, BattlePassProgress> mapField2 = other.progress_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C29")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((MapField<TKey, TValue>)(object)progress_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD010", Offset = "0x1ABBA10", VA = "0x181ABD010", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD070", Offset = "0x1ABBA70", VA = "0x181ABD070", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<string, BattlePassProgress> mapField = progress_;
			MapField<string, BattlePassProgress>.Codec map_progress_codec = _map_progress_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_progress_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2C")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC310", Offset = "0x1ABAD10", VA = "0x181ABC310", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<string, BattlePassProgress> mapField = progress_;
			MapField<string, BattlePassProgress>.Codec map_progress_codec = _map_progress_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_progress_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2D")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCB20", Offset = "0x1ABB520", VA = "0x181ABCB20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassStatesData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<string, BattlePassProgress> mapField = progress_;
				MapField<string, BattlePassProgress> mapField2 = other.progress_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCBA0", Offset = "0x1ABB5A0", VA = "0x181ABCBA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, BattlePassProgress> mapField = progress_;
					MapField<string, BattlePassProgress>.Codec map_progress_codec = _map_progress_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_progress_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C2F")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC6C0", Offset = "0x1ABB0C0", VA = "0x181ABC6C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, BattlePassProgress> mapField = progress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C30")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCFB0", Offset = "0x1ABB9B0", VA = "0x181ABCFB0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004C31")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC3C0", Offset = "0x1ABADC0", VA = "0x181ABC3C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<string, BattlePassProgress> mapField = progress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C38")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC740", Offset = "0x1ABB140", VA = "0x181ABC740")]
		public void Initialize(in Player player, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00aa
			int num = 0;
			IPlayerEventDispatcher dispatcher = player.dispatcher;
			if (dispatcher == null)
			{
			}
			int num2 = 0;
			Dispatcher = (ProfileEventDispatcher)dispatcher;
			Context = context;
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			ProfileEventDispatcher.BattlePassTasksUpdate battlePassTasksUpdate = OnBattlePassTasksUpdate;
			profileEventDispatcher.OnBattlePassTasksUpdate += battlePassTasksUpdate;
			DateTime now = (DateTime)battlePassTasksUpdate;
			MapField<string, BattlePassProgress> mapField = progress_;
			Func<KeyValuePair<string, BattlePassProgress>, bool> func = (Func<KeyValuePair<string, BattlePassProgress>, bool>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			IEnumerable<KeyValuePair<string, BattlePassProgress>> enumerable = (IEnumerable<KeyValuePair<string, BattlePassProgress>>)Enumerable.Where<KeyValuePair<string, BattlePassProgress>>((IEnumerable<>)(object)mapField, (Func<, >)(object)func);
			Func<KeyValuePair<string, BattlePassProgress>, string> func2 = default(Func<KeyValuePair<string, BattlePassProgress>, string>);
			if (_003C_003Ec._003C_003E9__40_1 == null)
			{
				func2 = (Func<KeyValuePair<string, BattlePassProgress>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			List<string> list = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Select<KeyValuePair<string, BattlePassProgress>, string>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			bool flag = default(bool);
			if (flag)
			{
				MapField<string, BattlePassProgress> mapField2 = progress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C39")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCC90", Offset = "0x1ABB690", VA = "0x181ABCC90")]
		private unsafe void OnBattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons)
		{
			//Discarded unreachable code: IL_0061, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			//IL_001a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			int num = 0;
			ITransactionContext transactionContext = Context;
			bool flag = default(bool);
			if (flag)
			{
				if (!((MapField<TKey, TValue>)(object)progress_).TryGetValue((TKey)num, out *(TValue*)num))
				{
					BattlePassProgress battlePassProgress = new BattlePassProgress();
					battlePassProgress.isNew_ = true;
					((MapField<TKey, TValue>)(object)progress_).Add((TKey)num, (TValue)battlePassProgress);
				}
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				ITransactionContext transactionContext2 = Context;
				Profile profile = Profile;
				ProfileEventDispatcher.TransactionStateChanged onTransactionStateChanged = profileEventDispatcher.OnTransactionStateChanged;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C3A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABD130", Offset = "0x1ABBB30", VA = "0x181ABD130")]
		static BattlePassStatesData()
		{
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<BattlePassProgress> parser = BattlePassProgress._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<BattlePassProgress>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<BattlePassStatesData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
