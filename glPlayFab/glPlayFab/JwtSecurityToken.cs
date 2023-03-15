using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class JwtSecurityToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private readonly string[] tokenParts;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000258")]
		public bool Validated
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000259")]
		public JwtHeader Header
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400025A")]
		public JwtPayload Payload
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1033380", Offset = "0x1031D80", VA = "0x181033380")]
		private JwtSecurityToken(JwtHeader header, JwtPayload payload, bool validated)
		{
			Header = header;
			Payload = payload;
			Validated = validated;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x10330C0", Offset = "0x1031AC0", VA = "0x1810330C0")]
		public JwtSecurityToken(string token)
		{
			//IL_00b1: Expected O, but got I4
			if (token != null)
			{
				char[] array = new char[1];
				array[0] = '.';
				string[] array2 = (tokenParts = token.Split(array));
				if (tokenParts.Length <= 1)
				{
					goto IL_00b8;
				}
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				byte[] bytes = FromBase64Url(tokenParts[0]);
				JwtHeader jwtHeader = (Header = JsonConvert.DeserializeObject<JwtHeader>(uTF.GetString(bytes)));
				int num2 = 0;
				Encoding uTF2 = Encoding.UTF8;
				byte[] bytes2 = FromBase64Url(tokenParts[1]);
				JwtPayload jwtPayload = (Payload = JsonConvert.DeserializeObject<JwtPayload>(uTF2.GetString(bytes2)));
			}
			int num3 = 0;
			CryptographicException ex = new CryptographicException("invalid token " + (string)num3);
			goto IL_00b8;
			IL_00b8:
			CryptographicException ex2 = new CryptographicException("invalid token " + token);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1032BD0", Offset = "0x10315D0", VA = "0x181032BD0")]
		public unsafe JwtSecurityToken Validate(string key)
		{
			//Discarded unreachable code: IL_0136
			//IL_00ea: Expected I4, but got O
			JObject jObject = JObject.Parse(key);
			byte[] array = FromBase64Url(jObject["e"]!.ToString());
			byte[] array2 = FromBase64Url(jObject["n"]!.ToString());
			RSACryptoServiceProvider key2 = new RSACryptoServiceProvider();
			int num = 0;
			int num2 = 0;
			SHA512 sHA = SHA512.Create();
			int num3 = 0;
			Encoding uTF = Encoding.UTF8;
			string[] array3 = tokenParts;
			int length = array3.Length;
			string text = array3[0];
			string text2 = array3[1];
			string s = text + "." + text2;
			byte[] bytes = uTF.GetBytes(s);
			byte[] rgbHash = sHA.ComputeHash(bytes);
			RSAPKCS1SignatureDeformatter rSAPKCS1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(key2);
			rSAPKCS1SignatureDeformatter.SetHashAlgorithm("SHA512");
			byte[] rgbSignature = FromBase64Url(tokenParts[2]);
			bool flag = rSAPKCS1SignatureDeformatter.VerifySignature(rgbHash, rgbSignature);
			int? _003CExp_003Ek__BackingField = Payload.Exp;
			if ((object)_003CExp_003Ek__BackingField != null)
			{
				int num4 = (int)((T?*)_003CExp_003Ek__BackingField)->Value;
				int num5 = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime dateTime = default(DateTime);
				bool flag2 = dateTime >= utcNow;
			}
			if (flag && num != 0)
			{
				JwtHeader jwtHeader = Header;
				JwtPayload jwtPayload = Payload;
				JwtSecurityToken jwtSecurityToken = default(JwtSecurityToken);
				jwtSecurityToken.Header = jwtHeader;
				jwtSecurityToken.Payload = jwtPayload;
				jwtSecurityToken.Validated = true;
				return jwtSecurityToken;
			}
			string text3 = default(string);
			CryptographicException ex = new CryptographicException("Fail to verify signature for token " + text3);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1032AB0", Offset = "0x10314B0", VA = "0x181032AB0")]
		public static byte[] FromBase64Url(string base64Url)
		{
			//Discarded unreachable code: IL_003e
			int num;
			do
			{
				num = base64Url.m_stringLength;
				if ((long)(IntPtr)base64Url < 0L)
				{
					num++;
				}
			}
			while (num == 0);
			string text = default(string);
			return Convert.FromBase64String((base64Url + text).Replace("_", "/").Replace("-", "+"));
		}
	}
}
