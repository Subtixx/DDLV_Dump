using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200062A")]
	public static class ItemsTrimmingsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021E8")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012E0")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004940")]
			[Cpp2IlInjected.Address(RVA = "0x2738520", Offset = "0x2736F20", VA = "0x182738520")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004941")]
		[Cpp2IlInjected.Address(RVA = "0x27382D0", Offset = "0x2736CD0", VA = "0x1827382D0")]
		static ItemsTrimmingsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("ChpJdGVtcy9JdGVtc1RyaW1taW5ncy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl" + "bXMqUQoQVHJpbW1pbmdJdGVtVHlwZRIeChpUcmltbWluZ0l0ZW1UeXBlX1dh" + "bGxwYXBlchAAEh0KGVRyaW1taW5nSXRlbVR5cGVfRmxvb3JpbmcQAWIGcHJv" + "dG8z");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(TrimmingItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
