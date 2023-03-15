using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000923")]
	public class DecalView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000924")]
		public delegate void SelectDecal(DecalView decal);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035F2")]
		[SerializeField]
		private AsyncAtlassedIcon _decal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035F3")]
		[SerializeField]
		private RectTransform _decalHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40035F4")]
		[SerializeField]
		private GameObject _selectedHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035F5")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.Token(Token = "0x170007F0")]
		public DecalItemData DecalData
		{
			[Cpp2IlInjected.Token(Token = "0x6003983")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CDecalData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003984")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CDecalData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F1")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003985")]
			[Cpp2IlInjected.Address(RVA = "0x116CEA0", Offset = "0x116B8A0", VA = "0x18116CEA0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003986")]
			[Cpp2IlInjected.Address(RVA = "0x116CFE0", Offset = "0x116B9E0", VA = "0x18116CFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x40035F8")]
		public int Layer
		{
			[Cpp2IlInjected.Token(Token = "0x6003987")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003988")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000074")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003989")]
			[Cpp2IlInjected.Address(RVA = "0x12B8230", Offset = "0x12B6C30", VA = "0x1812B8230")]
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
			[Cpp2IlInjected.Token(Token = "0x600398A")]
			[Cpp2IlInjected.Address(RVA = "0x12B82D0", Offset = "0x12B6CD0", VA = "0x1812B82D0")]
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

		[Cpp2IlInjected.Token(Token = "0x600398B")]
		[Cpp2IlInjected.Address(RVA = "0x12B7D90", Offset = "0x12B6790", VA = "0x1812B7D90")]
		public void Init(DecalItemData decalData, Color color, int layer)
		{
			//Discarded unreachable code: IL_00d4
			_button.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick = _button.m_OnClick;
			UnityAction call = SelectCurrent;
			onClick.AddListener(call);
			DecalData = decalData;
			AsyncAtlassedIcon decal = _decal;
			Layer = layer;
			AsyncAtlassedIcon.ImageLoaded value = UpdateColor;
			decal.OnImageLoaded += value;
			DecalItemData decalItemData = DecalData;
			AsyncAtlassedIcon decal2 = _decal;
			string iconAddress_ = decalItemData.iconAddress_;
			if (decal2.SetIcon(iconAddress_))
			{
				AsyncAtlassedIcon decal3 = _decal;
				AsyncAtlassedIcon decal4 = _decal;
				AsyncAtlassedIcon.ImageLoaded value2 = UpdateColor;
				decal4.OnImageLoaded -= value2;
				RawImage rawImage = decal3.RawImage;
				Color color3 = (rawImage.color = Color);
			}
			GameObject selectedHighlight = _selectedHighlight;
			int active = 0;
			selectedHighlight.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600398C")]
		[Cpp2IlInjected.Address(RVA = "0x12B8160", Offset = "0x12B6B60", VA = "0x1812B8160")]
		private void UpdateColor(AsyncAtlassedIcon icon)
		{
			//Discarded unreachable code: IL_0031
			AsyncAtlassedIcon decal = _decal;
			AsyncAtlassedIcon.ImageLoaded value = UpdateColor;
			decal.OnImageLoaded -= value;
			RawImage rawImage = icon.RawImage;
			Color color2 = (rawImage.color = Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600398D")]
		[Cpp2IlInjected.Address(RVA = "0x12B8090", Offset = "0x12B6A90", VA = "0x1812B8090")]
		public RectTransform TakeIcon(RectTransform newParent)
		{
			//Discarded unreachable code: IL_002b
			_decal.transform.parentInternal = newParent;
			Transform transform = _decal.transform;
			int num = 0;
			return _decal.GetComponent<RectTransform>();
		}

		[Cpp2IlInjected.Token(Token = "0x600398E")]
		[Cpp2IlInjected.Address(RVA = "0x12B7FD0", Offset = "0x12B69D0", VA = "0x1812B7FD0")]
		public void PutBackIcon(RectTransform icon)
		{
			//Discarded unreachable code: IL_0036
			RectTransform rectTransform = (RectTransform)(((Transform)icon).parentInternal = _decalHolder);
			float z = Vector3.one.z;
			float z2 = Vector3.zero.z;
			int num = 0;
			Vector2 vector = (icon.sizeDelta = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x600398F")]
		[Cpp2IlInjected.Address(RVA = "0x1117360", Offset = "0x1115D60", VA = "0x181117360")]
		public void Highlight(bool selected)
		{
			//Discarded unreachable code: IL_000d
			_selectedHighlight.SetActive(selected);
		}

		[Cpp2IlInjected.Token(Token = "0x6003990")]
		[Cpp2IlInjected.Address(RVA = "0x12B8070", Offset = "0x12B6A70", VA = "0x1812B8070")]
		private void SelectCurrent()
		{
			this.OnDecalSelected?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003991")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DecalView()
		{
		}
	}
}
