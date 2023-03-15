using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Rewired.UI;
using UnityEngine;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DeviceInfo : IEquatable<DeviceInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DeviceFamily
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDeviceFamily_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CDeviceFamily_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string Firmware
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CFirmware_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CFirmware_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Country
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCountry_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CCountry_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CLanguage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CLanguage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string Carrier
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCarrier_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCarrier_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4000021")]
		public bool IsApplicationEncrypted
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x41"), Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool? IsAdIdentifierAuthorized
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x402CA20", Offset = "0x402B420", VA = "0x18402CA20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x402CA30", Offset = "0x402B430", VA = "0x18402CA30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x402C6F0", Offset = "0x402B0F0", VA = "0x18402C6F0", Slot = "4")]
		public bool Equals(DeviceInfo other)
		{
			if ((object)other != null)
			{
				if ((object)this == other)
				{
					return true;
				}
				string b = other.Model;
				if (string.Equals(Model, b))
				{
					string b2 = other.DeviceFamily;
					if (string.Equals(DeviceFamily, b2))
					{
						string b3 = other.Firmware;
						if (string.Equals(Firmware, b3))
						{
							string b4 = other.Country;
							if (string.Equals(Country, b4))
							{
								string b5 = other.Language;
								if (string.Equals(Language, b5))
								{
									string b6 = other.Carrier;
									if (string.Equals(Carrier, b6))
									{
										bool? flag = IsAdIdentifierAuthorized;
										bool? flag2 = other.IsAdIdentifierAuthorized;
										bool flag3 = (object)flag == (object)flag2;
										if ((object)flag == (object)flag2 != flag3)
										{
											bool flag4 = other.IsApplicationEncrypted;
											return IsApplicationEncrypted == flag4;
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x402C580", Offset = "0x402AF80", VA = "0x18402C580", Slot = "0")]
		public unsafe override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj != null)
			{
				int num = 0;
				if (obj != null && this != obj)
				{
					string text = Model;
					if ((object)typeof(DeviceInfo).TypeHandle != null)
					{
						string text2 = DeviceFamily;
						if ((object)typeof(DeviceInfo).TypeHandle != null)
						{
							string text3 = Firmware;
							if ((object)typeof(DeviceInfo).TypeHandle != null)
							{
								string text4 = Country;
								if ((object)typeof(DeviceInfo).TypeHandle != null)
								{
									string text5 = Language;
									if ((object)typeof(DeviceInfo).TypeHandle != null)
									{
										int num2 = 0;
										string text6 = Carrier;
										if ((object)typeof(DeviceInfo).TypeHandle != null)
										{
											bool? flag = IsAdIdentifierAuthorized;
											bool flag2 = (IntPtr)(void*)flag == (IntPtr)num2;
											if ((IntPtr)(void*)flag == (IntPtr)num2 == flag2)
											{
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E7E0", Offset = "0x3A5D1E0", VA = "0x183A5E7E0")]
		public static bool operator ==(DeviceInfo lhs, DeviceInfo rhs)
		{
			return object.Equals(lhs, rhs);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E920", Offset = "0x3A5D320", VA = "0x183A5E920")]
		public static bool operator !=(DeviceInfo lhs, DeviceInfo rhs)
		{
			return !object.Equals(lhs, rhs);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x402C820", Offset = "0x402B220", VA = "0x18402C820", Slot = "2")]
		public override int GetHashCode()
		{
			bool flag = IsApplicationEncrypted;
			bool? flag2 = IsAdIdentifierAuthorized;
			string text = Carrier;
			string text2 = Language;
			string text3 = Country;
			string text4 = Firmware;
			string text5 = DeviceFamily;
			Vector2 wheelDelta = ((IMouseInputSource)Tuple.Create<string, string, string, string, string, string, bool?, bool>(Model, text5, text4, text3, text2, text, flag2, flag)).wheelDelta;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x402C9B0", Offset = "0x402B3B0", VA = "0x18402C9B0")]
		private static extern int GetUserDefaultLCID();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x402C8D0", Offset = "0x402B2D0", VA = "0x18402C8D0")]
		private static extern int GetLocaleInfo(int lcid, int lctype, StringBuilder buffer, int nsize);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x402C240", Offset = "0x402AC40", VA = "0x18402C240")]
		public static DeviceInfo Collect()
		{
			//Discarded unreachable code: IL_00d1
			//IL_00c6: Expected O, but got I4
			StringBuilder stringBuilder = new StringBuilder(256);
			int num = 0;
			if (stringBuilder.Length > 0)
			{
				string text = stringBuilder.ToString();
			}
			int num2 = 0;
			string name = CultureInfo.CurrentCulture.Name;
			DeviceInfo deviceInfo = new DeviceInfo();
			int num3 = 0;
			deviceInfo.Model = (string)(object)deviceInfo;
			int num4 = 0;
			string text2 = "Unknown";
			if ((long)deviceInfo == 3)
			{
				text2 = "Win32Desktop";
			}
			deviceInfo.DeviceFamily = text2;
			int num5 = 0;
			string text3 = (deviceInfo.Firmware = Environment.OSVersion._version.ToString());
			int startIndex = 0;
			string text4 = (deviceInfo.Language = name.Substring(startIndex, 2));
			string text5 = (deviceInfo.Country = name.Substring(3).ToLower());
			deviceInfo.Carrier = "N/A";
			int num6 = 0;
			deviceInfo.IsAdIdentifierAuthorized = (bool?)(object)num;
			deviceInfo.IsApplicationEncrypted = true;
			return deviceInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DeviceInfo()
		{
		}
	}
}
