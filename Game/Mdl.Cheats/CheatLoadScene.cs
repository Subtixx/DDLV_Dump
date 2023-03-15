using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000840")]
	[CreateAssetMenu]
	public class CheatLoadScene : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E08")]
		public int sceneIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E09")]
		private List<string> _scenes = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000542")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatLoadScene.cs", 31)]
		public int SceneIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6002534")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return sceneIndex;
			}
			[Cpp2IlInjected.Token(Token = "0x6002535")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				sceneIndex = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000543")]
		public string[] SceneNames
		{
			[Cpp2IlInjected.Token(Token = "0x6002536")]
			[Cpp2IlInjected.Address(RVA = "0xA7C820", Offset = "0xA7B220", VA = "0x180A7C820")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (string[])(object)((List<T>)(object)_scenes).ToArray();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002533")]
		[Cpp2IlInjected.Address(RVA = "0xA7C640", Offset = "0xA7B040", VA = "0x180A7C640")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0068
			((List<T>)(object)_scenes).Clear();
			int num = 0;
			int sceneCountInBuildSettings = SceneManager.sceneCountInBuildSettings;
			int num2 = 0;
			if (sceneCountInBuildSettings > 0)
			{
				string scenePathByBuildIndex = SceneUtility.GetScenePathByBuildIndex(num2);
				char[] array = new char[1];
				array[0] = '/';
				string[] array2 = scenePathByBuildIndex.Split(array);
				int num3 = array2.Length - 1;
				List<string> scenes = _scenes;
				string item = array2[num3];
				((List<T>)(object)scenes).Add((T)item);
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002537")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5E0", Offset = "0xA7AFE0", VA = "0x180A7C5E0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatLoadScene.cs", 43)]
		public void LoadScene()
		{
			SceneManager.LoadScene(sceneIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6002538")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7A0", Offset = "0xA7B1A0", VA = "0x180A7C7A0")]
		public CheatLoadScene()
		{
		}
	}
}
