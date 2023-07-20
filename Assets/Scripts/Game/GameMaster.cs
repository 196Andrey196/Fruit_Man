using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private Challenge _challenge;
    private FinalLevelAction _finalLevelAction;
    [SerializeField] private GameObject _objectSpawner;

    private void Start()
    {
        _challenge = GetComponent<Challenge>();
        _finalLevelAction = GetComponent<FinalLevelAction>();
    }
    private void Update()
    {
        if (_challenge._challengeComplite)
            LevelComplite();

    }

    private void LevelComplite()
    {
        StartCoroutine(_finalLevelAction.FinalAction());
        _objectSpawner.GetComponent<ObjectSpawner>().enabled = false;
    }
}
