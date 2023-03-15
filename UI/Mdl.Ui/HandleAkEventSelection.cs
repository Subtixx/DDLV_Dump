using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Mdl.Audio;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200072B")]
	public class HandleAkEventSelection : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002966")]
		public AK.Wwise.Event GamestartTrailerAudioEn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002967")]
		public AK.Wwise.Event GamestartTrailerAudioFr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002968")]
		public AK.Wwise.Event GamestartTrailerAudioCh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002969")]
		public AK.Wwise.Event GamestartTrailerAudioGe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400296A")]
		public AK.Wwise.Event GamestartTrailerAudioIt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400296B")]
		public AK.Wwise.Event GamestartTrailerAudioSp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400296C")]
		public AK.Wwise.Event GamestartTrailerAudioJp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400296D")]
		private AK.Wwise.Event _currentEvent;

		[Cpp2IlInjected.Token(Token = "0x6002D95")]
		[Cpp2IlInjected.Address(RVA = "0xAE2EC0", Offset = "0xAE18C0", VA = "0x180AE2EC0")]
		private void Start()
		{
			//Discarded unreachable code: IL_00f7
			AK.Wwise.Event @event = (_currentEvent = GamestartTrailerAudioEn);
			string culture = SystemRoot.Instance._localizationManager.Culture;
			string culture2 = LocalizationUtil.GetCulture(Definitions.Locale.FrenchFr);
			if (!string.Equals(culture, culture2))
			{
				string culture3 = SystemRoot.Instance._localizationManager.Culture;
				string culture4 = LocalizationUtil.GetCulture(Definitions.Locale.ChineseSimplified);
				if (!string.Equals(culture3, culture4))
				{
					int num = 0;
					string culture5 = LocalizationUtil.GetCulture(Definitions.Locale.ChineseTraditional);
					string a = default(string);
					if (!string.Equals(a, culture5))
					{
						int num2 = 0;
						string culture6 = LocalizationUtil.GetCulture(Definitions.Locale.GermanDe);
						string a2 = default(string);
						if (!string.Equals(a2, culture6))
						{
							int num3 = 0;
							string culture7 = LocalizationUtil.GetCulture(Definitions.Locale.ItalianIt);
							string a3 = default(string);
							if (!string.Equals(a3, culture7))
							{
								int num4 = 0;
								string culture8 = LocalizationUtil.GetCulture(Definitions.Locale.SpanishEs);
								string a4 = default(string);
								if (!string.Equals(a4, culture8))
								{
									int num5 = 0;
									string culture9 = LocalizationUtil.GetCulture(Definitions.Locale.JapaneseJp);
									string a5 = default(string);
									if (!string.Equals(a5, culture9))
									{
										goto IL_00db;
									}
								}
							}
						}
					}
				}
			}
			AK.Wwise.Event event2 = (_currentEvent = GamestartTrailerAudioFr);
			goto IL_00db;
			IL_00db:
			AK.Wwise.Event currentEvent = _currentEvent;
			GameObject gameObject = base.gameObject;
			uint num6 = currentEvent.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D96")]
		[Cpp2IlInjected.Address(RVA = "0xAE2DA0", Offset = "0xAE17A0", VA = "0x180AE2DA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_002b
			AK.Wwise.Event currentEvent = _currentEvent;
			GameObject gameObject = base.gameObject;
			int transitionDuration = 0;
			currentEvent.Stop(gameObject, transitionDuration);
			SystemRoot.Instance.GetSystem<AudioManager>().SetGameState(AudioManager.GameState.LaunchMenu);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D97")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HandleAkEventSelection()
		{
		}
	}
}
