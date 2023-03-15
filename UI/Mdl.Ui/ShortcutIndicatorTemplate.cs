using System;
using System.Reflection;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	public class ShortcutIndicatorTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		public ShortcutIndicator Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		public ShortcutIndicator.VisualType VisualType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public GameObjectTemplate GameObjectTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		public GameObjectTemplate BackgroundHolderTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public GameObjectTemplate BackgroundTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		public GameObjectTemplate LabelTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		public GameObjectTemplate AdditionalLabelTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		public GameObjectTemplate IconTemplate = new GameObjectTemplate();

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x15EBF80", Offset = "0x15EA980", VA = "0x1815EBF80")]
		public void Load(ShortcutIndicator shortcutIndicator)
		{
			//IL_0083: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_0142: Expected O, but got I4
			//IL_02b3: Expected O, but got I4
			//IL_02e7: Expected O, but got I4
			//IL_034b: Expected F4, but got I4
			ShortcutIndicatorView view;
			int num4;
			do
			{
				int num = 0;
				int num2 = 0;
				Vector2 zero = Vector2.zero;
				GameObjectTemplate gameObjectTemplate = GameObjectTemplate;
				int num3 = 0;
				gameObjectTemplate.IgnoreParent = true;
				GameObjectTemplate gameObjectTemplate2 = GameObjectTemplate;
				if ((gameObjectTemplate2.ActiveSelf ? 1 : 0) == num3 && (gameObjectTemplate2.IgnoreActiveSelf ? 1 : 0) == num3)
				{
					GameObject gameObject = shortcutIndicator.gameObject;
					int ignoreParent = 0;
					gameObjectTemplate2.Load(gameObject, (byte)ignoreParent != 0);
					return;
				}
				view = shortcutIndicator.View;
				if ((IntPtr)Name == (IntPtr)num)
				{
					Transform parent = shortcutIndicator.transform.parent;
					if ((object)parent != null)
					{
						string name = parent.name;
					}
					Name = (string)num;
				}
				num4 = 0;
			}
			while (view == (UnityEngine.Object)num4);
			view.gameObject.SetActive(value: true);
			BackgroundHolderTemplate.IgnoreParent = true;
			BackgroundTemplate.IgnoreParent = true;
			IconTemplate.IgnoreParent = true;
			LabelTemplate.IgnoreParent = true;
			AdditionalLabelTemplate.IgnoreParent = true;
			TMP_Text label = view.Label;
			GameObjectTemplate labelTemplate = LabelTemplate;
			GameObject gameObject2 = label.gameObject;
			int ignoreParent2 = 0;
			labelTemplate.Load(gameObject2, (byte)ignoreParent2 != 0);
			TMP_Text additionalLabel = view.AdditionalLabel;
			GameObjectTemplate additionalLabelTemplate = AdditionalLabelTemplate;
			GameObject gameObject3 = additionalLabel.gameObject;
			int ignoreParent3 = 0;
			additionalLabelTemplate.Load(gameObject3, (byte)ignoreParent3 != 0);
			ShortcutDefinition shortcutDefinition = ShortcutDefinition;
			int num5 = 0;
			string spriteName = default(string);
			bool hideVisual = default(bool);
			if (shortcutDefinition != (UnityEngine.Object)num5)
			{
				string stringID = ShortcutDefinition.Self.StringID;
				if (!string.IsNullOrEmpty(stringID))
				{
					view.Label.gameObject.GetComponent<TextBase>().Text = stringID;
				}
				string labelStringID = ShortcutDefinition.Self.LabelStringID;
				if (!string.IsNullOrEmpty(labelStringID))
				{
					view.AdditionalLabel.gameObject.GetComponent<TextBase>().StringID = labelStringID;
				}
				ShortcutDefinition self = ShortcutDefinition.Self;
				ShortcutDefinition shortcutDefinition2 = ShortcutDefinition;
				spriteName = self.SpriteName;
				ShortcutDefinition self2 = shortcutDefinition2.Self;
				ShortcutDefinition self3 = ShortcutDefinition.Self;
				ShortcutDefinition shortcutDefinition3 = ShortcutDefinition;
				hideVisual = self3.HideVisual;
				float iconRotation = shortcutDefinition3.Self.IconRotation;
			}
			ShortcutDefinition shortcutDefinition4 = (shortcutIndicator.ShortcutDefinition = ShortcutDefinition);
			GameObjectTemplate backgroundHolderTemplate = BackgroundHolderTemplate;
			GameObject backgroundHolderObject = view.BackgroundHolderObject;
			int ignoreParent4 = 0;
			backgroundHolderTemplate.Load(backgroundHolderObject, (byte)ignoreParent4 != 0);
			GameObjectTemplate backgroundTemplate = BackgroundTemplate;
			GameObject backgroundObject = view.BackgroundObject;
			int ignoreParent5 = 0;
			backgroundTemplate.Load(backgroundObject, (byte)ignoreParent5 != 0);
			GameObjectTemplate iconTemplate = IconTemplate;
			GameObject iconObject = view.IconObject;
			int ignoreParent6 = 0;
			iconTemplate.Load(iconObject, (byte)ignoreParent6 != 0);
			GameObjectTemplate gameObjectTemplate3 = GameObjectTemplate;
			GameObject gameObject4 = shortcutIndicator.gameObject;
			int ignoreParent7 = 0;
			gameObjectTemplate3.Load(gameObject4, (byte)ignoreParent7 != 0);
			if (!string.IsNullOrEmpty(spriteName))
			{
				SpriteAtlasLoader componentInChildren = view.IconObject.GetComponentInChildren<SpriteAtlasLoader>(includeInactive: true);
				int num6 = 0;
				if (componentInChildren != (UnityEngine.Object)num6)
				{
					componentInChildren.SetTarget(spriteName);
					int num7 = 0;
					componentInChildren?.GetComponent<Image>().SetNativeSize();
				}
			}
			ShortcutDefinition shortcutDefinition5 = ShortcutDefinition;
			int num8 = 0;
			if (shortcutDefinition5 != (UnityEngine.Object)num8 && ShortcutDefinition.IndicatorVisualType != 0)
			{
				Transform transform = view.IconObject.transform;
			}
			CanvasGroup orAddComponent = shortcutIndicator.GetOrAddComponent<CanvasGroup>();
			if (!hideVisual)
			{
				int num9 = ((orAddComponent.enabled = false) ? 1 : 0);
			}
			orAddComponent.enabled = true;
			int num10 = ((orAddComponent.blocksRaycasts = false) ? 1 : 0);
			int num11 = ((orAddComponent.interactable = false) ? 1 : 0);
			int num12 = 0;
			orAddComponent.alpha = num12;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x15EC620", Offset = "0x15EB020", VA = "0x1815EC620")]
		public void Save(ShortcutIndicator shortcutIndicator)
		{
			//IL_0017: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			ShortcutIndicatorView view;
			int num4;
			do
			{
				Target = shortcutIndicator;
				ShortcutDefinition shortcutDefinition = shortcutIndicator.ShortcutDefinition;
				int num = 0;
				if (shortcutDefinition != (UnityEngine.Object)num)
				{
					ShortcutDefinition shortcutDefinition2 = (ShortcutDefinition = shortcutIndicator.ShortcutDefinition);
				}
				Transform parent = shortcutIndicator.transform.parent;
				if ((object)parent != null)
				{
					string name = parent.name;
				}
				int num2 = 0;
				ShortcutDefinition shortcutDefinition3 = ShortcutDefinition;
				int num3 = 0;
				if (shortcutDefinition3 != (UnityEngine.Object)num3)
				{
					string name2 = ShortcutDefinition.name;
				}
				string text = (Name = (string)num2 + " (" + "" + ")");
				GameObjectTemplate.IgnoreParent = true;
				BackgroundHolderTemplate.IgnoreParent = true;
				BackgroundTemplate.IgnoreParent = true;
				IconTemplate.IgnoreParent = true;
				LabelTemplate.IgnoreParent = true;
				AdditionalLabelTemplate.IgnoreParent = true;
				bool activeSelf = shortcutIndicator.gameObject.activeSelf;
				if (!activeSelf)
				{
					GameObjectTemplate gameObjectTemplate = GameObjectTemplate;
					if (gameObjectTemplate.IgnoreActiveSelf == activeSelf)
					{
						GameObject gameObject = shortcutIndicator.gameObject;
						gameObjectTemplate.Save(gameObject);
						return;
					}
				}
				view = shortcutIndicator.View;
				num4 = 0;
			}
			while (view == (UnityEngine.Object)num4);
			GameObject backgroundHolderObject = view.BackgroundHolderObject;
			GameObject backgroundObject = view.BackgroundObject;
			GameObject gameObject2 = view.Label.gameObject;
			GameObject gameObject3 = view.AdditionalLabel.gameObject;
			GameObject iconObject = view.IconObject;
			GameObject gameObject4 = shortcutIndicator.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x15EBAE0", Offset = "0x15EA4E0", VA = "0x1815EBAE0")]
		internal void Backup(ShortcutIndicator shortcutIndicator)
		{
			//Discarded unreachable code: IL_0191
			//IL_0017: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			Target = shortcutIndicator;
			ShortcutDefinition shortcutDefinition = shortcutIndicator.ShortcutDefinition;
			int num = 0;
			if (shortcutDefinition != (UnityEngine.Object)num)
			{
				ShortcutDefinition shortcutDefinition2 = (ShortcutDefinition = shortcutIndicator.ShortcutDefinition);
			}
			Transform parent = shortcutIndicator.transform.parent;
			if ((object)parent != null)
			{
				string name = parent.name;
			}
			int num2 = 0;
			ShortcutDefinition shortcutDefinition3 = ShortcutDefinition;
			int num3 = 0;
			if (shortcutDefinition3 != (UnityEngine.Object)num3)
			{
				string name2 = ShortcutDefinition.name;
			}
			string text = (Name = (string)num2 + " (" + "" + ")");
			GameObjectTemplate.IgnoreParent = true;
			BackgroundHolderTemplate.IgnoreParent = true;
			BackgroundTemplate.IgnoreParent = true;
			IconTemplate.IgnoreParent = true;
			LabelTemplate.IgnoreParent = true;
			AdditionalLabelTemplate.IgnoreParent = true;
			ShortcutIndicatorView view = shortcutIndicator.View;
			GameObjectTemplate backgroundHolderTemplate = BackgroundHolderTemplate;
			GameObject backgroundHolderObject = view.BackgroundHolderObject;
			backgroundHolderTemplate.Save(backgroundHolderObject);
			GameObjectTemplate backgroundTemplate = BackgroundTemplate;
			GameObject backgroundObject = view.BackgroundObject;
			backgroundTemplate.Save(backgroundObject);
			TMP_Text label = view.Label;
			GameObjectTemplate labelTemplate = LabelTemplate;
			GameObject gameObject = label.gameObject;
			labelTemplate.Save(gameObject);
			TMP_Text additionalLabel = view.AdditionalLabel;
			GameObjectTemplate additionalLabelTemplate = AdditionalLabelTemplate;
			GameObject gameObject2 = additionalLabel.gameObject;
			additionalLabelTemplate.Save(gameObject2);
			GameObjectTemplate iconTemplate = IconTemplate;
			GameObject iconObject = view.IconObject;
			iconTemplate.Save(iconObject);
			GameObjectTemplate gameObjectTemplate = GameObjectTemplate;
			GameObject gameObject3 = shortcutIndicator.gameObject;
			gameObjectTemplate.Save(gameObject3);
			GameObjectTemplate.ActiveSelf = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x15EBDB0", Offset = "0x15EA7B0", VA = "0x1815EBDB0")]
		public ShortcutIndicatorTemplate Clone()
		{
			ConstructorInfo constructorInfo = GetType().GetConstructors()[0];
			object obj = default(object);
			if (obj == null)
			{
			}
			int num = 0;
			ShortcutIndicator target = Target;
			ShortcutIndicator target2 = Target;
			bool ignoreActiveSelf = GameObjectTemplate.IgnoreActiveSelf;
			bool ignoreParent = GameObjectTemplate.IgnoreParent;
			bool ignoreParent2 = BackgroundHolderTemplate.IgnoreParent;
			bool ignoreParent3 = BackgroundTemplate.IgnoreParent;
			bool ignoreParent4 = IconTemplate.IgnoreParent;
			bool ignoreParent5 = LabelTemplate.IgnoreParent;
			bool ignoreParent6 = AdditionalLabelTemplate.IgnoreParent;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x15EC960", Offset = "0x15EB360", VA = "0x1815EC960")]
		public ShortcutIndicatorTemplate()
		{
		}
	}
}
