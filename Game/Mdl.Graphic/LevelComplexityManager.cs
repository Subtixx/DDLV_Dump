using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004A2")]
	public class LevelComplexityManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20004A3")]
		public delegate void ComplexityChanged();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D22")]
		private List<SceneComplexity> _sceneComplexity = (List<SceneComplexity>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D23")]
		private List<LevelComplexityBoundary> currentAnchors = (List<LevelComplexityBoundary>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D24")]
		private float delayInterval = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001D25")]
		private float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D26")]
		private LevelComplexityUpdateMode _updateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001D27")]
		private bool _isDebugOnScreenDisplayEnable;

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4001D21")]
		public LevelComplexityEnum CurrentComplexityLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600148D")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600148E")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		} = LevelComplexityEnum.COMPLEXITY_HIGH;


		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public SceneComplexityData CurrentComplexityData
		{
			[Cpp2IlInjected.Token(Token = "0x600148F")]
			[Cpp2IlInjected.Address(RVA = "0x11C7350", Offset = "0x11C5D50", VA = "0x1811C7350")]
			get
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public LevelComplexityUpdateMode CurrentUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6001490")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return _updateMode;
			}
			[Cpp2IlInjected.Token(Token = "0x6001491")]
			[Cpp2IlInjected.Address(RVA = "0x11C74D0", Offset = "0x11C5ED0", VA = "0x1811C74D0")]
			set
			{
				_updateMode = value;
				if (value != 0)
				{
					bool visibility = value == LevelComplexityUpdateMode.AlwaysEnable;
					ToggleAllComplexityVisible(visibility);
				}
				else
				{
					ComputeIntersection();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		private bool IsUpdatingBasedOnDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6001492")]
			[Cpp2IlInjected.Address(RVA = "0x11C7420", Offset = "0x11C5E20", VA = "0x1811C7420")]
			get
			{
				return _updateMode == LevelComplexityUpdateMode.DistanceToggle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public bool IsDebugOnScreenDisplayEnable
		{
			[Cpp2IlInjected.Token(Token = "0x6001493")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get
			{
				return _isDebugOnScreenDisplayEnable;
			}
			[Cpp2IlInjected.Token(Token = "0x6001494")]
			[Cpp2IlInjected.Address(RVA = "0x11C74F0", Offset = "0x11C5EF0", VA = "0x1811C74F0")]
			set
			{
				//Discarded unreachable code: IL_003e
				_isDebugOnScreenDisplayEnable = value;
				int num = 0;
				DebugOnScreenText instance = DebugOnScreenText.Instance;
				if (!value)
				{
					DebugOnScreenText.AddOnScreenText value2 = OnScreenDebugText;
					instance.OnAddOnScreenText -= value2;
				}
				else
				{
					DebugOnScreenText.AddOnScreenText value2 = default(DebugOnScreenText.AddOnScreenText);
					instance.OnAddOnScreenText -= value2;
					int num2 = 0;
					DebugOnScreenText.AddOnScreenText value3 = default(DebugOnScreenText.AddOnScreenText);
					DebugOnScreenText.Instance.OnAddOnScreenText += value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000035")]
		public event ComplexityChanged OnCurrentComplexityChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600148B")]
			[Cpp2IlInjected.Address(RVA = "0x11C72B0", Offset = "0x11C5CB0", VA = "0x1811C72B0")]
			[CompilerGenerated]
			add
			{
				ComplexityChanged onCurrentComplexityChanged = this.OnCurrentComplexityChanged;
				Delegate @delegate = Delegate.Combine(onCurrentComplexityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentComplexityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600148C")]
			[Cpp2IlInjected.Address(RVA = "0x11C7430", Offset = "0x11C5E30", VA = "0x1811C7430")]
			[CompilerGenerated]
			remove
			{
				ComplexityChanged onCurrentComplexityChanged = this.OnCurrentComplexityChanged;
				Delegate @delegate = Delegate.Remove(onCurrentComplexityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentComplexityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001495")]
		[Cpp2IlInjected.Address(RVA = "0x11C6520", Offset = "0x11C4F20", VA = "0x1811C6520")]
		public void SetLevelComplexity(LevelComplexityEnum level)
		{
			if (CurrentComplexityLevel != level)
			{
				CurrentComplexityLevel = level;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				this.OnCurrentComplexityChanged?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001496")]
		[Cpp2IlInjected.Address(RVA = "0x11C6E10", Offset = "0x11C5810", VA = "0x1811C6E10")]
		[AsyncStateMachine(typeof(_003CUpdateComplexity_003Ed__25))]
		private Task UpdateComplexity()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001497")]
		[Cpp2IlInjected.Address(RVA = "0x11C6090", Offset = "0x11C4A90", VA = "0x1811C6090")]
		[AsyncStateMachine(typeof(_003CLoadSceneComplexity_003Ed__26))]
		public Task LoadSceneComplexity(SceneComplexityData complexityData, SceneData sceneData)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001498")]
		[Cpp2IlInjected.Address(RVA = "0x11C5F30", Offset = "0x11C4930", VA = "0x1811C5F30")]
		[AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__27))]
		public Task LoadSceneAsync(string sceneDef, LevelComplexityEnum _complexity, SceneData sd)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001499")]
		[Cpp2IlInjected.Address(RVA = "0x11C6BB0", Offset = "0x11C55B0", VA = "0x1811C6BB0")]
		[AsyncStateMachine(typeof(_003CUnloadScene_003Ed__28))]
		public Task UnloadScene(SceneComplexity sceneComplexity)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600149A")]
		[Cpp2IlInjected.Address(RVA = "0x11C6CE0", Offset = "0x11C56E0", VA = "0x1811C6CE0")]
		[AsyncStateMachine(typeof(_003CUnloadScene_003Ed__29))]
		public Task UnloadScene(SceneData _sceneData)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600149B")]
		[Cpp2IlInjected.Address(RVA = "0x11C6690", Offset = "0x11C5090", VA = "0x1811C6690")]
		public void ToggleAllComplexityVisible(bool visibility)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			bool flag = default(bool);
			if (currentAnchors != null && !flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149C")]
		[Cpp2IlInjected.Address(RVA = "0x11C67B0", Offset = "0x11C51B0", VA = "0x1811C67B0")]
		public void ToggleComplexityVisibility(SceneData _sceneData, bool visibility)
		{
			//Discarded unreachable code: IL_006f, IL_0075, IL_007b
			int num = 0;
			SceneData _sceneData2 = (SceneData)_sceneData.sceneInstance.m_Operation;
			_sceneData2 = (SceneData)_sceneData.EditCameraConfig;
			List<SceneComplexity> sceneComplexity = _sceneComplexity;
			Func<SceneComplexity, bool> func = (Func<SceneComplexity, bool>)(object)(Func<T, TResult>)delegate(SceneComplexity x)
			{
				//Discarded unreachable code: IL_0011
				SceneData sceneData = _sceneData2;
				return (object)x.ownerSceneData == (object)sceneData;
			};
			IEnumerable<SceneComplexity> enumerable = (IEnumerable<SceneComplexity>)Enumerable.Where<SceneComplexity>((IEnumerable<>)sceneComplexity, (Func<, >)(object)func);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0069;
					}
					num++;
				}
				GameObject gameObject = default(GameObject);
				gameObject.SetActive(visibility);
			}
			goto IL_0069;
			IL_0069:
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149D")]
		[Cpp2IlInjected.Address(RVA = "0x11C6A10", Offset = "0x11C5410", VA = "0x1811C6A10")]
		public void ToggleComplexityVisibility(List<SceneComplexity> complexity, bool visibility)
		{
			//Discarded unreachable code: IL_0021
			//IL_0015: Expected O, but got I4
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			while (true)
			{
				int num = 0;
				if (complexity != null && flag)
				{
					int num2 = 0;
					if (gameObject != (UnityEngine.Object)num2)
					{
						gameObject2.SetActive(visibility);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600149E")]
		[Cpp2IlInjected.Address(RVA = "0x11C5AD0", Offset = "0x11C44D0", VA = "0x1811C5AD0")]
		public void FindAnchors()
		{
			//Discarded unreachable code: IL_0121
			//IL_0053: Expected I4, but got O
			//IL_00c9: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			if ((object)gameObject == null)
			{
				return;
			}
			List<LevelComplexityBoundary> list = (List<LevelComplexityBoundary>)(object)Enumerable.ToList<LevelComplexityBoundary>((IEnumerable<>)(object)gameObject.GetComponentsInChildren<LevelComplexityBoundary>());
			if (list == null)
			{
				return;
			}
			currentAnchors = list;
			SceneComplexityData currentComplexityData = CurrentComplexityData;
			List<LevelComplexityBoundary> list2 = (currentComplexityData.Anchors = (List<LevelComplexityBoundary>)(object)new List<T>((int)list));
			int num = 0;
			if (SceneManager.sceneCount <= 0)
			{
				return;
			}
			int num2 = 0;
			int num3 = 0;
			int sceneCount = SceneManager.sceneCount;
			if (num2 >= sceneCount)
			{
				return;
			}
			Scene scene = SceneManager.GetSceneAt(num2);
			List<LevelComplexityBoundary> list3 = currentAnchors;
			Func<LevelComplexityBoundary, bool> func = (Func<LevelComplexityBoundary, bool>)(object)(Func<T, TResult>)delegate(LevelComplexityBoundary x)
			{
				//Discarded unreachable code: IL_0014
				string value = x.gameObject.name;
				string text = default(string);
				return text.Contains(value);
			};
			LevelComplexityBoundary levelComplexityBoundary = Enumerable.FirstOrDefault<LevelComplexityBoundary>((IEnumerable<>)list3, (Func<, >)(object)func);
			int num4 = 0;
			if (levelComplexityBoundary != (UnityEngine.Object)num4)
			{
				levelComplexityBoundary.isLoaded = true;
				List<SceneComplexity> sceneComplexity = _sceneComplexity;
				Func<SceneComplexity, bool> func2 = (Func<SceneComplexity, bool>)(object)(Func<T, TResult>)delegate(SceneComplexity x)
				{
					SceneInstance sceneInstance = x.sceneInstance;
					throw new NullReferenceException();
				};
				SceneComplexity sceneComplexity2 = Enumerable.FirstOrDefault<SceneComplexity>((IEnumerable<>)sceneComplexity, (Func<, >)(object)func2);
				if (sceneComplexity2 != null && !((List<T>)(object)levelComplexityBoundary.complexity).Contains((T)sceneComplexity2))
				{
					((List<T>)(object)levelComplexityBoundary.complexity).Add((T)sceneComplexity2);
				}
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x600149F")]
		[Cpp2IlInjected.Address(RVA = "0x11C5860", Offset = "0x11C4260", VA = "0x1811C5860")]
		public void ComputeIntersection()
		{
			//Discarded unreachable code: IL_0042, IL_0048, IL_004e, IL_0054, IL_005a, IL_0060
			int num = 0;
			bool flag = default(bool);
			if (_updateMode == (LevelComplexityUpdateMode)num && currentAnchors != null && flag)
			{
				GameObject gameObject = default(GameObject);
				Transform transform = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num2 = 0;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int num3 = 0;
				float num4 = default(float);
				if (QualitySettings.lodBias > num4)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C6F10", Offset = "0x11C5910", VA = "0x1811C6F10")]
		public void UpdateCurrentAnchors()
		{
			//Discarded unreachable code: IL_007f
			//IL_001b: Expected O, but got I4
			//IL_0073: Expected I4, but got O
			((List<T>)(object)currentAnchors).Clear();
			SceneComplexityData currentComplexityData = CurrentComplexityData;
			int num = 0;
			if (currentComplexityData == (UnityEngine.Object)num || (long)CurrentComplexityData.Anchors == 0)
			{
				return;
			}
			List<LevelComplexityBoundary> anchors = CurrentComplexityData.Anchors;
			Func<LevelComplexityBoundary, bool> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
			if (_003C_003E9__35_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(LevelComplexityBoundary i)
				{
					//IL_0009: Expected O, but got I4
					int num2 = 0;
					return i == (UnityEngine.Object)num2;
				};
			}
			if (!((IEnumerable<>)anchors).Any<LevelComplexityBoundary>((Func<, >)(object)_003C_003E9__35_))
			{
				List<LevelComplexityBoundary> list = (currentAnchors = (List<LevelComplexityBoundary>)(object)new List<T>((int)CurrentComplexityData.Anchors));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C7170", Offset = "0x11C5B70", VA = "0x1811C7170")]
		private void Update()
		{
			if (_updateMode == LevelComplexityUpdateMode.DistanceToggle && currentAnchors != null)
			{
				int num = 0;
				if (!(Time.time <= delay))
				{
					ComputeIntersection();
					int num2 = 0;
					float num3 = (delay = Time.time);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C61E0", Offset = "0x11C4BE0", VA = "0x1811C61E0")]
		private void OnScreenDebugText(StringBuilder dest)
		{
			//Discarded unreachable code: IL_007c, IL_0082, IL_008e
			//IL_0011: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			GameObject gameObject = default(GameObject);
			string arg = default(string);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				string value = $"IsUpdatingBasedOnDistance={num2}";
				StringBuilder stringBuilder = dest.AppendLine(value);
				LevelComplexityUpdateMode updateMode = _updateMode;
				string value2 = $"CurrentUpdateMode={updateMode}";
				StringBuilder stringBuilder2 = dest.AppendLine(value2);
				if (currentAnchors == null)
				{
					return;
				}
				if (flag)
				{
					if (flag2)
					{
						bool activeSelf = gameObject.activeSelf;
						string value3 = $"Layer {arg}={activeSelf}";
						StringBuilder stringBuilder3 = dest.AppendLine(value3);
					}
					if (updateMode != 0)
					{
						break;
					}
				}
				if (updateMode == LevelComplexityUpdateMode.DistanceToggle)
				{
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C71E0", Offset = "0x11C5BE0", VA = "0x1811C71E0")]
		public LevelComplexityManager()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
