using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class RpcErrorReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x38E2140", Offset = "0x38E0B40", VA = "0x1838E2140")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x38E19E0", Offset = "0x38E03E0", VA = "0x1838E19E0")]
		static RpcErrorReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] array2;
			GeneratedClrTypeInfo[] array3;
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				string[] array = new string[6];
				if ("Cg5ScGNFcnJvci5wcm90bxIRR2FtZWxvZnQuUnBjLkNvcmUaIGdvb2dsZS9w" != null && "Cg5ScGNFcnJvci5wcm90bxIRR2FtZWxvZnQuUnBjLkNvcmUaIGdvb2dsZS9w" == null)
				{
					continue;
				}
				array[0] = "Cg5ScGNFcnJvci5wcm90bxIRR2FtZWxvZnQuUnBjLkNvcmUaIGdvb2dsZS9w";
				if ("cm90b2J1Zi9kZXNjcmlwdG9yLnByb3RvIjQKEFVua25vd25FeGNlcHRpb24S" != null && "cm90b2J1Zi9kZXNjcmlwdG9yLnByb3RvIjQKEFVua25vd25FeGNlcHRpb24S" == null)
				{
					continue;
				}
				array[1] = "cm90b2J1Zi9kZXNjcmlwdG9yLnByb3RvIjQKEFVua25vd25FeGNlcHRpb24S";
				if ("DwoHY2xyVHlwZRgBIAEoCRIPCgdtZXNzYWdlGAIgASgJOi4KBXRocm93Eh4u" != null && "DwoHY2xyVHlwZRgBIAEoCRIPCgdtZXNzYWdlGAIgASgJOi4KBXRocm93Eh4u" == null)
				{
					continue;
				}
				array[2] = "DwoHY2xyVHlwZRgBIAEoCRIPCgdtZXNzYWdlGAIgASgJOi4KBXRocm93Eh4u";
				if ("Z29vZ2xlLnByb3RvYnVmLk1ldGhvZE9wdGlvbnMY0A8gAygJOjEKB2NsclR5" != null && "Z29vZ2xlLnByb3RvYnVmLk1ldGhvZE9wdGlvbnMY0A8gAygJOjEKB2NsclR5" == null)
				{
					continue;
				}
				array[3] = "Z29vZ2xlLnByb3RvYnVmLk1ldGhvZE9wdGlvbnMY0A8gAygJOjEKB2NsclR5";
				if ("cGUSHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMY0Q8gASgJYgZw" != null && "cGUSHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMY0Q8gASgJYgZw" == null)
				{
					continue;
				}
				array[4] = "cGUSHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMY0Q8gASgJYgZw";
				if ("cm90bzM=" != null && "cm90bzM=" == null)
				{
					continue;
				}
				array[5] = "cm90bzM=";
				descriptorData = Convert.FromBase64String(string.Concat(array));
				array2 = new FileDescriptor[1];
				int num = 0;
				FileDescriptor CS_0024_003C_003E8__locals0 = FileDescriptor.DescriptorProtoFileDescriptor;
				if (CS_0024_003C_003E8__locals0 != null && CS_0024_003C_003E8__locals0 == null)
				{
					continue;
				}
				array2[0] = CS_0024_003C_003E8__locals0;
				array3 = new GeneratedClrTypeInfo[1];
				string[] array4 = new string[2];
				if ("ClrType" != null && "ClrType" == null)
				{
					continue;
				}
				array4[0] = "ClrType";
				if ("Message" == null || "Message" != null)
				{
					array4[1] = "Message";
					Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(UnknownException));
					int num2 = 0;
					if (generatedClrTypeInfo == null || num2 != 0)
					{
						break;
					}
				}
			}
			array3[0] = generatedClrTypeInfo;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, array2, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
