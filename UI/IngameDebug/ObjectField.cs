using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class ObjectField : ExpandableInspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		[SerializeField]
		private Button initializeObjectButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private bool elementsInitialized;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		protected override int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x12A2DF0", Offset = "0x12A17F0", VA = "0x1812A2DF0", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_0055
				Button button;
				do
				{
					bool flag = ((InspectorField)this).m_value.IsNull();
					button = initializeObjectButton;
					if (flag)
					{
						continue;
					}
					bool activeSelf = button.gameObject.activeSelf;
					if (!activeSelf)
					{
						if (elementsInitialized != activeSelf)
						{
							return ((List<>)(object)elements)._size;
						}
						elementsInitialized = true;
					}
					return -1;
				}
				while (!button.gameObject.activeSelf);
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x12A2CF0", Offset = "0x12A16F0", VA = "0x1812A2CF0", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0027
			base.Initialize();
			Button.ButtonClickedEvent onClick = initializeObjectButton.m_OnClick;
			UnityAction call = InitializeObject;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x12A2DA0", Offset = "0x12A17A0", VA = "0x1812A2DA0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			elementsInitialized = false;
			base.OnBound(variable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x12A2A30", Offset = "0x12A1430", VA = "0x1812A2A30", Slot = "16")]
		protected override void GenerateElements()
		{
			//Discarded unreachable code: IL_008d, IL_0093
			int num = 0;
			bool flag = ((InspectorField)this).m_value.IsNull();
			Button button = initializeObjectButton;
			if (!flag)
			{
				GameObject gameObject = button.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				RuntimeInspector inspector = ((InspectorField)this).m_inspector;
				Type type = ((InspectorField)this).m_value.GetType();
				IEnumerator<MemberInfo> enumerator = (IEnumerator<MemberInfo>)inspector.GetExposedVariablesForType(type).GetEnumerator();
				if (enumerator != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num != (int)num2)
						{
							num++;
						}
					}
					enumerator = (IEnumerator<MemberInfo>)(object)((object)enumerator + (object)enumerator);
				}
				if (enumerator == null)
				{
				}
			}
			GameObject gameObject2 = button.gameObject;
			bool active2 = CanInitializeNewObject();
			gameObject2.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x12A2DB0", Offset = "0x12A17B0", VA = "0x1812A2DB0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			base.OnSkinChanged();
			UISkin skin = ((InspectorField)this).m_skin;
			initializeObjectButton.SetSkinButton(skin);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x12A2840", Offset = "0x12A1240", VA = "0x1812A2840")]
		private bool CanInitializeNewObject()
		{
			if (!((InspectorField)this).m_boundVariableType.IsAbstract && !((InspectorField)this).m_boundVariableType.IsInterface)
			{
				Type typeFromHandle = typeof(ScriptableObject);
				Type boundVariableType = ((InspectorField)this).m_boundVariableType;
				if (!typeFromHandle.IsAssignableFrom(boundVariableType))
				{
					Type typeFromHandle2 = typeof(UnityEngine.Object);
					Type boundVariableType2 = ((InspectorField)this).m_boundVariableType;
					if (typeFromHandle2.IsAssignableFrom(boundVariableType2) || ((InspectorField)this).m_boundVariableType.IsArray)
					{
						goto IL_009d;
					}
					if (((InspectorField)this).m_boundVariableType.IsGenericType)
					{
						Type genericTypeDefinition = ((InspectorField)this).m_boundVariableType.GetGenericTypeDefinition();
						Type typeFromHandle3 = typeof(List<>);
						if (((object)genericTypeDefinition).Equals((object)typeFromHandle3))
						{
							goto IL_009d;
						}
					}
				}
				return true;
			}
			goto IL_009d;
			IL_009d:
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x12A2C50", Offset = "0x12A1650", VA = "0x1812A2C50")]
		private void InitializeObject()
		{
			if (CanInitializeNewObject())
			{
				object obj2 = (base.Value = ((InspectorField)this).m_boundVariableType.Instantiate());
				RegenerateElements();
				base.IsExpanded = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x12A2DE0", Offset = "0x12A17E0", VA = "0x1812A2DE0")]
		public ObjectField()
		{
		}
	}
}
