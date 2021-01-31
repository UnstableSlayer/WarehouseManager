using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        Organization GetByCode(string codeToFind);
        Organization GetByAuthenticationCode(string authenticationCodeToFind);
        Organization GetByName(string nameToFind);
        Organization GetByEN_Name(string enNameToFind);
        Organization GetByCity(string cityToFind);
        Organization GetByDistrict(string districtToFind);
        Organization GetByPostalCode(string postalCodeToFind);
        Organization GetByAddress(string addressToFind);
        Organization GetByLongitudeAndLatitude(double longitudeToFind, double latitudeToFind);
        Organization GetByPhoneNumber(string phoneNumberToFind);
        Organization GetByEmail(string emailToFind);
        Organization GetByWebsiteURL(string websiteURLToFind);
        Organization GetByOrgType(OrganizationType orgTypeToFind);
    }
}
