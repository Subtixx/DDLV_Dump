using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public static class RuntimeInspectorUtils
	{
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private static readonly Dictionary<Type, MemberInfo[]> typeToVariables;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static readonly Dictionary<Type, ExposedMethod[]> typeToExposedMethods;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly HashSet<Type> commonSerializableTypes;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly List<MemberInfo> validVariablesList;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly List<Type> typesToSearchForVariablesList;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly List<string> propertyNamesInVariablesList;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly List<ExposedMethod> exposedMethodsList;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private static readonly List<ExposedExtensionMethodHolder> exposedExtensionMethods;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly HashSet<Transform> IgnoredTransformsInHierarchy;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private static Canvas popupCanvas;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private static Canvas popupReferenceCanvas;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private static Tooltip tooltipPopup;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private static readonly Stack<DraggedReferenceItem> draggedReferenceItemsPool;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		internal static readonly StringBuilder stringBuilder;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public static Type ExposedExtensionMethodsHolder
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0xE40310", Offset = "0xE3ED10", VA = "0x180E40310")]
			set
			{
				GetExposedExtensionMethods(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE3E0C0", Offset = "0xE3CAC0", VA = "0x180E3E0C0")]
		public static bool IsNull(this object obj)
		{
			if (obj != null)
			{
				int num = 0;
				if (obj == null)
				{
				}
			}
			return obj == null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE3EAB0", Offset = "0xE3D4B0", VA = "0x180E3EAB0")]
		public static string ToTitleCase(this string str)
		{
			//Discarded unreachable code: IL_0129
			if (str != null)
			{
				int stringLength = str.m_stringLength;
				if (stringLength != 0)
				{
					int num = 0;
					if (stringLength > 1)
					{
						char c = str[1];
					}
					StringBuilder stringBuilder = RuntimeInspectorUtils.stringBuilder;
					int num3 = (stringBuilder.Length = 0);
					if (num < str.m_stringLength)
					{
						char c2 = str[num];
						if (!char.IsUpper(c2))
						{
							int num4 = default(int);
							if (!char.IsNumber(c2))
							{
								if (1L > 1L)
								{
								}
								if (RuntimeInspectorUtils.stringBuilder.Length > 0)
								{
									StringBuilder stringBuilder2 = RuntimeInspectorUtils.stringBuilder;
								}
								StringBuilder stringBuilder3 = RuntimeInspectorUtils.stringBuilder;
								c2 = char.ToUpper(c2);
								StringBuilder stringBuilder4 = stringBuilder3.Append(c2);
								num4 = 0;
								num++;
							}
							if (num4 != 2 && RuntimeInspectorUtils.stringBuilder.Length > 0)
							{
								StringBuilder stringBuilder5 = RuntimeInspectorUtils.stringBuilder;
							}
							StringBuilder stringBuilder6 = RuntimeInspectorUtils.stringBuilder.Append(c2);
							num++;
							num++;
						}
						if (str.m_stringLength > 1 && char.IsLower(str[1]) && RuntimeInspectorUtils.stringBuilder.Length > 0)
						{
							StringBuilder stringBuilder7 = RuntimeInspectorUtils.stringBuilder;
						}
						StringBuilder stringBuilder8 = RuntimeInspectorUtils.stringBuilder.Append(c2);
						num++;
					}
					if (RuntimeInspectorUtils.stringBuilder.Length != 0)
					{
						return RuntimeInspectorUtils.stringBuilder.ToString();
					}
				}
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE3D8F0", Offset = "0xE3C2F0", VA = "0x180E3D8F0")]
		public static string GetName(this UnityEngine.Object obj)
		{
			//Discarded unreachable code: IL_0016
			if ((bool)obj)
			{
				return obj.name;
			}
			return "None";
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE3D610", Offset = "0xE3C010", VA = "0x180E3D610")]
		public static string GetNameWithType(this object obj, [Optional] Type defaultType)
		{
			//IL_0059: Expected O, but got I4
			if (obj != null)
			{
				int num = 0;
				if (obj == null)
				{
				}
			}
			string text = default(string);
			if (obj != null)
			{
				int num2 = 0;
				if (obj != null)
				{
					int num3 = 0;
					if (obj != null)
					{
						int num4 = 0;
						if (obj != null)
						{
							string name = obj.GetType().Name;
							return text + " (" + name + ")";
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				Type type = default(Type);
				Guid gUID = type.GUID;
			}
			int num5 = 0;
			string result = default(string);
			if (!((object)text).Equals((object)num5))
			{
				return result;
			}
			return "None";
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE3D980", Offset = "0xE3C380", VA = "0x180E3D980")]
		public static Texture GetTexture(this UnityEngine.Object obj)
		{
			if ((bool)obj && (object)obj != null)
			{
				int num = 0;
				if ((object)obj == null)
				{
					if ((object)obj == null)
					{
						goto IL_0023;
					}
					if ((object)obj == null)
					{
						goto IL_0026;
					}
					int num2 = 0;
				}
				int num3 = 0;
				if ((object)obj == null)
				{
					throw new InvalidCastException();
				}
			}
			goto IL_0023;
			IL_0023:
			int num4 = 0;
			goto IL_0026;
			IL_0026:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE3EA40", Offset = "0xE3D440", VA = "0x180E3EA40")]
		public static Color Tint(this Color color, float tintAmount)
		{
			return color;
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE3E790", Offset = "0xE3D190", VA = "0x180E3E790")]
		public static void ShowTooltip(string tooltip, PointerEventData pointer, [Optional] UISkin skin, [Optional] Canvas referenceCanvas)
		{
			//Discarded unreachable code: IL_0066
			//IL_0024: Expected I4, but got I8
			bool flag = CreatePopupCanvas(referenceCanvas);
			if ((bool)tooltipPopup)
			{
				ulong num = default(ulong);
				tooltipPopup.gameObject.SetActive((byte)num != 0);
				if (!flag)
				{
					goto IL_0045;
				}
			}
			typeToVariables = (Dictionary<Type, MemberInfo[]>)(object)UnityEngine.Object.FindObjectOfType<Tooltip>();
			Tooltip tooltip2 = tooltipPopup;
			Canvas canvas = popupCanvas;
			tooltip2.Initialize(canvas);
			goto IL_0045;
			IL_0045:
			if ((bool)skin)
			{
				tooltipPopup.Skin = skin;
			}
			tooltipPopup.SetContent(tooltip, pointer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDE0", Offset = "0xE3C7E0", VA = "0x180E3DDE0")]
		public static void HideTooltip()
		{
			//Discarded unreachable code: IL_0035
			if ((bool)tooltipPopup && tooltipPopup.gameObject.activeSelf)
			{
				GameObject gameObject = tooltipPopup.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE3B320", Offset = "0xE39D20", VA = "0x180E3B320")]
		public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object reference, GameObject prefab, PointerEventData draggingPointer, [Optional] UISkin skin, [Optional] Canvas referenceCanvas)
		{
			//Discarded unreachable code: IL_0089
			//IL_000f: Expected O, but got I4
			Stack<DraggedReferenceItem> stack = draggedReferenceItemsPool;
			int num = 0;
			if (!(prefab != (UnityEngine.Object)num))
			{
				DraggedReferenceItem draggedReferenceItem = UnityEngine.Object.FindObjectOfType<DraggedReferenceItem>();
			}
			Transform transform = popupCanvas.transform;
			int worldPositionStays = 0;
			UnityEngine.Object reference2 = UnityEngine.Object.Instantiate(prefab, transform, (byte)worldPositionStays != 0).GetComponent<DraggedReferenceItem>().m_reference;
			DraggedReferenceItem draggedReferenceItem2 = default(DraggedReferenceItem);
			draggedReferenceItem2.gameObject.SetActive(value: true);
			bool flag = default(bool);
			if (flag)
			{
				Canvas canvas = popupCanvas;
				draggedReferenceItem2.Initialize(canvas);
			}
			if ((bool)skin)
			{
				draggedReferenceItem2.Skin = skin;
			}
			draggedReferenceItem2.SetContent(reference, draggingPointer);
			draggingPointer.dragging = true;
			draggingPointer.eligibleForClick = false;
			return draggedReferenceItem2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE3E6E0", Offset = "0xE3D0E0", VA = "0x180E3E6E0")]
		public static void PoolDraggedReferenceItem(DraggedReferenceItem item)
		{
			//Discarded unreachable code: IL_001c
			GameObject gameObject = item.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			((Stack<T>)(object)draggedReferenceItemsPool).Push((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE3C780", Offset = "0xE3B180", VA = "0x180E3C780")]
		public static UnityEngine.Object GetAssignableObjectFromDraggedReferenceItem(PointerEventData draggingPointer, Type assignableType)
		{
			DraggedReferenceItem component;
			if ((bool)draggingPointer.pointerDrag)
			{
				component = draggingPointer.pointerDrag.GetComponent<DraggedReferenceItem>();
				if ((bool)component)
				{
					bool flag = component.m_reference;
					Type type = component.m_reference.GetType();
					if (assignableType.IsAssignableFrom(type))
					{
						goto IL_00d8;
					}
					if (typeof(Component).IsAssignableFrom(assignableType))
					{
						goto IL_0097;
					}
					if (typeof(GameObject).IsAssignableFrom(assignableType))
					{
						UnityEngine.Object reference = component.m_reference;
						if ((object)reference != null)
						{
							int num = 0;
							if ((object)reference != null)
							{
								int num2 = 0;
								if ((object)reference != null)
								{
									int num3 = 0;
									if ((object)reference != null)
									{
										goto IL_0097;
									}
								}
								throw new InvalidCastException();
							}
						}
					}
				}
			}
			goto IL_00df;
			IL_00c9:
			int num4 = default(int);
			while (num4 == 0)
			{
			}
			while (num4 == 0)
			{
			}
			if (num4 == 0)
			{
				throw new InvalidCastException();
			}
			goto IL_00d8;
			IL_00bf:
			Component component2 = default(Component);
			if ((bool)component2)
			{
				goto IL_00c9;
			}
			goto IL_00df;
			IL_00d8:
			return component.m_reference;
			IL_00df:
			int num5 = 0;
			throw new NullReferenceException();
			IL_0097:
			UnityEngine.Object reference2 = component.m_reference;
			if ((object)reference2 == null)
			{
				goto IL_00bf;
			}
			int num6 = 0;
			if ((object)reference2 != null)
			{
				int num7 = 0;
				if ((object)reference2 != null)
				{
					int num8 = 0;
					if ((object)reference2 != null)
					{
						num4 = 0;
						goto IL_00bf;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_00c9;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE3AE20", Offset = "0xE39820", VA = "0x180E3AE20")]
		public static void CopyValuesFrom(this Canvas canvas, Canvas referenceCanvas)
		{
			int num = 0;
			bool flag = canvas;
			if (!flag || !referenceCanvas)
			{
				return;
			}
			bool flag2 = (canvas.pixelPerfect = referenceCanvas.pixelPerfect);
			RenderMode renderMode = referenceCanvas.renderMode;
			int num2 = (canvas.sortingLayerID = referenceCanvas.sortingLayerID);
			int num3 = (canvas.sortingOrder = referenceCanvas.sortingOrder);
			if (referenceCanvas.renderMode == RenderMode.ScreenSpaceCamera)
			{
				Camera camera = (canvas.worldCamera = referenceCanvas.worldCamera);
				float num5 = (canvas.planeDistance = referenceCanvas.planeDistance * 0.75f);
				CanvasScaler component = canvas.GetComponent<CanvasScaler>();
				CanvasScaler component2 = referenceCanvas.GetComponent<CanvasScaler>();
				if (!component || !component2)
				{
					return;
				}
				float num6 = (component.m_ReferencePixelsPerUnit = component2.m_ReferencePixelsPerUnit);
				if (referenceCanvas.renderMode != RenderMode.WorldSpace)
				{
					CanvasScaler.ScaleMode scaleMode = (component.m_UiScaleMode = component2.m_UiScaleMode);
					CanvasScaler.ScaleMode uiScaleMode = component2.m_UiScaleMode;
					if (uiScaleMode != 0)
					{
						switch (uiScaleMode)
						{
						case CanvasScaler.ScaleMode.ScaleWithScreenSize:
						{
							CanvasScaler.Unit unit = (component.m_PhysicalUnit = component2.m_PhysicalUnit);
							float num7 = (component.m_FallbackScreenDPI = component2.m_FallbackScreenDPI);
							float num8 = (component.defaultSpriteDPI = component2.m_DefaultSpriteDPI);
							return;
						}
						default:
							return;
						case CanvasScaler.ScaleMode.ConstantPixelSize:
							break;
						}
					}
				}
			}
			else
			{
				while (!flag)
				{
				}
				Camera camera2 = (canvas.worldCamera = referenceCanvas.worldCamera);
				if ((object)referenceCanvas.transform == null)
				{
					throw new InvalidCastException();
				}
				int num9 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform = canvas.transform;
				Transform transform2 = canvas.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE3B630", Offset = "0xE3A030", VA = "0x180E3B630")]
		private unsafe static bool CreatePopupCanvas(Canvas referenceCanvas)
		{
			//IL_0070: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0148: Expected I4, but got I8
			bool flag = popupCanvas;
			if (!popupCanvas)
			{
				typeToVariables = (Dictionary<Type, MemberInfo[]>)(object)new GameObject("PopupCanvas").AddComponent<Canvas>();
				CanvasScaler canvasScaler = popupCanvas.gameObject.AddComponent<CanvasScaler>();
				if (!referenceCanvas)
				{
					Canvas canvas = popupCanvas;
					int num = (int)(canvas.renderMode = RenderMode.ScreenSpaceOverlay);
					uint sortingOrder = default(uint);
					popupCanvas.sortingOrder = (int)sortingOrder;
				}
				int num2 = default(int);
				UnityAction<Scene, LoadSceneMode> unityAction = (UnityAction<Scene, LoadSceneMode>)(object)new UnityAction<T0, T1>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Scene, LoadSceneMode, void>*/)(&OnSceneLoaded));
				num2 = 0;
				SceneManager.remove_sceneLoaded((UnityAction<, >)(object)unityAction);
				int num3 = default(int);
				UnityAction<Scene, LoadSceneMode> unityAction2 = (UnityAction<Scene, LoadSceneMode>)(object)new UnityAction<T0, T1>(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Scene, LoadSceneMode, void>*/)(&OnSceneLoaded));
				num3 = 0;
				SceneManager.add_sceneLoaded((UnityAction<, >)(object)unityAction2);
				UnityEngine.Object.DontDestroyOnLoad(popupCanvas.gameObject);
				Canvas canvas2 = popupCanvas;
				HashSet<Transform> ignoredTransformsInHierarchy = IgnoredTransformsInHierarchy;
				Transform transform = canvas2.transform;
				bool flag2 = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Add((T)transform);
			}
			if ((bool)referenceCanvas)
			{
				Canvas canvas3 = popupReferenceCanvas;
				if (referenceCanvas != canvas3)
				{
					typeToVariables = (Dictionary<Type, MemberInfo[]>)(object)referenceCanvas;
					popupCanvas.CopyValuesFrom(referenceCanvas);
					Canvas canvas4 = popupCanvas;
					int b = 0;
					int sortingOrder2 = referenceCanvas.sortingOrder;
					uint a = default(uint);
					int num5 = (canvas4.sortingOrder = Mathf.Max((int)a, b));
				}
			}
			ulong num6 = default(ulong);
			if (num6 != 0)
			{
				GameObject gameObject = popupCanvas.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				ulong num7 = default(ulong);
				popupCanvas.gameObject.SetActive((byte)num7 != 0);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE3E580", Offset = "0xE3CF80", VA = "0x180E3E580")]
		private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
			//Discarded unreachable code: IL_0031
			if ((bool)popupCanvas)
			{
				Transform transform = popupCanvas.transform;
				int childCount = transform.childCount;
				UnityEngine.Object.Destroy(transform.GetChild(childCount).gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE3E150", Offset = "0xE3CB50", VA = "0x180E3E150")]
		public static bool IsPointerValid(this PointerEventData eventData)
		{
			//IL_0039: Invalid comparison between F4 and I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int touchCount = Input.touchCount;
			Touch touch = default(Touch);
			float y = touch.m_RawPosition.y;
			int tapCount = touch.m_TapCount;
			float maximumPossiblePressure = touch.m_maximumPossiblePressure;
			if (touch.m_AzimuthAngle != (float)eventData.pointerId)
			{
				return Input.GetMouseButton((int)eventData.button);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE3BBC0", Offset = "0xE3A5C0", VA = "0x180E3BBC0")]
		public static MemberInfo[] GetAllVariables(this Type type)
		{
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			Dictionary<Type, MemberInfo[]> dictionary = typeToVariables;
			bool flag = default(bool);
			int num3;
			if (!flag)
			{
				((List<T>)(object)validVariablesList).Clear();
				((List<T>)(object)typesToSearchForVariablesList).Clear();
				if ((object)typeof(object) != null)
				{
					Dictionary<Type, MemberInfo[]> dictionary2 = typeToVariables;
					bool flag2 = default(bool);
					if (!flag2)
					{
						((List<T>)(object)typesToSearchForVariablesList).Add((T)type);
						Type baseType = type.BaseType;
					}
					List<MemberInfo> list = validVariablesList;
				}
				int size = ((List<>)(object)typesToSearchForVariablesList)._size;
				List<Type> list2 = typesToSearchForVariablesList;
				((List<T>)(object)propertyNamesInVariablesList).Clear();
				Dictionary<Type, MemberInfo[]> dictionary3 = typeToVariables;
				int num = 0;
				Dictionary<Type, MemberInfo[]> dictionary4 = typeToVariables;
				bool flag3 = default(bool);
				if (!flag3)
				{
					Dictionary<Type, MemberInfo[]> dictionary5 = typeToVariables;
					int num2 = 0;
					bool flag4 = default(bool);
					if (!flag4)
					{
						Dictionary<Type, MemberInfo[]> dictionary6 = typeToVariables;
						Dictionary<Type, MemberInfo[]> dictionary7 = typeToVariables;
						bool flag5 = default(bool);
						bool flag6 = default(bool);
						bool flag7 = default(bool);
						bool flag8 = default(bool);
						if (flag5 && !flag6 && !flag7 && !flag8)
						{
							List<string> list3 = propertyNamesInVariablesList;
							Dictionary<Type, MemberInfo[]> dictionary8 = typeToVariables;
							List<MemberInfo> list4 = validVariablesList;
						}
					}
				}
				num++;
				num3 = 0;
				bool flag9 = default(bool);
				bool flag10 = default(bool);
				bool flag11 = default(bool);
				bool flag12 = default(bool);
				bool flag13 = default(bool);
				bool flag14 = default(bool);
				bool flag15 = default(bool);
				if (!flag9 && !flag10 && flag11 && !flag12 && !flag13 && !flag14 && !flag15)
				{
					if ((flag14 ? 1 : 0) > 16777216)
					{
						if ((flag14 ? 1 : 0) > (true ? 1 : 0))
						{
						}
						int num4 = 0;
					}
					List<string> list5 = propertyNamesInVariablesList;
					List<string> list6 = propertyNamesInVariablesList;
					list6 = (List<string>)(list6 - 16777216);
					int num5 = 0;
					char c = default(char);
					char c2 = default(char);
					if (c == c2 || c2 == '\0' || c2 == '\0')
					{
						HashSet<Type> hashSet = commonSerializableTypes;
						HashSet<Type> hashSet2 = default(HashSet<Type>);
						if (16777216L < (long)(IntPtr)hashSet)
						{
							char c3 = default(char);
							char c4 = default(char);
							if (c3 == c4)
							{
							}
							hashSet2 = commonSerializableTypes;
						}
						if ((IntPtr)16777216 == (IntPtr)hashSet2)
						{
							goto IL_0171;
						}
					}
					List<MemberInfo> list7 = validVariablesList;
				}
				goto IL_0171;
			}
			throw new NullReferenceException();
			IL_0171:
			num3++;
			List<MemberInfo> list8 = validVariablesList;
			MemberInfo[] array = (MemberInfo[])(object)((List<T>)(object)validVariablesList).ToArray();
			int num6 = 0;
			Dictionary<Type, MemberInfo[]> dictionary9 = typeToVariables;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE3CFE0", Offset = "0xE3B9E0", VA = "0x180E3CFE0")]
		public static ExposedMethod[] GetExposedMethods(this Type type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE3E2B0", Offset = "0xE3CCB0", VA = "0x180E3E2B0")]
		private static bool IsSerializable(this Type type)
		{
			//Discarded unreachable code: IL_009e
			while (!type.IsPrimitive && !((HashSet<T>)(object)commonSerializableTypes).Contains((T)type) && !type.IsEnum && !typeof(UnityEngine.Object).IsAssignableFrom(type))
			{
				if (!type.IsArray)
				{
					if (!type.IsGenericType)
					{
						Type typeFromHandle = typeof(SerializableAttribute);
						int inherit = 0;
						if (Attribute.IsDefined(type, typeFromHandle, (byte)inherit != 0))
						{
							break;
						}
						int num = 0;
					}
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					if ((object)typeof(List<>) != null)
					{
						continue;
					}
					Type[] genericArguments = type.GetGenericArguments();
				}
				if (type.GetArrayRank() == 1)
				{
					return type.GetElementType().IsSerializable();
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x1B20280", Offset = "0x1B1EC80", VA = "0x181B20280")]
		public static bool HasAttribute<T>(this MemberInfo P_0) where T : Attribute
		{
			Type attributeType = default(Type);
			return Attribute.IsDefined(P_0, attributeType, inherit: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1B20100", Offset = "0x1B1EB00", VA = "0x181B20100")]
		public static T GetAttribute<T>(this MemberInfo P_0) where T : Attribute
		{
			Type typeFromHandle;
			do
			{
				typeFromHandle = typeof(Type);
			}
			while (Attribute.GetCustomAttribute(P_0, typeFromHandle, inherit: true) != null);
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x1B201C0", Offset = "0x1B1EBC0", VA = "0x181B201C0")]
		public static T[] GetAttributes<T>(this MemberInfo variable) where T : Attribute
		{
			Type typeFromHandle;
			do
			{
				typeFromHandle = typeof(Type);
			}
			while (Attribute.GetCustomAttributes(variable, typeFromHandle, inherit: true) != null);
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE3DF30", Offset = "0xE3C930", VA = "0x180E3DF30")]
		public static object Instantiate(this Type type)
		{
			//Discarded unreachable code: IL_0039
			if (!typeof(ScriptableObject).IsAssignableFrom(type))
			{
				int num = 0;
				ConstructorInfo constructorInfo = default(ConstructorInfo);
				if ((object)constructorInfo == null)
				{
					object uninitializedObject = FormatterServices.GetUninitializedObject(type);
				}
				object obj = Activator.CreateInstance(type, nonPublic: true);
			}
			ScriptableObject scriptableObject = ScriptableObject.CreateInstance(type);
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE3DAC0", Offset = "0xE3C4C0", VA = "0x180E3DAC0")]
		public static Type GetType(string typeName)
		{
			//Discarded unreachable code: IL_00dd, IL_00e3, IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d
			//IL_0057: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			if ("." == null)
			{
				if (!typeName.Contains("."))
				{
					Assembly assembly = Assembly.Load("UnityEngine");
					string name = "UnityEngine." + typeName;
					if ((object)assembly.GetType(name) == null)
					{
						goto IL_0076;
					}
				}
				int startIndex = 0;
				int length = default(int);
				Assembly assembly2 = Assembly.Load(typeName.Substring(startIndex, length));
				int num = 0;
				if (!(assembly2 == (Assembly)num))
				{
					Type type = assembly2.GetType(typeName);
					int num2 = 0;
					if (!(type != (Type)num2))
					{
						goto IL_0076;
					}
				}
				goto IL_00d4;
			}
			goto IL_00d7;
			IL_00d4:
			int num3 = 0;
			goto IL_00d7;
			IL_00d7:
			throw new NullReferenceException();
			IL_0076:
			int num4 = 0;
			Assembly[] assemblies = AppDomain.getCurDomain().GetAssemblies();
			int num5 = 0;
			if (num5 < assemblies.Length)
			{
				Type[] types = assemblies[num5].GetTypes();
				int num6 = 0;
				if (num6 < types.Length && !string.Equals(types[num6].Name, typeName))
				{
					num6++;
				}
				num5++;
			}
			goto IL_00d4;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE3CC10", Offset = "0xE3B610", VA = "0x180E3CC10")]
		private static void GetExposedExtensionMethods(Type type)
		{
			//Discarded unreachable code: IL_00ae
			//IL_00a9: Expected O, but got I4
			((List<T>)(object)exposedExtensionMethods).Clear();
			((Dictionary<TKey, TValue>)(object)typeToExposedMethods).Clear();
			MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			int num = 0;
			int length = methods.Length;
			if (num >= length)
			{
				return;
			}
			if (methods[num].HasAttribute<RuntimeInspectorButtonAttribute>())
			{
				ParameterInfo[] parameters = methods[num].GetParameters();
				if (parameters.Length == 1)
				{
					RuntimeInspectorButtonAttribute attribute = methods[num].GetAttribute<RuntimeInspectorButtonAttribute>();
					Type parameterType = parameters[0].ParameterType;
					if ((attribute.m_isInitializer ? 1 : 0) != num)
					{
						Type returnType = methods[num].ReturnType;
						if (!parameterType.IsAssignableFrom(returnType))
						{
							goto IL_00a9;
						}
					}
					List<ExposedExtensionMethodHolder> list = exposedExtensionMethods;
					int num2 = 0;
					int num3 = 0;
					((List<T>)(object)list).Add((T)num2);
				}
			}
			goto IL_00a9;
			IL_00a9:
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE3F030", Offset = "0xE3DA30", VA = "0x180E3F030")]
		static RuntimeInspectorUtils()
		{
			//Discarded unreachable code: IL_0018
			//IL_07fa: Expected O, but got I4
			//IL_0801: Expected O, but got I4
			uint capacity = default(uint);
			Dictionary<Type, MemberInfo[]> dictionary = (Dictionary<Type, MemberInfo[]>)(object)new Dictionary<TKey, TValue>((int)capacity);
			Type typeFromHandle = typeof(object);
			throw new NullReferenceException();
		}
	}
}
