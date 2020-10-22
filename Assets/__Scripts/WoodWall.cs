using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodWall : MonoBehaviour
{
    public GameObject woodWall;
    void OnCollisionEnter(Collision coll)
    {
        GameObject collideWith = coll.gameObject;
        if (collideWith.tag == "Projectile") Destroy(woodWall);
    }
}
