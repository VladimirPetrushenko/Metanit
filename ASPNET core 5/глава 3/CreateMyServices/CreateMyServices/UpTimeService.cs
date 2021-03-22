using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateMyServices
{
    public interface IUpTimeService
    {
        string UpTimeSpan { get; }
    }
    public class UpTimeServiceSecond : IUpTimeService
    {
        DateTime timeSrart;
        public UpTimeServiceSecond()
        {
            timeSrart = DateTime.Now;
        }
        public string UpTimeSpan { get => $"{(int)(DateTime.Now - timeSrart).TotalSeconds} s."; }
    }

    public class UpTimeServiceMinutes : IUpTimeService
    {
        DateTime timeSrart;
        public UpTimeServiceMinutes()
        {
            timeSrart = DateTime.Now;
        }
        public string UpTimeSpan { get => $"{(DateTime.Now - timeSrart).TotalMinutes} m."; }
    }
}
