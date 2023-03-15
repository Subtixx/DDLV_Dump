using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model.Breadcrumbs.Storage;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class HostBuilder : HostBuilderBase<ServiceBase, ServiceBuilder>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly List<InterceptorBuilder> interceptorFuncs = (List<InterceptorBuilder>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int anonymousCount;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x38DD8E0", Offset = "0x38DC2E0", VA = "0x1838DD8E0")]
		public HostBuilder()
		{
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x19AB0D0", Offset = "0x19A9AD0", VA = "0x1819AB0D0")]
		public ServiceBuilder AddService<TConcreteType>() where TConcreteType : ServiceBase
		{
			Stream writeStream = ((Backtrace.Unity.Model.Breadcrumbs.Storage.IBreadcrumbFile)this).GetWriteStream();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x19AB080", Offset = "0x19A9A80", VA = "0x1819AB080")]
		public ServiceBuilder AddService<TConcreteType>(CreateDelegate createFunc) where TConcreteType : ServiceBase
		{
			Stream writeStream = ((Backtrace.Unity.Model.Breadcrumbs.Storage.IBreadcrumbFile)this).GetWriteStream();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x19AAEA0", Offset = "0x19A98A0", VA = "0x1819AAEA0")]
		public InterceptorBuilder AddInterceptor<TInterceptorType>(InterceptorFunc interceptorFunc) where TInterceptorType : Interceptor
		{
			//Discarded unreachable code: IL_0017
			Type interceptorType = default(Type);
			InterceptorBuilder interceptorBuilder = new InterceptorBuilder(this, interceptorFunc, interceptorType);
			((List<T>)(object)interceptorFuncs).Add((T)interceptorBuilder);
			return interceptorBuilder;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x38DC970", Offset = "0x38DB370", VA = "0x1838DC970")]
		public unsafe InterceptorBuilder AddInterceptor([Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			//Discarded unreachable code: IL_005f
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.before = before;
			_003C_003Ec__DisplayClass6_.after = after;
			InterceptorFunc interceptorFunc = default(InterceptorFunc);
			((Delegate)interceptorFunc).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass6_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass6_0._003CAddInterceptor_003Eb__0);
			((Delegate)interceptorFunc).m_target = _003C_003Ec__DisplayClass6_;
			anonymousCount++;
			InterceptorBuilder interceptorBuilder = default(InterceptorBuilder);
			interceptorBuilder.hostBuilder = this;
			interceptorBuilder.Func = interceptorFunc;
			((List<T>)(object)interceptorFuncs).Add((T)interceptorBuilder);
			return interceptorBuilder;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x38DD040", Offset = "0x38DBA40", VA = "0x1838DD040")]
		public Host Build()
		{
			//Discarded unreachable code: IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df, IL_00e5, IL_00eb, IL_00f1, IL_0103, IL_0109, IL_010f, IL_0115
			//IL_001f: Expected I4, but got O
			//IL_0085: Expected O, but got I4
			HostBuilderState hostBuilderState = default(HostBuilderState);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			AsyncServer asyncServer = default(AsyncServer);
			DefaultProcessor _003CProcessor_003Ek__BackingField = default(DefaultProcessor);
			Host host = default(Host);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<ServiceBase> list = (List<ServiceBase>)(object)new List<T>();
				List<ICallInvoker> list2 = (List<ICallInvoker>)(object)new List<T>();
				List<InterceptorBuilderBase> list3 = (List<InterceptorBuilderBase>)(object)InterceptorSorter.Sort((List<>)(object)new List<T>((int)interceptorFuncs));
				((List<T>)(object)list3).Reverse();
				if (list3 != null)
				{
					Dictionary<Type, object> singletons = hostBuilderState.singletons;
					if (!flag)
					{
						Dictionary<Type, CreateDelegateInfo> dictionary = hostBuilderState.delegateInfos;
						if (flag2)
						{
							Dictionary<Type, object> singletons2 = hostBuilderState.singletons;
							throw new NullReferenceException();
						}
					}
					else if (num3 != 0)
					{
					}
					int num4 = 0;
					if (flag3)
					{
						if (num2 == 0)
						{
							throw new InvalidCastException();
						}
						if (num2 != 0)
						{
							while (!flag4)
							{
							}
						}
					}
					if (num3 != 0)
					{
						break;
					}
					((List<T>)(object)list).Add((T)num3);
				}
				if (list3 != null)
				{
				}
				if (num3 == 0)
				{
					ITransport transport = (asyncServer.Transport = hostBuilderState.GetInstance<ITransport>());
					asyncServer.ownTransport = true;
					asyncServer.Processor = _003CProcessor_003Ek__BackingField;
					Dictionary<Type, object> singletons3 = hostBuilderState.singletons;
					host.Server = asyncServer;
					return host;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38DD860", Offset = "0x38DC260", VA = "0x1838DD860", Slot = "4")]
		protected override ServiceBuilder GetServiceBuilder(Type serviceType)
		{
			ServiceBuilder serviceBuilder = default(ServiceBuilder);
			serviceBuilder.hostBuilder = this;
			serviceBuilder.serviceType = serviceType;
			return serviceBuilder;
		}
	}
}
