using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class OpenIdRequestParameters : Dictionary<OpenIdParam.HttpRequestParameterType, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10355A0", Offset = "0x1033FA0", VA = "0x1810355A0")]
		public static implicit operator Dictionary<string, string>(OpenIdRequestParameters requestParams)
		{
			Func<KeyValuePair<OpenIdParam.HttpRequestParameterType, string>, string> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				string result = default(string);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<OpenIdParam.HttpRequestParameterType, string> x) => result);
			}
			Func<KeyValuePair<OpenIdParam.HttpRequestParameterType, string>, string> func = default(Func<KeyValuePair<OpenIdParam.HttpRequestParameterType, string>, string>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				func = (Func<KeyValuePair<OpenIdParam.HttpRequestParameterType, string>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			return (Dictionary<string, string>)(object)Enumerable.ToDictionary<KeyValuePair<OpenIdParam.HttpRequestParameterType, string>, string, string>((IEnumerable<>)requestParams, (Func<, >)(object)_003C_003E9__0_, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1035360", Offset = "0x1033D60", VA = "0x181035360")]
		public static OpenIdRequestParameters CreateLoginParameters(string email, string password)
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024, IL_002a, IL_0030, IL_0036, IL_003c, IL_0042, IL_0044
			OpenIdRequestParameters openIdRequestParameters = new OpenIdRequestParameters();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1035560", Offset = "0x1033F60", VA = "0x181035560")]
		public OpenIdRequestParameters()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}
}
