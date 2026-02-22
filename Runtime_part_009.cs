	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> UpperIdleTimeOfDuration; // 0x738
	System.Single MobileAttackSlowDownTime; // 0x740
	System.Single MaxRange; // 0x744
	System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> BehaviorMapping; // 0x748
	System.Single HealthState1; // 0x750
	System.Single HealthState2; // 0x754
	System.Single TankSpeed; // 0x758
	System.Single TankTurretTurnSpeed; // 0x75c
	System.Single TargetNearRange; // 0x760
	System.Boolean InMainAttack; // 0x764
	System.Single ClientRotateLerpScale; // 0x768
	System.Single TurretTrackAngleSpeed; // 0x76c
	System.Boolean DefaultState; // 0x770
	System.Func<System.Single,System.Single> OnCalcFireParam; // 0x778
	System.Int64 TargetVehicleId; // 0x780
	System.Nullable<System.Numerics.Vector3> TargetVehicleMeleePoint; // 0x788
	System.Boolean NoTargetShoot; // 0x798
	System.Single WallShootDistance; // 0x79c
	System.Boolean UseGroundRandomShoot; // 0x7a0
	System.Int32 GroundRandomShootPointCount; // 0x7a4
	System.Boolean UseLastPositionShoot; // 0x7a8
	System.Single LastPositionTimestamp; // 0x7ac
	System.Single FleeRange; // 0x7b0
	System.Single NoTargetDurationToSleep; // 0x7b4
	System.Int32 FlagTypes; // 0x7b8
	System.Int64 AllowLongShootTime; // 0x7c0
	System.Single AgentStableTime; // 0x7c8
	System.Boolean ObstacleStable; // 0x7cc
	System.Boolean ForceMoving; // 0x7cd
	System.Int32 InvalidRoamCheck; // 0x7d0
	System.Boolean EnableLongShoot; // 0x7d4
	System.Single ObstacleMaxRange; // 0x7d8
	System.Int64 RelatedTargetId; // 0x7e0
	System.Int32 NotAttackCode; // 0x7e8
	System.Single AnchorRange; // 0x7ec
	System.Int64 MoveToEntityId; // 0x7f0
	System.Int32 PreBehaviorTemplateId; // 0x7f8
	System.Single DefensePatrolTeamDistance; // 0x7fc
	System.Boolean IsDefensePatrolTeam; // 0x800
	System.Boolean FleeToPatrolTeam; // 0x801
	System.Boolean <IsBeingSeeked>k__BackingField; // 0x802
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> <TargeterInfos>k__BackingField; // 0x808
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> <SeekerIds>k__BackingField; // 0x810
	System.Int32 NotRoamOrPatrolCount; // 0x818
	WizardGames.Soc.Common.Entity.IHeldItemEntity CurrentHeldItem; // 0x820
	WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage LocalMonsterSkillPlayStage; // 0x828
	WizardGames.Soc.Common.State.Monster.EMonsterGrenadeThrowType LocalMonsterGrenadeThrowType; // 0x82c
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidHeldItemData TpAniHeldItemData; // 0x830
	WizardGames.Soc.Common.Entity.HumanoidAnimLocalData TpAniPlayerLocalData; // 0x880
	WizardGames.Soc.Common.Data.DataItem.ItemEntityType TpCacheCurrentTableItemType; // 0x1588
	WizardGames.Soc.Common.Weapon.WeaponUnique TpAnimIndex; // 0x158c
	WizardGames.Soc.Common.Weapon.WeaponUnique ApplyTpAnimIndex; // 0x1598
	System.Int64 LogicFrameSequence; // 0x15a8
	System.String ShowName; // 0x15b0
	System.String CachedMonsterName; // 0x15b8
	System.Int32 GetClassHash(); // 0x06ebc2e4
	System.String GetTypeName(); // 0x06ebc34c
	System.Int32 get_EntityType(); // 0x06ebc3c4
	System.Void .ctor(); // 0x06ebc428
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ebcbbc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ebd6f4
	System.Single get_PosX(); // 0x06ebdeb4
	System.Void set_PosX(System.Single value); // 0x06ebdf28
	System.Single get_PosY(); // 0x06ebdfb4
	System.Void set_PosY(System.Single value); // 0x06ebe028
	System.Single get_PosZ(); // 0x06ebe0b4
	System.Void set_PosZ(System.Single value); // 0x06ebe128
	System.Single get_RotateX(); // 0x06ebe1b4
	System.Void set_RotateX(System.Single value); // 0x06ebe228
	System.Single get_RotateY(); // 0x06ebe2b4
	System.Void set_RotateY(System.Single value); // 0x06ebe328
	System.Single get_RotateZ(); // 0x06ebe3b8
	System.Void set_RotateZ(System.Single value); // 0x06ebe42c
	System.Single get_RotateYTargetOffset(); // 0x06ebe4b8
	System.Single get_OriginRotateY(); // 0x06ebe52c
	System.Single get_TargetLookX(); // 0x06ebe5a0
	System.Single get_TargetLookY(); // 0x06ebe614
	System.Single get_TargetLookZ(); // 0x06ebe688
	System.Int64 get_TemplateId(); // 0x06ebe6fc
	System.Int32 get_BattleState(); // 0x06ebe770
	System.Single get_Speed(); // 0x06ebe7e4
	System.Single get_SpeedX(); // 0x06ebe858
	System.Single get_SpeedZ(); // 0x06ebe8cc
	System.Int32 get_SpawnType(); // 0x06ebe940
	System.Int32 get_GroupTemplateId(); // 0x06ebe9b4
	System.Int64 get_MeleeAttackTS(); // 0x06ebea28
	System.Int64 get_CurrentHeldItemId(); // 0x06ebea9c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_HeldItem1(); // 0x06ebeb10
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_HeldItem2(); // 0x06ebebd4
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_HeldItem3(); // 0x06ebec98
	System.Int32 get_BehaviorTemplateId(); // 0x06ebed5c
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_ThrowWeapon(); // 0x06ebedd0
	System.Int32 get_SpeedType(); // 0x06ebee94
	System.Int32 get_MoveTypeDt(); // 0x06ebef08
	System.Int32 get_Type(); // 0x06ebef7c
	System.Void set_Type(System.Int32 value); // 0x06ebeff0
	System.Int64 get_TargetId(); // 0x06ebf07c
	System.Int64 get_SndTargetId(); // 0x06ebf0f0
	System.Int32 get_TransitionMode(); // 0x06ebf164
	System.Boolean get_AutoTurretIsOn(); // 0x06ebf1d8
	System.Int64 get_PartEntityId(); // 0x06ebf24c
	System.Boolean get_IsStateActive(); // 0x06ebf2c0
	System.Int32 get_AttackMode(); // 0x06ebf334
	System.Int32 get_MonumentId(); // 0x06ebf3a8
	System.Boolean get_CanRotate(); // 0x06ebf41c
	System.Int64 get_CorpseEntityId(); // 0x06ebf490
	System.Boolean get_IsActiveStatus(); // 0x06ebf504
	System.Single get_AtkAimTime(); // 0x06ebf578
	System.Int64 get_MountableId(); // 0x06ebf5ec
	System.Int32 get_VehicleType(); // 0x06ebf660
	System.Int32 get_MountSeatIndex(); // 0x06ebf6d4
	System.Boolean get_CanSummonNpc(); // 0x06ebf748
	System.Boolean get_EffectDisappear(); // 0x06ebf7bc
	System.Int32 get_BotFirstNameIndex(); // 0x06ebf830
	System.Int32 get_BotSecondNameIndex(); // 0x06ebf8a4
	System.Int32 get_CurrentHealthState(); // 0x06ebf918
	WizardGames.Soc.Common.CustomType.MonsterEntityCustom get_MonsterListData(); // 0x06ebf98c
	System.Boolean get_IsWild(); // 0x06ebfa50
	System.Int64 get_DeathStartTime(); // 0x06ebfac4
	System.Int32 get_Camp(); // 0x06ebfb38
	System.Boolean get_CurrentMouthOpen(); // 0x06ebfbac
	System.Int32 get_DeathAnimValue(); // 0x06ebfc20
	System.Byte get_MonsterLifeState(); // 0x06ebfc94
	System.Byte get_MonsterPoseState(); // 0x06ebfd08
	System.Byte get_MonsterAttackState(); // 0x06ebfd7c
	System.Byte get_MonsterActionState(); // 0x06ebfdf0
	System.Void set_MonsterActionState(System.Byte value); // 0x06ebfe64
	System.Byte get_MonsterMoveState(); // 0x06ebfef0
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06ebff64
	static System.Void InitializePropertyChangeCallbacks(); // 0x06ebffe4
	static System.Void OnTargetLookXChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06ec0714
	static System.Void OnTargetLookYChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06ec07d8
	static System.Void OnTargetLookZChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06ec089c
	static System.Void OnMoveTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec0960
	static System.Void OnBattleStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec0a24
	static System.Void OnSpeedXChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06ec0ae8
	static System.Void OnSpeedZChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06ec0bac
	static System.Void OnMeleeAttackTSChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int64 oldValue, System.Int64 newValue); // 0x06ec0c70
	static System.Void OnCurrentHeldItemIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int64 oldValue, System.Int64 newValue); // 0x06ec0d34
	static System.Void OnMoveTypeDtChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec0df8
	static System.Void OnTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec0ebc
	static System.Void OnTargetIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int64 oldValue, System.Int64 newValue); // 0x06ec0f80
	static System.Void OnMountableIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int64 oldValue, System.Int64 newValue); // 0x06ec1044
	static System.Void OnMonsterLifeStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec1108
	static System.Void OnMonsterPoseStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec11cc
	static System.Void OnMonsterAttackStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec1290
	static System.Void OnMonsterActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec1354
	static System.Void OnMonsterDirectionTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec1418
	static System.Void OnMonsterMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Byte oldValue, System.Byte newValue); // 0x06ec14dc
	static System.Void OnSpecialIdleAnimTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec15a0
	static System.Void OnNormalAttackTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06ec1664
	static System.Void .cctor(); // 0x06ec1728
	System.Void InvokeChildOnCustomCreate(); // 0x06ec2a28
	System.Void InvokeChildOnCustomRemove(); // 0x06ec2d3c
	System.Single get_PosX_Smooth(); // 0x06ec3080
	System.Void set_PosX_Smooth(System.Single value); // 0x06ec30e4
	System.Single get_PosY_Smooth(); // 0x06ec315c
	System.Void set_PosY_Smooth(System.Single value); // 0x06ec31c0
	System.Single get_PosZ_Smooth(); // 0x06ec3238
	System.Void set_PosZ_Smooth(System.Single value); // 0x06ec329c
	System.Single get_RotateX_Smooth(); // 0x06ec3314
	System.Void set_RotateX_Smooth(System.Single value); // 0x06ec3378
	System.Single get_RotateY_Smooth(); // 0x06ec33f0
	System.Void set_RotateY_Smooth(System.Single value); // 0x06ec3454
	System.Single get_RotateZ_Smooth(); // 0x06ec34cc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06ec3530
	System.Int64 get_ParentId(); // 0x06ec35a8
	System.Int64 get_MountID(); // 0x06ec360c
	System.Boolean get_HasLocalRotation(); // 0x06ec3670
	System.Boolean get_DeathStable(); // 0x06ec36d4
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06ec3740
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06ec3804
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06ec3880
	System.Void ClientInitMonsterEntityData(); // 0x06ec3990
	System.Void ClientInitTbMonsterData(WizardGames.Soc.Common.Data.units.Monster& monsterCfg); // 0x06ec3a2c
	System.Void ClientInitTbMonsterBehaviorData(WizardGames.Soc.Common.Data.units.Monster& monsterCfg); // 0x06ec3d70
	System.Void ClientInitTbMonsterBehaviorMappingData(WizardGames.Soc.Common.Data.units.Monster& monsterCfg); // 0x06ec41c8
	System.Boolean InitAnimalBehavior(System.Int32 paramId); // 0x06ec44f8
	System.Boolean InitScientistBehavior(System.Int32 paramId); // 0x06ec482c
	System.Boolean InitTurretBehavior(System.Int32 paramId); // 0x06ec4ae8
	System.Boolean InitTankBehavior(System.Int32 paramId); // 0x06ec4da8
	System.Boolean InitUnknowBehavior(System.Int32 paramId); // 0x06ec5044
	System.Void Init(); // 0x06ec5200
	System.Boolean get_IsOnMount(); // 0x06ec5278
	WizardGames.Soc.Common.Entity.IItemEntity GetItemEntity(System.Int32 id); // 0x06ec52e4
	System.Single get_HpRate(); // 0x06ec5410
	System.Boolean get_IsActive(); // 0x06ec54dc
	System.Boolean get_IsAutoTurret(); // 0x06ec555c
	System.Boolean get_IsNpcTurret(); // 0x06ec55cc
	System.Boolean get_IsAnimal(); // 0x06ec563c
	System.Boolean get_IsScientist(); // 0x06ec56ac
	System.Boolean get_IsTank(); // 0x06ec571c
	System.Boolean get_IsDead(); // 0x06ec578c
	System.Boolean get_IsInBattleState(); // 0x06ec5800
	System.Int64 get_GroupInstanceId(); // 0x06ec58d8
	System.Int64 get_TableID(); // 0x06ec5954
	System.Boolean IsValid(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06ec59b8
	System.Boolean get_CanBeShot(); // 0x06ec5a30
	UnityEngine.Vector3 get_SeekingPos(); // 0x06ec5b54
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> get_TargeterInfos(); // 0x06ec5bec
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_SeekerIds(); // 0x06ec5c50
	System.Boolean IsInWater(); // 0x06ec5cb4
	System.Single get_Hp(); // 0x06ec5aa0
	System.Single get_MaxHp(); // 0x06ec5d58
	System.String ToPrettyString(); // 0x06ec5e0c
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState None = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState Idle = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState Death = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState Stable = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim Idle_None = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim Idle_01 = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim Idle_02 = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim Idle_03 = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot Invalid = -1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot MainWeapon1 = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot MainWeapon2 = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot ThrowWeapon = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot MainWeapon3 = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot Count = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.MonsterMoveType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterMoveType None = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterMoveType Forward = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterMoveType SplitStep = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.MonsterBattleState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterBattleState OutBattle = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.MonsterBattleState InBattle = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.CoverStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.CoverStateEnum Outside = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.CoverStateEnum Moving = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.CoverStateEnum Inside = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.MonsterEntity.AIRelationTriggerInfo : System.ValueType
{
	System.Int64 TargetId; // 0x10
	System.Int32 relationType; // 0x18
	System.Int32 triggerConditionType; // 0x1c
	System.Single preferenceVal; // 0x20
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID Grenade1 = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID Grenade2 = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID Grenade3 = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID Grenade4 = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState LeisureIdle = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState BattleIdle = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState Vehicle = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState Throw = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LeisureIdle = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LeisureIdle2 = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LeisureIdle3 = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LeisureIdle4 = 4;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState BattleIdle = 5;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState CrouchIdle = 6;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState StandMove = 7;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState CrouchMove = 8;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState Sprint = 9;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LeisureWalk = 10;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir ForwardStand = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir BackwardStand = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir LeftStand = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir RightStand = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState Fire = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState Reload = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState Draw = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState FireWarm = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState Stand = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState Crouch = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Empty = 0;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Death = 1;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState NearThrow = 2;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState FarThrow = 3;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Draw = 4;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Attack = 5;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BossAttack1 = 6;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BossAttack2 = 7;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BossAttack3 = 8;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState HeavyAttack = 9;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BowFireStart = 10;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BowFireLoop = 11;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BowFireArrow = 12;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState BowPickArrow = 13;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Recourse = 14;
	static WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState Show = 15;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MonumentEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	static System.Int32 CLASS_HASH = 1802786918;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f347d0
	System.String GetTypeName(); // 0x06f34838
	System.Int32 get_EntityType(); // 0x06f348b0
	System.Void .ctor(); // 0x06f34914
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f349a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f34a54
	System.Single get_PosX(); // 0x06f34b04
	System.Void set_PosX(System.Single value); // 0x06f34b78
	System.Single get_PosY(); // 0x06f34c04
	System.Void set_PosY(System.Single value); // 0x06f34c78
	System.Single get_PosZ(); // 0x06f34d04
	System.Void set_PosZ(System.Single value); // 0x06f34d78
	System.Single get_RotateY(); // 0x06f34e04
	System.Void set_RotateY(System.Single value); // 0x06f34e78
	System.Single get_RotateX(); // 0x06f34f04
	System.Void set_RotateX(System.Single value); // 0x06f34f78
	System.Single get_RotateZ(); // 0x06f35004
	System.Void set_RotateZ(System.Single value); // 0x06f35078
	System.Int64 get_TemplateId(); // 0x06f35104
	System.Int32 get_SpawnType(); // 0x06f35178
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f351ec
	System.Void Init(); // 0x06f3526c
	System.Void AddLocalComponent(); // 0x06f35398
	static System.Void .cctor(); // 0x06f3542c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MonumentGroupEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 707187827;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f35758
	System.String GetTypeName(); // 0x06f357c0
	System.Int32 get_EntityType(); // 0x06f35838
	System.Void .ctor(); // 0x06f3589c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f3592c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f359dc
	static System.Object DeserializeMonumentGroupEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f35a8c
	static System.Void .cctor(); // 0x06f35b60
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MushroomEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	static System.Int32 CLASS_HASH = 1317359302;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f35d88
	System.String GetTypeName(); // 0x06f35df0
	System.Int32 get_EntityType(); // 0x06f35e68
	System.Void .ctor(); // 0x06f35ecc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f35f5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f3600c
	System.Single get_PosX(); // 0x06f360bc
	System.Void set_PosX(System.Single value); // 0x06f36130
	System.Single get_PosY(); // 0x06f361bc
	System.Void set_PosY(System.Single value); // 0x06f36230
	System.Single get_PosZ(); // 0x06f362bc
	System.Void set_PosZ(System.Single value); // 0x06f36330
	System.Single get_RotateY(); // 0x06f363bc
	System.Void set_RotateY(System.Single value); // 0x06f36430
	System.Single get_RotateX(); // 0x06f364bc
	System.Void set_RotateX(System.Single value); // 0x06f36530
	System.Single get_RotateZ(); // 0x06f365bc
	System.Void set_RotateZ(System.Single value); // 0x06f36630
	System.Single get_ScaleX(); // 0x06f366bc
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f36730
	static System.Void .cctor(); // 0x06f367b0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.NPCEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IEntity
{
	static System.Int32 CLASS_HASH = 552609369;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f36a74
	System.String GetTypeName(); // 0x06f36adc
	System.Int32 get_EntityType(); // 0x06f36b54
	System.Void .ctor(); // 0x06f36bb8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f36c48
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f36cf8
	System.Int64 get_TemplateId(); // 0x06f36da8
	System.Int32 get_SpawnType(); // 0x06f36e1c
	System.Single get_PosX(); // 0x06f36e90
	System.Void set_PosX(System.Single value); // 0x06f36f04
	System.Single get_PosY(); // 0x06f36f90
	System.Void set_PosY(System.Single value); // 0x06f37004
	System.Single get_PosZ(); // 0x06f37090
	System.Void set_PosZ(System.Single value); // 0x06f37104
	System.Single get_RotateY(); // 0x06f37190
	System.Void set_RotateY(System.Single value); // 0x06f37204
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f37290
	System.Void Init(); // 0x06f37310
	static System.Void .cctor(); // 0x06f37378
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ObserverEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	static System.Int32 CLASS_HASH = 1470462294;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.ObserverEntity Instance; // 0x10
	static WizardGames.Soc.Common.Entity.LinkedSequenceSegment head; // 0x18
	static WizardGames.Soc.Common.Entity.LinkedSequenceSegment tail; // 0x20
	System.Int32 GetClassHash(); // 0x06f375d4
	System.String GetTypeName(); // 0x06f3763c
	System.Int32 get_EntityType(); // 0x06f376b4
	System.Void .ctor(); // 0x06f37718
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f377a8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f37858
	System.Single get_PosX(); // 0x06f37908
	System.Void set_PosX(System.Single value); // 0x06f3797c
	System.Single get_PosY(); // 0x06f37a08
	System.Void set_PosY(System.Single value); // 0x06f37a7c
	System.Single get_PosZ(); // 0x06f37b08
	System.Void set_PosZ(System.Single value); // 0x06f37b7c
	System.Single get_RotateY(); // 0x06f37c08
	System.UInt64 get_RoleId(); // 0x06f37c7c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f37cf0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06f37d70
	System.Void RemoteCallObserverGetGlobalTrees(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f39718
	System.Void RemoteCallGetTerrainHeight(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 seq, System.Single posX, System.Single posZ); // 0x06f39884
	System.Void RemoteCallGetAllTerritory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f39a34
	System.Void RemoteCallGetTerritoryDetail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 territoryId); // 0x06f39ba0
	System.Void RemoteCallGetAllPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f39d2c
	System.Void RemoteCallGetPlayerDetail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId); // 0x06f39e98
	System.Void RemoteCallSetTransform(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single tarX, System.Single tarY, System.Single tarZ, System.Single tarRotY); // 0x06f3a024
	System.Void RemoteCallTransportAroundPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 playerId); // 0x06f3a1ec
	System.Void OnConsoleCommand(System.Int32 netPeerId, System.String command); // 0x06f384c8
	System.Void LoadingSuccessAck(System.Int64 worldTime, System.Int64 sequence, System.Int64 ts, System.Int64 myEntityId, WizardGames.Soc.Common.SimpleCustom.GameTimeParam gameTimeParam); // 0x06f38838
	System.Void FrameEnd(System.Int64 ts, System.Int64 sequence, System.Int32 interval); // 0x06f38af8
	System.Void OnTransportAck(System.Single posX, System.Single posY, System.Single posZ, System.Single rotY); // 0x06f38c2c
	System.Void SetTransform(System.Single posX, System.Single posY, System.Single posZ, System.Single rotY, System.Boolean setPlayer); // 0x06f3a51c
	System.Void TransportAroundPlayer(System.UInt64 playerId); // 0x06f3a7e8
	System.Void GetTerrainHeightAck(System.Int64 seq, System.Single posY); // 0x06f38ecc
	System.Void GetGlobalTreesAck(System.Boolean isStart, System.Boolean isEnd, System.Buffers.ReadOnlySequence<System.Byte> seq); // 0x06f38f98
	System.Void GetAllTerritoryAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> territories); // 0x06f39448
	System.Void GetTerritoryDetailAck(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo detailInfo); // 0x06f394fc
	System.Void GetAllPlayerAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> players); // 0x06f395b0
	System.Void GetPlayerDetailAck(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo detailInfo); // 0x06f39664
	static System.Void .cctor(); // 0x06f3a868
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.OreEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ICombatEntity
{
	static System.Int32 CLASS_HASH = 468694922;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f3aac4
	System.String GetTypeName(); // 0x06f3ab2c
	System.Int32 get_EntityType(); // 0x06f3aba4
	System.Void .ctor(); // 0x06f3ac08
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f3ac98
	System.Single get_PosX(); // 0x06f3ad48
	System.Void set_PosX(System.Single value); // 0x06f3adbc
	System.Single get_PosY(); // 0x06f3ae48
	System.Void set_PosY(System.Single value); // 0x06f3aebc
	System.Single get_PosZ(); // 0x06f3af48
	System.Void set_PosZ(System.Single value); // 0x06f3afbc
	System.Single get_RotateY(); // 0x06f3b048
	System.Void set_RotateY(System.Single value); // 0x06f3b0bc
	System.Single get_RotateX(); // 0x06f3b148
	System.Void set_RotateX(System.Single value); // 0x06f3b1bc
	System.Single get_RotateZ(); // 0x06f3b248
	System.Void set_RotateZ(System.Single value); // 0x06f3b2bc
	System.Int64 get_TemplateId(); // 0x06f3b348
	System.Int32 get_SpawnType(); // 0x06f3b3bc
	System.Single get_RemainHp(); // 0x06f3b430
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f3b4a4
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f3b524
	System.Void CleanupLogic(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06f3b6c8
	System.Void OnLodSwitch(System.Int32 oldLeastSignificantBit, System.Int32 newLeastSignificantBit); // 0x06f3ba88
	static System.Void .cctor(); // 0x06f3bb64
	static System.Void OnRemainHpChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldHp, System.Single newHp); // 0x06f3bf00
	System.Void OnHpChange(System.Single oldHp, System.Single newHp); // 0x06f3bfdc
	System.String ToPrettyString(); // 0x06f3c138
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ParachuteEntity : WizardGames.Soc.Common.Entity.BaseMountableEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 544814355;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "ParachuteEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd0
	System.Single <PosY_Smooth>k__BackingField; // 0xd4
	System.Single <PosZ_Smooth>k__BackingField; // 0xd8
	System.Single <RotateX_Smooth>k__BackingField; // 0xdc
	System.Single <RotateY_Smooth>k__BackingField; // 0xe0
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe4
	System.Int64 <ParentId>k__BackingField; // 0xe8
	System.Int64 <MountID>k__BackingField; // 0xf0
	WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState AnimType; // 0xf8
	System.Int32 GetClassHash(); // 0x06f3c410
	System.String GetTypeName(); // 0x06f3c478
	System.Int32 get_EntityType(); // 0x06f3c4f0
	System.Void .ctor(); // 0x06f3c554
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f3c5e0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f3c690
	System.Int32 get_MoveState(); // 0x06f3c740
	System.Void set_MoveState(System.Int32 value); // 0x06f3c7b4
	System.Single get_StateTime(); // 0x06f3c840
	System.Void set_StateTime(System.Single value); // 0x06f3c8b4
	System.Single get_MoveSpeed(); // 0x06f3c940
	System.Void set_MoveSpeed(System.Single value); // 0x06f3c9b4
	System.Single get_RotateSpeed(); // 0x06f3ca40
	System.Void set_RotateSpeed(System.Single value); // 0x06f3cab4
	System.Boolean get_IsEnd(); // 0x06f3cb40
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f3cbb4
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06f3cc34
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06f3d368
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f3d3cc
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f3d4a8
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f3d524
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f3d5dc
	System.Void CleanupLogic(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06f3d77c
	System.Void CalcBlend(System.Single& h, System.Single& v); // 0x06f3d7f0
	System.Void .ctor(System.Int64 id); // 0x06f3ccd4
	System.Int32 get_DriversCount(); // 0x06f3dd0c
	static System.Void .cctor(); // 0x06f3dd70
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PartDebrisEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 629140519;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f3e70c
	System.String GetTypeName(); // 0x06f3e774
	System.Int32 get_EntityType(); // 0x06f3e7ec
	System.Void .ctor(); // 0x06f3e850
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f3e8e0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f3e990
	System.Int64 get_TemplateId(); // 0x06f3ea40
	System.Single get_PosX(); // 0x06f3eab4
	System.Void set_PosX(System.Single value); // 0x06f3eb28
	System.Single get_PosY(); // 0x06f3ebb4
	System.Void set_PosY(System.Single value); // 0x06f3ec28
	System.Single get_PosZ(); // 0x06f3ecb4
	System.Void set_PosZ(System.Single value); // 0x06f3ed28
	System.Single get_RotateY(); // 0x06f3edb4
	System.Void set_RotateY(System.Single value); // 0x06f3ee28
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f3eeb4
	static System.Void .cctor(); // 0x06f3ef34
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PartEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.CustomType.IEntityWithElectric, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, Share.Entity.Interface.ILadderEntity
{
	static System.Int32 CLASS_HASH = 21;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "PartEntity";
	static System.String[] PropNameArray; // 0x8
	static UnityEngine.Color NightColor; // 0x10
	static UnityEngine.Color DayColor; // 0x20
	System.Int32 StorageComponentId; // 0x5c
	UnityEngine.Vector3 <positionUnity>k__BackingField; // 0x60
	UnityEngine.Quaternion <rotationUnity>k__BackingField; // 0x6c
	WizardGames.Soc.Common.Unity.Go.BasePartGo partGo; // 0x80
	WizardGames.Soc.Common.Framework.Algorithm.Quaternion <Rotation>k__BackingField; // 0x88
	static WizardGames.Soc.Common.Data.constraction.ConstructionPrefabConfig prefabConfigCache; // 0x30
	System.Int32 <LightState>k__BackingField; // 0x98
	System.Int32 GetClassHash(); // 0x06f3f0f4
	System.String GetTypeName(); // 0x06f3f158
	System.Int32 get_EntityType(); // 0x06f3f1d0
	System.Void .ctor(); // 0x06f3f234
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f3f2c4
	System.Single get_PosX(); // 0x06f3f374
	System.Void set_PosX(System.Single value); // 0x06f3f3e8
	System.Single get_PosZ(); // 0x06f3f474
	System.Void set_PosZ(System.Single value); // 0x06f3f4e8
	System.Single get_PosY(); // 0x06f3f574
	System.Void set_PosY(System.Single value); // 0x06f3f5e8
	System.Single get_RotateX(); // 0x06f3f674
	System.Void set_RotateX(System.Single value); // 0x06f3f6e8
	System.Single get_RotateY(); // 0x06f3f774
	System.Void set_RotateY(System.Single value); // 0x06f3f7e8
	System.Single get_RotateZ(); // 0x06f3f874
	System.Void set_RotateZ(System.Single value); // 0x06f3f8e8
	System.Int64 get_TemplateId(); // 0x06f3f974
	System.Void set_TemplateId(System.Int64 value); // 0x06f3f9e8
	System.Int64 get_OwnerId(); // 0x06f3fa74
	System.Int32 get_SpawnType(); // 0x06f3fae8
	System.Int32 get_ModuleState(); // 0x06f3fb5c
	System.Int64 get_BornTime(); // 0x06f3fbd0
	System.Int32 get_PlayCampId(); // 0x06f3fc44
	System.Int32 get_PartState(); // 0x06f3fcb8
	System.Void set_PartState(System.Int32 value); // 0x06f3fd2c
	System.Int32 get_PartStateExpireSec(); // 0x06f3fdb8
	System.Int32 get_LastMovedSec(); // 0x06f3fe2c
	System.Boolean get_RedPoint(); // 0x06f3fea0
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f3ff14
	System.Void RemoteCallPartRename(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String newName); // 0x06f3ff94
	UnityEngine.Vector3 get_CentroidPos(); // 0x06f40120
	WizardGames.Soc.Common.Component.ConstructionFlagComponent get_FlagComponent(); // 0x06f4041c
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.EntityFlag_Toggle> get_SkinFlagToggleList(); // 0x06f4049c
	System.Void Init(); // 0x06f4050c
	UnityEngine.Vector3 get_UnityPosition(); // 0x06f408e4
	UnityEngine.Quaternion get_UnityRotation(); // 0x06f4097c
	System.Void PostInit(); // 0x06f40a24
	WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig GetPartGoConfig(); // 0x06f402e8
	System.String GetShowName(); // 0x06f40bc0
	System.Void GetSocketModNoMonoByType<T>(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SocketModNoMono>& socketMods); // 0x052af1f0
	System.Void AddBaseComponents(); // 0x06f40c5c
	UnityEngine.Vector3 GetFixedLocalPositionByEntityRot(UnityEngine.Quaternion rot); // 0x06f40f44
	System.Void AddClientOnlyComponents(); // 0x06f410e8
	UnityEngine.Color get_EmissionColor(); // 0x06f41488
	WizardGames.Soc.Common.Component.DestroyEffectComponent get_DestroyEffectComponent(); // 0x06f417ec
	WizardGames.Soc.Common.Component.PartSkinAnimateComponent get_SkinAnimateComponent(); // 0x06f4186c
	WizardGames.Soc.Common.Component.DeployComponent get_DeployComponent(); // 0x06f418ec
	WizardGames.Soc.Common.Component.PlantBoxComponent get_PlantBoxComponent(); // 0x06f4196c
	WizardGames.Soc.Common.Component.MixingTableComponent get_MixingTableComponent(); // 0x06f419ec
	WizardGames.Soc.Common.Component.ConstructionGapComponent get_ConstructionGapComponent(); // 0x06f41a6c
	UnityEngine.Bounds get_UnityBounds(); // 0x06f41aec
	WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent get_SocketComponent(); // 0x06f41ef0
	WizardGames.Soc.Common.Component.ConstructionRenderComponent get_RenderComponent(); // 0x06f41f70
	WizardGames.Soc.Common.Component.ConstructionProduceComponent get_ProduceComponent(); // 0x06f41ff0
	WizardGames.Soc.Common.Component.PermissionHubComponent get_PermissionHubComponent(); // 0x06f42070
	System.Int64 get_OutputItemId(); // 0x06f420f0
	System.String get_ConstructionName(); // 0x06f4216c
	System.Int32 get_DeployComboId(); // 0x06f42338
	WizardGames.Soc.Common.Component.ConstructionRenameComponent get_RenameComponent(); // 0x06f422b8
	System.Int32 get_AutoOpenDoorState(); // 0x06f423fc
	System.Boolean get_IsAutoOpen(); // 0x06f424f8
	WizardGames.Soc.Common.Component.InteractiveComponent get_InteractiveComponent(); // 0x06f42574
	WizardGames.Soc.Common.Component.StabilityComponent get_StabilityComponent(); // 0x06f425f4
	WizardGames.Soc.Common.Component.ConstructionCoreComponent get_CoreComponent(); // 0x06f42674
	WizardGames.Soc.Common.Component.ConstructionDoorComponent get_DoorComponent(); // 0x06f42478
	WizardGames.Soc.Common.Component.TransformComponent get_TransformComponent(); // 0x06f426f4
	WizardGames.Soc.Common.Component.ColliderComponentClient get_ColliderComponent(); // 0x06f42774
	WizardGames.Soc.Common.Component.ConstructionSkinComponent get_SkinComponent(); // 0x06f427f4
	WizardGames.Soc.Common.Component.ElectricElevatorComponent get_ElevatorComponent(); // 0x06f42874
	System.Single get_Stability(); // 0x06f428f4
	System.Int32 get_Grade(); // 0x06f42974
	WizardGames.Soc.Common.Component.PartHighLightEffectComponent get_HighLightEffectComponent(); // 0x06f42aa4
	WizardGames.Soc.Common.Component.PartGOUnityComponent get_GoComponent(); // 0x06f42b24
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags f); // 0x06f42bc0
	System.Single get_RotationAmount(); // 0x06f42c64
	UnityEngine.Transform get_DeployTransform(); // 0x06f41d78
	System.Boolean get_CanRotateBeforePlace(); // 0x06f42d70
	System.Void LocalGoRemove(); // 0x06f42e80
	System.Boolean IsCoreConstruction(); // 0x06f42a08
	WizardGames.Soc.Common.Construction.FreeSocketRuntime GetSocketFree(); // 0x06f42f6c
	System.Boolean get_IsHolding(); // 0x06f43184
	System.Boolean WizardGames.Soc.Common.CustomType.IEntityWithElectric.get_IsLocalEntity(); // 0x06f431f0
	System.Void BeforeRemove(); // 0x06f43254
	System.Void DestroyPartEvent(); // 0x06f43340
	System.Void CheckAndPlayShatterEffect(); // 0x06f433a4
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f43478
	System.Void SetRenderEntityFlag(System.Boolean haveEntity); // 0x06f40a98
	System.Void OnLodSwitch(System.Int32 oldLevel, System.Int32 newLevel); // 0x06f4363c
	System.Void OnComponentAdded(WizardGames.Soc.Share.Framework.ComponentBase component); // 0x06f43768
	System.Void AttachSpecialGameModeComponent(); // 0x06f40e60
	static System.Void .cctor(); // 0x06f43900
	UnityEngine.Vector3 get_positionUnity(); // 0x06f43f54
	System.Void set_positionUnity(UnityEngine.Vector3 value); // 0x06f43fb8
	UnityEngine.Quaternion get_rotationUnity(); // 0x06f44050
	System.Void set_rotationUnity(UnityEngine.Quaternion value); // 0x06f440b4
	UnityEngine.Vector3 get_forwardUnity(); // 0x06f44154
	UnityEngine.Vector3 get_lossyScaleUnity(); // 0x06f44274
	UnityEngine.Vector3 get_rightUnity(); // 0x06f4430c
	UnityEngine.Vector3 get_eulerAnglesUnity(); // 0x06f4442c
	System.Void set_PartGo(WizardGames.Soc.Common.Unity.Go.BasePartGo value); // 0x06f444f8
	UnityEngine.Transform get_MainTransform(); // 0x06f44578
	UnityEngine.GameObject get_MainGo(); // 0x06f446d8
	System.Boolean get_HaveMainGo(); // 0x06f44890
	UnityEngine.Vector3 get_FixedPosition(); // 0x06f4498c
	System.Void CalcPositionUnity(); // 0x06f44bdc
	System.Void CalcRotationUnity(); // 0x06f44cdc
	System.Void OnInitUnity(); // 0x06f40798
	UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 localPoint); // 0x06f44e0c
	UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 worldPos); // 0x06f44f6c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x06f450d0
	System.Void ComponentSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x06f4514c
	System.Void OnSkinGoRemove(); // 0x06f45384
	System.Void ComponentOnSkinGoRemove(); // 0x06f453e8
	WizardGames.Soc.Common.Component.ConstructionBaseComponent get_BaseComponent(); // 0x06f45618
	WizardGames.Soc.Common.Component.ConstructionCombinationComponent get_CombinationComponent(); // 0x06f45698
	WizardGames.Soc.Common.Component.ContainerLinkComponent get_ContainerLinkComponent(); // 0x06f45718
	WizardGames.Soc.Common.Component.FoundationLinkComponent get_FoundationComponent(); // 0x06f45798
	WizardGames.Soc.Common.Component.ConstructionLadderComponent get_LadderComponent(); // 0x06f45818
	System.Int64 get_ContainersFoundation(); // 0x06f45898
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_FoundationsContainer(); // 0x06f45914
	System.Boolean get_IsComboPart(); // 0x06f45990
	System.Int64 get_ComboParentId(); // 0x06f45a0c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ComboChildPartData> get_ComboChildDataDict(); // 0x06f45a88
	System.Int64 get_ComboGroupId(); // 0x06f45b04
	System.Single get_BuildDistance(); // 0x06f45b80
	WizardGames.Soc.Common.Algorithm.Vector3 get_Forward(); // 0x06f45cc4
	WizardGames.Soc.Common.Algorithm.Vector3 get_Position(); // 0x06f40384
	WizardGames.Soc.Common.Framework.Algorithm.Quaternion get_Rotation(); // 0x06f45e94
	System.Void set_Rotation(WizardGames.Soc.Common.Framework.Algorithm.Quaternion value); // 0x06f45ef8
	WizardGames.Soc.Common.Component.TerritoryCabinetComponent get_TerritoryCabinetComp(); // 0x06f45f98
	static System.Void OnPositionChanged(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06f46018
	static System.Void OnRotationChanged(WizardGames.Soc.Share.Framework.CustomTypeBase self, System.Single oldValue, System.Single newValue); // 0x06f46214
	System.Void OnPositionChange(); // 0x06f460e0
	System.Void OnRotationChange(); // 0x06f46364
	System.Void CalcRotation(); // 0x06f463cc
	System.Boolean get_IsWaitLoading(); // 0x06f41788
	System.Boolean get_IsInMiddleState(); // 0x06f465f4
	System.Boolean get_IsBlueprintLoading(); // 0x06f46584
	System.Boolean get_IsBatchUpgrading(); // 0x06f46658
	System.Boolean get_IsMovable(); // 0x06f466c8
	System.Int64 RecoverStillNeedSecond(); // 0x06f467f8
	System.Boolean get_CanBeManaged(); // 0x06f468c0
	System.Single get_Hp(); // 0x06f46930
	System.Single get_MaxHp(); // 0x06f469e4
	System.Int64 get_SkinId(); // 0x06f46a98
	System.Boolean get_IsImport(); // 0x06f46be0
	System.Void .ctor(System.Int64 id); // 0x06f46c5c
	WizardGames.Soc.Common.CustomType.BatchUpgradeRecord GetBatchUpgradeRecord(); // 0x06f46d00
	T WizardGames.Soc.Common.CustomType.IEntityWithElectric.GetComponent<T>(System.Int32 componentId); // 0x052af1f0
	System.Int64 get_TerritoryId(); // 0x06f46d98
	WizardGames.Soc.Common.Entity.TerritoryEntity GetOwnerTerritory(); // 0x06f46fb4
	System.String ToPrettyString(); // 0x06f47110
	static WizardGames.Soc.Common.Data.constraction.ConstructionPrefabConfig GetPrefabConfig(System.Int64 templateId); // 0x06f473e8
	static System.Single GetSizeLength(System.Int64 templateId); // 0x06f47588
	static WizardGames.Soc.Common.Data.BeansVector3 GetBoundsCenter(System.Int64 templateId); // 0x06f47700
	System.Single get_SizeX(); // 0x06f477a4
	System.Single get_SizeY(); // 0x06f4783c
	System.Single get_SizeZ(); // 0x06f478d4
	System.Single get_BoundsCenterX(); // 0x06f4796c
	System.Single get_BoundsCenterY(); // 0x06f47a18
	System.Single get_BoundsCenterZ(); // 0x06f47ac4
	WizardGames.Soc.Common.Framework.Algorithm.Bounds get_Bounds(); // 0x06f47b70
	System.Single get_SecondsSinceAttacked(); // 0x06f47ce8
	System.Boolean IsDuringAttackedPeriod(); // 0x06f48318
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PlayerEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IPlayerPredictEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IMovableEntity, WizardGames.Soc.Common.Entity.IMetabolismEntity, WizardGames.Soc.Common.Entity.ILifeCycleEntity, WizardGames.Soc.Common.Entity.IEquipEntity, WizardGames.Soc.Common.Entity.IShortcutEntity, WizardGames.Soc.Common.Entity.IHostileEntity, WizardGames.Soc.Common.Soc.Common.Src.Entity.Interface.IBuffEntity, WizardGames.Soc.Common.Entity.IMountVehicleEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Share.Framework.IPredictType, WizardGames.Soc.Common.Entity.ISmoothCloneEntity, WizardGames.Soc.Common.Unity.HeldItem.IWeaponClipHandle
{
	static System.Int32 CLASS_HASH = 1561531089;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "PlayerEntity";
	static System.String[] PropNameArray; // 0x8
	static System.Boolean loadingSuccessDone; // 0x10
	System.Single _PosX_Smooth; // 0x5c
	System.Single _PosY_Smooth; // 0x60
	System.Single _PosZ_Smooth; // 0x64
	System.Single temp; // 0x68
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Defines.TableItemEnum,WizardGames.Soc.Common.Weapon.TargetingLauncherData> TargetingLauncherTokens; // 0x70
	System.Single <RotateX_Smooth>k__BackingField; // 0x78
	System.Single <RotateY_Smooth>k__BackingField; // 0x7c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x80
	System.Single PlatformPosX_Smooth; // 0x84
	System.Single PlatformPosY_Smooth; // 0x88
	System.Single PlatformPosZ_Smooth; // 0x8c
	System.Int64 LastUpdatedTs; // 0x90
	WizardGames.Soc.Common.SimpleCustom.TraceTimeData TraceData; // 0x98
	System.Boolean printNetworkStat; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> weaponEffectFuncIndex; // 0xa8
	static WizardGames.Soc.Common.Entity.PlayerEntity <MyPlayerClient>k__BackingField; // 0x18
	static System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam> listForGcSaving; // 0x20
	static WizardGames.Soc.Common.Entity.LinkedSequenceSegment head; // 0x28
	static WizardGames.Soc.Common.Entity.LinkedSequenceSegment tail; // 0x30
	System.Int32 ammoInBag; // 0xb0
	WizardGames.Soc.Common.Unity.Character.IInteractiveBehavior InteractiveStateBehavior; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> WearedItems; // 0xc0
	System.Boolean <DetectWaterDepth>k__BackingField; // 0xc8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3BuffData> <CustomType>k__BackingField; // 0xd0
	static System.Collections.Generic.Dictionary<System.Type,System.Tuple<System.Int32,System.UInt64>> StateOffsetMap; // 0x38
	System.Int64 LocalLogicState; // 0xd8
	System.Collections.Generic.HashSet<System.Int64> StateLayerSubscribeIds; // 0xe0
	System.Int64 equipCDOpenParachuteTime; // 0xe8
	System.Int32 <HeldItemSwitchSeq>k__BackingField; // 0xf0
	System.Single SlopeAngle; // 0xf4
	System.Single LastSlopeAngle; // 0xf8
	System.Single SignedSlopeAngle; // 0xfc
	System.Single LastSignedSlopeAngle; // 0x100
	System.Boolean InSlope; // 0x104
	System.Int32 FpModelInvisibleFlag; // 0x108
	System.Int32 TpModelInvisibleFlagForFp; // 0x10c
	System.Int32 TpModelInvisibleFlagForTp; // 0x110
	System.Int32 FpHeldItemInvisibleFlag; // 0x114
	System.Int32 TpHeldItemInvisibleFlag; // 0x118
	System.Int32 <WakeUpTimeAcc>k__BackingField; // 0x11c
	System.Boolean <WakeUpEnd>k__BackingField; // 0x120
	System.Single <WakeUpCameraDelta>k__BackingField; // 0x124
	System.Byte <InteractionType>k__BackingField; // 0x128
	System.Boolean <InteractionDisableIK>k__BackingField; // 0x129
	System.Int32 <CollisionFlags>k__BackingField; // 0x12c
	System.Int32 <LastMountSeatIndex>k__BackingField; // 0x130
	System.Single <LookTargetOffsetX>k__BackingField; // 0x134
	System.Single <LookTargetOffsetY>k__BackingField; // 0x138
	System.Single <LookTargetOffsetZ>k__BackingField; // 0x13c
	System.Int32 <ReloadStartTime>k__BackingField; // 0x140
	System.Boolean <IsStepReload>k__BackingField; // 0x144
	System.Int64 <DyingFinishTime>k__BackingField; // 0x148
	System.Int64 <BowWeapon_FireTime>k__BackingField; // 0x150
	WizardGames.Soc.Common.Entity.PlayerThrowState <LocalThrowState>k__BackingField; // 0x158
	System.Boolean <IsInFire>k__BackingField; // 0x159
	System.Collections.Generic.Queue<System.Single> <HistoryYaw>k__BackingField; // 0x160
	System.Int32 <InputMoveIdleTick>k__BackingField; // 0x168
	System.Boolean <InputLastMoveForward>k__BackingField; // 0x16c
	System.Boolean <InputLastMoveBackward>k__BackingField; // 0x16d
	System.Boolean <InputLastMoveLeft>k__BackingField; // 0x16e
	System.Boolean <InputLastMoveRight>k__BackingField; // 0x16f
	System.Single <InputLastYaw>k__BackingField; // 0x170
	System.Boolean <ApplyCameraAnimation>k__BackingField; // 0x174
	System.Boolean <NewbieApplyCameraAnimation>k__BackingField; // 0x175
	System.Boolean <ApplyCameraAnimationForAim>k__BackingField; // 0x176
	System.Byte <CameraAnimationByte>k__BackingField; // 0x177
	System.Int64 <RebornedTime>k__BackingField; // 0x178
	System.Boolean <IsReborn>k__BackingField; // 0x180
	System.Single LastPosX; // 0x184
	System.Single LastPosZ; // 0x188
	System.Int64 LastPosTime; // 0x190
	System.Int32 <LastLifeCycleFlags>k__BackingField; // 0x198
	System.Boolean <LastIsWounded>k__BackingField; // 0x19c
	System.Single <EnterDyingTime>k__BackingField; // 0x1a0
	WizardGames.Soc.Common.Entity.RebornRequestType <RebornRequest>k__BackingField; // 0x1a4
	System.Single <TickDelta>k__BackingField; // 0x1a8
	System.Single <OxygenDelta>k__BackingField; // 0x1ac
	System.Single <OxygenDamageDelta>k__BackingField; // 0x1b0
	System.Single <HydrationFraction>k__BackingField; // 0x1b4
	System.Single <HeartRateFraction>k__BackingField; // 0x1b8
	System.Single <TargetTemperature>k__BackingField; // 0x1bc
	System.Single <TemperDamageCache>k__BackingField; // 0x1c0
	System.Single <OxygenDamageCache>k__BackingField; // 0x1c4
	System.Single <TargetComfort>k__BackingField; // 0x1c8
	System.Single <HydrationDamageCache>k__BackingField; // 0x1cc
	System.Single <CarloriesFraction>k__BackingField; // 0x1d0
	System.Single <CaloriesDamageCache>k__BackingField; // 0x1d4
	System.Single <CaloriesBenefitCache>k__BackingField; // 0x1d8
	System.Single <BleedingCache>k__BackingField; // 0x1dc
	System.Single <RadiationPoisonFraction>k__BackingField; // 0x1e0
	System.Single <RadiationLevelFraction>k__BackingField; // 0x1e4
	System.Single <RadiationDamageCache>k__BackingField; // 0x1e8
	System.Single <WetnessFraction>k__BackingField; // 0x1ec
	System.Single <WaterLevel>k__BackingField; // 0x1f0
	System.Single <EnvironmentWetness>k__BackingField; // 0x1f4
	System.Int64 <LastAttackedTime>k__BackingField; // 0x1f8
	System.Int64 <LastAttackPlayerId>k__BackingField; // 0x200
	System.Int64 <LastAttackedTimeByPlayer>k__BackingField; // 0x208
	System.Single[] <ArmorProtection>k__BackingField; // 0x210
	System.Single[] <OnMountProtection>k__BackingField; // 0x218
	System.Single[] BuffProtection; // 0x220
	System.Int32 <LocalEquipVersion>k__BackingField; // 0x228
	System.Single <LastNoisePositionX>k__BackingField; // 0x22c
	System.Single <LastNoisePositionY>k__BackingField; // 0x230
	System.Single <LastNoisePositionZ>k__BackingField; // 0x234
	System.Single <lastNoiseTime>k__BackingField; // 0x238
	System.Int64 <lastMakeNoiseWeaponID>k__BackingField; // 0x240
	System.Single <AdsLerpPosition>k__BackingField; // 0x248
	System.Single <AdsAnimRawProgress>k__BackingField; // 0x24c
	WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum <AdsAnimState>k__BackingField; // 0x250
	System.Int32 <AdsAnimStateStartTime>k__BackingField; // 0x254
	System.Single <AdsAnimPosition>k__BackingField; // 0x258
	System.Int64 <AdsSwitchTime>k__BackingField; // 0x260
	System.Int64 NextWeaponId; // 0x268
	System.Int64 PreviousWeaponTableId; // 0x270
	System.Int64 <NowHistoryWeaponId>k__BackingField; // 0x278
	System.Single defaultSceneFov; // 0x280
	System.Single defaultVehicleFov; // 0x284
	System.Boolean <HasSceneFovChanged>k__BackingField; // 0x288
	System.Single <GunFov>k__BackingField; // 0x28c
	System.Int32 <AdsFovOnTime>k__BackingField; // 0x290
	System.Int32 <AdsFovOffTime>k__BackingField; // 0x294
	System.Int32 <AdsUpGunFovTime>k__BackingField; // 0x298
	System.Int32 <AdsDownGunFovTime>k__BackingField; // 0x29c
	System.Int32 <AdsUpAniTime>k__BackingField; // 0x2a0
	System.Int32 <AdsDownAniTime>k__BackingField; // 0x2a4
	System.Boolean <bLocalPlayer>k__BackingField; // 0x2a8
	System.Boolean <FlyToPos>k__BackingField; // 0x2a9
	System.Numerics.Vector3 <FlyPos>k__BackingField; // 0x2ac
	System.Single <FlySpeed>k__BackingField; // 0x2b8
	System.Boolean <IsAutoFire>k__BackingField; // 0x2bc
	System.Boolean <CanAutoFire>k__BackingField; // 0x2bd
	System.Int64 <PoorOxygenTime>k__BackingField; // 0x2c0
	System.Single <SensitivityDefault>k__BackingField; // 0x2c8
	System.Int32 <LastRadiationIntensity>k__BackingField; // 0x2cc
	System.Int32 <SelectMantleOnIndex>k__BackingField; // 0x2d0
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum <StartLadderState>k__BackingField; // 0x2d4
	WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum <StartMantleState>k__BackingField; // 0x2d5
	System.Boolean <MantleInPlatform>k__BackingField; // 0x2d6
	System.Single <MantleInPlatformStartX>k__BackingField; // 0x2d8
	System.Single <MantleInPlatformStartY>k__BackingField; // 0x2dc
	System.Single <MantleInPlatformStartZ>k__BackingField; // 0x2e0
	System.Int32 <OfflineSafeAreaIndex>k__BackingField; // 0x2e4
	System.Single <PunchRoll>k__BackingField; // 0x2e8
	System.Single <GunSwayPitch>k__BackingField; // 0x2ec
	System.Single <GunSwayYaw>k__BackingField; // 0x2f0
	System.Single <DecayTime>k__BackingField; // 0x2f4
	System.Boolean <FireToggle>k__BackingField; // 0x2f8
	System.Boolean <ThrowToggle>k__BackingField; // 0x2f9
	UnityEngine.Vector3 <LockShootPitchYawOffset>k__BackingField; // 0x2fc
	System.Int32 <DefenseTemplateId>k__BackingField; // 0x308
	System.Int64 <TemplateId>k__BackingField; // 0x310
	System.Boolean <lastIsHostile>k__BackingField; // 0x318
	System.Int64 <lastHostileStartTime>k__BackingField; // 0x320
	System.Int64 <lastHostileEndTime>k__BackingField; // 0x328
	System.Boolean <MarkAttackerHostile>k__BackingField; // 0x330
	System.Int32 <lastSafetyState>k__BackingField; // 0x334
	System.Boolean <IsInAir>k__BackingField; // 0x338
	System.Boolean <teleport>k__BackingField; // 0x339
	System.Single <DrawScale>k__BackingField; // 0x33c
	System.Single <FireScale>k__BackingField; // 0x340
	System.Single <FireHitScale>k__BackingField; // 0x344
	System.Single <AltFireScale>k__BackingField; // 0x348
	System.Single <AltFireHitScale>k__BackingField; // 0x34c
	System.Single <ReloadEndScale>k__BackingField; // 0x350
	System.Single <InspectScale>k__BackingField; // 0x354
	System.Single <ReloadStartScale>k__BackingField; // 0x358
	System.Single <ReloadScale>k__BackingField; // 0x35c
	System.Single <AdsOnScale>k__BackingField; // 0x360
	System.Single <AdsOffScale>k__BackingField; // 0x364
	System.Single <BowChargeScale>k__BackingField; // 0x368
	System.Single <BowCancelChargeScale>k__BackingField; // 0x36c
	System.Single <ChainSawStartUpScale>k__BackingField; // 0x370
	System.Single <BoltScale>k__BackingField; // 0x374
	System.Boolean <WantCrouchPose>k__BackingField; // 0x378
	System.Int32 <SwimPosType>k__BackingField; // 0x37c
	System.Boolean <ServerAuthorityFlag>k__BackingField; // 0x380
	System.Int32 <LastYawSign>k__BackingField; // 0x384
	System.Int32 <CmdYawSign>k__BackingField; // 0x388
	System.Int32 YawSignLocal; // 0x38c
	System.Int32 TurnDirection; // 0x390
	System.Single AimYawLocal; // 0x394
	System.Single LastLerpAimYaw; // 0x398
	System.Single TurnTargetAngle; // 0x39c
	System.Int32 LastYawSignMount; // 0x3a0
	System.Int32 CmdYawSignMount; // 0x3a4
	System.Int32 YawSignLocalMount; // 0x3a8
	System.Int32 TurnDirectionMount; // 0x3ac
	System.Single AimYawLocalMount; // 0x3b0
	System.Single LastLerpAimYawMount; // 0x3b4
	System.Single TurnTargetAngleMount; // 0x3b8
	System.Single LastLerpAimYawMountBack; // 0x3bc
	System.Single MantleAniNormalize; // 0x3c0
	System.Boolean MantleByAir; // 0x3c4
	System.Int64 ClientLadderTargetId; // 0x3c8
	System.Int32 ClientAdsorbTargetIndex; // 0x3d0
	System.Int32 ClientAdsorbWayIndex; // 0x3d4
	System.Numerics.Vector3 ClientLadderTestPos; // 0x3d8
	System.Single lastYaw; // 0x3e4
	System.Numerics.Vector3 LastValidLadderNormal; // 0x3e8
	System.Boolean ClientWantLadder; // 0x3f4
	System.Boolean ClientWantLadderSprint; // 0x3f5
	System.Int32 BreakReason; // 0x3f8
	System.Boolean WantAutoEquip; // 0x3fc
	System.Boolean WantAutoUnEquip; // 0x3fd
	System.Boolean CheckEquip; // 0x3fe
	System.Int64 _HistoryWeaponId; // 0x400
	System.Int64 ExpectUnEquipWeaponId; // 0x408
	System.Int64 UnLoadHistoryWeaponTableId; // 0x410
	System.Int64 UnLoadHistoryWeaponId; // 0x418
	System.Int32 <StateTime>k__BackingField; // 0x420
	System.Int32 <ShootingRecoverySprintDelay>k__BackingField; // 0x424
	System.Int32 <ShootingRecoverySprintIgnored>k__BackingField; // 0x428
	System.Int32 <AnimatorStateTime>k__BackingField; // 0x42c
	System.Int32 <CommonStateTime>k__BackingField; // 0x430
	System.Int32 <CommonRecoveryStateTime>k__BackingField; // 0x434
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Entity.PlayerEntity.InteractiveAnimInfo> InteractiveAnimInfos; // 0x438
	System.Int32 GoToSleepTime; // 0x440
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Entity.PlayerEntity.TempInfo> <TempPos>k__BackingField; // 0x448
	System.Boolean <IsWalkableGround>k__BackingField; // 0x450
	System.Boolean <UseExtraDraw>k__BackingField; // 0x451
	System.Int64 CtrlId; // 0x458
	System.Int64 <NearestMountableEntityId>k__BackingField; // 0x460
	System.Int64 <NereastWorkbenchID>k__BackingField; // 0x468
	System.Int64 <CurrentFocusedEntityId>k__BackingField; // 0x470
	System.Collections.Generic.Queue<WizardGames.Soc.Common.SimpleCustom.UserCmd> <UnprocessedCmds>k__BackingField; // 0x478
	System.Boolean <LastIsDriver>k__BackingField; // 0x480
	System.Int64 <LastMountableId>k__BackingField; // 0x488
	System.Int32 <LastVehicleType>k__BackingField; // 0x490
	System.Object <BasePlayerType>k__BackingField; // 0x498
	System.Action<WizardGames.Soc.Common.Entity.PlayerEntity> <OnChangeWeapon>k__BackingField; // 0x4a0
	System.Action<WizardGames.Soc.Common.Entity.IHeldItemEntity,System.Single> <ShowUseLoading>k__BackingField; // 0x4a8
	System.Action<System.Int64> <HideUseLoading>k__BackingField; // 0x4b0
	System.Single <bagReloadDoneTime>k__BackingField; // 0x4b8
	System.Boolean <bagReloadCanInterrupt>k__BackingField; // 0x4bc
	System.Int64 <bagReloadWeaponId>k__BackingField; // 0x4c0
	System.Boolean <HasEnterPoseState>k__BackingField; // 0x4c8
	System.UInt64 <HitSourceRoleId>k__BackingField; // 0x4d0
	System.Int32 <HitSourceRelation>k__BackingField; // 0x4d8
	System.Boolean <IsFirstInVehicleCameraUpdate>k__BackingField; // 0x4dc
	System.Single <WaterHeight>k__BackingField; // 0x4e0
	System.Single <NightVisionLightIntensity>k__BackingField; // 0x4e4
	System.Boolean IsInside; // 0x4e8
	System.String ReplaceFootStepSound; // 0x4f0
	System.Boolean NeedUpdateVehicleData; // 0x4f8
	System.Single <AnimLayerFpWeight>k__BackingField; // 0x4fc
	static System.Boolean GlobalInvincible; // 0x40
	System.Int32 LastAnimLateMoveState; // 0x500
	System.Int32 PosKey; // 0x504
	System.Boolean IsPatrolHostile; // 0x508
	System.Int32 ParachuteOperState; // 0x50c
	WizardGames.Soc.Common.Entity.MeleeAttackRequest MeleeAttackRequest; // 0x510
	System.Boolean IsRollBack; // 0x540
	System.Int64 BombHomeStatisticGraphEntityId; // 0x548
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg BombHomeStatisticPanelCfg; // 0x550
	System.Boolean DebugStateChange; // 0x558
	System.Int32 eWeaponColor; // 0x55c
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.PropModifierType,System.Int32> FirstBornAddProperties; // 0x560
	System.Int64 MountStayMonumentMs; // 0x568
	System.Boolean UseMantleBtn; // 0x570
	System.Single AimYaw; // 0x574
	System.Single MyCmdPitch; // 0x578
	WizardGames.Soc.Common.Unity.Character.MantleTestResult MantleTestResult; // 0x580
	System.Int64 LogicFrameSequence; // 0x618
	WizardGames.Soc.Common.Weapon.WeaponUnique FpAnimIndex; // 0x620
	WizardGames.Soc.Common.Weapon.WeaponUnique ApplyFpAnimIndex; // 0x62c
	System.Int32 DismountResult; // 0x638
	System.Single UnOverLapPosX; // 0x63c
	System.Single UnOverLapPosY; // 0x640
	System.Single UnOverLapPosZ; // 0x644
	System.Boolean PreTickDisableDriveUro; // 0x648
	System.Boolean TickDisableDriveUro; // 0x649
	System.Boolean NeedTpLogicFrame; // 0x64a
	System.Boolean IsContinuousJump; // 0x64b
	System.Single LastSmoothPosY; // 0x64c
	System.Int32 StepLerpTime; // 0x650
	System.Boolean IsInterpolating; // 0x654
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer FpLocomotionState; // 0x658
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer FpSightState; // 0x65c
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer FpPoseState; // 0x660
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer FpAddState; // 0x664
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer FpAddSubState; // 0x668
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer FpOverState; // 0x66c
	WizardGames.Soc.Common.Unity.Character.FpClipLengthCollect FpOcTimeCollect; // 0x670
	WizardGames.Soc.Common.Unity.Character.FpClipLengthCollect FpAddTimeCollect; // 0x6e4
	WizardGames.Soc.Common.Unity.Character.FpClipLengthCollect FpLocoTimeCollect; // 0x758
	WizardGames.Soc.Common.Unity.Character.FpClipLengthCollect FpAddSubTimeCollect; // 0x7cc
	System.Single FpLocomotionCameraShakePosX; // 0x840
	System.Single FpLocomotionCameraShakePosY; // 0x844
	System.Single FpLocomotionCameraShakePosZ; // 0x848
	System.Single FpLocomotionCameraShakeRotX; // 0x84c
	System.Single FpLocomotionCameraShakeRotY; // 0x850
	System.Single FpLocomotionCameraShakeRotZ; // 0x854
	System.Single FpLocomotionCameraShakeRotW; // 0x858
	System.Boolean IsMagicBullet; // 0x85c
	System.Int64 HitSourceEntityId; // 0x860
	System.Collections.Generic.HashSet<System.Int32> ActivationIds; // 0x868
	WizardGames.Soc.Common.Character.TpAniPlayerStateData TpAniPlayerStateData; // 0x870
	WizardGames.Soc.Common.Character.TpAniHeldItemData TpAniHeldItemData; // 0x980
	WizardGames.Soc.Common.Character.TpAniVehicleData TpAniVehicleData; // 0x9c8
	WizardGames.Soc.Common.Unity.Character.Job.StateUpdateJobData StateUpdateJobData; // 0xa38
	System.Single <LastChangeBoltAdsTime>k__BackingField; // 0xbf8
	System.Boolean <CanChangeBolt>k__BackingField; // 0xbfc
	System.Single FpAniLerpHeight; // 0xc00
	System.Single NormalXFp; // 0xc04
	System.Single FpAniLocalSpeedX; // 0xc08
	System.Single FpAniLocalSpeedZ; // 0xc0c
	System.Single NormalZFp; // 0xc10
	System.Single LastMoveForward; // 0xc14
	System.Single LastMoveRight; // 0xc18
	System.Single <Sprint2JogTime>k__BackingField; // 0xc1c
	System.Single <Jog2SprintTime>k__BackingField; // 0xc20
	System.Int32 <Anim_CurParachuteState>k__BackingField; // 0xc24
	System.Boolean <ForceParachuteEnd>k__BackingField; // 0xc28
	System.Int64 Anim_HeldItemTableId; // 0xc30
	System.Numerics.Vector3 <FpJogPosVector3>k__BackingField; // 0xc38
	System.Numerics.Vector3 <FpJogRotVector3>k__BackingField; // 0xc44
	System.Single <LerpStandCrouch>k__BackingField; // 0xc50
	System.Int32 FpJumpMode; // 0xc54
	System.Object FpTemplateJumpSet; // 0xc58
	System.Single FpJumpStartTime; // 0xc60
	System.Single FpJumpOverTime; // 0xc64
	System.Single FpJump_AnimFDst; // 0xc68
	System.Single FpJump_AnimRDst; // 0xc6c
	System.Single FpJump_AnimFSrc; // 0xc70
	System.Single FpJump_AnimRSrc; // 0xc74
	System.Numerics.Vector3 FinalFpAdditivePos; // 0xc78
	System.Single JumpPoseActionFade; // 0xc84
	System.Int32 TpJumpMode; // 0xc88
	System.Object TpTemplateJumpSet; // 0xc90
	System.Single TpJumpStartTime; // 0xc98
	System.Single TpJumpOverTime; // 0xc9c
	System.Single TpJump_AnimPitchDst; // 0xca0
	System.Single TpJump_AnimRollDst; // 0xca4
	System.Single TpJump_AnimPitchSrc; // 0xca8
	System.Single TpJump_AnimRollSrc; // 0xcac
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup BoneWeightGroupFp; // 0xcb0
	System.Int64 LocomotionLayerTargetWeightFpWeaponId; // 0xdc8
	System.Int32 FpAnimatorInstanceId; // 0xdd0
	System.Int32 FpNowAoInstanceId; // 0xdd4
	System.Int32 FpApplyAoInstanceId; // 0xdd8
	System.Boolean SwitchFpAnimator; // 0xddc
	System.Int32 UpdateIndexFp; // 0xde0
	WizardGames.Soc.Common.Character.FpAniHeldItemWeight HeldItemWeight; // 0xde4
	System.Boolean FpInJumpEndInput; // 0xf34
	System.Single <LastFp_adsboltWeightCurve>k__BackingField; // 0xf38
	System.Single <LastFp_adsboltAutoCurve>k__BackingField; // 0xf3c
	System.Single <LastFp_boltWeightCurve>k__BackingField; // 0xf40
	System.Single <LastFp_boltAutoCurve>k__BackingField; // 0xf44
	WizardGames.Soc.Common.Character.TpClipLength FpJumpStart; // 0xf48
	System.Int32 JumpLandTolerantMode; // 0xf68
	System.Int32 JumpLandTolerantTime; // 0xf6c
	System.Boolean EnableJumpLandTolerant; // 0xf70
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum JumpStartStancePose; // 0xf71
	System.Single <TpCameraBlocked>k__BackingField; // 0xf74
	System.Single <TpOffsetYaw>k__BackingField; // 0xf78
	WizardGames.Soc.Common.Data.DataItem.ItemEntityType TpCacheCurrentTableItemType; // 0xf7c
	WizardGames.Soc.Common.Entity.IBaseVehicleEntity TpVehicleEntity; // 0xf80
	System.Int32 CreateAttachedSceneItemCount; // 0xf88
	System.Int32 RecentCreateAttachedSceneItemTime; // 0xf8c
	System.Boolean WantCrouchFromLadder; // 0xf90
	System.Numerics.Vector3 <FpPositionOffset>k__BackingField; // 0xf94
	System.Numerics.Vector3 <FpRotationOffset>k__BackingField; // 0xfa0
	WizardGames.Soc.Common.Entity.TpAniPlayerLocalData TpAniPlayerLocalData; // 0xfb0
	System.Boolean LadderVisibleDirty; // 0x1bf8
	System.Int32 LadderWaitFrame; // 0x1bfc
	System.Boolean IsLocked; // 0x1c00
	System.Boolean shouldClearToken; // 0x1c01
	System.Int64 CurrentLockedEntityId; // 0x1c08
	System.Boolean shouldClearAllToken; // 0x1c10
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp TpParameters; // 0x1c14
	System.Numerics.Vector3 <DMantlePos>k__BackingField; // 0x1ce4
	System.Numerics.Vector3 <DMantleDataStartPos>k__BackingField; // 0x1cf0
	System.Numerics.Vector3 <DMantleDataEndPos>k__BackingField; // 0x1cfc
	System.Numerics.Vector3 <DLastCcPos>k__BackingField; // 0x1d08
	System.Numerics.Vector3 <DNowCcPos>k__BackingField; // 0x1d14
	System.Numerics.Vector3 <DMoveSpeed>k__BackingField; // 0x1d20
	System.Int32 <DUseCmdPosCondition>k__BackingField; // 0x1d2c
	System.Int64 <DPlatformId>k__BackingField; // 0x1d30
	UnityEngine.Vector3 AddSpeed; // 0x1d38
	System.Boolean HasWakeUpRequestLocal; // 0x1d44
	System.Int32 GetClassHash(); // 0x06ee4eec
	System.String GetTypeName(); // 0x06ee4f54
	System.Int32 get_EntityType(); // 0x06ee4fcc
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x055128b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x05524154
	System.Single get_PosX(); // 0x06ee6328
	System.Void set_PosX(System.Single value); // 0x06ee63c8
	System.Single get_PosY(); // 0x06ee645c
	System.Void set_PosY(System.Single value); // 0x06ee64fc
	System.Single get_PosZ(); // 0x06ee6590
	System.Void set_PosZ(System.Single value); // 0x06ee6630
	System.Single get_RotateX(); // 0x06ee66c4
	System.Void set_RotateX(System.Single value); // 0x06ee6738
	System.Single get_RotateY(); // 0x06ee67c4
	System.Void set_RotateY(System.Single value); // 0x06ee6838
	System.Single get_RotateZ(); // 0x06ee68c4
	System.Void set_RotateZ(System.Single value); // 0x06ee6938
	System.Int64 get_CurrentWeaponId(); // 0x06ee69c4
	System.Void set_CurrentWeaponId(System.Int64 value); // 0x06ee6a38
	System.Int64 get_PreviousWeaponId(); // 0x06ee6ac4
	System.Void set_PreviousWeaponId(System.Int64 value); // 0x06ee6b38
	WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum get_CharacterState(); // 0x06ee6bc4
	System.Void set_CharacterState(WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum value); // 0x06ee6c38
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum get_ActionState(); // 0x06ee6cc4
	System.Void set_ActionState(WizardGames.Soc.Common.Entity.PlayerActionStateEnum value); // 0x06ee6d38
	WizardGames.Soc.Common.Entity.PlayerAdsStateEnum get_AdsState(); // 0x06ee6dc4
	System.Void set_AdsState(WizardGames.Soc.Common.Entity.PlayerAdsStateEnum value); // 0x06ee6e38
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_MoveState(); // 0x06ee6ec4
	System.Void set_MoveState(WizardGames.Soc.Common.Entity.PlayerMoveStateEnum value); // 0x06ee6f38
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_LastMoveState(); // 0x06ee6fc4
	System.Void set_LastMoveState(WizardGames.Soc.Common.Entity.PlayerMoveStateEnum value); // 0x06ee7038
	WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum get_MoveJumpState(); // 0x06ee70c4
	System.Void set_MoveJumpState(WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum value); // 0x06ee7138
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum get_MoveLadderState(); // 0x06ee71c4
	System.Void set_MoveLadderState(WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum value); // 0x06ee7238
	WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum get_MoveMantleState(); // 0x06ee72c4
	System.Void set_MoveMantleState(WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum value); // 0x06ee7338
	WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum get_MoveSwimState(); // 0x06ee73c4
	System.Void set_MoveSwimState(WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum value); // 0x06ee7438
	WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum get_MoveZiplineState(); // 0x06ee74c4
	System.Void set_MoveZiplineState(WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum value); // 0x06ee7538
	WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum get_PoseDyingState(); // 0x06ee75c4
	System.Void set_PoseDyingState(WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum value); // 0x06ee7638
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_PoseState(); // 0x06ee76c4
	System.Void set_PoseState(WizardGames.Soc.Common.Entity.PlayerPoseStateEnum value); // 0x06ee7738
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_LastPoseState(); // 0x06ee77c4
	System.Void set_LastPoseState(WizardGames.Soc.Common.Entity.PlayerPoseStateEnum value); // 0x06ee7838
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum get_UnAliveState(); // 0x06ee78c4
	System.Void set_UnAliveState(WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum value); // 0x06ee7938
	WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum get_PassiveState(); // 0x06ee79c4
	System.Void set_PassiveState(WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum value); // 0x06ee7a38
	WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum get_ReloadState(); // 0x06ee7ac4
	System.Void set_ReloadState(WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum value); // 0x06ee7b38
	WizardGames.Soc.Common.Entity.PlayerBowStateEnum get_BowState(); // 0x06ee7bc4
	System.Void set_BowState(WizardGames.Soc.Common.Entity.PlayerBowStateEnum value); // 0x06ee7c38
	WizardGames.Soc.Common.Entity.PlayerAttackStateEnum get_AttackSubState(); // 0x06ee7cc4
	System.Void set_AttackSubState(WizardGames.Soc.Common.Entity.PlayerAttackStateEnum value); // 0x06ee7d38
	WizardGames.Soc.Common.Entity.PlayerThrowState get_ThrowState(); // 0x06ee7dc4
	System.Void set_ThrowState(WizardGames.Soc.Common.Entity.PlayerThrowState value); // 0x06ee7e38
	WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum get_InteractiveState(); // 0x06ee7ec4
	System.Void set_InteractiveState(WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum value); // 0x06ee7f38
	System.Byte get_InteractiveSubState(); // 0x06ee7fc4
	System.Void set_InteractiveSubState(System.Byte value); // 0x06ee8038
	System.Int32 get_InteractiveStateStartTime(); // 0x06ee80c4
	System.Void set_InteractiveStateStartTime(System.Int32 value); // 0x06ee8138
	System.Int32 get_InteractiveSubStateStartTime(); // 0x06ee81c4
	System.Void set_InteractiveSubStateStartTime(System.Int32 value); // 0x06ee8238
	System.Int32 get_InteractiveId(); // 0x06ee82c4
	System.Void set_InteractiveId(System.Int32 value); // 0x06ee8338
	System.Int64 get_InteractiveTargetId(); // 0x06ee83c4
	System.Void set_InteractiveTargetId(System.Int64 value); // 0x06ee8438
	System.Int32 get_InteractiveTrigger(); // 0x06ee84c4
	System.Void set_InteractiveTrigger(System.Int32 value); // 0x06ee8538
	System.Int32 get_StateRecovery(); // 0x06ee85c4
	System.Void set_StateRecovery(System.Int32 value); // 0x06ee8638
	System.Int32 get_CommonStateRecovery(); // 0x06ee86c4
	System.Void set_CommonStateRecovery(System.Int32 value); // 0x06ee8738
	System.Int64 get_LongRoleId(); // 0x06ee87c4
	System.Void set_LongRoleId(System.Int64 value); // 0x06ee8838
	System.String get_OpenId(); // 0x06ee88c4
	System.Void set_OpenId(System.String value); // 0x06ee8938
	System.Int32 get_Level(); // 0x06ee89c4
	System.Boolean get_IsGround(); // 0x06ee8a38
	System.Void set_IsGround(System.Boolean value); // 0x06ee8aac
	System.Int32 get_LastIsGroundTime(); // 0x06ee8b38
	System.Void set_LastIsGroundTime(System.Int32 value); // 0x06ee8bac
	System.Int32 get_SetClipTime(); // 0x06ee8c38
	System.Void set_SetClipTime(System.Int32 value); // 0x06ee8cac
	System.Int32 get_ClientTime(); // 0x06ee8d38
	System.Void set_ClientTime(System.Int32 value); // 0x06ee8dac
	System.Int64 get_CmdAck(); // 0x06ee8e38
	System.Void set_CmdAck(System.Int64 value); // 0x06ee8eac
	System.Int64 get_RenderTime(); // 0x06ee8f38
	System.Void set_RenderTime(System.Int64 value); // 0x06ee8fac
	System.Single get_Fov(); // 0x06ee9038
	System.Int32 get_CreateIndex(); // 0x06ee90ac
	System.Void set_CreateIndex(System.Int32 value); // 0x06ee9120
	System.Single get_Stamina(); // 0x06ee91ac
	System.Void set_Stamina(System.Single value); // 0x06ee9220
	System.Single get_SpeedX(); // 0x06ee92ac
	System.Void set_SpeedX(System.Single value); // 0x06ee9320
	System.Single get_SpeedY(); // 0x06ee93ac
	System.Void set_SpeedY(System.Single value); // 0x06ee9420
	System.Single get_SpeedZ(); // 0x06ee94ac
	System.Void set_SpeedZ(System.Single value); // 0x06ee9520
	System.Single get_WantSpeedX(); // 0x06ee95ac
	System.Void set_WantSpeedX(System.Single value); // 0x06ee9620
	System.Single get_WantSpeedY(); // 0x06ee96ac
	System.Void set_WantSpeedY(System.Single value); // 0x06ee9720
	System.Single get_WantSpeedZ(); // 0x06ee97ac
	System.Void set_WantSpeedZ(System.Single value); // 0x06ee9820
	System.Single get_HorseSpeedX(); // 0x06ee98ac
	System.Single get_HorseSpeedY(); // 0x06ee9920
	System.Single get_HorseSpeedZ(); // 0x06ee9994
	System.Single get_ExtraSpeedX(); // 0x06ee9a08
	System.Void set_ExtraSpeedX(System.Single value); // 0x06ee9a7c
	System.Single get_ExtraSpeedY(); // 0x06ee9b08
	System.Void set_ExtraSpeedY(System.Single value); // 0x06ee9b7c
	System.Single get_ExtraSpeedZ(); // 0x06ee9c08
	System.Void set_ExtraSpeedZ(System.Single value); // 0x06ee9c7c
	System.Boolean get_FirstInSwim(); // 0x06ee9d08
	System.Void set_FirstInSwim(System.Boolean value); // 0x06ee9d7c
	System.Int32 get_AirTimeAcc(); // 0x06ee9e08
	System.Void set_AirTimeAcc(System.Int32 value); // 0x06ee9e7c
	System.Single get_LastRotateY(); // 0x06ee9f08
	System.Void set_LastRotateY(System.Single value); // 0x06ee9f7c
	System.Boolean get_ForceSwitch(); // 0x06eea008
	System.Void set_ForceSwitch(System.Boolean value); // 0x06eea07c
	System.Single get_GroundNormalX(); // 0x06eea108
	System.Void set_GroundNormalX(System.Single value); // 0x06eea17c
	System.Single get_GroundNormalY(); // 0x06eea208
	System.Void set_GroundNormalY(System.Single value); // 0x06eea27c
	System.Single get_GroundNormalZ(); // 0x06eea308
	System.Void set_GroundNormalZ(System.Single value); // 0x06eea37c
	System.Single get_LastGroundNormalX(); // 0x06eea408
	System.Void set_LastGroundNormalX(System.Single value); // 0x06eea47c
	System.Single get_LastGroundNormalY(); // 0x06eea508
	System.Void set_LastGroundNormalY(System.Single value); // 0x06eea57c
	System.Single get_LastGroundNormalZ(); // 0x06eea608
	System.Void set_LastGroundNormalZ(System.Single value); // 0x06eea67c
	System.Single get_AdsOffsetProgress(); // 0x06eea708
	System.Void set_AdsOffsetProgress(System.Single value); // 0x06eea77c
	System.Single get_RecoverChance(); // 0x06eea808
	System.Void set_RecoverChance(System.Single value); // 0x06eea87c
	System.Boolean get_IsDieFromCrawl(); // 0x06eea908
	System.Void set_IsDieFromCrawl(System.Boolean value); // 0x06eea97c
	System.Int32 get_AutoDiveMove(); // 0x06eeaa08
	System.Void set_AutoDiveMove(System.Int32 value); // 0x06eeaa7c
	System.Int32 get_AutoDiveMoveTime(); // 0x06eeab08
	System.Void set_AutoDiveMoveTime(System.Int32 value); // 0x06eeab7c
	System.Single get_Calories(); // 0x06eeac08
	System.Void set_Calories(System.Single value); // 0x06eeac7c
	System.Single get_Hydration(); // 0x06eead08
	System.Void set_Hydration(System.Single value); // 0x06eead7c
	System.Single get_HeartRate(); // 0x06eeae08
	System.Void set_HeartRate(System.Single value); // 0x06eeae7c
	System.Single get_PendingHealth(); // 0x06eeaf08
	System.Void set_PendingHealth(System.Single value); // 0x06eeaf7c
	System.Single get_Bleeding(); // 0x06eeb008
	System.Void set_Bleeding(System.Single value); // 0x06eeb07c
	System.Single get_Temperature(); // 0x06eeb108
	System.Void set_Temperature(System.Single value); // 0x06eeb17c
	System.Single get_Poison(); // 0x06eeb208
	System.Void set_Poison(System.Single value); // 0x06eeb27c
	System.Single get_RadiationLevel(); // 0x06eeb308
	System.Void set_RadiationLevel(System.Single value); // 0x06eeb37c
	System.Single get_RadiationPoison(); // 0x06eeb408
	System.Void set_RadiationPoison(System.Single value); // 0x06eeb47c
	System.Single get_Wetness(); // 0x06eeb508
	System.Void set_Wetness(System.Single value); // 0x06eeb57c
	System.Single get_Oxygen(); // 0x06eeb608
	System.Void set_Oxygen(System.Single value); // 0x06eeb67c
	System.Single get_Comfort(); // 0x06eeb708
	System.Void set_Comfort(System.Single value); // 0x06eeb77c
	System.Int32 get_CaloriesBenefit(); // 0x06eeb808
	System.Void set_CaloriesBenefit(System.Int32 value); // 0x06eeb87c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem1(); // 0x06eeb908
	System.Void set_CustomItem1(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eeb9cc
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem2(); // 0x06eeba58
	System.Void set_CustomItem2(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eebb1c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem3(); // 0x06eebba8
	System.Void set_CustomItem3(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eebc6c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem4(); // 0x06eebcf8
	System.Void set_CustomItem4(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eebdbc
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem5(); // 0x06eebe48
	System.Void set_CustomItem5(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eebf0c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem6(); // 0x06eebf98
	System.Void set_CustomItem6(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eec05c
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem7(); // 0x06eec0e8
	System.Void set_CustomItem7(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eec1ac
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItem8(); // 0x06eec238
	System.Void set_CustomItem8(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eec2fc
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_CustomItemHiddenUse(); // 0x06eec388
	System.Void set_CustomItemHiddenUse(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x06eec44c
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EmbeddedCustomBase> get_CustomItemModels(); // 0x06eec4d8
	System.Void set_CustomItemModels(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EmbeddedCustomBase> value); // 0x06eec578
	System.Int64 get_AliveDuration(); // 0x06eec604
	System.Void set_AliveDuration(System.Int64 value); // 0x06eec678
	System.String get_HitSourceName(); // 0x06eec704
	System.Void set_HitSourceName(System.String value); // 0x06eec778
	System.Int64 get_HitSourcePlayerRoleId(); // 0x06eec804
	System.Void set_HitSourcePlayerRoleId(System.Int64 value); // 0x06eec878
	System.Int64 get_HitSourceTableId(); // 0x06eec904
	System.Void set_HitSourceTableId(System.Int64 value); // 0x06eec978
	System.Int64 get_HitWeaponTableId(); // 0x06eeca04
	System.Void set_HitWeaponTableId(System.Int64 value); // 0x06eeca78
	System.Int64 get_HitWeaponSkinId(); // 0x06eecb04
	System.Int64 get_HitAmmoTableId(); // 0x06eecb78
	System.Void set_HitAmmoTableId(System.Int64 value); // 0x06eecbec
	System.Int32 get_HitDamageType(); // 0x06eecc78
	System.Void set_HitDamageType(System.Int32 value); // 0x06eeccec
	System.Int32 get_NoIgnoreHitDamageType(); // 0x06eecd78
	System.Void set_NoIgnoreHitDamageType(System.Int32 value); // 0x06eecdec
	System.Int64 get_HitOccurTime(); // 0x06eece78
	System.Void set_HitOccurTime(System.Int64 value); // 0x06eeceec
	System.Single get_HitDistance(); // 0x06eecf78
	System.Void set_HitDistance(System.Single value); // 0x06eecfec
	System.Int32 get_HitSourceEntityType(); // 0x06eed078
	System.Single get_HitDamage(); // 0x06eed0ec
	System.Int32 get_HitPart(); // 0x06eed160
	System.Int32 get_KillPlayerCount(); // 0x06eed1d4
	System.Int32 get_KillScientistCount(); // 0x06eed248
	System.Int32 get_WaysToDieID(); // 0x06eed2bc
	System.Single get_MainLightIntensity(); // 0x06eed330
	System.Void set_MainLightIntensity(System.Single value); // 0x06eed3a4
	System.Single get_EnvironmentIntensity(); // 0x06eed430
	System.Void set_EnvironmentIntensity(System.Single value); // 0x06eed4a4
	System.Boolean get_IsInterior(); // 0x06eed530
	System.Void set_IsInterior(System.Boolean value); // 0x06eed5a4
	System.Boolean get_IsHideSea(); // 0x06eed630
	System.Void set_IsHideSea(System.Boolean value); // 0x06eed6a4
	System.Boolean get_IsOpenShadowFunc(); // 0x06eed730
	System.Void set_IsOpenShadowFunc(System.Boolean value); // 0x06eed7a4
	System.Int32 get_TodType(); // 0x06eed830
	System.Void set_TodType(System.Int32 value); // 0x06eed8a4
	System.Int32 get_MonumentLightVolumeId(); // 0x06eed930
	System.Void set_MonumentLightVolumeId(System.Int32 value); // 0x06eed9a4
	System.Boolean get_IsLightVolumeTriggerChanged(); // 0x06eeda30
	System.Void set_IsLightVolumeTriggerChanged(System.Boolean value); // 0x06eedaa4
	System.Boolean get_IsHighThreat(); // 0x06eedb30
	System.Boolean get_IsHostile(); // 0x06eedba4
	System.Void set_IsHostile(System.Boolean value); // 0x06eedc18
	System.Int64 get_HostileStartTime(); // 0x06eedca4
	System.Void set_HostileStartTime(System.Int64 value); // 0x06eedd18
	System.Int64 get_HostileEndTime(); // 0x06eedda4
	System.Void set_HostileEndTime(System.Int64 value); // 0x06eede18
	System.Int64 get_HoldWeaponInsideTime(); // 0x06eedea4
	System.Int32 get_SafetyAreaState(); // 0x06eedf18
	System.Void set_SafetyAreaState(System.Int32 value); // 0x06eedf8c
	System.Int64 get_ClientAuthorityTime(); // 0x06eee018
	System.Void set_ClientAuthorityTime(System.Int64 value); // 0x06eee08c
	System.Int64 get_StandOrCrouchInTime(); // 0x06eee118
	System.Void set_StandOrCrouchInTime(System.Int64 value); // 0x06eee18c
	System.Int64 get_CheckToStandTime(); // 0x06eee218
	System.Void set_CheckToStandTime(System.Int64 value); // 0x06eee28c
	System.Int32 get_LadderWayPointIndex(); // 0x06eee318
	System.Void set_LadderWayPointIndex(System.Int32 value); // 0x06eee38c
	System.Single get_LadderStartPositionX(); // 0x06eee418
	System.Void set_LadderStartPositionX(System.Single value); // 0x06eee48c
	System.Single get_LadderStartPositionY(); // 0x06eee518
	System.Void set_LadderStartPositionY(System.Single value); // 0x06eee58c
	System.Single get_LadderStartPositionZ(); // 0x06eee618
	System.Void set_LadderStartPositionZ(System.Single value); // 0x06eee68c
	System.Single get_LadderPositionX(); // 0x06eee718
	System.Void set_LadderPositionX(System.Single value); // 0x06eee78c
	System.Single get_LadderPositionY(); // 0x06eee818
	System.Void set_LadderPositionY(System.Single value); // 0x06eee88c
	System.Single get_LadderPositionZ(); // 0x06eee918
	System.Void set_LadderPositionZ(System.Single value); // 0x06eee98c
	System.Single get_LadderStartYaw(); // 0x06eeea18
	System.Void set_LadderStartYaw(System.Single value); // 0x06eeea8c
	System.Single get_LadderTargetYaw(); // 0x06eeeb18
	System.Void set_LadderTargetYaw(System.Single value); // 0x06eeeb8c
	System.Single get_LadderStartPitch(); // 0x06eeec18
	System.Void set_LadderStartPitch(System.Single value); // 0x06eeec8c
	System.Single get_LadderTargetPitch(); // 0x06eeed18
	System.Void set_LadderTargetPitch(System.Single value); // 0x06eeed8c
	System.Int32 get_LadderMoveFlag(); // 0x06eeee18
	System.Void set_LadderMoveFlag(System.Int32 value); // 0x06eeee8c
	System.Int32 get_LadderEnterDir(); // 0x06eeef18
	System.Void set_LadderEnterDir(System.Int32 value); // 0x06eeef8c
	System.Int32 get_LadderLeaveDir(); // 0x06eef018
	System.Void set_LadderLeaveDir(System.Int32 value); // 0x06eef08c
	System.Int64 get_LadderTargetId(); // 0x06eef118
	System.Void set_LadderTargetId(System.Int64 value); // 0x06eef18c
	System.Int64 get_LadderAdsorbTargetIndex(); // 0x06eef218
	System.Void set_LadderAdsorbTargetIndex(System.Int64 value); // 0x06eef28c
	System.Single get_LadderLeaveSpeedX(); // 0x06eef318
	System.Void set_LadderLeaveSpeedX(System.Single value); // 0x06eef38c
	System.Single get_LadderLeaveSpeedY(); // 0x06eef418
	System.Void set_LadderLeaveSpeedY(System.Single value); // 0x06eef48c
	System.Single get_LadderLeaveSpeedZ(); // 0x06eef518
	System.Void set_LadderLeaveSpeedZ(System.Single value); // 0x06eef58c
	System.Int32 get_LadderTopExitToleranceTime(); // 0x06eef618
	System.Void set_LadderTopExitToleranceTime(System.Int32 value); // 0x06eef68c
	System.Int32 get_LadderBotExitToleranceTime(); // 0x06eef718
	System.Void set_LadderBotExitToleranceTime(System.Int32 value); // 0x06eef78c
	System.Int32 get_LadderTopEnterToleranceTime(); // 0x06eef818
	System.Void set_LadderTopEnterToleranceTime(System.Int32 value); // 0x06eef88c
	System.Int32 get_LadderBotEnterToleranceTime(); // 0x06eef918
	System.Void set_LadderBotEnterToleranceTime(System.Int32 value); // 0x06eef98c
	System.Int32 get_LadderNextEnterTime(); // 0x06eefa18
	System.Void set_LadderNextEnterTime(System.Int32 value); // 0x06eefa8c
	System.Boolean get_AngleOverJumpInLadder(); // 0x06eefb18
	System.Void set_AngleOverJumpInLadder(System.Boolean value); // 0x06eefb8c
	System.Boolean get_IsTrustClient(); // 0x06eefc18
	System.Void set_IsTrustClient(System.Boolean value); // 0x06eefc8c
	System.Single get_Height(); // 0x06eefd18
	System.Void set_Height(System.Single value); // 0x06eefd8c
	System.Single get_CcHeight(); // 0x06eefe18
	System.Void set_CcHeight(System.Single value); // 0x06eefe8c
	System.Single get_Scale(); // 0x06eeff18
	System.Void set_Scale(System.Single value); // 0x06eeff8c
	System.String get_Name(); // 0x06ef0018
	System.Void set_Name(System.String value); // 0x06ef008c
	System.String get_Portrait(); // 0x06ef0118
	System.UInt32 get_PortraitFrame(); // 0x06ef018c
	System.UInt32 get_ChatBubbleId(); // 0x06ef0200
	System.Int32 get_NameCardId(); // 0x06ef0274
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.PlayerAppearanceData> get_AppearanceData(); // 0x06ef02e8
	System.Void set_AppearanceData(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.PlayerAppearanceData> value); // 0x06ef0388
	System.Int32 get_Sex(); // 0x06ef0414
	System.Void set_Sex(System.Int32 value); // 0x06ef0488
	System.Int32 get_FaceId(); // 0x06ef0514
	System.Void set_FaceId(System.Int32 value); // 0x06ef0588
	System.Int32 get_HairId(); // 0x06ef0614
	System.Void set_HairId(System.Int32 value); // 0x06ef0688
	System.Int32 get_HairColorId(); // 0x06ef0714
	System.Void set_HairColorId(System.Int32 value); // 0x06ef0788
	WizardGames.Soc.Common.CustomType.MeleeCustom get_NullHandCustom(); // 0x06ef0814
	System.Void set_NullHandCustom(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x06ef08d8
	System.Single get_ReadonlyHp(); // 0x06ef0964
	System.Single get_ReadonlyMaxHp(); // 0x06ef09d8
	System.Int32 get_PlayCampId(); // 0x06ef0a4c
	System.Void set_PlayCampId(System.Int32 value); // 0x06ef0ac0
	System.Int32 get_RootMotionResNumber(); // 0x06ef0b4c
	System.Void set_RootMotionResNumber(System.Int32 value); // 0x06ef0bc0
	System.Int32 get_RootMotionTime(); // 0x06ef0c4c
	System.Void set_RootMotionTime(System.Int32 value); // 0x06ef0cc0
	System.Single get_RootMotionStartX(); // 0x06ef0d4c
	System.Void set_RootMotionStartX(System.Single value); // 0x06ef0dc0
	System.Single get_RootMotionStartY(); // 0x06ef0e4c
	System.Void set_RootMotionStartY(System.Single value); // 0x06ef0ec0
	System.Single get_RootMotionStartZ(); // 0x06ef0f4c
	System.Void set_RootMotionStartZ(System.Single value); // 0x06ef0fc0
	System.Single get_RootMotionStartYaw(); // 0x06ef104c
	System.Void set_RootMotionStartYaw(System.Single value); // 0x06ef10c0
	System.Single get_RootMotionTargetX(); // 0x06ef114c
	System.Void set_RootMotionTargetX(System.Single value); // 0x06ef11c0
	System.Single get_RootMotionTargetY(); // 0x06ef124c
	System.Void set_RootMotionTargetY(System.Single value); // 0x06ef12c0
	System.Single get_RootMotionTargetZ(); // 0x06ef134c
	System.Void set_RootMotionTargetZ(System.Single value); // 0x06ef13c0
	System.Single get_RootMotionTargetYaw(); // 0x06ef144c
	System.Void set_RootMotionTargetYaw(System.Single value); // 0x06ef14c0
	System.Single get_RootMotionTargetX2(); // 0x06ef154c
	System.Void set_RootMotionTargetX2(System.Single value); // 0x06ef15c0
	System.Single get_RootMotionTargetY2(); // 0x06ef164c
	System.Void set_RootMotionTargetY2(System.Single value); // 0x06ef16c0
	System.Single get_RootMotionTargetZ2(); // 0x06ef174c
	System.Void set_RootMotionTargetZ2(System.Single value); // 0x06ef17c0
	System.Single get_RootMotionTargetYaw2(); // 0x06ef184c
	System.Void set_RootMotionTargetYaw2(System.Single value); // 0x06ef18c0
	System.Single get_RootMotionTargetX3(); // 0x06ef194c
	System.Void set_RootMotionTargetX3(System.Single value); // 0x06ef19c0
	System.Single get_RootMotionTargetY3(); // 0x06ef1a4c
	System.Void set_RootMotionTargetY3(System.Single value); // 0x06ef1ac0
	System.Single get_RootMotionTargetZ3(); // 0x06ef1b4c
	System.Void set_RootMotionTargetZ3(System.Single value); // 0x06ef1bc0
	System.Single get_RootMotionTargetYaw3(); // 0x06ef1c4c
	System.Void set_RootMotionTargetYaw3(System.Single value); // 0x06ef1cc0
	System.Single get_ViewYaw(); // 0x06ef1d4c
	System.Void set_ViewYaw(System.Single value); // 0x06ef1dc0
	System.Single get_ViewPitch(); // 0x06ef1e4c
	System.Void set_ViewPitch(System.Single value); // 0x06ef1ec0
	System.Int32 get_Events(); // 0x06ef1f4c
	System.Void set_Events(System.Int32 value); // 0x06ef1fc0
	System.Int64 get_LastWoundedTime(); // 0x06ef204c
	System.Void set_LastWoundedTime(System.Int64 value); // 0x06ef20c0
	System.Int32 get_LifeCycleFlags(); // 0x06ef214c
	System.Void set_LifeCycleFlags(System.Int32 value); // 0x06ef21c0
	System.Int64 get_AidCompleteTime(); // 0x06ef224c
	System.Void set_AidCompleteTime(System.Int64 value); // 0x06ef22c0
	System.Int64 get_AidEntityId(); // 0x06ef234c
	System.Void set_AidEntityId(System.Int64 value); // 0x06ef23c0
	System.Int64 get_AidedSourceEntityId(); // 0x06ef244c
	System.Void set_AidedSourceEntityId(System.Int64 value); // 0x06ef24c0
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipHeadCustom(); // 0x06ef254c
	System.Void set_EquipHeadCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2610
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipEyeCustom(); // 0x06ef269c
	System.Void set_EquipEyeCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2760
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipJawCustom(); // 0x06ef27ec
	System.Void set_EquipJawCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef28b0
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipUpperArmorCustom(); // 0x06ef293c
	System.Void set_EquipUpperArmorCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2a00
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipShirtCustom(); // 0x06ef2a8c
	System.Void set_EquipShirtCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2b50
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipGloveCustom(); // 0x06ef2bdc
	System.Void set_EquipGloveCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2ca0
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipPantsCustom(); // 0x06ef2d2c
	System.Void set_EquipPantsCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2df0
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipLowerArmorCustom(); // 0x06ef2e7c
	System.Void set_EquipLowerArmorCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef2f40
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipShoeCustom(); // 0x06ef2fcc
	System.Void set_EquipShoeCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef3090
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipBagCustom(); // 0x06ef311c
	System.Void set_EquipBagCustom(WizardGames.Soc.Common.CustomType.WearItemCustom value); // 0x06ef31e0
	System.Int32 get_EquipVersion(); // 0x06ef326c
	System.Void set_EquipVersion(System.Int32 value); // 0x06ef32e0
	System.Single get_AniMantleSpeed(); // 0x06ef336c
	System.Void set_AniMantleSpeed(System.Single value); // 0x06ef33e0
	System.Int64 get_MountableId(); // 0x06ef346c
	System.Void set_MountableId(System.Int64 value); // 0x06ef34e0
	System.Int32 get_MountableType(); // 0x06ef356c
	System.Void set_MountableType(System.Int32 value); // 0x06ef35e0
	System.Int32 get_VehicleType(); // 0x06ef366c
	System.Void set_VehicleType(System.Int32 value); // 0x06ef36e0
	System.Int32 get_MountSeatIndex(); // 0x06ef376c
	System.Void set_MountSeatIndex(System.Int32 value); // 0x06ef37e0
	System.Int64 get_OutpostRebornValidTime(); // 0x06ef386c
	System.Void set_OutpostRebornValidTime(System.Int64 value); // 0x06ef38e0
	System.Int64 get_NearbyRebornValidTime(); // 0x06ef396c
	System.Void set_NearbyRebornValidTime(System.Int64 value); // 0x06ef39e0
	System.Int64 get_NearbyRebornPVPValidTime(); // 0x06ef3a6c
	System.Void set_NearbyRebornPVPValidTime(System.Int64 value); // 0x06ef3ae0
	System.Boolean get_IsNearbyReborn(); // 0x06ef3b6c
	System.Void set_IsNearbyReborn(System.Boolean value); // 0x06ef3be0
	System.Single get_NearbyRebornPosX(); // 0x06ef3c6c
	System.Void set_NearbyRebornPosX(System.Single value); // 0x06ef3ce0
	System.Single get_NearbyRebornPosY(); // 0x06ef3d6c
	System.Void set_NearbyRebornPosY(System.Single value); // 0x06ef3de0
	System.Single get_NearbyRebornPosZ(); // 0x06ef3e6c
	System.Void set_NearbyRebornPosZ(System.Single value); // 0x06ef3ee0
	System.Int32 get_RandomRebornStage(); // 0x06ef3f6c
	System.Void set_RandomRebornStage(System.Int32 value); // 0x06ef3fe0
	System.Int64 get_RandomRebornLastTime(); // 0x06ef406c
	System.Void set_RandomRebornLastTime(System.Int64 value); // 0x06ef40e0
	System.Int32 get_EquipEnableFlags(); // 0x06ef416c
	System.Void set_EquipEnableFlags(System.Int32 value); // 0x06ef41e0
	System.Single get_LittleEyeGoPosX(); // 0x06ef426c
	System.Void set_LittleEyeGoPosX(System.Single value); // 0x06ef42e0
	System.Single get_LittleEyeGoPosY(); // 0x06ef436c
	System.Void set_LittleEyeGoPosY(System.Single value); // 0x06ef43e0
	System.Single get_LittleEyeGoPosZ(); // 0x06ef446c
	System.Void set_LittleEyeGoPosZ(System.Single value); // 0x06ef44e0
	System.Int32 get_ProhibitJumpCount(); // 0x06ef456c
	System.Void set_ProhibitJumpCount(System.Int32 value); // 0x06ef45e0
	System.Boolean get_Observer(); // 0x06ef466c
	System.Void set_Observer(System.Boolean value); // 0x06ef46e0
	System.Boolean get_IsRobot(); // 0x06ef476c
	System.Void set_IsRobot(System.Boolean value); // 0x06ef47e0
	System.Int32 get_DeathAnimValue(); // 0x06ef486c
	System.Void set_DeathAnimValue(System.Int32 value); // 0x06ef48e0
	System.Int64 get_LastJumpTime(); // 0x06ef496c
	System.Void set_LastJumpTime(System.Int64 value); // 0x06ef49e0
	System.Int64 get_ObserverLoadingFinishTime(); // 0x06ef4a6c
	System.Void set_ObserverLoadingFinishTime(System.Int64 value); // 0x06ef4ae0
	System.Int64 get_PlatformId(); // 0x06ef4b6c
	System.Void set_PlatformId(System.Int64 value); // 0x06ef4be0
	System.Single get_PlatformPosX(); // 0x06ef4c6c
	System.Void set_PlatformPosX(System.Single value); // 0x06ef4ce0
	System.Single get_PlatformPosY(); // 0x06ef4d6c
	System.Void set_PlatformPosY(System.Single value); // 0x06ef4de0
	System.Single get_PlatformPosZ(); // 0x06ef4e6c
	System.Void set_PlatformPosZ(System.Single value); // 0x06ef4ee0
	System.Int32 get_MonumentId(); // 0x06ef4f6c
	System.Void set_MonumentId(System.Int32 value); // 0x06ef4fe0
	System.Int32 get_MonumentTypeId(); // 0x06ef506c
	System.Void set_MonumentTypeId(System.Int32 value); // 0x06ef50e0
	System.Boolean get_IsDriver(); // 0x06ef516c
	System.Void set_IsDriver(System.Boolean value); // 0x06ef51e0
	System.Boolean get_ClothingBlocksAiming(); // 0x06ef526c
	System.Void set_ClothingBlocksAiming(System.Boolean value); // 0x06ef52e0
	System.Single get_ClothingMoveSpeedReduction(); // 0x06ef536c
	System.Void set_ClothingMoveSpeedReduction(System.Single value); // 0x06ef53e0
	System.Single get_ClothingWaterSpeedBonus(); // 0x06ef546c
	System.Void set_ClothingWaterSpeedBonus(System.Single value); // 0x06ef54e0
	System.Single get_ReduceSpeedRate(); // 0x06ef556c
	System.Void set_ReduceSpeedRate(System.Single value); // 0x06ef55e0
	System.Single get_HeldItemSpeedRate(); // 0x06ef566c
	System.Void set_HeldItemSpeedRate(System.Single value); // 0x06ef56e0
	System.Int32 get_EscapeFromStuckCount(); // 0x06ef576c
	System.Void set_EscapeFromStuckCount(System.Int32 value); // 0x06ef57e0
	System.Int64 get_EscapeFromStuckValidTime(); // 0x06ef586c
	System.Void set_EscapeFromStuckValidTime(System.Int64 value); // 0x06ef58e0
	System.Int32 get_MonumentTaskGroupId(); // 0x06ef596c
	System.Void set_MonumentTaskGroupId(System.Int32 value); // 0x06ef59e0
	System.Int32 get_MonumentTaskId(); // 0x06ef5a6c
	System.Void set_MonumentTaskId(System.Int32 value); // 0x06ef5ae0
	System.Boolean get_ProhibitMountHorse(); // 0x06ef5b6c
	System.Void set_ProhibitMountHorse(System.Boolean value); // 0x06ef5be0
	System.Byte get_AttackInfoIndex(); // 0x06ef5c6c
	System.Void set_AttackInfoIndex(System.Byte value); // 0x06ef5ce0
	System.Byte get_UseAnimIndex(); // 0x06ef5d6c
	System.Void set_UseAnimIndex(System.Byte value); // 0x06ef5de0
	System.Byte get_UseHitIndex(); // 0x06ef5e6c
	System.Void set_UseHitIndex(System.Byte value); // 0x06ef5ee0
	System.Int32 get_AttackHitMat(); // 0x06ef5f6c
	System.Void set_AttackHitMat(System.Int32 value); // 0x06ef5fe0
	System.Int32 get_ActionStateStartTime(); // 0x06ef606c
	System.Void set_ActionStateStartTime(System.Int32 value); // 0x06ef60e0
	System.Int32 get_ActionSubStateStartTime(); // 0x06ef616c
	System.Void set_ActionSubStateStartTime(System.Int32 value); // 0x06ef61e0
	System.Int32 get_ActionStateTrigger(); // 0x06ef626c
	System.Void set_ActionStateTrigger(System.Int32 value); // 0x06ef62e0
	System.Single get_BowChargeProgress(); // 0x06ef636c
	System.Void set_BowChargeProgress(System.Single value); // 0x06ef63e0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3BuffData> get_BuffDataMap(); // 0x06ef646c
	System.Void set_BuffDataMap(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3BuffData> value); // 0x06ef650c
	System.Int32 get_Movement8Direction(); // 0x06ef6598
	System.Void set_Movement8Direction(System.Int32 value); // 0x06ef660c
	System.Int32 get_LastMovement8Direction(); // 0x06ef6698
	System.Void set_LastMovement8Direction(System.Int32 value); // 0x06ef670c
	System.Int32 get_Movement4Direction(); // 0x06ef6798
	System.Void set_Movement4Direction(System.Int32 value); // 0x06ef680c
	System.Boolean get_InputSprint(); // 0x06ef6898
	System.Void set_InputSprint(System.Boolean value); // 0x06ef690c
	System.Int32 get_StateRecoveryReason(); // 0x06ef6998
	System.Void set_StateRecoveryReason(System.Int32 value); // 0x06ef6a0c
	System.Int32 get_RootMotionWarpingIndex(); // 0x06ef6a98
	System.Void set_RootMotionWarpingIndex(System.Int32 value); // 0x06ef6b0c
	System.Int32 get_AnimCurBowTpState(); // 0x06ef6b98
	System.Void set_AnimCurBowTpState(System.Int32 value); // 0x06ef6c0c
	System.Int32 get_AdsStateStartTime(); // 0x06ef6c98
	System.Void set_AdsStateStartTime(System.Int32 value); // 0x06ef6d0c
	System.Boolean get_IsOnline(); // 0x06ef6d98
	System.Void set_IsOnline(System.Boolean value); // 0x06ef6e0c
	System.Boolean get_IsNovice(); // 0x06ef6e98
	System.Void set_IsNovice(System.Boolean value); // 0x06ef6f0c
	System.Int64 get_ShoppingEntityId(); // 0x06ef6f98
	System.Int64 get_NpcShoppEntityId(); // 0x06ef700c
	System.Int32 get_MoveStateStartTime(); // 0x06ef7080
	System.Void set_MoveStateStartTime(System.Int32 value); // 0x06ef70f4
	System.Int32 get_GestureIndex(); // 0x06ef7180
	System.Int32 get_HorseMountDir(); // 0x06ef71f4
	System.Void set_HorseMountDir(System.Int32 value); // 0x06ef7268
	System.Int32 get_ReputationExp(); // 0x06ef72f4
	System.Int32 get_ReputationLevel(); // 0x06ef7368
	System.Int64 get_CurrentLockingEntityId(); // 0x06ef73dc
	System.Void set_CurrentLockingEntityId(System.Int64 value); // 0x06ef7450
	System.Single get_CurrentLockingEntityToken(); // 0x06ef74dc
	System.Void set_CurrentLockingEntityToken(System.Single value); // 0x06ef7550
	System.Single get_ParachuteEquipCDTime(); // 0x06ef75dc
	System.Single get_ParachuteDestroyCDTime(); // 0x06ef7650
	System.Int64 get_SafetyBoxEntityId(); // 0x06ef76c4
	System.Int32 get_NextActiveSafetyBoxTime(); // 0x06ef7738
	System.Int32 get_NextCloseSafetyBoxTime(); // 0x06ef77ac
	System.Boolean get_InLandMineFuse(); // 0x06ef7820
	System.Void set_InLandMineFuse(System.Boolean value); // 0x06ef7894
	System.Int64 get_DieTimeStamp(); // 0x06ef7920
	WizardGames.Soc.Common.Entity.SightStateEnum get_SightStateEnum(); // 0x06ef7994
	System.Void set_SightStateEnum(WizardGames.Soc.Common.Entity.SightStateEnum value); // 0x06ef7a08
	System.Boolean get_HasWakeUpRequest(); // 0x06ef7a94
	System.Void set_HasWakeUpRequest(System.Boolean value); // 0x06ef7b08
	System.Boolean get_AutoRunBackToSprint(); // 0x06ef7b94
	System.Void set_AutoRunBackToSprint(System.Boolean value); // 0x06ef7c08
	System.Single get_RunToSprintFireTime(); // 0x06ef7c94
	System.Void set_RunToSprintFireTime(System.Single value); // 0x06ef7d08
	System.Byte get_SpatialAudio(); // 0x06ef7d94
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ef7e08
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ef806c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06ef84b4
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06ef8534
	System.Void RemoteCallOnTimerReportData2(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String reportData2); // 0x06f09784
	System.Void RemoteCallRequestDeployVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid, System.Int64 vehicleId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 rotation); // 0x06f09910
	System.Void RemoteCallRequestCreateComboPart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 comboId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 angle, System.Int64 targetPartId, System.Int64 markId, System.Int32 grade); // 0x06f09ae4
	System.Void RemoteCallCreatePart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData createPartData); // 0x06f09ce0
	System.Void RemoteCallCreateMultiParts(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> createList); // 0x06f09e6c
	System.Void RemoteCallEditRemovePart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId); // 0x06f09ff8
	System.Void RemoteCallCreateBlueprintParts(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 prefabId, System.Single x, System.Single y, System.Single z, System.Single rotateY); // 0x06f0a184
	System.Void RemoteCallEditUpgradePart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId, System.Int32 targetGrade); // 0x06f0a358
	System.Void RemoteCallEditChangeSkin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId, System.Int64 targetSkinNodeId, System.Boolean needChangeDefault); // 0x06f0a4fc
	System.Void RemoteCallEditRotatePart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId); // 0x06f0a6bc
	System.Void RemoteCallPickupPart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId); // 0x06f0a848
	System.Void RemoteCallRequestChangePartDirection(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId); // 0x06f0a9d4
	System.Void RemoteCallRequestMoveDeploy(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 angle); // 0x06f0ab60
	System.Void RemoteCallClientResumedControl(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0ad20
	System.Void RemoteCallClientStopControl(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0ae8c
	System.Void RemoteCallSyncTime(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 peerLocalTime); // 0x06f0aff8
	System.Void RemoteCallReportTime(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 peerLocalTimeMs); // 0x06f0b184
	System.Void RemoteCallFetchCupToolboxUpKeepItems(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId); // 0x06f0b310
	System.Void RemoteCallRequestChangeComboPart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 parentEntityId, System.Int64 targetParentPartType, System.Int32 targetParentPartGrade, System.Int64 targetChildComboId); // 0x06f0b49c
	System.Void RemoteCallPlayerGetInKatyuSha(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 katyushaEntityId); // 0x06f0b670
	System.Void RemoteCallGetMultiPlayerNames(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> playerIds); // 0x06f0b7fc
	System.Void RemoteCallGetMultiPlayerBriefInfo(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.UInt64> roleIds); // 0x06f0b988
	System.Void RemoteCallGetTerrainHeight(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 seq, System.Single posX, System.Single posZ); // 0x06f0bb14
	System.Void RemoteCallPlayerGetGlobalTrees(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0bcc4
	System.Void RemoteCallIsAnyMonsterInMyMonument(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interativeEntityId); // 0x06f0be30
	System.Void RemoteCallActivateSafetyBox(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 territoryCabinetId); // 0x06f0bfbc
	System.Void RemoteCallCloseSafetyBox(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0c148
	System.Void RemoteCallRefreshLobbyLevel(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0c2b4
	System.Void RemoteCallSendQuickNearbyChat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 textId); // 0x06f0c420
	System.Void RemoteCallNormalInteractCompleted(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactionEntityId); // 0x06f0c5ac
	System.Void RemoteCallPrintClientRecentRpc(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String entityRpcRecords); // 0x06f0c738
	System.Void RemoteCallSkipNewbie(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0c8c4
	System.Void RemoteCallUploadBattleButonTLog(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo> infoList); // 0x06f0ca30
	System.Void RemoteCallSecMoveReport(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String angleValueFlow, System.String angleRangeStatistics); // 0x06f0cbbc
	System.Void RemoteCallSendGameSummaryToLobby(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0cd60
	System.Void RemoteCallSetClientLoadingSuccess(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0cecc
	System.Void RemoteCallModifyUgcProperty(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo info); // 0x06f0d038
	System.Void RemoteCallTimelineNPCPathFind(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single srcX, System.Single srcY, System.Single srcZ, System.Single tarX, System.Single tarY, System.Single tarZ, System.UInt64 roleId, System.Int64 modelId); // 0x06f0d1dc
	System.Void RemoteCallTimelineNPCMultiplePathFind(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Single> posXList, System.Collections.Generic.IList<System.Single> posYList, System.Collections.Generic.IList<System.Single> posZList, System.UInt64 roleId, System.Int64 modelId); // 0x06f0d3ec
	System.Void RemoteCallReceiveUserCmd(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06f0d5cc
	System.Void RemoteCallGetMonumentBiomeForClient(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0d754
	System.Void RemoteCallTrackMonumentTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isSuccess); // 0x06f0d8c0
	System.Void RemoteCallDrink(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single riverX, System.Single riverY, System.Single riverZ); // 0x06f0da4c
	System.Void RemoteCallPickItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimulatorPickUpRequest data); // 0x06f0dc08
	System.Void RemoteCallSpawnAndMountParachute(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0dd94
	System.Void RemoteCallFireGanRaoDan(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> seekerIds); // 0x06f0df00
	System.Void RemoteCallUnloadBullet(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 weaponId); // 0x06f0e08c
	System.Void RemoteCallChangeAccessoryStatus(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 accessoryId, System.Int32 status, System.Boolean add); // 0x06f0e218
	System.Void RemoteCallStartCorpseHighlight(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 corpseEntityId, System.Int64 viewPlayerEntityId); // 0x06f0e3d8
	System.Void RemoteCallFinishLoading(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0e57c
	System.Void RemoteCallWakeUpAction(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0e6e8
	System.Void RemoteCallReborn(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 type); // 0x06f0e854
	System.Void RemoteCallOutpostReborn(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 outpostId); // 0x06f0e9e0
	System.Void RemoteCallSuicide(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 doSuicideType); // 0x06f0eb6c
	System.Void RemoteCallSuicideWhenDismountFailed(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0ecf8
	System.Void RemoteCallSetEquipEnable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 equipIndex, System.Boolean enable); // 0x06f0ee64
	System.Void RemoteCallSyncEquipFlags(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 flags); // 0x06f0f008
	System.Void RemoteCallWantsMountZipline(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 ziplineId, System.Int64 interactionId); // 0x06f0f194
	System.Void RemoteCallGetOutVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0f338
	System.Void RemoteCallSpeedUpZipLine(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 playerEntityId, System.Boolean speedUp); // 0x06f0f4a4
	System.Void RemoteCallSwitchMountSeat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 seatIndex); // 0x06f0f648
	System.Void RemoteCallWantsMount(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mountableId, System.Int32 seatType, System.Int32 seatIndex); // 0x06f0f7d4
	System.Void RemoteCallWantsDismount(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0f994
	System.Void RemoteCallJackHammerCharge(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 jackhammerId, System.Int64 workbenchID); // 0x06f0fb00
	System.Void RemoteCallWantsPush(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mountableId); // 0x06f0fca4
	System.Void RemoteCallEscapeFromStuck(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f0fe30
	System.Void RemoteCallHorseFollow(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mountableId, System.Boolean followOrCancel); // 0x06f0ff9c
	System.Void RemoteCallHorseFeed(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 horseEntityId, System.Int64 foodTemplateId); // 0x06f10140
	System.Void RemoteCallOpenVehicleLight(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x06f102e4
	System.Void RemoteCallModuleSwitchMountSeat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 targetModuleId, System.Int32 targetSeatIndex); // 0x06f10470
	System.Void RemoteCallOpenArmorModuleWindow(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x06f10614
	System.Void RemoteCallUpdateForagingState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 horseId); // 0x06f107a0
	System.Void RemoteCallOnTeamMemberChange(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f1092c
	System.Void RemoteCallOnTriggerInteract(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactEntityId); // 0x06f10a98
	System.Void RemoteCallHasTreasuretTaskTracked(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactEntityId); // 0x06f10c24
	System.Void RemoteCallOnTriggerInteractTrain(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactEntityId, System.Int32 currentSelected); // 0x06f10db0
	System.Void RemoteCallPing(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f10f54
	System.Void RemoteCallRepairPartOrVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 targetEntityId); // 0x06f110c0
	System.Void RemoteCallDefuse(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimulatorPickUpRequest req); // 0x06f1124c
	System.Void RemoteCallStartReloadNotInHand(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 heldItemEntityId, System.Int32 ammoId, System.Int64 nodeid, System.Int32 expectTime); // 0x06f113d8
	System.Void RemoteCallGetSummarizedDamageRecords(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f115b0
	System.Void RemoteCallParachuteCutEnd(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f1171c
	System.Void RemoteCallReceiveUserControllerSetting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.UserControllerSetting setting); // 0x06f11888
	System.Void RemoteCallRequestPlayTimeline(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 timelineId); // 0x06f11a14
	System.Void RemoteCallNotifyTimelineFinish(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 timelineId); // 0x06f11ba0
	System.Void RemoteCallStartLooting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch, System.Int64 targetId); // 0x06f11d2c
	System.Void RemoteCallSwitchLooting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch, System.Int64 entityId, System.Collections.Generic.IList<System.Int64> entityIds); // 0x06f11ef4
	System.Void RemoteCallGetItemWithoutLooting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch, System.Int64 entityId, System.Int64 itemUid); // 0x06f120d8
	System.Void RemoteCallQuickMerge(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch, System.Int64 entityId, System.Int64 bizId, System.Int32 count); // 0x06f122bc
	System.Void RemoteCallQuickRequire(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch, System.Int64 entityId, System.Int64 bizId, System.Int32 count); // 0x06f124b8
	System.Void InvokeChildOnCustomCreate(); // 0x06f126b4
	System.Void InvokeChildOnCustomRemove(); // 0x06f133c8
	System.Int32 CompareTo(WizardGames.Soc.Common.Entity.PlayerEntity other); // 0x06f141cc
	static System.Object DeserializePlayerEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f19ec0
	WizardGames.Soc.Common.Component.RootNodeComponent get_RootNode(); // 0x06f1a168
	WizardGames.Soc.Common.Component.ReputationComponent get_ReputationComp(); // 0x06f1a1e8
	WizardGames.Soc.Common.Component.PlayerLootingComponent get_LootingComp(); // 0x06f1a268
	WizardGames.Soc.Common.Component.PlayerSkinComponent get_SkinComp(); // 0x06f1a2e8
	WizardGames.Soc.Common.Component.BuffComponent get_BuffComp(); // 0x06f1a368
	System.Void .ctor(System.Int64 id); // 0x055112ac
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Boolean> get_CostumeOptions(); // 0x06f1a9bc
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_Costumes(); // 0x06f1abf8
	System.Boolean get_PlayStartAnim(); // 0x06f1ae30
	System.Boolean get_PlaySpecialIdleAnim(); // 0x06f1af44
	System.Boolean get_HideHelmet(); // 0x06f1afac
	System.Boolean get_HideBag(); // 0x06f1b014
	System.Boolean get_OnlyShowEquip(); // 0x06f1b07c
	System.Boolean GetCostumeOptionByKey(System.Int32 key); // 0x06f1ae98
	System.Single get_PosX_Smooth(); // 0x06f1b0e4
	System.Void set_PosX_Smooth(System.Single value); // 0x06f1b170
	System.Single get_PosY_Smooth(); // 0x06f1b1f0
	System.Void set_PosY_Smooth(System.Single value); // 0x06f1b27c
	System.Single get_PosZ_Smooth(); // 0x06f1b2fc
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f1b384
	System.Single get_RotateX_Smooth(); // 0x06f1b404
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f1b468
	System.Single get_RotateY_Smooth(); // 0x06f1b4e0
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f1b544
	System.Single get_RotateZ_Smooth(); // 0x06f1b5bc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f1b620
	System.Int64 get_ParentId(); // 0x06f1b698
	System.Int64 get_MountID(); // 0x06f1b6fc
	System.Boolean get_HasLocalRotation(); // 0x06f1b760
	System.Single get_PosX_Immediate(); // 0x06f1b7c4
	System.Single get_PosY_Immediate(); // 0x06f1b854
	System.Single get_PosZ_Immediate(); // 0x06f1b8e4
	System.Single get_RotateY_Immediate(); // 0x06f1b974
	WizardGames.Soc.Common.Component.TeamComponent get_MyTeamComponent(); // 0x06f1b9d8
	System.Int64 get_TeamId(); // 0x06f1ba58
	WizardGames.Soc.Common.Entity.TeamEntity get_MyTeam(); // 0x06f1bad4
	WizardGames.Soc.Common.Component.ChatComponent get_MyChatComponent(); // 0x06f1bc30
	WizardGames.Soc.Common.Component.PlayerPlunderComponent get_PlayerPlunderComponent(); // 0x06f1bcb0
	WizardGames.Soc.Common.Component.PlayerInventoryComponent get_InventoryComponent(); // 0x06f1bd30
	WizardGames.Soc.Common.Component.PlayerTaskComponent get_TaskComponent(); // 0x06f1bdb0
	WizardGames.Soc.Common.Component.PlayerVehicleComponent get_VehicleComponent(); // 0x06f1be30
	WizardGames.Soc.Common.Component.BlueprintComponent get_BlueprintComponent(); // 0x06f1beb0
	WizardGames.Soc.Common.Component.CommonComposeComponent get_CommonComposeComponent(); // 0x06f1bf30
	WizardGames.Soc.Common.Component.PlayerShopComponent get_ShopComponent(); // 0x06f1bfb0
	WizardGames.Soc.Share.Framework.EntityBase get_LootingEntity(); // 0x06f1c030
	WizardGames.Soc.Common.Component.PlayerFriendComponent get_FriendComponent(); // 0x06f1c160
	WizardGames.Soc.Common.Component.PlayerSeedBackpackComponent get_SeedBackpackComponent(); // 0x06f1c1e0
	WizardGames.Soc.Common.Component.BeeBuzzComponent get_BeeBuzzComponent(); // 0x06f1c260
	System.Boolean get_DebugEnable(); // 0x06f1c2e0
	System.Boolean get_KOLEnable(); // 0x06f1c358
	WizardGames.Soc.Common.Component.PlayerDrawComponentClient get_DrawComponent(); // 0x06f1c3d0
	System.Int32 GetCurWeaponEffectFuncIndex(); // 0x06f1c450
	System.Void SetCurWeaponEffectFuncIndex(System.Int32 index); // 0x06f1c54c
	System.Int32 get_NetworkRtt(); // 0x06f1c630
	System.Boolean get_InSkyDiving(); // 0x06f1c6b0
	System.Void Init(); // 0x06f1c820
	System.Void OnClientAdsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f1cb98
	System.Void OnClientMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f1cf64
	System.Void OnClientActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f1d0e0
	System.Void OnLandMineFuse(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean o, System.Boolean n); // 0x06f1d24c
	System.Void ShowOnGoingTip(); // 0x06f1d3c8
	WizardGames.Soc.Common.CustomType.SystemRootNode GetSystemNode(System.Int32 sysType); // 0x06f1d534
	System.Boolean TryGetAdvancedPerformance(System.Int64 weaponTableId, System.Int64 weaponSkinId, WizardGames.Soc.Common.Data.Display.AdvancedPerformance& advancedPerformance); // 0x06f1d5cc
	System.Boolean TryGetAdvancedPerformance(System.Int64 weaponTableId, System.Int64 weaponSkinId, WizardGames.Soc.Common.Entity.AdvancedPerformanceType performanceType, System.Int32& intValue, System.String& stringValue); // 0x06f1d88c
	static WizardGames.Soc.Common.Entity.PlayerEntity get_MyPlayerClient(); // 0x06f1da88
	static System.Void set_MyPlayerClient(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x06f1db10
	System.Void PostInit(); // 0x06f1dba4
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f1e9c8
	System.Void ExcuteGm(System.String content); // 0x06f1ecd4
	System.Void ReceiveReplayCmds(WizardGames.Soc.Common.SimpleCustom.ReplayUserCmd Cmd); // 0x06efb9c4
	System.Void LoadingSuccessAck(System.Int64 worldTime, System.Int64 sequence, System.Int64 ts, System.Int64 myEntityId, WizardGames.Soc.Common.SimpleCustom.GameTimeParam gameTimeParam); // 0x06efbac4
	static System.Void RefreshEntityId(System.Int64 entityId); // 0x06f1eecc
	System.Void FrameEnd(System.Int64 ts, System.Int64 sequence, System.Int32 interval, System.Int64 snapshotSequenceAck, WizardGames.Soc.Common.SimpleCustom.TraceTimeData trace); // 0x06efc01c
	System.Void UpdateServerTime(System.Int64 ts); // 0x06efc5d4
	System.Void OnTrainEnterMonument(System.Int32 monumentID); // 0x06efc688
	System.Void TestReceivePathNodes(System.Collections.Generic.List<System.Single> nodeX, System.Collections.Generic.List<System.Single> nodeY, System.Collections.Generic.List<System.Single> nodeZ); // 0x06efc8dc
	System.Void ShowMapMark(System.Int64 entityId, System.Int32 markType, System.Single posX, System.Single posY, System.Single posZ); // 0x06efc96c
	System.Void HideMapMark(System.Int64 entityId); // 0x06efcaa0
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06f1f300
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f1f3a0
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f1f464
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f1f504
	System.Void OnTeleport(); // 0x06efcb84
	System.Void SwitchToolboxModeOver(System.Int64 toolboxId, System.Int32 newMode, System.Int32 result, System.Int32 leftMinute); // 0x06efcc80
	System.Void OnDoorControllerMatchResult(System.Int64 partId, System.Int32 result); // 0x06efd80c
	System.Void ShowUpkeepCostInfo(System.Single keepTime, System.Collections.Generic.Dictionary<System.Int64,System.Int32> amounts, System.Int64 entityId); // 0x06efd9b0
	System.Void NetworkTestClient(System.Int32 seq, System.Buffers.ReadOnlySequence<System.Byte> input); // 0x06efdaa0
	System.Void OnConsumeOilAck(System.Int64 vehicleId, System.Int32 code, System.Int32 leftCount, System.Int32 consumeCount); // 0x06efdcbc
	System.Void PartTransformationOver(System.Int32 code, System.Int32 transformTimes, System.Int32 freeTransFormTime); // 0x06efdea0
	System.Void ShopInfoUpdate(System.Int64 id); // 0x06efe650
	System.Void OnSwitchSnapshotSequence(System.Int64 seq); // 0x06f1f5bc
	System.Void FailToKatyusha(); // 0x06efea9c
	System.Void UpdateSwipeCardGameState(System.Int32 graphId, System.Int32 state, System.Int32 leftGuaranteedNum, System.Int64 fuseBoxEntityID); // 0x06efebac
	System.Void OnPlayerMonumentTaskIDChanged(System.Int32 taskGroupID, System.Int32 taskID); // 0x06efeca8
	System.Void OnPlayerEnterMonument(System.Int32 monumentId); // 0x06efed68
	System.Void UpdateMonumentTaskState(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MonumentTaskState> taskStateList); // 0x06efee34
	System.Void UpdateMonumentBiome(System.Collections.Generic.Dictionary<System.Int32,System.Int32> biomeDict); // 0x06eff078
	System.Void CallAirDropSuccess(System.Boolean isRandom); // 0x06eff12c
	System.Void TriggerMonumentEvent(WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData eventCustomData); // 0x06eff304
	System.Void RemoveMonumentEvent(WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData actionParams); // 0x06eff744
	System.Void ResetMountablePosAndRot(System.Int64 mountableId, System.Collections.Generic.List<System.Single> list); // 0x06eff818
	System.Void ShowDismountFailWindow(); // 0x06efffd4
	System.Void SyncTimeAck(System.Int64 worldTime, System.Int64 timeOffset, System.Int64 now, System.Int64 msSinceStartup, System.Int64 msSinceLogicStart); // 0x06f00420
	System.Void CheckAndSyncTime(); // 0x06f1dd84
	System.Void ReportTime(System.Int64 timerId); // 0x06f1f72c
	System.Void TipsWithConstructionName(System.Int64 tipsId, System.Int64 entityId); // 0x06f005e4
	System.Void RequestChangeWireColorAck(System.Int32 isSuccess, System.Int64 entityId, System.Int32 type, System.Int32 colorId); // 0x06f0088c
	System.Void PopMessage(System.Int32 type, System.Int32 msgId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam> lanParams); // 0x06f00988
	System.Void PopMessageWithSingleParam(System.Int32 type, System.Int32 msgId, WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam lanParams); // 0x06f00da0
	System.Void PopMessageWithNoParams(System.Int32 type, System.Int32 msgId); // 0x06f00f78
	System.Void PopItemMessage(System.Int32 msgId, System.Int64 itemId, System.Int32 changeCount, System.Int32 remainCount); // 0x06f01004
	System.Void PopItemMessageSimple(System.Int32 msgId, System.Int64 itemId); // 0x06f012dc
	System.Void PopItemMessageDoubleParam(System.Int32 msgId, System.Int64 itemId, System.Int64 itemId2); // 0x06f0148c
	System.Void InterruptReloadGiveAmmo(System.Int64 bulletId, System.Int32 count); // 0x06f016e0
	System.Void ReloadNotInHand(System.Int64 weaponId, System.Int64 bizId, System.Single time, System.Boolean isBegin); // 0x06f0177c
	System.Void OnNotifyPlayerCorpse(); // 0x06f019cc
	System.Void OnGetMultiPlayerNames(System.Collections.Generic.Dictionary<System.Int64,System.String> result); // 0x06f01a60
	System.Void OnGetPlayerBriefInfo(WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo info); // 0x06f01cb8
	System.Void OnGetMultiPlayerBriefInfo(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo> info); // 0x06f01d6c
	System.Void GetFirePositionAndOffset(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Numerics.Vector3& pos, System.Numerics.Vector3& offset); // 0x06f1f9cc
	System.Void ShowTips(System.Int32 tipId); // 0x06f01e70
	System.Void ShowImportantStageTips(System.Int32 tipId); // 0x06f01f94
	System.Void ShowImportantAchievementTips(System.Int32 tipId); // 0x06f0203c
	System.Void RequestTrackMonumentTask(); // 0x06f020dc
	System.Void GetTerrainHeightAck(System.Int64 seq, System.Single posY); // 0x06f02220
	System.Void TestTeleportMountable(System.Int64 entityId, System.Single posX, System.Single posY, System.Single posZ); // 0x06f022ec
	System.Void EatFoodCallback(System.Int64 foodTableId, System.Int32 randomResult); // 0x06f024a0
	System.Void ChangeLogicFrameTime(System.Int32 frameTime); // 0x06f02a68
	System.Void UpdateProtection(System.Buffers.ReadOnlySequence<System.Byte> sdata); // 0x06f02c50
	System.Void PingCallback(); // 0x06f02ef0
	System.Void OnRepairFiledResources(System.Collections.Generic.Dictionary<System.Int64,System.Int32> items); // 0x06f02f8c
	System.Void ClientHitStatistic(System.Int32 res, System.Int32 hitentity, System.Int64 serverTime); // 0x06f0303c
	System.Void SetSceneConfigByMap(System.Single cameraFarClipPlane); // 0x06f03188
	System.Void OnConsoleCommand(System.Int32 netPeerId, System.String command); // 0x06f03368
	System.Void PartDeployUpgradeOver(System.Int64 partEntityId, System.Int32 info); // 0x06f036dc
	System.Void PartChangeSkinOver(System.Int64 partEntityId, System.Int64 targetSkinId, System.Int32 info); // 0x06f03798
	System.Void PlayLockEffect(System.Int32 effectType, System.Int64 partEntityId); // 0x06f0386c
	System.Void SetFixImportPosOver(System.Single x, System.Single y, System.Single z); // 0x06f038e8
	System.Void PartUpgradeOver(System.Int64 partEntityId, System.Int32 grade); // 0x06f039bc
	System.Void CreatePartAndPlayAudio(System.Int64 partType, System.Single posX, System.Single posY, System.Single posZ, System.Int32 grade); // 0x06f03ab4
	System.Void CreateBlueprintPartsOver(System.Int32 result, System.Int64 param); // 0x06f03ba4
	System.Void CreatePartOver(System.Int32 result, System.Int64 markId, System.Int64 itemUid, System.Int64 templateId, System.String extraInfo, System.Int64 extraParam); // 0x06f03c60
	System.Void DestroyPartGo(System.Int64 partEntityId); // 0x06f03d64
	System.Void PlayKnockDoorAudio(System.Int64 partEntityId, System.Int32 index); // 0x06f03dd8
	System.Void OnPickupPartResult(System.Int32 result); // 0x06f03e84
	System.Void OnDestroyPartResult(System.Int32 result); // 0x06f042bc
	System.Void CreateAndSwitch2ReputationModeOver(System.Int32 result); // 0x06f045ac
	System.Void MoveDeployOver(System.Int64 entityId, System.Int32 result, System.Collections.Generic.List<System.Int64> args); // 0x06f04814
	System.Void HandWeaponReloadFinish(System.Int64 seq); // 0x06f04a6c
	System.Void SyncWeaponData(System.Int64 weaponEntityId, System.Int32 clips, System.Int32 lastAmmoId, System.Int32 usingAmmoId, System.Int64 seq); // 0x06f04bd0
	System.Void ShowPropertiesChange(System.Collections.Generic.List<System.Int32> properties, System.Collections.Generic.List<System.Single> propertiesNums); // 0x06f04e70
	static System.Void ShowGapTip(System.Int32 tipId, System.String param); // 0x06f04f1c
	System.Void GetGlobalTreesAck(System.Boolean isStart, System.Boolean isEnd, System.Buffers.ReadOnlySequence<System.Byte> seq); // 0x06f05350
	System.Void ResetEntityPosRotAndView(System.Int32 poseState, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos, System.Single moveYaw, System.Single viewYaw, System.Single viewPitch); // 0x06f05800
	System.Void SwitchWeapon(System.Int64 itemEntityId); // 0x06f05be4
	System.Void ShowCustomTips(System.Int32 type, System.Int32 time, System.String bgColor, System.String frontColor, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg content); // 0x06f05cb4
	System.String MultiLangStringToString(WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg builder); // 0x06f200e4
	System.String[] MultiLangStringBuilderToServerTipDataContent(WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg builder); // 0x06f1fee4
	System.Void ShowLargePanel(System.String bgColor, System.String titleColor, System.String contentColor, System.Single canCloseTime, System.Single autoCloseTime, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg content); // 0x06f05e0c
	System.Void TurnAirWall(System.Collections.Generic.List<System.Int32> wallId, System.Boolean isOn, System.Boolean isInit); // 0x06f05fc4
	System.Void FindPathCallback(System.Int64 modelId, System.Collections.Generic.List<System.Single> nodeX, System.Collections.Generic.List<System.Single> nodeY, System.Collections.Generic.List<System.Single> nodeZ); // 0x06f061cc
	System.Void OpenMonumentDoorAnim(); // 0x06f062c0
	System.Void OpenBox(System.Int64 boxEntityId); // 0x06f06350
	System.Void ShowCountDown(System.Int64 duration, System.Int64 startTime, System.String timeColor, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title, System.String titleColor); // 0x06f06454
	System.Void ShowTargetHp(System.Int64 targetEntityId, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title); // 0x06f06550
	System.Void ShowCustomMapMark(System.Int64 uniqueId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title); // 0x06f06610
	System.Void NotifyNewbieStageCompleted(); // 0x06f06730
	System.Void NotifyServerKickComingSoon(System.Int32 tipsCode); // 0x06f06954
	System.Void StartReloadLoop(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon, System.Int64 seqID, System.Int32 maxAmmo); // 0x06f201a8
	System.Void ReloadInterrupt(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon); // 0x06f206c4
	System.Void ReloadSetClip(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHaveBulletEntity entity); // 0x06f20a84
	System.Void PickAndDropSound(WizardGames.Soc.Common.SimpleCustom.PickAndDropSuccessEvent pickAndDropEvent); // 0x06f06e0c
	System.Void OnLifeCycleFlagsChange(System.Int32 lifeCycleFlags); // 0x06f07278
	System.Void GetSummarizedDamageRecordsAck(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord> records); // 0x06f073b4
	System.Void IsAnyMonsterInMyMonumentResponse(System.Int32 result, System.Int64 interactiveEntityId); // 0x06f074c4
	System.Void ActiveSafetyBoxResponse(System.Int32 result); // 0x06f078bc
	System.Void CloseSafetyBoxResponse(System.Int32 result); // 0x06f07d50
	System.Void WakeUpActionAck(); // 0x06f080d8
	System.Void Teleport(System.Single x, System.Single y, System.Single z); // 0x06f082d0
	System.Void OnServerTimelineFinish(System.Int64 timelineId); // 0x06f086d4
	System.Void NotifySafetyBoxDestroyed(); // 0x06f08794
	System.Void NotifyTheBattleResult(System.Int64 duration); // 0x06f08834
	System.Void NotifySendGameSummaryToLobbyResult(System.Int32 result); // 0x06f08ad4
	System.Void QuickNearbyChatNotify(System.Int32 textId, System.Int64 senderEntityId); // 0x06f08c70
	System.Void SkipNewbieActionAck(System.Int32 result); // 0x06f08d48
	System.Void DeployVehicleResp(System.Int32 result, System.Int64 itemUid, System.Int64 vehicleId); // 0x06f08ef4
	System.Void NormalInteractCompletedResponse(System.Int32 result); // 0x06f090d0
	System.Void TryInteraction(System.Int32 id); // 0x06f09144
	System.Void OnVendingMachineClosed(); // 0x06f091e8
	System.Void UgcTryPlayGame(); // 0x06f09268
	System.Void UgcRpcResponse(System.Int32 option, System.Int32 result); // 0x06f09370
	System.Void SyncMountableVelocity(System.Int64 mountableId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 velocity, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 angularVelocity); // 0x06f0954c
	System.Boolean CanBeAided(WizardGames.Soc.Common.Entity.PlayerEntity source, System.Boolean beingAided); // 0x06f211c0
	System.Boolean get_CanSelfAid(); // 0x06f21514
	System.Boolean get_InCampingTent(); // 0x06f215b0
	System.Boolean get_ShouldDisableCC(); // 0x06f21620
	System.Boolean get_IsCrawl(); // 0x06f216a0
	System.Boolean get_IsDying(); // 0x06f21794
	System.Int64 get_CurrentWeaponSkinId(); // 0x06f1ce7c
	System.Int32 get_CurrentWeaponType(); // 0x06f21b64
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipHead(); // 0x06f21c4c
	System.Void set_EquipHead(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f21cb0
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipEye(); // 0x06f21d78
	System.Void set_EquipEye(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f21ddc
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipJaw(); // 0x06f21ea4
	System.Void set_EquipJaw(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f21f08
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipUpperArmor(); // 0x06f21fd0
	System.Void set_EquipUpperArmor(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f22034
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipShirt(); // 0x06f220fc
	System.Void set_EquipShirt(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f22160
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipGlove(); // 0x06f22228
	System.Void set_EquipGlove(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f2228c
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipPants(); // 0x06f22354
	System.Void set_EquipPants(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f223b8
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipLowerArmor(); // 0x06f22480
	System.Void set_EquipLowerArmor(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f224e4
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipShoe(); // 0x06f225ac
	System.Void set_EquipShoe(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f22610
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipBag(); // 0x06f226d8
	System.Void set_EquipBag(WizardGames.Soc.Common.Entity.IWearItemEntity value); // 0x06f2273c
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> EnumWearedItem(); // 0x06f22804
	System.Void InitWearedItemsOnCreate(); // 0x06f22868
	static System.Boolean GetHeldItemIndex(System.Int32 arrIndex, WizardGames.Soc.Common.Utility.HoldItemIndex& holdItemIndex); // 0x06f229ec
	System.Boolean get_IsObserverLoading(); // 0x06f22a84
	WizardGames.Soc.Common.Entity.IItemEntity get_Item1(); // 0x06f22b3c
	System.Void set_Item1(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f22bbc
	WizardGames.Soc.Common.Entity.IItemEntity get_Item2(); // 0x06f22c80
	System.Void set_Item2(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f22d00
	WizardGames.Soc.Common.Entity.IItemEntity get_Item3(); // 0x06f22dc4
	System.Void set_Item3(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f22e44
	WizardGames.Soc.Common.Entity.IItemEntity get_Item4(); // 0x06f22f08
	System.Void set_Item4(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f22f88
	WizardGames.Soc.Common.Entity.IItemEntity get_Item5(); // 0x06f2304c
	System.Void set_Item5(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f230cc
	WizardGames.Soc.Common.Entity.IItemEntity get_Item6(); // 0x06f23190
	System.Void set_Item6(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f23210
	WizardGames.Soc.Common.Entity.IItemEntity get_Item7(); // 0x06f232d4
	System.Void set_Item7(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f23354
	WizardGames.Soc.Common.Entity.IItemEntity get_Item8(); // 0x06f23418
	System.Void set_Item8(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f23498
	WizardGames.Soc.Common.Entity.IItemEntity get_ItemHiddenUse(); // 0x06f2355c
	System.Void set_ItemHiddenUse(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f235dc
	WizardGames.Soc.Common.Entity.IItemEntity GetItemModel(WizardGames.Soc.Common.Utility.HoldItemIndex holdItemIndex); // 0x06f236a0
	System.Void SetItemModel(WizardGames.Soc.Common.Utility.HoldItemIndex holdItemIndex, WizardGames.Soc.Common.Entity.IItemEntity value); // 0x06f237e4
	System.Numerics.Vector3 GetEye2PlayerInWorld(System.Single pitch, System.Single yaw, System.Single roll, System.Numerics.Vector3 offset); // 0x06f2395c
	System.Numerics.Vector3 GetEyeWorldPosition(System.Single x, System.Single y, System.Single z, System.Single pitch, System.Single yaw, System.Single roll, System.Numerics.Vector3 offset); // 0x06f23ae8
	System.Void EnterSubAttackState(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PlayerAttackStateEnum state); // 0x06f23c34
	System.Void InitLogicStateParser(); // 0x06f1e10c
	System.Void ReleaseLogicStateParser(); // 0x06f1eb48
	System.Void OnCharacterStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24240
	System.Void OnUnaliveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24450
	System.Void OnMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24534
	System.Void OnMoveJumpStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24618
	System.Void OnMoveLadderStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f246fc
	System.Void OnMoveMantleStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f247e0
	System.Void OnMoveSwimStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f248c4
	System.Void OnMoveZiplineStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f249a8
	System.Void OnPoseStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24a8c
	System.Void OnPoseDyingStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24b70
	System.Void OnActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24c54
	System.Void OnAdsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24d38
	System.Void OnPassiveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24e1c
	System.Void OnInteractiveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06f24f00
	System.Void OnLayerStateChange(System.Type Layer, System.UInt32 value); // 0x06f24324
	System.Void UpdateLogicState(); // 0x06f23e3c
	static System.Int32 ParseStateOffset<T>(System.Collections.Generic.Dictionary<System.Type,System.Tuple<System.Int32,System.UInt64>>& offsetMap, System.Int32 startIndex); // 0x052af1f0
	static System.Int32 GetPO2(System.Int32 value); // 0x06f24fe4
	System.Boolean HeightToGroundAndFallTimeCheck(); // 0x06f25068
	System.Void CheckPlatform(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, UnityEngine.Transform freeCcParent); // 0x06f25354
	System.Void OnReloadEnd(WizardGames.Soc.Common.Entity.IHaveBulletEntity havebullet); // 0x06f2090c
	System.Int32 get_HeldItemSwitchSeq(); // 0x06f25944
	System.Void set_HeldItemSwitchSeq(System.Int32 value); // 0x06f259a8
	System.Void SwitchHeldItem(System.Int64 wantId); // 0x055112ac
	System.Boolean get_IsInInteractive(); // 0x06f2659c
	System.Void ClearInteractive(); // 0x06f2660c
	System.Void SetHeldItemSpeedRate(System.Single rate); // 0x06f26520
	System.Boolean ProhibitJump(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06f26698
	System.Int32 get_WakeUpTimeAcc(); // 0x06f2671c
	System.Void set_WakeUpTimeAcc(System.Int32 value); // 0x06f26780
	System.Boolean get_WakeUpEnd(); // 0x06f267f8
	System.Void set_WakeUpEnd(System.Boolean value); // 0x06f2685c
	System.Single get_WakeUpCameraDelta(); // 0x06f268d8
	System.Void set_WakeUpCameraDelta(System.Single value); // 0x06f2693c
	System.Boolean get_InteractionDisableIK(); // 0x06f269b4
	System.Void set_InteractionDisableIK(System.Boolean value); // 0x06f26a18
	System.Int32 get_CollisionFlags(); // 0x06f26a94
	System.Void set_CollisionFlags(System.Int32 value); // 0x06f26af8
	System.Int32 get_LastMountSeatIndex(); // 0x06f26b70
	System.Void set_LastMountSeatIndex(System.Int32 value); // 0x06f26bd4
	System.Single get_LookTargetOffsetX(); // 0x06f26c4c
	System.Single get_LookTargetOffsetY(); // 0x06f26cb0
	System.Single get_LookTargetOffsetZ(); // 0x06f26d14
	System.Int32 get_ReloadStartTime(); // 0x06f26d78
	System.Void set_ReloadStartTime(System.Int32 value); // 0x06f26ddc
	System.Boolean get_IsStepReload(); // 0x06f26e54
	System.Void set_IsStepReload(System.Boolean value); // 0x06f26eb8
	System.Int64 get_BowWeapon_FireTime(); // 0x06f26f34
	System.Void set_BowWeapon_FireTime(System.Int64 value); // 0x06f26f98
	WizardGames.Soc.Common.Entity.PlayerThrowState get_LocalThrowState(); // 0x06f27010
	System.Void set_LocalThrowState(WizardGames.Soc.Common.Entity.PlayerThrowState value); // 0x06f27074
	System.Boolean get_IsInFire(); // 0x06f270ec
	System.Void set_IsInFire(System.Boolean value); // 0x06f27150
	System.Boolean get_ApplyCameraAnimation(); // 0x06f271cc
	System.Void set_ApplyCameraAnimation(System.Boolean value); // 0x06f27230
	System.Boolean get_NewbieApplyCameraAnimation(); // 0x06f272ac
	System.Void set_NewbieApplyCameraAnimation(System.Boolean value); // 0x06f27310
	System.Boolean get_ApplyCameraAnimationForAim(); // 0x06f2738c
	System.Void set_ApplyCameraAnimationForAim(System.Boolean value); // 0x06f273f0
	System.Byte get_CameraAnimationByte(); // 0x06f2746c
	System.Void set_CameraAnimationByte(System.Byte value); // 0x06f274d0
	System.Int64 get_RebornedTime(); // 0x06f27548
	System.Void set_RebornedTime(System.Int64 value); // 0x06f275ac
	System.Void set_IsReborn(System.Boolean value); // 0x06f27624
	System.Int32 get_LastLifeCycleFlags(); // 0x06f276a0
	System.Void set_LastLifeCycleFlags(System.Int32 value); // 0x06f27704
	System.Boolean get_LastIsWounded(); // 0x06f2777c
	System.Void set_LastIsWounded(System.Boolean value); // 0x06f277e0
	System.Single get_EnterDyingTime(); // 0x06f2785c
	System.Void set_EnterDyingTime(System.Single value); // 0x06f278c0
	System.Boolean get_IsSelfAiding(); // 0x06f27938
	System.Boolean get_IsOtherAiding(); // 0x06f27a08
	System.Boolean get_IsAidingOther(); // 0x06f27ad8
	System.Single[] get_ArmorProtection(); // 0x06f27bbc
	System.Void set_ArmorProtection(System.Single[] value); // 0x06f27c20
	System.Void set_LocalEquipVersion(System.Int32 value); // 0x06f27ca0
	System.Void ForceUpdateEquip(); // 0x06f27d18
	System.Void set_AdsLerpPosition(System.Single value); // 0x06f27e6c
	System.Single get_AdsAnimRawProgress(); // 0x06f27ee4
	System.Void set_AdsAnimRawProgress(System.Single value); // 0x06f27f48
	WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum get_AdsAnimState(); // 0x06f27fc0
	System.Void set_AdsAnimState(WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum value); // 0x06f28024
	System.Void set_AdsAnimStateStartTime(System.Int32 value); // 0x06f2809c
	System.Int32 get_AdsAnimStateStartTime(); // 0x06f28114
	System.Single get_AdsAnimPosition(); // 0x06f28178
	System.Void set_AdsAnimPosition(System.Single value); // 0x06f281dc
	System.Void set_AdsSwitchTime(System.Int64 value); // 0x06f28254
	System.Single get_DefaultSceneFov(); // 0x06f282cc
	System.Void set_DefaultSceneFov(System.Single value); // 0x06f28330
	System.Single get_DefaultVehicleFov(); // 0x06f28868
	System.Void set_DefaultVehicleFov(System.Single value); // 0x06f288cc
	System.Single get_GunFov(); // 0x06f28ae8
	System.Void set_GunFov(System.Single value); // 0x06f28b4c
	System.Int32 get_AdsFovOnTime(); // 0x06f28bc4
	System.Void set_AdsFovOnTime(System.Int32 value); // 0x06f28c28
	System.Int32 get_AdsFovOffTime(); // 0x06f28ca0
	System.Void set_AdsFovOffTime(System.Int32 value); // 0x06f28d04
	System.Int32 get_AdsUpGunFovTime(); // 0x06f28d7c
	System.Void set_AdsUpGunFovTime(System.Int32 value); // 0x06f28de0
	System.Int32 get_AdsDownGunFovTime(); // 0x06f28e58
	System.Void set_AdsDownGunFovTime(System.Int32 value); // 0x06f28ebc
	System.Int32 get_AdsUpAniTime(); // 0x06f28f34
	System.Void set_AdsUpAniTime(System.Int32 value); // 0x06f28f98
	System.Int32 get_AdsDownAniTime(); // 0x06f29010
	System.Void set_AdsDownAniTime(System.Int32 value); // 0x06f29074
	System.Boolean get_bLocalPlayer(); // 0x06f290ec
	System.Void set_bLocalPlayer(System.Boolean value); // 0x06f29150
	System.Boolean get_IsAttachedToMgr(); // 0x06f291cc
	System.Boolean get_IsAutoFire(); // 0x06f2927c
	System.Void set_IsAutoFire(System.Boolean value); // 0x06f292e0
	System.Boolean get_CanAutoFire(); // 0x06f2935c
	System.Void set_CanAutoFire(System.Boolean value); // 0x06f293c0
	System.Int64 get_PoorOxygenTime(); // 0x06f2943c
	System.Void set_PoorOxygenTime(System.Int64 value); // 0x06f294a0
	System.Single get_SensitivityDefault(); // 0x06f29518
	System.Void set_SensitivityDefault(System.Single value); // 0x06f2957c
	System.Int32 get_LastRadiationIntensity(); // 0x06f295f4
	System.Void set_LastRadiationIntensity(System.Int32 value); // 0x06f29658
	System.Int32 get_SelectMantleOnIndex(); // 0x06f296d0
	System.Void set_SelectMantleOnIndex(System.Int32 value); // 0x06f29734
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum get_StartLadderState(); // 0x06f297ac
	System.Void set_StartLadderState(WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum value); // 0x06f29810
	WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum get_StartMantleState(); // 0x06f29888
	System.Void set_StartMantleState(WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum value); // 0x06f298ec
	System.Boolean get_MantleInPlatform(); // 0x06f29964
	System.Void set_MantleInPlatform(System.Boolean value); // 0x06f299c8
	System.Single get_MantleInPlatformStartX(); // 0x06f29a44
	System.Void set_MantleInPlatformStartX(System.Single value); // 0x06f29aa8
	System.Single get_MantleInPlatformStartY(); // 0x06f29b20
	System.Void set_MantleInPlatformStartY(System.Single value); // 0x06f29b84
	System.Single get_MantleInPlatformStartZ(); // 0x06f29bfc
	System.Void set_MantleInPlatformStartZ(System.Single value); // 0x06f29c60
	System.Int32 get_OfflineSafeAreaIndex(); // 0x06f29cd8
	System.Single get_PunchRoll(); // 0x06f29d3c
	System.Void set_PunchRoll(System.Single value); // 0x06f29da0
	System.Single get_GunSwayPitch(); // 0x06f29e18
	System.Void set_GunSwayPitch(System.Single value); // 0x06f29e7c
	System.Single get_GunSwayYaw(); // 0x06f29ef4
	System.Void set_GunSwayYaw(System.Single value); // 0x06f29f58
	System.Void set_DecayTime(System.Single value); // 0x06f29fd0
	System.Boolean get_FireToggle(); // 0x06f2a048
	System.Void set_FireToggle(System.Boolean value); // 0x06f2a0ac
	System.Boolean get_ThrowToggle(); // 0x06f2a128
	System.Void set_ThrowToggle(System.Boolean value); // 0x06f2a18c
	UnityEngine.Vector3 get_LockShootPitchYawOffset(); // 0x06f2a208
	System.Void set_LockShootPitchYawOffset(UnityEngine.Vector3 value); // 0x06f2a270
	System.Int64 get_TemplateId(); // 0x06f2a30c
	System.Boolean get_lastIsHostile(); // 0x06f2a370
	System.Void set_lastIsHostile(System.Boolean value); // 0x06f2a3d4
	System.Int64 get_lastHostileStartTime(); // 0x06f2a450
	System.Void set_lastHostileStartTime(System.Int64 value); // 0x06f2a4b4
	System.Int64 get_lastHostileEndTime(); // 0x06f2a52c
	System.Void set_lastHostileEndTime(System.Int64 value); // 0x06f2a590
	System.Int32 get_lastSafetyState(); // 0x06f2a608
	System.Void set_lastSafetyState(System.Int32 value); // 0x06f2a66c
	System.Boolean get_IsInAir(); // 0x06f2a6e4
	System.Void set_IsInAir(System.Boolean value); // 0x06f2a748
	System.Boolean get_teleport(); // 0x06f2a7c4
	System.Void set_teleport(System.Boolean value); // 0x06f2a828
	System.Single get_DrawScale(); // 0x06f2a8a4
	System.Void set_DrawScale(System.Single value); // 0x06f2a908
	System.Single get_FireScale(); // 0x06f2a980
	System.Void set_FireScale(System.Single value); // 0x06f2a9e4
	System.Void set_FireHitScale(System.Single value); // 0x06f2aa5c
	System.Void set_AltFireScale(System.Single value); // 0x06f2aad4
	System.Void set_AltFireHitScale(System.Single value); // 0x06f2ab4c
	System.Single get_ReloadEndScale(); // 0x06f2abc4
	System.Void set_ReloadEndScale(System.Single value); // 0x06f2ac28
	System.Void set_InspectScale(System.Single value); // 0x06f2aca0
	System.Single get_ReloadStartScale(); // 0x06f2ad18
	System.Void set_ReloadStartScale(System.Single value); // 0x06f2ad7c
	System.Single get_ReloadScale(); // 0x06f2adf4
	System.Void set_ReloadScale(System.Single value); // 0x06f2ae58
	System.Single get_AdsOnScale(); // 0x06f2aed0
	System.Void set_AdsOnScale(System.Single value); // 0x06f2af34
	System.Single get_AdsOffScale(); // 0x06f2afac
	System.Void set_AdsOffScale(System.Single value); // 0x06f2b010
	System.Single get_BowChargeScale(); // 0x06f2b088
	System.Void set_BowChargeScale(System.Single value); // 0x06f2b0ec
	System.Single get_BowCancelChargeScale(); // 0x06f2b164
	System.Void set_BowCancelChargeScale(System.Single value); // 0x06f2b1c8
	System.Void set_ChainSawStartUpScale(System.Single value); // 0x06f2b240
	System.Single get_BoltScale(); // 0x06f2b2b8
	System.Void set_BoltScale(System.Single value); // 0x06f2b31c
	System.Boolean get_WantCrouchPose(); // 0x06f2b394
	System.Void set_WantCrouchPose(System.Boolean value); // 0x06f2b3f8
	System.Int32 get_SwimPosType(); // 0x06f2b474
	System.Void set_SwimPosType(System.Int32 value); // 0x06f2b4d8
	System.Boolean get_IsCrouch(); // 0x06f1fe70
	System.Int64 get_HistoryWeaponId(); // 0x054a4380
	System.Void set_HistoryWeaponId(System.Int64 value); // 0x055112ac
	System.Int32 get_StateTime(); // 0x0548ba98
	System.Void set_StateTime(System.Int32 value); // 0x055056e8
	System.Int32 get_ShootingRecoverySprintDelay(); // 0x0548ba98
	System.Void set_ShootingRecoverySprintDelay(System.Int32 value); // 0x055056e8
	System.Int32 get_ShootingRecoverySprintIgnored(); // 0x0548ba98
	System.Void set_ShootingRecoverySprintIgnored(System.Int32 value); // 0x055056e8
	System.Int32 get_ActionStateNowTime(); // 0x06f2b8c0
	System.Int32 get_AnimatorStateTime(); // 0x0548ba98
	System.Void set_AnimatorStateTime(System.Int32 value); // 0x055056e8
	System.Int32 get_CommonStateTime(); // 0x0548ba98
	System.Void set_CommonStateTime(System.Int32 value); // 0x055056e8
	System.Int32 get_CommonRecoveryStateTime(); // 0x0548ba98
	System.Void set_CommonRecoveryStateTime(System.Int32 value); // 0x055056e8
	System.Void PlayInteractiveAnim(System.Int32 layer, System.Int32 typeInt, System.Int32 NameId, System.Single scale, System.Single BlendTime, System.Single Offset); // 0x05505db4
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Entity.PlayerEntity.TempInfo> get_TempPos(); // 0x054e7844
	System.Void AddTempPos(System.Numerics.Vector3 pos, System.Int64 sequence, System.Numerics.Vector3 cmdPos, System.Int32 step); // 0x06f2be78
	System.Boolean TestNullHand(System.Int64 testId); // 0x06f2c098
	System.Boolean get_IsNullHand(); // 0x06f2c12c
	System.Boolean get_IsInMonument(); // 0x06f2c19c
	System.Boolean get_IsWalkableGround(); // 0x054c4760
	System.Void set_IsWalkableGround(System.Boolean value); // 0x05523a7c
	System.Boolean get_UseExtraDraw(); // 0x054c4760
	System.Void set_UseExtraDraw(System.Boolean value); // 0x05523a7c
	System.Int32 GetShortcutsIndexOfEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f2c3cc
	System.Boolean get_IsOnMount(); // 0x06f2c7f0
	System.Boolean get_IsMountDriver(); // 0x06f2c860
	System.Boolean get_IsMountPassenger(); // 0x06f2c8e0
	System.Boolean get_IsOnHorse(); // 0x06f2c964
	System.Boolean get_IsHorseDriver(); // 0x06f2c9e8
	System.Boolean get_IsDrivingKayak(); // 0x06f2ca6c
	System.Boolean get_IsDrivingParachute(); // 0x06f2caf0
	System.Boolean get_CanOperateMount(); // 0x06f2cb74
	System.Boolean get_IsWearingLightableHat(); // 0x06f2cbf8
	System.Int64 get_NereastWorkbenchID(); // 0x054a4380
	System.Void set_NereastWorkbenchID(System.Int64 value); // 0x055112ac
	WizardGames.Soc.Common.Entity.IWearItemEntity get_DivingTank(); // 0x06f2cdb8
	System.Int64 get_CurrentFocusedEntityId(); // 0x054a4380
	System.Void set_CurrentFocusedEntityId(System.Int64 value); // 0x055112ac
	System.Boolean get_LastIsDriver(); // 0x054c4760
	System.Void set_LastIsDriver(System.Boolean value); // 0x05523a7c
	System.Int64 get_LastMountableId(); // 0x054a4380
	System.Void set_LastMountableId(System.Int64 value); // 0x055112ac
	System.Int32 get_LastVehicleType(); // 0x0548ba98
	System.Void set_LastVehicleType(System.Int32 value); // 0x055056e8
	System.Action<WizardGames.Soc.Common.Entity.IHeldItemEntity,System.Single> get_ShowUseLoading(); // 0x054e7844
	System.Void set_ShowUseLoading(System.Action<WizardGames.Soc.Common.Entity.IHeldItemEntity,System.Single> value); // 0x05523a54
	System.Action<System.Int64> get_HideUseLoading(); // 0x054e7844
	System.Void set_HideUseLoading(System.Action<System.Int64> value); // 0x05523a54
	System.Single get_bagReloadDoneTime(); // 0x054a5abc
	System.Void set_bagReloadDoneTime(System.Single value); // 0x05513724
	System.Boolean get_bagReloadCanInterrupt(); // 0x054c4760
	System.Void set_bagReloadCanInterrupt(System.Boolean value); // 0x05523a7c
	System.Int64 get_bagReloadWeaponId(); // 0x054a4380
	System.Void set_bagReloadWeaponId(System.Int64 value); // 0x055112ac
	System.Boolean get_HasEnterPoseState(); // 0x054c4760
	System.Void set_HasEnterPoseState(System.Boolean value); // 0x05523a7c
	System.Void set_IsFirstInVehicleCameraUpdate(System.Boolean value); // 0x05523a7c
	System.Single get_WaterHeight(); // 0x054a5abc
	System.Void set_WaterHeight(System.Single value); // 0x05513724
	System.Single get_NightVisionLightIntensity(); // 0x054a5abc
	System.Void set_NightVisionLightIntensity(System.Single value); // 0x05513724
	System.Single get_AnimLayerFpWeight(); // 0x054a5abc
	System.Void set_AnimLayerFpWeight(System.Single value); // 0x05513724
	System.Void RefreshWearProtection(); // 0x06f2da7c
	System.Void SetBagReload(System.Int64 weaponId, System.Single doneTime, System.Boolean canInterrupt); // 0x06f1f7d8
	System.Void ClearBagReload(); // 0x06f1f95c
	System.Void CaculateBaseProtection(); // 0x06f2e238
	System.Single GetSpeedMultiplier(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06f2e434
	System.Void ClearClientLadderCache(); // 0x06f2e538
	System.Int64 get_RealNearbyRebornValidTime(); // 0x06f2e5a8
	System.Boolean get_IsNearbyRebornValid(); // 0x06f2e654
	System.Boolean get_IsOutpostRebornValid(); // 0x06f2e6f4
	System.Void SetId(System.Int64 id); // 0x06f1f254
	System.Boolean get_InAttackState(); // 0x06f2e794
	System.Void OnFovUpdate(); // 0x06f286e8
	System.Void OnVehicleFovUpdate(); // 0x06f2896c
	System.Single ClampFov(System.Single val, System.String key); // 0x06f283d0
	System.Single get_LastChangeBoltAdsTime(); // 0x054a5abc
	System.Void set_LastChangeBoltAdsTime(System.Single value); // 0x05513724
	System.Boolean get_CanChangeBolt(); // 0x054c4760
	System.Void set_CanChangeBolt(System.Boolean value); // 0x05523a7c
	System.Single get_Sprint2JogTime(); // 0x054a5abc
	System.Void set_Sprint2JogTime(System.Single value); // 0x05513724
	System.Single get_Jog2SprintTime(); // 0x054a5abc
	System.Void set_Jog2SprintTime(System.Single value); // 0x05513724
	System.Int32 get_Anim_CurParachuteState(); // 0x0548ba98
	System.Boolean get_ForceParachuteEnd(); // 0x054c4760
	System.Void set_ForceParachuteEnd(System.Boolean value); // 0x05523a7c
	System.Numerics.Vector3 get_FpJogPosVector3(); // 0x054b1148
	System.Void set_FpJogPosVector3(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_FpJogRotVector3(); // 0x054b1148
	System.Void set_FpJogRotVector3(System.Numerics.Vector3 value); // 0x05514688
	System.Single get_LerpStandCrouch(); // 0x054a5abc
	System.Void set_LerpStandCrouch(System.Single value); // 0x05513724
	System.Single get_LastFp_adsboltWeightCurve(); // 0x054a5abc
	System.Void set_LastFp_adsboltWeightCurve(System.Single value); // 0x05513724
	System.Single get_LastFp_adsboltAutoCurve(); // 0x054a5abc
	System.Void set_LastFp_adsboltAutoCurve(System.Single value); // 0x05513724
	System.Single get_LastFp_boltWeightCurve(); // 0x054a5abc
	System.Void set_LastFp_boltWeightCurve(System.Single value); // 0x05513724
	System.Single get_LastFp_boltAutoCurve(); // 0x054a5abc
	System.Void set_LastFp_boltAutoCurve(System.Single value); // 0x05513724
	System.Void set_TpCameraBlocked(System.Single value); // 0x05513724
	System.Single get_TpOffsetYaw(); // 0x054a5abc
	System.Void set_TpOffsetYaw(System.Single value); // 0x05513724
	System.Numerics.Vector3 get_FpPositionOffset(); // 0x054b1148
	System.Void set_FpPositionOffset(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_FpRotationOffset(); // 0x054b1148
	System.Void set_FpRotationOffset(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DMantlePos(); // 0x054b1148
	System.Void set_DMantlePos(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DMantleDataStartPos(); // 0x054b1148
	System.Void set_DMantleDataStartPos(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DMantleDataEndPos(); // 0x054b1148
	System.Void set_DMantleDataEndPos(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DLastCcPos(); // 0x054b1148
	System.Void set_DLastCcPos(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DNowCcPos(); // 0x054b1148
	System.Void set_DNowCcPos(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_DMoveSpeed(); // 0x054b1148
	System.Void set_DMoveSpeed(System.Numerics.Vector3 value); // 0x05514688
	System.Int32 get_DUseCmdPosCondition(); // 0x0548ba98
	System.Int64 get_DPlatformId(); // 0x054a4380
	System.Void set_DPlatformId(System.Int64 value); // 0x055112ac
	System.Void InitAnim(); // 0x06f1a95c
	WizardGames.Soc.Common.Entity.IItemEntity GetItemEntity(System.Int32 id); // 0x06f2fdf8
	WizardGames.Soc.Common.Component.PlayerDebugComponent get_DebugComp(); // 0x06f2fe9c
	WizardGames.Soc.Common.Component.PlayerKOLComponent get_KOLComp(); // 0x06f2ff1c
	System.Boolean get_KOLOrDebugEnable(); // 0x06f2ff9c
	WizardGames.Soc.Common.Component.PlayerConstructionComponent get_ConstructionComp(); // 0x06f30020
	WizardGames.Soc.Common.Component.PlayerSafeOfflineComponent get_SafeOfflineComp(); // 0x06f300a0
	System.UInt64 get_RoleId(); // 0x06f1ab94
	System.Boolean get_IsOffline(); // 0x06f30120
	System.Boolean IsEquipEnable(System.Int32 position); // 0x06f30190
	System.Boolean get_IsWounded(); // 0x06f21434
	System.Boolean get_IsIncapacitated(); // 0x06f21724
	System.Boolean get_IsDead(); // 0x06f213c4
	System.Boolean get_HasDieFlag(); // 0x06f30218
	System.Boolean get_IsAlive(); // 0x06f302c8
	System.Boolean get_WasAided(); // 0x06f214a4
	WizardGames.Soc.Common.CustomType.MeleeCustom get_NullHand(); // 0x06f263d4
	System.Void set_NullHand(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x06f30338
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetBeltItem(System.Int64 current); // 0x06f303b4
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldItemByEntityId(System.Int64 entityId); // 0x06f21804
	System.Int64 get_CurrentWeaponTableId(); // 0x06f26438
	System.Void SetEquipEnableFlag(System.Int32 position, System.Boolean enable); // 0x06f305f4
	System.Single get_Hp(); // 0x06f30694
	System.Single get_MaxHp(); // 0x06f306f8
	static System.Void .cctor(); // 0x06f3075c
	System.Void <Init>b__1122_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Boolean old, System.Boolean newValue); // 0x06f344dc
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.PlayerEntity.InteractiveAnimInfo : System.ValueType
{
	System.Int32 Layer; // 0x10
	System.Int32 TypeInt; // 0x14
	System.Int32 NameId; // 0x18
	System.Single Scale; // 0x1c
	System.Single BlendTime; // 0x20
	System.Single Offset; // 0x24
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.PlayerEntity.TempInfo : System.ValueType
{
	System.Numerics.Vector3 pos; // 0x10
	System.Int64 sequence; // 0x20
	System.Numerics.Vector3 CmdPos; // 0x28
	System.Int32 step; // 0x34
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PlayerEntity.<>c : System.Object
{
	static WizardGames.Soc.Common.Entity.PlayerEntity.<>c <>9; // 0x0
	static System.Action <>9__1139_0; // 0x8
	static System.Action <>9__1139_1; // 0x10
	static System.Action <>9__1171_1; // 0x18
	static System.Action <>9__1171_0; // 0x20
	static System.Action <>9__1219_0; // 0x28
	static System.Action <>9__1220_0; // 0x30
	static System.Action <>9__1239_0; // 0x38
	static System.Action <>9__1240_0; // 0x40
	static System.Void .cctor(); // 0x06f489b8
	System.Void .ctor(); // 0x06f48a1c
	System.Void <LoadingSuccessAck>b__1139_0(); // 0x06f48a84
	System.Void <LoadingSuccessAck>b__1139_1(); // 0x06f48b20
	System.Void <ShowDismountFailWindow>b__1171_0(); // 0x06f48bd8
	System.Void <ShowDismountFailWindow>b__1171_1(); // 0x06f49024
	System.Void <HandWeaponReloadFinish>b__1219_0(); // 0x06f490d0
	System.Void <SyncWeaponData>b__1220_0(); // 0x06f49170
	System.Void <NotifyNewbieStageCompleted>b__1239_0(); // 0x06f49210
	System.Void <NotifyServerKickComingSoon>b__1240_0(); // 0x06f492b8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PlayerEntity.<>c__DisplayClass1248_0 : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity <>4__this; // 0x10
	System.Int64 interactiveEntityId; // 0x18
	System.Void .ctor(); // 0x06f49360
	System.Void <IsAnyMonsterInMyMonumentResponse>b__0(); // 0x06f493c8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PlunderReportEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 538825849;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f4944c
	System.String GetTypeName(); // 0x06f494b4
	System.Int32 get_EntityType(); // 0x06f4952c
	System.Void .ctor(); // 0x06f49590
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f49620
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f496d0
	static System.Object DeserializePlunderReportEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f49780
	static System.Void .cctor(); // 0x06f49850
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.RecordCheckEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 525836143;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f499a8
	System.String GetTypeName(); // 0x06f49a10
	System.Int32 get_EntityType(); // 0x06f49a88
	System.Void .ctor(); // 0x06f49aec
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f49b7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f49c2c
	static System.Object DeserializeRecordCheckEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f49cdc
	static System.Void .cctor(); // 0x06f49e00
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.RpcEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 2094208211;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.RpcEntity <Instance>k__BackingField; // 0x10
	static System.Int64 lastPhotoTime; // 0x18
	System.Int64 reportTimeTimerId; // 0x60
	System.Boolean IsLoadingSucess; // 0x68
	System.Boolean startLoadingDone; // 0x69
	System.Int32 GetClassHash(); // 0x06f49f58
	System.String GetTypeName(); // 0x06f49fc0
	System.Int32 get_EntityType(); // 0x06f4a038
	System.Void .ctor(); // 0x06f4a09c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f4a12c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f4a1dc
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06f4a28c
	System.Void RemoteCallRemoteConsoleReply(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 consoleClientId, System.String reply); // 0x06f3a378
	System.Void RemoteCallReportEntityRecord(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.Queue<WizardGames.Soc.Common.CustomType.EntityRecord> records); // 0x06f4ef5c
	System.Void RemoteCallLoginReq(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String token, System.String roleIdStr, System.Int32 deviceLevel, WizardGames.Soc.Common.SimpleCustom.LoginInfo loginInfo); // 0x06f4f0e8
	System.Void RemoteCallTestLogin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId, System.Boolean isRobot, WizardGames.Soc.Common.SimpleCustom.LoginInfo loginInfo); // 0x06f4f2b8
	System.Void RemoteCallClientSyncTime(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 peerLocalTime); // 0x06f4f474
	System.Void RemoteCallClientReportTime(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 peerLocalTimeMs); // 0x06f4f600
	System.Void RemoteCallLoadingSuccess(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f4f78c
	System.Void RemoteCallLogout(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f4f8f8
	System.Void RemoteCallObserverLoadingSuccess(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f4fa64
	System.Void RemoteCallCancelQueue(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06f4fbd0
	System.Void RemoteCallTrackMonumentTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 taskGroupID, System.Int32 taskID); // 0x06f4fd3c
	System.Void RemoteCallRequestMonumentTaskState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> taskGroupIds); // 0x06f4fee0
	System.Void RemoteCallSubscriptionMonumentTasksGroup(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> taskGroupIds); // 0x06f5006c
	System.Void RemoteCallUnSubscriptionMonumentTasksGroup(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> taskGroupIds); // 0x06f501f8
	System.Void RemoteCallUnityDsAutoTurretRotateDone(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int32 curTransitionState); // 0x06f50384
	System.Void RemoteCallClientVehicleCollisionDamage(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 targetVehicleEntityId, System.Single damage); // 0x06f50528
	System.Void RemoteCallClientHelicopterDelayedImpactDamage(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 targetVehicleEntityId, System.Single damage); // 0x06f506cc
	static WizardGames.Soc.Common.Entity.RpcEntity get_Instance(); // 0x06f50870
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.RpcEntity value); // 0x06f508f8
	System.Boolean get_PerserveWhenReconnect(); // 0x06f5098c
	static System.Void InitInstance(); // 0x06f509f0
	System.Void .ctor(System.Int64 id); // 0x06f50b14
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f50d7c
	System.Void OnWorldChat(WizardGames.Soc.Common.CustomType.ChatMessageWithInfo msg); // 0x06f4adec
	System.Void RemoveWorldChatForRoleId(System.UInt64 roleId); // 0x06f4ae8c
	System.Void NotifyServerChangeTime(System.Int64 ms); // 0x06f4af40
	System.Void NotifyPopMessageWithSingleParam(WizardGames.Soc.Common.SimpleCustom.EPopType type, System.Int32 msgId, WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam lanParams); // 0x06f4b154
	System.Void NotifyPopMessageWithNoParams(WizardGames.Soc.Common.SimpleCustom.EPopType type, System.Int32 msgId); // 0x06f4b238
	System.Void NotifyShowShortTriggerTip(System.Int32 msgId, System.Collections.Generic.List<System.String> param); // 0x06f4b304
	System.Void GetOneTerritoryOutside(); // 0x06f50e9c
	System.Void GetOneTerritoryOutsideAck(System.Int64 entityId, System.String roleId, System.String roles, System.Buffers.ReadOnlySequence<System.Byte> seq); // 0x06f4b49c
	System.Void NoTerritoryOutside(); // 0x06f4b53c
	static System.Void PlayGMRemovePartAlert(System.Int64 userId, System.Int32 type); // 0x06f4b59c
	static System.Void ShowCountDown(System.Int64 duration, System.Int64 startTime, System.String timeColor, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder title, System.String titleColor); // 0x06f4b728
	System.Void OnMarqueeNotify(System.String content, System.Int32 priority, System.Int32 repeat); // 0x06f4b860
	System.Void RefreshExcelClient(System.Collections.Generic.Dictionary<System.String,System.String> data, System.Collections.Generic.Dictionary<System.String,System.String> play); // 0x06f4ba70
	System.Void ServerLoadingDone(); // 0x06f4bea0
	System.Void OnEnterQueue(System.Int32 pos); // 0x06f4bfbc
	System.Void UpdateQueuePosition(System.Int32 pos); // 0x06f4c1a0
	System.Void LoginNak(System.Boolean rpcMatch, System.Boolean rpcCustomTypeMatch, System.Boolean entityMatch, System.Boolean resourceVersionMatch); // 0x06f4c384
	System.Void LoginVersionMismatch(System.Boolean rpcMatch, System.Boolean rpcCustomTypeMatch, System.Boolean entityMatch, System.Int32 serverRpcVer, System.Int32 serverRpcCustomTypeVer, System.Int32 serverCollectionVer); // 0x06f4cd58
	System.Void DevVersionMismatchDetail(System.Buffers.ReadOnlySequence<System.Byte> entityDetail); // 0x06f4d07c
	System.Void LoginAck(WizardGames.Soc.Common.SimpleCustom.LoginResult result); // 0x06f4d8a8
	System.Void ClientSyncTimeAck(WizardGames.Soc.Common.SimpleCustom.ClientSyncTimeData syncData); // 0x06f4e1cc
	System.Void ReportTime(System.Int64 timerId); // 0x06f50f7c
	System.Void StopReportTimer(); // 0x06f50efc
	System.Void StartLoading(WizardGames.Soc.Common.SimpleCustom.LoginBaseInfo baseInfo); // 0x06f4e590
	System.Void UpdateClientTable(System.String jsonDataStr); // 0x06f4ea24
	System.Void UpdateClientTableByIndex(SimpleJSON.JSONNode tableUpdaloadJson, System.String index); // 0x06f51028
	static System.Void .cctor(); // 0x06f51308
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.RpcEntity.<>c : System.Object
{
	static WizardGames.Soc.Common.Entity.RpcEntity.<>c <>9; // 0x0
	static System.Action <>9__71_0; // 0x8
	static System.Action <>9__71_1; // 0x10
	static System.Action <>9__74_0; // 0x18
	static System.Void .cctor(); // 0x06f513d4
	System.Void .ctor(); // 0x06f51438
	System.Void <LoginNak>b__71_0(); // 0x06f514a0
	System.Void <LoginNak>b__71_1(); // 0x06f51528
	System.Void <LoginAck>b__74_0(); // 0x06f51798
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.RuleGraphDebugEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 218066857;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static System.Action<System.Int64> NodeStartEvent; // 0x10
	static System.Action<System.Int64> NodeStopEvent; // 0x18
	static System.Action<System.Int64,System.String> NodeFailEvent; // 0x20
	System.Int32 GetClassHash(); // 0x06f51930
	System.String GetTypeName(); // 0x06f51998
	System.Int32 get_EntityType(); // 0x06f51a10
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f51a74
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f51b6c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.GraphDebugInfo> get_DebugInfos(); // 0x06f51c1c
	System.Void set_DebugInfos(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.GraphDebugInfo> value); // 0x06f51cbc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06f51d48
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f51ea8
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06f521c8
	static System.Object DeserializeRuleGraphDebugEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f529c4
	static System.Void OnAddDebugEntitySuccess(); // 0x06f52624
	static System.Void OnStartGraph(System.Int64 graphId, System.Int64 graphInstanceId); // 0x06f526b0
	static System.Void OnStopGraph(System.Int64 graphId, System.Int64 graphInstanceId); // 0x06f52724
	static System.Void OnStartNode(System.Int64 nodeId); // 0x06f52798
	static System.Void OnStopNode(System.Int64 nodeId); // 0x06f52848
	static System.Void OnFailNode(System.Int64 nodeId, System.String errMsg); // 0x06f528f8
	static System.Void .cctor(); // 0x06f52a94
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SafetyBoxEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 616878803;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f52b84
	System.String GetTypeName(); // 0x06f52bec
	System.Int32 get_EntityType(); // 0x06f52c64
	System.Void .ctor(); // 0x06f52cc8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f52d58
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f52e08
	System.Int64 get_TemplateId(); // 0x06f52eb8
	System.Int64 get_TerritoryCabinetId(); // 0x06f52f2c
	System.Int32 get_State(); // 0x06f52fa0
	System.Void Init(); // 0x06f53014
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f5317c
	System.Void OnSafetyBoxEntityStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06f532b8
	static System.Void .cctor(); // 0x06f53388
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SceneItemEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IPrivateEntity, WizardGames.Soc.Common.Entity.IAttachedEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 108326598;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <MountID>k__BackingField; // 0x78
	UnityEngine.Transform <AttachedTransform>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06f53514
	System.String GetTypeName(); // 0x06f5357c
	System.Int32 get_EntityType(); // 0x06f535f4
	System.Void .ctor(); // 0x06f53658
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f536e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f53798
	System.Single get_PosX(); // 0x06f53848
	System.Void set_PosX(System.Single value); // 0x06f538bc
	System.Single get_PosY(); // 0x06f53948
	System.Void set_PosY(System.Single value); // 0x06f539bc
	System.Single get_PosZ(); // 0x06f53a48
	System.Void set_PosZ(System.Single value); // 0x06f53abc
	System.Single get_RotateX(); // 0x06f53b48
	System.Void set_RotateX(System.Single value); // 0x06f53bbc
	System.Single get_RotateY(); // 0x06f53c48
	System.Void set_RotateY(System.Single value); // 0x06f53cbc
	System.Single get_RotateZ(); // 0x06f53d48
	System.Void set_RotateZ(System.Single value); // 0x06f53dbc
	System.Int64 get_TemplateId(); // 0x06f53e48
	System.Int32 get_SpawnType(); // 0x06f53ebc
	System.Int64 get_TargetEntityID(); // 0x06f53f30
	System.Void set_TargetEntityID(System.Int64 value); // 0x06f53fa4
	System.Int32 get_TargetColliderIndex(); // 0x06f54030
	System.Void set_TargetColliderIndex(System.Int32 value); // 0x06f540a4
	System.Single get_PosOffsetX(); // 0x06f54130
	System.Void set_PosOffsetX(System.Single value); // 0x06f541a4
	System.Single get_PosOffsetY(); // 0x06f54230
	System.Void set_PosOffsetY(System.Single value); // 0x06f542a4
	System.Single get_PosOffsetZ(); // 0x06f54330
	System.Void set_PosOffsetZ(System.Single value); // 0x06f543a4
	System.Single get_RotOffsetX(); // 0x06f54430
	System.Void set_RotOffsetX(System.Single value); // 0x06f544a4
	System.Single get_RotOffsetY(); // 0x06f54530
	System.Void set_RotOffsetY(System.Single value); // 0x06f545a4
	System.Single get_RotOffsetZ(); // 0x06f54630
	System.Void set_RotOffsetZ(System.Single value); // 0x06f546a4
	System.Single get_RotOffsetW(); // 0x06f54730
	System.Void set_RotOffsetW(System.Single value); // 0x06f547a4
	System.Boolean get_IsMeleeThrow(); // 0x06f54830
	System.Boolean get_IsAttached(); // 0x06f548a4
	System.Int64 get_SkinId(); // 0x06f54918
	System.Boolean get_IsThrow(); // 0x06f5498c
	System.Int64 get_BelongPlayerEntityId(); // 0x06f54a00
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f54a74
	System.Single get_PosX_Smooth(); // 0x06f54af4
	System.Void set_PosX_Smooth(System.Single value); // 0x06f54b58
	System.Single get_PosY_Smooth(); // 0x06f54bd0
	System.Void set_PosY_Smooth(System.Single value); // 0x06f54c34
	System.Single get_PosZ_Smooth(); // 0x06f54cac
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f54d10
	System.Single get_RotateX_Smooth(); // 0x06f54d88
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f54dec
	System.Single get_RotateY_Smooth(); // 0x06f54e64
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f54ec8
	System.Single get_RotateZ_Smooth(); // 0x06f54f40
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f54fa4
	System.Int64 get_ParentId(); // 0x06f5501c
	System.Int64 get_MountID(); // 0x06f55080
	System.Boolean get_HasLocalRotation(); // 0x06f550e4
	System.Void set_AttachedTransform(UnityEngine.Transform value); // 0x06f55148
	System.Void Init(); // 0x06f551c8
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f55268
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f5532c
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f5541c
	System.Boolean get_Attaching(); // 0x06f554d4
	System.String ToPrettyString(); // 0x06f55544
	static System.Void .cctor(); // 0x06f5581c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ServerInstanceEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 38;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f560c8
	System.String GetTypeName(); // 0x06f5612c
	System.Int32 get_EntityType(); // 0x06f561a4
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f56208
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f562b8
	static System.Object DeserializeServerInstanceEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f56368
	static System.Void .cctor(); // 0x06f56620
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ShopControlEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 1057929691;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.ShopControlEntity <Instance>k__BackingField; // 0x10
	System.Int32 GetClassHash(); // 0x06f56c88
	System.String GetTypeName(); // 0x06f56cf0
	System.Int32 get_EntityType(); // 0x06f56d68
	System.Void .ctor(); // 0x06f56dcc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f56e5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f56f54
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ShopInfo> get_Shops(); // 0x06f57004
	System.Void set_Shops(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ShopInfo> value); // 0x06f570a4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06f57130
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f57290
	static System.Object DeserializeShopControlEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f575b0
	static WizardGames.Soc.Common.Entity.ShopControlEntity get_Instance(); // 0x06f57680
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.ShopControlEntity value); // 0x06f57708
	System.Void PostInit(); // 0x06f5779c
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f57964
	static System.Void .cctor(); // 0x06f57b2c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ShopEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 196307822;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Data.spawn.PatrolGroup _patrolGroup; // 0x60
	UnityEngine.Matrix4x4 MatrixOffset; // 0x68
	System.Single <PosX_Smooth>k__BackingField; // 0xa8
	System.Single <PosY_Smooth>k__BackingField; // 0xac
	System.Single <PosZ_Smooth>k__BackingField; // 0xb0
	System.Single <RotateX_Smooth>k__BackingField; // 0xb4
	System.Single <RotateY_Smooth>k__BackingField; // 0xb8
	System.Single <RotateZ_Smooth>k__BackingField; // 0xbc
	System.Int64 <ParentId>k__BackingField; // 0xc0
	System.Int64 <MountID>k__BackingField; // 0xc8
	System.Int32 GetClassHash(); // 0x06f57c50
	System.String GetTypeName(); // 0x06f57cb8
	System.Int32 get_EntityType(); // 0x06f57d30
	System.Void .ctor(); // 0x06f57d94
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f57e58
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f57f3c
	System.Single get_PosX(); // 0x06f58020
	System.Void set_PosX(System.Single value); // 0x06f58094
	System.Single get_PosY(); // 0x06f58120
	System.Void set_PosY(System.Single value); // 0x06f58194
	System.Single get_PosZ(); // 0x06f58220
	System.Void set_PosZ(System.Single value); // 0x06f58294
	System.Single get_RotateY(); // 0x06f58320
	System.Void set_RotateY(System.Single value); // 0x06f58394
	System.Single get_RotateX(); // 0x06f58420
	System.Void set_RotateX(System.Single value); // 0x06f58494
	System.Single get_RotateZ(); // 0x06f58520
	System.Void set_RotateZ(System.Single value); // 0x06f58594
	System.Int64 get_TemplateId(); // 0x06f58620
	System.Int32 get_SpawnType(); // 0x06f58694
	System.Int32 get_UseCount(); // 0x06f58708
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f5877c
	System.Single get_PosX_Smooth(); // 0x06f587fc
	System.Void set_PosX_Smooth(System.Single value); // 0x06f58860
	System.Single get_PosY_Smooth(); // 0x06f588d8
	System.Void set_PosY_Smooth(System.Single value); // 0x06f5893c
	System.Single get_PosZ_Smooth(); // 0x06f589b4
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f58a18
	System.Single get_RotateX_Smooth(); // 0x06f58a90
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f58af4
	System.Single get_RotateY_Smooth(); // 0x06f58b6c
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f58bd0
	System.Single get_RotateZ_Smooth(); // 0x06f58c48
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f58cac
	System.Int64 get_ParentId(); // 0x06f58d24
	System.Int64 get_MountID(); // 0x06f58d88
	System.Boolean get_HasLocalRotation(); // 0x06f58dec
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f58e50
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f58f14
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f59134
	System.Void Init(); // 0x06f591ec
	static System.Void .cctor(); // 0x06f59254
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SinCarEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	static System.Int32 CLASS_HASH = 1390996815;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f595e8
	System.String GetTypeName(); // 0x06f59650
	System.Int32 get_EntityType(); // 0x06f596c8
	System.Void .ctor(); // 0x06f5972c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f597bc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5986c
	System.Single get_PosX(); // 0x06f5991c
	System.Void set_PosX(System.Single value); // 0x06f59990
	System.Single get_PosY(); // 0x06f59a1c
	System.Void set_PosY(System.Single value); // 0x06f59a90
	System.Single get_PosZ(); // 0x06f59b1c
	System.Void set_PosZ(System.Single value); // 0x06f59b90
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f59c1c
	static System.Void .cctor(); // 0x06f59c9c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SpawnPersistentEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 2059153343;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.SpawnPersistentEntity <Instance>k__BackingField; // 0x10
	System.Int32 GetClassHash(); // 0x06f59f60
	System.String GetTypeName(); // 0x06f59fc8
	System.Int32 get_EntityType(); // 0x06f5a040
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5a0a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5a154
	System.Boolean get_BoybandExist(); // 0x06f5a204
	static System.Object DeserializeSpawnPersistentEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f5a278
	static WizardGames.Soc.Common.Entity.SpawnPersistentEntity get_Instance(); // 0x06f5a39c
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.SpawnPersistentEntity value); // 0x06f5a424
	System.Void PostInit(); // 0x06f5a4b8
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f5a5a8
	static System.Void .cctor(); // 0x06f5a6c8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SpecializedVehicleEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 412360114;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.String PrefabPath; // 0x88
	System.Single AiActivityArea; // 0x90
	System.Single AverageSpeed; // 0x94
	System.Single SpeedChangeRate; // 0x98
	System.Single RotationAngle; // 0x9c
	System.Single StatusChangeArea; // 0xa0
	System.Int32 GetClassHash(); // 0x06f5a820
	System.String GetTypeName(); // 0x06f5a888
	System.Int32 get_EntityType(); // 0x06f5a900
	System.Void .ctor(); // 0x06f5a964
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5aa30
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5ab58
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_EntityIds(); // 0x06f5ac44
	System.Void set_EntityIds(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x06f5ace4
	System.Single get_PosX(); // 0x06f5ad70
	System.Void set_PosX(System.Single value); // 0x06f5ade4
	System.Single get_PosY(); // 0x06f5ae70
	System.Void set_PosY(System.Single value); // 0x06f5aee4
	System.Single get_PosZ(); // 0x06f5af70
	System.Void set_PosZ(System.Single value); // 0x06f5afe4
	System.Single get_RotateX(); // 0x06f5b070
	System.Void set_RotateX(System.Single value); // 0x06f5b0e4
	System.Single get_RotateY(); // 0x06f5b170
	System.Void set_RotateY(System.Single value); // 0x06f5b1e4
	System.Single get_RotateZ(); // 0x06f5b270
	System.Void set_RotateZ(System.Single value); // 0x06f5b2e4
	System.Int64 get_TemplateId(); // 0x06f5b370
	System.Int32 get_SpawnType(); // 0x06f5b3e4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f5b458
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f5b778
	System.Void InvokeChildOnCustomCreate(); // 0x06f5b7f8
	System.Void InvokeChildOnCustomRemove(); // 0x06f5b858
	static System.Object DeserializeSpecializedVehicleEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f5b8b8
	System.Single get_PosX_Smooth(); // 0x06f5b98c
	System.Void set_PosX_Smooth(System.Single value); // 0x06f5b9f0
	System.Single get_PosY_Smooth(); // 0x06f5ba68
	System.Void set_PosY_Smooth(System.Single value); // 0x06f5bacc
	System.Single get_PosZ_Smooth(); // 0x06f5bb44
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f5bba8
	System.Single get_RotateX_Smooth(); // 0x06f5bc20
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f5bc84
	System.Single get_RotateY_Smooth(); // 0x06f5bcfc
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f5bd60
	System.Single get_RotateZ_Smooth(); // 0x06f5bdd8
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f5be3c
	System.Int64 get_ParentId(); // 0x06f5beb4
	System.Int64 get_MountID(); // 0x06f5bf18
	System.Boolean get_HasLocalRotation(); // 0x06f5bf7c
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f5bfe0
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f5c0e0
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f5c15c
	static System.Void .cctor(); // 0x06f5c214
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.StorageDebrisEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 1814137797;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Unity.Go.BaseStorageDebrisGo storageDebrisGo; // 0x60
	System.Int32 GetClassHash(); // 0x06f5c50c
	System.String GetTypeName(); // 0x06f5c574
	System.Int32 get_EntityType(); // 0x06f5c5ec
	System.Void .ctor(); // 0x06f5c650
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5c6e0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5c790
	System.Single get_PosX(); // 0x06f5c840
	System.Void set_PosX(System.Single value); // 0x06f5c8b4
	System.Single get_PosZ(); // 0x06f5c940
	System.Void set_PosZ(System.Single value); // 0x06f5c9b4
	System.Single get_PosY(); // 0x06f5ca40
	System.Void set_PosY(System.Single value); // 0x06f5cab4
	System.Single get_RotateX(); // 0x06f5cb40
	System.Void set_RotateX(System.Single value); // 0x06f5cbb4
	System.Single get_RotateY(); // 0x06f5cc40
	System.Void set_RotateY(System.Single value); // 0x06f5ccb4
	System.Single get_RotateZ(); // 0x06f5cd40
	System.Void set_RotateZ(System.Single value); // 0x06f5cdb4
	System.Int64 get_TemplateId(); // 0x06f5ce40
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f5ceb4
	System.Void PostInit(); // 0x06f5cf34
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f5d044
	WizardGames.Soc.Common.Unity.Go.BaseStorageDebrisGo get_StorageDebrisGo(); // 0x06f5d16c
	System.Void set_StorageDebrisGo(WizardGames.Soc.Common.Unity.Go.BaseStorageDebrisGo value); // 0x06f5d308
	System.Void ReturnToPoolBusiness(); // 0x06f5d388
	WizardGames.Soc.Common.Component.DebrisComponent get_DebrisComponent(); // 0x06f5d44c
	System.Void Init(); // 0x06f5d4cc
	static System.Void .cctor(); // 0x06f5d56c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.SwarmAIEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 1149019983;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f5d794
	System.String GetTypeName(); // 0x06f5d7fc
	System.Int32 get_EntityType(); // 0x06f5d874
	System.Void .ctor(); // 0x06f5d8d8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5d968
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5da18
	static System.Void .cctor(); // 0x06f5dac8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TargetEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 443921914;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "TargetEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06f5db84
	System.String GetTypeName(); // 0x06f5dbec
	System.Int32 get_EntityType(); // 0x06f5dc64
	System.Void .ctor(); // 0x06f5dcc8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5dd58
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5de08
	System.Single get_PosX(); // 0x06f5deb8
	System.Void set_PosX(System.Single value); // 0x06f5df2c
	System.Single get_PosY(); // 0x06f5dfb8
	System.Void set_PosY(System.Single value); // 0x06f5e02c
	System.Single get_PosZ(); // 0x06f5e0b8
	System.Void set_PosZ(System.Single value); // 0x06f5e12c
	System.Single get_RotateX(); // 0x06f5e1b8
	System.Void set_RotateX(System.Single value); // 0x06f5e22c
	System.Single get_RotateY(); // 0x06f5e2b8
	System.Void set_RotateY(System.Single value); // 0x06f5e32c
	System.Single get_RotateZ(); // 0x06f5e3b8
	System.Void set_RotateZ(System.Single value); // 0x06f5e42c
	System.Int64 get_TemplateId(); // 0x06f5e4b8
	System.Int32 get_SpawnType(); // 0x06f5e52c
	System.Single get_ScaleX(); // 0x06f5e5a0
	System.Single get_ScaleY(); // 0x06f5e614
	System.Single get_ScaleZ(); // 0x06f5e688
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f5e6fc
	System.Single get_PosX_Smooth(); // 0x06f5e77c
	System.Void set_PosX_Smooth(System.Single value); // 0x06f5e7e0
	System.Single get_PosY_Smooth(); // 0x06f5e858
	System.Void set_PosY_Smooth(System.Single value); // 0x06f5e8bc
	System.Single get_PosZ_Smooth(); // 0x06f5e934
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f5e998
	System.Single get_RotateX_Smooth(); // 0x06f5ea10
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f5ea74
	System.Single get_RotateY_Smooth(); // 0x06f5eaec
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f5eb50
	System.Single get_RotateZ_Smooth(); // 0x06f5ebc8
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f5ec2c
	System.Int64 get_ParentId(); // 0x06f5eca4
	System.Int64 get_MountID(); // 0x06f5ed08
	System.Boolean get_HasLocalRotation(); // 0x06f5ed6c
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f5edd0
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f5ee94
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f5ef10
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f5efc8
	System.Void CleanupLogic(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06f5f16c
	static System.Void .cctor(); // 0x06f5f230
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TeamEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 659405843;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	SocLogger logger; // 0x60
	static System.Collections.Generic.List<System.UInt64> s_RemoveList; // 0x10
	static WizardGames.Soc.Common.Entity.TeamEntity Instance; // 0x18
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.Entity.TeammateSpeaker> teammateSpeakers; // 0x68
	System.Int32 GetClassHash(); // 0x06f5f5c4
	System.String GetTypeName(); // 0x06f5f62c
	System.Int32 get_EntityType(); // 0x06f5f6a4
	System.Void .ctor(); // 0x06f5f708
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f5f890
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f5fb50
	System.UInt64 get_CaptainRoleId(); // 0x06f5fcf8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.TeamMemberInfo> get_MemberDic(); // 0x06f5fd6c
	System.Void set_MemberDic(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.TeamMemberInfo> value); // 0x06f5fe0c
	WizardGames.Soc.Common.CustomType.ReputationTeamInfo get_TeamReputationInfo(); // 0x06f5fe98
	System.Int32 get_ApplicationCount(); // 0x06f5ff5c
	System.Int32 get_ImpeachState(); // 0x06f5ffd0
	System.UInt64 get_ApplicationPlayer(); // 0x06f60044
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Boolean> get_VoteRoles(); // 0x06f600b8
	System.Void set_VoteRoles(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Boolean> value); // 0x06f60158
	System.Int32 get_InviteOtherCount(); // 0x06f601e4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06f60258
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f603b8
	static System.Object DeserializeTeamEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f60800
	System.Void Init(); // 0x06f60958
	System.Void RefreshImpeachStateToPopUI(); // 0x06f61bfc
	System.Void OnVoteRolesSubscribeAnyUpdateCallback(); // 0x06f61d08
	System.Void RefreshTeammateCloth(System.UInt64 roleId); // 0x06f61e54
	System.Void RefreshAllTeammatesCloth(); // 0x06f6192c
	System.Void RefreshTeammateSpeaker(); // 0x06f611e8
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f61f54
	static System.Void .cctor(); // 0x06f62348
	System.Void <Init>b__46_0(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 key, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldVal); // 0x06f62768
	System.Void <Init>b__46_1(); // 0x06f62a70
	System.Void <RefreshImpeachStateToPopUI>b__47_0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06f62b50
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TeamEntity.<>c : System.Object
{
	static WizardGames.Soc.Common.Entity.TeamEntity.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.UInt64,System.Boolean> <>9__48_0; // 0x8
	static System.Void .cctor(); // 0x06f62f20
	System.Void .ctor(); // 0x06f62f84
	System.Void <OnVoteRolesSubscribeAnyUpdateCallback>b__48_0(WizardGames.Soc.Share.Framework.ECustomDictOpType eType, System.UInt64 _, System.Boolean _); // 0x06f62fec
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TeamManagerEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 1225061073;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f630dc
	System.String GetTypeName(); // 0x06f63144
	System.Int32 get_EntityType(); // 0x06f631bc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f63220
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f63318
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.WarZoneTeamRecruitment> get_WarZoneTeamRecruitments(); // 0x06f633c8
	System.Void set_WarZoneTeamRecruitments(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.WarZoneTeamRecruitment> value); // 0x06f63468
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06f634f4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f63654
	static System.Object DeserializeTeamManagerEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f63974
	static System.Void .cctor(); // 0x06f63a98
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TempCofferEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 729925981;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f63bbc
	System.String GetTypeName(); // 0x06f63c24
	System.Int32 get_EntityType(); // 0x06f63c9c
	System.Void .ctor(); // 0x06f63d00
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f63d90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f63e40
	System.Int32 get_SpawnType(); // 0x06f63ef0
	System.Int64 get_TemplateId(); // 0x06f63f64
	System.Single get_PosX(); // 0x06f63fd8
	System.Void set_PosX(System.Single value); // 0x06f6404c
	System.Single get_PosY(); // 0x06f640d8
	System.Void set_PosY(System.Single value); // 0x06f6414c
	System.Single get_PosZ(); // 0x06f641d8
	System.Void set_PosZ(System.Single value); // 0x06f6424c
	System.Single get_RotateX(); // 0x06f642d8
	System.Single get_RotateY(); // 0x06f6434c
	System.Single get_RotateZ(); // 0x06f643c0
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f64434
	static System.Void .cctor(); // 0x06f644b4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TerritoryEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	static System.Int32 CLASS_HASH = 224226856;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f64814
	System.String GetTypeName(); // 0x06f6487c
	System.Int32 get_EntityType(); // 0x06f648f4
	System.Void .ctor(); // 0x06f64958
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f649e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f64b00
	System.Single get_PosX(); // 0x06f64bb0
	System.Void set_PosX(System.Single value); // 0x06f64c24
	System.Single get_PosY(); // 0x06f64cb0
	System.Void set_PosY(System.Single value); // 0x06f64d24
	System.Single get_PosZ(); // 0x06f64db0
	System.Void set_PosZ(System.Single value); // 0x06f64e24
	System.Int64 get_LocTs(); // 0x06f64eb0
	WizardGames.Soc.Common.CustomType.DeadSheepBuildingRecord get_DeadSheepRecord(); // 0x06f64f24
	System.Boolean get_IsPrimaryTerritory(); // 0x06f64fe8
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f6505c
	WizardGames.Soc.Common.Component.TerritoryBaseComponent get_BaseComp(); // 0x06f650dc
	WizardGames.Soc.Common.Component.TerritoryPermissionComponent get_PermissionComp(); // 0x06f6515c
	WizardGames.Soc.Common.Component.TerritoryPlayComponent get_PlayComp(); // 0x06f651dc
	WizardGames.Soc.Common.Component.TerritoryOutsideComponent get_OutsideComp(); // 0x06f6525c
	WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent get_BatchRecover(); // 0x06f652dc
	WizardGames.Soc.Common.Component.TerritorySkinComponent get_SkinComp(); // 0x06f6535c
	WizardGames.Soc.Common.Component.TerritoryPlunderComponent get_PlunderComp(); // 0x06f653dc
	WizardGames.Soc.Common.Component.ConstructionRenameComponent get_RenameComp(); // 0x06f6545c
	WizardGames.Soc.Common.Component.TerritoryDoorComponent get_DoorComp(); // 0x06f654dc
	WizardGames.Soc.Common.Component.TerritoryDeadSheepComponent get_DeadSheepComp(); // 0x06f6555c
	static System.Void .cctor(); // 0x06f655dc
	static System.Void OnPosChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06f65910
	System.Void PostInit(); // 0x06f65db0
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f65f2c
	System.Void OnLodSwitch(System.Int32 oldLevel, System.Int32 newLevel); // 0x06f66110
	System.Void TryAddTerritory(); // 0x06f65aa0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ThrownEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IRFDetonationEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IAttachedEntity, WizardGames.Soc.Common.Entity.Ability.IPredictEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 277891373;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "ThrownEntity";
	static System.String[] PropNameArray; // 0x8
	UnityEngine.Transform <AttachedTransform>k__BackingField; // 0x60
	System.Int64 PredictEntityId; // 0x68
	System.Single <PosX_Smooth>k__BackingField; // 0x70
	System.Single <PosY_Smooth>k__BackingField; // 0x74
	System.Single <PosZ_Smooth>k__BackingField; // 0x78
	System.Single <RotateX_Smooth>k__BackingField; // 0x7c
	System.Single <RotateY_Smooth>k__BackingField; // 0x80
	System.Single <RotateZ_Smooth>k__BackingField; // 0x84
	System.Int64 <MountID>k__BackingField; // 0x88
	System.Int32 <HitCount>k__BackingField; // 0x90
	System.Int32 <ExplodeMode>k__BackingField; // 0x94
	System.Boolean <Predict>k__BackingField; // 0x98
	System.Numerics.Vector3 <Velocity>k__BackingField; // 0x9c
	System.Boolean <IsClient>k__BackingField; // 0xa8
	System.Int32 <StartSequence>k__BackingField; // 0xac
	System.Int32 <TriggerEffect>k__BackingField; // 0xb0
	System.Int32 <TriggerMinNum>k__BackingField; // 0xb4
	System.Int32 <TriggerMaxNum>k__BackingField; // 0xb8
	System.String <FpxPath>k__BackingField; // 0xc0
	System.Int32[] <AdsorptionType>k__BackingField; // 0xc8
	System.Int32 <AttachType>k__BackingField; // 0xd0
	System.Single <DudPercentage>k__BackingField; // 0xd4
	System.Boolean <IsCreateItem>k__BackingField; // 0xd8
	System.Int32 <TriggerDelayTime>k__BackingField; // 0xdc
	System.Boolean <IsTrigger>k__BackingField; // 0xe0
	System.Boolean <Triggered>k__BackingField; // 0xe1
	System.Boolean <FuseTriggered>k__BackingField; // 0xe2
	System.Boolean <IsShowHighLight>k__BackingField; // 0xe3
	System.Int64 LocalTime; // 0xe8
	System.Int64 ItemUid; // 0xf0
	System.Boolean <HasVelocitySnapshot>k__BackingField; // 0xf8
	System.Int64 <CmdSendRenderTime>k__BackingField; // 0x100
	System.Int64 <VehicleEntityId>k__BackingField; // 0x108
	System.Int32 GetClassHash(); // 0x06f6627c
	System.String GetTypeName(); // 0x06f662e4
	System.Int32 get_EntityType(); // 0x06f6635c
	System.Void .ctor(); // 0x06f663c0
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f66458
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f6654c
	System.Single get_PosX(); // 0x06f66604
	System.Void set_PosX(System.Single value); // 0x06f66678
	System.Single get_PosY(); // 0x06f66704
	System.Void set_PosY(System.Single value); // 0x06f66778
	System.Single get_PosZ(); // 0x06f66804
	System.Void set_PosZ(System.Single value); // 0x06f66878
	System.Single get_RotateX(); // 0x06f66904
	System.Void set_RotateX(System.Single value); // 0x06f66978
	System.Single get_RotateY(); // 0x06f66a04
	System.Void set_RotateY(System.Single value); // 0x06f66a78
	System.Single get_RotateZ(); // 0x06f66b04
	System.Void set_RotateZ(System.Single value); // 0x06f66b78
	System.Int64 get_TargetEntityID(); // 0x06f66c04
	System.Void set_TargetEntityID(System.Int64 value); // 0x06f66c78
	System.Int32 get_TargetColliderIndex(); // 0x06f66d04
	System.Void set_TargetColliderIndex(System.Int32 value); // 0x06f66d78
	System.Single get_PosOffsetX(); // 0x06f66e04
	System.Void set_PosOffsetX(System.Single value); // 0x06f66e78
	System.Single get_PosOffsetY(); // 0x06f66f04
	System.Void set_PosOffsetY(System.Single value); // 0x06f66f78
	System.Single get_PosOffsetZ(); // 0x06f67004
	System.Void set_PosOffsetZ(System.Single value); // 0x06f67078
	System.Single get_RotOffsetX(); // 0x06f67104
	System.Void set_RotOffsetX(System.Single value); // 0x06f67178
	System.Single get_RotOffsetY(); // 0x06f67204
	System.Void set_RotOffsetY(System.Single value); // 0x06f67278
	System.Single get_RotOffsetZ(); // 0x06f67304
	System.Void set_RotOffsetZ(System.Single value); // 0x06f67378
	System.Single get_RotOffsetW(); // 0x06f67404
	System.Void set_RotOffsetW(System.Single value); // 0x06f67478
	System.Int32 get_TemplateId(); // 0x06f67504
	System.Int64 get_TableId(); // 0x06f67578
	System.Void set_TableId(System.Int64 value); // 0x06f675ec
	System.Int64 get_OwnerEntityId(); // 0x06f67678
	System.Void set_OwnerEntityId(System.Int64 value); // 0x06f676ec
	System.Int64 get_OwnerRoleId(); // 0x06f67778
	System.Void set_OwnerRoleId(System.Int64 value); // 0x06f677ec
	System.Single get_MoveTime(); // 0x06f67878
	System.Void set_MoveTime(System.Single value); // 0x06f678ec
	System.Single get_Duration(); // 0x06f67978
	System.Void set_Duration(System.Single value); // 0x06f679ec
	System.Single get_MaxDuration(); // 0x06f67a78
	System.Void set_MaxDuration(System.Single value); // 0x06f67aec
	System.Int32 get_SeqKey(); // 0x06f67b78
	System.Void set_SeqKey(System.Int32 value); // 0x06f67bec
	System.Int32 get_TriggerMode(); // 0x06f67c78
	System.Void set_TriggerMode(System.Int32 value); // 0x06f67cec
	System.Boolean get_HitSomething(); // 0x06f67d78
	System.Void set_HitSomething(System.Boolean value); // 0x06f67dec
	System.Int32 get_FollowEffectId(); // 0x06f67e78
	System.Boolean get_IsDudPercentage(); // 0x06f67eec
	System.Boolean get_CanPickUp(); // 0x06f67f60
	System.Boolean get_PickUped(); // 0x06f67fd4
	System.Int64 get_SkinID(); // 0x06f68048
	System.Void set_SkinID(System.Int64 value); // 0x06f680bc
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_FuseEntityIds(); // 0x06f68148
	System.Boolean get_IsFuseSetup(); // 0x06f681e8
	System.Boolean get_IsRFDetonation(); // 0x06f6825c
	System.Void set_IsRFDetonation(System.Boolean value); // 0x06f682d0
	System.Int32 get_Frequency(); // 0x06f6835c
	System.Void set_Frequency(System.Int32 value); // 0x06f683d0
	System.Boolean get_RFTriggered(); // 0x06f6845c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f684d0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06f68550
	static System.Object DeserializeThrownEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f689ec
	UnityEngine.Transform get_AttachedTransform(); // 0x06f68ac0
	System.Void set_AttachedTransform(UnityEngine.Transform value); // 0x06f68b24
	System.Single get_PosX_Smooth(); // 0x06f68ba4
	System.Void set_PosX_Smooth(System.Single value); // 0x06f68c08
	System.Single get_PosY_Smooth(); // 0x06f68c80
	System.Void set_PosY_Smooth(System.Single value); // 0x06f68ce4
	System.Single get_PosZ_Smooth(); // 0x06f68d5c
	System.Void set_PosZ_Smooth(System.Single value); // 0x06f68dc0
	System.Single get_RotateX_Smooth(); // 0x06f68e38
	System.Void set_RotateX_Smooth(System.Single value); // 0x06f68e9c
	System.Single get_RotateY_Smooth(); // 0x06f68f14
	System.Void set_RotateY_Smooth(System.Single value); // 0x06f68f78
	System.Single get_RotateZ_Smooth(); // 0x06f68ff0
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06f69054
	System.Int64 get_ParentId(); // 0x06f690cc
	System.Int64 get_MountID(); // 0x06f69130
	System.Boolean get_HasLocalRotation(); // 0x06f69194
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f691f8
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f692bc
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f693ac
	System.Void Init(); // 0x06f69464
	System.Void AddLocalComponent(); // 0x06f694d4
	System.Void PlaySoundOnFuse(); // 0x06f6875c
	System.Int32 get_HitCount(); // 0x06f695a0
	System.Void set_HitCount(System.Int32 value); // 0x06f69604
	System.Boolean get_Predict(); // 0x06f6967c
	System.Void set_Predict(System.Boolean value); // 0x06f696e0
	System.Numerics.Vector3 get_Velocity(); // 0x06f6975c
	System.Void set_Velocity(System.Numerics.Vector3 value); // 0x06f697c0
	System.Boolean get_IsClient(); // 0x06f69858
	System.Void set_IsClient(System.Boolean value); // 0x06f698bc
	System.Int32 get_StartSequence(); // 0x06f69938
	System.Void set_StartSequence(System.Int32 value); // 0x06f6999c
	System.Void set_TriggerEffect(System.Int32 value); // 0x06f69a14
	System.Void set_TriggerMinNum(System.Int32 value); // 0x06f69a8c
	System.Void set_TriggerMaxNum(System.Int32 value); // 0x06f69b04
	System.Int32[] get_AdsorptionType(); // 0x06f69b7c
	System.Void set_AdsorptionType(System.Int32[] value); // 0x06f69be0
	System.Int32 get_AttachType(); // 0x06f69c60
	System.Void set_AttachType(System.Int32 value); // 0x06f69cc4
	System.Void set_DudPercentage(System.Single value); // 0x06f69d3c
	System.Boolean get_IsTrigger(); // 0x06f69db4
	System.Boolean get_IsShowHighLight(); // 0x06f69e18
	System.Void set_IsShowHighLight(System.Boolean value); // 0x06f69e7c
	System.Void .ctor(System.Int64 id); // 0x06f69ef8
	System.Void set_VehicleEntityId(System.Int64 value); // 0x06f69fa4
	static System.Void .cctor(); // 0x06f6a01c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TrainBarricadeEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity
{
	static System.Int32 CLASS_HASH = 1090400944;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f6ad58
	System.String GetTypeName(); // 0x06f6adc0
	System.Int32 get_EntityType(); // 0x06f6ae38
	System.Void .ctor(); // 0x06f6ae9c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f6af2c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f6afdc
	System.Int64 get_TemplateId(); // 0x06f6b08c
	System.Single get_PosX(); // 0x06f6b100
	System.Void set_PosX(System.Single value); // 0x06f6b174
	System.Single get_PosY(); // 0x06f6b200
	System.Void set_PosY(System.Single value); // 0x06f6b274
	System.Single get_PosZ(); // 0x06f6b300
	System.Void set_PosZ(System.Single value); // 0x06f6b374
	System.Single get_RotateX(); // 0x06f6b400
	System.Void set_RotateX(System.Single value); // 0x06f6b474
	System.Single get_RotateY(); // 0x06f6b500
	System.Void set_RotateY(System.Single value); // 0x06f6b574
	System.Single get_RotateZ(); // 0x06f6b600
	System.Void set_RotateZ(System.Single value); // 0x06f6b674
	System.Int32 get_SpawnType(); // 0x06f6b700
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f6b774
	static System.Void .cctor(); // 0x06f6b7f4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TrainCarEntity : WizardGames.Soc.Common.Entity.BaseVehicleEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IPlatformEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 1731818416;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "TrainCarEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd4
	System.Single <PosY_Smooth>k__BackingField; // 0xd8
	System.Single <PosZ_Smooth>k__BackingField; // 0xdc
	System.Single <RotateX_Smooth>k__BackingField; // 0xe0
	System.Single <RotateY_Smooth>k__BackingField; // 0xe4
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe8
	System.Int64 <ParentId>k__BackingField; // 0xf0
	System.Int64 <MountID>k__BackingField; // 0xf8
	System.Collections.Generic.HashSet<System.Int64> childrenList; // 0x100
	System.Int64 <firstTakeInPlayerId>k__BackingField; // 0x108
	System.Boolean <moveAwayPlayer>k__BackingField; // 0x110
	System.Boolean IsUnloading; // 0x111
	System.Int32 GroupTotalUnloadCount; // 0x114
	System.Int32 TrainUnloadCount; // 0x118
	WizardGames.Soc.Common.Component.TrainComponent _trainCom; // 0x120
	System.Int32 GetClassHash(); // 0x06f6bb20
	System.String GetTypeName(); // 0x06f6bb88
	System.Int32 get_EntityType(); // 0x06f6bc00
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x055128b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x05524154
	System.Single get_EngineSpeeds(); // 0x06f6bf34
	System.Int32 get_TrackSelection(); // 0x06f6bfa8
	System.Single get_FrontBogieY(); // 0x06f6c01c
	System.Single get_RearBogieY(); // 0x06f6c090
	System.Int32 get_ThrottleFraction(); // 0x06f6c104
	WizardGames.Soc.Common.Entity.TrainEngineStateEnum get_EngineState(); // 0x06f6c178
	System.Boolean get_HasHazards(); // 0x06f6c1ec
	System.Int32 get_ChangeTrailDis(); // 0x06f6c260
	System.Int64 get_HeadEntityId(); // 0x06f6c2d4
	System.Int32 get_SlotIndex(); // 0x06f6c348
	WizardGames.Soc.Common.Entity.TrainUnloadStateEnum get_TrainUnloadState(); // 0x06f6c3bc
	System.Single get_TrainUnloadPercentage(); // 0x06f6c430
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f6c4a4
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06f6cb14
	System.Void Init(); // 0x06f6cb78
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f6cc18
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f6ccf4
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f6cd70
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x054e7844
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x055112ac
	System.String ToPrettyString(); // 0x06f6cf04
	static System.Void .cctor(); // 0x06f6d238
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TrapEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 1028398781;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f6e0b4
	System.String GetTypeName(); // 0x06f6e11c
	System.Int32 get_EntityType(); // 0x06f6e194
	System.Void .ctor(); // 0x06f6e1f8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f6e288
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f6e338
	System.Int64 get_TemplateId(); // 0x06f6e3e8
	System.Int32 get_SpawnType(); // 0x06f6e45c
	System.Single get_PosX(); // 0x06f6e4d0
	System.Void set_PosX(System.Single value); // 0x06f6e544
	System.Single get_PosY(); // 0x06f6e5d0
	System.Void set_PosY(System.Single value); // 0x06f6e644
	System.Single get_PosZ(); // 0x06f6e6d0
	System.Void set_PosZ(System.Single value); // 0x06f6e744
	System.Single get_RotateX(); // 0x06f6e7d0
	System.Void set_RotateX(System.Single value); // 0x06f6e844
	System.Single get_RotateY(); // 0x06f6e8d0
	System.Void set_RotateY(System.Single value); // 0x06f6e944
	System.Single get_RotateZ(); // 0x06f6e9d0
	System.Void set_RotateZ(System.Single value); // 0x06f6ea44
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f6ead0
	System.Void Init(); // 0x06f6eb50
	static System.Void .cctor(); // 0x06f6ecac
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TreeControlEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 2027509471;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.TreeControlEntity <Instance>k__BackingField; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.VisionTree> trees; // 0x60
	System.Int32 GetClassHash(); // 0x06f6f0dc
	System.String GetTypeName(); // 0x06f6f144
	System.Int32 get_EntityType(); // 0x06f6f1bc
	System.Void .ctor(); // 0x06f6f220
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f6f2b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f6f3dc
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TreeBriefData> get_DeltaAddTrees(); // 0x06f6f48c
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_DeltaRemoveIds(); // 0x06f6f52c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06f6f5cc
	static System.Object DeserializeTreeControlEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f6f72c
	static WizardGames.Soc.Common.Entity.TreeControlEntity get_Instance(); // 0x06f6f850
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.TreeControlEntity value); // 0x06f6f8d8
	System.Void PostInit(); // 0x06f6f96c
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f6fb74
	System.Void GetGlobalTrees(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.VisionTree> trees); // 0x06f6fd88
	System.Void OnAddTreeChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 treeEntityId, WizardGames.Soc.Common.CustomType.TreeBriefData _); // 0x06f704fc
	System.Void OnRemoveTreeChanged(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int64 treeEntityId); // 0x06f70724
	static System.Void .cctor(); // 0x06f70820
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TreeEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ICombatEntity
{
	static System.Int32 CLASS_HASH = 1675205170;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f70944
	System.String GetTypeName(); // 0x06f709ac
	System.Int32 get_EntityType(); // 0x06f70a24
	System.Void .ctor(); // 0x06f70a88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f70b18
	System.Single get_PosX(); // 0x06f70bc8
	System.Void set_PosX(System.Single value); // 0x06f70c3c
	System.Single get_PosY(); // 0x06f70cc8
	System.Void set_PosY(System.Single value); // 0x06f70d3c
	System.Single get_PosZ(); // 0x06f70dc8
	System.Void set_PosZ(System.Single value); // 0x06f70e3c
	System.Single get_RotateY(); // 0x06f70ec8
	System.Void set_RotateY(System.Single value); // 0x06f70f3c
	System.Int64 get_TemplateId(); // 0x06f70fc8
	System.Int32 get_SpawnType(); // 0x06f7103c
	System.Single get_ScaleX(); // 0x06f710b0
	System.Single get_RemainHp(); // 0x06f71124
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f71198
	System.Void BeforeRemove(); // 0x06f71218
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f71ae4
	System.Void CleanupLogic(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06f71c88
	System.Void GenerateFxAndAudio(WizardGames.Soc.Common.Data.units.GatherResourcesTree table, UnityEngine.Vector3 position); // 0x06f71460
	System.String ToPrettyString(); // 0x06f71eb0
	System.Void ReturnToPoolBusiness(); // 0x06f72188
	static System.Void .cctor(); // 0x06f721e8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.UcmCarEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	static System.Int32 CLASS_HASH = 1395314197;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f72478
	System.String GetTypeName(); // 0x06f724e0
	System.Int32 get_EntityType(); // 0x06f72558
	System.Void .ctor(); // 0x06f725bc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f7264c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f726fc
	System.Single get_PosX(); // 0x06f727ac
	System.Void set_PosX(System.Single value); // 0x06f72820
	System.Single get_PosY(); // 0x06f728ac
	System.Void set_PosY(System.Single value); // 0x06f72920
	System.Single get_PosZ(); // 0x06f729ac
	System.Void set_PosZ(System.Single value); // 0x06f72a20
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f72aac
	static System.Void .cctor(); // 0x06f72b2c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.UgcLevelMgrEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 46248757;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f72df0
	System.String GetTypeName(); // 0x06f72e58
	System.Int32 get_EntityType(); // 0x06f72ed0
	System.Void .ctor(); // 0x06f72f34
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f72fc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f730b0
	WizardGames.Soc.Share.Framework.BasicTypeList<System.String> get_LevelFileList(); // 0x06f73160
	System.Void set_LevelFileList(WizardGames.Soc.Share.Framework.BasicTypeList<System.String> value); // 0x06f73200
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f7328c
	static System.Object DeserializeUgcLevelMgrEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f735ac
	static System.Void .cctor(); // 0x06f736d0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.VehicleEntity : WizardGames.Soc.Common.Entity.BaseVehicleEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.Interface.IMarkerEntity, WizardGames.Soc.Common.Entity.IPlatformEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 1042579317;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd4
	System.Single <PosY_Smooth>k__BackingField; // 0xd8
	System.Single <PosZ_Smooth>k__BackingField; // 0xdc
	System.Single <RotateX_Smooth>k__BackingField; // 0xe0
	System.Single <RotateY_Smooth>k__BackingField; // 0xe4
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe8
	System.Int64 <ParentId>k__BackingField; // 0xf0
	System.Int64 <MountID>k__BackingField; // 0xf8
	System.Boolean HasPreloadCorpse; // 0x100
	System.Single NextFireCDFinishTime; // 0x104
	System.Single <LastCopterHp>k__BackingField; // 0x108
	System.Collections.Generic.HashSet<System.Int64> childrenList; // 0x110
	System.Int64 <firstTakeInPlayerId>k__BackingField; // 0x118
	System.Int32 GetClassHash(); // 0x06f737f4
	System.String GetTypeName(); // 0x06f7385c
	System.Int32 get_EntityType(); // 0x06f738d4
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x055128b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x05524154
	System.Single get_MainGunYaw(); // 0x06f73c20
	System.Single get_MainGunPitch(); // 0x06f73c94
	System.Single get_LeftGunYaw(); // 0x06f73d08
	System.Single get_LeftGunPitch(); // 0x06f73d7c
	System.Single get_RightGunYaw(); // 0x06f73df0
	System.Single get_RightGunPitch(); // 0x06f73e64
	System.Int32 get_CurEngineThrust(); // 0x06f73ed8
	System.Int32 get_TotalStartTime(); // 0x06f73f4c
	System.Void set_TotalStartTime(System.Int32 value); // 0x06f73fc0
	System.Int32 get_RevSpeed(); // 0x06f7404c
	System.Void set_RevSpeed(System.Int32 value); // 0x06f740c0
	System.Boolean get_JustBought(); // 0x06f7414c
	System.Void set_JustBought(System.Boolean value); // 0x06f741c0
	System.Int32 get_SpawnMonumentId(); // 0x06f7424c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f742c0
	System.Void RemoteCallClientPlayAudio(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String wwiseEventName); // 0x06f74340
	System.Void InvokeChildOnCustomCreate(); // 0x06f744cc
	System.Void InvokeChildOnCustomRemove(); // 0x06f7452c
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06f7458c
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06f74d14
	System.Void Init(); // 0x06f74d78
	System.Void PostInit(); // 0x06f74e18
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f74f54
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f75030
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f750ac
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.VehicleEntity target, WizardGames.Soc.Common.Unity.Go.BaseMountableGo _mountableGo); // 0x0552af00
	System.Void UnSubscribePropertyChange(); // 0x06f754fc
	System.Void OnTotalStartTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.VehicleEntity target); // 0x06f75564
	System.Void OnRevSpeedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.VehicleEntity target); // 0x06f7566c
	System.Void OnJustBoughtChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.VehicleEntity target); // 0x06f75774
	System.Single get_LastCopterHp(); // 0x054a5abc
	System.Void set_LastCopterHp(System.Single value); // 0x05513724
	System.Int32 get_DriversCount(); // 0x06f758f8
	System.Int32 get_RemainLimitedAuthorityTs(); // 0x06f759ac
	System.Void RefreshAttribution(); // 0x06f75b44
	System.Void .ctor(System.Int64 id); // 0x055112ac
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x054e7844
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x055112ac
	System.String ToPrettyString(); // 0x06f75dd8
	System.Boolean IsCanPlatform(WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig); // 0x06f7610c
	static System.Void .cctor(); // 0x06f76224
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.VehicleEntity.<>c__DisplayClass100_0 : System.Object
{
	WizardGames.Soc.Common.Entity.VehicleEntity <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.VehicleEntity target; // 0x18
	System.Void .ctor(); // 0x06f75494
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06f770d0
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06f7717c
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06f77228
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.WildEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity
{
	static System.Int32 CLASS_HASH = 749423500;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06f772d4
	System.String GetTypeName(); // 0x06f7733c
	System.Int32 get_EntityType(); // 0x06f773b4
	System.Void .ctor(); // 0x06f77418
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f774a8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f77558
	System.Int32 get_Index(); // 0x06f77608
	System.Single get_PosX(); // 0x06f7767c
	System.Void set_PosX(System.Single value); // 0x06f776f0
	System.Single get_PosY(); // 0x06f7777c
	System.Void set_PosY(System.Single value); // 0x06f777f0
	System.Single get_PosZ(); // 0x06f7787c
	System.Void set_PosZ(System.Single value); // 0x06f778f0
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f7797c
	WizardGames.Soc.Common.Component.WildOutsideComponent get_OutsideComp(); // 0x06f779fc
	System.Void PostInit(); // 0x06f77a7c
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f77d7c
	System.Void OnLodSwitch(System.Int32 oldLevel, System.Int32 newLevel); // 0x06f7818c
	static System.Void .cctor(); // 0x06f78244
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ZiplineEntity : WizardGames.Soc.Common.Entity.BaseMountableEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 180413503;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd0
	System.Single <PosY_Smooth>k__BackingField; // 0xd4
	System.Single <PosZ_Smooth>k__BackingField; // 0xd8
	System.Single <RotateX_Smooth>k__BackingField; // 0xdc
	System.Single <RotateY_Smooth>k__BackingField; // 0xe0
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe4
	System.Int64 <ParentId>k__BackingField; // 0xe8
	System.Int64 <MountID>k__BackingField; // 0xf0
	System.Single <ElapsedMoveTime>k__BackingField; // 0xf8
	System.Int32 GetClassHash(); // 0x06f783d0
	System.String GetTypeName(); // 0x06f78438
	System.Int32 get_EntityType(); // 0x06f784b0
	System.Void .ctor(); // 0x06f78514
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f785a0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f78650
	System.Boolean get_SpeedUp(); // 0x06f78700
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06f78774
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06f78de4
	System.Single get_ElapsedMoveTime(); // 0x054a5abc
	System.Void Init(); // 0x06f78eac
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06f79154
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06f79230
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06f792ac
	static System.Void .cctor(); // 0x06f79364
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TimeUpdateEvent : System.Object
{
	
	System.Void .ctor(); // 0x06f79c70
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.DayNightShiftEntity : WizardGames.Soc.Share.Framework.ClientLocalEntity
{
	static WizardGames.Soc.Common.Entity.DayNightShiftEntity Instance; // 0x0
	WizardGames.Soc.Common.Data.GameTimeStage <Stage>k__BackingField; // 0x5c
	System.Boolean <IsNight>k__BackingField; // 0x60
	System.Boolean <IsDay>k__BackingField; // 0x61
	System.Int32 <Hour>k__BackingField; // 0x64
	System.Int32 <Minute>k__BackingField; // 0x68
	System.Int32 <Second>k__BackingField; // 0x6c
	System.Int32 offset; // 0x70
	WizardGames.Soc.SocWorld.Share.Utility.GameTimeParamHolder gameTimeParamHolder; // 0x78
	WizardGames.Soc.Common.Entity.TimeUpdateEvent instance; // 0x80
	System.Boolean isFirstUpdate; // 0x88
	System.Boolean get_PerserveWhenReconnect(); // 0x06f79cd8
	WizardGames.Soc.Common.Data.GameTimeStage get_Stage(); // 0x06f79d3c
	System.Void set_Stage(WizardGames.Soc.Common.Data.GameTimeStage value); // 0x06f79da0
	System.Boolean get_IsNight(); // 0x06f79e18
	System.Void set_IsNight(System.Boolean value); // 0x06f79e7c
	System.Boolean get_IsDay(); // 0x06f79ef8
	System.Void set_IsDay(System.Boolean value); // 0x06f79f5c
	System.Int32 get_Hour(); // 0x06f79fd8
	System.Void set_Hour(System.Int32 value); // 0x06f7a03c
	System.Int32 get_Minute(); // 0x06f7a0b4
	System.Void set_Minute(System.Int32 value); // 0x06f7a118
	System.Int32 get_Second(); // 0x06f7a190
	System.Void set_Second(System.Int32 value); // 0x06f7a1f4
	System.Single get_HourFloat(); // 0x06f7a26c
	System.Void Init(); // 0x06f7a3e4
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f7a5e0
	System.String GetTypeName(); // 0x06f7a690
	System.Void Update(); // 0x06f7a708
	System.Void UpdateGameTimeParams(WizardGames.Soc.Common.SimpleCustom.GameTimeParam gameTimeParam); // 0x06f7abe0
	System.Void .ctor(); // 0x06f7aca8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ElectricManagerEntity : WizardGames.Soc.Share.Framework.ClientLocalEntity, WizardGames.Soc.Common.Manager.IElectricCollection
{
	static WizardGames.Soc.Common.Entity.ElectricManagerEntity <Instance>k__BackingField; // 0x0
	System.Boolean get_PerserveWhenReconnect(); // 0x06f7ad50
	static WizardGames.Soc.Common.Entity.ElectricManagerEntity get_Instance(); // 0x06f7adb4
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.ElectricManagerEntity value); // 0x06f7ae2c
	static System.Void InitInstance(); // 0x06f7aeb8
	System.Void .ctor(System.Int64 id); // 0x06f7afdc
	System.Void PostInit(); // 0x06f7b05c
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f7b278
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetElectricIntegrateCircuit(System.Int64 entityId); // 0x06f7b3d8
	System.String GetTypeName(); // 0x06f7b490
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ISmoothCloneEntity : 
{
	
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x054c4760
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x0552af00
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x0552af00
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x054d3108
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.LinkedSequenceSegment : System.Buffers.ReadOnlySequenceSegment<System.Byte>
{
	
	System.Void .ctor(System.ReadOnlyMemory<System.Byte> memory); // 0x06f7b508
	WizardGames.Soc.Common.Entity.LinkedSequenceSegment AddNext(System.ReadOnlyMemory<System.Byte> next); // 0x06f7b5c0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.PartEntityPrebuild : WizardGames.Soc.Common.Entity.PartEntity
{
	
	System.Void .ctor(System.Int64 id); // 0x06f7b6f4
	System.Void AddBaseComponents(); // 0x06f7b798
	System.Void CheckAndPlayShatterEffect(); // 0x06f7b868
	System.Void Init(); // 0x06f7b8c8
	System.Void AddClientOnlyComponents(); // 0x06f7b94c
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.AdvancedPerformanceType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.AdvancedPerformanceType FireEffect = 0;
	static WizardGames.Soc.Common.Entity.AdvancedPerformanceType FireSound = 1;
	static WizardGames.Soc.Common.Entity.AdvancedPerformanceType SilenceFireSound = 2;
	static WizardGames.Soc.Common.Entity.AdvancedPerformanceType InspectionSound = 3;
	static WizardGames.Soc.Common.Entity.AdvancedPerformanceType DropMag = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TeammateSpeaker : System.Object
{
	WizardGames.Soc.Common.CustomType.TeamMemberInfo teamMemberData; // 0x10
	System.Int32 speakerValue; // 0x18
	System.Boolean isMuteValue; // 0x1c
	System.Void .ctor(WizardGames.Soc.Common.CustomType.TeamMemberInfo teamMemberData); // 0x06f7b9ac
	System.Int32 get_SpeakerValue(); // 0x06f7bc44
	System.Void set_SpeakerValue(System.Int32 value); // 0x06f7bb38
	System.Boolean get_IsMuteValue(); // 0x06f7bca8
	System.Void set_IsMuteValue(System.Boolean value); // 0x06f7bd0c
	System.String get_RoleId(); // 0x06f7bdfc
	System.Void ClearRecord(); // 0x06f7be8c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TerritoryManagerEntity : WizardGames.Soc.Share.Framework.ClientLocalEntity
{
	static WizardGames.Soc.Common.Entity.TerritoryManagerEntity <Instance>k__BackingField; // 0x0
	WizardGames.Soc.Common.Framework.Algorithm.Octree.PointOctree<System.Int64> terrOctree; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Algorithm.Vector3> terrPos; // 0x68
	System.Int32 XMapOffset; // 0x70
	System.Int32 ZMapOffset; // 0x74
	System.Int32 XWildIndexMax; // 0x78
	System.Int32 ZWildIndexMax; // 0x7c
	System.Int32 XWildCount; // 0x80
	System.Int32 ZWildCount; // 0x84
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> WildIndexDict; // 0x88
	System.Collections.Generic.List<System.Int64> tempTerrIdList; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.TerritoryEntity> terrResult; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.TerritoryEntity> terrDict; // 0xa0
	System.Int32 xSize; // 0xa8
	System.Int32 zSize; // 0xac
	System.Boolean get_PerserveWhenReconnect(); // 0x06f7bf80
	static WizardGames.Soc.Common.Entity.TerritoryManagerEntity get_Instance(); // 0x06f7bfe4
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.TerritoryManagerEntity value); // 0x06f7c05c
	System.String GetTypeName(); // 0x06f7c0e8
	static System.Void InitInstance(); // 0x06f7c160
	System.Void .ctor(System.Int64 id); // 0x06f7c284
	System.Void Cleanup(System.Boolean isDestroy); // 0x06f7c57c
	WizardGames.Soc.Common.Entity.TerritoryEntity GetInChargeTerritoryEntity(WizardGames.Soc.Common.Entity.PartEntity part); // 0x06f7c678
	WizardGames.Soc.Common.Entity.TerritoryEntity GetInChargeTerritoryEntity(System.Single x, System.Single y, System.Single z); // 0x06f7c894
	WizardGames.Soc.Common.Entity.TerritoryEntity GetInChargeTerritoryEntity(UnityEngine.Vector3 pos); // 0x06f7cd7c
	System.Collections.Generic.IEnumerable<System.Int64> get_TerrIds(); // 0x06f7ce24
	System.Void InitTerritoryOctree(System.Int32 xSize, System.Int32 zSize, System.Int32 xOffset, System.Int32 zOffset); // 0x06f7cea8
	WizardGames.Soc.Common.Entity.TerritoryEntity GetTerritoryEntity(System.Int64 terrId); // 0x06f7c730
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IBaseMountableEntity : , WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	
	System.Single get_PosX(); // 0x054a5abc
	System.Void set_PosX(System.Single value); // 0x05513724
	System.Single get_PosY(); // 0x054a5abc
	System.Void set_PosY(System.Single value); // 0x05513724
	System.Single get_PosZ(); // 0x054a5abc
	System.Void set_PosZ(System.Single value); // 0x05513724
	System.Single get_RotateX(); // 0x054a5abc
	System.Void set_RotateX(System.Single value); // 0x05513724
	System.Single get_RotateY(); // 0x054a5abc
	System.Void set_RotateY(System.Single value); // 0x05513724
	System.Single get_RotateZ(); // 0x054a5abc
	System.Void set_RotateZ(System.Single value); // 0x05513724
	System.Int32 get_DriversCount(); // 0x0548ba98
	System.Int32 get_Flag(); // 0x0548ba98
	System.Void set_Flag(System.Int32 value); // 0x055056e8
	System.Single get_VelocityX(); // 0x054a5abc
	System.Void set_VelocityX(System.Single value); // 0x05513724
	System.Single get_VelocityY(); // 0x054a5abc
	System.Void set_VelocityY(System.Single value); // 0x05513724
	System.Single get_VelocityZ(); // 0x054a5abc
	System.Void set_VelocityZ(System.Single value); // 0x05513724
	System.Int32 get_SpeedInt(); // 0x0548ba98
	System.Int64 get_Seat1Id(); // 0x054a4380
	System.Void set_Seat1Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat2Id(); // 0x054a4380
	System.Void set_Seat2Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat3Id(); // 0x054a4380
	System.Void set_Seat3Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat4Id(); // 0x054a4380
	System.Void set_Seat4Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat5Id(); // 0x054a4380
	System.Void set_Seat5Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat6Id(); // 0x054a4380
	System.Void set_Seat6Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat7Id(); // 0x054a4380
	System.Void set_Seat7Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat8Id(); // 0x054a4380
	System.Void set_Seat8Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat9Id(); // 0x054a4380
	System.Void set_Seat9Id(System.Int64 value); // 0x055112ac
	System.Int64 get_Seat10Id(); // 0x054a4380
	System.Void set_Seat10Id(System.Int64 value); // 0x055112ac
	System.Int64 GetSeatId(System.Int32 index); // 0x06f7d440
	System.Void SetSeatId(System.Int32 index, System.Int64 id); // 0x06f7d868
	System.Int64 get_TemplateId(); // 0x054a4380
	System.Int32 get_VehicleType(); // 0x0548ba98
	System.Void set_VehicleType(System.Int32 value); // 0x055056e8
	System.Int64 get_DriverId(); // 0x054a4380
	System.Single get_Fuel(); // 0x054a5abc
	System.Void set_Fuel(System.Single value); // 0x05513724
	System.Single get_MaxFuel(); // 0x054a5abc
	System.Int64 get_VehicleLastAttackedTime(); // 0x054a4380
	System.Int64 get_VehicleLastRepairedTime(); // 0x054a4380
	System.Boolean get_CanDecay(); // 0x054c4760
	System.Single get_Power(); // 0x054a5abc
	System.Single get_MountableMaxSpeed(); // 0x054a5abc
	System.Void set_MountableMaxSpeed(System.Single value); // 0x05513724
	System.Single get_FuelConsumption(); // 0x054a5abc
	System.Boolean get_IsForceServerAuthority(); // 0x054c4760
	System.Boolean get_IsAuthority(); // 0x054c4760
	System.Void set_IsAuthority(System.Boolean value); // 0x05523a7c
	System.Void set_IsSleep(System.Boolean value); // 0x05523a7c
	System.Boolean HasAnyMounted(); // 0x06f7dc98
	System.Collections.Generic.IEnumerable<System.Int64> GetSeatedIds(); // 0x06f7df34
	System.Int32 get_RemainLimitedAuthorityTs(); // 0x0548ba98
	System.Void RefreshAttribution(); // 0x06f7e068
	System.Single get_Hp(); // 0x054a5abc
	System.Single get_MaxHp(); // 0x054a5abc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.IBaseMountableEntity.<GetSeatedIds>d__132 : System.Object, System.Collections.Generic.IEnumerable<System.Int64>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Int64>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Int64 <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	WizardGames.Soc.Common.Entity.IBaseMountableEntity <>4__this; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x06f7dfd8
	System.Void System.IDisposable.Dispose(); // 0x06f7e0c8
	System.Boolean MoveNext(); // 0x06f7e128
	System.Int64 System.Collections.Generic.IEnumerator<System.Int64>.get_Current(); // 0x06f7eaf4
	System.Void System.Collections.IEnumerator.Reset(); // 0x06f7eb58
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06f7ebe0
	System.Collections.Generic.IEnumerator<System.Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator(); // 0x06f7ec74
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x06f7ed44
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HistoryHorseEntity : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	System.Int32 <MoveState>k__BackingField; // 0x1c
	System.Single <PosX>k__BackingField; // 0x20
	System.Single <PosY>k__BackingField; // 0x24
	System.Single <PosZ>k__BackingField; // 0x28
	System.Boolean <IsRollBack>k__BackingField; // 0x2c
	System.Single <Fuel>k__BackingField; // 0x30
	System.Single <MaxFuel>k__BackingField; // 0x34
	System.Int32 get_MoveState(); // 0x06f7eda8
	System.Void set_MoveState(System.Int32 value); // 0x06f7ee0c
	System.Single get_PosX(); // 0x06f7ee84
	System.Void set_PosX(System.Single value); // 0x06f7eee8
	System.Single get_PosY(); // 0x06f7ef60
	System.Void set_PosY(System.Single value); // 0x06f7efc4
	System.Single get_PosZ(); // 0x06f7f03c
	System.Void set_PosZ(System.Single value); // 0x06f7f0a0
	System.Boolean get_IsRollBack(); // 0x06f7f118
	System.Void set_IsRollBack(System.Boolean value); // 0x06f7f17c
	System.Single get_Fuel(); // 0x06f7f1f8
	System.Void set_Fuel(System.Single value); // 0x06f7f25c
	System.Single get_MaxFuel(); // 0x06f7f2d4
	System.Void set_MaxFuel(System.Single value); // 0x06f7f338
	System.Void CopyFrom(WizardGames.Soc.Common.Entity.HorseEntity horseEntity); // 0x05523a54
	System.Void .ctor(); // 0x06f7f6b8
	static System.Void .cctor(); // 0x06f7f720
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HistoryPlayerEntity : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	System.Int32 <CreateIndex>k__BackingField; // 0x1c
	System.Int32 <ClientTime>k__BackingField; // 0x20
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum <MoveState>k__BackingField; // 0x24
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum <PoseState>k__BackingField; // 0x25
	WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum <MoveZiplineState>k__BackingField; // 0x26
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum <ActionState>k__BackingField; // 0x27
	System.Int32 <InteractiveId>k__BackingField; // 0x28
	System.Int64 <CurrentWeaponId>k__BackingField; // 0x30
	System.Single <PosX>k__BackingField; // 0x38
	System.Single <PosY>k__BackingField; // 0x3c
	System.Single <PosZ>k__BackingField; // 0x40
	System.Single <PlatformPosX>k__BackingField; // 0x44
	System.Single <PlatformPosY>k__BackingField; // 0x48
	System.Single <PlatformPosZ>k__BackingField; // 0x4c
	System.Int64 <PlatformId>k__BackingField; // 0x50
	System.Single <Height>k__BackingField; // 0x58
	System.Int64 <MountableId>k__BackingField; // 0x60
	System.Single <RotateX>k__BackingField; // 0x68
	System.Single <RotateY>k__BackingField; // 0x6c
	System.Single <RotateZ>k__BackingField; // 0x70
	System.Int64 ladderTargetId; // 0x78
	System.Int64 AidTargetId; // 0x80
	System.Boolean IsRollBack; // 0x88
	System.Single <VehiclePosX>k__BackingField; // 0x8c
	System.Single <VehiclePosY>k__BackingField; // 0x90
	System.Single <VehiclePosZ>k__BackingField; // 0x94
	System.Single <VehicleVelX>k__BackingField; // 0x98
	System.Single <VehicleVelY>k__BackingField; // 0x9c
	System.Single <VehicleVelZ>k__BackingField; // 0xa0
	System.Single <VehicleRotateX>k__BackingField; // 0xa4
	System.Single <VehicleRotateY>k__BackingField; // 0xa8
	System.Single <VehicleRotateZ>k__BackingField; // 0xac
	System.Boolean <IsGround>k__BackingField; // 0xb0
	System.Int32 get_CreateIndex(); // 0x06f7f7f4
	System.Void set_CreateIndex(System.Int32 value); // 0x06f7f858
	System.Int32 get_ClientTime(); // 0x06f7f8d0
	System.Void set_ClientTime(System.Int32 value); // 0x06f7f934
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_MoveState(); // 0x06f7f9ac
	System.Void set_MoveState(WizardGames.Soc.Common.Entity.PlayerMoveStateEnum value); // 0x06f7fa10
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_PoseState(); // 0x06f7fa88
	System.Void set_PoseState(WizardGames.Soc.Common.Entity.PlayerPoseStateEnum value); // 0x06f7faec
	WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum get_MoveZiplineState(); // 0x06f7fb64
	System.Void set_MoveZiplineState(WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum value); // 0x06f7fbc8
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum get_ActionState(); // 0x06f7fc40
	System.Void set_ActionState(WizardGames.Soc.Common.Entity.PlayerActionStateEnum value); // 0x06f7fca4
	System.Int32 get_InteractiveId(); // 0x06f7fd1c
	System.Void set_InteractiveId(System.Int32 value); // 0x06f7fd80
	System.Int64 get_CurrentWeaponId(); // 0x06f7fdf8
	System.Void set_CurrentWeaponId(System.Int64 value); // 0x06f7fe5c
	System.Single get_PosX(); // 0x06f7fed4
	System.Void set_PosX(System.Single value); // 0x06f7ff38
	System.Single get_PosY(); // 0x06f7ffb0
	System.Void set_PosY(System.Single value); // 0x06f80014
	System.Single get_PosZ(); // 0x06f8008c
	System.Void set_PosZ(System.Single value); // 0x06f800f0
	System.Single get_PlatformPosX(); // 0x06f80168
	System.Void set_PlatformPosX(System.Single value); // 0x06f801cc
	System.Single get_PlatformPosY(); // 0x06f80244
	System.Void set_PlatformPosY(System.Single value); // 0x06f802a8
	System.Single get_PlatformPosZ(); // 0x06f80320
	System.Void set_PlatformPosZ(System.Single value); // 0x06f80384
	System.Int64 get_PlatformId(); // 0x06f803fc
	System.Void set_PlatformId(System.Int64 value); // 0x06f80460
	System.Single get_Height(); // 0x06f804d8
	System.Void set_Height(System.Single value); // 0x06f8053c
	System.Int64 get_MountableId(); // 0x06f805b4
	System.Void set_MountableId(System.Int64 value); // 0x06f80618
	System.Single get_VehiclePosX(); // 0x06f80690
	System.Void set_VehiclePosX(System.Single value); // 0x06f806f4
	System.Single get_VehiclePosY(); // 0x06f8076c
	System.Void set_VehiclePosY(System.Single value); // 0x06f807d0
	System.Single get_VehiclePosZ(); // 0x06f80848
	System.Void set_VehiclePosZ(System.Single value); // 0x06f808ac
	System.Void set_VehicleVelX(System.Single value); // 0x06f80924
	System.Void set_VehicleVelY(System.Single value); // 0x06f8099c
	System.Void set_VehicleVelZ(System.Single value); // 0x06f80a14
	System.Single get_VehicleRotateX(); // 0x06f80a8c
	System.Void set_VehicleRotateX(System.Single value); // 0x06f80af0
	System.Single get_VehicleRotateY(); // 0x06f80b68
	System.Void set_VehicleRotateY(System.Single value); // 0x06f80bcc
	System.Single get_VehicleRotateZ(); // 0x06f80c44
	System.Void set_VehicleRotateZ(System.Single value); // 0x06f80ca8
	System.Boolean get_IsGround(); // 0x06f80d20
	System.Void set_IsGround(System.Boolean value); // 0x06f80d84
	System.Void CopyFrom(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, UnityEngine.Rigidbody rigid); // 0x0552af00
	System.Void .ctor(); // 0x06f818d4
	static System.Void .cctor(); // 0x06f8193c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HistoryThrowEntity : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Single <MoveTime>k__BackingField; // 0x1c
	System.Single <PosX>k__BackingField; // 0x20
	System.Single <PosY>k__BackingField; // 0x24
	System.Single <PosZ>k__BackingField; // 0x28
	System.Single <LocalPosX>k__BackingField; // 0x2c
	System.Single <LocalPosY>k__BackingField; // 0x30
	System.Single <LocalPosZ>k__BackingField; // 0x34
	System.Int64 <TargetEntityID>k__BackingField; // 0x38
	System.Single get_MoveTime(); // 0x06f81a10
	System.Void set_MoveTime(System.Single value); // 0x06f81a74
	System.Single get_PosX(); // 0x06f81aec
	System.Void set_PosX(System.Single value); // 0x06f81b50
	System.Single get_PosY(); // 0x06f81bc8
	System.Void set_PosY(System.Single value); // 0x06f81c2c
	System.Single get_PosZ(); // 0x06f81ca4
	System.Void set_PosZ(System.Single value); // 0x06f81d08
	System.Single get_LocalPosX(); // 0x06f81d80
	System.Void set_LocalPosX(System.Single value); // 0x06f81de4
	System.Single get_LocalPosY(); // 0x06f81e5c
	System.Void set_LocalPosY(System.Single value); // 0x06f81ec0
	System.Single get_LocalPosZ(); // 0x06f81f38
	System.Void set_LocalPosZ(System.Single value); // 0x06f81f9c
	System.Int64 get_TargetEntityID(); // 0x06f82014
	System.Void set_TargetEntityID(System.Int64 value); // 0x06f82078
	System.Void .ctor(); // 0x06f820f0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HistoryVehicleEntity : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06f82158
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HistoryWeaponEntity : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 <EntityId>k__BackingField; // 0x20
	System.Int32 <Clips>k__BackingField; // 0x28
	System.Int32 <UsingAmmoId>k__BackingField; // 0x2c
	System.Int32 <LastAmmoId>k__BackingField; // 0x30
	System.Int64 <SkinId>k__BackingField; // 0x38
	System.Int64 <NextFireTime>k__BackingField; // 0x40
	System.Int32 <FireInterval>k__BackingField; // 0x48
	System.Int64 <NextClipConsumeTime>k__BackingField; // 0x50
	System.Single <Condition>k__BackingField; // 0x58
	System.Int32 <SubClipConsumed>k__BackingField; // 0x5c
	System.Int64 <NextBurstFireTime>k__BackingField; // 0x60
	System.Int64 <BurstFireCount>k__BackingField; // 0x68
	System.Boolean <IsReloading>k__BackingField; // 0x70
	System.Int32 <ContinueReloadAmmoID>k__BackingField; // 0x74
	System.Int32 <StepReloadingAmmoAmount>k__BackingField; // 0x78
	System.Int64 Acc0Id; // 0x80
	System.Int64 Acc1Id; // 0x88
	System.Int64 Acc2Id; // 0x90
	System.Int64 Acc3Id; // 0x98
	System.Int64 get_EntityId(); // 0x06f821c0
	System.Void set_EntityId(System.Int64 value); // 0x06f82224
	System.Int32 get_Clips(); // 0x06f8229c
	System.Void set_Clips(System.Int32 value); // 0x06f82300
	System.Int32 get_UsingAmmoId(); // 0x06f82378
	System.Void set_UsingAmmoId(System.Int32 value); // 0x06f823dc
	System.Void set_LastAmmoId(System.Int32 value); // 0x06f82454
	System.Int64 get_SkinId(); // 0x06f824cc
	System.Void set_SkinId(System.Int64 value); // 0x06f82530
	System.Void set_NextFireTime(System.Int64 value); // 0x06f825a8
	System.Int32 get_FireInterval(); // 0x06f82620
	System.Void set_FireInterval(System.Int32 value); // 0x06f82684
	System.Void set_NextClipConsumeTime(System.Int64 value); // 0x06f826fc
	System.Single get_Condition(); // 0x06f82774
	System.Void set_Condition(System.Single value); // 0x06f827d8
	System.Void set_SubClipConsumed(System.Int32 value); // 0x06f82850
	System.Void set_NextBurstFireTime(System.Int64 value); // 0x06f828c8
	System.Void set_BurstFireCount(System.Int64 value); // 0x06f82940
	System.Void set_IsReloading(System.Boolean value); // 0x06f829b8
	System.Void set_ContinueReloadAmmoID(System.Int32 value); // 0x06f82a34
	System.Void set_StepReloadingAmmoAmount(System.Int32 value); // 0x06f82aac
	System.Void .ctor(); // 0x06f82b24
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.EHorseAnimType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.EHorseAnimType Idle = 0;
	static WizardGames.Soc.Common.Entity.EHorseAnimType Locomotion = 1;
	static WizardGames.Soc.Common.Entity.EHorseAnimType Jump = 2;
	static WizardGames.Soc.Common.Entity.EHorseAnimType GoToDead = 3;
	static WizardGames.Soc.Common.Entity.EHorseAnimType Dead = 4;
	static WizardGames.Soc.Common.Entity.EHorseAnimType Halter = 5;
	static WizardGames.Soc.Common.Entity.EHorseAnimType Eat = 6;
	static WizardGames.Soc.Common.Entity.EHorseAnimType GetHit = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.EHorseJumpAnimType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.EHorseJumpAnimType JumpStart = 0;
	static WizardGames.Soc.Common.Entity.EHorseJumpAnimType InAir = 1;
	static WizardGames.Soc.Common.Entity.EHorseJumpAnimType JumpEnd = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.HumanoidAnimLocalData : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCache MoveSpeedLocalCache; // 0x10
	WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState PoseLayerState; // 0x34
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LocomotionLayerState; // 0x38
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LastLocomotionLayerState; // 0x3c
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir LocomotionDir; // 0x40
	WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState AdditiveLayerstate; // 0x44
	WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState LastAdditiveLayerstate; // 0x48
	WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState AimOffsetLayerState; // 0x4c
	WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState OverrideLayerState; // 0x50
	WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState LastOverrideLayerState; // 0x54
	System.Single ClientAnimBlendX; // 0x58
	System.Single ClientAnimBlendY; // 0x5c
	System.Single CurrentLerpCrouchStand; // 0x60
	System.Single CurrentLerpHipSight; // 0x64
	System.Boolean ForceMonsterAnimatorUpdate; // 0x68
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer LastEOverrideLayer; // 0x6c
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer EOverrideLayer; // 0x70
	System.Int32 LastTpOcHeldIndex; // 0x74
	System.Int32 NowTpOcHeldIndex; // 0x78
	WizardGames.Soc.Common.Unity.Monster.Animation.OverrideLayerCacheData PrevOverrideCacheData; // 0x7c
	WizardGames.Soc.Common.Unity.Monster.Animation.LocomotionStateCacheData PrevLocomotionStateCache; // 0x98
	System.Boolean OverrideEmptyNeedTransition; // 0xd0
	System.Single ToBattleIdlePoseTime; // 0xd4
	System.Single ToLeisureIdlePoseTime; // 0xd8
	System.Single StartIdle2LocoLerp; // 0xdc
	System.Boolean ToIdlePoseFlag; // 0xe0
	System.Boolean ToLocomotionPoseFlag; // 0xe1
	System.Single LeftIdle2LocoLerp; // 0xe4
	System.Int64 LocomotionLayerTargetWeightTpWeaponId; // 0xe8
	System.Single LocomotionLayerTargetWeightTp; // 0xf0
	System.Single LocomotionLayerOverrideTargetWeightTp; // 0xf4
	System.Single LocomotionLayerNowWeightTp; // 0xf8
	System.Single LocomotionLayerWeightTimeTp; // 0xfc
	System.Single LocomotionLayerWeightSpeedTp; // 0x100
	System.Single LocomotionSpineLayerTargetWeightTp; // 0x104
	System.Single LocomotionSpineLayerOverrideTargetWeightTp; // 0x108
	System.Single LocomotionSpineLayerNowWeightTp; // 0x10c
	System.Single LocomotionSpineLayerWeightTimeTp; // 0x110
	System.Single LocomotionSpineLayerWeightSpeedTp; // 0x114
	System.Single LocomotionWeaponLayerTargetWeightTp; // 0x118
	System.Single LocomotionWeaponLayerOverrideTargetWeightTp; // 0x11c
	System.Single LocomotionWeaponLayerNowWeightTp; // 0x120
	System.Single LocomotionWeaponLayerWeightTimeTp; // 0x124
	System.Single LocomotionWeaponLayerWeightSpeedTp; // 0x128
	System.Single LocomotionLeftArmLayerTargetWeightTp; // 0x12c
	System.Single LocomotionLeftArmLayerOverrideTargetWeightTp; // 0x130
	System.Single LocomotionLeftArmLayerNowWeightTp; // 0x134
	System.Single LocomotionLeftArmLayerWeightTimeTp; // 0x138
	System.Single LocomotionLeftArmLayerWeightSpeedTp; // 0x13c
	System.Single LocomotionRightArmLayerTargetWeightTp; // 0x140
	System.Single LocomotionRightArmLayerOverrideTargetWeightTp; // 0x144
	System.Single LocomotionRightArmLayerNowWeightTp; // 0x148
	System.Single LocomotionRightArmLayerWeightTimeTp; // 0x14c
	System.Single LocomotionRightArmLayerWeightSpeedTp; // 0x150
	WizardGames.Soc.Common.CustomType.WarmAnimType curWarmupAnimType; // 0x154
	System.Boolean BowShowArrow; // 0x155
	System.Single TpLerpAniSpeedX; // 0x158
	System.Single TpLerpAniSpeedZ; // 0x15c
	System.Single TpMapDirectionFB; // 0x160
	System.Single TpMapDirectionLR; // 0x164
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup BoneWeightGroup; // 0x168
	System.Int64 LastMeleeAttackTS; // 0x2f8
	System.Int64 TpAniWeaponId; // 0x300
	System.Int32 ApplyInstanceId; // 0x308
	System.Int32 UpdateIndex; // 0x30c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoBoneWeightGroup; // 0x310
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoBaseBoneWeightGroup; // 0x4a0
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoAddBoneWeightGroup; // 0x630
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup OcBoneWeightGroup; // 0x7c0
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup PoseBoneWeightGroup; // 0x950
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup AoBoneWeightGroup; // 0xae0
	System.Single IkBlendLoc; // 0xc70
	System.Single IkBlendAdd; // 0xc74
	System.Single IkBlendOc; // 0xc78
	System.Single LastIkLocLeft; // 0xc7c
	System.Single LastIkLocRight; // 0xc80
	System.Single LastIkLocHorse; // 0xc84
	System.Single LastIkAddLeft; // 0xc88
	System.Single LastIkAddRight; // 0xc8c
	System.Single LastIkAddHorse; // 0xc90
	System.Single LastIkOcLeft; // 0xc94
	System.Single LastIkOcRight; // 0xc98
	System.Single LastIkOcHorse; // 0xc9c
	System.Single IkFinalLocLeft; // 0xca0
	System.Single IkFinalLocRight; // 0xca4
	System.Single IkFinalLocHorse; // 0xca8
	System.Single IkFinalAddLeft; // 0xcac
	System.Single IkFinalAddRight; // 0xcb0
	System.Single IkFinalAddHorse; // 0xcb4
	System.Single IkFinalOcLeft; // 0xcb8
	System.Single IkFinalOcRight; // 0xcbc
	System.Single IkFinalOcHorse; // 0xcc0
	System.Boolean AoLayerWeightFlag; // 0xcc4
	System.Boolean PoseLayerWeightFlag; // 0xcc5
	WizardGames.Soc.Common.Character.TpClipLengthCollect TpClipCollect; // 0xcc8
	System.Boolean LogicFrame; // 0xd0c
	System.Boolean RenderFrame; // 0xd0d
	System.Int32 LogicInterval; // 0xd10
	System.Int32 RenderInterval; // 0xd14
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.MeleeAttackRequest : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.PlayerLogicParams P; // 0x10
	WizardGames.Soc.Common.CustomType.MeleeCustom melee; // 0x18
	WizardGames.Soc.Common.Data.holdItem.MeleeHitBox HitBoxInfo; // 0x20
	WizardGames.Soc.Common.Data.holdItem.HoldItemBase HoldItemTb; // 0x28
	WizardGames.Soc.Common.Data.holdItem.MeleeBase MeleeTb; // 0x30
	System.Single AttackRange; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseMgrEntity : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.Common.Entity.Collection.EntitySetCollection EntitySet; // 0x18
	System.Action<WizardGames.Soc.Common.Entity.IEmbeddedCustom> OnEntityCustomTypeCreate; // 0x20
	System.Action<WizardGames.Soc.Common.Entity.IEmbeddedCustom> OnEntityCustomTypeRemove; // 0x28
	System.Action<WizardGames.Soc.Common.Entity.PlayerEntity> OnPlayerEntityCreate; // 0x30
	System.Action<WizardGames.Soc.Common.Entity.PlayerEntity> OnPlayerEntityMoveAction; // 0x38
	System.Action<WizardGames.Soc.Common.Entity.IEntity> OnEntityCreate; // 0x40
	System.Action<WizardGames.Soc.Share.Framework.EntityBase> OnFullEntityCreate; // 0x48
	System.Action<WizardGames.Soc.Common.Entity.IEntity> OnEntityBeforeRemove; // 0x50
	System.Action<WizardGames.Soc.Common.Entity.IEntity> OnEntityRemove; // 0x58
	System.Action<WizardGames.Soc.Share.Framework.EntityBase> OnFullEntityDowngrade; // 0x60
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Entity.IEntity,System.Collections.Generic.HashSet<System.Action<WizardGames.Soc.Common.Entity.IEntity>>> entityRemoveActionMap; // 0x68
	System.Void Init(); // 0x06f82b8c
	System.Void InvokeEntityRemoveAction(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f82c2c
	System.Void EntitySetAddHandle(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x06f82e14
	System.Void EntitySetRemoveHandle(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x06f82ea8
	WizardGames.Soc.Common.Entity.IEntity GetEntityViaType(System.Type EntityType, System.Int64 Id, System.Boolean local); // 0x06f82f3c
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaType<T>(System.Boolean local); // 0x052af1f0
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaInterface<T>(System.Boolean local); // 0x052af1f0
	System.Void .ctor(); // 0x06f82fd4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseMgrLocalEntity : WizardGames.Soc.Common.Entity.BaseMgrEntity
{
	static SocLogger logger; // 0x0
	System.Int64 SnapshotSequence; // 0x70
	System.Int64 SnapshotWorldTime; // 0x78
	System.Action<System.Int64,System.Int64,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase>,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom>> EntitiesUpdatedFull; // 0x80
	WizardGames.Soc.Common.Utility.Counter ParseSnapshotTimer; // 0x88
	WizardGames.Soc.Common.Utility.Counter UpdateEntityTimer; // 0x90
	WizardGames.Soc.Common.Utility.Counter AfterParseTimer; // 0x98
	System.Collections.Generic.IReadOnlyDictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> get_Entities(); // 0x06f83088
	System.Void Init(); // 0x06f831b8
	System.Void ParseFullSnapshot(WizardGames.Soc.Common.SimpleCustom.Snapshot snapshot, WizardGames.Soc.Common.Synchronization.SnapshotIncremental snapshotIncremental); // 0x0552af00
	WizardGames.Soc.Common.Entity.IEntity GetEntity(System.Int64 id); // 0x06f8321c
	System.Boolean TryGetEntity<T>(System.Int64 id, T& entity); // 0x052af1f0
	System.Void ParseIncrementalSnapshot(WizardGames.Soc.Common.Synchronization.SnapshotIncremental inc); // 0x05523a54
	System.Void AddEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local, System.Boolean isLoadFromDB); // 0x06f833c8
	System.Void AfterAddEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local, System.Boolean isLoadFromDB, System.Int32 lodLevel); // 0x06f83594
	System.Void OnCreateEntities(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> createResult); // 0x06f8374c
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean isMaster); // 0x06f83d14
	System.Void AfterRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f83d90
	System.Void BeforeRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f83fe0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> UpdateHandleOffLinePlayerEntities(); // 0x06f84178
	System.Void .ctor(); // 0x06f841dc
	static System.Void .cctor(); // 0x06f842d4
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ICombatEntity : , WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Int64 get_TemplateId(); // 0x054a4380
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.StateEnumAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06f843a8
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IAttachedEntity : 
{
	
	System.Int64 get_TargetEntityID(); // 0x054a4380
	System.Void set_TargetEntityID(System.Int64 value); // 0x055112ac
	System.Int32 get_TargetColliderIndex(); // 0x0548ba98
	System.Void set_TargetColliderIndex(System.Int32 value); // 0x055056e8
	System.Single get_PosOffsetX(); // 0x054a5abc
	System.Void set_PosOffsetX(System.Single value); // 0x05513724
	System.Single get_PosOffsetY(); // 0x054a5abc
	System.Void set_PosOffsetY(System.Single value); // 0x05513724
	System.Single get_PosOffsetZ(); // 0x054a5abc
	System.Void set_PosOffsetZ(System.Single value); // 0x05513724
	System.Single get_RotOffsetX(); // 0x054a5abc
	System.Void set_RotOffsetX(System.Single value); // 0x05513724
	System.Single get_RotOffsetY(); // 0x054a5abc
	System.Void set_RotOffsetY(System.Single value); // 0x05513724
	System.Single get_RotOffsetZ(); // 0x054a5abc
	System.Void set_RotOffsetZ(System.Single value); // 0x05513724
	System.Single get_RotOffsetW(); // 0x054a5abc
	System.Void set_RotOffsetW(System.Single value); // 0x05513724
	System.Void set_AttachedTransform(UnityEngine.Transform value); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IConditionConsumeEntity : , WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Boolean get_IsUsing(); // 0x054c4760
	System.Single get_ConditionConsumeMS(); // 0x054a5abc
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ICorpseableEntity : , WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IEquipEntity : , WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Void set_LocalEquipVersion(System.Int32 value); // 0x055056e8
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> EnumWearedItem(); // 0x054e7844
	System.Int32 get_EquipVersion(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IHaveBulletEntity : , WizardGames.Soc.Common.Entity.IHeldItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Void set_UsingAmmoNodeId(System.Int64 value); // 0x055112ac
	System.Int32 get_LastAmmoId(); // 0x0548ba98
	System.Void set_LastAmmoId(System.Int32 value); // 0x055056e8
	System.Int32 get_ClipCapacity(); // 0x0548ba98
	System.Int32 get_ContinueReloadingAmmoID(); // 0x0548ba98
	System.Void set_ContinueReloadingAmmoID(System.Int32 value); // 0x055056e8
	System.Int32 get_ReloadTime(); // 0x0548ba98
	System.Int32 get_TotalReloadTime(); // 0x0548ba98
	System.Boolean get_IsReloading(); // 0x054c4760
	System.Void set_IsReloading(System.Boolean value); // 0x05523a7c
	System.Int32 get_StepReloadingAmmoAmount(); // 0x0548ba98
	System.Void set_StepReloadingAmmoAmount(System.Int32 value); // 0x055056e8
	System.Void set_IsEmptyReload(System.Boolean value); // 0x05523a7c
	System.Boolean get_EmptyClip(); // 0x054c4760
	System.Boolean get_InsufficientClip(); // 0x054c4760
	System.Boolean get_CanFireReload(); // 0x054c4760
	System.Int32 get_SingleReloadClipNum(); // 0x0548ba98
	System.Boolean get_HasReloadStart(); // 0x054c4760
	System.Boolean get_HasReloadEnd(); // 0x054c4760
	System.Int32[] get_AvailableAmmos(); // 0x054e7844
	System.Int32 ExpectReloadTime(System.Int32 ammoCnt, System.Boolean followPerform); // 0x0548c30c
	System.Int32 get_UsingAmmoId(); // 0x0548ba98
	System.Void set_UsingAmmoId(System.Int32 value); // 0x055056e8
	System.Int32 get_Clips(); // 0x0548ba98
	System.Void set_Clips(System.Int32 value); // 0x055056e8
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IHeldItemEntity : , WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Void OnDeploy(); // 0x055049cc
	System.Void OnHolster(); // 0x055049cc
	System.Int32 get_TemplateId(); // 0x0548ba98
	System.Int64 get_NextFireTime(); // 0x054a4380
	System.Void set_NextFireTime(System.Int64 value); // 0x055112ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IHitableEntity : 
{
	
	System.Single get_Hp(); // 0x054a5abc
	System.Void set_Hp(System.Single value); // 0x05513724
	System.Single get_MaxHp(); // 0x054a5abc
	System.Void set_MaxHp(System.Single value); // 0x05513724
	System.Int32 get_CombatTemplateId(); // 0x0548ba98
	System.Void set_CombatTemplateId(System.Int32 value); // 0x055056e8
	System.Void set_DefenseTemplateId(System.Int32 value); // 0x055056e8
	System.Single[] get_BaseProtection(); // 0x054e7844
	System.Void set_BaseProtection(System.Single[] value); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IHostileEntity : 
{
	
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.RebornRequestType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.RebornRequestType None = 0;
	static WizardGames.Soc.Common.Entity.RebornRequestType RandomPos = 1;
	static WizardGames.Soc.Common.Entity.RebornRequestType Nearby = 2;
	static WizardGames.Soc.Common.Entity.RebornRequestType RingRandomPos = 3;
	static WizardGames.Soc.Common.Entity.RebornRequestType OutpostRandomPos = 4;
	static WizardGames.Soc.Common.Entity.RebornRequestType Archive = 5;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ILifeCycleEntity : 
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IMetabolismEntity : , WizardGames.Soc.Common.Entity.IEntity
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IMountVehicleEntity : , WizardGames.Soc.Common.Entity.IMovableEntity, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Int32 get_MountSeatIndex(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IMovableEntity : , WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Single get_PosX(); // 0x054a5abc
	System.Void set_PosX(System.Single value); // 0x05513724
	System.Single get_PosY(); // 0x054a5abc
	System.Void set_PosY(System.Single value); // 0x05513724
	System.Single get_PosZ(); // 0x054a5abc
	System.Void set_PosZ(System.Single value); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IPlatformEntity : 
{
	
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x054e7844
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x055112ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IRFDetonationEntity : , WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IEntity
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IShortcutEntity : , WizardGames.Soc.Common.Entity.IEntity
{
	
	WizardGames.Soc.Common.Entity.IItemEntity GetItemEntity(System.Int32 id); // 0x054e7c9c
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ISustainAttackEntity : 
{
	
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.TpLadderEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.TpLadderEnum Empty = 0;
	static WizardGames.Soc.Common.Entity.TpLadderEnum UpEnter = 1;
	static WizardGames.Soc.Common.Entity.TpLadderEnum UpLeave = 2;
	static WizardGames.Soc.Common.Entity.TpLadderEnum DownEnter = 3;
	static WizardGames.Soc.Common.Entity.TpLadderEnum DownLeave = 4;
	static WizardGames.Soc.Common.Entity.TpLadderEnum LadderMove = 5;
	static WizardGames.Soc.Common.Entity.TpLadderEnum ProcedureAnim = 6;
	static WizardGames.Soc.Common.Entity.TpLadderEnum Wait = 7;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Entity.TpAniPlayerLocalData : System.ValueType
{
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCacheGroup MoveSpeedLocalCaches; // 0x10
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum NowPoseStateCacheTp; // 0xc4
	System.Single LerpStandCrouchTimeTp; // 0xc8
	System.Single LerpIdleAoTimeTp; // 0xcc
	System.Boolean NeedLerpIdleAoUpdate; // 0xd0
	System.Single LastIdleAoYaw; // 0xd4
	System.Single LastLerpIdleAoYaw; // 0xd8
	System.Single LerpStandCrouchTp; // 0xdc
	System.Int32 YawSignLocalMount; // 0xe0
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EPoseLayer EPoseLayer; // 0xe4
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EPoseLayer LastEPoseLayer; // 0xe8
	System.Single LastLerpAimYawMountBack; // 0xec
	System.Single LastLerpAimYawMount; // 0xf0
	System.Int32 LastYawSignMount; // 0xf4
	System.Int32 CmdYawSignMount; // 0xf8
	System.Int32 TurnDirectionMount; // 0xfc
	System.Single TurnTargetAngleMount; // 0x100
	System.Single AimYawLocalMount; // 0x104
	System.Single LerpAdsTp; // 0x108
	System.Single StartStance2LocoLerp; // 0x10c
	System.Single LeftStance2LocoLerp; // 0x110
	System.Single TpToLocomotionTime; // 0x114
	System.Single TpToStanceTime; // 0x118
	System.Single TpLerpAniSpeedX; // 0x11c
	System.Single TpLerpAniSpeedZ; // 0x120
	System.Int32 TpHorseJumpIndex; // 0x124
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoBoneWeightGroup; // 0x128
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoBaseBoneWeightGroup; // 0x2b8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup LocoAddBoneWeightGroup; // 0x448
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup OcBoneWeightGroup; // 0x5d8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup PoseBoneWeightGroup; // 0x768
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup AoBoneWeightGroup; // 0x8f8
	WizardGames.Soc.Common.Entity.TpLadderEnum TpLadder; // 0xa88
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer subLadderLocomotionLayer; // 0xa8c
	System.Boolean tpLadderMove; // 0xa90
	System.Single LocalSpeedX; // 0xa94
	System.Single LocalSpeedZ; // 0xa98
	System.Single TpMapDirectionFB; // 0xa9c
	System.Single TpMapDirectionLR; // 0xaa0
	System.Single AdsLerpAlpha; // 0xaa4
	System.Single MoveForward; // 0xaa8
	System.Single MoveRight; // 0xaac
	System.Single TpLastMoveForward; // 0xab0
	System.Single TpLastMoveRight; // 0xab4
	System.Int32 HorseMountDir; // 0xab8
	System.Single LastAnimSteerAngleTp; // 0xabc
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAimOffsetLayer EAimOffsetLayer; // 0xac0
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAimOffsetLayer LastEAimOffsetLayer; // 0xac4
	System.Single LastUpDown; // 0xac8
	System.Single PreUpDown; // 0xacc
	System.Int32 CmdYawSign; // 0xad0
	System.Int32 LastYawSign; // 0xad4
	System.Int32 YawSignLocal; // 0xad8
	System.Int32 TurnDirection; // 0xadc
	System.Single AimYawLocal; // 0xae0
	System.Single LastLerpAimYaw; // 0xae4
	System.Single TurnTargetAngle; // 0xae8
	System.Int64 TpAniWeaponId; // 0xaf0
	System.Int32 ApplyInstanceId; // 0xaf8
	System.Int32 UpdateIndex; // 0xafc
	System.Single DebugPara1; // 0xb00
	System.Single DebugPara2; // 0xb04
	System.Single DebugPara3; // 0xb08
	System.Single DebugPara4; // 0xb0c
	System.Single DebugPara5; // 0xb10
	System.Single DebugPara6; // 0xb14
	System.Single DebugPara7; // 0xb18
	System.Single DebugPara8; // 0xb1c
	System.Single DebugPara9; // 0xb20
	System.Single DebugPara10; // 0xb24
	System.Single DebugPara11; // 0xb28
	System.Single DebugPara12; // 0xb2c
	System.Single DebugPara13; // 0xb30
	System.Single DebugPara14; // 0xb34
	System.Single DebugPara15; // 0xb38
	System.Single DebugPara16; // 0xb3c
	System.Single DebugPara17; // 0xb40
	System.Single DebugPara18; // 0xb44
	System.Single DebugPara19; // 0xb48
	System.Single DebugPara20; // 0xb4c
	System.Boolean EnableDriveUro; // 0xb50
	System.Boolean AlwaysUpdate; // 0xb51
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer LastEOverrideLayer; // 0xb54
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer EOverrideLayer; // 0xb58
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer LastELocomotionLayer; // 0xb5c
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer ELocomotionLayer; // 0xb60
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer LastEAdditiveLayer; // 0xb64
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer EAdditiveLayer; // 0xb68
	System.Single IkBlendLoc; // 0xb6c
	System.Single IkBlendAdd; // 0xb70
	System.Single IkBlendOc; // 0xb74
	System.Single LastIkLocLeft; // 0xb78
	System.Single LastIkLocRight; // 0xb7c
	System.Single LastIkLocHorse; // 0xb80
	System.Single LastIkAddLeft; // 0xb84
	System.Single LastIkAddRight; // 0xb88
	System.Single LastIkAddHorse; // 0xb8c
	System.Single LastIkOcLeft; // 0xb90
	System.Single LastIkOcRight; // 0xb94
	System.Single LastIkOcHorse; // 0xb98
	System.Single IkFinalLocLeft; // 0xb9c
	System.Single IkFinalLocRight; // 0xba0
	System.Single IkFinalLocHorse; // 0xba4
	System.Single IkFinalAddLeft; // 0xba8
	System.Single IkFinalAddRight; // 0xbac
	System.Single IkFinalAddHorse; // 0xbb0
	System.Single IkFinalOcLeft; // 0xbb4
	System.Single IkFinalOcRight; // 0xbb8
	System.Single IkFinalOcHorse; // 0xbbc
	WizardGames.Soc.Common.Character.TpClipLengthCollect TpClipCollect; // 0xbc0
	System.Boolean AoLayerWeightFlag; // 0xc04
	System.Boolean PoseLayerWeightFlag; // 0xc05
	System.Boolean PlayInteraction; // 0xc06
	System.Boolean NeedForceLogicFrameSwitchWeapon; // 0xc07
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer InteractionType; // 0xc08
	System.Single ToInteractionTransitionTime; // 0xc0c
	System.Boolean InJumpEndInput; // 0xc10
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer LastOverrideLayerState; // 0xc14
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer NowOverrideLayerState; // 0xc18
	WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType LastOcHeldStateToLocomotion; // 0xc1c
	WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType NowOcHeldStateToLocomotion; // 0xc20
	System.Int32 TurnInPlaceDirection; // 0xc24
	System.Boolean TipOver; // 0xc28
	System.Single AnimRotation; // 0xc2c
	System.Single AnimTurnInPlaceDeltaAngle; // 0xc30
	System.Single LastAimYawLocal; // 0xc34
	System.Boolean OverrideEmptyNeedTransition; // 0xc38
	System.Boolean SwitchTpAnimator; // 0xc39
	System.Boolean OverrideLayerStateChange; // 0xc3a
	System.Boolean PoseNeedTransition; // 0xc3b
	System.Boolean LogicFrame; // 0xc3c
	System.Boolean RenderFrame; // 0xc3d
	System.Boolean LogicToRenderFrame; // 0xc3e
	System.Boolean WantLogicToRenderFrame; // 0xc3f
	System.Boolean LogicWantToIdleState; // 0xc40
	System.Single LogicWantToIdleStateTransitionTime; // 0xc44
	System.Int32 LogicInterval; // 0xc48
	System.Int32 RenderInterval; // 0xc4c
	System.Single TpHeight; // 0xc50
	System.Void SetLogicToRenderFrame(System.Boolean logicToRenderFrame); // 0x06f84410
	System.Void SetWantLogicToRenderFrame(System.Boolean wantLogicToRenderFrame, System.Boolean force); // 0x06f8448c
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType IdleStand = 0;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType IdleCrouch = 1;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType JogStand = 2;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType JogCrouch = 3;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType Sprint = 4;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType Jump = 5;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType SwimIdle = 6;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType SwimJog = 7;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType SwimSprint = 8;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType Ladder = 9;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType Horse = 10;
	static WizardGames.Soc.Common.Entity.TpAniPlayerLocalData.ETpOcStateToLocoType Vehicle = 11;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.IPlatformEntityHelper : System.Object
{
	
	static System.Void TakeInEntity(WizardGames.Soc.Common.Entity.IPlatformEntity ent, System.Int64 entityId); // 0x06f8451c
	static System.Void TakeOffEntity(WizardGames.Soc.Common.Entity.IPlatformEntity ent, System.Int64 entityId); // 0x06f846a4
	static System.Boolean CanPlatform(WizardGames.Soc.Common.Entity.IPlatformEntity ent, WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig); // 0x06f84828
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IPlayerPredictEntity : 
{
	
	System.Int32 get_ClientTime(); // 0x0548ba98
	System.Void set_ClientTime(System.Int32 value); // 0x055056e8
	System.Int64 get_CmdAck(); // 0x054a4380
	System.Void set_CmdAck(System.Int64 value); // 0x055112ac
	System.Int64 get_RenderTime(); // 0x054a4380
	System.Void set_RenderTime(System.Int64 value); // 0x055112ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IRotation3Entity : , WizardGames.Soc.Common.Entity.IRotationEntity
{
	
	System.Single get_RotateX(); // 0x054a5abc
	System.Void set_RotateX(System.Single value); // 0x05513724
	System.Single get_RotateZ(); // 0x054a5abc
	System.Void set_RotateZ(System.Single value); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IRotationEntity : 
{
	
	System.Single get_RotateY(); // 0x054a5abc
	System.Void set_RotateY(System.Single value); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IEntity : 
{
	
	WizardGames.Soc.Common.Entity.IEntity get_RootParent(); // 0x054e7844
	System.Int64 get_EntityId(); // 0x054a4380
	System.Int32 get_EntityType(); // 0x0548ba98
	System.Boolean get_IsAttachedToMgr(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IEmbeddedCustom : , WizardGames.Soc.Common.Entity.IEntity
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IHaveEmbedded : 
{
	
	System.Void InvokeChildOnCustomCreate(); // 0x055049cc
	System.Void InvokeChildOnCustomRemove(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TerritoryEntityHotfix : System.Object
{
	
	static System.Boolean CannotCaputred(WizardGames.Soc.Common.Entity.TerritoryEntity self); // 0x06f8493c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.TerritoryManagerEntityHotfix : System.Object
{
	
	static System.Void AddTerritory(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Int64 terrId, WizardGames.Soc.Common.Algorithm.Vector3 position); // 0x06f84bc8
	static System.Void RemoveTerritory(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Int64 terrId); // 0x06f85010
	static WizardGames.Soc.Common.Entity.TerritoryEntity GetInChargeTerritoryEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, WizardGames.Soc.Common.Algorithm.Vector3 pos); // 0x06f7c934
	static System.Void GetSurroundingTerritory(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.TerritoryEntity> result, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Single range, System.Single height); // 0x06f853d0
	static System.Void GetSurroundingTerritory(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.TerritoryEntity> result, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Single range, System.Single height, System.Int64 exceptTerritoryId); // 0x06f854b0
	static System.Boolean IsColliding(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Single x, System.Single z, System.Single range); // 0x06f85a04
	static WizardGames.Soc.Common.Entity.TerritoryEntity FindAnyOtherTerritoryEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Single radius, System.Single height, System.Int64 ignoredToolBoxId, System.Boolean canFindDeserted); // 0x06f85cf4
	static System.Void AddWildEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, WizardGames.Soc.Common.Entity.WildEntity entity); // 0x06f77b4c
	static System.Void RemoveWildEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, WizardGames.Soc.Common.Entity.WildEntity entity); // 0x06f77e64
	static WizardGames.Soc.Common.Entity.WildEntity GetWildEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06f85fe0
	static WizardGames.Soc.Common.Entity.WildEntity GetWildEntity(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Single posX, System.Single posZ); // 0x06f86090
	static System.Int32 GetWildIndex(WizardGames.Soc.Common.Entity.TerritoryManagerEntity self, System.Single posX, System.Single posZ); // 0x06f8624c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CustomTypeStaticInfo : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Boolean> CustomType2AbstractFlag; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> ChildCustomType; // 0x8
	static System.Void .cctor(); // 0x06f8637c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityTypeId : System.Object
{
	static System.Int32 MaxEntityTypeId; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.Int32> EntityName2Type; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,System.String> EntityType2Name; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.Type> EntityType2Class; // 0x18
	static System.Collections.Generic.Dictionary<System.Type,System.Int32> EntityClass2Type; // 0x20
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> EntityHash2EntityType; // 0x28
	static System.Collections.Generic.HashSet<System.Int32> GlobalEntities; // 0x30
	static System.Void .cctor(); // 0x06f8bf70
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MountPointPoseType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MountPointPoseType Sit = 0;
	static WizardGames.Soc.Common.Entity.MountPointPoseType Stand = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.MountPointProtectType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.MountPointProtectType Invalid = 0;
	static WizardGames.Soc.Common.Entity.MountPointProtectType Complete = 1;
	static WizardGames.Soc.Common.Entity.MountPointProtectType Normal = 2;
	static WizardGames.Soc.Common.Entity.MountPointProtectType NoProtect = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IBaseVehicleEntity : , WizardGames.Soc.Common.Entity.IBaseMountableEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	
	System.Single get_Steering(); // 0x054a5abc
	System.Void set_Steering(System.Single value); // 0x05513724
	System.Single get_GasPedal(); // 0x054a5abc
	System.Void set_GasPedal(System.Single value); // 0x05513724
	System.Single get_Break(); // 0x054a5abc
	System.Void set_Break(System.Single value); // 0x05513724
	System.Single get_Throttle(); // 0x054a5abc
	System.Void set_Throttle(System.Single value); // 0x05513724
	System.Boolean get_LightsAreOn(); // 0x054c4760
	System.Void set_LightsAreOn(System.Boolean value); // 0x05523a7c
	System.Single get_DriveWheelVelocity(); // 0x054a5abc
	System.Void set_DriveWheelVelocity(System.Single value); // 0x05513724
	System.Single get_SteerAngle(); // 0x054a5abc
	System.Void set_SteerAngle(System.Single value); // 0x05513724
	System.Single get_DriveWheelSlip(); // 0x054a5abc
	System.Void set_DriveWheelSlip(System.Single value); // 0x05513724
	System.Boolean get_IsGrounded(); // 0x054c4760
	System.Void set_IsGrounded(System.Boolean value); // 0x05523a7c
	System.Boolean get_IsEngineStartFailed(); // 0x054c4760
	System.Void set_IsEngineStartFailed(System.Boolean value); // 0x05523a7c
	System.Boolean get_IsInterior(); // 0x054c4760
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.EImpeachState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.EImpeachState None = 0;
	static WizardGames.Soc.Common.Entity.EImpeachState Applying = 1;
	static WizardGames.Soc.Common.Entity.EImpeachState Voting = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.ETestCustomTypeEnum : System.Enum
{
	System.Int64 value__; // 0x10
	static WizardGames.Soc.Common.Entity.ETestCustomTypeEnum Int = 0;
