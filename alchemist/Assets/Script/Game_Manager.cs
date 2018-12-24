using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public Target_ani T1_a;
    public Target_ani T2_a;
    public Target_ani T3_a;

    public float Time_T1 = 0;
    public float Time_T2 = 0;
    public float Time_T3 = 0;

    public bool Reset1 = false;
    public bool Reset2 = false;
    public bool Reset3 = false;

    void Update()
    {
        if (T1_a.Particle_On)
        {
            Time_T1 += Time.deltaTime;
        }
        if (Time_T1 > 2.0f)
        {
            T1_a.P.SetActive(false);
            T1_a.Particle_On = false;
            Reset1 = true;
            Time_T1 = 0;
        }
        if (T2_a.Particle_On)
        {
            Time_T2 += Time.deltaTime;
        }
        if (Time_T2 > 2.0f)
        {
            T2_a.P.SetActive(false);
            T2_a.Particle_On = false;
            Reset2 = true;
            Time_T2 = 0;
        }

        if (T3_a.Particle_On)
        {
            Time_T3 += Time.deltaTime;
        }
        if (Time_T3 > 2.0f)
        {
            T3_a.P.SetActive(false);
            T3_a.Particle_On = false;
            Reset3 = true;
            Time_T3 = 0;
        }
        if(Reset1 && Reset2 && Reset3)
        {
            T1_a.Target.SetActive(true);
            T2_a.Target.SetActive(true);
            T3_a.Target.SetActive(true);

            Reset1 = false;
            Reset2 = false;
            Reset3 = false;
        }

    }
}
