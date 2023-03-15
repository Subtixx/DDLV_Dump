using System;
using System.Data.SqlTypes;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class ObjectReferenceField : InspectorField, IDropHandler, IEventSystemHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		[SerializeField]
		private RectTransform referencePickerArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		[SerializeField]
		private PointerEventListener input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[SerializeField]
		private PointerEventListener inspectReferenceButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private Image inspectReferenceImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		[SerializeField]
		protected Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		[SerializeField]
		protected Text referenceNameText;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x12A2EF0", Offset = "0x12A18F0", VA = "0x1812A2EF0", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0031: Expected O, but got I4
			base.Initialize();
			PointerEventListener pointerEventListener = input;
			PointerEventListener.PointerEvent value = ShowReferencePicker;
			pointerEventListener.PointerClick += value;
			PointerEventListener pointerEventListener2 = inspectReferenceButton;
			int num = 0;
			if (pointerEventListener2 != (UnityEngine.Object)num)
			{
				PointerEventListener pointerEventListener3 = inspectReferenceButton;
				PointerEventListener.PointerEvent value2 = InspectReference;
				pointerEventListener3.PointerClick += value2;
				Image image = (inspectReferenceImage = inspectReferenceButton.GetComponent<Image>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x12A3B30", Offset = "0x12A2530", VA = "0x1812A3B30", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Guid gUID = typeof(UnityEngine.Object).GUID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x12A38F0", Offset = "0x12A22F0", VA = "0x1812A38F0")]
		private void ShowReferencePicker(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_00bc
			Type boundVariableType = base.m_boundVariableType;
			int num = 0;
			ObjectReferencePicker instance = ObjectReferencePicker.Instance;
			UISkin uISkin = (instance.Skin = ((SkinnedWindow)base.m_inspector).m_skin);
			int num2 = 0;
			ObjectReferencePicker instance2 = ObjectReferencePicker.Instance;
			Type boundVariableType2 = base.m_boundVariableType;
			object value = base.m_value;
			if (value == null)
			{
			}
			int num3 = 0;
			if (value != null)
			{
				instance2.initialValue = (UnityEngine.Object)value;
				ObjectReferencePicker.OnReferenceChanged onReferenceChanged = default(ObjectReferencePicker.OnReferenceChanged);
				instance2.onReferenceChanged = onReferenceChanged;
				RectTransform rectTransform = instance2.panel.rectTransform;
				int num4 = 0;
				Vector2 vector = (rectTransform.anchoredPosition = Vector2.zero);
				instance2.gameObject.SetActive(value: true);
				Text selectPromptText = instance2.selectPromptText;
				string text = boundVariableType2.Name;
				string text3 = (selectPromptText.text = "Select " + text);
				instance2.currentlySelectedObject = (UnityEngine.Object)value;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x12A3050", Offset = "0x12A1A50", VA = "0x1812A3050")]
		private void InspectReference(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0052, IL_0058
			if (base.m_value == null)
			{
				return;
			}
			object value = base.m_value;
			if (value != null)
			{
				int num = 0;
				if (value != null)
				{
					float y = eventData.scrollDelta.y;
					RuntimeInspector inspector = base.m_inspector;
					int num2 = 0;
					if ("{il2cpp array field il2cppMethodInfo->}" == eventData)
					{
					}
					int num3 = 0;
					GameObject obj = default(GameObject);
					inspector.Inspect(obj);
					return;
				}
			}
			base.m_inspector.Inspect(value);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x12A31A0", Offset = "0x12A1BA0", VA = "0x1812A31A0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			object value = base.m_value;
			if (value == null)
			{
			}
			int num = 0;
			if (value != null)
			{
				long length = ((System.Data.SqlTypes.SqlStreamChars)(object)this).Length;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x12A3320", Offset = "0x12A1D20", VA = "0x1812A3320", Slot = "16")]
		protected virtual void OnReferenceChanged(UnityEngine.Object reference)
		{
			//IL_0031: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			object value = base.m_value;
			if (value == null)
			{
			}
			int num = 0;
			if (value != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					base.Value = reference;
				}
				Text text = referenceNameText;
				int num2 = 0;
				if (text != (UnityEngine.Object)num2)
				{
					Text text2 = referenceNameText;
					Type boundVariableType = base.m_boundVariableType;
					string text3 = (text2.text = reference.GetNameWithType(boundVariableType));
				}
				PointerEventListener pointerEventListener = inspectReferenceButton;
				int num3 = 0;
				if (pointerEventListener != (UnityEngine.Object)num3)
				{
					GameObject gameObject = inspectReferenceButton.gameObject;
					if (base.m_value != null)
					{
					}
					bool active = default(bool);
					gameObject.SetActive(active);
				}
				base.m_inspector.RefreshDelayed();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x12A3250", Offset = "0x12A1C50", VA = "0x1812A3250", Slot = "15")]
		public void OnDrop(PointerEventData eventData)
		{
			//IL_0018: Expected O, but got I4
			Type boundVariableType = base.m_boundVariableType;
			UnityEngine.Object assignableObjectFromDraggedReferenceItem = RuntimeInspectorUtils.GetAssignableObjectFromDraggedReferenceItem(eventData, boundVariableType);
			int num = 0;
			if (assignableObjectFromDraggedReferenceItem != (UnityEngine.Object)num)
			{
				OnReferenceChanged(assignableObjectFromDraggedReferenceItem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x12A3540", Offset = "0x12A1F40", VA = "0x1812A3540", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0134
			//IL_00d9: Expected I4, but got F4
			//IL_0126: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			Image image = background;
			Color inputFieldNormalBackgroundColor = skin.m_inputFieldNormalBackgroundColor;
			UISkin skin2 = base.m_skin;
			referenceNameText.SetSkinInputFieldText(skin2);
			UISkin skin3 = base.m_skin;
			Text text = referenceNameText;
			int fontSize = skin3.m_fontSize;
			fontSize += -2;
			fontSize = (text.resizeTextMinSize = Mathf.Max(2, fontSize));
			UISkin skin4 = base.m_skin;
			Text text2 = referenceNameText;
			int num2 = (text2.resizeTextMaxSize = skin4.m_fontSize);
			if ((bool)inspectReferenceImage)
			{
				UISkin skin5 = base.m_skin;
				Image image2 = inspectReferenceImage;
				Color textColor = skin5.m_textColor;
				LayoutElement component = inspectReferenceImage.GetComponent<LayoutElement>();
				int lineHeight = base.m_skin.m_lineHeight;
				lineHeight += -8;
				int num3 = Mathf.Max(lineHeight, 0);
				component.SetWidth(8E-45f);
			}
			if ((bool)referencePickerArea)
			{
				UISkin skin6 = base.m_skin;
				Image image3 = variableNameMask;
				float labelWidthPercentage = skin6.m_labelWidthPercentage;
				int num4 = 0;
				RectTransform rectTransform = image3.rectTransform;
				int num5 = 0;
				rectTransform.anchorMin = (Vector2)num4;
				referencePickerArea.anchorMin = (Vector2)num4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x12A3840", Offset = "0x12A2240", VA = "0x1812A3840", Slot = "14")]
		public override void Refresh()
		{
			//IL_0010: Expected O, but got I4
			object value = base.m_value;
			int num = 0;
			base.OnBound((MemberInfo)num);
			object value2 = base.m_value;
			if (value != value2)
			{
				if (value2 == null)
				{
				}
				int num2 = 0;
				if (value2 == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public ObjectReferenceField()
		{
		}
	}
}
