using UnityEngine;
using System.Collections.Generic;


public class Challenge : MonoBehaviour
{
    public bool _challengeComplite = false;

    [SerializeField] private UiChallengeInfo[] _staps;


    private void Start()
    {
        foreach (var stap in _staps)
        {
            int randomValue = Random.Range(1, 5);
            stap.countNeadItem = randomValue;
        }
    }
    private void Update()
    {
        OutputChalangeInfo();
    }
    private void OutputChalangeInfo()
    {
        foreach (var stap in _staps)
        {
            stap.textCountChalangeItem.text = stap.countHaveItem + "/" + stap.countNeadItem;
        }

    }

    public void UpdateItemCountInBascet(string name)
    {
        foreach (var stap in _staps)
        {
            if (stap.name == name && stap.countHaveItem < stap.countNeadItem)
                stap.countHaveItem++;
        }
        ChallengeComplite();
    }

    private void ChallengeComplite()
    {
        bool allCompleted = true;

        foreach (var stap in _staps)
        {
            if (stap.countHaveItem != stap.countNeadItem)
            {
                allCompleted = false;
                break;
            }
        }
        _challengeComplite = allCompleted;
    }
}
