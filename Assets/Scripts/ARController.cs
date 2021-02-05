using UnityEngine;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARController : MonoBehaviour
{
    [SerializeField]
    private GameObject model;
    private ARRaycastManager aRRaycastManager;
    private Vector2 touchPosition;
    private List<ARRaycastHit> arHits = new List<ARRaycastHit>();

    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            
            if (aRRaycastManager.Raycast(touchPosition, arHits, TrackableType.PlaneWithinPolygon))
            {
               Pose pose = arHits[0].pose;
                Instantiate(model, pose.position, pose.rotation);
            }
        }
    }
}
