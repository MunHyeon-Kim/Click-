using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTest : MonoBehaviour
{

    GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        box = Instantiate(Resources.Load<GameObject>("Box"));
        box.transform.position = new Vector3(1.0f, -1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
