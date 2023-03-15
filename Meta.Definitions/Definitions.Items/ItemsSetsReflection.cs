using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000624")]
	public static class ItemsSetsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021CA")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012DD")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600493A")]
			[Cpp2IlInjected.Address(RVA = "0x27375E0", Offset = "0x2735FE0", VA = "0x1827375E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600493B")]
		[Cpp2IlInjected.Address(RVA = "0x2737390", Offset = "0x2735D90", VA = "0x182737390")]
		static ItemsSetsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("ChVJdGVtcy9JdGVtc1NldHMucHJvdG8SEURlZmluaXRpb25zLkl0ZW1zKnEK" + "C1NldEl0ZW1UeXBlEhkKFVNldEl0ZW1UeXBlX0Z1cm5pdHVyZRAAEhgKFFNl" + "dEl0ZW1UeXBlX0Nsb3RoaW5nEAESFQoRU2V0SXRlbVR5cGVfRGVjYWwQAhIW" + "ChJTZXRJdGVtVHlwZV9NYWtldXAQA2IGcHJvdG8z");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(SetItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
