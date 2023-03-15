using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using PlayFab.EconomyModels;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000766")]
	public sealed class OnlineChoiceOptions : IMessage<OnlineChoiceOptions>, IMessage, IEquatable<OnlineChoiceOptions>, IDeepCloneable<OnlineChoiceOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000767")]
		public abstract class Result
		{
			[Cpp2IlInjected.Token(Token = "0x170014C3")]
			public OnlineChoiceOptions Options
			{
				[Cpp2IlInjected.Token(Token = "0x60051DF")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003COptions_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60051E0")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003COptions_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60051E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000768")]
		public class UgcResult : Result
		{
			[Cpp2IlInjected.Token(Token = "0x170014C4")]
			public CatalogItem CatalogItem
			{
				[Cpp2IlInjected.Token(Token = "0x60051E2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCatalogItem_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60051E3")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCatalogItem_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60051E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UgcResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000769")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200076A")]
			public enum OnlineType
			{
				[Cpp2IlInjected.Token(Token = "0x40024EB")]
				[OriginalName("Ugc")]
				Ugc
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40024E0")]
		private static readonly MessageParser<OnlineChoiceOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024E2")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024E3")]
		private Types.OnlineType type_;

		[Cpp2IlInjected.Token(Token = "0x40024E4")]
		public const int FilterFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024E5")]
		private string filter_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024E6")]
		public const int DownloadDirectoryFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024E7")]
		private string downloadDirectory_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014BD")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineChoiceOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60051C7")]
			[Cpp2IlInjected.Address(RVA = "0x298C4A0", Offset = "0x298AEA0", VA = "0x18298C4A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60051C8")]
			[Cpp2IlInjected.Address(RVA = "0x298C3D0", Offset = "0x298ADD0", VA = "0x18298C3D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60051C9")]
			[Cpp2IlInjected.Address(RVA = "0x298C500", Offset = "0x298AF00", VA = "0x18298C500", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C0")]
		[DebuggerNonUserCode]
		public Types.OnlineType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60051CD")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051CE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C1")]
		[DebuggerNonUserCode]
		public string Filter
		{
			[Cpp2IlInjected.Token(Token = "0x60051CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return filter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051D0")]
			[Cpp2IlInjected.Address(RVA = "0x298C680", Offset = "0x298B080", VA = "0x18298C680")]
			set
			{
				string text = (filter_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C2")]
		[DebuggerNonUserCode]
		public string DownloadDirectory
		{
			[Cpp2IlInjected.Token(Token = "0x60051D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return downloadDirectory_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051D2")]
			[Cpp2IlInjected.Address(RVA = "0x298C610", Offset = "0x298B010", VA = "0x18298C610")]
			set
			{
				string text = (downloadDirectory_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051CA")]
		[Cpp2IlInjected.Address(RVA = "0x298C370", Offset = "0x298AD70", VA = "0x18298C370")]
		[DebuggerNonUserCode]
		public OnlineChoiceOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051CB")]
		[Cpp2IlInjected.Address(RVA = "0x298C2A0", Offset = "0x298ACA0", VA = "0x18298C2A0")]
		[DebuggerNonUserCode]
		public OnlineChoiceOptions(OnlineChoiceOptions other)
		{
			Types.OnlineType onlineType = (type_ = other.type_);
			string text = (filter_ = other.filter_);
			string text2 = (downloadDirectory_ = other.downloadDirectory_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051CC")]
		[Cpp2IlInjected.Address(RVA = "0x298BC10", Offset = "0x298A610", VA = "0x18298BC10", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineChoiceOptions Clone()
		{
			//Discarded unreachable code: IL_005d
			OnlineChoiceOptions onlineChoiceOptions = new OnlineChoiceOptions();
			onlineChoiceOptions.filter_ = "";
			onlineChoiceOptions.downloadDirectory_ = "";
			Types.OnlineType onlineType = (onlineChoiceOptions.type_ = type_);
			string text = (onlineChoiceOptions.filter_ = filter_);
			string text2 = (onlineChoiceOptions.downloadDirectory_ = downloadDirectory_);
			UnknownFieldSet unknownFieldSet = (onlineChoiceOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineChoiceOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x60051D3")]
		[Cpp2IlInjected.Address(RVA = "0x298BD10", Offset = "0x298A710", VA = "0x18298BD10", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(OnlineChoiceOptions).TypeHandle)
				{
					string text = filter_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = downloadDirectory_;
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

		[Cpp2IlInjected.Token(Token = "0x60051D4")]
		[Cpp2IlInjected.Address(RVA = "0x1700C40", Offset = "0x16FF640", VA = "0x181700C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineChoiceOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.OnlineType onlineType = other.type_;
				if (type_ == onlineType)
				{
					string text = other.filter_;
					if (!(filter_ != text))
					{
						string text2 = other.downloadDirectory_;
						if (!(downloadDirectory_ != text2))
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

		[Cpp2IlInjected.Token(Token = "0x60051D5")]
		[Cpp2IlInjected.Address(RVA = "0x1700E70", Offset = "0x16FF870", VA = "0x181700E70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			if (type_ != 0)
			{
			}
			string text = filter_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = downloadDirectory_;
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

		[Cpp2IlInjected.Token(Token = "0x60051D6")]
		[Cpp2IlInjected.Address(RVA = "0x298C130", Offset = "0x298AB30", VA = "0x18298C130", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D7")]
		[Cpp2IlInjected.Address(RVA = "0x17011F0", Offset = "0x16FFBF0", VA = "0x1817011F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			if (type_ != 0)
			{
			}
			if (filter_.m_stringLength != 0)
			{
				string value = filter_;
				output.WriteString(value);
			}
			if (downloadDirectory_.m_stringLength != 0)
			{
				string value2 = downloadDirectory_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D8")]
		[Cpp2IlInjected.Address(RVA = "0x298BA70", Offset = "0x298A470", VA = "0x18298BA70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007a
			Types.OnlineType onlineType = type_;
			int num = 0;
			if (onlineType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)onlineType);
			}
			string text = filter_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = downloadDirectory_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60051D9")]
		[Cpp2IlInjected.Address(RVA = "0x298BEC0", Offset = "0x298A8C0", VA = "0x18298BEC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineChoiceOptions other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				Types.OnlineType onlineType = other.type_;
				if (onlineType != 0)
				{
					type_ = onlineType;
				}
				string text = other.filter_;
				if (text.m_stringLength != 0)
				{
					Filter = text;
				}
				string text2 = other.downloadDirectory_;
				if (text2.m_stringLength != 0)
				{
					DownloadDirectory = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051DA")]
		[Cpp2IlInjected.Address(RVA = "0x298BF50", Offset = "0x298A950", VA = "0x18298BF50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005f
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(type_ = (Types.OnlineType)input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 18)
				{
					text2 = (Filter = input.ReadString());
				}
				if ((long)text2 == 26)
				{
					string text4 = (DownloadDirectory = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051DB")]
		[Cpp2IlInjected.Address(RVA = "0x298BDE0", Offset = "0x298A7E0", VA = "0x18298BDE0", Slot = "11")]
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
					string text = downloadDirectory_;
				}
				string text2 = filter_;
			}
			Types.OnlineType onlineType = type_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051DC")]
		[Cpp2IlInjected.Address(RVA = "0x298C010", Offset = "0x298AA10", VA = "0x18298C010", Slot = "12")]
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
						DownloadDirectory = (string)num2;
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
				type_ = (Types.OnlineType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051DD")]
		[Cpp2IlInjected.Address(RVA = "0x298BB80", Offset = "0x298A580", VA = "0x18298BB80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0031: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					DownloadDirectory = "";
					break;
				case 0:
					Filter = "";
					break;
				}
			}
			else
			{
				type_ = Types.OnlineType.Ugc;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051DE")]
		[Cpp2IlInjected.Address(RVA = "0x298C190", Offset = "0x298AB90", VA = "0x18298C190")]
		static OnlineChoiceOptions()
		{
			Func<OnlineChoiceOptions> func = default(Func<OnlineChoiceOptions>);
			_parser = (MessageParser<OnlineChoiceOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
