using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200061E")]
	public static class ItemsMissionsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021B7")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012DA")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004934")]
			[Cpp2IlInjected.Address(RVA = "0x655040", Offset = "0x653A40", VA = "0x180655040")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004935")]
		[Cpp2IlInjected.Address(RVA = "0x654DF0", Offset = "0x6537F0", VA = "0x180654DF0")]
		static ItemsMissionsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array;
			Type typeFromHandle;
			do
			{
				descriptorData = Convert.FromBase64String("ChlJdGVtcy9JdGVtc01pc3Npb25zLnByb3RvEhFEZWZpbml0aW9ucy5JdGVt" + "cyp3Cg9NaXNzaW9uSXRlbVR5cGUSHwobTWlzc2lvbkl0ZW1UeXBlX01pc3Np" + "b25EYXRhEAASIQodTWlzc2lvbkl0ZW1UeXBlX1NjYWxpbmdTY3JpcHQQARIg" + "ChxNaXNzaW9uSXRlbVR5cGVfTWlzc2lvblF1ZXN0EAJiBnByb3RvMw==");
				dependencies = new FileDescriptor[0];
				array = new Type[1];
				typeFromHandle = typeof(MissionItemType);
			}
			while ((object)typeFromHandle != null && (object)typeFromHandle == null);
			array[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
