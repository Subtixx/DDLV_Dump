using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Graphic;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000968")]
	public class SceneStack : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000969")]
		public delegate void PreCurrentSceneChanged(SceneData currentScene, SceneData nextScene);

		[Cpp2IlInjected.Token(Token = "0x200096A")]
		public delegate void CurrentSceneChanged(SceneData scene);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400341A")]
		[SerializeField]
		[ItemID]
		public int _mainSceneItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400341D")]
		private List<SceneData> _sceneStack = (List<SceneData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400341E")]
		private SceneData _main;

		[Cpp2IlInjected.Token(Token = "0x1700063F")]
		public SceneData CurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAA")]
			[Cpp2IlInjected.Address(RVA = "0xCCA9E0", Offset = "0xCC93E0", VA = "0x180CCA9E0")]
			get
			{
				//IL_000e: Expected O, but got I4
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				this.OnPreCurrentSceneChanged = (PreCurrentSceneChanged)0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000640")]
		public IEnumerable<SceneData> AllLoadedScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				List<SceneData> sceneStack = _sceneStack;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000641")]
		public SceneItemData MainSceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAC")]
			[Cpp2IlInjected.Address(RVA = "0xCCAA90", Offset = "0xCC9490", VA = "0x180CCAA90")]
			get
			{
				//Discarded unreachable code: IL_0016
				int mainSceneItem = _mainSceneItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)mainSceneItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000064")]
		public event PreCurrentSceneChanged OnPreCurrentSceneChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAD")]
			[Cpp2IlInjected.Address(RVA = "0xCCA940", Offset = "0xCC9340", VA = "0x180CCA940")]
			[CompilerGenerated]
			add
			{
				PreCurrentSceneChanged onPreCurrentSceneChanged = this.OnPreCurrentSceneChanged;
				Delegate @delegate = Delegate.Combine(onPreCurrentSceneChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPreCurrentSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BAE")]
			[Cpp2IlInjected.Address(RVA = "0xCCAC40", Offset = "0xCC9640", VA = "0x180CCAC40")]
			[CompilerGenerated]
			remove
			{
				PreCurrentSceneChanged onPreCurrentSceneChanged = this.OnPreCurrentSceneChanged;
				Delegate @delegate = Delegate.Remove(onPreCurrentSceneChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPreCurrentSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000065")]
		public event CurrentSceneChanged OnCurrentSceneChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAF")]
			[Cpp2IlInjected.Address(RVA = "0xCCA8A0", Offset = "0xCC92A0", VA = "0x180CCA8A0")]
			[CompilerGenerated]
			add
			{
				CurrentSceneChanged onCurrentSceneChanged = this.OnCurrentSceneChanged;
				Delegate @delegate = Delegate.Combine(onCurrentSceneChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002BB0")]
			[Cpp2IlInjected.Address(RVA = "0xCCABA0", Offset = "0xCC95A0", VA = "0x180CCABA0")]
			[CompilerGenerated]
			remove
			{
				CurrentSceneChanged onCurrentSceneChanged = this.OnCurrentSceneChanged;
				Delegate @delegate = Delegate.Remove(onCurrentSceneChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB1")]
		[Cpp2IlInjected.Address(RVA = "0xCC9FF0", Offset = "0xCC89F0", VA = "0x180CC9FF0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_002b
			//IL_0023: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			int mainSceneItem = _mainSceneItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)mainSceneItem);
			SceneItemData main = default(SceneItemData);
			_main = (SceneData)main;
			_main = (SceneData)0;
			_main = (SceneData)0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB2")]
		[Cpp2IlInjected.Address(RVA = "0xCCA160", Offset = "0xCC8B60", VA = "0x180CCA160")]
		[AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__18))]
		public Task<SceneData> LoadSceneAsync(SceneItemData sceneItemDataToLoad, bool additive)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<SceneData>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB3")]
		[Cpp2IlInjected.Address(RVA = "0xCCA490", Offset = "0xCC8E90", VA = "0x180CCA490")]
		[AsyncStateMachine(typeof(_003CUnloadCurrentScene_003Ed__19))]
		public Task UnloadCurrentScene()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB4")]
		[Cpp2IlInjected.Address(RVA = "0xCCA5B0", Offset = "0xCC8FB0", VA = "0x180CCA5B0")]
		public void UnloadScene(SceneItemData sceneDefItemData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB5")]
		[Cpp2IlInjected.Address(RVA = "0xCCA2B0", Offset = "0xCC8CB0", VA = "0x180CCA2B0")]
		public void OnComplexityChanged()
		{
			//Discarded unreachable code: IL_004e
			List<SceneData> sceneStack = _sceneStack;
			SceneData main = _main;
			CameraNavigationConfig editCameraConfig = _main.EditCameraConfig;
			LevelComplexityManager levelComplexityManager = SystemRoot.Instance._levelComplexityManager;
			SceneData sceneData = default(SceneData);
			CameraNavigationConfig editCameraConfig2 = sceneData.EditCameraConfig;
			SceneData sceneData2 = default(SceneData);
			AsyncOperation operation = sceneData2.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig3 = sceneData2.EditCameraConfig;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BB6")]
		[Cpp2IlInjected.Address(RVA = "0xCCA820", Offset = "0xCC9220", VA = "0x180CCA820")]
		public SceneStack()
		{
		}
	}
}
