namespace Rftim8Convoy.Services.Host.CP.CodeForces.Data
{
    public interface IRftCodeForcesHostData
    {
        public List<string>? Input_Test(bool testType = true, bool direction = true, string? problemName = null);

        public List<string>? Output_Test(bool testType = true, bool direction = false, string? problemName = null);
    }
}
