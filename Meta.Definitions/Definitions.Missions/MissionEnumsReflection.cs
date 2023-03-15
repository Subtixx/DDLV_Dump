using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000259")]
	public static class MissionEnumsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400095A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170004F7")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001666")]
			[Cpp2IlInjected.Address(RVA = "0x1D3AFA0", Offset = "0x1D399A0", VA = "0x181D3AFA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001667")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A9F0", Offset = "0x1D393F0", VA = "0x181D3A9F0")]
		static MissionEnumsReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle2;
			while (true)
			{
				string[] array = new string[7];
				if ("ChtNaXNzaW9ucy9NaXNzaW9uRW51bXMucHJvdG8SFERlZmluaXRpb25zLk1p" != null && "ChtNaXNzaW9ucy9NaXNzaW9uRW51bXMucHJvdG8SFERlZmluaXRpb25zLk1p" == null)
				{
					continue;
				}
				array[0] = "ChtNaXNzaW9ucy9NaXNzaW9uRW51bXMucHJvdG8SFERlZmluaXRpb25zLk1p";
				if ("c3Npb25zKlUKD01pc3Npb25TdGVwVHlwZRIQCgxTdGVwR2FtZXBsYXkQABIM" != null && "c3Npb25zKlUKD01pc3Npb25TdGVwVHlwZRIQCgxTdGVwR2FtZXBsYXkQABIM" == null)
				{
					continue;
				}
				array[1] = "c3Npb25zKlUKD01pc3Npb25TdGVwVHlwZRIQCgxTdGVwR2FtZXBsYXkQABIM";
				if ("CghTdGVwSXRlbRABEg8KC1N0ZXBXYWl0aW5nEAISEQoNU3RlcEludmVudG9y" != null && "CghTdGVwSXRlbRABEg8KC1N0ZXBXYWl0aW5nEAISEQoNU3RlcEludmVudG9y" == null)
				{
					continue;
				}
				array[2] = "CghTdGVwSXRlbRABEg8KC1N0ZXBXYWl0aW5nEAISEQoNU3RlcEludmVudG9y";
				if ("eRADKo4BChBNaXNzaW9uU2xvdFN0YXRlEhwKGE1pc3Npb25TbG90U3RhdGVf" != null && "eRADKo4BChBNaXNzaW9uU2xvdFN0YXRlEhwKGE1pc3Npb25TbG90U3RhdGVf" == null)
				{
					continue;
				}
				array[3] = "eRADKo4BChBNaXNzaW9uU2xvdFN0YXRlEhwKGE1pc3Npb25TbG90U3RhdGVf";
				if ("SW52YWxpZBAAEh4KGk1pc3Npb25TbG90U3RhdGVfQXZhaWxhYmxlEAESHAoY" != null && "SW52YWxpZBAAEh4KGk1pc3Npb25TbG90U3RhdGVfQXZhaWxhYmxlEAESHAoY" == null)
				{
					continue;
				}
				array[4] = "SW52YWxpZBAAEh4KGk1pc3Npb25TbG90U3RhdGVfQXZhaWxhYmxlEAESHAoY";
				if ("TWlzc2lvblNsb3RTdGF0ZV9PbkdvaW5nEAISHgoaTWlzc2lvblNsb3RTdGF0" != null && "TWlzc2lvblNsb3RTdGF0ZV9PbkdvaW5nEAISHgoaTWlzc2lvblNsb3RTdGF0" == null)
				{
					continue;
				}
				array[5] = "TWlzc2lvblNsb3RTdGF0ZV9PbkdvaW5nEAISHgoaTWlzc2lvblNsb3RTdGF0";
				if ("ZV9Db21wbGV0ZWQQA2IGcHJvdG8z" != null && "ZV9Db21wbGV0ZWQQA2IGcHJvdG8z" == null)
				{
					continue;
				}
				array[6] = "ZV9Db21wbGV0ZWQQA2IGcHJvdG8z";
				descriptorData = Convert.FromBase64String(string.Concat(array));
				dependencies = new FileDescriptor[0];
				array2 = new Type[2];
				Type typeFromHandle = typeof(MissionStepType);
				if ((object)typeFromHandle == null || (object)typeFromHandle != null)
				{
					array2[0] = typeFromHandle;
					typeFromHandle2 = typeof(MissionSlotState);
					if ((object)typeFromHandle2 == null || (object)typeFromHandle2 != null)
					{
						break;
					}
				}
			}
			array2[1] = typeFromHandle2;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
