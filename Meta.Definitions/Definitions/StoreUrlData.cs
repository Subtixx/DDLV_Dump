using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class StoreUrlData : IMessage<StoreUrlData>, IMessage, IEquatable<StoreUrlData>, IDeepCloneable<StoreUrlData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private static readonly MessageParser<StoreUrlData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public const int UseSteamOverlayFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool useSteamOverlay_;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public const int SteamURLFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private string steamURL_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public const int EpicURLFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private string epicURL_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreUrlData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0x2556E70", Offset = "0x2555870", VA = "0x182556E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x2556CC0", Offset = "0x25556C0", VA = "0x182556CC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0x2556ED0", Offset = "0x25558D0", VA = "0x182556ED0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		[DebuggerNonUserCode]
		public bool UseSteamOverlay
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useSteamOverlay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useSteamOverlay_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		[DebuggerNonUserCode]
		public string SteamURL
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return steamURL_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x2557050", Offset = "0x2555A50", VA = "0x182557050")]
			set
			{
				string text = (steamURL_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		[DebuggerNonUserCode]
		public string EpicURL
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return epicURL_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x2556FE0", Offset = "0x25559E0", VA = "0x182556FE0")]
			set
			{
				string text = (epicURL_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public static StoreUrlData Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x2556D90", Offset = "0x2555790", VA = "0x182556D90")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<StoreUrlData>("StoreUrl");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2556C60", Offset = "0x2555660", VA = "0x182556C60")]
		[DebuggerNonUserCode]
		public StoreUrlData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2556B90", Offset = "0x2555590", VA = "0x182556B90")]
		[DebuggerNonUserCode]
		public StoreUrlData(StoreUrlData other)
		{
			bool flag = (useSteamOverlay_ = other.useSteamOverlay_);
			string text = (steamURL_ = other.steamURL_);
			string text2 = (epicURL_ = other.epicURL_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x2556260", Offset = "0x2554C60", VA = "0x182556260", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreUrlData Clone()
		{
			//Discarded unreachable code: IL_005d
			StoreUrlData storeUrlData = new StoreUrlData();
			storeUrlData.steamURL_ = "";
			storeUrlData.epicURL_ = "";
			bool flag = (storeUrlData.useSteamOverlay_ = useSteamOverlay_);
			string text = (storeUrlData.steamURL_ = steamURL_);
			string text2 = (storeUrlData.epicURL_ = epicURL_);
			UnknownFieldSet unknownFieldSet = (storeUrlData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeUrlData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2556410", Offset = "0x2554E10", VA = "0x182556410", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(useSteamOverlay_ ? 1 : 0) == (IntPtr)typeof(StoreUrlData).TypeHandle)
				{
					string text = steamURL_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = epicURL_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x25564E0", Offset = "0x2554EE0", VA = "0x1825564E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreUrlData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useSteamOverlay_;
				if (useSteamOverlay_ == flag)
				{
					string text = other.steamURL_;
					if (!(steamURL_ != text))
					{
						string text2 = other.epicURL_;
						if (!(epicURL_ != text2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2556640", Offset = "0x2555040", VA = "0x182556640", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			if (useSteamOverlay_)
			{
			}
			string text = steamURL_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = epicURL_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2556960", Offset = "0x2555360", VA = "0x182556960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x25569C0", Offset = "0x25553C0", VA = "0x1825569C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0062
			if (useSteamOverlay_)
			{
				bool value = useSteamOverlay_;
				output.WriteBool(value);
			}
			if (steamURL_.m_stringLength != 0)
			{
				string value2 = steamURL_;
				output.WriteString(value2);
			}
			if (epicURL_.m_stringLength != 0)
			{
				string value3 = epicURL_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x25560F0", Offset = "0x2554AF0", VA = "0x1825560F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004b
			UnknownFieldSet unknownFields;
			do
			{
				string text = steamURL_;
				if (text.m_stringLength != 0)
				{
					int num = CodedOutputStream.ComputeStringSize(text);
					num++;
				}
				string text2 = epicURL_;
				if (text2.m_stringLength != 0)
				{
					int num2 = CodedOutputStream.ComputeStringSize(text2);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x25566F0", Offset = "0x25550F0", VA = "0x1825566F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreUrlData other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				bool flag = other.useSteamOverlay_;
				if (flag)
				{
					useSteamOverlay_ = flag;
				}
				string text = other.steamURL_;
				if (text.m_stringLength != 0)
				{
					SteamURL = text;
				}
				string text2 = other.epicURL_;
				if (text2.m_stringLength != 0)
				{
					EpicURL = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2556780", Offset = "0x2555180", VA = "0x182556780", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005f
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (useSteamOverlay_ = input.ReadBool());
				}
				string text2 = default(string);
				if (num == 18)
				{
					text2 = (SteamURL = input.ReadString());
				}
				if ((long)text2 == 26)
				{
					string text4 = (EpicURL = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2556560", Offset = "0x2554F60", VA = "0x182556560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					string text = epicURL_;
				}
				string text2 = steamURL_;
			}
			bool flag = useSteamOverlay_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2556840", Offset = "0x2555240", VA = "0x182556840", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0033
			//IL_0021: Expected O, but got I4
			//IL_0032: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						EpicURL = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
					if (value == null || value != null)
					{
						break;
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj = default(object);
				useSteamOverlay_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x25561D0", Offset = "0x2554BD0", VA = "0x1825561D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					EpicURL = "";
					break;
				case 0:
					SteamURL = "";
					break;
				}
			}
			else
			{
				useSteamOverlay_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2556360", Offset = "0x2554D60", VA = "0x182556360", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003f
			string text = steamURL_;
			if ("Cannot be empty in ProtoDatabase.StoreUrl" != null)
			{
				context.AddInvalidMemberError("Cannot be empty in ProtoDatabase.StoreUrl", "SteamURL");
			}
			string text2 = epicURL_;
			if ("Cannot be empty in ProtoDatabase.StoreUrl" != null)
			{
				context.AddInvalidMemberError("Cannot be empty in ProtoDatabase.StoreUrl", "EpicURL");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2556A80", Offset = "0x2555480", VA = "0x182556A80")]
		static StoreUrlData()
		{
			Func<StoreUrlData> func = default(Func<StoreUrlData>);
			_parser = (MessageParser<StoreUrlData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
