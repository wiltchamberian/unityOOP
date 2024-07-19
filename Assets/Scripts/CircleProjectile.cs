using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleProjectile : Projectile
{
    [SerializeField] float radius;
    [SerializeField] float omega;
    Vector3 centerPosition;
    // Start is called before the first frame update
    void Start()
    {
        centerPosition = Vector3.zero;
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
        centerPosition = centerPosition + velocity * Time.deltaTime;
        transform.position = centerPosition + Vector3.right * radius * Mathf.Cos(theta) + Vector3.up * radius * Mathf.Sin(theta);
        base.Move();
    }
}
