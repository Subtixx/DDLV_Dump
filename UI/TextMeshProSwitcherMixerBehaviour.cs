using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.Ui;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

[Cpp2IlInjected.Token(Token = "0x200006E")]
public class TextMeshProSwitcherMixerBehaviour : PlayableBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private Color m_DefaultColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private int m_DefaultFontSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public string m_DefaultText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private TextMeshProUGUI m_TrackBinding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private bool m_FirstFrameHappened;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x17EC930", Offset = "0x17EB330", VA = "0x1817EC930", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
		//Discarded unreachable code: IL_010b
		//IL_0023: Expected O, but got I4
		//IL_0057: Expected I4, but got O
		//IL_0084: Invalid comparison between F4 and I4
		//IL_00ad: Expected O, but got I4
		//IL_00cd: Expected F4, but got I4
		//IL_00ed: Expected F4, but got I4
		int num = 0;
		if (playerData == null)
		{
		}
		int num2 = 0;
		int num3 = 0;
		m_TrackBinding = (TextMeshProUGUI)playerData;
		TextMeshProUGUI trackBinding = m_TrackBinding;
		int num4 = 0;
		bool flag = trackBinding == (Object)num4;
		if (flag)
		{
			return;
		}
		if (m_FirstFrameHappened == flag)
		{
			TextMeshProUGUI trackBinding2 = m_TrackBinding;
			Color color = trackBinding.color;
			TextMeshProUGUI trackBinding3 = m_TrackBinding;
			m_DefaultFontSize = (int)color;
			string text = (m_DefaultText = trackBinding3.text);
			m_FirstFrameHappened = true;
		}
		int num5 = 0;
		int num6 = default(int);
		int num9 = default(int);
		if (num6 > 0)
		{
			TextMeshProSwitcherBehaviour textMeshProSwitcherBehaviour = default(TextMeshProSwitcherBehaviour);
			Color color2 = textMeshProSwitcherBehaviour.color;
			float num7 = default(float);
			if (!(num7 <= (float)num5))
			{
				TextMeshProUGUI trackBinding4 = m_TrackBinding;
				if (textMeshProSwitcherBehaviour.localizeText)
				{
					string stringID = textMeshProSwitcherBehaviour.stringID;
					int num8 = 0;
					string text2 = LocalizationManager.FromStringID(stringID, (IResolver)num8);
				}
				string text3 = (trackBinding4.text = textMeshProSwitcherBehaviour.stringID);
			}
			num9 = 0;
			if (!Mathf.Approximately(num7, num9))
			{
				num3++;
			}
			num3++;
		}
		TextMeshProUGUI trackBinding5 = m_TrackBinding;
		m_TrackBinding.fontSize = num9;
		if (num3 != 1)
		{
			TextMeshProUGUI trackBinding6 = m_TrackBinding;
			string text4 = (trackBinding6.text = m_DefaultText);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x17EC860", Offset = "0x17EB260", VA = "0x1817EC860", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
		//Discarded unreachable code: IL_0051
		//IL_0017: Expected O, but got I4
		TextMeshProUGUI trackBinding = m_TrackBinding;
		m_FirstFrameHappened = false;
		int num = 0;
		if (!(trackBinding == (Object)num))
		{
			TextMeshProUGUI trackBinding2 = m_TrackBinding;
			Color color = (trackBinding2.color = m_DefaultColor);
			TextMeshProUGUI trackBinding3 = m_TrackBinding;
			TextMeshProUGUI trackBinding4 = m_TrackBinding;
			string text = (trackBinding4.text = m_DefaultText);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
	public TextMeshProSwitcherMixerBehaviour()
	{
	}
}
