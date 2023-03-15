using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000922")]
	public sealed class MiniProfile : IMessage<MiniProfile>, IMessage, IEquatable<MiniProfile>, IDeepCloneable<MiniProfile>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002503")]
		private static readonly MessageParser<MiniProfile> _parser = (MessageParser<MiniProfile>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MiniProfile()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002504")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002505")]
		public const int GameInfoFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002506")]
		private ProfileGameInfo gameInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002507")]
		public const int PlayerNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002508")]
		private string playerName_;

		[Cpp2IlInjected.Token(Token = "0x4002509")]
		public const int TimePlayedInMinutesFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400250A")]
		private int timePlayedInMinutes_;

		[Cpp2IlInjected.Token(Token = "0x400250B")]
		public const int PlayerLevelFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400250C")]
		private int playerLevel_;

		[Cpp2IlInjected.Token(Token = "0x400250D")]
		public const int PlayerXpFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400250E")]
		private int playerXp_;

		[Cpp2IlInjected.Token(Token = "0x400250F")]
		public const int SoftCurrencyFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002510")]
		private int softCurrency_;

		[Cpp2IlInjected.Token(Token = "0x4002511")]
		public const int HardCurrencyFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002512")]
		private int hardCurrency_;

		[Cpp2IlInjected.Token(Token = "0x4002513")]
		public const int PlayerCountryCodeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002514")]
		private string playerCountryCode_;

		[Cpp2IlInjected.Token(Token = "0x4002515")]
		public const int PlatformSpecificHardCurrenciesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4002516")]
		private static readonly MapField<int, int>.Codec _map_platformSpecificHardCurrencies_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002517")]
		private readonly MapField<int, int> platformSpecificHardCurrencies_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002518")]
		private List<MiniProfileComparator> miniProfileComparators;

		[Cpp2IlInjected.Token(Token = "0x17000D8B")]
		[DebuggerNonUserCode]
		public static MessageParser<MiniProfile> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F71")]
			[Cpp2IlInjected.Address(RVA = "0x7FA4A0", Offset = "0x7F8EA0", VA = "0x1807FA4A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F72")]
			[Cpp2IlInjected.Address(RVA = "0x7FA3C0", Offset = "0x7F8DC0", VA = "0x1807FA3C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F73")]
			[Cpp2IlInjected.Address(RVA = "0x7FA510", Offset = "0x7F8F10", VA = "0x1807FA510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8E")]
		[DebuggerNonUserCode]
		public ProfileGameInfo GameInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004F78")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gameInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F79")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				gameInfo_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8F")]
		[DebuggerNonUserCode]
		public string PlayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6004F7A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playerName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F7B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA6A0", Offset = "0x7F90A0", VA = "0x1807FA6A0")]
			set
			{
				string text = (playerName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D90")]
		[DebuggerNonUserCode]
		public int TimePlayedInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6004F7C")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return timePlayedInMinutes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F7D")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				timePlayedInMinutes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D91")]
		[DebuggerNonUserCode]
		public int PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6004F7E")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return playerLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F7F")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				playerLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D92")]
		[DebuggerNonUserCode]
		public int PlayerXp
		{
			[Cpp2IlInjected.Token(Token = "0x6004F80")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return playerXp_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F81")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				playerXp_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D93")]
		[DebuggerNonUserCode]
		public int SoftCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x6004F82")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return softCurrency_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F83")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				softCurrency_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D94")]
		[DebuggerNonUserCode]
		public int HardCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x6004F84")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return hardCurrency_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F85")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				hardCurrency_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D95")]
		[DebuggerNonUserCode]
		public string PlayerCountryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6004F86")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return playerCountryCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F87")]
			[Cpp2IlInjected.Address(RVA = "0x7FA630", Offset = "0x7F9030", VA = "0x1807FA630")]
			set
			{
				string text = (playerCountryCode_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D96")]
		[DebuggerNonUserCode]
		public MapField<int, int> PlatformSpecificHardCurrencies
		{
			[Cpp2IlInjected.Token(Token = "0x6004F88")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return platformSpecificHardCurrencies_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D97")]
		public string DataComparedStr
		{
			[Cpp2IlInjected.Token(Token = "0x6004F97")]
			[Cpp2IlInjected.Address(RVA = "0x7FA270", Offset = "0x7F8C70", VA = "0x1807FA270")]
			get
			{
				List<MiniProfileComparator> list = miniProfileComparators;
				Func<MiniProfileComparator, string> _003C_003E9__73_ = _003C_003Ec._003C_003E9__73_0;
				if (_003C_003E9__73_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MiniProfileComparator x) => x.ToDebugStr());
				}
				IEnumerable<MiniProfileComparator> enumerable = (IEnumerable<MiniProfileComparator>)Enumerable.Select<MiniProfileComparator, string>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__73_);
				return string.Join("\n", (IEnumerable<>)enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F74")]
		[Cpp2IlInjected.Address(RVA = "0x7FA030", Offset = "0x7F8A30", VA = "0x1807FA030")]
		[DebuggerNonUserCode]
		public MiniProfile()
		{
			//Discarded unreachable code: IL_0097
			playerName_ = "";
			playerCountryCode_ = "";
			platformSpecificHardCurrencies_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();
			miniProfileComparators = (List<MiniProfileComparator>)(object)new List<T>();
			base._002Ector();
			List<MiniProfileComparator> list = miniProfileComparators;
			TimePlayedComparator item = new TimePlayedComparator(this);
			((List<T>)(object)list).Add((T)item);
			List<MiniProfileComparator> list2 = miniProfileComparators;
			LevelComparator item2 = new LevelComparator(this);
			((List<T>)(object)list2).Add((T)item2);
			List<MiniProfileComparator> list3 = miniProfileComparators;
			XpComparator item3 = new XpComparator(this);
			((List<T>)(object)list3).Add((T)item3);
			List<MiniProfileComparator> list4 = miniProfileComparators;
			ModifiedTimeComparator item4 = new ModifiedTimeComparator(this);
			((List<T>)(object)list4).Add((T)item4);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F75")]
		[Cpp2IlInjected.Address(RVA = "0x7F96A0", Offset = "0x7F80A0", VA = "0x1807F96A0")]
		private void OnConstruction()
		{
			//Discarded unreachable code: IL_005d
			List<MiniProfileComparator> list = miniProfileComparators;
			TimePlayedComparator item = new TimePlayedComparator(this);
			((List<T>)(object)list).Add((T)item);
			List<MiniProfileComparator> list2 = miniProfileComparators;
			LevelComparator item2 = new LevelComparator(this);
			((List<T>)(object)list2).Add((T)item2);
			List<MiniProfileComparator> list3 = miniProfileComparators;
			XpComparator item3 = new XpComparator(this);
			((List<T>)(object)list3).Add((T)item3);
			List<MiniProfileComparator> list4 = miniProfileComparators;
			ModifiedTimeComparator item4 = new ModifiedTimeComparator(this);
			((List<T>)(object)list4).Add((T)item4);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F76")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F30", Offset = "0x7F8930", VA = "0x1807F9F30")]
		[DebuggerNonUserCode]
		public MiniProfile(MiniProfile other)
		{
			//IL_001b: Expected O, but got I4
			ProfileGameInfo profileGameInfo = other.gameInfo_;
			if (profileGameInfo != null)
			{
				ProfileGameInfo profileGameInfo2 = profileGameInfo.Clone();
			}
			int num = 0;
			gameInfo_ = (ProfileGameInfo)num;
			string text = (playerName_ = other.playerName_);
			int num2 = (timePlayedInMinutes_ = other.timePlayedInMinutes_);
			int num3 = (playerLevel_ = other.playerLevel_);
			int num4 = (playerXp_ = other.playerXp_);
			int num5 = (softCurrency_ = other.softCurrency_);
			int num6 = (hardCurrency_ = other.hardCurrency_);
			string text2 = (playerCountryCode_ = other.playerCountryCode_);
			MapField<int, int> mapField = (platformSpecificHardCurrencies_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.platformSpecificHardCurrencies_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F77")]
		[Cpp2IlInjected.Address(RVA = "0x7F8460", Offset = "0x7F6E60", VA = "0x1807F8460", Slot = "10")]
		[DebuggerNonUserCode]
		public MiniProfile Clone()
		{
			//Discarded unreachable code: IL_00bd
			//IL_0021: Expected O, but got I4
			MiniProfile miniProfile = new MiniProfile();
			ProfileGameInfo profileGameInfo = gameInfo_;
			if (profileGameInfo != null)
			{
				ProfileGameInfo profileGameInfo2 = profileGameInfo.Clone();
			}
			int num = 0;
			miniProfile.gameInfo_ = (ProfileGameInfo)num;
			string text = (miniProfile.playerName_ = playerName_);
			int num2 = (miniProfile.timePlayedInMinutes_ = timePlayedInMinutes_);
			int num3 = (miniProfile.playerLevel_ = playerLevel_);
			int num4 = (miniProfile.playerXp_ = playerXp_);
			int num5 = (miniProfile.softCurrency_ = softCurrency_);
			int num6 = (miniProfile.hardCurrency_ = hardCurrency_);
			string text2 = (miniProfile.playerCountryCode_ = playerCountryCode_);
			MapField<int, int> mapField = (miniProfile.platformSpecificHardCurrencies_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)platformSpecificHardCurrencies_).Clone());
			UnknownFieldSet unknownFieldSet = (miniProfile._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return miniProfile;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F89")]
		[Cpp2IlInjected.Address(RVA = "0x7F8590", Offset = "0x7F6F90", VA = "0x1807F8590", Slot = "0")]
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
				if (object.Equals(gameInfo_, other))
				{
					string text = playerName_;
					bool flag = default(bool);
					if (!flag && timePlayedInMinutes_ == (flag ? 1 : 0) && playerLevel_ == (flag ? 1 : 0) && playerXp_ == (flag ? 1 : 0) && softCurrency_ == (flag ? 1 : 0) && hardCurrency_ == (flag ? 1 : 0))
					{
						string text2 = playerCountryCode_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							MapField<int, int> mapField = platformSpecificHardCurrencies_;
							bool flag3 = default(bool);
							if (flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8A")]
		[Cpp2IlInjected.Address(RVA = "0x7F86E0", Offset = "0x7F70E0", VA = "0x1807F86E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MiniProfile other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ProfileGameInfo objB = other.gameInfo_;
				if (object.Equals(gameInfo_, objB))
				{
					string text = other.playerName_;
					if (!(playerName_ != text))
					{
						int num = other.timePlayedInMinutes_;
						if (timePlayedInMinutes_ == num)
						{
							int num2 = other.playerLevel_;
							if (playerLevel_ == num2)
							{
								int num3 = other.playerXp_;
								if (playerXp_ == num3)
								{
									int num4 = other.softCurrency_;
									if (softCurrency_ == num4)
									{
										int num5 = other.hardCurrency_;
										if (hardCurrency_ == num5)
										{
											string text2 = other.playerCountryCode_;
											if (!(playerCountryCode_ != text2))
											{
												MapField<int, int> mapField = platformSpecificHardCurrencies_;
												MapField<int, int> mapField2 = other.platformSpecificHardCurrencies_;
												if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
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
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FA0", Offset = "0x7F79A0", VA = "0x1807F8FA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0097
			ProfileGameInfo profileGameInfo = gameInfo_;
			if (profileGameInfo != null)
			{
				int hashCode = profileGameInfo.GetHashCode();
			}
			string text = playerName_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			if (timePlayedInMinutes_ != 0)
			{
			}
			if (playerLevel_ != 0)
			{
			}
			if (playerXp_ != 0)
			{
			}
			if (softCurrency_ != 0)
			{
			}
			if (hardCurrency_ != 0)
			{
			}
			string text2 = playerCountryCode_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			int hashCode4 = ((MapField<TKey, TValue>)(object)platformSpecificHardCurrencies_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8C")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B00", Offset = "0x7F8500", VA = "0x1807F9B00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8D")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B60", Offset = "0x7F8560", VA = "0x1807F9B60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00fb
			if ((long)gameInfo_ != 0)
			{
				ProfileGameInfo value = gameInfo_;
				output.WriteMessage(value);
			}
			if (playerName_.m_stringLength != 0)
			{
				string value2 = playerName_;
				output.WriteString(value2);
			}
			if (timePlayedInMinutes_ != 0)
			{
				int value3 = timePlayedInMinutes_;
				output.WriteInt32(value3);
			}
			if (playerLevel_ != 0)
			{
				int value4 = playerLevel_;
				output.WriteInt32(value4);
			}
			if (playerXp_ != 0)
			{
				int value5 = playerXp_;
				output.WriteInt32(value5);
			}
			if (softCurrency_ != 0)
			{
				int value6 = softCurrency_;
				output.WriteInt32(value6);
			}
			if (hardCurrency_ != 0)
			{
				int value7 = hardCurrency_;
				output.WriteInt32(value7);
			}
			if (playerCountryCode_.m_stringLength != 0)
			{
				string value8 = playerCountryCode_;
				output.WriteString(value8);
			}
			MapField<int, int> mapField = platformSpecificHardCurrencies_;
			MapField<int, int>.Codec map_platformSpecificHardCurrencies_codec = _map_platformSpecificHardCurrencies_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_platformSpecificHardCurrencies_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8090", Offset = "0x7F6A90", VA = "0x1807F8090", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_013e
			ProfileGameInfo profileGameInfo = gameInfo_;
			int num = 0;
			if (profileGameInfo != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(profileGameInfo);
			}
			string text = playerName_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			int num4 = timePlayedInMinutes_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = playerLevel_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			int num8 = playerXp_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			int num10 = softCurrency_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num += num11;
			}
			int num12 = hardCurrency_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num += num13;
			}
			string text2 = playerCountryCode_;
			if (text2.m_stringLength != 0)
			{
				int num14 = CodedOutputStream.ComputeStringSize(text2);
				num14++;
				num += num14;
			}
			MapField<int, int> mapField = platformSpecificHardCurrencies_;
			MapField<int, int>.Codec map_platformSpecificHardCurrencies_codec = _map_platformSpecificHardCurrencies_codec;
			int num15 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_platformSpecificHardCurrencies_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num15;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num += num16;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8F")]
		[Cpp2IlInjected.Address(RVA = "0x7F9310", Offset = "0x7F7D10", VA = "0x1807F9310", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniProfile other)
		{
			//Discarded unreachable code: IL_010b
			if (other == null)
			{
				return;
			}
			if ((long)other.gameInfo_ != 0)
			{
				ProfileGameInfo profileGameInfo = gameInfo_;
				if (profileGameInfo == null)
				{
					ProfileGameInfo profileGameInfo2 = (gameInfo_ = new ProfileGameInfo());
				}
				ProfileGameInfo other2 = other.gameInfo_;
				profileGameInfo.MergeFrom(other2);
			}
			string text = other.playerName_;
			if (text.m_stringLength != 0)
			{
				PlayerName = text;
			}
			int num = other.timePlayedInMinutes_;
			if (num != 0)
			{
				timePlayedInMinutes_ = num;
			}
			int num2 = other.playerLevel_;
			if (num2 != 0)
			{
				playerLevel_ = num2;
			}
			int num3 = other.playerXp_;
			if (num3 != 0)
			{
				playerXp_ = num3;
			}
			int num4 = other.softCurrency_;
			if (num4 != 0)
			{
				softCurrency_ = num4;
			}
			int num5 = other.hardCurrency_;
			if (num5 != 0)
			{
				hardCurrency_ = num5;
			}
			string text2 = other.playerCountryCode_;
			if (text2.m_stringLength != 0)
			{
				PlayerCountryCode = text2;
			}
			MapField<int, int> mapField = platformSpecificHardCurrencies_;
			MapField<int, int> mapField2 = other.platformSpecificHardCurrencies_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004F90")]
		[Cpp2IlInjected.Address(RVA = "0x7F9470", Offset = "0x7F7E70", VA = "0x1807F9470", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0125
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 48)
				{
					if (num == 56)
					{
						int num2 = (hardCurrency_ = input.ReadInt32());
					}
					string text2 = default(string);
					if (num == 66)
					{
						text2 = (PlayerCountryCode = input.ReadString());
					}
					if ((long)text2 != 74)
					{
						goto IL_010e;
					}
					MapField<int, int> mapField = platformSpecificHardCurrencies_;
					MapField<int, int>.Codec map_platformSpecificHardCurrencies_codec = _map_platformSpecificHardCurrencies_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_platformSpecificHardCurrencies_codec);
				}
				int num3 = default(int);
				if (num == 40)
				{
					num3 = (playerXp_ = input.ReadInt32());
				}
				if (num3 != 48)
				{
					goto IL_010e;
				}
				int num4 = (softCurrency_ = input.ReadInt32());
			}
			int num6 = default(int);
			if ((int)num > 18)
			{
				int num5 = default(int);
				if (num == 24)
				{
					num5 = (timePlayedInMinutes_ = input.ReadInt32());
				}
				if (num5 != 32)
				{
					goto IL_010e;
				}
				num6 = (playerLevel_ = input.ReadInt32());
			}
			ProfileGameInfo profileGameInfo = default(ProfileGameInfo);
			if (num6 == 10)
			{
				ProfileGameInfo builder = default(ProfileGameInfo);
				if (gameInfo_ == null)
				{
					profileGameInfo = (gameInfo_ = new ProfileGameInfo());
					builder = gameInfo_;
				}
				input.ReadMessage(builder);
			}
			if ((long)profileGameInfo == 18)
			{
				string text4 = (PlayerName = input.ReadString());
			}
			goto IL_010e;
			IL_010e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004F91")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E60", Offset = "0x7F7860", VA = "0x1807F8E60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				ProfileGameInfo profileGameInfo = gameInfo_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F92")]
		[Cpp2IlInjected.Address(RVA = "0x7F9800", Offset = "0x7F8200", VA = "0x1807F9800", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_0026, IL_002e, IL_0036, IL_003e, IL_0046, IL_004e, IL_004f, IL_0060, IL_0066, IL_006c
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 8)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				gameInfo_ = (ProfileGameInfo)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F93")]
		[Cpp2IlInjected.Address(RVA = "0x7F8300", Offset = "0x7F6D00", VA = "0x1807F8300", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d, IL_0010
			if (fieldNumber - 1 > 8)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F94")]
		[Cpp2IlInjected.Address(RVA = "0x7F9220", Offset = "0x7F7C20", VA = "0x1807F9220")]
		public bool IsOlder(MiniProfile other)
		{
			//Discarded unreachable code: IL_0029
			List<MiniProfileComparator> cpp2il__autoParamName__idx_ = miniProfileComparators;
			Func<MiniProfileComparator, bool> cpp2il__autoParamName__idx_2 = (Func<MiniProfileComparator, bool>)(object)(Func<T, TResult>)delegate(MiniProfileComparator x)
			{
				//Discarded unreachable code: IL_000f
				MiniProfile other2 = other;
				return x.IsOlder(other2);
			};
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MiniProfileComparator>((Func<, >)(object)cpp2il__autoParamName__idx_2);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F95")]
		[Cpp2IlInjected.Address(RVA = "0x7F9130", Offset = "0x7F7B30", VA = "0x1807F9130")]
		public bool IsNewer(MiniProfile other)
		{
			//Discarded unreachable code: IL_0029
			List<MiniProfileComparator> cpp2il__autoParamName__idx_ = miniProfileComparators;
			Func<MiniProfileComparator, bool> cpp2il__autoParamName__idx_2 = (Func<MiniProfileComparator, bool>)(object)(Func<T, TResult>)delegate(MiniProfileComparator x)
			{
				//Discarded unreachable code: IL_000f
				MiniProfile other2 = other;
				return x.IsOlder(other2);
			};
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<MiniProfileComparator>((Func<, >)(object)cpp2il__autoParamName__idx_2);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F96")]
		[Cpp2IlInjected.Address(RVA = "0x7F90F0", Offset = "0x7F7AF0", VA = "0x1807F90F0")]
		public bool IsLastSaveFrom(MiniProfile other)
		{
			//Discarded unreachable code: IL_001d
			ProfileGameInfo profileGameInfo = other.gameInfo_;
			ProfileGameInfo profileGameInfo2 = gameInfo_;
			DeviceInfo _003CDeviceInfo_003Ek__BackingField = profileGameInfo.DeviceInfo;
			return profileGameInfo2.IsLastSaveFrom(_003CDeviceInfo_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F98")]
		[Cpp2IlInjected.Address(RVA = "0x7F87F0", Offset = "0x7F71F0", VA = "0x1807F87F0")]
		public string GetDebugProfileDesc()
		{
			//Discarded unreachable code: IL_01cd
			//IL_006d: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_0116: Expected O, but got I4
			//IL_01ad: Expected O, but got I4
			string[] array;
			string text8;
			while (true)
			{
				array = new string[12];
				if ("Name=" != null && "Name=" == null)
				{
					continue;
				}
				array[0] = "Name=";
				string text = playerName_;
				if (text != null && "Name=" == null)
				{
					continue;
				}
				array[1] = text;
				if ("\n" != null && "\n" == null)
				{
					continue;
				}
				array[2] = "\n";
				int num = timePlayedInMinutes_;
				string text2 = $"TimePlayedInMinutes={num}\n";
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[3] = text2;
				int num2 = playerLevel_;
				string text3 = $"Level={num2}\n";
				if (text3 != null && text3 == null)
				{
					continue;
				}
				array[4] = text3;
				int num3 = playerXp_;
				string text4 = $"Xp={num3}\n";
				if (text4 != null && text4 == null)
				{
					continue;
				}
				array[5] = text4;
				int num4 = softCurrency_;
				string text5 = $"SC={num4}\n";
				if (text5 != null && text5 == null)
				{
					continue;
				}
				array[6] = text5;
				int num5 = hardCurrency_;
				string text6 = $"HC={num5}\n";
				if (text6 != null && text6 == null)
				{
					continue;
				}
				array[7] = text6;
				if ("CountryCode=" != null && "CountryCode=" == null)
				{
					continue;
				}
				array[8] = "CountryCode=";
				string text7 = playerCountryCode_;
				if (text7 != null && "CountryCode=" == null)
				{
					continue;
				}
				array[9] = text7;
				if ("\nModifiedTime=" == null || "\nModifiedTime=" != null)
				{
					array[10] = "\nModifiedTime=";
					DateTime time = gameInfo_.modified_.ToDateTime();
					int num6 = 0;
					text8 = time.ToLocalPrettyTime((CultureInfo)num6);
					if (text8 == null || text8 != null)
					{
						break;
					}
				}
			}
			array[11] = text8;
			return string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F99")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D90", Offset = "0x7F8790", VA = "0x1807F9D90")]
		static MiniProfile()
		{
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<MiniProfile>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
