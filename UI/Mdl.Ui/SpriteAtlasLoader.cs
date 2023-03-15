using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.U2D;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F1")]
	[DisallowMultipleComponent]
	public abstract class SpriteAtlasLoader : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400087E")]
		public SpriteAtlas SpriteAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400087F")]
		public Sprite Sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		public bool BlockAutoAssign;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000881")]
		public bool UseGeneralAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000882")]
		private Sprite targetSprite;

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public string ImageAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000C81")]
			[Cpp2IlInjected.Address(RVA = "0x15FF620", Offset = "0x15FE020", VA = "0x1815FF620")]
			set
			{
				//Discarded unreachable code: IL_0033
				//IL_0010: Expected O, but got I4
				Sprite sprite = targetSprite;
				int num = 0;
				if (sprite != (Object)num)
				{
					Object.Destroy(targetSprite);
				}
				Sprite sprite2 = (targetSprite = SpriteAtlas.GetSprite(value));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x15FF4A0", Offset = "0x15FDEA0", VA = "0x1815FF4A0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0078
			//IL_0031: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			int num = 0;
			if (!Application.isPlaying)
			{
				int num2 = 0;
				bool isPlaying = Application.isPlaying;
				if (isPlaying || BlockAutoAssign != isPlaying)
				{
					return;
				}
			}
			SpriteAtlas spriteAtlas = SpriteAtlas;
			int num3 = 0;
			if (!(spriteAtlas != (Object)num3))
			{
				return;
			}
			Sprite sprite = Sprite;
			int num4 = 0;
			if (sprite != (Object)num4)
			{
				Sprite sprite2 = targetSprite;
				int num5 = 0;
				if (sprite2 == (Object)num5)
				{
					string text = Sprite.name;
					UpdateTargetSprite(text);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		internal virtual void RemoveImageReference()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x15FF200", Offset = "0x15FDC00", VA = "0x1815FF200")]
		public void OnDestroy()
		{
			//IL_0010: Expected O, but got I4
			Sprite sprite = targetSprite;
			int num = 0;
			if (sprite != (Object)num)
			{
				int num2 = 0;
				bool webSecurityEnabled = Application.webSecurityEnabled;
				Sprite obj = targetSprite;
				if (!webSecurityEnabled)
				{
					Object.Destroy(obj);
				}
				else
				{
					Object.DestroyImmediate(obj);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x15FF2D0", Offset = "0x15FDCD0", VA = "0x1815FF2D0")]
		public void SetSourceSprite(Sprite newSprite)
		{
			//Discarded unreachable code: IL_0037
			if (Sprite != newSprite)
			{
				Sprite = newSprite;
				string text = Sprite.name;
				Sprite sprite = (targetSprite = SpriteAtlas.GetSprite(text));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x15FF3B0", Offset = "0x15FDDB0", VA = "0x1815FF3B0")]
		public void SetTarget(string value)
		{
			//Discarded unreachable code: IL_0033
			//IL_0010: Expected O, but got I4
			Sprite sprite = targetSprite;
			int num = 0;
			if (sprite != (Object)num)
			{
				Object.Destroy(targetSprite);
			}
			Sprite sprite2 = (targetSprite = SpriteAtlas.GetSprite(value));
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void SetTarget(Sprite targetSprite);

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x15FF5C0", Offset = "0x15FDFC0", VA = "0x1815FF5C0")]
		private void UpdateTargetSprite(string name)
		{
			//Discarded unreachable code: IL_0015
			Sprite sprite = (targetSprite = SpriteAtlas.GetSprite(name));
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected SpriteAtlasLoader()
		{
		}
	}
}
