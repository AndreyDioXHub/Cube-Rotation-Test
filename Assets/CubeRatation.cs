using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRatation : MonoBehaviour
{
    [SerializeField]
    private Slider _mySlider;
    [SerializeField]
    private float _minSpeed = 0f;
    [SerializeField]
    private float _maxSpeed = 10f;
    private float _speed = 10f;
    [SerializeField]
    private Vector3 _direction = new Vector3(0,1,0);
    private float _currentAxisAngle;

    // Update is called once per frame
    void Update()
    {
       SetCurrentSpeed();
       _currentAxisAngle += _speed * Time.deltaTime;
       transform.rotation = Quaternion.AngleAxis(_currentAxisAngle, _direction);
    }

    public void SetCurrentSpeed()
    {
        _speed = (_maxSpeed - _minSpeed) * _mySlider.value;
    }

    public void SetXDirection()
    {
        _direction = new Vector3(1, 0, 0);
        _currentAxisAngle = transform.localEulerAngles.x;
    }

    public void SetYDirection()
    {
        _direction = new Vector3(0, 1, 0);
        _currentAxisAngle = transform.localEulerAngles.y;
    }

    public void SetZDirection()
    {
        _direction = new Vector3(0, 0, 1);
        _currentAxisAngle = transform.localEulerAngles.z;
    }

}
