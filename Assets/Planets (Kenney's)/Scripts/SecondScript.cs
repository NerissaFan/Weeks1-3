using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SecondScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorpos.x, cursorpos.y);
    }
}
