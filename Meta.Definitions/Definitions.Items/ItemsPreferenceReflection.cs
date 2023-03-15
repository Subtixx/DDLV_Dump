using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000620")]
	public static class ItemsPreferenceReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021BC")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012DB")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004936")]
			[Cpp2IlInjected.Address(RVA = "0x6552F0", Offset = "0x653CF0", VA = "0x1806552F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004937")]
		[Cpp2IlInjected.Address(RVA = "0x6550A0", Offset = "0x653AA0", VA = "0x1806550A0")]
		static ItemsPreferenceReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("ChtJdGVtcy9JdGVtc1ByZWZlcmVuY2UucHJvdG8SEURlZmluaXRpb25zLkl0" + "ZW1zKlEKElByZWZlcmVuY2VJdGVtVHlwZRIeChpQcmVmZXJlbmNlSXRlbVR5" + "cGVfUHJvZmlsZRAAEhsKF1ByZWZlcmVuY2VJdGVtVHlwZV9Qb29sEAFiBnBy" + "b3RvMw==");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(PreferenceItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
