using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004D1")]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class CameraLight : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20004D2")]
		public delegate void UpdateCameraLightCallback(Color cameraLightColor, float cameraLightIntensity);

		[Cpp2IlInjected.Token(Token = "0x4001E2F")]
		public static UpdateCameraLightCallback updateCameraLightCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E30")]
		private bool UseWeatherSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E31")]
		private Light _light;

		[Cpp2IlInjected.Token(Token = "0x600152F")]
		[Cpp2IlInjected.Address(RVA = "0x164D470", Offset = "0x164BE70", VA = "0x18164D470")]
		private void Start()
		{
			updateCameraLightCallback = UpdateCameraLightValues;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001530")]
		[Cpp2IlInjected.Address(RVA = "0x164D430", Offset = "0x164BE30", VA = "0x18164D430")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001531")]
		[Cpp2IlInjected.Address(RVA = "0x164D500", Offset = "0x164BF00", VA = "0x18164D500")]
		public void UpdateCameraLightValues(Color cameraLightColor, float cameraLightIntensity)
		{
			//Discarded unreachable code: IL_0081
			//IL_0053: Expected F4, but got I4
			//IL_007e: Expected F4, but got I4
			if (base.enabled)
			{
				bool flag = default(bool);
				if (flag)
				{
					Light light = (_light = GetComponent<Light>());
				}
				UseWeatherSettings = flag;
				float lightIntensity = default(float);
				if (!flag)
				{
					Color white = Color.white;
					lightIntensity = Sun.lightIntensity;
					float lightIntensity2 = Moon.lightIntensity;
					float num = Mathf.Max(lightIntensity, lightIntensity2);
					int num2 = 0;
					float num3 = Mathf.Clamp(0.3f, num2, cameraLightIntensity);
				}
				float lightIntensity3 = Sun.lightIntensity;
				float lightIntensity4 = Moon.lightIntensity;
				float num4 = Mathf.Max(lightIntensity3, lightIntensity4);
				num4 = lightIntensity;
				int num5 = 0;
				float num6 = Mathf.Clamp(num4, num5, cameraLightIntensity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001532")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraLight()
		{
		}
	}
}
