using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    public GameObject parachute;
    public Transform[] Positions;
    private Vector3 _initialPosition;
    private Vector3 _currentPosition;

    private LineRenderer _lineRenderer;

    private bool test = true;


    public void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.SetWidth(0.2f, 0.2f);
        _lineRenderer.enabled = false;

       
        
       
    }

    
    public void Update()
    {
        _currentPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        _lineRenderer.positionCount = 2;
        _lineRenderer.SetPosition(0, parachute.transform.position);
        _lineRenderer.SetPosition(1, _currentPosition);


        /*if (test = true)
        {



            _initialPosition = GetCurrentMousePosition().GetValueOrDefault();
            _lineRenderer.SetPosition(0, _initialPosition);
          
            _lineRenderer.SetVertexCount(1);
            _lineRenderer.enabled = true;
        }
        else if (Input.GetMouseButton(0))
        {
            _currentPosition = GetCurrentMousePosition().GetValueOrDefault();
            _lineRenderer.SetVertexCount(2);
            _lineRenderer.SetPosition(1, _currentPosition);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            _lineRenderer.enabled = false;
            var releasePosition = GetCurrentMousePosition().GetValueOrDefault();
            var direction = releasePosition - _initialPosition;
            Debug.Log("Process direction " + direction);
        }
    }

    private Vector3? GetCurrentMousePosition()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var plane = new Plane(Vector3.forward, Vector3.zero);

        float rayDistance;
        if (plane.Raycast(ray, out rayDistance))
        {
            return ray.GetPoint(rayDistance);

        }

        return null;
        */
    }
    

    /*
    _initialPosition = GetCurrentMousePosition().GetValueOrDefault();
    _lineRenderer.SetPosition(0, _initialPosition);
            _lineRenderer.SetVertexCount(1);
            _lineRenderer.enabled = true;*/
}
