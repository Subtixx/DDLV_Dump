using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200061A")]
	public static class ItemsFormulasReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021A8")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012D8")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004930")]
			[Cpp2IlInjected.Address(RVA = "0x6547F0", Offset = "0x6531F0", VA = "0x1806547F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004931")]
		[Cpp2IlInjected.Address(RVA = "0x654390", Offset = "0x652D90", VA = "0x180654390")]
		static ItemsFormulasReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[5];
				if ("ChlJdGVtcy9JdGVtc0Zvcm11bGFzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVt" != null && "ChlJdGVtcy9JdGVtc0Zvcm11bGFzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVt" == null)
				{
					continue;
				}
				array[0] = "ChlJdGVtcy9JdGVtc0Zvcm11bGFzLnByb3RvEhFEZWZpbml0aW9ucy5JdGVt";
				if ("cyqQAQoPRm9ybXVsYUl0ZW1UeXBlEhkKFUZvcm11bGFJdGVtVHlwZV9Qcmlj" != null && "cyqQAQoPRm9ybXVsYUl0ZW1UeXBlEhkKFUZvcm11bGFJdGVtVHlwZV9Qcmlj" == null)
				{
					continue;
				}
				array[1] = "cyqQAQoPRm9ybXVsYUl0ZW1UeXBlEhkKFUZvcm11bGFJdGVtVHlwZV9Qcmlj";
				if ("ZRAAEh8KG0Zvcm11bGFJdGVtVHlwZV9NaXNzaW9uU3RlcBABEh0KGUZvcm11" != null && "ZRAAEh8KG0Zvcm11bGFJdGVtVHlwZV9NaXNzaW9uU3RlcBABEh0KGUZvcm11" == null)
				{
					continue;
				}
				array[2] = "ZRAAEh8KG0Zvcm11bGFJdGVtVHlwZV9NaXNzaW9uU3RlcBABEh0KGUZvcm11";
				if ("bGFJdGVtVHlwZV9TZWxsUHJpY2UQAhIiCh5Gb3JtdWxhSXRlbVR5cGVfUHJv" != null && "bGFJdGVtVHlwZV9TZWxsUHJpY2UQAhIiCh5Gb3JtdWxhSXRlbVR5cGVfUHJv" == null)
				{
					continue;
				}
				array[3] = "bGFJdGVtVHlwZV9TZWxsUHJpY2UQAhIiCh5Gb3JtdWxhSXRlbVR5cGVfUHJv";
				if ("ZmVzc2lvblN0YXQQA2IGcHJvdG8z" == null || "ZmVzc2lvblN0YXQQA2IGcHJvdG8z" != null)
				{
					array[4] = "ZmVzc2lvblN0YXQQA2IGcHJvdG8z";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(FormulaItemType);
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
