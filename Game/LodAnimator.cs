using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LodAnimator : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private enum Modes
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		LoadComplete,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Threshold,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		UnloadComplete
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	private AssetReferenceT<RuntimeAnimatorController> complete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Animator animator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private RuntimeAnimatorController defaultController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private RuntimeAnimatorController lodController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Modes mode = Modes.Unknown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool loading;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private float CompleteLoadDistanceSqr
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBBAF80", Offset = "0xBB9980", VA = "0x180BBAF80")]
		get
		{
			return GraphicSettings.LodAnimationLoadDistance;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private float CompleteUnloadDistance
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBBB080", Offset = "0xBB9A80", VA = "0x180BBB080")]
		get
		{
			return GraphicSettings.LodAnimationLoadDistance;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private float CompleteUnloadSqr
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xBBB180", Offset = "0xBB9B80", VA = "0x180BBB180")]
		get
		{
			float completeUnloadDistance = CompleteUnloadDistance;
			return CompleteUnloadDistance;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[field: Cpp2IlInjected.Token(Token = "0x400002F")]
	public static bool LogDebug
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBBB1D0", Offset = "0xBB9BD0", VA = "0x180BBB1D0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBBB240", Offset = "0xBB9C40", VA = "0x180BBB240")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x3D"), Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool ForceLoadComplete
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xBBB1C0", Offset = "0xBB9BC0", VA = "0x180BBB1C0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xBBB230", Offset = "0xBB9C30", VA = "0x180BBB230")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBBA2D0", Offset = "0xBB8CD0", VA = "0x180BBA2D0")]
	private void Log(string format)
	{
		//Discarded unreachable code: IL_0045
		string msg;
		object[] array;
		do
		{
			Animator animator = this.animator;
			if ((object)animator == null || animator.name == null)
			{
			}
			msg = "[LodAnim][" + "null" + "] " + format;
			array = new object[1];
		}
		while (array == null);
		array[0] = this;
		GameLog.Info(msg, array);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xBBA110", Offset = "0xBB8B10", VA = "0x180BBA110")]
	private void Log(string format, params object[] args)
	{
		//Discarded unreachable code: IL_0051
		string msg;
		object[] array;
		do
		{
			string text = string.Format(format, args);
			Animator animator = this.animator;
			if ((object)animator == null || animator.name == null)
			{
			}
			msg = "[LodAnim][" + "null" + "] " + text;
			array = new object[1];
		}
		while (array == null);
		array[0] = this;
		GameLog.Info(msg, array);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBBA5B0", Offset = "0xBB8FB0", VA = "0x180BBA5B0")]
	private void Start()
	{
		//Discarded unreachable code: IL_0093
		//IL_002e: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		bool flag;
		object[] array;
		while (true)
		{
			Animator animator = (this.animator = base.gameObject.GetComponent<Animator>());
			Animator animator2 = this.animator;
			int num = 0;
			if ((object)animator2 != null)
			{
				RuntimeAnimatorController runtimeAnimatorController = animator2.runtimeAnimatorController;
			}
			defaultController = (RuntimeAnimatorController)num;
			Animator animator3 = this.animator;
			int num2 = 0;
			if (!(animator3 != (Object)num2))
			{
				continue;
			}
			AssetReferenceT<RuntimeAnimatorController> assetReferenceT = complete;
			if (assetReferenceT != null)
			{
				flag = assetReferenceT.RuntimeKeyIsValid();
				array = new object[1];
				if (array == null || array != null)
				{
					break;
				}
			}
		}
		array[0] = array;
		Log("enabled: {0}", array);
		base.enabled = flag;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xBBA480", Offset = "0xBB8E80", VA = "0x180BBA480")]
	private void OnDestroy()
	{
		AssetReferenceT<RuntimeAnimatorController> assetReferenceT = complete;
		if (assetReferenceT != null)
		{
			DataSet dataSet = ((DataRelationCollection)(object)assetReferenceT).GetDataSet();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xBBA790", Offset = "0xBB9190", VA = "0x180BBA790")]
	private void Update()
	{
		//Discarded unreachable code: IL_018a
		//IL_0021: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_0177: Expected O, but got I8
		Vector3 vector = default(Vector3);
		Vector3 vector2 = default(Vector3);
		float num3 = default(float);
		Task asyncTask = default(Task);
		while (true)
		{
			int num = 0;
			if ((loading ? 1 : 0) != num)
			{
				break;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
			}
			int num2 = 0;
			if (_003CInstance_003Ek__BackingField != (Object)num2)
			{
				Transform transform = this.animator.transform;
				float z = vector.z;
				SceneStack sceneStack = _003CInstance_003Ek__BackingField._sceneStack;
				float z2 = vector2.z;
			}
			if (!ForceLoadComplete)
			{
				float _003CLodAnimationLoadDistance_003Ek__BackingField = GraphicSettings.LodAnimationLoadDistance;
				if (!(_003CLodAnimationLoadDistance_003Ek__BackingField > num3))
				{
					_003CLodAnimationLoadDistance_003Ek__BackingField = CompleteUnloadDistance;
					float completeUnloadDistance = CompleteUnloadDistance;
					int num4 = 0;
					num4++;
				}
			}
			int num5 = 0;
			if (num5 == (int)mode)
			{
				break;
			}
			object[] array = new object[2];
			if (array != null && array == null)
			{
				continue;
			}
			array[0] = array;
			if (array != null && array == null)
			{
				continue;
			}
			array[1] = array;
			Log("lod animator mode changed: {0} => {1}", array);
			if (num5 == 0)
			{
				goto IL_0177;
			}
			if (num5 == 2)
			{
				RuntimeAnimatorController runtimeAnimatorController = lodController;
				int num6 = 0;
				if (runtimeAnimatorController != (Object)num6)
				{
					Animator animator = this.animator;
					if ((object)animator == null || animator.name == null)
					{
					}
					string msg = "[LodAnim][" + "null" + "] " + "unloading complete animator";
					object[] array2 = new object[1];
					if (array2 == null)
					{
						continue;
					}
					array2[0] = this;
					GameLog.Info(msg, array2);
					Animator animator2 = this.animator;
					RuntimeAnimatorController runtimeAnimatorController3 = (animator2.runtimeAnimatorController = defaultController);
					complete.ReleaseAsset();
					lodController = (RuntimeAnimatorController)0;
					goto IL_0177;
				}
			}
			goto IL_0181;
			IL_0181:
			mode = (Modes)num5;
			break;
			IL_0177:
			int num7 = 0;
			asyncTask.FireAndForgetTask();
			goto IL_0181;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xBBA4A0", Offset = "0xBB8EA0", VA = "0x180BBA4A0")]
	[AsyncStateMachine(typeof(_003CSetCompleteController_003Ed__26))]
	private Task SetCompleteController()
	{
		int num = 0;
		int num2 = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xBBAF70", Offset = "0xBB9970", VA = "0x180BBAF70")]
	public LodAnimator()
	{
	}//IL_0010: Expected I4, but got I8


	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static LodAnimator()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
