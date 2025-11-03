using UnityEngine;

public class DisableTimer : MonoBehaviour
{
    [SerializeField] private float _maxTime = 0.5f;
    private float _time;

    // ------------------------------------------------------------------------
    void OnEnable()
    {
        _time = _maxTime;
    }

    // ------------------------------------------------------------------------
    void Update()
    {
        _time -= Time.deltaTime;
        if(_time <= 0.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
