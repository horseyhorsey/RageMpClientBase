﻿using System.Collections.Generic;

namespace RageMpClientShared
{
    public static class TimeCycle
    {
        /// <summary>
        /// Timecycles (rootcause)
        /// </summary>
        public static readonly Dictionary<int, string> TimeCycleMods = new Dictionary<int, string>
        {
            {1,"AmbientPUSH"},{2,"AP1_01_B_IntRefRange"},{3,"AP1_01_C_NoFog"},{4,"Bank_HLWD"},{5,"Barry1_Stoned"},{6,"BarryFadeOut"},{7,"baseTONEMAPPING"},{8,"BeastIntro01"},{9,"BeastIntro02"},{10,"BeastLaunch01"},{11,"BeastLaunch02"},{12,"BikerFilter"},{13,"BikerForm01"},{14,"BikerFormFlash"},{15,"Bikers"},{16,"BikersSPLASH"},{17,"blackNwhite"},{18,"BlackOut"},{19,"BleepYellow01"},{20,"BleepYellow02"},{21,"Bloom"},{22,"BloomLight"},{23,"BloomMid"},{24,"buggy_shack"},{25,"buildingTOP"},{26,"BulletTimeDark"},{27,"BulletTimeLight"},{28,"CAMERA_BW"},{29,"CAMERA_secuirity"},{30,"CAMERA_secuirity_FUZZ"},{31,"canyon_mission"},{32,"carMOD_underpass"},{33,"carpark"},{34,"carpark_dt1_02"},{35,"carpark_dt1_03"},{36,"Carpark_MP_exit"},{37,"cashdepot"},{38,"cashdepotEMERGENCY"},{39,"cBank_back"},{40,"cBank_front"},{41,"ch2_tunnel_whitelight"},{42,"CH3_06_water"},{43,"CHOP"},{44,"cinema"},{45,"cinema_001"},{46,"cops"},{47,"CopsSPLASH"},{48,"crane_cam"},{49,"crane_cam_cinematic"},{50,"CrossLine01"},{51,"CrossLine02"},{52,"CS1_railwayB_tunnel"},{53,"CS3_rail_tunnel"},{54,"CUSTOM_streetlight"},{55,"damage"},{56,"DeadlineNeon01"},{57,"default"},{58,"DefaultColorCode"},{59,"DONT_overide_sunpos"},{60,"Dont_tazeme_bro"},{61,"dont_tazeme_bro_b"},{62,"downtown_FIB_cascades_opt"},{63,"DrivingFocusDark"},{64,"DrivingFocusLight"},{65,"DRUG_2_drive"},{66,"Drug_deadman"},{67,"Drug_deadman_blend"},{68,"drug_drive_blend01"},{69,"drug_drive_blend02"},{70,"drug_flying_01"},{71,"drug_flying_02"},{72,"drug_flying_base"},{73,"DRUG_gas_huffin"},{74,"drug_wobbly"},{75,"Drunk"},{76,"dying"},{77,"eatra_bouncelight_beach"},{78,"epsilion"},{79,"exile1_exit"},{80,"exile1_plane"},{81,"ExplosionJosh"},{82,"EXT_FULLAmbientmult_art"},{83,"ext_int_extlight_large"},{84,"EXTRA_bouncelight"},{85,"eyeINtheSKY"},{86,"Facebook_NEW"},{87,"facebook_serveroom"},{88,"FIB_5"},{89,"FIB_6"},{90,"FIB_A"},{91,"FIB_B"},{92,"FIB_interview"},{93,"FIB_interview_optimise"},{94,"FinaleBank"},{95,"FinaleBankexit"},{96,"FinaleBankMid"},{97,"fireDEPT"},{98,"FORdoron_delete"},{99,"Forest"},{100,"fp_vig_black"},{101,"fp_vig_blue"},{102,"fp_vig_brown"},{103,"fp_vig_gray"},{104,"fp_vig_green"},{105,"fp_vig_red"},{106,"FrankilinsHOUSEhills"},{107,"frankilnsAUNTS_new"},{108,"frankilnsAUNTS_SUNdir"},{109,"FRANKLIN"},{110,"FranklinColorCode"},{111,"FranklinColorCodeBasic"},{112,"FranklinColorCodeBright"},{113,"FullAmbientmult_interior"},{114,"gallery_refmod"},{115,"garage"},{116,"gen_bank"},{117,"glasses_black"},{118,"Glasses_BlackOut"},{119,"glasses_blue"},{120,"glasses_brown"},{121,"glasses_Darkblue"},{122,"glasses_green"},{123,"glasses_orange"},{124,"glasses_pink"},{125,"glasses_purple"},{126,"glasses_red"},{127,"glasses_Scuba"},{128,"glasses_VISOR"},{129,"glasses_yellow"},{130,"gorge_reflection_gpu"},{131,"gorge_reflectionoffset"},{132,"gorge_reflectionoffset2"},{133,"graveyard_shootout"},{134,"grdlc_int_02"},{135,"grdlc_int_02_trailer_cave"},{136,"gunclub"},{137,"gunclubrange"},{138,"gunshop"},{139,"gunstore"},{140,"half_direct"},{141,"hangar_lightsmod"},{142,"Hanger_INTmods"},{143,"heathaze"},{144,"heist_boat"},{145,"heist_boat_engineRoom"},{146,"heist_boat_norain"},{147,"helicamfirst"},{148,"heliGunCam"},{149,"Hicksbar"},{150,"HicksbarNEW"},{151,"hillstunnel"},{152,"Hint_cam"},{153,"hitped"},{154,"hud_def_blur"},{155,"hud_def_blur_switch"},{156,"hud_def_colorgrade"},{157,"hud_def_desat_cold"},{158,"hud_def_desat_cold_kill"},{159,"hud_def_desat_Franklin"},{160,"hud_def_desat_Michael"},{161,"hud_def_desat_Neutral"},{162,"hud_def_desat_switch"},{163,"hud_def_desat_Trevor"},{164,"hud_def_desatcrunch"},{165,"hud_def_flash"},{166,"hud_def_focus"},{167,"hud_def_Franklin"},{168,"hud_def_lensdistortion"},{169,"hud_def_lensdistortion_subtle"},{170,"hud_def_Michael"},{171,"hud_def_Trevor"},{172,"ImpExp_Interior_01"},{173,"IMpExt_Interior_02"},{174,"IMpExt_Interior_02_stair_cage"},{175,"InchOrange01"},{176,"InchOrange02"},{177,"InchPickup01"},{178,"InchPickup02"},{179,"InchPurple01"},{180,"InchPurple02"},{181,"INT_FullAmbientmult"},{182,"INT_FULLAmbientmult_art"},{183,"INT_FULLAmbientmult_both"},{184,"INT_garage"},{185,"INT_mall"},{186,"INT_NO_fogALPHA"},{187,"INT_NoAmbientmult"},{188,"INT_NoAmbientmult_art"},{189,"INT_NoAmbientmult_both"},{190,"INT_NOdirectLight"},{191,"INT_nowaterREF"},{192,"INT_posh_hairdresser"},{193,"INT_smshop"},{194,"INT_smshop_indoor_bloom"},{195,"INT_smshop_inMOD"},{196,"INT_smshop_outdoor_bloom"},{197,"INT_streetlighting"},{198,"INT_trailer_cinema"},{199,"id1_11_tunnel"},{200,"impexp_interior_01_lift"},{201,"int_amb_mult_large"},{202,"int_Barber1"},{203,"int_carmod_small"},{204,"int_carrier_control"},{205,"int_carrier_control_2"},{206,"int_carrier_hanger"},{207,"int_carrier_rear"},{208,"int_carrier_stair"},{209,"int_carshowroom"},{210,"int_chopshop"},{211,"int_clean_extlight_large"},{212,"int_clean_extlight_none"},{213,"int_clean_extlight_small"},{214,"int_ClothesHi"},{215,"int_clotheslow_large"},{216,"int_cluckinfactory_none"},{217,"int_cluckinfactory_small"},{218,"int_ControlTower_none"},{219,"int_ControlTower_small"},{220,"int_dockcontrol_small"},{221,"int_extlght_sm_cntrst"},{222,"int_extlight_large"},{223,"int_extlight_large_fog"},{224,"int_extlight_none"},{225,"int_extlight_none_dark"},{226,"int_extlight_none_dark_fog"},{227,"int_extlight_none_fog"},{228,"int_extlight_small"},{229,"int_extlight_small_clipped"},{230,"int_extlight_small_fog"},{231,"int_Farmhouse_none"},{232,"int_Farmhouse_small"},{233,"int_FranklinAunt_small"},{234,"int_GasStation"},{235,"int_hanger_none"},{236,"int_hanger_small"},{237,"int_Hospital_Blue"},{238,"int_Hospital_BlueB"},{239,"int_hospital_dark"},{240,"int_Hospital_DM"},{241,"int_hospital_small"},{242,"int_Hospital2_DM"},{243,"int_lesters"},{244,"int_Lost_none"},{245,"int_Lost_small"},{246,"int_methlab_small"},{247,"int_motelroom"},{248,"int_office_Lobby"},{249,"int_office_LobbyHall"},{250,"int_tattoo"},{251,"int_tattoo_B"},{252,"int_tunnel_none_dark"},{253,"interior_WATER_lighting"},{254,"introblue"},{255,"jewel_gas"},{256,"jewel_optim"},{257,"jewelry_entrance"},{258,"jewelry_entrance_INT"},{259,"jewelry_entrance_INT_fog"},{260,"Kifflom"},{261,"KT_underpass"},{262,"lab_none"},{263,"lab_none_dark"},{264,"lab_none_dark_fog"},{265,"lab_none_dark_OVR"},{266,"lab_none_exit"},{267,"lab_none_exit_OVR"},{268,"LectroDark"},{269,"LectroLight"},{270,"LIGHTSreduceFALLOFF"},{271,"li"},{272,"LifeInvaderLOD"},{273,"lightning"},{274,"lightning_cloud"},{275,"lightning_strong"},{276,"lightning_weak"},{277,"LightPollutionHills"},{278,"lightpolution"},{279,"LODmult_global_reduce"},{280,"LODmult_global_reduce_NOHD"},{281,"LODmult_HD_orphan_LOD_reduce"},{282,"LODmult_HD_orphan_reduce"},{283,"LODmult_LOD_reduce"},{284,"LODmult_SLOD1_reduce"},{285,"LODmult_SLOD2_reduce"},{286,"LODmult_SLOD3_reduce"},{287,"lodscaler"},{288,"LostTimeDark"},{289,"LostTimeFlash"},{290,"LostTimeLight"},{291,"maxlodscaler"},{292,"metro"},{293,"METRO_platform"},{294,"METRO_Tunnels"},{295,"METRO_Tunnels_entrance"},{296,"MichaelColorCode"},{297,"MichaelColorCodeBasic"},{298,"MichaelColorCodeBright"},{299,"MichaelsDarkroom"},{300,"MichaelsDirectional"},{301,"MichaelsNODirectional"},{302,"micheal"},{303,"micheals_lightsOFF"},{304,"michealspliff"},{305,"michealspliff_blend"},{306,"michealspliff_blend02"},{307,"militarybase_nightlight"},{308,"mineshaft"},{309,"morebloom"},{310,"morgue_dark"},{311,"morgue_dark_ovr"},{312,"Mp_apart_mid"},{313,"mp_bkr_int01_garage"},{314,"mp_bkr_int01_small_rooms"},{315,"mp_bkr_int01_transition"},{316,"mp_bkr_int02_garage"},{317,"mp_bkr_int02_hangout"},{318,"mp_bkr_int02_small_rooms"},{319,"mp_bkr_ware01"},{320,"mp_bkr_ware02_dry"},{321,"mp_bkr_ware02_standard"},{322,"mp_bkr_ware02_upgrade"},{323,"mp_bkr_ware03_basic"},{324,"mp_bkr_ware03_upgrade"},{325,"mp_bkr_ware04"},{326,"mp_bkr_ware05"},{327,"MP_Bull_tost"},{328,"MP_Bull_tost_blend"},{329,"MP_corona_heist"},{330,"MP_corona_heist_blend"},{331,"MP_corona_heist_BW"},{332,"MP_corona_heist_BW_night"},{333,"MP_corona_heist_DOF"},{334,"MP_corona_heist_night"},{335,"MP_corona_heist_night_blend"},{336,"MP_corona_selection"},{337,"MP_corona_switch"},{338,"MP_corona_tournament"},{339,"MP_corona_tournament_DOF"},{340,"MP_death_grade"},{341,"MP_death_grade_blend01"},{342,"MP_death_grade_blend02"},{343,"MP_deathfail_night"},{344,"mp_exec_office_01"},{345,"mp_exec_office_02"},{346,"mp_exec_office_03"},{347,"mp_exec_office_03_blue"},{348,"mp_exec_office_03C"},{349,"mp_exec_office_04"},{350,"mp_exec_office_05"},{351,"mp_exec_office_06"},{352,"mp_exec_warehouse_01"},{353,"MP_Garage_L"},{354,"mp_gr_int01_black"},{355,"mp_gr_int01_grey"},{356,"mp_gr_int01_white"},{357,"MP_H_01_Bathroom"},{358,"MP_H_01_Bedroom"},{359,"MP_H_01_New"},{360,"MP_H_01_New_Bathroom"},{361,"MP_H_01_New_Bedroom"},{362,"MP_H_01_New_Study"},{363,"MP_H_01_Study"},{364,"MP_H_02"},{365,"MP_H_04"},{366,"mp_h_05"},{367,"MP_H_06"},{368,"mp_h_07"},{369,"mp_h_08"},{370,"MP_heli_cam"},{371,"mp_imx_intwaremed"},{372,"mp_imx_intwaremed_office"},{373,"mp_imx_mod_int_01"},{374,"MP_intro_logo"},{375,"MP_job_end_night"},{376,"MP_job_load"},{377,"MP_job_load_01"},{378,"MP_job_load_02"},{379,"MP_job_lose"},{380,"MP_job_preload"},{381,"MP_job_preload_blend"},{382,"MP_job_preload_night"},{383,"MP_job_win"},{384,"MP_Killstreak"},{385,"MP_Killstreak_blend"},{386,"mp_lad_day"},{387,"mp_lad_judgment"},{388,"mp_lad_night"},{389,"MP_Loser"},{390,"MP_Loser_blend"},{391,"MP_lowgarage"},{392,"MP_MedGarage"},{393,"mp_nightshark_shield_fp"},{394,"MP_Powerplay"},{395,"MP_Powerplay_blend"},{396,"MP_race_finish"},{397,"MP_select"},{398,"mp_smg_int01_han"},{399,"mp_smg_int01_han_blue"},{400,"mp_smg_int01_han_red"},{401,"mp_smg_int01_han_yellow"},{402,"Mp_Stilts"},{403,"Mp_Stilts_gym"},{404,"Mp_Stilts_gym2"},{405,"Mp_Stilts2"},{406,"Mp_Stilts2_bath"},{407,"MP_Studio_Lo"},{408,"mp_x17dlc_base"},{409,"mp_x17dlc_base_dark"},{410,"mp_x17dlc_base_darkest"},{411,"mp_x17dlc_facility"},{412,"mp_x17dlc_facility_conference"},{413,"mp_x17dlc_facility2"},{414,"mp_x17dlc_in_sub"},{415,"mp_x17dlc_in_sub_no_reflection"},{416,"mp_x17dlc_int_01"},{417,"mp_x17dlc_int_01_tint1"},{418,"mp_x17dlc_int_01_tint2"},{419,"mp_x17dlc_int_01_tint3"},{420,"mp_x17dlc_int_01_tint4"},{421,"mp_x17dlc_int_01_tint5"},{422,"mp_x17dlc_int_01_tint6"},{423,"mp_x17dlc_int_01_tint7"},{424,"mp_x17dlc_int_01_tint8"},{425,"mp_x17dlc_int_01_tint9"},{426,"mp_x17dlc_int_02"},{427,"mp_x17dlc_int_02_hangar"},{428,"mp_x17dlc_int_02_tint1"},{429,"mp_x17dlc_int_02_tint2"},{430,"mp_x17dlc_int_02_tint3"},{431,"mp_x17dlc_int_02_tint4"},{432,"mp_x17dlc_int_02_tint5"},{433,"mp_x17dlc_int_02_tint6"},{434,"mp_x17dlc_int_02_tint7"},{435,"mp_x17dlc_int_02_tint8"},{436,"mp_x17dlc_int_02_tint9"},{437,"mp_x17dlc_int_silo"},{438,"mp_x17dlc_int_silo_escape"},{439,"mp_x17dlc_lab"},{440,"mp_x17dlc_lab_loading_bay"},{441,"MPApart_H_01"},{442,"MPApart_H_01_gym"},{443,"MPApartHigh"},{444,"MPApartHigh_palnning"},{445,"mugShot"},{446,"mugShot_lineup"},{447,"Multipayer_spectatorCam"},{448,"multiplayer_ped_fight"},{449,"nervousRON_fog"},{450,"NeutralColorCode"},{451,"NeutralColorCodeBasic"},{452,"NeutralColorCodeBright"},{453,"NeutralColorCodeLight"},{454,"NEW_abattoir"},{455,"new_bank"},{456,"NEW_jewel"},{457,"NEW_jewel_EXIT"},{458,"NEW_lesters"},{459,"new_MP_Garage_L"},{460,"NEW_ornate_bank"},{461,"NEW_ornate_bank_entrance"},{462,"NEW_ornate_bank_office"},{463,"NEW_ornate_bank_safe"},{464,"New_sewers"},{465,"NEW_shrinksOffice"},{466,"NEW_station_unfinished"},{467,"new_stripper_changing"},{468,"NEW_trevorstrailer"},{469,"NEW_tunnels"},{470,"NEW_tunnels_ditch"},{471,"new_tunnels_entrance"},{472,"NEW_tunnels_hole"},{473,"NEW_yellowtunnels"},{474,"NewMicheal"},{475,"NewMicheal_night"},{476,"NewMicheal_upstairs"},{477,"NewMichealgirly"},{478,"NewMichealstoilet"},{479,"NewMichealupstairs"},{480,"nextgen"},{481,"NG_blackout"},{482,"NG_deathfail_BW_base"},{483,"NG_deathfail_BW_blend01"},{484,"NG_deathfail_BW_blend02"},{485,"NG_filmic01"},{486,"NG_filmic02"},{487,"NG_filmic03"},{488,"NG_filmic04"},{489,"NG_filmic05"},{490,"NG_filmic06"},{491,"NG_filmic07"},{492,"NG_filmic08"},{493,"NG_filmic09"},{494,"NG_filmic10"},{495,"NG_filmic11"},{496,"NG_filmic12"},{497,"NG_filmic13"},{498,"NG_filmic14"},{499,"NG_filmic15"},{500,"NG_filmic16"},{501,"NG_filmic17"},{502,"NG_filmic18"},{503,"NG_filmic19"},{504,"NG_filmic20"},{505,"NG_filmic21"},{506,"NG_filmic22"},{507,"NG_filmic23"},{508,"NG_filmic24"},{509,"NG_filmic25"},{510,"NG_filmnoir_BW01"},{511,"NG_filmnoir_BW02"},{512,"NG_first"},{513,"nightvision"},{514,"NO_coronas"},{515,"NO_fog_alpha"},{516,"NO_streetAmbient"},{517,"NO_weather"},{518,"NoAmbientmult"},{519,"NoAmbientmult_interior"},{520,"NOdirectLight"},{521,"NoPedLight"},{522,"NOrain"},{523,"overwater"},{524,"Paleto"},{525,"paleto_nightlight"},{526,"paleto_opt"},{527,"PennedInDark"},{528,"PennedInLight"},{529,"PERSHING_water_reflect"},{530,"phone_cam"},{531,"phone_cam1"},{532,"phone_cam10"},{533,"phone_cam11"},{534,"phone_cam12"},{535,"phone_cam13"},{536,"phone_cam2"},{537,"phone_cam3"},{538,"phone_cam3_REMOVED"},{539,"phone_cam4"},{540,"phone_cam5"},{541,"phone_cam6"},{542,"phone_cam7"},{543,"phone_cam8"},{544,"phone_cam8_REMOVED"},{545,"phone_cam9"},{546,"plane_inside_mode"},{547,"player_transition"},{548,"player_transition_no_scanlines"},{549,"player_transition_scanlines"},{550,"PlayerSwitchNeutralFlash"},{551,"PlayerSwitchPulse"},{552,"plaza_carpark"},{553,"PoliceStation"},{554,"PoliceStationDark"},{555,"polluted"},{556,"poolsidewaterreflection2"},{557,"PORT_heist_underwater"},{558,"powerplant_nightlight"},{559,"powerstation"},{560,"PPFilter"},{561,"PPGreen01"},{562,"PPGreen02"},{563,"PPOrange01"},{564,"PPOrange02"},{565,"PPPink01"},{566,"PPPink02"},{567,"PPPurple01"},{568,"PPPurple02"},{569,"prison_nightlight"},{570,"projector"},{571,"prologue"},{572,"prologue_ending_fog"},{573,"prologue_ext_art_amb"},{574,"prologue_reflection_opt"},{575,"prologue_shootout"},{576,"Prologue_shootout_opt"},{577,"pulse"},{578,"RaceTurboDark"},{579,"RaceTurboFlash"},{580,"RaceTurboLight"},{581,"ranch"},{582,"REDMIST"},{583,"REDMIST_blend"},{584,"ReduceDrawDistance"},{585,"ReduceDrawDistanceMAP"},{586,"ReduceDrawDistanceMission"},{587,"reducelightingcost"},{588,"ReduceSSAO"},{589,"reducewaterREF"},{590,"refit"},{591,"reflection_correct_ambient"},{592,"RemoteSniper"},{593,"resvoire_reflection"},{594,"rply_brightness"},{595,"rply_brightness_neg"},{596,"rply_contrast"},{597,"rply_contrast_neg"},{598,"rply_motionblur"},{599,"rply_saturation"},{600,"rply_saturation_neg"},{601,"rply_vignette"},{602,"rply_vignette_neg"},{603,"SALTONSEA"},{604,"sandyshore_nightlight"},{605,"SAWMILL"},{606,"scanline_cam"},{607,"scanline_cam_cheap"},{608,"scope_zoom_in"},{609,"scope_zoom_out"},{610,"secret_camera"},{611,"services_nightlight"},{612,"shades_pink"},{613,"shades_yellow"},{614,"SheriffStation"},{615,"ship_explosion_underwater"},{616,"ship_lighting"},{617,"Shop247"},{618,"Shop247_none"},{619,"sleeping"},{620,"Sniper"},{621,"SP1_03_drawDistance"},{622,"spectator1"},{623,"spectator10"},{624,"spectator2"},{625,"spectator3"},{626,"spectator4"},{627,"spectator5"},{628,"spectator6"},{629,"spectator7"},{630,"spectator8"},{631,"spectator9"},{632,"StadLobby"},{633,"stc_coroners"},{634,"stc_deviant_bedroom"},{635,"stc_deviant_lounge"},{636,"stc_franklinsHouse"},{637,"stc_trevors"},{638,"stoned"},{639,"stoned_aliens"},{640,"stoned_cutscene"},{641,"stoned_monkeys"},{642,"StreetLighting"},{643,"StreetLightingJunction"},{644,"StreetLightingtraffic"},{645,"STRIP_changing"},{646,"STRIP_nofog"},{647,"STRIP_office"},{648,"STRIP_stage"},{649,"StuntFastDark"},{650,"StuntFastLight"},{651,"StuntSlowDark"},{652,"StuntSlowLight"},{653,"subBASE_water_ref"},{654,"sunglasses"},{655,"superDARK"},{656,"switch_cam_1"},{657,"switch_cam_2"},{658,"telescope"},{659,"TinyGreen01"},{660,"TinyGreen02"},{661,"TinyPink01"},{662,"TinyPink02"},{663,"TinyRacerMoBlur"},{664,"torpedo"},{665,"traffic_skycam"},{666,"trailer_explosion_optimise"},{667,"TREVOR"},{668,"TrevorColorCode"},{669,"TrevorColorCodeBasic"},{670,"TrevorColorCodeBright"},{671,"Trevors_room"},{672,"trevorspliff"},{673,"trevorspliff_blend"},{674,"trevorspliff_blend02"},{675,"Tunnel"},{676,"tunnel_entrance"},{677,"tunnel_entrance_INT"},{678,"TUNNEL_green"},{679,"TUNNEL_green_ext"},{680,"Tunnel_green1"},{681,"tunnel_id1_11"},{682,"TUNNEL_orange"},{683,"TUNNEL_orange_exterior"},{684,"TUNNEL_white"},{685,"TUNNEL_yellow"},{686,"TUNNEL_yellow_ext"},{687,"ufo"},{688,"ufo_deathray"},{689,"underwater"},{690,"underwater_deep"},{691,"underwater_deep_clear"},{692,"v_abattoir"},{693,"V_Abattoir_Cold"},{694,"v_bahama"},{695,"v_cashdepot"},{696,"V_CIA_Facility"},{697,"v_dark"},{698,"V_FIB_IT3"},{699,"V_FIB_IT3_alt"},{700,"V_FIB_IT3_alt5"},{701,"V_FIB_stairs"},{702,"v_foundry"},{703,"v_janitor"},{704,"v_jewel2"},{705,"v_metro"},{706,"V_Metro_station"},{707,"V_Metro2"},{708,"v_michael"},{709,"v_michael_lounge"},{710,"V_Office_smoke"},{711,"V_Office_smoke_ext"},{712,"V_Office_smoke_Fire"},{713,"v_recycle"},{714,"V_recycle_dark"},{715,"V_recycle_light"},{716,"V_recycle_mainroom"},{717,"v_rockclub"},{718,"V_Solomons"},{719,"V_strip_nofog"},{720,"V_strip_office"},{721,"v_strip3"},{722,"v_strpchangerm"},{723,"v_sweat"},{724,"v_sweat_entrance"},{725,"v_sweat_NoDirLight"},{726,"v_torture"},{727,"Vagos"},{728,"vagos_extlight_small"},{729,"VAGOS_new_garage"},{730,"VAGOS_new_hangout"},{731,"VagosSPLASH"},{732,"VC_tunnel_entrance"},{733,"vehicle_subint"},{734,"venice_canal_tunnel"},{735,"vespucci_garage"},{736,"VolticBlur"},{737,"VolticFlash"},{738,"VolticGold"},{739,"WAREHOUSE"},{740,"WATER _lab_cooling"},{741,"WATER_CH2_06_01_03"},{742,"WATER_CH2_06_02"},{743,"WATER_CH2_06_04"},{744,"WATER_cove"},{745,"WATER_hills"},{746,"WATER_ID2_21"},{747,"WATER_lab"},{748,"WATER_lab_cooling"},{749,"WATER_militaryPOOP"},{750,"WATER_muddy"},{751,"WATER_port"},{752,"WATER_REF_malibu"},{753,"WATER_refmap_high"},{754,"WATER_refmap_hollywoodlake"},{755,"WATER_refmap_low"},{756,"WATER_refmap_med"},{757,"WATER_refmap_off"},{758,"WATER_refmap_poolside"},{759,"WATER_refmap_silverlake"},{760,"WATER_refmap_venice"},{761,"WATER_refmap_verylow"},{762,"WATER_resevoir"},{763,"WATER_RichmanStuntJump"},{764,"WATER_river"},{765,"WATER_salton"},{766,"WATER_salton_bottom"},{767,"WATER_shore"},{768,"WATER_silty"},{769,"WATER_silverlake"},{770,"WeaponUpgrade"},{771,"whitenightlighting"},{772,"WhiteOut"},{773,"winning_room"},{774,"yacht_DLC"}
        };
    }
}