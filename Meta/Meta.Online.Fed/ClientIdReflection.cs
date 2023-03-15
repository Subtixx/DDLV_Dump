using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Online.Fed
{
	[Cpp2IlInjected.Token(Token = "0x2000FE7")]
	public static class ClientIdReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4004154")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700165E")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007FEA")]
			[Cpp2IlInjected.Address(RVA = "0x1672EF0", Offset = "0x16718F0", VA = "0x181672EF0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007FEB")]
		[Cpp2IlInjected.Address(RVA = "0x16728D0", Offset = "0x16712D0", VA = "0x1816728D0")]
		static ClientIdReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle2;
			while (true)
			{
				string[] array = new string[8];
				if ("Cg5DbGllbnRJZC5wcm90bxIPTWV0YS5PbmxpbmUuRmVkKnEKCFBsYXRmb3Jt" != null && "Cg5DbGllbnRJZC5wcm90bxIPTWV0YS5PbmxpbmUuRmVkKnEKCFBsYXRmb3Jt" == null)
				{
					continue;
				}
				array[0] = "Cg5DbGllbnRJZC5wcm90bxIPTWV0YS5PbmxpbmUuRmVkKnEKCFBsYXRmb3Jt";
				if ("EhAKDFBsYXRmb3JtX2lPUxAAEhQKEFBsYXRmb3JtX0FuZHJvaWQQARITCg9Q" != null && "EhAKDFBsYXRmb3JtX2lPUxAAEhQKEFBsYXRmb3JtX0FuZHJvaWQQARITCg9Q" == null)
				{
					continue;
				}
				array[1] = "EhAKDFBsYXRmb3JtX2lPUxAAEhQKEFBsYXRmb3JtX0FuZHJvaWQQARITCg9Q";
				if ("bGF0Zm9ybV9Td2l0Y2gQAhIUChBQbGF0Zm9ybV9XaW5kb3dzEAMSEgoOUGxh" != null && "bGF0Zm9ybV9Td2l0Y2gQAhIUChBQbGF0Zm9ybV9XaW5kb3dzEAMSEgoOUGxh" == null)
				{
					continue;
				}
				array[2] = "bGF0Zm9ybV9Td2l0Y2gQAhIUChBQbGF0Zm9ybV9XaW5kb3dzEAMSEgoOUGxh";
				if ("dGZvcm1fU3RlYW0QBCqdAQoORG93bmxvYWRTb3VyY2USGwoXRG93bmxvYWRT" != null && "dGZvcm1fU3RlYW0QBCqdAQoORG93bmxvYWRTb3VyY2USGwoXRG93bmxvYWRT" == null)
				{
					continue;
				}
				array[3] = "dGZvcm1fU3RlYW0QBCqdAQoORG93bmxvYWRTb3VyY2USGwoXRG93bmxvYWRT";
				if ("b3VyY2VfQXBwc3RvcmUQABIdChlEb3dubG9hZFNvdXJjZV9Hb29nbGVQbGF5" != null && "b3VyY2VfQXBwc3RvcmUQABIdChlEb3dubG9hZFNvdXJjZV9Hb29nbGVQbGF5" == null)
				{
					continue;
				}
				array[4] = "b3VyY2VfQXBwc3RvcmUQABIdChlEb3dubG9hZFNvdXJjZV9Hb29nbGVQbGF5";
				if ("EAESGQoVRG93bmxvYWRTb3VyY2VfU3dpdGNoEAISGgoWRG93bmxvYWRTb3Vy" != null && "EAESGQoVRG93bmxvYWRTb3VyY2VfU3dpdGNoEAISGgoWRG93bmxvYWRTb3Vy" == null)
				{
					continue;
				}
				array[5] = "EAESGQoVRG93bmxvYWRTb3VyY2VfU3dpdGNoEAISGgoWRG93bmxvYWRTb3Vy";
				if ("Y2VfV2luZG93cxADEhgKFERvd25sb2FkU291cmNlX1N0ZWFtEARiBnByb3Rv" != null && "Y2VfV2luZG93cxADEhgKFERvd25sb2FkU291cmNlX1N0ZWFtEARiBnByb3Rv" == null)
				{
					continue;
				}
				array[6] = "Y2VfV2luZG93cxADEhgKFERvd25sb2FkU291cmNlX1N0ZWFtEARiBnByb3Rv";
				if ("Mw==" != null && "Mw==" == null)
				{
					continue;
				}
				array[7] = "Mw==";
				descriptorData = Convert.FromBase64String(string.Concat(array));
				dependencies = new FileDescriptor[0];
				array2 = new Type[2];
				Type typeFromHandle = typeof(Platform);
				if ((object)typeFromHandle == null || (object)typeFromHandle != null)
				{
					array2[0] = typeFromHandle;
					typeFromHandle2 = typeof(DownloadSource);
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
