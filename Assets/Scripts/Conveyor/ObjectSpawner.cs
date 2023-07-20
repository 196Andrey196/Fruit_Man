using UnityEngine;
using System.Collections;
public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private float _spawnCountDown;
    [SerializeField] private float _timeBetweenWaves;
    [SerializeField] private GameObject[] _item;



    void Update()
    {
        SpawnTimer();
    }
    private void SpawnTimer()
    {
        if (_spawnCountDown <= 0f)
        {
            _spawnCountDown = _timeBetweenWaves;
            StartCoroutine(SpawnByTimer());
            return;
        }
        _spawnCountDown -= Time.deltaTime;

        // _spawnCountDown = Mathf.Clamp(_spawnCountDown, 0f, Mathf.Infinity);
        // _waveCountDownText.text = string.Format("{0:00.00}", _spawnCountDown);
    }
    private IEnumerator SpawnByTimer()
    {
        int randomObject = Random.Range(0, _item.Length);
        Instantiate(_item[randomObject], transform.position, transform.rotation);
        yield return new WaitForSeconds(_timeBetweenWaves);

    }

}
