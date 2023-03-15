using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public abstract class PopupBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private const float POINTER_VALIDATE_INTERVAL = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		[SerializeField]
		private LayoutElement borderLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		[SerializeField]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		[SerializeField]
		protected Text label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private RectTransform canvasTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private Camera worldCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected PointerEventData pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private float nextPointerValidation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private UISkin m_skin;

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xE14940", Offset = "0xE13340", VA = "0x180E14940")]
			set
			{
				//Discarded unreachable code: IL_0098
				if (!(m_skin != value))
				{
					int version = m_skin.m_version;
					if (m_skinVersion == version)
					{
						return;
					}
				}
				m_skin = value;
				int num = (m_skinVersion = m_skin.m_version);
				float num2 = default(float);
				borderLayoutElement.SetHeight(num2);
				LayoutElement component = background.GetComponent<LayoutElement>();
				UISkin skin = m_skin;
				component.minHeight = num2;
				Image image = background;
				Color inputFieldNormalBackgroundColor = m_skin.m_inputFieldNormalBackgroundColor;
				Image image2 = background;
				UISkin skin2 = m_skin;
				label.SetSkinInputFieldText(skin2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE14510", Offset = "0xE12F10", VA = "0x180E14510")]
		public void Initialize(Canvas canvas)
		{
			//IL_0018: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				rectTransform = (RectTransform)num;
				Transform transform2 = canvas.transform;
				if ((object)transform2 != null && (object)transform2 == null)
				{
					throw new InvalidCastException();
				}
				canvasTransform = (RectTransform)transform2;
				if (canvas.renderMode != 0)
				{
					if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
					{
						Camera camera = canvas.worldCamera;
						int num2 = 0;
						if (camera == (UnityEngine.Object)num2)
						{
							goto IL_007d;
						}
					}
					if ((bool)canvas.worldCamera)
					{
						Camera camera2 = canvas.worldCamera;
					}
					int num3 = 0;
					Camera camera3 = (worldCamera = Camera.main);
				}
			}
			goto IL_007d;
			IL_007d:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE147A0", Offset = "0xE131A0", VA = "0x180E147A0")]
		protected void SetPointer(PointerEventData pointer)
		{
			//Discarded unreachable code: IL_0042
			this.pointer = pointer;
			nextPointerValidation = 5f;
			PointerEventData pointerEventData = this.pointer;
			RectTransform rectTransform = canvasTransform;
			Vector2 _003Cposition_003Ek__BackingField = pointerEventData.position;
			float y = pointerEventData.position.y;
			bool flag = default(bool);
			if (flag)
			{
				RectTransform rectTransform2 = this.rectTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE146C0", Offset = "0xE130C0", VA = "0x180E146C0")]
		protected void RepositionSelf()
		{
			//Discarded unreachable code: IL_0030
			PointerEventData pointerEventData = pointer;
			RectTransform rectTransform = canvasTransform;
			Vector2 _003Cposition_003Ek__BackingField = pointerEventData.position;
			float y = pointerEventData.position.y;
			bool flag = default(bool);
			if (flag)
			{
				RectTransform rectTransform2 = this.rectTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void DestroySelf();

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE14890", Offset = "0xE13290", VA = "0x180E14890")]
		private void Update()
		{
			float num = nextPointerValidation;
			int num2 = 0;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int num3 = 0;
			nextPointerValidation = num;
			PointerEventData pointerEventData = pointer;
			nextPointerValidation = 5f;
			if (pointerEventData == null || !pointerEventData.IsPointerValid())
			{
				DestroySelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected PopupBase()
		{
		}
	}
}
