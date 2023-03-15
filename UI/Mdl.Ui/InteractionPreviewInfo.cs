using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B6")]
	public class InteractionPreviewInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D3D")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D3E")]
		[SerializeField]
		private Transform _interactionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D3F")]
		[SerializeField]
		private InteractionInfoGroup _interactionInfoGroupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D40")]
		[SerializeField]
		private BubbleAnimation _interactionBubbleAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002D41")]
		[SerializeField]
		private BubbleAnimation _priceBubbleAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002D42")]
		[SerializeField]
		[Header("Position settings")]
		private float _offsetY = 150f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002D43")]
		[SerializeField]
		[Header("Position Animation Offset settings")]
		private float _animationOffsetY = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002D44")]
		[SerializeField]
		[Header("Price Tag Custom Button")]
		private CustomButton _customButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002D45")]
		private CharacterQuestMarker _targetMarker;

		[Cpp2IlInjected.Token(Token = "0x6003146")]
		[Cpp2IlInjected.Address(RVA = "0xD262B0", Offset = "0xD24CB0", VA = "0x180D262B0", Slot = "15")]
		public override void Kill()
		{
			//Discarded unreachable code: IL_002c
			//IL_0010: Expected O, but got I4
			BubbleAnimation interactionBubbleAnim = _interactionBubbleAnim;
			int num = 0;
			interactionBubbleAnim.Hide((Action)num);
			BubbleAnimation priceBubbleAnim = _priceBubbleAnim;
			Action onComplete = DoKill;
			priceBubbleAnim.Hide(onComplete);
		}

		[Cpp2IlInjected.Token(Token = "0x6003147")]
		[Cpp2IlInjected.Address(RVA = "0xD25A60", Offset = "0xD24460", VA = "0x180D25A60", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0148
			//IL_001b: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected I4, but got Unknown
			//IL_0136: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			Func<CharacterQuestMarker, bool> func = default(Func<CharacterQuestMarker, bool>);
			IEnumerable<CharacterQuestMarker> enumerable;
			uint num4 = default(uint);
			MailboxObject[] array2 = default(MailboxObject[]);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				object[] array = new object[1];
				if (num != 0 && array == null)
				{
					continue;
				}
				array[0] = num;
				if (InitArgs(array) == null)
				{
					continue;
				}
				if ((long)num < (long)(IntPtr)typeof(UnityEngine.Object).TypeHandle)
				{
					InteractionInfoGroup interactionInfoGroupPrefab = _interactionInfoGroupPrefab;
					Transform interactionParent = _interactionParent;
					InteractionInfoGroup interactionInfoGroup = UnityEngine.Object.Instantiate(interactionInfoGroupPrefab, interactionParent);
					num++;
				}
				int num3 = 0;
				CharacterQuestMarker[] componentsInChildren = UiRoot.Instance._worldCanvas.transform.GetComponentsInChildren<CharacterQuestMarker>();
				if (_003C_003Ec._003C_003E9__10_0 == null)
				{
					func = (Func<CharacterQuestMarker, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterQuestMarker x) => x.IsMailbox));
				}
				enumerable = (IEnumerable<CharacterQuestMarker>)Enumerable.Where<CharacterQuestMarker>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
				if (enumerable == null)
				{
					break;
				}
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_00dc;
					}
					num++;
				}
				int num5 = 0;
				if (!((UnityEngine.Object)(object)array2 != (UnityEngine.Object)num5))
				{
					continue;
				}
				GameObject gameObject = ((Component)(object)array2).gameObject;
				while (!flag)
				{
				}
				_targetMarker = (CharacterQuestMarker)enumerable;
				_targetMarker.ForceHide = true;
				goto IL_00dc;
				IL_00dc:
				enumerable = (IEnumerable<CharacterQuestMarker>)(object)((object)enumerable + (object)enumerable);
				break;
			}
			if (enumerable != null)
			{
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
				int num6 = 0;
				Camera main = Camera.main;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int num7 = 0;
				int height = Screen.height;
				height -= main;
				int num8 = 0;
			}
			BubbleAnimation interactionBubbleAnim = _interactionBubbleAnim;
			int num9 = 0;
			int num10 = 0;
			interactionBubbleAnim.Show((Action)num10, (Action)num9);
			int num11 = 0;
			int num12 = 0;
			interactionBubbleAnim.Show((Action)num12, (Action)num11);
		}

		[Cpp2IlInjected.Token(Token = "0x6003148")]
		[Cpp2IlInjected.Address(RVA = "0xD265B0", Offset = "0xD24FB0", VA = "0x180D265B0")]
		private void ShowInteractionList(InteractPreviewData[] interactions)
		{
			//Discarded unreachable code: IL_004f
			int num = 0;
			int length = interactions.Length;
			if (num < length)
			{
				InteractionInfoGroup interactionInfoGroupPrefab = _interactionInfoGroupPrefab;
				Transform interactionParent = _interactionParent;
				InteractPreviewData interactPreviewData = interactions[num];
				InteractionInfoGroup interactionInfoGroup = UnityEngine.Object.Instantiate(interactionInfoGroupPrefab, interactionParent);
				bool holdButton = interactPreviewData._holdButton;
				string text = interactPreviewData._text;
				interactionInfoGroup.Init(text, holdButton);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003149")]
		[Cpp2IlInjected.Address(RVA = "0xD26400", Offset = "0xD24E00", VA = "0x180D26400")]
		private void PushInteraction()
		{
			//Discarded unreachable code: IL_0081
			//IL_0010: Expected O, but got I4
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected I4, but got Unknown
			//IL_0080: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (!(targetObject == (UnityEngine.Object)num))
			{
				int num2 = 0;
				Camera main = Camera.main;
				Transform transform = _targetObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int num3 = 0;
				int height = Screen.height;
				height -= main;
				Transform transform2 = base.transform;
				RectTransform rectTransform = _rectTransform;
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				RectTransform rectTransform2 = _rectTransform;
				int num4 = 0;
				Vector2 anchoredPosition2 = rectTransform2.anchoredPosition;
				rectTransform.anchoredPosition = (Vector2)num4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600314A")]
		[Cpp2IlInjected.Address(RVA = "0xD266B0", Offset = "0xD250B0", VA = "0x180D266B0", Slot = "17")]
		protected override void UpdatePosition()
		{
			//Discarded unreachable code: IL_009d
			//IL_0010: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected I4, but got Unknown
			//IL_009c: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (targetObject != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Camera main = Camera.main;
				int num3 = 0;
				if (main != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					Camera main2 = Camera.main;
					Transform transform = _targetObject.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					int num5 = 0;
					int height = Screen.height;
					height -= main2;
					Transform transform2 = base.transform;
					RectTransform rectTransform = _rectTransform;
					Vector2 anchoredPosition = rectTransform.anchoredPosition;
					RectTransform rectTransform2 = _rectTransform;
					int num6 = 0;
					Vector2 anchoredPosition2 = rectTransform2.anchoredPosition;
					rectTransform.anchoredPosition = (Vector2)num6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600314B")]
		[Cpp2IlInjected.Address(RVA = "0xD26360", Offset = "0xD24D60", VA = "0x180D26360", Slot = "19")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0030
			base.OnControllerChanged();
			ShortcutIndicator[] componentsInChildren = _interactionParent.GetComponentsInChildren<ShortcutIndicator>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				componentsInChildren[num].TransformToPreset();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600314C")]
		[Cpp2IlInjected.Address(RVA = "0xD25750", Offset = "0xD24150", VA = "0x180D25750")]
		private void InitPriceTag(params object[] parameters)
		{
			//Discarded unreachable code: IL_0082
			int length = parameters.Length;
			if ((long)"{il2cpp array field parameters->}" != 0)
			{
				_customButton.gameObject.SetActive(value: true);
				object obj = parameters[0];
				AsyncAtlassedIcon asyncAtlassedIcon = _customButton.View.DynamicIcon.AsyncAtlassedIcon;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			}
			if ((long)"{il2cpp array field parameters->}" != 0)
			{
				_customButton.gameObject.SetActive(value: true);
				object obj2 = parameters[1];
				string text = default(string);
				_customButton.View.Label.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600314D")]
		[Cpp2IlInjected.Address(RVA = "0xD25560", Offset = "0xD23F60", VA = "0x180D25560")]
		private void DoAnimationAndFade(bool isFadeIn)
		{
			//Discarded unreachable code: IL_005a
			//IL_0014: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			BubbleAnimation interactionBubbleAnim = _interactionBubbleAnim;
			if (!isFadeIn)
			{
				int num = 0;
				interactionBubbleAnim.Hide((Action)num);
				BubbleAnimation priceBubbleAnim = _priceBubbleAnim;
				Action onComplete = DoKill;
				priceBubbleAnim.Hide(onComplete);
			}
			else
			{
				int num2 = 0;
				int num3 = 0;
				interactionBubbleAnim.Show((Action)num3, (Action)num2);
				BubbleAnimation priceBubbleAnim2 = _priceBubbleAnim;
				int num4 = 0;
				int num5 = 0;
				priceBubbleAnim2.Show((Action)num5, (Action)num4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600314E")]
		[Cpp2IlInjected.Address(RVA = "0xD25650", Offset = "0xD24050", VA = "0x180D25650")]
		private void DoKill()
		{
			//Discarded unreachable code: IL_0087
			//IL_0010: Expected O, but got I4
			CharacterQuestMarker targetMarker = _targetMarker;
			int num = 0;
			if (targetMarker != (UnityEngine.Object)num)
			{
				_targetMarker.ForceHide = false;
			}
			RectTransform rectTransform = _rectTransform;
			int complete = 0;
			int num2 = rectTransform.DOKill((byte)complete != 0);
			RectTransform interactionIcon = _interactionInfoGroupPrefab.InteractionIcon;
			int complete2 = 0;
			int num3 = interactionIcon.DOKill((byte)complete2 != 0);
			TextBase interactionText = _interactionInfoGroupPrefab.InteractionText;
			int complete3 = 0;
			int num4 = interactionText.DOKill((byte)complete3 != 0);
			GameObject gameObject = _customButton.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x600314F")]
		[Cpp2IlInjected.Address(RVA = "0xD268A0", Offset = "0xD252A0", VA = "0x180D268A0")]
		public InteractionPreviewInfo()
		{
		}
	}
}
