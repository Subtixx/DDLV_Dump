using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Options;
using Definitions.Scene;
using Definitions.Shops;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Rpc.Core;
using glPlayFab;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Meta.ErrorReporting;
using Meta.Missions;
using Meta.Online.CRM;
using Meta.Social;
using Meta.Social.Ralph;
using Meta.Util;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E88")]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public class Client : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000E89")]
		public class PreGameLoadChainResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003B18")]
			public List<PreGameLoadResult> Results = (List<PreGameLoadResult>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x17001555")]
			public PreGameLoadResult First
			{
				[Cpp2IlInjected.Token(Token = "0x6007A98")]
				[Cpp2IlInjected.Address(RVA = "0x99B9A0", Offset = "0x99A3A0", VA = "0x18099B9A0")]
				get
				{
					return Enumerable.FirstOrDefault<PreGameLoadResult>((IEnumerable<>)Results);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001556")]
			public PreGameLoadResult Last
			{
				[Cpp2IlInjected.Token(Token = "0x6007A99")]
				[Cpp2IlInjected.Address(RVA = "0x99BB10", Offset = "0x99A510", VA = "0x18099BB10")]
				get
				{
					return Enumerable.LastOrDefault<PreGameLoadResult>((IEnumerable<>)Results);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001557")]
			public PreGameLoadResult LastSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x6007A9A")]
				[Cpp2IlInjected.Address(RVA = "0x99B9E0", Offset = "0x99A3E0", VA = "0x18099B9E0")]
				get
				{
					//Discarded unreachable code: IL_002e
					List<PreGameLoadResult> results = Results;
					Predicate<PreGameLoadResult> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
					if (_003C_003E9__5_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((PreGameLoadResult x) => default(bool));
					}
					return (PreGameLoadResult)((List<T>)(object)results).FindLast((Predicate<>)(object)_003C_003E9__5_);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001558")]
			public int PreviousOnlineVersion
			{
				[Cpp2IlInjected.Token(Token = "0x6007A9B")]
				[Cpp2IlInjected.Address(RVA = "0x99BB50", Offset = "0x99A550", VA = "0x18099BB50")]
				get
				{
					return Enumerable.FirstOrDefault<PreGameLoadResult>((IEnumerable<>)Results)?.OriginalOnlineVersion ?? InvalidOnlineVersion;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001559")]
			public int UpdatedOnlineVersion
			{
				[Cpp2IlInjected.Token(Token = "0x6007A9C")]
				[Cpp2IlInjected.Address(RVA = "0x99BBF0", Offset = "0x99A5F0", VA = "0x18099BBF0")]
				get
				{
					//Discarded unreachable code: IL_003f
					List<PreGameLoadResult> results = Results;
					Predicate<PreGameLoadResult> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
					if (_003C_003E9__5_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((PreGameLoadResult x) => default(bool));
					}
					return ((PreGameLoadResult)((List<T>)(object)results).FindLast((Predicate<>)(object)_003C_003E9__5_))?.UpdatedOnlineVersion ?? InvalidOnlineVersion;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007A9D")]
			[Cpp2IlInjected.Address(RVA = "0x99B920", Offset = "0x99A320", VA = "0x18099B920")]
			public PreGameLoadChainResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E8B")]
		public class PreGameLoadResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000E8C")]
			public enum ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x4003B22")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4003B23")]
				ProfileAlreadyLoaded,
				[Cpp2IlInjected.Token(Token = "0x4003B24")]
				LocalMiniProfileNotFound,
				[Cpp2IlInjected.Token(Token = "0x4003B25")]
				NotFullOnline,
				[Cpp2IlInjected.Token(Token = "0x4003B26")]
				HandshakeCallFailed,
				[Cpp2IlInjected.Token(Token = "0x4003B27")]
				HandshakeImplFailed,
				[Cpp2IlInjected.Token(Token = "0x4003B28")]
				FailedCachingFile,
				[Cpp2IlInjected.Token(Token = "0x4003B29")]
				FailedFindingAllRequestedData,
				[Cpp2IlInjected.Token(Token = "0x4003B2A")]
				SendRequestedDataCallFailed,
				[Cpp2IlInjected.Token(Token = "0x4003B2B")]
				SendRequestedDataImplFailed,
				[Cpp2IlInjected.Token(Token = "0x4003B2C")]
				FailedToApplyAllFixes,
				[Cpp2IlInjected.Token(Token = "0x4003B2D")]
				FailedToApplyOnlineVersionToProfile,
				[Cpp2IlInjected.Token(Token = "0x4003B2E")]
				CommitToFileFailed,
				[Cpp2IlInjected.Token(Token = "0x4003B2F")]
				WithException
			}

			[Cpp2IlInjected.Token(Token = "0x2000E8D")]
			public enum SuccessStatusCode
			{
				[Cpp2IlInjected.Token(Token = "0x4003B31")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x4003B32")]
				AlreadyUptoDate,
				[Cpp2IlInjected.Token(Token = "0x4003B33")]
				NoUpdateRequiringApply,
				[Cpp2IlInjected.Token(Token = "0x4003B34")]
				Updated
			}

			[Cpp2IlInjected.Token(Token = "0x2000E8E")]
			public class TokenNotFoundError
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003B35")]
				public string filename;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003B36")]
				public string token;

				[Cpp2IlInjected.Token(Token = "0x6007AA5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public TokenNotFoundError()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003B1B")]
			public List<TokenNotFoundError> SearchTokenNotFound;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003B1C")]
			public int OriginalOnlineVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4003B1D")]
			public int UpdatedOnlineVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003B1E")]
			public int MaxOnlineVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4003B1F")]
			public ErrorCode Error;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003B20")]
			public SuccessStatusCode SuccessStatus;

			[Cpp2IlInjected.Token(Token = "0x6007AA1")]
			[Cpp2IlInjected.Address(RVA = "0x99BD80", Offset = "0x99A780", VA = "0x18099BD80")]
			public PreGameLoadResult WithError(ErrorCode error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AA2")]
			[Cpp2IlInjected.Address(RVA = "0x99BE60", Offset = "0x99A860", VA = "0x18099BE60")]
			public PreGameLoadResult WithSuccess(SuccessStatusCode success)
			{
				//IL_0010: Expected I4, but got I8
				SuccessStatus = success;
				Error = ErrorCode.Success;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AA3")]
			[Cpp2IlInjected.Address(RVA = "0x99BD90", Offset = "0x99A790", VA = "0x18099BD90")]
			public PreGameLoadResult WithSearchTokenNotFound(TokenNotFoundError token, ErrorCode error)
			{
				//Discarded unreachable code: IL_002a
				List<TokenNotFoundError> searchTokenNotFound = SearchTokenNotFound;
				if (searchTokenNotFound == null)
				{
					List<TokenNotFoundError> list = (SearchTokenNotFound = (List<TokenNotFoundError>)(object)new List<T>());
				}
				((List<T>)(object)searchTokenNotFound).Add((T)token);
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AA4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PreGameLoadResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E8F")]
		private class CachedFileUpdater
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003B37")]
			public string filename;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003B38")]
			public bool canBeEncrypted;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003B39")]
			private string jsonStr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003B3A")]
			private JToken jsonTokenFileRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4003B3E")]
			private ProfileUtil.TryDecryptResult fileDecryptResult;

			[Cpp2IlInjected.Token(Token = "0x1700155A")]
			private static IFileSystem fs
			{
				[Cpp2IlInjected.Token(Token = "0x6007AA6")]
				[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
				get
				{
					return FileSystem.Save;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700155B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003B3B")]
			public bool WasModified
			{
				[Cpp2IlInjected.Token(Token = "0x6007AA7")]
				[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007AA8")]
				[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700155C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x31"), Cpp2IlInjected.Token(Token = "0x4003B3C")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6007AA9")]
				[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007AAA")]
				[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700155D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x32"), Cpp2IlInjected.Token(Token = "0x4003B3D")]
			public bool IsPlayerProfile
			{
				[Cpp2IlInjected.Token(Token = "0x6007AAB")]
				[Cpp2IlInjected.Address(RVA = "0x997D80", Offset = "0x996780", VA = "0x180997D80")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007AAC")]
				[Cpp2IlInjected.Address(RVA = "0x997DB0", Offset = "0x9967B0", VA = "0x180997DB0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700155E")]
			public bool WasEncrypted
			{
				[Cpp2IlInjected.Token(Token = "0x6007AAD")]
				[Cpp2IlInjected.Address(RVA = "0x997DA0", Offset = "0x9967A0", VA = "0x180997DA0")]
				get
				{
					ProfileUtil.TryDecryptResult tryDecryptResult;
					do
					{
						tryDecryptResult = fileDecryptResult;
					}
					while (tryDecryptResult == null);
					return tryDecryptResult.WasEncrypted;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007AAE")]
			[Cpp2IlInjected.Address(RVA = "0x997CA0", Offset = "0x9966A0", VA = "0x180997CA0")]
			public CachedFileUpdater(string filename, bool canBeEncrypted, bool isPlayerProfile)
			{
				//Discarded unreachable code: IL_0035
				//IL_0026: Expected I4, but got O
				this.filename = filename;
				if ((object)typeof(IReadOnlyFileSystem).TypeHandle != null)
				{
				}
				IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
				IsValid = (byte)(int)typeof(FileSystem).TypeHandle != 0;
				IsPlayerProfile = isPlayerProfile;
				this.canBeEncrypted = canBeEncrypted;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AAF")]
			[Cpp2IlInjected.Address(RVA = "0x9976A0", Offset = "0x9960A0", VA = "0x1809976A0")]
			public bool LoadJsonFile()
			{
				//Discarded unreachable code: IL_005f
				//IL_0034: Expected I4, but got O
				if (IsValid)
				{
					if (!canBeEncrypted)
					{
						IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
						string path = filename;
						string text = (jsonStr = _003CSave_003Ek__BackingField.ReadAllText(path));
						return (byte)(int)typeof(Serilog.ILogger).TypeHandle != 0;
					}
					IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
					string path2 = filename;
					byte[] array = _003CSave_003Ek__BackingField2.ReadAllBytes(path2);
					ProfileUtil.TryDecryptResult tryDecryptResult = default(ProfileUtil.TryDecryptResult);
					return tryDecryptResult.Success;
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007AB0")]
			[Cpp2IlInjected.Address(RVA = "0x997930", Offset = "0x996330", VA = "0x180997930")]
			public bool Parse()
			{
				//Discarded unreachable code: IL_0041
				while (IsValid)
				{
					if ((object)typeof(JToken).TypeHandle == null)
					{
						bool flag = LoadJsonFile();
						if (!string.IsNullOrEmpty(jsonStr))
						{
							JToken jToken = (jsonTokenFileRoot = JToken.Parse(jsonStr));
						}
						break;
					}
				}
				return 0 != 0;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AB1")]
			[Cpp2IlInjected.Address(RVA = "0x997680", Offset = "0x996080", VA = "0x180997680")]
			public JToken FindToken(string searchToken)
			{
				if (IsValid)
				{
					JToken jToken = jsonTokenFileRoot;
					if (jToken != null && searchToken != null)
					{
						return jToken.SelectToken(searchToken);
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AB2")]
			[Cpp2IlInjected.Address(RVA = "0x997A90", Offset = "0x996490", VA = "0x180997A90")]
			public bool SetTokenData(string searchToken, JToken obj)
			{
				if (obj != null && IsValid)
				{
					JToken jToken = jsonTokenFileRoot;
					if (jToken != null && searchToken != null)
					{
						JToken jToken2 = jToken.SelectToken(searchToken);
						if (jToken2 != null)
						{
							WasModified = true;
							if (jToken2 != jsonTokenFileRoot)
							{
								jToken2.Replace(obj);
								return true;
							}
							jsonTokenFileRoot = obj;
							return true;
						}
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AB3")]
			[Cpp2IlInjected.Address(RVA = "0x997420", Offset = "0x995E20", VA = "0x180997420")]
			public bool CommitChangeToFile()
			{
				//Discarded unreachable code: IL_0089
				if (WasModified)
				{
					if (!IsPlayerProfile)
					{
						string data = jsonTokenFileRoot.ToString();
						string profilePath = filename;
						ProfileUtil.TryDecryptResult tryDecryptResult = fileDecryptResult;
						IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
						if (tryDecryptResult != null)
						{
						}
						int encrypt = 0;
						return ProfileUtil.SaveFileWithEncryption(_003CSave_003Ek__BackingField, profilePath, data, (byte)encrypt != 0);
					}
					int num = 0;
					bool isPrettyJson = LocalProfileHolder.IsPrettyJson;
					JToken jToken = jsonTokenFileRoot;
					string profilePath2 = filename;
					ProfileUtil.TryDecryptResult tryDecryptResult2 = fileDecryptResult;
					IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
					if (tryDecryptResult2 != null)
					{
					}
					int encrypt2 = 0;
					string data2 = default(string);
					bool flag = ProfileUtil.SaveProfileWithEncryption(_003CSave_003Ek__BackingField2, profilePath2, data2, (byte)encrypt2 != 0);
				}
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AB4")]
			[Cpp2IlInjected.Address(RVA = "0x997B30", Offset = "0x996530", VA = "0x180997B30")]
			public bool TryUpdateOnlineVersion(int onlineVersion)
			{
				//Discarded unreachable code: IL_004a, IL_0050, IL_0056
				if (IsPlayerProfile)
				{
					JToken jToken = JToken.FromObject("GameInfo");
					JToken jToken2 = jsonTokenFileRoot["GameInfo"]!["OnlineVersion"];
					if (jToken2 != jToken)
					{
						JToken value = onlineVersion;
						jToken2.Replace(value);
						WasModified = true;
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000E90")]
		public delegate void RemoteTransactionError(string errorKey, UserChoice<RemoteTransactionErrorOption> userChoice);

		[Cpp2IlInjected.Token(Token = "0x2000E91")]
		public delegate void DebugError(string errorMessage, UserChoice<DebugErrorOption> userChoice);

		[Cpp2IlInjected.Token(Token = "0x2000E92")]
		public delegate void DebugMessage(string title, string message, Exception e, bool allowClose, IEnumerable<OptionWithCallback> options);

		[Cpp2IlInjected.Token(Token = "0x2000E93")]
		public delegate void DebugPrompt(string title, string subtitle, string message, bool allowClose, IEnumerable<OptionWithCallback> options);

		[Cpp2IlInjected.Token(Token = "0x2000E94")]
		public delegate Task GenericMessage(string title, string subtitle, string message, bool isSystem, Exception e, bool allowClose, IEnumerable<OptionWithCallback> options);

		[Cpp2IlInjected.Token(Token = "0x2000E95")]
		public delegate void InfoMessage(string message);

		[Cpp2IlInjected.Token(Token = "0x2000E96")]
		public delegate Task OnlineValidationFailure(Action selectionCallback, ClientSession.ValidationResult validationResult, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000E97")]
		public delegate Task GameInitializationErrorDetected(Action selectionCallback, GameInitializationError profileLoadingError, string debugMessage, Exception e, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000E98")]
		public delegate Task OnUserCredentialInitCB(Action<string, FailureFallback> userCredentialInitCompleted);

		[Cpp2IlInjected.Token(Token = "0x2000E99")]
		public delegate void OnUserCredentialSetupCompletedCB();

		[Cpp2IlInjected.Token(Token = "0x2000E9A")]
		public delegate bool SoftReset();

		[Cpp2IlInjected.Token(Token = "0x2000E9B")]
		public delegate bool ForceQuit();

		[Cpp2IlInjected.Token(Token = "0x2000E9C")]
		public delegate Task<bool> InventoryFullFlowDelegate(IInventoryFullRequest request, IInventoryFullResponse response);

		[Cpp2IlInjected.Token(Token = "0x2000E9D")]
		public delegate void InitialLoginCompleted(Profile profile, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000E9E")]
		public delegate void StartUpHandler(Profile profile, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000E9F")]
		public class ProfileMeta
		{
			[Cpp2IlInjected.Token(Token = "0x1700155F")]
			public string DeviceId
			{
				[Cpp2IlInjected.Token(Token = "0x6007AF1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007AF2")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CDeviceId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001560")]
			public string CustomId
			{
				[Cpp2IlInjected.Token(Token = "0x6007AF3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCustomId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007AF4")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCustomId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001561")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003B41")]
			public DateTime LastModified
			{
				[Cpp2IlInjected.Token(Token = "0x6007AF5")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007AF6")]
				[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001562")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003B42")]
			public ulong TransactionId
			{
				[Cpp2IlInjected.Token(Token = "0x6007AF7")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007AF8")]
				[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007AF9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ProfileMeta()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000EA0")]
		public enum GameInitializationError
		{
			[Cpp2IlInjected.Token(Token = "0x4003B44")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003B45")]
			ProfileLoadError_Parsing,
			[Cpp2IlInjected.Token(Token = "0x4003B46")]
			ProfileLoadError_BinaryParsing,
			[Cpp2IlInjected.Token(Token = "0x4003B47")]
			ProfileLoadError_VersionMismatch,
			[Cpp2IlInjected.Token(Token = "0x4003B48")]
			ProfileLoadError_ProfileMissingData,
			[Cpp2IlInjected.Token(Token = "0x4003B49")]
			ProfileLoadError_Decrypt,
			[Cpp2IlInjected.Token(Token = "0x4003B4A")]
			ProfileLoadError_Unknown,
			[Cpp2IlInjected.Token(Token = "0x4003B4B")]
			ProfileInitError_Initialization,
			[Cpp2IlInjected.Token(Token = "0x4003B4C")]
			ProfileInitError_Actualization,
			[Cpp2IlInjected.Token(Token = "0x4003B4D")]
			ProfileInitError_Unknown,
			[Cpp2IlInjected.Token(Token = "0x4003B4E")]
			EnterVillageException
		}

		[Cpp2IlInjected.Token(Token = "0x2000EA1")]
		public enum FailureFallback
		{
			[Cpp2IlInjected.Token(Token = "0x4003B50")]
			TryToContinue,
			[Cpp2IlInjected.Token(Token = "0x4003B51")]
			AskRetry,
			[Cpp2IlInjected.Token(Token = "0x4003B52")]
			AskRetryOrContinue,
			[Cpp2IlInjected.Token(Token = "0x4003B53")]
			AskRestartApp
		}

		[Cpp2IlInjected.Token(Token = "0x2000EA2")]
		public class ClientTransactionContext : ITransactionContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003B54")]
			private readonly Client client;

			[Cpp2IlInjected.Token(Token = "0x17001563")]
			public unsafe DateTime Now
			{
				[Cpp2IlInjected.Token(Token = "0x6007AFA")]
				[Cpp2IlInjected.Address(RVA = "0x997F10", Offset = "0x996910", VA = "0x180997F10", Slot = "4")]
				get
				{
					//Discarded unreachable code: IL_003e
					//IL_003d: Expected O, but got I4
					int num;
					Profile profile;
					do
					{
						DateTime? dateTime = UtcNowOverride;
						num = 0;
						bool flag = SystemExtensions.TryGetValue<DateTime>((Nullable<>)dateTime, ref *(DateTime*)num);
						Client client = this.client;
						if (!flag)
						{
							return client.ServerTime;
						}
						profile = client.profile;
					}
					while (profile == null);
					return ServerUtil.NowUtc(profile.player_, (DateTime)num);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001564")]
			public unsafe DateTime LocalNow
			{
				[Cpp2IlInjected.Token(Token = "0x6007AFB")]
				[Cpp2IlInjected.Address(RVA = "0x997DD0", Offset = "0x9967D0", VA = "0x180997DD0", Slot = "5")]
				get
				{
					//Discarded unreachable code: IL_006b
					//IL_0052: Expected O, but got I4
					int num;
					Profile profile;
					do
					{
						if ((object)typeof(DateTime).TypeHandle == null)
						{
							return this.client.LocalTime;
						}
						DateTime? dateTime = UtcNowOverride;
						num = 0;
						bool flag = SystemExtensions.TryGetValue<DateTime>((Nullable<>)dateTime, ref *(DateTime*)num);
						Client client = this.client;
						if (!flag)
						{
							DateTime serverTime = client.ServerTime;
						}
						profile = client.profile;
					}
					while (profile == null);
					DateTime dateTime2 = ServerUtil.NowUtc(profile.player_, (DateTime)num);
					TimeSpan timeZoneOffset = this.client.TimeZoneOffset;
					return dateTime2 + timeZoneOffset;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001565")]
			public bool IsServer
			{
				[Cpp2IlInjected.Token(Token = "0x6007AFC")]
				[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001566")]
			internal DateTime? UtcNowOverride
			{
				[Cpp2IlInjected.Token(Token = "0x6007AFD")]
				[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x6007AFE")]
				[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9969C0", VA = "0x180997FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007AFF")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public ClientTransactionContext(Client client)
			{
				this.client = client;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000EA3")]
		public class ThreadMarker
		{
			[Cpp2IlInjected.Token(Token = "0x17001567")]
			public string Id
			{
				[Cpp2IlInjected.Token(Token = "0x6007B00")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007B01")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001568")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003B57")]
			public int Idx
			{
				[Cpp2IlInjected.Token(Token = "0x6007B02")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007B03")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001569")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4003B58")]
			public bool Cancel
			{
				[Cpp2IlInjected.Token(Token = "0x6007B04")]
				[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007B05")]
				[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007B06")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ThreadMarker()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003ADC")]
		private PreGameLoadChainResult LastPreGameLoadChainResult = new PreGameLoadChainResult();

		[Cpp2IlInjected.Token(Token = "0x4003ADD")]
		public static readonly int InvalidOnlineVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003ADE")]
		private int nextRequestId;

		[Cpp2IlInjected.Token(Token = "0x4003ADF")]
		public const string MetadataCrcBefore = "ClientCrcBefore";

		[Cpp2IlInjected.Token(Token = "0x4003AE0")]
		public const string MetadataBeforeProfileString = "ClientProfileBefore";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003AEF")]
		private Task OnlineLoginTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003AF3")]
		private string localUserId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003AF6")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003AF7")]
		private CancellationTokenSource _profileCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003AFB")]
		private Dictionary<uint, CancellationTokenSource> recurringEventCTS = (Dictionary<uint, CancellationTokenSource>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003B02")]
		public readonly IKeyChain Keychain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003B06")]
		private Simulator<TransactionServiceServerImpl, TransactionService.TransactionServiceClient> simulator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003B07")]
		private Simulator<SocialServiceServer, SocialService.SocialServiceClient> socialSimulator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003B09")]
		private DisposableList disposableList = new DisposableList();

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003B0B")]
		private LimitedAction GetNewsFeedLimitedAction = new LimitedAction();

		[Cpp2IlInjected.Token(Token = "0x4003B0D")]
		private const string testProfileDirPath = "test_profiles";

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003B0F")]
		private bool blockRecurringEventReschedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4003B10")]
		private bool IsDelayingProfileWrite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003B12")]
		private Dictionary<string, CancellationTokenSource> ctsBattlePassUpdates = (Dictionary<string, CancellationTokenSource>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4003B14")]
		private static TimedCachedValue<CreateNewsFeed.Types.Response> NewsFeedCache;

		[Cpp2IlInjected.Token(Token = "0x4003B15")]
		private static TimedCachedValue<GetUserPosts.Types.Response> MyPostsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003B16")]
		private List<NewsFeedPost> postedPictures = (List<NewsFeedPost>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4003B17")]
		private static TimedCachedValue<SuggestFollower.Types.Response> SuggestFollowerCache;

		[Cpp2IlInjected.Token(Token = "0x17001523")]
		public ClientNetworkData NetworkData
		{
			[Cpp2IlInjected.Token(Token = "0x600791C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CNetworkData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600791D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CNetworkData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new ClientNetworkData
		{
			LocalPlayerId = 0
		};


		[Cpp2IlInjected.Token(Token = "0x17001524")]
		private PreGameLoadResult LastPreGameLoadResult
		{
			[Cpp2IlInjected.Token(Token = "0x600791F")]
			[Cpp2IlInjected.Address(RVA = "0x738E90", Offset = "0x737890", VA = "0x180738E90")]
			get
			{
				//Discarded unreachable code: IL_000c
				return LastPreGameLoadChainResult.Last;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001525")]
		public bool HasSuccessfulyUpdateOnlineVersionInThisSession
		{
			[Cpp2IlInjected.Token(Token = "0x6007920")]
			[Cpp2IlInjected.Address(RVA = "0x738C90", Offset = "0x737690", VA = "0x180738C90")]
			get
			{
				if (LastPreGameLoadChainResult.Last != null && LastPreGameLoadChainResult.Last.Error == PreGameLoadResult.ErrorCode.Success && LastPreGameLoadChainResult.Last.SuccessStatus == PreGameLoadResult.SuccessStatusCode.Updated)
				{
					int previousOnlineVersion = LastPreGameLoadChainResult.PreviousOnlineVersion;
					return (IntPtr)LastPreGameLoadChainResult.UpdatedOnlineVersion != (IntPtr)"{il2cpp field on {'constant29' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}";
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001526")]
		public int PreviousOnlineVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6007921")]
			[Cpp2IlInjected.Address(RVA = "0x738F70", Offset = "0x737970", VA = "0x180738F70")]
			get
			{
				//Discarded unreachable code: IL_000c
				return LastPreGameLoadChainResult.PreviousOnlineVersion;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001527")]
		public int UpdatedOnlineVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6007922")]
			[Cpp2IlInjected.Address(RVA = "0x739420", Offset = "0x737E20", VA = "0x180739420")]
			get
			{
				//Discarded unreachable code: IL_000c
				return LastPreGameLoadChainResult.UpdatedOnlineVersion;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001528")]
		public string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600799D")]
			[Cpp2IlInjected.Address(RVA = "0x738A10", Offset = "0x737410", VA = "0x180738A10")]
			get
			{
				//Discarded unreachable code: IL_0031
				string gameCustomID = CredentialProvider.GameCustomID;
				OnlineClient onlineClient = OnlineClient;
				if (onlineClient == null || onlineClient.EntityId == null)
				{
				}
				return gameCustomID + " ## " + "[unset]";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001529")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003AE1")]
		internal Serilog.ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x600799E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700152A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003AE2")]
		public IUnityContext UnityContext
		{
			[Cpp2IlInjected.Token(Token = "0x600799F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700152B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4003AE3")]
		public IErrorReporter ErrorReporter
		{
			[Cpp2IlInjected.Token(Token = "0x60079A0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700152C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4003AE4")]
		public INativeNetworkManager NativeNetworkManager
		{
			[Cpp2IlInjected.Token(Token = "0x60079A1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700152D")]
		public IFileSystem SaveFS
		{
			[Cpp2IlInjected.Token(Token = "0x60079C4")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152E")]
		public IFileSystem TempFS
		{
			[Cpp2IlInjected.Token(Token = "0x60079C5")]
			[Cpp2IlInjected.Address(RVA = "0x739290", Offset = "0x737C90", VA = "0x180739290")]
			get
			{
				return FileSystem.Temp;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700152F")]
		public IFileSystem GlobalSaveFS
		{
			[Cpp2IlInjected.Token(Token = "0x60079C6")]
			[Cpp2IlInjected.Address(RVA = "0x738C50", Offset = "0x737650", VA = "0x180738C50")]
			get
			{
				return FileSystem.SaveGlobal;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001530")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC0"), Cpp2IlInjected.Token(Token = "0x4003AF4")]
		private bool AutoLogin
		{
			[Cpp2IlInjected.Token(Token = "0x60079C7")]
			[Cpp2IlInjected.Address(RVA = "0x7389C0", Offset = "0x7373C0", VA = "0x1807389C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60079C8")]
			[Cpp2IlInjected.Address(RVA = "0x739E30", Offset = "0x738830", VA = "0x180739E30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001531")]
		[field: Cpp2IlInjected.Token(Token = "0x4003AF5")]
		public static bool UseDebugErrors
		{
			[Cpp2IlInjected.Token(Token = "0x60079C9")]
			[Cpp2IlInjected.Address(RVA = "0x739440", Offset = "0x737E40", VA = "0x180739440")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60079CA")]
			[Cpp2IlInjected.Address(RVA = "0x73A370", Offset = "0x738D70", VA = "0x18073A370")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001532")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x60079CB")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return profile;
			}
			[Cpp2IlInjected.Token(Token = "0x60079CC")]
			[Cpp2IlInjected.Address(RVA = "0x739EC0", Offset = "0x7388C0", VA = "0x180739EC0")]
			private set
			{
				//Discarded unreachable code: IL_0089
				//IL_001d: Expected O, but got I4
				//IL_0053: Expected I4, but got I8
				if (this.profile != value)
				{
					int num = 0;
					if ((object)typeof(MoreAsync).TypeHandle != null)
					{
						_profileCTS = (CancellationTokenSource)num;
					}
					this.profile = value;
					Profile profile = this.profile;
					if (profile != null)
					{
						ClientTransactionContext context = TransactionContext;
						ProfileEventDispatcher dispatcher = Dispatcher;
						profile.Initialize(dispatcher, context);
						this.profile.ProfileLocation = Profile.Location.Client;
						CancellationTokenSource cancellationTokenSource = (_profileCTS = new CancellationTokenSource());
						CancellationToken ct = default(CancellationToken);
						WaitForRecurringEvents(ct);
						int num2 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
						int num3 = 0;
						Task asyncTask2 = default(Task);
						asyncTask2.FireAndForgetTask();
						int num4 = 0;
						Task asyncTask3 = default(Task);
						asyncTask3.FireAndForgetTask();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001533")]
		public LoadAndInitProfileResult LastLocalLoadProfileResult
		{
			[Cpp2IlInjected.Token(Token = "0x60079CD")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			[CompilerGenerated]
			get
			{
				return _003CLastLocalLoadProfileResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079CE")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			[CompilerGenerated]
			private set
			{
				_003CLastLocalLoadProfileResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001534")]
		public TimeSpan TimeZoneOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60079CF")]
			[Cpp2IlInjected.Address(RVA = "0x7392D0", Offset = "0x737CD0", VA = "0x1807392D0")]
			get
			{
				Profile profile = this.profile;
				if (profile != null)
				{
					ProfileWorld world_ = profile.world_;
					if (world_ != null)
					{
						Google.Protobuf.WellKnownTypes.Duration timeZoneOffset_ = world_.timeZoneOffset_;
						if (timeZoneOffset_ != null)
						{
							TimeSpan timeSpan = timeZoneOffset_.ToTimeSpan();
							int num = 0;
						}
					}
				}
				int num2 = 0;
				return TimeSpan.Zero;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001535")]
		public DateTime LocalTime
		{
			[Cpp2IlInjected.Token(Token = "0x60079D0")]
			[Cpp2IlInjected.Address(RVA = "0x738ED0", Offset = "0x7378D0", VA = "0x180738ED0")]
			get
			{
				//IL_000f: Expected O, but got I4
				if (profile != null)
				{
				}
				DateTime dateTime = ServerUtil.NowUtc((ProfilePlayer)0);
				TimeSpan timeZoneOffset = TimeZoneOffset;
				return dateTime + timeZoneOffset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001536")]
		public DateTime ServerTime
		{
			[Cpp2IlInjected.Token(Token = "0x60079D1")]
			[Cpp2IlInjected.Address(RVA = "0x7359C0", Offset = "0x7343C0", VA = "0x1807359C0")]
			get
			{
				Profile profile = this.profile;
				if (profile != null)
				{
					return ServerUtil.NowUtc(profile.player_);
				}
				DateTime result = default(DateTime);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001537")]
		public DateTime ServerTimeOnline
		{
			[Cpp2IlInjected.Token(Token = "0x60079D2")]
			[Cpp2IlInjected.Address(RVA = "0x738FF0", Offset = "0x7379F0", VA = "0x180738FF0")]
			get
			{
				//Discarded unreachable code: IL_0041
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				Profile profile = this.profile;
				if (profile != null)
				{
					Google.Protobuf.WellKnownTypes.Duration debugTimeSkippedOnline_ = profile.player_.debugTimeSkippedOnline_;
					if (debugTimeSkippedOnline_ != null)
					{
						TimeSpan timeSpan = debugTimeSkippedOnline_.ToTimeSpan();
						int num2 = 0;
					}
				}
				int num3 = 0;
				TimeSpan zero = TimeSpan.Zero;
				return utcNow + zero;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001538")]
		public DateTime GamePortalTime
		{
			[Cpp2IlInjected.Token(Token = "0x60079D3")]
			[Cpp2IlInjected.Address(RVA = "0x738AE0", Offset = "0x7374E0", VA = "0x180738AE0")]
			get
			{
				//Discarded unreachable code: IL_0034
				//IL_0015: Expected O, but got I4
				int num = 0;
				if (DebugSettings.Settings.cloudFunctionMode_ == CloudFunctionMode.Embed)
				{
					PlayFabSysHttp orCreatePlayfabSysHTTP = PlayFabSysHttp.GetOrCreatePlayfabSysHTTP((Serilog.ILogger)0);
					if (orCreatePlayfabSysHTTP != null)
					{
						ICloudScriptExecutor cloudScriptExecutor = orCreatePlayfabSysHTTP.cloudScriptExecutor;
						if (cloudScriptExecutor != null)
						{
							int num2 = 0;
							if (cloudScriptExecutor == null)
							{
							}
						}
					}
				}
				int num3 = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001539")]
		public TransactionService.TransactionServiceClient TransactionService
		{
			[Cpp2IlInjected.Token(Token = "0x60079D4")]
			[Cpp2IlInjected.Address(RVA = "0x7393D0", Offset = "0x737DD0", VA = "0x1807393D0")]
			get
			{
				Simulator<TransactionServiceServerImpl, TransactionService.TransactionServiceClient> simulator = this.simulator;
				if (simulator != null)
				{
					return (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700153A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xE0"), Cpp2IlInjected.Token(Token = "0x4003AF9")]
		public ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x60079D5")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get;
		} = new ProfileEventDispatcher();


		[Cpp2IlInjected.Token(Token = "0x1700153B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xE8"), Cpp2IlInjected.Token(Token = "0x4003AFA")]
		public ClientTransactionContext TransactionContext
		{
			[Cpp2IlInjected.Token(Token = "0x60079D6")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700153C")]
		public Clock Clock
		{
			[Cpp2IlInjected.Token(Token = "0x60079D7")]
			[Cpp2IlInjected.Address(RVA = "0x7389F0", Offset = "0x7373F0", VA = "0x1807389F0")]
			[CompilerGenerated]
			get
			{
				return _003CClock_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079D8")]
			[Cpp2IlInjected.Address(RVA = "0x739E50", Offset = "0x738850", VA = "0x180739E50")]
			[CompilerGenerated]
			private set
			{
				_003CClock_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700153D")]
		public Clock ClockOnline
		{
			[Cpp2IlInjected.Token(Token = "0x60079D9")]
			[Cpp2IlInjected.Address(RVA = "0x7389E0", Offset = "0x7373E0", VA = "0x1807389E0")]
			[CompilerGenerated]
			get
			{
				return _003CClockOnline_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079DA")]
			[Cpp2IlInjected.Address(RVA = "0x739E40", Offset = "0x738840", VA = "0x180739E40")]
			[CompilerGenerated]
			private set
			{
				_003CClockOnline_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700153E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x108"), Cpp2IlInjected.Token(Token = "0x4003AFE")]
		public DeviceInfo DeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60079DB")]
			[Cpp2IlInjected.Address(RVA = "0x738AB0", Offset = "0x7374B0", VA = "0x180738AB0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700153F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x110"), Cpp2IlInjected.Token(Token = "0x4003AFF")]
		public ClientConfig ClientConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60079DC")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001540")]
		public Gameloft.Common.Version GameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60079DD")]
			[Cpp2IlInjected.Address(RVA = "0x738C20", Offset = "0x737620", VA = "0x180738C20")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001541")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x148"), Cpp2IlInjected.Token(Token = "0x4003B01")]
		public OnlineClient OnlineClient
		{
			[Cpp2IlInjected.Token(Token = "0x60079DE")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001542")]
		private ClientSession clientSession
		{
			[Cpp2IlInjected.Token(Token = "0x60079DF")]
			[Cpp2IlInjected.Address(RVA = "0x7394A0", Offset = "0x737EA0", VA = "0x1807394A0")]
			get
			{
				OnlineClient onlineClient = OnlineClient;
				if (onlineClient != null)
				{
					return onlineClient.ClientSession;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001543")]
		public HttpClientWithTimeout Http
		{
			[Cpp2IlInjected.Token(Token = "0x60079E0")]
			[Cpp2IlInjected.Address(RVA = "0x738DD0", Offset = "0x7377D0", VA = "0x180738DD0")]
			get
			{
				int num = 0;
				return PlayFabHttpClient.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001544")]
		public CredentialProvider CredentialProvider
		{
			[Cpp2IlInjected.Token(Token = "0x60079E1")]
			[Cpp2IlInjected.Address(RVA = "0x738A00", Offset = "0x737400", VA = "0x180738A00")]
			[CompilerGenerated]
			get
			{
				return _003CCredentialProvider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079E2")]
			[Cpp2IlInjected.Address(RVA = "0x739E60", Offset = "0x738860", VA = "0x180739E60")]
			[CompilerGenerated]
			private set
			{
				_003CCredentialProvider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001545")]
		public LocalStorage LocalStorage
		{
			[Cpp2IlInjected.Token(Token = "0x60079E3")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			[CompilerGenerated]
			get
			{
				return _003CLocalStorage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079E4")]
			[Cpp2IlInjected.Address(RVA = "0x739EB0", Offset = "0x7388B0", VA = "0x180739EB0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalStorage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001546")]
		public GameSettings GameSettings
		{
			[Cpp2IlInjected.Token(Token = "0x60079E5")]
			[Cpp2IlInjected.Address(RVA = "0x738C10", Offset = "0x737610", VA = "0x180738C10")]
			[CompilerGenerated]
			get
			{
				return _003CGameSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079E6")]
			[Cpp2IlInjected.Address(RVA = "0x739E80", Offset = "0x738880", VA = "0x180739E80")]
			[CompilerGenerated]
			private set
			{
				_003CGameSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001547")]
		public Simulator<TransactionServiceServerImpl, TransactionService.TransactionServiceClient> Simulator
		{
			[Cpp2IlInjected.Token(Token = "0x60079E7")]
			[Cpp2IlInjected.Address(RVA = "0x739220", Offset = "0x737C20", VA = "0x180739220")]
			get
			{
				return simulator;
			}
			[Cpp2IlInjected.Token(Token = "0x60079E8")]
			[Cpp2IlInjected.Address(RVA = "0x73A350", Offset = "0x738D50", VA = "0x18073A350")]
			private set
			{
				simulator = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001548")]
		public Simulator<SocialServiceServer, SocialService.SocialServiceClient> SocialSimulator
		{
			[Cpp2IlInjected.Token(Token = "0x60079E9")]
			[Cpp2IlInjected.Address(RVA = "0x739280", Offset = "0x737C80", VA = "0x180739280")]
			get
			{
				return socialSimulator;
			}
			[Cpp2IlInjected.Token(Token = "0x60079EA")]
			[Cpp2IlInjected.Address(RVA = "0x73A360", Offset = "0x738D60", VA = "0x18073A360")]
			private set
			{
				socialSimulator = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001549")]
		public Meta.Online.CRM.GameConfig GameConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60079EB")]
			[Cpp2IlInjected.Address(RVA = "0x738AD0", Offset = "0x7374D0", VA = "0x180738AD0")]
			[CompilerGenerated]
			get
			{
				return _003CGameConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079EC")]
			[Cpp2IlInjected.Address(RVA = "0x739E70", Offset = "0x738870", VA = "0x180739E70")]
			[CompilerGenerated]
			set
			{
				_003CGameConfig_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new Meta.Online.CRM.GameConfig();


		[Cpp2IlInjected.Token(Token = "0x1700154A")]
		public LocalProfileHolder LocalProfileHolder
		{
			[Cpp2IlInjected.Token(Token = "0x60079ED")]
			[Cpp2IlInjected.Address(RVA = "0x738EB0", Offset = "0x7378B0", VA = "0x180738EB0")]
			[CompilerGenerated]
			get
			{
				return _003CLocalProfileHolder_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60079EE")]
			[Cpp2IlInjected.Address(RVA = "0x739EA0", Offset = "0x7388A0", VA = "0x180739EA0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalProfileHolder_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1A0"), Cpp2IlInjected.Token(Token = "0x4003B0C")]
		public ApplicationConfigurationType AppConfigType
		{
			[Cpp2IlInjected.Token(Token = "0x60079EF")]
			[Cpp2IlInjected.Address(RVA = "0x7389B0", Offset = "0x7373B0", VA = "0x1807389B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60079F0")]
			[Cpp2IlInjected.Address(RVA = "0x739E20", Offset = "0x738820", VA = "0x180739E20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700154C")]
		public bool IsGameRunningInEditor
		{
			[Cpp2IlInjected.Token(Token = "0x60079F1")]
			[Cpp2IlInjected.Address(RVA = "0x738E40", Offset = "0x737840", VA = "0x180738E40")]
			get
			{
				return AppConfigType == ApplicationConfigurationType.Editor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154D")]
		public bool IsGameRunningInDevelopment
		{
			[Cpp2IlInjected.Token(Token = "0x60079F2")]
			[Cpp2IlInjected.Address(RVA = "0x738E30", Offset = "0x737830", VA = "0x180738E30")]
			get
			{
				return AppConfigType == ApplicationConfigurationType.Development;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154E")]
		public bool IsGameRunningInRelease
		{
			[Cpp2IlInjected.Token(Token = "0x60079F3")]
			[Cpp2IlInjected.Address(RVA = "0x738E50", Offset = "0x737850", VA = "0x180738E50")]
			get
			{
				ApplicationConfigurationType applicationConfigurationType = AppConfigType;
				if (applicationConfigurationType == ApplicationConfigurationType.ReleaseWithCheats)
				{
					return true;
				}
				return applicationConfigurationType == ApplicationConfigurationType.Release;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154F")]
		public bool IsAccountLinkingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60079F8")]
			[Cpp2IlInjected.Address(RVA = "0x738DE0", Offset = "0x7377E0", VA = "0x180738DE0")]
			get
			{
				//Discarded unreachable code: IL_0010
				IUnityContext unityContext = UnityContext;
				return (object)typeof(IUnityContext).TypeHandle == null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001550")]
		public SocialService.SocialServiceClient SocialService
		{
			[Cpp2IlInjected.Token(Token = "0x60079FA")]
			[Cpp2IlInjected.Address(RVA = "0x739230", Offset = "0x737C30", VA = "0x180739230")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001551")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1B8"), Cpp2IlInjected.Token(Token = "0x4003B11")]
		private AsyncSemaphorePriority<TransactionPriorityOptions.Types.Priority> Semaphore
		{
			[Cpp2IlInjected.Token(Token = "0x60079FB")]
			[Cpp2IlInjected.Address(RVA = "0x738FE0", Offset = "0x7379E0", VA = "0x180738FE0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001552")]
		public bool IsSimulatorRunning
		{
			[Cpp2IlInjected.Token(Token = "0x6007A0F")]
			[Cpp2IlInjected.Address(RVA = "0x738E70", Offset = "0x737870", VA = "0x180738E70")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001553")]
		public bool ShouldIncludeScheduledBattlePasses
		{
			[Cpp2IlInjected.Token(Token = "0x6007A7D")]
			[Cpp2IlInjected.Address(RVA = "0x739150", Offset = "0x737B50", VA = "0x180739150")]
			get
			{
				//Discarded unreachable code: IL_0018
				if (AppConfigType == ApplicationConfigurationType.Editor)
				{
					return true;
				}
				int num = 0;
				return DebugSettings.Settings.showScheduledStarPathEvents_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001554")]
		public bool ShouldIncludeScheduledBundlesAndStores
		{
			[Cpp2IlInjected.Token(Token = "0x6007A7E")]
			[Cpp2IlInjected.Address(RVA = "0x7391C0", Offset = "0x737BC0", VA = "0x1807391C0")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.showScheduledBundlesAndStores_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008F")]
		public event RemoteTransactionError OnRemoteTransactionError
		{
			[Cpp2IlInjected.Token(Token = "0x60079A2")]
			[Cpp2IlInjected.Address(RVA = "0x738690", Offset = "0x737090", VA = "0x180738690")]
			[CompilerGenerated]
			add
			{
				RemoteTransactionError onRemoteTransactionError = this.OnRemoteTransactionError;
				Delegate @delegate = Delegate.Combine(onRemoteTransactionError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onRemoteTransactionError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079A3")]
			[Cpp2IlInjected.Address(RVA = "0x739B00", Offset = "0x738500", VA = "0x180739B00")]
			[CompilerGenerated]
			remove
			{
				RemoteTransactionError onRemoteTransactionError = this.OnRemoteTransactionError;
				Delegate @delegate = Delegate.Remove(onRemoteTransactionError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onRemoteTransactionError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000090")]
		public event DebugError OnDebugError
		{
			[Cpp2IlInjected.Token(Token = "0x60079A4")]
			[Cpp2IlInjected.Address(RVA = "0x738050", Offset = "0x736A50", VA = "0x180738050")]
			[CompilerGenerated]
			add
			{
				DebugError onDebugError = this.OnDebugError;
				Delegate @delegate = Delegate.Combine(onDebugError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079A5")]
			[Cpp2IlInjected.Address(RVA = "0x7394C0", Offset = "0x737EC0", VA = "0x1807394C0")]
			[CompilerGenerated]
			remove
			{
				DebugError onDebugError = this.OnDebugError;
				Delegate @delegate = Delegate.Remove(onDebugError, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugError)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000091")]
		public event DebugMessage OnDebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60079A6")]
			[Cpp2IlInjected.Address(RVA = "0x7380F0", Offset = "0x736AF0", VA = "0x1807380F0")]
			[CompilerGenerated]
			add
			{
				DebugMessage onDebugMessage = this.OnDebugMessage;
				Delegate @delegate = Delegate.Combine(onDebugMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079A7")]
			[Cpp2IlInjected.Address(RVA = "0x739560", Offset = "0x737F60", VA = "0x180739560")]
			[CompilerGenerated]
			remove
			{
				DebugMessage onDebugMessage = this.OnDebugMessage;
				Delegate @delegate = Delegate.Remove(onDebugMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000092")]
		public event DebugPrompt OnDebugPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x60079A8")]
			[Cpp2IlInjected.Address(RVA = "0x738190", Offset = "0x736B90", VA = "0x180738190")]
			[CompilerGenerated]
			add
			{
				DebugPrompt onDebugPrompt = this.OnDebugPrompt;
				Delegate @delegate = Delegate.Combine(onDebugPrompt, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugPrompt)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079A9")]
			[Cpp2IlInjected.Address(RVA = "0x739600", Offset = "0x738000", VA = "0x180739600")]
			[CompilerGenerated]
			remove
			{
				DebugPrompt onDebugPrompt = this.OnDebugPrompt;
				Delegate @delegate = Delegate.Remove(onDebugPrompt, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDebugPrompt)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000093")]
		public event GenericMessage OnGenericMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60079AA")]
			[Cpp2IlInjected.Address(RVA = "0x738370", Offset = "0x736D70", VA = "0x180738370")]
			[CompilerGenerated]
			add
			{
				GenericMessage onGenericMessage = this.OnGenericMessage;
				Delegate @delegate = Delegate.Combine(onGenericMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGenericMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079AB")]
			[Cpp2IlInjected.Address(RVA = "0x7397E0", Offset = "0x7381E0", VA = "0x1807397E0")]
			[CompilerGenerated]
			remove
			{
				GenericMessage onGenericMessage = this.OnGenericMessage;
				Delegate @delegate = Delegate.Remove(onGenericMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGenericMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000094")]
		public event InfoMessage OnInfoMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60079AC")]
			[Cpp2IlInjected.Address(RVA = "0x738410", Offset = "0x736E10", VA = "0x180738410")]
			[CompilerGenerated]
			add
			{
				InfoMessage onInfoMessage = this.OnInfoMessage;
				Delegate @delegate = Delegate.Combine(onInfoMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInfoMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079AD")]
			[Cpp2IlInjected.Address(RVA = "0x739880", Offset = "0x738280", VA = "0x180739880")]
			[CompilerGenerated]
			remove
			{
				InfoMessage onInfoMessage = this.OnInfoMessage;
				Delegate @delegate = Delegate.Remove(onInfoMessage, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInfoMessage)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000095")]
		public event OnlineValidationFailure OnOnlineValidationFailure
		{
			[Cpp2IlInjected.Token(Token = "0x60079AE")]
			[Cpp2IlInjected.Address(RVA = "0x7385F0", Offset = "0x736FF0", VA = "0x1807385F0")]
			[CompilerGenerated]
			add
			{
				OnlineValidationFailure onOnlineValidationFailure = this.OnOnlineValidationFailure;
				Delegate @delegate = Delegate.Combine(onOnlineValidationFailure, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOnlineValidationFailure)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079AF")]
			[Cpp2IlInjected.Address(RVA = "0x739A60", Offset = "0x738460", VA = "0x180739A60")]
			[CompilerGenerated]
			remove
			{
				OnlineValidationFailure onOnlineValidationFailure = this.OnOnlineValidationFailure;
				Delegate @delegate = Delegate.Remove(onOnlineValidationFailure, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOnlineValidationFailure)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000096")]
		public event GameInitializationErrorDetected OnGameInitializationError
		{
			[Cpp2IlInjected.Token(Token = "0x60079B0")]
			[Cpp2IlInjected.Address(RVA = "0x7382D0", Offset = "0x736CD0", VA = "0x1807382D0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079B1")]
			[Cpp2IlInjected.Address(RVA = "0x739740", Offset = "0x738140", VA = "0x180739740")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000097")]
		public event OnUserCredentialInitCB OnUserCredentialInit
		{
			[Cpp2IlInjected.Token(Token = "0x60079B2")]
			[Cpp2IlInjected.Address(RVA = "0x738870", Offset = "0x737270", VA = "0x180738870")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079B3")]
			[Cpp2IlInjected.Address(RVA = "0x739CE0", Offset = "0x7386E0", VA = "0x180739CE0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000098")]
		public event OnUserCredentialSetupCompletedCB OnUserCredentialSetupCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60079B4")]
			[Cpp2IlInjected.Address(RVA = "0x738910", Offset = "0x737310", VA = "0x180738910")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079B5")]
			[Cpp2IlInjected.Address(RVA = "0x739D80", Offset = "0x738780", VA = "0x180739D80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000099")]
		public event SoftReset OnSoftReset
		{
			[Cpp2IlInjected.Token(Token = "0x60079BB")]
			[Cpp2IlInjected.Address(RVA = "0x738730", Offset = "0x737130", VA = "0x180738730")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079BC")]
			[Cpp2IlInjected.Address(RVA = "0x739BA0", Offset = "0x7385A0", VA = "0x180739BA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400009A")]
		public event SoftReset OnForceQuit
		{
			[Cpp2IlInjected.Token(Token = "0x60079BE")]
			[Cpp2IlInjected.Address(RVA = "0x738230", Offset = "0x736C30", VA = "0x180738230")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079BF")]
			[Cpp2IlInjected.Address(RVA = "0x7396A0", Offset = "0x7380A0", VA = "0x1807396A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400009B")]
		public event InventoryFullFlowDelegate OnInventoryFull
		{
			[Cpp2IlInjected.Token(Token = "0x60079C1")]
			[Cpp2IlInjected.Address(RVA = "0x738550", Offset = "0x736F50", VA = "0x180738550")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079C2")]
			[Cpp2IlInjected.Address(RVA = "0x7399C0", Offset = "0x7383C0", VA = "0x1807399C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400009C")]
		public event InitialLoginCompleted OnInitialLoginCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60079F6")]
			[Cpp2IlInjected.Address(RVA = "0x7384B0", Offset = "0x736EB0", VA = "0x1807384B0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60079F7")]
			[Cpp2IlInjected.Address(RVA = "0x739920", Offset = "0x738320", VA = "0x180739920")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400009D")]
		public event StartUpHandler OnStartUp
		{
			[Cpp2IlInjected.Token(Token = "0x6007A0C")]
			[Cpp2IlInjected.Address(RVA = "0x7387D0", Offset = "0x7371D0", VA = "0x1807387D0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007A0D")]
			[Cpp2IlInjected.Address(RVA = "0x739C40", Offset = "0x738640", VA = "0x180739C40")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600791E")]
		[Cpp2IlInjected.Address(RVA = "0x72EEF0", Offset = "0x72D8F0", VA = "0x18072EEF0")]
		public bool IsPlayerIdValid(int playerId)
		{
			int num = 0;
			return playerId < 4;
		}

		[Cpp2IlInjected.Token(Token = "0x6007923")]
		[Cpp2IlInjected.Address(RVA = "0x730470", Offset = "0x72EE70", VA = "0x180730470")]
		[AsyncStateMachine(typeof(_003CPreGameLoad_003Ed__18))]
		public Task<PreGameLoadChainResult> PreGameLoad(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PreGameLoadChainResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007924")]
		[Cpp2IlInjected.Address(RVA = "0x730330", Offset = "0x72ED30", VA = "0x180730330")]
		[AsyncStateMachine(typeof(_003CPreGameLoadImpl_003Ed__19))]
		private Task<PreGameLoadResult> PreGameLoadImpl(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PreGameLoadResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007925")]
		[Cpp2IlInjected.Address(RVA = "0x731EB0", Offset = "0x7308B0", VA = "0x180731EB0")]
		public Task<SaveProfile.Types.Response> SaveProfileAsync(SaveProfile.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SaveProfile.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SaveProfileAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007926")]
		[Cpp2IlInjected.Address(RVA = "0x72F330", Offset = "0x72DD30", VA = "0x18072F330")]
		public Task<MoveInContainerInventory.Types.Response> MoveInContainerInventory(MoveInContainerInventory.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<MoveInContainerInventory.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).MoveInContainerInventoryAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007927")]
		[Cpp2IlInjected.Address(RVA = "0x734290", Offset = "0x732C90", VA = "0x180734290")]
		public Task<SortContainerInventory.Types.Response> SortContainerInventory(SortContainerInventory.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SortContainerInventory.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SortContainerInventoryAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007928")]
		[Cpp2IlInjected.Address(RVA = "0x734210", Offset = "0x732C10", VA = "0x180734210")]
		public Task<SmartInventoryTransfer.Types.Response> SmartInventoryTransfer(SmartInventoryTransfer.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SmartInventoryTransfer.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SmartInventoryTransferAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007929")]
		[Cpp2IlInjected.Address(RVA = "0x72D880", Offset = "0x72C280", VA = "0x18072D880")]
		public Task<EnterRealm.Types.Response> EnterRealm(EnterRealm.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<EnterRealm.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).EnterRealmAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792A")]
		[Cpp2IlInjected.Address(RVA = "0x735F80", Offset = "0x734980", VA = "0x180735F80")]
		public Task<UnlockRealm.Types.Response> UnlockRealm(UnlockRealm.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UnlockRealm.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UnlockRealmAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792B")]
		[Cpp2IlInjected.Address(RVA = "0x730010", Offset = "0x72EA10", VA = "0x180730010")]
		public Task<PlaceOnGrid.Types.Response> PlaceOnGrid(PlaceOnGrid.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PlaceOnGrid.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PlaceOnGridAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792C")]
		[Cpp2IlInjected.Address(RVA = "0x731700", Offset = "0x730100", VA = "0x180731700")]
		public Task<RemoveFromGrid.Types.Response> RemoveFromGrid(RemoveFromGrid.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<RemoveFromGrid.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).RemoveFromGridAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792D")]
		[Cpp2IlInjected.Address(RVA = "0x731630", Offset = "0x730030", VA = "0x180731630")]
		public Task<RemoveBlocker.Types.Response> RemoveBlocker(uint gridID, uint gridObjectID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			RemoveBlocker.Types.Request request = new RemoveBlocker.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = gridObjectID;
			return (Task<RemoveBlocker.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).RemoveBlockerAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792E")]
		[Cpp2IlInjected.Address(RVA = "0x736280", Offset = "0x734C80", VA = "0x180736280")]
		public Task<UpdateGridObjectTransform.Types.Response> UpdateGridObjectTransform(UpdateGridObjectTransform.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdateGridObjectTransform.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateGridObjectTransformAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600792F")]
		[Cpp2IlInjected.Address(RVA = "0x734F30", Offset = "0x733930", VA = "0x180734F30")]
		public Task<SwitchGridObjectGrid.Types.Response> SwitchGridObjectGrid(SwitchGridObjectGrid.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SwitchGridObjectGrid.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SwitchGridObjectGridAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007930")]
		[Cpp2IlInjected.Address(RVA = "0x7318E0", Offset = "0x7302E0", VA = "0x1807318E0")]
		public Task<ReplaceGridObject.Types.Response> ReplaceGridObject(ReplaceGridObject.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ReplaceGridObject.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ReplaceGridObjectAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007931")]
		[Cpp2IlInjected.Address(RVA = "0x72FD20", Offset = "0x72E720", VA = "0x18072FD20")]
		public Task<PickUpContainerItem.Types.Response> PickUpContainerItem(PickUpContainerItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PickUpContainerItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PickUpContainerItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007932")]
		[Cpp2IlInjected.Address(RVA = "0x735430", Offset = "0x733E30", VA = "0x180735430")]
		public Task<TrackClaimedFoundersPack.Types.Response> TrackClaimedFoundersPack(string foundersPackName, string onlineID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			TrackClaimedFoundersPack.Types.Request request = new TrackClaimedFoundersPack.Types.Request();
			request.FoundersPackName = foundersPackName;
			request.FoundersPackOnlineId = onlineID;
			return (Task<TrackClaimedFoundersPack.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).TrackClaimedFoundersPackAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007933")]
		[Cpp2IlInjected.Address(RVA = "0x730B40", Offset = "0x72F540", VA = "0x180730B40")]
		public Task<PutDownContainerItem.Types.Response> PutDownContainerItem(PutDownContainerItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PutDownContainerItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PutDownContainerItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007934")]
		[Cpp2IlInjected.Address(RVA = "0x72D4A0", Offset = "0x72BEA0", VA = "0x18072D4A0")]
		public Task<DropContainerInventoryStack.Types.Response> DropContainerInventoryStack(DropContainerInventoryStack.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DropContainerInventoryStack.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DropContainerInventoryStackAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007935")]
		[Cpp2IlInjected.Address(RVA = "0x72FE70", Offset = "0x72E870", VA = "0x18072FE70")]
		public Task<PickUpListItem.Types.Response> PickUpListItem(PickUpListItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PickUpListItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PickUpListItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007936")]
		[Cpp2IlInjected.Address(RVA = "0x730BC0", Offset = "0x72F5C0", VA = "0x180730BC0")]
		public Task<PutDownListItem.Types.Response> PutDownListItem(PutDownListItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PutDownListItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PutDownListItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007937")]
		[Cpp2IlInjected.Address(RVA = "0x72FDA0", Offset = "0x72E7A0", VA = "0x18072FDA0")]
		public Task<PickUpItem.Types.Response> PickUpItem(uint gridID, uint gridObjectID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			PickUpItem.Types.Request request = new PickUpItem.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = gridObjectID;
			return (Task<PickUpItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PickUpItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007938")]
		[Cpp2IlInjected.Address(RVA = "0x72A4D0", Offset = "0x728ED0", VA = "0x18072A4D0")]
		public Task<CollectLootPresent.Types.Response> CollectLootPresent(uint gridID, uint gridObjectID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			CollectLootPresent.Types.Request request = new CollectLootPresent.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = gridObjectID;
			return (Task<CollectLootPresent.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectLootPresentAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007939")]
		[Cpp2IlInjected.Address(RVA = "0x72A2B0", Offset = "0x728CB0", VA = "0x18072A2B0")]
		public Task<CollectConsummable.Types.Response> CollectConsummable(uint gridID, uint gridObjectID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			CollectConsummable.Types.Request request = new CollectConsummable.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = gridObjectID;
			return (Task<CollectConsummable.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectConsummableAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793A")]
		[Cpp2IlInjected.Address(RVA = "0x72A6E0", Offset = "0x7290E0", VA = "0x18072A6E0")]
		public Task<ConsumeItem.Types.Response> ConsumeItem(ConsumeItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ConsumeItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ConsumeItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793B")]
		[Cpp2IlInjected.Address(RVA = "0x734FB0", Offset = "0x7339B0", VA = "0x180734FB0")]
		public Task<SwitchPictureFrame.Types.Response> SwitchPictureFrame(SwitchPictureFrame.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SwitchPictureFrame.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SwitchPictureFrameAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793C")]
		[Cpp2IlInjected.Address(RVA = "0x736000", Offset = "0x734A00", VA = "0x180736000")]
		public Task<UnlockStorage.Types.Response> UnlockStorage(UnlockStorage.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UnlockStorage.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UnlockStorageAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793D")]
		[Cpp2IlInjected.Address(RVA = "0x732E10", Offset = "0x731810", VA = "0x180732E10")]
		public Task<SetFurnitureToggleState.Types.Response> SetFurnitureToggleState(SetFurnitureToggleState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SetFurnitureToggleState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetFurnitureToggleStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793E")]
		[Cpp2IlInjected.Address(RVA = "0x732D90", Offset = "0x731790", VA = "0x180732D90")]
		public Task<SetFurnitureIndexState.Types.Response> SetFurnitureIndexState(SetFurnitureIndexState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SetFurnitureIndexState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetFurnitureIndexStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600793F")]
		[Cpp2IlInjected.Address(RVA = "0x728790", Offset = "0x727190", VA = "0x180728790")]
		public Task<AvatarTransfer.Types.Response> AvatarTransfer(AvatarTransfer.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<AvatarTransfer.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).AvatarTransferAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007940")]
		[Cpp2IlInjected.Address(RVA = "0x732B90", Offset = "0x731590", VA = "0x180732B90")]
		public Task<AvatarCustomization.Types.Response> SetAvatarCustomization(AvatarCustomization.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<AvatarCustomization.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetAvatarCustomizationAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007941")]
		[Cpp2IlInjected.Address(RVA = "0x732D10", Offset = "0x731710", VA = "0x180732D10")]
		public Task<FurnitureCustomization.Types.Response> SetFurnitureCustomization(FurnitureCustomization.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<FurnitureCustomization.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetFurnitureCustomizationAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007942")]
		[Cpp2IlInjected.Address(RVA = "0x72D1C0", Offset = "0x72BBC0", VA = "0x18072D1C0")]
		public Task<DiscussWithCharacter.Types.Response> DiscussWithCharacter(DiscussWithCharacter.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DiscussWithCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DiscussWithCharacterAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007943")]
		[Cpp2IlInjected.Address(RVA = "0x731A60", Offset = "0x730460", VA = "0x180731A60")]
		public Task<ResetCharacterDiscussions.Types.Response> ResetCharacterDiscussions(ResetCharacterDiscussions.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ResetCharacterDiscussions.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ResetCharacterDiscussionsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007944")]
		[Cpp2IlInjected.Address(RVA = "0x72EAB0", Offset = "0x72D4B0", VA = "0x18072EAB0")]
		public Task<GiveItemsToCharacter.Types.Response> GiveItemsToCharacter(GiveItemsToCharacter.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<GiveItemsToCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).GiveItemsToCharacterAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007945")]
		[Cpp2IlInjected.Address(RVA = "0x732C10", Offset = "0x731610", VA = "0x180732C10")]
		public Task<SetCharacterPreferredItemsAsSeen.Types.Response> SetCharacterPreferredItemsAsSeen(SetCharacterPreferredItemsAsSeen.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SetCharacterPreferredItemsAsSeen.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetCharacterPreferredItemsAsSeenAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007946")]
		[Cpp2IlInjected.Address(RVA = "0x736100", Offset = "0x734B00", VA = "0x180736100")]
		public Task<UpdateCharacterSchedules.Types.Response> UpdateCharacterSchedules(UpdateCharacterSchedules.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdateCharacterSchedules.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateCharacterSchedulesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007947")]
		[Cpp2IlInjected.Address(RVA = "0x732090", Offset = "0x730A90", VA = "0x180732090")]
		public Task<SecretCharacterDiscovered.Types.Response> SecretCharacterDiscovered(SecretCharacterDiscovered.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SecretCharacterDiscovered.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SecretCharacterDiscoveredAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007948")]
		[Cpp2IlInjected.Address(RVA = "0x728520", Offset = "0x726F20", VA = "0x180728520")]
		public Task<ApplyCharacterProfession.Types.Response> ApplyCharacterProfession(ApplyCharacterProfession.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ApplyCharacterProfession.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ApplyCharacterProfessionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007949")]
		[Cpp2IlInjected.Address(RVA = "0x729200", Offset = "0x727C00", VA = "0x180729200")]
		public Task<ChangeCharacterProfession.Types.Response> ChangeCharacterProfession(ChangeCharacterProfession.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ChangeCharacterProfession.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ChangeCharacterProfessionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794A")]
		[Cpp2IlInjected.Address(RVA = "0x7285A0", Offset = "0x726FA0", VA = "0x1807285A0")]
		public Task<ApplyCharacterSkin.Types.Response> ApplyCharacterSkin(ApplyCharacterSkin.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ApplyCharacterSkin.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ApplyCharacterSkinAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794B")]
		[Cpp2IlInjected.Address(RVA = "0x72AB00", Offset = "0x729500", VA = "0x18072AB00")]
		public Task<CreateGardeningTile.Types.Response> CreateGardeningTile(CreateGardeningTile.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CreateGardeningTile.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CreateGardeningTileAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794C")]
		[Cpp2IlInjected.Address(RVA = "0x731780", Offset = "0x730180", VA = "0x180731780")]
		public Task<RemoveGardeningTile.Types.Response> RemoveGardeningTile(RemoveGardeningTile.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<RemoveGardeningTile.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).RemoveGardeningTileAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794D")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72EA90", VA = "0x180730090")]
		public Task<PlantSeed.Types.Response> PlantSeed(PlantSeed.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PlantSeed.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PlantSeedAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794E")]
		[Cpp2IlInjected.Address(RVA = "0x72DC30", Offset = "0x72C630", VA = "0x18072DC30")]
		public Task<FinishGardeningSlotGrowth.Types.Response> FinishGardeningSlotGrowth(FinishGardeningSlotGrowth.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<FinishGardeningSlotGrowth.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).FinishGardeningSlotGrowthAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600794F")]
		[Cpp2IlInjected.Address(RVA = "0x72EB70", Offset = "0x72D570", VA = "0x18072EB70")]
		public Task<HarvestGardeningSlot.Types.Response> HarvestGardeningSlot(HarvestGardeningSlot.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<HarvestGardeningSlot.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).HarvestGardeningSlotAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007950")]
		[Cpp2IlInjected.Address(RVA = "0x72A450", Offset = "0x728E50", VA = "0x18072A450")]
		public Task<CollectGardenStallSlot.Types.Response> CollectGardenStallSlot(CollectGardenStallSlot.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CollectGardenStallSlot.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectGardenStallSlotAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007951")]
		[Cpp2IlInjected.Address(RVA = "0x7370F0", Offset = "0x735AF0", VA = "0x1807370F0")]
		public Task<WaterObjects.Types.Response> WaterObjects(WaterObjects.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<WaterObjects.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).WaterObjectsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007952")]
		[Cpp2IlInjected.Address(RVA = "0x734390", Offset = "0x732D90", VA = "0x180734390")]
		public Task<StartFishing.Types.Response> StartFishing(StartFishing.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StartFishing.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StartFishingAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007953")]
		[Cpp2IlInjected.Address(RVA = "0x734570", Offset = "0x732F70", VA = "0x180734570")]
		public Task<StartHangoutWithCharacter.Types.Response> StartHangoutWithCharacter(StartHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StartHangoutWithCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StartHangoutWithCharacterAsync(request, cancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6007954")]
		[Cpp2IlInjected.Address(RVA = "0x734BE0", Offset = "0x7335E0", VA = "0x180734BE0")]
		public Task<StopHangoutWithCharacter.Types.Response> StopHangoutWithCharacter(StopHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StopHangoutWithCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StopHangoutWithCharacterAsync(request, cancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6007955")]
		[Cpp2IlInjected.Address(RVA = "0x734310", Offset = "0x732D10", VA = "0x180734310")]
		public Task<SpawnHangoutRewardsForCharacter.Types.Response> SpawnHangoutRewardsForCharacter(SpawnHangoutRewardsForCharacter.Types.Request request, CancellationToken cancellationToken)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SpawnHangoutRewardsForCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SpawnHangoutRewardsForCharacterAsync(request, cancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6007956")]
		[Cpp2IlInjected.Address(RVA = "0x732B10", Offset = "0x731510", VA = "0x180732B10")]
		public Task<SendFishingResult.Types.Response> SendFishingResult(SendFishingResult.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SendFishingResult.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SendFishingResultAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007957")]
		[Cpp2IlInjected.Address(RVA = "0x736380", Offset = "0x734D80", VA = "0x180736380")]
		public Task<UpdatePendingFishes.Types.Response> UpdatePendingFishes(UpdatePendingFishes.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdatePendingFishes.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdatePendingFishesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007958")]
		[Cpp2IlInjected.Address(RVA = "0x72A380", Offset = "0x728D80", VA = "0x18072A380")]
		public Task<CollectFishingStall.Types.Response> CollectFishingStall(uint gridID, uint objectGridID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			CollectFishingStall.Types.Request request = new CollectFishingStall.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = objectGridID;
			return (Task<CollectFishingStall.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectFishingStallAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007959")]
		[Cpp2IlInjected.Address(RVA = "0x7356D0", Offset = "0x7340D0", VA = "0x1807356D0")]
		public Task<TransferToPantry.Types.Response> TransferToPantry(TransferToPantry.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<TransferToPantry.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).TransferToPantryAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795A")]
		[Cpp2IlInjected.Address(RVA = "0x72A7D0", Offset = "0x7291D0", VA = "0x18072A7D0")]
		public Task<CookWithIngredients.Types.Response> CookWithIngredients(CookWithIngredients.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CookWithIngredients.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CookWithIngredientsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795B")]
		[Cpp2IlInjected.Address(RVA = "0x72D580", Offset = "0x72BF80", VA = "0x18072D580")]
		public Task<EatItem.Types.Response> EatItem(EatItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<EatItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).EatItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795C")]
		[Cpp2IlInjected.Address(RVA = "0x736400", Offset = "0x734E00", VA = "0x180736400")]
		public Task<UpdateRestaurantOrders.Types.Response> UpdateRestaurantOrders(UpdateRestaurantOrders.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdateRestaurantOrders.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateRestaurantOrdersAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795D")]
		[Cpp2IlInjected.Address(RVA = "0x72DE30", Offset = "0x72C830", VA = "0x18072DE30")]
		public Task<FulfillRestaurantOrders.Types.Response> FulfillRestaurantOrders(FulfillRestaurantOrders.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<FulfillRestaurantOrders.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).FulfillRestaurantOrdersAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795E")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF0", Offset = "0x72D5F0", VA = "0x18072EBF0")]
		public Task<HitMiningRock.Types.Response> HitMiningRock(HitMiningRock.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<HitMiningRock.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).HitMiningRockAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600795F")]
		[Cpp2IlInjected.Address(RVA = "0x72A850", Offset = "0x729250", VA = "0x18072A850")]
		public Task<CraftWithRecipe.Types.Response> CraftWithRecipe(CraftWithRecipe.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CraftWithRecipe.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CraftWithRecipeAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007960")]
		[Cpp2IlInjected.Address(RVA = "0x732C90", Offset = "0x731690", VA = "0x180732C90")]
		public Task<SetCraftingRecipeAsSeen.Types.Response> SetCraftingRecipeAsSeen(SetCraftingRecipeAsSeen.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SetCraftingRecipeAsSeen.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetCraftingRecipeAsSeenAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007961")]
		[Cpp2IlInjected.Address(RVA = "0x72DB10", Offset = "0x72C510", VA = "0x18072DB10")]
		public Task<FeedCritter.Types.Response> FeedCritter(FeedCritter.Types.Request request, uint gridID, GridPosition gridPosition, GridPosition direction, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			//IL_0006: Expected O, but got I4
			int num = default(int);
			CallOptions callOptions = new CallOptions((MetadataCollection)num);
			num = 0;
			string value = default(string);
			callOptions.Metadata.Add("avatarpos", value);
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<FeedCritter.Types.Response> result = default(Task<FeedCritter.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007962")]
		[Cpp2IlInjected.Address(RVA = "0x72FC60", Offset = "0x72E660", VA = "0x18072FC60")]
		public Task<PetCompanion.Types.Response> PetCompanion(Item companionItem, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			int itemID = companionItem.ItemID;
			PetCompanion.Types.Request request = new PetCompanion.Types.Request();
			request.companionItemID_ = itemID;
			return (Task<PetCompanion.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PetCompanionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007963")]
		[Cpp2IlInjected.Address(RVA = "0x72CBE0", Offset = "0x72B5E0", VA = "0x18072CBE0")]
		public Task<DebugUnlockAllCritters.Types.Response> DebugUnlockAllCritters(DebugUnlockAllCritters.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockAllCritters.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockAllCrittersAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007964")]
		[Cpp2IlInjected.Address(RVA = "0x72DA30", Offset = "0x72C430", VA = "0x18072DA30")]
		public Task<ExpandPlayerHouseRoom.Types.Response> ExpandPlayerHouseRoom(ExpandPlayerHouseRoom.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ExpandPlayerHouseRoom.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ExpandPlayerHouseRoomAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007965")]
		[Cpp2IlInjected.Address(RVA = "0x72F060", Offset = "0x72DA60", VA = "0x18072F060")]
		public Task<ManagePlayerHouseRoom.Types.Response> ManagePlayerHouseRoom(ManagePlayerHouseRoom.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ManagePlayerHouseRoom.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ManagePlayerHouseRoomAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007966")]
		[Cpp2IlInjected.Address(RVA = "0x7283D0", Offset = "0x726DD0", VA = "0x1807283D0")]
		public Task<AddPlayerHouseFloor.Types.Response> AddPlayerHouseFloor(AddPlayerHouseFloor.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<AddPlayerHouseFloor.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).AddPlayerHouseFloorAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007967")]
		[Cpp2IlInjected.Address(RVA = "0x729380", Offset = "0x727D80", VA = "0x180729380")]
		public Task<ChangePlayerHouseFlooring.Types.Response> ChangePlayerHouseFlooring(ChangePlayerHouseFlooring.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ChangePlayerHouseFlooring.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ChangePlayerHouseFlooringAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007968")]
		[Cpp2IlInjected.Address(RVA = "0x729400", Offset = "0x727E00", VA = "0x180729400")]
		public Task<ChangePlayerHouseWallpaper.Types.Response> ChangePlayerHouseWallpaper(ChangePlayerHouseWallpaper.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ChangePlayerHouseWallpaper.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ChangePlayerHouseWallpaperAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007969")]
		[Cpp2IlInjected.Address(RVA = "0x72C7C0", Offset = "0x72B1C0", VA = "0x18072C7C0")]
		[AsyncStateMachine(typeof(_003CDebugSkipTime_003Ed__88))]
		public Task<DebugSkipTime.Types.Response> DebugSkipTime(DebugSkipTime.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DebugSkipTime.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600796A")]
		[Cpp2IlInjected.Address(RVA = "0x72B410", Offset = "0x729E10", VA = "0x18072B410")]
		public Task DebugBuildHouse(uint gridID, uint objectGridID, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.BuildHouse buildHouse = new DebugGenericCheat.Types.BuildHouse();
			buildHouse.gridID_ = gridID;
			buildHouse.objectGridID_ = objectGridID;
			request.BuildHouse = buildHouse;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600796B")]
		[Cpp2IlInjected.Address(RVA = "0x72B9C0", Offset = "0x72A3C0", VA = "0x18072B9C0")]
		public Task DebugForceSpecificFish(bool enabled, Item fishItem, FishRarity fishRarity, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.ForceSpecificFish forceSpecificFish = new DebugGenericCheat.Types.ForceSpecificFish();
			forceSpecificFish.enabled_ = enabled;
			request.ForceSpecificFish = forceSpecificFish;
			bool flag = default(bool);
			if (!flag)
			{
				DebugGenericCheat.Types.ForceSpecificFish forceSpecificFish2 = request.ForceSpecificFish;
			}
			DebugGenericCheat.Types.ForceSpecificFish forceSpecificFish3 = request.ForceSpecificFish;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600796C")]
		[Cpp2IlInjected.Address(RVA = "0x72BB50", Offset = "0x72A550", VA = "0x18072BB50")]
		public Task DebugForceSpecificMining(Item miningItem, CancellationToken ct)
		{
			int itemID = miningItem.ItemID;
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.ForceSpecificMining forceSpecificMining = new DebugGenericCheat.Types.ForceSpecificMining();
			forceSpecificMining.miningItemID_ = itemID;
			request.ForceSpecificMining = forceSpecificMining;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600796D")]
		[Cpp2IlInjected.Address(RVA = "0x72C220", Offset = "0x72AC20", VA = "0x18072C220")]
		public Task DebugRemoveNightThorns(int keepOneEvery, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.RemoveNightThorns removeNightThorns = new DebugGenericCheat.Types.RemoveNightThorns();
			removeNightThorns.keepOneEvery_ = keepOneEvery;
			request.RemoveNightThorns = removeNightThorns;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600796E")]
		[Cpp2IlInjected.Address(RVA = "0x72BFC0", Offset = "0x72A9C0", VA = "0x18072BFC0")]
		public Task DebugRemoveBlockers(Item blockerItem, CancellationToken ct)
		{
			int itemID = blockerItem.ItemID;
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.RemoveBlockers removeBlockers = new DebugGenericCheat.Types.RemoveBlockers();
			removeBlockers.blockerItemID_ = itemID;
			request.RemoveBlockers = removeBlockers;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600796F")]
		[Cpp2IlInjected.Address(RVA = "0x72CDD0", Offset = "0x72B7D0", VA = "0x18072CDD0")]
		public Task DebugUnlockAllTools(CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.UnlockAllTools unlockAllTools2 = (request.UnlockAllTools = new DebugGenericCheat.Types.UnlockAllTools());
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007970")]
		[Cpp2IlInjected.Address(RVA = "0x72CCE0", Offset = "0x72B6E0", VA = "0x18072CCE0")]
		public Task DebugUnlockAllRecipies(CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.UnlockAllRecipies unlockAllRecipies2 = (request.UnlockAllRecipies = new DebugGenericCheat.Types.UnlockAllRecipies());
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007971")]
		[Cpp2IlInjected.Address(RVA = "0x72C5D0", Offset = "0x72AFD0", VA = "0x18072C5D0")]
		public Task DebugShowAllCraftingRecipes(bool enabled, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.ShowAllCraftingRecipes showAllCraftingRecipes = new DebugGenericCheat.Types.ShowAllCraftingRecipes();
			showAllCraftingRecipes.enabled_ = enabled;
			request.ShowAllCraftingRecipes = showAllCraftingRecipes;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007972")]
		[Cpp2IlInjected.Address(RVA = "0x72BC60", Offset = "0x72A660", VA = "0x18072BC60")]
		public Task DebugForceSpecificStoreFilter(Item displayItem, int filterType, CancellationToken ct)
		{
			int itemID = displayItem.ItemID;
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.ForceSpecificStoreFilter forceSpecificStoreFilter = new DebugGenericCheat.Types.ForceSpecificStoreFilter();
			forceSpecificStoreFilter.displayItemID_ = itemID;
			forceSpecificStoreFilter.filterType_ = filterType;
			request.ForceSpecificStoreFilter = forceSpecificStoreFilter;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007973")]
		[Cpp2IlInjected.Address(RVA = "0x72BD70", Offset = "0x72A770", VA = "0x18072BD70")]
		public Task DebugForceSpecificWeather(string weather, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.ForceSpecificWeather forceSpecificWeather = new DebugGenericCheat.Types.ForceSpecificWeather();
			forceSpecificWeather.Weather = weather;
			request.ForceSpecificWeather = forceSpecificWeather;
			Task<DebugGenericCheat.Types.Response> task = (Task<DebugGenericCheat.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenericCheatAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007974")]
		[Cpp2IlInjected.Address(RVA = "0x72B2F0", Offset = "0x729CF0", VA = "0x18072B2F0")]
		public Task DebugBattlePassTaskProgresion(string onlineId, int taskIndex, int amount, CancellationToken ct)
		{
			DebugGenericCheat.Types.Request request = new DebugGenericCheat.Types.Request();
			DebugGenericCheat.Types.BattlePassTaskProgresion battlePassTaskProgresion = new DebugGenericCheat.Types.BattlePassTaskProgresion();
			battlePassTaskProgresion.OnlineId = onlineId;
			battlePassTaskProgresion.taskIndex_ = taskIndex;
			battlePassTaskProgresion.amount_ = amount;
			request.BattlePassTaskProgresion = battlePassTaskProgresion;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007975")]
		[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
		public Task<BuyOffline.Types.Response> BuyOffline(BuyOffline.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<BuyOffline.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).BuyOfflineAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007976")]
		[Cpp2IlInjected.Address(RVA = "0x729280", Offset = "0x727C80", VA = "0x180729280")]
		public Task<ChangeCurrentPet.Types.Response> ChangeCurrentPet(ChangeCurrentPet.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ChangeCurrentPet.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ChangeCurrentPetAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007977")]
		[Cpp2IlInjected.Address(RVA = "0x734A10", Offset = "0x733410", VA = "0x180734A10")]
		public Task<StartPendingBurningState.Types.Response> StartPendingBurningState(StartPendingBurningState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StartPendingBurningState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StartPendingBurningStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007978")]
		[Cpp2IlInjected.Address(RVA = "0x72A230", Offset = "0x728C30", VA = "0x18072A230")]
		public Task<CollectBurningState.Types.Response> CollectBurningState(CollectBurningState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CollectBurningState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectBurningStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007979")]
		[Cpp2IlInjected.Address(RVA = "0x729FE0", Offset = "0x7289E0", VA = "0x180729FE0")]
		public Task<ClearBurningState.Types.Response> ClearBurningState(ClearBurningState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ClearBurningState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ClearBurningStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797A")]
		[Cpp2IlInjected.Address(RVA = "0x7306E0", Offset = "0x72F0E0", VA = "0x1807306E0")]
		public Task<PullWeed.Types.Response> PullWeed(PullWeed.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<PullWeed.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).PullWeedAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797B")]
		[Cpp2IlInjected.Address(RVA = "0x7345F0", Offset = "0x732FF0", VA = "0x1807345F0")]
		public Task<StartItemCollectMinigame.Types.Response> StartItemCollectMinigame(StartItemCollectMinigame.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StartItemCollectMinigame.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StartItemCollectMinigameAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797C")]
		[Cpp2IlInjected.Address(RVA = "0x72A5A0", Offset = "0x728FA0", VA = "0x18072A5A0")]
		public Task<CollectMinigameItem.Types.Response> CollectMinigameItem(CollectMinigameItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<CollectMinigameItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectMinigameItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797D")]
		[Cpp2IlInjected.Address(RVA = "0x734C60", Offset = "0x733660", VA = "0x180734C60")]
		public Task<StopItemCollectMinigame.Types.Response> StopItemCollectMinigame(StopItemCollectMinigame.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<StopItemCollectMinigame.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).StopItemCollectMinigameAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797E")]
		[Cpp2IlInjected.Address(RVA = "0x72F0E0", Offset = "0x72DAE0", VA = "0x18072F0E0")]
		public Task<Meditate.Types.Response> Meditate(Meditate.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<Meditate.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).MeditateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600797F")]
		[Cpp2IlInjected.Address(RVA = "0x736080", Offset = "0x734A80", VA = "0x180736080")]
		public Task<UpdateBattlePassTasksProgression.Types.Response> UpdateBattlePassTasksProgression(UpdateBattlePassTasksProgression.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdateBattlePassTasksProgression.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateBattlePassTasksProgressionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007980")]
		[Cpp2IlInjected.Address(RVA = "0x736300", Offset = "0x734D00", VA = "0x180736300")]
		public Task<UpdateOnlineShopStates.Types.Response> UpdateOnlineShopStates(UpdateOnlineShopStates.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<UpdateOnlineShopStates.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateOnlineShopStatesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007981")]
		[Cpp2IlInjected.Address(RVA = "0x72AD30", Offset = "0x729730", VA = "0x18072AD30")]
		public Task<DebugAddCurrency.Types.Response> DebugAddCurrency(DebugAddCurrency.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugAddCurrency.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddCurrencyAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007982")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x729A00", VA = "0x18072B000")]
		public Task<DebugAddItem.Types.Response> DebugAddItem(Item item, int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			int itemID = item.ItemID;
			DebugAddItem.Types.Request request = new DebugAddItem.Types.Request();
			request.itemID_ = itemID;
			request.amount_ = amount;
			return (Task<DebugAddItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007983")]
		[Cpp2IlInjected.Address(RVA = "0x72AF80", Offset = "0x729980", VA = "0x18072AF80")]
		public Task<DebugAddItem.Types.Response> DebugAddItem(DebugAddItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugAddItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007984")]
		[Cpp2IlInjected.Address(RVA = "0x72C150", Offset = "0x72AB50", VA = "0x18072C150")]
		public Task<DebugRemoveItem.Types.Response> DebugRemoveItem(Item item, int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			int itemID = item.ItemID;
			DebugRemoveItem.Types.Request request = new DebugRemoveItem.Types.Request();
			request.itemID_ = itemID;
			request.amount_ = amount;
			return (Task<DebugRemoveItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugRemoveItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007985")]
		[Cpp2IlInjected.Address(RVA = "0x72C0D0", Offset = "0x72AAD0", VA = "0x18072C0D0")]
		public Task<DebugRemoveItem.Types.Response> DebugRemoveItem(DebugRemoveItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugRemoveItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugRemoveItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007986")]
		[Cpp2IlInjected.Address(RVA = "0x72AEB0", Offset = "0x7298B0", VA = "0x18072AEB0")]
		public Task<DebugAddFriendship.Types.Response> DebugAddFriendship(Item characterId, int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			int itemID = characterId.ItemID;
			DebugAddFriendship.Types.Request request = new DebugAddFriendship.Types.Request();
			request.characterID_ = itemID;
			request.amount_ = amount;
			return (Task<DebugAddFriendship.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddFriendshipAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007987")]
		[Cpp2IlInjected.Address(RVA = "0x72AE30", Offset = "0x729830", VA = "0x18072AE30")]
		public Task<DebugAddFriendship.Types.Response> DebugAddFriendship(DebugAddFriendship.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugAddFriendship.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddFriendshipAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007988")]
		[Cpp2IlInjected.Address(RVA = "0x72B230", Offset = "0x729C30", VA = "0x18072B230")]
		public Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXP(int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			DebugAddPlayerXP.Types.Request request = new DebugAddPlayerXP.Types.Request();
			request.amount_ = amount;
			return (Task<DebugAddPlayerXP.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddPlayerXPAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007989")]
		[Cpp2IlInjected.Address(RVA = "0x72B1B0", Offset = "0x729BB0", VA = "0x18072B1B0")]
		public Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXP(DebugAddPlayerXP.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugAddPlayerXP.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddPlayerXPAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798A")]
		[Cpp2IlInjected.Address(RVA = "0x72C510", Offset = "0x72AF10", VA = "0x18072C510")]
		public Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevel(int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			DebugSetPlayerLevel.Types.Request request = new DebugSetPlayerLevel.Types.Request();
			request.amount_ = amount;
			return (Task<DebugSetPlayerLevel.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugSetPlayerLevelAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798B")]
		[Cpp2IlInjected.Address(RVA = "0x72C490", Offset = "0x72AE90", VA = "0x18072C490")]
		public Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevel(DebugSetPlayerLevel.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugSetPlayerLevel.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugSetPlayerLevelAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798C")]
		[Cpp2IlInjected.Address(RVA = "0x72CF40", Offset = "0x72B940", VA = "0x18072CF40")]
		public Task<DebugUnlockCharacter.Types.Response> DebugUnlockCharacter(DebugUnlockCharacter.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockCharacterAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798D")]
		[Cpp2IlInjected.Address(RVA = "0x729300", Offset = "0x727D00", VA = "0x180729300")]
		public Task<ChangeCurrentScene.Types.Response> ChangeCurrentScene(ChangeCurrentScene.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ChangeCurrentScene.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ChangeCurrentSceneAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798E")]
		[Cpp2IlInjected.Address(RVA = "0x732FF0", Offset = "0x7319F0", VA = "0x180732FF0")]
		public Task<SetManaHasAlreadyMissed.Types.Response> SetManaHasAlreadyMissed(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			SetManaHasAlreadyMissed.Types.Request request = new SetManaHasAlreadyMissed.Types.Request();
			return (Task<SetManaHasAlreadyMissed.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SetManaHasAlreadyMissedAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600798F")]
		[Cpp2IlInjected.Address(RVA = "0x72CA00", Offset = "0x72B400", VA = "0x18072CA00")]
		public Task<DebugStartEvent.Types.Response> DebugStartEvent(DebugStartEvent.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugStartEvent.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugStartEventAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007990")]
		[Cpp2IlInjected.Address(RVA = "0x72B740", Offset = "0x72A140", VA = "0x18072B740")]
		public Task<DebugEndEvent.Types.Response> DebugEndEvent(DebugEndEvent.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugEndEvent.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugEndEventAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007991")]
		[Cpp2IlInjected.Address(RVA = "0x72B840", Offset = "0x72A240", VA = "0x18072B840")]
		public Task<DebugForceActivityBonusReward.Types.Response> DebugForceActivityBonusReward(DebugForceActivityBonusReward.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugForceActivityBonusReward.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugForceActivityBonusRewardAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007992")]
		[Cpp2IlInjected.Address(RVA = "0x72B8C0", Offset = "0x72A2C0", VA = "0x18072B8C0")]
		public Task<DebugForceBurningState.Types.Response> DebugForceBurningState(DebugForceBurningState.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugForceBurningState.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugForceBurningStateAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007993")]
		[Cpp2IlInjected.Address(RVA = "0x72B940", Offset = "0x72A340", VA = "0x18072B940")]
		public Task<DebugForceSecretCharacter.Types.Response> DebugForceSecretCharacter(DebugForceSecretCharacter.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugForceSecretCharacter.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugForceSecretCharacterAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007994")]
		[Cpp2IlInjected.Address(RVA = "0x72CFC0", Offset = "0x72B9C0", VA = "0x18072CFC0")]
		public Task<DebugUnlockVillageArea.Types.Response> DebugUnlockVillageArea(DebugUnlockVillageArea.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockVillageArea.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockVillageAreaAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007995")]
		[Cpp2IlInjected.Address(RVA = "0x72CB60", Offset = "0x72B560", VA = "0x18072CB60")]
		public Task<DebugUnlockAllBuildings.Types.Response> DebugUnlockAllBuildings(DebugUnlockAllBuildings.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockAllBuildings.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockAllBuildingsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007996")]
		[Cpp2IlInjected.Address(RVA = "0x72CC60", Offset = "0x72B660", VA = "0x18072CC60")]
		public Task<DebugUnlockAllRealms.Types.Response> DebugUnlockAllRealms(DebugUnlockAllRealms.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockAllRealms.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockAllRealmsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007997")]
		[Cpp2IlInjected.Address(RVA = "0x72CEC0", Offset = "0x72B8C0", VA = "0x18072CEC0")]
		public Task<DebugUnlockCharacterPreferredItems.Types.Response> DebugUnlockCharacterPreferredItems(DebugUnlockCharacterPreferredItems.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugUnlockCharacterPreferredItems.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugUnlockCharacterPreferredItemsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007998")]
		[Cpp2IlInjected.Address(RVA = "0x72BF40", Offset = "0x72A940", VA = "0x18072BF40")]
		public Task<DebugRemoveAllForagingItems.Types.Response> DebugRemoveAllForagingItems(DebugRemoveAllForagingItems.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugRemoveAllForagingItems.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugRemoveAllForagingItemsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007999")]
		[Cpp2IlInjected.Address(RVA = "0x72B6C0", Offset = "0x72A0C0", VA = "0x18072B6C0")]
		public Task<DebugEmptyAllActivitySources.Types.Response> DebugEmptyAllActivitySources(DebugEmptyAllActivitySources.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugEmptyAllActivitySources.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugEmptyAllActivitySourcesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600799A")]
		[Cpp2IlInjected.Address(RVA = "0x72B7C0", Offset = "0x72A1C0", VA = "0x18072B7C0")]
		public Task<DebugFakeRPCException.Types.Response> DebugFakeRPCException(DebugFakeRPCException.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugFakeRPCException.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugFakeRPCExceptionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x600799B")]
		[Cpp2IlInjected.Address(RVA = "0x72EC70", Offset = "0x72D670", VA = "0x18072EC70")]
		public int IncrementRequestId()
		{
			int num = nextRequestId;
			return nextRequestId = num + 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600799C")]
		[Cpp2IlInjected.Address(RVA = "0x7291E0", Offset = "0x727BE0", VA = "0x1807291E0")]
		public bool CanRetryOnError(StatusCode code)
		{
			//Discarded unreachable code: IL_0002
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60079B6")]
		[Cpp2IlInjected.Address(RVA = "0x733A60", Offset = "0x732460", VA = "0x180733A60")]
		internal Task<Option> ShowDebugMessage(string title, string message, [Optional] Exception exception, bool allowClose = false, params Option[] options)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60079B7")]
		[Cpp2IlInjected.Address(RVA = "0x733EA0", Offset = "0x7328A0", VA = "0x180733EA0")]
		internal Task<Option> ShowDebugPrompt(string title, string subtitle, string message, bool allowClose = false, params Option[] options)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60079B8")]
		[Cpp2IlInjected.Address(RVA = "0x730E40", Offset = "0x72F840", VA = "0x180730E40")]
		public Task RaiseOnlineValidationFailure(ClientSession.ValidationResult validationResult, CancellationToken ct)
		{
			OnlineClient.AskForLogout(ct);
			if ((long)this.OnOnlineValidationFailure != 0)
			{
				TaskCompletionSource<bool> t = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
				OnlineValidationFailure onOnlineValidationFailure = this.OnOnlineValidationFailure;
				if (onOnlineValidationFailure != null)
				{
					Action selectionCallback = delegate
					{
						//Discarded unreachable code: IL_000d
						//IL_000c: Expected O, but got I4
						((TaskCompletionSource<TResult>)(object)t).SetResult((TResult)1);
					};
					Task task = onOnlineValidationFailure(selectionCallback, validationResult, ct);
				}
			}
			Task<> task2 = Task.FromResult(result: false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60079B9")]
		[Cpp2IlInjected.Address(RVA = "0x733880", Offset = "0x732280", VA = "0x180733880")]
		internal Task<Option> ShowAlertMessage(string title, string subtitle, string message, bool isSystem, [Optional] Exception exception, bool allowClose = false, params Option[] options)
		{
			TaskCompletionSource<Option> t = (TaskCompletionSource<Option>)(object)new TaskCompletionSource<TResult>();
			if (this.OnGenericMessage != null)
			{
				Func<Option, OptionWithCallback> func = (Func<Option, OptionWithCallback>)(object)(Func<T, TResult>)delegate(Option o)
				{
					//Discarded unreachable code: IL_0030
					Option option = o;
					Action callback = delegate
					{
						//Discarded unreachable code: IL_001b
						TaskCompletionSource<Option> taskCompletionSource = t;
						Option result = o;
						((TaskCompletionSource<TResult>)(object)taskCompletionSource).SetResult((TResult)result);
					};
					return new OptionWithCallback(option, callback);
				};
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60079BA")]
		[Cpp2IlInjected.Address(RVA = "0x7341D0", Offset = "0x732BD0", VA = "0x1807341D0")]
		internal void ShowInfoMessage(string message)
		{
			this.OnInfoMessage?.Invoke(message);
		}

		[Cpp2IlInjected.Token(Token = "0x60079BD")]
		[Cpp2IlInjected.Address(RVA = "0x72D260", Offset = "0x72BC60", VA = "0x18072D260")]
		internal bool DoSoftReset()
		{
			SoftReset onSoftReset = this.OnSoftReset;
			if (onSoftReset != null)
			{
				return onSoftReset();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60079C0")]
		[Cpp2IlInjected.Address(RVA = "0x72D240", Offset = "0x72BC40", VA = "0x18072D240")]
		internal bool DoForceQuit()
		{
			SoftReset onForceQuit = this.OnForceQuit;
			if (onForceQuit != null)
			{
				return onForceQuit();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60079C3")]
		[Cpp2IlInjected.Address(RVA = "0x72EB30", Offset = "0x72D530", VA = "0x18072EB30")]
		public void InvokeDebugError(string msg, UserChoice<DebugErrorOption> userChoice)
		{
			this.OnDebugError?.Invoke(msg, (UserChoice<>)(object)userChoice);
		}

		[Cpp2IlInjected.Token(Token = "0x60079F4")]
		[Cpp2IlInjected.Address(RVA = "0x7289D0", Offset = "0x7273D0", VA = "0x1807289D0")]
		private string BuildTestProfileRelativeDir(string titleId)
		{
			return Path.Combine("test_profiles", titleId);
		}

		[Cpp2IlInjected.Token(Token = "0x60079F5")]
		[Cpp2IlInjected.Address(RVA = "0x728A40", Offset = "0x727440", VA = "0x180728A40")]
		private string BuildTestProfileRelativePath(string titleId, string profileName)
		{
			return Path.Combine(Path.Combine("test_profiles", titleId), profileName);
		}

		[Cpp2IlInjected.Token(Token = "0x60079F9")]
		[Cpp2IlInjected.Address(RVA = "0x7376E0", Offset = "0x7360E0", VA = "0x1807376E0")]
		public Client(Serilog.ILogger logger, DeviceInfo deviceInfo, IUnityContext unityContext, Gameloft.Common.Version gameVersion, [Optional] IKeyChain keychain, [Optional] IErrorReporter errorReporter, ApplicationConfigurationType appConfigType = ApplicationConfigurationType.Development, bool isDelayingProfileWrite = false, [Optional] INativeNetworkManager nativeNetworkMgr, [Optional] SynchronizationContext synchronizationContext)
		{
			//IL_00ca: Expected O, but got I4
			//IL_00d1: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			int num = 0;
			Common.SetupHttp();
			AppConfigType = ApplicationConfigurationType.Editor;
			IsDelayingProfileWrite = false;
			Log = logger;
			UnityContext = unityContext;
			ErrorReporter = (IErrorReporter)0;
			NativeNetworkManager = (INativeNetworkManager)0;
			Func<DateTime> func = (Func<DateTime>)(object)(Func<TResult>)delegate
			{
				Profile profile2 = profile;
				DateTime dateTime = default(DateTime);
				return (profile2 != null) ? ServerUtil.NowUtc(profile2.player_) : dateTime;
			};
			Func<TimeSpan> func2 = (Func<TimeSpan>)(object)(Func<TResult>)(() => TimeZoneOffset);
			Clock clock = (Clock = new Clock((Func<>)(object)func, (Func<>)(object)func2));
			Func<DateTime> func3 = (Func<DateTime>)(object)(Func<TResult>)delegate
			{
				//Discarded unreachable code: IL_0041
				int num5 = 0;
				DateTime utcNow = DateTime.UtcNow;
				Profile profile = this.profile;
				if (profile != null)
				{
					Google.Protobuf.WellKnownTypes.Duration debugTimeSkippedOnline_ = profile.player_.debugTimeSkippedOnline_;
					if (debugTimeSkippedOnline_ != null)
					{
						TimeSpan timeSpan = debugTimeSkippedOnline_.ToTimeSpan();
						int num6 = 0;
					}
				}
				int num7 = 0;
				TimeSpan zero = TimeSpan.Zero;
				return utcNow + zero;
			};
			Func<TimeSpan> func4 = (Func<TimeSpan>)(object)(Func<TResult>)(() => TimeZoneOffset);
			Clock clock2 = (ClockOnline = new Clock((Func<>)(object)func3, (Func<>)(object)func4));
			DeviceInfo = (DeviceInfo)0;
			DeviceInfo deviceInfo2 = DeviceInfo;
			int num2 = 0;
			ClientConfig clientConfig = (ClientConfig = ClientConfig.Instance.Clone());
			ClientTransactionContext clientTransactionContext = (TransactionContext = new ClientTransactionContext(this));
			Keychain = (IKeyChain)0;
			OnlineClient onlineClient = (OnlineClient = new OnlineClient(this));
			if (ErrorReporter != null && ErrorReporter != null)
			{
				int num3 = 0;
				if (((GlobalStorageData)((BaseStorage<DataType>)(object)GlobalStorage.Instance).Data).LastTitleId == null)
				{
				}
				if (ErrorReporter != null)
				{
					int num4 = 0;
					if (((GlobalStorageData)((BaseStorage<DataType>)(object)GlobalStorage.Instance).Data).LastPlayFabId != null)
					{
					}
				}
			}
			ProfileEventDispatcher profileEventDispatcher = Dispatcher;
			ProfileEventDispatcher.RecurringEventRescheduled value = OnRecurringEventRescheduled;
			profileEventDispatcher.OnRecurringEventRescheduled += value;
			ProfileEventDispatcher profileEventDispatcher2 = Dispatcher;
			ProfileEventDispatcher.RecurringEventRescheduled value2 = OnRecurringEventRemoved;
			profileEventDispatcher2.OnRecurringEventRemoved += value2;
			DisposableList disposableList = this.disposableList;
			Action a = delegate
			{
				//Discarded unreachable code: IL_0037
				ProfileEventDispatcher profileEventDispatcher5 = Dispatcher;
				ProfileEventDispatcher.RecurringEventRescheduled value5 = OnRecurringEventRescheduled;
				profileEventDispatcher5.OnRecurringEventRescheduled -= value5;
				ProfileEventDispatcher profileEventDispatcher6 = Dispatcher;
				ProfileEventDispatcher.RecurringEventRescheduled value6 = OnRecurringEventRemoved;
				profileEventDispatcher6.OnRecurringEventRemoved -= value6;
			};
			disposableList.Add(a);
			ProfileEventDispatcher profileEventDispatcher3 = Dispatcher;
			ProfileEventDispatcher.BattlePassTasksUpdate value3 = OnBattlePassTasksUpdate;
			profileEventDispatcher3.OnBattlePassTasksUpdate += value3;
			DisposableList disposableList2 = this.disposableList;
			Action a2 = delegate
			{
				//Discarded unreachable code: IL_001c
				ProfileEventDispatcher profileEventDispatcher4 = Dispatcher;
				ProfileEventDispatcher.BattlePassTasksUpdate value4 = OnBattlePassTasksUpdate;
				profileEventDispatcher4.OnBattlePassTasksUpdate -= value4;
			};
			disposableList2.Add(a2);
			AsyncSemaphorePriority<TransactionPriorityOptions.Types.Priority> asyncSemaphorePriority = default(AsyncSemaphorePriority<TransactionPriorityOptions.Types.Priority>);
			Semaphore = asyncSemaphorePriority;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60079FC")]
		[Cpp2IlInjected.Address(RVA = "0x7329D0", Offset = "0x7313D0", VA = "0x1807329D0")]
		[AsyncStateMachine(typeof(_003CSemaphoreWaitAsync_003Ed__343))]
		internal Task SemaphoreWaitAsync(string name, TransactionPriorityOptions.Types.Priority priority)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60079FD")]
		[Cpp2IlInjected.Address(RVA = "0x732910", Offset = "0x731310", VA = "0x180732910")]
		internal void SemaphoreRelease(string name)
		{
			//Discarded unreachable code: IL_0024
			Serilog.ILogger logger = Log;
			string text = "[Meta/RPC] " + name + " releasing on semaphore";
			((AsyncSemaphorePriority<T>)(object)Semaphore).Release();
		}

		[Cpp2IlInjected.Token(Token = "0x60079FE")]
		[Cpp2IlInjected.Address(RVA = "0x736600", Offset = "0x735000", VA = "0x180736600")]
		public void Update()
		{
			//Discarded unreachable code: IL_0023
			if ((long)profile != 0)
			{
				Clock.Update();
				ClockOnline.Update();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60079FF")]
		[Cpp2IlInjected.Address(RVA = "0x72D140", Offset = "0x72BB40", VA = "0x18072D140")]
		public void Destroy()
		{
			//IL_0009: Expected O, but got I4
			//IL_0034: Expected O, but got I8
			int num = 0;
			Profile = (Profile)num;
			OnlineClient?.Destroy();
			disposableList?.Dispose();
			disposableList = (DisposableList)0;
			Dispatcher?.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x6007A00")]
		[Cpp2IlInjected.Address(RVA = "0x72D140", Offset = "0x72BB40", VA = "0x18072D140", Slot = "4")]
		public void Dispose()
		{
			//IL_0009: Expected O, but got I4
			//IL_0034: Expected O, but got I8
			int num = 0;
			Profile = (Profile)num;
			OnlineClient?.Destroy();
			disposableList?.Dispose();
			disposableList = (DisposableList)0;
			Dispatcher?.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x6007A01")]
		[Cpp2IlInjected.Address(RVA = "0x72EB50", Offset = "0x72D550", VA = "0x18072EB50")]
		private void HandleSocialRequestException(string error, UserChoice<RemoteTransactionErrorOption> choice)
		{
			this.OnRemoteTransactionError?.Invoke(error, (UserChoice<>)(object)choice);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A02")]
		[Cpp2IlInjected.Address(RVA = "0x72EB30", Offset = "0x72D530", VA = "0x18072EB30")]
		private void HandleSocialDebugError(string error, UserChoice<DebugErrorOption> choice)
		{
			this.OnDebugError?.Invoke(error, (UserChoice<>)(object)choice);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A03")]
		[Cpp2IlInjected.Address(RVA = "0x72F3B0", Offset = "0x72DDB0", VA = "0x18072F3B0")]
		private unsafe void OnBattlePassTasksUpdate(Dictionary<string, BattlePassSeasonData> battlePassSeasons)
		{
			//Discarded unreachable code: IL_002a, IL_0042, IL_0048, IL_004e, IL_0054
			//IL_0013: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				if (((Dictionary<TKey, TValue>)(object)ctsBattlePassUpdates).TryGetValue((TKey)num, out *(TValue*)num))
				{
				}
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				Dictionary<string, CancellationTokenSource> dictionary = ctsBattlePassUpdates;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A04")]
		[Cpp2IlInjected.Address(RVA = "0x736970", Offset = "0x735370", VA = "0x180736970")]
		[AsyncStateMachine(typeof(_003CWaitForNextBattlePassUpdates_003Ed__352))]
		private Task WaitForNextBattlePassUpdates(string onlineId, BattlePassSeasonData battlePassSeason, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A05")]
		[Cpp2IlInjected.Address(RVA = "0x736D00", Offset = "0x735700", VA = "0x180736D00")]
		private void WaitForRecurringEvents(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001f
			int num = 0;
			Dictionary<uint, CancellationTokenSource>.ValueCollection values = (Dictionary<uint, CancellationTokenSource>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)recurringEventCTS).get_Values();
			bool flag = default(bool);
			if (flag)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A06")]
		[Cpp2IlInjected.Address(RVA = "0x736AC0", Offset = "0x7354C0", VA = "0x180736AC0")]
		[AsyncStateMachine(typeof(_003CWaitForNextOccurrence_003Ed__354))]
		private Task WaitForNextOccurrence(RecurringEvent recurringEvent, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A07")]
		[Cpp2IlInjected.Address(RVA = "0x72F6F0", Offset = "0x72E0F0", VA = "0x18072F6F0")]
		private void OnRecurringEventRescheduled(uint recurringEventID)
		{
			//Discarded unreachable code: IL_003c
			if (!blockRecurringEventReschedule)
			{
				MapField<uint, RecurringEvent> recurringEvents_ = profile.world_.recurringEvents_;
				bool flag = default(bool);
				IRecurringEvent recurringEvent = default(IRecurringEvent);
				if (flag && !recurringEvent.IsEventOver())
				{
					CancellationToken token = _profileCTS.Token;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A08")]
		[Cpp2IlInjected.Address(RVA = "0x72F640", Offset = "0x72E040", VA = "0x18072F640")]
		private void OnRecurringEventRemoved(uint recurringEventID)
		{
			//Discarded unreachable code: IL_0019
			//IL_0017: Expected O, but got I4
			Dictionary<uint, CancellationTokenSource> dictionary = recurringEventCTS;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ((Dictionary<TKey, TValue>)(object)recurringEventCTS).Remove((TKey)recurringEventID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A09")]
		[Cpp2IlInjected.Address(RVA = "0x736730", Offset = "0x735130", VA = "0x180736730")]
		[AsyncStateMachine(typeof(_003CWaitForCampaignEventAsync_003Ed__357))]
		private Task WaitForCampaignEventAsync(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A0A")]
		[Cpp2IlInjected.Address(RVA = "0x736850", Offset = "0x735250", VA = "0x180736850")]
		[AsyncStateMachine(typeof(_003CWaitForDailyReset_003Ed__358))]
		private Task WaitForDailyReset(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A0B")]
		[Cpp2IlInjected.Address(RVA = "0x736FD0", Offset = "0x7359D0", VA = "0x180736FD0")]
		[AsyncStateMachine(typeof(_003CWaitForWeatherChange_003Ed__359))]
		private Task WaitForWeatherChange(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A0E")]
		[Cpp2IlInjected.Address(RVA = "0x731020", Offset = "0x72FA20", VA = "0x180731020")]
		public void RaiseStartUp(Profile profile, CancellationToken ct)
		{
			this.OnStartUp?.Invoke(profile, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A10")]
		[Cpp2IlInjected.Address(RVA = "0x72A8D0", Offset = "0x7292D0", VA = "0x18072A8D0")]
		public void CreateAndStartSimulators()
		{
			//Discarded unreachable code: IL_0095, IL_009b
			ProfileEventDispatcher profileEventDispatcher = new ProfileEventDispatcher();
			ServerTransactionContext serverTransactionContext = new ServerTransactionContext();
			ClientNetworkData clientNetworkData = NetworkData;
			LocalProfileHolder localProfileHolder = LocalProfileHolder;
			Simulator<, > simulator = (Simulator<, >)(object)(this.simulator = (Simulator<TransactionServiceServerImpl, TransactionService.TransactionServiceClient>)(object)Simulator<SERVER, CLIENT>.CreateAndStart(this, localProfileHolder, profileEventDispatcher, (NetworkDataProvider)clientNetworkData, serverTransactionContext));
			ClientNetworkData clientNetworkData2 = NetworkData;
			LocalProfileHolder localProfileHolder2 = LocalProfileHolder;
			Simulator<, > simulator2 = (Simulator<, >)(object)(socialSimulator = (Simulator<SocialServiceServer, SocialService.SocialServiceClient>)(object)Simulator<SERVER, CLIENT>.CreateAndStart(this, localProfileHolder2, profileEventDispatcher, (NetworkDataProvider)clientNetworkData2, serverTransactionContext));
			DisposableList disposableList = this.disposableList;
			Action a = delegate
			{
			};
			disposableList.Add(a);
			DisposableList disposableList2 = this.disposableList;
			Action a2 = delegate
			{
			};
			disposableList2.Add(a2);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A11")]
		[Cpp2IlInjected.Address(RVA = "0x7335B0", Offset = "0x731FB0", VA = "0x1807335B0")]
		[AsyncStateMachine(typeof(_003CSetProfileToUse_003Ed__369))]
		public Task<bool> SetProfileToUse(Profile profile, bool forceWhilePlaying, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A12")]
		[Cpp2IlInjected.Address(RVA = "0x730C40", Offset = "0x72F640", VA = "0x180730C40")]
		public Task RaiseGameInitializationError(CancellationToken ct, GameInitializationError error, string debugMessage, Exception exception)
		{
			LocalStorage?.ResetMiniProfile();
			if ((long)this.OnGameInitializationError != 0)
			{
				TaskCompletionSource<bool> t = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
				if (this.OnGameInitializationError != null)
				{
					Action action = delegate
					{
						//Discarded unreachable code: IL_000d
						//IL_000c: Expected O, but got I4
						((TaskCompletionSource<TResult>)(object)t).SetResult((TResult)1);
					};
				}
			}
			Task<> task = Task.FromResult(result: false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007A13")]
		[Cpp2IlInjected.Address(RVA = "0x72E590", Offset = "0x72CF90", VA = "0x18072E590")]
		public string GetSaveGameFolderByUser(string userkey)
		{
			//Discarded unreachable code: IL_009b
			while (true)
			{
				string[] array = new string[5];
				IUnityContext unityContext = UnityContext;
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = (string)(object)array;
				if ("_" != null && "_" == null)
				{
					continue;
				}
				array[1] = "_";
				if (userkey != null && "_" == null)
				{
					continue;
				}
				array[2] = userkey;
				if ("_" != null && "_" == null)
				{
					continue;
				}
				array[3] = "_";
				ApplicationConfigurationType applicationConfigurationType = AppConfigType;
				switch (applicationConfigurationType)
				{
				}
				if ("r" == null || applicationConfigurationType != 0)
				{
					array[4] = "r";
					return string.Concat(array);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A14")]
		[Cpp2IlInjected.Address(RVA = "0x7305B0", Offset = "0x72EFB0", VA = "0x1807305B0")]
		[AsyncStateMachine(typeof(_003CPrepareUserCredentials_003Ed__374))]
		public Task PrepareUserCredentials(CancellationToken ct, Func<FailureFallback, Task<bool>> retryPrompt, bool isMultipleUsersPerDeviceSupportedNatively)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A15")]
		[Cpp2IlInjected.Address(RVA = "0x734790", Offset = "0x733190", VA = "0x180734790")]
		public void StartOnlineInitTask(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0080, IL_0086, IL_008c, IL_0092, IL_0098
			int num = 0;
			if ((OnlineClient.IsInitialized ? 1 : 0) == num)
			{
				if ((IntPtr)OnlineLoginTask != (IntPtr)num)
				{
					Serilog.ILogger logger = Log;
				}
				int num2 = 0;
				if ((DebugSettings.Settings.resetOnlineUserId_ ? 1 : 0) != num)
				{
					CredentialProvider.ResetGameID();
				}
				int num3 = 0;
				Profile.TemporaryOverrideScope temporaryOverrideScope = Profile.OverrideSaveWithoutUpdatingContext();
				int num4 = 0;
				if (!DebugSettings.Settings.DoResetProfile)
				{
					int num5 = 0;
					if (!DebugSettings.Settings.deleteLocalProfileOnly_)
					{
						return;
					}
				}
				Serilog.ILogger logger2 = Log;
				LocalProfileHolder.DeleteProfileFile();
			}
			else
			{
				Serilog.ILogger logger3 = Log;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A16")]
		[Cpp2IlInjected.Address(RVA = "0x736C00", Offset = "0x735600", VA = "0x180736C00")]
		[AsyncStateMachine(typeof(_003CWaitForOnlineInitTask_003Ed__376))]
		public Task WaitForOnlineInitTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A17")]
		[Cpp2IlInjected.Address(RVA = "0x72A760", Offset = "0x729160", VA = "0x18072A760")]
		public static GameInitializationError Convert(LoadProfileResult.Types.ErrorCode loadError, InitProfileResult.Types.ErrorCode initError)
		{
			while (true)
			{
				if (loadError == LoadProfileResult.Types.ErrorCode.UnknownError)
				{
				}
				if (initError == InitProfileResult.Types.ErrorCode.InitializationError)
				{
				}
				if (initError == InitProfileResult.Types.ErrorCode.ActualizationError)
				{
					/*Error: Could not find block for branch target IL_000d*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A18")]
		[Cpp2IlInjected.Address(RVA = "0x734A90", Offset = "0x733490", VA = "0x180734A90")]
		[AsyncStateMachine(typeof(_003CStartSimulatorAndLogin_003Ed__378))]
		public Task<Profile> StartSimulatorAndLogin(CancellationToken ct, bool debugSettingsWasActive = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Profile>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A19")]
		[Cpp2IlInjected.Address(RVA = "0x72EC80", Offset = "0x72D680", VA = "0x18072EC80")]
		[AsyncStateMachine(typeof(_003CInitLogin_003Ed__379))]
		public Task<Profile> InitLogin(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Profile>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1A")]
		[Cpp2IlInjected.Address(RVA = "0x729770", Offset = "0x728170", VA = "0x180729770")]
		[AsyncStateMachine(typeof(_003CCheat_UploadProfileSlot_003Ed__380))]
		public Task<bool> Cheat_UploadProfileSlot(string profileSlotName)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1B")]
		[Cpp2IlInjected.Address(RVA = "0x7298B0", Offset = "0x7282B0", VA = "0x1807298B0")]
		[AsyncStateMachine(typeof(_003CCheat_UploadUserInfo_003Ed__381))]
		public Task<bool> Cheat_UploadUserInfo(string ugcName, string reports, [Optional] object customProperties)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1C")]
		[Cpp2IlInjected.Address(RVA = "0x7295D0", Offset = "0x727FD0", VA = "0x1807295D0")]
		[AsyncStateMachine(typeof(_003CCheat_CreateUGC_003Ed__382))]
		private Task<bool> Cheat_CreateUGC(string customId, string ugcItemName, string contentType, string data, bool allowOverwrite, [Optional] string fileName)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1D")]
		[Cpp2IlInjected.Address(RVA = "0x72D3A0", Offset = "0x72BDA0", VA = "0x18072D3A0")]
		[AsyncStateMachine(typeof(_003CDownloadTestProfiles_003Ed__383))]
		public Task DownloadTestProfiles(OnlineEnvironment onlineEnv)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1E")]
		[Cpp2IlInjected.Address(RVA = "0x72E970", Offset = "0x72D370", VA = "0x18072E970")]
		[AsyncStateMachine(typeof(_003CGetTestProfilePathsByEnv_003Ed__384))]
		public Task<List<string>> GetTestProfilePathsByEnv(OnlineEnvironment onlineEnv, bool downloadProfiles = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<string>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A1F")]
		[Cpp2IlInjected.Address(RVA = "0x729DD0", Offset = "0x7287D0", VA = "0x180729DD0")]
		public void CleanupTestProfiles()
		{
			//Discarded unreachable code: IL_0033
			ulong num = default(ulong);
			if (num == 0)
			{
			}
			IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if (num2 != 0)
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField2 = FileSystem.SaveGlobal;
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A20")]
		[Cpp2IlInjected.Address(RVA = "0x731960", Offset = "0x730360", VA = "0x180731960")]
		public void ReplaceProfileFromPath(string sourceProfilePath)
		{
			//Discarded unreachable code: IL_0022
			IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			string profilePath_ = ClientConfig.profilePath_;
			ProfileUtil.CopyProfile(_003CSaveGlobal_003Ek__BackingField, _003CSave_003Ek__BackingField, sourceProfilePath, profilePath_);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A21")]
		[Cpp2IlInjected.Address(RVA = "0x72ADB0", Offset = "0x7297B0", VA = "0x18072ADB0")]
		public Task<DebugAddFreeTimer.Types.Response> DebugAddFreeTimer(DebugAddFreeTimer.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DebugAddFreeTimer.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugAddFreeTimerAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A22")]
		[Cpp2IlInjected.Address(RVA = "0x72CA80", Offset = "0x72B480", VA = "0x18072CA80")]
		public Task<DebugTestMission.Types.Response> DebugTestMissionAsync(int missionId, bool autoStart, int stepIndex, MissionChoice missionChoice, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0030
			DebugTestMission.Types.Request request = new DebugTestMission.Types.Request();
			request.missionChoice_ = MissionChoice.Any;
			request.missionId_ = missionId;
			request.autoStart_ = autoStart;
			request.stepIndex_ = stepIndex;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<DebugTestMission.Types.Response> result = default(Task<DebugTestMission.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A23")]
		[Cpp2IlInjected.Address(RVA = "0x72C6E0", Offset = "0x72B0E0", VA = "0x18072C6E0")]
		public Task<DebugSkipMissionStep.Types.Response> DebugSkipMissionStepAsync(int missionId, CancellationToken ct, bool allSteps = false)
		{
			//Discarded unreachable code: IL_0027
			DebugSkipMissionStep.Types.Request request = new DebugSkipMissionStep.Types.Request();
			request.missionId_ = missionId;
			request.allSteps_ = allSteps;
			return (Task<DebugSkipMissionStep.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugSkipMissionStepAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A24")]
		[Cpp2IlInjected.Address(RVA = "0x729CF0", Offset = "0x7286F0", VA = "0x180729CF0")]
		public Task<ClaimMiniEventReward.Types.Response> ClaimMiniEventReward(string name, int index, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			ClaimMiniEventReward.Types.Request request = new ClaimMiniEventReward.Types.Request();
			request.Name = name;
			request.index_ = index;
			return (Task<ClaimMiniEventReward.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ClaimMiniEventRewardAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A25")]
		[Cpp2IlInjected.Address(RVA = "0x734670", Offset = "0x733070", VA = "0x180734670")]
		public Task<StartMission.Types.Response> StartMissionAsync(MissionSlotClass slotClass, int slotId, MissionChoice choice, List<FriendshipChoice> friendshipChoices, InventoryFullResolution inventoryFullResolution, CancellationToken ct)
		{
			//Discarded unreachable code: IL_003d
			//IL_0011: Expected O, but got I4
			StartMission.Types.Request request = new StartMission.Types.Request();
			request.inventoryFullResolution_ = (InventoryFullResolution)0;
			request.slotClass_ = slotClass;
			request.slotId_ = slotId;
			request.missionChoice_ = choice;
			RepeatedField<FriendshipChoice> friendshipChoices_ = request.friendshipChoices_;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<StartMission.Types.Response> result = default(Task<StartMission.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A26")]
		[Cpp2IlInjected.Address(RVA = "0x736180", Offset = "0x734B80", VA = "0x180736180")]
		public Task<UpdateDialogueFlags.Types.Response> UpdateDialogueFlagsAsync(Dictionary<int, bool> flagChanges, CancellationToken ct, bool isOverride = false)
		{
			//Discarded unreachable code: IL_002c
			UpdateDialogueFlags.Types.Request request = new UpdateDialogueFlags.Types.Request();
			request.isOverride_ = isOverride;
			((MapField<TKey, TValue>)(object)request.flagChanges_).Add((IDictionary<, >)flagChanges);
			return (Task<UpdateDialogueFlags.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateDialogueFlagsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A27")]
		[Cpp2IlInjected.Address(RVA = "0x728620", Offset = "0x727020", VA = "0x180728620")]
		public Task<UpdateDialogueFlags.Types.Response> ApplyDialogueFlagsOverrideAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			UpdateDialogueFlags.Types.Request request = new UpdateDialogueFlags.Types.Request();
			request.applyOverride_ = true;
			return (Task<UpdateDialogueFlags.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateDialogueFlagsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A28")]
		[Cpp2IlInjected.Address(RVA = "0x72F160", Offset = "0x72DB60", VA = "0x18072F160")]
		public Task<MissionCompleteStep.Types.Response> MissionCompleteStepAsync(Item missionItem, string stepName, MissionCompleteStep.Types.Condition condition, CancellationToken ct, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			//Discarded unreachable code: IL_003a
			//IL_0024: Expected O, but got I4
			int itemID = missionItem.ItemID;
			MissionCompleteStep.Types.Request request = new MissionCompleteStep.Types.Request();
			request.missionItemID_ = itemID;
			request.StepName = stepName;
			request.inventoryFullResolution_ = (InventoryFullResolution)0;
			request.condition_ = condition;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<MissionCompleteStep.Types.Response> result = default(Task<MissionCompleteStep.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A29")]
		[Cpp2IlInjected.Address(RVA = "0x72D760", Offset = "0x72C160", VA = "0x18072D760")]
		public Task<EndMission.Types.Response> EndMissionAsync(MissionSlotClass slotClass, int slotId, List<FriendshipChoice> friendshipChoices, InventoryFullResolution inventoryFullResolution, CancellationToken ct, bool forceCheat = false)
		{
			//Discarded unreachable code: IL_003e
			//IL_0016: Expected O, but got I4
			EndMission.Types.Request request = new EndMission.Types.Request();
			request.cheatForced_ = false;
			request.inventoryFullResolution_ = (InventoryFullResolution)0;
			request.slotClass_ = slotClass;
			request.slotId_ = slotId;
			((RepeatedField<T>)(object)request.friendshipChoices_).AddRange((IEnumerable<>)friendshipChoices);
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<EndMission.Types.Response> result = default(Task<EndMission.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2A")]
		[Cpp2IlInjected.Address(RVA = "0x72B520", Offset = "0x729F20", VA = "0x18072B520")]
		public Task<DebugCancelMission.Types.Response> DebugCancelMissionAsync(MissionSlotClass slotClass, int slotId, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			DebugCancelMission.Types.Request request = new DebugCancelMission.Types.Request();
			request.slotClass_ = slotClass;
			request.slotId_ = slotId;
			return (Task<DebugCancelMission.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugCancelMissionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2B")]
		[Cpp2IlInjected.Address(RVA = "0x735520", Offset = "0x733F20", VA = "0x180735520")]
		public Task<TrackMission.Types.Response> TrackMissionAsync(int missionId, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			TrackMission.Types.Request request = new TrackMission.Types.Request();
			request.trackedMission_ = missionId;
			return (Task<TrackMission.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).TrackMissionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2C")]
		[Cpp2IlInjected.Address(RVA = "0x7330A0", Offset = "0x731AA0", VA = "0x1807330A0")]
		public Task<SetMissionNextChoice.Types.Response> SetMissionNextChoiceAsync(MissionSlotClass slotClass, int slotId, MissionChoice choice, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			SetMissionNextChoice.Types.Request request = new SetMissionNextChoice.Types.Request();
			request.slotClass_ = slotClass;
			request.slotId_ = slotId;
			request.missionChoice_ = choice;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<SetMissionNextChoice.Types.Response> result = default(Task<SetMissionNextChoice.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2D")]
		[Cpp2IlInjected.Address(RVA = "0x72FEF0", Offset = "0x72E8F0", VA = "0x18072FEF0")]
		public Task<PictureTaken.Types.Response> PictureTakenAsync(PhotoModeType photoMode, List<int> itemsInPicture, List<int> gardenItemInPicture, SceneType sceneType, CancellationToken ct)
		{
			//Discarded unreachable code: IL_003f
			PictureTaken.Types.Request request = new PictureTaken.Types.Request();
			request.sceneType_ = SceneType.Main;
			RepeatedField<int> itemIds_ = request.itemIds_;
			request.photoMode_ = photoMode;
			((RepeatedField<T>)(object)itemIds_).AddRange((IEnumerable<>)itemsInPicture);
			((RepeatedField<T>)(object)request.gardenItemIds_).AddRange((IEnumerable<>)gardenItemInPicture);
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<PictureTaken.Types.Response> result = default(Task<PictureTaken.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2E")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72DC70", VA = "0x18072F270")]
		public Task<MissionItemInteraction.Types.Response> MissionItemInteractionAsync(Item item, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			int itemID = item.ItemID;
			MissionItemInteraction.Types.Request request = new MissionItemInteraction.Types.Request();
			request.itemId_ = itemID;
			return (Task<MissionItemInteraction.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).MissionItemInteractionAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A2F")]
		[Cpp2IlInjected.Address(RVA = "0x72EDD0", Offset = "0x72D7D0", VA = "0x18072EDD0")]
		public Task<InitTLE.Types.Response> InitTLEAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0030
			InitTLE.Types.Request request = new InitTLE.Types.Request();
			if (profile != null)
			{
			}
			DateTime dateTime = default(DateTime);
			Timestamp timestamp = (request.serverTime_ = Timestamp.FromDateTime(dateTime));
			return (Task<InitTLE.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).InitTLEAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A30")]
		[Cpp2IlInjected.Address(RVA = "0x72D9B0", Offset = "0x72C3B0", VA = "0x18072D9B0")]
		public Task<ExecuteRecurringEvent.Types.Response> ExecuteRecurringEventAsync(ExecuteRecurringEvent.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<ExecuteRecurringEvent.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ExecuteRecurringEventAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A31")]
		[Cpp2IlInjected.Address(RVA = "0x72D900", Offset = "0x72C300", VA = "0x18072D900")]
		public Task<ExecuteCampaignEvent.Types.Response> ExecuteCampaignEventAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			ExecuteCampaignEvent.Types.Request request = new ExecuteCampaignEvent.Types.Request();
			return (Task<ExecuteCampaignEvent.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).ExecuteCampaignEventAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A32")]
		[Cpp2IlInjected.Address(RVA = "0x731DB0", Offset = "0x7307B0", VA = "0x180731DB0")]
		public Task<SaveClothingDesign.Types.Response> SaveClothingDesign(SaveClothingDesign.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SaveClothingDesign.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SaveClothingDesignAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A33")]
		[Cpp2IlInjected.Address(RVA = "0x72D040", Offset = "0x72BA40", VA = "0x18072D040")]
		public Task<DeleteClothingDesign.Types.Response> DeleteClothingDesign(DeleteClothingDesign.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DeleteClothingDesign.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DeleteClothingDesignAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A34")]
		[Cpp2IlInjected.Address(RVA = "0x731E30", Offset = "0x730830", VA = "0x180731E30")]
		public Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesign(SaveFurnitureDesign.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SaveFurnitureDesign.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).SaveFurnitureDesignAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A35")]
		[Cpp2IlInjected.Address(RVA = "0x72D0C0", Offset = "0x72BAC0", VA = "0x18072D0C0")]
		public Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesign(DeleteFurnitureDesign.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<DeleteFurnitureDesign.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DeleteFurnitureDesignAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A36")]
		[Cpp2IlInjected.Address(RVA = "0x734410", Offset = "0x732E10", VA = "0x180734410")]
		[AsyncStateMachine(typeof(_003CStartFtueEvent_003Ed__408))]
		public Task<StartFtueEvent.Types.Response> StartFtueEvent(StartFtueEvent.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<StartFtueEvent.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A37")]
		[Cpp2IlInjected.Address(RVA = "0x72D600", Offset = "0x72C000", VA = "0x18072D600")]
		[AsyncStateMachine(typeof(_003CEndFtueEvent_003Ed__409))]
		public Task<EndFtueEvent.Types.Response> EndFtueEvent(EndFtueEvent.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<EndFtueEvent.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A38")]
		[Cpp2IlInjected.Address(RVA = "0x72C330", Offset = "0x72AD30", VA = "0x18072C330")]
		[AsyncStateMachine(typeof(_003CDebugResetFtueEvent_003Ed__410))]
		public Task<DebugResetFtueEvent.Types.Response> DebugResetFtueEvent(DebugResetFtueEvent.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DebugResetFtueEvent.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A39")]
		[Cpp2IlInjected.Address(RVA = "0x732E90", Offset = "0x731890", VA = "0x180732E90")]
		[AsyncStateMachine(typeof(_003CSetHudApparition_003Ed__411))]
		public Task<SetHudApparition.Types.Response> SetHudApparition(SetHudApparition.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SetHudApparition.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3A")]
		[Cpp2IlInjected.Address(RVA = "0x733180", Offset = "0x731B80", VA = "0x180733180")]
		[AsyncStateMachine(typeof(_003CSetName_003Ed__412))]
		public Task<SetName.Types.Response> SetName(SetName.Types.Request request, CancellationToken ct, bool skipOnline = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SetName.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3B")]
		[Cpp2IlInjected.Address(RVA = "0x731AE0", Offset = "0x7304E0", VA = "0x180731AE0")]
		[AsyncStateMachine(typeof(_003CResetPlayfabNameChangeCooldown_003Ed__413))]
		public Task<ResetPlayfabNameChangeCooldown.Types.Response> ResetPlayfabNameChangeCooldown(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ResetPlayfabNameChangeCooldown.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3C")]
		[Cpp2IlInjected.Address(RVA = "0x733720", Offset = "0x732120", VA = "0x180733720")]
		[AsyncStateMachine(typeof(_003CShopBuyItem_003Ed__414))]
		public Task<ShopBuyItem.Types.Response> ShopBuyItem(ShopBuyItem.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ShopBuyItem.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3D")]
		[Cpp2IlInjected.Address(RVA = "0x72DEB0", Offset = "0x72C8B0", VA = "0x18072DEB0")]
		public Task<GenericBuyItem.Types.Response> GenericBuyItem(GenericBuyItem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<GenericBuyItem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).GenericBuyItemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3E")]
		[Cpp2IlInjected.Address(RVA = "0x728B00", Offset = "0x727500", VA = "0x180728B00")]
		public Task<BuyDeliverySystem.Types.Response> BuyDeliverySystem(BuyDeliverySystem.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<BuyDeliverySystem.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).BuyDeliverySystemAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A3F")]
		[Cpp2IlInjected.Address(RVA = "0x728EC0", Offset = "0x7278C0", VA = "0x180728EC0")]
		[AsyncStateMachine(typeof(_003CBuySoftCurrency_003Ed__417))]
		public Task<BuySoftCurrency.Types.Response> BuySoftCurrency(BuySoftCurrency.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<BuySoftCurrency.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A40")]
		[Cpp2IlInjected.Address(RVA = "0x735E20", Offset = "0x734820", VA = "0x180735E20")]
		[AsyncStateMachine(typeof(_003CUnlockBuilding_003Ed__418))]
		public Task<UnlockBuilding.Types.Response> UnlockBuilding(UnlockBuilding.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<UnlockBuilding.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A41")]
		[Cpp2IlInjected.Address(RVA = "0x736650", Offset = "0x735050", VA = "0x180736650")]
		public Task<UpgradeBuilding.Types.Response> UpgradeBuilding(uint gridId, uint gridObjectId, UpgradeBuilding.Types.BuildingType buildingType, CancellationToken ct, bool cheat = false)
		{
			//Discarded unreachable code: IL_0032
			UpgradeBuilding.Types.Request request = new UpgradeBuilding.Types.Request();
			request.cheatForced_ = false;
			request.gridID_ = gridId;
			request.gridObjectID_ = gridObjectId;
			request.buildingType_ = buildingType;
			TransactionService.TransactionServiceClient clientService = (TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService;
			Task<UpgradeBuilding.Types.Response> result = default(Task<UpgradeBuilding.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A42")]
		[Cpp2IlInjected.Address(RVA = "0x728870", Offset = "0x727270", VA = "0x180728870")]
		[AsyncStateMachine(typeof(_003CBuildHouse_003Ed__420))]
		public Task<BuildHouse.Types.Response> BuildHouse(uint gridId, uint gridObjectId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<BuildHouse.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A43")]
		[Cpp2IlInjected.Address(RVA = "0x729020", Offset = "0x727A20", VA = "0x180729020")]
		[AsyncStateMachine(typeof(_003CBuyStoreBundle_003Ed__421))]
		public Task<CRMBuyResult> BuyStoreBundle(string bundleId, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CRMBuyResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A44")]
		[Cpp2IlInjected.Address(RVA = "0x728D60", Offset = "0x727760", VA = "0x180728D60")]
		[AsyncStateMachine(typeof(_003CBuyOffline_003Ed__422))]
		public Task<CRMBuyResult> BuyOffline(string bundleId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CRMBuyResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A45")]
		[Cpp2IlInjected.Address(RVA = "0x736480", Offset = "0x734E80", VA = "0x180736480")]
		public Task<UpdateRoyalDutySlots.Types.Response> UpdateRoyalDutySlotsAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			UpdateRoyalDutySlots.Types.Request request = new UpdateRoyalDutySlots.Types.Request();
			return (Task<UpdateRoyalDutySlots.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateRoyalDutySlotsAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A46")]
		[Cpp2IlInjected.Address(RVA = "0x72BE90", Offset = "0x72A890", VA = "0x18072BE90")]
		public Task<DebugGenerateNewRoyalDuties.Types.Response> DebugGenerateNewRoyalDutiesAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			DebugGenerateNewRoyalDuties.Types.Request request = new DebugGenerateNewRoyalDuties.Types.Request();
			return (Task<DebugGenerateNewRoyalDuties.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugGenerateNewRoyalDutiesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A47")]
		[Cpp2IlInjected.Address(RVA = "0x72A620", Offset = "0x729020", VA = "0x18072A620")]
		public Task<CollectRoyalDutyReward.Types.Response> CollectRoyalDutyRewardAsync(int slotID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			CollectRoyalDutyReward.Types.Request request = new CollectRoyalDutyReward.Types.Request();
			request.royalDutySlotID_ = slotID;
			return (Task<CollectRoyalDutyReward.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectRoyalDutyRewardAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A48")]
		[Cpp2IlInjected.Address(RVA = "0x731C20", Offset = "0x730620", VA = "0x180731C20")]
		public Task<UpdateTimeAcumulated.Types.Response> ResetUncursedTimeAcumulatedAsync(int newValue, [Optional] CancellationToken ct)
		{
			//IL_0022: Expected I4, but got I8
			//IL_0038: Expected I4, but got I8
			if (profile.world_.uncursedLightLockedTimer_ == newValue)
			{
				UpdateTimeAcumulated.Types.Response response = new UpdateTimeAcumulated.Types.Response();
				response.result_ = UpdateTimeAcumulated.Types.Result.Error;
				return (Task<UpdateTimeAcumulated.Types.Response>)(object)Task.FromResult(response);
			}
			UpdateTimeAcumulated.Types.Request request = new UpdateTimeAcumulated.Types.Request();
			request.timerType_ = ProfileTimerType.Uncursed;
			request.minutesPassed_ = newValue;
			Task<UpdateTimeAcumulated.Types.Response> task = (Task<UpdateTimeAcumulated.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateTimeAcumulatedAsync(request, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007A49")]
		[Cpp2IlInjected.Address(RVA = "0x736530", Offset = "0x734F30", VA = "0x180736530")]
		public Task<UpdateTimeAcumulated.Types.Response> UpdateTimeAcumulatedAsync(int minutesPassed, ProfileTimerType timerType, [Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			UpdateTimeAcumulated.Types.Request request = new UpdateTimeAcumulated.Types.Request();
			request.minutesPassed_ = minutesPassed;
			request.timerType_ = timerType;
			return (Task<UpdateTimeAcumulated.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).UpdateTimeAcumulatedAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4A")]
		[Cpp2IlInjected.Address(RVA = "0x72A060", Offset = "0x728A60", VA = "0x18072A060")]
		public Task<CollectAchievementReward.Types.Response> CollectAchievementRewardAsync(int achID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			CollectAchievementReward.Types.Request request = new CollectAchievementReward.Types.Request();
			request.achID_ = achID;
			return (Task<CollectAchievementReward.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).CollectAchievementRewardAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4B")]
		[Cpp2IlInjected.Address(RVA = "0x72B5F0", Offset = "0x729FF0", VA = "0x18072B5F0")]
		public Task<DebugCompleteAchievementMilestone.Types.Response> DebugCompleteAchievementMilestoneAsync(int achID, int milestone, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			DebugCompleteAchievementMilestone.Types.Request request = new DebugCompleteAchievementMilestone.Types.Request();
			request.achID_ = achID;
			request.milestone_ = milestone;
			return (Task<DebugCompleteAchievementMilestone.Types.Response>)(object)((TransactionService.TransactionServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ClientService).DebugCompleteAchievementMilestoneAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4C")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734150", VA = "0x180735750")]
		public Task<bool> TryInventoryFullFlow(IInventoryFullRequest request, IInventoryFullResponse response)
		{
			InventoryFullFlowDelegate onInventoryFull;
			do
			{
				onInventoryFull = this.OnInventoryFull;
			}
			while (onInventoryFull != null && onInventoryFull(request, response) != null);
			return (Task<bool>)(object)Task.FromResult(result: false);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4D")]
		[Cpp2IlInjected.Address(RVA = "0x732110", Offset = "0x730B10", VA = "0x180732110")]
		public static void Select(ThreadMarker tm)
		{
			int stringLength = tm.Id.m_stringLength;
			if (!tm.Cancel)
			{
				uint millisecondsTimeout = default(uint);
				Thread.Sleep((int)millisecondsTimeout);
			}
			string _003CId_003Ek__BackingField = tm.Id;
			int _003CIdx_003Ek__BackingField = tm.Idx;
			int num = (tm.Idx = _003CIdx_003Ek__BackingField + 1);
			char c = _003CId_003Ek__BackingField[_003CIdx_003Ek__BackingField];
			while ((long)typeof(Client).TypeHandle > 5)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4E")]
		[Cpp2IlInjected.Address(RVA = "0x737170", Offset = "0x735B70", VA = "0x180737170")]
		private static void _0(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A4F")]
		[Cpp2IlInjected.Address(RVA = "0x7371D0", Offset = "0x735BD0", VA = "0x1807371D0")]
		private static void _1(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A50")]
		[Cpp2IlInjected.Address(RVA = "0x737230", Offset = "0x735C30", VA = "0x180737230")]
		private static void _2(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A51")]
		[Cpp2IlInjected.Address(RVA = "0x737290", Offset = "0x735C90", VA = "0x180737290")]
		private static void _3(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A52")]
		[Cpp2IlInjected.Address(RVA = "0x7372F0", Offset = "0x735CF0", VA = "0x1807372F0")]
		private static void _4(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A53")]
		[Cpp2IlInjected.Address(RVA = "0x737350", Offset = "0x735D50", VA = "0x180737350")]
		private static void _5(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A54")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0")]
		private static void _6(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A55")]
		[Cpp2IlInjected.Address(RVA = "0x737410", Offset = "0x735E10", VA = "0x180737410")]
		private static void _7(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A56")]
		[Cpp2IlInjected.Address(RVA = "0x737470", Offset = "0x735E70", VA = "0x180737470")]
		private static void _8(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A57")]
		[Cpp2IlInjected.Address(RVA = "0x7374D0", Offset = "0x735ED0", VA = "0x1807374D0")]
		private static void _9(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A58")]
		[Cpp2IlInjected.Address(RVA = "0x728370", Offset = "0x726D70", VA = "0x180728370")]
		private static void A(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A59")]
		[Cpp2IlInjected.Address(RVA = "0x728810", Offset = "0x727210", VA = "0x180728810")]
		private static void B(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5A")]
		[Cpp2IlInjected.Address(RVA = "0x729180", Offset = "0x727B80", VA = "0x180729180")]
		private static void C(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5B")]
		[Cpp2IlInjected.Address(RVA = "0x72ACD0", Offset = "0x7296D0", VA = "0x18072ACD0")]
		private static void D(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5C")]
		[Cpp2IlInjected.Address(RVA = "0x72D520", Offset = "0x72BF20", VA = "0x18072D520")]
		private static void E(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5D")]
		[Cpp2IlInjected.Address(RVA = "0x72DAB0", Offset = "0x72C4B0", VA = "0x18072DAB0")]
		private static void F(ThreadMarker tm)
		{
			Select(tm);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5E")]
		[Cpp2IlInjected.Address(RVA = "0x728B80", Offset = "0x727580", VA = "0x180728B80")]
		[AsyncStateMachine(typeof(_003CBuyIAP_003Ed__450))]
		public Task<BuyIAP.Types.Response> BuyIAP(BuyIAP.Types.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<BuyIAP.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A5F")]
		[Cpp2IlInjected.Address(RVA = "0x72D280", Offset = "0x72BC80", VA = "0x18072D280")]
		[AsyncStateMachine(typeof(_003CDownloadLikes_003Ed__451))]
		private Task DownloadLikes(RepeatedField<NewsFeedPost> list)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A60")]
		[Cpp2IlInjected.Address(RVA = "0x72F9B0", Offset = "0x72E3B0", VA = "0x18072F9B0")]
		private void OverrideLikes(string ugcItemId, bool likedByMe, int inc)
		{
			//Discarded unreachable code: IL_008d
			TimedCachedValue<CreateNewsFeed.Types.Response> newsFeedCache = NewsFeedCache;
			if (newsFeedCache != null && ((TimedCachedValue<>)(object)newsFeedCache).Value != null)
			{
				Func<NewsFeedPost, bool> func = (Func<NewsFeedPost, bool>)(object)(Func<T, TResult>)delegate(NewsFeedPost x)
				{
					//Discarded unreachable code: IL_0014
					string b2 = ugcItemId;
					return string.Equals(x.itemId_, b2);
				};
				Action<NewsFeedPost> action = (Action<NewsFeedPost>)(object)(Action<T>)delegate(NewsFeedPost x)
				{
					//Discarded unreachable code: IL_001e
					NewsFeedUserPost userPost2 = x.UserPost;
					int inc3 = inc;
					bool likedByMe3 = likedByMe;
					userPost2.OverrideLikes(likedByMe3, inc3);
				};
				IEnumerable<NewsFeedPost> enumerable = default(IEnumerable<NewsFeedPost>);
				MoreLinq.ForEach<NewsFeedPost>((IEnumerable<>)enumerable, (Action<>)(object)action);
			}
			TimedCachedValue<SuggestFollower.Types.Response> suggestFollowerCache = SuggestFollowerCache;
			if (suggestFollowerCache != null && ((TimedCachedValue<>)(object)suggestFollowerCache).Value != null)
			{
				Func<NewsFeedPost, bool> func2 = (Func<NewsFeedPost, bool>)(object)(Func<T, TResult>)delegate(NewsFeedPost x)
				{
					//Discarded unreachable code: IL_0014
					string b = ugcItemId;
					return string.Equals(x.itemId_, b);
				};
				Action<NewsFeedPost> action2 = (Action<NewsFeedPost>)(object)(Action<T>)delegate(NewsFeedPost x)
				{
					//Discarded unreachable code: IL_001e
					NewsFeedUserPost userPost = x.UserPost;
					int inc2 = inc;
					bool likedByMe2 = likedByMe;
					userPost.OverrideLikes(likedByMe2, inc2);
				};
				IEnumerable<NewsFeedPost> enumerable2 = default(IEnumerable<NewsFeedPost>);
				MoreLinq.ForEach<NewsFeedPost>((IEnumerable<>)enumerable2, (Action<>)(object)action2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007A61")]
		[Cpp2IlInjected.Address(RVA = "0x72AB80", Offset = "0x729580", VA = "0x18072AB80")]
		[AsyncStateMachine(typeof(_003CCreateNewsFeed_003Ed__454))]
		public Task<CreateNewsFeed.Types.Response> CreateNewsFeed(CancellationToken ct, bool forceRefresh = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CreateNewsFeed.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A62")]
		[Cpp2IlInjected.Address(RVA = "0x72E440", Offset = "0x72CE40", VA = "0x18072E440")]
		[AsyncStateMachine(typeof(_003CGetMyPostList_003Ed__457))]
		public Task<GetUserPosts.Types.Response> GetMyPostList(CancellationToken ct, bool forceRefresh = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetUserPosts.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A63")]
		[Cpp2IlInjected.Address(RVA = "0x730110", Offset = "0x72EB10", VA = "0x180730110")]
		public Task<PostLogin.Types.Response> PostLogin(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001b
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			PostLogin.Types.Request request = new PostLogin.Types.Request();
			return (Task<PostLogin.Types.Response>)(object)clientService.PostLoginAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A64")]
		[Cpp2IlInjected.Address(RVA = "0x7286E0", Offset = "0x7270E0", VA = "0x1807286E0")]
		public Task<AutoRedeemFoundersPack.Types.Response> AutoRedeemFoundersPack(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001b
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			AutoRedeemFoundersPack.Types.Request request = new AutoRedeemFoundersPack.Types.Request();
			return (Task<AutoRedeemFoundersPack.Types.Response>)(object)clientService.AutoRedeemFoundersPackAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A65")]
		[Cpp2IlInjected.Address(RVA = "0x7355E0", Offset = "0x733FE0", VA = "0x1807355E0")]
		public Task<TransferMarketplacePacks.Types.Response> TransferMarketplacePacks(string sourceEntityToken, string gameloftIdLink, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			TransferMarketplacePacks.Types.Request request = new TransferMarketplacePacks.Types.Request();
			request.SourceEntityToken = sourceEntityToken;
			request.GameloftIdLink = gameloftIdLink;
			return (Task<TransferMarketplacePacks.Types.Response>)(object)clientService.TransferMarketplacePacksAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A66")]
		[Cpp2IlInjected.Address(RVA = "0x7301C0", Offset = "0x72EBC0", VA = "0x1807301C0")]
		[AsyncStateMachine(typeof(_003CPostPicture_003Ed__461))]
		public Task<PostPicture.Types.Response> PostPicture(CancellationToken ct, PictureRecipe recipe, bool applyToEvent)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PostPicture.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A67")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x731CF0", VA = "0x1807332F0")]
		[AsyncStateMachine(typeof(_003CSetPlayfabAvatar_003Ed__462))]
		public Task<SetPlayfabAvatar.Types.Response> SetPlayfabAvatar(CancellationToken ct, byte[] avatar)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SetPlayfabAvatar.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A68")]
		[Cpp2IlInjected.Address(RVA = "0x72EF00", Offset = "0x72D900", VA = "0x18072EF00")]
		[AsyncStateMachine(typeof(_003CLikeNewsFeed_003Ed__463))]
		public Task<LikeNewsFeed.Types.Response> LikeNewsFeed(CancellationToken ct, string ugcItemId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LikeNewsFeed.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A69")]
		[Cpp2IlInjected.Address(RVA = "0x735CC0", Offset = "0x7346C0", VA = "0x180735CC0")]
		[AsyncStateMachine(typeof(_003CUnlikeNewsFeed_003Ed__464))]
		public Task<UnlikeNewsFeed.Types.Response> UnlikeNewsFeed(CancellationToken ct, string ugcItemId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<UnlikeNewsFeed.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6A")]
		[Cpp2IlInjected.Address(RVA = "0x733450", Offset = "0x731E50", VA = "0x180733450")]
		[AsyncStateMachine(typeof(_003CSetPlayfabName_003Ed__465))]
		public Task<SetPlayfabName.Types.Response> SetPlayfabName(CancellationToken ct, string userName)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SetPlayfabName.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6B")]
		[Cpp2IlInjected.Address(RVA = "0x72E1A0", Offset = "0x72CBA0", VA = "0x18072E1A0")]
		[AsyncStateMachine(typeof(_003CGetFollowData_003Ed__466))]
		public Task<GetFollowData.Types.Response> GetFollowData(CancellationToken ct, bool getFollowings = true, bool getFollowers = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetFollowData.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6C")]
		[Cpp2IlInjected.Address(RVA = "0x72DCB0", Offset = "0x72C6B0", VA = "0x18072DCB0")]
		[AsyncStateMachine(typeof(_003CFollowUser_003Ed__467))]
		public Task<FollowUser.Types.Response> FollowUser(CancellationToken ct, string friendPlayfabId, [Optional] string friendTitleId, bool unfollow = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FollowUser.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6D")]
		[Cpp2IlInjected.Address(RVA = "0x734DE0", Offset = "0x7337E0", VA = "0x180734DE0")]
		[AsyncStateMachine(typeof(_003CSuggestFollower_003Ed__469))]
		public Task<SuggestFollower.Types.Response> SuggestFollower(CancellationToken ct, bool forceRefresh = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SuggestFollower.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6E")]
		[Cpp2IlInjected.Address(RVA = "0x731F30", Offset = "0x730930", VA = "0x180731F30")]
		[AsyncStateMachine(typeof(_003CSearchFriends_003Ed__470))]
		public Task<SearchFriends.Types.Response> SearchFriends(CancellationToken ct, string search)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SearchFriends.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A6F")]
		[Cpp2IlInjected.Address(RVA = "0x72E300", Offset = "0x72CD00", VA = "0x18072E300")]
		[AsyncStateMachine(typeof(_003CGetInbox_003Ed__471))]
		public Task<GetInbox.Types.Response> GetInbox(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GetInbox.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A70")]
		[Cpp2IlInjected.Address(RVA = "0x731040", Offset = "0x72FA40", VA = "0x180731040")]
		[AsyncStateMachine(typeof(_003CReadInboxMessage_003Ed__472))]
		public Task<ReadInboxMessages.Types.Response> ReadInboxMessage(InboxMessageKey messageKey, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ReadInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A71")]
		[Cpp2IlInjected.Address(RVA = "0x7311A0", Offset = "0x72FBA0", VA = "0x1807311A0")]
		[AsyncStateMachine(typeof(_003CReadInboxMessages_003Ed__473))]
		public Task<ReadInboxMessages.Types.Response> ReadInboxMessages(List<InboxMessageKey> messageKeys, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ReadInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A72")]
		[Cpp2IlInjected.Address(RVA = "0x729A10", Offset = "0x728410", VA = "0x180729A10")]
		[AsyncStateMachine(typeof(_003CClaimInboxMessage_003Ed__474))]
		public Task<ClaimInboxMessages.Types.Response> ClaimInboxMessage(InboxMessageKey messageKey, bool autoClaim, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A73")]
		[Cpp2IlInjected.Address(RVA = "0x729B80", Offset = "0x728580", VA = "0x180729B80")]
		[AsyncStateMachine(typeof(_003CClaimInboxMessages_003Ed__475))]
		public Task<ClaimInboxMessages.Types.Response> ClaimInboxMessages(List<InboxMessageKey> messageKeys, bool autoClaim, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A74")]
		[Cpp2IlInjected.Address(RVA = "0x731300", Offset = "0x72FD00", VA = "0x180731300")]
		public Task<RefundInboxMessages.Types.Response> RefundInboxMessage(InboxMessageKey messageKey, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)messageKey);
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<RefundInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A75")]
		[Cpp2IlInjected.Address(RVA = "0x7314D0", Offset = "0x72FED0", VA = "0x1807314D0")]
		[AsyncStateMachine(typeof(_003CRefundInboxMessages_003Ed__477))]
		public Task<RefundInboxMessages.Types.Response> RefundInboxMessages(List<InboxMessageKey> messageKeys, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<RefundInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A76")]
		[Cpp2IlInjected.Address(RVA = "0x730A90", Offset = "0x72F490", VA = "0x180730A90")]
		public Task<PurgeInbox.Types.Response> PurgeInbox(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001b
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			PurgeInbox.Types.Request request = new PurgeInbox.Types.Request();
			return (Task<PurgeInbox.Types.Response>)(object)clientService.PurgeInboxAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A77")]
		[Cpp2IlInjected.Address(RVA = "0x728450", Offset = "0x726E50", VA = "0x180728450")]
		public Task<AddInboxMessage.Types.Response> AddRewardInboxMessage(CancellationToken ct, int numberOfMessages)
		{
			//Discarded unreachable code: IL_0022
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			AddInboxMessage.Types.Request request = new AddInboxMessage.Types.Request();
			request.messageNum_ = numberOfMessages;
			return (Task<AddInboxMessage.Types.Response>)(object)clientService.AddInboxMessageAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A78")]
		[Cpp2IlInjected.Address(RVA = "0x731800", Offset = "0x730200", VA = "0x180731800")]
		public Task<RemoveInboxMessage.Types.Response> RemoveInboxMessage(List<InboxMessageKey> messageKeys, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0025
			RemoveInboxMessage.Types.Request request = new RemoveInboxMessage.Types.Request();
			((RepeatedField<T>)(object)request.messagesToRemove_).AddRange((IEnumerable<>)messageKeys);
			return (Task<RemoveInboxMessage.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).RemoveInboxMessageAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A79")]
		[Cpp2IlInjected.Address(RVA = "0x72E070", Offset = "0x72CA70", VA = "0x18072E070")]
		public Task<GetBundles.Types.Response> GetBundles(CancellationToken ct, List<KnownLiveopsItem> knownBundles)
		{
			//Discarded unreachable code: IL_0039
			GetBundles.Types.Request request = new GetBundles.Types.Request();
			int num = 0;
			bool flag = (request.includeScheduled_ = DebugSettings.Settings.showScheduledBundlesAndStores_);
			((RepeatedField<T>)(object)request.knownItems_).AddRange((IEnumerable<>)knownBundles);
			return (Task<GetBundles.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).GetBundlesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A7A")]
		[Cpp2IlInjected.Address(RVA = "0x72E840", Offset = "0x72D240", VA = "0x18072E840")]
		public Task<GetStores.Types.Response> GetStores(CancellationToken ct, List<KnownLiveopsItem> knownStores)
		{
			//Discarded unreachable code: IL_0039
			GetStores.Types.Request request = new GetStores.Types.Request();
			int num = 0;
			bool flag = (request.includeScheduled_ = DebugSettings.Settings.showScheduledBundlesAndStores_);
			((RepeatedField<T>)(object)request.knownItems_).AddRange((IEnumerable<>)knownStores);
			return (Task<GetStores.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).GetStoresAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A7B")]
		[Cpp2IlInjected.Address(RVA = "0x734CE0", Offset = "0x7336E0", VA = "0x180734CE0")]
		public Task<StorePurchase.Types.Response> StorePurchase(CancellationToken ct, string storeId, string contentId, int priceAmount, int currencyId, int contentVersion = -1)
		{
			//Discarded unreachable code: IL_003c
			StorePurchase.Types.Request request = new StorePurchase.Types.Request();
			request.StoreId = storeId;
			request.ContentId = contentId;
			request.priceAmount_ = 0;
			request.currencyId_ = 0;
			request.contentVersion_ = 0;
			return (Task<StorePurchase.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).StorePurchaseAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A7C")]
		[Cpp2IlInjected.Address(RVA = "0x72F810", Offset = "0x72E210", VA = "0x18072F810")]
		public Task<OnlineClaimPromoCode.Types.Response> OnlineClaimPromoCode(string promoCodeId, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			OnlineClaimPromoCode.Types.Request request = new OnlineClaimPromoCode.Types.Request();
			request.PromoCodeId = promoCodeId;
			return (Task<OnlineClaimPromoCode.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).OnlineClaimPromoCodeAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A7F")]
		[Cpp2IlInjected.Address(RVA = "0x72DF30", Offset = "0x72C930", VA = "0x18072DF30")]
		public Task<GetBattlePasses.Types.Response> GetBattlePasses(CancellationToken ct, List<KnownLiveopsItem> knownBattlePasses)
		{
			//Discarded unreachable code: IL_0042
			GetBattlePasses.Types.Request request = new GetBattlePasses.Types.Request();
			if (AppConfigType == ApplicationConfigurationType.Editor)
			{
			}
			int num = 0;
			bool flag = (request.includeScheduled_ = DebugSettings.Settings.showScheduledStarPathEvents_);
			((RepeatedField<T>)(object)request.knownItems_).AddRange((IEnumerable<>)knownBattlePasses);
			return (Task<GetBattlePasses.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).GetBattlePassesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A80")]
		[Cpp2IlInjected.Address(RVA = "0x72A120", Offset = "0x728B20", VA = "0x18072A120")]
		public Task<CollectBattlePassTaskCurrency.Types.Response> CollectBattlePassTaskCurrency(string battlePassOnlineId, int taskIdx, string currencyOnlineId, string currencyOnlineType, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			CollectBattlePassTaskCurrency.Types.Request request = new CollectBattlePassTaskCurrency.Types.Request();
			request.BattlePassOnlineId = battlePassOnlineId;
			request.taskIdx_ = taskIdx;
			request.CurrencyOnlineId = currencyOnlineId;
			Task<CollectBattlePassTaskCurrency.Types.Response> result = default(Task<CollectBattlePassTaskCurrency.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A81")]
		[Cpp2IlInjected.Address(RVA = "0x730870", Offset = "0x72F270", VA = "0x180730870")]
		public Task<PurchaseBattlePassReward.Types.Response> PurchaseBattlePassReward(string bpOnlineId, int rewardIdx, string currencyOnlineId, string currencyOnlineType, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			PurchaseBattlePassReward.Types.Request request = new PurchaseBattlePassReward.Types.Request();
			request.BattlePassOnlineId = bpOnlineId;
			request.rewardIdx_ = rewardIdx;
			request.CurrencyOnlineId = currencyOnlineId;
			Task<PurchaseBattlePassReward.Types.Response> result = default(Task<PurchaseBattlePassReward.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A82")]
		[Cpp2IlInjected.Address(RVA = "0x730980", Offset = "0x72F380", VA = "0x180730980")]
		public Task<PurchasePremiumPass.Types.Response> PurchasePremiumPass(string bpOnlineId, bool purchaseBundle, string currencyOnlineId, string currencyOnlineType, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0029
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			PurchasePremiumPass.Types.Request request = new PurchasePremiumPass.Types.Request();
			request.BattlePassOnlineId = bpOnlineId;
			request.purchaseBundle_ = purchaseBundle;
			request.CurrencyOnlineId = currencyOnlineId;
			Task<PurchasePremiumPass.Types.Response> result = default(Task<PurchasePremiumPass.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A83")]
		[Cpp2IlInjected.Address(RVA = "0x730760", Offset = "0x72F160", VA = "0x180730760")]
		public Task<PurchaseBattlePassCurrency.Types.Response> PurchaseBattlePassCurrency(string bpOnlineId, string currencyOnlineId, string currencyOnlineType, int amountToBuy, bool useBundlePromo, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0037
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			PurchaseBattlePassCurrency.Types.Request request = new PurchaseBattlePassCurrency.Types.Request();
			request.BattlePassOnlineId = bpOnlineId;
			request.CurrencyOnlineId = currencyOnlineId;
			request.CurrencyOnlineType = currencyOnlineType;
			request.amountToBuy_ = 0;
			request.useBundlePromo_ = false;
			Task<PurchaseBattlePassCurrency.Types.Response> result = default(Task<PurchaseBattlePassCurrency.Types.Response>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A84")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D0", Offset = "0x729AD0", VA = "0x18072B0D0")]
		public Task<DebugAddOnlineCurrency.Types.Response> DebugAddOnlineCurrency(Item item, int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0030
			int itemID = item.ItemID;
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			DebugAddOnlineCurrency.Types.Request request = new DebugAddOnlineCurrency.Types.Request();
			request.currencyID_ = itemID;
			request.currencyAmount_ = amount;
			return (Task<DebugAddOnlineCurrency.Types.Response>)(object)clientService.DebugAddOnlineCurrencyAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A85")]
		[Cpp2IlInjected.Address(RVA = "0x72C920", Offset = "0x72B320", VA = "0x18072C920")]
		public Task<DebugSpendOnlineCurrency.Types.Response> DebugSpendOnlineCurrency(Item item, int amount, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0030
			int itemID = item.ItemID;
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			DebugSpendOnlineCurrency.Types.Request request = new DebugSpendOnlineCurrency.Types.Request();
			request.currencyID_ = itemID;
			request.currencyAmount_ = amount;
			return (Task<DebugSpendOnlineCurrency.Types.Response>)(object)clientService.DebugSpendOnlineCurrencyAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A86")]
		[Cpp2IlInjected.Address(RVA = "0x735160", Offset = "0x733B60", VA = "0x180735160")]
		public Task<SyncOnline.Types.Response> SyncOnline(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0084
			SyncOnline.Types.Request request = new SyncOnline.Types.Request();
			OnlineClient onlineClient = OnlineClient;
			MapField<string, string> battlePassIds_ = request.battlePassIds_;
			List<BattlePassSeasonData> battlePasses = (List<BattlePassSeasonData>)(object)onlineClient.GetBattlePasses();
			Func<BattlePassSeasonData, string> _003C_003E9__496_ = _003C_003Ec._003C_003E9__496_0;
			if (_003C_003E9__496_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassSeasonData x) => x.currencyOnlineId_);
			}
			Func<BattlePassSeasonData, string> func = default(Func<BattlePassSeasonData, string>);
			if (_003C_003Ec._003C_003E9__496_1 == null)
			{
				func = (Func<BattlePassSeasonData, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((BattlePassSeasonData y) => y.onlineId_));
			}
			Dictionary<BattlePassSeasonData, string> dictionary = (Dictionary<BattlePassSeasonData, string>)(object)Enumerable.ToDictionary<BattlePassSeasonData, string, string>((IEnumerable<>)battlePasses, (Func<, >)(object)_003C_003E9__496_, (Func<, >)(object)func);
			((MapField<TKey, TValue>)(object)battlePassIds_).Add((IDictionary<, >)dictionary);
			return (Task<SyncOnline.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).SyncOnlineAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A87")]
		[Cpp2IlInjected.Address(RVA = "0x7350E0", Offset = "0x733AE0", VA = "0x1807350E0")]
		public Task<SyncOnlineInventory.Types.Response> SyncOnlineInventory(SyncOnlineInventory.Types.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0013
			return (Task<SyncOnlineInventory.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).SyncOnlineInventoryAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A88")]
		[Cpp2IlInjected.Address(RVA = "0x735030", Offset = "0x733A30", VA = "0x180735030")]
		public Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrencies(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001b
			SocialService.SocialServiceClient clientService = (SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService;
			SyncOnlineCurrencies.Types.Request request = new SyncOnlineCurrencies.Types.Request();
			return (Task<SyncOnlineCurrencies.Types.Response>)(object)clientService.SyncOnlineCurrenciesAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A89")]
		[Cpp2IlInjected.Address(RVA = "0x72F8E0", Offset = "0x72E2E0", VA = "0x18072F8E0")]
		public Task<OnlineCollectLootPresent.Types.Response> OnlineCollectLootPresent(uint gridID, uint gridObjectID, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			OnlineCollectLootPresent.Types.Request request = new OnlineCollectLootPresent.Types.Request();
			request.gridID_ = gridID;
			request.gridObjectID_ = gridObjectID;
			return (Task<OnlineCollectLootPresent.Types.Response>)(object)((SocialService.SocialServiceClient)(object)((Simulator<SERVER, CLIENT>)(object)socialSimulator).ClientService).OnlineCollectLootPresentAsync(request, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007A8A")]
		[Cpp2IlInjected.Address(RVA = "0x729480", Offset = "0x727E80", VA = "0x180729480")]
		[AsyncStateMachine(typeof(_003CCheat_ChangeName_003Ed__500))]
		public Task<bool> Cheat_ChangeName(CancellationToken ct, string name)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007A8B")]
		[Cpp2IlInjected.Address(RVA = "0x737530", Offset = "0x735F30", VA = "0x180737530")]
		static Client()
		{
			//IL_000b: Expected I4, but got O
			//IL_0016: Expected I4, but got O
			//IL_0021: Expected I4, but got O
			TimeSpan cacheDelay = default(TimeSpan);
			InvalidOnlineVersion = (int)new TimedCachedValue<T>(cacheDelay);
			TimeSpan cacheDelay2 = default(TimeSpan);
			InvalidOnlineVersion = (int)new TimedCachedValue<T>(cacheDelay2);
			TimeSpan cacheDelay3 = default(TimeSpan);
			InvalidOnlineVersion = (int)new TimedCachedValue<T>(cacheDelay3);
			/*Error: Unexpected end of block*/;
		}
	}
}
