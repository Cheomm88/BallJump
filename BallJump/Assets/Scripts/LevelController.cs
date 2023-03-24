using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0f, Input.GetAxis("Horizontal") * speed,0f);
        transform.Rotate(rot);
    }
}
