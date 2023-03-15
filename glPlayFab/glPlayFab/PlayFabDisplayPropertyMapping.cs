using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class PlayFabDisplayPropertyMapping
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static List<DisplayPropertyIndexInfo> displayPropertyIndexInfos;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public static List<DisplayPropertyIndexInfo> DisplayPropertyIndexInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x103DA00", Offset = "0x103C400", VA = "0x18103DA00")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x103D5B0", Offset = "0x103BFB0", VA = "0x18103D5B0")]
		static PlayFabDisplayPropertyMapping()
		{
			//Discarded unreachable code: IL_014c
			List<DisplayPropertyIndexInfo> list = (List<DisplayPropertyIndexInfo>)(object)new List<T>();
			DisplayPropertyIndexInfo displayPropertyIndexInfo = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo.Type = (DisplayPropertyType?)(displayPropertyIndexInfo.Name = SearchField.displayProperties_Name.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo);
			DisplayPropertyIndexInfo displayPropertyIndexInfo2 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo2.Type = (DisplayPropertyType?)(displayPropertyIndexInfo2.Name = SearchField.displayProperties_ID.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo2);
			DisplayPropertyIndexInfo displayPropertyIndexInfo3 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo3.Type = (DisplayPropertyType?)(displayPropertyIndexInfo3.Name = SearchField.displayProperties_IsOnlineOnly.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo3);
			DisplayPropertyIndexInfo displayPropertyIndexInfo4 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo4.Type = (DisplayPropertyType?)(displayPropertyIndexInfo4.Name = SearchField.displayProperties_SearchName.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo4);
			DisplayPropertyIndexInfo displayPropertyIndexInfo5 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo5.Type = (DisplayPropertyType?)(displayPropertyIndexInfo5.Name = SearchField.displayProperties_SearchName6.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo5);
			DisplayPropertyIndexInfo displayPropertyIndexInfo6 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo6.Type = (DisplayPropertyType?)(displayPropertyIndexInfo6.Name = SearchField.displayProperties_QueryName.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo6);
			DisplayPropertyIndexInfo displayPropertyIndexInfo7 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo7.Type = (DisplayPropertyType?)(displayPropertyIndexInfo7.Name = SearchField.displayProperties_MarketplaceEpicId.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo7);
			DisplayPropertyIndexInfo displayPropertyIndexInfo8 = new DisplayPropertyIndexInfo();
			displayPropertyIndexInfo8.Type = (DisplayPropertyType?)(displayPropertyIndexInfo8.Name = SearchField.displayProperties_IsSyncOnlineItem.ParseDisplayPropertyName());
			((List<T>)(object)list).Add((T)displayPropertyIndexInfo8);
		}
	}
}
