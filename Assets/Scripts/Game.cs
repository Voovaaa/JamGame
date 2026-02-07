using UnityEngine;

namespace JamGame
{
   
    public class Game : MonoBehaviour
    {
        public bool playing = false;

        public void Initialize()
        {
            this.playing = true;
        }

        public void Pause()
        {
            this.playing = false;
        }

        public void Resume()
        {
            this.playing = true;
        }

        public void Win()
        {
            this.playing = false;
        }
    }
 
}