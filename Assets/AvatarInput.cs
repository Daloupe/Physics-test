using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEditor.Events;


public class AvatarInput : MonoBehaviour
{   
    public float Gravity = -10;
    public LayerMask LayerMask;

    Vector3 _velocity;
    BoxCollider2D _collider;
    ContactFilter2D _filter = new ContactFilter2D();
    RaycastHit2D[] _hits = new RaycastHit2D[2];

    LayerMask _towerLayerMask;
    LayerMask _groundLayerMask;

    private void Awake()
    {
        _filter.SetLayerMask(LayerMask);
        _collider = GetComponent<BoxCollider2D>();

        _towerLayerMask = LayerMask.NameToLayer("Tower");
        _groundLayerMask = LayerMask.NameToLayer("Ground");
    }

    void FixedUpdate()
    {
        // Gravity
        _velocity.y += Gravity * Time.fixedDeltaTime;

        // Collisions
        var hitCount = _collider.Cast(_velocity.normalized, _filter, _hits, _velocity.magnitude * Time.fixedDeltaTime);

        if (hitCount > 0)
        {
            if (_hits[0].collider.CompareTag("Tower")) //.gameObject.layer == _towerLayerMask)
            {
                // Top of tower
                if (_hits[0].normal == Vector2.up)
                {
                    _velocity = new Vector3(3.25f, 10, 0);
                }
                // Side of tower
                else
                {
                    _velocity.x *= -1f;
                }
            }
            // Ground
            else if (_hits[0].collider.CompareTag("Ground"))  //.gameObject.layer == _groundLayerMask
            {
                _velocity = new Vector3(3.25f, 10, 0); ;
            }
        }

        // Translation
        transform.Translate(_velocity * Time.fixedDeltaTime, Space.World);
    }


    void Update()
    {
        // Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _velocity = new Vector3(0, -30, 0);
        }

        // Rotation
        var direction = -Mathf.Sign(_velocity.x);

        if (_velocity.y > 3f)
        {
            transform.Rotate
                (
                    xAngle: 0,
                    yAngle: 0,
                    zAngle: direction * 180 * _velocity.y * Time.deltaTime
                );
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards
                (
                    from: transform.rotation,
                    to: Quaternion.AngleAxis
                        (
                            angle: Vector3.Angle
                                (
                                    from: Vector3.up,
                                    to: _velocity
                                ) * direction,
                            axis: Vector3.forward
                        ),
                    maxDegreesDelta: 15
                );
        }
    }
}
