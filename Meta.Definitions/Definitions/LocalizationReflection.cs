using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class LocalizationReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF8")]
			[Cpp2IlInjected.Address(RVA = "0x27502A0", Offset = "0x274ECA0", VA = "0x1827502A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x274FDD0", Offset = "0x274E7D0", VA = "0x18274FDD0")]
		static LocalizationReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[6];
				if ("ChdVdGlsL0xvY2FsaXphdGlvbi5wcm90bxILRGVmaW5pdGlvbnMqyAEKBkxv" != null && "ChdVdGlsL0xvY2FsaXphdGlvbi5wcm90bxILRGVmaW5pdGlvbnMqyAEKBkxv" == null)
				{
					continue;
				}
				array[0] = "ChdVdGlsL0xvY2FsaXphdGlvbi5wcm90bxILRGVmaW5pdGlvbnMqyAEKBkxv";
				if ("Y2FsZRIUChBMb2NhbGVfRW5nbGlzaFVTEAASEwoPTG9jYWxlX0ZyZW5jaEZS" != null && "Y2FsZRIUChBMb2NhbGVfRW5nbGlzaFVTEAASEwoPTG9jYWxlX0ZyZW5jaEZS" == null)
				{
					continue;
				}
				array[1] = "Y2FsZRIUChBMb2NhbGVfRW5nbGlzaFVTEAASEwoPTG9jYWxlX0ZyZW5jaEZS";
				if ("EAESFAoQTG9jYWxlX1NwYW5pc2hFUxACEhMKD0xvY2FsZV9HZXJtYW5ERRAD" != null && "EAESFAoQTG9jYWxlX1NwYW5pc2hFUxACEhMKD0xvY2FsZV9HZXJtYW5ERRAD" == null)
				{
					continue;
				}
				array[2] = "EAESFAoQTG9jYWxlX1NwYW5pc2hFUxACEhMKD0xvY2FsZV9HZXJtYW5ERRAD";
				if ("EhQKEExvY2FsZV9JdGFsaWFuSVQQBBIVChFMb2NhbGVfSmFwYW5lc2VKUBAF" != null && "EhQKEExvY2FsZV9JdGFsaWFuSVQQBBIVChFMb2NhbGVfSmFwYW5lc2VKUBAF" == null)
				{
					continue;
				}
				array[3] = "EhQKEExvY2FsZV9JdGFsaWFuSVQQBBIVChFMb2NhbGVfSmFwYW5lc2VKUBAF";
				if ("EhwKGExvY2FsZV9DaGluZXNlU2ltcGxpZmllZBAGEh0KGUxvY2FsZV9DaGlu" != null && "EhwKGExvY2FsZV9DaGluZXNlU2ltcGxpZmllZBAGEh0KGUxvY2FsZV9DaGlu" == null)
				{
					continue;
				}
				array[4] = "EhwKGExvY2FsZV9DaGluZXNlU2ltcGxpZmllZBAGEh0KGUxvY2FsZV9DaGlu";
				if ("ZXNlVHJhZGl0aW9uYWwQB2IGcHJvdG8z" == null || "ZXNlVHJhZGl0aW9uYWwQB2IGcHJvdG8z" != null)
				{
					array[5] = "ZXNlVHJhZGl0aW9uYWwQB2IGcHJvdG8z";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(Locale);
					if ((object)typeFromHandle == null || (object)typeFromHandle != null)
					{
						break;
					}
				}
			}
			array2[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
