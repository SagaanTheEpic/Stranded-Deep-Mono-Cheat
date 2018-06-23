﻿using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Beam;
using Beam.AI;

namespace StrandardDeep_Cheat
{
    public class SkinnableESP : MonoBehaviour
    {
        private void Start()
        {

        }
        IEnumerator SleepFor(float Time)
        {
            yield return new WaitForSeconds(Time);
        }

        private void OnGUI()
        {
            if (Menu.EntityESP == true)
            {
                if (Menu.SkinnableESP)
                {
                    IEnumerable<Interactive_SKINNABLE> playerProxies = FindObjectsOfType<Interactive_SKINNABLE>();
                    foreach (Interactive_SKINNABLE playerProxy in playerProxies)
                    {
                        Player localplayer = FindObjectsOfType<Player>()[0];
                        Vector3 pos = playerProxy.transform.position;
                        float dist = Vector3.Distance(pos, localplayer.transform.position);
                        if (dist < Menu.EntityDist)
                        {
                            //Extremely useful
                            Vector3 posScreen = Camera.main.WorldToScreenPoint(pos);

                            if (posScreen.z > 0 & posScreen.y < Screen.width - 2)
                            {
                                //Interactive_FISHES proxyName = playerProxy.GetComponent<Interactive_FISHES>();

                                string playerName = "Skinnable";
                                posScreen.y = Screen.height - (posScreen.y + 1f);
                                Render.DrawString(new Vector2(posScreen.x, posScreen.y), ("   " + playerName + string.Format(" [{0:0}m]", (object)dist)), Color.green);
                            }
                        }
                        SleepFor(0.300f);
                    }
                    SleepFor(0.300f);
                }
                SleepFor(0.300f);

            }
        }


        private void Update()
        {

        }
    }
}
