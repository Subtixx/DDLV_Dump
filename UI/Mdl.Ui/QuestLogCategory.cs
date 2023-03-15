using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200067E")]
	public class QuestLogCategory : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002460")]
		[SerializeField]
		private BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002461")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002462")]
		[SerializeField]
		private Image _arrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002463")]
		[SerializeField]
		private Image _arrowHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002464")]
		[SerializeField]
		private Image _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002465")]
		[SerializeField]
		private GameObject _pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002466")]
		private Action _onClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002467")]
		private Action _onHighlight;

		[Cpp2IlInjected.Token(Token = "0x60029E6")]
		[Cpp2IlInjected.Address(RVA = "0xE269C0", Offset = "0xE253C0", VA = "0x180E269C0")]
		public void Refresh(QuestLogListItemData.CategoryType category, bool isOpen, Action onClick, Action onHighlight)
		{
			//Discarded unreachable code: IL_009d
			_onClick = onClick;
			_onHighlight = onClick;
			if (category != 0)
			{
				if (category != 0)
				{
					if (category != 0)
					{
						if (category != QuestLogListItemData.CategoryType.Story)
						{
							goto IL_0045;
						}
						TextBase title = _title;
					}
					TextBase title2 = _title;
				}
				TextBase title3 = _title;
			}
			_title.StringID = "menu.questlog_realm_quests";
			goto IL_0045;
			IL_0045:
			Transform transform = _arrow.transform;
			Transform transform2 = _arrow.transform;
			Transform transform3 = _arrow.transform;
			Transform transform4 = _arrowHighlight.transform;
			Transform transform5 = _arrowHighlight.transform;
			Transform transform6 = _arrowHighlight.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60029E7")]
		[Cpp2IlInjected.Address(RVA = "0xE26D30", Offset = "0xE25730", VA = "0x180E26D30")]
		public void Toggle()
		{
			_onClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60029E8")]
		[Cpp2IlInjected.Address(RVA = "0xE26CD0", Offset = "0xE256D0", VA = "0x180E26CD0")]
		public void SetHighLightMode()
		{
			//Discarded unreachable code: IL_0030
			_arrowHighlight.gameObject.SetActive(value: true);
			_pointer.SetActive(value: true);
			_onHighlight?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60029E9")]
		[Cpp2IlInjected.Address(RVA = "0xE26C80", Offset = "0xE25680", VA = "0x180E26C80")]
		public void RemoveHighLightMode()
		{
			//Discarded unreachable code: IL_0026
			GameObject gameObject = _arrowHighlight.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject pointer = _pointer;
			int active2 = 0;
			pointer.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60029EA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public QuestLogCategory()
		{
		}
	}
}
