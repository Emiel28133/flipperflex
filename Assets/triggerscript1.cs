using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerscript1 : MonoBehaviour
{
    [SerializeField] private UnityEvent OnHit;

    void OnTriggerEnter(Collider collider) {
        if (!collider.transform.CompareTag("Player")) return;
        
        float dx = transform.position.x - collider.transform.position.x;

        if (dx > 0) {
            OnHit.Invoke();
        }
    }
}
