using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerLongNote : MonoBehaviour
{
    [SerializeField] KeyCode hitButton = KeyCode.Space;
    [SerializeField] UnityEvent OnHit;

    void OnTriggerStay(Collider col)
    {
        var hit = col.GetComponent<LongNote>();

        if (hit is LongNote)
        {
            if (Input.GetKey(hitButton))
            {
                OnHit.Invoke();

                ScoreManager.instance.AddScore(hit.score);

                Destroy(hit.gameObject);
            }
        }
    }
}
