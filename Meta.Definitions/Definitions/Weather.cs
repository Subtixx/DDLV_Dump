using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public sealed class Weather : IMessage<Weather>, IMessage, IEquatable<Weather>, IDeepCloneable<Weather>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200010C")]
			public sealed class NextWeather : IMessage<NextWeather>, IMessage, IEquatable<NextWeather>, IDeepCloneable<NextWeather>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004FD")]
				private static readonly MessageParser<NextWeather> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004FE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004FF")]
				public const int WeatherFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000500")]
				private string weather_;

				[Cpp2IlInjected.Token(Token = "0x4000501")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000502")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x170002B2")]
				[DebuggerNonUserCode]
				public static MessageParser<NextWeather> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000B20")]
					[Cpp2IlInjected.Address(RVA = "0x23732B0", Offset = "0x2371CB0", VA = "0x1823732B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B3")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B21")]
					[Cpp2IlInjected.Address(RVA = "0x2373230", Offset = "0x2371C30", VA = "0x182373230")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B4")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B22")]
					[Cpp2IlInjected.Address(RVA = "0x2373310", Offset = "0x2371D10", VA = "0x182373310", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B5")]
				[DebuggerNonUserCode]
				public string Weather
				{
					[Cpp2IlInjected.Token(Token = "0x6000B27")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000B28")]
					[Cpp2IlInjected.Address(RVA = "0x23733D0", Offset = "0x2371DD0", VA = "0x1823733D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B6")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6000B29")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B2A")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0x23731E0", Offset = "0x2371BE0", VA = "0x1823731E0")]
				[DebuggerNonUserCode]
				public NextWeather()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B24")]
				[Cpp2IlInjected.Address(RVA = "0x2372EA0", Offset = "0x23718A0", VA = "0x182372EA0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0x2373130", Offset = "0x2371B30", VA = "0x182373130")]
				[DebuggerNonUserCode]
				public NextWeather(NextWeather other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B26")]
				[Cpp2IlInjected.Address(RVA = "0x2372B40", Offset = "0x2371540", VA = "0x182372B40", Slot = "10")]
				[DebuggerNonUserCode]
				public NextWeather Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B2B")]
				[Cpp2IlInjected.Address(RVA = "0x2372C10", Offset = "0x2371610", VA = "0x182372C10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B2C")]
				[Cpp2IlInjected.Address(RVA = "0x1395A20", Offset = "0x1394420", VA = "0x181395A20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(NextWeather other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B2D")]
				[Cpp2IlInjected.Address(RVA = "0x1395C10", Offset = "0x1394610", VA = "0x181395C10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B2E")]
				[Cpp2IlInjected.Address(RVA = "0x2372FC0", Offset = "0x23719C0", VA = "0x182372FC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B2F")]
				[Cpp2IlInjected.Address(RVA = "0x1395F20", Offset = "0x1394920", VA = "0x181395F20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B30")]
				[Cpp2IlInjected.Address(RVA = "0x23729C0", Offset = "0x23713C0", VA = "0x1823729C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B31")]
				[Cpp2IlInjected.Address(RVA = "0x2372D90", Offset = "0x2371790", VA = "0x182372D90", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(NextWeather other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B32")]
				[Cpp2IlInjected.Address(RVA = "0x2372E00", Offset = "0x2371800", VA = "0x182372E00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B33")]
				[Cpp2IlInjected.Address(RVA = "0x2372CC0", Offset = "0x23716C0", VA = "0x182372CC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B34")]
				[Cpp2IlInjected.Address(RVA = "0x2372EB0", Offset = "0x23718B0", VA = "0x182372EB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B35")]
				[Cpp2IlInjected.Address(RVA = "0x2372A90", Offset = "0x2371490", VA = "0x182372A90", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private static readonly MessageParser<Weather> _parser = (MessageParser<Weather>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Weather()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public const int DefaultFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private bool default_;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public const int MinDurationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private Duration minDuration_;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public const int MaxDurationFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private Duration maxDuration_;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public const int WeatherProfileAssetAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private string weatherProfileAssetAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public const int NextWeathersFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private static readonly FieldCodec<Types.NextWeather> _repeated_nextWeathers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private readonly RepeatedField<Types.NextWeather> nextWeathers_ = (RepeatedField<Types.NextWeather>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public const int WaterPlantsFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private bool waterPlants_;

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		[DebuggerNonUserCode]
		public static MessageParser<Weather> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x17CACC0", Offset = "0x17C96C0", VA = "0x1817CACC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0x17CABF0", Offset = "0x17C95F0", VA = "0x1817CABF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B03")]
			[Cpp2IlInjected.Address(RVA = "0x17CAD20", Offset = "0x17C9720", VA = "0x1817CAD20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		[DebuggerNonUserCode]
		public bool Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return default_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B09")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				default_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		[DebuggerNonUserCode]
		public Duration MinDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return minDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				minDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		[DebuggerNonUserCode]
		public Duration MaxDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return maxDuration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				maxDuration_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		[DebuggerNonUserCode]
		public string WeatherProfileAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return weatherProfileAssetAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0F")]
			[Cpp2IlInjected.Address(RVA = "0x17CAE30", Offset = "0x17C9830", VA = "0x1817CAE30")]
			set
			{
				string text = (weatherProfileAssetAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.NextWeather> NextWeathers
		{
			[Cpp2IlInjected.Token(Token = "0x6000B10")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return nextWeathers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		[DebuggerNonUserCode]
		public bool WaterPlants
		{
			[Cpp2IlInjected.Token(Token = "0x6000B11")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return waterPlants_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B12")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				waterPlants_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x17CA8D0", Offset = "0x17C92D0", VA = "0x1817CA8D0")]
		[DebuggerNonUserCode]
		public Weather()
		{
			Duration duration = (minDuration_ = new Duration());
			Duration duration2 = (maxDuration_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x17CA260", Offset = "0x17C8C60", VA = "0x1817CA260")]
		private void OnConstruction()
		{
			Duration duration = (minDuration_ = new Duration());
			Duration duration2 = (maxDuration_ = new Duration());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x17CA9E0", Offset = "0x17C93E0", VA = "0x1817CA9E0")]
		[DebuggerNonUserCode]
		public Weather(Weather other)
		{
			//IL_0067: Expected O, but got I4
			Duration duration = (minDuration_ = new Duration());
			Duration duration2 = (maxDuration_ = new Duration());
			bool flag = other.default_;
			int num = 0;
			default_ = flag;
			Duration duration3 = other.minDuration_;
			if (duration3 != null)
			{
				Duration duration4 = duration3.Clone();
			}
			minDuration_ = (Duration)num;
			Duration duration5 = other.maxDuration_;
			Duration duration6 = default(Duration);
			if (duration5 != null)
			{
				duration6 = duration5.Clone();
			}
			maxDuration_ = duration6;
			string text = (weatherProfileAssetAddress_ = other.weatherProfileAssetAddress_);
			RepeatedField<Types.NextWeather> repeatedField = (nextWeathers_ = (RepeatedField<Types.NextWeather>)(object)((RepeatedField<T>)(object)other.nextWeathers_).Clone());
			bool flag2 = (waterPlants_ = other.waterPlants_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0x17C9590", Offset = "0x17C7F90", VA = "0x1817C9590", Slot = "10")]
		[DebuggerNonUserCode]
		public Weather Clone()
		{
			return new Weather(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x17C9BA0", Offset = "0x17C85A0", VA = "0x1817C9BA0", Slot = "0")]
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
				if ((IntPtr)(default_ ? 1 : 0) == (IntPtr)typeof(Weather).TypeHandle && object.Equals(minDuration_, other) && object.Equals(maxDuration_, other))
				{
					string text = weatherProfileAssetAddress_;
					bool flag = default(bool);
					if (!flag)
					{
						RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
						bool flag2 = default(bool);
						if (flag2 && waterPlants_ == flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x17C9AB0", Offset = "0x17C84B0", VA = "0x1817C9AB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Weather other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.default_;
				if (default_ == flag)
				{
					Duration objB = other.minDuration_;
					if (object.Equals(minDuration_, objB))
					{
						Duration objB2 = other.maxDuration_;
						if (object.Equals(maxDuration_, objB2))
						{
							string text = other.weatherProfileAssetAddress_;
							if (!(weatherProfileAssetAddress_ != text))
							{
								RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
								RepeatedField<Types.NextWeather> repeatedField2 = other.nextWeathers_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									bool flag2 = other.waterPlants_;
									if (waterPlants_ == flag2)
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x17C9E00", Offset = "0x17C8800", VA = "0x1817C9E00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007a
			if (default_)
			{
			}
			Duration duration = minDuration_;
			if (duration != null)
			{
				int hashCode = duration.GetHashCode();
			}
			Duration duration2 = maxDuration_;
			if (duration2 != null)
			{
				int hashCode2 = duration2.GetHashCode();
			}
			string text = weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode3 = text.GetHashCode();
			}
			int hashCode4 = ((RepeatedField<T>)(object)nextWeathers_).GetHashCode();
			if (waterPlants_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x17CA500", Offset = "0x17C8F00", VA = "0x1817CA500", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x17CA560", Offset = "0x17C8F60", VA = "0x1817CA560", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ad
			if (default_)
			{
				bool value = default_;
				output.WriteBool(value);
			}
			if ((long)minDuration_ != 0)
			{
				Duration value2 = minDuration_;
				output.WriteMessage(value2);
			}
			if ((long)maxDuration_ != 0)
			{
				Duration value3 = maxDuration_;
				output.WriteMessage(value3);
			}
			if (weatherProfileAssetAddress_.m_stringLength != 0)
			{
				string value4 = weatherProfileAssetAddress_;
				output.WriteString(value4);
			}
			RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
			FieldCodec<Types.NextWeather> repeated_nextWeathers_codec = _repeated_nextWeathers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_nextWeathers_codec);
			if (waterPlants_)
			{
				bool value5 = waterPlants_;
				output.WriteBool(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x17C9300", Offset = "0x17C7D00", VA = "0x1817C9300", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			Duration duration = minDuration_;
			if (duration != null)
			{
				int num = CodedOutputStream.ComputeMessageSize(duration);
				num++;
			}
			Duration duration2 = maxDuration_;
			if (duration2 != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(duration2);
				num2++;
			}
			string text = weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
			}
			RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
			FieldCodec<Types.NextWeather> repeated_nextWeathers_codec = _repeated_nextWeathers_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_nextWeathers_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.NextWeather>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x17C9EF0", Offset = "0x17C88F0", VA = "0x1817C9EF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Weather other)
		{
			//Discarded unreachable code: IL_00f3
			if (other == null)
			{
				return;
			}
			bool flag = other.default_;
			if (flag)
			{
				default_ = flag;
			}
			if ((long)other.minDuration_ != 0)
			{
				Duration duration2 = default(Duration);
				if (minDuration_ == null)
				{
					Duration duration = (minDuration_ = new Duration());
					duration2 = minDuration_;
				}
				Duration other2 = other.minDuration_;
				duration2.MergeFrom(other2);
			}
			if ((long)other.maxDuration_ != 0)
			{
				Duration duration4 = default(Duration);
				if (maxDuration_ == null)
				{
					Duration duration3 = (maxDuration_ = new Duration());
					duration4 = maxDuration_;
				}
				Duration other3 = other.maxDuration_;
				duration4.MergeFrom(other3);
			}
			string text = other.weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				WeatherProfileAssetAddress = text;
			}
			RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
			RepeatedField<Types.NextWeather> repeatedField2 = other.nextWeathers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			bool flag2 = other.waterPlants_;
			if (flag2)
			{
				waterPlants_ = flag2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x17CA060", Offset = "0x17C8A60", VA = "0x1817CA060", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00e6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (WeatherProfileAssetAddress = input.ReadString());
				}
				if (num == 42)
				{
					RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
					FieldCodec<Types.NextWeather> repeated_nextWeathers_codec = _repeated_nextWeathers_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_nextWeathers_codec);
				}
				if (num != 48)
				{
					goto IL_00cf;
				}
				bool flag = (waterPlants_ = input.ReadBool());
			}
			bool flag2 = default(bool);
			if (num == 8)
			{
				flag2 = (default_ = input.ReadBool());
			}
			Duration duration = default(Duration);
			if (flag2)
			{
				Duration builder = default(Duration);
				if (minDuration_ == null)
				{
					duration = (minDuration_ = new Duration());
					builder = minDuration_;
				}
				input.ReadMessage(builder);
			}
			if ((long)duration == 26)
			{
				Duration builder2 = default(Duration);
				if (maxDuration_ == null)
				{
					Duration duration2 = (maxDuration_ = new Duration());
					builder2 = maxDuration_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00cf;
			IL_00cf:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x17C9CD0", Offset = "0x17C86D0", VA = "0x1817C9CD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				bool flag = default_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x17CA2F0", Offset = "0x17C8CF0", VA = "0x1817CA2F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0019, IL_0026, IL_002e, IL_0034, IL_003a, IL_0040
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				default_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x17C9480", Offset = "0x17C7E80", VA = "0x1817C9480", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0012
			if (fieldNumber - 1 <= 5)
			{
				default_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x17C95F0", Offset = "0x17C7FF0", VA = "0x1817C95F0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0108
			if (default_)
			{
				IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<Weather>();
				Func<Weather, bool> _003C_003E9__54_ = _003C_003Ec._003C_003E9__54_0;
				if (_003C_003E9__54_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Weather x) => x.default_);
				}
				if (Enumerable.Count<Weather>(enumerable, (Func<, >)(object)_003C_003E9__54_) > 1)
				{
					DataValidation.Context context2 = context;
				}
			}
			DataValidation.Context context3 = context;
			RepeatedField<Types.NextWeather> cpp2il__autoParamName__idx_ = nextWeathers_;
			context3.RequireNotEmpty<Types.NextWeather>((IEnumerable<>)(object)cpp2il__autoParamName__idx_, "NextWeathers");
			int count = ((RepeatedField<T>)(object)nextWeathers_).Count;
			RepeatedField<Types.NextWeather> repeatedField = nextWeathers_;
			Func<Types.NextWeather, string> func = default(Func<Types.NextWeather, string>);
			if (_003C_003Ec._003C_003E9__54_1 == null)
			{
				func = (Func<Types.NextWeather, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.NextWeather x) => x.weather_));
			}
			int num = Enumerable.Count<IGrouping<string, Types.NextWeather>>(Enumerable.GroupBy<Types.NextWeather, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func));
			if (count != num)
			{
				context.AddInvalidMemberError("Cannot have duplicate weathers in the list", "NextWeathers");
			}
			RepeatedField<Types.NextWeather> cpp2il__autoParamName__idx_2 = nextWeathers_;
			Func<Types.NextWeather, bool> cpp2il__autoParamName__idx_3 = (Func<Types.NextWeather, bool>)(object)(Func<T, TResult>)delegate(Types.NextWeather x)
			{
				//Discarded unreachable code: IL_001d
				DataValidation.Context context4 = context;
				string weather_ = x.weather_;
				string topName = context4.TopName;
				return string.Equals(weather_, topName);
			};
			if (((IEnumerable<>)(object)cpp2il__autoParamName__idx_2).Any<Types.NextWeather>((Func<, >)(object)cpp2il__autoParamName__idx_3))
			{
				context.AddInvalidMemberError("Cannot have the weather itself in the list", "NextWeathers");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x17CA700", Offset = "0x17C9100", VA = "0x1817CA700")]
		static Weather()
		{
			MessageParser<Types.NextWeather> parser = Types.NextWeather._parser;
			uint num = default(uint);
			_parser = (MessageParser<Weather>)(object)FieldCodec.ForMessage<Types.NextWeather>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
