using System;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000716")]
	public class AttentionVFX : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002939")]
		[SerializeField]
		private AttentionVFXData _data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400293A")]
		[SerializeField]
		private Transform parentOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400293B")]
		[SerializeField]
		[ItemID]
		private int _conditionItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400293C")]
		private GameObject attentionVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400293D")]
		private bool conditionIsTrue = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400293E")]
		private bool isPaused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400293F")]
		private Transform myTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002940")]
		private Transform avatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002941")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x6001F6C")]
		[Cpp2IlInjected.Address(RVA = "0xA466F0", Offset = "0xA450F0", VA = "0x180A466F0")]
		private void Start()
		{
			int conditionItemID = _conditionItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)conditionItemID);
			ConditionItemData conditionItemData = default(ConditionItemData);
			if (conditionItemData != null)
			{
				CreateEventHandler();
				ConditionsList conditions_ = conditionItemData.conditions_;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				bool flag = (conditionIsTrue = conditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField));
			}
			Transform transform = (myTransform = base.transform);
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			Transform _003Ctransform_003Ek__BackingField = default(Transform);
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				_003Ctransform_003Ek__BackingField = _003CInstance_003Ek__BackingField2._avatar.transform;
			}
			avatarTransform = _003Ctransform_003Ek__BackingField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6D")]
		[Cpp2IlInjected.Address(RVA = "0xA466D0", Offset = "0xA450D0", VA = "0x180A466D0")]
		public void Pause()
		{
			isPaused = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6E")]
		[Cpp2IlInjected.Address(RVA = "0xA466E0", Offset = "0xA450E0", VA = "0x180A466E0")]
		public void Resume()
		{
			isPaused = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F6F")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45400", VA = "0x180A46A00")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_00d8
			//IL_0017: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			int num = 0;
			GameObject attentionVFXPrefab = _data.attentionVFXPrefab;
			int num2 = 0;
			if (!(attentionVFXPrefab != (UnityEngine.Object)num2))
			{
				return;
			}
			Transform transform = avatarTransform;
			int num3 = 0;
			if (!(transform != (UnityEngine.Object)num3))
			{
				return;
			}
			if (conditionIsTrue && !isPaused)
			{
				Transform transform2 = avatarTransform;
				Transform transform3 = myTransform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float num4 = MathExtensions.DistanceSq(in *(Vector3*)num, in *(Vector3*)num);
				float distanceToTrigger = _data.distanceToTrigger;
			}
			if (false)
			{
				bool flag;
				if (flag)
				{
					AttentionVFXData data = _data;
					Transform transform4 = parentOverride;
					GameObject attentionVFXPrefab2 = data.attentionVFXPrefab;
					int num5 = 0;
					Transform parent;
					if (transform4 != (UnityEngine.Object)num5)
					{
						parent = parentOverride;
					}
					GameObject gameObject = (attentionVFXInstance = UnityEngine.Object.Instantiate(attentionVFXPrefab2, parent));
				}
			}
			else
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				DestroyVFX();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F70")]
		[Cpp2IlInjected.Address(RVA = "0xA46650", Offset = "0xA45050", VA = "0x180A46650")]
		private void OnDisable()
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = attentionVFXInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				DestroyVFX();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F71")]
		[Cpp2IlInjected.Address(RVA = "0xA44AA0", Offset = "0xA434A0", VA = "0x180A44AA0")]
		private void OnDestroy()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F72")]
		[Cpp2IlInjected.Address(RVA = "0xA461E0", Offset = "0xA44BE0", VA = "0x180A461E0")]
		private void DestroyVFX()
		{
			//Discarded unreachable code: IL_007c
			//IL_0025: Expected O, but got I4
			//IL_007b: Expected F4, but got I4
			GameObject gameObject = attentionVFXInstance;
			int num = 0;
			ParticleSystem componentInChildren = (ParticleSystem)(object)gameObject.GetComponentInChildren<Animator>();
			Animator componentInChildren2 = gameObject.GetComponentInChildren<Animator>();
			int num2 = 0;
			if (componentInChildren2 != (UnityEngine.Object)num2 && !string.IsNullOrEmpty(_data.endClipBool))
			{
				string endClipBool = _data.endClipBool;
				componentInChildren2.SetBool(endClipBool, value: true);
			}
			UnityEngine.Object.Destroy(this);
			int num3 = 0;
			int num4 = 0;
			if (0L < (long)(IntPtr)componentInChildren)
			{
				ParticleSystem.MinMaxCurve minMaxCurve = default(ParticleSystem.MinMaxCurve);
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
				num3++;
			}
			DestroyAfterTime destroyAfterTime = default(DestroyAfterTime);
			destroyAfterTime.destroyAfterSeconds = num4;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F73")]
		[Cpp2IlInjected.Address(RVA = "0xA46490", Offset = "0xA44E90", VA = "0x180A46490")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0025
			int conditionItemID = _conditionItemID;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag = default(bool);
			conditionIsTrue = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F74")]
		[Cpp2IlInjected.Address(RVA = "0xA46000", Offset = "0xA44A00", VA = "0x180A46000")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)_conditionItemID);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F75")]
		[Cpp2IlInjected.Address(RVA = "0xA44AA0", Offset = "0xA434A0", VA = "0x180A44AA0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F76")]
		[Cpp2IlInjected.Address(RVA = "0xA46CA0", Offset = "0xA456A0", VA = "0x180A46CA0")]
		public AttentionVFX()
		{
		}
	}
}
