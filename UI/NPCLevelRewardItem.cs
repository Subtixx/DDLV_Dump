using System;
using Cpp2IlInjected;
using Definitions.Character;
using Definitions.Items;
using Definitions.Rewards;
using Mdl.Ui;
using Meta;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NPCLevelRewardItem : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[SerializeField]
	private TextBase _level;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[SerializeField]
	private TextBase _amount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[SerializeField]
	private ImageHelper _rewardIco;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[SerializeField]
	private ImageHelper _rewardIcoMale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[SerializeField]
	private GameObject _bg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[SerializeField]
	private GameObject _bgAlt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[SerializeField]
	private GameObject _questMarker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[SerializeField]
	private GameObject _glow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[SerializeField]
	private GameObject _line;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[SerializeField]
	private RectTransform _levelContainer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[SerializeField]
	private float _normalXPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[SerializeField]
	private float _finalXPos = -20f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[SerializeField]
	private float _bigPosY = -3f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[SerializeField]
	private float _finalPosY = 14f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[SerializeField]
	private float _smallPosY = -13f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[SerializeField]
	private float _bigSize = 84f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[SerializeField]
	private float _smallSize = 72f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[SerializeField]
	private float _bigSizeIco = 78f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[SerializeField]
	private float _finalSizeIco = 100f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[SerializeField]
	private float _smallSizeIco = 32f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[SerializeField]
	private Color _colorOnGoing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[SerializeField]
	private Color _colorDone;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[SerializeField]
	private Color _colorOnTextGoing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[SerializeField]
	private Color _colorTextDone;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private CharacterLevelRewardItemModel _data;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x12982A0", Offset = "0x1296CA0", VA = "0x1812982A0")]
	public void SetData(CharacterLevelRewardItemModel data, bool noLine = false)
	{
		//IL_0118: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		_data = data;
		TextBase level = _level;
		int level_ = data.FriendshipLevel.level_;
		string text = default(string);
		level.Text = text;
		GameObject line = _line;
		if (noLine)
		{
		}
		bool active = !data.IsFinalReward;
		line.SetActive(active);
		Character _003CCharacter_003Ek__BackingField = data.Character;
		FriendshipLevel _003CFriendshipLevel_003Ek__BackingField = data.FriendshipLevel;
		int friendshipLevel_ = _003CCharacter_003Ek__BackingField.friendshipLevel_;
		int level_2 = _003CFriendshipLevel_003Ek__BackingField.level_;
		GameObject bg = _bg;
		int num = friendshipLevel_ + 1;
		int num2 = 0;
		if ((data.IsFinalReward ? 1 : 0) != num2)
		{
		}
		bg.SetActive(active);
		GameObject bgAlt = _bgAlt;
		if (num != level_2)
		{
		}
		bgAlt.SetActive(active);
		GameObject gameObject = _rewardIcoMale.gameObject;
		int active2 = 0;
		gameObject.SetActive((byte)active2 != 0);
		GameObject glow = _glow;
		int active3 = 0;
		glow.SetActive((byte)active3 != 0);
		GameObject questMarker = _questMarker;
		int active4 = 0;
		questMarker.SetActive((byte)active4 != 0);
		TextMeshProUGUI textComponent = _amount.TextComponent;
		Color color = (textComponent.color = _colorOnTextGoing);
		RectTransform levelContainer = _levelContainer;
		int num3 = 0;
		Vector2 anchoredPosition = levelContainer.anchoredPosition;
		levelContainer.anchoredPosition = (Vector2)num3;
		ImageHelper rewardIco = default(ImageHelper);
		if (data.IsFinalReward)
		{
			GameObject gameObject2 = _amount.gameObject;
			int active5 = 0;
			gameObject2.SetActive((byte)active5 != 0);
			_questMarker.SetActive(value: true);
			_glow.SetActive(value: true);
			RectTransform levelContainer2 = _levelContainer;
			int num4 = 0;
			Vector2 anchoredPosition2 = levelContainer2.anchoredPosition;
			levelContainer2.anchoredPosition = (Vector2)num4;
			IItemData _003CMissionReward_003Ek__BackingField = data.MissionReward;
			if (_003CMissionReward_003Ek__BackingField != null)
			{
			}
			GameObject gameObject3 = default(GameObject);
			int active6 = default(int);
			if ((long)data.MissionRewardAlt == 0)
			{
				if (_003CMissionReward_003Ek__BackingField != null)
				{
					rewardIco = _rewardIco;
					rewardIco.IconAddress = (string)typeof(ClothingItemData).TypeHandle;
					_rewardIco.Load();
					Transform transform = _rewardIco.transform;
					float finalSizeIco = _finalSizeIco;
					Transform transform2 = _rewardIco.transform;
					float normalXPos = _normalXPos;
					float finalPosY = _finalPosY;
					gameObject3 = _amount.gameObject;
					active6 = 0;
					gameObject3.SetActive((byte)active6 != 0);
				}
				return;
			}
			ImageHelper rewardIco2 = _rewardIco;
			if ((object)gameObject3 == null || active6 == 0)
			{
			}
			rewardIco2.IconAddress = "";
			_rewardIco.Load();
			float b = rewardIco._loadedColor.b;
			_rewardIcoMale.IconAddress = (string)(object)rewardIco2;
			Transform transform3 = _rewardIco.transform;
			float finalSizeIco2 = _finalSizeIco;
			Transform transform4 = _rewardIco.transform;
			float finalXPos = _finalXPos;
			float finalPosY2 = _finalPosY;
			_rewardIcoMale.gameObject.SetActive(value: true);
			_rewardIcoMale.Load();
		}
		Image component = _bg.GetComponent<Image>();
		Color color2 = (component.color = _colorOnGoing);
		Image component2 = _line.GetComponent<Image>();
		Color color3 = (component2.color = _colorOnGoing);
		float b2 = rewardIco._startColor.b;
		TextBase amount = _amount;
		int num5 = 0;
		string text2 = default(string);
		amount.Text = text2;
		ImageHelper rewardIco3 = _rewardIco;
		ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
		float b3 = rewardIco._startColor.b;
		int num6 = 0;
		ItemReward itemReward = default(ItemReward);
		Item item = itemReward.Item;
		IItemData _003CIconAddress_003Ek__BackingField = default(IItemData);
		rewardIco3.IconAddress = (string)(object)_003CIconAddress_003Ek__BackingField;
		_rewardIco.Load();
		float b4 = rewardIco._startColor.b;
		int num7 = 0;
		ItemReward itemReward2 = default(ItemReward);
		TextBase amount2 = default(TextBase);
		if (itemReward2.amount_ != 1)
		{
			Transform transform5 = base.transform;
			float smallSize = _smallSize;
			Transform transform6 = _rewardIco.transform;
			float normalXPos2 = _normalXPos;
			float smallPosY = _smallPosY;
			Transform transform7 = _rewardIco.transform;
			float smallSizeIco = _smallSizeIco;
			amount2 = _amount;
			GameObject gameObject4 = amount2.gameObject;
		}
		Transform transform8 = amount2.transform;
		float bigSize = _bigSize;
		Transform transform9 = _rewardIco.transform;
		float normalXPos3 = _normalXPos;
		float bigPosY = _bigPosY;
		Transform transform10 = _rewardIco.transform;
		float bigSizeIco = _bigSizeIco;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1298D10", Offset = "0x1297710", VA = "0x181298D10")]
	public NPCLevelRewardItem()
	{
		Color white = Color.white;
		Color white2 = Color.white;
		Color white3 = Color.white;
		Color white4 = Color.white;
		base._002Ector();
	}
}
