using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	public static class ProtoExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private const int ProtoFormatterDefaultCapacity = 102400;

		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private static readonly FieldType[] IntegerFieldTypes;

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		public static Timestamp TimestampMinValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000DB3")]
			[Cpp2IlInjected.Address(RVA = "0x2D9F0A0", Offset = "0x2D9DAA0", VA = "0x182D9F0A0")]
			get
			{
				//IL_0006: Expected I8, but got I4
				return Timestamp.FromDateTime(DateTime.FromFileTimeUtc(0L));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		public static DateTime DateTimeEpoch
		{
			[Cpp2IlInjected.Token(Token = "0x6000DB4")]
			[Cpp2IlInjected.Address(RVA = "0x2D9EEA0", Offset = "0x2D9D8A0", VA = "0x182D9EEA0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		public static Timestamp Epoch
		{
			[Cpp2IlInjected.Token(Token = "0x6000DB5")]
			[Cpp2IlInjected.Address(RVA = "0x2D9EED0", Offset = "0x2D9D8D0", VA = "0x182D9EED0")]
			get
			{
				return new Timestamp();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		[field: Cpp2IlInjected.Token(Token = "0x4000601")]
		private static JsonFormatter FormatterNoDefaultValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC1")]
			[Cpp2IlInjected.Address(RVA = "0x2D9EFE0", Offset = "0x2D9D9E0", VA = "0x182D9EFE0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000352")]
		[field: Cpp2IlInjected.Token(Token = "0x4000602")]
		private static JsonFormatter FormatterNoDefaultValuesEnumAsInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC2")]
			[Cpp2IlInjected.Address(RVA = "0x2D9EF80", Offset = "0x2D9D980", VA = "0x182D9EF80")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000353")]
		[field: Cpp2IlInjected.Token(Token = "0x4000603")]
		private static JsonFormatter Formatter
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC3")]
			[Cpp2IlInjected.Address(RVA = "0x2D9F040", Offset = "0x2D9DA40", VA = "0x182D9F040")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		[field: Cpp2IlInjected.Token(Token = "0x4000604")]
		private static JsonFormatter FormatterEnumAsInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000DC4")]
			[Cpp2IlInjected.Address(RVA = "0x2D9EF20", Offset = "0x2D9D920", VA = "0x182D9EF20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E1F0", Offset = "0x2D9CBF0", VA = "0x182D9E1F0")]
		public static Timestamp ToProto(this DateTime dateTime)
		{
			return Timestamp.FromDateTime(dateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E190", Offset = "0x2D9CB90", VA = "0x182D9E190")]
		public static Duration ToProto(this TimeSpan timeSpan)
		{
			return Duration.FromTimeSpan(timeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DF10", Offset = "0x2D9C910", VA = "0x182D9DF10")]
		public static long ToEpoch(this Timestamp self)
		{
			//Discarded unreachable code: IL_0013
			Timestamp timestamp = new Timestamp();
			return (self - timestamp).Seconds;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DC70", Offset = "0x2D9C670", VA = "0x182D9DC70")]
		public static bool IsExpiredDaily(this Timestamp timestamp, Timestamp now)
		{
			//Discarded unreachable code: IL_0030
			Duration duration = new Duration();
			long seconds = timestamp.Seconds;
			long seconds2 = duration.Seconds;
			long seconds3 = now.Seconds;
			long seconds4 = duration.Seconds;
			seconds4 = seconds3;
			seconds4 = seconds;
			return seconds4 > seconds4;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DD60", Offset = "0x2D9C760", VA = "0x182D9DD60")]
		public static bool IsExpired(this Timestamp timestamp, Timestamp now, Duration duration)
		{
			//Discarded unreachable code: IL_0019
			long seconds = (timestamp + duration).Seconds;
			long seconds2 = now.Seconds;
			return seconds > seconds2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB9")]
		[Cpp2IlInjected.Address(RVA = "0x1B14060", Offset = "0x1B12A60", VA = "0x181B14060")]
		public static T Find<T>(this RepeatedField<> P_0, Predicate<> P_1) where T : class
		{
			int num = 0;
			num++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBA")]
		[Cpp2IlInjected.Address(RVA = "0x1B14650", Offset = "0x1B13050", VA = "0x181B14650")]
		public static void Set<T>(this RepeatedField<T> field, IEnumerable<T> values)
		{
			//Discarded unreachable code: IL_0008
			IEnumerable<(TagItemType, int?)> usedTagTypes = (IEnumerable<(TagItemType, int?)>)((IHasTagsRnd)(object)field).get_UsedTagTypes();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBB")]
		[Cpp2IlInjected.Address(RVA = "0x1B13FD0", Offset = "0x1B129D0", VA = "0x181B13FD0")]
		public static T FindOrDefault<T>(this RepeatedField<T> field, Predicate<T> a, T defaultValue) where T : class
		{
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBC")]
		[Cpp2IlInjected.Address(RVA = "0x1B13D50", Offset = "0x1B12750", VA = "0x181B13D50")]
		public static bool Exists<T>(this RepeatedField<T> field, Predicate<T> a) where T : class
		{
			return (object)typeof(ProtoExtensions).TypeHandle != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0x1B146B0", Offset = "0x1B130B0", VA = "0x181B146B0")]
		public static bool TryFindValue<T>(this RepeatedField<T> field, Predicate<T> a, out T val) where T : class
		{
			//IL_0006: Expected I4, but got O
			return (byte)(int)typeof(ProtoExtensions).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x1B13A80", Offset = "0x1B12480", VA = "0x181B13A80")]
		public static int BinarySearch<T>(this RepeatedField<T> field, T value) where T : IComparable<T>
		{
			//Discarded unreachable code: IL_000a
			if ((object)typeof(ProtoExtensions).TypeHandle != null)
			{
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0x1B13ED0", Offset = "0x1B128D0", VA = "0x181B13ED0")]
		public static int FindIndex<T>(this RepeatedField<> P_0, Func<, > P_1)
		{
			if (P_1 != null)
			{
				int num = 0;
				return num + 1;
			}
			ArgumentNullException ex = new ArgumentNullException("predicate");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0x1B139D0", Offset = "0x1B123D0", VA = "0x181B139D0")]
		public static bool Any<T>(this RepeatedField<> P_0, Predicate<> P_1)
		{
			//Discarded unreachable code: IL_0008
			int num = 0;
			num++;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DFF0", Offset = "0x2D9C9F0", VA = "0x182D9DFF0")]
		public static string ToJSONString(this IMessage message, bool formatDefaultValues = true, bool indented = true, bool formatEnumAsIntegers = false, int capacity = 102400)
		{
			//Discarded unreachable code: IL_002b
			int num = 0;
			StringBuilder stringBuilder = default(StringBuilder);
			StringWriter stringWriter = new StringWriter(stringBuilder);
			message.WriteTo(stringWriter, formatDefaultValues, formatEnumAsIntegers);
			string text = stringBuilder.ToString();
			if (indented)
			{
				string text2 = Indent(text);
			}
			if (stringWriter != null)
			{
			}
			return text;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E980", Offset = "0x2D9D380", VA = "0x182D9E980")]
		public static void WriteTo(this IMessage message, TextWriter textWriter, bool formatDefaultValues = true, bool formatEnumAsIntegers = false)
		{
			//Discarded unreachable code: IL_001b
			int num = 0;
			if (!formatDefaultValues || formatEnumAsIntegers)
			{
			}
			if (formatEnumAsIntegers)
			{
			}
			FormatterNoDefaultValues.Format(message, textWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DA40", Offset = "0x2D9C440", VA = "0x182D9DA40")]
		public static string Indent(string jsonText)
		{
			//Discarded unreachable code: IL_000c
			int num = 0;
			JToken jToken = JToken.Parse(jsonText);
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0x1B14290", Offset = "0x1B12C90", VA = "0x181B14290")]
		public static void ForEach<T>(this RepeatedField<> P_0, Action<> P_1)
		{
			//Discarded unreachable code: IL_0027
			bool flag = default(bool);
			if (flag)
			{
			}
			int num = 0;
			if ((long)num < (long)(IntPtr)P_0)
			{
				num += num;
				if ((object)"{il2cpp array field il2cppMethodInfo->}" != (object)typeof(IDisposable).TypeHandle)
				{
					num++;
				}
			}
			num += 312;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0x1B14590", Offset = "0x1B12F90", VA = "0x181B14590")]
		public static TValue GetValueOrDefault<TValue, TKey>(this MapField<TKey, TValue> map, TKey key)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D980", Offset = "0x2D9C380", VA = "0x182D9D980")]
		public static IMessage Clone(this IMessage self, bool useCloneDefaultData = false)
		{
			//Discarded unreachable code: IL_0009
			byte[] array = self.ToByteArray();
			IMessage result = default(IMessage);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0x1B13C70", Offset = "0x1B12670", VA = "0x181B13C70")]
		public static T Clone<T>(this T self, bool useCloneDefaultData = false) where T : class, IMessage
		{
			IMessage message = default(IMessage);
			if (message == null)
			{
			}
			while (message != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DE00", Offset = "0x2D9C800", VA = "0x182D9DE00")]
		public static bool IsInteger(this FieldType self)
		{
			//Discarded unreachable code: IL_0025
			FieldType[] integerFieldTypes = IntegerFieldTypes;
			Predicate<FieldType> predicate = (Predicate<FieldType>)(object)(Predicate<T>)((FieldType x) => x == self);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0x1B13690", Offset = "0x1B12090", VA = "0x181B13690")]
		public static List<T> AllMessagesRecursive<T>(this IMessage self, bool includeSelf = false)
		{
			//Discarded unreachable code: IL_0049
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
			int num = 0;
			List<IMessage> list = (List<IMessage>)(object)ProtoExtensions.AllMessagesRecursive(self, includeSelf);
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				if (!flag)
				{
					throw new InvalidCastException();
				}
			}
			int num2 = 0;
			if (num2 < (flag ? 1 : 0))
			{
				num2 += num2;
				num2++;
			}
			num2 += 312;
			num2 += typeof(List<IMessage>.Enumerator).TypeHandle;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D8C0", Offset = "0x2D9C2C0", VA = "0x182D9D8C0")]
		public static List<IMessage> AllMessagesRecursive(this IMessage self, bool includeSelf = false)
		{
			return (List<IMessage>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EC30", Offset = "0x2D9D630", VA = "0x182D9EC30")]
		static ProtoExtensions()
		{
			//IL_002f: Expected I4, but got I8
			//IL_0040: Expected I4, but got I8
			//IL_005f: Expected I4, but got I8
			//IL_0066: Expected I4, but got I8
			int formatDefaultValues = default(int);
			JsonFormatter.Settings settings = new JsonFormatter.Settings((byte)formatDefaultValues != 0);
			formatDefaultValues = 0;
			int formatEnumsAsIntegers = 0;
			FormatterNoDefaultValues = new JsonFormatter(settings.WithFormatEnumsAsIntegers((byte)formatEnumsAsIntegers != 0));
			int formatDefaultValues2 = default(int);
			JsonFormatter.Settings settings2 = new JsonFormatter.Settings((byte)formatDefaultValues2 != 0);
			formatDefaultValues2 = 0;
			ulong num = default(ulong);
			FormatterNoDefaultValues = new JsonFormatter(settings2.WithFormatEnumsAsIntegers((byte)num != 0));
			ulong num2 = default(ulong);
			JsonFormatter.Settings settings3 = new JsonFormatter.Settings((byte)num2 != 0);
			int formatEnumsAsIntegers2 = 0;
			FormatterNoDefaultValues = new JsonFormatter(settings3.WithFormatEnumsAsIntegers((byte)formatEnumsAsIntegers2 != 0));
			ulong num3 = default(ulong);
			ulong num4 = default(ulong);
			FormatterNoDefaultValues = new JsonFormatter(new JsonFormatter.Settings((byte)num3 != 0).WithFormatEnumsAsIntegers((byte)num4 != 0));
			FieldType[] array = new FieldType[10];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			FormatterNoDefaultValues = (JsonFormatter)(object)array;
			throw new NullReferenceException();
		}
	}
}
