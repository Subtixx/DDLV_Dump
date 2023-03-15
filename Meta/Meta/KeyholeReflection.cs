using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class KeyholeReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x18A0940", Offset = "0x189F340", VA = "0x1818A0940")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x18A0370", Offset = "0x189ED70", VA = "0x1818A0370")]
		static KeyholeReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] array;
			GeneratedClrTypeInfo[] array2;
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				int num = 0;
				string CS_0024_003C_003E8__locals0 = "Cg1LZXlob2xlLnByb3RvEgRNZXRhGhhLZXlob2xlRGVmaW5pdGlvbnMucHJv" + "dG8iZAoHS2V5aG9sZRI1CgdDb250ZW50GAEgAygLMiQuRGVmaW5pdGlvbnMu" + "S2V5aG9sZXMuS2V5aG9sZUNvbnRlbnQSDAoER1VJRBgCIAEoCRIUCgxDdXJy" + "ZW50TGV2ZWwYAyABKAViBnByb3RvMw==";
				descriptorData = Convert.FromBase64String(CS_0024_003C_003E8__locals0);
				array = new FileDescriptor[1];
				if (CS_0024_003C_003E8__locals0 != null)
				{
				}
				array[0] = (FileDescriptor)(object)CS_0024_003C_003E8__locals0;
				array2 = new GeneratedClrTypeInfo[1];
				string[] array3 = new string[3];
				if ("Content" != null && "Content" == null)
				{
					continue;
				}
				array3[0] = "Content";
				if ("GUID" != null && "GUID" == null)
				{
					continue;
				}
				array3[1] = "GUID";
				if ("CurrentLevel" == null || "CurrentLevel" != null)
				{
					array3[2] = "CurrentLevel";
					Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(Keyhole));
					if (generatedClrTypeInfo == null || generatedClrTypeInfo != null)
					{
						break;
					}
				}
			}
			array2[0] = generatedClrTypeInfo;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, array, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
