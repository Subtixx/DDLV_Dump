using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B28")]
	public class Security : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002B5B")]
		private readonly RijndaelManaged _rijndaelManaged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B5C")]
		private readonly ICryptoTransform _encryptor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B5D")]
		private readonly ICryptoTransform _decryptor;

		[Cpp2IlInjected.Token(Token = "0x6005E44")]
		[Cpp2IlInjected.Address(RVA = "0x1772920", Offset = "0x1771320", VA = "0x181772920")]
		public Security(string encryptKey)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			int num = 0;
			byte[] array = (rijndaelManaged.Key = Encoding.UTF8.GetBytes(encryptKey));
			rijndaelManaged.Mode = CipherMode.ECB;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			_rijndaelManaged = rijndaelManaged;
			ICryptoTransform cryptoTransform = (_encryptor = _rijndaelManaged.CreateEncryptor());
			ICryptoTransform cryptoTransform2 = (_decryptor = _rijndaelManaged.CreateDecryptor());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E45")]
		[Cpp2IlInjected.Address(RVA = "0x17728B0", Offset = "0x17712B0", VA = "0x1817728B0")]
		public byte[] Encrypt(byte[] bytes)
		{
			ICryptoTransform encryptor = _encryptor;
			int length = bytes.Length;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E46")]
		[Cpp2IlInjected.Address(RVA = "0x1772810", Offset = "0x1771210", VA = "0x181772810")]
		public byte[] Encrypt(string s)
		{
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			ICryptoTransform encryptor = _encryptor;
			int length = bytes.Length;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E47")]
		[Cpp2IlInjected.Address(RVA = "0x1772520", Offset = "0x1770F20", VA = "0x181772520")]
		public byte[] Decrypt(byte[] bytes)
		{
			ICryptoTransform decryptor = _decryptor;
			int length = bytes.Length;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E48")]
		[Cpp2IlInjected.Address(RVA = "0x1772590", Offset = "0x1770F90", VA = "0x181772590")]
		public byte[] Decrypt(string s)
		{
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			ICryptoTransform decryptor = _decryptor;
			int length = bytes.Length;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E49")]
		[Cpp2IlInjected.Address(RVA = "0x17726A0", Offset = "0x17710A0", VA = "0x1817726A0")]
		public string EncryptToString(byte[] bytes)
		{
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			ICryptoTransform encryptor = _encryptor;
			int length = bytes.Length;
			int maxByteCount = uTF.GetMaxByteCount(length);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4A")]
		[Cpp2IlInjected.Address(RVA = "0x1772740", Offset = "0x1771140", VA = "0x181772740")]
		public string EncryptToString(string s)
		{
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			int num2 = 0;
			Encoding uTF = Encoding.UTF8;
			ICryptoTransform encryptor = _encryptor;
			int length = bytes.Length;
			int maxByteCount = uTF.GetMaxByteCount(length);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4B")]
		[Cpp2IlInjected.Address(RVA = "0x1772480", Offset = "0x1770E80", VA = "0x181772480")]
		public string DecryptToString(byte[] bytes)
		{
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			ICryptoTransform decryptor = _decryptor;
			int length = bytes.Length;
			int maxByteCount = uTF.GetMaxByteCount(length);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4C")]
		[Cpp2IlInjected.Address(RVA = "0x17723B0", Offset = "0x1770DB0", VA = "0x1817723B0")]
		public string DecryptToString(string s)
		{
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			int num2 = 0;
			Encoding uTF = Encoding.UTF8;
			ICryptoTransform decryptor = _decryptor;
			int length = bytes.Length;
			int maxByteCount = uTF.GetMaxByteCount(length);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4D")]
		[Cpp2IlInjected.Address(RVA = "0x1772630", Offset = "0x1771030", VA = "0x181772630", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_001a
			ICryptoTransform decryptor = _decryptor;
			ICryptoTransform encryptor = _encryptor;
			_rijndaelManaged.Dispose();
		}
	}
}
