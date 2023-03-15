using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GlowingTile : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public AK.Wwise.Event spawnSfx;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public AK.Wwise.Event despawnSfx;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public GameObject audioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private Animator animator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private float delayBeforeHide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private bool isHidding;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000415")]
	public SpawnGlowingTiles.Foot Foot
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public SpawnGlowingTiles Spawner
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
		[CompilerGenerated]
		get
		{
			return _003CSpawner_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
		[CompilerGenerated]
		set
		{
			_003CSpawner_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool AvatarIsOver
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD30", Offset = "0x8CC730", VA = "0x1808CDD30")]
		get
		{
			if (!isHidding)
			{
				Transform transform = base.transform;
				SpawnGlowingTiles spawnGlowingTiles = Spawner;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform2 = spawnGlowingTiles.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				float sqrMaxDistance = Spawner.sqrMaxDistance;
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA60", Offset = "0x8CC460", VA = "0x1808CDA60")]
	private void Start()
	{
		GameObject gameObject = base.gameObject;
		int active = 0;
		gameObject.SetActive((byte)active != 0);
		Animator animator = (this.animator = GetComponent<Animator>());
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8CDAD0", Offset = "0x8CC4D0", VA = "0x1808CDAD0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0068
		//IL_0067: Expected F4, but got I4
		if (!isHidding)
		{
			Transform transform = base.transform;
			Transform transform2 = Spawner.transform;
			float sqrMaxDistance = Spawner.sqrMaxDistance;
			Vector3 vector = default(Vector3);
			if ((object)vector == null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				SpawnGlowingTiles spawnGlowingTiles = Spawner;
				delayBeforeHide = deltaTime;
				if (deltaTime <= spawnGlowingTiles.delayBeforeHide)
				{
					return;
				}
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}
		int num3 = 0;
		delayBeforeHide = num3;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x8CD940", Offset = "0x8CC340", VA = "0x1808CD940")]
	public void Spawn(Vector3 position, Quaternion rotation)
	{
		//Discarded unreachable code: IL_006e
		isHidding = false;
		delayBeforeHide = 0f;
		base.gameObject.SetActive(value: true);
		Transform transform = base.transform;
		float z = position.z;
		Transform transform2 = base.transform;
		animator.SetTrigger("Spawn");
		AK.Wwise.Event @event = spawnSfx;
		if (@event != null)
		{
			GameObject gameObject = audioEmitter;
			if ((object)gameObject == null)
			{
				GameObject gameObject2 = base.gameObject;
			}
			uint num = @event.Post(gameObject);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8CD840", Offset = "0x8CC240", VA = "0x1808CD840")]
	[AsyncStateMachine(typeof(_003CHideAsync_003Ed__19))]
	private Task HideAsync()
	{
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public GlowingTile()
	{
	}
}
