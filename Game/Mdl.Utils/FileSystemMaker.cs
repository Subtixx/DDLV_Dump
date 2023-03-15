using Cpp2IlInjected;
using Gameloft.FileSystem;
using Gameloft.FileSystem.Abstraction;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007D1")]
	public static class FileSystemMaker
	{
		[Cpp2IlInjected.Token(Token = "0x4002BFF")]
		private static IFileSystem editorStreamingAssetsFileSystem;

		[Cpp2IlInjected.Token(Token = "0x4002C00")]
		private static IReadOnlyFileSystem streamingAssetsFileSystem;

		[Cpp2IlInjected.Token(Token = "0x4002C01")]
		private static IFileSystem persistentDataFileSystem;

		[Cpp2IlInjected.Token(Token = "0x4002C02")]
		private static IFileSystem tempFileSystem;

		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		public static IFileSystem EditorStreamingAssetsFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60022BE")]
			[Cpp2IlInjected.Address(RVA = "0x136E460", Offset = "0x136CE60", VA = "0x18136E460")]
			get
			{
				int num = 0;
				editorStreamingAssetsFileSystem = DefaultFileSystem.FromPath(Application.streamingAssetsPath);
				return editorStreamingAssetsFileSystem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		public static IReadOnlyFileSystem StreamingAssetsFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60022BF")]
			[Cpp2IlInjected.Address(RVA = "0x136E660", Offset = "0x136D060", VA = "0x18136E660")]
			get
			{
				int num = 0;
				RuntimePlatform platform = Application.platform;
				int num2 = 0;
				if (platform != RuntimePlatform.Android)
				{
					editorStreamingAssetsFileSystem = DefaultFileSystem.FromPath(Application.streamingAssetsPath);
				}
				string dataPath = Application.dataPath;
				MyLogger logger = new MyLogger();
				editorStreamingAssetsFileSystem = SharpZipFileSystem.FromArchive(dataPath, "assets", logger);
				return streamingAssetsFileSystem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		public static IFileSystem PersistentDataFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60022C0")]
			[Cpp2IlInjected.Address(RVA = "0x136E4E0", Offset = "0x136CEE0", VA = "0x18136E4E0")]
			get
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				editorStreamingAssetsFileSystem = DefaultFileSystem.FromPath(Application.persistentDataPath);
				IFileSystem fileSystem = persistentDataFileSystem;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				int num4 = 0;
				string message = default(string);
				Debug.Log(message);
				return persistentDataFileSystem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public static IFileSystem TempFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x60022C1")]
			[Cpp2IlInjected.Address(RVA = "0x136E770", Offset = "0x136D170", VA = "0x18136E770")]
			get
			{
				int num = 0;
				editorStreamingAssetsFileSystem = DefaultFileSystem.FromPath(Application.temporaryCachePath);
				return tempFileSystem;
			}
		}
	}
}
