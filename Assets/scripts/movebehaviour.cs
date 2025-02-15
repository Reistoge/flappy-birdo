using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebehaviour : MonoBehaviour
{
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        /// same thing.
        //gameObject.transform.Translate(Vector2.left*velocity*Time.deltaTime);

        transform.position+=Vector3.left*velocity*Time.deltaTime;

        //why with vetor 2 dontwork?
        /* transform.position+=Vector2.left*velocity*Time.deltaTime; */
    }

}
