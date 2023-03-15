using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class TitleDataConfigHolder<TitleDataType> where TitleDataType : ITitleDataConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TitleDataType CachedData;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private ITitleDataOnlineSyncCondition OnlineSyncCondition
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((TitleDataConfigHolder<>)(object)this)._003COnlineSyncCondition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((TitleDataConfigHolder<>)(object)this)._003COnlineSyncCondition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public bool IsUpToDateWithOnlineData
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x2C898C0", Offset = "0x2C882C0", VA = "0x182C898C0")]
			get
			{
				if (OnlineSyncCondition == null)
				{
				}
				ITitleDataOnlineSyncCondition onlineSyncCondition = OnlineSyncCondition;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2C89850", Offset = "0x2C88250", VA = "0x182C89850")]
		public TitleDataConfigHolder(TitleDataType defaultData, ITitleDataOnlineSyncCondition syncCondition)
		{
			OnlineSyncCondition = syncCondition;
			((TitleDataConfigHolder<>)(object)this).CachedData = defaultData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
		public TitleDataType Get()
		{
			return ((TitleDataConfigHolder<>)(object)this).CachedData;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2C896B0", Offset = "0x2C880B0", VA = "0x182C896B0")]
		[AsyncStateMachine(typeof(TitleDataConfigHolder<>._003CGetOrUpdateAsync_003Ed__9))]
		public Task<TitleDataType> GetOrUpdateAsync(PlayFabContext context, bool isForcedSync = false, [Optional] CancellationToken ct)
		{
			PlayFabAuthenticationInstanceAPI auth = context.auth;
			PlayFabAuthenticationInstanceAPI auth2 = context.auth;
			ITitleDataOnlineSyncCondition titleDataOnlineSyncCondition = ((TitleDataConfigHolder<>)(object)this).OnlineSyncCondition;
			PlayFabAuthenticationInstanceAPI auth3 = context.auth;
			PlayFabAuthenticationInstanceAPI auth4 = context.auth;
			PlayFabAuthenticationInstanceAPI auth5 = context.auth;
			PlayFabAuthenticationInstanceAPI auth6 = context.auth;
			Task<> result = default(Task<>);
			return (Task<TitleDataType>)(object)result;
		}
	}
}
