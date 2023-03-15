using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000772")]
	public static class CustomOptionsExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600522C")]
		[Cpp2IlInjected.Address(RVA = "0x16D2660", Offset = "0x16D1060", VA = "0x1816D2660")]
		public static bool TryGetBool<T>(this CustomOptions customOptions, T field, out bool value) where T : struct, Enum, IConvertible
		{
			//Discarded unreachable code: IL_001a
			int num = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600522D")]
		public static bool TryGetBytes<T>(this CustomOptions customOptions, T field, out ByteString value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600522E")]
		public static bool TryGetDouble<T>(this CustomOptions customOptions, T field, out double value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600522F")]
		public static bool TryGetFixed32<T>(this CustomOptions customOptions, T field, out uint value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005230")]
		public static bool TryGetFixed64<T>(this CustomOptions customOptions, T field, out ulong value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005231")]
		public static bool TryGetFloat<T>(this CustomOptions customOptions, T field, out float value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005232")]
		public static bool TryGetInt32<T>(this CustomOptions customOptions, T field, out int value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005233")]
		public static bool TryGetInt64<T>(this CustomOptions customOptions, T field, out long value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005234")]
		[Cpp2IlInjected.Address(RVA = "0x16D29C0", Offset = "0x16D13C0", VA = "0x1816D29C0")]
		public static bool TryGetMessage<T, T2>(this CustomOptions P_0, T field, out T2 value) where T : struct, Enum, IConvertible where T2 : class, IMessage, new()
		{
			int num = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			invariantCulture = (CultureInfo)(object)((object)invariantCulture + (object)invariantCulture);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005235")]
		public static bool TryGetSFixed32<T>(this CustomOptions customOptions, T field, out int value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005236")]
		public static bool TryGetSFixed64<T>(this CustomOptions customOptions, T field, out long value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005237")]
		public static bool TryGetSInt32<T>(this CustomOptions customOptions, T field, out int value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005238")]
		public static bool TryGetSInt64<T>(this CustomOptions customOptions, T field, out long value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005239")]
		[Cpp2IlInjected.Address(RVA = "0x16D2B10", Offset = "0x16D1510", VA = "0x1816D2B10")]
		public static bool TryGetString<T>(this CustomOptions cpp2il__autoParamName__idx_0, T field, ref string cpp2il__autoParamName__idx_2) where T : struct, Enum, IConvertible
		{
			//Discarded unreachable code: IL_001a
			int num = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600523A")]
		public static bool TryGetUInt32<T>(this CustomOptions customOptions, T field, out uint value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600523B")]
		public static bool TryGetUInt64<T>(this CustomOptions customOptions, T field, out ulong value) where T : struct, Enum, IConvertible
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600523C")]
		[Cpp2IlInjected.Address(RVA = "0x16D27B0", Offset = "0x16D11B0", VA = "0x1816D27B0")]
		public static bool TryGetEnum<T, U>(this CustomOptions customOptions, T field, out U value) where T : struct, Enum, IConvertible where U : struct, Enum, IConvertible
		{
			//Discarded unreachable code: IL_0039
			//IL_001d: Expected O, but got I4
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
			int num = 0;
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				num++;
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
			object obj = Enum.ToObject(typeFromHandle, num);
			RuntimeTypeHandle impl = typeFromHandle._impl;
			object obj2 = obj;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600523D")]
		[Cpp2IlInjected.Address(RVA = "0x2D49A90", Offset = "0x2D48490", VA = "0x182D49A90")]
		[AsyncStateMachine(typeof(_003CGetOnlineChoices_003Ed__17))]
		public static Task<List<(string, object)>> GetOnlineChoices(this CustomOptions self)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<(string, object)>>)(object)result;
		}
	}
}
