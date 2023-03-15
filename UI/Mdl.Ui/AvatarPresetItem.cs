using Cpp2IlInjected;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004A9")]
	public class AvatarPresetItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001874")]
		[SerializeField]
		private AsyncImage Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001875")]
		[HideInInspector]
		public AvatarBodyPreset Preset;

		[Cpp2IlInjected.Token(Token = "0x6001E55")]
		[Cpp2IlInjected.Address(RVA = "0x88CC30", Offset = "0x88B630", VA = "0x18088CC30")]
		public void SetData(AvatarBodyPreset preset)
		{
			//Discarded unreachable code: IL_0029
			Preset = preset;
			string iconAddress_ = preset.iconAddress_;
			AsyncImage icon = Icon;
			icon.Release();
			icon.Key = iconAddress_;
			icon.Acquire();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E56")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public AvatarPresetItem()
		{
		}
	}
}
