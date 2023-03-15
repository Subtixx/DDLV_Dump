using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2IlInjected;
using UnityEngine;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class Identifiers
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly byte[] Rfc2898IDFVSalt;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400003B")]
		public string Vendor
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400003C")]
		public VendorIdentifierType VendorType
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string Advertising
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x402E000", Offset = "0x402CA00", VA = "0x18402E000")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400003D")]
		public AdvertisingIdentifierType AdvertisingType
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsAdvertisingIdentifierValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x402E0B0", Offset = "0x402CAB0", VA = "0x18402E0B0")]
			get
			{
				if ((object)AdIdentifierProvider.authorizationStatus == null)
				{
				}
				AdIdentifierStatus authorizationStatus = AdIdentifierProvider.authorizationStatus;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x402DE80", Offset = "0x402C880", VA = "0x18402DE80")]
		public Identifiers()
		{
			//Discarded unreachable code: IL_0045, IL_004b
			int num = 0;
			int num2 = 0;
			base._002Ector();
			int num3 = 0;
			string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
			byte[] rfc2898IDFVSalt = Rfc2898IDFVSalt;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(deviceUniqueIdentifier, rfc2898IDFVSalt);
			byte[] bytes = rfc2898DeriveBytes.GetBytes(16);
			string text = default(string);
			string text2 = (Vendor = text.ToUpperInvariant());
			if (rfc2898DeriveBytes == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x402DE00", Offset = "0x402C800", VA = "0x18402DE00")]
		static Identifiers()
		{
			byte[] array = new byte[16];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			Rfc2898IDFVSalt = array;
			/*Error: Unexpected end of block*/;
		}
	}
}
