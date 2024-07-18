using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleProjectile : Projectile
{
    [SerializeField] float radius;
    [SerializeField] float omega;
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
        float theta = Time.time * omega;
        transform.position = transform.position + velocity * Time.deltaTime + Vector3.right * radius * Mathf.Cos(theta) + Vector3.up * radius * Mathf.Sin(theta);
    }
}
