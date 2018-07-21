using System;

namespace ROR
{
    class active_wars
    {
        private int activeWars;
        public active_wars (int active_wars)
        {
            this.activeWars = active_wars;
        }
        public int get_active_wars()
        {
            return this.activeWars;
        }
        public void set_active_wars(int active_wars)
        {
            this.activeWars = active_wars;
        }
        public void inc_active_wars()
        {
            this.activeWars++;
        }
        public void dec_active_wars()
        {
            this.activeWars--;
        }
        public int pay_active_wars()
        {
            return this.activeWars*-20;
        }
    }
}