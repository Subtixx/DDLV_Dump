using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	public class MenuLayoutTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public RuntimePlatform Platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public bool IsLandscape = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public float CanvasScaleFactor = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public ShortcutSetDefinition ShortcutSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		[NonReorderable]
		public List<GameObjectTemplate> GameObjectTemplates = (List<GameObjectTemplate>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x118FAC0", Offset = "0x118E4C0", VA = "0x18118FAC0")]
		public List<GameObjectTemplate> GetTemplates()
		{
			//Discarded unreachable code: IL_0016
			List<GameObjectTemplate> list = (List<GameObjectTemplate>)(object)new List<T>();
			List<GameObjectTemplate> gameObjectTemplates = GameObjectTemplates;
			((List<T>)(object)list).AddRange((IEnumerable<>)gameObjectTemplates);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x118FB50", Offset = "0x118E550", VA = "0x18118FB50")]
		public void SetTemplates(List<GameObjectTemplate> templates)
		{
			//Discarded unreachable code: IL_004f
			//IL_000d: Expected O, but got I4
			RuntimePlatform platform = Platform;
			string text = ((Enum)platform).ToString();
			RuntimePlatform runtimePlatform = (Platform = platform);
			if (!IsLandscape)
			{
			}
			string text2 = (Name = text + " " + "Landscape");
			Action<GameObjectTemplate> action = (Action<GameObjectTemplate>)(object)(Action<T>)delegate(GameObjectTemplate x)
			{
				//Discarded unreachable code: IL_0037
				List<GameObjectTemplate> gameObjectTemplates = GameObjectTemplates;
				Predicate<GameObjectTemplate> predicate = (Predicate<GameObjectTemplate>)(object)(Predicate<T>)delegate(GameObjectTemplate y)
				{
					//Discarded unreachable code: IL_0034
					//IL_0033: Expected O, but got I4
					GameObjectTemplate gameObjectTemplate = x;
					GameObject target = y.Target;
					GameObject target2 = gameObjectTemplate.Target;
					if (target == target2)
					{
						return true;
					}
					GameObject target3 = y.Target;
					int num2 = 0;
					return target3 == (UnityEngine.Object)num2;
				};
				int num = ((List<T>)(object)gameObjectTemplates).RemoveAll((Predicate<>)(object)predicate);
				GameObjectTemplate item = default(GameObjectTemplate);
				((List<T>)(object)GameObjectTemplates).Add((T)item);
			};
			((List<T>)(object)templates).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x118FE10", Offset = "0x118E810", VA = "0x18118FE10")]
		public MenuLayoutTemplate()
		{
		}
	}
}
