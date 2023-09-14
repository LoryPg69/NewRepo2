namespace DirittiUmaniUnioneEuropea
{
    public interface IEUCountry
    {
        void ConstitutionIntegration();
        bool Equals(object obj);
        int GetHashCode();
        void HumanRights();
        void Permesso(EuroZoneCountry euroZoneCountry);
        void PopulationControl();
        void TerritoryControl();
        string ToString();
    }
}