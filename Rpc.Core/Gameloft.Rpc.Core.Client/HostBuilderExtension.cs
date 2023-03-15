using System;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class HostBuilderExtension
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public delegate IClientAuthentication AuthenticationFunc();

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Transport TransportFunc(IClientAuthentication authentication);

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38DC0A0", Offset = "0x38DAAA0", VA = "0x1838DC0A0")]
		public unsafe static HostBuilder UseAuthentication(this HostBuilder builder, AuthenticationFunc authenticationFunc)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.authenticationFunc = authenticationFunc;
			CreateDelegate createDelegate = default(CreateDelegate);
			((Delegate)createDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass2_0._003CUseAuthentication_003Eb__0);
			((Delegate)createDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass2_0._003CUseAuthentication_003Eb__0);
			((Delegate)createDelegate).m_target = _003C_003Ec__DisplayClass2_;
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)builder).RegisterType<IClientAuthentication>(createDelegate);
			return builder;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x38DC370", Offset = "0x38DAD70", VA = "0x1838DC370")]
		public unsafe static HostBuilder UseTransport(this HostBuilder builder, TransportFunc transportFunc)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.transportFunc = transportFunc;
			CreateDelegate createDelegate = default(CreateDelegate);
			((Delegate)createDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass3_0._003CUseTransport_003Eb__0);
			((Delegate)createDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass3_0._003CUseTransport_003Eb__0);
			((Delegate)createDelegate).m_target = _003C_003Ec__DisplayClass3_;
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)builder).RegisterType<Transport>(createDelegate);
			return builder;
		}
	}
}
