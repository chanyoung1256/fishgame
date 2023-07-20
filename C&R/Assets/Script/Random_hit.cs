using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Random_hit : MonoBehaviour
{
    public Animator animator;
    public string animationParameter = "FishMove_Sphere";
    public float minDelay = 3f;
    public float maxDelay = 10f;
    public string nextSceneName; // 다른 씬으로 전환할 때 사용할 씬 이름

    private float timer = 0f;
    private float randomDelay = 0f;
    private bool isAnimating = false;

    private void Start()
    {
        RandomizeDelay();
    }

    private void Update()
    {
        if (!isAnimating)
        {
            timer += Time.deltaTime;
            if (timer >= randomDelay)
            {
                PlayRandomAnimation();
                RandomizeDelay();
            }
        }
    }
    private void PlayRandomAnimation()
    {
        animator.SetTrigger(animationParameter);
        isAnimating = true;
    }

    private void RandomizeDelay()
    {
        randomDelay = Random.Range(minDelay, maxDelay);
        timer = 0f;
        isAnimating = false;
    }

    public void OnAnimationEnd()
    {
        isAnimating = false;
        SwitchScene();
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}