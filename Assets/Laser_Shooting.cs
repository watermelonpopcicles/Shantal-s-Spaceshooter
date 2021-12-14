using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Shooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform barrel; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject Clone = Instantiate(projectile, barrel.position, barrel.rotation);
            Destroy(Clone, 3);
        }
    }
}
