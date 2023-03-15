using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200082E")]
	public static class Operations
	{
		[Cpp2IlInjected.Token(Token = "0x6005BB6")]
		[Cpp2IlInjected.Address(RVA = "0x36A1680", Offset = "0x36A0080", VA = "0x1836A1680")]
		public static bool EvaluateInverse(bool condition, bool inversed)
		{
			return condition;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BB7")]
		[Cpp2IlInjected.Address(RVA = "0x26D1980", Offset = "0x26D0380", VA = "0x1826D1980")]
		public static bool Evaluate<T>(T profileValue, EqualOperator operation, T protobufValue)
		{
			while (operation != EqualOperator.NotEqual)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BB8")]
		[Cpp2IlInjected.Address(RVA = "0x36A19F0", Offset = "0x36A03F0", VA = "0x1836A19F0")]
		public static string ToString(EqualOperator operation)
		{
			string result = "==";
			if (operation == EqualOperator.NotEqual)
			{
				result = "!=";
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BB9")]
		[Cpp2IlInjected.Address(RVA = "0x36A1790", Offset = "0x36A0190", VA = "0x1836A1790")]
		public static bool Evaluate(string profileValue, StringOperator operation, string protobufValue, bool caseSensitive = true)
		{
			if (!caseSensitive)
			{
				if (profileValue != null)
				{
					string text = profileValue.ToLower();
				}
				if (protobufValue != null)
				{
					string text2 = protobufValue.ToLower();
				}
			}
			bool result3 = default(bool);
			if (operation != 0)
			{
				if (operation != 0)
				{
					bool result2 = default(bool);
					if (operation != 0)
					{
						bool result = default(bool);
						if (operation != 0)
						{
							if (operation != StringOperator.NotEqual)
							{
								goto IL_004f;
							}
							if (profileValue != null)
							{
								return profileValue.EndsWith(protobufValue);
							}
						}
						else if (profileValue != null)
						{
							return result;
						}
					}
					else if (profileValue != null)
					{
						return result2;
					}
					int num = 0;
				}
				return result3;
			}
			goto IL_004f;
			IL_004f:
			return result3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBA")]
		[Cpp2IlInjected.Address(RVA = "0x36A1A40", Offset = "0x36A0440", VA = "0x1836A1A40")]
		public static string ToString(StringOperator operation)
		{
			//Discarded unreachable code: IL_0006, IL_000c, IL_0012
			return "==";
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBB")]
		[Cpp2IlInjected.Address(RVA = "0x26D18A0", Offset = "0x26D02A0", VA = "0x1826D18A0")]
		public static bool Evaluate<T>(T profileValue, IntOperator P_1, T protobufValue) where T : IComparable<T>
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_0020
			int num = default(int);
			if (P_1 <= IntOperator.GreaterThanOrEqual)
			{
				return num != 0;
			}
			int num2 = default(int);
			return num2 == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBC")]
		[Cpp2IlInjected.Address(RVA = "0x26D13C0", Offset = "0x26CFDC0", VA = "0x1826D13C0")]
		public static void DataValidationMinValue<T>(T minValue, IntOperator P_1, T protobufValue, DataValidation.Context P_3, string P_4) where T : IComparable<T>
		{
			if (P_1 <= IntOperator.GreaterThanOrEqual)
			{
				return;
			}
			while (P_3 != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBD")]
		[Cpp2IlInjected.Address(RVA = "0x26D0EE0", Offset = "0x26CF8E0", VA = "0x1826D0EE0")]
		public static void DataValidationMaxValue<T>(T maxValue, IntOperator operation, T protobufValue, DataValidation.Context context, string memberName) where T : IComparable<T>
		{
			if (operation <= IntOperator.GreaterThanOrEqual)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				if (num > 0 && num2 > 0 && num3 <= 0)
				{
				}
				return;
			}
			int num4 = default(int);
			while (num4 <= 0)
			{
			}
			while (context != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBE")]
		[Cpp2IlInjected.Address(RVA = "0x36A1910", Offset = "0x36A0310", VA = "0x1836A1910")]
		public static string ToString(IntOperator operation)
		{
			//Discarded unreachable code: IL_000a, IL_0010, IL_0016, IL_001c
			if (operation <= IntOperator.GreaterThanOrEqual)
			{
				return "!=";
			}
			return "==";
		}

		[Cpp2IlInjected.Token(Token = "0x6005BBF")]
		[Cpp2IlInjected.Address(RVA = "0x36A1710", Offset = "0x36A0110", VA = "0x1836A1710")]
		public static bool Evaluate(MissionStepStatus value, MissionStatusOperator operation)
		{
			//Discarded unreachable code: IL_000c, IL_0010, IL_0014, IL_0016, IL_001e, IL_0026, IL_002b
			if (operation <= MissionStatusOperator.NotReadyToBeCompleted)
			{
				return value != MissionStepStatus.NotStarted;
			}
			return value == MissionStepStatus.NotStarted;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BC0")]
		[Cpp2IlInjected.Address(RVA = "0x36A1690", Offset = "0x36A0090", VA = "0x1836A1690")]
		public static bool Evaluate(MissionState state, MissionStateOperator operation)
		{
			//Discarded unreachable code: IL_0009, IL_0011, IL_0016, IL_001e, IL_0023, IL_002b, IL_0030
			if (operation <= MissionStateOperator.NotCompleted)
			{
				return state == MissionState.NotAvailableYet;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BC1")]
		[Cpp2IlInjected.Address(RVA = "0x36A18B0", Offset = "0x36A02B0", VA = "0x1836A18B0")]
		public static bool Evaluate(int profileValue, KeyholeStatusOperator operation, int protobufValue)
		{
			bool result = default(bool);
			return result;
		}
	}
}
