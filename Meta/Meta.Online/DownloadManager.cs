using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using glPlayFab;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F0F")]
	public class DownloadManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000F10")]
		private class DownloadTask
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003D66")]
			private TaskCompletionSource<bool> tcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003D67")]
			private CancellationTokenSource cts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003D68")]
			private int refCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003D69")]
			private readonly string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4003D6A")]
			private Dictionary<string, DownloadTask> taskList;

			[Cpp2IlInjected.Token(Token = "0x17001597")]
			public Task<bool> Task
			{
				[Cpp2IlInjected.Token(Token = "0x6007C39")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CTask_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007C3A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CTask_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007C3B")]
			[Cpp2IlInjected.Address(RVA = "0x9993B0", Offset = "0x997DB0", VA = "0x1809993B0")]
			public unsafe DownloadTask(string _url, string _fileRelativePath, Dictionary<string, DownloadTask> _taskList, HttpClientWithTimeout httpClient)
			{
				//Discarded unreachable code: IL_0049, IL_006c
				//IL_000b: Expected O, but got I4
				//IL_002e: Expected I4, but got I8
				int num = 0;
				base.FieldGetter((string)num, _fileRelativePath, ref *(object*)_taskList);
				TaskCompletionSource<bool> taskCompletionSource = (tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
				CancellationTokenSource cancellationTokenSource = (cts = new CancellationTokenSource());
				refCount = 1;
				url = _url;
				taskList = _taskList;
				Dictionary<string, DownloadTask> dictionary = taskList;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007C3C")]
			[Cpp2IlInjected.Address(RVA = "0x999160", Offset = "0x997B60", VA = "0x180999160")]
			[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__10))]
			private Task DownloadAsync()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007C3D")]
			[Cpp2IlInjected.Address(RVA = "0x999270", Offset = "0x997C70", VA = "0x180999270")]
			[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__11))]
			public Task<bool> WaitAsync(CancellationToken ct)
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<bool>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007C3E")]
			[Cpp2IlInjected.Address(RVA = "0x999260", Offset = "0x997C60", VA = "0x180999260")]
			public void IncRef()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6007C3F")]
			[Cpp2IlInjected.Address(RVA = "0x9990D0", Offset = "0x997AD0", VA = "0x1809990D0")]
			public void DecRef()
			{
				//Discarded unreachable code: IL_0031
				//IL_002e: Expected O, but got I4
				if (!((TaskCompletionSource<>)(object)tcs).m_task.IsCompleted)
				{
					cts.Cancel();
					TaskCompletionSource<bool> taskCompletionSource = tcs;
					int num = 0;
					bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003D61")]
		private static DownloadManager _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D62")]
		private readonly int MaxConcurrentDownloads = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D63")]
		private string CacheRelativeFolder = "download_cache";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D64")]
		private Dictionary<string, DownloadTask> ActiveDownload = (Dictionary<string, DownloadTask>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17001593")]
		public static DownloadManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6007C28")]
			[Cpp2IlInjected.Address(RVA = "0x173C580", Offset = "0x173AF80", VA = "0x18173C580")]
			get
			{
				//IL_0010: Expected I4, but got I8
				DownloadManager downloadManager = new DownloadManager();
				downloadManager.MaxConcurrentDownloads = 20;
				downloadManager.CacheRelativeFolder = "download_cache";
				Dictionary<string, DownloadTask> dictionary = (downloadManager.ActiveDownload = (Dictionary<string, DownloadTask>)(object)new Dictionary<TKey, TValue>());
				_instance = downloadManager;
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001594")]
		public static IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6007C29")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return Definitions.Util.FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001595")]
		private string CacheAbsoluteFolder
		{
			[Cpp2IlInjected.Token(Token = "0x6007C2B")]
			[Cpp2IlInjected.Address(RVA = "0x173C4C0", Offset = "0x173AEC0", VA = "0x18173C4C0")]
			get
			{
				//Discarded unreachable code: IL_0008
				IFileSystem _003CSave_003Ek__BackingField = Definitions.Util.FileSystem.Save;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001596")]
		public bool IsConcurentDownloadMaxOut
		{
			[Cpp2IlInjected.Token(Token = "0x6007C2F")]
			[Cpp2IlInjected.Address(RVA = "0x173C690", Offset = "0x173B090", VA = "0x18173C690")]
			get
			{
				//Discarded unreachable code: IL_0017
				return ((Dictionary<TKey, TValue>)(object)ActiveDownload).Count >= MaxConcurrentDownloads;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C2A")]
		[Cpp2IlInjected.Address(RVA = "0x173B3F0", Offset = "0x1739DF0", VA = "0x18173B3F0")]
		private string CacheRelativePath(string filename)
		{
			return Path.Combine(CacheRelativeFolder, filename);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C2C")]
		[Cpp2IlInjected.Address(RVA = "0x173B380", Offset = "0x1739D80", VA = "0x18173B380")]
		private string CacheAbsolutePath(string filename)
		{
			return Path.Combine(CacheAbsoluteFolder, filename);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C2D")]
		[Cpp2IlInjected.Address(RVA = "0x173C0B0", Offset = "0x173AAB0", VA = "0x18173C0B0")]
		public bool IsDownloadingUrl(string url)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<string, DownloadTask> activeDownload = ActiveDownload;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C2E")]
		[Cpp2IlInjected.Address(RVA = "0x173C040", Offset = "0x173AA40", VA = "0x18173C040")]
		private bool IsDownloadingUrl(string url, out DownloadTask task)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<string, DownloadTask> activeDownload = ActiveDownload;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C30")]
		[Cpp2IlInjected.Address(RVA = "0x173C2D0", Offset = "0x173ACD0", VA = "0x18173C2D0")]
		private string UrlToFileRelativePath(string url)
		{
			//Discarded unreachable code: IL_0044
			Uri uri = new Uri(url);
			if ((object)uri == null || uri.PathAndQuery == null)
			{
			}
			string text = ToMD5(url);
			if ((object)uri == null || uri.AbsolutePath == null)
			{
			}
			string extension = Path.GetExtension(url);
			string path = text + extension;
			return Path.Combine(CacheRelativeFolder, path);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C31")]
		[Cpp2IlInjected.Address(RVA = "0x173C120", Offset = "0x173AB20", VA = "0x18173C120")]
		private static string ToMD5(string value)
		{
			//Discarded unreachable code: IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072
			int num = 0;
			int num2 = 0;
			MD5 mD = MD5.Create();
			int num3 = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			if (num < array.Length)
			{
				string value2 = default(string);
				StringBuilder stringBuilder2 = stringBuilder.Append(value2);
				num++;
			}
			string result = stringBuilder.ToString();
			if (mD != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C32")]
		[Cpp2IlInjected.Address(RVA = "0x173BDE0", Offset = "0x173A7E0", VA = "0x18173BDE0")]
		public bool IsDownloaded(string url, out string fileRelativePath)
		{
			if ((object)typeof(IReadOnlyFileSystem).TypeHandle == null)
			{
				Uri uri = new Uri(url);
				if ((object)uri == null || uri.PathAndQuery == null)
				{
				}
				string text = ToMD5(url);
				if ((object)uri == null || uri.AbsolutePath == null)
				{
				}
				string extension = Path.GetExtension(url);
				string path = text + extension;
				string text2 = Path.Combine(CacheRelativeFolder, path);
				IFileSystem _003CSave_003Ek__BackingField = Definitions.Util.FileSystem.Save;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			int num3 = 0;
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007C33")]
		[Cpp2IlInjected.Address(RVA = "0x173B9A0", Offset = "0x173A3A0", VA = "0x18173B9A0")]
		[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__19))]
		public Task<string> DownloadAsync(CancellationToken ct, string url)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C34")]
		[Cpp2IlInjected.Address(RVA = "0x173BB00", Offset = "0x173A500", VA = "0x18173BB00")]
		[AsyncStateMachine(typeof(_003CDownloadMultiAsync_003Ed__20))]
		public Task DownloadMultiAsync(CancellationToken ct, List<string> urls, [Optional] Action<string, string, object> callback, [Optional] object callbackArg)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C35")]
		[Cpp2IlInjected.Address(RVA = "0x173BC60", Offset = "0x173A660", VA = "0x18173BC60")]
		[AsyncStateMachine(typeof(_003CInnerDownloadAsync_003Ed__21))]
		private static Task<bool> InnerDownloadAsync(CancellationToken ct, string url, string fileRelativePath, HttpClientWithTimeout httpClient)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C36")]
		[Cpp2IlInjected.Address(RVA = "0x173B460", Offset = "0x1739E60", VA = "0x18173B460")]
		[AsyncStateMachine(typeof(_003CCleanupFilesAsync_003Ed__22))]
		public Task CleanupFilesAsync(int daysSinceCreated = 0, int daysSinceLastAccess = 0, bool deleteTmp = true, bool deleteAll = false)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C37")]
		[Cpp2IlInjected.Address(RVA = "0x173B5B0", Offset = "0x1739FB0", VA = "0x18173B5B0")]
		public void CleanupFiles(int daysSinceCreated = 0, int daysSinceLastAccess = 0, bool deleteTmp = true, bool deleteAll = false)
		{
			//Discarded unreachable code: IL_0086, IL_008c, IL_0092
			uint num3 = default(uint);
			int num;
			string text = default(string);
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			uint num6 = default(uint);
			do
			{
				num = 0;
				int num2 = 0;
				DateTime now = DateTime.Now;
				IFileSystem _003CSave_003Ek__BackingField = Definitions.Util.FileSystem.Save;
				string cacheAbsoluteFolder = CacheAbsoluteFolder;
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (cacheAbsoluteFolder != null)
				{
					if (text.EndsWith(".tmp"))
					{
						goto IL_006f;
					}
					if (daysSinceCreated > 0)
					{
						int num4 = 0;
						DateTime creationTime = File.GetCreationTime(text);
						if (dateTime < now)
						{
							goto IL_006f;
						}
					}
					if (daysSinceLastAccess > 0)
					{
						int num5 = 0;
						DateTime lastAccessTime = File.GetLastAccessTime(text);
						if (dateTime2 < now)
						{
							goto IL_006f;
						}
					}
					goto IL_0072;
				}
				goto IL_0079;
				IL_0072:
				num6 += num6;
				goto IL_0079;
				IL_0079:
				if (cacheAbsoluteFolder != null)
				{
				}
				continue;
				IL_006f:
				int num7 = 0;
				goto IL_0072;
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C38")]
		[Cpp2IlInjected.Address(RVA = "0x173C420", Offset = "0x173AE20", VA = "0x18173C420")]
		public DownloadManager()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
