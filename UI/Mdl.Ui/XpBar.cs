using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200057C")]
	public class XpBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DFD")]
		[SerializeField]
		private TextBase _levelLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DFE")]
		[SerializeField]
		private TextBase _maxLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DFF")]
		[SerializeField]
		private RectTransform _xpProgressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E00")]
		[SerializeField]
		public SlidingPanel SlidingPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E01")]
		[SerializeField]
		private float _filledWidth;

		[Cpp2IlInjected.Token(Token = "0x60023EA")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB20", Offset = "0x8EB520", VA = "0x1808ECB20")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_0102
			//IL_00c0: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			//IL_00f4: Expected I4, but got I8
			int level_ = SystemRoot.Instance.MetaClient.profile.player_.level_;
			int maxLevel = SystemRoot.Instance.MetaClient.profile.player_.GetMaxLevel();
			int xp_ = SystemRoot.Instance.MetaClient.profile.player_.xp_;
			ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			level_++;
			int xpRequiredForLevel = player_.GetXpRequiredForLevel(level_);
			if (level_ > 0)
			{
				int xpRequiredForLevel2 = SystemRoot.Instance.Client.Profile.player_.GetXpRequiredForLevel(level_);
			}
			int num = 0;
			RectTransform xpProgressBar = _xpProgressBar;
			if (level_ != maxLevel)
			{
				int num2 = 0;
				Vector2 sizeDelta = xpProgressBar.sizeDelta;
				xp_ -= num;
				xpRequiredForLevel -= num;
				xpProgressBar.sizeDelta = (Vector2)num2;
				GameObject gameObject = _maxLabel.gameObject;
			}
			int num3 = 0;
			Vector2 sizeDelta2 = xpProgressBar.sizeDelta;
			xpProgressBar.sizeDelta = (Vector2)num3;
			ulong num4 = default(ulong);
			_maxLabel.gameObject.SetActive((byte)num4 != 0);
			string text = default(string);
			_levelLabel.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60023EB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public XpBar()
		{
		}
	}
}
