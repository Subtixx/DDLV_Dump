using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Ui.Widgets;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008E4")]
	internal class AvatarMainEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008E5")]
		public delegate void SetGender(bool isMale);

		[Cpp2IlInjected.Token(Token = "0x20008E6")]
		public delegate void SetBodyType(int index);

		[Cpp2IlInjected.Token(Token = "0x20008E7")]
		public delegate void SelectClothes(Item item);

		[Cpp2IlInjected.Token(Token = "0x20008E8")]
		public delegate void RemoveClothes(ClothingItemType clothingType);

		[Cpp2IlInjected.Token(Token = "0x20008E9")]
		public delegate void SelectMakeup(MakeupItem makeupItem);

		[Cpp2IlInjected.Token(Token = "0x20008EA")]
		public delegate void RemoveMakeup(MakeupItemType makeupType);

		[Cpp2IlInjected.Token(Token = "0x20008EB")]
		public delegate void SelectFaceType(FacePartType facePartType, int index);

		[Cpp2IlInjected.Token(Token = "0x20008EC")]
		public delegate void SetSkinColor(int skinColorIndex);

		[Cpp2IlInjected.Token(Token = "0x20008ED")]
		public delegate void SetHairColor(int hairColorIndex);

		[Cpp2IlInjected.Token(Token = "0x20008EE")]
		public delegate void SetHighlightColor(int highlightColorIndex);

		[Cpp2IlInjected.Token(Token = "0x20008EF")]
		public delegate void SetEyeColor(int color);

		[Cpp2IlInjected.Token(Token = "0x20008F0")]
		public delegate void SetFaceBlendShape(int shapeDefIndex, float value);

		[Cpp2IlInjected.Token(Token = "0x20008F1")]
		public delegate void SetEyeOffset(EyeOffsetType type, float value);

		[Cpp2IlInjected.Token(Token = "0x20008F2")]
		public delegate void SetMouthOffset(MouthOffsetType type, float value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003508")]
		public TabsContainer tabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003509")]
		public AvatarMainEditTab tabPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400350A")]
		public ClothingSelectionView clothingSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400350B")]
		public FaceSelectionView faceSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400350C")]
		public MakeupSelectionView makeupSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400350D")]
		[SerializeField]
		private TabsContainer _genderTabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400350E")]
		[SerializeField]
		private Transform _skinColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400350F")]
		[SerializeField]
		private SkinColorButton _skinColorButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003510")]
		[SerializeField]
		private GameObject HairColorBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003511")]
		[SerializeField]
		private GameObject HighlightColorBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003512")]
		[SerializeField]
		private Transform _hairMainColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003513")]
		[SerializeField]
		private HairColorButton _hairColorButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003514")]
		[SerializeField]
		private Transform _hightlightColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003515")]
		[SerializeField]
		private Transform _eyeColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003516")]
		[SerializeField]
		private Button _newDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003517")]
		[SerializeField]
		private Button _editDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003518")]
		[SerializeField]
		private Button _deleteDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003519")]
		[SerializeField]
		private Button _setDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400351A")]
		[SerializeField]
		private Button _editMakeupButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400351B")]
		[SerializeField]
		private Text _currentDesign;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400351C")]
		[SerializeField]
		private Button _saveButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400351D")]
		[SerializeField]
		private Button _cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400351E")]
		[SerializeField]
		private Button _undoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400351F")]
		[SerializeField]
		private Button _redoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003520")]
		[SerializeField]
		private Button _photoViewButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003521")]
		[SerializeField]
		private Button _bodyTypeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003530")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003531")]
		private AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003532")]
		private int _makeupCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4003533")]
		private int _facePresetCount;

		[Cpp2IlInjected.Token(Token = "0x170007D9")]
		public Button EditDesignButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037E8")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _editDesignButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DA")]
		public Button NewDesignButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037E9")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _newDesignButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DB")]
		public Button EditMakeupButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037EA")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return _editMakeupButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DC")]
		public Button SaveButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037EB")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return _saveButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DD")]
		public Button CancelButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037EC")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return _cancelButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DE")]
		public Button UndoButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037ED")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return _undoButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007DF")]
		public Button RedoButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037EE")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return _redoButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007E0")]
		public Button PhotoViewButton
		{
			[Cpp2IlInjected.Token(Token = "0x60037EF")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return _photoViewButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000057")]
		public event SetGender OnGenderSet
		{
			[Cpp2IlInjected.Token(Token = "0x60037F0")]
			[Cpp2IlInjected.Address(RVA = "0x88AC60", Offset = "0x889660", VA = "0x18088AC60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037F1")]
			[Cpp2IlInjected.Address(RVA = "0x88B540", Offset = "0x889F40", VA = "0x18088B540")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000058")]
		public event SetBodyType OnBodyTypeSet
		{
			[Cpp2IlInjected.Token(Token = "0x60037F2")]
			[Cpp2IlInjected.Address(RVA = "0x88A800", Offset = "0x889200", VA = "0x18088A800")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037F3")]
			[Cpp2IlInjected.Address(RVA = "0x88B0E0", Offset = "0x889AE0", VA = "0x18088B0E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000059")]
		public event SelectClothes OnClothesSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60037F4")]
			[Cpp2IlInjected.Address(RVA = "0x88A940", Offset = "0x889340", VA = "0x18088A940")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037F5")]
			[Cpp2IlInjected.Address(RVA = "0x88B220", Offset = "0x889C20", VA = "0x18088B220")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005A")]
		public event RemoveClothes OnClothesRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60037F6")]
			[Cpp2IlInjected.Address(RVA = "0x88A8A0", Offset = "0x8892A0", VA = "0x18088A8A0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037F7")]
			[Cpp2IlInjected.Address(RVA = "0x88B180", Offset = "0x889B80", VA = "0x18088B180")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005B")]
		public event SelectMakeup OnMakeupSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60037F8")]
			[Cpp2IlInjected.Address(RVA = "0x88AEE0", Offset = "0x8898E0", VA = "0x18088AEE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037F9")]
			[Cpp2IlInjected.Address(RVA = "0x88B7C0", Offset = "0x88A1C0", VA = "0x18088B7C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005C")]
		public event RemoveMakeup OnMakeupRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60037FA")]
			[Cpp2IlInjected.Address(RVA = "0x88AE40", Offset = "0x889840", VA = "0x18088AE40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037FB")]
			[Cpp2IlInjected.Address(RVA = "0x88B720", Offset = "0x88A120", VA = "0x18088B720")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005D")]
		public event SelectFaceType OnFaceTypeSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60037FC")]
			[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8895C0", VA = "0x18088ABC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037FD")]
			[Cpp2IlInjected.Address(RVA = "0x88B4A0", Offset = "0x889EA0", VA = "0x18088B4A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005E")]
		public event SetSkinColor OnSkinColorSet
		{
			[Cpp2IlInjected.Token(Token = "0x60037FE")]
			[Cpp2IlInjected.Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037FF")]
			[Cpp2IlInjected.Address(RVA = "0x88B900", Offset = "0x88A300", VA = "0x18088B900")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005F")]
		public event SetHairColor OnHairColorSet
		{
			[Cpp2IlInjected.Token(Token = "0x6003800")]
			[Cpp2IlInjected.Address(RVA = "0x88AD00", Offset = "0x889700", VA = "0x18088AD00")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003801")]
			[Cpp2IlInjected.Address(RVA = "0x88B5E0", Offset = "0x889FE0", VA = "0x18088B5E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000060")]
		public event SetHairColor OnHighlightColorSet
		{
			[Cpp2IlInjected.Token(Token = "0x6003802")]
			[Cpp2IlInjected.Address(RVA = "0x88ADA0", Offset = "0x8897A0", VA = "0x18088ADA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003803")]
			[Cpp2IlInjected.Address(RVA = "0x88B680", Offset = "0x88A080", VA = "0x18088B680")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000061")]
		public event SetEyeColor OnEyeColorSet
		{
			[Cpp2IlInjected.Token(Token = "0x6003804")]
			[Cpp2IlInjected.Address(RVA = "0x88A9E0", Offset = "0x8893E0", VA = "0x18088A9E0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003805")]
			[Cpp2IlInjected.Address(RVA = "0x88B2C0", Offset = "0x889CC0", VA = "0x18088B2C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000062")]
		public event SetFaceBlendShape OnFaceBlendShapeSet
		{
			[Cpp2IlInjected.Token(Token = "0x6003806")]
			[Cpp2IlInjected.Address(RVA = "0x88AB20", Offset = "0x889520", VA = "0x18088AB20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003807")]
			[Cpp2IlInjected.Address(RVA = "0x88B400", Offset = "0x889E00", VA = "0x18088B400")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000063")]
		public event SetEyeOffset OnEyeOffsetSet
		{
			[Cpp2IlInjected.Token(Token = "0x6003808")]
			[Cpp2IlInjected.Address(RVA = "0x88AA80", Offset = "0x889480", VA = "0x18088AA80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003809")]
			[Cpp2IlInjected.Address(RVA = "0x88B360", Offset = "0x889D60", VA = "0x18088B360")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000064")]
		public event SetMouthOffset OnMouthOffsetSet
		{
			[Cpp2IlInjected.Token(Token = "0x600380A")]
			[Cpp2IlInjected.Address(RVA = "0x88AF80", Offset = "0x889980", VA = "0x18088AF80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600380B")]
			[Cpp2IlInjected.Address(RVA = "0x88B860", Offset = "0x88A260", VA = "0x18088B860")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600380C")]
		[Cpp2IlInjected.Address(RVA = "0x887770", Offset = "0x886170", VA = "0x180887770")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0310
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			int num = 0;
			ClothingSelectionView clothingSelectionView = clothingSelection;
			ClothingSelectionView.ClothesSelected value = ClothesSelected;
			clothingSelectionView.OnClothesSelected += value;
			ClothingSelectionView clothingSelectionView2 = clothingSelection;
			ClothingSelectionView.ClothesRemoved value2 = ClothesRemoved;
			clothingSelectionView2.OnClothesRemoved += value2;
			MakeupSelectionView makeupSelectionView = makeupSelection;
			MakeupSelectionView.MakeupSelected value3 = MakeupSelected;
			makeupSelectionView.OnMakeupSelected += value3;
			MakeupSelectionView makeupSelectionView2 = makeupSelection;
			MakeupSelectionView.MakeupRemoved value4 = MakeupRemoved;
			makeupSelectionView2.OnMakeupRemoved += value4;
			FaceSelectionView faceSelectionView = faceSelection;
			FaceSelectionView.FacePartTypeSelected value5 = delegate(FacePartType facePartType, int index)
			{
				//Discarded unreachable code: IL_001a
				this.OnFaceTypeSelected?.Invoke(facePartType, index);
			};
			faceSelectionView.OnFacePartTypeSelected += value5;
			TabsContainer tabsContainer = this.tabsContainer;
			int num2 = Enum.GetValues(typeof(FacePartType)).System_002ECollections_002EICollection_002ECount;
			int num3 = Enum.GetValues(typeof(MakeupItemType)).System_002ECollections_002EICollection_002ECount;
			num3 = (tabsContainer.initialIndex = num3 + num2);
			this.tabsContainer.Init();
			Button[] componentsInChildren = _eyeColorContainer.GetComponentsInChildren<Button>();
			int i = num;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				Button button = componentsInChildren[num];
				Image component = button.GetComponent<Image>();
				Button.ButtonClickedEvent onClick = button.m_OnClick;
				UnityAction unityAction = default(UnityAction);
				UnityAction unityAction2 = unityAction;
				if (unityAction2 == null)
				{
					unityAction = delegate
					{
						//Discarded unreachable code: IL_0020
						SetEyeColor onEyeColorSet = this.OnEyeColorSet;
						if (onEyeColorSet != null)
						{
							int color = i;
							onEyeColorSet(color);
						}
					};
				}
				onClick.AddListener(unityAction2);
				num++;
			}
			IEnumerator enumerator = Enum.GetValues(typeof(MakeupItemType)).GetEnumerator();
			int num4 = 0;
			uint num5 = default(uint);
			if (num4 < (int)num5)
			{
				num4 += num4;
				num4++;
			}
			string text2 = default(string);
			if (enumerator != null)
			{
				uint num6 = default(uint);
				if (num4 < (int)num6)
				{
					num4 += num4;
					num4++;
				}
				int num7 = num4;
				AvatarMainEditTab original = tabPrefab;
				Transform parent = this.tabsContainer.transform;
				AvatarMainEditTab avatarMainEditTab = UnityEngine.Object.Instantiate(original, parent);
				string text = avatarMainEditTab.ToString();
				AvatarMainEditTab avatarMainEditTab2 = avatarMainEditTab;
				text2 = "Makeup " + text;
				avatarMainEditTab._label.text = text2;
				TabsContainer tabsContainer2 = this.tabsContainer;
				Tab tab = avatarMainEditTab._tab;
				tabsContainer2.AddTab(tab);
				tab = (Tab)(object)((object)tab + (object)tab);
				tab = (Tab)(object)((object)tab + (object)tab);
			}
			int num8 = 0;
			if (text2 != null)
			{
				int num9 = 0;
			}
			IEnumerator enumerator2 = Enum.GetValues(typeof(FacePartType)).GetEnumerator();
			uint num10 = default(uint);
			if (num8 < (int)num10)
			{
				num8 += num8;
				num8++;
			}
			if (enumerator2 != null)
			{
				IEnumerator enumerator3 = enumerator2;
				AvatarMainEditTab avatarMainEditTab3 = default(AvatarMainEditTab);
				string text3 = avatarMainEditTab3.ToString();
				AvatarMainEditTab avatarMainEditTab4 = avatarMainEditTab3;
				avatarMainEditTab3._label.text = text3;
				Tab tab2 = avatarMainEditTab3._tab;
				tab2 = (Tab)(object)((object)tab2 + (object)tab2);
			}
			int num11 = 0;
			IEnumerator enumerator4 = Enum.GetValues(typeof(ClothingItemType)).GetEnumerator();
			if (enumerator4 != null)
			{
				IEnumerator enumerator5 = enumerator4;
				AvatarMainEditTab avatarMainEditTab5 = default(AvatarMainEditTab);
				string text4 = avatarMainEditTab5.ToString();
				AvatarMainEditTab avatarMainEditTab6 = avatarMainEditTab5;
				avatarMainEditTab5._label.text = text4;
				Tab tab3 = avatarMainEditTab5._tab;
			}
			int num12 = 0;
			int num13 = 0;
			bool active = default(bool);
			GameObject gameObject = default(GameObject);
			gameObject.SetActive(active);
			int num14 = 0;
			gameObject = (GameObject)(gameObject - num14);
			bool active2 = gameObject < "{il2cpp field on {'constant217' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x16C}";
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive(active2);
			int num15 = 0;
			GameObject gameObject3 = default(GameObject);
			bool active3 = default(bool);
			gameObject3.SetActive(active3);
			int num16 = 0;
			int num17 = 0;
			int num18 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600380D")]
		[Cpp2IlInjected.Address(RVA = "0x888E50", Offset = "0x887850", VA = "0x180888E50")]
		public void Init(AvatarAppearance avatar, AvatarCustomization avatarCustomization)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600380E")]
		[Cpp2IlInjected.Address(RVA = "0x88A1B0", Offset = "0x888BB0", VA = "0x18088A1B0")]
		public void Refresh(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_003b
			TabsContainer genderTabs = _genderTabs;
			bool index = avatar.IsMale;
			genderTabs.SelectTab(index ? 1 : 0);
			Text currentDesign = _currentDesign;
			ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
			int num = this.CurrentDesignId((Nullable<>)clothingItemType);
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x600380F")]
		[Cpp2IlInjected.Address(RVA = "0x88A4C0", Offset = "0x888EC0", VA = "0x18088A4C0")]
		public void Show()
		{
			//Discarded unreachable code: IL_0013
			base.gameObject.SetActive(value: true);
			PopulateCurrent();
		}

		[Cpp2IlInjected.Token(Token = "0x6003810")]
		[Cpp2IlInjected.Address(RVA = "0x888E00", Offset = "0x887800", VA = "0x180888E00")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0027
			clothingSelection.Clear();
			makeupSelection.Clear();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003811")]
		[Cpp2IlInjected.Address(RVA = "0x88A380", Offset = "0x888D80", VA = "0x18088A380")]
		private void SelectSkinColor(int skinColorIndex)
		{
			this.OnSkinColorSet?.Invoke(skinColorIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6003812")]
		[Cpp2IlInjected.Address(RVA = "0x88A340", Offset = "0x888D40", VA = "0x18088A340")]
		private void SelectHairColor(int hairColorIndex)
		{
			this.OnHairColorSet?.Invoke(hairColorIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6003813")]
		[Cpp2IlInjected.Address(RVA = "0x88A360", Offset = "0x888D60", VA = "0x18088A360")]
		private void SelectHighlightColor(int highlightColorIndex)
		{
			this.OnHighlightColorSet?.Invoke(highlightColorIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6003814")]
		[Cpp2IlInjected.Address(RVA = "0x888770", Offset = "0x887170", VA = "0x180888770")]
		private void ClothesSelected(Item item)
		{
			//Discarded unreachable code: IL_0031
			this.OnClothesSelected?.Invoke(item);
			Text currentDesign = _currentDesign;
			ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
			int num = this.CurrentDesignId((Nullable<>)clothingItemType);
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6003815")]
		[Cpp2IlInjected.Address(RVA = "0x8886F0", Offset = "0x8870F0", VA = "0x1808886F0")]
		private void ClothesRemoved(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0031
			this.OnClothesRemoved?.Invoke(clothingType);
			Text currentDesign = _currentDesign;
			ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
			int num = this.CurrentDesignId((Nullable<>)clothingItemType);
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6003816")]
		[Cpp2IlInjected.Address(RVA = "0x889B90", Offset = "0x888590", VA = "0x180889B90")]
		private void MakeupSelected(MakeupItem makeup)
		{
			this.OnMakeupSelected?.Invoke(makeup);
		}

		[Cpp2IlInjected.Token(Token = "0x6003817")]
		[Cpp2IlInjected.Address(RVA = "0x889B70", Offset = "0x888570", VA = "0x180889B70")]
		private void MakeupRemoved(MakeupItemType makeupType)
		{
			this.OnMakeupRemoved?.Invoke(makeupType);
		}

		[Cpp2IlInjected.Token(Token = "0x6003818")]
		[Cpp2IlInjected.Address(RVA = "0x88A790", Offset = "0x889190", VA = "0x18088A790")]
		private void UpdateCurrentDesignLabel()
		{
			//Discarded unreachable code: IL_001e
			Text currentDesign = _currentDesign;
			ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
			int num = this.CurrentDesignId((Nullable<>)clothingItemType);
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6003819")]
		[Cpp2IlInjected.Address(RVA = "0x888890", Offset = "0x887290", VA = "0x180888890")]
		private int CurrentDesignId(ClothingItemType? clothingType)
		{
			//Discarded unreachable code: IL_000e
			AvatarAppearance avatar = _avatar;
			bool flag = default(bool);
			if (flag)
			{
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x600381A")]
		[Cpp2IlInjected.Address(RVA = "0x889BB0", Offset = "0x8885B0", VA = "0x180889BB0")]
		private void NextDesign()
		{
			//Discarded unreachable code: IL_007b
			ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
			if ((object)clothingItemType != null)
			{
				AvatarWorkingCopy currentAvatar = _avatar.CurrentAvatar;
				AvatarAppearance avatar = _avatar;
				int currentId = this.CurrentDesignId((Nullable<>)clothingItemType);
				Predicate<KeyValuePair<int, Design>> predicate = (Predicate<KeyValuePair<int, Design>>)(object)(Predicate<T>)delegate
				{
					int num3 = currentId;
					bool result = default(bool);
					return result;
				};
				List<KeyValuePair<int, Design>> list = default(List<KeyValuePair<int, Design>>);
				int num = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				int size = ((List<>)(object)list)._size;
				num++;
				if ((IntPtr)predicate != (IntPtr)size)
				{
					int num2 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num2 += num2;
				}
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600381B")]
		[Cpp2IlInjected.Address(RVA = "0x88A3A0", Offset = "0x888DA0", VA = "0x18088A3A0")]
		[AsyncStateMachine(typeof(_003CSetCurrentDesign_003Ed__117))]
		private Task SetCurrentDesign(Item item, int designId)
		{
			int itemID = item.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600381C")]
		[Cpp2IlInjected.Address(RVA = "0x888BB0", Offset = "0x8875B0", VA = "0x180888BB0")]
		private void DeleteDesign()
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			if ((object)this.CurrentClothingType() != null)
			{
				AvatarAppearance avatar = _avatar;
				DesignWorkingCopy designWorkingCopy = default(DesignWorkingCopy);
				if (designWorkingCopy != null)
				{
					int num2 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				Text currentDesign = _currentDesign;
				ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
				int num3 = this.CurrentDesignId((Nullable<>)clothingItemType);
				string text = default(string);
				currentDesign.text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600381D")]
		[Cpp2IlInjected.Address(RVA = "0x888A70", Offset = "0x887470", VA = "0x180888A70")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__119))]
		private Task DeleteDesignAsync(DesignWorkingCopy design, ClothingItemType clothingType)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600381E")]
		[Cpp2IlInjected.Address(RVA = "0x8887F0", Offset = "0x8871F0", VA = "0x1808887F0")]
		public ClothingItemType? CurrentClothingType()
		{
			if (clothingSelection.gameObject.activeSelf)
			{
				int _003CCurrentTabIndex_003Ek__BackingField = tabsContainer.CurrentTabIndex;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600381F")]
		[Cpp2IlInjected.Address(RVA = "0x888940", Offset = "0x887340", VA = "0x180888940")]
		public FacePartType? CurrentFacePartType()
		{
			if (faceSelection.gameObject.activeSelf)
			{
				int _003CCurrentTabIndex_003Ek__BackingField = tabsContainer.CurrentTabIndex;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003820")]
		[Cpp2IlInjected.Address(RVA = "0x8889E0", Offset = "0x8873E0", VA = "0x1808889E0")]
		public MakeupItemType? CurrentMakeupType()
		{
			if (makeupSelection.gameObject.activeSelf)
			{
				int _003CCurrentTabIndex_003Ek__BackingField = tabsContainer.CurrentTabIndex;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003821")]
		[Cpp2IlInjected.Address(RVA = "0x88A300", Offset = "0x888D00", VA = "0x18088A300")]
		private void SelectGender(int currentTab)
		{
			SetGender onGenderSet = this.OnGenderSet;
			if (onGenderSet != null)
			{
				bool isMale = currentTab == 1;
				onGenderSet(isMale);
			}
			PopulateCurrent();
		}

		[Cpp2IlInjected.Token(Token = "0x6003822")]
		[Cpp2IlInjected.Address(RVA = "0x88A250", Offset = "0x888C50", VA = "0x18088A250")]
		private void SelectBodyType()
		{
			//Discarded unreachable code: IL_0053
			int bodyType_ = _avatar.CurrentAvatar.Data.bodyType_;
			AvatarAppearance avatar = _avatar;
			bodyType_++;
			if (!avatar.IsMale)
			{
				List<AvatarAppearance.BodyType> femaleBodyTypes = avatar.femaleBodyTypes;
			}
			List<AvatarAppearance.BodyType> maleBodyTypes = avatar.maleBodyTypes;
			int index = 0;
			this.OnBodyTypeSet?.Invoke(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6003823")]
		[Cpp2IlInjected.Address(RVA = "0x88A500", Offset = "0x888F00", VA = "0x18088A500")]
		private void SwitchTab(int index)
		{
			//Discarded unreachable code: IL_00cc
			//IL_0010: Expected O, but got I4
			AvatarCustomization avatarCustomization = _avatarCustomization;
			int num = 0;
			if (!(avatarCustomization == (UnityEngine.Object)num))
			{
				GameObject gameObject = makeupSelection.gameObject;
				TabsContainer tabsContainer = this.tabsContainer;
				int makeupCount = _makeupCount;
				bool active = tabsContainer.CurrentTabIndex < makeupCount;
				gameObject.SetActive(active);
				GameObject gameObject2 = faceSelection.gameObject;
				int _003CCurrentTabIndex_003Ek__BackingField = this.tabsContainer.CurrentTabIndex;
				int makeupCount2 = _makeupCount;
				if (_003CCurrentTabIndex_003Ek__BackingField < makeupCount2)
				{
				}
				_003CCurrentTabIndex_003Ek__BackingField -= makeupCount2;
				bool active2 = _003CCurrentTabIndex_003Ek__BackingField < _facePresetCount;
				gameObject2.SetActive(active2);
				GameObject gameObject3 = clothingSelection.gameObject;
				TabsContainer tabsContainer2 = this.tabsContainer;
				int facePresetCount = _facePresetCount;
				bool active3 = tabsContainer2.CurrentTabIndex >= facePresetCount;
				gameObject3.SetActive(active3);
				PopulateCurrent();
				ToggleHairMenu();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003824")]
		[Cpp2IlInjected.Address(RVA = "0x889E00", Offset = "0x888800", VA = "0x180889E00")]
		private void PopulateCurrent()
		{
			//Discarded unreachable code: IL_00fb
			if (!clothingSelection.gameObject.activeSelf)
			{
				bool activeSelf = makeupSelection.gameObject.activeSelf;
				AvatarCustomization avatarCustomization = _avatarCustomization;
				if (!activeSelf)
				{
					avatarCustomization.ZoomIn();
					FaceSelectionView faceSelectionView = faceSelection;
					if (faceSelection.gameObject.activeSelf)
					{
						int _003CCurrentTabIndex_003Ek__BackingField = tabsContainer.CurrentTabIndex;
						int num = 0;
					}
					int num2 = 0;
				}
				else
				{
					MakeupSelectionView makeupSelectionView = makeupSelection;
					if (makeupSelection.gameObject.activeSelf)
					{
						int _003CCurrentTabIndex_003Ek__BackingField2 = tabsContainer.CurrentTabIndex;
						int num3 = 0;
					}
					int num4 = 0;
				}
			}
			else
			{
				_avatarCustomization.ZoomOut();
				ClothingSelectionView clothingSelectionView = clothingSelection;
				if (clothingSelection.gameObject.activeSelf)
				{
					int _003CCurrentTabIndex_003Ek__BackingField3 = tabsContainer.CurrentTabIndex;
					int num5 = 0;
				}
				int num6 = 0;
				Text currentDesign = _currentDesign;
				ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
				int num7 = this.CurrentDesignId((Nullable<>)clothingItemType);
				string text = default(string);
				currentDesign.text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003825")]
		[Cpp2IlInjected.Address(RVA = "0x88A660", Offset = "0x889060", VA = "0x18088A660")]
		private void ToggleHairMenu()
		{
			//Discarded unreachable code: IL_0067
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			GameObject hairColorBox = HairColorBox;
			int num = 0;
			if (!(hairColorBox == (UnityEngine.Object)num))
			{
				GameObject highlightColorBox = HighlightColorBox;
				int num2 = 0;
				if (!(highlightColorBox == (UnityEngine.Object)num2))
				{
					GameObject hairColorBox2 = HairColorBox;
					ClothingItemType? clothingItemType = (ClothingItemType?)this.CurrentClothingType();
					ClothingItemType clothingItemType2 = default(ClothingItemType);
					bool active = clothingItemType2 == ClothingItemType.BodHair;
					hairColorBox2.SetActive(active);
					GameObject highlightColorBox2 = HighlightColorBox;
					ClothingItemType? clothingItemType3 = (ClothingItemType?)this.CurrentClothingType();
					ClothingItemType clothingItemType4 = default(ClothingItemType);
					bool active2 = clothingItemType4 == ClothingItemType.BodHair;
					highlightColorBox2.SetActive(active2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003826")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarMainEditView()
		{
		}
	}
}
