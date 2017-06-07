
using UnityEngine;

public class RobotHint : MonoBehaviour {

    public float interval = 5;

    [SerializeField]
    private Sprite[] _sprites;

    private float _time;
    private float _time2;

    // Update is called once per frame
    void Update()
    {
        _time++;

        if (_time >= 60 * Random.Range(3, interval))
        {
            _time2++;
            gameObject.GetComponent<SpriteRenderer>().sprite = _sprites[1];

            if (_time2 >= 3.0f)
            {
                _time = 0;
                _time2 = 0;
                gameObject.GetComponent<SpriteRenderer>().sprite = _sprites[0];
            }
        }
    }
}
