using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExApp
{
    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
