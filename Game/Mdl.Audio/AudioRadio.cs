using System;
using Cpp2IlInjected;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B0E")]
	public class AudioRadio : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D7C")]
		public GameObject radioEmmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D7D")]
		private GridObjectScript gridObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003D7E")]
		private string radioID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003D7F")]
		private bool inPlayerHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003D80")]
		private Channel channel;

		[Cpp2IlInjected.Token(Token = "0x60032F4")]
		[Cpp2IlInjected.Address(RVA = "0x1506130", Offset = "0x1504B30", VA = "0x181506130")]
		private void Awake()
		{
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			bool flag = (inPlayerHouse = (long)"{il2cpp field on {'constant24' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 3);
			radioID = "";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032F5")]
		[Cpp2IlInjected.Address(RVA = "0x1506AC0", Offset = "0x15054C0", VA = "0x181506AC0")]
		private void Start()
		{
			//IL_002a: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			if (!inPlayerHouse)
			{
				GridObjectScript gridObjectScript = (gridObj = GetComponent<GridObjectScript>());
				GridObjectScript gridObjectScript2 = gridObj;
				int num = 0;
				if (!(gridObjectScript2 != (UnityEngine.Object)num))
				{
					return;
				}
				GridScript _003CGridScript_003Ek__BackingField = gridObj.GridScript;
				int num2 = 0;
				if (!(_003CGridScript_003Ek__BackingField != (UnityEngine.Object)num2))
				{
					return;
				}
				GridObjectScript gridObjectScript3 = gridObj;
				if ((long)gridObjectScript3.GridObject != 0)
				{
					uint gridID = gridObjectScript3.GridScript.GridID;
					uint iD_ = gridObj.GridObject.iD_;
					int itemID_ = gridObj.GridObject.itemID_;
					int num3 = 0;
					string text = (radioID = $"{gridID}_{gridID}_{gridID}");
					bool flag = inPlayerHouse;
					GameObject radioGameobj = radioEmmitter;
					string text2 = radioID;
					AudioManager audioManager = default(AudioManager);
					if (!audioManager.AddRadio(text2, radioGameobj, flag))
					{
						bool flag2 = inPlayerHouse;
						string text3 = radioID;
						AudioManager audioManager2 = default(AudioManager);
						audioManager2.ResumeRadio(text3, flag2);
					}
				}
				return;
			}
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032F6")]
		[Cpp2IlInjected.Address(RVA = "0x15065A0", Offset = "0x1504FA0", VA = "0x1815065A0")]
		private void GridObj_OnTransformUpdate(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_002a
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			bool flag = inPlayerHouse;
			GameObject gameObj = radioEmmitter;
			string text = radioID;
			system.UpdateRadio(text, gameObj, flag);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F7")]
		[Cpp2IlInjected.Address(RVA = "0x1506900", Offset = "0x1505300", VA = "0x181506900")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0088
			//IL_001e: Expected O, but got I4
			GridObjectScript gridObjectScript = (gridObj = GetComponent<GridObjectScript>());
			GridObjectScript gridObjectScript2 = gridObj;
			int num = 0;
			if (gridObjectScript2 != (UnityEngine.Object)num)
			{
				if (!string.IsNullOrEmpty(radioID))
				{
					bool flag = inPlayerHouse;
					string text = radioID;
					AudioManager audioManager = default(AudioManager);
					audioManager.ResumeRadio(text, flag);
				}
				GridObjectScript gridObjectScript3 = gridObj;
				EventHandler value = GridObj_OnTransformUpdate;
				gridObjectScript3.OnTransformUpdate -= value;
				GridObjectScript gridObjectScript4 = gridObj;
				EventHandler value2 = GridObj_OnTransformUpdate;
				gridObjectScript4.OnTransformUpdate += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F8")]
		[Cpp2IlInjected.Address(RVA = "0x1506230", Offset = "0x1504C30", VA = "0x181506230")]
		public void ChangeStation()
		{
			//Discarded unreachable code: IL_00b3
			//IL_0033: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			int num = 0;
			if ((inPlayerHouse ? 1 : 0) == num)
			{
				AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
				string text = radioID;
				bool flag = inPlayerHouse;
				Channel channel = this.channel;
				string text2 = ((Enum)channel).ToString();
				Channel channel2 = (this.channel = channel);
				system.InteractWithRadio(text, flag, text2);
				this.channel = (Channel)num;
			}
			Channel curHouseRadioChan = SystemRoot.Instance.GetSystem<AudioManager>().GetCurHouseRadioChan();
			AudioManager system2 = SystemRoot.Instance.GetSystem<AudioManager>();
			string text3 = radioID;
			bool flag2 = inPlayerHouse;
			Channel channel3 = default(Channel);
			string text4 = ((Enum)channel3).ToString();
			Channel channel4 = channel3;
			system2.InteractWithRadio(text3, flag2, text4);
			string text5 = radioID;
			MonoBehaviour.print("audiotest : change station " + text5);
		}

		[Cpp2IlInjected.Token(Token = "0x60032F9")]
		[Cpp2IlInjected.Address(RVA = "0x1506770", Offset = "0x1505170", VA = "0x181506770")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_0064
			//IL_0010: Expected O, but got I4
			GridObjectScript gridObjectScript = gridObj;
			int num = 0;
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				GridObjectScript gridObjectScript2 = gridObj;
				EventHandler value = GridObj_OnTransformUpdate;
				gridObjectScript2.OnTransformUpdate -= value;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				AudioManager system = _003CInstance_003Ek__BackingField.GetSystem<AudioManager>();
				if ((object)system != null)
				{
					bool flag = inPlayerHouse;
					string text = radioID;
					system.PauseRadio(text, flag);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032FA")]
		[Cpp2IlInjected.Address(RVA = "0x1506690", Offset = "0x1505090", VA = "0x181506690")]
		public void OnDestroy()
		{
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				AudioManager system = _003CInstance_003Ek__BackingField.GetSystem<AudioManager>();
				if ((object)system != null)
				{
					bool flag = inPlayerHouse;
					string text = radioID;
					system.RemoveRadio(text, flag);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032FB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AudioRadio()
		{
		}
	}
}
