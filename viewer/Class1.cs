using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace viewer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
    public interface IObserver
    {
        void Update(Season season);
        void Update(SeasonType currentSeason);
    }
    public class Season : ISubject
    {
        private List<IObserver> observers;
        private SeasonType currentSeason;

        public Season()
        {
            observers = new List<IObserver>();
            currentSeason = SeasonType.Spring;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(currentSeason);
            }
        }

        public void SetSeason(SeasonType season)
        {
            currentSeason = season;
            NotifyObservers();
        }
    }

    public enum SeasonType
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public class SeasonObserver : IObserver
    {
        private PictureBox pictureBox;

        public SeasonObserver(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }
        public void Update(SeasonType season)
        {
            throw new NotImplementedException();
        }

        /*public void Update(SeasonType season)
        {
            switch (season)
            {
                case SeasonType.Spring:
                    MessageBox.Show("Зараз Весна");
                    break;
                case SeasonType.Summer:
                    
                    break;
                case SeasonType.Autumn:
                    
                    break;
                case SeasonType.Winter:
                    
                    break;
            }
        }*/
        public class TreeObserver : IObserver
        {
            private PictureBox pictureBox;

            public TreeObserver(PictureBox pictureBox)
            {
                this.pictureBox = pictureBox;
            }

            public void Update(SeasonType season)
            {
                switch (season)
                {
                    case SeasonType.Spring:
                        pictureBox.Image = Properties.Resources.spring;
                        break;
                    case SeasonType.Summer:
                        pictureBox.Image = Properties.Resources.Summer;
                        break;
                    case SeasonType.Autumn:
                        pictureBox.Image = Properties.Resources.Auttem;
                        break;
                    case SeasonType.Winter:
                        pictureBox.Image = Properties.Resources.Winter;
                        break;
                }
            }

            public void Update(Season season)
            {
                throw new NotImplementedException();
            }
        }

        public void Update(Season season)
        {
            throw new NotImplementedException();
        }
    }


}
