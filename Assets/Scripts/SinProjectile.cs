using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

// INHERITANCE
public class SinProjectile : Projectile
{
    [SerializeField] float m_amplitude;
    Vector3 centerPosition;
    // ENCAPSULATION
    float amplitude
    {
        get
        {
            return m_amplitude;
        }
        set
        {
            if(amplitude >= 0)
            {
                m_amplitude = amplitude;
            }
        }
    }
    [SerializeField]  float m_period; 
    float period
    {
        get
        {
            return m_period;
        }
        set
        {
            if(period >=0)
            {
                m_period = period;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // POLYMORPHISM
    public override void Move()
    {
        centerPosition = centerPosition + velocity * Time.deltaTime;
        transform.position = centerPosition + Vector3.right * Mathf.Sin(Time.time/ period) * amplitude;
        base.Move();
    }
}
