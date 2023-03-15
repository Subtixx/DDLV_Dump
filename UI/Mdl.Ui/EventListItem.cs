using Cpp2IlInjected;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200047B")]
	public class EventListItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016BF")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016C0")]
		[SerializeField]
		private AsyncAtlassedIcon _eventIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016C1")]
		[SerializeField]
		private TextBase _eventTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016C2")]
		[SerializeField]
		private SpriteAtlasImage _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016C3")]
		[SerializeField]
		private Color _selectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40016C4")]
		[SerializeField]
		private Color _deselectedColor;

		[Cpp2IlInjected.Token(Token = "0x6001D02")]
		[Cpp2IlInjected.Address(RVA = "0x13FD8D0", Offset = "0x13FC2D0", VA = "0x1813FD8D0")]
		public void Refresh(MiniEventProgress miniEvent, bool selected)
		{
			//Discarded unreachable code: IL_00f0
			TextBase eventTitle = _eventTitle;
			string text = (eventTitle.StringID = miniEvent.Data.name_);
			Image image = _background.Image;
			if (selected)
			{
			}
			Color color = (image.color = _deselectedColor);
			_canvasGroup.interactable = selected;
			AsyncAtlassedIcon eventIcon = _eventIcon;
			AsyncAtlassedIcon.ImageLoaded value = OnIconLoaded;
			eventIcon.OnImageLoaded -= value;
			if (!string.IsNullOrEmpty(miniEvent.Data.iconAddress_))
			{
				AsyncAtlassedIcon eventIcon2 = _eventIcon;
				AsyncAtlassedIcon.ImageLoaded value2 = OnIconLoaded;
				eventIcon2.OnImageLoaded += value2;
				AsyncAtlassedIcon eventIcon3 = _eventIcon;
				string iconAddress_ = miniEvent.Data.iconAddress_;
				if (eventIcon3.SetIcon(iconAddress_))
				{
					AsyncAtlassedIcon eventIcon4 = _eventIcon;
					AsyncAtlassedIcon.ImageLoaded value3 = OnIconLoaded;
					eventIcon4.OnImageLoaded -= value3;
					RawImage rawImage = _eventIcon.RawImage;
					Image image2 = _background.Image;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D03")]
		[Cpp2IlInjected.Address(RVA = "0x13FD7D0", Offset = "0x13FC1D0", VA = "0x1813FD7D0")]
		private void OnIconLoaded(AsyncAtlassedIcon image)
		{
			//Discarded unreachable code: IL_0034
			AsyncAtlassedIcon eventIcon = _eventIcon;
			AsyncAtlassedIcon.ImageLoaded value = OnIconLoaded;
			eventIcon.OnImageLoaded -= value;
			RawImage rawImage = _eventIcon.RawImage;
			Image image2 = _background.Image;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D04")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventListItem()
		{
		}
	}
}
