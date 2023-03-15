using System;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class HostBuilderExtension
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public delegate IServerAuthentication AuthenticationFunc();

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate ITransport TransportFunc(IServerAuthentication authentication);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x38DC190", Offset = "0x38DAB90", VA = "0x1838DC190")]
		public unsafe static HostBuilder UseAuthentication(this HostBuilder builder, AuthenticationFunc authenticationFunc)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.authenticationFunc = authenticationFunc;
			CreateDelegate createDelegate = default(CreateDelegate);
			((Delegate)createDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass2_0._003CUseAuthentication_003Eb__0);
			((Delegate)createDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass2_0._003CUseAuthentication_003Eb__0);
			((Delegate)createDelegate).m_target = _003C_003Ec__DisplayClass2_;
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)builder).RegisterType<IServerAuthentication>(createDelegate);
			return builder;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x38DC280", Offset = "0x38DAC80", VA = "0x1838DC280")]
		public unsafe static HostBuilder UseTransport(this HostBuilder builder, TransportFunc transportFunc)
		{
			//Discarded unreachable code: IL_0035
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.transportFunc = transportFunc;
			CreateDelegate createDelegate = default(CreateDelegate);
			((Delegate)createDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass3_0._003CUseTransport_003Eb__0);
			((Delegate)createDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass3_0._003CUseTransport_003Eb__0);
			((Delegate)createDelegate).m_target = _003C_003Ec__DisplayClass3_;
			((HostBuilderBase<TServiceType, TServiceBuilderType>)(object)builder).RegisterType<ITransport>(createDelegate);
			return builder;
		}
	}
}
