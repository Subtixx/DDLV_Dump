using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Activities;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000630")]
	public class MapHarvestItem : MapItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002276")]
		[SerializeField]
		private SpriteAtlasImage _regularBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002277")]
		[SerializeField]
		private SpriteAtlasImage _needWaterBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002278")]
		[SerializeField]
		private GameObject _vegetableIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002279")]
		[SerializeField]
		private GameObject _fruitIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400227A")]
		[SerializeField]
		private GameObject _waterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400227B")]
		[SerializeField]
		private GameObject _countHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400227C")]
		[SerializeField]
		private TextBase _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400227D")]
		[SerializeField]
		private PlayerTaskDefinition _harvestDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400227E")]
		private Garden _garden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400227F")]
		private GardeningSlot _gardeningSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002280")]
		private int _gardenCount;

		[Cpp2IlInjected.Token(Token = "0x17000611")]
		public Garden Garden
		{
			[Cpp2IlInjected.Token(Token = "0x6002851")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _garden;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000612")]
		public bool NeedsWatering
		{
			[Cpp2IlInjected.Token(Token = "0x6002852")]
			[Cpp2IlInjected.Address(RVA = "0x117D4F0", Offset = "0x117BEF0", VA = "0x18117D4F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _waterIcon.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000613")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6002853")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return _gardenCount;
			}
			[Cpp2IlInjected.Token(Token = "0x6002854")]
			[Cpp2IlInjected.Address(RVA = "0x117D520", Offset = "0x117BF20", VA = "0x18117D520")]
			set
			{
				//Discarded unreachable code: IL_0027
				_gardenCount = value;
				GameObject countHolder = _countHolder;
				bool active = value > 1;
				countHolder.SetActive(active);
				string text = default(string);
				_count.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000614")]
		internal override bool IsPinned
		{
			[Cpp2IlInjected.Token(Token = "0x6002855")]
			[Cpp2IlInjected.Address(RVA = "0x117D4D0", Offset = "0x117BED0", VA = "0x18117D4D0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return PinVisual.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x6002856")]
			[Cpp2IlInjected.Address(RVA = "0x117D580", Offset = "0x117BF80", VA = "0x18117D580", Slot = "5")]
			set
			{
				//IL_001c: Expected O, but got I4
				//IL_002f: Expected O, but got I4
				//IL_0059: Expected O, but got I4
				//IL_0065: Expected O, but got I4
				PinVisual.SetActive(value);
				Garden garden = _garden;
				int num = 0;
				if (!(garden != (UnityEngine.Object)num))
				{
					return;
				}
				GardeningSlot gardeningSlot = _gardeningSlot;
				int num2 = 0;
				if (!(gardeningSlot != (UnityEngine.Object)num2))
				{
					return;
				}
				if ((object)_garden.GetComponent<PlayerTaskCollider>() != null)
				{
				}
				int num3 = 0;
				TrailSystem trailSystem = default(TrailSystem);
				Transform target = trailSystem.Target;
				if (value)
				{
					if ((UnityEngine.Object)num3 != target)
					{
						trailSystem.Target = (Transform)num3;
					}
					return;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002857")]
		[Cpp2IlInjected.Address(RVA = "0x117D180", Offset = "0x117BB80", VA = "0x18117D180")]
		public void RefreshData(Garden garden, bool needsWatering)
		{
			//Discarded unreachable code: IL_0139
			//IL_0028: Expected I4, but got I8
			//IL_0049: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			_garden = garden;
			int slotIndex = 0;
			GardeningSlot gardeningSlot = (_gardeningSlot = garden.GetGardeningSlot(slotIndex));
			GameObject countHolder = _countHolder;
			_gardenCount = 1;
			int active = 0;
			countHolder.SetActive((byte)active != 0);
			string text = default(string);
			_count.Text = text;
			int num = 0;
			if (!(garden != (UnityEngine.Object)num))
			{
				return;
			}
			GardeningSlot gardeningSlot2 = _gardeningSlot;
			int num2 = 0;
			if (!(gardeningSlot2 != (UnityEngine.Object)num2))
			{
				return;
			}
			_regularBackground.gameObject.SetActive(needsWatering);
			_needWaterBackground.gameObject.SetActive(needsWatering);
			GameObject vegetableIcon = _vegetableIcon;
			if (needsWatering)
			{
			}
			bool active2 = garden.Data.cropType_ == CropType.Vegetable;
			vegetableIcon.SetActive(active2);
			GameObject fruitIcon = _fruitIcon;
			if (needsWatering)
			{
			}
			bool active3 = garden.Data.cropType_ == CropType.Fruit;
			fruitIcon.SetActive(active3);
			GameObject waterIcon = _waterIcon;
			active3 = needsWatering;
			waterIcon.SetActive(active3);
			int num3 = 0;
			TrailSystem trailSystem = default(TrailSystem);
			if (trailSystem != (UnityEngine.Object)num3)
			{
				Transform target = trailSystem.Target;
				PlayerTaskCollider component = garden.GetComponent<PlayerTaskCollider>();
				Transform destination = default(Transform);
				if ((object)component != null)
				{
					destination = component.Destination;
				}
				if (target == destination)
				{
					((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002858")]
		[Cpp2IlInjected.Address(RVA = "0x117D070", Offset = "0x117BA70", VA = "0x18117D070")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_0058
			//IL_0010: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			Garden garden = _garden;
			int num = 0;
			if (!(garden != (UnityEngine.Object)num))
			{
				return;
			}
			GameObject gameObject = _garden.gameObject;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				GardeningSlot gardeningSlot = _gardeningSlot;
				int num3 = 0;
				if (gardeningSlot != (UnityEngine.Object)num3)
				{
					((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002859")]
		[Cpp2IlInjected.Address(RVA = "0x117CF80", Offset = "0x117B980", VA = "0x18117CF80", Slot = "6")]
		internal override void CopyTo(MapItem target)
		{
			//Discarded unreachable code: IL_0037
			if ((object)target != null)
			{
				int num = 0;
				if ((object)target != null)
				{
					GameObject pinVisual = PinVisual;
					GameObject pinVisual2 = target.PinVisual;
					bool activeSelf = pinVisual.activeSelf;
					pinVisual2.SetActive(activeSelf);
					Action<MapItem> action = (target.OnMapItemClicked = OnMapItemClicked);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600285A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MapHarvestItem()
		{
		}
	}
}
