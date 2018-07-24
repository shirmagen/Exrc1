using Caliburn.Micro;

namespace Exrc1.ViewModels
{
    public class FixButtonViewModel : PropertyChangedBase
    {
        private int _bugsCounter;

        public int BugsCounter
        {
            get
            {
                return _bugsCounter;
            }
            set
            {
                _bugsCounter = value;
                NotifyOfPropertyChange(() => BugsCounter);
                NotifyOfPropertyChange(() => CanIncreaseBugs);
            }
        }

        public bool CanIncreaseBugs
        {
            get { return BugsCounter < 30; }
        }

        public FixButtonViewModel()
        {
            BugsCounter = 0;
        }

        public void IncreaseBugs()
        {
            BugsCounter++;
        }
    }
}