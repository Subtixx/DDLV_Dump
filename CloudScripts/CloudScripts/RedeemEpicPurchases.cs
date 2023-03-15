using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public class RedeemEpicPurchases
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public PlayFabAuthenticationContext AuthContext
			{
				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthContext_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAuthContext_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public string PlayFabID
			{
				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public string TitleId
			{
				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CTitleId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CTitleId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public string Token
			{
				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			InvalidToken,
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			NoItemOwned,
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			NoItemToRedeem,
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			FailedToRetrieveBundles,
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			BundlesNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			GetTitleDataError,
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public RedeemMarketplaceAssetsResult PlayFabRedeemResult = new RedeemMarketplaceAssetsResult
			{
				Failed = (List<RedeemFailureLegacy>)(object)new List<T>(),
				Succeeded = (List<RedeemSuccessLegacy>)(object)new List<T>()
			};

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400049B")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			public string ErrorMessage
			{
				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CErrorMessage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CErrorMessage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public List<string> itemRedeemed
			{
				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CitemRedeemed_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CitemRedeemed_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x392F5F0", Offset = "0x392DFF0", VA = "0x18392F5F0")]
			public Result WithError(Error error)
			{
				int num = (int)(Error = error);
				List<string> list = (itemRedeemed = (List<string>)(object)new List<T>());
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x392FB50", Offset = "0x392E550", VA = "0x18392FB50")]
			public Result WithSecurityException(CryptographicException exception)
			{
				//Discarded unreachable code: IL_0019
				//IL_0009: Expected I4, but got I8
				Error = Error.InvalidToken;
				string text = (ErrorMessage = exception.Message);
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x392FA60", Offset = "0x392E460", VA = "0x18392FA60")]
			public Result WithRedeemedItems(IEnumerable<string> redeemedItems)
			{
				//IL_0009: Expected I4, but got I8
				Error = Error.Success;
				List<string> list = (itemRedeemed = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)redeemedItems));
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x392FBA0", Offset = "0x392E5A0", VA = "0x18392FBA0")]
			public Result()
			{
			}//Discarded unreachable code: IL_002e

		}

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static string TitleDataRedeemedCatalotIdsKey;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RedeemEpicPurchases()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1170A80", Offset = "0x116F480", VA = "0x181170A80")]
		static RedeemEpicPurchases()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
