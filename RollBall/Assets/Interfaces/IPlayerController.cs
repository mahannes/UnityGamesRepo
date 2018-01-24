using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Assets.Interfaces
{
    public interface IPlayerController : INotifyPropertyChanged
    {
        int Count { get; }
    }
}
