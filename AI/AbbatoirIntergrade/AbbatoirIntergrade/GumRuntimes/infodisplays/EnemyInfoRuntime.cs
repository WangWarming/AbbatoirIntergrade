﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class EnemyInfoRuntime
    {
        public void Show(BaseEnemy enemy)
        {

            var isEnemyOnScreen =  enemy.X >= Camera.Main.X - Camera.Main.OrthogonalWidth / 2 &&
                                   enemy.X <= Camera.Main.X + Camera.Main.OrthogonalWidth / 2 &&
                                   enemy.Y >= Camera.Main.Y - Camera.Main.OrthogonalHeight / 2 &&
                                   enemy.Y <= Camera.Main.Y + Camera.Main.OrthogonalHeight / 2;

            Visible = isEnemyOnScreen;

            if (Visible)
            {
                var minMaxX = (CameraZoomManager.OriginalOrthogonalWidth - GetAbsoluteWidth()) / 2;
                var minMaxY = (CameraZoomManager.OriginalOrthogonalHeight - GetAbsoluteHeight()) / 2;

                var newX = (enemy.X - Camera.Main.X) * CameraZoomManager.GumCoordOffset;
                var newY = (enemy.Y - Camera.Main.Y + enemy.SpriteInstance.Height / 2) * CameraZoomManager.GumCoordOffset + GetAbsoluteHeight() / 2;

                X = MathHelper.Clamp(newX, -minMaxX, minMaxX);
                Y = MathHelper.Clamp(newY, -minMaxY, minMaxY);

                EnemyName = enemy.DisplayName;
                EnemyHealth = $"{enemy.HealthRemaining} / {enemy.MaximumHealth}";
            }
        }

        public void Hide()
        {
            Visible = false;
        }
    }
}