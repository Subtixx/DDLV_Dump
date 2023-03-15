using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class HostBuilder : HostBuilderBase<ClientBase, ServiceBuilder>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly List<InterceptorBuilder> interceptorFuncs = (List<InterceptorBuilder>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int anonymousCount;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x38DD970", Offset = "0x38DC370", VA = "0x1838DD970")]
		public HostBuilder()
		{
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x19AB2A0", Offset = "0x19A9CA0", VA = "0x1819AB2A0")]
		public ServiceBuilder AddService<TConcreteType>() where TConcreteType : ClientBase
		{
			IPatternContext patternContext = ((IPattern)this).CreatePatternContextForInclude();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x19AAF90", Offset = "0x19A9990", VA = "0x1819AAF90")]
		public InterceptorBuilder AddInterceptor<TInterceptorType>(InterceptorFunc interceptorFunc) where TInterceptorType : Interceptor
		{
			//Discarded unreachable code: IL_0017
			Type interceptorType = default(Type);
			InterceptorBuilder interceptorBuilder = new InterceptorBuilder(this, interceptorFunc, interceptorType);
			((List<T>)(object)interceptorFuncs).Add((T)interceptorBuilder);
			return interceptorBuilder;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x38DC7F0", Offset = "0x38DB1F0", VA = "0x1838DC7F0")]
		public unsafe InterceptorBuilder AddInterceptor([Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			//Discarded unreachable code: IL_005f
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.before = before;
			_003C_003Ec__DisplayClass5_.after = after;
			InterceptorFunc interceptorFunc = default(InterceptorFunc);
			((Delegate)interceptorFunc).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass5_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass5_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).m_target = _003C_003Ec__DisplayClass5_;
			anonymousCount++;
			InterceptorBuilder interceptorBuilder = default(InterceptorBuilder);
			interceptorBuilder.hostBuilder = this;
			interceptorBuilder.Func = interceptorFunc;
			((List<T>)(object)interceptorFuncs).Add((T)interceptorBuilder);
			return interceptorBuilder;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x38DCAF0", Offset = "0x38DB4F0", VA = "0x1838DCAF0")]
		public Host Build()
		{
			//Discarded unreachable code: IL_007c, IL_0082, IL_0088, IL_009a, IL_00a0, IL_00a6
			//IL_001d: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			List<ClientBase> list = (List<ClientBase>)(object)new List<T>();
			HostBuilderState hostBuilderState = default(HostBuilderState);
			Transport instance = hostBuilderState.GetInstance<Transport>();
			List<InterceptorBuilderBase> list2 = (List<InterceptorBuilderBase>)(object)InterceptorSorter.Sort((List<>)(object)new List<T>((int)interceptorFuncs));
			((List<T>)(object)list2).Reverse();
			if (list2 != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					if (num2 == 0)
					{
						throw new InvalidCastException();
					}
					if (num2 != 0)
					{
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
					}
				}
				object[] array = new object[1];
				if (instance != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[0] = instance;
				object obj = default(object);
				if (obj == null)
				{
				}
				int num3 = 0;
			}
			if (list2 != null)
			{
			}
			Dictionary<Type, object> singletons = hostBuilderState.singletons;
			return new Host((IEnumerable<>)list, (IReadOnlyDictionary<, >)singletons);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x38DD7E0", Offset = "0x38DC1E0", VA = "0x1838DD7E0", Slot = "4")]
		protected override ServiceBuilder GetServiceBuilder(Type serviceType)
		{
			ServiceBuilder serviceBuilder = default(ServiceBuilder);
			serviceBuilder.hostBuilder = this;
			serviceBuilder.serviceType = serviceType;
			return serviceBuilder;
		}
	}
}
