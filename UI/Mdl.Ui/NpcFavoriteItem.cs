using System;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000525")]
	public class NpcFavoriteItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BB8")]
		[SerializeField]
		private AsyncAtlassedIcon _mcAsyncIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BB9")]
		[SerializeField]
		private SpriteAtlasImage _mcTypeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BBA")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001BBB")]
		[SerializeField]
		private TextBase _tfQuestionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BBC")]
		[SerializeField]
		private Image _bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001BBD")]
		[SerializeField]
		private GameObject _bgDeactivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001BBE")]
		public bool Darken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001BBF")]
		[SerializeField]
		private RectTransform _mcNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001BC0")]
		[SerializeField]
		private GameObject _mcExtra;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001BC1")]
		[SerializeField]
		private GameObject _mcComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001BC2")]
		[SerializeField]
		private GameObject _iconCheckmark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001BC3")]
		private PreferredItemCategory _preferredItemCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001BC4")]
		private Item _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001BC5")]
		private bool _isGiftedAlready;

		[Cpp2IlInjected.Token(Token = "0x6002180")]
		[Cpp2IlInjected.Address(RVA = "0x129F960", Offset = "0x129E360", VA = "0x18129F960")]
		internal void RefreshDisplay(Item item, PreferredItemStatus preferredItemStatus, PreferredItemCategory preferredItemCategory, bool isGiftedAlready)
		{
			//IL_0017: Expected O, but got I4
			//IL_003a: Expected I4, but got I8
			//IL_0054: Expected I4, but got I8
			//IL_0092: Expected I4, but got I8
			//IL_00a1: Expected O, but got I4
			//IL_00d7: Expected I4, but got I8
			//IL_00e6: Expected O, but got I4
			//IL_01ce: Expected I4, but got I8
			//IL_0233: Expected I4, but got I8
			//IL_0271: Expected I4, but got I8
			//IL_02db: Expected I4, but got I8
			//IL_0340: Expected I4, but got I8
			//IL_037a: Expected I4, but got I8
			//IL_0393: Expected O, but got I4
			int itemID = item.ItemID;
			_preferredItemCategory = preferredItemCategory;
			_item = (Item)itemID;
			if (preferredItemStatus != 0)
			{
				switch (preferredItemStatus)
				{
				case PreferredItemStatus.Category:
				{
					ulong num = default(ulong);
					_tfLabel.gameObject.SetActive((byte)num != 0);
					TextBase tfLabel = _tfLabel;
					ulong num2 = default(ulong);
					_mcAsyncIcon.gameObject.SetActive((byte)num2 != 0);
					AsyncAtlassedIcon mcAsyncIcon = _mcAsyncIcon;
					GameObject gameObject = _mcTypeIcon.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					break;
				}
				case PreferredItemStatus.Unknown:
					break;
				default:
					return;
				}
				TextBase tfLabel2 = _tfLabel;
				if (preferredItemCategory != 0)
				{
					ulong num3 = default(ulong);
					tfLabel2.gameObject.SetActive((byte)num3 != 0);
					TextBase tfLabel3 = _tfLabel;
					PreferredItemCategory preferredItemCategory2 = default(PreferredItemCategory);
					string text2 = (tfLabel3.StringID = ((Enum)preferredItemCategory2).ToString());
					GameObject gameObject2 = _mcAsyncIcon.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					ulong num4 = default(ulong);
					_mcTypeIcon.gameObject.SetActive((byte)num4 != 0);
					SpriteAtlasImage mcTypeIcon = _mcTypeIcon;
					PreferredItemCategory preferredItemCategory3 = default(PreferredItemCategory);
					string text3 = ((Enum)preferredItemCategory3).ToString().ToLower();
					string text5 = (mcTypeIcon.ImageAddress = "icon_" + text3 + "_black");
					GameObject gameObject3 = _tfQuestionMark.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
					Image bg = _bg;
					GameObject bgDeactivated = _bgDeactivated;
					int active4 = 0;
					bgDeactivated.SetActive((byte)active4 != 0);
					GameObject gameObject4 = _mcExtra.gameObject;
					GameObject mcComplete = _mcComplete;
					int active5 = 0;
					mcComplete.gameObject.SetActive((byte)active5 != 0);
					GameObject iconCheckmark = _iconCheckmark;
					int active6 = 0;
					iconCheckmark.gameObject.SetActive((byte)active6 != 0);
					return;
				}
				int active7 = 0;
				GameObject gameObject5 = default(GameObject);
				gameObject5.SetActive((byte)active7 != 0);
				GameObject gameObject6 = _mcAsyncIcon.gameObject;
				int active8 = 0;
				gameObject6.SetActive((byte)active8 != 0);
				GameObject gameObject7 = _mcTypeIcon.gameObject;
				int active9 = 0;
				gameObject7.SetActive((byte)active9 != 0);
				ulong num5 = default(ulong);
				_tfQuestionMark.gameObject.SetActive((byte)num5 != 0);
				GameObject gameObject8 = _mcExtra.gameObject;
				int active10 = 0;
				gameObject8.SetActive((byte)active10 != 0);
				GameObject gameObject9 = _mcComplete.gameObject;
				int active11 = 0;
				gameObject9.SetActive((byte)active11 != 0);
				GameObject gameObject10 = _iconCheckmark.gameObject;
				int active12 = 0;
				gameObject10.SetActive((byte)active12 != 0);
				Image bg2 = _bg;
				TextBase tfQuestionMark = default(TextBase);
				if (!Darken)
				{
					ulong num6 = default(ulong);
					bg2.enabled = (byte)num6 != 0;
					GameObject bgDeactivated2 = _bgDeactivated;
					int active13 = 0;
					bgDeactivated2.SetActive((byte)active13 != 0);
					tfQuestionMark = _tfQuestionMark;
					TextMeshProUGUI textComponent = tfQuestionMark.TextComponent;
				}
				int num7 = ((tfQuestionMark.enabled = false) ? 1 : 0);
				ulong num8 = default(ulong);
				_bgDeactivated.SetActive((byte)num8 != 0);
				TextMeshProUGUI textComponent2 = _tfQuestionMark.TextComponent;
			}
			GameObject gameObject11 = _tfLabel.gameObject;
			int active14 = 0;
			gameObject11.SetActive((byte)active14 != 0);
			GameObject gameObject12 = _mcAsyncIcon.gameObject;
			int active15 = 0;
			gameObject12.SetActive((byte)active15 != 0);
			GameObject gameObject13 = _mcTypeIcon.gameObject;
			int active16 = 0;
			gameObject13.SetActive((byte)active16 != 0);
			ulong num9 = default(ulong);
			_tfQuestionMark.gameObject.SetActive((byte)num9 != 0);
			GameObject gameObject14 = _mcExtra.gameObject;
			int active17 = 0;
			gameObject14.SetActive((byte)active17 != 0);
			GameObject gameObject15 = _mcComplete.gameObject;
			int active18 = 0;
			gameObject15.SetActive((byte)active18 != 0);
			GameObject gameObject16 = _iconCheckmark.gameObject;
			int active19 = 0;
			gameObject16.SetActive((byte)active19 != 0);
			Image bg3 = _bg;
			if (!Darken)
			{
				ulong num10 = default(ulong);
				bg3.enabled = (byte)num10 != 0;
				GameObject bgDeactivated3 = _bgDeactivated;
				int active20 = 0;
				bgDeactivated3.SetActive((byte)active20 != 0);
				TextMeshProUGUI textComponent3 = _tfQuestionMark.TextComponent;
			}
			int num11 = ((bg3.enabled = false) ? 1 : 0);
			ulong num12 = default(ulong);
			_bgDeactivated.SetActive((byte)num12 != 0);
			TextBase tfQuestionMark2 = _tfQuestionMark;
			int num13 = 0;
			tfQuestionMark2.TextComponent.color = (Color)num13;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002181")]
		[Cpp2IlInjected.Address(RVA = "0x129F6A0", Offset = "0x129E0A0", VA = "0x18129F6A0")]
		internal void Animate(PreferredItemStatus newStatus)
		{
			//Discarded unreachable code: IL_00ee
			//IL_0015: Expected F4, but got I4
			//IL_006f: Expected F4, but got I4
			//IL_009d: Expected O, but got I4
			CanvasGroup component = base.gameObject.GetComponent<CanvasGroup>();
			int num = 0;
			component.alpha = num;
			bool isGiftedAlready = _isGiftedAlready;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component, 1f, 0.12f);
			CanvasGroup component2 = _mcNew.GetComponent<CanvasGroup>();
			int num2 = 0;
			component2.alpha = num2;
			_mcNew.gameObject.SetActive(value: true);
			RectTransform mcNew = _mcNew;
			int num3 = 0;
			Vector2 anchoredPosition = mcNew.anchoredPosition;
			mcNew.anchoredPosition = (Vector2)num3;
			int num4 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_mcNew, -23f, 0.3f, (byte)num4 != 0)).SetEase(Ease.OutBack, 2.5f).SetDelay(0.25f);
			TweenerCore<float, float, FloatOptions> tweenerCore4 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component2, 1f, 0.15f)).SetDelay(0.25f);
		}

		[Cpp2IlInjected.Token(Token = "0x6002182")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public NpcFavoriteItem()
		{
		}
	}
}
