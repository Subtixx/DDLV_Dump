using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public class CustomButtonTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public GameObjectTemplate[] Templates;

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x111C340", Offset = "0x111AD40", VA = "0x18111C340")]
		internal void Save(ButtonViewDefault view)
		{
			//Discarded unreachable code: IL_015e
			GameObjectTemplate[] array;
			GameObjectTemplate gameObjectTemplate5;
			while (true)
			{
				array = new GameObjectTemplate[5];
				GameObjectTemplate gameObjectTemplate = new GameObjectTemplate();
				gameObjectTemplate.IgnoreParent = true;
				if (gameObjectTemplate == null)
				{
					continue;
				}
				array[0] = gameObjectTemplate;
				GameObjectTemplate gameObjectTemplate2 = new GameObjectTemplate();
				gameObjectTemplate2.IgnoreParent = true;
				if (gameObjectTemplate2 == null)
				{
					continue;
				}
				array[1] = gameObjectTemplate2;
				GameObjectTemplate gameObjectTemplate3 = new GameObjectTemplate();
				gameObjectTemplate3.IgnoreParent = true;
				if (gameObjectTemplate3 == null)
				{
					continue;
				}
				array[2] = gameObjectTemplate3;
				GameObjectTemplate gameObjectTemplate4 = new GameObjectTemplate();
				gameObjectTemplate4.IgnoreParent = true;
				if (gameObjectTemplate4 != null)
				{
					array[3] = gameObjectTemplate4;
					gameObjectTemplate5 = new GameObjectTemplate();
					gameObjectTemplate5.IgnoreParent = true;
					if (gameObjectTemplate5 != null)
					{
						break;
					}
				}
			}
			array[4] = gameObjectTemplate5;
			Templates = array;
			GameObjectTemplate gameObjectTemplate6 = Templates[0];
			GameObject gameObject = view.Background.gameObject;
			gameObjectTemplate6.Save(gameObject);
			GameObjectTemplate[] templates = Templates;
			ImageHelper staticIcon = view.StaticIcon;
			GameObjectTemplate gameObjectTemplate7 = templates[1];
			GameObject gameObject2 = staticIcon.gameObject;
			gameObjectTemplate7.Save(gameObject2);
			GameObjectTemplate[] templates2 = Templates;
			ImageHelper dynamicIcon = view.DynamicIcon;
			GameObjectTemplate gameObjectTemplate8 = templates2[2];
			GameObject gameObject3 = dynamicIcon.gameObject;
			gameObjectTemplate8.Save(gameObject3);
			GameObjectTemplate[] templates3 = Templates;
			TextBase label = view.Label;
			GameObjectTemplate gameObjectTemplate9 = templates3[3];
			GameObject gameObject4 = label.gameObject;
			gameObjectTemplate9.Save(gameObject4);
			GameObjectTemplate gameObjectTemplate10 = Templates[4];
			GameObject gameObject5 = view.gameObject;
			gameObjectTemplate10.Save(gameObject5);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x111C170", Offset = "0x111AB70", VA = "0x18111C170")]
		internal void Load(ButtonViewDefault view)
		{
			//Discarded unreachable code: IL_00c5
			GameObjectTemplate gameObjectTemplate = Templates[0];
			GameObject gameObject = view.Background.gameObject;
			gameObjectTemplate.Load(gameObject, ignoreParent: true);
			GameObjectTemplate[] templates = Templates;
			ImageHelper staticIcon = view.StaticIcon;
			GameObjectTemplate gameObjectTemplate2 = templates[1];
			GameObject gameObject2 = staticIcon.gameObject;
			gameObjectTemplate2.Load(gameObject2, ignoreParent: true);
			GameObjectTemplate[] templates2 = Templates;
			ImageHelper dynamicIcon = view.DynamicIcon;
			GameObjectTemplate gameObjectTemplate3 = templates2[2];
			GameObject gameObject3 = dynamicIcon.gameObject;
			gameObjectTemplate3.Load(gameObject3, ignoreParent: true);
			GameObjectTemplate[] templates3 = Templates;
			TextBase label = view.Label;
			GameObjectTemplate gameObjectTemplate4 = templates3[3];
			GameObject gameObject4 = label.gameObject;
			gameObjectTemplate4.Load(gameObject4, ignoreParent: true);
			GameObjectTemplate gameObjectTemplate5 = Templates[4];
			GameObject gameObject5 = view.gameObject;
			gameObjectTemplate5.Load(gameObject5, ignoreParent: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CustomButtonTemplate()
		{
		}
	}
}
