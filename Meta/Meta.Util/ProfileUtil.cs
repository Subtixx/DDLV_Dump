using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using glPlayFab;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B21")]
	public static class ProfileUtil
	{
		[Cpp2IlInjected.Token(Token = "0x2000B22")]
		public class TryDecryptResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002B51")]
			public bool Success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4002B52")]
			public bool WasEncrypted;

			[Cpp2IlInjected.Token(Token = "0x6005E39")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public TryDecryptResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002B4A")]
		public const string ProfileEncryptionKey = "b5qhh8saJ8UlDJUzTZXd2Tg6mbo8W8n5";

		[Cpp2IlInjected.Token(Token = "0x4002B4B")]
		private static Security _securityInstance = (Security)new object();

		[Cpp2IlInjected.Token(Token = "0x4002B4C")]
		private static int MaxProfileSize;

		[Cpp2IlInjected.Token(Token = "0x4002B4D")]
		private const int ProtoFormatSizeExtraBuffer = 524288;

		[Cpp2IlInjected.Token(Token = "0x4002B4E")]
		public static string LoadingProfilePath;

		[Cpp2IlInjected.Token(Token = "0x4002B4F")]
		private static readonly object profileSavingLock;

		[Cpp2IlInjected.Token(Token = "0x4002B50")]
		private static readonly MemoryStream jsonMemoryStream;

		[Cpp2IlInjected.Token(Token = "0x6005E29")]
		[Cpp2IlInjected.Address(RVA = "0x1477220", Offset = "0x1475C20", VA = "0x181477220")]
		public static Security GetSecurity()
		{
			//Discarded unreachable code: IL_0015
			_securityInstance = new Security("b5qhh8saJ8UlDJUzTZXd2Tg6mbo8W8n5");
			return _securityInstance;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2A")]
		[Cpp2IlInjected.Address(RVA = "0x1479C70", Offset = "0x1478670", VA = "0x181479C70")]
		private static void UpdateProfileSize(int newSize)
		{
			MaxProfileSize = Math.Max(MaxProfileSize, newSize);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2B")]
		[Cpp2IlInjected.Address(RVA = "0x14782E0", Offset = "0x1476CE0", VA = "0x1814782E0")]
		public static Profile NewProfile(string defaultProfilePath, DeviceInfo info)
		{
			//Discarded unreachable code: IL_0140
			//IL_0129: Expected O, but got I4
			int num = 0;
			int count = 0;
			if (!defaultProfilePath.StartsWith("<data>/") && !defaultProfilePath.StartsWith("<save>/"))
			{
				int count2 = 0;
				if (!defaultProfilePath.StartsWith("<online>/"))
				{
					goto IL_00fb;
				}
				int num2 = 0;
				string playfabProfileSlot_ = DebugSettings.Settings.playfabProfileSlot_;
				char[] array = new char[1];
				uint num3 = default(uint);
				array[0] = (char)num3;
				string[] array2 = playfabProfileSlot_.Split(array, count2);
				Func<string, string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => x.Trim());
				}
				string text = Enumerable.First<string>(Enumerable.Select<string, string>((IEnumerable<>)(object)array2, (Func<, >)(object)_003C_003E9__6_));
				uint num4 = default(uint);
				(new char[1])[0] = (char)num4;
			}
			int num5 = 0;
			string profileSlot_ = DebugSettings.Settings.profileSlot_;
			char[] array3 = new char[1];
			uint num6 = default(uint);
			array3[0] = (char)num6;
			string[] array4 = profileSlot_.Split(array3, count);
			if (string.Equals(array4[0], "<data>"))
			{
			}
			IFileSystem _003CSaveGlobal_003Ek__BackingField = FileSystem.SaveGlobal;
			string path = array4[1];
			int num7 = 0;
			goto IL_00fb;
			IL_00fb:
			byte[] array5 = _003CSaveGlobal_003Ek__BackingField.ReadAllBytes(path);
			TryDecryptResult tryDecryptResult = default(TryDecryptResult);
			Profile profile = default(Profile);
			if (tryDecryptResult.Success)
			{
				ulong num8 = default(ulong);
				if (num8 != 0)
				{
				}
				ulong num9 = default(ulong);
				if (num9 == 0)
				{
				}
				if (num7 != 0)
				{
					FakeTransactionContext context = new FakeTransactionContext((Nullable<>)0);
					profile.Create(context);
				}
				ProfileGameInfo gameInfo_ = profile.gameInfo_;
			}
			return profile;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2C")]
		[Cpp2IlInjected.Address(RVA = "0x1479D20", Offset = "0x1478720", VA = "0x181479D20")]
		public static void ValidateLoadedProfile(IFileSystem fs)
		{
			//Discarded unreachable code: IL_0035
			string text = LoadingProfilePath + ".loading";
			if (text != null)
			{
				string path = LoadingProfilePath + ".valid";
				byte[] bytes = fs.ReadAllBytes(text);
				fs.WriteAllBytes(path, bytes);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2D")]
		[Cpp2IlInjected.Address(RVA = "0x1477330", Offset = "0x1475D30", VA = "0x181477330")]
		public static LoadProfileResult LoadOrCreateProfile(IFileSystem fs, string profilePath, string defaultProfilePath, DeviceInfo info)
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_0085, IL_008b, IL_0091
			//IL_003a: Expected O, but got I4
			ProfilerScope profilerScope = default(ProfilerScope);
			int length;
			LoadProfileResult loadProfileResult2;
			do
			{
				int num = 0;
				if ((object)profilerScope == null)
				{
					LoadProfileResult loadProfileResult = new LoadProfileResult();
					Profile profile = (loadProfileResult.profile_ = NewProfile(defaultProfilePath, info));
				}
				byte[] array = fs.ReadAllBytes(profilePath);
				length = array.Length;
				string text = $"[AL] LoadOrCreateProfile profilePath={profilePath} bytes.Length={length}";
				loadProfileResult2 = LoadProfile(array, info);
				if (loadProfileResult2.result_ == LoadProfileResult.Types.ErrorCode.Success)
				{
					_securityInstance = (Security)(object)profilePath;
					string path = LoadingProfilePath + ".loading";
					fs.WriteAllBytes(path, array);
				}
			}
			while (length != 0);
			return loadProfileResult2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2E")]
		[Cpp2IlInjected.Address(RVA = "0x1479940", Offset = "0x1478340", VA = "0x181479940")]
		public static TryDecryptResult TryDecryptProfile(byte[] bytes, out string text)
		{
			//Discarded unreachable code: IL_0020, IL_0050, IL_0056, IL_005c
			//IL_0044: Expected I4, but got O
			//IL_004d: Expected I4, but got I8
			int num = 0;
			string @string = Encoding.UTF8.GetString(bytes);
			TryDecryptResult tryDecryptResult = new TryDecryptResult();
			tryDecryptResult.Success = true;
			return tryDecryptResult;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E2F")]
		[Cpp2IlInjected.Address(RVA = "0x1477710", Offset = "0x1476110", VA = "0x181477710")]
		public static LoadProfileResult LoadProfileFromCompressData(byte[] compressData, DeviceInfo info)
		{
			return LoadProfile(glPlayFab.Compression.DecompressZip(compressData), info);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E30")]
		[Cpp2IlInjected.Address(RVA = "0x1477780", Offset = "0x1476180", VA = "0x181477780")]
		public static LoadProfileResult LoadProfile(byte[] bytes, DeviceInfo info)
		{
			//Discarded unreachable code: IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d, IL_0083
			//IL_001c: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_0052: Expected I4, but got I8
			int num;
			LoadProfileResult loadProfileResult;
			TryDecryptResult tryDecryptResult = default(TryDecryptResult);
			do
			{
				num = 0;
				loadProfileResult = new LoadProfileResult();
				if (bytes.Length == num)
				{
					loadProfileResult.result_ = LoadProfileResult.Types.ErrorCode.ProfileMissingData;
					loadProfileResult.Message = "Cannot load profile given an empty bytes array";
				}
				if (!tryDecryptResult.Success)
				{
					loadProfileResult.result_ = LoadProfileResult.Types.ErrorCode.DecryptingError;
					loadProfileResult.Message = "Couldn't decrypt the profile file.";
				}
				loadProfileResult.result_ = LoadProfileResult.Types.ErrorCode.DecryptingError;
			}
			while (num != 0);
			return loadProfileResult;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E31")]
		[Cpp2IlInjected.Address(RVA = "0x1477B40", Offset = "0x1476540", VA = "0x181477B40")]
		public unsafe static LoadProfileResult LoadProfile(string jsonText, DeviceInfo info)
		{
			//Discarded unreachable code: IL_00fc, IL_0102, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a, IL_0150, IL_0156, IL_015c, IL_0162, IL_0168, IL_016e, IL_0174, IL_017a, IL_0180, IL_0186, IL_018c, IL_0192, IL_0198, IL_019e, IL_01a4
			//IL_0015: Expected I4, but got I8
			//IL_001c: Expected I8, but got O
			//IL_0023: Expected I8, but got O
			//IL_0054: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_00c6: Expected O, but got I8
			//IL_00de: Expected O, but got I4
			//IL_00e9: Expected I4, but got I8
			LoadProfileResult loadProfileResult = new LoadProfileResult();
			ulong num = default(ulong);
			if (num == 0)
			{
			}
			loadProfileResult.result_ = LoadProfileResult.Types.ErrorCode.VersionMismatch;
			((ulong*)num)->m_value = (ulong)(long)info;
			((ulong*)num)->m_value = (ulong)(long)info;
			object[] array = new object[6];
			if (num != 0)
			{
				if (num != 0)
				{
					int num2 = default(int);
					if (num2 == 0 || num2 != 0)
					{
						array[2] = num2;
						int num3 = default(int);
						if (num3 == 0 || num3 != 0)
						{
							array[3] = num3;
							if (((num3 == 0 || num3 == 0) && "unknown" == null) || num != 0)
							{
								array[4] = "unknown";
								int num4 = 0;
								bool isUpdatingSaveContext = Profile.IsUpdatingSaveContext;
								if (!isUpdatingSaveContext || isUpdatingSaveContext)
								{
									array[5] = isUpdatingSaveContext;
									string text = string.Format("[AL] LoadProfile uid={0} playerName={1} level={2} CastleLevel={3} lastSaveDeviceName={4} IsUpdatingSaveContext={5}", array);
									loadProfileResult.profile_ = (Profile)num;
									bool _003CHasAnyUpdateApplied_003Ek__BackingField = default(bool);
									loadProfileResult.profile_.HasAnyUpdateApplied = _003CHasAnyUpdateApplied_003Ek__BackingField;
									string text2 = $"[AL] LoadProfile raised an exception : {isUpdatingSaveContext}";
									loadProfileResult.result_ = LoadProfileResult.Types.ErrorCode.ParsingError;
									string text4 = (loadProfileResult.Message = (isUpdatingSaveContext ? ((bool*)1) : ((bool*)null))->ToString());
									return loadProfileResult;
								}
								throw new IndexOutOfRangeException();
							}
							throw new IndexOutOfRangeException();
						}
						throw new IndexOutOfRangeException();
					}
					throw new IndexOutOfRangeException();
				}
				throw new IndexOutOfRangeException();
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E32")]
		[Cpp2IlInjected.Address(RVA = "0x1478CE0", Offset = "0x14776E0", VA = "0x181478CE0")]
		public static byte[] SaveProfile(IFileSystem fs, string profilePath, Profile profile, DeviceInfo info, bool pretty, bool encrypt, [Optional] Security security)
		{
			//Discarded unreachable code: IL_026c, IL_0272, IL_0278, IL_027e, IL_0284, IL_028a, IL_02b4, IL_02c0, IL_02c6, IL_02cc, IL_02d2, IL_02d8, IL_02de, IL_02e4, IL_02f0, IL_02f6, IL_02fc, IL_0302, IL_0308, IL_030e, IL_0314
			//IL_00de: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			//IL_0164: Expected O, but got I4
			//IL_017b: Expected O, but got I4
			//IL_01a3: Expected I8, but got I4
			//IL_01c6: Expected I4, but got I8
			//IL_01f7: Expected I4, but got I8
			int encoderShouldEmitUTF8Identifier = default(int);
			ulong num6 = default(ulong);
			uint num7 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (Profile.IsUpdatingSaveContext)
				{
					ProfileGameInfo gameInfo_ = profile.gameInfo_;
					int num3 = 0;
					Timestamp timestamp = (gameInfo_.modified_ = Timestamp.FromDateTime(DateTime.UtcNow));
					ProfileGameInfo gameInfo_2 = profile.gameInfo_;
					ProfileGameInfo gameInfo_3 = profile.gameInfo_;
					AccountLinkingInfo accountLinkingInfo = new AccountLinkingInfo();
					accountLinkingInfo.loggedDevice_ = info;
					Timestamp timestamp2 = (accountLinkingInfo.lastServerSave_ = profile.gameInfo_.modified_);
					gameInfo_3.UpdateAccountLinkingInfo(accountLinkingInfo);
				}
				object[] array = new object[8];
				string profileUID_ = profile.gameInfo_.profileUID_;
				if (profileUID_ == null || array != null)
				{
					array[0] = profileUID_;
					string name_ = profile.player_.name_;
					if (name_ == null || array != null)
					{
						array[1] = name_;
						int level_ = profile.player_.level_;
						if (level_ == 0 || level_ != 0)
						{
							array[2] = level_;
							int castleLevel_ = profile.world_.castleLevel_;
							level_ = castleLevel_;
							if (castleLevel_ == 0 || castleLevel_ != 0)
							{
								array[3] = level_;
								ProfileGameInfo gameInfo_4 = profile.gameInfo_;
								DeviceInfo lastSaveDeviceInfo_ = gameInfo_4.lastSaveDeviceInfo_;
								if (((lastSaveDeviceInfo_ == null || lastSaveDeviceInfo_.deviceName_ == null) && "unknown" == null) || gameInfo_4 != null)
								{
									array[4] = "unknown";
									int num4 = 0;
									bool isUpdatingSaveContext = Profile.IsUpdatingSaveContext;
									if (!isUpdatingSaveContext || isUpdatingSaveContext)
									{
										array[5] = isUpdatingSaveContext;
										if (!isUpdatingSaveContext || isUpdatingSaveContext)
										{
											array[6] = isUpdatingSaveContext;
											string text = string.Format("[AL] save profile uid={0} playerName={1} level={2} CastleLevel={3} lastSaveDeviceName={4} IsUpdatingSaveContext={5} encrypt={6} at path={7}", array);
											object obj = profileSavingLock;
											MemoryStream memoryStream = jsonMemoryStream;
											int num5 = 0;
											memoryStream.SetLength(num5);
											MemoryStream stream = jsonMemoryStream;
											UTF8Encoding encoding = new UTF8Encoding((byte)encoderShouldEmitUTF8Identifier != 0);
											encoderShouldEmitUTF8Identifier = 0;
											StreamWriter streamWriter = new StreamWriter(stream, encoding, 4096, (byte)num6 != 0);
											int formatEnumAsIntegers = 0;
											profile.WriteTo(streamWriter, formatDefaultValues: true, (byte)formatEnumAsIntegers != 0);
											if (streamWriter != null)
											{
											}
											if (num == 0)
											{
												if (num7 != 0)
												{
												}
												UpdateProfileSize((int)jsonMemoryStream.Length);
												byte[] array2 = jsonMemoryStream.ToArray();
												int num8 = 0;
												Encoding uTF = Encoding.UTF8;
												int num9 = 0;
												string s = ProtoExtensions.Indent(Encoding.UTF8.GetString(array2));
												byte[] bytes = uTF.GetBytes(s);
												int num10 = 0;
												Security security2 = GetSecurity();
												object obj2 = streamWriter.InitializeLifetimeService();
												num7++;
												Monitor.Exit(obj);
												if (num != 0)
												{
													break;
												}
												if (num7 != 0)
												{
												}
												if (num == 0)
												{
													return array2;
												}
												continue;
											}
											throw new NullReferenceException();
										}
										throw new IndexOutOfRangeException();
									}
									throw new IndexOutOfRangeException();
								}
								throw new IndexOutOfRangeException();
							}
							throw new IndexOutOfRangeException();
						}
						throw new IndexOutOfRangeException();
					}
					throw new IndexOutOfRangeException();
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E33")]
		[Cpp2IlInjected.Address(RVA = "0x14770C0", Offset = "0x1475AC0", VA = "0x1814770C0")]
		public static Profile CloneForDiff(this Profile self)
		{
			//Discarded unreachable code: IL_002c
			//IL_001c: Expected I4, but got I8
			Profile profile = self.Clone();
			ProfileGameInfo gameInfo_ = profile.gameInfo_;
			profile.gameInfo_.version_ = 0;
			profile.gameInfo_.revision_ = 0uL;
			return profile;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E34")]
		[Cpp2IlInjected.Address(RVA = "0x1477130", Offset = "0x1475B30", VA = "0x181477130")]
		public static void CopyProfile(IFileSystem srcFS, IFileSystem destFS, string sourceProfilePath, string destProfilePath)
		{
			//Discarded unreachable code: IL_0011
			string text = default(string);
			string destFileName = Path.Combine(text, destProfilePath);
			File.Copy(text, destFileName, overwrite: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E35")]
		[Cpp2IlInjected.Address(RVA = "0x1478B20", Offset = "0x1477520", VA = "0x181478B20")]
		public static void SaveProfileAvatarTransfer(IFileSystem fs, string profilePath, string data, bool encrypt)
		{
			bool flag = SaveFileWithEncryption(fs, profilePath, data, encrypt);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E36")]
		[Cpp2IlInjected.Address(RVA = "0x1478BB0", Offset = "0x14775B0", VA = "0x181478BB0")]
		public unsafe static bool SaveProfileWithEncryption(IFileSystem fs, string profilePath, string data, bool encrypt)
		{
			int num = 0;
			object obj = profileSavingLock;
			Monitor.Enter(obj, ref *(bool*)num);
			bool result = SaveFileWithEncryption(fs, profilePath, data, encrypt);
			Monitor.Exit(obj);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E37")]
		[Cpp2IlInjected.Address(RVA = "0x1478950", Offset = "0x1477350", VA = "0x181478950")]
		public static bool SaveFileWithEncryption(IFileSystem fs, string profilePath, string data, bool encrypt)
		{
			//Discarded unreachable code: IL_0024, IL_002a
			if (!encrypt)
			{
				fs.WriteAllText(profilePath, data);
			}
			int num = 0;
			byte[] bytes = GetSecurity().Encrypt(data);
			fs.WriteAllBytes(profilePath, bytes);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E38")]
		[Cpp2IlInjected.Address(RVA = "0x1479FB0", Offset = "0x14789B0", VA = "0x181479FB0")]
		static ProfileUtil()
		{
			MemoryStream securityInstance = default(MemoryStream);
			_securityInstance = (Security)(object)securityInstance;
			/*Error: Unexpected end of block*/;
		}
	}
}
