using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class ServiceBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly HostBuilder hostBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Type serviceType;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		internal ServiceBuilder(HostBuilder hostBuilder, Type serviceType)
		{
			this.hostBuilder = hostBuilder;
			this.serviceType = serviceType;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1B23100", Offset = "0x1B21B00", VA = "0x181B23100")]
		public InterceptorBuilder AddInterceptor<TInterceptorType>(InterceptorFunc interceptorFunc) where TInterceptorType : Interceptor
		{
			HostBuilder hostBuilder = this.hostBuilder;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x38E3C30", Offset = "0x38E2630", VA = "0x1838E3C30")]
		public unsafe InterceptorBuilder AddInterceptor([Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			//Discarded unreachable code: IL_0095
			HostBuilder hostBuilder = this.hostBuilder;
			HostBuilder._003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new HostBuilder._003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.before = before;
			_003C_003Ec__DisplayClass5_.after = after;
			InterceptorFunc interceptorFunc = default(InterceptorFunc);
			((Delegate)interceptorFunc).method_ptr = (IntPtr)__ldftn(HostBuilder._003C_003Ec__DisplayClass5_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).method = (IntPtr)__ldftn(HostBuilder._003C_003Ec__DisplayClass5_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).m_target = _003C_003Ec__DisplayClass5_;
			hostBuilder.anonymousCount++;
			InterceptorBuilder interceptorBuilder = default(InterceptorBuilder);
			interceptorBuilder.hostBuilder = hostBuilder;
			interceptorBuilder.Func = interceptorFunc;
			((List<T>)(object)hostBuilder.interceptorFuncs).Add((T)interceptorBuilder);
			ServiceFilterFunc serviceFilterFunc = default(ServiceFilterFunc);
			((Delegate)serviceFilterFunc).method_ptr = (IntPtr)__ldftn(ServiceBuilder._003CAddInterceptor_003Eb__4_0);
			((Delegate)serviceFilterFunc).method = (IntPtr)__ldftn(ServiceBuilder._003CAddInterceptor_003Eb__4_0);
			((Delegate)serviceFilterFunc).m_target = this;
			((InterceptorBuilderBase)interceptorBuilder).ServiceFilterFunc = serviceFilterFunc;
			return interceptorBuilder;
		}
	}
}
