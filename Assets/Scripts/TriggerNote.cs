using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TriggerNote : MonoBehaviour
{
    [SerializeField] KeyCode hitButton = KeyCode.Space;
    [SerializeField] UnityEvent OnHit;

    //private void Update()
    //{
    //    Debug.Log("Updating...");
    //}

    void OnTriggerStay(Collider col)
    {

        var hit = col.GetComponent<Note>();

       

        if (hit is Note)
        {
            if (Input.GetKeyDown(hitButton))
            {
                //Successful hit!
                OnHit.Invoke();

               

                //Increase score
                ScoreManager.instance.AddScore(10);
                //ScoreManager.instance.AddScore(hit.score);

                //Destroy the note
                Destroy(hit.gameObject);
            }
            //else
            //    Debug.Log("NOT HITTING!");

        }
    }

   

}
