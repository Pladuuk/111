using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public List<AudioClip> playerWalking;
    public AudioClip playerJumping;
    public AudioSource playerSource;

    public int pos;

    public static PlayerSound instance;
    private void Awake()
    {
        instance = this;
        playerSource = GetComponent<AudioSource>();

    }
    
    public void playWalking()
    {
        pos = (int)Mathf.Floor(Random.Range(0, playerWalking.Count));
        playerSource.PlayOneShot(playerWalking[pos]);
    }

    public void playJumping()
    {
        playerSource.PlayOneShot(playerJumping);
    }
}
