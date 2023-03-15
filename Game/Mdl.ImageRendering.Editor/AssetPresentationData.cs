using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.ImageRendering.Editor
{
	[Cpp2IlInjected.Token(Token = "0x20003F4")]
	public class AssetPresentationData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003F5")]
		public class Tab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019A4")]
			public string label;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019A5")]
			public List<ItemType> assetTypes = (List<ItemType>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40019A6")]
			public List<BuildingItemType> renderBuildingItems = (List<BuildingItemType>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40019A7")]
			public List<ActivityItemType> renderActivityItems = (List<ActivityItemType>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40019A8")]
			public List<FurnitureItemType> renderFurnitureItems = (List<FurnitureItemType>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60010F3")]
			[Cpp2IlInjected.Address(RVA = "0x156B580", Offset = "0x1569F80", VA = "0x18156B580")]
			public Tab()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003F6")]
		public class PresetBinding
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019A9")]
			public string path;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019AA")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60010F4")]
			[Cpp2IlInjected.Address(RVA = "0x156B110", Offset = "0x1569B10", VA = "0x18156B110")]
			public PresetBinding(int id, string path)
			{
				this.path = path;
				this.id = id;
				/*Error: Unexpected end of block*/;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003F7")]
		public class Preset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019AB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019AC")]
			public bool hidden;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40019AD")]
			[HideInInspector]
			public Settings settings;

			[Cpp2IlInjected.Token(Token = "0x60010F5")]
			[Cpp2IlInjected.Address(RVA = "0x156B150", Offset = "0x1569B50", VA = "0x18156B150")]
			public Preset(string name, Settings settings)
			{
				this.name = name;
				this.settings = settings;
				/*Error: Unexpected end of block*/;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003F8")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019AE")]
			public CameraSettings[] cameras;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019AF")]
			public int mannequinPose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40019B0")]
			public int maleMannequinPose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40019B1")]
			public float lightDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40019B2")]
			public float lightIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40019B3")]
			public Color backgroundColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40019B4")]
			public Color mannequinColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40019B5")]
			public MannequinMode mannequinMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40019B6")]
			public bool postProcess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
			[Cpp2IlInjected.Token(Token = "0x40019B7")]
			public bool backFaces;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
			[Cpp2IlInjected.Token(Token = "0x40019B8")]
			public bool particles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4F")]
			[Cpp2IlInjected.Token(Token = "0x40019B9")]
			public bool GPUFraming;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40019BA")]
			public AlphaMode alphaMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40019BB")]
			public float brightnessTreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40019BC")]
			public bool lockCamera;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40019BD")]
			public float animTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40019BE")]
			public Color hairBaseColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40019BF")]
			public Color hairColorOne;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40019C0")]
			public Color hairColorTwo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40019C1")]
			public Color hairColorThree;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40019C2")]
			public Color hairAmbientColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40019C3")]
			public Color hairSpecularColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40019C4")]
			public Color makeupColor1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40019C5")]
			public Color makeupColor2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40019C6")]
			public float makeupOpacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
			[Cpp2IlInjected.Token(Token = "0x40019C7")]
			public float makeupGloss;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40019C8")]
			public bool makeupMannequinColor;

			[Cpp2IlInjected.Token(Token = "0x60010F6")]
			[Cpp2IlInjected.Address(RVA = "0x156B1A0", Offset = "0x1569BA0", VA = "0x18156B1A0")]
			public Settings Copy()
			{
				return MakeCopy(this);
			}

			[Cpp2IlInjected.Token(Token = "0x60010F7")]
			[Cpp2IlInjected.Address(RVA = "0x156B1E0", Offset = "0x1569BE0", VA = "0x18156B1E0")]
			public Settings()
			{
				//Discarded unreachable code: IL_016f
				//IL_013e: Expected O, but got I4
				//IL_014e: Expected I4, but got I8
				//IL_0156: Expected O, but got I4
				CameraSettings[] array;
				CameraSettings cameraSettings5;
				while (true)
				{
					array = new CameraSettings[5];
					CameraSettings cameraSettings = new CameraSettings();
					cameraSettings.dolly = 1f;
					cameraSettings.fov = 56f;
					cameraSettings.fov = 42f;
					if (cameraSettings == null)
					{
						continue;
					}
					array[0] = cameraSettings;
					CameraSettings cameraSettings2 = new CameraSettings();
					cameraSettings2.dolly = 1f;
					cameraSettings2.fov = 56f;
					cameraSettings2.fov = 42f;
					if (cameraSettings2 == null)
					{
						continue;
					}
					array[1] = cameraSettings2;
					CameraSettings cameraSettings3 = new CameraSettings();
					cameraSettings3.dolly = 1f;
					cameraSettings3.fov = 56f;
					cameraSettings3.fov = 42f;
					if (cameraSettings3 == null)
					{
						continue;
					}
					array[2] = cameraSettings3;
					CameraSettings cameraSettings4 = new CameraSettings();
					cameraSettings4.dolly = 1f;
					cameraSettings4.fov = 56f;
					cameraSettings4.fov = 56f;
					if (cameraSettings4 != null)
					{
						array[3] = cameraSettings4;
						cameraSettings5 = new CameraSettings();
						cameraSettings5.dolly = 1f;
						cameraSettings5.fov = 56f;
						cameraSettings5.fov = 56f;
						if (cameraSettings5 != null)
						{
							break;
						}
					}
				}
				array[4] = cameraSettings5;
				cameras = array;
				int num = 0;
				lightIntensity = 2.7f;
				int num2 = 0;
				int num3 = 0;
				backgroundColor = (Color)num;
				postProcess = true;
				alphaMode = AlphaMode.FromBrightness;
				mannequinColor = (Color)num3;
				brightnessTreshold = 0.99f;
				lockCamera = true;
				base._002Ector();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003F9")]
		public class CameraSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019C9")]
			public FocusType focusType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40019CA")]
			public float dolly = 1f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019CB")]
			public Vector3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40019CC")]
			public float fov = 56f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40019CD")]
			[Range(-1f, 1f)]
			public float pitch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40019CE")]
			[Range(-1f, 1f)]
			public float yaw;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40019CF")]
			[Range(-1f, 1f)]
			public float roll;

			[Cpp2IlInjected.Token(Token = "0x60010F8")]
			[Cpp2IlInjected.Address(RVA = "0x156AA70", Offset = "0x1569470", VA = "0x18156AA70")]
			public CameraSettings Copy()
			{
				return MakeCopy(this);
			}

			[Cpp2IlInjected.Token(Token = "0x60010F9")]
			[Cpp2IlInjected.Address(RVA = "0x156AAB0", Offset = "0x15694B0", VA = "0x18156AAB0")]
			public Pose GetOrbitPose()
			{
				//IL_0055: Expected O, but got I4
				float num = default(float);
				float num2 = num * 0.499f;
				float z = Vector3.up.z;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
				Vector3 vector4 = default(Vector3);
				float z5 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z6 = vector5.z;
				int num3 = 0;
				offset = (Vector3)(focusType = FocusType.Bounds);
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60010FA")]
			[Cpp2IlInjected.Address(RVA = "0x156AD90", Offset = "0x1569790", VA = "0x18156AD90")]
			public CameraSettings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20003FA")]
		public enum FocusType
		{
			[Cpp2IlInjected.Token(Token = "0x40019D1")]
			Bounds,
			[Cpp2IlInjected.Token(Token = "0x40019D2")]
			World
		}

		[Cpp2IlInjected.Token(Token = "0x20003FB")]
		public enum RenderFilter
		{
			[Cpp2IlInjected.Token(Token = "0x40019D4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40019D5")]
			ItemOnly,
			[Cpp2IlInjected.Token(Token = "0x40019D6")]
			MissingOnly,
			[Cpp2IlInjected.Token(Token = "0x40019D7")]
			RedMarkOnly,
			[Cpp2IlInjected.Token(Token = "0x40019D8")]
			ExistingOnly
		}

		[Cpp2IlInjected.Token(Token = "0x20003FC")]
		public enum TexSize
		{
			[Cpp2IlInjected.Token(Token = "0x40019DA")]
			_16,
			[Cpp2IlInjected.Token(Token = "0x40019DB")]
			_32,
			[Cpp2IlInjected.Token(Token = "0x40019DC")]
			_64,
			[Cpp2IlInjected.Token(Token = "0x40019DD")]
			_128,
			[Cpp2IlInjected.Token(Token = "0x40019DE")]
			_256,
			[Cpp2IlInjected.Token(Token = "0x40019DF")]
			_512,
			[Cpp2IlInjected.Token(Token = "0x40019E0")]
			_1024,
			[Cpp2IlInjected.Token(Token = "0x40019E1")]
			_2048,
			[Cpp2IlInjected.Token(Token = "0x40019E2")]
			_4096,
			[Cpp2IlInjected.Token(Token = "0x40019E3")]
			_8184
		}

		[Cpp2IlInjected.Token(Token = "0x20003FD")]
		public enum AlphaMode
		{
			[Cpp2IlInjected.Token(Token = "0x40019E5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40019E6")]
			Classic,
			[Cpp2IlInjected.Token(Token = "0x40019E7")]
			FromBrightness
		}

		[Cpp2IlInjected.Token(Token = "0x20003FE")]
		public enum MannequinMode
		{
			[Cpp2IlInjected.Token(Token = "0x40019E9")]
			Classic,
			[Cpp2IlInjected.Token(Token = "0x40019EA")]
			Unlit,
			[Cpp2IlInjected.Token(Token = "0x40019EB")]
			Hidden
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003FF")]
		public class ClothMannequin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019EC")]
			public ClothingItemType type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40019ED")]
			public GameObject prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40019EE")]
			public GameObject malePrefab;

			[Cpp2IlInjected.Token(Token = "0x60010FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClothMannequin()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019A0")]
		public List<PresetBinding> binding = (List<PresetBinding>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019A1")]
		public List<Preset> presets = (List<Preset>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019A2")]
		public List<Tab> tabs = (List<Tab>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40019A3")]
		public List<ClothMannequin> clothMannequins = (List<ClothMannequin>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60010F1")]
		[Cpp2IlInjected.Address(RVA = "0x7EF670", Offset = "0x7EE070", VA = "0x1807EF670")]
		public static T MakeCopy<T>(T source)
		{
			string text = default(string);
			object obj = ((ICloneable)text).Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F2")]
		[Cpp2IlInjected.Address(RVA = "0xA45550", Offset = "0xA43F50", VA = "0x180A45550")]
		public AssetPresentationData()
		{
		}
	}
}
