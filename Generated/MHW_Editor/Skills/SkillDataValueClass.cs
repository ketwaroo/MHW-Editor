using MHW_Template;

namespace MHW_Editor.Skills {
    public static class SkillDataValueClass {
        public const ushort Poison_Resistance = 1; // Reduces damage while poisoned.
        public const ushort Paralysis_Resistance = 2; // Reduces the duration of paralysis.
        public const ushort Sleep_Resistance = 3; // Reduces the duration of sleep.
        public const ushort Stun_Resistance = 4; // Reduces stun duration.
        public const ushort Muck_Resistance = 5; // Reduces impairments to mobility while stuck in monster muck.
        public const ushort Blast_Resistance = 6; // Grants protection against blastblight.
        public const ushort Bleeding_Resistance = 7; // Grants protection against bleeding.
        public const ushort Iron_Skin = 8; // Grants protection against Defense Down.
        public const ushort Earplugs = 11; // Grants protection from large monsters' roars.
        public const ushort Windproof = 12; // Grants protection against wind pressure.
        public const ushort Tremor_Resistance = 13; // Grants protection against ground tremors.
        public const ushort Dungmaster = 14; // Makes monsters hit with slinger dung pods more likely to run.
        public const ushort Effluvial_Expert = 16; // Nullifies or reduces environmental damage in the Rotten Vale.
        public const ushort Heat_Guard = 17; // Nullifies damage from heat.
        public const ushort Attack_Boost = 19; // Increases attack power. Also improves affinity at higher levels.
        public const ushort Defense_Boost = 20; // Increases defense. Level up to improve resistances as well.
        public const ushort Health_Boost = 21; // Increases health.
        public const ushort Recovery_Up = 22; // Increases the amount recovered when restoring health.
        public const ushort Recovery_Speed = 23; // Speeds healing of recoverable damage (the red portion of the health gauge).
        public const ushort Fire_Resistance = 24; // Increases fire resistance. Also improves defense at higher levels.
        public const ushort Water_Resistance = 25; // Increases water resistance. Also improves defense at higher levels.
        public const ushort Ice_Resistance = 26; // Increases ice resistance. Also improves defense at higher levels.
        public const ushort Thunder_Resistance = 27; // Increases thunder resistance. Also improves defense at higher levels.
        public const ushort Dragon_Resistance = 28; // Increases dragon resistance. Also improves defense at higher levels.
        public const ushort Blight_Resistance = 29; // Grants protection against all elemental blights.
        public const ushort Fire_Attack = 30; // Increases fire element attack power. <STYL MOJI_YELLOW_DEFAULT>(Elemental attack power has a maximum limit.)</STYL>
        public const ushort Water_Attack = 31; // Increases water element attack power. <STYL MOJI_YELLOW_DEFAULT>(Elemental attack power has a maximum limit.)</STYL>
        public const ushort Ice_Attack = 32; // Increases ice element attack power. <STYL MOJI_YELLOW_DEFAULT>(Elemental attack power has a maximum limit.)</STYL>
        public const ushort Thunder_Attack = 33; // Increases thunder element attack power. <STYL MOJI_YELLOW_DEFAULT>(Elemental attack power has a maximum limit.)</STYL>
        public const ushort Dragon_Attack = 34; // Increases dragon element attack power. <STYL MOJI_YELLOW_DEFAULT>(Elemental attack power has a maximum limit.)</STYL>
        public const ushort Poison_Attack = 35; // Increases the rate of poison buildup. <STYL MOJI_YELLOW_DEFAULT>(Elemental buildup has a maximum limit.)</STYL>
        public const ushort Paralysis_Attack = 36; // Increases the rate of paralysis buildup. <STYL MOJI_YELLOW_DEFAULT>(Elemental buildup has a maximum limit.)</STYL>
        public const ushort Sleep_Attack = 37; // Increases the rate of sleep buildup. <STYL MOJI_YELLOW_DEFAULT>(Elemental buildup has a maximum limit.)</STYL>
        public const ushort Blast_Attack = 38; // Increases the rate of blast buildup. <STYL MOJI_YELLOW_DEFAULT>(Elemental buildup has a maximum limit.)</STYL>
        public const ushort Normal_Shots = 39; // Increases the attack power of normal ammo and normal arrows.
        public const ushort Piercing_Shots = 40; // Increases the attack power of piercing ammo and Dragon Piercer.
        public const ushort Spread_Power_Shots = 41; // Increases the attack power of spread ammo, power shot arrows, and Thousand Dragons.
        public const ushort Poison_Functionality = 42; // Allows you to apply poison coatings.
        public const ushort Para_Functionality = 43; // Allows you to apply paralysis coatings.
        public const ushort Sleep_Functionality = 44; // Allows you to apply sleep coatings.
        public const ushort Blast_Functionality = 46; // Allows you to apply blast coatings.
        public const ushort Free_Elem_Ammo_Up = 47; // Unlocks your weapon's hidden element. Also increases bowgun loading capacity. <STYL MOJI_YELLOW_DEFAULT>(There is a cap to loading capacity.)</STYL>
        public const ushort Critical_Eye = 48; // Increases affinity.
        public const ushort Critical_Boost = 49; // Increases the damage of critical hits.
        public const ushort Weakness_Exploit = 50; // Increases the affinity of attacks that exploit a monster weak spot.
        public const ushort Focus = 52; // Increases the fill rate for weapons with gauges and the charge rate for weapons with charge attacks.
        public const ushort Power_Prolonger = 53; // Allows long swords, dual blades, insect glaives, switch axes, and charge blades to stay powered up longer.
        public const ushort Handicraft = 54; // Extends the weapon sharpness gauge. However, it will not increase the gauge past its maximum.
        public const ushort Critical_Draw = 55; // Increases affinity when performing draw attacks.
        public const ushort Partbreaker = 56; // Makes it easier to break or sever parts of large monsters.
        public const ushort Slugger = 57; // Makes it easier to stun monsters.
        public const ushort Stamina_Thief = 58; // Increases certain attacks' ability to exhaust monsters.
        public const ushort Master_Mounter = 59; // Makes it easier to mount monsters.
        public const ushort Airborne = 60; // Increases the damage caused by jumping attacks.
        public const ushort Latent_Power = 61; // Temporarily increases affinity and reduces stamina depletion when certain conditions are met.
        public const ushort Agitator = 62; // Increases attack power and affinity when large monsters become enraged.
        public const ushort Peak_Performance = 63; // Increases attack when your health is full.
        public const ushort Heroics = 64; // Increases attack power and defense when health drops to 35% or lower.
        public const ushort Fortify = 65; // Temporarily increases your attack and defense every time you faint <STYL MOJI_YELLOW_DEFAULT>up to 2 times</STYL>.
        public const ushort Resentment = 66; // Increases attack when you have recoverable damage (the red portion of your health gauge).
        public const ushort Resuscitate = 67; // Improves evasion and reduces stamina depletion when afflicted with abnormal status effects.
        public const ushort Horn_Maestro = 68; // Increases the effect duration of hunting horn melodies.
        public const ushort Capacity_Boost = 69; // Increases the gunlance's shell capacity and charge blade's phial capacity.
        public const ushort Special_Ammo_Boost = 70; // Increases the power of bowgun special ammo, Dragon Piercer, and Thousand Dragons.
        public const ushort Artillery = 71; // Strengthens explosive attacks like gunlance shells, Wyvern's Fire, charge blade phial attacks, and sticky ammo.
        public const ushort Heavy_Artillery = 72; // Increases the firepower of ballistae and cannons.
        public const ushort Marathon_Runner = 73; // Slows down stamina depletion for actions which continuously drain stamina (such as dashing).
        public const ushort Constitution = 74; // Reduces stamina depletion when performing stamina-draining moves such as evading, etc.
        public const ushort Leap_of_Faith = 75; // Allows you to do a dive-evade when facing towards large monsters, and extends the dive-evade distance.
        public const ushort Stamina_Surge = 76; // Speeds up stamina recovery.
        public const ushort Hunger_Resistance = 77; // Reduces maximum stamina depletion over time. However, does not work against cold environments that reduce stamina.
        public const ushort Evade_Window = 78; // Extends the invulnerability period when evading.
        public const ushort Evade_Extender = 79; // Increases evade distance.
        public const ushort Guard = 80; // Reduces knockbacks and stamina depletion when guarding.
        public const ushort Quick_Sheath = 81; // Speeds up weapon sheathing.
        public const ushort Wide_Range = 82; // Allows the effects of certain items to also affect nearby allies.
        public const ushort Item_Prolonger = 83; // Extends the duration of some item effects.
        public const ushort Free_Meal = 84; // Gives you a predetermined chance of consuming a food or drink item for free.
        public const ushort Speed_Eating = 85; // Increases meat-eating and item-consumption speed.
        public const ushort Speed_Sharpening = 86; // Speeds up weapon sharpening when using a whetstone.
        public const ushort Bombardier = 88; // Increases the damage of explosive items.
        public const ushort Mushroomancer = 90; // Lets you digest mushrooms that would otherwise be inedible and gain their advantageous effects.
        public const ushort Master_Fisher = 91; // Improves your skill at fishing.
        public const ushort BBQ_Master = 92; // Improves your skill at cooking meat.
        public const ushort Pro_Transporter = 93; // Increases your speed while transporting items and decreases the likelihood of dropping them.
        public const ushort Master_Gatherer = 94; // Allows you to gather more quickly, and also prevents attacks from knocking you back while gathering.
        public const ushort Honey_Hunter = 95; // Increases the quantity of honey you receive when gathering in the field.
        public const ushort Carving_Pro = 96; // Prevents knockback from attacks while carving.
        public const ushort Divine_Blessing = 97; // Has a predetermined chance of reducing the damage you take.
        public const ushort Palico_Rally = 98; // Powers up Palicoes.
        public const ushort Botanist = 99; // Increases the quantity of herbs and other consumable items you gather.
        public const ushort Geologist = 100; // Increases the number of times you can use a gathering point.
        public const ushort Maximum_Might = 101; // Increases affinity as long as stamina is kept full for a period of time.
        public const ushort Slinger_Capacity = 102; // Increases loading capacity for slinger ammo obtained in the field. Limits the amount of ammo used when firing certain shots.
        public const ushort Stealth = 103; // Makes it easier for monsters to lose sight of you.
        public const ushort Flinch_Free = 104; // Prevents knockbacks and other reactions to small damage.
        public const ushort Scoutfly_Range_Up = 105; // Expands your scoutflies' detection range.
        public const ushort Speed_Crawler = 106; // Increases movement speed while crouching.
        public const ushort Jump_Master = 107; // Prevents attacks from knocking you back during a jump.
        public const ushort Survival_Expert = 108; // Extra health is recovered from environmental interactables like Sporepuffs or Wiggly Litchi.
        public const ushort Aquatic_Polar_Mobility = 109; // Lets you move more freely in water. Also prevents you from being slowed down by terrain effects, such as deep snow.
        public const ushort Cliffhanger = 111; // Decreases stamina depletion when evading while clinging to walls or ivy, or when moving while grappling onto an enemy.
        public const ushort Blindsider = 112; // Improves the effectiveness of flash attacks and items.
        public const ushort Scholar = 114; // Speeds up progress on research levels and special investigations. <STYL MOJI_YELLOW_DEFAULT>(Effect is applied at the quest results screen.)</STYL>
        public const ushort Entomologist = 115; // Decreases the chances of destroying the bodies of small insect monsters, allowing them to be carved.
        public const ushort Effluvia_Resistance = 116; // Gain a resistance to effluvial buildup.
        public const ushort Scenthound = 117; // Increases your scoutflies' gauge fill rate when you find tracks and other traces left by monsters.
        public const ushort Forager_s_Luck = 118; // Increases the chance of finding rare gathering points.
        public const ushort Detector = 119; // Shows rare gathering points on the Wildlife Map.
        public const ushort Tool_Specialist = 120; // Reduces the recharge time for specialized tools.
        public const ushort Affinity_Sliding = 122; // Sliding increases your affinity for a short time.
        public const ushort Elderseal_Boost = 123; // Increases the Elderseal of weapons and dragon ammo.
        public const ushort Intimidator = 124; // Reduces the chances small monsters will attack after spotting you. <STYL MOJI_YELLOW_DEFAULT>(No effect on certain monsters.)</STYL>
        public const ushort Anjanath_Power = 125;
        public const ushort Nergigante_Hunger = 126;
        public const ushort Vaal_Hazak_Vitality = 127;
        public const ushort Rathalos_Power = 128;
        public const ushort Diablos_Power = 129;
        public const ushort Kirin_Blessing = 130;
        public const ushort Pink_Rathian_Mastery = 131;
        public const ushort Anjanath_Will = 132;
        public const ushort Rathalos_Mastery = 135;
        public const ushort Diablos_Mastery = 136;
        public const ushort Kirin_Favor = 137;
        public const ushort Uragaan_Protection = 138;
        public const ushort Bazelgeuse_Protection = 142;
        public const ushort Teostra_Technique = 143;
        public const ushort Kushala_Daora_Flight = 144;
        public const ushort Xeno_jiiva_Divinity = 145;
        public const ushort Zorah_Magdaros_Mastery = 147;
        public const ushort Guild_Guidance = 149;
        public const ushort Commission_Guidance = 150;
        public const ushort Legiana_Blessing = 151;
        public const ushort Legiana_Favor = 152;
        public const ushort Odogaron_Power = 153;
        public const ushort Odogaron_Mastery = 154;
        public const ushort Bow_Charge_Plus = 155; // Increases max bow charge level by one.
        public const ushort Mind_s_Eye_Ballistics = 156; // Prevents attacks from being deflected. Also shortens the distance before ammo and arrows reach maximum power.
        public const ushort Guard_Up = 157; // Allows you to guard against ordinarily unblockable attacks.
        public const ushort Protective_Polish = 158; // Weapon sharpness does not decrease for a set time after sharpening.
        public const ushort Non_elemental_Boost = 159; // Powers up non-elemental weapons you have equipped.
        public const ushort Guts = 160; // Above a certain health threshold, you withstand an attack that would normally cart you (once only).
        public const ushort Hasten_Recovery = 161; // Regenerates your health as you continually attack a monster. Recovery varies by weapon.
        public const ushort Razor_Sharp_Spare_Shot = 162; // Halves sharpness loss. For bows and bowguns, shots have a chance not to expend coatings or ammo.
        public const ushort Lunastra_Favor = 163;
        public const ushort Soul_of_the_Dragoon = 164;
        public const ushort Critical_Element = 165; // Increases elemental damage (fire, water, thunder, ice, dragon) when landing critical hits.
        public const ushort Critical_Status = 166; // Increases abnormal status effect damage (paralysis, poison, sleep, blast) when landing critical hits.
        public const ushort Witcher_s_Knowledge = 167;
        public const ushort Astera_Blessing = 168;
        public const ushort Zinogre_Essence = 169;
        public const ushort Tigrex_Essence = 170;
        public const ushort Nargacuga_Essence = 171;
        public const ushort Brachydios_Essence = 172;
        public const ushort Glavenus_Essence = 173;
        public const ushort Silver_Rathalos_Essence = 174;
        public const ushort Gold_Rathian_Essence = 175;
        public const ushort Shara_Ishvalda_Divinity = 176;
        public const ushort Namielle_Divinity = 177;
        public const ushort Velkhana_Divinity = 178;
        public const ushort Ancient_Divinity = 179;
        public const ushort Commission_Alchemy = 180;
        public const ushort Instructor_s_Guidance = 181;
        public const ushort Anjanath_Dominance = 182;
        public const ushort Rathian_Essence = 183;
        public const ushort Provoker = 184; // Increases the attention drawn when attacking a monster.
        public const ushort Offensive_Guard = 185; // Temporarily increases attack power after executing a perfectly-timed guard.
        public const ushort Coalescence = 186; // Temporarily enhances attacks after recovering from blights or abnormal status.
        public const ushort Safe_Landing = 187; // Allows you to quickly recover from heavy attacks that blow you back when you have your weapon unsheathed.
        public const ushort Barioth_Hidden_Art = 188;
        public const ushort Rathalos_Essence = 189;
        public const ushort Diablos_Ambition = 190;
        public const ushort Legiana_Ambition = 191;
        public const ushort Odogaron_Essence = 192;
        public const ushort Uragaan_Ambition = 193;
        public const ushort Bazelgeuse_Ambition = 194;
        public const ushort Deviljho_Essence = 195;
        public const ushort Vaal_Soulvein = 196;
        public const ushort Kirin_Divinity = 199;
        public const ushort Guild_Pride = 200;
        public const ushort Zorah_Magdaros_Essence = 201;
        public const ushort Lunastra_Essence = 202;
        public const ushort Nergigante_Ambition = 203;
        public const ushort Bludgeoner = 205; // Raises attack as your weapon loses sharpness. Also boosts ranged weapon melee attacks and odds of stunning.
        public const ushort Adrenaline = 206; // Temporarily reduces stamina depletion when health is at 40% or lower.
        public const ushort Coldproof = 207; // Nullifies the effects of cold weather.
        public const ushort Rajang_s_Rage = 208;
        public const ushort Power_Cell = 209;
        public const ushort Survivor = 210;
        public const ushort Safi_jiiva_Seal = 211;
        public const ushort Joyful_Blessing = 212;
        public const ushort Appreciation_Blessing = 213;
        public const ushort Full_Bloom_Blessing = 214;
        public const ushort Sizzling_Blessing = 215;
        public const ushort Fun_Fright_Blessing = 216;
        public const ushort Rajang_Will = 217;
        public const ushort Brachydios_Will = 218;
        public const ushort Kulve_Taroth_Essence = 219;
        public const ushort Frostfang_Absolute_Art = 220;
        public const ushort Alatreon_Divinity = 221;
        public const ushort Fatalis_Legend = 222;
        public const ushort Clutch_Claw_Boost = 223; // Clutch claw weapon attacks wound monsters easier, and have a better chance of dropping slinger ammo.
        public const ushort New_World = 224;
    }
}