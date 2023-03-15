using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Ui;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FenceInfoGizmo : InfoGizmo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	[SerializeField]
	private TextBase _amountLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[SerializeField]
	private GameObject _controlsGamepadInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	[SerializeField]
	private GameObject _fenceIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[SerializeField]
	private GameObject _pathingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private GridEditMode gridEditModeSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private bool _hidden;

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x15300E0", Offset = "0x152EAE0", VA = "0x1815300E0", Slot = "11")]
	public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
	{
		//Discarded unreachable code: IL_0051
		int num = 0;
		GameObject controlsGamepadInfo = _controlsGamepadInfo;
		int num2 = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		bool active = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
		controlsGamepadInfo.SetActive(active);
		GridEditMode gridEditMode = (gridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
		CancellationToken? cancellationToken = _cancellationToken;
		bool flag = default(bool);
		if (!flag)
		{
			Hide();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1530300", Offset = "0x152ED00", VA = "0x181530300", Slot = "14")]
	public override Task Show(CancellationToken ct)
	{
		//Discarded unreachable code: IL_006a
		int itemID = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject.ItemID;
		GameObject pathingIcon = _pathingIcon;
		FurnitureItemType furnitureItemType = default(FurnitureItemType);
		if (furnitureItemType != FurnitureItemType.GroundAlteration)
		{
			int active = 0;
			pathingIcon.SetActive((byte)active != 0);
			GameObject fenceIcon = _fenceIcon;
		}
		pathingIcon.SetActive(value: true);
		GameObject fenceIcon2 = _fenceIcon;
		int active2 = 0;
		fenceIcon2.SetActive((byte)active2 != 0);
		base.gameObject.SetActive(value: true);
		UpdatePosition();
		int num = 0;
		return Task.CompletedTask;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1530450", Offset = "0x152EE50", VA = "0x181530450", Slot = "13")]
	protected override void Update()
	{
		//Discarded unreachable code: IL_0067
		//IL_0016: Expected O, but got I4
		base.Update();
		GridEditMode gridEditMode = gridEditModeSystem;
		int num = 0;
		if (gridEditMode != (Object)num && gridEditModeSystem.IsInFenceMode())
		{
			GridEditMode gridEditMode2 = gridEditModeSystem;
			TextBase amountLabel = _amountLabel;
			int remainingAmountOfSelectedFences = gridEditMode2.GetRemainingAmountOfSelectedFences();
			int num2 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			amountLabel.Text = text;
		}
		else if (!_hidden)
		{
			_hidden = true;
			Hide();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x15300D0", Offset = "0x152EAD0", VA = "0x1815300D0", Slot = "16")]
	protected override void HideImpl()
	{
		DestroyInfoGizmo();
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x15302A0", Offset = "0x152ECA0", VA = "0x1815302A0", Slot = "15")]
	public override void Kill()
	{
		Object.Destroy(base.gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
	public FenceInfoGizmo()
	{
	}
}
