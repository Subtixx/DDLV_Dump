using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.DreamDust
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public static class DreamDustReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA1")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DA50", Offset = "0x2C4C450", VA = "0x182C4DA50")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D570", Offset = "0x2C4BF70", VA = "0x182C4D570")]
		static DreamDustReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			GeneratedClrTypeInfo[] array;
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				int num = 0;
				string CS_0024_003C_003E8__locals0 = "ChVTaG9wcy9EcmVhbUR1c3QucHJvdG8SFURlZmluaXRpb25zLkRyZWFtRHVz" + "dCJYChBDb252ZXJzaW9uVmFsdWVzEhgKEGZ1cm5pdHVyZVBlclN0YXIYASAB" + "KAUSFwoPY2xvdGhpbmdQZXJTdGFyGAIgASgFEhEKCWNoYXJhY3RlchgDIAEo" + "BWIGcHJvdG8z";
				descriptorData = Convert.FromBase64String(CS_0024_003C_003E8__locals0);
				dependencies = new FileDescriptor[0];
				array = new GeneratedClrTypeInfo[1];
				string[] array2 = new string[3];
				if ("FurniturePerStar" != null && "FurniturePerStar" == null)
				{
					continue;
				}
				array2[0] = "FurniturePerStar";
				if ("ClothingPerStar" != null && "ClothingPerStar" == null)
				{
					continue;
				}
				array2[1] = "ClothingPerStar";
				if ("Character" == null || "Character" != null)
				{
					array2[2] = "Character";
					Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(ConversionValues));
					if (generatedClrTypeInfo == null || generatedClrTypeInfo != null)
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
