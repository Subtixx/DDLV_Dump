using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FBC")]
	public class TimedCachedValue<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17001649")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6007F5B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((TimedCachedValue<>)(object)this)._003CValue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007F5C")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				((TimedCachedValue<>)(object)this)._003CValue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40040D3")]
		public TimeSpan CacheDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6007F5D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007F5E")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700164B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40040D4")]
		public DateTime LastUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6007F5F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007F60")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F61")]
		[Cpp2IlInjected.Address(RVA = "0x2C89650", Offset = "0x2C88050", VA = "0x182C89650")]
		public TimedCachedValue(TimeSpan cacheDelay)
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x6007F62")]
		[Cpp2IlInjected.Address(RVA = "0x2C89290", Offset = "0x2C87C90", VA = "0x182C89290")]
		public T GetValue(Func<T> refreshFunc, [Optional] Func<T, bool> validateFunc, bool forceRefresh = false, [Optional] TimeSpan? cacheDelay)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007F63")]
		[Cpp2IlInjected.Address(RVA = "0x2C890F0", Offset = "0x2C87AF0", VA = "0x182C890F0")]
		[AsyncStateMachine(typeof(TimedCachedValue<>._003CGetValueAsync_003Ed__14))]
		public Task<T> GetValueAsync(Func<Task<T>> refreshFunc, [Optional] Func<T, bool> validateFunc, bool forceRefresh = false, [Optional] TimeSpan? cacheDelay)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007F64")]
		[Cpp2IlInjected.Address(RVA = "0x2C89520", Offset = "0x2C87F20", VA = "0x182C89520")]
		[AsyncStateMachine(typeof(TimedCachedValue<>._003CUpdateValueAsync_003Ed__15))]
		public Task UpdateValueAsync(Func<T, Task> updateFunc)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F65")]
		[Cpp2IlInjected.Address(RVA = "0x2C88EC0", Offset = "0x2C878C0", VA = "0x182C88EC0")]
		public void ClearCache([Optional] TimeSpan? minDelay)
		{
			//Discarded unreachable code: IL_004c
			//IL_0010: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			DateTime lastUpdate = LastUpdate;
			int num = 0;
			if (!(lastUpdate == (DateTime)num))
			{
				int num2 = 0;
				DateTime utcNow = DateTime.UtcNow;
				if ((object)LastUpdate != null)
				{
					int num3 = 0;
				}
				int num4 = 0;
				if (!(utcNow >= (DateTime)num4))
				{
					return;
				}
			}
			int num5 = 0;
			Value = (T)num5;
			int num6 = 0;
			LastUpdate = (DateTime)num6;
		}
	}
}
