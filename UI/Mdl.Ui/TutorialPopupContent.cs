using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200074C")]
	public class TutorialPopupContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A92")]
		public UnityEvent Hook;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A93")]
		public List<TutorialInfoBox> _infoBoxList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A94")]
		public Action OnOkButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A95")]
		public Action OnShowOkButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002A96")]
		public float BoxDelay = 0.75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002A97")]
		private int nbSlidesShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002A98")]
		[SerializeField]
		public SettingsGameGuideConfig.GameGuideSlide Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002A99")]
		public RectTransform Title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002A9A")]
		public RectTransform BgTitle;

		[Cpp2IlInjected.Token(Token = "0x6002EA3")]
		[Cpp2IlInjected.Address(RVA = "0x17F54B0", Offset = "0x17F3EB0", VA = "0x1817F54B0")]
		public void Start()
		{
			Hook?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA4")]
		[Cpp2IlInjected.Address(RVA = "0x17F5380", Offset = "0x17F3D80", VA = "0x1817F5380")]
		public void Show()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA5")]
		[Cpp2IlInjected.Address(RVA = "0x17F51C0", Offset = "0x17F3BC0", VA = "0x1817F51C0")]
		private void BoxShown()
		{
			//Discarded unreachable code: IL_002c
			int num = nbSlidesShown;
			List<TutorialInfoBox> infoBoxList = _infoBoxList;
			num = (nbSlidesShown = num + 1);
			OnShowOkButton?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA6")]
		[Cpp2IlInjected.Address(RVA = "0x17F5220", Offset = "0x17F3C20", VA = "0x1817F5220")]
		public void OnClickOkButton()
		{
			OnOkButton?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA7")]
		[Cpp2IlInjected.Address(RVA = "0x17F5240", Offset = "0x17F3C40", VA = "0x1817F5240")]
		public void SetupGameGuideMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA8")]
		[Cpp2IlInjected.Address(RVA = "0x17F51B0", Offset = "0x17F3BB0", VA = "0x1817F51B0")]
		public TutorialPopupContent()
		{
		}
	}
}
