using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeWatcher : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.beeTouched(-1);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
