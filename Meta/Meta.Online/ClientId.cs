using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F02")]
	public class ClientId
	{
		[Cpp2IlInjected.Token(Token = "0x4003D3A")]
		public const char Separator = ':';

		[Cpp2IlInjected.Token(Token = "0x17001579")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003D3B")]
		public string Gamespace
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700157A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003D3C")]
		public int Pid
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700157B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4003D3D")]
		public int Ggi
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD4")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700157C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003D3E")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700157D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003D3F")]
		public string Platform
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700157E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003D40")]
		public string DownloadSource
		{
			[Cpp2IlInjected.Token(Token = "0x6007BD7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1673030", Offset = "0x1671A30", VA = "0x181673030", Slot = "3")]
		public override string ToString()
		{
			//IL_004a: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			string separator = default(string);
			while (true)
			{
				if (string.IsNullOrEmpty(Gamespace))
				{
					object[] array = new object[5];
					int num = Pid;
					if (array != null && array == null)
					{
						continue;
					}
					array[0] = array;
					int num2 = Ggi;
					if (num2 != 0 && num2 == 0)
					{
						continue;
					}
					array[1] = num2;
					string text = Version;
					if (text != null && num2 == 0)
					{
						continue;
					}
					array[2] = text;
					string text2 = Platform;
					if (text2 == null || num2 != 0)
					{
						array[3] = text2;
						string text3 = DownloadSource;
						if (text3 == null || num2 != 0)
						{
							array[4] = text3;
							return string.Join(separator, array);
						}
					}
					continue;
				}
				object[] array2 = new object[6];
				string text4 = Gamespace;
				if (text4 != null && array2 == null)
				{
					continue;
				}
				array2[0] = text4;
				int num3 = Pid;
				if (num3 != 0 && num3 == 0)
				{
					continue;
				}
				array2[1] = num3;
				int num4 = Ggi;
				num3 = num4;
				if (num4 != 0 && num4 == 0)
				{
					continue;
				}
				array2[2] = num3;
				string text5 = Version;
				if (text5 != null && num4 == 0)
				{
					continue;
				}
				array2[3] = text5;
				string text6 = Platform;
				if (text6 == null || num4 != 0)
				{
					array2[4] = text6;
					if (DownloadSource == null || num4 != 0)
					{
						break;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BD9")]
		[Cpp2IlInjected.Address(RVA = "0x1673870", Offset = "0x1672270", VA = "0x181673870")]
		private ClientId(int pid, int ggi, string version, string platform, string downloadSource, [Optional] string gamespace)
		{
			//IL_000d: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			Gamespace = (string)0;
			Version = version;
			Pid = pid;
			Ggi = ggi;
			Platform = (string)0;
			DownloadSource = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1672F50", Offset = "0x1671950", VA = "0x181672F50")]
		public ClientId ChangeVersion(string version)
		{
			int num = Pid;
			int num2 = Ggi;
			string text = Platform;
			string text2 = DownloadSource;
			ClientId clientId = default(ClientId);
			string text3 = (clientId.Gamespace = Gamespace);
			clientId.Version = version;
			clientId.Pid = num;
			clientId.Ggi = num2;
			clientId.Platform = text;
			clientId.DownloadSource = text2;
			return clientId;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BDB")]
		[Cpp2IlInjected.Address(RVA = "0x1673550", Offset = "0x1671F50", VA = "0x181673550")]
		public unsafe static bool TryParse(string clientId, out ClientId value)
		{
			//IL_00e3: Expected O, but got I4
			int num = 0;
			char[] array = new char[0];
			array[0] = ':';
			string[] array2 = clientId.Split(array);
			switch (array2.Length)
			{
			case 6:
				if (int.TryParse(array2[1], out *(int*)num) && int.TryParse(array2[2], out *(int*)num))
				{
					int length2 = array2.Length;
					string version2 = array2[3];
					string platform2 = array2[4];
					string downloadSource2 = array2[5];
					string gamespace = array2[0];
					ClientId clientId3 = new ClientId(num, num, version2, platform2, downloadSource2, gamespace);
					return true;
				}
				break;
			case 5:
				if (int.TryParse(array2[0], out *(int*)num) && int.TryParse(array2[1], out *(int*)num))
				{
					int length = array2.Length;
					string version = array2[2];
					string platform = array2[3];
					string downloadSource = array2[4];
					ClientId clientId2 = new ClientId(num, num, version, platform, downloadSource, (string)num);
				}
				break;
			}
			throw new NullReferenceException();
		}
	}
}
