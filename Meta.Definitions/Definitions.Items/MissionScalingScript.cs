using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200054E")]
	public sealed class MissionScalingScript : IMessage<MissionScalingScript>, IMessage, IEquatable<MissionScalingScript>, IDeepCloneable<MissionScalingScript>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x200054F")]
		public enum ScriptsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001CE1")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001CE2")]
			ExponentialScalingByLevel = 6
		}

		[Cpp2IlInjected.Token(Token = "0x4001CD1")]
		private static readonly MessageParser<MissionScalingScript> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CD2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CD3")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CD4")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001CD5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CD6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CD7")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CD8")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CD9")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CDA")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CDB")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001CDC")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001CDD")]
		public const int ExponentialScalingByLevelFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001CDE")]
		private object scripts_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001CDF")]
		private ScriptsOneofCase scriptsCase_;

		[Cpp2IlInjected.Token(Token = "0x17001118")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionScalingScript> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004233")]
			[Cpp2IlInjected.Address(RVA = "0x29E46D0", Offset = "0x29E30D0", VA = "0x1829E46D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001119")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004234")]
			[Cpp2IlInjected.Address(RVA = "0x29E4560", Offset = "0x29E2F60", VA = "0x1829E4560")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004235")]
			[Cpp2IlInjected.Address(RVA = "0x29E4730", Offset = "0x29E3130", VA = "0x1829E4730", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111B")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004239")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600423A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600423B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x600423C")]
			[Cpp2IlInjected.Address(RVA = "0x29E4920", Offset = "0x29E3320", VA = "0x1829E4920")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111D")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600423D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600423E")]
			[Cpp2IlInjected.Address(RVA = "0x29E4840", Offset = "0x29E3240", VA = "0x1829E4840")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111E")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600423F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004240")]
			[Cpp2IlInjected.Address(RVA = "0x29E48B0", Offset = "0x29E32B0", VA = "0x1829E48B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700111F")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004241")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004242")]
			[Cpp2IlInjected.Address(RVA = "0x29E4990", Offset = "0x29E3390", VA = "0x1829E4990")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001120")]
		[DebuggerNonUserCode]
		public ExponentialScalingByLevel ExponentialScalingByLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6004243")]
			[Cpp2IlInjected.Address(RVA = "0x29E4630", Offset = "0x29E3030", VA = "0x1829E4630")]
			get
			{
				int num = 0;
				if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					object obj = scripts_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004244")]
			[Cpp2IlInjected.Address(RVA = "0x1398B40", Offset = "0x1397540", VA = "0x181398B40")]
			set
			{
				scripts_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001121")]
		[DebuggerNonUserCode]
		public ScriptsOneofCase ScriptsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004245")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return scriptsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001122")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004254")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001123")]
		public IScalingScript GetIScalingScript
		{
			[Cpp2IlInjected.Token(Token = "0x6004256")]
			[Cpp2IlInjected.Address(RVA = "0x29E4690", Offset = "0x29E3090", VA = "0x1829E4690")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004236")]
		[Cpp2IlInjected.Address(RVA = "0x29E44E0", Offset = "0x29E2EE0", VA = "0x1829E44E0")]
		[DebuggerNonUserCode]
		public MissionScalingScript()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004237")]
		[Cpp2IlInjected.Address(RVA = "0x29E4340", Offset = "0x29E2D40", VA = "0x1829E4340")]
		[DebuggerNonUserCode]
		public MissionScalingScript(MissionScalingScript other)
		{
			//IL_009c: Expected I4, but got O
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			if (other.scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
			{
				if (other.scripts_ == null)
				{
					throw new InvalidCastException();
				}
				ExponentialScalingByLevel exponentialScalingByLevel = default(ExponentialScalingByLevel);
				scripts_ = exponentialScalingByLevel;
				scriptsCase_ = (ScriptsOneofCase)exponentialScalingByLevel;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004238")]
		[Cpp2IlInjected.Address(RVA = "0x29E32D0", Offset = "0x29E1CD0", VA = "0x1829E32D0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionScalingScript Clone()
		{
			return new MissionScalingScript(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004246")]
		[Cpp2IlInjected.Address(RVA = "0x1396870", Offset = "0x1395270", VA = "0x181396870")]
		[DebuggerNonUserCode]
		public void ClearScripts()
		{
			//IL_0010: Expected O, but got I4
			scripts_ = (scriptsCase_ = ScriptsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004247")]
		[Cpp2IlInjected.Address(RVA = "0x29E3430", Offset = "0x29E1E30", VA = "0x1829E3430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(MissionScalingScript).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									ExponentialScalingByLevel objB = default(ExponentialScalingByLevel);
									bool flag5 = object.Equals(ExponentialScalingByLevel, objB);
									if (flag5 && scriptsCase_ == (flag5 ? ((ScriptsOneofCase)1) : ScriptsOneofCase.None))
									{
										return object.Equals(_unknownFields, objB);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004248")]
		[Cpp2IlInjected.Address(RVA = "0x29E3330", Offset = "0x29E1D30", VA = "0x1829E3330", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionScalingScript other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									ExponentialScalingByLevel exponentialScalingByLevel = ExponentialScalingByLevel;
									ExponentialScalingByLevel exponentialScalingByLevel2 = other.ExponentialScalingByLevel;
									if (object.Equals(exponentialScalingByLevel, exponentialScalingByLevel2))
									{
										ScriptsOneofCase scriptsOneofCase = other.scriptsCase_;
										if (scriptsCase_ == scriptsOneofCase)
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
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004249")]
		[Cpp2IlInjected.Address(RVA = "0x29E36B0", Offset = "0x29E20B0", VA = "0x1829E36B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ac
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
			{
				object obj = scripts_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode5 = obj.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600424A")]
		[Cpp2IlInjected.Address(RVA = "0x29E4020", Offset = "0x29E2A20", VA = "0x1829E4020", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600424B")]
		[Cpp2IlInjected.Address(RVA = "0x29E4080", Offset = "0x29E2A80", VA = "0x1829E4080", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00c3
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel && scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
			{
				object obj = scripts_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600424C")]
		[Cpp2IlInjected.Address(RVA = "0x29E2F50", Offset = "0x29E1950", VA = "0x1829E2F50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f3
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
			{
				if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					object obj = scripts_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num8 = default(int);
				num2 += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600424D")]
		[Cpp2IlInjected.Address(RVA = "0x29E39C0", Offset = "0x29E23C0", VA = "0x1829E39C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionScalingScript other)
		{
			//Discarded unreachable code: IL_011e
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if (other.scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
			{
				ScriptsOneofCase scriptsOneofCase = scriptsCase_;
				object obj = default(object);
				if (scriptsOneofCase == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					obj = scripts_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					ExponentialScalingByLevel exponentialScalingByLevel = (ExponentialScalingByLevel)(scripts_ = new ExponentialScalingByLevel());
					scriptsCase_ = scriptsOneofCase;
				}
				if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					object obj2 = scripts_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					object obj3 = other.scripts_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600424E")]
		[Cpp2IlInjected.Address(RVA = "0x29E3C00", Offset = "0x29E2600", VA = "0x1829E3C00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_008d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_00d0;
				}
				ExponentialScalingByLevel builder = new ExponentialScalingByLevel();
				if (scriptsCase_ == ScriptsOneofCase.ExponentialScalingByLevel)
				{
					if (scriptsCase_ != ScriptsOneofCase.ExponentialScalingByLevel)
					{
					}
					object obj = scripts_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				scripts_ = builder;
				scriptsCase_ = (ScriptsOneofCase)typeof(ExponentialScalingByLevel).TypeHandle;
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num2 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_00d0;
			IL_00d0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600424F")]
		[Cpp2IlInjected.Address(RVA = "0x29E3570", Offset = "0x29E1F70", VA = "0x1829E3570", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004250")]
		[Cpp2IlInjected.Address(RVA = "0x29E3DF0", Offset = "0x29E27F0", VA = "0x1829E3DF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0012, IL_0016, IL_0017, IL_001b, IL_001f, IL_0020, IL_0024, IL_0028, IL_0029, IL_002d, IL_0031, IL_0032, IL_0036, IL_003a, IL_003b, IL_0041, IL_0047, IL_004d, IL_0053
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004251")]
		[Cpp2IlInjected.Address(RVA = "0x29E3150", Offset = "0x29E1B50", VA = "0x1829E3150", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013
			if (fieldNumber - 1 <= 5)
			{
				int num = (iD_ = 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004252")]
		[Cpp2IlInjected.Address(RVA = "0x29E3820", Offset = "0x29E2220", VA = "0x1829E3820", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Scripts"))
			{
				ScriptsOneofCase scriptsOneofCase = scriptsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004253")]
		[Cpp2IlInjected.Address(RVA = "0x29E3260", Offset = "0x29E1C60", VA = "0x1829E3260", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Scripts"))
			{
				scripts_ = (scriptsCase_ = ScriptsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004255")]
		[Cpp2IlInjected.Address(RVA = "0x29E32D0", Offset = "0x29E1CD0", VA = "0x1829E32D0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			MissionScalingScript missionScalingScript = new MissionScalingScript(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004257")]
		[Cpp2IlInjected.Address(RVA = "0x29E38D0", Offset = "0x29E22D0", VA = "0x1829E38D0")]
		public float GetScale(float input)
		{
			if ((object)typeof(IScalingScript).TypeHandle == null)
			{
				int num = 0;
			}
			int num2 = 0;
			num2 += num2;
			num2++;
			num2 += 312;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004258")]
		[Cpp2IlInjected.Address(RVA = "0x29E4230", Offset = "0x29E2C30", VA = "0x1829E4230")]
		static MissionScalingScript()
		{
			Func<MissionScalingScript> func = default(Func<MissionScalingScript>);
			_parser = (MessageParser<MissionScalingScript>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
