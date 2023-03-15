using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005E3")]
	public static class ItemsDutiesAchievementsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4002019")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012CF")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004906")]
			[Cpp2IlInjected.Address(RVA = "0x64BD60", Offset = "0x64A760", VA = "0x18064BD60")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004907")]
		[Cpp2IlInjected.Address(RVA = "0x64BB10", Offset = "0x64A510", VA = "0x18064BB10")]
		static ItemsDutiesAchievementsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("CiNJdGVtcy9JdGVtc0R1dGllc0FjaGlldmVtZW50cy5wcm90bxIRRGVmaW5p" + "dGlvbnMuSXRlbXMqUQoPRHV0eUFjaEl0ZW1UeXBlEh0KGUR1dHlBY2hJdGVt" + "VHlwZV9Sb3lhbER1dHkQABIfChtEdXR5QWNoSXRlbVR5cGVfQWNoaWV2ZW1l" + "bnQQAWIGcHJvdG8z");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(DutyAchItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
