using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008D2")]
	public sealed class MegaEventProgress : IMessage<MegaEventProgress>, IMessage, IEquatable<MegaEventProgress>, IDeepCloneable<MegaEventProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400239B")]
		private static readonly MessageParser<MegaEventProgress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400239C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400239D")]
		public const int ChapterIndexFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400239E")]
		private int chapterIndex_;

		[Cpp2IlInjected.Token(Token = "0x400239F")]
		public const int RequestIndexFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023A0")]
		private int requestIndex_;

		[Cpp2IlInjected.Token(Token = "0x17000CC7")]
		[DebuggerNonUserCode]
		public static MessageParser<MegaEventProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004B9F")]
			[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BA0")]
			[Cpp2IlInjected.Address(RVA = "0x7F4320", Offset = "0x7F2D20", VA = "0x1807F4320")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004BA1")]
			[Cpp2IlInjected.Address(RVA = "0x7F4480", Offset = "0x7F2E80", VA = "0x1807F4480", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCA")]
		[DebuggerNonUserCode]
		public int ChapterIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004BA5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return chapterIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BA6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				chapterIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCB")]
		[DebuggerNonUserCode]
		public int RequestIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004BA7")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return requestIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BA8")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				requestIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40023A1")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004BB7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004BB8")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40023A2")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004BB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004BBA")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCE")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004BBB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004BBC")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCF")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6004BBD")]
			[Cpp2IlInjected.Address(RVA = "0x7F43F0", Offset = "0x7F2DF0", VA = "0x1807F43F0")]
			get
			{
				return !string.IsNullOrEmpty(Name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD0")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6004BBE")]
			[Cpp2IlInjected.Address(RVA = "0x7F4410", Offset = "0x7F2E10", VA = "0x1807F4410")]
			get
			{
				int num = 0;
				int num2 = requestIndex_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MegaEventProgress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA3")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public MegaEventProgress(MegaEventProgress other)
		{
			int num = (chapterIndex_ = other.chapterIndex_);
			int num2 = (requestIndex_ = other.requestIndex_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C10", Offset = "0x7F2610", VA = "0x1807F3C10", Slot = "10")]
		[DebuggerNonUserCode]
		public MegaEventProgress Clone()
		{
			//Discarded unreachable code: IL_0037
			MegaEventProgress megaEventProgress = new MegaEventProgress();
			int num = (megaEventProgress.chapterIndex_ = chapterIndex_);
			int num2 = (megaEventProgress.requestIndex_ = requestIndex_);
			UnknownFieldSet unknownFieldSet = (megaEventProgress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return megaEventProgress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CB0", Offset = "0x7F26B0", VA = "0x1807F3CB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)chapterIndex_ == (IntPtr)typeof(MegaEventProgress).TypeHandle && (IntPtr)requestIndex_ == (IntPtr)typeof(MegaEventProgress).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAA")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MegaEventProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.chapterIndex_;
				if (chapterIndex_ == num)
				{
					int num2 = other.requestIndex_;
					if (requestIndex_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAB")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (chapterIndex_ != 0)
				{
				}
				if (requestIndex_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAC")]
		[Cpp2IlInjected.Address(RVA = "0x7F41B0", Offset = "0x7F2BB0", VA = "0x1807F41B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAD")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (chapterIndex_ != 0)
			{
				int value = chapterIndex_;
				output.WriteInt32(value);
			}
			if (requestIndex_ != 0)
			{
				int value2 = requestIndex_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3B40", Offset = "0x7F2540", VA = "0x1807F3B40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = chapterIndex_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = requestIndex_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAF")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MegaEventProgress other)
		{
			if (other != null)
			{
				int num = other.chapterIndex_;
				if (num != 0)
				{
					chapterIndex_ = num;
				}
				int num2 = other.requestIndex_;
				if (num2 != 0)
				{
					requestIndex_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB0")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (chapterIndex_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (requestIndex_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D40", Offset = "0x7F2740", VA = "0x1807F3D40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = chapterIndex_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB2")]
		[Cpp2IlInjected.Address(RVA = "0x7F40E0", Offset = "0x7F2AE0", VA = "0x1807F40E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				chapterIndex_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			requestIndex_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB3")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				chapterIndex_ = 0;
				break;
			case 2:
				requestIndex_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E00", Offset = "0x7F2800", VA = "0x1807F3E00")]
		public void Initialize(ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0029
			ProfileEventDispatcher.MegaEventStarted value = OnMegaEventStarted;
			dispatcher.OnMegaEventStarted += value;
			Action value2 = OnMegaEventStopped;
			dispatcher.OnMegaEventStopped += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB5")]
		[Cpp2IlInjected.Address(RVA = "0x7F4060", Offset = "0x7F2A60", VA = "0x1807F4060")]
		private void OnMegaEventStarted(bool start, DateTime startTime, DateTime endTime, string name)
		{
			//IL_0022: Expected O, but got I4
			if (start)
			{
				int num = (chapterIndex_ = 0);
			}
			StartTime = startTime;
			EndTime = endTime;
			Name = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4090", Offset = "0x7F2A90", VA = "0x1807F4090")]
		private void OnMegaEventStopped()
		{
			//IL_0014: Expected I4, but got I8
			Name = "";
			chapterIndex_ = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BBF")]
		[Cpp2IlInjected.Address(RVA = "0x7F41A0", Offset = "0x7F2BA0", VA = "0x1807F41A0")]
		public void Start()
		{
			int num = (chapterIndex_ = 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3CA0", Offset = "0x7F26A0", VA = "0x1807F3CA0")]
		public void Complete()
		{
			//IL_0009: Expected I4, but got I8
			chapterIndex_ = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EE0", Offset = "0x7F28E0", VA = "0x1807F3EE0")]
		public Item Next(MegaEventData megaEventData)
		{
			//IL_005b: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			int num = requestIndex_;
			num = (requestIndex_ = num + 1);
			RepeatedField<MegaEventChapterData> chapters_ = megaEventData.chapters_;
			int index = chapterIndex_;
			int count = ((RepeatedField<T>)(object)((MegaEventChapterData)((RepeatedField<T>)(object)chapters_)[index]).requests_).Count;
			RepeatedField<MegaEventChapterData> chapters_2 = megaEventData.chapters_;
			int index2 = chapterIndex_;
			int characterId_ = ((MegaEventChapterData)((RepeatedField<T>)(object)chapters_2)[index2]).characterId_;
			requestIndex_ = 0;
			RepeatedField<MegaEventChapterData> chapters_3 = megaEventData.chapters_;
			int num2 = chapterIndex_;
			int count2 = ((RepeatedField<T>)(object)chapters_3).Count;
			chapterIndex_ = -1;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4210", Offset = "0x7F2C10", VA = "0x1807F4210")]
		static MegaEventProgress()
		{
			Func<MegaEventProgress> func = default(Func<MegaEventProgress>);
			_parser = (MessageParser<MegaEventProgress>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
