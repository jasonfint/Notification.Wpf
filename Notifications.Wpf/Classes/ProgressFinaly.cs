﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notification.Wpf.Classes
{
    public class ProgressFinaly<T> : Progress<T>,IDisposable, IProgress<T>
    {
        #region IsFinished : bool - progress was finished

        /// <summary>progress was finished</summary>
        public bool IsFinished => _IsFinished;

        /// <summary>progress was finished</summary>
        private bool _IsFinished { get; set; }

        #endregion

        public ProgressFinaly(Action<T> handler) : base(handler) { }


        public void Dispose() { _IsFinished = true; }

    }
}
