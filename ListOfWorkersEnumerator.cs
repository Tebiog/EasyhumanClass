using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    class ListOfWorkersEnumerator:IEnumerator
    {
        private ListOfWorkers _listOfWorkers;               //наша "уникальная структура данных"
        private int _currPosition = -1;                     //за пределами колекции

        public ListOfWorkersEnumerator(ListOfWorkers listOfWorkers)
        {
            _listOfWorkers = listOfWorkers; 
        }
        public bool MoveNext()
        {
            if (_currPosition < _listOfWorkers.Count - 1)
            {
                _currPosition++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _currPosition = -1;
        }

        public object? Current
        {
            get
            {
                if (_currPosition == -1 || _currPosition >= _listOfWorkers.Count)
                {
                    throw  new InvalidOperationException();
                }
                else
                {
                    return _listOfWorkers.Workers[_currPosition];
                }
            }
        }
    }
}
