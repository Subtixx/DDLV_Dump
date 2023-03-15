using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public static class TimeOfDayReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x3548AB0", Offset = "0x35474B0", VA = "0x183548AB0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x3547FA0", Offset = "0x35469A0", VA = "0x183547FA0")]
		static TimeOfDayReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] array2;
			GeneratedClrTypeInfo[] array3;
			GeneratedClrTypeInfo CS_0024_003C_003E8__locals1 = default(GeneratedClrTypeInfo);
			GeneratedClrTypeInfo generatedClrTypeInfo = default(GeneratedClrTypeInfo);
			while (true)
			{
				string[] array = new string[6];
				if ("Cg9UaW1lT2ZEYXkucHJvdG8SC0RlZmluaXRpb25zGhJGaWVsZE9wdGlvbnMu" != null && "Cg9UaW1lT2ZEYXkucHJvdG8SC0RlZmluaXRpb25zGhJGaWVsZE9wdGlvbnMu" == null)
				{
					continue;
				}
				array[0] = "Cg9UaW1lT2ZEYXkucHJvdG8SC0RlZmluaXRpb25zGhJGaWVsZE9wdGlvbnMu";
				if ("cHJvdG8aFE1lc3NhZ2VPcHRpb25zLnByb3RvIkUKCVRpbWVPZkRheRIcCgVT" != null && "cHJvdG8aFE1lc3NhZ2VPcHRpb25zLnByb3RvIkUKCVRpbWVPZkRheRIcCgVT" == null)
				{
					continue;
				}
				array[1] = "cHJvdG8aFE1lc3NhZ2VPcHRpb25zLnByb3RvIkUKCVRpbWVPZkRheRIcCgVT";
				if ("dGFydBgBIAEoBUINurUYCQgBGAElAAC4QRIaCgNFbmQYAiABKAVCDbq1GAkI" != null && "dGFydBgBIAEoBUINurUYCQgBGAElAAC4QRIaCgNFbmQYAiABKAVCDbq1GAkI" == null)
				{
					continue;
				}
				array[2] = "dGFydBgBIAEoBUINurUYCQgBGAElAAC4QRIaCgNFbmQYAiABKAVCDbq1GAkI";
				if ("ARgBJQAAuEEibQoJVGltZUluRGF5EicKBEhvdXIYAiABKAVCGZi2GADqtRgE" != null && "ARgBJQAAuEEibQoJVGltZUluRGF5EicKBEhvdXIYAiABKAVCGZi2GADqtRgE" == null)
				{
					continue;
				}
				array[3] = "ARgBJQAAuEEibQoJVGltZUluRGF5EicKBEhvdXIYAiABKAVCGZi2GADqtRgE";
				if ("UgIIHrq1GAkIARgBJQAAuEESLwoGTWludXRlGAMgASgFQh+ithgBOuq1GAlS" != null && "UgIIHrq1GAkIARgBJQAAuEESLwoGTWludXRlGAMgASgFQh+ithgBOuq1GAlS" == null)
				{
					continue;
				}
				array[4] = "UgIIHrq1GAkIARgBJQAAuEESLwoGTWludXRlGAMgASgFQh+ithgBOuq1GAlS";
				if ("Aggt+gECCA+6tRgJCAEYASUAAGxCOgaSshkCCAFiBnByb3RvMw==" != null && "Aggt+gECCA+6tRgJCAEYASUAAGxCOgaSshkCCAFiBnByb3RvMw==" == null)
				{
					continue;
				}
				array[5] = "Aggt+gECCA+6tRgJCAEYASUAAGxCOgaSshkCCAFiBnByb3RvMw==";
				string CS_0024_003C_003E8__locals0 = string.Concat(array);
				descriptorData = Convert.FromBase64String(CS_0024_003C_003E8__locals0);
				array2 = new FileDescriptor[2];
				if (CS_0024_003C_003E8__locals0 != null)
				{
				}
				array2[0] = (FileDescriptor)(object)CS_0024_003C_003E8__locals0;
				if (CS_0024_003C_003E8__locals0 != null)
				{
				}
				array2[1] = (FileDescriptor)(object)CS_0024_003C_003E8__locals0;
				array3 = new GeneratedClrTypeInfo[2];
				string[] array4 = new string[2];
				if ("Start" != null && "Start" == null)
				{
					continue;
				}
				array4[0] = "Start";
				if ("End" != null && "End" == null)
				{
					continue;
				}
				array4[1] = "End";
				Func<Type> func = (Func<Type>)(object)(Func<TResult>)(() => typeof(TimeOfDay));
				int num = 0;
				if (CS_0024_003C_003E8__locals1 != null && CS_0024_003C_003E8__locals1 == null)
				{
					continue;
				}
				array3[0] = CS_0024_003C_003E8__locals1;
				string[] array5 = new string[2];
				if ("Hour" != null && "Hour" == null)
				{
					continue;
				}
				array5[0] = "Hour";
				if ("Minute" == null || "Minute" != null)
				{
					array5[1] = "Minute";
					Func<Type> func2 = (Func<Type>)(object)(Func<TResult>)(() => typeof(TimeInDay));
					if (generatedClrTypeInfo == null || generatedClrTypeInfo != null)
					{
						break;
					}
				}
			}
			array3[1] = generatedClrTypeInfo;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, array2, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
