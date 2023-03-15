using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using glPlayFab;
using Localization.Formatter.Resolvers;
using Mdl.Log;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Meta.Util;
using Serilog;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	public class LocalizationManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20001F6")]
		public class CreditsResolver : IResolver
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xF65200", Offset = "0xF63C00", VA = "0x180F65200", Slot = "4")]
			public object Resolve(string key)
			{
				//IL_005d: Expected O, but got I4
				char[] array = new char[1];
				uint num = default(uint);
				array[0] = (char)num;
				string[] array2 = key.Split(array);
				List<(string, string)> list = (List<(string, string)>)(object)new List<T>();
				uint num2 = default(uint);
				if (array2.Length > (int)num2)
				{
					int length = array2.Length;
					num2++;
					if ((int)num2 < length)
					{
						uint num3 = num2 + 1;
						string text = array2[num3];
						int num4 = 0;
						string text2 = array2[num2];
						((List<T>)(object)list).Add((T)num4);
						num2 += 2;
					}
				}
				string stringID = array2[0];
				(string, string)[] pairs = ((string, string)[])(object)((List<T>)(object)list).ToArray();
				string text3 = FromStringID(stringID, pairs);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public CreditsResolver()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F7")]
		private class ProfileResolver : IResolver
		{
			[Cpp2IlInjected.Token(Token = "0x1700012C")]
			private Profile Profile
			{
				[Cpp2IlInjected.Token(Token = "0x600086E")]
				[Cpp2IlInjected.Address(RVA = "0xF66240", Offset = "0xF64C40", VA = "0x180F66240")]
				get
				{
					//Discarded unreachable code: IL_0010
					return SystemRoot.Instance.MetaClient.profile;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0xF66050", Offset = "0xF64A50", VA = "0x180F66050", Slot = "4")]
			public object Resolve(string key)
			{
				//IL_0045: Expected O, but got I4
				//IL_0045: Expected O, but got I4
				//IL_006d: Expected O, but got I4
				string text = key.ToLower();
				if (!string.Equals(text, "playername"))
				{
					if (!string.Equals(text, "placeholder"))
					{
						if (text.StartsWith("str:"))
						{
							string stringID = key.Substring(4);
							int num = 0;
							int num2 = 0;
							string text2 = FromStringID(stringID, (IResolver)num2, (string)num);
						}
						int num3 = 0;
					}
					return "";
				}
				Profile profile = Profile;
				if (profile == null || profile.player_ != null)
				{
				}
				if (string.IsNullOrEmpty((string)0))
				{
					return "Player Name";
				}
				Profile profile2 = default(Profile);
				string name_ = profile2.player_.name_;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ProfileResolver()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001114")]
		public const string LocPath = "Localization/";

		[Cpp2IlInjected.Token(Token = "0x4001115")]
		public const string PlayerPrefUseBinaryInEditor = "UseBinaryLocSettings";

		[Cpp2IlInjected.Token(Token = "0x400111B")]
		private static Dictionary<SystemLanguage, string> lang2culture;

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		private static Localizator LocalizatorInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0xBB7F00", Offset = "0xBB6900", VA = "0x180BB7F00")]
			get
			{
				int num = 0;
				if (Application.isPlaying)
				{
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					if ((object)_003CInstance_003Ek__BackingField != null)
					{
						return _003CInstance_003Ek__BackingField._localizationManager.Localizator;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public static string FullLocPath
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0xBB7D10", Offset = "0xBB6710", VA = "0x180BB7D10")]
			get
			{
				//Discarded unreachable code: IL_0008
				Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001116")]
		private bool UseBinaryLoc
		{
			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Localizator Localizator
		{
			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CLocalizator_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalizator_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public string Culture
		{
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xBB7CF0", Offset = "0xBB66F0", VA = "0x180BB7CF0")]
			get
			{
				CultureInfo cultureInfo = CultureInfo;
				if (cultureInfo != null)
				{
					object obj = ((ICloneable)cultureInfo).Clone();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public CultureInfo CultureInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCultureInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CCultureInfo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public string ISOCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CISOCode_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CISOCode_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public static bool IsMetric
		{
			[Cpp2IlInjected.Token(Token = "0x6000855")]
			[Cpp2IlInjected.Address(RVA = "0xBB7DD0", Offset = "0xBB67D0", VA = "0x180BB7DD0")]
			get
			{
				//IL_0038: Expected O, but got I4
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					LocalizationManager localizationManager = _003CInstance_003Ek__BackingField._localizationManager;
					if ((object)localizationManager != null)
					{
						CultureInfo cultureInfo = localizationManager.CultureInfo;
						if (cultureInfo != null)
						{
							string text = cultureInfo.Name;
						}
					}
				}
				int num = 0;
				if (num == 0)
				{
					return true;
				}
				RegionInfo regionInfo = new RegionInfo((string)num);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		private Serilog.ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xBB7FD0", Offset = "0xBB69D0", VA = "0x180BB7FD0")]
			get
			{
				return Serilogger.Create<LocalizationManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public static IEnumerable<CultureInfo> SupportedCultures
		{
			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8030", Offset = "0xBB6A30", VA = "0x180BB8030")]
			get
			{
				//Discarded unreachable code: IL_0037
				IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Distinct<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)lang2culture).get_Values());
				Func<string, CultureInfo> _003C_003E9__41_ = _003C_003Ec._003C_003E9__41_0;
				if (_003C_003E9__41_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => CultureInfo.GetCultureInfo(x));
				}
				return (IEnumerable<CultureInfo>)Enumerable.Select<string, CultureInfo>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__41_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EventHandler OnLanguageChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xBB7C50", Offset = "0xBB6650", VA = "0x180BB7C50")]
			[CompilerGenerated]
			add
			{
				EventHandler onLanguageChanged = this.OnLanguageChanged;
				Delegate @delegate = Delegate.Combine(onLanguageChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLanguageChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xBB81E0", Offset = "0xBB6BE0", VA = "0x180BB81E0")]
			[CompilerGenerated]
			remove
			{
				EventHandler onLanguageChanged = this.OnLanguageChanged;
				Delegate @delegate = Delegate.Remove(onLanguageChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLanguageChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xBB6000", Offset = "0xBB4A00", VA = "0x180BB6000")]
		public static string FromStringID(string stringID, params (string key, string text)[] pairs)
		{
			//IL_0011: Expected O, but got I4
			IResolver resolver = NewResolver(pairs);
			int num = 0;
			return FromStringID(stringID, resolver, (string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xBB6070", Offset = "0xBB4A70", VA = "0x180BB6070")]
		public static string FromStringID(string stringID, [System.Runtime.InteropServices.Optional] IResolver resolver, [System.Runtime.InteropServices.Optional] string fallbackStrId)
		{
			//Discarded unreachable code: IL_0031
			int num = 0;
			if (LocalizatorInstance != null)
			{
				int num2 = 0;
				Localizator localizatorInstance = LocalizatorInstance;
				bool flag = default(bool);
				if (!flag && !flag)
				{
					int num3 = 0;
					Localizator localizatorInstance2 = LocalizatorInstance;
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xBB5F90", Offset = "0xBB4990", VA = "0x180BB5F90")]
		public static string FormatText(string text, params (string key, string text)[] pairs)
		{
			IResolver resolver = NewResolver(pairs);
			return FormatText(text, resolver);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xBB5E20", Offset = "0xBB4820", VA = "0x180BB5E20")]
		public static string FormatText(string text, [System.Runtime.InteropServices.Optional] IResolver resolver)
		{
			//IL_001d: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField._localizationManager != null)
			{
			}
			int num = 0;
			return Resource.Format(text, resolver, (CultureInfo)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xBB6400", Offset = "0xBB4E00", VA = "0x180BB6400")]
		public static IResolver NewResolver(params (string key, string text)[] pairs)
		{
			Func<(string, string), string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
			if (_003C_003E9__6_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Func<(string, string), object> func = default(Func<(string, string), object>);
			if (_003C_003Ec._003C_003E9__6_1 == null)
			{
				func = (Func<(string, string), object>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			DictionaryResolver dictionaryResolver = new DictionaryResolver((IReadOnlyDictionary<, >)Enumerable.ToDictionary<(string, string), string, object>((IEnumerable<>)(object)pairs, (Func<, >)(object)_003C_003E9__6_, (Func<, >)(object)func));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xBB6390", Offset = "0xBB4D90", VA = "0x180BB6390")]
		public static bool IsSupportedCulture(CultureInfo culture)
		{
			if (culture != null)
			{
				string text = culture.Name;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xBB62D0", Offset = "0xBB4CD0", VA = "0x180BB62D0")]
		public static bool IsSupportedCulture(string language)
		{
			//Discarded unreachable code: IL_001c
			if (string.IsNullOrEmpty(language))
			{
				int num = 0;
			}
			return Enumerable.Contains<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)lang2culture).get_Values(), language);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xBB75B0", Offset = "0xBB5FB0", VA = "0x180BB75B0")]
		public static string ToCulture(SystemLanguage lang)
		{
			Dictionary<SystemLanguage, string> dictionary = lang2culture;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xBB7660", Offset = "0xBB6060", VA = "0x180BB7660")]
		private string ToISOCode(string culture)
		{
			//Discarded unreachable code: IL_0040
			int num = 0;
			List<LocalizationUtil.LocaleInfo> locales = (List<LocalizationUtil.LocaleInfo>)(object)LocalizationUtil.get_Locales();
			Func<LocalizationUtil.LocaleInfo, bool> func = (Func<LocalizationUtil.LocaleInfo, bool>)(object)(Func<T, TResult>)delegate(LocalizationUtil.LocaleInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = culture;
				return string.Equals(x.Culture, b);
			};
			LocalizationUtil.LocaleInfo localeInfo = Enumerable.FirstOrDefault<LocalizationUtil.LocaleInfo>((IEnumerable<>)locales, (Func<, >)(object)func);
			if (localeInfo == null || localeInfo.ISOCode == null)
			{
			}
			return "en-US";
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xBB5C20", Offset = "0xBB4620", VA = "0x180BB5C20")]
		public static FluxReviewedTableProvider CreateReviewedTableProvider(CultureInfo culture, [System.Runtime.InteropServices.Optional] Gameloft.Localization.Core.IFileSystem fileSystem)
		{
			//Discarded unreachable code: IL_0068
			//IL_0043: Expected O, but got I4
			bool flag = string.Equals(culture.Name, "en-US");
			bool bypassTimestampCheck = !flag;
			int num = 0;
			if (!DebugSettings.Settings.showLocalizationRef_ || !flag)
			{
			}
			int num2 = 0;
			int num3 = 0;
			FluxTableProvider provider = new FluxTableProvider(FullLocPath, fileSystem);
			TableOptions options = new TableOptions((string)num2, bypassTimestampCheck, ignoreEmptyRev: true);
			FluxReviewedTableProvider fluxReviewedTableProvider = new FluxReviewedTableProvider(provider, options);
			CultureInfo cultureInfo = (fluxReviewedTableProvider.ReferenceCulture = CultureInfo.GetCultureInfo("en-US"));
			return fluxReviewedTableProvider;
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xBB59C0", Offset = "0xBB43C0", VA = "0x180BB59C0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0069
			int num = 0;
			bool flag = (UseBinaryLoc = Application.platform != RuntimePlatform.Android);
			int num2 = 0;
			if (string.IsNullOrEmpty(DebugSettings.Settings.language_))
			{
				int num3 = 0;
				GlobalStorageData data = (GlobalStorageData)((BaseStorage<DataType>)(object)GlobalStorage.Instance).Data;
			}
			int num4 = 0;
			if (!IsSupportedCulture(DebugSettings.Settings.language_))
			{
				int num5 = 0;
				SystemLanguage systemLanguage = Application.systemLanguage;
				Dictionary<SystemLanguage, string> dictionary = lang2culture;
				int num6 = 0;
				GlobalStorage instance = GlobalStorage.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xBB75A0", Offset = "0xBB5FA0", VA = "0x180BB75A0")]
		private void Start()
		{
			SetupResolver();
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xBB69F0", Offset = "0xBB53F0", VA = "0x180BB69F0")]
		public void RefreshLanguage()
		{
			//IL_001c: Expected O, but got I4
			CultureInfo cultureInfo = CultureInfo;
			if (cultureInfo != null)
			{
				string text = cultureInfo.Name;
			}
			int num = 0;
			if (SetupLanguage((string)num, force: true))
			{
				SetupResolver();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xBB5BF0", Offset = "0xBB45F0", VA = "0x180BB5BF0")]
		public void ChangeLanguage(string culture)
		{
			int force = 0;
			if (SetupLanguage(culture, (byte)force != 0))
			{
				SetupResolver();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xBB6A40", Offset = "0xBB5440", VA = "0x180BB6A40")]
		private bool SetupLanguage(string culture, bool force = false)
		{
			//IL_0045: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_0145: Expected O, but got I4
			//IL_0145: Expected O, but got I4
			//IL_01bc: Expected I4, but got O
			object[] array;
			string fullLocPath;
			while (true)
			{
				bool flag = IsSupportedCulture(culture);
				array = new object[4];
				if (culture != null && array == null)
				{
					continue;
				}
				array[0] = culture;
				if (culture != null && array == null)
				{
					continue;
				}
				array[1] = culture;
				bool flag2 = UseBinaryLoc;
				if (!flag2 || flag2)
				{
					array[2] = flag2;
					int num = 0;
					fullLocPath = FullLocPath;
					if (fullLocPath == null || fullLocPath != null)
					{
						break;
					}
				}
			}
			array[3] = fullLocPath;
			string text = string.Format("LocalizationManager: AskedCulture={0}, UsedCulture={1}, Binary={2}, Path={3}", array);
			if (!force)
			{
				CultureInfo cultureInfo = CultureInfo;
				if (cultureInfo != null)
				{
					string text2 = cultureInfo.Name;
				}
				if (0 == 0)
				{
				}
			}
			CultureInfo cultureInfo2 = (CultureInfo = CultureInfo.GetCultureInfo(culture));
			if (!UseBinaryLoc)
			{
				CultureInfo culture3 = CultureInfo;
				int num2 = 0;
				FluxReviewedTableProvider fluxReviewedTableProvider = CreateReviewedTableProvider(culture3, (Gameloft.Localization.Core.IFileSystem)num2);
			}
			int num3 = 0;
			RuntimePlatform platform = Application.platform;
			int num4 = 0;
			string arg = Path.Combine(Directory.GetCurrentDirectory(), "Library", "MDLCompiledData");
			bool flag3 = default(bool);
			string text3 = $"LocalizationManager: UsingArchive={flag3}, BinaryFolder={arg}";
			CultureInfo cultureInfo3 = CultureInfo;
			int num5 = 0;
			RuntimePlatform platform2 = Application.platform;
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			string text4 = cultureInfo3.Name;
			string text5 = "Localization//LocDB_" + text4 + ".zip";
			int num6 = 0;
			string path = default(string);
			SharpZipFileSystem _003CFileSystem_003Ek__BackingField = SharpZipFileSystem.FromArchive(path, "", (Gameloft.FileSystem.ILogger)num6);
			int num7 = 0;
			LocalizationProtoBufTableProvider localizationProtoBufTableProvider = default(LocalizationProtoBufTableProvider);
			localizationProtoBufTableProvider.Gameloft_002ELocalization_002ECore_002EITableProvider_002ERemoveJsonValue((LocId)num7, (CultureInfo)num6);
			localizationProtoBufTableProvider.FileSystem = _003CFileSystem_003Ek__BackingField;
			localizationProtoBufTableProvider.IsArchive = true;
			string text6 = CultureInfo.Name;
			string culture2 = text6;
			int num8 = 0;
			List<LocalizationUtil.LocaleInfo> locales = (List<LocalizationUtil.LocaleInfo>)(object)LocalizationUtil.get_Locales();
			Func<LocalizationUtil.LocaleInfo, bool> func = (Func<LocalizationUtil.LocaleInfo, bool>)(object)(Func<T, TResult>)delegate(LocalizationUtil.LocaleInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = culture2;
				return string.Equals(x.Culture, b);
			};
			LocalizationUtil.LocaleInfo localeInfo = Enumerable.FirstOrDefault<LocalizationUtil.LocaleInfo>((IEnumerable<>)locales, (Func<, >)(object)func);
			if (localeInfo == null || localeInfo.ISOCode == null)
			{
			}
			ISOCode = "en-US";
			PlayFabSysHttp.TimeSinceLoginThreshold = (int)ISOCode;
			string text7 = CultureInfo.Name;
			Func<LocId, LocId> func2 = (Func<LocId, LocId>)(object)new Func<T, TResult>(RedirectionLocId);
			Localizator localizator = default(Localizator);
			Localizator = localizator;
			LocalizationUtil.localesMapping = (Dictionary<Definitions.Locale, LocalizationUtil.LocaleInfo>)(object)Localizator;
			if (this.OnLanguageChanged != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xBB6250", Offset = "0xBB4C50", VA = "0x180BB6250")]
		public void InvokeLanguageChanged()
		{
			if (this.OnLanguageChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xBB7360", Offset = "0xBB5D60", VA = "0x180BB7360")]
		private void SetupResolver()
		{
			//Discarded unreachable code: IL_0073
			if ((long)Localizator != 0)
			{
				List<IResolver> list = (List<IResolver>)(object)new List<T>();
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField.Version;
				int build = _003CInstance_003Ek__BackingField.Version.version.build;
				string buildType = _003CInstance_003Ek__BackingField.Version.buildType;
				string version = default(string);
				AppResolver item = new AppResolver(version);
				((List<T>)(object)list).Add((T)item);
				ProfileResolver item2 = new ProfileResolver();
				((List<T>)(object)list).Add((T)item2);
				MultiResolver resolver = new MultiResolver((IReadOnlyCollection<>)list);
				Localizator.AddGeneralResolver(resolver);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xBB6630", Offset = "0xBB5030", VA = "0x180BB6630")]
		private LocId RedirectionLocId(LocId locId)
		{
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null)
				{
					Meta.Online.Client _003CMetaClient_003Ek__BackingField = client.MetaClient;
					if (_003CMetaClient_003Ek__BackingField != null)
					{
						Profile profile = _003CMetaClient_003Ek__BackingField.profile;
						if (profile != null)
						{
							bool avatarIsMale_ = profile.player_.avatarIsMale_;
						}
					}
				}
				if (num != 1)
				{
					bool flag = default(bool);
					if (!flag)
					{
						int num2 = 0;
					}
					(new char[1])[0] = 'f';
					string text = default(string);
					string text2 = text + "m";
					bool flag2 = default(bool);
					if (1L != 0L && flag2 && flag2)
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xBB77A0", Offset = "0xBB61A0", VA = "0x180BB77A0")]
		public static bool TryGetBinaryRenameInfo(string tableName, out string folderName, out string prefix)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0xBB77E0", Offset = "0xBB61E0", VA = "0x180BB77E0")]
		public static bool TryGetMaleLocId(LocId locId, out LocId maleLocId)
		{
			//Discarded unreachable code: IL_004c
			//IL_004a: Expected O, but got I4
			string _003CStringName_003Ek__BackingField = locId.StringName;
			if (!_003CStringName_003Ek__BackingField.EndsWith("_f"))
			{
			}
			char[] array = new char[1];
			array[0] = 'f';
			string text = _003CStringName_003Ek__BackingField.TrimEnd(array) + "m";
			if (1L == 0L)
			{
				int num = 0;
				int num2 = 0;
				maleLocId.TableName = (string)num;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xBB7960", Offset = "0xBB6360", VA = "0x180BB7960")]
		public static bool TryGetMaleStringId(string strId, out string maleStrId)
		{
			//Discarded unreachable code: IL_0035
			if (!strId.EndsWith("_f"))
			{
				int num = 0;
			}
			char[] array = new char[1];
			array[0] = 'f';
			string text = strId.TrimEnd(array) + "m";
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LocalizationManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xBB7A60", Offset = "0xBB6460", VA = "0x180BB7A60")]
		static LocalizationManager()
		{
			//Discarded unreachable code: IL_0013, IL_0020, IL_002d, IL_003b, IL_0049, IL_0057, IL_0065, IL_0073, IL_0081
			Dictionary<SystemLanguage, string> dictionary = (Dictionary<SystemLanguage, string>)(object)new Dictionary<TKey, TValue>();
			string culture = LocalizationUtil.GetCulture(Definitions.Locale.EnglishUs);
			throw new NullReferenceException();
		}
	}
}
