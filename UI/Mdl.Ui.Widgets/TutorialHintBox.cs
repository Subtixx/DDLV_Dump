using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009B0")]
	public class TutorialHintBox : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20009B1")]
		public class TutorialWidgetBubble
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003910")]
			public TutorialWidgetAnchor anchorType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003911")]
			public GameObject bg;

			[Cpp2IlInjected.Token(Token = "0x6003CC7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public TutorialWidgetBubble()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003905")]
		private TutorialWidgetAnchor anchorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003906")]
		public List<TutorialWidgetBubble> bubbleBg = (List<TutorialWidgetBubble>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003907")]
		public List<Button> buttons = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003908")]
		public TextMeshProUGUI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003909")]
		public RectTransform panelAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400390A")]
		[HideInInspector]
		public RectTransform self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400390B")]
		[HideInInspector]
		public RectTransform parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400390C")]
		[HideInInspector]
		public RectTransform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400390D")]
		[HideInInspector]
		public Vector3[] worldPoints = new Vector3[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400390E")]
		[HideInInspector]
		public Vector2[] localPoints = new Vector2[2];

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400390F")]
		private bool buttonClicked;

		[Cpp2IlInjected.Token(Token = "0x17000859")]
		public TutorialWidgetAnchor AnchorType
		{
			[Cpp2IlInjected.Token(Token = "0x6003CBE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return anchorType;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CBF")]
			[Cpp2IlInjected.Address(RVA = "0x17F45D0", Offset = "0x17F2FD0", VA = "0x1817F45D0")]
			set
			{
				anchorType = value;
				TutorialUtil.Anchor(panelAnchor, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC0")]
		[Cpp2IlInjected.Address(RVA = "0x17F3AC0", Offset = "0x17F24C0", VA = "0x1817F3AC0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0019, IL_001f
			List<Button> list = buttons;
			bool flag = default(bool);
			if (flag)
			{
				UnityAction unityAction = OnButtonClicked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC1")]
		[Cpp2IlInjected.Address(RVA = "0x17F3C20", Offset = "0x17F2620", VA = "0x1817F3C20")]
		public void Init(RectTransform target, TutorialWidgetAnchor anchorType, string message, bool enableButton)
		{
			//Discarded unreachable code: IL_0059, IL_005f, IL_0065
			int num = ((buttonClicked = false) ? 1 : 0);
			this.target = target;
			this.anchorType = anchorType;
			RectTransform rectTransform = (self = GetComponent<RectTransform>());
			RectTransform rectTransform2 = (parent = base.transform.parent.GetComponent<RectTransform>());
			this.message.text = message;
			List<Button> list = buttons;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC2")]
		[Cpp2IlInjected.Address(RVA = "0x17F3E30", Offset = "0x17F2830", VA = "0x1817F3E30")]
		private unsafe void SetBubbleBg(TutorialWidgetAnchor anchorType)
		{
			//Discarded unreachable code: IL_0018, IL_001e
			List<TutorialWidgetBubble> list = bubbleBg;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = (IntPtr)(void*)(int)anchorType == (IntPtr)"{il2cpp field on {'constant14' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x10}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC3")]
		[Cpp2IlInjected.Address(RVA = "0x17F43B0", Offset = "0x17F2DB0", VA = "0x1817F43B0")]
		[AsyncStateMachine(typeof(_003CWaitForInput_003Ed__18))]
		public Task WaitForInput()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC4")]
		[Cpp2IlInjected.Address(RVA = "0x17F3F50", Offset = "0x17F2950", VA = "0x1817F3F50")]
		public void UpdatePosition()
		{
			//Discarded unreachable code: IL_012f
			//IL_0010: Expected O, but got I4
			RectTransform rectTransform = target;
			int num = 0;
			if (rectTransform != (UnityEngine.Object)num)
			{
				RectTransform rectTransform2 = target;
				Vector3[] fourCornersArray = worldPoints;
				rectTransform2.GetWorldCorners(fourCornersArray);
				RectTransform rectTransform3 = self;
				int num2 = 0;
				Vector2 vector = (rectTransform3.anchorMin = Vector2.zero);
				RectTransform rectTransform4 = self;
				int num3 = 0;
				Vector2 vector2 = (rectTransform4.anchorMax = Vector2.one);
				Vector3[] array = worldPoints;
				RectTransform rectTransform5 = self;
				Vector3 vector3 = array[1];
				Vector2[] array2 = localPoints;
				int num4 = 0;
				Vector3 vector4 = worldPoints[4];
				Vector2[] array3 = localPoints;
				RectTransform rectTransform6 = self;
				Vector2[] array4 = localPoints;
				RectTransform rectTransform7 = self;
				RectTransform rectTransform8 = parent;
				Vector2 anchorMin = array4[0];
				Vector2[] array5 = localPoints;
				RectTransform rectTransform9 = parent;
				Vector2 vector5 = array5[0];
				rectTransform7.anchorMin = anchorMin;
				Vector2[] array6 = localPoints;
				RectTransform rectTransform10 = self;
				RectTransform rectTransform11 = parent;
				Vector2 anchorMax = array6[1];
				Vector2[] array7 = localPoints;
				RectTransform rectTransform12 = parent;
				Vector2 vector6 = array7[1];
				rectTransform10.anchorMax = anchorMax;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC5")]
		[Cpp2IlInjected.Address(RVA = "0x17F3E20", Offset = "0x17F2820", VA = "0x1817F3E20")]
		private void OnButtonClicked()
		{
			buttonClicked = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CC6")]
		[Cpp2IlInjected.Address(RVA = "0x17F44B0", Offset = "0x17F2EB0", VA = "0x1817F44B0")]
		public TutorialHintBox()
		{
		}
	}
}
