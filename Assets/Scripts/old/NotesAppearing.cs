using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesAppearing : MonoBehaviour
{

    public GameObject greenNotePrefab;


    void OnTriggerStay(Collider col)
    {
        if (tag == "Note")
        {
            greenNotePrefab.SetActive(false);
        }
    }
}
