using System;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public static class PlayFabErrorExt
	{
		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public static PlayFabError UnknownError
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x103E1C0", Offset = "0x103CBC0", VA = "0x18103E1C0")]
			get
			{
				//Discarded unreachable code: IL_0011
				//IL_000f: Expected I4, but got I8
				PlayFabError playFabError = new PlayFabError();
				playFabError.Error = PlayFabErrorCode.Unknown;
				return playFabError;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x103DCD0", Offset = "0x103C6D0", VA = "0x18103DCD0")]
		public static bool IsWebError(this PlayFabError playFabError)
		{
			PlayFabErrorCode error = playFabError.Error;
			if (error > PlayFabErrorCode.ServiceUnavailable)
			{
				if (error == PlayFabErrorCode.DownstreamServiceUnavailable || error == PlayFabErrorCode.EconomyServiceUnavailable)
				{
					return true;
				}
			}
			else
			{
				while (error == PlayFabErrorCode.ConnectionError)
				{
				}
				while (error == PlayFabErrorCode.ServiceUnavailable)
				{
				}
			}
			int num = 0;
			if (playFabError != null)
			{
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x103DA60", Offset = "0x103C460", VA = "0x18103DA60")]
		public static string GetReadableError(this PlayFabError playFabError)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x103DD80", Offset = "0x103C780", VA = "0x18103DD80")]
		public static string ToGameLog(this PlayFabError playFabError)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
