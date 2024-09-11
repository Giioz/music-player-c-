using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace ConsolApp1 
{
    class MusicPlayer
    {
        private List<Song> _songs = new List<Song>();
        private int _currentSongIndex;
        private bool _isPlaying;
        private bool _shuffle;
        private int _volume;

        public Song CurrentSong 
        {
            get 
            {
                return _songs[_currentSongIndex];
            }
        }

        public bool IsPlaying
        {
            get { return _isPlaying; }
        }

        public bool Shuffle 
        {
            get { return _shuffle; }
            set { _shuffle = value; }
        }

        public int Volume 
        {
            get { return _volume; }
            set 
            {
                if(_volume <= 0)
                    _volume = 0;
                else if(_volume >= 100)
                    _volume = 100;
            }
        }

        public void ShowSongs()
        {
            Console.Clear();
            foreach (Song item in _songs)
            {
                System.Console.WriteLine($"Music : {item.Title}\nArtist : {item.Artist}\nSong ID : {item.Id}\n-----------------");
            }
        }

        private void ValidateVolume(int value)
        {
            if (value >= 0 && value <= 100)
            {
                _volume = value;
            }
        }
        public void AddSong(Song song)
        {
        
            _songs.Add(song);
        }
        public void RemoveSong(Song song)
        {
            _songs.Remove(song);
        }
        public void Play()
        {
            Console.Clear();
            if (_songs.Count == 0)
            {
                Console.WriteLine("No songs to play.");
                return;
            }

            _isPlaying = true;
            Console.WriteLine($"Playing: {CurrentSong.Title} / {CurrentSong.Artist}");
        }
        public void Pause()
        {
            Console.Clear();
            if (_isPlaying)
            {
                _isPlaying = false;
                Console.WriteLine("Music paused.");
            }
        }
        public void Stop()
        {
            Console.Clear();
            _isPlaying = false;
            Console.WriteLine("Music stopped.");
        }
        public void NextSong()
        {
            Console.Clear();
            if(_currentSongIndex == _songs.Count-1) {
                _currentSongIndex = 0;
                
            } else {
                _currentSongIndex = _currentSongIndex+1;
            }
            Play();
        }

        public void PreviousSong() 
        {
            Console.Clear();
            if(_currentSongIndex == 0) {
                _currentSongIndex = _songs.Count-1;
            }else {
                _currentSongIndex = _currentSongIndex-1;
            }
            Play();
        }
    }

}