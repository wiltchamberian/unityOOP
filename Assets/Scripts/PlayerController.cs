using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(new Vector3(horizontal, 0, vertical));
     
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
