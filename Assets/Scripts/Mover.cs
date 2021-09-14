using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{

    public GameObject Projectile;
    private GameObject cloneProj;
    public float fireSpeed;
    public float fireRate;
    public GameObject Player;
    public float speed;
    public Vector3 target;
    //public Transform target1;

    void Start()
    {
        //target = target1.transform.position;
        target = Input.mousePosition - transform.position;


        transform.rotation = Player.transform.rotation;
    }


    void Update()
    {
        transform.rotation = Player.transform.rotation;
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > fireRate)
        {
            fireRate = Time.time + fireSpeed;
            cloneProj = (GameObject)Instantiate(Projectile, transform.position, transform.rotation);
            //target = target1.transform.position;
            target = Input.mousePosition - transform.position;


        }
        //var delta = speed * Time.deltaTime;
        cloneProj.transform.position = Vector3.MoveTowards(cloneProj.transform.position, target, speed);
        //if (cloneProj.transform.position == target)
        if(Time.time >= fireRate)
        {
            Destroy(cloneProj.gameObject);
        }
    }

}