using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Rendering;

namespace Assets.Scripts.Dialogues
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal class DisneyWorldDialogueSetup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		[ItemID]
		[SerializeField]
		private int _characterItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public Transform CharacterTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public Transform AvatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public Transform CameraTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public VolumeProfile PostProcessProfile;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x16319F0", Offset = "0x16303F0", VA = "0x1816319F0")]
			get
			{
				long num = Convert.ToInt64((uint)_characterItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DisneyWorldDialogueSetup()
		{
		}
	}
}
