using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    public float distoryTime;
    float timer = 0;

    // Update is called once per frame  
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(-1, Random.Range(-2.5f, 3.0f), 0);
            timer = 0;
            Destroy(newpipe, distoryTime);
        }
        
    }
}
