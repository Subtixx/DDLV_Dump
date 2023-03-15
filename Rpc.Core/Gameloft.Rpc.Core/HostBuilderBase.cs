using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class HostBuilderBase<TServiceType, TServiceBuilderType> where TServiceBuilderType : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<Type> serviceTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Dictionary<Type, CreateDelegateInfo> delegateInfos;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected IEnumerable<Type> ServiceTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				List<Type> list = ((HostBuilderBase<, >)(object)this).serviceTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected IReadOnlyDictionary<Type, CreateDelegateInfo> DelegateInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				Dictionary<Type, CreateDelegateInfo> dictionary = ((HostBuilderBase<, >)(object)this).delegateInfos;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xFB4CD0", Offset = "0xFB36D0", VA = "0x180FB4CD0")]
		protected TServiceBuilderType RegisterService<TConcreteType>() where TConcreteType : TServiceType
		{
			//Discarded unreachable code: IL_0021
			List<Type> list = ((HostBuilderBase<, >)(object)this).serviceTypes;
			Type typeFromHandle = typeof(Type);
			((List<T>)(object)list).Add((T)typeFromHandle);
			Type serviceType = default(Type);
			return GetServiceBuilder(serviceType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xFB4DA0", Offset = "0xFB37A0", VA = "0x180FB4DA0")]
		public void RegisterType<TInstance>(CreateDelegate P_0) where TInstance : class
		{
			//Discarded unreachable code: IL_0016
			CreateDelegateInfo value = new CreateDelegateInfo(P_0, isSingleton: true);
			Type key = default(Type);
			((Dictionary<TKey, TValue>)(object)((HostBuilderBase<, >)(object)this).delegateInfos).Add((TKey)key, (TValue)value);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract TServiceBuilderType GetServiceBuilder(Type serviceType);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B0E0", Offset = "0x1C19AE0", VA = "0x181C1B0E0")]
		protected HostBuilderBase()
		{
			((HostBuilderBase<, >)(object)this).serviceTypes = (List<Type>)(object)new List<T>();
			((HostBuilderBase<, >)(object)this).delegateInfos = (Dictionary<Type, CreateDelegateInfo>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
		}
	}
}
