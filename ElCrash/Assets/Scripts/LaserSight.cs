using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSight : MonoBehaviour
{
    LineRenderer lr;


    [SerializeField] private Transform _initialPosition;
    private Vector2 _currentPosition;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }


    private void Update()
    {
        _currentPosition = GetCurrentMousePosition().GetValueOrDefault();
        lr.SetPosition(0, _currentPosition);
        lr.SetVertexCount(1);
        lr.enabled = true;
    }


    private Vector3? GetCurrentMousePosition()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var plane = new Plane(Vector2.up, Vector2.zero);

        float rayDistance;
        if (plane.Raycast(ray, out rayDistance))
        {
            return ray.GetPoint(rayDistance);

        }

        return null;
    }

}
