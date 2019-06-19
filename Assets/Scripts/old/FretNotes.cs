using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FretNotes : MonoBehaviour
{

    public GameObject[] note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;


     void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Destroy(note1);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Destroy(note2);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Destroy(note3);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Destroy(note4);
        }
      
    }

}
