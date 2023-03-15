using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007EA")]
	public sealed class ConditionCurrentScene : ICondition, IDataValidation, IMessage<ConditionCurrentScene>, IMessage, IEquatable<ConditionCurrentScene>, IDeepCloneable<ConditionCurrentScene>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400279C")]
		private static readonly MessageParser<ConditionCurrentScene> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400279D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400279E")]
		public const int SceneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400279F")]
		private int scene_;

		[Cpp2IlInjected.Token(Token = "0x40027A0")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027A1")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001628")]
		private Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005779")]
			[Cpp2IlInjected.Address(RVA = "0x3219660", Offset = "0x3218060", VA = "0x183219660")]
			get
			{
				long num = Convert.ToInt64((uint)scene_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001629")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600577B")]
			[Cpp2IlInjected.Address(RVA = "0x3219460", Offset = "0x3217E60", VA = "0x183219460", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0068
				if (inversed_)
				{
					long num = Convert.ToInt64((uint)scene_);
					string text = default(string);
					string text2 = text.Replace("Scene/", "");
					return "Current scene is not " + text2 + ".";
				}
				long num2 = Convert.ToInt64((uint)scene_);
				string text3 = default(string);
				string text4 = text3.Replace("Scene/", "");
				return "Current scene is " + text4 + ".";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162A")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600577C")]
			[Cpp2IlInjected.Address(RVA = "0x32195F0", Offset = "0x3217FF0", VA = "0x1832195F0", Slot = "6")]
			get
			{
				return ConditionListener.Scene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCurrentScene> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600577F")]
			[Cpp2IlInjected.Address(RVA = "0x3219600", Offset = "0x3218000", VA = "0x183219600")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005780")]
			[Cpp2IlInjected.Address(RVA = "0x3219390", Offset = "0x3217D90", VA = "0x183219390")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005781")]
			[Cpp2IlInjected.Address(RVA = "0x32196C0", Offset = "0x32180C0", VA = "0x1832196C0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162E")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x6005785")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005786")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				scene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700162F")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005787")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005788")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600577A")]
		[Cpp2IlInjected.Address(RVA = "0x3218EF0", Offset = "0x32178F0", VA = "0x183218EF0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002c
			IProfilePlayer section = playerProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool inversed = inversed_;
			return Operations.EvaluateInverse((IntPtr)section == (IntPtr)scene_, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x600577D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600577E")]
		[Cpp2IlInjected.Address(RVA = "0x3218E80", Offset = "0x3217880", VA = "0x183218E80", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (scene_ == 0)
			{
				context.AddInvalidMemberError("Please select a scene", "Scene");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005782")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCurrentScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005783")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCurrentScene(ConditionCurrentScene other)
		{
			int num = (scene_ = other.scene_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005784")]
		[Cpp2IlInjected.Address(RVA = "0x3218DF0", Offset = "0x32177F0", VA = "0x183218DF0", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionCurrentScene Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCurrentScene conditionCurrentScene = new ConditionCurrentScene();
			int num = (conditionCurrentScene.scene_ = scene_);
			bool flag = (conditionCurrentScene.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCurrentScene._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCurrentScene;
		}

		[Cpp2IlInjected.Token(Token = "0x6005789")]
		[Cpp2IlInjected.Address(RVA = "0x3218FD0", Offset = "0x32179D0", VA = "0x183218FD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)scene_ == (IntPtr)typeof(ConditionCurrentScene).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCurrentScene).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600578A")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCurrentScene other)
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
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600578B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (scene_ != 0)
				{
				}
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600578C")]
		[Cpp2IlInjected.Address(RVA = "0x3219220", Offset = "0x3217C20", VA = "0x183219220", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600578D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (scene_ != 0)
			{
				int value = scene_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600578E")]
		[Cpp2IlInjected.Address(RVA = "0x3218D60", Offset = "0x3217760", VA = "0x183218D60", Slot = "12")]
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
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600578F")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCurrentScene other)
		{
			if (other != null)
			{
				int num = other.scene_;
				if (num != 0)
				{
					scene_ = num;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005790")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (scene_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005791")]
		[Cpp2IlInjected.Address(RVA = "0x3219060", Offset = "0x3217A60", VA = "0x183219060", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = scene_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005792")]
		[Cpp2IlInjected.Address(RVA = "0x3219150", Offset = "0x3217B50", VA = "0x183219150", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				scene_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005793")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				scene_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005794")]
		[Cpp2IlInjected.Address(RVA = "0x3219280", Offset = "0x3217C80", VA = "0x183219280")]
		static ConditionCurrentScene()
		{
			Func<ConditionCurrentScene> func = default(Func<ConditionCurrentScene>);
			_parser = (MessageParser<ConditionCurrentScene>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005795")]
		[Cpp2IlInjected.Address(RVA = "0x3218EF0", Offset = "0x32178F0", VA = "0x183218EF0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002c
			IProfilePlayer section = playerProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool inversed = inversed_;
			return Operations.EvaluateInverse((IntPtr)section == (IntPtr)scene_, inversed);
		}
	}
}
