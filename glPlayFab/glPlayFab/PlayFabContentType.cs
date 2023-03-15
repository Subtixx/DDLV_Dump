using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public static class PlayFabContentType
	{
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public interface IContentType
		{
			[Cpp2IlInjected.Token(Token = "0x17000103")]
			string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000402")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		public interface IMailboxContent
		{
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		public interface IUGCContent
		{
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		public abstract class BaseContentTypeData : IContentType
		{
			[Cpp2IlInjected.Token(Token = "0x17000104")]
			public string TypeName
			{
				[Cpp2IlInjected.Token(Token = "0x6000403")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CTypeName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CTypeName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000105")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000313")]
			public ContentType? OverrideContentTypeLink
			{
				[Cpp2IlInjected.Token(Token = "0x6000405")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000314")]
			public bool IsStackable
			{
				[Cpp2IlInjected.Token(Token = "0x6000407")]
				[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000107")]
			public List<string> OriginReferences
			{
				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003COriginReferences_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003COriginReferences_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000108")]
			public abstract string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000109")]
			public string FullName
			{
				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0x14EF6E0", Offset = "0x14EE0E0", VA = "0x1814EF6E0")]
				get
				{
					string rootName = RootName;
					string text = TypeName;
					return rootName + "/" + text;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000316")]
			public bool CreateStatistic
			{
				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected BaseContentTypeData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		public class CurrencyContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public const string CurrencyRoot = "currency";

			[Cpp2IlInjected.Token(Token = "0x1700010B")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000410")]
				[Cpp2IlInjected.Address(RVA = "0x14EF770", Offset = "0x14EE170", VA = "0x1814EF770", Slot = "5")]
				get
				{
					return "currency";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public CurrencyContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public class ItemContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public const string ItemRoot = "item";

			[Cpp2IlInjected.Token(Token = "0x1700010C")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000412")]
				[Cpp2IlInjected.Address(RVA = "0x14EF7D0", Offset = "0x14EE1D0", VA = "0x1814EF7D0", Slot = "5")]
				get
				{
					return "item";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ItemContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		public class BattlePassContentType : ItemContentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public BattlePassContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		public class KeyContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public const string KeyRoot = "key";

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000415")]
				[Cpp2IlInjected.Address(RVA = "0x14EF800", Offset = "0x14EE200", VA = "0x1814EF800", Slot = "5")]
				get
				{
					return "key";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public KeyContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public class SaveBackupContentType : BaseContentTypeData, IUGCContent
		{
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public const string KeyRoot = "savebackup";

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x14F5320", Offset = "0x14F3D20", VA = "0x1814F5320", Slot = "5")]
				get
				{
					return "savebackup";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SaveBackupContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		public class MailboxKeyContentType : KeyContentType, IMailboxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MailboxKeyContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public class BundleContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public const string BundleRoot = "bundle";

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0x14EF740", Offset = "0x14EE140", VA = "0x1814EF740", Slot = "5")]
				get
				{
					return "bundle";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public BundleContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		public class RecipeContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public const string RecipeRoot = "recipe";

			[Cpp2IlInjected.Token(Token = "0x17000110")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x14F4A70", Offset = "0x14F3470", VA = "0x1814F4A70", Slot = "5")]
				get
				{
					return "recipe";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RecipeContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public class StoreContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public const string StoreRoot = "store";

			[Cpp2IlInjected.Token(Token = "0x17000111")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0x14F6A90", Offset = "0x14F5490", VA = "0x1814F6A90", Slot = "5")]
				get
				{
					return "store";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public StoreContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public class GlobalContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public const string GlobalRoot = "global";

			[Cpp2IlInjected.Token(Token = "0x17000112")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x14EF7A0", Offset = "0x14EE1A0", VA = "0x1814EF7A0", Slot = "5")]
				get
				{
					return "global";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GlobalContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public abstract class MailboxContentType : GlobalContentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected MailboxContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public class MailboxMessageContentType : GlobalContentType, IMailboxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MailboxMessageContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public class RedeemContentType : BaseContentTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public const string RedeemRoot = "redeem";

			[Cpp2IlInjected.Token(Token = "0x17000113")]
			public override string RootName
			{
				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x14F4F60", Offset = "0x14F3960", VA = "0x1814F4F60", Slot = "5")]
				get
				{
					return "redeem";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RedeemContentType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static Dictionary<ContentType, BaseContentTypeData> contentTypes;

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public static Dictionary<ContentType, BaseContentTypeData> ContentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x1039620", Offset = "0x1038020", VA = "0x181039620")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1038B20", Offset = "0x1037520", VA = "0x181038B20")]
		public static string ToFilter(this ContentType contentType)
		{
			//Discarded unreachable code: IL_001a
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			string fullName = baseContentTypeData.FullName;
			return "contentType eq '" + fullName + "'";
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1037CD0", Offset = "0x10366D0", VA = "0x181037CD0")]
		public static string GetName(ContentType type)
		{
			//Discarded unreachable code: IL_0009
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			return baseContentTypeData.FullName;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x10389B0", Offset = "0x10373B0", VA = "0x1810389B0")]
		public static bool IsStackable(ContentType type)
		{
			//Discarded unreachable code: IL_0009
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			return baseContentTypeData.IsStackable;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1038040", Offset = "0x1036A40", VA = "0x181038040")]
		public static ContentType? GetType(string type)
		{
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000f
				string b = type;
				string a = default(string);
				return string.Equals(a, b);
			};
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1037EC0", Offset = "0x10368C0", VA = "0x181037EC0")]
		public static ContentType? GetTypeByOrigin(string origin)
		{
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000b
				int num2 = 0;
				string text = origin;
				bool result = default(bool);
				return result;
			};
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1037A60", Offset = "0x1036460", VA = "0x181037A60")]
		public static List<string> GetMailboxContentTypes()
		{
			if (_003C_003Ec._003C_003E9__25_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<ContentType, BaseContentTypeData> x) => (object)typeof(IMailboxContent).TypeHandle != null);
			}
			Func<KeyValuePair<ContentType, BaseContentTypeData>, string> func = default(Func<KeyValuePair<ContentType, BaseContentTypeData>, string>);
			if (_003C_003Ec._003C_003E9__25_1 == null)
			{
				string result = default(string);
				func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<ContentType, BaseContentTypeData> x) => result));
			}
			IEnumerable<KeyValuePair<ContentType, BaseContentTypeData>> enumerable = default(IEnumerable<KeyValuePair<ContentType, BaseContentTypeData>>);
			return (List<string>)(object)Enumerable.ToList<string>(Enumerable.Select<KeyValuePair<ContentType, BaseContentTypeData>, string>((IEnumerable<>)enumerable, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1038470", Offset = "0x1036E70", VA = "0x181038470")]
		public static bool IsMailboxKey(string contentType)
		{
			//Discarded unreachable code: IL_0022, IL_0027
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000f
				string b = contentType;
				string a = default(string);
				return string.Equals(a, b);
			};
			return 0 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1038370", Offset = "0x1036D70", VA = "0x181038370")]
		public static bool IsMailboxKey(ContentType contentType)
		{
			//Discarded unreachable code: IL_0018
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			if (baseContentTypeData == null)
			{
				return 0 != 0;
			}
			int num = 0;
			return baseContentTypeData != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1038620", Offset = "0x1037020", VA = "0x181038620")]
		private static bool IsMailboxKey(BaseContentTypeData contentTypeData)
		{
			if (contentTypeData == null)
			{
				return 0 != 0;
			}
			int num = 0;
			return contentTypeData != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1038A40", Offset = "0x1037440", VA = "0x181038A40")]
		public static bool NeedStatistic(ContentType type)
		{
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			if (baseContentTypeData != null)
			{
				int num = 0;
				if (baseContentTypeData != null)
				{
					return baseContentTypeData.CreateStatistic;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x10386A0", Offset = "0x10370A0", VA = "0x1810386A0")]
		public static bool IsOriginMailboxKey(string origin)
		{
			//Discarded unreachable code: IL_002f, IL_0035
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000b
				int num2 = 0;
				string text = origin;
				bool result2 = default(bool);
				return result2;
			};
			if (0 == 0)
			{
			}
			ContentType contentType = default(ContentType);
			int num = (int)contentType;
			BaseContentTypeData baseContentTypeData = default(BaseContentTypeData);
			if (baseContentTypeData != null)
			{
				return baseContentTypeData != null;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x10381C0", Offset = "0x1036BC0", VA = "0x1810381C0")]
		public static bool HasOrigin(string contentType, string origin)
		{
			//Discarded unreachable code: IL_0029
			string contentType2 = contentType;
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				string b = contentType2;
				string text = default(string);
				if (string.Equals(text, b) && text != null)
				{
					string text2 = origin;
					bool result = default(bool);
					return result;
				}
				int num = 0;
				throw new NullReferenceException();
			};
			return ((IEnumerable<>)(object)contentType).Any<KeyValuePair<ContentType, BaseContentTypeData>>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1037D60", Offset = "0x1036760", VA = "0x181037D60")]
		public static string GetOrigin(string contentType)
		{
			//Discarded unreachable code: IL_001c
			Func<KeyValuePair<ContentType, BaseContentTypeData>, bool> func = (Func<KeyValuePair<ContentType, BaseContentTypeData>, bool>)(object)(Func<T, TResult>)delegate
			{
				string b = contentType;
				string a = default(string);
				bool flag = string.Equals(a, b);
				bool result2 = default(bool);
				if (flag && flag)
				{
					return result2;
				}
				int num = 0;
				throw new NullReferenceException();
			};
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10382F0", Offset = "0x1036CF0", VA = "0x1810382F0")]
		private static bool IsBattlePass(BaseContentTypeData contentTypeData)
		{
			if (contentTypeData == null)
			{
				return 0 != 0;
			}
			int num = 0;
			return contentTypeData != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1038C30", Offset = "0x1037630", VA = "0x181038C30")]
		static PlayFabContentType()
		{
			//Discarded unreachable code: IL_001b, IL_0030, IL_0045, IL_005a, IL_006f, IL_009e, IL_00b3, IL_00d5, IL_00f6, IL_010b, IL_012d, IL_0142, IL_0157, IL_016c, IL_0181, IL_0196, IL_01ab, IL_01cc, IL_01e1, IL_01f6, IL_020b, IL_0220, IL_0235, IL_024a, IL_024b
			//IL_00cf: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			Dictionary<ContentType, BaseContentTypeData> dictionary = (Dictionary<ContentType, BaseContentTypeData>)(object)new Dictionary<TKey, TValue>();
			((BaseContentTypeData)new ItemContentType()).TypeName = "dummy";
			throw new NullReferenceException();
		}
	}
}
