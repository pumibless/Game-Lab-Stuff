using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask whatToHit;

    public Transform BulletTrailPrefab;

    float timeToFire = 0;
    Transform firePoint;


	// Use this for initialization
	void Awake () {
        firePoint = transform.Find("FirePoint");
        if (firePoint == null) {
            Debug.LogError("NO FIREPOINT!");

        }

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (fireRate == 0)
        { //getkeydown mouse0
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        else {
            if (Input.GetButton("Fire1") && Time.time > timeToFire) {
                timeToFire = Time.time + 1 / fireRate;
                Shoot (); 
            }
        }
	}

    void Shoot() {

        Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);

        //Calculate Rotation
        Vector3 MousePos;
        MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(MousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        Instantiate(BulletTrailPrefab, firePoint.position, Quaternion.AngleAxis(angle - 90, Vector3.forward));

        Debug.DrawLine(firePointPosition, (mousePosition - firePointPosition) * 100, Color.cyan);
        if (hit.collider != null) {
            Debug.DrawLine(firePointPosition, hit.point, Color.red);
            Debug.Log("We hit " + hit.collider.name + " and did " + Damage + " damage.");

        }
    }

    
}
