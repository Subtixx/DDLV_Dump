using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class LiveopsDefinitionsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2747650", Offset = "0x2746050", VA = "0x182747650")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2747270", Offset = "0x2745C70", VA = "0x182747270")]
		static LiveopsDefinitionsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			GeneratedClrTypeInfo[] array;
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				string CS_0024_003C_003E8__locals0 = "CiBMaXZlb3BzL0xpdmVvcHNEZWZpbml0aW9ucy5wcm90bxILRGVmaW5pdGlv" + "bnMiJQoPTGl2ZW9wc01ldGFkYXRhEhIKCk1pblZlcnNpb24YASABKAliBnBy" + "b3RvMw==";
				descriptorData = Convert.FromBase64String(CS_0024_003C_003E8__locals0);
				dependencies = new FileDescriptor[0];
				array = new GeneratedClrTypeInfo[1];
				string[] array2 = new string[1];
				if ("MinVersion" == null || array2 != null)
				{
					array2[0] = "MinVersion";
					Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(LiveopsMetadata));
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
