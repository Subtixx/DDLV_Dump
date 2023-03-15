using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Gameloft.Localization.Formatter;
using Mdl.Missions;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000682")]
	public class QuestLogItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002494")]
		[SerializeField]
		private AsyncAtlassedIcon _characterIconLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002495")]
		[SerializeField]
		private AsyncAtlassedIcon _characterIconRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002496")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002497")]
		[SerializeField]
		private Image _characterBgLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002498")]
		[SerializeField]
		private Image _characterBgRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002499")]
		[SerializeField]
		private Image _backgroundSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400249A")]
		[SerializeField]
		private Image _backgroundSelectedHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400249B")]
		[SerializeField]
		private Image _backgroundHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400249C")]
		[SerializeField]
		private Color _highlightedTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400249D")]
		[SerializeField]
		private Color _unhighlightedTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400249E")]
		[SerializeField]
		private GameObject _trackIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400249F")]
		[SerializeField]
		private GameObject _trackIconActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40024A0")]
		[SerializeField]
		private GameObject _lockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40024A1")]
		[SerializeField]
		private GameObject _unlockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40024A2")]
		[SerializeField]
		private Material _greyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40024A3")]
		[SerializeField]
		private SpriteAtlasImage _completedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40024A4")]
		[SerializeField]
		private Transform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40024A5")]
		[SerializeField]
		private GameObject _pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40024A6")]
		[SerializeField]
		private Color _completedQuestBgColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40024A7")]
		[SerializeField]
		private AK.Wwise.Event _selectItemSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40024A8")]
		private Action _onClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40024A9")]
		private bool _selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40024AA")]
		private bool _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDA")]
		[Cpp2IlInjected.Token(Token = "0x40024AB")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40024AC")]
		private float _animatedContentOX;

		[Cpp2IlInjected.Token(Token = "0x6002A04")]
		[Cpp2IlInjected.Address(RVA = "0xF2CD80", Offset = "0xF2B780", VA = "0x180F2CD80")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected F4, but got O
			if (!_isInit)
			{
				Transform animatedContent = _animatedContent;
				_isInit = true;
				Vector2 vector = default(Vector2);
				_animatedContentOX = (float)vector;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A05")]
		[Cpp2IlInjected.Address(RVA = "0xF2CF80", Offset = "0xF2B980", VA = "0x180F2CF80")]
		public void Refresh(MissionSlot quest, bool selected, bool tracked, Action onClick)
		{
			//Discarded unreachable code: IL_01ab
			//IL_000e: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			if (quest == null)
			{
				return;
			}
			_onClick = (Action)0;
			_selected = selected;
			TextBase title = _title;
			MissionItemData data = quest.Data;
			int num = 0;
			if (data != null)
			{
			}
			int num2 = 0;
			string text2 = (title.StringID = quest.ResolveString((string)num, (IResolver)num2));
			RefreshDisplay();
			GameObject gameObject = _characterIconLeft.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _characterIconRight.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			if (quest.Data != null && quest.Data.ownerCharacter_ != num)
			{
				int ownerCharacter = quest.Data.OwnerCharacter;
				IItemData itemData = default(IItemData);
				if (itemData != null && itemData == null)
				{
					_characterIconLeft.gameObject.SetActive(value: true);
					_characterIconRight.gameObject.SetActive(value: true);
					AsyncAtlassedIcon characterIconLeft = _characterIconLeft;
					AsyncAtlassedIcon characterIconRight = _characterIconRight;
				}
			}
			GameObject trackIconActive = _trackIconActive;
			bool active3 = tracked;
			trackIconActive.SetActive(active3);
			GameObject trackIcon = _trackIcon;
			bool active4 = default(bool);
			if (selected)
			{
				active4 = !_trackIconActive.activeSelf;
			}
			trackIcon.SetActive(active4);
			GameObject lockedIcon = _lockedIcon;
			int active5 = 0;
			lockedIcon.SetActive((byte)active5 != 0);
			GameObject unlockedIcon = _unlockedIcon;
			int active6 = 0;
			unlockedIcon.SetActive((byte)active6 != 0);
			GameObject gameObject3 = _completedIcon.gameObject;
			int active7 = 0;
			gameObject3.SetActive((byte)active7 != 0);
			if (quest.state_ == MissionSlotState.OnGoing)
			{
				int num3 = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
			}
			Color color = default(Color);
			if ((long)color == 3)
			{
				int num4 = 0;
				UIGameColors gameColors2 = UiRoot.Instance._gameColors;
			}
			Color color2 = default(Color);
			if ((long)color2 == 1)
			{
				int num5 = 0;
				UIGameColors gameColors3 = UiRoot.Instance._gameColors;
			}
			Color white = Color.white;
			Image characterBgRight = _characterBgRight;
			Image characterBgLeft = _characterBgLeft;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A06")]
		[Cpp2IlInjected.Address(RVA = "0xF2D400", Offset = "0xF2BE00", VA = "0x180F2D400")]
		public void Refresh(MissionItemData quest, bool selected, bool tracked, Action onClick)
		{
			//Discarded unreachable code: IL_0175
			//IL_000e: Expected O, but got I4
			if (quest == null)
			{
				return;
			}
			_onClick = (Action)0;
			_selected = selected;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			int iD = quest.ID;
			TextBase title = _title;
			string stringID = "menu.next_mission_not_available";
			bool flag = default(bool);
			if (flag)
			{
				stringID = "menu.new_mission_available";
			}
			title.StringID = stringID;
			RefreshDisplay();
			GameObject gameObject = _characterIconLeft.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _characterIconRight.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			if (quest.ownerCharacter_ != 0)
			{
				int ownerCharacter = quest.OwnerCharacter;
				IItemData itemData = default(IItemData);
				if (itemData != null && itemData == null)
				{
					_characterIconLeft.gameObject.SetActive(value: true);
					_characterIconRight.gameObject.SetActive(value: true);
					AsyncAtlassedIcon characterIconLeft = _characterIconLeft;
					AsyncAtlassedIcon characterIconRight = _characterIconRight;
				}
			}
			GameObject trackIconActive = _trackIconActive;
			int active3 = 0;
			trackIconActive.SetActive((byte)active3 != 0);
			GameObject trackIcon = _trackIcon;
			int active4 = 0;
			trackIcon.SetActive((byte)active4 != 0);
			GameObject lockedIcon = _lockedIcon;
			bool active5 = !flag;
			lockedIcon.SetActive(active5);
			GameObject unlockedIcon = _unlockedIcon;
			active5 = flag;
			unlockedIcon.SetActive(active5);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			if (!flag)
			{
				UIGameColors gameColors = instance._gameColors;
			}
			UIGameColors gameColors2 = instance._gameColors;
			Image characterBgRight = _characterBgRight;
			Image characterBgLeft = _characterBgLeft;
			GameObject gameObject3 = _completedIcon.gameObject;
			int active6 = 0;
			gameObject3.SetActive((byte)active6 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A07")]
		[Cpp2IlInjected.Address(RVA = "0xF2CD10", Offset = "0xF2B710", VA = "0x180F2CD10")]
		public void OnClick()
		{
			if (!_selected)
			{
				AK.Wwise.Event selectItemSfx = _selectItemSfx;
				if (selectItemSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = selectItemSfx.Post(gameObject);
				}
			}
			_onClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A08")]
		[Cpp2IlInjected.Address(RVA = "0xF2CE70", Offset = "0xF2B870", VA = "0x180F2CE70")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0099
			GameObject gameObject2;
			do
			{
				GameObject gameObject = _backgroundHighlight.gameObject;
				int num = 0;
				if ((_highlighted ? 1 : 0) == num)
				{
				}
				bool active = (_selected ? 1 : 0) == num;
				gameObject.SetActive(active);
				gameObject2 = _backgroundSelectedHighlight.gameObject;
			}
			while (!_highlighted);
			bool active2 = _selected;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _backgroundSelected.gameObject;
			bool selected = _selected;
			gameObject3.SetActive(selected);
			TextMeshProUGUI textComponent = _title.TextComponent;
			if (_highlighted)
			{
			}
			Color color = (textComponent.color = _unhighlightedTextColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A09")]
		[Cpp2IlInjected.Address(RVA = "0xF2CE00", Offset = "0xF2B800", VA = "0x180F2CE00")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_0033
			_highlighted = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				_onClick?.Invoke();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0A")]
		[Cpp2IlInjected.Address(RVA = "0xF2CE60", Offset = "0xF2B860", VA = "0x180F2CE60")]
		public void OnHighlightRemoved()
		{
			_highlighted = false;
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0B")]
		[Cpp2IlInjected.Address(RVA = "0xF2CC60", Offset = "0xF2B660", VA = "0x180F2CC60")]
		public void ApplySwitchSettings(int min, int max)
		{
			//Discarded unreachable code: IL_002e
			TextBase title = _title;
			TextBase.AdjustForHandheldParam adjustForHandheldParam = new TextBase.AdjustForHandheldParam();
			adjustForHandheldParam.min = min;
			adjustForHandheldParam.max = max;
			title.SetAdjustForHandheld(adjustForHandheldParam);
			_title.AdjustForHandheld();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A0C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public QuestLogItem()
		{
		}
	}
}
