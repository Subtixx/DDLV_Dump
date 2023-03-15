using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class HierarchyDragDropListener : MonoBehaviour, IDropHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private const float POINTER_VALIDATE_INTERVAL = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		[SerializeField]
		private float siblingIndexModificationArea = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		[SerializeField]
		private float scrollableArea = 75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private float _overScrollableArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[SerializeField]
		private float scrollSpeed = 75f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[SerializeField]
		private bool canDropParentOnChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		[SerializeField]
		private bool canAddObjectsToPseudoScenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		[SerializeField]
		[Header("Internal Variables")]
		private RuntimeHierarchy hierarchy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		[SerializeField]
		private Image dragDropTargetVisualization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private PointerEventData pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private Camera worldCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private float pointerLastYPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private float nextPointerValidation;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xAE6470", Offset = "0xAE4E70", VA = "0x180AE6470")]
		private void Start()
		{
			//IL_0018: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				rectTransform = (RectTransform)num;
				Canvas canvas = (this.canvas = hierarchy.GetComponentInParent<Canvas>());
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xAE6460", Offset = "0xAE4E60", VA = "0x180AE6460")]
		private void OnRectTransformDimensionsChange()
		{
			height = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xAE7890", Offset = "0xAE6290", VA = "0x180AE7890")]
		private unsafe void Update()
		{
			//IL_004e: Expected O, but got I4
			//IL_00a2: Expected F4, but got I4
			//IL_00d5: Expected O, but got F4
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected F4, but got Unknown
			//IL_00e9: Invalid comparison between I4 and F4
			//IL_018f: Expected O, but got I4
			//IL_01be: Expected O, but got I4
			//IL_01da: Expected O, but got F4
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected F4, but got Unknown
			//IL_021f: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			if ((IntPtr)pointer == (IntPtr)num)
			{
				return;
			}
			float num3 = nextPointerValidation;
			int num4 = 0;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int num5 = 0;
			nextPointerValidation = num3;
			PointerEventData eventData = pointer;
			nextPointerValidation = 5f;
			if (!eventData.IsPointerValid())
			{
				pointer = (PointerEventData)num;
			}
			PointerEventData pointerEventData = pointer;
			RectTransform rect = this.rectTransform;
			Vector2 _003Cposition_003Ek__BackingField = pointerEventData.position;
			float y = pointerEventData.position.y;
			Camera cam = worldCamera;
			bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, _003Cposition_003Ek__BackingField, cam, out *(Vector2*)num);
			if (!flag || !flag)
			{
				return;
			}
			pointerLastYPos = 0f;
			RectTransform rectTransform = this.rectTransform;
			float num6 = pointerLastYPos;
			float num7 = scrollableArea;
			if (!(num7 > num6))
			{
				float num8 = height;
				if (num6 <= num8)
				{
					goto IL_00d8;
				}
			}
			float overScrollableArea = ((HierarchyDragDropListener)num7)._overScrollableArea;
			float num9 = /*Error near IL_00d6: Stack underflow*/* overScrollableArea;
			goto IL_00d8;
			IL_00d8:
			Vector2 anchoredPosition = content.anchoredPosition;
			if (!((float)num5 > y))
			{
				UISkin skin = ((SkinnedWindow)hierarchy).m_skin;
				if (dragDropTargetVisualization.gameObject.activeSelf)
				{
					GameObject gameObject = dragDropTargetVisualization.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					GameObject gameObject2 = default(GameObject);
					if (!gameObject2.activeSelf)
					{
						dragDropTargetVisualization.rectTransform.SetAsLastSibling();
						dragDropTargetVisualization.gameObject.SetActive(value: true);
					}
					UISkin skin2 = ((SkinnedWindow)hierarchy).m_skin;
					num7 = num6;
					float num10 = siblingIndexModificationArea;
					Image image = dragDropTargetVisualization;
					if (!(num10 > y))
					{
						if (!(y > num6))
						{
							image.rectTransform.anchoredPosition = (Vector2)num;
							RectTransform rectTransform2 = dragDropTargetVisualization.rectTransform;
							UISkin skin3 = ((SkinnedWindow)hierarchy).m_skin;
						}
						UISkin skin4 = ((SkinnedWindow)hierarchy).m_skin;
					}
					RectTransform rectTransform3 = default(RectTransform);
					rectTransform3.anchoredPosition = (Vector2)num;
					RectTransform rectTransform4 = dragDropTargetVisualization.rectTransform;
				}
				RuntimeHierarchy runtimeHierarchy = hierarchy;
				float num11 = ((HierarchyDragDropListener)num9).scrollSpeed;
				float num12 = (runtimeHierarchy.m_autoScrollSpeed = /*Error near IL_01db: Stack underflow*/* num11);
				return;
			}
			if (dragDropTargetVisualization.gameObject.activeSelf)
			{
				GameObject gameObject3 = dragDropTargetVisualization.gameObject;
				int active2 = 0;
				gameObject3.SetActive((byte)active2 != 0);
			}
			hierarchy.m_autoScrollSpeed = num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xAE6520", Offset = "0xAE4F20", VA = "0x180AE6520", Slot = "4")]
		void IDropHandler.OnDrop(PointerEventData eventData)
		{
			//IL_00a2: Expected I4, but got F4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected F4, but got Unknown
			//IL_00e5: Expected I4, but got F4
			//IL_00fe: Invalid comparison between F4 and I4
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected F4, but got Unknown
			//IL_010f: Expected I4, but got F4
			//IL_0310: Expected O, but got I4
			uint num2 = default(uint);
			uint num8 = default(uint);
			uint num14 = default(uint);
			int num24 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			GameObject gameObject = default(GameObject);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag3 = default(bool);
			bool flag7 = default(bool);
			int num33 = default(int);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			GameObject gameObject2 = default(GameObject);
			bool flag11 = default(bool);
			GameObject go = default(GameObject);
			int num44 = default(int);
			bool flag12 = default(bool);
			int num23 = default(int);
			int num53 = default(int);
			while (true)
			{
				int num = 0;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				RuntimeHierarchy runtimeHierarchy = hierarchy;
				if ((runtimeHierarchy.m_canReorganizeItems ? 1 : 0) == num || (runtimeHierarchy.m_isInSearchMode ? 1 : 0) != num)
				{
					return;
				}
				Type typeFromHandle = typeof(Transform);
				UnityEngine.Object @object = RuntimeInspectorUtils.GetAssignableObjectFromDraggedReferenceItem(eventData, typeFromHandle);
				if ((object)@object == null)
				{
					@object = (UnityEngine.Object)(object)((object)@object + (object)@object);
				}
				int num3 = 0;
				if (!@object)
				{
					return;
				}
				RectTransform rectTransform = content;
				float num4 = pointerLastYPos;
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				RuntimeHierarchy runtimeHierarchy2 = hierarchy;
				UISkin skin = ((SkinnedWindow)runtimeHierarchy2).m_skin;
				float x = anchoredPosition.x;
				float x2 = anchoredPosition.x;
				HierarchyData dataAt = runtimeHierarchy2.GetDataAt((int)x);
				HierarchyData dataAt2;
				if (dataAt != null)
				{
					RuntimeHierarchy runtimeHierarchy3 = hierarchy;
					UISkin skin2 = ((SkinnedWindow)runtimeHierarchy3).m_skin;
					float num5 = siblingIndexModificationArea;
					int num6 = 0;
					while (dataAt != null)
					{
					}
					if (!(x2 <= 0f))
					{
						float num7 = x2 - 1;
						if (runtimeHierarchy3.GetDataAt((int)num7) == null)
						{
							continue;
						}
					}
					while ((int)num8 <= 0)
					{
					}
					int totalItemCount = runtimeHierarchy3.totalItemCount;
					while (x2 >= (float)totalItemCount)
					{
					}
					float num9 = x2 + 1;
					dataAt2 = runtimeHierarchy3.GetDataAt((int)num9);
					while (dataAt2 == null)
					{
					}
					int num10 = 0;
					while (dataAt2 == null)
					{
					}
					int num11 = 0;
					if (dataAt2 != null)
					{
						int num12 = 0;
						if (dataAt2 != null)
						{
							int num13 = 0;
							if (dataAt2 != null)
							{
								Transform boundTransform = dataAt2.BoundTransform;
								if (!boundTransform || @object == boundTransform)
								{
									return;
								}
								if (num14 != 0)
								{
									if ((int)num14 <= 0 || dataAt2.m_height > 1)
									{
									}
									if (dataAt2.m_depth == 1)
									{
										int num15 = 0;
										HierarchyDataRoot root = dataAt2.Root;
										if (root != null)
										{
											int num16 = 0;
											if (root != null)
											{
												HierarchyDataRoot root2 = dataAt2.Root;
												int num17 = 0;
												if (root2 != null)
												{
													int num18 = 0;
													if (root2 != null)
													{
														int num19 = 0;
														int num20 = root2.IndexOf(boundTransform);
														int num21 = 0;
														if (num19 != 0)
														{
															int num22 = 0;
															if (num19 != 0)
															{
																goto IL_01e3;
															}
														}
														throw new InvalidCastException();
													}
													goto IL_0351;
												}
												throw new InvalidCastException();
											}
										}
									}
									goto IL_01e3;
								}
								goto IL_023f;
							}
						}
						throw new InvalidCastException();
					}
					goto IL_02d7;
				}
				goto IL_0341;
				IL_01e3:
				num24 = num23 + 1;
				num24 = num23;
				if (flag)
				{
					if (flag2)
					{
						goto IL_0239;
					}
					int num25 = 0;
					HierarchyDataRoot root3 = dataAt2.Root;
					if (root3 != null)
					{
						int num26 = 0;
						if (root3 != null)
						{
							HierarchyDataRoot root4 = dataAt2.Root;
							int num27 = 0;
							if (root4 != null)
							{
								int num28 = 0;
								if (root4 != null)
								{
									if ((object)gameObject.scene != null)
									{
										goto IL_0239;
									}
									goto IL_023f;
								}
							}
							throw new InvalidCastException();
						}
					}
				}
				goto IL_023f;
				IL_0349:
				RuntimeHierarchy runtimeHierarchy4 = hierarchy;
				goto IL_0351;
				IL_023f:
				if (flag3)
				{
					if ((canDropParentOnChild ? 1 : 0) != num)
					{
						if (flag4)
						{
							flag3 = flag4;
							if (!flag5)
							{
							}
						}
						flag3 = flag5;
						if (!flag6)
						{
							goto IL_02b2;
						}
						flag3 = flag6;
						if (flag7)
						{
							int num29 = 0;
							HierarchyDataRoot root5 = dataAt2.Root;
							if (root5 != null)
							{
								int num30 = 0;
								if (root5 != null)
								{
									if ((canAddObjectsToPseudoScenes ? 1 : 0) == num)
									{
										return;
									}
									int num31 = 0;
									HierarchyDataRoot root6 = dataAt2.Root;
									int num32 = 0;
									if (root6 == null)
									{
										throw new InvalidCastException();
									}
									num23 = num33;
								}
							}
						}
					}
					if (flag8)
					{
						return;
					}
					goto IL_02b2;
				}
				goto IL_02d7;
				IL_0351:
				throw new InvalidCastException();
				IL_0341:
				while (flag9)
				{
				}
				int num34 = 0;
				goto IL_0349;
				IL_02d7:
				int num35 = 0;
				int num36 = 0;
				int num37 = 0;
				if (flag10)
				{
					int num38 = 0;
					int num39 = 0;
				}
				int num40 = 0;
				int num41 = 0;
				int handle = gameObject2.scene.m_Handle;
				if (flag11)
				{
					int num42 = 0;
					SceneManager.MoveGameObjectToScene(go, (Scene)num41);
				}
				int num43 = 0;
				int num45 = num44 + 1;
				int num46 = 0;
				if (num41 != 0)
				{
					int num47 = 0;
					if (num41 != 0)
					{
						int num48 = 0;
						int num49 = 0;
						if (num41 == 0)
						{
							break;
						}
						int num50 = 0;
						if (num41 == 0)
						{
							break;
						}
						while (flag12)
						{
						}
						goto IL_0341;
					}
				}
				throw new InvalidCastException();
				IL_02b2:
				int num51 = 0;
				int num52 = 0;
				num23 = num24;
				if ((long)dataAt2.children > 0)
				{
					hierarchy.Refresh();
					return;
				}
				goto IL_0349;
				IL_0239:
				if (num24 <= num53)
				{
				}
				goto IL_023f;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xAE75B0", Offset = "0xAE5FB0", VA = "0x180AE75B0", Slot = "5")]
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_00d9
			//IL_009a: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			if (!eventData.dragging)
			{
				return;
			}
			RuntimeHierarchy runtimeHierarchy = hierarchy;
			if (!runtimeHierarchy.m_canReorganizeItems || runtimeHierarchy.m_isInSearchMode)
			{
				return;
			}
			Type typeFromHandle = typeof(Transform);
			if (!RuntimeInspectorUtils.GetAssignableObjectFromDraggedReferenceItem(eventData, typeFromHandle))
			{
				return;
			}
			pointer = eventData;
			Canvas canvas = this.canvas;
			pointerLastYPos = -1f;
			nextPointerValidation = 5f;
			if (canvas.renderMode != 0)
			{
				if (this.canvas.renderMode == RenderMode.ScreenSpaceCamera)
				{
					Camera camera = this.canvas.worldCamera;
					int num = 0;
					if (camera == (UnityEngine.Object)num)
					{
						goto IL_00c7;
					}
				}
				if ((bool)this.canvas.worldCamera)
				{
					Camera camera2 = this.canvas.worldCamera;
				}
				int num2 = 0;
				Camera main = Camera.main;
			}
			goto IL_00c7;
			IL_00c7:
			int num3 = 0;
			worldCamera = (Camera)num3;
			Update();
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xAE77F0", Offset = "0xAE61F0", VA = "0x180AE77F0", Slot = "6")]
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0042
			//IL_0009: Expected O, but got I8
			pointer = (PointerEventData)0;
			if (dragDropTargetVisualization.gameObject.activeSelf)
			{
				GameObject gameObject = dragDropTargetVisualization.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			hierarchy.m_autoScrollSpeed = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAE7E00", Offset = "0xAE6800", VA = "0x180AE7E00")]
		public HierarchyDragDropListener()
		{
			((MeshFilter)(object)this)._002Ector();
		}
	}
}
