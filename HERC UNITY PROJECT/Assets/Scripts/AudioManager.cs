using UnityEngine.Audio;
using System; 
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    void Awake()
    {
        {
            foreach (Sound s in sounds)
            {
               s.source = gameObject.AddComponent<AudioSource>();
               s.source.clip = s.clip;

               s.source.volume = s.volume;
               s.source.pitch = s.pitch;
            }
        }
        
         void Play (string name)
        {
            Array.Find(sounds, sound => sound.name == name);
        }
    }
}