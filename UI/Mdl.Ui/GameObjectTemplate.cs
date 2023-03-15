using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000891")]
	public class GameObjectTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40032A8")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032A9")]
		public GameObject Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032AA")]
		public bool ActiveSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40032AB")]
		public bool IgnoreActiveSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40032AC")]
		public bool IgnoreParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40032AD")]
		public bool IgnoreTrasform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032AE")]
		[HideInInspector]
		[SerializeField]
		private List<TransformTemplate> _transformTemplate = (List<TransformTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032AF")]
		[HideInInspector]
		[SerializeField]
		private List<RectTransformTemplate> _rectTransformTemplate = (List<RectTransformTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40032B0")]
		[HideInInspector]
		[SerializeField]
		private List<SpriteImageTemplate> _imageTemplate = (List<SpriteImageTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40032B1")]
		[HideInInspector]
		[SerializeField]
		private List<SpriteAtlasImageTemplate> _spriteAtlasImageTemplate = (List<SpriteAtlasImageTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40032B2")]
		[HideInInspector]
		[SerializeField]
		private List<AsyncAtlassedIconTemplate> _asyncAtlassedIconTemplate = (List<AsyncAtlassedIconTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40032B3")]
		[HideInInspector]
		[SerializeField]
		private List<TextBaseTemplate> _textBaseTemplate = (List<TextBaseTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40032B4")]
		[HideInInspector]
		[SerializeField]
		private List<FishingReelTemplate> _fishingReelTemplate = (List<FishingReelTemplate>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003610")]
		[Cpp2IlInjected.Address(RVA = "0xE47040", Offset = "0xE45A40", VA = "0x180E47040")]
		public void Load(GameObject gameObject, bool ignoreParent = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003611")]
		[Cpp2IlInjected.Address(RVA = "0xE474C0", Offset = "0xE45EC0", VA = "0x180E474C0")]
		public void Save(GameObject gameObject)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003612")]
		[Cpp2IlInjected.Address(RVA = "0xE46F30", Offset = "0xE45930", VA = "0x180E46F30")]
		public GameObjectTemplate Clone()
		{
			ConstructorInfo constructorInfo = GetType().GetConstructors()[0];
			object obj = default(object);
			if (obj == null)
			{
			}
			int num = 0;
			GameObject target = Target;
			GameObject target2 = Target;
			bool ignoreActiveSelf = IgnoreActiveSelf;
			bool ignoreParent = IgnoreParent;
			bool ignoreTrasform = IgnoreTrasform;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003613")]
		[Cpp2IlInjected.Address(RVA = "0xE47BF0", Offset = "0xE465F0", VA = "0x180E47BF0")]
		public GameObjectTemplate()
		{
		}
	}
}
