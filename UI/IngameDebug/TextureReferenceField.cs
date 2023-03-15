using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public class TextureReferenceField : ObjectReferenceField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		[SerializeField]
		private RawImage referencePreview;

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		protected override float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x17EDE20", Offset = "0x17EC820", VA = "0x1817EDE20", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			if (typeof(Texture).IsAssignableFrom(type))
			{
				return true;
			}
			Guid gUID = typeof(Sprite).GUID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x17EDCF0", Offset = "0x17EC6F0", VA = "0x1817EDCF0", Slot = "16")]
		protected override void OnReferenceChanged(UnityEngine.Object reference)
		{
			//Discarded unreachable code: IL_0054
			//IL_003d: Expected O, but got I4
			base.OnReferenceChanged(reference);
			GameObject gameObject = referenceNameText.gameObject;
			bool active = !reference;
			gameObject.SetActive(active);
			Texture texture = reference.GetTexture();
			RawImage rawImage = referencePreview;
			int num = 0;
			bool flag2 = (rawImage.enabled = texture != (UnityEngine.Object)num);
			referencePreview.texture = texture;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x17EDF20", Offset = "0x17EC920", VA = "0x1817EDF20")]
		public TextureReferenceField()
		{
		}
	}
}
