using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class GameloftIdConnection : OpenIdConnection
	{
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public enum ErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			SUCCESS,
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			UNKNOWN,
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			NO_CONTENT,
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			INVALID_RESPONSE,
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			USER_EXISTS,
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			MISSING_EMAIL,
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			NOT_AUTHORIZED,
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			INVALID_CREDENTIALS,
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			USER_NOT_FOUND,
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			EXPIRED_CODE,
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			WRONG_CODE,
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			MAX_RESET_PASSWORD_ATTEMPTS_REACHED,
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			METHOD_NOT_ALLOWED,
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			UUID_UNAVAILABLE
		}

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static string ConnectionId = "GameloftID";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private bool isProd;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public override string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x102F350", Offset = "0x102DD50", VA = "0x18102F350", Slot = "4")]
			get
			{
				return ConnectionId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public override string ClientId
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x102F320", Offset = "0x102DD20", VA = "0x18102F320", Slot = "5")]
			get
			{
				return "ddv";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public override string BaseUri
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x102F2D0", Offset = "0x102DCD0", VA = "0x18102F2D0", Slot = "6")]
			get
			{
				string result = "https://id-beta.gameloft.com";
				if (isProd)
				{
					result = "https://id.gameloft.com";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x102EFB0", Offset = "0x102D9B0", VA = "0x18102EFB0", Slot = "7")]
		public override IOpenIdAPI CreateNewUserAPI()
		{
			OpenIdAPI<JsonContent> openIdAPI = (OpenIdAPI<JsonContent>)(object)new OpenIdAPI<T>();
			((OpenIdAPI<>)(object)openIdAPI).Name = "users/";
			((OpenIdAPI<>)(object)openIdAPI).ApplyFixedParams = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x102EF20", Offset = "0x102D920", VA = "0x18102EF20", Slot = "8")]
		public override IOpenIdAPI CreateConfirmEmailAPI()
		{
			((OpenIdAPI<>)(object)new OpenIdAPI<T>()).Name = "confirm-email";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x102EE80", Offset = "0x102D880", VA = "0x18102EE80", Slot = "9")]
		public override IOpenIdAPI CreateAuthorizationAPI()
		{
			OpenIdAPI<FormUrlContent> openIdAPI = (OpenIdAPI<FormUrlContent>)(object)new OpenIdAPI<T>();
			((OpenIdAPI<>)(object)openIdAPI).Name = "authorize";
			((OpenIdAPI<>)(object)openIdAPI).ApplyFixedParams = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x102F0E0", Offset = "0x102DAE0", VA = "0x18102F0E0", Slot = "10")]
		public override IOpenIdAPI CreateResetUserPasswordAPI()
		{
			OpenIdAPI<FormUrlContent> openIdAPI = (OpenIdAPI<FormUrlContent>)(object)new OpenIdAPI<T>();
			((OpenIdAPI<>)(object)openIdAPI).Name = "reset-password";
			((OpenIdAPI<>)(object)openIdAPI).ApplyFixedParams = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x102F050", Offset = "0x102DA50", VA = "0x18102F050", Slot = "11")]
		public override IOpenIdAPI CreateNewUserPasswordAPI()
		{
			((OpenIdAPI<>)(object)new OpenIdAPI<T>()).Name = "password";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x102F2A0", Offset = "0x102DCA0", VA = "0x18102F2A0")]
		public GameloftIdConnection(bool isProd)
		{
			this.isProd = isProd;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x102F180", Offset = "0x102DB80", VA = "0x18102F180")]
		public ErrorCode ParseErrorCode(string error)
		{
			//Discarded unreachable code: IL_001b
			if ((object)typeof(Enum).TypeHandle == null)
			{
				int num = default(int);
				int startIndex = num + 1;
				string text = error.Substring(startIndex);
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			return ErrorCode.UNKNOWN;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x102F250", Offset = "0x102DC50", VA = "0x18102F250")]
		static GameloftIdConnection()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
