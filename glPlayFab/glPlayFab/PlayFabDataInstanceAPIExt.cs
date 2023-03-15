using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.DataModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public static class PlayFabDataInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		public class FileEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public readonly string fileName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public readonly byte[] data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public readonly string checksum;

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB3E0", Offset = "0x1AE9DE0", VA = "0x181AEB3E0")]
			public FileEntry(string fileName, string data, [Optional] string checksum)
			{
				int num = 0;
				byte[] bytes = Encoding.UTF8.GetBytes(data);
				base._002Ector();
				this.fileName = fileName;
				this.data = bytes;
				this.checksum = checksum;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x79F770", Offset = "0x79E170", VA = "0x18079F770")]
			public FileEntry(string fileName, byte[] data, [Optional] string checksum)
			{
				this.fileName = fileName;
				this.data = data;
				this.checksum = checksum;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000116")]
		public class UploadFileResult
		{
			[Cpp2IlInjected.Token(Token = "0x17000155")]
			public HttpResponseMessage HttpResponseMessage
			{
				[Cpp2IlInjected.Token(Token = "0x600052D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CHttpResponseMessage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600052E")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CHttpResponseMessage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UploadFileResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000117")]
		public class PutFileResult
		{
			[Cpp2IlInjected.Token(Token = "0x17000156")]
			public PlayFabResult<InitiateFileUploadsResponse> InitiateFileUploadsResponse
			{
				[Cpp2IlInjected.Token(Token = "0x6000530")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CInitiateFileUploadsResponse_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000531")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CInitiateFileUploadsResponse_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000157")]
			public Dictionary<string, PlayFabResult<AbortFileUploadsResponse>> AbortFileUploadResponses
			{
				[Cpp2IlInjected.Token(Token = "0x6000532")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CAbortFileUploadResponses_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000533")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CAbortFileUploadResponses_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000158")]
			public PlayFabResult<FinalizeFileUploadsResponse> FinalizeFileUploadsResponse
			{
				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CFinalizeFileUploadsResponse_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CFinalizeFileUploadsResponse_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000159")]
			public UploadFileResult UploadFileResult
			{
				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CUploadFileResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CUploadFileResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000405")]
			public int FileChecksum
			{
				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700015B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4000406")]
			public bool VersionOrChecksumMismatch
			{
				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600053B")]
				[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700015C")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x1AEB890", Offset = "0x1AEA290", VA = "0x181AEB890")]
				get
				{
					if (FinalizeFileUploadsResponse != null)
					{
						return true;
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x1AEB8B0", Offset = "0x1AEA2B0", VA = "0x181AEB8B0")]
				get
				{
					while (true)
					{
						PlayFabResult<InitiateFileUploadsResponse> playFabResult = InitiateFileUploadsResponse;
						if ((playFabResult == null || playFabResult == null) && FinalizeFileUploadsResponse != null)
						{
							/*Error: Could not find block for branch target IL_0018*/;
						}
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			public PlayFabCustomError PlayFabCustomError
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabCustomError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabCustomError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB670", Offset = "0x1AEA070", VA = "0x181AEB670")]
			public string GetErrorResult()
			{
				//Discarded unreachable code: IL_00ad
				//IL_007b: Expected O, but got I4
				//IL_00ac: Expected O, but got I4
				PlayFabResult<InitiateFileUploadsResponse> playFabResult = InitiateFileUploadsResponse;
				PlayFabResult<FinalizeFileUploadsResponse> playFabResult2 = default(PlayFabResult<FinalizeFileUploadsResponse>);
				if (playFabResult == null || playFabResult == null)
				{
					playFabResult2 = FinalizeFileUploadsResponse;
					if (playFabResult2 == null)
					{
					}
				}
				int num = default(int);
				if (PlayFabCustomError == null)
				{
					string reasonPhrase = default(string);
					if (playFabResult2 == null)
					{
						UploadFileResult uploadFileResult = UploadFileResult;
						if (uploadFileResult != null)
						{
							HttpResponseMessage _003CHttpResponseMessage_003Ek__BackingField = uploadFileResult.HttpResponseMessage;
							if (_003CHttpResponseMessage_003Ek__BackingField != null && !_003CHttpResponseMessage_003Ek__BackingField.IsSuccessStatusCode)
							{
								HttpStatusCode statusCode = UploadFileResult.HttpResponseMessage.statusCode;
								reasonPhrase = UploadFileResult.HttpResponseMessage.ReasonPhrase;
								return $"HTTP error occured with code {statusCode} => {reasonPhrase}";
							}
						}
						return string.Empty;
					}
					num = 0;
					string arg = default(string);
					return $"PlayFabError occured with code {arg} => {reasonPhrase}";
				}
				string text = default(string);
				return $"PlayFabCustomError occured with code {text} (base error code={text}) => {num}";
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PutFileResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000118")]
		public class PutFilesResult
		{
			[Cpp2IlInjected.Token(Token = "0x1700015F")]
			public PutFileResult Result
			{
				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			public List<UploadFileResult> UploadResults
			{
				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CUploadResults_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CUploadResults_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400040A")]
			public int ProfileVersion
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PutFilesResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000119")]
		public class GetFileMetadataResult
		{
			[Cpp2IlInjected.Token(Token = "0x200011A")]
			public enum ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x4000411")]
				Latest,
				[Cpp2IlInjected.Token(Token = "0x4000412")]
				ChecksumMismatch,
				[Cpp2IlInjected.Token(Token = "0x4000413")]
				KeyNotFound,
				[Cpp2IlInjected.Token(Token = "0x4000414")]
				DownloadError,
				[Cpp2IlInjected.Token(Token = "0x4000415")]
				DownloadTimeoutError,
				[Cpp2IlInjected.Token(Token = "0x4000416")]
				GetFilesError,
				[Cpp2IlInjected.Token(Token = "0x4000417")]
				GetFileUnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x17000162")]
			public string Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CKey_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CKey_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			public GetFileMetadata FileMetadata
			{
				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CFileMetadata_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CFileMetadata_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000164")]
			public string Data
			{
				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000165")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400040E")]
			public ErrorCode Result
			{
				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000166")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000167")]
			public bool IsFileOutdated
			{
				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x1AEB480", Offset = "0x1AE9E80", VA = "0x181AEB480")]
				get
				{
					return Result == ErrorCode.ChecksumMismatch;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000168")]
			public bool IsFileLatest
			{
				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x15FC520", Offset = "0x15FAF20", VA = "0x1815FC520")]
				get
				{
					return Result == ErrorCode.Latest;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetFileMetadataResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x103CB80", Offset = "0x103B580", VA = "0x18103CB80")]
		public static EntityKey GetDataEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x103CC00", Offset = "0x103B600", VA = "0x18103CC00")]
		public static EntityKey GetEntityKey(this PlayFabDataInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x103D100", Offset = "0x103BB00", VA = "0x18103D100")]
		[AsyncStateMachine(typeof(_003CInitiateFileUploadsAsync_003Ed__2))]
		public static Task<PlayFabResult<InitiateFileUploadsResponse>> InitiateFileUploadsAsync(this PlayFabDataInstanceAPI self, IEnumerable<string> filenames, [Optional] int? expectedProfileVersion, [Optional] EntityKey entity)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<InitiateFileUploadsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x103C8C0", Offset = "0x103B2C0", VA = "0x18103C8C0")]
		public static Task<PlayFabResult<AbortFileUploadsResponse>> AbortFileUploadsAsync(this PlayFabDataInstanceAPI self, IEnumerable<string> fileNames, [Optional] int? profileVersion, [Optional] EntityKey entity)
		{
			//Discarded unreachable code: IL_0075
			//IL_0074: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			AbortFileUploadsRequest abortFileUploadsRequest = new AbortFileUploadsRequest();
			PlayFabAuthenticationContext playFabAuthenticationContext = (abortFileUploadsRequest.AuthenticationContext = self.authenticationContext);
			if (entity == null)
			{
				PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
				EntityKey entityKey = new EntityKey();
				string text = (entityKey.Type = authenticationContext.EntityType);
				string text2 = (entityKey.Id = authenticationContext.EntityId);
			}
			abortFileUploadsRequest.Entity = entity;
			List<string> list = (abortFileUploadsRequest.FileNames = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)fileNames));
			int num = 0;
			abortFileUploadsRequest.ProfileVersion = profileVersion;
			int num2 = 0;
			return (Task<PlayFabResult<AbortFileUploadsResponse>>)(object)self.AbortFileUploadsAsync(abortFileUploadsRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x103CA20", Offset = "0x103B420", VA = "0x18103CA20")]
		[AsyncStateMachine(typeof(_003CFinalizeFileUploadsAsync_003Ed__4))]
		public static Task<PlayFabResult<FinalizeFileUploadsResponse>> FinalizeFileUploadsAsync(this PlayFabDataInstanceAPI self, IEnumerable<string> filenames, [Optional] EntityKey entity)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<FinalizeFileUploadsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x103D270", Offset = "0x103BC70", VA = "0x18103D270")]
		[AsyncStateMachine(typeof(_003CPutFileAsync_003Ed__9))]
		public static Task<PutFileResult> PutFileAsync(this PlayFabDataInstanceAPI self, string key, string data, bool abortPendingUpload = true, [Optional] int? expectedProfileVersion, [Optional] string checksum, [Optional] EntityKey entity, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PutFileResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x103D420", Offset = "0x103BE20", VA = "0x18103D420")]
		[AsyncStateMachine(typeof(_003CPutFilesAsync_003Ed__10))]
		public static Task<PutFilesResult> PutFilesAsync(this PlayFabDataInstanceAPI self, IEnumerable<FileEntry> fileEntries, bool abortPendingUpload = true, [Optional] int? expectedProfileVersion, [Optional] EntityKey entity, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PutFilesResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x103CC90", Offset = "0x103B690", VA = "0x18103CC90")]
		[AsyncStateMachine(typeof(_003CGetFileLatest_003Ed__12))]
		public static Task<GetFileMetadataResult> GetFileLatest(this PlayFabDataInstanceAPI self, string key, GetFileMetadata metadata, bool alwaysDownloadFile = false, [Optional] EntityKey entity, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetFileMetadataResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x103CF80", Offset = "0x103B980", VA = "0x18103CF80")]
		[AsyncStateMachine(typeof(_003CGetFilesLatest_003Ed__13))]
		public static Task<List<GetFileMetadataResult>> GetFilesLatest(this PlayFabDataInstanceAPI self, Dictionary<string, GetFileMetadata> requestedFiles, bool alwaysDownloadFile = false, [Optional] EntityKey entity, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<GetFileMetadataResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x103CE20", Offset = "0x103B820", VA = "0x18103CE20")]
		[AsyncStateMachine(typeof(_003CGetFile_003Ed__14))]
		public static Task<(string, int?, string)> GetFile(this PlayFabDataInstanceAPI self, string key, [Optional] EntityKey entity)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(string, int?, string)>)(object)result;
		}
	}
}
