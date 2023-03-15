using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Log;
using Mdl.Systems;
using Serilog;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000781")]
	public class MdlAddressables : Mdl.Systems.System, IAddressableDownloadEvent
	{
		[Cpp2IlInjected.Token(Token = "0x2000782")]
		public enum DownloadEvent
		{
			[Cpp2IlInjected.Token(Token = "0x4002B12")]
			DownloadProgress
		}

		[Cpp2IlInjected.Token(Token = "0x2000783")]
		private struct OperationHelper<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002B13")]
			public object key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002B14")]
			public AsyncOperationHandle<T> op;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002B15")]
			public bool is_downloading;
		}

		[Cpp2IlInjected.Token(Token = "0x4002B0C")]
		private static bool _debugIsTracingNavMeshObstableWithCarving;

		[Cpp2IlInjected.Token(Token = "0x4002B0D")]
		private static int _instantiatedWithCarving;

		[Cpp2IlInjected.Token(Token = "0x4002B0E")]
		private static int _instantiatedWithCarvingComponentCount;

		[Cpp2IlInjected.Token(Token = "0x170004A8")]
		public unsafe static bool DebugIsTracingNavMeshObstableWithCarving
		{
			[Cpp2IlInjected.Token(Token = "0x6002156")]
			[Cpp2IlInjected.Address(RVA = "0xBC1A10", Offset = "0xBC0410", VA = "0x180BC1A10")]
			get
			{
				return _debugIsTracingNavMeshObstableWithCarving;
			}
			[Cpp2IlInjected.Token(Token = "0x6002157")]
			[Cpp2IlInjected.Address(RVA = "0xBC1B10", Offset = "0xBC0510", VA = "0x180BC1B10")]
			set
			{
				//Discarded unreachable code: IL_0025, IL_0070
				//IL_001a: Expected O, but got I4
				//IL_003c: Expected O, but got I4
				//IL_0061: Expected O, but got I4
				_debugIsTracingNavMeshObstableWithCarving = value;
				int num = 0;
				DebugOnScreenText instance = DebugOnScreenText.Instance;
				int num2 = default(int);
				DebugOnScreenText.AddOnScreenText value2 = new DebugOnScreenText.AddOnScreenText(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StringBuilder, void>*/)(&OnScreenDebugText));
				num2 = 0;
				instance.OnAddOnScreenText -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x4002B10")]
		private Serilog.ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x600215A")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get;
		} = Serilogger.Create<MdlAddressables>();


		[Cpp2IlInjected.Token(Token = "0x1400004B")]
		public event AddressableDownloadEvent OnDownloadEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002158")]
			[Cpp2IlInjected.Address(RVA = "0xBC1970", Offset = "0xBC0370", VA = "0x180BC1970", Slot = "8")]
			[CompilerGenerated]
			add
			{
				AddressableDownloadEvent onDownloadEvent = this.OnDownloadEvent;
				Delegate @delegate = Delegate.Combine(onDownloadEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDownloadEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002159")]
			[Cpp2IlInjected.Address(RVA = "0xBC1A70", Offset = "0xBC0470", VA = "0x180BC1A70", Slot = "9")]
			[CompilerGenerated]
			remove
			{
				AddressableDownloadEvent onDownloadEvent = this.OnDownloadEvent;
				Delegate @delegate = Delegate.Remove(onDownloadEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDownloadEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600215B")]
		[Cpp2IlInjected.Address(RVA = "0x19C94A0", Offset = "0x19C7EA0", VA = "0x1819C94A0")]
		public static AsyncOperationHandle<T> LoadAssetAsync<T>(object key)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600215C")]
		[Cpp2IlInjected.Address(RVA = "0xBC17D0", Offset = "0xBC01D0", VA = "0x180BC17D0")]
		private static object TweakKey(object key)
		{
			if (key != null && key != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					Debug.LogWarning($"Load|Instanciate(Scene)Async with address {key}. we should always use guid.");
				}
			}
			return key;
		}

		[Cpp2IlInjected.Token(Token = "0x600215D")]
		[Cpp2IlInjected.Address(RVA = "0xBC1110", Offset = "0xBBFB10", VA = "0x180BC1110")]
		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode mode = LoadSceneMode.Single)
		{
			//IL_0006: Expected O, but got I4
			object obj = TweakKey(mode);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600215E")]
		[Cpp2IlInjected.Address(RVA = "0xBC0C60", Offset = "0xBBF660", VA = "0x180BC0C60")]
		[AsyncStateMachine(typeof(_003CInstantiateAsyncAndWaitForVisual_003Ed__16))]
		public static Task<GameObject> InstantiateAsyncAndWaitForVisual(AsyncOperationHandle<GameObject> mainHandle, bool forceStreamable)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600215F")]
		[Cpp2IlInjected.Address(RVA = "0xBC0830", Offset = "0xBBF230", VA = "0x180BC0830")]
		public unsafe static Task<GameObject> InstantiateAsyncAndWaitForVisual(object key, Vector3 position, Quaternion rotation, [System.Runtime.InteropServices.Optional] Transform parent, bool forceStreamable = true)
		{
			//IL_001b: Expected O, but got I4
			object obj = TweakKey(key);
			float z = position.z;
			int num = default(int);
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<AsyncOperationHandle<GameObject>, void>*/)(&LogCarving));
			num = 0;
			Task<GameObject> result = default(Task<GameObject>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002160")]
		[Cpp2IlInjected.Address(RVA = "0xBC0A60", Offset = "0xBBF460", VA = "0x180BC0A60")]
		public unsafe static Task<GameObject> InstantiateAsyncAndWaitForVisual(object key, [System.Runtime.InteropServices.Optional] Transform parent, bool instantiateInWorldSpace = false, bool forceStreamable = true)
		{
			//IL_0014: Expected O, but got I4
			object obj = TweakKey(key);
			int num = default(int);
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<AsyncOperationHandle<GameObject>, void>*/)(&LogCarving));
			num = 0;
			Task<GameObject> result = default(Task<GameObject>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002161")]
		[Cpp2IlInjected.Address(RVA = "0xBC0DA0", Offset = "0xBBF7A0", VA = "0x180BC0DA0")]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, [System.Runtime.InteropServices.Optional] Transform parent)
		{
			//IL_001d: Expected O, but got I4
			int num = 0;
			object obj = TweakKey(position);
			float z = rotation.z;
			int num2 = default(int);
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<AsyncOperationHandle<GameObject>, void>*/)(&LogCarving));
			num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002162")]
		[Cpp2IlInjected.Address(RVA = "0xBC0F70", Offset = "0xBBF970", VA = "0x180BC0F70")]
		public unsafe static AsyncOperationHandle<GameObject> InstantiateAsync(object key, [System.Runtime.InteropServices.Optional] Transform parent, bool instantiateInWorldSpace = false)
		{
			//IL_0016: Expected O, but got I4
			int num = 0;
			object obj = TweakKey(parent);
			int num2 = default(int);
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<AsyncOperationHandle<GameObject>, void>*/)(&LogCarving));
			num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002163")]
		[Cpp2IlInjected.Address(RVA = "0xBC11E0", Offset = "0xBBFBE0", VA = "0x180BC11E0")]
		private unsafe static void LogCarving(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_00a1, IL_00a7, IL_00ad
			int num = 0;
			Debug.Log("[carving] : LogCarving was called even if DebugIsTracingNavMeshObstableWithCarving is false, this is not performance friendly");
			GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)obj)->Result;
			int includeInactive = 0;
			NavMeshObstacle[] componentsInChildren = result.GetComponentsInChildren<NavMeshObstacle>((byte)includeInactive != 0);
			Func<NavMeshObstacle, bool> func = default(Func<NavMeshObstacle, bool>);
			if (_003C_003Ec._003C_003E9__21_0 == null)
			{
				func = (Func<NavMeshObstacle, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NavMeshObstacle x) => x.carving));
			}
			bool flag = Enumerable.Any<NavMeshObstacle>(Enumerable.Where<NavMeshObstacle>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func));
			if (flag)
			{
			}
			GameObject gameObject2 = default(GameObject);
			if (flag)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0094;
					}
					num++;
				}
				GameObject gameObject = default(GameObject);
				string text = gameObject.name;
				string debugName = ((AsyncOperationHandle<TObject>*)obj)->DebugName;
				Debug.Log("[carving] : InstantiateAsync loaded a component with for gameobject: " + text + " handle.DebugName=" + debugName, gameObject2);
				goto IL_0094;
			}
			goto IL_009b;
			IL_009b:
			if (!flag)
			{
			}
			return;
			IL_0094:
			gameObject2 = (GameObject)(object)((object)gameObject2 + (object)gameObject2);
			goto IL_009b;
		}

		[Cpp2IlInjected.Token(Token = "0x6002164")]
		[Cpp2IlInjected.Address(RVA = "0xBC16A0", Offset = "0xBC00A0", VA = "0x180BC16A0")]
		private static void OnScreenDebugText(StringBuilder dest)
		{
			//Discarded unreachable code: IL_003a
			//IL_002d: Expected O, but got I4
			StringBuilder stringBuilder = dest.AppendLine("Streaming->TraceLoadedCarving ON have perf impact");
			int instantiatedWithCarving = _instantiatedWithCarving;
			string value = default(string);
			StringBuilder stringBuilder2 = dest.AppendLine(value);
			int instantiatedWithCarvingComponentCount = _instantiatedWithCarvingComponentCount;
			string value2 = $"Carving component cnt :  {instantiatedWithCarvingComponentCount}";
			StringBuilder stringBuilder3 = dest.AppendLine(value2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002165")]
		[Cpp2IlInjected.Address(RVA = "0x19C9560", Offset = "0x19C7F60", VA = "0x1819C9560")]
		[AsyncStateMachine(typeof(_003CLoadAssetsAsync_003Ed__24<>))]
		public static Task<> LoadAssetsAsync<T>(List<> cpp2il__autoParamName__idx_0)
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002166")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002167")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void OnSystemStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002168")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002169")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600216A")]
		[Cpp2IlInjected.Address(RVA = "0xBC18F0", Offset = "0xBC02F0", VA = "0x180BC18F0")]
		public MdlAddressables()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600216B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static MdlAddressables()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
