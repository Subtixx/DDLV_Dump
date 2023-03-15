using System;
using System.Text;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Utils;
using Meta.Grids;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DistanceCullingManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static DistanceCullingManager Instance;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static float FirstBand;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float SecondBand;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float TallFirstBand;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static float TallSecondBand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private DistanceCulling tallCullingGroup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private DistanceCulling defaultCullingGroup;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int PendingLoadCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x19CB6C0", Offset = "0x19CA0C0", VA = "0x1819CB6C0")]
		get
		{
			//Discarded unreachable code: IL_003b
			DistanceCulling distanceCulling = defaultCullingGroup;
			if (distanceCulling != null)
			{
				return distanceCulling.toLoad.ReadyCount;
			}
			DistanceCulling distanceCulling2 = tallCullingGroup;
			if (distanceCulling2 != null)
			{
				int readyCount = distanceCulling2.toLoad.ReadyCount;
				int num = 0;
			}
			int num2 = 0;
			if (num2 != 0)
			{
			}
			return num2;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x19CB640", Offset = "0x19CA040", VA = "0x1819CB640")]
	public void UpdateDistanceBands()
	{
		//Discarded unreachable code: IL_0017
		defaultCullingGroup.UpdateDistanceBands();
		tallCullingGroup.UpdateDistanceBands();
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x19CB460", Offset = "0x19C9E60", VA = "0x1819CB460")]
	public void ResetLoadLimit()
	{
		tallCullingGroup?.ResetLoadLimit();
		defaultCullingGroup?.ResetLoadLimit();
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x19CB5C0", Offset = "0x19C9FC0", VA = "0x1819CB5C0")]
	public void StartBoostLoadLimit()
	{
		//Discarded unreachable code: IL_0017
		tallCullingGroup.StartBoostLoadLimit();
		defaultCullingGroup.StartBoostLoadLimit();
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x19CB600", Offset = "0x19CA000", VA = "0x1819CB600")]
	public void StopBoostLoadLimit()
	{
		//Discarded unreachable code: IL_0017
		tallCullingGroup.ResetLoadLimit();
		defaultCullingGroup.ResetLoadLimit();
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x19CAD60", Offset = "0x19C9760", VA = "0x1819CAD60")]
	private void Awake()
	{
		Instance = this;
		float tallFirstBand = TallFirstBand;
		float tallSecondBand = TallSecondBand;
		DistanceCulling distanceCulling = (tallCullingGroup = new DistanceCulling(tallFirstBand, tallSecondBand));
		DistanceCulling distanceCulling2 = (defaultCullingGroup = new DistanceCulling(tallFirstBand, tallSecondBand));
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x19CAEE0", Offset = "0x19C98E0", VA = "0x1819CAEE0")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_002d
		tallCullingGroup.Enable();
		tallCullingGroup.ResetLoadLimit();
		defaultCullingGroup.Enable();
		defaultCullingGroup.ResetLoadLimit();
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x19CAEA0", Offset = "0x19C98A0", VA = "0x1819CAEA0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_0017
		tallCullingGroup.Disable();
		defaultCullingGroup.Disable();
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x19CAE60", Offset = "0x19C9860", VA = "0x1819CAE60")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0017
		tallCullingGroup.Destroy();
		defaultCullingGroup.Destroy();
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x19CAC30", Offset = "0x19C9630", VA = "0x1819CAC30")]
	public bool AddAsset(GridObject gridObject, GridScript gridScript, out AsyncOperationHandle<GameObject> loadedAsset)
	{
		//Discarded unreachable code: IL_001a
		int itemID = gridObject.ItemID;
		ItemType itemType = default(ItemType);
		if (itemType != ItemType.Building)
		{
		}
		return tallCullingGroup.AddAsset(gridObject, gridScript, out loadedAsset);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x19CACC0", Offset = "0x19C96C0", VA = "0x1819CACC0")]
	public void AddLoadedAsset(AsyncOperationHandle<GameObject> loadedAsset, GridObjectScript gridObjectScript, GridScript gridScript)
	{
		int itemID = gridObjectScript.GridObject.ItemID;
		ItemType itemType = default(ItemType);
		if (itemType != ItemType.Building)
		{
			DistanceCulling distanceCulling = defaultCullingGroup;
			return;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x19CB3D0", Offset = "0x19C9DD0", VA = "0x1819CB3D0")]
	public bool RemoveAsset(GridObject gridObject, GridScript gridScript, out AsyncOperationHandle<GameObject> loadedAsset)
	{
		//Discarded unreachable code: IL_001a
		int itemID = gridObject.ItemID;
		ItemType itemType = default(ItemType);
		if (itemType != ItemType.Building)
		{
		}
		return tallCullingGroup.RemoveAsset(gridObject, gridScript, out loadedAsset);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x19CB680", Offset = "0x19CA080", VA = "0x1819CB680")]
	private void Update()
	{
		//Discarded unreachable code: IL_0017
		defaultCullingGroup.Update();
		tallCullingGroup.Update();
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x19CB4A0", Offset = "0x19C9EA0", VA = "0x1819CB4A0")]
	public void SetOSDEnable(bool isEnable)
	{
		//Discarded unreachable code: IL_0057
		int num = 0;
		DebugOnScreenText instance = DebugOnScreenText.Instance;
		if (!isEnable)
		{
			DebugOnScreenText.AddOnScreenText value = OnScreenDebugText;
			instance.OnAddOnScreenText -= value;
			return;
		}
		DebugOnScreenText.AddOnScreenText value2 = OnScreenDebugText;
		instance.OnAddOnScreenText -= value2;
		int num2 = 0;
		DebugOnScreenText instance2 = DebugOnScreenText.Instance;
		DebugOnScreenText.AddOnScreenText value3 = OnScreenDebugText;
		instance2.OnAddOnScreenText += value3;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x19CAF40", Offset = "0x19C9940", VA = "0x1819CAF40")]
	public void OnScreenDebugText(StringBuilder dest)
	{
		//Discarded unreachable code: IL_012a
		DistanceCulling distanceCulling = defaultCullingGroup;
		DistanceCulling.DebugStats debugStats = default(DistanceCulling.DebugStats);
		string value = $"DistanceCulling L:{debugStats} R:{debugStats}";
		StringBuilder stringBuilder = dest.AppendLine(value);
		StringBuilder arg = dest.Append("DistanceCulling toLoad   :");
		string value2 = $"{arg}";
		StringBuilder stringBuilder2 = dest.AppendLine(value2);
		StringBuilder arg2 = dest.Append("DistanceCulling toRemove :");
		string value3 = $"{arg2}";
		StringBuilder stringBuilder3 = dest.AppendLine(value3);
		StringBuilder stringBuilder4 = dest.Append("DistanceCulling loaded/loading/total : ");
		string value4 = $"{debugStats:D6}/{debugStats:D6}/{debugStats}";
		StringBuilder stringBuilder5 = dest.AppendLine(value4);
		StringBuilder stringBuilder6 = dest.AppendLine();
		DistanceCulling distanceCulling2 = tallCullingGroup;
		DistanceCulling.DebugStats debugStats2 = default(DistanceCulling.DebugStats);
		string value5 = $"TallDistanceCulling L:{debugStats2} R:{debugStats2}";
		StringBuilder stringBuilder7 = dest.AppendLine(value5);
		StringBuilder arg3 = dest.Append("TallDistanceCulling toLoad   :");
		string value6 = $"{arg3}";
		StringBuilder stringBuilder8 = dest.AppendLine(value6);
		StringBuilder arg4 = dest.Append("TallDistanceCulling toRemove :");
		string value7 = $"{arg4}";
		StringBuilder stringBuilder9 = dest.AppendLine(value7);
		StringBuilder stringBuilder10 = dest.Append("TallDistanceCulling loaded/loading/total : ");
		string value8 = $"{stringBuilder10:D6}/{stringBuilder10:D6}/{stringBuilder10}";
		StringBuilder stringBuilder11 = dest.AppendLine(value8);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public DistanceCullingManager()
	{
	}
}
