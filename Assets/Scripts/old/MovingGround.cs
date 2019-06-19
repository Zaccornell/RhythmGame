using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }   
}
