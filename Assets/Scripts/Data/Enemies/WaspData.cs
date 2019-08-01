﻿using System.Collections;
using System.Collections.Generic;
using SpaceMarine.Model;
using UnityEngine;

namespace SpaceMarine.Data
{
    [CreateAssetMenu(menuName = "Data/Wasp")]
    public class WaspData : EnemyData
    {
        public override IEnemy GetEnemy(IRoom room)
        {
            return new Wasp(this);
        }
    }
}