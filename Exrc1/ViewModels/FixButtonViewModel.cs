using Caliburn.Micro;

namespace Exrc1.ViewModels
{
    public class FixButtonViewModel : PropertyChangedBase
    {
        private int _bugsCounter = 0;

        public int BugsCounter
        {
            get { return _bugsCounter; }
            set
            {
                _bugsCounter = value;
                NotifyOfPropertyChange(() => BugsCounter);
            }
        }

        public void IncreaseCounter()
        {

        }
    }
}
