using System;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct Version
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string FullVersionPath = "FullVersion.txt";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string LocalBuildId = "local";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string IncrementalBuildId = "incremental";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly Version Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly string branch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly SemVer version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly int commit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly string hash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly string buildType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly int buildId;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string FullVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4115870", Offset = "0x4114270", VA = "0x184115870")]
			get
			{
				//Discarded unreachable code: IL_009b
				//IL_0027: Expected O, but got I4
				//IL_0040: Expected O, but got I4
				//IL_008f: Expected O, but got I4
				object[] array;
				int num2;
				while (true)
				{
					array = new object[6];
					if (array == null)
					{
						continue;
					}
					int build = version.build;
					if (build != 0 && build == 0)
					{
						continue;
					}
					array[1] = build;
					int num = commit;
					build = num;
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[2] = build;
					string text = hash;
					if (text != null && num == 0)
					{
						continue;
					}
					array[3] = text;
					string text2 = buildType;
					if (text2 == null || num != 0)
					{
						array[4] = text2;
						num2 = buildId;
						if (num2 == 0 || num2 != 0)
						{
							break;
						}
					}
				}
				array[5] = num2;
				return string.Format("{0}-{1}-{2}-{3}-{4}-{5}", array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string CommitString
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4115850", Offset = "0x4114250", VA = "0x184115850")]
			get
			{
				int num = commit;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string VersionString
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4115BC0", Offset = "0x41145C0", VA = "0x184115BC0")]
			get
			{
				int build = version.build;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string BuildIdString
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4115830", Offset = "0x4114230", VA = "0x184115830")]
			get
			{
				int num = buildId;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VersionWithCommit
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4115CB0", Offset = "0x41146B0", VA = "0x184115CB0")]
			get
			{
				//IL_001f: Expected O, but got I4
				//IL_001f: Expected O, but got I4
				int build = version.build;
				int num = commit;
				return $"{build}.{build}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsIncrementalBuild
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4115B80", Offset = "0x4114580", VA = "0x184115B80")]
			get
			{
				return string.Equals(buildType, "incremental");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4115650", Offset = "0x4114050", VA = "0x184115650", Slot = "3")]
		public override string ToString()
		{
			return FullVersion;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x41157C0", Offset = "0x41141C0", VA = "0x1841157C0")]
		public unsafe Version(string branch, SemVer version, int commit, string hash, string buildType, int buildId)
		{
			//IL_0015: Expected native int or pointer, but got O
			//IL_0028: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			this.branch = branch;
			int build = version.build;
			((SemVer*)(IntPtr)this.version)->build = build;
			this.commit = commit;
			this.hash = (string)0;
			this.buildType = (string)0;
			this.buildId = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4115340", Offset = "0x4113D40", VA = "0x184115340")]
		public static Version Parse(string content)
		{
			int num = 0;
			uint num2 = default(uint);
			(new char[0])[0] = (char)num2;
			string[] array = default(string[]);
			int length = array.Length;
			Version invalid = Invalid;
			SemVer semVer = default(SemVer);
			int build = semVer.build;
			content.m_stringLength = num;
			content.m_stringLength = build;
			content.m_firstChar = (char)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4115660", Offset = "0x4114060", VA = "0x184115660")]
		static Version()
		{
			string invalid = default(string);
			Invalid = (Version)invalid;
		}
	}
}
