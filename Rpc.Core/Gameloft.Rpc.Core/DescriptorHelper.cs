using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class DescriptorHelper
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x38DACF0", Offset = "0x38D96F0", VA = "0x1838DACF0")]
		public static ServiceDescriptor GetServiceDescriptor(this FileDescriptor fileDescriptor, string serviceName)
		{
			//Discarded unreachable code: IL_0029
			IList<ServiceDescriptor> _003CServices_003Ek__BackingField = fileDescriptor.Services;
			Func<ServiceDescriptor, bool> func = (Func<ServiceDescriptor, bool>)(object)(Func<T, TResult>)delegate(ServiceDescriptor x)
			{
				//Discarded unreachable code: IL_0016
				string name = x.Name;
				string b = serviceName;
				return string.Equals(name, b);
			};
			return Enumerable.FirstOrDefault<ServiceDescriptor>((IEnumerable<>)_003CServices_003Ek__BackingField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38DACD0", Offset = "0x38D96D0", VA = "0x1838DACD0")]
		public static MethodDescriptor GetMethodDescriptor(this ServiceDescriptor serviceDescriptor, string methodName)
		{
			//Discarded unreachable code: IL_0008
			return serviceDescriptor.FindMethodByName(methodName);
		}
	}
}
