using CloudScripts;
using Cpp2IlInjected;
using Definitions;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DA4")]
	public static class LiveopsExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007237")]
		[Cpp2IlInjected.Address(RVA = "0x19C2820", Offset = "0x19C1220", VA = "0x1819C2820")]
		public unsafe static T CreateCloudScriptRequest<T>(this ILiveopsRequestBase clientRequest) where T : GetLiveopsDataRequest, new()
		{
			//Discarded unreachable code: IL_0029
			//IL_0023: Expected I4, but got O
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			int num4 = 0;
			string currentLanguage = LocalizationUtil.CurrentLanguage;
			((int*)num4)->m_value = (int)currentLanguage;
			return (T)typeof(LocalizationUtil).TypeHandle;
		}
	}
}
