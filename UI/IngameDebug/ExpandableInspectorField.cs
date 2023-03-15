using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public abstract class ExpandableInspectorField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		[SerializeField]
		protected RectTransform drawArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private RectTransform expandToggleTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		[SerializeField]
		private LayoutGroup layoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		[SerializeField]
		private Image expandArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		protected readonly List<InspectorField> elements = (List<InspectorField>)(object)new List<T>(8);

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly List<ExposedMethodField> exposedMethods;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private bool m_isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private RuntimeInspector.HeaderVisibility m_headerVisibility;

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected virtual int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x1411860", Offset = "0x1410260", VA = "0x181411860", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)elements)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public override bool ShouldRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get
			{
				return m_isExpanded;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x1411B80", Offset = "0x1410580", VA = "0x181411B80")]
			set
			{
				//Discarded unreachable code: IL_006a
				//IL_0035: Expected O, but got I4
				RectTransform rectTransform = drawArea;
				m_isExpanded = value;
				GameObject gameObject = rectTransform.gameObject;
				bool isExpanded = m_isExpanded;
				gameObject.SetActive(isExpanded);
				Image image = expandArrow;
				int num = 0;
				if (image != (UnityEngine.Object)num)
				{
					RectTransform rectTransform2 = expandArrow.rectTransform;
					if (m_isExpanded)
					{
					}
					float z = Vector3.zero.z;
				}
				if (m_isExpanded)
				{
					Refresh();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public RuntimeInspector.HeaderVisibility HeaderVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0")]
			get
			{
				return m_headerVisibility;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x14118A0", Offset = "0x14102A0", VA = "0x1814118A0")]
			set
			{
				//Discarded unreachable code: IL_0113
				//IL_00c2: Expected O, but got I4
				RuntimeInspector.HeaderVisibility headerVisibility = m_headerVisibility;
				if (headerVisibility == value)
				{
					return;
				}
				if (headerVisibility != RuntimeInspector.HeaderVisibility.Hidden)
				{
					if (value != RuntimeInspector.HeaderVisibility.Hidden)
					{
						goto IL_009f;
					}
					int num = (base.Depth = base.m_depth);
					RectOffset padding = this.layoutGroup.m_Padding;
					int num3 = (padding.top = 0);
					GameObject gameObject = expandToggle.gameObject;
				}
				int depth2 = base.m_depth;
				depth2 = (base.Depth = depth2 + 1);
				LayoutGroup layoutGroup = this.layoutGroup;
				UISkin skin = base.m_skin;
				RectOffset padding2 = layoutGroup.m_Padding;
				int num5 = (padding2.top = skin.m_lineHeight);
				expandToggle.gameObject.SetActive(value: true);
				goto IL_009f;
				IL_009f:
				m_headerVisibility = value;
				if (value != 0)
				{
					if (value == RuntimeInspector.HeaderVisibility.AlwaysVisible)
					{
						Image image = expandArrow;
						int num6 = 0;
						if (image != (UnityEngine.Object)num6)
						{
							GameObject gameObject2 = expandArrow.gameObject;
							int active = 0;
							gameObject2.SetActive((byte)active != 0);
						}
						if ((object)variableNameText.transform == null)
						{
							throw new InvalidCastException();
						}
					}
					if (!m_isExpanded)
					{
						IsExpanded = true;
					}
				}
				else
				{
					bool flag = default(bool);
					if (flag)
					{
						GameObject gameObject3 = default(GameObject);
						gameObject3.SetActive(value: true);
					}
					int num7 = 0;
					Transform transform = default(Transform);
					if ((object)transform == null)
					{
						throw new InvalidCastException();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x1410F20", Offset = "0x140F920", VA = "0x181410F20", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_004f
			//IL_0023: Expected O, but got I4
			base.Initialize();
			Transform transform = expandToggle.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				expandToggleTransform = (RectTransform)num;
				PointerEventListener pointerEventListener = expandToggle;
				PointerEventListener.PointerEvent value = delegate
				{
					if (m_headerVisibility == RuntimeInspector.HeaderVisibility.Collapsible)
					{
						bool flag3 = (IsExpanded = !m_isExpanded);
					}
				};
				pointerEventListener.PointerClick += value;
				bool flag = (IsExpanded = m_isExpanded);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x14113E0", Offset = "0x140FDE0", VA = "0x1814113E0", Slot = "10")]
		protected override void OnUnbound()
		{
			base.OnUnbound();
			int num = ((IsExpanded = false) ? 1 : 0);
			GenerateElements();
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1411160", Offset = "0x140FB60", VA = "0x181411160", Slot = "12")]
		protected override void OnSkinChanged()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x1411030", Offset = "0x140FA30", VA = "0x181411030", Slot = "13")]
		protected override void OnDepthChanged()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1411660", Offset = "0x1410060", VA = "0x181411660")]
		protected void RegenerateElements()
		{
			//Discarded unreachable code: IL_005a, IL_005b
			List<InspectorField> list = elements;
			List<ExposedMethodField> list2 = exposedMethods;
			ClearElements();
			int nestLimit = base.m_inspector.m_nestLimit;
			drawArea.gameObject.SetActive(value: true);
			GenerateElements();
			GenerateMethods();
			GameObject gameObject = drawArea.gameObject;
			bool isExpanded = m_isExpanded;
			gameObject.SetActive(isExpanded);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract void GenerateElements();

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x1410B20", Offset = "0x140F520", VA = "0x181410B20")]
		private void GenerateMethods()
		{
			//IL_0084: Expected O, but got I4
			//IL_0084: Expected I4, but got I8
			//IL_009f: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			int num = 0;
			Type boundVariableType = base.m_boundVariableType;
			int num2 = 0;
			ExposedMethod[] array = boundVariableType.GetExposedMethods();
			if (array == null)
			{
				return;
			}
			if (base.m_value == null)
			{
			}
			int num3 = 0;
			int length = array.Length;
			if (num3 >= length)
			{
				return;
			}
			bool flag = default(bool);
			if (!flag)
			{
				num3++;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_00ea;
				}
			}
			RuntimeInspector inspector = base.m_inspector;
			Type typeFromHandle = typeof(ExposedMethod);
			int depth = base.m_depth;
			RectTransform drawerParent = drawArea;
			depth++;
			ulong num4 = default(ulong);
			InspectorField inspectorField = inspector.CreateDrawerForType(typeFromHandle, drawerParent, depth, (byte)num4 != 0, (MemberInfo)num3);
			if ((object)inspectorField == null)
			{
			}
			int num5 = 0;
			if ((object)inspectorField != null)
			{
				int num6 = 0;
				if (inspectorField != (UnityEngine.Object)num6)
				{
					Type typeFromHandle2 = typeof(ExposedMethod);
					string empty = string.Empty;
					Getter getter = () => base.m_value;
					Setter setter = delegate(object value)
					{
						base.Value = value;
					};
					inspectorField.BindTo(typeFromHandle2, empty, getter, setter, (MemberInfo)num3);
					List<ExposedMethodField> list = exposedMethods;
				}
				goto IL_00ea;
			}
			throw new InvalidCastException();
			IL_00ea:
			num3++;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x14102F0", Offset = "0x140ECF0", VA = "0x1814102F0", Slot = "17")]
		protected virtual void ClearElements()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1411420", Offset = "0x140FE20", VA = "0x181411420", Slot = "14")]
		public override void Refresh()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1410480", Offset = "0x140EE80", VA = "0x181410480")]
		protected InspectorField CreateDrawerForComponent(Component component, [Optional] string variableName)
		{
			//Discarded unreachable code: IL_00e6
			//IL_004a: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			Component component2 = component;
			RuntimeInspector inspector = base.m_inspector;
			Type type = component2.GetType();
			int depth = base.m_depth;
			int num = 0;
			RectTransform drawerParent = drawArea;
			depth++;
			InspectorField inspectorField = inspector.CreateDrawerForType(type, drawerParent, depth, (byte)num != 0, (MemberInfo)num);
			int num2 = 0;
			bool flag = inspectorField != (UnityEngine.Object)num2;
			string nameRaw = component.GetType().Name + " component";
			Type type2 = component.GetType();
			string empty = string.Empty;
			Getter getter = delegate
			{
				Component component3 = component;
				/*Error: Unexpected end of block*/;
			};
			Setter _003C_003E9__28_ = _003C_003Ec._003C_003E9__28_1;
			if (_003C_003E9__28_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Setter)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			int num3 = 0;
			inspectorField.BindTo(type2, empty, getter, _003C_003E9__28_, (MemberInfo)num3);
			inspectorField.NameRaw = nameRaw;
			((List<T>)(object)elements).Add((T)inspectorField);
			return inspectorField;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1410790", Offset = "0x140F190", VA = "0x181410790")]
		protected InspectorField CreateDrawerForVariable(MemberInfo variable, [Optional] string variableName)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x1410A00", Offset = "0x140F400", VA = "0x181410A00")]
		protected InspectorField CreateDrawer(Type variableType, string variableName, Getter getter, Setter setter, bool drawObjectsAsFields = true)
		{
			//Discarded unreachable code: IL_0030
			//IL_001f: Expected O, but got I4
			RuntimeInspector inspector = base.m_inspector;
			int depth = base.m_depth;
			int num = 0;
			depth++;
			int num2 = 0;
			InspectorField inspectorField = default(InspectorField);
			if (inspectorField != (UnityEngine.Object)num2)
			{
				((List<T>)(object)elements).Add((T)inspectorField);
			}
			return inspectorField;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1411790", Offset = "0x1410190", VA = "0x181411790")]
		protected ExpandableInspectorField()
		{
			List<ExposedMethodField> list = default(List<ExposedMethodField>);
			exposedMethods = list;
			base._002Ector();
		}
	}
}
