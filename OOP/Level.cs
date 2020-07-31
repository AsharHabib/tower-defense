namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers {get; set;}
        public Level(Invader[] invaders) {
            _invaders = invaders;
        }
        public bool Play() {
            //run until all invaders r neturalized or n invader reaches end of path
            int remainingInvaders = _invaders.Length;
            while (remainingInvaders > 0) {
                foreach(Tower tower in Towers) {
                    tower.FireOnInvaders(_invaders);
                }
                remainingInvaders = 0;
                foreach(Invader invader in _invaders) {
                    if(invader.IsActive) {
                        invader.Move();
                        if(invader.HasScored) {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}
