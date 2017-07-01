﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Barotrauma
{
    partial class HuskInfection
    {
        partial void UpdateProjSpecific(float prevTimer, Character character)
        {
            if (IncubationTimer < 0.5f)
            {
                if (prevTimer % 0.1f > 0.05f && IncubationTimer % 0.1f < 0.05f)
                {
                    GUI.AddMessage(InfoTextManager.GetInfoText("HuskDormant"), Color.Red, 4.0f);
                }
            }
            else if (IncubationTimer < 1.0f)
            {
                if (state == InfectionState.Dormant && Character.Controlled == character)
                {
                    new GUIMessageBox("", InfoTextManager.GetInfoText("HuskCantSpeak"));
                }
            }
            else
            {
                if (Character.Controlled == character) new GUIMessageBox("", InfoTextManager.GetInfoText("HuskActivate"));
            }
        }
    }
}