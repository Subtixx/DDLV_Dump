using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000448")]
	public sealed class LocationAnywhereScene : IMessage<LocationAnywhereScene>, IMessage, IEquatable<LocationAnywhereScene>, IDeepCloneable<LocationAnywhereScene>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001771")]
		private static readonly MessageParser<LocationAnywhereScene> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001772")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001773")]
		public const int SceneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001774")]
		private int scene_;

		[Cpp2IlInjected.Token(Token = "0x17000D7D")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationAnywhereScene> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60034A4")]
			[Cpp2IlInjected.Address(RVA = "0x27525F0", Offset = "0x2750FF0", VA = "0x1827525F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034A5")]
			[Cpp2IlInjected.Address(RVA = "0x2752520", Offset = "0x2750F20", VA = "0x182752520")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034A6")]
			[Cpp2IlInjected.Address(RVA = "0x2752750", Offset = "0x2751150", VA = "0x182752750", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D80")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x60034AA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x60034AB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				scene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D81")]
		public Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x60034B7")]
			[Cpp2IlInjected.Address(RVA = "0x2752650", Offset = "0x2751050", VA = "0x182752650")]
			get
			{
				long num = Convert.ToInt64((uint)scene_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D82")]
		public SceneType SceneType
		{
			[Cpp2IlInjected.Token(Token = "0x60034B8")]
			[Cpp2IlInjected.Address(RVA = "0x27526B0", Offset = "0x27510B0", VA = "0x1827526B0")]
			get
			{
				long num = Convert.ToInt64((uint)scene_);
				SceneType result = default(SceneType);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationAnywhereScene()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034A8")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationAnywhereScene(LocationAnywhereScene other)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
			int num2 = (scene_ = other.scene_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034A9")]
		[Cpp2IlInjected.Address(RVA = "0x2752010", Offset = "0x2750A10", VA = "0x182752010", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationAnywhereScene Clone()
		{
			//Discarded unreachable code: IL_002c
			//IL_0009: Expected O, but got I4
			int num = 0;
			LocationAnywhereScene locationAnywhereScene = default(LocationAnywhereScene);
			locationAnywhereScene.DataValidation((DataValidation.Context)num);
			int num2 = (locationAnywhereScene.scene_ = scene_);
			UnknownFieldSet unknownFieldSet = (locationAnywhereScene._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationAnywhereScene;
		}

		[Cpp2IlInjected.Token(Token = "0x60034AC")]
		[Cpp2IlInjected.Address(RVA = "0x2752090", Offset = "0x2750A90", VA = "0x182752090", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)scene_ == (IntPtr)typeof(LocationAnywhereScene).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationAnywhereScene other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.scene_;
				if (scene_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (scene_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AF")]
		[Cpp2IlInjected.Address(RVA = "0x27523B0", Offset = "0x2750DB0", VA = "0x1827523B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60034B0")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (scene_ != 0)
			{
				int value = scene_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60034B1")]
		[Cpp2IlInjected.Address(RVA = "0x2751F70", Offset = "0x2750970", VA = "0x182751F70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = scene_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationAnywhereScene other)
		{
			if (other != null)
			{
				int num = other.scene_;
				if (num != 0)
				{
					scene_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B3")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (scene_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B4")]
		[Cpp2IlInjected.Address(RVA = "0x2752120", Offset = "0x2750B20", VA = "0x182752120", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = scene_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034B5")]
		[Cpp2IlInjected.Address(RVA = "0x2752330", Offset = "0x2750D30", VA = "0x182752330", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				scene_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B6")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				scene_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B9")]
		[Cpp2IlInjected.Address(RVA = "0x27521D0", Offset = "0x2750BD0", VA = "0x1827521D0")]
		private static SceneType GetItemSceneType(Item item)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034BA")]
		[Cpp2IlInjected.Address(RVA = "0x27522C0", Offset = "0x2750CC0", VA = "0x1827522C0")]
		public static bool IsValidSceneItem(Item item)
		{
			SceneType sceneType = default(SceneType);
			if (item.ItemID > 5 && sceneType != SceneType.Cave)
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60034BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034BC")]
		[Cpp2IlInjected.Address(RVA = "0x2752410", Offset = "0x2750E10", VA = "0x182752410")]
		static LocationAnywhereScene()
		{
			Func<LocationAnywhereScene> func = default(Func<LocationAnywhereScene>);
			_parser = (MessageParser<LocationAnywhereScene>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
