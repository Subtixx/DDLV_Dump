using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public class PreGameLoad
	{
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		public class PlayerProfileSearchTokens
		{
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			public static readonly string InboxMessages;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlayerProfileSearchTokens()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x392EFA0", Offset = "0x392D9A0", VA = "0x18392EFA0")]
			static PlayerProfileSearchTokens()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013F")]
		[JsonObject]
		public class DataFragments
		{
			[Cpp2IlInjected.Token(Token = "0x2000140")]
			public enum ProcessingResult
			{
				[Cpp2IlInjected.Token(Token = "0x40005EA")]
				NotProcessed,
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				ReceivedDataEmpty,
				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				ReceivedDataSizeError,
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				ReceivedDataParseError,
				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				ReceivedDataOk,
				[Cpp2IlInjected.Token(Token = "0x40005EF")]
				NoFixRequired,
				[Cpp2IlInjected.Token(Token = "0x40005F0")]
				SendingNewData,
				[Cpp2IlInjected.Token(Token = "0x40005F1")]
				ProcessException
			}

			[Cpp2IlInjected.Token(Token = "0x2000141")]
			public enum ImplProcessingResult
			{
				[Cpp2IlInjected.Token(Token = "0x40005F3")]
				NotProccessed,
				[Cpp2IlInjected.Token(Token = "0x40005F4")]
				DataError,
				[Cpp2IlInjected.Token(Token = "0x40005F5")]
				NoFixRequired,
				[Cpp2IlInjected.Token(Token = "0x40005F6")]
				FixToApply
			}

			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			public static readonly string AllFileSearchToken = "";

			[Cpp2IlInjected.Token(Token = "0x170000C1")]
			[JsonProperty]
			public OnlineDataFileInfo FileInfo
			{
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CFileInfo_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CFileInfo_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			[JsonProperty]
			public string jsonSelectToken
			{
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CjsonSelectToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CjsonSelectToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			[JsonProperty]
			public string jsonTokenAsStr
			{
				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CjsonTokenAsStr_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CjsonTokenAsStr_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			[JsonProperty]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40005E5")]
			public int jsonTokenStrSize
			{
				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			[JsonProperty]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x40005E6")]
			public ProcessingResult InnerProcessResult
			{
				[Cpp2IlInjected.Token(Token = "0x600041F")]
				[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000C6")]
			[JsonProperty]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40005E7")]
			public ImplProcessingResult ImplProcessResult
			{
				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000C7")]
			[JsonIgnore]
			public JToken CachedJToken
			{
				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CCachedJToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				private set
				{
					_003CCachedJToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C8")]
			public bool HasJsonData
			{
				[Cpp2IlInjected.Token(Token = "0x6000425")]
				[Cpp2IlInjected.Address(RVA = "0x539530", Offset = "0x537F30", VA = "0x180539530")]
				get
				{
					return !string.IsNullOrEmpty(jsonTokenAsStr);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C9")]
			public int JsonCompressedSize
			{
				[Cpp2IlInjected.Token(Token = "0x6000426")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get
				{
					return jsonTokenStrSize;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			public string UniqueKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000427")]
				[Cpp2IlInjected.Address(RVA = "0x121A4F0", Offset = "0x1218EF0", VA = "0x18121A4F0")]
				get
				{
					//Discarded unreachable code: IL_000c
					return FileInfo.filename;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x384E360", Offset = "0x384CD60", VA = "0x18384E360")]
			public void SetDoesNotRequireFix()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x392E8A0", Offset = "0x392D2A0", VA = "0x18392E8A0")]
			public ProcessingResult WithProcessResult(ProcessingResult processResult)
			{
				InnerProcessResult = processResult;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x392E890", Offset = "0x392D290", VA = "0x18392E890")]
			public ImplProcessingResult WithImplProcessResult(ImplProcessingResult implProcessResult)
			{
				ImplProcessResult = implProcessResult;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x392E630", Offset = "0x392D030", VA = "0x18392E630")]
			public void ResetInternalData()
			{
				//IL_0009: Expected O, but got I8
				//IL_0012: Expected I4, but got I8
				jsonTokenAsStr = (string)0;
				jsonTokenStrSize = 0;
			}

			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x392E530", Offset = "0x392CF30", VA = "0x18392E530")]
			public void ClearCachedJToken()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x392E550", Offset = "0x392CF50", VA = "0x18392E550")]
			public void FromJToken(JToken token)
			{
				//IL_0009: Expected O, but got I8
				//IL_0012: Expected I4, but got I8
				//IL_0042: Expected I4, but got O
				string text;
				while (true)
				{
					jsonTokenAsStr = (string)0;
					jsonTokenStrSize = 0;
					if (token != null)
					{
						text = JsonConvert.SerializeObject(token);
						if (text == null)
						{
							break;
						}
					}
				}
				string text2 = (jsonTokenAsStr = Compression.CompressAndEncode(text));
				string text3 = jsonTokenAsStr;
				if (text3 != null)
				{
				}
				jsonTokenStrSize = (int)text3;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x392E660", Offset = "0x392D060", VA = "0x18392E660")]
			private void ToInternalData(JToken token)
			{
				//IL_0009: Expected O, but got I4
				int num = 0;
				jsonTokenAsStr = (string)num;
				jsonTokenStrSize = num;
				if (token == null)
				{
					return;
				}
				string text = JsonConvert.SerializeObject(token);
				if (text == null)
				{
					string text2 = (jsonTokenAsStr = Compression.CompressAndEncode(text));
					if (jsonTokenAsStr != null)
					{
					}
					jsonTokenStrSize = num;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x392E730", Offset = "0x392D130", VA = "0x18392E730")]
			public JToken ToJToken()
			{
				if (TryCacheObject() == ProcessingResult.ReceivedDataOk)
				{
					return CachedJToken;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x392E760", Offset = "0x392D160", VA = "0x18392E760")]
			public ProcessingResult TryCacheObject()
			{
				//Discarded unreachable code: IL_006a
				//IL_0014: Expected O, but got I8
				//IL_005d: Expected I4, but got I8
				//IL_0068: Expected I4, but got I8
				if ((long)CachedJToken == 0)
				{
					CachedJToken = (JToken)0;
					if (!string.IsNullOrEmpty(jsonTokenAsStr))
					{
						string text = jsonTokenAsStr;
						if (text.m_stringLength != jsonTokenStrSize)
						{
							InnerProcessResult = ProcessingResult.ReceivedDataSizeError;
						}
						JToken jToken = (CachedJToken = JToken.Parse(Compression.DecompressAndDecode(text)));
						return ProcessingResult.ReceivedDataParseError;
					}
					InnerProcessResult = ProcessingResult.ReceivedDataEmpty;
					return ProcessingResult.ReceivedDataEmpty;
				}
				InnerProcessResult = ProcessingResult.ReceivedDataOk;
				return ProcessingResult.ReceivedDataOk;
			}

			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DataFragments()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x392E8B0", Offset = "0x392D2B0", VA = "0x18392E8B0")]
			static DataFragments()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000142")]
		public class OnlineProfileUpdaterTransferData
		{
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			public enum ProcessingResult
			{
				[Cpp2IlInjected.Token(Token = "0x40005FB")]
				NotProcessed,
				[Cpp2IlInjected.Token(Token = "0x40005FC")]
				NullData,
				[Cpp2IlInjected.Token(Token = "0x40005FD")]
				NoDataFragments,
				[Cpp2IlInjected.Token(Token = "0x40005FE")]
				NameMismatch,
				[Cpp2IlInjected.Token(Token = "0x40005FF")]
				NameNotFound,
				[Cpp2IlInjected.Token(Token = "0x4000600")]
				DataFragmentError,
				[Cpp2IlInjected.Token(Token = "0x4000601")]
				Processing,
				[Cpp2IlInjected.Token(Token = "0x4000602")]
				DataFragmentProcessException,
				[Cpp2IlInjected.Token(Token = "0x4000603")]
				DataFragmentProcessError,
				[Cpp2IlInjected.Token(Token = "0x4000604")]
				ProcessingOk
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			public List<DataFragments> Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public ProcessingResult ProcessResult;

			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x392EDA0", Offset = "0x392D7A0", VA = "0x18392EDA0")]
			public ProcessingResult WithProcessResult(ProcessingResult result)
			{
				ProcessResult = result;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public OnlineProfileUpdaterTransferData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000144")]
		public class HandShake
		{
			[Cpp2IlInjected.Token(Token = "0x2000145")]
			public class Request
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000605")]
				public int Version;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000606")]
				public int OnlineVersion;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000607")]
				public bool IsDebugBuildType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000608")]
				public string RunningPlatformName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000609")]
				public int InitialVersion;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400060A")]
				public string ProfileCreatedDatetime;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400060B")]
				public string ProfileModifiedDateTime;

				[Cpp2IlInjected.Token(Token = "0x6000436")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Request()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000146")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x400060D")]
				Success
			}

			[Cpp2IlInjected.Token(Token = "0x2000147")]
			public enum Status
			{
				[Cpp2IlInjected.Token(Token = "0x400060F")]
				NotChecked,
				[Cpp2IlInjected.Token(Token = "0x4000610")]
				InvalidVersion,
				[Cpp2IlInjected.Token(Token = "0x4000611")]
				InvalidOnlineVersion,
				[Cpp2IlInjected.Token(Token = "0x4000612")]
				NoUpdateListEmpty,
				[Cpp2IlInjected.Token(Token = "0x4000613")]
				TooManyChainInProfilerUpdater,
				[Cpp2IlInjected.Token(Token = "0x4000614")]
				NoUpdateInitialVersionUpToDate,
				[Cpp2IlInjected.Token(Token = "0x4000615")]
				NoUpdateProfileVersionUpToDate,
				[Cpp2IlInjected.Token(Token = "0x4000616")]
				NoUpdateAvailable,
				[Cpp2IlInjected.Token(Token = "0x4000617")]
				NoUpdateAvailableForThisClientContext,
				[Cpp2IlInjected.Token(Token = "0x4000618")]
				UpdateAvailable
			}

			[Cpp2IlInjected.Token(Token = "0x2000148")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000619")]
				public Status Status;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400061A")]
				public List<OnlineProfileUpdaterTransferData> RequestedData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400061B")]
				public int MaxOnlineVersion;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400061C")]
				public int RegularUpdateCount;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400061D")]
				public int RecurringUpdateCount;

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public Error Error
				{
					[Cpp2IlInjected.Token(Token = "0x6000437")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					[CompilerGenerated]
					get
					{
						return default(Error);
					}
					[Cpp2IlInjected.Token(Token = "0x6000438")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public bool ServerRequestedDataFromClient
				{
					[Cpp2IlInjected.Token(Token = "0x600043B")]
					[Cpp2IlInjected.Address(RVA = "0x39303D0", Offset = "0x392EDD0", VA = "0x1839303D0")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x392F6B0", Offset = "0x392E0B0", VA = "0x18392F6B0")]
				public Result WithError(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithStatus(Status status)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600043C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public HandShake()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000149")]
		public class SendRequestedData
		{
			[Cpp2IlInjected.Token(Token = "0x200014A")]
			public class Request
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400061F")]
				public HandShake.Request HandShakeRequest;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000620")]
				public List<OnlineProfileUpdaterTransferData> ClientDataToFix;

				[Cpp2IlInjected.Token(Token = "0x600043E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Request()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200014B")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x4000622")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000623")]
				Failed
			}

			[Cpp2IlInjected.Token(Token = "0x200014C")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000624")]
				public List<OnlineProfileUpdaterTransferData> FixedData;

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public int NewOnlineVersion
				{
					[Cpp2IlInjected.Token(Token = "0x600043F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					[CompilerGenerated]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000440")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public bool HasDataToApply
				{
					[Cpp2IlInjected.Token(Token = "0x6000441")]
					[Cpp2IlInjected.Address(RVA = "0x3930260", Offset = "0x392EC60", VA = "0x183930260")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public Error Error
				{
					[Cpp2IlInjected.Token(Token = "0x6000442")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					[CompilerGenerated]
					get
					{
						return default(Error);
					}
					[Cpp2IlInjected.Token(Token = "0x6000443")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x1170AE0", Offset = "0x116F4E0", VA = "0x181170AE0")]
				public Result WithError(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000445")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SendRequestedData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PreGameLoad()
		{
		}
	}
}
