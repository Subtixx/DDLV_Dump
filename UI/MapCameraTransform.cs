using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000043")]
[RequiredAllNotNull]
public class MapCameraTransform : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[SerializeField]
	private Transform _camPosOnMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public GameObject PrefabMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[SerializeField]
	private Transform _newCharacterSpawnPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[SerializeField]
	private Transform _newCharacterPhotoZonePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[SerializeField]
	private Transform _avatarPhotoZonePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[SerializeField]
	private Transform _newAquaticCharacterSpawnPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[SerializeField]
	private Transform _newAquaticCharacterPhotoZonePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[SerializeField]
	private Transform _avatarPhotoZonePosForAquaticCharacter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[SerializeField]
	private Transform _wishingWellPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[SerializeField]
	private Transform _castlePos;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Transform CameraTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
		get
		{
			return _camPosOnMap;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		set
		{
			_camPosOnMap = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool IsAquaticCharacter
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Transform NewCharacterSpawningTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xFB01F0", Offset = "0xFAEBF0", VA = "0x180FB01F0")]
		get
		{
			if (!IsAquaticCharacter)
			{
				return _newCharacterSpawnPos;
			}
			return _newAquaticCharacterSpawnPos;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Transform NewCharacterPhotoZoneTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xFB01E0", Offset = "0xFAEBE0", VA = "0x180FB01E0")]
		get
		{
			if (!IsAquaticCharacter)
			{
				return _newCharacterPhotoZonePos;
			}
			return _newAquaticCharacterPhotoZonePos;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Transform AvatarPhotoZoneTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xFB01C0", Offset = "0xFAEBC0", VA = "0x180FB01C0")]
		get
		{
			if (!IsAquaticCharacter)
			{
				return _avatarPhotoZonePos;
			}
			return _avatarPhotoZonePosForAquaticCharacter;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Transform WishingWellTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
		get
		{
			return _wishingWellPos;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Transform CastleTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
		get
		{
			return _castlePos;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public MapCameraTransform()
	{
	}
}
