using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class OpenIdParam
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		public enum HttpRequestParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			ClientId,
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			ResponseType,
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			State,
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			Scope,
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			Authorized,
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			Email,
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			Password,
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			RedirectUri,
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			Redirect,
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			TwoFactorAuth,
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			Nonce,
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			Code
		}

		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private static OpenIdRequestParameters parametersNames;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1035030", Offset = "0x1033A30", VA = "0x181035030")]
		public static string GetParamName(HttpRequestParameterType paramType)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public OpenIdParam()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10350E0", Offset = "0x1033AE0", VA = "0x1810350E0")]
		static OpenIdParam()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024, IL_002a, IL_0030, IL_0036, IL_003c, IL_0042, IL_0048, IL_004e
			OpenIdRequestParameters openIdRequestParameters = new OpenIdRequestParameters();
			throw new NullReferenceException();
		}
	}
}
