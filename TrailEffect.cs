using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    [SerializeField] GameObject trail; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)){
          trail.SetActive(trail); 
          Plane objPlane = new Plane ( 
        Camera.main.transform.forward * -1, 
        new Vector3(trail.transform.position.x,
         trail.transform.position.y,
          trail.transform.position.z 
        ));

        Ray mRay = Camera.main.ScreenPointToRay(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Input.mousePosition.z
        ));
        float rayDistance;
        if (objPlane.Raycast(mRay, out rayDistance))
            trail.transform.position = mRay.GetPoint(rayDistance);
        } 
        else{
            trail.SetActive(false);
        }

        
    }
}
