using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x2001104")]
	public static class FurnitureReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4004632")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700184E")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008ACA")]
			[Cpp2IlInjected.Address(RVA = "0x180AAA0", Offset = "0x18094A0", VA = "0x18180AAA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008ACB")]
		[Cpp2IlInjected.Address(RVA = "0x180A5E0", Offset = "0x1808FE0", VA = "0x18180A5E0")]
		static FurnitureReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			GeneratedClrTypeInfo[] array;
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				string CS_0024_003C_003E8__locals0 = "Cg9GdXJuaXR1cmUucHJvdG8SEk1ldGEuQ3VzdG9taXphdGlvbiJFCglGdXJu" + "aXR1cmUSCgoCSWQYASABKA0SFQoNRnVybml0dXJlSXRlbRgCIAEoBRIVCg1D" + "dXJyZW50RGVzaWduGAMgASgFYgZwcm90bzM=";
				descriptorData = Convert.FromBase64String(CS_0024_003C_003E8__locals0);
				dependencies = new FileDescriptor[0];
				array = new GeneratedClrTypeInfo[1];
				string[] array2 = new string[3];
				if ("Id" != null && "Id" == null)
				{
					continue;
				}
				array2[0] = "Id";
				if ("FurnitureItem" != null && "FurnitureItem" == null)
				{
					continue;
				}
				array2[1] = "FurnitureItem";
				if ("CurrentDesign" == null || "CurrentDesign" != null)
				{
					array2[2] = "CurrentDesign";
					Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(Furniture));
					int num = 0;
					if (generatedClrTypeInfo == null || num != 0)
					{
						break;
					}
				}
			}
			array[0] = generatedClrTypeInfo;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
