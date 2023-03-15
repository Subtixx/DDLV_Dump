using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Customization;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200091B")]
	public class DecalLayerView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200091C")]
		public delegate void SelectDecal(DecalView decal);

		[Cpp2IlInjected.Token(Token = "0x200091D")]
		public delegate void InsertDecal(DecalView decal, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035D4")]
		public DecalView decalPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035D5")]
		public RectTransform decalsAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40035D6")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035D7")]
		[SerializeField]
		private float _holdTime = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40035DA")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40035DB")]
		private RectTransform _dragIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40035DC")]
		private float _time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40035DD")]
		private Vector2 _startHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40035DE")]
		private DecalView _current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40035DF")]
		private List<DecalView> _decals = (List<DecalView>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x14000070")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003943")]
			[Cpp2IlInjected.Address(RVA = "0x12B1370", Offset = "0x12AFD70", VA = "0x1812B1370")]
			[CompilerGenerated]
			add
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Combine(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003944")]
			[Cpp2IlInjected.Address(RVA = "0x12B14B0", Offset = "0x12AFEB0", VA = "0x1812B14B0")]
			[CompilerGenerated]
			remove
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Remove(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000071")]
		public event InsertDecal OnInsertDecal
		{
			[Cpp2IlInjected.Token(Token = "0x6003945")]
			[Cpp2IlInjected.Address(RVA = "0x12B1410", Offset = "0x12AFE10", VA = "0x1812B1410")]
			[CompilerGenerated]
			add
			{
				InsertDecal onInsertDecal = this.OnInsertDecal;
				Delegate @delegate = Delegate.Combine(onInsertDecal, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInsertDecal)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003946")]
			[Cpp2IlInjected.Address(RVA = "0x12B1550", Offset = "0x12AFF50", VA = "0x1812B1550")]
			[CompilerGenerated]
			remove
			{
				InsertDecal onInsertDecal = this.OnInsertDecal;
				Delegate @delegate = Delegate.Remove(onInsertDecal, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInsertDecal)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003947")]
		[Cpp2IlInjected.Address(RVA = "0x12B01B0", Offset = "0x12AEBB0", VA = "0x1812B01B0")]
		private void Awake()
		{
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003948")]
		[Cpp2IlInjected.Address(RVA = "0x12B0C90", Offset = "0x12AF690", VA = "0x1812B0C90")]
		private void Update()
		{
			//IL_001e: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_00d5: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			//IL_00f6: Expected O, but got I4
			//IL_0127: Expected F4, but got I4
			//IL_0147: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_01bd: Expected O, but got I4
			//IL_01fd: Expected O, but got I4
			//IL_022e: Expected F4, but got I4
			//IL_0242: Expected O, but got I4
			while (true)
			{
				int num = 0;
				if (Input.GetMouseButtonUp(0))
				{
					DecalView current = _current;
					int num2 = 0;
					if (current != (UnityEngine.Object)num2)
					{
						RectTransform dragIcon = _dragIcon;
						int num3 = 0;
						if (dragIcon != (UnityEngine.Object)num3)
						{
							int num4 = 0;
							Vector2 mousePosition = Input.mousePosition;
							DecalView decalView = RaycastDecal(mousePosition);
							int num5 = 0;
							if (decalView != (UnityEngine.Object)num5)
							{
								InsertDecal onInsertDecal = this.OnInsertDecal;
								if (onInsertDecal != null)
								{
									DecalView current2 = _current;
									int siblingIndex = decalView.transform.GetSiblingIndex();
									onInsertDecal(current2, siblingIndex);
								}
							}
							DecalView current3 = _current;
							RectTransform dragIcon2 = _dragIcon;
							RectTransform rectTransform = (RectTransform)(((Transform)dragIcon2).parentInternal = current3._decalHolder);
							int num6 = 0;
							UnityEngine.Vector3 one = UnityEngine.Vector3.one;
							dragIcon2.localScale = (UnityEngine.Vector3)num6;
							int num7 = 0;
							UnityEngine.Vector3 zero = UnityEngine.Vector3.zero;
							dragIcon2.localPosition = (UnityEngine.Vector3)num7;
							int num8 = 0;
							Vector2 vector = (dragIcon2.sizeDelta = Vector2.zero);
							_current = (DecalView)num;
							_dragIcon = (RectTransform)num;
							_scrollRect.enabled = true;
							return;
						}
					}
				}
				if (Input.GetMouseButtonDown(0))
				{
					int num9 = 0;
					Vector2 mousePosition2 = Input.mousePosition;
					Vector2 vector2 = ScreenToLocal(mousePosition2);
					_time = num;
				}
				if (!Input.GetMouseButton(0))
				{
					continue;
				}
				RectTransform dragIcon3 = _dragIcon;
				int num10 = 0;
				if (dragIcon3 == (UnityEngine.Object)num10)
				{
					DecalView current4 = _current;
					int num11 = 0;
					if (current4 == (UnityEngine.Object)num11)
					{
						int num12 = 0;
						float num13 = (_time = Time.deltaTime);
						int num14 = 0;
						Vector2 mousePosition3 = Input.mousePosition;
						Vector2 vector3 = ScreenToLocal(mousePosition3);
						int num15 = 0;
						Vector2 mousePosition4 = Input.mousePosition;
						DecalView decalView2 = (_current = RaycastDecal(mousePosition4));
						DecalView current5 = _current;
						int num16 = 0;
						if (current5 != (UnityEngine.Object)num16)
						{
							DecalView current6 = _current;
							RectTransform rect = _rect;
							current6._decal.transform.parentInternal = rect;
							AsyncAtlassedIcon decal = current6._decal;
							int num17 = 0;
							decal.transform.localScale = (UnityEngine.Vector3)num17;
							RectTransform rectTransform2 = (_dragIcon = current6._decal.GetComponent<RectTransform>());
							ScrollRect scrollRect = _scrollRect;
							int num18 = ((scrollRect.enabled = false) ? 1 : 0);
						}
						_time = num;
					}
				}
				RectTransform dragIcon4 = _dragIcon;
				int num19 = 0;
				if (dragIcon4 != (UnityEngine.Object)num19)
				{
					break;
				}
			}
			RectTransform dragIcon5 = _dragIcon;
			int num20 = 0;
			Vector2 mousePosition5 = Input.mousePosition;
			Vector2 vector4 = ScreenToLocal(mousePosition5);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003949")]
		[Cpp2IlInjected.Address(RVA = "0x12B0A00", Offset = "0x12AF400", VA = "0x1812B0A00")]
		public Vector2 ScreenToLocal(Vector2 screenPos)
		{
			RectTransform rect = _rect;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600394A")]
		[Cpp2IlInjected.Address(RVA = "0x12B0A90", Offset = "0x12AF490", VA = "0x1812B0A90")]
		public DecalView Select(int layer)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600394B")]
		[Cpp2IlInjected.Address(RVA = "0x12B0200", Offset = "0x12AEC00", VA = "0x1812B0200")]
		public void DeselectAll()
		{
			//Discarded unreachable code: IL_000e, IL_0014, IL_001a
			List<DecalView> decals = _decals;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600394C")]
		[Cpp2IlInjected.Address(RVA = "0x12B0330", Offset = "0x12AED30", VA = "0x1812B0330")]
		public void Deselect()
		{
			//IL_0010: Expected O, but got I4
			//IL_0031: Expected O, but got I8
			DecalView current = _current;
			int num = 0;
			if (current != (UnityEngine.Object)num)
			{
				GameObject selectedHighlight = _current._selectedHighlight;
				int active = 0;
				selectedHighlight.SetActive((byte)active != 0);
			}
			_current = (DecalView)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600394D")]
		[Cpp2IlInjected.Address(RVA = "0x12B05B0", Offset = "0x12AEFB0", VA = "0x1812B05B0")]
		public unsafe void Refresh(Design design)
		{
			//Discarded unreachable code: IL_0075, IL_0087
			//IL_0065: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = decalsAnchor.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject != null)
			{
				int num4 = 0;
			}
			int num5 = 0;
			int num6 = default(int);
			if (0 < num6)
			{
				DecalView decalView = default(DecalView);
				Transform transform = decalView.transform;
				float z = UnityEngine.Vector3.one.z;
				Decal decal = default(Decal);
				bool flag = ColorUtility.TryParseHtmlString(decal.color_, out *(Color*)num);
				DecalItemData decalData = default(DecalItemData);
				decalView.Init(decalData, (Color)num, num5);
				DecalView.SelectDecal value = default(DecalView.SelectDecal);
				decalView.OnDecalSelected += value;
				num5++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600394E")]
		[Cpp2IlInjected.Address(RVA = "0x12B03D0", Offset = "0x12AEDD0", VA = "0x1812B03D0")]
		private DecalView RaycastDecal(Vector2 screenPos)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600394F")]
		[Cpp2IlInjected.Address(RVA = "0x12B0B60", Offset = "0x12AF560", VA = "0x1812B0B60")]
		private void SelectionChanged(DecalView decal)
		{
			//Discarded unreachable code: IL_007d
			//IL_0010: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			RectTransform dragIcon = _dragIcon;
			int num = 0;
			if (!(dragIcon != (UnityEngine.Object)num))
			{
				DecalView current = _current;
				if ((object)current != null)
				{
					GameObject selectedHighlight = current._selectedHighlight;
					int active = 0;
					selectedHighlight.SetActive((byte)active != 0);
				}
				bool flag = current == decal;
				int num2 = 0;
				_current = (DecalView)num2;
				_current?._selectedHighlight.SetActive(value: true);
				SelectDecal onDecalSelected = this.OnDecalSelected;
				if (onDecalSelected != null)
				{
					DecalView current2 = _current;
					onDecalSelected(current2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003950")]
		[Cpp2IlInjected.Address(RVA = "0x12B12F0", Offset = "0x12AFCF0", VA = "0x1812B12F0")]
		public DecalLayerView()
		{
		}
	}
}
