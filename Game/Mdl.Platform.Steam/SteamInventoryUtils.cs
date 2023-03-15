using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Steamworks;

namespace Mdl.Platform.Steam
{
	[Cpp2IlInjected.Token(Token = "0x20002FE")]
	public static class SteamInventoryUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xF606F0", Offset = "0xF5F0F0", VA = "0x180F606F0")]
		public static bool IsSuccess(this EResult result)
		{
			return result == EResult.k_EResultOK;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xF606E0", Offset = "0xF5F0E0", VA = "0x180F606E0")]
		public static bool IsFailure(this EResult result)
		{
			return result != EResult.k_EResultOK;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0x17508D0", Offset = "0x174F2D0", VA = "0x1817508D0")]
		[AsyncStateMachine(typeof(_003CWaitCallResult_003Ed__2<>))]
		private static Task<T> WaitCallResult<T>(SteamAPICall_t handle, [Optional] string debugName, [Optional] Func<T, string> debugResult) where T : struct
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<T>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D31")]
		[Cpp2IlInjected.Address(RVA = "0xF60700", Offset = "0xF5F100", VA = "0x180F60700")]
		[AsyncStateMachine(typeof(_003CRequestPricesAsync_003Ed__3))]
		public static Task<string> RequestPricesAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D32")]
		[Cpp2IlInjected.Address(RVA = "0xF601D0", Offset = "0xF5EBD0", VA = "0x180F601D0")]
		[IteratorStateMachine(typeof(_003CEnumItemsWithPrices_003Ed__4))]
		public static IEnumerable<(SteamItemDef_t, ulong, ulong)> EnumItemsWithPrices()
		{
			_003CEnumItemsWithPrices_003Ed__4 _003CEnumItemsWithPrices_003Ed__ = new _003CEnumItemsWithPrices_003Ed__4(-2);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D33")]
		[Cpp2IlInjected.Address(RVA = "0xF607F0", Offset = "0xF5F1F0", VA = "0x180F607F0")]
		[AsyncStateMachine(typeof(_003CStartPurchaseAsync_003Ed__5))]
		public static Task<bool> StartPurchaseAsync(SteamItemDef_t item, int qty = 1, bool allowRetry = true)
		{
			int steamItemDef = item.m_SteamItemDef;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D34")]
		[Cpp2IlInjected.Address(RVA = "0xF60220", Offset = "0xF5EC20", VA = "0x180F60220")]
		[AsyncStateMachine(typeof(_003CGetAllItemsAsync_003Ed__6))]
		public static Task<(EResult, SteamInventoryResult_t)> GetAllItemsAsync()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(EResult, SteamInventoryResult_t)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D35")]
		[Cpp2IlInjected.Address(RVA = "0xF60E90", Offset = "0xF5F890", VA = "0x180F60E90")]
		private static bool TryGetResultItems(SteamInventoryResult_t handle, out SteamItemDetails_t[] items)
		{
			int steamInventoryResult = handle.m_SteamInventoryResult;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			SteamItemDetails_t[] array = (SteamItemDetails_t[])(System.Runtime.CompilerServices.Unsafe.As<SteamItemDetails_t[], SteamItemDetails_t>(ref items).m_itemId = (SteamItemInstanceID_t)new SteamItemDetails_t[0]);
			bool flag2 = default(bool);
			return flag2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xF60BD0", Offset = "0xF5F5D0", VA = "0x180F60BD0")]
		public static bool TryGetItemProperties(SteamInventoryResult_t handle, uint index, string property, out string value)
		{
			//Discarded unreachable code: IL_0067
			int steamInventoryResult;
			string[] array;
			do
			{
				steamInventoryResult = handle.m_SteamInventoryResult;
				array = new string[1];
			}
			while (property != null && array == null);
			array[0] = property;
			int num = 0;
			bool flag = default(bool);
			if (array.Length == num && flag)
			{
				(new char[0])[0] = ',';
			}
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			string[] array2 = default(string[]);
			int length = array2.Length;
			if (num < length)
			{
				length = steamInventoryResult;
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				num++;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xF604F0", Offset = "0xF5EEF0", VA = "0x180F604F0")]
		private static Dictionary<string, string> GetItemProperties(SteamInventoryResult_t handle, uint index, params string[] extraProperties)
		{
			//Discarded unreachable code: IL_004e
			int steamInventoryResult = handle.m_SteamInventoryResult;
			int num = 0;
			bool flag = default(bool);
			if (extraProperties.Length == num && flag)
			{
				(new char[0])[0] = ',';
			}
			Dictionary<string, string> result = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			int length = extraProperties.Length;
			if (num < length)
			{
				length = steamInventoryResult;
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				num++;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xF60930", Offset = "0xF5F330", VA = "0x180F60930")]
		public static bool TryGetItemDefProperty(SteamItemDef_t itemDef, string property, out string value)
		{
			//Discarded unreachable code: IL_0067
			int steamItemDef;
			string[] array;
			do
			{
				steamItemDef = itemDef.m_SteamItemDef;
				array = new string[1];
			}
			while (property != null && array == null);
			array[0] = property;
			int num = 0;
			bool flag = default(bool);
			if (array.Length == num && flag)
			{
				(new char[0])[0] = ',';
			}
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			string[] array2 = default(string[]);
			int length = array2.Length;
			if (num < length)
			{
				length = steamItemDef;
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				num++;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xF60320", Offset = "0xF5ED20", VA = "0x180F60320")]
		public static Dictionary<string, string> GetItemDefProperties(SteamItemDef_t itemDef, params string[] extraProperties)
		{
			//Discarded unreachable code: IL_004e
			int steamItemDef = itemDef.m_SteamItemDef;
			int num = 0;
			bool flag = default(bool);
			if (extraProperties.Length == num && flag)
			{
				(new char[0])[0] = ',';
			}
			Dictionary<string, string> result = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			int length = extraProperties.Length;
			if (num < length)
			{
				length = steamItemDef;
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				num++;
			}
			return result;
		}
	}
}
