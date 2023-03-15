using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000628")]
	public static class ItemsToolsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021E1")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012DF")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600493E")]
			[Cpp2IlInjected.Address(RVA = "0x2738270", Offset = "0x2736C70", VA = "0x182738270")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600493F")]
		[Cpp2IlInjected.Address(RVA = "0x2737E10", Offset = "0x2736810", VA = "0x182737E10")]
		static ItemsToolsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[5];
				if ("ChZJdGVtcy9JdGVtc1Rvb2xzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVtcyqP" != null && "ChZJdGVtcy9JdGVtc1Rvb2xzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVtcyqP" == null)
				{
					continue;
				}
				array[0] = "ChZJdGVtcy9JdGVtc1Rvb2xzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVtcyqP";
				if ("AQoMVG9vbEl0ZW1UeXBlEhoKFlRvb2xJdGVtVHlwZV9HYXJkZW5pbmcQABIY" != null && "AQoMVG9vbEl0ZW1UeXBlEhoKFlRvb2xJdGVtVHlwZV9HYXJkZW5pbmcQABIY" == null)
				{
					continue;
				}
				array[1] = "AQoMVG9vbEl0ZW1UeXBlEhoKFlRvb2xJdGVtVHlwZV9HYXJkZW5pbmcQABIY";
				if ("ChRUb29sSXRlbVR5cGVfRmlzaGluZxABEhcKE1Rvb2xJdGVtVHlwZV9NaW5p" != null && "ChRUb29sSXRlbVR5cGVfRmlzaGluZxABEhcKE1Rvb2xJdGVtVHlwZV9NaW5p" == null)
				{
					continue;
				}
				array[2] = "ChRUb29sSXRlbVR5cGVfRmlzaGluZxABEhcKE1Rvb2xJdGVtVHlwZV9NaW5p";
				if ("bmcQBBIZChVUb29sSXRlbVR5cGVfV2F0ZXJpbmcQBRIVChFUb29sSXRlbVR5" != null && "bmcQBBIZChVUb29sSXRlbVR5cGVfV2F0ZXJpbmcQBRIVChFUb29sSXRlbVR5" == null)
				{
					continue;
				}
				array[3] = "bmcQBBIZChVUb29sSXRlbVR5cGVfV2F0ZXJpbmcQBRIVChFUb29sSXRlbVR5";
				if ("cGVfTWlzYxAGYgZwcm90bzM=" == null || "cGVfTWlzYxAGYgZwcm90bzM=" != null)
				{
					array[4] = "cGVfTWlzYxAGYgZwcm90bzM=";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(ToolItemType);
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
