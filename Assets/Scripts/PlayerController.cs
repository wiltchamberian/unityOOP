using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ProjectileType
{
    Straight,
    Sin,
    Circle,
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] Projectile[] projectiles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            int select = Random.Range(0, 3);
            Spawn(select);
        }
    }



    // ABSTRACTION
    void Spawn(int select)
    {
        Instantiate(projectiles[select], transform.position, projectiles[select].transform.rotation);
    }

}
