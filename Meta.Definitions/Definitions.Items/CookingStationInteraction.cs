using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002C5")]
	public sealed class CookingStationInteraction : IMessage<CookingStationInteraction>, IMessage, IEquatable<CookingStationInteraction>, IDeepCloneable<CookingStationInteraction>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000C7A")]
		private static readonly MessageParser<CookingStationInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C7B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C7C")]
		public const int RestrictMealsToCurrentSceneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C7D")]
		private bool restrictMealsToCurrentScene_;

		[Cpp2IlInjected.Token(Token = "0x4000C7E")]
		public const int NoCombustibleSpentFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000C7F")]
		private bool noCombustibleSpent_;

		[Cpp2IlInjected.Token(Token = "0x170006CA")]
		[DebuggerNonUserCode]
		public static MessageParser<CookingStationInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001DAD")]
			[Cpp2IlInjected.Address(RVA = "0x3285C10", Offset = "0x3284610", VA = "0x183285C10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DAE")]
			[Cpp2IlInjected.Address(RVA = "0x3285B40", Offset = "0x3284540", VA = "0x183285B40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DAF")]
			[Cpp2IlInjected.Address(RVA = "0x3285C70", Offset = "0x3284670", VA = "0x183285C70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CD")]
		[DebuggerNonUserCode]
		public bool RestrictMealsToCurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x6001DB3")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return restrictMealsToCurrentScene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DB4")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				restrictMealsToCurrentScene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CE")]
		[DebuggerNonUserCode]
		public bool NoCombustibleSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6001DB5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return noCombustibleSpent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DB6")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				noCombustibleSpent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CookingStationInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB1")]
		[Cpp2IlInjected.Address(RVA = "0x1E7F0E0", Offset = "0x1E7DAE0", VA = "0x181E7F0E0")]
		[DebuggerNonUserCode]
		public CookingStationInteraction(CookingStationInteraction other)
		{
			bool flag = (restrictMealsToCurrentScene_ = other.restrictMealsToCurrentScene_);
			bool flag2 = (noCombustibleSpent_ = other.noCombustibleSpent_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB2")]
		[Cpp2IlInjected.Address(RVA = "0x3285720", Offset = "0x3284120", VA = "0x183285720", Slot = "10")]
		[DebuggerNonUserCode]
		public CookingStationInteraction Clone()
		{
			//Discarded unreachable code: IL_0037
			CookingStationInteraction cookingStationInteraction = new CookingStationInteraction();
			bool flag = (cookingStationInteraction.restrictMealsToCurrentScene_ = restrictMealsToCurrentScene_);
			bool flag2 = (cookingStationInteraction.noCombustibleSpent_ = noCombustibleSpent_);
			UnknownFieldSet unknownFieldSet = (cookingStationInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookingStationInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB7")]
		[Cpp2IlInjected.Address(RVA = "0x32857B0", Offset = "0x32841B0", VA = "0x1832857B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(restrictMealsToCurrentScene_ ? 1 : 0) == (IntPtr)typeof(CookingStationInteraction).TypeHandle && (IntPtr)(noCombustibleSpent_ ? 1 : 0) == (IntPtr)typeof(CookingStationInteraction).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB8")]
		[Cpp2IlInjected.Address(RVA = "0x1E7A3D0", Offset = "0x1E78DD0", VA = "0x181E7A3D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CookingStationInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.restrictMealsToCurrentScene_;
				if (restrictMealsToCurrentScene_ == flag)
				{
					bool flag2 = other.noCombustibleSpent_;
					if (noCombustibleSpent_ == flag2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB9")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B000", Offset = "0x1E79A00", VA = "0x181E7B000", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (restrictMealsToCurrentScene_)
				{
				}
				if (noCombustibleSpent_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBA")]
		[Cpp2IlInjected.Address(RVA = "0x32859D0", Offset = "0x32843D0", VA = "0x1832859D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBB")]
		[Cpp2IlInjected.Address(RVA = "0x1E7DE60", Offset = "0x1E7C860", VA = "0x181E7DE60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (restrictMealsToCurrentScene_)
			{
				bool value = restrictMealsToCurrentScene_;
				output.WriteBool(value);
			}
			if (noCombustibleSpent_)
			{
				bool value2 = noCombustibleSpent_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBC")]
		[Cpp2IlInjected.Address(RVA = "0x1E78E70", Offset = "0x1E77870", VA = "0x181E78E70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBD")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B890", Offset = "0x1E7A290", VA = "0x181E7B890", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookingStationInteraction other)
		{
			if (other != null)
			{
				bool flag = other.restrictMealsToCurrentScene_;
				if (flag)
				{
					restrictMealsToCurrentScene_ = flag;
				}
				bool flag2 = other.noCombustibleSpent_;
				if (flag2)
				{
					noCombustibleSpent_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBE")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BD50", Offset = "0x1E7A750", VA = "0x181E7BD50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (restrictMealsToCurrentScene_ = input.ReadBool());
				}
				if (num == 16)
				{
					bool flag2 = (noCombustibleSpent_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DBF")]
		[Cpp2IlInjected.Address(RVA = "0x3285850", Offset = "0x3284250", VA = "0x183285850", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = restrictMealsToCurrentScene_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC0")]
		[Cpp2IlInjected.Address(RVA = "0x3285910", Offset = "0x3284310", VA = "0x183285910", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				restrictMealsToCurrentScene_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			noCombustibleSpent_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC1")]
		[Cpp2IlInjected.Address(RVA = "0x1E79060", Offset = "0x1E77A60", VA = "0x181E79060", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			switch (fieldNumber)
			{
			case 1:
				restrictMealsToCurrentScene_ = false;
				break;
			case 2:
				noCombustibleSpent_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC2")]
		[Cpp2IlInjected.Address(RVA = "0x3285A30", Offset = "0x3284430", VA = "0x183285A30")]
		static CookingStationInteraction()
		{
			Func<CookingStationInteraction> func = default(Func<CookingStationInteraction>);
			_parser = (MessageParser<CookingStationInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
