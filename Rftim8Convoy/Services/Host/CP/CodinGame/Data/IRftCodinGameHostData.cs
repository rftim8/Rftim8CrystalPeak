﻿namespace Rftim8Convoy.Services.Host.CP.CodinGame.Data
{
    public interface IRftCodinGameHostData
    {
        public List<string>? Input_Test(bool testType = true, bool direction = true, string? problemName = null);

        public List<string>? Output_Test(bool testType = true, bool direction = false, string? problemName = null);
    }
}
