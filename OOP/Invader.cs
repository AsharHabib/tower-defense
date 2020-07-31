namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public MapLocation Location {
          get {
            return _path.GetLocationAt(_pathStep);
          }
        }
        public Invader(Path path) {
            _path = path;
        }
        public void Move() {
          _pathStep += 1;
        }
        public int Health {get{return Health;} private set {Health = 2;}}
        public bool HasScored {get {return _pathStep >= _path.Length;}}
        public bool IsNeutralized {
          get {
            return Health <= 0;
          }
        }
        public bool IsActive {
          get {
            return !(IsNeutralized || HasScored);
          }
        }
        public void DecreaseHealth(int factor) {
            Health -= factor;
        }
    }
}
