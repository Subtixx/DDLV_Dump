using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Streaming;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000719")]
	public class AvatarProximityAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002945")]
		public GameObject triggerPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002946")]
		public float triggerDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002947")]
		public string triggerEventName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002948")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002949")]
		private List<Animator> animators = (List<Animator>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400294A")]
		private StreamableAssetRef streamableAssetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400294B")]
		private bool mustTrigger;

		[Cpp2IlInjected.Token(Token = "0x6001F7D")]
		[Cpp2IlInjected.Address(RVA = "0x151F300", Offset = "0x151DD00", VA = "0x18151F300")]
		public void Start()
		{
			//Discarded unreachable code: IL_009c
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			bool flag = default(bool);
			if (!flag)
			{
				List<Animator> list = animators;
				((Component)this).GetComponentsInChildren<Animator>((List<>)(object)list);
			}
			StreamableAssetRef streamableAssetRef = this.streamableAssetRef;
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetChanged);
			streamableAssetRef.add_OnLoadedAssetChanged((Action<>)(object)action);
			StreamableAssetRef streamableAssetRef2 = this.streamableAssetRef;
			Action<AsyncOperationHandle<GameObject>> action2 = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetLoadComplete);
			streamableAssetRef2.add_OnLoadedAssetLoadComplete((Action<>)(object)action2);
			if (this.streamableAssetRef.IsLoaded)
			{
				StreamableAssetRef streamableAssetRef3 = this.streamableAssetRef;
				List<Animator> list2 = animators;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(CurseSystemStateChanged);
				bool flag3 = default(bool);
				base.enabled = flag3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7E")]
		[Cpp2IlInjected.Address(RVA = "0x151F020", Offset = "0x151DA20", VA = "0x18151F020")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_0063
			//IL_0010: Expected O, but got I4
			StreamableAssetRef streamableAssetRef = this.streamableAssetRef;
			int num = 0;
			if (streamableAssetRef != (UnityEngine.Object)num)
			{
				StreamableAssetRef streamableAssetRef2 = this.streamableAssetRef;
				Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetChanged);
				streamableAssetRef2.remove_OnLoadedAssetChanged((Action<>)(object)action);
				StreamableAssetRef streamableAssetRef3 = this.streamableAssetRef;
				Action<AsyncOperationHandle<GameObject>> action2 = (Action<AsyncOperationHandle<GameObject>>)(object)new Action<T>(OnLoadedAssetLoadComplete);
				streamableAssetRef3.remove_OnLoadedAssetLoadComplete((Action<>)(object)action2);
			}
			bool flag = default(bool);
			if (flag)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(CurseSystemStateChanged);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7F")]
		[Cpp2IlInjected.Address(RVA = "0x151F210", Offset = "0x151DC10", VA = "0x18151F210")]
		private unsafe void OnLoadedAssetChanged(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0015
			if (!((AsyncOperationHandle<TObject>*)obj)->IsValid())
			{
				((List<T>)(object)animators).Clear();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F80")]
		[Cpp2IlInjected.Address(RVA = "0x151F290", Offset = "0x151DC90", VA = "0x18151F290")]
		private unsafe void OnLoadedAssetLoadComplete(AsyncOperationHandle<GameObject> obj)
		{
			//Discarded unreachable code: IL_0016
			GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)obj)->Result;
			List<Animator> list = animators;
			result.GetComponentsInChildren<Animator>((List<>)(object)list);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F81")]
		[Cpp2IlInjected.Address(RVA = "0x151F010", Offset = "0x151DA10", VA = "0x18151F010")]
		private void CurseSystemStateChanged(object sender, bool isActive)
		{
			base.enabled = isActive;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F82")]
		[Cpp2IlInjected.Address(RVA = "0x151F690", Offset = "0x151E090", VA = "0x18151F690")]
		public void Update()
		{
			//Discarded unreachable code: IL_0083
			List<Animator> list = animators;
			if (!avatar.gameObject.activeInHierarchy)
			{
				return;
			}
			PlayerAvatar playerAvatar = avatar;
			bool flag = mustTrigger;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
			GameObject gameObject = triggerPosition;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform = gameObject.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			bool flag2 = default(bool);
			mustTrigger = flag2;
			if (!flag && flag2)
			{
				List<Animator> list2 = animators;
				Action<Animator> action = (Action<Animator>)(object)(Action<T>)delegate(Animator x)
				{
					//Discarded unreachable code: IL_000f
					string trigger = triggerEventName;
					x.SetTrigger(trigger);
				};
				((List<T>)(object)list2).ForEach((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F83")]
		[Cpp2IlInjected.Address(RVA = "0x151F830", Offset = "0x151E230", VA = "0x18151F830")]
		public AvatarProximityAnimation()
		{
		}
	}
}
