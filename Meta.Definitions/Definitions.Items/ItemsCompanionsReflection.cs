using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005DF")]
	public static class ItemsCompanionsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400200C")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012CD")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004902")]
			[Cpp2IlInjected.Address(RVA = "0x64B510", Offset = "0x649F10", VA = "0x18064B510")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004903")]
		[Cpp2IlInjected.Address(RVA = "0x64B2E0", Offset = "0x649CE0", VA = "0x18064B2E0")]
		static ItemsCompanionsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("ChtJdGVtcy9JdGVtc0NvbXBhbmlvbnMucHJvdG8SEURlZmluaXRpb25zLkl0" + "ZW1zKk0KEUNvbXBhbmlvbkl0ZW1UeXBlEhkKFUNvbXBhbmlvbkl0ZW1UeXBl" + "X1BldBAAEh0KGUNvbXBhbmlvbkl0ZW1UeXBlX0NyaXR0ZXIQAWIGcHJvdG8z");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(CompanionItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
