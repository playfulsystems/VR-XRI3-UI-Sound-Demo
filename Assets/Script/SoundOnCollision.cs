using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    int collisionPointsPlayed = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (Time.time < 0.5f) return;
        
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.volume = 1;
        collisionPointsPlayed = 1;
        audioSource.Play();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Time.time < 0.5f) return;

        // collision.contacts
        if (collision.contacts.Length > collisionPointsPlayed)
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.volume *= 0.75f;
            audioSource.Play();
            collisionPointsPlayed++;
        }
    }


}
