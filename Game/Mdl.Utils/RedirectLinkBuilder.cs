using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079D")]
	public class RedirectLinkBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x4002B6C")]
		private static readonly byte[] EncryptionKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002B6D")]
		private readonly Uri baseUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B6E")]
		private readonly Dictionary<string, string> parameters = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x60021D8")]
		[Cpp2IlInjected.Address(RVA = "0xCBC0C0", Offset = "0xCBAAC0", VA = "0x180CBC0C0")]
		public RedirectLinkBuilder(Uri baseUri)
		{
			this.baseUri = baseUri;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021D9")]
		[Cpp2IlInjected.Address(RVA = "0xCBBFD0", Offset = "0xCBA9D0", VA = "0x180CBBFD0")]
		public RedirectLinkBuilder WithParameter(string parameter, string value)
		{
			//Discarded unreachable code: IL_000d, IL_000f
			Dictionary<string, string> dictionary = parameters;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021DA")]
		[Cpp2IlInjected.Address(RVA = "0xCBBBD0", Offset = "0xCBA5D0", VA = "0x180CBBBD0")]
		private static string Encrypt(string input)
		{
			//Discarded unreachable code: IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1
			int num = 0;
			int num2 = 0;
			DES dES = DES.Create();
			byte[] array = (dES.Key = EncryptionKey);
			dES.Mode = CipherMode.ECB;
			dES.Padding = PaddingMode.Zeros;
			int num3 = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform cryptoTransform = dES.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
			int length = bytes.Length;
			int offset = 0;
			cryptoStream.Write(bytes, offset, length);
			if (cryptoStream != null)
			{
			}
			uint num4 = default(uint);
			if (num4 != 0)
			{
			}
			string result = Convert.ToBase64String(memoryStream.ToArray());
			num4++;
			if (cryptoTransform != null)
			{
			}
			if (num4 != 0)
			{
			}
			if (memoryStream != null)
			{
			}
			if (num4 != 0)
			{
			}
			if (dES != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021DB")]
		[Cpp2IlInjected.Address(RVA = "0xCBB8A0", Offset = "0xCBA2A0", VA = "0x180CBB8A0")]
		public Uri Build()
		{
			//Discarded unreachable code: IL_0086, IL_008c
			StringBuilder stringBuilder = new StringBuilder();
			Dictionary<string, string> dictionary = parameters;
			bool flag = default(bool);
			if (flag)
			{
				if (stringBuilder.Length > 0)
				{
				}
				string value = default(string);
				StringBuilder stringBuilder2 = stringBuilder.Append(value);
			}
			Debug.Log($"[RedirectLinkBuilder] parameters: {stringBuilder}");
			string text = Encrypt(stringBuilder.ToString());
			UriBuilder uriBuilder = default(UriBuilder);
			uriBuilder.Path = "/redir/";
			string text3 = (uriBuilder.Query = "?data=" + text + "&enc=2");
			Uri uri = uriBuilder.Uri;
			Debug.Log($"[RedirectLinkBuilder] URI: {uri}");
			return uri;
		}

		[Cpp2IlInjected.Token(Token = "0x60021DC")]
		[Cpp2IlInjected.Address(RVA = "0xCBC040", Offset = "0xCBAA40", VA = "0x180CBC040")]
		static RedirectLinkBuilder()
		{
			int num = 0;
			EncryptionKey = Encoding.UTF8.GetBytes("qPKBGA==");
			throw new NullReferenceException();
		}
	}
}
