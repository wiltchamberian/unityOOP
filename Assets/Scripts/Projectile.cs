using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] protected Vector3 velocity;
    private float duration = 0.0f;
    protected Vector3 originalPosition;
    [SerializeField] float lifeTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // POLYMORPHISM
    public virtual void Move()
    {
        duration += Time.deltaTime;
        if(duration > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
