using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class InspectorField : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public delegate object Getter();

		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate void Setter(object value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[SerializeField]
		protected LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		[SerializeField]
		protected Text variableNameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[SerializeField]
		protected Image variableNameMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		[SerializeField]
		private MaskableGraphic visibleArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private RuntimeInspector m_inspector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private Type m_boundVariableType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private object m_value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private int m_depth = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private bool m_isVisible = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private Getter getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private Setter setter;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public RuntimeInspector Inspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return m_inspector;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xD24950", Offset = "0xD23350", VA = "0x180D24950")]
			set
			{
				if (m_inspector != value)
				{
					m_inspector = value;
					OnInspectorChanged();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xD24B80", Offset = "0xD23580", VA = "0x180D24B80")]
			set
			{
				//Discarded unreachable code: IL_004b
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
				OnSkinChanged();
				OnDepthChanged();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected Type BoundVariableType
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return m_boundVariableType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected object Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return m_value;
			}
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xD24C60", Offset = "0xD23660", VA = "0x180D24C60")]
			set
			{
				//Discarded unreachable code: IL_0014
				setter(value);
				m_value = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			protected get
			{
				return m_depth;
			}
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xD24930", Offset = "0xD23330", VA = "0x180D24930")]
			set
			{
				if (m_depth != value)
				{
					m_depth = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get
			{
				return m_isVisible;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xD24880", Offset = "0xD23280", VA = "0x180D24880")]
			get
			{
				if (!variableNameText)
				{
					return string.Empty;
				}
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)variableNameText).DtdValidation;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xD24AA0", Offset = "0xD234A0", VA = "0x180D24AA0")]
			set
			{
				//Discarded unreachable code: IL_0034
				if ((bool)variableNameText)
				{
					RuntimeInspector inspector = m_inspector;
					Text text = variableNameText;
					if (inspector.m_useTitleCaseNaming)
					{
						string text2 = value.ToTitleCase();
					}
					text.text = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public string NameRaw
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xD247D0", Offset = "0xD231D0", VA = "0x180D247D0")]
			get
			{
				if (!variableNameText)
				{
					return string.Empty;
				}
				bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)variableNameText).DtdValidation;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xD24A00", Offset = "0xD23400", VA = "0x180D24A00")]
			set
			{
				//Discarded unreachable code: IL_001b
				if ((bool)variableNameText)
				{
					variableNameText.text = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public virtual bool ShouldRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0", Slot = "4")]
			get
			{
				return m_isVisible;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected virtual float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xD247B0", Offset = "0xD231B0", VA = "0x180D247B0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xD24150", Offset = "0xD22B50", VA = "0x180D24150", Slot = "6")]
		public virtual void Initialize()
		{
			//Discarded unreachable code: IL_002f
			if ((bool)visibleArea)
			{
				MaskableGraphic.CullStateChangedEvent onCullStateChanged = visibleArea.m_OnCullStateChanged;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)(UnityAction<T0>)delegate(bool isCulled)
				{
					m_isVisible = isCulled;
				};
				((UnityEvent<T0>)(object)onCullStateChanged).AddListener((UnityAction<>)(object)unityAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool SupportsType(Type type);

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "8")]
		public virtual bool CanBindTo(Type type, MemberInfo variable)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xD23BD0", Offset = "0xD225D0", VA = "0x180D23BD0")]
		public void BindTo(InspectorField parent, MemberInfo variable, [Optional] string variableName)
		{
			//Discarded unreachable code: IL_0156
			string text = default(string);
			if ((object)variable != null)
			{
				int num = 0;
				int num2 = 0;
				if ((object)variable != null)
				{
					goto IL_00b6;
				}
				int num3 = 0;
				if ((object)variable != null)
				{
					int num4 = 0;
					if ((object)variable != null)
					{
						PropertyInfo property = (PropertyInfo)variable;
						if (variableName == null)
						{
							text = property.Name;
						}
						InspectorField inspectorField = parent;
						Type type = default(Type);
						bool isValueType = type.IsValueType;
						PropertyInfo propertyInfo = property;
						if (isValueType)
						{
							Type propertyType = propertyInfo.PropertyType;
							Getter getter = delegate
							{
								InspectorField inspectorField8 = parent;
								PropertyAttributes attributes6 = property.Attributes;
								throw new NullReferenceException();
							};
							Setter setter = delegate
							{
								InspectorField inspectorField7 = parent;
								PropertyAttributes attributes5 = property.Attributes;
								throw new NullReferenceException();
							};
						}
						Getter getter2 = delegate
						{
							InspectorField inspectorField6 = parent;
							PropertyAttributes attributes4 = property.Attributes;
							throw new NullReferenceException();
						};
						goto IL_00b6;
					}
				}
			}
			goto IL_015c;
			IL_00b6:
			int num5 = 0;
			if ((object)variable != null)
			{
				FieldInfo field = (FieldInfo)variable;
				if (text == null)
				{
					string text2 = field.Name;
				}
				bool isValueType2 = parent.m_boundVariableType.IsValueType;
				FieldInfo fieldInfo = field;
				if (isValueType2)
				{
					Type fieldType = fieldInfo.FieldType;
					Getter getter3 = delegate
					{
						InspectorField inspectorField5 = parent;
						FieldAttributes attributes3 = field.Attributes;
						throw new NullReferenceException();
					};
					Setter setter2 = delegate
					{
						InspectorField inspectorField4 = parent;
						FieldAttributes attributes2 = field.Attributes;
						throw new NullReferenceException();
					};
				}
				Getter getter4 = delegate
				{
					InspectorField inspectorField3 = parent;
					FieldAttributes attributes = field.Attributes;
					throw new NullReferenceException();
				};
				Setter setter3 = delegate(object value)
				{
					//Discarded unreachable code: IL_0023
					InspectorField inspectorField2 = parent;
					FieldInfo fieldInfo2 = field;
					object value2 = inspectorField2.m_value;
					fieldInfo2.SetValue(value2, value);
				};
				return;
			}
			goto IL_015c;
			IL_015c:
			ArgumentException ex = new ArgumentException("Variable can either be a field or a property");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xD23A90", Offset = "0xD22490", VA = "0x180D23A90")]
		public void BindTo(Type variableType, string variableName, Getter getter, Setter setter, [Optional] MemberInfo variable)
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected O, but got I4
			m_boundVariableType = variableType;
			if ((bool)variableNameText)
			{
				RuntimeInspector inspector = m_inspector;
				Text text = variableNameText;
				if (inspector.m_useTitleCaseNaming)
				{
					string text2 = variableName.ToTitleCase();
				}
				text.text = variableName;
			}
			this.getter = getter;
			this.setter = (Setter)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xD24710", Offset = "0xD23110", VA = "0x180D24710")]
		public void Unbind()
		{
			//Discarded unreachable code: IL_001c
			//IL_0009: Expected O, but got I8
			m_boundVariableType = (Type)0;
			OnUnbound();
			m_inspector.PoolDrawer(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xD24250", Offset = "0xD22C50", VA = "0x180D24250", Slot = "9")]
		protected virtual void OnBound(MemberInfo variable)
		{
			RefreshValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xD24650", Offset = "0xD23050", VA = "0x180D24650", Slot = "10")]
		protected virtual void OnUnbound()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xD24320", Offset = "0xD22D20", VA = "0x180D24320", Slot = "11")]
		protected virtual void OnInspectorChanged()
		{
			//Discarded unreachable code: IL_0077
			//IL_0076: Expected O, but got I4
			TooltipArea component2;
			do
			{
				Text text = variableNameText;
				if (!text)
				{
					return;
				}
				RuntimeInspector inspector = m_inspector;
				Text text2 = variableNameText;
				if (!inspector.m_showTooltips)
				{
					TooltipArea component = text2.GetComponent<TooltipArea>();
					if ((bool)component)
					{
						UnityEngine.Object.Destroy(component);
						Text text3 = variableNameText;
						int num = ((text3.raycastTarget = false) ? 1 : 0);
					}
					return;
				}
				component2 = text.GetComponent<TooltipArea>();
			}
			while ((bool)component2);
			component2.gameObject.AddComponent<TooltipArea>().drawer = (InspectorField)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xD244F0", Offset = "0xD22EF0", VA = "0x180D244F0", Slot = "12")]
		protected virtual void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0080
			if ((bool)this.layoutElement)
			{
				UISkin skin = m_skin;
				LayoutElement layoutElement = this.layoutElement;
				float heightMultiplier = HeightMultiplier;
				layoutElement.SetHeight(0f);
			}
			if ((bool)variableNameText)
			{
				UISkin skin2 = m_skin;
				variableNameText.SetSkinText(skin2);
			}
			if ((bool)variableNameMask)
			{
				UISkin skin3 = m_skin;
				Image image = variableNameMask;
				Color color = (image.color = skin3.m_backgroundColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xD24260", Offset = "0xD22C60", VA = "0x180D24260", Slot = "13")]
		protected virtual void OnDepthChanged()
		{
			//Discarded unreachable code: IL_002a
			//IL_0010: Expected O, but got I4
			Text text = variableNameText;
			int num = 0;
			if (text != (UnityEngine.Object)num)
			{
				RectTransform rectTransform = variableNameText.rectTransform;
				UISkin skin = m_skin;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xD24250", Offset = "0xD22C50", VA = "0x180D24250", Slot = "14")]
		public virtual void Refresh()
		{
			RefreshValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xD24670", Offset = "0xD23070", VA = "0x180D24670")]
		private void RefreshValue()
		{
			//Discarded unreachable code: IL_0018, IL_001e
			object obj = (m_value = getter());
			bool flag = default(bool);
			if (flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xD24790", Offset = "0xD23190", VA = "0x180D24790")]
		protected InspectorField()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
