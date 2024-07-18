using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

// INHERITANCE
public class SinProjectile : Projectile
{
    float m_amplitude;
    // ENCAPSULATION
    [SerializeField] float amplitude
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
    float m_period; 
    [SerializeField]
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
    }

    // POLYMORPHISM
    public override void Move()
    {
        transform.position = transform.position + velocity * Time.deltaTime + Vector3.right * Mathf.Sin(Time.time/ period) * amplitude;
    }
}
