using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parcala : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fractured;
    public float breakforce;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            BreakTheThing();
        }
    }
    public void BreakTheThing(){
        GameObject frac= Instantiate(fractured,transform.position,transform.rotation);
        foreach(Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>()){
            Vector3 force=(rb.transform.position-transform.position).normalized*breakforce;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }
}
