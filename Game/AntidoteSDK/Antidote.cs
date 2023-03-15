using System;
using AOT;
using Cpp2IlInjected;

namespace AntidoteSDK
{
	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	public class Antidote
	{
		[Cpp2IlInjected.Token(Token = "0x20001E7")]
		public delegate void OnSessionValidated_(int isValid);

		[Cpp2IlInjected.Token(Token = "0x20001E8")]
		public delegate void OnSessionValidated(bool isValid);

		[Cpp2IlInjected.Token(Token = "0x40010F3")]
		private static OnSessionValidated m_callback;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA40230", Offset = "0xA3EC30", VA = "0x180A40230")]
		private static extern void Antidote_validateSession(OnSessionValidated_ callback);

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA402C0", Offset = "0xA3ECC0", VA = "0x180A402C0")]
		[MonoPInvokeCallback(typeof(OnSessionValidated_))]
		private static void SessionValidationCallback(int isValid)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA40320", Offset = "0xA3ED20", VA = "0x180A40320")]
		public unsafe static void ValidateSession(OnSessionValidated callback)
		{
			//IL_000c: Expected O, but got I4
			int num = default(int);
			OnSessionValidated_ onSessionValidated_ = new OnSessionValidated_(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, void>*/)(&SessionValidationCallback));
			num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Antidote()
		{
		}
	}
}
