using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A2")]
	public class GhostMode : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008A3")]
		public delegate void ChangingMaterial(bool inGhostMode);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030A9")]
		[ItemID]
		[SerializeField]
		private int activeWhen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030AA")]
		[SerializeField]
		private AssetReference vfxAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030AB")]
		[SerializeField]
		private AssetReference materialAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030AC")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030AD")]
		private GameObject vfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40030AE")]
		private List<Material> materials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40030AF")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x170005D6")]
		private Item ActiveWhenItem
		{
			[Cpp2IlInjected.Token(Token = "0x60027EE")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDF0", Offset = "0x8CA7F0", VA = "0x1808CBDF0")]
			get
			{
				long num = Convert.ToInt64((uint)activeWhen);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005D7")]
		private bool HasActiveWhen
		{
			[Cpp2IlInjected.Token(Token = "0x60027EF")]
			[Cpp2IlInjected.Address(RVA = "0x8CBE50", Offset = "0x8CA850", VA = "0x1808CBE50")]
			get
			{
				long num = Convert.ToInt64((uint)activeWhen);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005D")]
		public event ChangingMaterial OnChangingMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x60027F0")]
			[Cpp2IlInjected.Address(RVA = "0x8CBD50", Offset = "0x8CA750", VA = "0x1808CBD50")]
			[CompilerGenerated]
			add
			{
				ChangingMaterial onChangingMaterial = this.OnChangingMaterial;
				Delegate @delegate = Delegate.Combine(onChangingMaterial, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onChangingMaterial)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60027F1")]
			[Cpp2IlInjected.Address(RVA = "0x8CBF10", Offset = "0x8CA910", VA = "0x1808CBF10")]
			[CompilerGenerated]
			remove
			{
				ChangingMaterial onChangingMaterial = this.OnChangingMaterial;
				Delegate @delegate = Delegate.Remove(onChangingMaterial, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onChangingMaterial)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F2")]
		[Cpp2IlInjected.Address(RVA = "0x8CBC70", Offset = "0x8CA670", VA = "0x1808CBC70")]
		private void Start()
		{
			long num = Convert.ToInt64((uint)activeWhen);
			bool flag = default(bool);
			if (flag)
			{
				CreateEventHandler();
				int conditionListener = 0;
				OnAnyConditionChanged((ConditionListener)conditionListener);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F3")]
		[Cpp2IlInjected.Address(RVA = "0x8CBC20", Offset = "0x8CA620", VA = "0x1808CBC20")]
		private void OnDestroy()
		{
			//IL_001a: Expected O, but got I8
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			if (isActive)
			{
				Deactivate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F4")]
		[Cpp2IlInjected.Address(RVA = "0x8CB5B0", Offset = "0x8C9FB0", VA = "0x1808CB5B0")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)activeWhen);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027F5")]
		[Cpp2IlInjected.Address(RVA = "0x8CB8A0", Offset = "0x8CA2A0", VA = "0x1808CB8A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60027F6")]
		[Cpp2IlInjected.Address(RVA = "0x8CB8D0", Offset = "0x8CA2D0", VA = "0x1808CB8D0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			bool flag = isActive;
			int num = activeWhen;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag2 = default(bool);
			isActive = flag2;
			if (flag2 != flag)
			{
				if (flag2)
				{
					int num2 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
					throw new NullReferenceException();
				}
				Deactivate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CB490", Offset = "0x8C9E90", VA = "0x1808CB490")]
		[AsyncStateMachine(typeof(_003CActivate_003Ed__20))]
		private Task Activate()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CB7A0", Offset = "0x8CA1A0", VA = "0x1808CB7A0")]
		private void Deactivate()
		{
			//Discarded unreachable code: IL_0051
			//IL_0014: Expected O, but got I8
			//IL_0024: Expected O, but got I4
			UnityEngine.Object.Destroy(vfx);
			vfx = (GameObject)0;
			Renderer component = GetComponent<Renderer>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				Material[] materialArray = (Material[])(object)((List<T>)(object)materials).ToArray();
				component.SetMaterialArray(materialArray);
				ChangingMaterial onChangingMaterial = this.OnChangingMaterial;
				if (onChangingMaterial != null)
				{
					int inGhostMode = 0;
					onChangingMaterial((byte)inGhostMode != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027F9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GhostMode()
		{
		}
	}
}
