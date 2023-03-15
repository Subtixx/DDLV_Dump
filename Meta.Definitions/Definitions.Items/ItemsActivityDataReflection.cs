using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005DB")]
	public static class ItemsActivityDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4001FFE")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012CB")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60048FE")]
			[Cpp2IlInjected.Address(RVA = "0x64AD50", Offset = "0x649750", VA = "0x18064AD50")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048FF")]
		[Cpp2IlInjected.Address(RVA = "0x64A880", Offset = "0x649280", VA = "0x18064A880")]
		static ItemsActivityDataReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[6];
				if ("Ch1JdGVtcy9JdGVtc0FjdGl2aXR5RGF0YS5wcm90bxIRRGVmaW5pdGlvbnMu" != null && "Ch1JdGVtcy9JdGVtc0FjdGl2aXR5RGF0YS5wcm90bxIRRGVmaW5pdGlvbnMu" == null)
				{
					continue;
				}
				array[0] = "Ch1JdGVtcy9JdGVtc0FjdGl2aXR5RGF0YS5wcm90bxIRRGVmaW5pdGlvbnMu";
				if ("SXRlbXMqsgEKFEFjdGl2aXR5RGF0YUl0ZW1UeXBlEiYKIkFjdGl2aXR5RGF0" != null && "SXRlbXMqsgEKFEFjdGl2aXR5RGF0YUl0ZW1UeXBlEiYKIkFjdGl2aXR5RGF0" == null)
				{
					continue;
				}
				array[1] = "SXRlbXMqsgEKFEFjdGl2aXR5RGF0YUl0ZW1UeXBlEiYKIkFjdGl2aXR5RGF0";
				if ("YUl0ZW1UeXBlX0Nvb2tpbmdSZWNpcGUQABIkCiBBY3Rpdml0eURhdGFJdGVt" != null && "YUl0ZW1UeXBlX0Nvb2tpbmdSZWNpcGUQABIkCiBBY3Rpdml0eURhdGFJdGVt" == null)
				{
					continue;
				}
				array[2] = "YUl0ZW1UeXBlX0Nvb2tpbmdSZWNpcGUQABIkCiBBY3Rpdml0eURhdGFJdGVt";
				if ("VHlwZV9GaXNoaW5nRGF0YRABEiMKH0FjdGl2aXR5RGF0YUl0ZW1UeXBlX01p" != null && "VHlwZV9GaXNoaW5nRGF0YRABEiMKH0FjdGl2aXR5RGF0YUl0ZW1UeXBlX01p" == null)
				{
					continue;
				}
				array[3] = "VHlwZV9GaXNoaW5nRGF0YRABEiMKH0FjdGl2aXR5RGF0YUl0ZW1UeXBlX01p";
				if ("bmluZ0RhdGEQAhInCiNBY3Rpdml0eURhdGFJdGVtVHlwZV9DcmFmdGluZ1Jl" != null && "bmluZ0RhdGEQAhInCiNBY3Rpdml0eURhdGFJdGVtVHlwZV9DcmFmdGluZ1Jl" == null)
				{
					continue;
				}
				array[4] = "bmluZ0RhdGEQAhInCiNBY3Rpdml0eURhdGFJdGVtVHlwZV9DcmFmdGluZ1Jl";
				if ("Y2lwZRADYgZwcm90bzM=" == null || "Y2lwZRADYgZwcm90bzM=" != null)
				{
					array[5] = "Y2lwZRADYgZwcm90bzM=";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(ActivityDataItemType);
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
