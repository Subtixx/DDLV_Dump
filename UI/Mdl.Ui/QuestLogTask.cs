using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Missions;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000690")]
	public class QuestLogTask : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024E3")]
		[SerializeField]
		private TextBase _taskLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024E4")]
		[SerializeField]
		private SpriteAtlasImage _checkboxImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024E5")]
		[SerializeField]
		private SpriteAtlasImage _completedImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024E6")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40024E7")]
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40024E8")]
		private bool isCompleted;

		[Cpp2IlInjected.Token(Token = "0x6002A5B")]
		[Cpp2IlInjected.Address(RVA = "0xF327B0", Offset = "0xF311B0", VA = "0x180F327B0")]
		public void Init(DescriptionInfo info, bool hasSubsteps, [Optional] DescriptionInfo parent)
		{
			//Discarded unreachable code: IL_002b
			MissionObjective _003CObjective_003Ek__BackingField = info.Objective;
			int _003CIndentation_003Ek__BackingField = info.Indentation;
			bool _003CCompleted_003Ek__BackingField = info.Completed;
			string _003CDescription_003Ek__BackingField = info.Description;
			Init(_003CDescription_003Ek__BackingField, _003CCompleted_003Ek__BackingField, _003CIndentation_003Ek__BackingField, _003CObjective_003Ek__BackingField, hasSubsteps, parent);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A5C")]
		[Cpp2IlInjected.Address(RVA = "0xF32800", Offset = "0xF31200", VA = "0x180F32800")]
		private void Init(string text, bool completed, int indentation, MissionObjective objective, bool hasSubsteps, [Optional] DescriptionInfo parent)
		{
			//Discarded unreachable code: IL_00ea
			//IL_001b: Expected I8, but got I4
			//IL_0022: Expected I4, but got I8
			//IL_0070: Expected O, but got I4
			HorizontalLayoutGroup layoutGroup = _layoutGroup;
			isCompleted = completed;
			RectOffset padding = ((LayoutGroup)layoutGroup).m_Padding;
			long num = indentation * 25;
			padding.left = (int)num;
			TextBase taskLabel = _taskLabel;
			string text3 = (taskLabel.Text = taskLabel.ParseImageGlyph(text));
			_checkboxImage.gameObject.SetActive(completed);
			_completedImage.gameObject.SetActive(completed);
			CanvasGroup component = GetComponent<CanvasGroup>();
			int num2 = 0;
			bool flag = component != (Object)num2;
			if (flag)
			{
				CanvasGroup component2 = GetComponent<CanvasGroup>();
				if (completed)
				{
				}
				component2.alpha = 1f;
			}
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (flag)
			{
			}
			if ((isCompleted ? 1 : 0) != num3)
			{
			}
			if (1 == 0)
			{
				bool enable = indentation > 0;
				InitCountHolder(enable, 1, indentation);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(_taskLabel.RectTransform);
			_taskLabel.RectTransform.parent.RebuildLayout();
			if ((object)base.transform == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A5D")]
		[Cpp2IlInjected.Address(RVA = "0xF32BE0", Offset = "0xF315E0", VA = "0x180F32BE0")]
		private void RefreshItemCount(MissionObjective objective, bool hasSubsteps)
		{
			//IL_0016: Invalid comparison between I4 and F4
			int num = 0;
			if (objective != null)
			{
				float currentAmount = objective.CurrentAmount;
				float targetAmount_ = objective.targetAmount_;
				if (!(0f >= targetAmount_))
				{
					MissionObjectiveData _003CData_003Ek__BackingField = objective.Data;
					if (_003CData_003Ek__BackingField != null)
					{
						bool hideProgressionCount_ = _003CData_003Ek__BackingField.hideProgressionCount_;
					}
				}
			}
			if ((isCompleted ? 1 : 0) != num)
			{
			}
			if ((!hasSubsteps) ? true : false)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A5E")]
		[Cpp2IlInjected.Address(RVA = "0xF32410", Offset = "0xF30E10", VA = "0x180F32410")]
		private void InitCountHolder(int _current = 0, int _total = 0)
		{
			//Discarded unreachable code: IL_000f
			bool enable = _total > 0;
			InitCountHolder(enable, _total, _total);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A5F")]
		[Cpp2IlInjected.Address(RVA = "0xF32450", Offset = "0xF30E50", VA = "0x180F32450")]
		private void InitCountHolder(bool _enable, int _current = 0, int _total = 0)
		{
			//Discarded unreachable code: IL_00bf
			string text2 = default(string);
			string text3 = default(string);
			while (_enable)
			{
				TextBase taskLabel = _taskLabel;
				string[] array = new string[6];
				string text = taskLabel._text;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				if (" (" != null && " (" == null)
				{
					continue;
				}
				array[1] = " (";
				int num = 0;
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[2] = text2;
				if ("/" != null && "/" == null)
				{
					continue;
				}
				array[3] = "/";
				if (text3 == null || text3 != null)
				{
					array[4] = text3;
					if (")" == null || ")" != null)
					{
						array[5] = ")";
						string text5 = (taskLabel.Text = string.Concat(array));
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A60")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public QuestLogTask()
		{
		}
	}
}
