using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005DD")]
	public static class ItemsBuildingsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4002004")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012CC")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004900")]
			[Cpp2IlInjected.Address(RVA = "0x64B280", Offset = "0x649C80", VA = "0x18064B280")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004901")]
		[Cpp2IlInjected.Address(RVA = "0x64ADB0", Offset = "0x6497B0", VA = "0x18064ADB0")]
		static ItemsBuildingsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[6];
				if ("ChpJdGVtcy9JdGVtc0J1aWxkaW5ncy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl" != null && "ChpJdGVtcy9JdGVtc0J1aWxkaW5ncy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl" == null)
				{
					continue;
				}
				array[0] = "ChpJdGVtcy9JdGVtc0J1aWxkaW5ncy5wcm90bxIRRGVmaW5pdGlvbnMuSXRl";
				if ("bXMqywEKEEJ1aWxkaW5nSXRlbVR5cGUSGgoWQnVpbGRpbmdJdGVtVHlwZV9I" != null && "bXMqywEKEEJ1aWxkaW5nSXRlbVR5cGUSGgoWQnVpbGRpbmdJdGVtVHlwZV9I" == null)
				{
					continue;
				}
				array[1] = "bXMqywEKEEJ1aWxkaW5nSXRlbVR5cGUSGgoWQnVpbGRpbmdJdGVtVHlwZV9I";
				if ("b3VzZRAAEhoKFkJ1aWxkaW5nSXRlbVR5cGVfU3RhbGwQARIbChdCdWlsZGlu" != null && "b3VzZRAAEhoKFkJ1aWxkaW5nSXRlbVR5cGVfU3RhbGwQARIbChdCdWlsZGlu" == null)
				{
					continue;
				}
				array[2] = "b3VzZRAAEhoKFkJ1aWxkaW5nSXRlbVR5cGVfU3RhbGwQARIbChdCdWlsZGlu";
				if ("Z0l0ZW1UeXBlX0dhcmRlbhACEhoKFkJ1aWxkaW5nSXRlbVR5cGVfT3RoZXIQ" != null && "Z0l0ZW1UeXBlX0dhcmRlbhACEhoKFkJ1aWxkaW5nSXRlbVR5cGVfT3RoZXIQ" == null)
				{
					continue;
				}
				array[3] = "Z0l0ZW1UeXBlX0dhcmRlbhACEhoKFkJ1aWxkaW5nSXRlbVR5cGVfT3RoZXIQ";
				if ("AxIkCiBCdWlsZGluZ0l0ZW1UeXBlX09mZkdyaWRCdWlsZGluZxAEEiAKHEJ1" != null && "AxIkCiBCdWlsZGluZ0l0ZW1UeXBlX09mZkdyaWRCdWlsZGluZxAEEiAKHEJ1" == null)
				{
					continue;
				}
				array[4] = "AxIkCiBCdWlsZGluZ0l0ZW1UeXBlX09mZkdyaWRCdWlsZGluZxAEEiAKHEJ1";
				if ("aWxkaW5nSXRlbVR5cGVfUGxheWVySG91c2UQBWIGcHJvdG8z" == null || "aWxkaW5nSXRlbVR5cGVfUGxheWVySG91c2UQBWIGcHJvdG8z" != null)
				{
					array[5] = "aWxkaW5nSXRlbVR5cGVfUGxheWVySG91c2UQBWIGcHJvdG8z";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(BuildingItemType);
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
