using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage = 20;
    [SerializeField] private float fireRate = 10;
    [SerializeField] private float range = 200;
    [SerializeField] private AudioClip shotSFX;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float delay;
    [SerializeField] private Camera _cam;
    public static int ammo=8;
    private float nextFire=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void Reload()
    {
        ammo = 8;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>nextFire && (ammo>0))
        {
            nextFire = Time.time + 1f / fireRate;
            ammo -= 1;
            Shoot();
        }
    }


    void Shoot()
    {
        _audioSource.PlayOneShot(shotSFX);

        RaycastHit hit;

        if (Physics.Raycast(_cam.transform.position,_cam.transform.forward, out hit, range))
        {
            Debug.Log("Попадание");
                var enemy = hit.rigidbody.GetComponent<MyEnemy>();
                enemy.Hurt(damage);
        }
    }
}
