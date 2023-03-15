using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class SpawnGlowingTiles : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public enum Foot
	{
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		Right
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public float maxDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public GameObject instanceLeftFoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public GameObject instanceRightFoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public int maxInstances;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public bool lookTransformForward;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public float forwardOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public float delayBeforeHide = 3f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private PlayerNavigation navigation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private Vector3 prevSpawnPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private Transform root;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private List<GlowingTile> usedLeftFootTiles = (List<GlowingTile>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private List<GlowingTile> availableLeftFootTiles = (List<GlowingTile>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private List<GlowingTile> usedRightFootTiles = (List<GlowingTile>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private List<GlowingTile> availableRightFootTiles = (List<GlowingTile>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private InvisiblePath invisiblePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private bool idle;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float sqrMaxDistance
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xF57B70", Offset = "0xF56570", VA = "0x180F57B70")]
		get
		{
			return maxDistance;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xF57320", Offset = "0xF55D20", VA = "0x180F57320")]
	private void Start()
	{
		AnimationEventDispatcher component = SystemRoot.Instance._avatar.GetComponent<AnimationEventDispatcher>();
		AnimationEventDispatcher.AnimationEventHandler value = OnAvatarAnimationEvent;
		component.AnimationEvent += value;
		SceneStack sceneStack = SystemRoot.Instance._sceneStack;
		SceneData sceneData = default(SceneData);
		AsyncOperation operation = sceneData.sceneInstance.m_Operation;
		CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
		SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
		SceneData sceneData2 = default(SceneData);
		AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
		CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
		SceneStack sceneStack3 = SystemRoot.Instance._sceneStack;
		SceneStack.CurrentSceneChanged value2 = OnCurrentSceneChanged;
		sceneStack3.OnCurrentSceneChanged += value2;
		PlayerNavigation playerNavigation = (navigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xF57750", Offset = "0xF56150", VA = "0x180F57750")]
	private void Update()
	{
		//Discarded unreachable code: IL_00b0
		//IL_0046: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		Animator animator = SystemRoot.Instance._avatar.Animator;
		AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
		float length = animatorStateInfo.m_Length;
		int loop = animatorStateInfo.m_Loop;
		bool flag = default(bool);
		if (flag && !idle)
		{
			idle = true;
			int num = 0;
			AnimationEventDispatcher.AnimationEventArgs args = new AnimationEventDispatcher.AnimationEventArgs((Nullable<>)num, (Nullable<>)num, "_l", (UnityEngine.Object)num);
			OnAvatarAnimationEvent("OnFootStep", args);
			AnimationEventDispatcher.AnimationEventArgs args2 = new AnimationEventDispatcher.AnimationEventArgs((Nullable<>)num, (Nullable<>)num, "_r", (UnityEngine.Object)num);
			OnAvatarAnimationEvent("OnFootStep", args2);
		}
		else
		{
			Animator animator2 = SystemRoot.Instance._avatar.Animator;
			AnimatorStateInfo animatorStateInfo2 = default(AnimatorStateInfo);
			float length2 = animatorStateInfo2.m_Length;
			int loop2 = animatorStateInfo2.m_Loop;
			bool flag2 = default(bool);
			while (flag2)
			{
			}
			while (idle == flag2)
			{
			}
			idle = flag2;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xF568A0", Offset = "0xF552A0", VA = "0x180F568A0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_006b
		//IL_0057: Expected O, but got I4
		SceneStack sceneStack = SystemRoot.Instance._sceneStack;
		SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
		sceneStack.OnCurrentSceneChanged -= value;
		AnimationEventDispatcher component = SystemRoot.Instance._avatar.GetComponent<AnimationEventDispatcher>();
		AnimationEventDispatcher.AnimationEventHandler value2 = OnAvatarAnimationEvent;
		component.AnimationEvent -= value2;
		Transform transform = root;
		int num = 0;
		if (transform != (UnityEngine.Object)num)
		{
			UnityEngine.Object.Destroy(root.gameObject);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xF56720", Offset = "0xF55120", VA = "0x180F56720")]
	private void OnCurrentSceneChanged(SceneData scene)
	{
		//Discarded unreachable code: IL_0048
		AsyncOperation operation = scene.sceneInstance.m_Operation;
		CameraNavigationConfig editCameraConfig = scene.EditCameraConfig;
		SceneStack sceneStack = SystemRoot.Instance._sceneStack;
		SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
		sceneStack.OnCurrentSceneChanged -= value;
		AsyncOperation operation2 = scene.sceneInstance.m_Operation;
		CameraNavigationConfig editCameraConfig2 = scene.EditCameraConfig;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xF564B0", Offset = "0xF54EB0", VA = "0x180F564B0")]
	private unsafe void OnAvatarAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
	{
		//IL_007d: Expected native int or pointer, but got O
		if (eventName == null || "OnFootStep" == null)
		{
			return;
		}
		Transform transform = base.transform;
		float z = prevSpawnPosition.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		float num = maxDistance;
		if (idle)
		{
			if (args.String.Contains("_l"))
			{
				int num2 = 0;
				GameObject gameObject = default(GameObject);
				Transform transform2 = gameObject.transform;
				throw new NullReferenceException();
			}
			if (args.String.Contains("_r"))
			{
				int num3 = 0;
				GameObject gameObject2 = default(GameObject);
				Transform transform3 = gameObject2.transform;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				((Vector3*)(IntPtr)prevSpawnPosition)->z = z3;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0xF56BF0", Offset = "0xF555F0", VA = "0x180F56BF0")]
	private unsafe void SetupVillage(SceneData villageScene)
	{
		//Discarded unreachable code: IL_0100
		//IL_00d7: Expected I4, but got I8
		Transform transform = (root = new GameObject("Instances Root").transform);
		Transform transform2 = root;
		Transform transform4 = (transform2.parentInternal = ((SceneData*)villageScene)->sceneRoot.transform);
		int num = maxInstances;
		int num2 = 0;
		if (num > 0)
		{
			GameObject gameObject = instanceLeftFoot;
			Transform transform5 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Quaternion identity = Quaternion.identity;
			GameObject gameObject2 = default(GameObject);
			GlowingTile component = gameObject2.GetComponent<GlowingTile>();
			component.Spawner = this;
			component.Foot = (Foot)num2;
			((List<T>)(object)availableLeftFootTiles).Add((T)component);
			int num3 = maxInstances;
			num2++;
			if (num3 > 0)
			{
				GameObject gameObject3 = instanceRightFoot;
				Transform transform6 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Quaternion identity2 = Quaternion.identity;
				GameObject gameObject4 = default(GameObject);
				GlowingTile component2 = gameObject4.GetComponent<GlowingTile>();
				component2.Spawner = this;
				component2.Foot = Foot.Right;
				((List<T>)(object)availableRightFootTiles).Add((T)component2);
				num2++;
			}
		}
		InvisiblePath invisiblePath = (this.invisiblePath = ((SceneData*)villageScene)->sceneRoot.GetComponentInChildren<InvisiblePath>());
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xF56FA0", Offset = "0xF559A0", VA = "0x180F56FA0")]
	private Vector3 SpawnInstance(Transform footTransform, Foot foot)
	{
		//IL_0052: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Quaternion identity = Quaternion.identity;
		Transform transform = footTransform.transform;
		float z2 = footTransform.forward.z;
		bool flag = default(bool);
		if (flag)
		{
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
		}
		num2 += num2;
		int num5 = 0;
		GlowingTile glowingTile = default(GlowingTile);
		if (glowingTile != (UnityEngine.Object)num5)
		{
			int num6 = 0;
		}
		if ((object)glowingTile != null)
		{
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xF563B0", Offset = "0xF54DB0", VA = "0x180F563B0")]
	private GlowingTile GetTile(Foot foot)
	{
		//Discarded unreachable code: IL_0039
		//IL_0022: Expected O, but got I4
		if (foot == Foot.Left)
		{
		}
		List<GlowingTile> list = availableRightFootTiles;
		List<GlowingTile> list2 = usedRightFootTiles;
		GlowingTile glowingTile = Enumerable.FirstOrDefault<GlowingTile>((IEnumerable<>)list);
		int num = 0;
		if (glowingTile != (UnityEngine.Object)num)
		{
			int index = 0;
			((List<T>)(object)list).RemoveAt(index);
			((List<T>)(object)list2).Add((T)glowingTile);
		}
		return glowingTile;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0xF56B10", Offset = "0xF55510", VA = "0x180F56B10")]
	public void ReturnTile(GlowingTile tile)
	{
		//Discarded unreachable code: IL_0031
		if (tile.Foot == Foot.Left)
		{
		}
		List<GlowingTile> list = availableRightFootTiles;
		bool flag = ((List<T>)(object)usedRightFootTiles).Remove((T)tile);
		((List<T>)(object)list).Add((T)tile);
		Transform transform = tile.gameObject.transform;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xF57A60", Offset = "0xF56460", VA = "0x180F57A60")]
	public SpawnGlowingTiles()
	{
	}
}
