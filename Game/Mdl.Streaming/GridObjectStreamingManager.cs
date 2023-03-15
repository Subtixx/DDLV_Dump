using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta.Util;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x2000806")]
	public class GridObjectStreamingManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002CC2")]
		public StreamingManagerConfig DefaultConfig;

		[Cpp2IlInjected.Token(Token = "0x4002CC3")]
		private static StreamingManagerConfig _config;

		[Cpp2IlInjected.Token(Token = "0x4002CC4")]
		private static GridObjectStreamingManager _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CC5")]
		private List<CullingGroupStreamingManager> CullingGroupStreamingManagers;

		[Cpp2IlInjected.Token(Token = "0x1700050F")]
		public static StreamingManagerConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x60023E5")]
			[Cpp2IlInjected.Address(RVA = "0x1539EC0", Offset = "0x15388C0", VA = "0x181539EC0")]
			get
			{
				return _config;
			}
			[Cpp2IlInjected.Token(Token = "0x60023E6")]
			[Cpp2IlInjected.Address(RVA = "0x153A070", Offset = "0x1538A70", VA = "0x18153A070")]
			set
			{
				//Discarded unreachable code: IL_00da
				//IL_000f: Expected O, but got I4
				//IL_00bb: Expected O, but got I4
				GridObjectStreamingManager instance = _instance;
				int num = 0;
				if (!(instance == (UnityEngine.Object)num))
				{
					bool flag = _config == value;
					StreamingManagerConfig config = _config;
					if (!flag)
					{
						string text = config.name;
						string text2 = value.name;
						int num2 = 0;
						Debug.Log("Assigning new StreamingManagerConfig after the GridObjectStreamingManager from " + text + " to " + text2);
						_config = value;
						_instance.ReinitCullingManagers();
						return;
					}
					string text3 = config.name;
				}
				int num3 = 0;
				if (DebugSettings.Settings.overrideStreamingConfig_ == StreamingConfigOverrideType.PlatformDefault)
				{
					_config = value;
					string text4 = _config.name;
					Debug.Log("Assigned StreamingConfig _config=" + text4);
					return;
				}
				int num4 = 0;
				StreamingConfigOverrideType overrideStreamingConfig_ = DebugSettings.Settings.overrideStreamingConfig_;
				Debug.Log($"Applying DebugSettings.Settings.StreamingConfigOverrideType={overrideStreamingConfig_}");
				int num5 = 0;
				StreamingConfigOverrideType overrideStreamingConfig_2 = DebugSettings.Settings.overrideStreamingConfig_;
				int num6 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000510")]
		public StreamingManagerConfig ActiveConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60023E7")]
			[Cpp2IlInjected.Address(RVA = "0x1539DF0", Offset = "0x15387F0", VA = "0x181539DF0")]
			get
			{
				//IL_000f: Expected O, but got I4
				StreamingManagerConfig config = _config;
				int num = 0;
				if (config != (UnityEngine.Object)num)
				{
					return _config;
				}
				return DefaultConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000511")]
		public static GridObjectStreamingManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60023E8")]
			[Cpp2IlInjected.Address(RVA = "0x153A030", Offset = "0x1538A30", VA = "0x18153A030")]
			get
			{
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000512")]
		public static bool HasGridObjectStreamingActive
		{
			[Cpp2IlInjected.Token(Token = "0x60023E9")]
			[Cpp2IlInjected.Address(RVA = "0x1539F00", Offset = "0x1538900", VA = "0x181539F00")]
			get
			{
				//IL_000f: Expected O, but got I4
				GridObjectStreamingManager instance = _instance;
				int num = 0;
				if (instance != (UnityEngine.Object)num)
				{
					List<CullingGroupStreamingManager> cullingGroupStreamingManagers = _instance.CullingGroupStreamingManagers;
					int num2 = 0;
					return !DebugSettings.Settings.disableGridObjStreaming_;
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023E4")]
		[Cpp2IlInjected.Address(RVA = "0x1538CC0", Offset = "0x15376C0", VA = "0x181538CC0")]
		[AsyncStateMachine(typeof(_003CAssignOverrideStreamingConfigAsync_003Ed__0))]
		private static Task AssignOverrideStreamingConfigAsync(StreamingConfigOverrideType configType)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60023EA")]
		[Cpp2IlInjected.Address(RVA = "0x1538DC0", Offset = "0x15377C0", VA = "0x181538DC0")]
		protected void Awake()
		{
			//Discarded unreachable code: IL_0036
			//IL_000f: Expected O, but got I4
			GridObjectStreamingManager instance = _instance;
			int num = 0;
			if (instance != (UnityEngine.Object)num)
			{
				Debug.LogError("GridObjectStreamingManager is expected to be a singleton but is not null", this);
			}
			_config = (StreamingManagerConfig)(object)this;
			InitCullingGroupManagers();
			int num2 = 0;
			StreamableGridObjectDatabase.Instance.Load();
		}

		[Cpp2IlInjected.Token(Token = "0x60023EB")]
		[Cpp2IlInjected.Address(RVA = "0x15391D0", Offset = "0x1537BD0", VA = "0x1815391D0")]
		private void DestroyCullingGroupManagers(List<CullingGroupStreamingManager> mgrs)
		{
			//Discarded unreachable code: IL_0095, IL_00b9, IL_00bf
			bool flag = default(bool);
			if (flag)
			{
				string[] array = new string[5];
				if ("StreamingManagerConfig Destorying Mgr=" != null && "StreamingManagerConfig Destorying Mgr=" == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[0] = "StreamingManagerConfig Destorying Mgr=";
				string text = default(string);
				if (text != null && text == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[1] = text;
				if ("(" != null && "(" == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[2] = "(";
				if (text != null && "(" == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[3] = text;
				if (")" != null && ")" == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[4] = ")";
				Debug.Log(string.Concat(array));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023EC")]
		[Cpp2IlInjected.Address(RVA = "0x1539720", Offset = "0x1538120", VA = "0x181539720")]
		private void InitCullingGroupManagers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023ED")]
		[Cpp2IlInjected.Address(RVA = "0x15399E0", Offset = "0x15383E0", VA = "0x1815399E0")]
		private void ReinitCullingManagers()
		{
			//Discarded unreachable code: IL_0026, IL_002c, IL_0032, IL_0038, IL_003e
			//IL_001f: Expected O, but got I4
			int num = 0;
			List<CullingGroupStreamingManager> cullingGroupStreamingManagers = CullingGroupStreamingManagers;
			InitCullingGroupManagers();
			bool flag = default(bool);
			if (flag)
			{
				if (num != 0)
				{
					CullingGroupStreamingManager cullingGroupStreamingManager = default(CullingGroupStreamingManager);
					bool flag2 = cullingGroupStreamingManager.AddAsset((ICullable)num);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023EE")]
		[Cpp2IlInjected.Address(RVA = "0x1539980", Offset = "0x1538380", VA = "0x181539980")]
		protected void OnDestroy()
		{
			//IL_0009: Expected O, but got I4
			//IL_000f: Expected O, but got I4
			int num = 0;
			CullingGroupStreamingManagers = (List<CullingGroupStreamingManager>)num;
			_config = (StreamingManagerConfig)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023EF")]
		[Cpp2IlInjected.Address(RVA = "0x15395C0", Offset = "0x1537FC0", VA = "0x1815395C0")]
		public CullingGroupStreamingManager GetCullingGroupManager(StreamableAssetRefType myType, float myHeight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023F0")]
		[Cpp2IlInjected.Address(RVA = "0x1539CE0", Offset = "0x15386E0", VA = "0x181539CE0")]
		public void SetOSDEnable(bool isEnable)
		{
			//Discarded unreachable code: IL_000c
			List<CullingGroupStreamingManager> cullingGroupStreamingManagers = CullingGroupStreamingManagers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F1")]
		[Cpp2IlInjected.Address(RVA = "0x1538F00", Offset = "0x1537900", VA = "0x181538F00")]
		public void DebugUpdateAllBoundingSphere()
		{
			//Discarded unreachable code: IL_000c
			List<CullingGroupStreamingManager> cullingGroupStreamingManagers = CullingGroupStreamingManagers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F2")]
		[Cpp2IlInjected.Address(RVA = "0x1539BC0", Offset = "0x15385C0", VA = "0x181539BC0")]
		public void SetAllCullingManagerEnable(bool isEnable)
		{
			//Discarded unreachable code: IL_0013
			base.enabled = isEnable;
			List<CullingGroupStreamingManager> cullingGroupStreamingManagers = CullingGroupStreamingManagers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F3")]
		[Cpp2IlInjected.Address(RVA = "0x15390F0", Offset = "0x1537AF0", VA = "0x1815390F0")]
		public void DebugUpdateDistanceBandForConfig(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023F4")]
		[Cpp2IlInjected.Address(RVA = "0x1538FF0", Offset = "0x15379F0", VA = "0x181538FF0")]
		public void DebugUpdateAllDistanceBandConfigs()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023F5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GridObjectStreamingManager()
		{
		}
	}
}
