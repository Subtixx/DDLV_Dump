using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public static class NamespaceGuid
	{
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid DnsNamespace;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid UrlNamespace;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid IsoOidNamespace;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x116E250", Offset = "0x116CC50", VA = "0x18116E250")]
		public static Guid Create(Guid namespaceId, string name)
		{
			//Discarded unreachable code: IL_000a
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			return namespaceId;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x116E700", Offset = "0x116D100", VA = "0x18116E700")]
		public static Guid Create(Guid namespaceId, string name, int version)
		{
			if (version != 0)
			{
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				return namespaceId;
			}
			ArgumentNullException ex = new ArgumentNullException("name");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x116E3A0", Offset = "0x116CDA0", VA = "0x18116E3A0")]
		public static Guid Create(Guid namespaceId, byte[] nameBytes)
		{
			return namespaceId;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x116E440", Offset = "0x116CE40", VA = "0x18116E440")]
		public static Guid Create(Guid namespaceId, byte[] nameBytes, int version)
		{
			//IL_0060: Expected I4, but got I8
			int num = 0;
			if ((long)typeof(NamespaceGuid).TypeHandle == 4294967293L)
			{
				byte[] guid = default(byte[]);
				SwapByteOrder(guid);
				IEnumerable<byte> cpp2il__autoParamName__idx_ = default(IEnumerable<byte>);
				byte[] buffer = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<byte>();
				int num2 = 0;
				MD5 mD = MD5.Create();
				SHA1 sHA = SHA1.Create();
				byte[] sourceArray = sHA.ComputeHash(buffer);
				if (sHA != null)
				{
				}
				byte[] array = new byte[16];
				int destinationIndex = 0;
				int sourceIndex = 0;
				ulong num3 = default(ulong);
				Array.Copy(sourceArray, sourceIndex, array, destinationIndex, (int)num3);
				int length = array.Length;
				byte b = (array[1] = array[1]);
				SwapByteOrder(array);
			}
			ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("version", "version must be either 3 or 5.");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x116E830", Offset = "0x116D230", VA = "0x18116E830")]
		internal static void SwapByteOrder(byte[] guid)
		{
			//Discarded unreachable code: IL_0092
			int length = guid.Length;
			byte b = guid[0];
			byte b2 = (guid[0] = guid[0]);
			guid[0] = b;
			byte b3 = guid[0];
			byte b4 = guid[0];
			guid[0] = b3;
			guid[0] = b4;
			byte b5 = guid[0];
			byte b6 = (guid[0] = guid[0]);
			guid[0] = b5;
			byte b7 = guid[0];
			byte b8 = (guid[0] = guid[0]);
			guid[0] = b7;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x116E940", Offset = "0x116D340", VA = "0x18116E940")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
			//Discarded unreachable code: IL_0008
			int length = guid.Length;
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x116E9C0", Offset = "0x116D3C0", VA = "0x18116E9C0")]
		static NamespaceGuid()
		{
			//IL_000a: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			//IL_0018: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			DnsNamespace = (Guid)num;
			int num3 = 0;
			UrlNamespace = (Guid)num2;
			IsoOidNamespace = (Guid)num3;
		}
	}
}
