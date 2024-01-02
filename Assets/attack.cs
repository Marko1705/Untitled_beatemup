using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool is_Player, is_Enemy;

    public GameObject hit_FX;

    void Update() {
        DetectCollision();
    }
    
    void DetectCollision() {

        Collider[] hit = physics.OverlapShare(transform.position, radius, collisionLayer);

    } // detect collision 


} // class










































