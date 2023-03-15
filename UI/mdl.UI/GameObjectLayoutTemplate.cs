using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;

namespace mdl.UI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public class GameObjectLayoutTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public List<GameObjectTemplate> GameObjectTemplates = (List<GameObjectTemplate>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xE46B30", Offset = "0xE45530", VA = "0x180E46B30")]
		public List<GameObjectTemplate> GetTemplates()
		{
			//Discarded unreachable code: IL_0016
			List<GameObjectTemplate> list = (List<GameObjectTemplate>)(object)new List<T>();
			List<GameObjectTemplate> gameObjectTemplates = GameObjectTemplates;
			((List<T>)(object)list).AddRange((IEnumerable<>)gameObjectTemplates);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xE46BC0", Offset = "0xE455C0", VA = "0x180E46BC0")]
		public void SetTemplates(List<GameObjectTemplate> templates)
		{
			//Discarded unreachable code: IL_0015
			Action<GameObjectTemplate> action = (Action<GameObjectTemplate>)(object)(Action<T>)delegate(GameObjectTemplate x)
			{
				//Discarded unreachable code: IL_009d
				List<GameObjectTemplate> gameObjectTemplates = GameObjectTemplates;
				Predicate<GameObjectTemplate> predicate = (Predicate<GameObjectTemplate>)(object)(Predicate<T>)delegate(GameObjectTemplate y)
				{
					//Discarded unreachable code: IL_0034
					//IL_0033: Expected O, but got I4
					GameObjectTemplate gameObjectTemplate3 = x;
					GameObject target4 = y.Target;
					GameObject target5 = gameObjectTemplate3.Target;
					if (target4 == target5)
					{
						return true;
					}
					GameObject target6 = y.Target;
					int num3 = 0;
					return target6 == (UnityEngine.Object)num3;
				};
				int num = ((List<T>)(object)gameObjectTemplates).RemoveAll((Predicate<>)(object)predicate);
				GameObjectTemplate gameObjectTemplate = x;
				GameObject target = gameObjectTemplate.Target;
				gameObjectTemplate.Save(target);
				GameObjectTemplate gameObjectTemplate2 = x;
				List<GameObjectTemplate> gameObjectTemplates2 = GameObjectTemplates;
				ConstructorInfo constructorInfo = gameObjectTemplate2.GetType().GetConstructors()[0];
				object obj = default(object);
				if (obj == null)
				{
				}
				int num2 = 0;
				GameObject target2 = gameObjectTemplate2.Target;
				GameObject target3 = gameObjectTemplate2.Target;
				bool ignoreActiveSelf = gameObjectTemplate2.IgnoreActiveSelf;
				bool ignoreParent = gameObjectTemplate2.IgnoreParent;
				bool ignoreTrasform = gameObjectTemplate2.IgnoreTrasform;
			};
			((List<T>)(object)templates).ForEach((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xE46EB0", Offset = "0xE458B0", VA = "0x180E46EB0")]
		public GameObjectLayoutTemplate()
		{
		}
	}
}
