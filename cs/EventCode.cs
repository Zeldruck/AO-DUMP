enum EventCodes
{
    Unused,
    Leave,
    JoinFinished,
    Move,
    Teleport,
    ChangeEquipment,
    HealthUpdate,
    HealthUpdates,
    EnergyUpdate,
    DamageShieldUpdate,
    CraftingFocusUpdate,
    ActiveSpellEffectsUpdate,
    ResetCooldowns,
    Attack,
    CastStart,
    ChannelingUpdate,
    CastCancel,
    CastTimeUpdate,
    CastFinished,
    CastSpell,
    CastSpells,
    CastHit,
    CastHits,
    StoredTargetsUpdate,
    ChannelingEnded,
    AttackBuilding,
    InventoryPutItem,
    InventoryDeleteItem,
    InventoryState,
    NewCharacter,
    NewEquipmentItem,
    NewSiegeBannerItem,
    NewSimpleItem,
    NewFurnitureItem,
    NewKillTrophyItem,
    NewJournalItem,
    NewLaborerItem,
    NewEquipmentItemLegendarySoul,
    NewSimpleHarvestableObject,
    NewSimpleHarvestableObjectList,
    NewHarvestableObject,
    NewTreasureDestinationObject,
    TreasureDestinationObjectStatus,
    CloseTreasureDestinationObject,
    NewSilverObject,
    NewBuilding,
    HarvestableChangeState,
    MobChangeState,
    FactionBuildingInfo,
    CraftBuildingInfo,
    RepairBuildingInfo,
    MeldBuildingInfo,
    ConstructionSiteInfo,
    PlayerBuildingInfo,
    FarmBuildingInfo,
    TutorialBuildingInfo,
    LaborerObjectInfo,
    LaborerObjectJobInfo,
    MarketPlaceBuildingInfo,
    HarvestStart,
    HarvestCancel,
    HarvestFinished,
    TakeSilver,
    RemoveSilver,
    ActionOnBuildingStart,
    ActionOnBuildingCancel,
    ActionOnBuildingFinished,
    ItemRerollQualityFinished,
    InstallResourceStart,
    InstallResourceCancel,
    InstallResourceFinished,
    CraftItemFinished,
    LogoutCancel,
    ChatMessage,
    ChatSay,
    ChatWhisper,
    ChatMuted,
    PlayEmote,
    StopEmote,
    SystemMessage,
    UtilityTextMessage,
    UpdateMoney,
    UpdateFame,
    UpdateLearningPoints,
    UpdateReSpecPoints,
    UpdateCurrency,
    UpdateFactionStanding,
    UpdateMistCityStanding,
    Respawn,
    ServerDebugLog,
    CharacterEquipmentChanged,
    RegenerationHealthChanged,
    RegenerationEnergyChanged,
    RegenerationMountHealthChanged,
    RegenerationCraftingChanged,
    RegenerationHealthEnergyComboChanged,
    RegenerationPlayerComboChanged,
    DurabilityChanged,
    NewLoot,
    AttachItemContainer,
    DetachItemContainer,
    InvalidateItemContainer,
    LockItemContainer,
    GuildUpdate,
    GuildPlayerUpdated,
    InvitedToGuild,
    GuildMemberWorldUpdate,
    UpdateMatchDetails,
    ObjectEvent,
    NewMonolithObject,
    MonolithHasBannersPlacedUpdate,
    NewOrbObject,
    NewCastleObject,
    NewSpellEffectArea,
    UpdateSpellEffectArea,
    NewChainSpell,
    UpdateChainSpell,
    NewTreasureChest,
    StartMatch,
    StartArenaMatchInfos,
    EndArenaMatch,
    MatchUpdate,
    ActiveMatchUpdate,
    NewMob,
    DebugMobInfo,
    DebugVariablesInfo,
    DebugReputationInfo,
    DebugDiminishingReturnInfo,
    DebugSmartClusterQueueInfo,
    ClaimOrbStart,
    ClaimOrbFinished,
    ClaimOrbCancel,
    OrbUpdate,
    OrbClaimed,
    OrbReset,
    NewWarCampObject,
    NewMatchLootChestObject,
    NewArenaExit,
    GuildMemberTerritoryUpdate,
    InvitedMercenaryToMatch,
    ClusterInfoUpdate,
    ForcedMovement,
    ForcedMovementCancel,
    CharacterStats,
    CharacterStatsKillHistory,
    CharacterStatsDeathHistory,
    GuildStats,
    KillHistoryDetails,
    FullAchievementInfo,
    FinishedAchievement,
    AchievementProgressInfo,
    FullAchievementProgressInfo,
    FullTrackedAchievementInfo,
    FullAutoLearnAchievementInfo,
    QuestGiverQuestOffered,
    QuestGiverDebugInfo,
    ConsoleEvent,
    TimeSync,
    ChangeAvatar,
    ChangeMountSkin,
    GameEvent,
    KilledPlayer,
    Died,
    KnockedDown,
    Unconcious,
    MatchPlayerJoinedEvent,
    MatchPlayerStatsEvent,
    MatchPlayerStatsCompleteEvent,
    MatchTimeLineEventEvent,
    MatchPlayerMainGearStatsEvent,
    MatchPlayerChangedAvatarEvent,
    InvitationPlayerTrade,
    PlayerTradeStart,
    PlayerTradeCancel,
    PlayerTradeUpdate,
    PlayerTradeFinished,
    PlayerTradeAcceptChange,
    MiniMapPing,
    MarketPlaceNotification,
    DuellingChallengePlayer,
    NewDuellingPost,
    DuelStarted,
    DuelEnded,
    DuelDenied,
    DuelRequestCanceled,
    DuelLeftArea,
    DuelReEnteredArea,
    NewRealEstate,
    MiniMapOwnedBuildingsPositions,
    RealEstateListUpdate,
    GuildLogoUpdate,
    GuildLogoChanged,
    PlaceableObjectPlace,
    PlaceableObjectPlaceCancel,
    FurnitureObjectBuffProviderInfo,
    FurnitureObjectCheatProviderInfo,
    FarmableObjectInfo,
    NewUnreadMails,
    MailOperationPossible,
    GuildLogoObjectUpdate,
    StartLogout,
    NewChatChannels,
    JoinedChatChannel,
    LeftChatChannel,
    RemovedChatChannel,
    AccessStatus,
    Mounted,
    MountStart,
    MountCancel,
    NewTravelpoint,
    NewIslandAccessPoint,
    NewExit,
    UpdateHome,
    UpdateChatSettings,
    ResurrectionOffer,
    ResurrectionReply,
    LootEquipmentChanged,
    UpdateUnlockedGuildLogos,
    UpdateUnlockedAvatars,
    UpdateUnlockedAvatarRings,
    UpdateUnlockedBuildings,
    NewIslandManagement,
    NewTeleportStone,
    Cloak,
    PartyInvitation,
    PartyJoinRequest,
    PartyJoined,
    PartyDisbanded,
    PartyPlayerJoined,
    PartyChangedOrder,
    PartyPlayerLeft,
    PartyLeaderChanged,
    PartyLootSettingChangedPlayer,
    PartySilverGained,
    PartyPlayerUpdated,
    PartyInvitationAnswer,
    PartyJoinRequestAnswer,
    PartyMarkedObjectsUpdated,
    PartyOnClusterPartyJoined,
    PartySetRoleFlag,
    PartyInviteOrJoinPlayerEquipmentInfo,
    PartyReadyCheckUpdate,
    SpellCooldownUpdate,
    NewHellgateExitPortal,
    NewExpeditionExit,
    NewExpeditionNarrator,
    ExitEnterStart,
    ExitEnterCancel,
    ExitEnterFinished,
    NewQuestGiverObject,
    FullQuestInfo,
    QuestProgressInfo,
    QuestGiverInfoForPlayer,
    FullExpeditionInfo,
    ExpeditionQuestProgressInfo,
    InvitedToExpedition,
    ExpeditionRegistrationInfo,
    EnteringExpeditionStart,
    EnteringExpeditionCancel,
    RewardGranted,
    ArenaRegistrationInfo,
    EnteringArenaStart,
    EnteringArenaCancel,
    EnteringArenaLockStart,
    EnteringArenaLockCancel,
    InvitedToArenaMatch,
    UsingHellgateShrine,
    EnteringHellgateLockStart,
    EnteringHellgateLockCancel,
    PlayerCounts,
    InCombatStateUpdate,
    OtherGrabbedLoot,
    TreasureChestUsingStart,
    TreasureChestUsingFinished,
    TreasureChestUsingCancel,
    TreasureChestUsingOpeningComplete,
    TreasureChestForceCloseInventory,
    LocalTreasuresUpdate,
    LootChestSpawnpointsUpdate,
    PremiumChanged,
    PremiumExtended,
    PremiumLifeTimeRewardGained,
    GoldPurchased,
    LaborerGotUpgraded,
    JournalGotFull,
    JournalFillError,
    FriendRequest,
    FriendRequestInfos,
    FriendInfos,
    FriendRequestAnswered,
    FriendOnlineStatus,
    FriendRequestCanceled,
    FriendRemoved,
    FriendUpdated,
    PartyLootItems,
    PartyLootItemsRemoved,
    ReputationUpdate,
    DefenseUnitAttackBegin,
    DefenseUnitAttackEnd,
    DefenseUnitAttackDamage,
    UnrestrictedPvpZoneUpdate,
    ReputationImplicationUpdate,
    NewMountObject,
    MountHealthUpdate,
    MountCooldownUpdate,
    NewExpeditionAgent,
    NewExpeditionCheckPoint,
    ExpeditionStartEvent,
    VoteEvent,
    RatingEvent,
    NewArenaAgent,
    BoostFarmable,
    UseFunction,
    NewPortalEntrance,
    NewPortalExit,
    NewRandomDungeonExit,
    WaitingQueueUpdate,
    PlayerMovementRateUpdate,
    ObserveStart,
    MinimapZergs,
    MinimapSmartClusterZergs,
    PaymentTransactions,
    PerformanceStatsUpdate,
    OverloadModeUpdate,
    DebugDrawEvent,
    RecordCameraMove,
    RecordStart,
    DeliverCarriableObjectStart,
    DeliverCarriableObjectCancel,
    DeliverCarriableObjectReset,
    DeliverCarriableObjectFinished,
    TerritoryClaimStart,
    TerritoryClaimCancel,
    TerritoryClaimFinished,
    TerritoryScheduleResult,
    TerritoryUpgradeWithPowerCrystalResult,
    ReceiveCarriableObjectStart,
    ReceiveCarriableObjectFinished,
    UpdateAccountState,
    StartDeterministicRoam,
    GuildFullAccessTagsUpdated,
    GuildAccessTagUpdated,
    GvgSeasonUpdate,
    GvgSeasonCheatCommand,
    SeasonPointsByKillingBooster,
    FishingStart,
    FishingCast,
    FishingCatch,
    FishingFinished,
    FishingCancel,
    NewFloatObject,
    NewFishingZoneObject,
    FishingMiniGame,
    AlbionJournalAchievementCompleted,
    UpdatePuppet,
    ChangeFlaggingFinished,
    NewOutpostObject,
    OutpostUpdate,
    OutpostClaimed,
    OverChargeEnd,
    OverChargeStatus,
    PartyFinderFullUpdate,
    PartyFinderUpdate,
    PartyFinderApplicantsUpdate,
    PartyFinderEquipmentSnapshot,
    PartyFinderJoinRequestDeclined,
    NewUnlockedPersonalSeasonRewards,
    PersonalSeasonPointsGained,
    PersonalSeasonPastSeasonDataEvent,
    EasyAntiCheatMessageToClient,
    MatchLootChestOpeningStart,
    MatchLootChestOpeningFinished,
    MatchLootChestOpeningCancel,
    NotifyCrystalMatchReward,
    CrystalRealmFeedback,
    NewLocationMarker,
    NewTutorialBlocker,
    NewTileSwitch,
    NewInformationProvider,
    NewDynamicGuildLogo,
    NewDecoration,
    TutorialUpdate,
    TriggerHintBox,
    RandomDungeonPositionInfo,
    NewLootChest,
    UpdateLootChest,
    LootChestOpened,
    UpdateLootProtectedByMobsWithMinimapDisplay,
    NewShrine,
    UpdateShrine,
    UpdateRoom,
    NewMistDungeonRoomMobSoul,
    NewHellgateShrine,
    UpdateHellgateShrine,
    ActivateHellgateExit,
    MutePlayerUpdate,
    ShopTileUpdate,
    ShopUpdate,
    AntiCheatKick,
    BattlEyeServerMessage,
    UnlockVanityUnlock,
    AvatarUnlocked,
    CustomizationChanged,
    BaseVaultInfo,
    GuildVaultInfo,
    BankVaultInfo,
    RecoveryVaultPlayerInfo,
    RecoveryVaultGuildInfo,
    UpdateWardrobe,
    CastlePhaseChanged,
    GuildAccountLogEvent,
    NewHideoutObject,
    NewHideoutManagement,
    NewHideoutExit,
    InitHideoutAttackStart,
    InitHideoutAttackCancel,
    InitHideoutAttackFinished,
    HideoutManagementUpdate,
    HideoutUpgradeWithPowerCrystalResult,
    IpChanged,
    SmartClusterQueueUpdateInfo,
    SmartClusterQueueActiveInfo,
    SmartClusterQueueKickWarning,
    SmartClusterQueueInvite,
    ReceivedGvgSeasonPoints,
    TowerPowerPointUpdate,
    OpenWorldAttackScheduleStart,
    OpenWorldAttackScheduleFinished,
    OpenWorldAttackScheduleCancel,
    OpenWorldAttackConquerStart,
    OpenWorldAttackConquerFinished,
    OpenWorldAttackConquerCancel,
    OpenWorldAttackConquerStatus,
    OpenWorldAttackStart,
    OpenWorldAttackEnd,
    NewRandomResourceBlocker,
    NewHomeObject,
    HideoutObjectUpdate,
    UpdateInfamy,
    MinimapPositionMarkers,
    NewTunnelExit,
    CorruptedDungeonUpdate,
    CorruptedDungeonStatus,
    CorruptedDungeonInfamy,
    HellgateRestrictedAreaUpdate,
    HellgateInfamy,
    HellgateStatus,
    HellgateStatusUpdate,
    HellgateSuspense,
    ReplaceSpellSlotWithMultiSpell,
    NewCorruptedShrine,
    UpdateCorruptedShrine,
    CorruptedShrineUsageStart,
    CorruptedShrineUsageCancel,
    ExitUsed,
    LinkedToObject,
    LinkToObjectBroken,
    EstimatedMarketValueUpdate,
    StuckCancel,
    DungonEscapeReady,
    FactionWarfareClusterState,
    FactionWarfareHasUnclaimedWeeklyReportsEvent,
    SimpleFeedback,
    SmartClusterQueueSkipClusterError,
    XignCodeEvent,
    BatchUseItemStart,
    BatchUseItemEnd,
    RedZoneEventClusterStatus,
    RedZonePlayerNotification,
    RedZoneWorldEvent,
    FactionWarfareStats,
    UpdateFactionBalanceFactors,
    FactionEnlistmentChanged,
    UpdateFactionRank,
    FactionWarfareCampaignRewardsUnlocked,
    FeaturedFeatureUpdate,
    NewCarriableObject,
    MinimapCrystalPositionMarker,
    CarriedObjectUpdate,
    PickupCarriableObjectStart,
    PickupCarriableObjectCancel,
    PickupCarriableObjectFinished,
    DoSimpleActionStart,
    DoSimpleActionCancel,
    DoSimpleActionFinished,
    NotifyGuestAccountVerified,
    MightAndFavorReceivedEvent,
    WeeklyPvpChallengeRewardStateUpdate,
    NewUnlockedPvpSeasonChallengeRewards,
    StaticDungeonEntrancesDungeonEventStatusUpdates,
    StaticDungeonDungeonValueUpdate,
    StaticDungeonEntranceDungeonEventsAborted,
    InAppPurchaseConfirmedGooglePlay,
    FeatureSwitchInfo,
    PartyJoinRequestAborted,
    PartyInviteAborted,
    PartyStartHuntRequest,
    PartyStartHuntRequested,
    PartyStartHuntRequestAnswer,
    PartyPlayerLeaveScheduled,
    GuildInviteDeclined,
    CancelMultiSpellSlots,
    NewVisualEventObject,
    CastleClaimProgress,
    CastleClaimProgressLogo,
    TownPortalUpdateState,
    TownPortalFailed,
    ConsumableVanityChargesAdded,
    FestivitiesUpdate,
    NewBannerObject,
    NewMistsImmediateReturnExit,
    MistsPlayerJoinedInfo,
    NewMistsStaticEntrance,
    NewMistsOpenWorldExit,
    NewTunnelExitTemp,
    NewMistsWispSpawn,
    MistsWispSpawnStateChange,
    NewMistsCityEntrance,
    NewMistsCityRoadsEntrance,
    MistsCityRoadsEntrancePartyStateUpdate,
    MistsCityRoadsEntranceClearStateForParty,
    MistsEntranceDataChanged,
    NewMistsCagedWisp,
    MistsWispCageOpened,
    MistsEntrancePartyBindingCreated,
    MistsEntrancePartyBindingCleared,
    MistsEntrancePartyBindingInfos,
    NewMistsBorderExit,
    NewMistsDungeonExit,
    LocalQuestInfos,
    LocalQuestStarted,
    LocalQuestActive,
    LocalQuestInactive,
    LocalQuestProgressUpdate,
    NewUnrestrictedPvpZone,
    TemporaryFlaggingStatusUpdate,
    SpellTestPerformanceUpdate,
    Transformation,
    TransformationEnd,
    UpdateTrustlevel,
    RevealHiddenTimeStamps,
    ModifyItemTraitFinished,
    RerollItemTraitValueFinished,
    HuntQuestProgressInfo,
    HuntStarted,
    HuntFinished,
    HuntAborted,
    HuntMissionStepStateUpdate,
    NewHuntTrack,
    HuntMissionUpdate,
    HuntQuestMissionProgressUpdate,
    HuntTrackUsed,
    HuntTrackUseableAgain,
    MinimapHuntTrackMarkers,
    NoTracksFound,
    HuntQuestAborted,
    InteractWithTrackStart,
    InteractWithTrackCancel,
    InteractWithTrackFinished,
    NewDynamicCompound,
    LegendaryItemDestroyed,
    AttunementInfo,
    TerritoryClaimRaidedRawEnergyCrystalResult,
    CarriedObjectExpiryWarning,
    CarriedObjectExpired,
    TerritoryRaidStart,
    TerritoryRaidCancel,
    TerritoryRaidFinished,
    TerritoryRaidResult,
    TerritoryMonolithActiveRaidStatus,
    TerritoryMonolithActiveRaidCancelled,
    MonolithEnergyStorageUpdate,
    MonolithNextScheduledOpenWorldAttackUpdate,
    MonolithProtectedBuildingsDamageReductionUpdate,
    NewBuildingBaseEvent,
    NewFortificationBuilding,
    NewCastleGateBuilding,
    BuildingDurabilityUpdate,
    MonolithFortificationPointsUpdate,
    FortificationBuildingUpgradeInfo,
    FortificationBuildingsDamageStateUpdate,
    SiegeNotificationEvent,
    UpdateEnemyWarBannerActive,
    TerritoryAnnouncePlayerEjection,
    CastleGateSwitchUseStarted,
    CastleGateSwitchUseFinished,
    FortificationBuildingWillDowngrade,
    BotCommand,
    JournalAchievementProgressUpdate,
    JournalClaimableRewardUpdate
}