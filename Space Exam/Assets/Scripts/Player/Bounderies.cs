using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounderies : MonoBehaviour
{
    private Vector2 screenBounderies;
    private float objectWidth;
    private float objectHeight;
     
    // Start is called before the first frame update
    void Start()
    {
        screenBounderies = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x/2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y/2;


    }

    // Update is called once per frame

    //Because called after movement script

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        // viewPos.x = Mathf.Clamp(viewPos.x, screenBounderies.x + objectWidth, screenBounderies.x * -1 - objectWidth);
        // viewPos.y = Mathf.Clamp(viewPos.y, screenBounderies.y +objectHeight, screenBounderies.y * -1- objectHeight);
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounderies.x * -1 - objectWidth, screenBounderies.x + objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.x, screenBounderies.x * -1 - objectHeight, screenBounderies.x + objectHeight);

        transform.position = viewPos;

     //   viewPos.x = Mathf.Clamp(viewPos.x, screenBounderies.x * -1 - objectWidth, screenBounderies.x + objectWidth);
      // viewPos.x = Mathf.Clamp(viewPos.x, screenBounderies.x * -1 - objectHeight, screenBounderies.x + objectHeight);
    }

}
