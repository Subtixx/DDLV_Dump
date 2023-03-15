using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006BD")]
	[RequireComponent(typeof(Image))]
	public class SliderMenu : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002617")]
		public Sprite Slider_Normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002618")]
		public Sprite Slider_Highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002619")]
		public Sprite Slider_Press;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400261A")]
		[SerializeField]
		private Image _image;

		[Cpp2IlInjected.Token(Token = "0x6002B76")]
		[Cpp2IlInjected.Address(RVA = "0x15F5E00", Offset = "0x15F4800", VA = "0x1815F5E00")]
		protected void OnEnable()
		{
			//Discarded unreachable code: IL_0024
			if ((bool)_image)
			{
				Image image = _image;
				Sprite sprite = (image.sprite = Slider_Normal);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B77")]
		[Cpp2IlInjected.Address(RVA = "0x15F5E00", Offset = "0x15F4800", VA = "0x1815F5E00")]
		public void Normal()
		{
			//Discarded unreachable code: IL_0024
			if ((bool)_image)
			{
				Image image = _image;
				Sprite sprite = (image.sprite = Slider_Normal);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B78")]
		[Cpp2IlInjected.Address(RVA = "0x15F5D80", Offset = "0x15F4780", VA = "0x1815F5D80")]
		public void Highlight()
		{
			//Discarded unreachable code: IL_0024
			if ((bool)_image)
			{
				Image image = _image;
				Sprite sprite = (image.sprite = Slider_Highlight);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B79")]
		[Cpp2IlInjected.Address(RVA = "0x15F5E80", Offset = "0x15F4880", VA = "0x1815F5E80")]
		public void Press()
		{
			//Discarded unreachable code: IL_0024
			if ((bool)_image)
			{
				Image image = _image;
				Sprite sprite = (image.sprite = Slider_Press);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SliderMenu()
		{
		}
	}
}
