using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 1;
    [SerializeField] GameObject bulletEmetor;
    private float timerLastShoot = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLastShoot += Time.deltaTime;
        if (timerLastShoot > fireRate)
        {
        var fire1 = Input.GetAxis("Fire1");
        if (fire1 > 0)
        {
            Instantiate(bullet, bulletEmetor.transform.position, bulletEmetor.transform.rotation);
                print(bulletEmetor.transform.rotation);
                timerLastShoot = 0;
        }
        }
		
	}
}
