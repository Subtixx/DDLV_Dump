using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006A7")]
	public class VillageSubEnvironment : Environment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400275A")]
		public Switch Switcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400275B")]
		private GridScript[] gridScriptsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400275C")]
		[SerializeField]
		private bool overrideCameraClearFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400275D")]
		[SerializeField]
		private CameraClearFlags sceneCameraClearFlag = CameraClearFlags.Skybox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400275E")]
		private CameraClearFlags oldCameraClearFlag = CameraClearFlags.Skybox;

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public override IEnumerable<GridScript> GridScriptsList
		{
			[Cpp2IlInjected.Token(Token = "0x6001D8A")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "4")]
			get
			{
				GridScript[] array = gridScriptsList;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8B")]
		[Cpp2IlInjected.Address(RVA = "0xD48630", Offset = "0xD47030", VA = "0x180D48630")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			if (Application.platform != 0)
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return;
				}
			}
			if (overrideCameraClearFlag)
			{
				CameraClearFlags cameraClearFlags = (oldCameraClearFlag = SystemRoot.Instance._playerCamera.clearFlags);
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				CameraClearFlags cameraClearFlags3 = (playerCamera.clearFlags = sceneCameraClearFlag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8C")]
		[Cpp2IlInjected.Address(RVA = "0xD48B00", Offset = "0xD47500", VA = "0x180D48B00")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0038
			int num = 0;
			if (Application.platform != 0)
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return;
				}
			}
			if (overrideCameraClearFlag)
			{
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				CameraClearFlags cameraClearFlags2 = (playerCamera.clearFlags = oldCameraClearFlag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8D")]
		[Cpp2IlInjected.Address(RVA = "0xD48980", Offset = "0xD47380", VA = "0x180D48980", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8E")]
		[Cpp2IlInjected.Address(RVA = "0xD48910", Offset = "0xD47310", VA = "0x180D48910")]
		public GridScript GetGridScript(IGrid grid)
		{
			GridScript[] array = gridScriptsList;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				GridScript gridScript = array[num];
				if (gridScript.Grid != grid)
				{
					num++;
				}
				return gridScript;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D8F")]
		[Cpp2IlInjected.Address(RVA = "0xD488E0", Offset = "0xD472E0", VA = "0x180D488E0", Slot = "12")]
		public override GridScript GetCurrentGrid(Vector3 position, out bool voidGrid)
		{
			float z = position.z;
			GridScript[] array = gridScriptsList;
			GridScript result = default(GridScript);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D90")]
		[Cpp2IlInjected.Address(RVA = "0xD487A0", Offset = "0xD471A0", VA = "0x180D487A0", Slot = "5")]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			Switch switcher = Switcher;
			GameObject value = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
			switcher.SetValue(value);
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D91")]
		[Cpp2IlInjected.Address(RVA = "0xD48BF0", Offset = "0xD475F0", VA = "0x180D48BF0")]
		public VillageSubEnvironment()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0012: Expected I4, but got I8

	}
}
