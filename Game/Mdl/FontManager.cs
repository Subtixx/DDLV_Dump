using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	public sealed class FontManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010FE")]
		[SerializeField]
		private LocalizationManager localizationManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010FF")]
		[SerializeField]
		private FontConfig _fontConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001100")]
		[SerializeField]
		private AssetReferenceT<FontConfigAdditionalFallbacks> _fontConfigAdditionalFallbacks;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[field: Cpp2IlInjected.Token(Token = "0x4001101")]
		public static bool FontsUnloaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x1464030", Offset = "0x1462A30", VA = "0x181464030")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x1464090", Offset = "0x1462A90", VA = "0x181464090")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x14638E0", Offset = "0x14622E0", VA = "0x1814638E0")]
		private void Start()
		{
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x1463690", Offset = "0x1462090", VA = "0x181463690")]
		[AsyncStateMachine(typeof(_003CLoadAdditionalFallbackFonts_003Ed__8))]
		private Task LoadAdditionalFallbackFonts()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x1463830", Offset = "0x1462230", VA = "0x181463830")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0022
			FixFontFallbacks();
			LocalizationManager localizationManager = this.localizationManager;
			EventHandler value = OnLanguageChanged;
			localizationManager.OnLanguageChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x14637A0", Offset = "0x14621A0", VA = "0x1814637A0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_001c
			LocalizationManager localizationManager = this.localizationManager;
			EventHandler value = OnLanguageChanged;
			localizationManager.OnLanguageChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x14638D0", Offset = "0x14622D0", VA = "0x1814638D0")]
		private void OnLanguageChanged(object sender, EventArgs args)
		{
			FixFontFallbacks();
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1463210", Offset = "0x1461C10", VA = "0x181463210")]
		public void FixFontFallbacks()
		{
			//Discarded unreachable code: IL_0119
			//IL_0026: Expected O, but got I4
			CultureInfo _003CCultureInfo_003Ek__BackingField = localizationManager.CultureInfo;
			if (_003CCultureInfo_003Ek__BackingField != null)
			{
				string twoLetterISOLanguageName = _003CCultureInfo_003Ek__BackingField.TwoLetterISOLanguageName;
			}
			int num = 0;
			string languageIso = (string)num;
			if ((long)languageIso == 0)
			{
				return;
			}
			FontConfig fontConfig = _fontConfig;
			TMP_FontAsset mainFontFallback = fontConfig.mainFontFallback;
			List<CultureFontFallbackGroup> cultureFontFallbackGroups = fontConfig.cultureFontFallbackGroups;
			Func<CultureFontFallbackGroup, bool> func = (Func<CultureFontFallbackGroup, bool>)(object)(Func<T, TResult>)delegate(CultureFontFallbackGroup x)
			{
				//Discarded unreachable code: IL_0014
				string b = languageIso;
				return string.Equals(x.languageIso, b);
			};
			IEnumerable<CultureFontFallbackGroup> enumerable = (IEnumerable<CultureFontFallbackGroup>)Enumerable.Where<CultureFontFallbackGroup>((IEnumerable<>)cultureFontFallbackGroups, (Func<, >)(object)func);
			Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>> func2 = default(Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>>);
			if (_003C_003Ec._003C_003E9__12_1 == null)
			{
				func2 = (Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CultureFontFallbackGroup f)
				{
					List<TMP_FontAsset> fontReferences = f.fontReferences;
					throw new NullReferenceException();
				});
			}
			List<TMP_FontAsset> fallbackFonts = (List<TMP_FontAsset>)(object)Enumerable.ToList<TMP_FontAsset>(Enumerable.SelectMany<CultureFontFallbackGroup, TMP_FontAsset>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			List<TMP_FontAsset> list = fallbackFonts;
			Converter<TMP_FontAsset, string> converter = default(Converter<TMP_FontAsset, string>);
			if (_003C_003Ec._003C_003E9__12_2 == null)
			{
				converter = (Converter<TMP_FontAsset, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Converter<TInput, TOutput>)((TMP_FontAsset f) => f.name));
			}
			string[] value = (string[])(object)((List<T>)(object)((List<T>)(object)list).ConvertAll<string>((Converter<, >)(object)converter)).ToArray();
			string text = string.Join(", ", value);
			Debug.Log("[UI] FontManager#FixFontFallbacks " + text);
			List<TMP_FontAsset> fallbackFontAssetTable = mainFontFallback.m_FallbackFontAssetTable;
			Comparison<TMP_FontAsset> comparison = (Comparison<TMP_FontAsset>)(object)(Comparison<T>)delegate(TMP_FontAsset f, TMP_FontAsset g)
			{
				//Discarded unreachable code: IL_0027
				bool flag = ((List<T>)(object)fallbackFonts).Contains((T)f);
				int num2 = 0;
				bool flag2 = !flag;
				bool flag3 = !((List<T>)(object)fallbackFonts).Contains((T)g);
				int result = default(int);
				return result;
			};
			((List<T>)(object)fallbackFontAssetTable).Sort((Comparison<>)(object)comparison);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x1463A30", Offset = "0x1462430", VA = "0x181463A30")]
		public void UnloadUnnecessaryFonts()
		{
			//Discarded unreachable code: IL_0134, IL_013a
			//IL_0026: Expected O, but got I4
			int num = 0;
			CultureInfo _003CCultureInfo_003Ek__BackingField = localizationManager.CultureInfo;
			if (_003CCultureInfo_003Ek__BackingField != null)
			{
				string twoLetterISOLanguageName = _003CCultureInfo_003Ek__BackingField.TwoLetterISOLanguageName;
			}
			string languageIso = (string)num;
			if ((IntPtr)languageIso == (IntPtr)num)
			{
				return;
			}
			FontConfig fontConfig = _fontConfig;
			TMP_FontAsset mainFontFallback = fontConfig.mainFontFallback;
			List<CultureFontFallbackGroup> cultureFontFallbackGroups = fontConfig.cultureFontFallbackGroups;
			Func<CultureFontFallbackGroup, bool> func = (Func<CultureFontFallbackGroup, bool>)(object)(Func<T, TResult>)delegate(CultureFontFallbackGroup x)
			{
				//Discarded unreachable code: IL_0014
				string b = languageIso;
				return string.Equals(x.languageIso, b);
			};
			IEnumerable<CultureFontFallbackGroup> enumerable = (IEnumerable<CultureFontFallbackGroup>)Enumerable.Where<CultureFontFallbackGroup>((IEnumerable<>)cultureFontFallbackGroups, (Func<, >)(object)func);
			Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>> func2 = default(Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>>);
			if (_003C_003Ec._003C_003E9__13_1 == null)
			{
				func2 = (Func<CultureFontFallbackGroup, IEnumerable<TMP_FontAsset>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CultureFontFallbackGroup f)
				{
					List<TMP_FontAsset> fontReferences = f.fontReferences;
					throw new NullReferenceException();
				});
			}
			List<TMP_FontAsset> fallbackFonts = (List<TMP_FontAsset>)(object)Enumerable.ToList<TMP_FontAsset>(Enumerable.SelectMany<CultureFontFallbackGroup, TMP_FontAsset>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			List<TMP_FontAsset> list = fallbackFonts;
			List<TMP_FontAsset> keepLoaded = _fontConfig.keepLoaded;
			((List<T>)(object)list).AddRange((IEnumerable<>)keepLoaded);
			List<TMP_FontAsset> fallbackFontAssetTable = mainFontFallback.m_FallbackFontAssetTable;
			Predicate<TMP_FontAsset> predicate = (Predicate<TMP_FontAsset>)(object)(Predicate<T>)((TMP_FontAsset f) => !((List<T>)(object)fallbackFonts).Contains((T)f));
			List<TMP_FontAsset> list2 = (List<TMP_FontAsset>)(object)((List<T>)(object)fallbackFontAssetTable).FindAll((Predicate<>)(object)predicate);
			Converter<TMP_FontAsset, string> converter = default(Converter<TMP_FontAsset, string>);
			if (_003C_003Ec._003C_003E9__13_3 == null)
			{
				converter = (Converter<TMP_FontAsset, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Converter<TInput, TOutput>)((TMP_FontAsset f) => f.name));
			}
			string[] value = (string[])(object)((List<T>)(object)((List<T>)(object)list2).ConvertAll<string>((Converter<, >)(object)converter)).ToArray();
			string text = string.Join(", ", value);
			Debug.Log("[UI] FontManager#UnloadUnnecessaryFonts " + text);
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FontManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static FontManager()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
