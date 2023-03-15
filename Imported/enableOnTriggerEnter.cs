using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000040")]
public class enableOnTriggerEnter : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LayerMask layer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public MonoBehaviour[] gameObjectsToEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public GameObject[] _gameObjectsToEnable;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD760", Offset = "0x3DCC160", VA = "0x183DCD760")]
	private void Start()
	{
		//Discarded unreachable code: IL_0069
		MonoBehaviour[] array = gameObjectsToEnable;
		int num = 0;
		if (num < array.Length)
		{
			MonoBehaviour monoBehaviour = array[num];
			int num2 = ((monoBehaviour.enabled = false) ? 1 : 0);
			MonoBehaviour[] array2 = gameObjectsToEnable;
			num++;
		}
		GameObject[] array3 = _gameObjectsToEnable;
		if (num < array3.Length)
		{
			GameObject gameObject = array3[num];
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject[] array4 = _gameObjectsToEnable;
			num++;
			while (array4 != null)
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD630", Offset = "0x3DCC030", VA = "0x183DCD630")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//Discarded unreachable code: IL_0087
		LayerMask layerMask = layer;
		int num = collision.gameObject.layer;
		int mask = layerMask.m_Mask;
		bool flag = default(bool);
		if (!flag)
		{
			return;
		}
		MonoBehaviour[] array = gameObjectsToEnable;
		int num2 = 0;
		if (num2 < array.Length)
		{
			array[num2].enabled = true;
			MonoBehaviour[] array2 = gameObjectsToEnable;
			num2++;
		}
		GameObject[] array3 = _gameObjectsToEnable;
		if (num2 < array3.Length)
		{
			array3[num2].SetActive(value: true);
			GameObject[] array4 = _gameObjectsToEnable;
			num2++;
			while (array4 != null)
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public enableOnTriggerEnter()
	{
	}
}
