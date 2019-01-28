﻿using System;
using System.Collections.Generic;

namespace Rasa.Structures
{
    using Data;

    public class Creature
    {
        public uint DbId { get; set; }
        public EntityClassId EntityClassId { get; set; }
        // npc data (only if creature is a NPC)
        public Npc Npc { get; set; }
        // loot data (only if creature is harvestable)
        public CreatureLootData LootData { get; set; }
        public Actor Actor { get; set; }                                        // the base actor object
        public Factions Faction { get; set; }
        public int Level { get; set; }
        public int MaxHitPoints { get; set; }
        public int NameId { get; set; }
        public long UpdatePositionCounter;                                       // decreases, when it hits 0 and the cell position changed, call creature_updateCellLocation()
        public Dictionary<EquipmentData, AppearanceData> AppearanceData { get; set; }
        //sint32 lastattack;
        //float velocity;
        //sint32 rottime; //rotation speed
        //float range; //attackrange
        //sint32 attack_habbit; //meelee or range fighter 
        //sint32 agression; // hunting timer for enemys
        // aggro info
        public float AggroRange = 18.0f; // how far away the creature can detect enemies, usually 24.0f but can be increased by having high-range attacks
        public long AggressionTime = 5000; // ToDo
        //sint32 wanderstate;
        public float WanderDistance { get; internal set; }
        public float Walkspeed = 4f;
        public float RunSpeed = 6.5f;
        //sint32 movestate;
        //float wx,wy,wz; // target destination (can be far away)
        public BaseBehaviorBaseNode HomePos = new BaseBehaviorBaseNode();  //--- spawn location (used for wander)
        public BaseBehaviorBaseNode Pathnodes { get; set; } //--entity patrol nodes
        //sint32** aggrotable; //stores enemydamage
        //sint32 aggrocount;
        // origin
        public SpawnPool SpawnPool { get; set; }    // the spawnpool that initiated the creation of this creature
        // behavior controller
        public BehaviorState Controller = new BehaviorState();
        // loot dispenser
        public uint LootDispenserObjectEntityId { get; internal set; }
        // creature actions
        public CreatureMissile[] Actions { get; set; }

        // creature tumers
        public long LastAgression { get; internal set; }
        public long LastRestTime { get; internal set; }
    }
}
