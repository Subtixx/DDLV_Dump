using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000032")]
public class CameraModifier : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private CountedBool shouldBeActive;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected Camera Camera
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x164DB00", Offset = "0x164C500", VA = "0x18164DB00")]
		get
		{
			//Discarded unreachable code: IL_000b
			return SystemRoot.Instance._playerCamera;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected GameObject targetObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
		[CompilerGenerated]
		get
		{
			return _003CtargetObject_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		[CompilerGenerated]
		private set
		{
			_003CtargetObject_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x164D970", Offset = "0x164C370", VA = "0x18164D970")]
	public void StartModifier([System.Runtime.InteropServices.Optional] GameObject targetObject)
	{
		//Discarded unreachable code: IL_0028
		//IL_0009: Expected O, but got I4
		int num = 0;
		if (targetObject != (Object)num)
		{
			this.targetObject = targetObject;
		}
		if (shouldBeActive.AddReference() == CountedBool.RefState.FirstReference)
		{
			OnStartModifier();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x164DA30", Offset = "0x164C430", VA = "0x18164DA30")]
	public void StopModifier()
	{
		//Discarded unreachable code: IL_001f
		if (shouldBeActive.ReleaseReference() == CountedBool.RefState.LastReference)
		{
			OnStopModifier();
			int num = ((base.enabled = false) ? 1 : 0);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
	protected virtual void OnStartModifier()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
	protected virtual void OnStopModifier()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x164DA80", Offset = "0x164C480", VA = "0x18164DA80")]
	public CameraModifier()
	{
		int debug = default(int);
		CountedBool countedBool = new CountedBool("", (byte)debug != 0);
		debug = 0;
		shouldBeActive = countedBool;
		base._002Ector();
	}
}
