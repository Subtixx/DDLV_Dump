using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class CatalogItemExt
	{
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public const string FriendlyIdKey = "FriendlyId";

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public const string NeutralKey = "neutral";

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public const string NeutralKeyUpper = "NEUTRAL";

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public const string ScreenshotType = "Screenshot";

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public const string ThumbnailType = "Thumbnail";

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public const string CurrencySuffix = "_OnlineCurrency";

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public const string RecipeKeySuffix = "_OnlineKey";

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public const string RecipeSuffix = "_OnlineRecipe";

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public const string BaseConfigSuffix = "_BaseConfig";

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public const string TaskConfigSuffix = "_TaskConfig";

		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public const string DisplayPropertyKey_StoreFrontGroup = "StoreFrontGroup";

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10263D0", Offset = "0x1024DD0", VA = "0x1810263D0")]
		public static string GetFriendlyName(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0045
			List<CatalogAlternateId> alternateIds = self.AlternateIds;
			if (alternateIds != null)
			{
				Func<CatalogAlternateId, bool> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CatalogAlternateId x) => string.Equals(x.Type, "FriendlyId"));
				}
				CatalogAlternateId catalogAlternateId = Enumerable.FirstOrDefault<CatalogAlternateId>((IEnumerable<>)alternateIds, (Func<, >)(object)_003C_003E9__5_);
				if (catalogAlternateId != null && catalogAlternateId.Value != null)
				{
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1026890", Offset = "0x1025290", VA = "0x181026890")]
		public unsafe static string GetNeutralTitle(this CatalogItem self)
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			Dictionary<string, string> title = self.Title;
			if (title == null || ((Dictionary<TKey, TValue>)(object)title).TryGetValue((TKey)"neutral", out *(TValue*)num))
			{
			}
			Dictionary<string, string> title2 = self.Title;
			if (title2 == null || ((Dictionary<TKey, TValue>)(object)title2).TryGetValue((TKey)"NEUTRAL", out *(TValue*)num))
			{
			}
			return "No Title";
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x10267C0", Offset = "0x10251C0", VA = "0x1810267C0")]
		public unsafe static string GetNeutralDescription(this CatalogItem self)
		{
			//Discarded unreachable code: IL_003c
			int num = 0;
			Dictionary<string, string> description = self.Description;
			if (description == null || ((Dictionary<TKey, TValue>)(object)description).TryGetValue((TKey)"neutral", out *(TValue*)num))
			{
			}
			Dictionary<string, string> description2 = self.Description;
			if (description2 == null || ((Dictionary<TKey, TValue>)(object)description2).TryGetValue((TKey)"NEUTRAL", out *(TValue*)num))
			{
			}
			return "No Message";
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1026EB0", Offset = "0x10258B0", VA = "0x181026EB0")]
		public static string GetTitle(this CatalogItem self)
		{
			//Discarded unreachable code: IL_000f
			if (self.Title != null)
			{
			}
			return "No Title";
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1026190", Offset = "0x1024B90", VA = "0x181026190")]
		public static string GetDescription(this CatalogItem self)
		{
			//Discarded unreachable code: IL_000f
			if (self.Description != null)
			{
			}
			return "No Message";
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1026CA0", Offset = "0x10256A0", VA = "0x181026CA0")]
		public static string GetTitleByAcceptLanguage(this CatalogItem self)
		{
			//Discarded unreachable code: IL_004b
			if ((long)self.Title != 0)
			{
				if (!string.IsNullOrEmpty(PlayFabSysHttp.DefaultAcceptLanguage))
				{
					Dictionary<string, string> title = self.Title;
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
				bool flag2 = default(bool);
				if (self.Title == null || flag2)
				{
				}
				if (self.Title != null)
				{
					bool flag3 = default(bool);
					while (flag3)
					{
					}
				}
				return "No Title";
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1025F90", Offset = "0x1024990", VA = "0x181025F90")]
		public static string GetDescriptionByAcceptLanguage(this CatalogItem self)
		{
			//Discarded unreachable code: IL_004b
			if ((long)self.Description != 0)
			{
				if (!string.IsNullOrEmpty(PlayFabSysHttp.DefaultAcceptLanguage))
				{
					Dictionary<string, string> description = self.Description;
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
				bool flag2 = default(bool);
				if (self.Description == null || flag2)
				{
				}
				if (self.Description != null)
				{
					bool flag3 = default(bool);
					while (flag3)
					{
					}
				}
				return "No Message";
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1026970", Offset = "0x1025370", VA = "0x181026970")]
		public static string GetRecipeFriendlyNameFromRecipeKey(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0016
			return self.GetFriendlyName().Replace("_OnlineKey", "_OnlineRecipe");
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x10269E0", Offset = "0x10253E0", VA = "0x1810269E0")]
		public static string GetRecipeKeyFriendlyNameFromRecipe(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0016
			return self.GetFriendlyName().Replace("_OnlineRecipe", "_OnlineKey");
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1026A50", Offset = "0x1025450", VA = "0x181026A50")]
		public static string GetRecipeKeyIdFromRecipe(this CatalogItem self)
		{
			List<CatalogPrice> prices = self.PriceOptions.Prices;
			if (prices != null)
			{
				CatalogPrice catalogPrice = Enumerable.FirstOrDefault<CatalogPrice>((IEnumerable<>)prices);
				if (catalogPrice != null)
				{
					List<CatalogPriceAmount> amounts = catalogPrice.Amounts;
					if (amounts != null)
					{
						CatalogPriceAmount catalogPriceAmount = Enumerable.FirstOrDefault<CatalogPriceAmount>((IEnumerable<>)amounts);
						if (catalogPriceAmount != null)
						{
							return catalogPriceAmount.ItemId;
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1024D70", Offset = "0x1023770", VA = "0x181024D70")]
		public static string BACKWARDCOMP_GetBaseConfigFriendlyNamePrefix(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0016
			return self.GetFriendlyName().Replace("_BaseConfig", "");
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1024DE0", Offset = "0x10237E0", VA = "0x181024DE0")]
		public static (string, ContentType?) BuildKeyContentFromRecipe(this CatalogItem self)
		{
			//IL_000e: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			int num = 0;
			SearchType searchType = default(SearchType);
			string text = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (!flag && (flag2 || flag3))
			{
				CatalogItem self2 = default(CatalogItem);
				Func<KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0014
					string contentType2 = self2.ContentType;
					string a2 = default(string);
					return string.Equals(a2, contentType2);
				};
				KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData> keyValuePair = default(KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData>);
				if ((object)keyValuePair != null)
				{
					ContentType contentType = default(ContentType);
					int num2 = (int)contentType;
				}
				string text2 = "global";
				bool flag4 = default(bool);
				if (flag4)
				{
					text2 = "recipe";
				}
				int num3 = 0;
				int stringLength = text2.m_stringLength;
				int num4 = default(int);
				stringLength += num4;
				string text3 = default(string);
				string text4 = default(string);
				string type = text3 + "key" + text4;
				PlayFabContentType._003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals1 = new PlayFabContentType._003C_003Ec__DisplayClass23_0();
				CS_0024_003C_003E8__locals1.type = type;
				Func<KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData>, bool> func2 = (Func<KeyValuePair<ContentType, PlayFabContentType.BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_000f
					string type2 = CS_0024_003C_003E8__locals1.type;
					string a = default(string);
					return string.Equals(a, type2);
				};
				string text5 = ((CatalogItem)num).GetFriendlyName().Replace("_OnlineRecipe", "_OnlineKey");
				int num5 = 0;
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1025860", Offset = "0x1024260", VA = "0x181025860")]
		public static CatalogItem CreateCurrency(string name, string contentType)
		{
			//Discarded unreachable code: IL_0020
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			string name2 = name + "_OnlineCurrency";
			return CreateCatalogItem(highLevelType, contentType, name2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1025930", Offset = "0x1024330", VA = "0x181025930")]
		public static CatalogItem CreateItem(string name, string contentType)
		{
			//Discarded unreachable code: IL_0012
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return CreateCatalogItem(highLevelType, contentType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1025B60", Offset = "0x1024560", VA = "0x181025B60")]
		public static CatalogItem CreateUgc(string name, string contentType)
		{
			//Discarded unreachable code: IL_0012
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return CreateCatalogItem(highLevelType, contentType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10253A0", Offset = "0x1023DA0", VA = "0x1810253A0")]
		public static CatalogItem CreateBundle(string name, string contentType)
		{
			//Discarded unreachable code: IL_0012
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return CreateCatalogItem(highLevelType, contentType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10259E0", Offset = "0x10243E0", VA = "0x1810259E0")]
		public static CatalogItem CreateRecipe(string name, string contentType)
		{
			//Discarded unreachable code: IL_0020
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			string name2 = name + "_OnlineRecipe";
			return CreateCatalogItem(highLevelType, contentType, name2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1025AB0", Offset = "0x10244B0", VA = "0x181025AB0")]
		public static CatalogItem CreateStore(string name, string contentType)
		{
			//Discarded unreachable code: IL_0012
			//IL_0006: Expected O, but got I4
			SearchType searchType = default(SearchType);
			string highLevelType = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return CreateCatalogItem(highLevelType, contentType, name);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1025450", Offset = "0x1023E50", VA = "0x181025450")]
		private static CatalogItem CreateCatalogItem(string highLevelType, string contentType, string name)
		{
			//Discarded unreachable code: IL_003e, IL_00e0
			//IL_0050: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			CatalogItem catalogItem = new CatalogItem();
			List<CatalogAlternateId> list = (List<CatalogAlternateId>)(object)new List<T>();
			CatalogAlternateId catalogAlternateId = new CatalogAlternateId();
			catalogAlternateId.Type = "FriendlyId";
			catalogAlternateId.Value = name;
			((List<T>)(object)list).Add((T)catalogAlternateId);
			catalogItem.AlternateIds = list;
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10262F0", Offset = "0x1024CF0", VA = "0x1810262F0")]
		public static string GetDisplayPropertiesString(this CatalogItem self)
		{
			object displayProperties = self.DisplayProperties;
			int num = 0;
			if (displayProperties != null)
			{
			}
			if (displayProperties != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1026210", Offset = "0x1024C10", VA = "0x181026210")]
		public static JObject GetDisplayPropertiesJObject(this CatalogItem self)
		{
			//Discarded unreachable code: IL_001d
			object displayProperties;
			do
			{
				displayProperties = self.DisplayProperties;
				int num = 0;
				if (displayProperties != null)
				{
				}
			}
			while (displayProperties != null);
			return JObject.Parse(displayProperties.ToString());
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1026530", Offset = "0x1024F30", VA = "0x181026530")]
		public static int GetIDFromDisplayProperties(this CatalogItem self)
		{
			//Discarded unreachable code: IL_001f
			if (self.GetDisplayPropertiesJObject().ContainsKey("ID"))
			{
				uint num = num + 20;
				num += num;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1026710", Offset = "0x1025110", VA = "0x181026710")]
		public static string GetMarketplaceEpicIdFromDisplayProperties(this CatalogItem self)
		{
			if (self.GetDisplayPropertiesJObject().ContainsKey("MarketplaceEpicId"))
			{
				uint num = num + 20;
				num += num;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10274B0", Offset = "0x1025EB0", VA = "0x1810274B0")]
		public static void PrepareDisplayPropertiesForDeployment(this CatalogItem catalogItem)
		{
			object displayProperties = catalogItem.DisplayProperties;
			int num = 0;
			if (displayProperties == null)
			{
				return;
			}
			if (displayProperties != null)
			{
				object displayProperties2 = default(object);
				catalogItem.DisplayProperties = displayProperties2;
				return;
			}
			while (displayProperties == null)
			{
			}
			int num2 = 0;
			while (displayProperties == null)
			{
			}
			string text = displayProperties.ToString();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1026B90", Offset = "0x1025590", VA = "0x181026B90")]
		public static Dictionary<string, int> GetStoreFrontGroupItemID(this CatalogItem self)
		{
			int num = 0;
			if (self.GetDisplayPropertiesJObject().ContainsKey("StoreFrontGroup"))
			{
				uint num2 = num2 + 20;
				num2 += num2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1025C10", Offset = "0x1024610", VA = "0x181025C10")]
		public static int DEPRECATED_GetIDFromDisplayProperties(this CatalogItemMetadata self)
		{
			//Discarded unreachable code: IL_0035
			object displayProperties;
			do
			{
				displayProperties = self.DisplayProperties;
				int num = 0;
				if (displayProperties != null)
				{
				}
			}
			while (displayProperties != null);
			if (JObject.Parse(displayProperties.ToString()).ContainsKey("ID"))
			{
				uint num2 = num2 + 20;
				num2 += num2;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x16CAAA0", Offset = "0x16C94A0", VA = "0x1816CAAA0")]
		public static bool TryDeserializeDisplayProperties<T>(this CatalogItem self, out T value) where T : class
		{
			//Discarded unreachable code: IL_0014
			int num = 0;
			string text = self.DisplayProperties.ToString();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1027620", Offset = "0x1026020", VA = "0x181027620")]
		public static bool TryGetVersion(this CatalogItem self, out int version)
		{
			//Discarded unreachable code: IL_000d
			return int.TryParse(self.DisplayVersion, out version);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x10275E0", Offset = "0x1025FE0", VA = "0x1810275E0")]
		public static void SetVersion(this CatalogItem self, int newVersion)
		{
			//Discarded unreachable code: IL_0008
			string displayVersion = default(string);
			self.DisplayVersion = displayVersion;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1026F30", Offset = "0x1025930", VA = "0x181026F30")]
		public static void IncVersion(this CatalogItem self, int value = 1)
		{
			//Discarded unreachable code: IL_0017
			string displayVersion = self.DisplayVersion;
			bool flag = default(bool);
			if (flag)
			{
				ulong num = num + (ulong)value;
				string displayVersion2 = default(string);
				self.DisplayVersion = displayVersion2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1026AE0", Offset = "0x10254E0", VA = "0x181026AE0")]
		public static string GetScreenshotUrl(this CatalogItem self, [Optional] string tag)
		{
			//Discarded unreachable code: IL_0034
			List<Content> contents = self.Contents;
			if (contents != null)
			{
				int num = 0;
				Content content = Enumerable.ElementAtOrDefault<Content>((IEnumerable<>)contents, num);
				if (content != null && content.Url != null)
				{
				}
			}
			return self.GetImageUrlByType("Screenshot", tag, "");
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x1025D70", Offset = "0x1024770", VA = "0x181025D70")]
		public static string GetThumbnailUrl(this CatalogItem self, [Optional] string tag)
		{
			//Discarded unreachable code: IL_0032
			List<Content> contents = self.Contents;
			if (contents != null)
			{
				Content content = Enumerable.ElementAtOrDefault<Content>((IEnumerable<>)contents, 1);
				if (content != null && content.Url != null)
				{
				}
			}
			return self.GetImageUrlByType("Thumbnail", tag, "");
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1025D70", Offset = "0x1024770", VA = "0x181025D70")]
		public static string GetAvatarUrl(this CatalogItem self, [Optional] string tag)
		{
			//Discarded unreachable code: IL_0032
			List<Content> contents = self.Contents;
			if (contents != null)
			{
				Content content = Enumerable.ElementAtOrDefault<Content>((IEnumerable<>)contents, 1);
				if (content != null && content.Url != null)
				{
				}
			}
			return self.GetImageUrlByType("Thumbnail", tag, "");
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10265E0", Offset = "0x1024FE0", VA = "0x1810265E0")]
		public static string GetImageUrlByType(this CatalogItem self, string type, [Optional] string tag, [Optional] string defaultValue)
		{
			//Discarded unreachable code: IL_0047
			if (self != null)
			{
				List<Image> images = self.Images;
				if (images != null)
				{
					Predicate<Image> predicate = (Predicate<Image>)(object)(Predicate<T>)delegate(Image x)
					{
						//Discarded unreachable code: IL_0031
						string b = type;
						string type2 = x.Type;
						bool flag = string.Equals(type2, b);
						if (!flag)
						{
							return flag;
						}
						string text = tag;
						return text == null || string.Equals(type2, text);
					};
					Image image = (Image)((List<T>)(object)images).Find((Predicate<>)(object)predicate);
					if (image != null && image.Url != null)
					{
					}
				}
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1025E30", Offset = "0x1024830", VA = "0x181025E30")]
		public static string GetContentUrlByType(this CatalogItem self, string contentType, [Optional] List<string> withTags, [Optional] string defaultValue)
		{
			//Discarded unreachable code: IL_006a
			List<string> list = withTags;
			if (list != null)
			{
				bool flag = Enumerable.Any<string>((IEnumerable<>)list);
			}
			bool checkTag = false;
			if (self != null)
			{
				List<Content> contents = self.Contents;
				if (contents != null)
				{
					Predicate<Content> predicate = (Predicate<Content>)(object)(Predicate<T>)delegate(Content x)
					{
						Content content2 = x;
						string b = contentType;
						bool flag2 = string.Equals(content2.Type, b);
						if (!flag2)
						{
							return flag2;
						}
						if (!checkTag)
						{
						}
						List<string> list2 = withTags;
						Func<string, bool> func = (Func<string, bool>)(object)(Func<T, TResult>)((string t) => ((List<T>)(object)x.Tags).Contains((T)t));
						bool flag3 = ((IEnumerable<>)list2).All<string>((Func<, >)(object)func);
						throw new NullReferenceException();
					};
					Content content = (Content)((List<T>)(object)contents).Find((Predicate<>)(object)predicate);
					if (content != null && content.Url != null)
					{
					}
				}
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10272E0", Offset = "0x1025CE0", VA = "0x1810272E0")]
		public static bool IsStatusAvailable(this CatalogItem self, DateTime dateTime)
		{
			//Discarded unreachable code: IL_0010, IL_0012
			DateTime dateTime2 = default(DateTime);
			bool flag = dateTime2 < dateTime;
			if (!flag)
			{
				return flag;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1027060", Offset = "0x1025A60", VA = "0x181027060")]
		public static bool IsCatalogItem(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0019
			//IL_000d: Expected O, but got I4
			string type = self.Type;
			SearchType searchType = default(SearchType);
			string b = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return string.Equals(type, b);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1027110", Offset = "0x1025B10", VA = "0x181027110")]
		public static bool IsCurrency(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0019
			//IL_000d: Expected O, but got I4
			string type = self.Type;
			SearchType searchType = default(SearchType);
			string b = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return string.Equals(type, b);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1026FB0", Offset = "0x10259B0", VA = "0x181026FB0")]
		public static bool IsBundle(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0019
			//IL_000d: Expected O, but got I4
			string type = self.Type;
			SearchType searchType = default(SearchType);
			string b = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return string.Equals(type, b);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1027230", Offset = "0x1025C30", VA = "0x181027230")]
		public static bool IsRecipe(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0019
			//IL_000d: Expected O, but got I4
			string type = self.Type;
			SearchType searchType = default(SearchType);
			string b = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return string.Equals(type, b);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10271C0", Offset = "0x1025BC0", VA = "0x1810271C0")]
		public static bool IsMailboxKey(this CatalogItem self)
		{
			//Discarded unreachable code: IL_000c
			return PlayFabContentType.IsMailboxKey(self.ContentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1027400", Offset = "0x1025E00", VA = "0x181027400")]
		public static bool IsStore(this CatalogItem self)
		{
			//Discarded unreachable code: IL_0019
			//IL_000d: Expected O, but got I4
			string type = self.Type;
			SearchType searchType = default(SearchType);
			string b = ((Enum)searchType).ToString();
			SearchType searchType2 = searchType;
			return string.Equals(type, b);
		}
	}
}
