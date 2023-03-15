using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008D4")]
	public sealed class MiniEventStatesData : IMessage<MiniEventStatesData>, IMessage, IEquatable<MiniEventStatesData>, IDeepCloneable<MiniEventStatesData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023A5")]
		private static readonly MessageParser<MiniEventStatesData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023A7")]
		public const int ProgressFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023A8")]
		private static readonly MapField<string, MiniEventProgress>.Codec _map_progress_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023A9")]
		private readonly MapField<string, MiniEventProgress> progress_ = (MapField<string, MiniEventProgress>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000CD1")]
		[DebuggerNonUserCode]
		public static MessageParser<MiniEventStatesData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004BC6")]
			[Cpp2IlInjected.Address(RVA = "0x7F7F20", Offset = "0x7F6920", VA = "0x1807F7F20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BC7")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E50", Offset = "0x7F6850", VA = "0x1807F7E50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BC8")]
			[Cpp2IlInjected.Address(RVA = "0x7F7F80", Offset = "0x7F6980", VA = "0x1807F7F80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD4")]
		[DebuggerNonUserCode]
		public MapField<string, MiniEventProgress> Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6004BCC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return progress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD5")]
		private Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6004BD8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BD9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD6")]
		private ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6004BDA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BDB")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD7")]
		private ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x6004BDC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BDD")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC9")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CD0", Offset = "0x7F66D0", VA = "0x1807F7CD0")]
		[DebuggerNonUserCode]
		public MiniEventStatesData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCA")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D50", Offset = "0x7F6750", VA = "0x1807F7D50")]
		[DebuggerNonUserCode]
		public MiniEventStatesData(MiniEventStatesData other)
		{
			MapField<string, MiniEventProgress> mapField = (progress_ = (MapField<string, MiniEventProgress>)(object)((MapField<TKey, TValue>)(object)other.progress_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCB")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C80", Offset = "0x7F5680", VA = "0x1807F6C80", Slot = "10")]
		[DebuggerNonUserCode]
		public MiniEventStatesData Clone()
		{
			//Discarded unreachable code: IL_003b
			MiniEventStatesData miniEventStatesData = new MiniEventStatesData();
			MapField<string, MiniEventProgress> mapField = (miniEventStatesData.progress_ = (MapField<string, MiniEventProgress>)(object)new MapField<TKey, TValue>());
			MapField<string, MiniEventProgress> mapField2 = (miniEventStatesData.progress_ = (MapField<string, MiniEventProgress>)(object)((MapField<TKey, TValue>)(object)progress_).Clone());
			UnknownFieldSet unknownFieldSet = (miniEventStatesData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return miniEventStatesData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCD")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E40", Offset = "0x7F5840", VA = "0x1807F6E40", Slot = "0")]
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
				MapField<string, MiniEventProgress> mapField = progress_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCE")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DB0", Offset = "0x7F57B0", VA = "0x1807F6DB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventStatesData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, MiniEventProgress> mapField = progress_;
				MapField<string, MiniEventProgress> mapField2 = other.progress_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCF")]
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

		[Cpp2IlInjected.Token(Token = "0x6004BD0")]
		[Cpp2IlInjected.Address(RVA = "0x7F7980", Offset = "0x7F6380", VA = "0x1807F7980", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD1")]
		[Cpp2IlInjected.Address(RVA = "0x7F79E0", Offset = "0x7F63E0", VA = "0x1807F79E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			MapField<string, MiniEventProgress> mapField = progress_;
			MapField<string, MiniEventProgress>.Codec map_progress_codec = _map_progress_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_progress_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD2")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B70", Offset = "0x7F5570", VA = "0x1807F6B70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			MapField<string, MiniEventProgress> mapField = progress_;
			MapField<string, MiniEventProgress>.Codec map_progress_codec = _map_progress_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_progress_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD3")]
		[Cpp2IlInjected.Address(RVA = "0x7F71B0", Offset = "0x7F5BB0", VA = "0x1807F71B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventStatesData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				MapField<string, MiniEventProgress> mapField = progress_;
				MapField<string, MiniEventProgress> mapField2 = other.progress_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD4")]
		[Cpp2IlInjected.Address(RVA = "0x7F70C0", Offset = "0x7F5AC0", VA = "0x1807F70C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<string, MiniEventProgress> mapField = progress_;
					MapField<string, MiniEventProgress>.Codec map_progress_codec = _map_progress_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_progress_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD5")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F20", Offset = "0x7F5920", VA = "0x1807F6F20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				MapField<string, MiniEventProgress> mapField = progress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD6")]
		[Cpp2IlInjected.Address(RVA = "0x7F76C0", Offset = "0x7F60C0", VA = "0x1807F76C0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004BD7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C20", Offset = "0x7F5620", VA = "0x1807F6C20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				MapField<string, MiniEventProgress> mapField = progress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDE")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FA0", Offset = "0x7F59A0", VA = "0x1807F6FA0")]
		public void Initialize(Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_004c
			Profile = profile;
			Dispatcher = dispatcher;
			Context = context;
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			ProfileEventDispatcher.MiniEventStarted value = OnMiniEventStarted;
			profileEventDispatcher.OnMiniEventStarted += value;
			ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
			ProfileEventDispatcher.MiniEventStopped value2 = OnMiniEventStopped;
			profileEventDispatcher2.OnMiniEventStopped += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDF")]
		[Cpp2IlInjected.Address(RVA = "0x7F7230", Offset = "0x7F5C30", VA = "0x1807F7230")]
		private void OnMiniEventStarted(bool start, string name, DateTime endDate)
		{
			//IL_006e: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			MiniEventProgress miniEventProgress2;
			int num2;
			while (true)
			{
				if (!start)
				{
					if (((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
					{
						MiniEventProgress miniEventProgress = (MiniEventProgress)((MapField<TKey, TValue>)(object)progress_)[(TKey)name];
						ProfileEventDispatcher profileEventDispatcher = Dispatcher;
						ITransactionContext transactionContext = Context;
						Profile profile = (miniEventProgress.Profile = Profile);
						miniEventProgress.Dispatcher = profileEventDispatcher;
						miniEventProgress.Context = transactionContext;
						if (miniEventProgress.name != name)
						{
							miniEventProgress.name = name;
							int num = 0;
							miniEventProgress.data = (MiniEventData)num;
						}
						miniEventProgress.EndDate = endDate;
						if (miniEventProgress.Data != null)
						{
							miniEventProgress.ResumeMilestone();
						}
					}
					return;
				}
				if (!((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
				{
					miniEventProgress2 = new MiniEventProgress();
					((MapField<TKey, TValue>)(object)progress_).Add((TKey)name, (TValue)miniEventProgress2);
					Profile profile2 = Profile;
					ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
					ITransactionContext transactionContext2 = Context;
					miniEventProgress2.Profile = profile2;
					miniEventProgress2.Dispatcher = profileEventDispatcher2;
					miniEventProgress2.Context = transactionContext2;
					bool flag = miniEventProgress2.name != name;
					num2 = 0;
					if (flag)
					{
						miniEventProgress2.name = name;
						miniEventProgress2.data = (MiniEventData)num2;
					}
					miniEventProgress2.EndDate = endDate;
					if (miniEventProgress2.Data != null)
					{
						break;
					}
				}
			}
			RepeatedField<MilestoneState> milestoneStates_ = miniEventProgress2.milestoneStates_;
			miniEventProgress2.currentMilestoneIdx_ = num2;
			((RepeatedField<T>)(object)milestoneStates_).Clear();
			miniEventProgress2.InitMilestone();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE0")]
		[Cpp2IlInjected.Address(RVA = "0x7F74D0", Offset = "0x7F5ED0", VA = "0x1807F74D0")]
		private void OnMiniEventStopped(string name)
		{
			//Discarded unreachable code: IL_002e
			if (((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
			{
				((MiniEventProgress)((MapField<TKey, TValue>)(object)progress_)[(TKey)name]).StopMilestone();
				bool flag = ((MapField<TKey, TValue>)(object)progress_).Remove((TKey)name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE1")]
		[Cpp2IlInjected.Address(RVA = "0x7F7720", Offset = "0x7F6120", VA = "0x1807F7720")]
		private bool Start(string name, DateTime endDate)
		{
			//IL_0074: Expected O, but got I4
			if (!((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
			{
				MiniEventProgress miniEventProgress = new MiniEventProgress();
				((MapField<TKey, TValue>)(object)progress_).Add((TKey)name, (TValue)miniEventProgress);
				Profile profile = Profile;
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				ITransactionContext transactionContext = Context;
				miniEventProgress.Profile = profile;
				miniEventProgress.Dispatcher = profileEventDispatcher;
				miniEventProgress.Context = transactionContext;
				bool flag = miniEventProgress.name != name;
				int num = 0;
				if (flag)
				{
					miniEventProgress.name = name;
					miniEventProgress.data = (MiniEventData)num;
				}
				miniEventProgress.EndDate = endDate;
				if (miniEventProgress.Data != null)
				{
					RepeatedField<MilestoneState> milestoneStates_ = miniEventProgress.milestoneStates_;
					miniEventProgress.currentMilestoneIdx_ = num;
					((RepeatedField<T>)(object)milestoneStates_).Clear();
					miniEventProgress.InitMilestone();
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE2")]
		[Cpp2IlInjected.Address(RVA = "0x7F7580", Offset = "0x7F5F80", VA = "0x1807F7580")]
		private bool Resume(string name, DateTime endDate)
		{
			if (((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
			{
				MiniEventProgress miniEventProgress = (MiniEventProgress)((MapField<TKey, TValue>)(object)progress_)[(TKey)name];
				ProfileEventDispatcher profileEventDispatcher = Dispatcher;
				ITransactionContext transactionContext = Context;
				Profile profile = (miniEventProgress.Profile = Profile);
				miniEventProgress.Dispatcher = profileEventDispatcher;
				miniEventProgress.Context = transactionContext;
				if (miniEventProgress.name != name)
				{
					miniEventProgress.name = name;
				}
				miniEventProgress.EndDate = endDate;
				if (miniEventProgress.Data != null)
				{
					miniEventProgress.ResumeMilestone();
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE3")]
		[Cpp2IlInjected.Address(RVA = "0x7F78C0", Offset = "0x7F62C0", VA = "0x1807F78C0")]
		private bool Stop(string name)
		{
			if (((MapField<TKey, TValue>)(object)progress_).ContainsKey((TKey)name))
			{
				((MiniEventProgress)((MapField<TKey, TValue>)(object)progress_)[(TKey)name]).StopMilestone();
				bool flag = ((MapField<TKey, TValue>)(object)progress_).Remove((TKey)name);
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE4")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AA0", Offset = "0x7F64A0", VA = "0x1807F7AA0")]
		static MiniEventStatesData()
		{
			Func<MiniEventStatesData> func = default(Func<MiniEventStatesData>);
			_parser = (MessageParser<MiniEventStatesData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<MiniEventProgress> parser = MiniEventProgress._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<MiniEventProgress>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<MiniEventStatesData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
