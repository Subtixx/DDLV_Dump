using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005B8")]
	public class TimelineDisableGridObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002348")]
		[SerializeField]
		[ItemID]
		private List<int> items;

		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		private List<Item> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600197F")]
			[Cpp2IlInjected.Address(RVA = "0x13CE300", Offset = "0x13CCD00", VA = "0x1813CE300")]
			get
			{
				List<int> list = items;
				Func<int, Item> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
				}
				return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__2_));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001980")]
		[Cpp2IlInjected.Address(RVA = "0x13CDEF0", Offset = "0x13CC8F0", VA = "0x1813CDEF0")]
		public void DisableGridObject()
		{
			//Discarded unreachable code: IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cc
			int num = 0;
			int num2 = 0;
			List<int> list = items;
			Func<int, Item> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
			if (_003C_003E9__2_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
			}
			List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__2_));
			bool flag = default(bool);
			if (flag)
			{
				Client client = default(Client);
				GridCollection gridCollection_ = client.profile.world_.gridCollection_;
				if (_003C_003E9__2_ != null)
				{
					SceneData sceneData = default(SceneData);
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					GameObject gameObject = default(GameObject);
					VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
					GridObjectScript gridObjectScript = default(GridObjectScript);
					GameObject gameObject2 = gridObjectScript.gameObject;
					int active = 0;
					gameObject2.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001981")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineDisableGridObject()
		{
		}
	}
}
