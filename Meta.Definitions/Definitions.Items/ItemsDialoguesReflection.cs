using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005E1")]
	public static class ItemsDialoguesReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4002010")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012CE")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004904")]
			[Cpp2IlInjected.Address(RVA = "0x64BAB0", Offset = "0x64A4B0", VA = "0x18064BAB0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004905")]
		[Cpp2IlInjected.Address(RVA = "0x64B570", Offset = "0x649F70", VA = "0x18064B570")]
		static ItemsDialoguesReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[7];
				if ("ChpJdGVtcy9JdGVtc0RpYWxvZ3Vlcy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl" != null && "ChpJdGVtcy9JdGVtc0RpYWxvZ3Vlcy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl" == null)
				{
					continue;
				}
				array[0] = "ChpJdGVtcy9JdGVtc0RpYWxvZ3Vlcy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl";
				if ("bXMq7gEKEERpYWxvZ3VlSXRlbVR5cGUSHQoZRGlhbG9ndWVJdGVtVHlwZV9H" != null && "bXMq7gEKEERpYWxvZ3VlSXRlbVR5cGUSHQoZRGlhbG9ndWVJdGVtVHlwZV9H" == null)
				{
					continue;
				}
				array[1] = "bXMq7gEKEERpYWxvZ3VlSXRlbVR5cGUSHQoZRGlhbG9ndWVJdGVtVHlwZV9H";
				if ("cmVldGluZxAAEh8KG0RpYWxvZ3VlSXRlbVR5cGVfRGlzY3Vzc2lvbhABEhwK" != null && "cmVldGluZxAAEh8KG0RpYWxvZ3VlSXRlbVR5cGVfRGlzY3Vzc2lvbhABEhwK" == null)
				{
					continue;
				}
				array[2] = "cmVldGluZxAAEh8KG0RpYWxvZ3VlSXRlbVR5cGVfRGlzY3Vzc2lvbhABEhwK";
				if ("GERpYWxvZ3VlSXRlbVR5cGVfQ2FsbG91dBACEiIKHkRpYWxvZ3VlSXRlbVR5" != null && "GERpYWxvZ3VlSXRlbVR5cGVfQ2FsbG91dBACEiIKHkRpYWxvZ3VlSXRlbVR5" == null)
				{
					continue;
				}
				array[3] = "GERpYWxvZ3VlSXRlbVR5cGVfQ2FsbG91dBACEiIKHkRpYWxvZ3VlSXRlbVR5";
				if ("cGVfTnBjRGlzY3Vzc2lvbhADEh8KG0RpYWxvZ3VlSXRlbVR5cGVfR2lmdFRo" != null && "cGVfTnBjRGlzY3Vzc2lvbhADEh8KG0RpYWxvZ3VlSXRlbVR5cGVfR2lmdFRo" == null)
				{
					continue;
				}
				array[4] = "cGVfTnBjRGlzY3Vzc2lvbhADEh8KG0RpYWxvZ3VlSXRlbVR5cGVfR2lmdFRo";
				if ("YW5rcxAEEhkKFURpYWxvZ3VlSXRlbVR5cGVfRmxhZxAFEhwKGERpYWxvZ3Vl" != null && "YW5rcxAEEhkKFURpYWxvZ3VlSXRlbVR5cGVfRmxhZxAFEhwKGERpYWxvZ3Vl" == null)
				{
					continue;
				}
				array[5] = "YW5rcxAEEhkKFURpYWxvZ3VlSXRlbVR5cGVfRmxhZxAFEhwKGERpYWxvZ3Vl";
				if ("SXRlbVR5cGVfSGFuZ291dBAGYgZwcm90bzM=" == null || "SXRlbVR5cGVfSGFuZ291dBAGYgZwcm90bzM=" != null)
				{
					array[6] = "SXRlbVR5cGVfSGFuZ291dBAGYgZwcm90bzM=";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(DialogueItemType);
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
