using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class ArrayField : ExpandableInspectorField, IDropHandler, IEventSystemHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		[SerializeField]
		private LayoutElement sizeLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[SerializeField]
		private Text sizeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		[SerializeField]
		private BoundInputField sizeInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private bool isArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private Type elementType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private readonly List<bool> elementsExpandedStates = (List<bool>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		protected override int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x880770", Offset = "0x87F170", VA = "0x180880770", Slot = "15")]
			get
			{
				object value = ((InspectorField)this).m_value;
				if (!isArray)
				{
					if (value == null)
					{
						goto IL_0028;
					}
					if ((object)typeof(Array).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
				}
				if (value != null)
				{
					int result = 0;
					if (value != null)
					{
						return result;
					}
					throw new InvalidCastException();
				}
				goto IL_0028;
				IL_0028:
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87F8F0", Offset = "0x87E2F0", VA = "0x18087F8F0", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0098
			//IL_003e: Expected O, but got I4
			base.Initialize();
			sizeInput.Initialize();
			BoundInputField boundInputField = sizeInput;
			BoundInputField.OnValueChangedDelegate onValueChangedDelegate = OnSizeInputBeingChanged;
			Delegate @delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
				BoundInputField boundInputField2 = sizeInput;
				BoundInputField.OnValueChangedDelegate onValueSubmitted = boundInputField2.OnValueSubmitted;
				BoundInputField.OnValueChangedDelegate b = OnSizeChanged;
				Delegate delegate2 = Delegate.Combine(onValueSubmitted, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					boundInputField2.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate2;
					sizeInput.DefaultEmptyValue = "0";
					sizeInput.CacheTextOnValueChange = false;
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x880350", Offset = "0x87ED50", VA = "0x180880350", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			//Discarded unreachable code: IL_0039
			if (!type.IsArray || type.GetArrayRank() == 1)
			{
			}
			bool isGenericType = type.IsGenericType;
			if (!isGenericType)
			{
				return isGenericType;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			Type typeFromHandle = typeof(List<>);
			return ((object)genericTypeDefinition).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87FAC0", Offset = "0x87E4C0", VA = "0x18087FAC0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			bool flag = ((InspectorField)this).m_boundVariableType.IsArray;
			Type boundVariableType = ((InspectorField)this).m_boundVariableType;
			isArray = flag;
			if (flag)
			{
				Type type = boundVariableType.GetElementType();
			}
			Type type2 = (elementType = boundVariableType.GetGenericArguments()[0]);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8802D0", Offset = "0x87ECD0", VA = "0x1808802D0", Slot = "10")]
		protected override void OnUnbound()
		{
			//Discarded unreachable code: IL_0022
			base.OnUnbound();
			sizeInput.Text = "0";
			((List<T>)(object)elementsExpandedStates).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8801A0", Offset = "0x87EBA0", VA = "0x1808801A0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_007e
			//IL_006f: Expected O, but got I4
			base.OnSkinChanged();
			BoundInputField boundInputField = sizeInput;
			UISkin uISkin = (boundInputField.Skin = ((InspectorField)this).m_skin);
			UISkin skin2 = ((InspectorField)this).m_skin;
			LayoutElement layoutElement = sizeLayoutElement;
			UISkin skin3 = ((InspectorField)this).m_skin;
			sizeText.SetSkinText(skin3);
			UISkin skin4 = ((InspectorField)this).m_skin;
			Image image = variableNameMask;
			float labelWidthPercentage = skin4.m_labelWidthPercentage;
			int num = 0;
			RectTransform rectTransform = image.rectTransform;
			int num2 = 0;
			rectTransform.anchorMin = (Vector2)num;
			if ((object)sizeInput.transform != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x87FB60", Offset = "0x87E560", VA = "0x18087FB60", Slot = "13")]
		protected override void OnDepthChanged()
		{
			//Discarded unreachable code: IL_001c
			base.OnDepthChanged();
			RectTransform rectTransform = sizeText.rectTransform;
			UISkin skin = ((InspectorField)this).m_skin;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x87EA60", Offset = "0x87D460", VA = "0x18087EA60", Slot = "17")]
		protected override void ClearElements()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x87EC90", Offset = "0x87D690", VA = "0x18087EC90", Slot = "16")]
		protected override void GenerateElements()
		{
			//IL_0073: Expected O, but got I4
			//IL_0073: Expected I4, but got I8
			//IL_0081: Expected O, but got I4
			//IL_00ee: Expected O, but got I4
			//IL_0181: Expected O, but got I4
			//IL_0181: Expected I4, but got I8
			//IL_018f: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			object value2 = ((InspectorField)this).m_value;
			int num = 0;
			if (value2 == null)
			{
				return;
			}
			if ((isArray ? 1 : 0) != num)
			{
				goto IL_012a;
			}
			InspectorField inspectorField;
			if (":" != null)
			{
				if ((long)num < (long)(IntPtr)":")
				{
					RuntimeInspector inspector = ((InspectorField)this).m_inspector;
					int depth = ((InspectorField)this).m_depth;
					RectTransform drawerParent = drawArea;
					depth++;
					Type type = elementType;
					ulong num2 = default(ulong);
					inspectorField = inspector.CreateDrawerForType(type, drawerParent, depth, (byte)num2 != 0, (MemberInfo)num);
					int num3 = 0;
					if (!(inspectorField == (UnityEngine.Object)num3))
					{
						int i = num;
						RuntimeInspector inspector2 = ((InspectorField)this).m_inspector;
						int num4 = 0;
						if ((inspector2.m_arrayIndicesStartAtOne ? 1 : 0) != num4)
						{
							num++;
						}
						string text = default(string);
						string variableName = text + ":";
						Type variableType = elementType;
						Getter getter = delegate
						{
							//Discarded unreachable code: IL_0033
							object value6 = ((InspectorField)this).m_value;
							int num22 = i;
							if ((object)typeof(IList).TypeHandle != null && (object)typeof(IList).TypeHandle != null)
							{
								int num23 = 0;
								num23 += num23;
								num23++;
								return typeof(IList).TypeHandle;
							}
							throw new InvalidCastException();
						};
						Setter setter = delegate
						{
							object value5 = ((InspectorField)this).m_value;
							int num21 = 0;
							if (value5 == null)
							{
							}
							if ((object)typeof(IList).TypeHandle != null)
							{
								ArrayField arrayField = default(ArrayField);
								if ((long)num21 < (long)(IntPtr)typeof(IList).TypeHandle)
								{
									num21 += num21;
									if ((object)"{il2cpp array field il2cppMethodInfo->}" == (object)typeof(IList).TypeHandle)
									{
										arrayField = (ArrayField)(object)((object)arrayField + (object)arrayField);
										num21 += 328;
										throw new NullReferenceException();
									}
									num21++;
								}
								arrayField = this;
								return;
							}
							throw new InvalidCastException();
						};
						int num5 = 0;
						inspectorField.BindTo(variableType, variableName, getter, setter, (MemberInfo)num5);
						List<bool> list = elementsExpandedStates;
						if (setter != null)
						{
							int num6 = 0;
							if ((object)inspectorField != null)
							{
								int num7 = 0;
								if ((object)inspectorField != null)
								{
									int num8 = 0;
									if ((object)inspectorField != null)
									{
										goto IL_0119;
									}
								}
								goto IL_0268;
							}
						}
						goto IL_0119;
					}
				}
				goto IL_023d;
			}
			goto IL_0268;
			IL_0268:
			throw new InvalidCastException();
			IL_0119:
			((List<T>)(object)elements).Add((T)inspectorField);
			num++;
			goto IL_012a;
			IL_012a:
			int num9 = 0;
			InspectorField inspectorField2;
			int num12;
			if (value2 != null)
			{
				if (num < num9)
				{
					RuntimeInspector inspector3 = ((InspectorField)this).m_inspector;
					int depth2 = ((InspectorField)this).m_depth;
					RectTransform drawerParent2 = drawArea;
					depth2++;
					Type type2 = elementType;
					ulong num10 = default(ulong);
					inspectorField2 = inspector3.CreateDrawerForType(type2, drawerParent2, depth2, (byte)num10 != 0, (MemberInfo)num);
					int num11 = 0;
					if (!(inspectorField2 == (UnityEngine.Object)num11))
					{
						int j = num;
						Type variableType2 = elementType;
						string empty = string.Empty;
						Getter getter2 = delegate
						{
							//Discarded unreachable code: IL_0022
							object value4 = ((InspectorField)this).m_value;
							int num18 = j;
							int num19 = 0;
							if (value4 != null)
							{
								int num20 = 0;
								object result = default(object);
								if (value4 != null)
								{
									return result;
								}
							}
							throw new InvalidCastException();
						};
						Setter setter2 = delegate
						{
							//Discarded unreachable code: IL_0026
							object value3 = ((InspectorField)this).m_value;
							int num16 = 0;
							if (value3 != null)
							{
								int num17 = j;
								base.Value = value3;
								return;
							}
							throw new InvalidCastException();
						};
						num12 = 0;
						inspectorField2.BindTo(variableType2, empty, getter2, setter2, (MemberInfo)num12);
						List<bool> list2 = elementsExpandedStates;
						if (num != 0)
						{
							int num13 = 0;
							if ((object)inspectorField2 != null)
							{
								int num14 = 0;
								if ((object)inspectorField2 != null)
								{
									int num15 = 0;
									if ((object)inspectorField2 != null)
									{
										goto IL_0202;
									}
								}
								throw new InvalidCastException();
							}
						}
						goto IL_0202;
					}
				}
				goto IL_023d;
			}
			throw new InvalidCastException();
			IL_023d:
			BoundInputField boundInputField = sizeInput;
			int length = Length;
			string text2 = default(string);
			boundInputField.Text = text2;
			((List<T>)(object)elementsExpandedStates).Clear();
			return;
			IL_0202:
			if ((((InspectorField)this).m_inspector.m_arrayIndicesStartAtOne ? 1 : 0) != num12)
			{
				num++;
			}
			string text3 = default(string);
			string text5 = (inspectorField2.NameRaw = text3 + ":");
			((List<T>)(object)elements).Add((T)inspectorField2);
			num++;
			goto IL_023d;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x880440", Offset = "0x87EE40", VA = "0x180880440", Slot = "18")]
		void IDropHandler.OnDrop(PointerEventData eventData)
		{
			//IL_0018: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_00b1: Expected I4, but got I8
			Type assignableType = elementType;
			UnityEngine.Object assignableObjectFromDraggedReferenceItem = RuntimeInspectorUtils.GetAssignableObjectFromDraggedReferenceItem(eventData, assignableType);
			int num = 0;
			if (!(assignableObjectFromDraggedReferenceItem != (UnityEngine.Object)num))
			{
				return;
			}
			int length = Length;
			length++;
			int num2 = 0;
			string input = default(string);
			bool flag = OnSizeChanged((BoundInputField)num2, input);
			if (!flag)
			{
				return;
			}
			object value = ((InspectorField)this).m_value;
			if (!isArray)
			{
				int num3 = 0;
				if (value == null)
				{
				}
				if (!flag)
				{
					throw new InvalidCastException();
				}
				int length2 = Length;
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				flag = (byte)((flag ? 1u : 0u) + (flag ? 1u : 0u)) != 0;
				num3 += 328;
			}
			if (value == null)
			{
			}
			int num5 = 0;
			if (value != null)
			{
				int num6 = Length - 1;
				base.Value = value;
				ulong num7 = default(ulong);
				base.IsExpanded = (byte)num7 != 0;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x880160", Offset = "0x87EB60", VA = "0x180880160")]
		private bool OnSizeInputBeingChanged(BoundInputField source, string input)
		{
			bool flag = default(bool);
			if (flag)
			{
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x87FBD0", Offset = "0x87E5D0", VA = "0x18087FBD0")]
		private unsafe bool OnSizeChanged(BoundInputField source, string input)
		{
			//IL_00d9: Expected O, but got I4
			int num = 0;
			object value;
			object templateElement = default(object);
			int length;
			if (int.TryParse(input, out *(int*)num))
			{
				length = Length;
				if (length != num)
				{
					value = ((InspectorField)this).m_value;
					if ((isArray ? 1 : 0) != num)
					{
						goto IL_00ff;
					}
					if (value == null)
					{
					}
					if (length != 0)
					{
						num -= length;
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						uint num3 = default(uint);
						if (num < (int)num3)
						{
							num += num;
							num++;
						}
						int num4 = length - 1;
						num4 += num4;
						num += 328;
						num4 += num4;
						num += 472;
						if (length == 0)
						{
							Type typeFromHandle = typeof(List<>);
							Type[] array = new Type[1];
							Type[] genericArguments = ((InspectorField)this).m_boundVariableType.GetGenericArguments();
							Type type = genericArguments[0];
							if ((object)type != null && genericArguments == null)
							{
								goto IL_015d;
							}
							array[0] = type;
							if (Activator.CreateInstance(typeFromHandle.MakeGenericType(array)) != null)
							{
								goto IL_00ec;
							}
						}
						templateElement = GetTemplateElement(num);
						uint num5 = default(uint);
						if (num < (int)num5)
						{
							num += num;
							num++;
						}
						num++;
						goto IL_00ec;
					}
					goto IL_015d;
				}
			}
			goto IL_0154;
			IL_00ec:
			if (num != 0)
			{
				templateElement += templateElement;
				num += 344;
				goto IL_00ff;
			}
			goto IL_015d;
			IL_0154:
			int num6 = 0;
			throw new IndexOutOfRangeException();
			IL_015d:
			throw new InvalidCastException();
			IL_00ff:
			if (value == null)
			{
			}
			int num7 = 0;
			if (value != null)
			{
				Array array2 = Array.CreateInstance(((InspectorField)this).m_boundVariableType.GetElementType(), num);
				if (value != null)
				{
				}
				if (length < num)
				{
					object templateElement2 = GetTemplateElement(value);
					if (templateElement2 != null)
					{
						array2.SetValue(templateElement2, length);
					}
					length++;
				}
				base.Value = array2;
				((InspectorField)this).m_inspector.RefreshDelayed();
				goto IL_0154;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x87F460", Offset = "0x87DE60", VA = "0x18087F460")]
		private object GetTemplateElement(object value)
		{
			Type typeFromHandle2 = default(Type);
			Array array2 = default(Array);
			object obj2 = default(object);
			while (true)
			{
				bool flag = isArray;
				int num = 0;
				if (!flag)
				{
					if (value == null)
					{
						goto IL_0029;
					}
					if ((object)typeof(Type).TypeHandle == null)
					{
						break;
					}
				}
				if (value != null)
				{
					int num2 = 0;
					if (value == null)
					{
						throw new InvalidCastException();
					}
				}
				goto IL_0029;
				IL_0029:
				Type boundVariableType = ((InspectorField)this).m_boundVariableType;
				if (flag)
				{
					Type type = boundVariableType.GetElementType();
				}
				Type type2 = boundVariableType.GetGenericArguments()[0];
				if (!type2.IsValueType)
				{
					if (!typeof(UnityEngine.Object).IsAssignableFrom(type2))
					{
						if (!type2.IsArray)
						{
							if (type2.IsGenericType)
							{
								Type genericTypeDefinition = type2.GetGenericTypeDefinition();
								Type typeFromHandle = typeof(List<>);
								if (((object)genericTypeDefinition).Equals((object)typeFromHandle))
								{
									typeFromHandle2 = typeof(List<>);
									Type[] array = new Type[1];
									if (array == null)
									{
										continue;
									}
									array[0] = type2;
									Type type3 = typeFromHandle2.MakeGenericType(array);
								}
							}
							object obj = type2.Instantiate();
						}
						int length = 0;
						array2 = Array.CreateInstance(type2, length);
					}
					if ((IntPtr)(isArray ? 1 : 0) != (IntPtr)typeFromHandle2)
					{
						if (value != null && (long)(IntPtr)array2 > 0L)
						{
							int num3 = 0;
						}
						if ((IntPtr)(isArray ? 1 : 0) != (IntPtr)typeFromHandle2)
						{
							continue;
						}
					}
					if (num == 0 || (long)(IntPtr)obj2 <= 0L)
					{
						continue;
					}
				}
				if ((IntPtr)(isArray ? 1 : 0) != (IntPtr)typeFromHandle2)
				{
					if (value != null)
					{
					}
					if ((IntPtr)(isArray ? 1 : 0) != (IntPtr)typeFromHandle2)
					{
						goto IL_0139;
					}
				}
				if (num == 0)
				{
				}
				goto IL_0139;
				IL_0139:
				return Activator.CreateInstance(type2);
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8806F0", Offset = "0x87F0F0", VA = "0x1808806F0")]
		public ArrayField()
		{
		}
	}
}
