using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	public class SoundComponent : MonoBehaviour, IHasSFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400087C")]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400087D")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x6000C78")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x15FE0C0", Offset = "0x15FCAC0", VA = "0x1815FE0C0", Slot = "6")]
		public void PostSfx(int index)
		{
			//Discarded unreachable code: IL_0045
			if (!IsMuted)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x15FDFF0", Offset = "0x15FC9F0", VA = "0x1815FDFF0")]
		public void PostSfxSafely(int index)
		{
			//Discarded unreachable code: IL_0053
			if (base.gameObject.activeInHierarchy && !IsMuted)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SoundComponent()
		{
		}
	}
}
