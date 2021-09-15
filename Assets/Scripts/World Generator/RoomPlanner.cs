﻿using UnityEngine;

namespace Assets.Scripts.World_Generator
{
    public class RoomPlanner
    {
        public Vector3 Scale;
        public Vector3 Position;

        public RoomPlanner SetPosition(Vector3 Position)
        {
            this.Position = Position;
            return this;
        }

        public RoomPlanner SetSize(Vector3 Scale)
        {
            this.Scale = Scale;
            return this;
        }

        public RoomPlanner AddPlayerSpawn()
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = new Vector3(Position.x, Position.y + 5, Position.z);
            var starterWeapon = UnityExtensions.LoadPrefabFrom("Items/Sword/Short Sword");
            starterWeapon.transform.position = new Vector3(Position.x, Position.y + 5, Position.z);
            var torch = UnityExtensions.LoadPrefabFrom("Items/Torch/Torch");
            torch.transform.position = new Vector3(Position.x, Position.y + 5, Position.z);
            return this;
        }

        public RoomPlanner AddEnemySpawnWithChanceOf(int chance)
        {
            int between0and100 = Random.Range(0, 100);
            if (between0and100 > chance)
            {
                var enemy = UnityExtensions.LoadPrefabFrom("NPCs/Enemy");
                enemy.transform.position = new Vector3(Position.x, Position.y + 5, Position.z);
            }
            return this;
        }
    }
}
