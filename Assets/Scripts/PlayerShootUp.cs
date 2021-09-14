using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerShootUp : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    private List<GameObject> bulletList = new List<GameObject>();

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
            bulletList.Add(newBullet);
        }

        for(int i = 0; i < bulletList.Count; i++)
        {
            GameObject goBullet = bulletList[i];
            if(goBullet != null)
            {
                goBullet.transform.Translate(new Vector3(0, 1) * Time.deltaTime * bulletSpeed);
            }

            Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
            if(bulletScreenPos.y >= Screen.height || bulletScreenPos.y <= 0)
            {
                DestroyObject(goBullet);
                bulletList.Remove(goBullet);
            }

        }
    }
}