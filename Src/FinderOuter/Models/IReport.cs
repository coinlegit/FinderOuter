﻿// The FinderOuter
// Copyright (c) 2020 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

using System.Numerics;

namespace FinderOuter.Models
{
    public interface IReport
    {
        State CurrentState { get; set; }
        string Message { get; set; }
        bool IsProgressVisible { get; set; }
        double Progress { get; set; }

        void Init();
        bool Finalize(bool success);

        void AddMessage(string msg);
        void AddMessageSafe(string msg);

        bool Fail(string msg);
        bool Pass(string msg);

        void SetKeyPerSec(BigInteger totalKeys, double totalSecond);
        void SetKeyPerSecSafe(BigInteger totalKeys, double totalSecond);

        void SetProgressSafe(BigInteger total, BigInteger current);
    }
}
