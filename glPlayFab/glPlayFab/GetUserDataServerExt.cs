using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.ServerModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public static class GetUserDataServerExt
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x102F510", Offset = "0x102DF10", VA = "0x18102F510")]
		public static bool IsDev(this GetUserDataResult getUserDataResult)
		{
			//Discarded unreachable code: IL_001e
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				int num2 = 0;
			}
			int count = ((Dictionary<, >)(object)data).count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x102F3B0", Offset = "0x102DDB0", VA = "0x18102F3B0")]
		public static bool IsDevBattlePass(this GetUserDataResult getUserDataResult)
		{
			//Discarded unreachable code: IL_001e
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				int num2 = 0;
			}
			int count = ((Dictionary<, >)(object)data).count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x102F460", Offset = "0x102DE60", VA = "0x18102F460")]
		public static bool IsDevShop(this GetUserDataResult getUserDataResult)
		{
			//Discarded unreachable code: IL_001e
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				int num2 = 0;
			}
			int count = ((Dictionary<, >)(object)data).count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x102F720", Offset = "0x102E120", VA = "0x18102F720")]
		public static bool IsTesterEnv(this GetUserDataResult getUserDataResult)
		{
			//Discarded unreachable code: IL_001e
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				int num2 = 0;
			}
			int count = ((Dictionary<, >)(object)data).count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x102F670", Offset = "0x102E070", VA = "0x18102F670")]
		public static bool IsQAPromo(this GetUserDataResult getUserDataResult)
		{
			//Discarded unreachable code: IL_001e
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				int num2 = 0;
			}
			int count = ((Dictionary<, >)(object)data).count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x102F5E0", Offset = "0x102DFE0", VA = "0x18102F5E0")]
		public static bool IsOnlineFlagEnabled(this GetUserDataResult getUserDataResult, string userDataKey)
		{
			//Discarded unreachable code: IL_0016
			Dictionary<string, UserDataRecord> data = getUserDataResult.Data;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			ulong num2 = default(ulong);
			while (num2 == 0)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x102F5C0", Offset = "0x102DFC0", VA = "0x18102F5C0")]
		public static bool IsOnlineFlagEnabled(this GetUserDataResult getUserDataResult, UserDataRecord userDataRecord)
		{
			if (userDataRecord == null)
			{
			}
			return userDataRecord.Value.IsTrue();
		}
	}
}
