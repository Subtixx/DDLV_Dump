using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Graphic.Lighting;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Grids;
using UnityEngine;
using UnityEngine.ResourceManagement.Diagnostics;

[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LightToggle : GridObjectStateUser, IToggeableState, IPlayerTaskData
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public delegate void Change(bool value);

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public Light[] lights;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public GameObject[] gameObjectsToToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public Renderer[] renderersForEmissive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private MaterialPropertyBlock materialPropertyBlock;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static bool _globalStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private SceneLightsManager sceneLightsManager;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static bool globalStatus
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBB4D70", Offset = "0xBB3770", VA = "0x180BB4D70")]
		get
		{
			return _globalStatus;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xBB4E70", Offset = "0xBB3870", VA = "0x180BB4E70")]
		set
		{
			_globalStatus = value;
			Change change = LightToggle.changeAll;
			if (change != null)
			{
				bool value2 = _globalStatus;
				change(value2);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool IToggeableState.CurrentValue
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xBB4030", Offset = "0xBB2A30", VA = "0x180BB4030", Slot = "8")]
		get
		{
			//Discarded unreachable code: IL_002e
			do
			{
				GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null && state_.Toggle == null)
					{
					}
				}
			}
			while (false);
			return _globalStatus;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Change changeAll
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xBB4CB0", Offset = "0xBB36B0", VA = "0x180BB4CB0")]
		[CompilerGenerated]
		add
		{
			Change change = LightToggle.changeAll;
			Delegate @delegate = Delegate.Combine(change, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)typeof(LightToggle).TypeHandle != change)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xBB4DB0", Offset = "0xBB37B0", VA = "0x180BB4DB0")]
		[CompilerGenerated]
		remove
		{
			Change change = LightToggle.changeAll;
			Delegate @delegate = Delegate.Remove(change, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)typeof(LightToggle).TypeHandle != change)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0xBB4210", Offset = "0xBB2C10", VA = "0x180BB4210")]
	protected void OnEnable()
	{
		Change b = toggle;
		int num = 0;
		Change change = LightToggle.changeAll;
		Delegate @delegate = Delegate.Combine(change, b);
		if ((object)@delegate == null || (object)@delegate != null)
		{
			while ((object)typeof(LightToggle).TypeHandle != change)
			{
			}
			GridObjectScript gridObjectScript = base.GridObjectScript;
			bool? value_ = default(bool?);
			if ((object)gridObjectScript != null)
			{
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				if (_003CGridObject_003Ek__BackingField != null)
				{
					GridState state_ = _003CGridObject_003Ek__BackingField.state_;
					if (state_ != null)
					{
						ToggleGridData toggleGridData = state_.Toggle;
						if (toggleGridData != null)
						{
							value_ = toggleGridData.value_;
						}
					}
				}
			}
			this.UpdateLights((Nullable<>)value_);
			return;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xBB4380", Offset = "0xBB2D80", VA = "0x180BB4380", Slot = "5")]
	protected override void Start()
	{
		//Discarded unreachable code: IL_00b8
		//IL_0021: Expected O, but got I4
		int handle = base.gameObject.scene.m_Handle;
		GameObject gameObject = default(GameObject);
		VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
		int num = 0;
		if (!(component != (UnityEngine.Object)num))
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item lightToggleCondition = SceneLightsManager.LightToggleCondition;
			IEnumerable<> allConditions = _003CInstance_003Ek__BackingField.GetItemData<ConditionItemData>(lightToggleCondition).conditions_.GetAllConditions<ConditionCurrentScene>();
			Func<ConditionCurrentScene, Item> _003C_003E9__16_ = _003C_003Ec._003C_003E9__16_0;
			if (_003C_003E9__16_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ConditionCurrentScene x)
				{
					//Discarded unreachable code: IL_000d
					int scene_ = x.scene_;
					return (Item)typeof(Item).TypeHandle;
				};
			}
			HashSet<ConditionCurrentScene> hashSet = (HashSet<ConditionCurrentScene>)(object)MoreLinq.ToHashSet<Item>(Enumerable.Select<ConditionCurrentScene, Item>(allConditions, (Func<, >)(object)_003C_003E9__16_));
			int handle2 = base.gameObject.scene.m_Handle;
			GameObject gameObject2 = default(GameObject);
			Item item = gameObject2.GetComponent<ItemScript>().Item;
			bool flag = default(bool);
			if (flag)
			{
				SceneLightsManager sceneLightsManager = (this.sceneLightsManager = gameObject2.GetOrAddComponent<SceneLightsManager>());
			}
		}
		base.Start();
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xBB40E0", Offset = "0xBB2AE0", VA = "0x180BB40E0")]
	protected void OnDisable()
	{
		Change value = toggle;
		Change change = LightToggle.changeAll;
		Delegate @delegate = Delegate.Remove(change, value);
		if ((object)@delegate == null || (object)@delegate != null)
		{
			while ((object)typeof(LightToggle).TypeHandle != change)
			{
			}
			SceneLightsManager sceneLightsManager = this.sceneLightsManager;
			if ((object)sceneLightsManager != null)
			{
				int on = 0;
				sceneLightsManager.NotifyLightChanged(this, (byte)on != 0);
			}
			return;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB38E0", VA = "0x180BB4EE0")]
	public void toggle(bool globalState)
	{
		//IL_0033: Expected O, but got I4
		GridObjectScript gridObjectScript = base.GridObjectScript;
		if ((object)gridObjectScript != null)
		{
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				GridState state_ = _003CGridObject_003Ek__BackingField.state_;
				if (state_ != null && state_.Toggle == null)
				{
				}
			}
		}
		int num = 0;
		this.UpdateLights((Nullable<>)num);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0xBB3FE0", Offset = "0xBB29E0", VA = "0x180BB3FE0", Slot = "7")]
	protected override void InitWithGridObject(GridObject gridObject)
	{
		//Discarded unreachable code: IL_0022
		//IL_0021: Expected O, but got I4
		if (gridObject != null)
		{
			GridState state_ = gridObject.state_;
			if (state_ != null && state_.Toggle == null)
			{
			}
		}
		int num = 0;
		this.UpdateLights((Nullable<>)num);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xBB4780", Offset = "0xBB3180", VA = "0x180BB4780")]
	private void UpdateLights(bool? playerState)
	{
		//Discarded unreachable code: IL_01b1
		//IL_0055: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_0168: Expected F4, but got I4
		//IL_0196: Expected O, but got I4
		if ((object)playerState != null)
		{
		}
		bool flag = _globalStatus;
		if (SystemRoot.Instance.GetSystem<GridEditMode>().IsQuitting)
		{
			sceneLightsManager?.NotifyLightChanged(this, flag);
		}
		int handle = base.gameObject.scene.m_Handle;
		GameObject gameObject = default(GameObject);
		VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
		int num = 0;
		bool flag2 = component != (UnityEngine.Object)num;
		int num2 = 0;
		if (!flag || !flag2)
		{
		}
		Light[] array = lights;
		bool flag3 = num2 != 0;
		int length = array.Length;
		if (num2 < length)
		{
			Light light = array[num2];
			int num3 = 0;
			if (light != (UnityEngine.Object)num3)
			{
				light.enabled = flag3;
			}
			num2++;
		}
		GameObject[] array2 = gameObjectsToToggle;
		int length2 = array2.Length;
		if (num2 < length2)
		{
			GameObject gameObject2 = array2[num2];
			int num4 = 0;
			if (gameObject2 != (UnityEngine.Object)num4)
			{
				gameObject2.SetActive(flag);
			}
			num2++;
		}
		bool flag4 = default(bool);
		if (!flag4)
		{
			Renderer[] array3 = renderersForEmissive;
			int length3 = array3.Length;
			if (num2 >= length3)
			{
				return;
			}
			Renderer renderer = array3[num2];
			int num5 = 0;
			if (renderer != (UnityEngine.Object)num5)
			{
				int num6 = 0;
				renderer.Internal_SetPropertyBlock((MaterialPropertyBlock)num6);
			}
			num2++;
		}
		MaterialPropertyBlock materialPropertyBlock2 = default(MaterialPropertyBlock);
		if (this.materialPropertyBlock == null)
		{
			MaterialPropertyBlock materialPropertyBlock = (this.materialPropertyBlock = new MaterialPropertyBlock());
			materialPropertyBlock2 = this.materialPropertyBlock;
		}
		int num7 = 0;
		materialPropertyBlock2.SetFloat("_GlobalEmissiveIntensity", num7);
		Renderer[] array4 = renderersForEmissive;
		int length4 = array4.Length;
		if (num2 < length4)
		{
			Renderer renderer2 = array4[num2];
			int num8 = 0;
			if (renderer2 != (UnityEngine.Object)num8)
			{
				MaterialPropertyBlock properties = this.materialPropertyBlock;
				renderer2.Internal_SetPropertyBlock(properties);
			}
			num2++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
	public LightToggle()
	{
		((DiagnosticEventCollector)(object)this)._002Ector();
	}
}
